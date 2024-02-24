Imports System.Data.Common
Imports System.Data.OleDb

Public Class frmInsertSaleItems

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim currentBill As New List(Of BillItem)()
    Dim stock As Integer
    Dim totalAmount As Integer
    Dim totalquantity As Integer

    Public Sub New()

        InitializeComponent()

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        adp = New OleDbDataAdapter("SELECT [Name] From Products", conn)
        adp.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            cmbProducts.Items.Add(row("Name").ToString())
        Next

    End Sub

    Function getProductId(name As String)

        Dim pid As Integer
        cmd = New OleDbCommand("SELECT Id,Stock FROM Products WHERE [Name] = '" & name & "'", conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            stock = Val(reader("Stock").ToString())
            pid = Val(reader("Id").ToString())
        End If
        Return pid

    End Function

    Private Sub UpdateUI()

        DataGridView1.Rows.Clear()
        For Each item As BillItem In currentBill

            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells("Product_Name").Value = item.ProductName
            DataGridView1.Rows(rowIndex).Cells("Quantity").Value = item.Quantity
            DataGridView1.Rows(rowIndex).Cells("Price").Value = item.Price
            DataGridView1.Rows(rowIndex).Cells("Total_Amount").Value = item.Total

        Next

    End Sub

    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged

        Dim pname As String = cmbProducts.SelectedItem().ToString()
        conn.Open()
        cmd = New OleDbCommand("SELECT Stock,Price FROM Products WHERE [Name] = '" & pname & "'", conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            lblQuantity.Text = reader("Stock").ToString()
            lblPrice.Text = reader("Price").ToString()
        End If
        conn.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbProducts.SelectedIndex.Equals(-1) Then
            MessageBox.Show("Please Select Product.")
            Return
        End If
        Dim pname As String = cmbProducts.SelectedItem.ToString()

        Dim quantity As Integer = Val(txtQuantity.Text())
        Dim price As Decimal = Val(lblPrice.Text())


        If quantity <= 0 Then

            MessageBox.Show("Quantity should be greater than zero.")
            Return

        ElseIf quantity > Val(lblQuantity.Text) Then

            MessageBox.Show("Quantity should be less than availble Stock.")
            Return

        End If
        Dim newItem As New BillItem()
        newItem.ProductName = pname
        newItem.Quantity = quantity
        newItem.Price = price
        newItem.Total = price * quantity

        currentBill.Add(newItem)
        UpdateUI()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If DataGridView1.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedCells(0).RowIndex
            DataGridView1.Rows.RemoveAt(rowIndex)
            currentBill.RemoveAt(rowIndex)
            UpdateUI()
        Else
            MessageBox.Show("Please select a row to remove.")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        For Each item As BillItem In currentBill

            totalAmount += item.Total
            totalquantity = totalquantity + item.Quantity

        Next
        If totalAmount = 0 Then
            Return
        End If
        Dim print As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
        print.Document = printDocument
        print.ShowDialog()


        Try
            conn.Open()
            cmd = New OleDbCommand("INSERT INTO Sales([Date],Amount) VALUES(@date,@amount)", conn)
            cmd.Parameters.AddWithValue("@date", DateTime.Today)
            cmd.Parameters.AddWithValue("@amount", totalAmount)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@Identity "
            Dim sid As Integer = Val(cmd.ExecuteScalar())
            For Each item As BillItem In currentBill
                Dim pid As Integer = getProductId(item.ProductName)
                Dim query As String = "INSERT INTO SaleItems(sid,pid,Quantity,Price) VALUES(" & sid & ", " & pid & ", " & item.Quantity & ", " & item.Total & ")"
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                stock -= item.Quantity
                cmd = New OleDbCommand("UPDATE Products SET Stock = " & stock & " WHERE Id = " & pid, conn)
                cmd.ExecuteNonQuery()
            Next
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show("Error :- " & ex.Message)
        End Try
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

        DataGridView1.ClearSelection()

        Dim printArea As New Rectangle(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100)
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim cellFont As New Font("Arial", 9)
        Dim cellPadding As Integer = 5
        Dim x As Integer = printArea.Left
        Dim y As Integer = printArea.Top
        For Each column As DataGridViewColumn In DataGridView1.Columns
            e.Graphics.DrawString(column.HeaderText, headerFont, Brushes.Black, x, y)
            x += column.Width
        Next
        y += headerFont.Height + cellPadding

        For Each row As DataGridViewRow In DataGridView1.Rows
            x = printArea.Left
            For Each cell As DataGridViewCell In row.Cells
                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                e.Graphics.DrawString(cellValue, cellFont, Brushes.Black, x, y)
                x += DataGridView1.Columns(cell.ColumnIndex).Width
            Next
            y += cellFont.Height + cellPadding
        Next
        x = printArea.Left
        For Each column As DataGridViewColumn In DataGridView1.Columns
            If column.Name = "Product_Name" Then
                e.Graphics.DrawString("Total", headerFont, Brushes.Black, x, y)
                x += column.Width
            ElseIf column.Name = "Quantity" Then
                e.Graphics.DrawString(totalquantity.ToString(), cellFont, Brushes.Black, x, y)
                x += column.Width * 2
                e.Graphics.DrawString(totalAmount.ToString("C"), cellFont, Brushes.Black, x, y)
            Else
                x += column.Width
            End If
        Next

        e.Graphics.DrawString("Bill Summary", headerFont, Brushes.Black, New PointF(50, 20))
        Dim footerFont As New Font("Arial", 8)
        Dim footerText As String = $"Printed on: {DateTime.Now}"
        e.Graphics.DrawString(footerText, footerFont, Brushes.Gray, New PointF(50, e.PageBounds.Bottom - 40))

    End Sub

End Class

Public Class BillItem

    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Property Total As Decimal

End Class
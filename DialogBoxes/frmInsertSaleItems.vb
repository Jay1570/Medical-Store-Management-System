Imports System.Data.Common
Imports System.Data.OleDb

Public Class frmInsertSaleItems

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim currentBill As New List(Of BillItem)()
    Dim stock As Integer

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
        pid = Val(cmd.ExecuteScalar().ToString())
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
        Dim reader As OleDbDataReader = cmd.ExecuteReader
        If reader.Read() Then
            stock = Val(reader("Stock").ToString())
            lblQuantity.Text = stock.ToString()
            lblPrice.Text = reader("Price").ToString()
        End If
        conn.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

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

        Dim print As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()
        Dim totalAmount As Integer
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
        print.Document = printDocument
        print.ShowDialog()
        For Each item As BillItem In currentBill

            totalAmount += item.Total

        Next
        If totalAmount = 0 Then
            Return
        End If
        'Try
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
        'Catch ex As Exception
        ' MessageBox.Show("Error :- " & ex.Message)
        ' Finally
        'conn.Close()
        'End Try
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)

        DataGridView1.ClearSelection()
        Dim bm As New Bitmap(DataGridView1.Width, DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, DataGridView1.Width, DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

End Class

Public Class BillItem

    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
    Public Property Total As Decimal

End Class
Imports System.Data.OleDb

Public Class frmInsert

    Dim query As String

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim lstProduct As New ComboBox
    Dim lstSupplier As New ComboBox
    Dim txtQuantity As New TextBox()
    Dim txtAmount As New TextBox()
    Dim pid As Integer
    Dim stock As Integer

    Public Sub New()

        InitializeComponent()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown

        lstProduct.Name = "cmbProduct"
        adp = New OleDbDataAdapter("SELECT [Name] From Products", conn)
        adp.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            lstProduct.Items.Add(row("Name").ToString())
        Next

        Dim pname As New FlowLayoutPanel
        pname.AutoSize = True
        pname.FlowDirection = FlowDirection.LeftToRight

        Dim labelName As New Label()
        labelName.Text = "Product Name"
        labelName.Size = New Size(150, 30)
        lstProduct.Size = New Size(150, 30)

        pname.Controls.Add(labelName)
        pname.Controls.Add(lstProduct)
        FlowLayoutPanel1.Controls.Add(pname)

        ds.Clear()
        lstSupplier.Name = "cmbSupplier"
        adp = New OleDbDataAdapter("SELECT [Name] From Supplier", conn)
        adp.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            lstSupplier.Items.Add(row("Name").ToString())
        Next

        Dim sname As New FlowLayoutPanel
        sname.AutoSize = True
        sname.FlowDirection = FlowDirection.LeftToRight

        Dim labelSName As New Label()
        labelSName.Text = "Supplier Name"
        labelSName.Size = New Size(150, 30)
        lstSupplier.Size = New Size(150, 30)

        sname.Controls.Add(labelSName)
        sname.Controls.Add(lstSupplier)
        FlowLayoutPanel1.Controls.Add(sname)

        Dim quantity As New FlowLayoutPanel
        quantity.AutoSize = True
        quantity.FlowDirection = FlowDirection.LeftToRight

        Dim labelQuantity As New Label()
        labelQuantity.Text = "Quantity"
        labelQuantity.Size = New Size(150, 30)

        txtQuantity.Name = "Quantity"
        txtQuantity.Enabled = True
        txtQuantity.Visible = True
        txtQuantity.Size = New Size(150, 30)

        quantity.Controls.Add(labelQuantity)
        quantity.Controls.Add(txtQuantity)
        FlowLayoutPanel1.Controls.Add(quantity)

        Dim amount As New FlowLayoutPanel
        amount.AutoSize = True
        amount.FlowDirection = FlowDirection.LeftToRight

        Dim labelAmount As New Label()
        labelAmount.Text = "Amount"
        labelAmount.Size = New Size(150, 30)

        txtAmount.Name = "Amount"
        txtAmount.Enabled = True
        txtAmount.Visible = True
        txtAmount.Size = New Size(150, 30)

        amount.Controls.Add(labelAmount)
        amount.Controls.Add(txtAmount)
        FlowLayoutPanel1.Controls.Add(amount)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click



        conn.Open()

        If lstProduct.SelectedItem Is Nothing OrElse lstSupplier.SelectedItem Is Nothing Then
            MessageBox.Show("Please select both a product and a supplier.")
            Return
        End If

        cmd = New OleDbCommand("SELECT Id, Stock FROM Products WHERE [Name] = @name", conn)
        Dim cmd1 As New OleDbCommand("SELECT Id FROM Supplier WHERE [Name] = @sname", conn)
        cmd.Parameters.Clear()
        cmd1.Parameters.Clear()
        cmd.Parameters.AddWithValue("@name", lstProduct.SelectedItem.ToString())
        cmd1.Parameters.AddWithValue("@sname", lstSupplier.SelectedItem.ToString())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If (reader.Read()) Then
            pid = Val(reader("Id").ToString())
            stock = Val(reader("Stock").ToString())
        End If
        Dim sid As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
            Dim day As DateTime = DateTime.Today
            query = "INSERT INTO PurchaseLog(pid,sid,[Date],Quantity,Amount) VALUES(@pid,@sid,@date,@quantity,@amount)"
            Dim insert As New OleDbCommand(query, conn)
            insert.Parameters.AddWithValue("@pid", pid)
            insert.Parameters.AddWithValue("@sid", sid)
            insert.Parameters.AddWithValue("@date", day)
            insert.Parameters.AddWithValue("@quantity", txtQuantity.Text)
            insert.Parameters.AddWithValue("@amount", txtAmount.Text)
            insert.ExecuteNonQuery()
            stock += Val(txtQuantity.Text)
            Dim update As New OleDbCommand("UPDATE Products SET Stock = @stock WHERE Id = @id", conn)
            update.Parameters.AddWithValue("@stock", stock)
            update.Parameters.AddWithValue("@id", pid)
            update.ExecuteNonQuery()
            conn.Close()
            Close()



    End Sub

End Class
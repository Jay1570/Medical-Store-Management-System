Imports System.Data.OleDb

Public Class frmInsertSaleItems

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter

    Public Sub New()

        InitializeComponent()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        adp = New OleDbDataAdapter("SELECT [Name] From Products", conn)
        adp.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            cmbProducts.Items.Add(row("Name").ToString())
        Next

    End Sub

    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged

        Dim pname As String = cmbProducts.SelectedItem().ToString()
        conn.Open()
        cmd = New OleDbCommand("SELECT Stock FROM Products WHERE [Name] = '" & pname & "'", conn)
        lblQuantity.Text = cmd.ExecuteScalar()
        conn.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click



    End Sub

End Class
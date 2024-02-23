Imports System.Data.OleDb

Public Class frmBills

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet
    Dim adp As New OleDbDataAdapter
    Dim fields As New List(Of String)
    Dim selectedFields As New List(Of String)
    Dim values As New List(Of String)

    Private Sub frmBills_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        showdata()
        fields.Add("Date")
        fields.Add("Amount")

    End Sub

    Sub showdata()

        ds.Clear()
        adp = New OleDbDataAdapter("SELECT Id AS [Sale Id],Date,Amount AS [Total Amount] FROM Sales", conn)
        adp.Fill(ds)
        dgvSales.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As New frmInsertSaleItems()
        If insert.ShowDialog() = DialogResult.OK Then

            showdata()

        End If

    End Sub

End Class
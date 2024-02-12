Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmEmployee

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim ds As New DataSet

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmOverView.Hide()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System\My Project\Medical Store Management System.accdb"
        conn.Open()
        showdata()

    End Sub

    Sub showdata()

        If ds.Tables.Count > 0 Then
            ds.Clear()
        End If
        Dim adp As New OleDbDataAdapter("SELECT * FROM Employee", conn)
        adp.Fill(ds, "Employee")
        dgvEmployee.DataSource = ds.Tables("Employee")

    End Sub

    Private Sub frmEmployee_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conn.Close()
    End Sub

End Class
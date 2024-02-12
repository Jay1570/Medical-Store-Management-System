Imports System.Configuration
Imports System.Data.OleDb
Imports System.Drawing.Imaging
Public Class frmLogin

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System1\My Project\Medical Store Management System.accdb"
        conn.Open

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim unm As String = txtUNM.Text
        Dim pass As String = txtPassword.Text
        Dim query As String = "SELECT Emp_Type,Emp_Name FROM [Employee] WHERE Emp_UserName=@user_nm AND Emp_password=@user_password"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@user_nm", unm)
        cmd.Parameters.AddWithValue("@user_password", pass)
        Try

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                Dim empName As String = reader("Emp_Name").ToString()
                Dim empType As String = reader("Emp_Type").ToString()
                Dim home As New frmHome(empName, empType)
                home.Show()
                Close()

            Else

                MessageBox.Show("Invalid username or password.", "Error!")
                'Dim home As New frmHome()
                'home.Show()
                'Close()

            End If

        Catch

            MessageBox.Show("Error")

        End Try

    End Sub

    Private Sub btnCLose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class
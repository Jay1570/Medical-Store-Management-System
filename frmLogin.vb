Imports System.Data.OleDb
Imports System.Drawing.Imaging
Public Class frmLogin
    Private connName As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Medical Store Management System1\Medical Store Management System.accdb;"
    Private conn As OleDbConnection
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim unm As String = txtUNM.Text
        Dim pass As String = txtPassword.Text
        Dim query As String = "SELECT Emp_Type,Emp_Name FROM [Employee] WHERE Emp_UserName=@user_nm AND Emp_password=@user_password"
        Using conn = New OleDbConnection(connName)
            Using command = New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@user_nm", unm)
                command.Parameters.AddWithValue("@user_password", pass)
                Try
                    conn.Open()

                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then

                        Dim empName As String = reader("Emp_Name").ToString()
                        Dim empType As String = reader("Emp_Type").ToString()
                        Dim home As New frmHome(empName, empType)
                        home.Show()
                        Close()

                    Else
                        MessageBox.Show("Invalid username or password.", "Error!")
                        Dim home As New frmHome()
                        home.Show()
                        Close()
                    End If
                Catch
                    MessageBox.Show("Error")
                End Try
            End Using
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class
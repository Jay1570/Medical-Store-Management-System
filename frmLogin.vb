Imports System.Data.OleDb
Public Class frmLogin

    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Public empName As String
    Public empType As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Medical Store Management System.accdb"

    End Sub



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim unm As String = txtUNM.Text
        Dim pass As String = txtPassword.Text
        If unm.Equals("") OrElse pass.Equals("") Then
            MsgBox("Please Enter Username Or Password", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")
            Return
        End If
        Try
            Dim query As String = "SELECT Designation,[Name] FROM Employee WHERE Username=@user_nm AND Password=@user_password"
            conn.Open()
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@user_nm", unm)
            cmd.Parameters.AddWithValue("@user_password", pass)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then

                empName = reader("Name").ToString()
                empType = reader("Designation").ToString()
                Dim home As New frmHome(empName, empType)
                DialogResult = DialogResult.OK
                conn.Close()
                home.Show()
                Close()

            Else

                MsgBox("Invalid username or password.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

            End If

        Catch ex As Exception

            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error!")

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub btnCLose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Activate()
        txtUNM.Focus()
    End Sub
End Class
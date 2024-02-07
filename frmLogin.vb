Public Class frmLogin
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub btnClose_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseClick
        Me.Close()
    End Sub

End Class
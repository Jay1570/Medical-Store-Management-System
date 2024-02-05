Public Class formHome
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Activate()
    End Sub

    Private Sub btnClose_MouseClick(sender As Object, e As MouseEventArgs) Handles btnClose.MouseClick
        Me.Close()
    End Sub

    Private Sub formHome_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        WindowState = FormWindowState.Maximized
    End Sub
End Class
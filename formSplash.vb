Public Class formSplash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBarLoad.Minimum = 0
        ProgressBarLoad.Maximum = 100
        timerLoad.Interval = 100
        timerLoad.Start()
    End Sub

    Private Sub timerLoad_Tick(sender As Object, e As EventArgs) Handles timerLoad.Tick
        ProgressBarLoad.Value += 5
        If ProgressBarLoad.Value >= ProgressBarLoad.Maximum Then
            timerLoad.Stop()
        End If
    End Sub


End Class

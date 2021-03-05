Public Class Splashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            MenuMain.Show()
            Timer1.Stop()

        End If
    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_sqlite_database()
    End Sub
End Class
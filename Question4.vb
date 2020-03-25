Public Class Question4
    Private Sub Question4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ4 = timer_test
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ4_Tick(sender As Object, e As EventArgs) Handles TimerQ4.Tick
        lbl_min.Text = minutes
        lbl_sec.Text = secondes

    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If DateTimePicker.Value = "10 / 03 / 2020" Then
            n_ari += 1
        End If
        Question5.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        If n_gram = 1 Then
            n_gram -= 1
        End If
        Question3.Show()
        Me.Hide()
    End Sub
End Class
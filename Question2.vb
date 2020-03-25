Public Class Question2
    Private Sub Question2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ2 = timer_test
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ2_Tick(sender As Object, e As EventArgs) Handles TimerQ2.Tick
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep.SelectedItem <> "" Then
            If rep.SelectedIndex = 1 Then
                n_ari += 1
            End If
            Question3.Show()
            Me.Hide()
        Else
            MsgBox("Aucune réponse n'a été selectionnée")
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        If n_voc = 1 Then
            n_voc -= 1
        End If
        Question1.Show()
        Me.Hide()
    End Sub

End Class
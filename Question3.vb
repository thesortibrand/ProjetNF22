Public Class Question3
    Private Sub Question3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ3 = timer_test
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ3_Tick(sender As Object, e As EventArgs) Handles TimerQ3.Tick
        lbl_min.Text = minutes
        lbl_sec.Text = secondes

    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep.SelectedItem = "" Then
            MsgBox("Aucune réponse n'a été selectionnée")
        Else
            If rep.SelectedIndex = 1 Then
                n_gram = n_gram + 1
            End If
            Question4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        If n_ari = 1 Then
            n_ari -= 1
        End If
        Question2.Show()
        Me.Hide()
    End Sub

End Class
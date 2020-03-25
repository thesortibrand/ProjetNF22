Public Class Question5
    Private Sub Question5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ5 = timer_test
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ5_Tick(sender As Object, e As EventArgs) Handles TimerQ5.Tick
        lbl_min.Text = minutes
        lbl_sec.Text = secondes

    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If TextBox.Text = "" Then
            MsgBox("Aucune réponse n'a été rentrée")
        Else
            If TextBox.Text = "chevaux" Or TextBox.Text = "Chevaux" Then
                n_voc = n_voc + 1
            End If
            Question6.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        If n_ari = 1 Or n_ari = 2 Then
            n_ari -= 1
        End If
        Question4.Show()
        Me.Hide()
    End Sub

End Class
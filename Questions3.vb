Public Class Questions3
    Private Sub Questions3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ3 = timer_test
        lbl_minQ3.Text = minutes
        lbl_secQ3.Text = secondes
    End Sub

    Private Sub TimerQ3_Tick(sender As Object, e As EventArgs) Handles TimerQ3.Tick
        lbl_minQ3.Text = minutes
        lbl_secQ3.Text = secondes
    End Sub

    Private Sub cmd_aideQ5_Click(sender As Object, e As EventArgs) Handles cmd_aideQ5.Click
        MsgBox("Cliques sur la flèche des boîtes de texte pour choisir une réponse.")
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If cb1.SelectedItem = "" Or cb2.SelectedItem = "" Or cb3.SelectedItem = "" Or cb4.SelectedItem = "" Or cb5.SelectedItem = "" Or cb6.SelectedItem = "" Or cb7.SelectedItem = "" Or cb8.SelectedItem = "" Or cb9.SelectedItem = "" Or cb10.SelectedItem = "" Or cb11.SelectedItem = "" Or cb12.SelectedItem = "" Or cb13.SelectedItem = "" Or cb14.SelectedItem = "" Then
            MsgBox("Complètes toutes le boîtes.")
        Else
            If cb1.SelectedIndex = 1 And cb2.SelectedIndex = 2 And cb3.SelectedIndex = 0 And cb4.SelectedIndex = 0 And cb5.SelectedIndex = 0 And cb6.SelectedIndex = 1 And cb7.SelectedIndex = 0 And cb8.SelectedIndex = 0 And cb9.SelectedIndex = 1 And cb10.SelectedIndex = 0 And cb11.SelectedIndex = 0 And cb12.SelectedIndex = 0 And cb13.SelectedIndex = 1 And cb14.SelectedIndex = 3 Then
                n_ponc += 1
            End If
            Questions4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        'If pour reinitialiser la réponse de la Question 4
        If n_gram = 1 Or n_gram = 2 Then
            n_gram -= 1
        End If
        Questions2.Show()
        Me.Hide()
    End Sub
End Class
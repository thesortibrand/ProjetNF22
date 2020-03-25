Public Class Question9
    Private Sub Question9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ9.Start()
        timer_test = TimerQ9
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ9_Tick(sender As Object, e As EventArgs) Handles TimerQ9.Tick
        If minutes <> 0 Then
            If secondes = 0 Then
                minutes -= 1
                secondes = 60
                lbl_min.Text = minutes
            End If
            secondes -= 1
            lbl_sec.Text = secondes
        End If
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If cb1.SelectedItem = "" Or cb2.SelectedItem = "" Or cb3.SelectedItem = "" Or cb4.SelectedItem = "" Or cb5.SelectedItem = "" Or cb6.SelectedItem = "" Or cb7.SelectedItem = "" Or cb8.SelectedItem = "" Or cb9.SelectedItem = "" Or cb10.SelectedItem = "" Or cb11.SelectedItem = "" Or cb12.SelectedItem = "" Or cb13.SelectedItem = "" Or cb14.SelectedItem = "" Then
            MsgBox("Complètes toutes le boîtes.")
        Else
            If cb1.SelectedIndex = 1 And cb2.SelectedIndex = 2 And cb3.SelectedIndex = 0 And cb4.SelectedIndex = 0 And cb5.SelectedIndex = 0 And cb6.SelectedIndex = 1 And cb7.SelectedIndex = 0 And cb8.SelectedIndex = 0 And cb9.SelectedIndex = 1 And cb10.SelectedIndex = 0 And cb11.SelectedIndex = 0 And cb12.SelectedIndex = 0 And cb13.SelectedIndex = 1 And cb14.SelectedIndex = 3 Then
                n_ponc += 1
            End If
            Question10.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        If n_ari = 1 Or n_ari = 2 Then
            n_ari -= 1
        End If
        Question8.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Aide_Click(sender As Object, e As EventArgs) Handles cmd_Aide.Click
        MsgBox("INSTRUCTION: Click sur les boîtes pour choisir une réponse.")
    End Sub
End Class
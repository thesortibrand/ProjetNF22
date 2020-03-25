Public Class Question8
    Dim i As Integer
    Private Sub Question8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ8.Start()
        timer_test = TimerQ8
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ8_Tick(sender As Object, e As EventArgs) Handles TimerQ8.Tick
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

    Private Sub rb_option1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option1.CheckedChanged
        i = 1
    End Sub

    Private Sub rb_option2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option2.CheckedChanged
        i = 2
    End Sub

    Private Sub rb_option3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option3.CheckedChanged
        i = 3
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If rb_option1.Checked = False And rb_option2.Checked = False And rb_option3.Checked = False Then
            MsgBox("Aucune réponse n'a été selectionnée")
        Else
            If i = 3 Then
                n_ari += 1
            End If
            Resultat.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        If n_gram = 1 Or n_gram = 2 Then
            n_gram -= 1
        End If
        Question7.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Aide_Click(sender As Object, e As EventArgs) Handles cmd_Aide.Click
        MsgBox("INSTRUCTION: Click sur un image pour choisir la bonne réponse.")
    End Sub
End Class
Public Class Questions1
    Dim i As Integer
    Private Sub Questions1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ1.Start()
        timer_test = TimerQ1
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ1_Tick(sender As Object, e As EventArgs) Handles TimerQ1.Tick
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

    'Code pour la Question 1
    Private Sub rb_option1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option1.CheckedChanged
        i = 1
    End Sub

    Private Sub rb_option2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option2.CheckedChanged
        i = 2
    End Sub

    Private Sub rb_option3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option3.CheckedChanged
        i = 3
    End Sub

    Private Sub rb_option4_CheckedChanged(sender As Object, e As EventArgs) Handles rb_option4.CheckedChanged
        i = 4
    End Sub

    'Code des boutons: Instruction 
    Private Sub cmd_aideQ1_Click(sender As Object, e As EventArgs) Handles cmd_aideQ1.Click
        MsgBox("Cliques sur le rond correspondant à la réponse de ton choix")
    End Sub

    Private Sub cmd_aideQ2_Click(sender As Object, e As EventArgs) Handles cmd_aideQ2.Click
        MsgBox("Cliques sur la flèche et selectionne la réponse de ton choix")
    End Sub

    Private Sub cmd_aideQ3_Click(sender As Object, e As EventArgs) Handles cmd_aideQ3.Click
        MsgBox("Cliques sur la zone de texte et écris ta réponse avec ton clavier")
    End Sub

    'Code du bouton pour passer à la prochaine Page de Questions
    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        'If pour verifier que une réponse existe dans Question 1
        If rb_option1.Checked = False And rb_option2.Checked = False And rb_option3.Checked = False And rb_option4.Checked = False Then
            MsgBox("Aucune réponse de la Question 1 n'a été selectionnée")
        Else
            'If pour verifier que une réponse existe dans Question 2
            If cb_Q2.SelectedItem = "" Then
                MsgBox("Aucune réponse de la Question 2 n'a été selectionnée")
            Else
                'if pour verifier que une réponse existe dans Question 3
                If txtbox_Q3.Text = "" Then
                    MsgBox("Aucune réponse de la Question 3 n'a été rentrée")
                Else
                    'If pour garder la réponse de Question 1
                    If i = 2 Then
                        n_voc += 1
                    End If

                    'If pour garder la réponse de Question 2
                    If cb_Q2.SelectedIndex = 1 Then
                        n_gram = n_gram + 1
                    End If

                    'If pour garder la réponse de Question 3
                    If txtbox_Q3.Text = "chevaux" Or txtbox_Q3.Text = "Chevaux" Then
                        n_voc = n_voc + 1
                    End If

                    Questions2.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub
End Class
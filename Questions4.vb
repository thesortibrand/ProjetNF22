Public Class Questions4
    Dim i As Integer

    Private Sub Questions4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ4 = timer_test
        lbl_minQ4.Text = minutes
        lbl_secQ4.Text = secondes
    End Sub

    Private Sub TimerQ4_Tick(sender As Object, e As EventArgs) Handles TimerQ4.Tick
        If minutes <> 0 Then
            If secondes = 0 Then
                minutes -= 1
                secondes = 60
                lbl_minQ4.Text = minutes
            End If
            secondes -= 1
            lbl_secQ4.Text = secondes
        End If
    End Sub

    'Code pour la Question 8
    Private Sub rbQ8_option1_CheckedChanged(sender As Object, e As EventArgs) Handles rbQ8_option1.CheckedChanged
        i = 1
    End Sub

    Private Sub rbQ8_option2_CheckedChanged(sender As Object, e As EventArgs) Handles rbQ8_option2.CheckedChanged
        i = 2
    End Sub

    Private Sub rbQ8_option3_CheckedChanged(sender As Object, e As EventArgs) Handles rbQ8_option3.CheckedChanged
        i = 3
    End Sub

    'Code pour la Question 9
    Private Sub lbl_chiffres_Click(sender As Object, e As EventArgs) Handles lbl_30000.Click, lbl_30.Click, lbl_7.Click, lbl_7000.Click, lbl_700.Click, lbl_9.Click
        If sender.BorderStyle = BorderStyle.None Then
            sender.BorderStyle = BorderStyle.FixedSingle
        Else
            sender.BorderStyle = BorderStyle.None
        End If
    End Sub

    'Code des boutons: Instruction 
    Private Sub cmd_aideQ6_Click(sender As Object, e As EventArgs) Handles cmd_aideQ6.Click
        MsgBox("Clique sur un des nombres de ton choix en faisant défiler la bar")
    End Sub

    Private Sub cmd_aideQ7_Click(sender As Object, e As EventArgs) Handles cmd_aideQ7.Click
        MsgBox("Clique sur la flèche à côté de la date et selectionne la date de ton choix sur le calendrier qui s'affiche")
    End Sub

    Private Sub cmd_aideQ8_Click(sender As Object, e As EventArgs) Handles cmd_aideQ8.Click
        MsgBox("Clique sur un image pour choisir la bonne réponse")
    End Sub

    Private Sub cmd_aideQ9_Click(sender As Object, e As EventArgs) Handles cmd_aideQ9.Click
        MsgBox("Clique sur les chiffres pour choisir la bonne composition")
    End Sub

    Private Sub cmd_Next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        'If pour verifier que une réponse existe dans Question 6
        If lb_Q6.SelectedItem = "" Then
            MsgBox("Aucune réponse de la Question 6 n'a été selectionnée")
        Else
            'If pour verifier que une réponse existe dans Question 8
            If rbQ8_option1.Checked = False And rbQ8_option2.Checked = False And rbQ8_option3.Checked = False Then
                MsgBox("Aucune réponse de la Question 8 n'a été selectionnée")
            Else
                'If pour verifier que une réponse existe dans Question 9
                If lbl_30000.BorderStyle = BorderStyle.None And lbl_30.BorderStyle = BorderStyle.None And lbl_7.BorderStyle = BorderStyle.None And lbl_700.BorderStyle = BorderStyle.None And lbl_7000.BorderStyle = BorderStyle.None And lbl_9.BorderStyle = BorderStyle.None Then
                    MsgBox("Aucune chiffre de la Question 9 n'a été selectionnée")
                Else
                    'If pour garder la réponse de Question 6
                    If lb_Q6.SelectedIndex = 1 Then
                        n_ari += 1
                    End If

                    'If pour garder la réponse de Question 7
                    If DateTimePickerQ7.Value = "10 / 03 / 2020" Then
                        n_ari += 1
                    End If

                    'If pour garder la réponse de Question 8
                    If i = 3 Then
                        n_ari += 1
                    End If

                    'If pour garder la réponse de Question 9
                    If lbl_30000.BorderStyle = BorderStyle.FixedSingle And lbl_700.BorderStyle = BorderStyle.FixedSingle And
                        lbl_30.BorderStyle = BorderStyle.FixedSingle And lbl_9.BorderStyle = BorderStyle.FixedSingle Then
                        n_ari += 1
                    End If

                    Questions5.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        'Ifs pour reinitialiser les réponses de Question 5
        If n_ponc = 1 Then
            n_ponc -= 1
        End If

        Questions3.Show()
        Me.Hide()
    End Sub

End Class
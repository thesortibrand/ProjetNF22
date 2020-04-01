Public Class Question10
    Private Sub Question10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ10.Start()
        timer_test = TimerQ10
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ8_Tick(sender As Object, e As EventArgs) Handles TimerQ10.Tick
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub lbl_chiffres_Click(sender As Object, e As EventArgs) Handles lbl_30000.Click, lbl_30.Click, lbl_7.Click, lbl_7000.Click, lbl_700.Click, lbl_9.Click
        If sender.BorderStyle = BorderStyle.None Then
            sender.BorderStyle = BorderStyle.FixedSingle
        Else
            sender.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If lbl_30000.BorderStyle = BorderStyle.None And lbl_30.BorderStyle = BorderStyle.None And lbl_7.BorderStyle = BorderStyle.None And lbl_700.BorderStyle = BorderStyle.None And lbl_7000.BorderStyle = BorderStyle.None And lbl_9.BorderStyle = BorderStyle.None Then
            MsgBox("Aucune chiffre n'a été selectionnée")
        Else
            If lbl_30000.BorderStyle = BorderStyle.FixedSingle And lbl_700.BorderStyle = BorderStyle.FixedSingle And
            lbl_30.BorderStyle = BorderStyle.FixedSingle And lbl_9.BorderStyle = BorderStyle.FixedSingle Then
                n_ari += 1
            End If
            Resultat.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        If n_ponc = 1 Then
            n_ponc -= 1
        End If
        Questions3.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Aide_Click(sender As Object, e As EventArgs) Handles cmd_Aide.Click
        MsgBox("INSTRUCTION: Clique sur les chiffres pour choisir la bonne composition.")
    End Sub
End Class
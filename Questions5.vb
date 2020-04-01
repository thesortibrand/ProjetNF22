Public Class Questions5
    Dim coordonnees As Point
    Dim x1, x2, y1, y2 As Double

    Private Sub Questions5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ5 = timer_test
        lbl_minQ10.Text = minutes
        lbl_secQ10.Text = secondes

        x1 = pb_horloge1.Left
        y1 = pb_horloge1.Top
        x2 = pb_horloge2.Left
        y2 = pb_horloge2.Top
    End Sub

    Private Sub TimerQ5_Tick(sender As Object, e As EventArgs) Handles TimerQ5.Tick
        lbl_minQ10.Text = minutes
        lbl_secQ10.Text = secondes
    End Sub

    Private Sub PictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles pb_horloge1.MouseDown, pb_horloge2.MouseDown
        coordonnees.X = MousePosition.X - sender.left
        coordonnees.Y = MousePosition.Y - sender.top
    End Sub

    Private Sub PictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles pb_horloge1.MouseMove, pb_horloge2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.top = MousePosition.Y - coordonnees.Y
            sender.left = MousePosition.X - coordonnees.X
            sender.BorderStyle = BorderStyle.FixedSingle
            Panel_reponse.SendToBack()
            lbl_heure.SendToBack()

            If sender.Location.Y >= Panel_reponse.Location.Y And sender.Location.Y <= Panel_reponse.Location.Y + Panel_reponse.Height() Or
               sender.Location.Y + sender.Height() >= Panel_reponse.Location.Y And sender.Location.Y + sender.Height() <= Panel_reponse.Location.Y + Panel_reponse.Height() And
               sender.Location.X >= Panel_reponse.Location.X And sender.Location.X <= Panel_reponse.Location.X + Panel_reponse.Width() Then

                Panel_reponse.BackgroundImage = sender.Image

            Else

                Panel_reponse.BackgroundImage = Nothing
                Panel_reponse.BackColor = Color.White

            End If
        End If
    End Sub

    Private Sub PictureBox_MouseUp(sender As Object, e As MouseEventArgs) Handles pb_horloge1.MouseUp, pb_horloge2.MouseUp
        pb_horloge1.Left = x1
        pb_horloge1.Top = y1
        pb_horloge2.Left = x2
        pb_horloge2.Top = y2
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private Sub cmd_aideQ10_Click(sender As Object, e As EventArgs) Handles cmd_aideQ10.Click
        MsgBox("Appuies et maintiens le click sur l'image que tu considères comme la bonne réponse, puis faites-la glisser vers la boîte vide pour la remplir")
    End Sub

    Private Sub cmd_Next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If Panel_reponse.BackgroundImage Is Nothing Then
            MsgBox("Aucune réponse de la Question 10 n'a été rentrée")
        Else
            If Panel_reponse.BackgroundImage Is pb_horloge2.Image Then
                n_lec += 1
            End If

            If minutes = 0 Then
                MsgBox("Le temps de réalisation est terminé")
                timer_test.Stop()
            End If

            Resultat.Show()
            Me.Hide()
            End If
    End Sub

    Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        'Ifs pour reinitialiser les réponses des Question 6-9
        If n_ari = 1 Then
            n_ari -= 1
        End If

        If n_ari = 2 Then
            n_ari -= 2
        End If

        If n_ari = 1 Then
            n_ari -= 3
        End If

        If n_ari = 1 Then
            n_ari -= 4
        End If

        Questions4.Show()
        Me.Hide()
    End Sub

End Class
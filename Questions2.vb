Public Class Questions2
    Dim coordonnees As Point
    Dim x1, x2, y1, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7 As Double

    Private Sub Questions2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ2 = timer_test
        lbl_minQ2.Text = minutes
        lbl_secQ2.Text = secondes

        x1 = lbl_mot1.Left
        y1 = lbl_mot1.Top

        x2 = lbl_mot2.Left
        y2 = lbl_mot2.Top

        x3 = lbl_mot3.Left
        y3 = lbl_mot3.Top

        x4 = lbl_mot4.Left
        y4 = lbl_mot4.Top

        x5 = lbl_mot5.Left
        y5 = lbl_mot5.Top

        x6 = lbl_mot6.Left
        y6 = lbl_mot6.Top

        x7 = lbl_mot7.Left
        y7 = lbl_mot7.Top


    End Sub

    Private Sub TimerQ2_Tick(sender As Object, e As EventArgs) Handles TimerQ2.Tick
        lbl_minQ2.Text = minutes
        lbl_secQ2.Text = secondes
    End Sub

    Private Sub lbl_mot_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_mot1.MouseDown, lbl_mot2.MouseDown, lbl_mot3.MouseDown, lbl_mot4.MouseDown, lbl_mot5.MouseDown, lbl_mot6.MouseDown, lbl_mot7.MouseDown
        coordonnees.X = MousePosition.X - sender.left
        coordonnees.Y = MousePosition.Y - sender.top
    End Sub

    Private Sub lbl_mot_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_mot1.MouseMove, lbl_mot2.MouseMove, lbl_mot3.MouseMove, lbl_mot4.MouseMove, lbl_mot5.MouseMove, lbl_mot6.MouseMove, lbl_mot7.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.Top = MousePosition.Y - coordonnees.Y
            sender.Left = MousePosition.X - coordonnees.X

            txtbox_mot1.SendToBack()
            txtbox_mot2.SendToBack()
            txtbox_mot3.SendToBack()
            txtbox_mot4.SendToBack()
            txtbox_mot5.SendToBack()
            txtbox_mot6.SendToBack()
            txtbox_mot7.SendToBack()

            If sender.Location.Y + sender.Height() >= txtbox_mot1.Location.Y And sender.Location.Y <= txtbox_mot1.Location.Y + txtbox_mot1.Height() And
               sender.Location.X >= txtbox_mot1.Location.X And sender.Location.X <= txtbox_mot1.Location.X + txtbox_mot1.Width() Then
                txtbox_mot1.Text = sender.Text
            Else
                If sender.Location.Y + sender.Height() >= txtbox_mot2.Location.Y And sender.Location.Y <= txtbox_mot2.Location.Y + txtbox_mot2.Height() And
                    sender.Location.X >= txtbox_mot2.Location.X And sender.Location.X <= txtbox_mot2.Location.X + txtbox_mot2.Width() Then
                    txtbox_mot2.Text = sender.Text
                Else
                    If sender.Location.Y + sender.Height() >= txtbox_mot3.Location.Y And sender.Location.Y <= txtbox_mot3.Location.Y + txtbox_mot3.Height() And
                        sender.Location.X >= txtbox_mot3.Location.X And sender.Location.X <= txtbox_mot3.Location.X + txtbox_mot3.Width() Then
                        txtbox_mot3.Text = sender.Text
                    Else
                        If sender.Location.Y + sender.Height() >= txtbox_mot4.Location.Y And sender.Location.Y <= txtbox_mot4.Location.Y + txtbox_mot4.Height() And
                            sender.Location.X >= txtbox_mot4.Location.X And sender.Location.X <= txtbox_mot4.Location.X + txtbox_mot4.Width() Then
                            txtbox_mot4.Text = sender.Text
                        Else
                            If sender.Location.Y + sender.Height() >= txtbox_mot5.Location.Y And sender.Location.Y <= txtbox_mot5.Location.Y + txtbox_mot5.Height() And
                                sender.Location.X >= txtbox_mot5.Location.X And sender.Location.X <= txtbox_mot5.Location.X + txtbox_mot5.Width() Then
                                txtbox_mot5.Text = sender.Text
                            Else
                                If sender.Location.Y + sender.Height() >= txtbox_mot6.Location.Y And sender.Location.Y <= txtbox_mot6.Location.Y + txtbox_mot6.Height() And
                                    sender.Location.X >= txtbox_mot6.Location.X And sender.Location.X <= txtbox_mot6.Location.X + txtbox_mot6.Width() Then
                                    txtbox_mot6.Text = sender.Text
                                Else
                                    If sender.Location.Y + sender.Height() >= txtbox_mot7.Location.Y And sender.Location.Y <= txtbox_mot7.Location.Y + txtbox_mot7.Height() And
                                        sender.Location.X >= txtbox_mot7.Location.X And sender.Location.X <= txtbox_mot7.Location.X + txtbox_mot7.Width() Then
                                        txtbox_mot7.Text = sender.Text
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Label_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_mot1.MouseUp, lbl_mot2.MouseUp, lbl_mot3.MouseUp, lbl_mot4.MouseUp, lbl_mot5.MouseUp, lbl_mot6.MouseUp, lbl_mot7.MouseUp
        lbl_mot1.Top = y1
        lbl_mot1.Left = x1

        lbl_mot2.Top = y2
        lbl_mot2.Left = x2

        lbl_mot3.Top = y3
        lbl_mot3.Left = x3

        lbl_mot4.Top = y4
        lbl_mot4.Left = x4

        lbl_mot5.Top = y5
        lbl_mot5.Left = x5

        lbl_mot6.Top = y6
        lbl_mot6.Left = x6

        lbl_mot7.Top = y7
        lbl_mot7.Left = x7
    End Sub

    Private Sub cmd_aideQ4_Click(sender As Object, e As EventArgs) Handles cmd_aideQ4.Click
        MsgBox("Appuie et maintiens le click sur un mot, puis fais-le glisser vers une boîte vide pour la remplir")
    End Sub

    Private Sub cmd_Next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        If txtbox_mot1.Text = "" Or txtbox_mot2.Text = "" Or txtbox_mot3.Text = "" Or txtbox_mot4.Text = "" Or txtbox_mot5.Text = "" Or txtbox_mot6.Text = "" Or txtbox_mot7.Text = "" Then
            MsgBox("Complète toutes les boîtes.")
        Else
            If txtbox_mot1.Text = lbl_mot3.Text And txtbox_mot2.Text = lbl_mot5.Text And txtbox_mot3.Text = lbl_mot7.Text And txtbox_mot4.Text = lbl_mot6.Text And txtbox_mot5.Text = lbl_mot1.Text And txtbox_mot6.Text = lbl_mot4.Text And txtbox_mot7.Text = lbl_mot2.Text Then
                n_gram += 1
            End If
            Questions3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        'Ifs pour reinitialiser les réponses de Question 1 et 3
        If n_voc = 1 Then
            n_voc -= 1
        End If

        If n_voc = 2 Then
            n_voc -= 2
        End If

        'If pour reinitialiser la réponse de Question 2 
        If n_gram = 1 Then
            n_gram -= 1
        End If
        Questions1.Show()
        Me.Hide()
    End Sub

End Class
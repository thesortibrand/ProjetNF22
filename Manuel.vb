Public Class Manuel
    Private Sub cmd_quitter_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        MsgBox("Bouton QUITTER, pour sortir du programme")
    End Sub

    Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
        MsgBox("Bouton BACK, pour retourner à une fenêtre de questions précédentes")
    End Sub

    Private Sub cmd_Next_Click(sender As Object, e As EventArgs) Handles cmd_Next.Click
        MsgBox("Bouton NEXT, pour passer à la fenêtre suivante de questions")
    End Sub

    Private Sub bt_voc_Click(sender As Object, e As EventArgs) Handles bt_voc.Click
        MsgBox("Bouton CONSEILS, pour écouter un conseil sur la catégorie de question dans laquelle tu as mal répondu")
    End Sub

    Private Sub cmd_aide_Click(sender As Object, e As EventArgs) Handles cmd_aide.Click
        MsgBox("Bouton INSTRUCTION, pour connaître la démarche pour répondre à la question")
    End Sub

    Private Sub cmd_start_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        MsgBox("Bouton START, bouton vert dans la fenêtre de: Accueil pour démarrer le test")
    End Sub

    Private Sub cmd_enregistrer_Click(sender As Object, e As EventArgs) Handles cmd_enregistrer.Click
        MsgBox("Bouton ENREGISTRER, pour sauvegarder tes résultats dans un fichier .txt")
    End Sub

    Private Sub cmd_finaliser_Click(sender As Object, e As EventArgs) Handles cmd_finaliser.Click
        MsgBox("Bouton FINALISER, pour terminer le test")
    End Sub

    Private Sub cb_manual_CheckedChanged(sender As Object, e As EventArgs) Handles cb_manual.CheckedChanged
        cb_manual.Checked = False
        Accueil.Show()
        Me.Hide()
    End Sub
End Class
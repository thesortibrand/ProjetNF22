Public Class Accueil
    Private Sub cmd_Quitter_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        Dim reponse_quitter As String = InputBox("Fermer le programme? Oui/Non")

        If reponse_quitter = "Oui" Or reponse_quitter = "oui" Then
            End
        End If

    End Sub

    Private Sub cmd_start_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        'Initialisation des variables pour compter les réponses
        n_voc = 0
        n_gram = 0
        n_ponc = 0
        n_ari = 0
        n_lec = 0

        'Initialisation des variables pour compter le temps de réalisaion du Test
        minutes = 30
        secondes = 0

        Question1.Show()
        Me.Hide()
    End Sub
End Class

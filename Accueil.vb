Public Class Accueil
    Private Sub btn_Manuel_Click(sender As Object, e As EventArgs) Handles btn_Manuel.Click
        Manuel.Show()
        Me.Hide()
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

        Questions1.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_Quitter_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        End
    End Sub
End Class

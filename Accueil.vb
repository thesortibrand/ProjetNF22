Public Class Accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        End
    End Sub

    Private Sub cmd_start_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        Question1.Show()
        Me.Hide()
    End Sub
End Class

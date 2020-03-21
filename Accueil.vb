Public Class Accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        End
    End Sub

    Private Sub cmd_start_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        Question1.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_explicationtest.Click

    End Sub
End Class

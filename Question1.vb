Public Class Question1
    Private Sub txtBox_repQ1_TextChanged(sender As Object, e As EventArgs) Handles txtBox_repQ1.TextChanged

    End Sub

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Accueil.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        Question2.Show()
        Me.Hide()
    End Sub
End Class
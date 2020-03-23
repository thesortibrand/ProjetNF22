Public Class Question5
    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Question4.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If TextBox.Text = "" Then
            MsgBox("Aucune réponse n'a été rentrée")
        Else
            If TextBox.Text = "chevaux" Then
                n = n + 1
            Else
                n = n
            End If
            Question6.Show()
            Me.Hide()
        End If
    End Sub
End Class
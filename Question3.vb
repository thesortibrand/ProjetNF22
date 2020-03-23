Public Class Question3
    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Question2.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep.SelectedItem = "" Then
            MsgBox("Aucune réponse n'a été selectionnée")
        Else
            If rep.SelectedIndex = 1 Then
                n_gram = n_gram + 1
            Else
                n_gram = n_gram
            End If
            Question4.Show()
            Me.Hide()
        End If
    End Sub
End Class
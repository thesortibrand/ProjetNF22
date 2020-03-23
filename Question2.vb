Public Class Question2
    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Question1.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep.SelectedItem <> "" Then
            If rep.SelectedIndex = 1 Then
                n_ope = n_ope + 1
            Else
                n_ope = n_ope
            End If
            Question3.Show()
            Me.Hide()
        Else
            MsgBox("Aucune réponse n'a été selectionnée")
        End If
    End Sub
End Class
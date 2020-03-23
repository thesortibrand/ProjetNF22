Public Class Question1
    Dim i As Integer

    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Accueil.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep1.Checked = False And rep2.Checked = False And rep3.Checked = False And rep4.Checked = False Then
            MsgBox("Aucune réponse n'a été selectionnée")
        Else
            n = 0
            If i = 2 Then
                n = n + 1
            Else
                n = n
            End If
            Question2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rep1_CheckedChanged(sender As Object, e As EventArgs) Handles rep1.CheckedChanged
        i = 1
    End Sub

    Private Sub rep2_CheckedChanged(sender As Object, e As EventArgs) Handles rep2.CheckedChanged
        i = 2
    End Sub

    Private Sub rep3_CheckedChanged(sender As Object, e As EventArgs) Handles rep3.CheckedChanged
        i = 3
    End Sub

    Private Sub rep4_CheckedChanged(sender As Object, e As EventArgs) Handles rep4.CheckedChanged
        i = 4
    End Sub
End Class
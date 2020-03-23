Public Class Question4
    Private Sub cmd_back_Click(sender As Object, e As EventArgs) Handles cmd_back.Click
        Question3.Show()
        Me.Hide()
    End Sub

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If DateTimePicker.Value = "10 / 03 / 2020" Then
            n = n + 1
        Else
            n = n
        End If
        Question5.Show()
        Me.Hide()
    End Sub

End Class
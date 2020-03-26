Public Class Question1
    Dim i As Integer
    Private Sub Question1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerQ1.Start()
        timer_test = TimerQ1
        lbl_min.Text = minutes
        lbl_sec.Text = secondes
    End Sub

    Private Sub TimerQ1_Tick(sender As Object, e As EventArgs) Handles TimerQ1.Tick
        If minutes <> 0 Then
            If secondes = 0 Then
                minutes -= 1
                secondes = 60
                lbl_min.Text = minutes
            End If
            secondes -= 1
            lbl_sec.Text = secondes
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

    Private Sub cmd_next_Click(sender As Object, e As EventArgs) Handles cmd_next.Click
        If rep1.Checked = False And rep2.Checked = False And rep3.Checked = False And rep4.Checked = False Then
            MsgBox("Aucune réponse n'a été selectionnée")
        Else
            If i = 2 Then
                n_voc += 1
            End If
            Question2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub cmd_Aide_Click(sender As Object, e As EventArgs) Handles cmd_Aide.Click
        MsgBox("INSTRUCTION : Clique sur le rond correspondant à la réponse de ton choix.")
    End Sub
End Class
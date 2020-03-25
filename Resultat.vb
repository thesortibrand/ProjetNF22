Public Class Resultat
    Private Sub Resultat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox_score.Text = n_ari + n_gram + n_lec + n_ponc + n_voc

        txtbox_ari.Text = ((n_ari / 4) * 100) & " %"
        txtbox_gram.Text = ((n_ari / 2) * 100) & " %"
        txtbox_voc.Text = ((n_voc / 2) * 100) & " %"
        txtbox_ponc.Text = ((n_ponc / 1) * 100) & " %"
        txtbox_lec.Text = ((n_lec / 1) * 100) & " %"

        If ((n_ari / 4) * 100) <> 100 Then
            listbox_conseils.Items.Add("- Conseil Arithmétique")
        End If

        If ((n_gram / 2) * 100) <> 100 Then
            listbox_conseils.Items.Add("- Conseil Grammaire")
        End If

        If ((n_lec / 1) * 100) <> 100 Then
            listbox_conseils.Items.Add("- Conseil Lecture Horloge")
        End If

        If ((n_ponc / 1) * 100) <> 100 Then
            listbox_conseils.Items.Add("- Conseil Ponctuation")
        End If

        If ((n_voc / 2) * 100) <> 100 Then
            listbox_conseils.Items.Add("- Conseil Vocabulaire")
        End If

    End Sub

    Private Sub cmd_Quitter_Click(sender As Object, e As EventArgs) Handles cmd_Quitter.Click
        MsgBox("Merci :) Créé par Louis GARBAY et Daniel GARCIA")
        End
    End Sub
End Class
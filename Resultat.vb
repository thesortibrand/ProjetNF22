Public Class Resultat
    Dim gram, voc, ponc, ari, lec As Integer
    Private Sub Resultat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_min.Text = 29 - minutes
        lbl_sec.Text = 60 - secondes

        txtbox_score.Text = n_ari + n_gram + n_lec + n_ponc + n_voc

        gram = (n_gram / 2) * 100
        voc = (n_voc / 2) * 100
        ponc = (n_ponc / 1) * 100
        ari = (n_ari / 4) * 100
        lec = (n_lec / 1) * 100

        txtbox_gram.Text = gram & " %"
        txtbox_voc.Text = voc & " %"
        txtbox_ponc.Text = ponc & " %"
        txtbox_ari.Text = ari & " %"
        txtbox_lec.Text = lec & " %"


        Me.Chart_Resultats.Series("Categories").Points.AddXY("Grammaire", gram)
        Me.Chart_Resultats.Series("Categories").Points.AddXY("Vocabulaire", voc)
        Me.Chart_Resultats.Series("Categories").Points.AddXY("Ponctuation", ponc)
        Me.Chart_Resultats.Series("Categories").Points.AddXY("Arithmétique", ari)
        Me.Chart_Resultats.Series("Categories").Points.AddXY("Horloge", lec)

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
        MsgBox("Merci :)" & Chr(13) & Chr(10) & "Créé par Louis GARBAY et Daniel GARCIA")
        End
    End Sub
End Class
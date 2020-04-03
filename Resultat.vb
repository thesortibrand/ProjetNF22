Public Class Resultat
    Dim gram, voc, ponc, ari, lec As Integer
    Dim i As Integer
    Dim resultats_enregistres(0 To 4) As String

    Private Sub Resultat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If minutes < 0 Then
            MsgBox("Tu as dépassé 30 minutes le temps objectif de résolution")
            lbl_minRes.Text = 30
            lbl_secRes.Text = 0
        Else
            lbl_minRes.Text = 29 - minutes
            lbl_secRes.Text = 60 - secondes
        End If

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


        Me.Chart_Resultats.Series("Nouveaux résultats").Points.AddXY("Grammaire", gram)
        Me.Chart_Resultats.Series("Nouveaux résultats").Points.AddXY("Vocabulaire", voc)
        Me.Chart_Resultats.Series("Nouveaux résultats").Points.AddXY("Ponctuation", ponc)
        Me.Chart_Resultats.Series("Nouveaux résultats").Points.AddXY("Arithmétique", ari)
        Me.Chart_Resultats.Series("Nouveaux résultats").Points.AddXY("Horloge", lec)

        If ((n_ari / 4) * 100) <> 100 Then
            bt_ari.Enabled = True
        End If

        If ((n_gram / 2) * 100) <> 100 Then
            bt_gram.Enabled = True
        End If

        If ((n_lec / 1) * 100) <> 100 Then
            bt_lec.Enabled = True
        End If

        If ((n_ponc / 1) * 100) <> 100 Then
            bt_ponc.Enabled = True
        End If

        If ((n_voc / 2) * 100) <> 100 Then
            bt_voc.Enabled = True
        End If

        'Code pour lire des résultats enregistrés avant
        OpenFileDialog1.ShowDialog()
        With OpenFileDialog1
            .Title = "Ouvrir" 'Titre de la barre de titre
            .Filter = "Fichiers txt|*.txt" ' on travaille uniquement sur les .txt
            .Multiselect = False 'sélectionner 1 seul fichier
        End With

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Do While Not EOF(1)
            Input(1, resultats_enregistres(i))
            i = i + 1
        Loop
        FileClose(1)

        Me.Chart_Resultats.Series("Résultats précédents").Points.AddXY("Grammaire", resultats_enregistres(0))
        Me.Chart_Resultats.Series("Résultats précédents").Points.AddXY("Vocabulaire", resultats_enregistres(1))
        Me.Chart_Resultats.Series("Résultats précédents").Points.AddXY("Ponctuation", resultats_enregistres(2))
        Me.Chart_Resultats.Series("Résultats précédents").Points.AddXY("Arithmétique", resultats_enregistres(3))
        Me.Chart_Resultats.Series("Résultats précédents").Points.AddXY("Horloge", resultats_enregistres(4))

    End Sub

    'Code pour ajouter audio aux Conseils
    Private Sub bt_voc_Click(sender As Object, e As EventArgs) Handles bt_voc.Click
        Dim audio_voc As New System.Media.SoundPlayer(My.Resources.voc_audio)
        audio_voc.Play()
    End Sub

    Private Sub bt_ponc_Click(sender As Object, e As EventArgs) Handles bt_ponc.Click
        Dim audio_ponc As New System.Media.SoundPlayer(My.Resources.ponc_audio)
        audio_ponc.Play()
    End Sub

    Private Sub bt_lec_Click(sender As Object, e As EventArgs) Handles bt_lec.Click
        Dim audio_lec As New System.Media.SoundPlayer(My.Resources.lec_audio)
        audio_lec.Play()
    End Sub

    Private Sub bt_ari_Click(sender As Object, e As EventArgs) Handles bt_ari.Click
        Dim audio_ari As New System.Media.SoundPlayer(My.Resources.Enregistrement)
        audio_ari.Play()
    End Sub

    Private Sub bt_gram_Click(sender As Object, e As EventArgs) Handles bt_gram.Click
        Dim audio_gram As New System.Media.SoundPlayer(My.Resources.gram_audio)
        audio_gram.Play()
    End Sub

    Private Sub cmd_enregistrer_Click(sender As Object, e As EventArgs) Handles cmd_enregistrer.Click
        'Code pour écrire dans le fichier et enregistrer les résultats nouveaux
        Dim obj As Object
        Dim fichier As Object
        obj = CreateObject("Scripting.FileSystemObject")
        fichier = obj.CreateTextFile(OpenFileDialog1.FileName)
        fichier.WriteLine(gram)
        fichier.WriteLine(voc)
        fichier.WriteLine(ponc)
        fichier.WriteLine(ari)
        fichier.WriteLine(lec)
        fichier.Close()
        MsgBox("Les résulats ont été sauvegardés")
    End Sub

    Private Sub cmd_Quitter_Click(sender As Object, e As EventArgs) Handles cmd_quitter.Click
        MsgBox("Merci :)" & Chr(13) & Chr(10) & "Créé par Louis GARBAY et Daniel GARCIA.")
        End
    End Sub
End Class
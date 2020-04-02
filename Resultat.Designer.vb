<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Resultat))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.txtbox_score = New System.Windows.Forms.TextBox()
        Me.lbl_10 = New System.Windows.Forms.Label()
        Me.groupbox_categories = New System.Windows.Forms.GroupBox()
        Me.lbl_lec = New System.Windows.Forms.Label()
        Me.txtbox_ponc = New System.Windows.Forms.TextBox()
        Me.lbl_ponct = New System.Windows.Forms.Label()
        Me.lbl_français = New System.Windows.Forms.Label()
        Me.txtbox_lec = New System.Windows.Forms.TextBox()
        Me.txtbox_ari = New System.Windows.Forms.TextBox()
        Me.txtbox_voc = New System.Windows.Forms.TextBox()
        Me.txtbox_gram = New System.Windows.Forms.TextBox()
        Me.lbl_ari = New System.Windows.Forms.Label()
        Me.lbl_math = New System.Windows.Forms.Label()
        Me.lbl_voc = New System.Windows.Forms.Label()
        Me.lbl_gram = New System.Windows.Forms.Label()
        Me.lbl_minRes = New System.Windows.Forms.Label()
        Me.lbl_deuxptsRes = New System.Windows.Forms.Label()
        Me.lbl_secRes = New System.Windows.Forms.Label()
        Me.GroupBox_duree = New System.Windows.Forms.GroupBox()
        Me.gb_conseils = New System.Windows.Forms.GroupBox()
        Me.bt_lec = New System.Windows.Forms.Button()
        Me.bt_ari = New System.Windows.Forms.Button()
        Me.bt_ponc = New System.Windows.Forms.Button()
        Me.bt_voc = New System.Windows.Forms.Button()
        Me.bt_gram = New System.Windows.Forms.Button()
        Me.cmd_enregistrer = New System.Windows.Forms.Button()
        Me.cmd_quitter = New System.Windows.Forms.Button()
        Me.Chart_Resultats = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.groupbox_categories.SuspendLayout()
        Me.GroupBox_duree.SuspendLayout()
        Me.gb_conseils.SuspendLayout()
        CType(Me.Chart_Resultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(50, 30)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(153, 35)
        Me.lbl_score.TabIndex = 0
        Me.lbl_score.Text = "Score Total"
        '
        'txtbox_score
        '
        Me.txtbox_score.Enabled = False
        Me.txtbox_score.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_score.Location = New System.Drawing.Point(75, 80)
        Me.txtbox_score.Name = "txtbox_score"
        Me.txtbox_score.Size = New System.Drawing.Size(100, 31)
        Me.txtbox_score.TabIndex = 1
        Me.txtbox_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_10
        '
        Me.lbl_10.AutoSize = True
        Me.lbl_10.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_10.Location = New System.Drawing.Point(195, 85)
        Me.lbl_10.Name = "lbl_10"
        Me.lbl_10.Size = New System.Drawing.Size(42, 24)
        Me.lbl_10.TabIndex = 2
        Me.lbl_10.Text = "/ 10"
        '
        'groupbox_categories
        '
        Me.groupbox_categories.Controls.Add(Me.lbl_lec)
        Me.groupbox_categories.Controls.Add(Me.txtbox_ponc)
        Me.groupbox_categories.Controls.Add(Me.lbl_ponct)
        Me.groupbox_categories.Controls.Add(Me.lbl_français)
        Me.groupbox_categories.Controls.Add(Me.txtbox_lec)
        Me.groupbox_categories.Controls.Add(Me.txtbox_ari)
        Me.groupbox_categories.Controls.Add(Me.txtbox_voc)
        Me.groupbox_categories.Controls.Add(Me.txtbox_gram)
        Me.groupbox_categories.Controls.Add(Me.lbl_ari)
        Me.groupbox_categories.Controls.Add(Me.lbl_math)
        Me.groupbox_categories.Controls.Add(Me.lbl_voc)
        Me.groupbox_categories.Controls.Add(Me.lbl_gram)
        Me.groupbox_categories.Location = New System.Drawing.Point(50, 140)
        Me.groupbox_categories.Name = "groupbox_categories"
        Me.groupbox_categories.Size = New System.Drawing.Size(250, 330)
        Me.groupbox_categories.TabIndex = 3
        Me.groupbox_categories.TabStop = False
        Me.groupbox_categories.Text = "% par Catégorie"
        '
        'lbl_lec
        '
        Me.lbl_lec.AutoSize = True
        Me.lbl_lec.Location = New System.Drawing.Point(30, 270)
        Me.lbl_lec.Name = "lbl_lec"
        Me.lbl_lec.Size = New System.Drawing.Size(106, 19)
        Me.lbl_lec.TabIndex = 14
        Me.lbl_lec.Text = "Lecture Heure"
        '
        'txtbox_ponc
        '
        Me.txtbox_ponc.Enabled = False
        Me.txtbox_ponc.Location = New System.Drawing.Point(150, 150)
        Me.txtbox_ponc.Name = "txtbox_ponc"
        Me.txtbox_ponc.Size = New System.Drawing.Size(55, 26)
        Me.txtbox_ponc.TabIndex = 10
        Me.txtbox_ponc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ponct
        '
        Me.lbl_ponct.AutoSize = True
        Me.lbl_ponct.Location = New System.Drawing.Point(30, 150)
        Me.lbl_ponct.Name = "lbl_ponct"
        Me.lbl_ponct.Size = New System.Drawing.Size(83, 19)
        Me.lbl_ponct.TabIndex = 9
        Me.lbl_ponct.Text = "Ponctuation"
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(30, 30)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(70, 17)
        Me.lbl_français.TabIndex = 4
        Me.lbl_français.Text = "Français"
        '
        'txtbox_lec
        '
        Me.txtbox_lec.Enabled = False
        Me.txtbox_lec.Location = New System.Drawing.Point(150, 270)
        Me.txtbox_lec.Name = "txtbox_lec"
        Me.txtbox_lec.Size = New System.Drawing.Size(55, 26)
        Me.txtbox_lec.TabIndex = 15
        Me.txtbox_lec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_ari
        '
        Me.txtbox_ari.Enabled = False
        Me.txtbox_ari.Location = New System.Drawing.Point(150, 230)
        Me.txtbox_ari.Name = "txtbox_ari"
        Me.txtbox_ari.Size = New System.Drawing.Size(55, 26)
        Me.txtbox_ari.TabIndex = 13
        Me.txtbox_ari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_voc
        '
        Me.txtbox_voc.Enabled = False
        Me.txtbox_voc.Location = New System.Drawing.Point(150, 110)
        Me.txtbox_voc.Name = "txtbox_voc"
        Me.txtbox_voc.Size = New System.Drawing.Size(55, 26)
        Me.txtbox_voc.TabIndex = 8
        Me.txtbox_voc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_gram
        '
        Me.txtbox_gram.Enabled = False
        Me.txtbox_gram.Location = New System.Drawing.Point(150, 70)
        Me.txtbox_gram.Name = "txtbox_gram"
        Me.txtbox_gram.Size = New System.Drawing.Size(55, 26)
        Me.txtbox_gram.TabIndex = 6
        Me.txtbox_gram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ari
        '
        Me.lbl_ari.AutoSize = True
        Me.lbl_ari.Location = New System.Drawing.Point(30, 230)
        Me.lbl_ari.Name = "lbl_ari"
        Me.lbl_ari.Size = New System.Drawing.Size(95, 19)
        Me.lbl_ari.TabIndex = 12
        Me.lbl_ari.Text = "Arithmétique"
        '
        'lbl_math
        '
        Me.lbl_math.AutoSize = True
        Me.lbl_math.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_math.Location = New System.Drawing.Point(30, 200)
        Me.lbl_math.Name = "lbl_math"
        Me.lbl_math.Size = New System.Drawing.Size(43, 17)
        Me.lbl_math.TabIndex = 11
        Me.lbl_math.Text = "Math"
        '
        'lbl_voc
        '
        Me.lbl_voc.AutoSize = True
        Me.lbl_voc.Location = New System.Drawing.Point(30, 110)
        Me.lbl_voc.Name = "lbl_voc"
        Me.lbl_voc.Size = New System.Drawing.Size(84, 19)
        Me.lbl_voc.TabIndex = 7
        Me.lbl_voc.Text = "Vocabulaire"
        '
        'lbl_gram
        '
        Me.lbl_gram.AutoSize = True
        Me.lbl_gram.Location = New System.Drawing.Point(30, 70)
        Me.lbl_gram.Name = "lbl_gram"
        Me.lbl_gram.Size = New System.Drawing.Size(81, 19)
        Me.lbl_gram.TabIndex = 5
        Me.lbl_gram.Text = "Grammaire"
        '
        'lbl_minRes
        '
        Me.lbl_minRes.AutoSize = True
        Me.lbl_minRes.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minRes.Location = New System.Drawing.Point(23, 33)
        Me.lbl_minRes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_minRes.Name = "lbl_minRes"
        Me.lbl_minRes.Size = New System.Drawing.Size(0, 28)
        Me.lbl_minRes.TabIndex = 17
        '
        'lbl_deuxptsRes
        '
        Me.lbl_deuxptsRes.AutoSize = True
        Me.lbl_deuxptsRes.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deuxptsRes.Location = New System.Drawing.Point(59, 33)
        Me.lbl_deuxptsRes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_deuxptsRes.Name = "lbl_deuxptsRes"
        Me.lbl_deuxptsRes.Size = New System.Drawing.Size(18, 28)
        Me.lbl_deuxptsRes.TabIndex = 18
        Me.lbl_deuxptsRes.Text = ":"
        '
        'lbl_secRes
        '
        Me.lbl_secRes.AutoSize = True
        Me.lbl_secRes.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secRes.Location = New System.Drawing.Point(90, 33)
        Me.lbl_secRes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_secRes.Name = "lbl_secRes"
        Me.lbl_secRes.Size = New System.Drawing.Size(0, 28)
        Me.lbl_secRes.TabIndex = 19
        '
        'GroupBox_duree
        '
        Me.GroupBox_duree.Controls.Add(Me.lbl_deuxptsRes)
        Me.GroupBox_duree.Controls.Add(Me.lbl_secRes)
        Me.GroupBox_duree.Controls.Add(Me.lbl_minRes)
        Me.GroupBox_duree.Location = New System.Drawing.Point(400, 30)
        Me.GroupBox_duree.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_duree.Name = "GroupBox_duree"
        Me.GroupBox_duree.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_duree.Size = New System.Drawing.Size(133, 72)
        Me.GroupBox_duree.TabIndex = 16
        Me.GroupBox_duree.TabStop = False
        Me.GroupBox_duree.Text = "Durée du test"
        '
        'gb_conseils
        '
        Me.gb_conseils.Controls.Add(Me.bt_lec)
        Me.gb_conseils.Controls.Add(Me.bt_ari)
        Me.gb_conseils.Controls.Add(Me.bt_ponc)
        Me.gb_conseils.Controls.Add(Me.bt_voc)
        Me.gb_conseils.Controls.Add(Me.bt_gram)
        Me.gb_conseils.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_conseils.Location = New System.Drawing.Point(400, 443)
        Me.gb_conseils.Name = "gb_conseils"
        Me.gb_conseils.Size = New System.Drawing.Size(454, 124)
        Me.gb_conseils.TabIndex = 21
        Me.gb_conseils.TabStop = False
        Me.gb_conseils.Text = "Conseils"
        '
        'bt_lec
        '
        Me.bt_lec.BackColor = System.Drawing.Color.White
        Me.bt_lec.Enabled = False
        Me.bt_lec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_lec.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_lec.Location = New System.Drawing.Point(365, 44)
        Me.bt_lec.Name = "bt_lec"
        Me.bt_lec.Size = New System.Drawing.Size(60, 60)
        Me.bt_lec.TabIndex = 26
        Me.bt_lec.UseVisualStyleBackColor = False
        '
        'bt_ari
        '
        Me.bt_ari.BackColor = System.Drawing.Color.White
        Me.bt_ari.Enabled = False
        Me.bt_ari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ari.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_ari.Location = New System.Drawing.Point(281, 44)
        Me.bt_ari.Name = "bt_ari"
        Me.bt_ari.Size = New System.Drawing.Size(60, 60)
        Me.bt_ari.TabIndex = 25
        Me.bt_ari.UseVisualStyleBackColor = False
        '
        'bt_ponc
        '
        Me.bt_ponc.BackColor = System.Drawing.Color.White
        Me.bt_ponc.Enabled = False
        Me.bt_ponc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_ponc.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_ponc.Location = New System.Drawing.Point(196, 44)
        Me.bt_ponc.Name = "bt_ponc"
        Me.bt_ponc.Size = New System.Drawing.Size(60, 60)
        Me.bt_ponc.TabIndex = 24
        Me.bt_ponc.UseVisualStyleBackColor = False
        '
        'bt_voc
        '
        Me.bt_voc.BackColor = System.Drawing.Color.White
        Me.bt_voc.Enabled = False
        Me.bt_voc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_voc.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_voc.Location = New System.Drawing.Point(115, 44)
        Me.bt_voc.Name = "bt_voc"
        Me.bt_voc.Size = New System.Drawing.Size(60, 60)
        Me.bt_voc.TabIndex = 23
        Me.bt_voc.UseVisualStyleBackColor = False
        '
        'bt_gram
        '
        Me.bt_gram.BackColor = System.Drawing.Color.White
        Me.bt_gram.Enabled = False
        Me.bt_gram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_gram.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_gram.Location = New System.Drawing.Point(28, 44)
        Me.bt_gram.Name = "bt_gram"
        Me.bt_gram.Size = New System.Drawing.Size(60, 60)
        Me.bt_gram.TabIndex = 22
        Me.bt_gram.UseVisualStyleBackColor = False
        '
        'cmd_enregistrer
        '
        Me.cmd_enregistrer.BackColor = System.Drawing.Color.LimeGreen
        Me.cmd_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_enregistrer.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_enregistrer.Location = New System.Drawing.Point(670, 30)
        Me.cmd_enregistrer.Name = "cmd_enregistrer"
        Me.cmd_enregistrer.Size = New System.Drawing.Size(115, 72)
        Me.cmd_enregistrer.TabIndex = 27
        Me.cmd_enregistrer.Text = "Enregistrer Résultats"
        Me.cmd_enregistrer.UseVisualStyleBackColor = False
        '
        'cmd_quitter
        '
        Me.cmd_quitter.AutoSize = True
        Me.cmd_quitter.BackColor = System.Drawing.Color.White
        Me.cmd_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_quitter.Image = CType(resources.GetObject("cmd_quitter.Image"), System.Drawing.Image)
        Me.cmd_quitter.Location = New System.Drawing.Point(130, 487)
        Me.cmd_quitter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_quitter.Name = "cmd_quitter"
        Me.cmd_quitter.Size = New System.Drawing.Size(80, 80)
        Me.cmd_quitter.TabIndex = 28
        Me.cmd_quitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quitter.UseVisualStyleBackColor = False
        '
        'Chart_Resultats
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Resultats.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_Resultats.Legends.Add(Legend1)
        Me.Chart_Resultats.Location = New System.Drawing.Point(376, 140)
        Me.Chart_Resultats.Name = "Chart_Resultats"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Chart_Resultats.Series.Add(Series1)
        Me.Chart_Resultats.Series.Add(Series2)
        Me.Chart_Resultats.Size = New System.Drawing.Size(478, 256)
        Me.Chart_Resultats.TabIndex = 20
        Me.Chart_Resultats.Text = "Résultats"
        '
        'Resultat
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(928, 619)
        Me.ControlBox = False
        Me.Controls.Add(Me.Chart_Resultats)
        Me.Controls.Add(Me.cmd_quitter)
        Me.Controls.Add(Me.cmd_enregistrer)
        Me.Controls.Add(Me.gb_conseils)
        Me.Controls.Add(Me.GroupBox_duree)
        Me.Controls.Add(Me.groupbox_categories)
        Me.Controls.Add(Me.lbl_10)
        Me.Controls.Add(Me.txtbox_score)
        Me.Controls.Add(Me.lbl_score)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Resultat"
        Me.Text = "Resultats"
        Me.groupbox_categories.ResumeLayout(False)
        Me.groupbox_categories.PerformLayout()
        Me.GroupBox_duree.ResumeLayout(False)
        Me.GroupBox_duree.PerformLayout()
        Me.gb_conseils.ResumeLayout(False)
        CType(Me.Chart_Resultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_score As Label
    Friend WithEvents txtbox_score As TextBox
    Friend WithEvents lbl_10 As Label
    Friend WithEvents groupbox_categories As GroupBox
    Friend WithEvents txtbox_ponc As TextBox
    Friend WithEvents lbl_ponct As Label
    Friend WithEvents lbl_français As Label
    Friend WithEvents txtbox_lec As TextBox
    Friend WithEvents txtbox_ari As TextBox
    Friend WithEvents txtbox_voc As TextBox
    Friend WithEvents txtbox_gram As TextBox
    Friend WithEvents lbl_ari As Label
    Friend WithEvents lbl_math As Label
    Friend WithEvents lbl_voc As Label
    Friend WithEvents lbl_gram As Label
    Friend WithEvents lbl_lec As Label
    Friend WithEvents lbl_minRes As Label
    Friend WithEvents lbl_deuxptsRes As Label
    Friend WithEvents lbl_secRes As Label
    Friend WithEvents GroupBox_duree As GroupBox
    Friend WithEvents gb_conseils As GroupBox
    Friend WithEvents cmd_enregistrer As Button
    Friend WithEvents cmd_quitter As Button
    Friend WithEvents bt_gram As Button
    Friend WithEvents bt_lec As Button
    Friend WithEvents bt_ari As Button
    Friend WithEvents bt_ponc As Button
    Friend WithEvents bt_voc As Button
    Friend WithEvents Chart_Resultats As DataVisualization.Charting.Chart
End Class

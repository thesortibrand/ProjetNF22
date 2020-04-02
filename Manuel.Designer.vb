<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manuel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manuel))
        Me.lbl_bienvenue = New System.Windows.Forms.Label()
        Me.gp_principe = New System.Windows.Forms.GroupBox()
        Me.lbl_pt3 = New System.Windows.Forms.Label()
        Me.lbl_pt2 = New System.Windows.Forms.Label()
        Me.lbl_pt1 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.gb_aides = New System.Windows.Forms.GroupBox()
        Me.bt_voc = New System.Windows.Forms.Button()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.lbl_cliques = New System.Windows.Forms.Label()
        Me.cmd_finaliser = New System.Windows.Forms.Button()
        Me.cmd_enregistrer = New System.Windows.Forms.Button()
        Me.cmd_aide = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_quitter = New System.Windows.Forms.Button()
        Me.lbl_salut = New System.Windows.Forms.Label()
        Me.cb_manual = New System.Windows.Forms.CheckBox()
        Me.gp_principe.SuspendLayout()
        Me.gb_aides.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_bienvenue
        '
        Me.lbl_bienvenue.AutoSize = True
        Me.lbl_bienvenue.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvenue.Location = New System.Drawing.Point(50, 30)
        Me.lbl_bienvenue.Name = "lbl_bienvenue"
        Me.lbl_bienvenue.Size = New System.Drawing.Size(255, 51)
        Me.lbl_bienvenue.TabIndex = 0
        Me.lbl_bienvenue.Text = "BIENVENUE!"
        '
        'gp_principe
        '
        Me.gp_principe.Controls.Add(Me.lbl_pt3)
        Me.gp_principe.Controls.Add(Me.lbl_pt2)
        Me.gp_principe.Controls.Add(Me.lbl_pt1)
        Me.gp_principe.Controls.Add(Me.lbl_3)
        Me.gp_principe.Controls.Add(Me.lbl_2)
        Me.gp_principe.Controls.Add(Me.lbl_1)
        Me.gp_principe.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_principe.Location = New System.Drawing.Point(80, 160)
        Me.gp_principe.Name = "gp_principe"
        Me.gp_principe.Size = New System.Drawing.Size(635, 142)
        Me.gp_principe.TabIndex = 2
        Me.gp_principe.TabStop = False
        Me.gp_principe.Text = "Principe de fonctionnement"
        '
        'lbl_pt3
        '
        Me.lbl_pt3.AutoSize = True
        Me.lbl_pt3.Location = New System.Drawing.Point(50, 81)
        Me.lbl_pt3.Name = "lbl_pt3"
        Me.lbl_pt3.Size = New System.Drawing.Size(1012, 78)
        Me.lbl_pt3.TabIndex = 8
        Me.lbl_pt3.Text = "Termine le test et clique sur ""Enregistrer Résultats"" pour les comparer avec" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tes" &
    " résultats antérieurs obtenus si ce n'est pas la première fois. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_pt2
        '
        Me.lbl_pt2.AutoSize = True
        Me.lbl_pt2.Location = New System.Drawing.Point(50, 49)
        Me.lbl_pt2.Name = "lbl_pt2"
        Me.lbl_pt2.Size = New System.Drawing.Size(961, 39)
        Me.lbl_pt2.TabIndex = 6
        Me.lbl_pt2.Text = "Réponds aux questions et cliques sur ""Instruction"" si tu as besoin d'aide."
        '
        'lbl_pt1
        '
        Me.lbl_pt1.AutoSize = True
        Me.lbl_pt1.Location = New System.Drawing.Point(50, 20)
        Me.lbl_pt1.Name = "lbl_pt1"
        Me.lbl_pt1.Size = New System.Drawing.Size(979, 78)
        Me.lbl_pt1.TabIndex = 4
        Me.lbl_pt1.Text = "Dans la fenêtre ""Accueil"", clique sur le bouton vert pour démarrer le test." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Location = New System.Drawing.Point(20, 80)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(44, 39)
        Me.lbl_3.TabIndex = 7
        Me.lbl_3.Text = "3)"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Location = New System.Drawing.Point(20, 50)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(44, 39)
        Me.lbl_2.TabIndex = 5
        Me.lbl_2.Text = "2)"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(20, 20)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(40, 39)
        Me.lbl_1.TabIndex = 3
        Me.lbl_1.Text = "1)"
        '
        'gb_aides
        '
        Me.gb_aides.Controls.Add(Me.bt_voc)
        Me.gb_aides.Controls.Add(Me.cmd_start)
        Me.gb_aides.Controls.Add(Me.lbl_cliques)
        Me.gb_aides.Controls.Add(Me.cmd_finaliser)
        Me.gb_aides.Controls.Add(Me.cmd_enregistrer)
        Me.gb_aides.Controls.Add(Me.cmd_aide)
        Me.gb_aides.Controls.Add(Me.cmd_Back)
        Me.gb_aides.Controls.Add(Me.cmd_Next)
        Me.gb_aides.Controls.Add(Me.cmd_quitter)
        Me.gb_aides.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_aides.Location = New System.Drawing.Point(80, 319)
        Me.gb_aides.Name = "gb_aides"
        Me.gb_aides.Size = New System.Drawing.Size(635, 261)
        Me.gb_aides.TabIndex = 9
        Me.gb_aides.TabStop = False
        Me.gb_aides.Text = "Aides visuelles"
        '
        'bt_voc
        '
        Me.bt_voc.BackColor = System.Drawing.Color.White
        Me.bt_voc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bt_voc.Image = Global.ProjetNF22.My.Resources.Resources.parleur1
        Me.bt_voc.Location = New System.Drawing.Point(408, 63)
        Me.bt_voc.Name = "bt_voc"
        Me.bt_voc.Size = New System.Drawing.Size(60, 60)
        Me.bt_voc.TabIndex = 14
        Me.bt_voc.UseVisualStyleBackColor = False
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.Color.LimeGreen
        Me.cmd_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_start.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_start.Location = New System.Drawing.Point(20, 154)
        Me.cmd_start.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(260, 80)
        Me.cmd_start.TabIndex = 16
        Me.cmd_start.Text = "Démarrer l'évaluation"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'lbl_cliques
        '
        Me.lbl_cliques.AutoSize = True
        Me.lbl_cliques.Location = New System.Drawing.Point(20, 20)
        Me.lbl_cliques.Name = "lbl_cliques"
        Me.lbl_cliques.Size = New System.Drawing.Size(696, 39)
        Me.lbl_cliques.TabIndex = 10
        Me.lbl_cliques.Text = "Clique sur chaque bouton pour connaître sa fonction."
        '
        'cmd_finaliser
        '
        Me.cmd_finaliser.BackColor = System.Drawing.Color.White
        Me.cmd_finaliser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_finaliser.Image = Global.ProjetNF22.My.Resources.Resources.terminer
        Me.cmd_finaliser.Location = New System.Drawing.Point(511, 164)
        Me.cmd_finaliser.Name = "cmd_finaliser"
        Me.cmd_finaliser.Size = New System.Drawing.Size(67, 68)
        Me.cmd_finaliser.TabIndex = 18
        Me.cmd_finaliser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_finaliser.UseVisualStyleBackColor = False
        '
        'cmd_enregistrer
        '
        Me.cmd_enregistrer.BackColor = System.Drawing.Color.LimeGreen
        Me.cmd_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_enregistrer.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_enregistrer.Location = New System.Drawing.Point(342, 160)
        Me.cmd_enregistrer.Name = "cmd_enregistrer"
        Me.cmd_enregistrer.Size = New System.Drawing.Size(115, 72)
        Me.cmd_enregistrer.TabIndex = 17
        Me.cmd_enregistrer.Text = "Enregistrer Résultats"
        Me.cmd_enregistrer.UseVisualStyleBackColor = False
        '
        'cmd_aide
        '
        Me.cmd_aide.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aide.Location = New System.Drawing.Point(496, 63)
        Me.cmd_aide.Name = "cmd_aide"
        Me.cmd_aide.Size = New System.Drawing.Size(109, 33)
        Me.cmd_aide.TabIndex = 15
        Me.cmd_aide.Text = "Instruction"
        Me.cmd_aide.UseVisualStyleBackColor = False
        '
        'cmd_Back
        '
        Me.cmd_Back.BackColor = System.Drawing.Color.White
        Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(220, 63)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(60, 60)
        Me.cmd_Back.TabIndex = 12
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = False
        '
        'cmd_Next
        '
        Me.cmd_Next.BackColor = System.Drawing.Color.White
        Me.cmd_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.Location = New System.Drawing.Point(315, 63)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(60, 60)
        Me.cmd_Next.TabIndex = 13
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = False
        '
        'cmd_quitter
        '
        Me.cmd_quitter.AutoSize = True
        Me.cmd_quitter.BackColor = System.Drawing.Color.White
        Me.cmd_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_quitter.Image = CType(resources.GetObject("cmd_quitter.Image"), System.Drawing.Image)
        Me.cmd_quitter.Location = New System.Drawing.Point(97, 63)
        Me.cmd_quitter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_quitter.Name = "cmd_quitter"
        Me.cmd_quitter.Size = New System.Drawing.Size(80, 80)
        Me.cmd_quitter.TabIndex = 11
        Me.cmd_quitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quitter.UseVisualStyleBackColor = False
        '
        'lbl_salut
        '
        Me.lbl_salut.AutoSize = True
        Me.lbl_salut.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salut.Location = New System.Drawing.Point(80, 75)
        Me.lbl_salut.Name = "lbl_salut"
        Me.lbl_salut.Size = New System.Drawing.Size(1292, 156)
        Me.lbl_salut.TabIndex = 1
        Me.lbl_salut.Text = resources.GetString("lbl_salut.Text")
        '
        'cb_manual
        '
        Me.cb_manual.AutoSize = True
        Me.cb_manual.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_manual.Location = New System.Drawing.Point(80, 600)
        Me.cb_manual.Name = "cb_manual"
        Me.cb_manual.Size = New System.Drawing.Size(655, 43)
        Me.cb_manual.TabIndex = 19
        Me.cb_manual.Text = "J'ai lu le manuel et je suis prêt(e) pour le test."
        Me.cb_manual.UseVisualStyleBackColor = True
        '
        'Manuel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1083, 808)
        Me.ControlBox = False
        Me.Controls.Add(Me.cb_manual)
        Me.Controls.Add(Me.lbl_salut)
        Me.Controls.Add(Me.gb_aides)
        Me.Controls.Add(Me.gp_principe)
        Me.Controls.Add(Me.lbl_bienvenue)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Manuel"
        Me.Text = "Manuel"
        Me.gp_principe.ResumeLayout(False)
        Me.gp_principe.PerformLayout()
        Me.gb_aides.ResumeLayout(False)
        Me.gb_aides.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_bienvenue As Label
    Friend WithEvents gp_principe As GroupBox
    Friend WithEvents lbl_pt3 As Label
    Friend WithEvents lbl_pt2 As Label
    Friend WithEvents lbl_pt1 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents gb_aides As GroupBox
    Friend WithEvents cmd_quitter As Button
    Friend WithEvents cmd_Next As Button
    Friend WithEvents cmd_Back As Button
    Friend WithEvents cmd_aide As Button
    Friend WithEvents cmd_enregistrer As Button
    Friend WithEvents lbl_salut As Label
    Friend WithEvents cmd_finaliser As Button
    Friend WithEvents lbl_cliques As Label
    Friend WithEvents cmd_start As Button
    Friend WithEvents cb_manual As CheckBox
    Friend WithEvents bt_voc As Button
End Class

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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listbox_conseils = New System.Windows.Forms.ListBox()
        Me.cmd_Quitter = New System.Windows.Forms.Button()
        Me.groupbox_categories.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(112, 9)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(117, 24)
        Me.lbl_score.TabIndex = 0
        Me.lbl_score.Text = "Score Total"
        '
        'txtbox_score
        '
        Me.txtbox_score.Enabled = False
        Me.txtbox_score.Location = New System.Drawing.Point(77, 53)
        Me.txtbox_score.Name = "txtbox_score"
        Me.txtbox_score.Size = New System.Drawing.Size(100, 22)
        Me.txtbox_score.TabIndex = 1
        Me.txtbox_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_10
        '
        Me.lbl_10.AutoSize = True
        Me.lbl_10.Location = New System.Drawing.Point(197, 56)
        Me.lbl_10.Name = "lbl_10"
        Me.lbl_10.Size = New System.Drawing.Size(32, 17)
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
        Me.groupbox_categories.Location = New System.Drawing.Point(66, 103)
        Me.groupbox_categories.Name = "groupbox_categories"
        Me.groupbox_categories.Size = New System.Drawing.Size(262, 325)
        Me.groupbox_categories.TabIndex = 3
        Me.groupbox_categories.TabStop = False
        Me.groupbox_categories.Text = "% par Categorie"
        '
        'lbl_lec
        '
        Me.lbl_lec.AutoSize = True
        Me.lbl_lec.Location = New System.Drawing.Point(24, 271)
        Me.lbl_lec.Name = "lbl_lec"
        Me.lbl_lec.Size = New System.Drawing.Size(99, 17)
        Me.lbl_lec.TabIndex = 11
        Me.lbl_lec.Text = "Lecture Heure"
        '
        'txtbox_ponc
        '
        Me.txtbox_ponc.Enabled = False
        Me.txtbox_ponc.Location = New System.Drawing.Point(134, 154)
        Me.txtbox_ponc.Name = "txtbox_ponc"
        Me.txtbox_ponc.Size = New System.Drawing.Size(55, 22)
        Me.txtbox_ponc.TabIndex = 10
        Me.txtbox_ponc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ponct
        '
        Me.lbl_ponct.AutoSize = True
        Me.lbl_ponct.Location = New System.Drawing.Point(19, 154)
        Me.lbl_ponct.Name = "lbl_ponct"
        Me.lbl_ponct.Size = New System.Drawing.Size(83, 17)
        Me.lbl_ponct.TabIndex = 9
        Me.lbl_ponct.Text = "Ponctuation"
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(29, 35)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(70, 17)
        Me.lbl_français.TabIndex = 8
        Me.lbl_français.Text = "Français"
        '
        'txtbox_lec
        '
        Me.txtbox_lec.Enabled = False
        Me.txtbox_lec.Location = New System.Drawing.Point(134, 271)
        Me.txtbox_lec.Name = "txtbox_lec"
        Me.txtbox_lec.Size = New System.Drawing.Size(55, 22)
        Me.txtbox_lec.TabIndex = 7
        Me.txtbox_lec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_ari
        '
        Me.txtbox_ari.Enabled = False
        Me.txtbox_ari.Location = New System.Drawing.Point(134, 232)
        Me.txtbox_ari.Name = "txtbox_ari"
        Me.txtbox_ari.Size = New System.Drawing.Size(55, 22)
        Me.txtbox_ari.TabIndex = 6
        Me.txtbox_ari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_voc
        '
        Me.txtbox_voc.Enabled = False
        Me.txtbox_voc.Location = New System.Drawing.Point(134, 113)
        Me.txtbox_voc.Name = "txtbox_voc"
        Me.txtbox_voc.Size = New System.Drawing.Size(55, 22)
        Me.txtbox_voc.TabIndex = 5
        Me.txtbox_voc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_gram
        '
        Me.txtbox_gram.Enabled = False
        Me.txtbox_gram.Location = New System.Drawing.Point(134, 71)
        Me.txtbox_gram.Name = "txtbox_gram"
        Me.txtbox_gram.Size = New System.Drawing.Size(55, 22)
        Me.txtbox_gram.TabIndex = 4
        Me.txtbox_gram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ari
        '
        Me.lbl_ari.AutoSize = True
        Me.lbl_ari.Location = New System.Drawing.Point(24, 232)
        Me.lbl_ari.Name = "lbl_ari"
        Me.lbl_ari.Size = New System.Drawing.Size(87, 17)
        Me.lbl_ari.TabIndex = 3
        Me.lbl_ari.Text = "Arithmétique"
        '
        'lbl_math
        '
        Me.lbl_math.AutoSize = True
        Me.lbl_math.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_math.Location = New System.Drawing.Point(29, 193)
        Me.lbl_math.Name = "lbl_math"
        Me.lbl_math.Size = New System.Drawing.Size(43, 17)
        Me.lbl_math.TabIndex = 2
        Me.lbl_math.Text = "Math"
        '
        'lbl_voc
        '
        Me.lbl_voc.AutoSize = True
        Me.lbl_voc.Location = New System.Drawing.Point(19, 113)
        Me.lbl_voc.Name = "lbl_voc"
        Me.lbl_voc.Size = New System.Drawing.Size(83, 17)
        Me.lbl_voc.TabIndex = 1
        Me.lbl_voc.Text = "Vocabulaire"
        '
        'lbl_gram
        '
        Me.lbl_gram.AutoSize = True
        Me.lbl_gram.Location = New System.Drawing.Point(21, 71)
        Me.lbl_gram.Name = "lbl_gram"
        Me.lbl_gram.Size = New System.Drawing.Size(78, 17)
        Me.lbl_gram.TabIndex = 0
        Me.lbl_gram.Text = "Grammaire"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(493, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Conseils"
        '
        'listbox_conseils
        '
        Me.listbox_conseils.Enabled = False
        Me.listbox_conseils.FormattingEnabled = True
        Me.listbox_conseils.ItemHeight = 16
        Me.listbox_conseils.Location = New System.Drawing.Point(423, 103)
        Me.listbox_conseils.Name = "listbox_conseils"
        Me.listbox_conseils.Size = New System.Drawing.Size(217, 324)
        Me.listbox_conseils.TabIndex = 7
        '
        'cmd_Quitter
        '
        Me.cmd_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Quitter.Location = New System.Drawing.Point(293, 471)
        Me.cmd_Quitter.Name = "cmd_Quitter"
        Me.cmd_Quitter.Size = New System.Drawing.Size(128, 38)
        Me.cmd_Quitter.TabIndex = 8
        Me.cmd_Quitter.Text = "Terminer "
        Me.cmd_Quitter.UseVisualStyleBackColor = True
        '
        'Resultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(761, 537)
        Me.Controls.Add(Me.cmd_Quitter)
        Me.Controls.Add(Me.listbox_conseils)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.groupbox_categories)
        Me.Controls.Add(Me.lbl_10)
        Me.Controls.Add(Me.txtbox_score)
        Me.Controls.Add(Me.lbl_score)
        Me.Name = "Resultat"
        Me.Text = "Resultats"
        Me.groupbox_categories.ResumeLayout(False)
        Me.groupbox_categories.PerformLayout()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents listbox_conseils As ListBox
    Friend WithEvents lbl_lec As Label
    Friend WithEvents cmd_Quitter As Button
End Class

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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listbox_conseils = New System.Windows.Forms.ListBox()
        Me.cmd_Quitter = New System.Windows.Forms.Button()
        Me.Chart_Resultats = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.GroupBox_duree = New System.Windows.Forms.GroupBox()
        Me.groupbox_categories.SuspendLayout()
        CType(Me.Chart_Resultats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_duree.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(168, 14)
        Me.lbl_score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(175, 33)
        Me.lbl_score.TabIndex = 0
        Me.lbl_score.Text = "Score Total"
        '
        'txtbox_score
        '
        Me.txtbox_score.Enabled = False
        Me.txtbox_score.Location = New System.Drawing.Point(116, 83)
        Me.txtbox_score.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_score.Name = "txtbox_score"
        Me.txtbox_score.Size = New System.Drawing.Size(148, 31)
        Me.txtbox_score.TabIndex = 1
        Me.txtbox_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_10
        '
        Me.lbl_10.AutoSize = True
        Me.lbl_10.Location = New System.Drawing.Point(296, 88)
        Me.lbl_10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_10.Name = "lbl_10"
        Me.lbl_10.Size = New System.Drawing.Size(48, 25)
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
        Me.groupbox_categories.Location = New System.Drawing.Point(99, 161)
        Me.groupbox_categories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupbox_categories.Name = "groupbox_categories"
        Me.groupbox_categories.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupbox_categories.Size = New System.Drawing.Size(393, 508)
        Me.groupbox_categories.TabIndex = 3
        Me.groupbox_categories.TabStop = False
        Me.groupbox_categories.Text = "% par Categorie"
        '
        'lbl_lec
        '
        Me.lbl_lec.AutoSize = True
        Me.lbl_lec.Location = New System.Drawing.Point(36, 423)
        Me.lbl_lec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_lec.Name = "lbl_lec"
        Me.lbl_lec.Size = New System.Drawing.Size(148, 25)
        Me.lbl_lec.TabIndex = 11
        Me.lbl_lec.Text = "Lecture Heure"
        '
        'txtbox_ponc
        '
        Me.txtbox_ponc.Enabled = False
        Me.txtbox_ponc.Location = New System.Drawing.Point(201, 241)
        Me.txtbox_ponc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_ponc.Name = "txtbox_ponc"
        Me.txtbox_ponc.Size = New System.Drawing.Size(80, 31)
        Me.txtbox_ponc.TabIndex = 10
        Me.txtbox_ponc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ponct
        '
        Me.lbl_ponct.AutoSize = True
        Me.lbl_ponct.Location = New System.Drawing.Point(28, 241)
        Me.lbl_ponct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ponct.Name = "lbl_ponct"
        Me.lbl_ponct.Size = New System.Drawing.Size(126, 25)
        Me.lbl_ponct.TabIndex = 9
        Me.lbl_ponct.Text = "Ponctuation"
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(44, 55)
        Me.lbl_français.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(103, 25)
        Me.lbl_français.TabIndex = 8
        Me.lbl_français.Text = "Français"
        '
        'txtbox_lec
        '
        Me.txtbox_lec.Enabled = False
        Me.txtbox_lec.Location = New System.Drawing.Point(201, 423)
        Me.txtbox_lec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_lec.Name = "txtbox_lec"
        Me.txtbox_lec.Size = New System.Drawing.Size(80, 31)
        Me.txtbox_lec.TabIndex = 7
        Me.txtbox_lec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_ari
        '
        Me.txtbox_ari.Enabled = False
        Me.txtbox_ari.Location = New System.Drawing.Point(201, 362)
        Me.txtbox_ari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_ari.Name = "txtbox_ari"
        Me.txtbox_ari.Size = New System.Drawing.Size(80, 31)
        Me.txtbox_ari.TabIndex = 6
        Me.txtbox_ari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_voc
        '
        Me.txtbox_voc.Enabled = False
        Me.txtbox_voc.Location = New System.Drawing.Point(201, 177)
        Me.txtbox_voc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_voc.Name = "txtbox_voc"
        Me.txtbox_voc.Size = New System.Drawing.Size(80, 31)
        Me.txtbox_voc.TabIndex = 5
        Me.txtbox_voc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_gram
        '
        Me.txtbox_gram.Enabled = False
        Me.txtbox_gram.Location = New System.Drawing.Point(201, 111)
        Me.txtbox_gram.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_gram.Name = "txtbox_gram"
        Me.txtbox_gram.Size = New System.Drawing.Size(80, 31)
        Me.txtbox_gram.TabIndex = 4
        Me.txtbox_gram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ari
        '
        Me.lbl_ari.AutoSize = True
        Me.lbl_ari.Location = New System.Drawing.Point(36, 362)
        Me.lbl_ari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ari.Name = "lbl_ari"
        Me.lbl_ari.Size = New System.Drawing.Size(132, 25)
        Me.lbl_ari.TabIndex = 3
        Me.lbl_ari.Text = "Arithmétique"
        '
        'lbl_math
        '
        Me.lbl_math.AutoSize = True
        Me.lbl_math.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_math.Location = New System.Drawing.Point(44, 302)
        Me.lbl_math.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_math.Name = "lbl_math"
        Me.lbl_math.Size = New System.Drawing.Size(64, 25)
        Me.lbl_math.TabIndex = 2
        Me.lbl_math.Text = "Math"
        '
        'lbl_voc
        '
        Me.lbl_voc.AutoSize = True
        Me.lbl_voc.Location = New System.Drawing.Point(28, 177)
        Me.lbl_voc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_voc.Name = "lbl_voc"
        Me.lbl_voc.Size = New System.Drawing.Size(126, 25)
        Me.lbl_voc.TabIndex = 1
        Me.lbl_voc.Text = "Vocabulaire"
        '
        'lbl_gram
        '
        Me.lbl_gram.AutoSize = True
        Me.lbl_gram.Location = New System.Drawing.Point(32, 111)
        Me.lbl_gram.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_gram.Name = "lbl_gram"
        Me.lbl_gram.Size = New System.Drawing.Size(117, 25)
        Me.lbl_gram.TabIndex = 0
        Me.lbl_gram.Text = "Grammaire"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1398, 83)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 29)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Conseils"
        '
        'listbox_conseils
        '
        Me.listbox_conseils.Enabled = False
        Me.listbox_conseils.FormattingEnabled = True
        Me.listbox_conseils.ItemHeight = 25
        Me.listbox_conseils.Location = New System.Drawing.Point(1299, 162)
        Me.listbox_conseils.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listbox_conseils.Name = "listbox_conseils"
        Me.listbox_conseils.Size = New System.Drawing.Size(324, 504)
        Me.listbox_conseils.TabIndex = 7
        '
        'cmd_Quitter
        '
        Me.cmd_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Quitter.Location = New System.Drawing.Point(440, 736)
        Me.cmd_Quitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Quitter.Name = "cmd_Quitter"
        Me.cmd_Quitter.Size = New System.Drawing.Size(192, 59)
        Me.cmd_Quitter.TabIndex = 8
        Me.cmd_Quitter.Text = "Terminer "
        Me.cmd_Quitter.UseVisualStyleBackColor = True
        '
        'Chart_Resultats
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart_Resultats.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart_Resultats.Legends.Add(Legend2)
        Me.Chart_Resultats.Location = New System.Drawing.Point(534, 253)
        Me.Chart_Resultats.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart_Resultats.Name = "Chart_Resultats"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Categories"
        Me.Chart_Resultats.Series.Add(Series2)
        Me.Chart_Resultats.Size = New System.Drawing.Size(681, 358)
        Me.Chart_Resultats.TabIndex = 9
        Me.Chart_Resultats.Text = "Chart_Resultats"
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_min.Location = New System.Drawing.Point(35, 45)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 37)
        Me.lbl_min.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec.Location = New System.Drawing.Point(141, 45)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 37)
        Me.lbl_sec.TabIndex = 13
        '
        'GroupBox_duree
        '
        Me.GroupBox_duree.Controls.Add(Me.Label1)
        Me.GroupBox_duree.Controls.Add(Me.lbl_sec)
        Me.GroupBox_duree.Controls.Add(Me.lbl_min)
        Me.GroupBox_duree.Location = New System.Drawing.Point(916, 61)
        Me.GroupBox_duree.Name = "GroupBox_duree"
        Me.GroupBox_duree.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_duree.TabIndex = 14
        Me.GroupBox_duree.TabStop = False
        Me.GroupBox_duree.Text = "Durée du test"
        '
        'Resultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1726, 855)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox_duree)
        Me.Controls.Add(Me.Chart_Resultats)
        Me.Controls.Add(Me.cmd_Quitter)
        Me.Controls.Add(Me.listbox_conseils)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.groupbox_categories)
        Me.Controls.Add(Me.lbl_10)
        Me.Controls.Add(Me.txtbox_score)
        Me.Controls.Add(Me.lbl_score)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Resultat"
        Me.Text = "Resultats"
        Me.groupbox_categories.ResumeLayout(False)
        Me.groupbox_categories.PerformLayout()
        CType(Me.Chart_Resultats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_duree.ResumeLayout(False)
        Me.GroupBox_duree.PerformLayout()
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
    Friend WithEvents Chart_Resultats As DataVisualization.Charting.Chart
    Friend WithEvents lbl_min As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents GroupBox_duree As GroupBox
End Class

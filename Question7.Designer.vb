<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question7
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question7))
        Me.lblQ7 = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_mot1 = New System.Windows.Forms.Label()
        Me.lbl_mot2 = New System.Windows.Forms.Label()
        Me.lbl_mot3 = New System.Windows.Forms.Label()
        Me.lbl_mot4 = New System.Windows.Forms.Label()
        Me.lbl_mot5 = New System.Windows.Forms.Label()
        Me.lbl_mot6 = New System.Windows.Forms.Label()
        Me.lbl_mot7 = New System.Windows.Forms.Label()
        Me.txtbox_mot1 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot2 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot3 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot4 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot5 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot6 = New System.Windows.Forms.TextBox()
        Me.txtbox_mot7 = New System.Windows.Forms.TextBox()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.lbl_français = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.TimerQ7 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ7
        '
        Me.lblQ7.AutoSize = True
        Me.lblQ7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ7.Location = New System.Drawing.Point(70, 41)
        Me.lblQ7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQ7.Name = "lblQ7"
        Me.lblQ7.Size = New System.Drawing.Size(209, 42)
        Me.lblQ7.TabIndex = 1
        Me.lblQ7.Text = "Question 7"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(72, 112)
        Me.lbl_consigne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(842, 32)
        Me.lbl_consigne.TabIndex = 2
        Me.lbl_consigne.Text = "Remets les mots suivants dans l'ordre pour constituer une phrase."
        '
        'lbl_mot1
        '
        Me.lbl_mot1.AutoSize = True
        Me.lbl_mot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot1.Location = New System.Drawing.Point(136, 222)
        Me.lbl_mot1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot1.Name = "lbl_mot1"
        Me.lbl_mot1.Size = New System.Drawing.Size(55, 27)
        Me.lbl_mot1.TabIndex = 3
        Me.lbl_mot1.Text = "chat"
        '
        'lbl_mot2
        '
        Me.lbl_mot2.AutoSize = True
        Me.lbl_mot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot2.Location = New System.Drawing.Point(273, 222)
        Me.lbl_mot2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot2.Name = "lbl_mot2"
        Me.lbl_mot2.Size = New System.Drawing.Size(101, 27)
        Me.lbl_mot2.TabIndex = 4
        Me.lbl_mot2.Text = "blanches"
        '
        'lbl_mot3
        '
        Me.lbl_mot3.AutoSize = True
        Me.lbl_mot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot3.Location = New System.Drawing.Point(466, 222)
        Me.lbl_mot3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot3.Name = "lbl_mot3"
        Me.lbl_mot3.Size = New System.Drawing.Size(49, 27)
        Me.lbl_mot3.TabIndex = 5
        Me.lbl_mot3.Text = "Les"
        '
        'lbl_mot4
        '
        Me.lbl_mot4.AutoSize = True
        Me.lbl_mot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot4.Location = New System.Drawing.Point(628, 222)
        Me.lbl_mot4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot4.Name = "lbl_mot4"
        Me.lbl_mot4.Size = New System.Drawing.Size(55, 27)
        Me.lbl_mot4.TabIndex = 6
        Me.lbl_mot4.Text = "sont"
        '
        'lbl_mot5
        '
        Me.lbl_mot5.AutoSize = True
        Me.lbl_mot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot5.Location = New System.Drawing.Point(794, 222)
        Me.lbl_mot5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot5.Name = "lbl_mot5"
        Me.lbl_mot5.Size = New System.Drawing.Size(73, 27)
        Me.lbl_mot5.TabIndex = 7
        Me.lbl_mot5.Text = "pattes"
        '
        'lbl_mot6
        '
        Me.lbl_mot6.AutoSize = True
        Me.lbl_mot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot6.Location = New System.Drawing.Point(960, 222)
        Me.lbl_mot6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot6.Name = "lbl_mot6"
        Me.lbl_mot6.Size = New System.Drawing.Size(55, 27)
        Me.lbl_mot6.TabIndex = 8
        Me.lbl_mot6.Text = "mon"
        '
        'lbl_mot7
        '
        Me.lbl_mot7.AutoSize = True
        Me.lbl_mot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot7.Location = New System.Drawing.Point(1137, 222)
        Me.lbl_mot7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mot7.Name = "lbl_mot7"
        Me.lbl_mot7.Size = New System.Drawing.Size(38, 27)
        Me.lbl_mot7.TabIndex = 9
        Me.lbl_mot7.Text = "de"
        '
        'txtbox_mot1
        '
        Me.txtbox_mot1.Enabled = False
        Me.txtbox_mot1.Location = New System.Drawing.Point(105, 353)
        Me.txtbox_mot1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot1.Name = "txtbox_mot1"
        Me.txtbox_mot1.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot1.TabIndex = 10
        '
        'txtbox_mot2
        '
        Me.txtbox_mot2.Enabled = False
        Me.txtbox_mot2.Location = New System.Drawing.Point(273, 353)
        Me.txtbox_mot2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot2.Name = "txtbox_mot2"
        Me.txtbox_mot2.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot2.TabIndex = 11
        '
        'txtbox_mot3
        '
        Me.txtbox_mot3.Enabled = False
        Me.txtbox_mot3.Location = New System.Drawing.Point(440, 353)
        Me.txtbox_mot3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot3.Name = "txtbox_mot3"
        Me.txtbox_mot3.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot3.TabIndex = 12
        '
        'txtbox_mot4
        '
        Me.txtbox_mot4.Enabled = False
        Me.txtbox_mot4.Location = New System.Drawing.Point(606, 353)
        Me.txtbox_mot4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot4.Name = "txtbox_mot4"
        Me.txtbox_mot4.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot4.TabIndex = 13
        '
        'txtbox_mot5
        '
        Me.txtbox_mot5.Enabled = False
        Me.txtbox_mot5.Location = New System.Drawing.Point(772, 353)
        Me.txtbox_mot5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot5.Name = "txtbox_mot5"
        Me.txtbox_mot5.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot5.TabIndex = 14
        '
        'txtbox_mot6
        '
        Me.txtbox_mot6.Enabled = False
        Me.txtbox_mot6.Location = New System.Drawing.Point(936, 353)
        Me.txtbox_mot6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot6.Name = "txtbox_mot6"
        Me.txtbox_mot6.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot6.TabIndex = 15
        '
        'txtbox_mot7
        '
        Me.txtbox_mot7.Enabled = False
        Me.txtbox_mot7.Location = New System.Drawing.Point(1101, 353)
        Me.txtbox_mot7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_mot7.Name = "txtbox_mot7"
        Me.txtbox_mot7.Size = New System.Drawing.Size(108, 31)
        Me.txtbox_mot7.TabIndex = 16
        '
        'cmd_Back
        '
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Back.Location = New System.Drawing.Point(78, 506)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Back.TabIndex = 17
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = True
        '
        'cmd_Next
        '
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Next.Location = New System.Drawing.Point(1124, 506)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Next.TabIndex = 18
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = True
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(549, 506)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 19
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(602, 506)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 20
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(666, 506)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 21
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(483, 564)
        Me.lbl_français.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(285, 32)
        Me.lbl_français.TabIndex = 22
        Me.lbl_français.Text = "Question de Français"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(1167, 41)
        Me.lbl_NumQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 23
        Me.lbl_NumQ.Text = "7/10"
        Me.lbl_NumQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(1124, 89)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(125, 36)
        Me.cmd_Aide.TabIndex = 24
        Me.cmd_Aide.Text = "Instruction"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'TimerQ7
        '
        Me.TimerQ7.Interval = 1000
        '
        'Question7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1302, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_français)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.txtbox_mot7)
        Me.Controls.Add(Me.txtbox_mot6)
        Me.Controls.Add(Me.txtbox_mot5)
        Me.Controls.Add(Me.txtbox_mot4)
        Me.Controls.Add(Me.txtbox_mot3)
        Me.Controls.Add(Me.txtbox_mot2)
        Me.Controls.Add(Me.txtbox_mot1)
        Me.Controls.Add(Me.lbl_mot7)
        Me.Controls.Add(Me.lbl_mot6)
        Me.Controls.Add(Me.lbl_mot5)
        Me.Controls.Add(Me.lbl_mot4)
        Me.Controls.Add(Me.lbl_mot3)
        Me.Controls.Add(Me.lbl_mot2)
        Me.Controls.Add(Me.lbl_mot1)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lblQ7)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Question7"
        Me.Text = "Question 7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ7 As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_mot1 As Label
    Friend WithEvents lbl_mot2 As Label
    Friend WithEvents lbl_mot3 As Label
    Friend WithEvents lbl_mot4 As Label
    Friend WithEvents lbl_mot5 As Label
    Friend WithEvents lbl_mot6 As Label
    Friend WithEvents lbl_mot7 As Label
    Friend WithEvents txtbox_mot1 As TextBox
    Friend WithEvents txtbox_mot2 As TextBox
    Friend WithEvents txtbox_mot3 As TextBox
    Friend WithEvents txtbox_mot4 As TextBox
    Friend WithEvents txtbox_mot5 As TextBox
    Friend WithEvents txtbox_mot6 As TextBox
    Friend WithEvents txtbox_mot7 As TextBox
    Friend WithEvents cmd_Back As Button
    Friend WithEvents cmd_Next As Button
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents lbl_français As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents cmd_Aide As Button
    Friend WithEvents TimerQ7 As Timer
End Class

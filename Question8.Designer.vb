<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question8))
        Me.lblQ8 = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_enonce1 = New System.Windows.Forms.Label()
        Me.lbl_enonce2 = New System.Windows.Forms.Label()
        Me.rb_option3 = New System.Windows.Forms.RadioButton()
        Me.rb_option2 = New System.Windows.Forms.RadioButton()
        Me.rb_option1 = New System.Windows.Forms.RadioButton()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.lbl_français = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.TimerQ8 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ8
        '
        Me.lblQ8.AutoSize = True
        Me.lblQ8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ8.Location = New System.Drawing.Point(68, 53)
        Me.lblQ8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQ8.Name = "lblQ8"
        Me.lblQ8.Size = New System.Drawing.Size(209, 42)
        Me.lblQ8.TabIndex = 1
        Me.lblQ8.Text = "Question 8"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(69, 123)
        Me.lbl_consigne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(330, 32)
        Me.lbl_consigne.TabIndex = 3
        Me.lbl_consigne.Text = "Choisi la bonne réponse."
        '
        'lbl_enonce1
        '
        Me.lbl_enonce1.AutoSize = True
        Me.lbl_enonce1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enonce1.Location = New System.Drawing.Point(69, 180)
        Me.lbl_enonce1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_enonce1.Name = "lbl_enonce1"
        Me.lbl_enonce1.Size = New System.Drawing.Size(770, 32)
        Me.lbl_enonce1.TabIndex = 4
        Me.lbl_enonce1.Text = "Maman partage 12 pommes également entre ses 3 enfants. "
        '
        'lbl_enonce2
        '
        Me.lbl_enonce2.AutoSize = True
        Me.lbl_enonce2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enonce2.Location = New System.Drawing.Point(69, 231)
        Me.lbl_enonce2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_enonce2.Name = "lbl_enonce2"
        Me.lbl_enonce2.Size = New System.Drawing.Size(603, 32)
        Me.lbl_enonce2.TabIndex = 5
        Me.lbl_enonce2.Text = "- Combien de pommes chaque enfant reçoit-il?"
        '
        'rb_option3
        '
        Me.rb_option3.AutoSize = True
        Me.rb_option3.Image = Global.ProjetNF22.My.Resources.Resources._4pommes
        Me.rb_option3.Location = New System.Drawing.Point(752, 320)
        Me.rb_option3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_option3.Name = "rb_option3"
        Me.rb_option3.Size = New System.Drawing.Size(147, 100)
        Me.rb_option3.TabIndex = 8
        Me.rb_option3.TabStop = True
        Me.rb_option3.UseVisualStyleBackColor = True
        '
        'rb_option2
        '
        Me.rb_option2.AutoSize = True
        Me.rb_option2.Image = Global.ProjetNF22.My.Resources.Resources._3pommes
        Me.rb_option2.Location = New System.Drawing.Point(402, 320)
        Me.rb_option2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_option2.Name = "rb_option2"
        Me.rb_option2.Size = New System.Drawing.Size(147, 100)
        Me.rb_option2.TabIndex = 7
        Me.rb_option2.TabStop = True
        Me.rb_option2.UseVisualStyleBackColor = True
        '
        'rb_option1
        '
        Me.rb_option1.AutoSize = True
        Me.rb_option1.Image = Global.ProjetNF22.My.Resources.Resources._2pommes
        Me.rb_option1.Location = New System.Drawing.Point(75, 320)
        Me.rb_option1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rb_option1.Name = "rb_option1"
        Me.rb_option1.Size = New System.Drawing.Size(147, 100)
        Me.rb_option1.TabIndex = 6
        Me.rb_option1.TabStop = True
        Me.rb_option1.UseVisualStyleBackColor = True
        '
        'cmd_Next
        '
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Next.Location = New System.Drawing.Point(933, 575)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Next.TabIndex = 5
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = True
        '
        'cmd_Back
        '
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Back.Location = New System.Drawing.Point(75, 575)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Back.TabIndex = 20
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = True
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(471, 575)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 21
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(532, 575)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 22
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(606, 575)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 23
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(382, 634)
        Me.lbl_français.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(357, 32)
        Me.lbl_français.TabIndex = 24
        Me.lbl_français.Text = "Question de Mathématique"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(976, 53)
        Me.lbl_NumQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 25
        Me.lbl_NumQ.Text = "8/10"
        Me.lbl_NumQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(948, 102)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(112, 36)
        Me.cmd_Aide.TabIndex = 26
        Me.cmd_Aide.Text = "Aide"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'TimerQ8
        '
        Me.TimerQ8.Interval = 1000
        '
        'Question8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1131, 688)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_français)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.rb_option3)
        Me.Controls.Add(Me.rb_option2)
        Me.Controls.Add(Me.rb_option1)
        Me.Controls.Add(Me.lbl_enonce2)
        Me.Controls.Add(Me.lbl_enonce1)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lblQ8)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Question8"
        Me.Text = "Question 8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ8 As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_enonce1 As Label
    Friend WithEvents lbl_enonce2 As Label
    Friend WithEvents rb_option1 As RadioButton
    Friend WithEvents rb_option2 As RadioButton
    Friend WithEvents rb_option3 As RadioButton
    Friend WithEvents cmd_Next As Button
    Friend WithEvents cmd_Back As Button
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents lbl_français As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents cmd_Aide As Button
    Friend WithEvents TimerQ8 As Timer
End Class

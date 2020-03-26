<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question5
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
        Me.lblQ5 = New System.Windows.Forms.Label()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.lbl_Francais = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_phrase = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.TimerQ5 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQ5
        '
        Me.lblQ5.AutoSize = True
        Me.lblQ5.BackColor = System.Drawing.Color.Transparent
        Me.lblQ5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ5.Location = New System.Drawing.Point(44, 31)
        Me.lblQ5.Name = "lblQ5"
        Me.lblQ5.Size = New System.Drawing.Size(209, 42)
        Me.lblQ5.TabIndex = 4
        Me.lblQ5.Text = "Question 5"
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.White
        Me.cmd_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_back.Image = Global.ProjetNF22.My.Resources.Resources.left_arrow
        Me.cmd_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_back.Location = New System.Drawing.Point(12, 345)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(100, 94)
        Me.cmd_back.TabIndex = 7
        Me.cmd_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'cmd_next
        '
        Me.cmd_next.BackColor = System.Drawing.Color.White
        Me.cmd_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_next.Location = New System.Drawing.Point(682, 341)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_next.TabIndex = 8
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'lbl_Francais
        '
        Me.lbl_Francais.AutoSize = True
        Me.lbl_Francais.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Francais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Francais.Location = New System.Drawing.Point(272, 403)
        Me.lbl_Francais.Name = "lbl_Francais"
        Me.lbl_Francais.Size = New System.Drawing.Size(263, 31)
        Me.lbl_Francais.TabIndex = 9
        Me.lbl_Francais.Text = "Question de français"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(732, 9)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 10
        Me.lbl_NumQ.Text = "5/10"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(44, 103)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(411, 31)
        Me.lbl_consigne.TabIndex = 11
        Me.lbl_consigne.Text = "Quel est le pluriel de cet animal ?"
        '
        'lbl_phrase
        '
        Me.lbl_phrase.AutoSize = True
        Me.lbl_phrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phrase.Location = New System.Drawing.Point(158, 205)
        Me.lbl_phrase.Name = "lbl_phrase"
        Me.lbl_phrase.Size = New System.Drawing.Size(218, 31)
        Me.lbl_phrase.TabIndex = 12
        Me.lbl_phrase.Text = "Un cheval -> des"
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(381, 202)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(188, 38)
        Me.TextBox.TabIndex = 13
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(346, 359)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 14
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(376, 359)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 15
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(417, 359)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 16
        '
        'TimerQ5
        '
        Me.TimerQ5.Interval = 1000
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(675, 56)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(119, 36)
        Me.cmd_Aide.TabIndex = 31
        Me.cmd_Aide.Text = "Instruction"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'Question5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.lbl_phrase)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_Francais)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_back)
        Me.Controls.Add(Me.lblQ5)
        Me.Name = "Question5"
        Me.Text = "Question5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ5 As Label
    Friend WithEvents cmd_back As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents lbl_Francais As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_phrase As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents TimerQ5 As Timer
    Friend WithEvents cmd_Aide As Button
End Class

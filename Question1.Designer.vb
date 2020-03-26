<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question1))
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lbl_Francais = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.rep1 = New System.Windows.Forms.RadioButton()
        Me.rep2 = New System.Windows.Forms.RadioButton()
        Me.rep3 = New System.Windows.Forms.RadioButton()
        Me.rep4 = New System.Windows.Forms.RadioButton()
        Me.lbl_coq = New System.Windows.Forms.Label()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.TimerQ1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(38, 31)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(209, 42)
        Me.lblQ1.TabIndex = 0
        Me.lblQ1.Text = "Question 1"
        '
        'lbl_Francais
        '
        Me.lbl_Francais.AutoSize = True
        Me.lbl_Francais.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Francais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Francais.Location = New System.Drawing.Point(249, 405)
        Me.lbl_Francais.Name = "lbl_Francais"
        Me.lbl_Francais.Size = New System.Drawing.Size(263, 31)
        Me.lbl_Francais.TabIndex = 12
        Me.lbl_Francais.Text = "Question de français"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(732, 9)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 13
        Me.lbl_NumQ.Text = "1/10"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(40, 91)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(347, 31)
        Me.lbl_consigne.TabIndex = 1
        Me.lbl_consigne.Text = "Quel est le féminin du coq ?"
        '
        'rep1
        '
        Me.rep1.AutoSize = True
        Me.rep1.Location = New System.Drawing.Point(268, 148)
        Me.rep1.Name = "rep1"
        Me.rep1.Size = New System.Drawing.Size(144, 29)
        Me.rep1.TabIndex = 4
        Me.rep1.TabStop = True
        Me.rep1.Text = "une coque"
        Me.rep1.UseVisualStyleBackColor = True
        '
        'rep2
        '
        Me.rep2.AutoSize = True
        Me.rep2.Location = New System.Drawing.Point(268, 183)
        Me.rep2.Name = "rep2"
        Me.rep2.Size = New System.Drawing.Size(138, 29)
        Me.rep2.TabIndex = 5
        Me.rep2.TabStop = True
        Me.rep2.Text = "une poule"
        Me.rep2.UseVisualStyleBackColor = True
        '
        'rep3
        '
        Me.rep3.AutoSize = True
        Me.rep3.Location = New System.Drawing.Point(268, 219)
        Me.rep3.Name = "rep3"
        Me.rep3.Size = New System.Drawing.Size(120, 29)
        Me.rep3.TabIndex = 6
        Me.rep3.TabStop = True
        Me.rep3.Text = "une coq"
        Me.rep3.UseVisualStyleBackColor = True
        '
        'rep4
        '
        Me.rep4.AutoSize = True
        Me.rep4.Location = New System.Drawing.Point(268, 253)
        Me.rep4.Name = "rep4"
        Me.rep4.Size = New System.Drawing.Size(156, 29)
        Me.rep4.TabIndex = 7
        Me.rep4.TabStop = True
        Me.rep4.Text = "une canette"
        Me.rep4.UseVisualStyleBackColor = True
        '
        'lbl_coq
        '
        Me.lbl_coq.AutoSize = True
        Me.lbl_coq.Location = New System.Drawing.Point(144, 148)
        Me.lbl_coq.Name = "lbl_coq"
        Me.lbl_coq.Size = New System.Drawing.Size(102, 25)
        Me.lbl_coq.TabIndex = 2
        Me.lbl_coq.Text = "un coq ->"
        '
        'cmd_next
        '
        Me.cmd_next.BackColor = System.Drawing.Color.White
        Me.cmd_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_next.Image = CType(resources.GetObject("cmd_next.Image"), System.Drawing.Image)
        Me.cmd_next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_next.Location = New System.Drawing.Point(687, 348)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_next.TabIndex = 3
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'TimerQ1
        '
        Me.TimerQ1.Interval = 1000
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(326, 348)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 8
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(406, 348)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 9
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(370, 348)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 10
        Me.lbl_2points.Text = ":"
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(665, 58)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(122, 36)
        Me.cmd_Aide.TabIndex = 31
        Me.cmd_Aide.Text = "Instruction"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'Question1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.lbl_coq)
        Me.Controls.Add(Me.rep4)
        Me.Controls.Add(Me.rep3)
        Me.Controls.Add(Me.rep2)
        Me.Controls.Add(Me.rep1)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_Francais)
        Me.Controls.Add(Me.lblQ1)
        Me.Name = "Question1"
        Me.Text = "Question1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ1 As Label
    Friend WithEvents lbl_Francais As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents cmd_next As Button
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents rep1 As RadioButton
    Friend WithEvents rep2 As RadioButton
    Friend WithEvents rep3 As RadioButton
    Friend WithEvents rep4 As RadioButton
    Friend WithEvents lbl_coq As Label
    Friend WithEvents TimerQ1 As Timer
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents cmd_Aide As Button
End Class

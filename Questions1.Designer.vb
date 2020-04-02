<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Questions1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Questions1))
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ3 = New System.Windows.Forms.Label()
        Me.lbl_NumQ1 = New System.Windows.Forms.Label()
        Me.lbl_consigneQ1 = New System.Windows.Forms.Label()
        Me.lbl_consigneQ2 = New System.Windows.Forms.Label()
        Me.lbl_consigneQ3 = New System.Windows.Forms.Label()
        Me.lbl_coq = New System.Windows.Forms.Label()
        Me.rb_option1 = New System.Windows.Forms.RadioButton()
        Me.rb_option2 = New System.Windows.Forms.RadioButton()
        Me.rb_option3 = New System.Windows.Forms.RadioButton()
        Me.rb_option4 = New System.Windows.Forms.RadioButton()
        Me.cmd_aideQ1 = New System.Windows.Forms.Button()
        Me.cmd_aideQ2 = New System.Windows.Forms.Button()
        Me.cb_Q2 = New System.Windows.Forms.ComboBox()
        Me.lbl_phrase2 = New System.Windows.Forms.Label()
        Me.lbl_phrase1 = New System.Windows.Forms.Label()
        Me.txtbox_Q3 = New System.Windows.Forms.TextBox()
        Me.lbl_phraseQ3 = New System.Windows.Forms.Label()
        Me.cmd_aideQ3 = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_deuxpt = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.TimerQ1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(50, 30)
        Me.lblQ1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(142, 35)
        Me.lblQ1.TabIndex = 0
        Me.lblQ1.Text = "Question 1"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.BackColor = System.Drawing.Color.Transparent
        Me.lblQ2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ2.Location = New System.Drawing.Point(50, 265)
        Me.lblQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(142, 35)
        Me.lblQ2.TabIndex = 8
        Me.lblQ2.Text = "Question 2"
        '
        'lblQ3
        '
        Me.lblQ3.AutoSize = True
        Me.lblQ3.BackColor = System.Drawing.Color.Transparent
        Me.lblQ3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ3.Location = New System.Drawing.Point(50, 398)
        Me.lblQ3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ3.Name = "lblQ3"
        Me.lblQ3.Size = New System.Drawing.Size(142, 35)
        Me.lblQ3.TabIndex = 14
        Me.lblQ3.Text = "Question 3"
        '
        'lbl_NumQ1
        '
        Me.lbl_NumQ1.AutoSize = True
        Me.lbl_NumQ1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumQ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_NumQ1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumQ1.Location = New System.Drawing.Point(460, 30)
        Me.lbl_NumQ1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NumQ1.Name = "lbl_NumQ1"
        Me.lbl_NumQ1.Size = New System.Drawing.Size(46, 30)
        Me.lbl_NumQ1.TabIndex = 20
        Me.lbl_NumQ1.Text = "1/5"
        '
        'lbl_consigneQ1
        '
        Me.lbl_consigneQ1.AutoSize = True
        Me.lbl_consigneQ1.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ1.Location = New System.Drawing.Point(75, 80)
        Me.lbl_consigneQ1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_consigneQ1.Name = "lbl_consigneQ1"
        Me.lbl_consigneQ1.Size = New System.Drawing.Size(259, 27)
        Me.lbl_consigneQ1.TabIndex = 2
        Me.lbl_consigneQ1.Text = "Quel est le féminin du coq ?"
        '
        'lbl_consigneQ2
        '
        Me.lbl_consigneQ2.AutoSize = True
        Me.lbl_consigneQ2.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ2.Location = New System.Drawing.Point(75, 315)
        Me.lbl_consigneQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_consigneQ2.Name = "lbl_consigneQ2"
        Me.lbl_consigneQ2.Size = New System.Drawing.Size(223, 27)
        Me.lbl_consigneQ2.TabIndex = 10
        Me.lbl_consigneQ2.Text = "Complète cette phrase: "
        '
        'lbl_consigneQ3
        '
        Me.lbl_consigneQ3.AutoSize = True
        Me.lbl_consigneQ3.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ3.Location = New System.Drawing.Point(75, 448)
        Me.lbl_consigneQ3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_consigneQ3.Name = "lbl_consigneQ3"
        Me.lbl_consigneQ3.Size = New System.Drawing.Size(308, 27)
        Me.lbl_consigneQ3.TabIndex = 16
        Me.lbl_consigneQ3.Text = "Quel est le pluriel de cet animal ?"
        '
        'lbl_coq
        '
        Me.lbl_coq.AutoSize = True
        Me.lbl_coq.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_coq.Location = New System.Drawing.Point(100, 115)
        Me.lbl_coq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_coq.Name = "lbl_coq"
        Me.lbl_coq.Size = New System.Drawing.Size(80, 24)
        Me.lbl_coq.TabIndex = 3
        Me.lbl_coq.Text = "un coq ->"
        '
        'rb_option1
        '
        Me.rb_option1.AutoSize = True
        Me.rb_option1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_option1.Location = New System.Drawing.Point(180, 115)
        Me.rb_option1.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_option1.Name = "rb_option1"
        Me.rb_option1.Size = New System.Drawing.Size(111, 28)
        Me.rb_option1.TabIndex = 4
        Me.rb_option1.TabStop = True
        Me.rb_option1.Text = "une coque"
        Me.rb_option1.UseVisualStyleBackColor = True
        '
        'rb_option2
        '
        Me.rb_option2.AutoSize = True
        Me.rb_option2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_option2.Location = New System.Drawing.Point(180, 150)
        Me.rb_option2.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_option2.Name = "rb_option2"
        Me.rb_option2.Size = New System.Drawing.Size(107, 28)
        Me.rb_option2.TabIndex = 5
        Me.rb_option2.TabStop = True
        Me.rb_option2.Text = "une poule"
        Me.rb_option2.UseVisualStyleBackColor = True
        '
        'rb_option3
        '
        Me.rb_option3.AutoSize = True
        Me.rb_option3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_option3.Location = New System.Drawing.Point(180, 185)
        Me.rb_option3.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_option3.Name = "rb_option3"
        Me.rb_option3.Size = New System.Drawing.Size(92, 28)
        Me.rb_option3.TabIndex = 6
        Me.rb_option3.TabStop = True
        Me.rb_option3.Text = "une coq"
        Me.rb_option3.UseVisualStyleBackColor = True
        '
        'rb_option4
        '
        Me.rb_option4.AutoSize = True
        Me.rb_option4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_option4.Location = New System.Drawing.Point(180, 220)
        Me.rb_option4.Margin = New System.Windows.Forms.Padding(2)
        Me.rb_option4.Name = "rb_option4"
        Me.rb_option4.Size = New System.Drawing.Size(127, 28)
        Me.rb_option4.TabIndex = 7
        Me.rb_option4.TabStop = True
        Me.rb_option4.Text = "une canette"
        Me.rb_option4.UseVisualStyleBackColor = True
        '
        'cmd_aideQ1
        '
        Me.cmd_aideQ1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ1.Location = New System.Drawing.Point(180, 32)
        Me.cmd_aideQ1.Name = "cmd_aideQ1"
        Me.cmd_aideQ1.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ1.TabIndex = 1
        Me.cmd_aideQ1.Text = "Instruction"
        Me.cmd_aideQ1.UseVisualStyleBackColor = False
        '
        'cmd_aideQ2
        '
        Me.cmd_aideQ2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ2.Location = New System.Drawing.Point(180, 267)
        Me.cmd_aideQ2.Name = "cmd_aideQ2"
        Me.cmd_aideQ2.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ2.TabIndex = 9
        Me.cmd_aideQ2.Text = "Instruction"
        Me.cmd_aideQ2.UseVisualStyleBackColor = False
        '
        'cb_Q2
        '
        Me.cb_Q2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Q2.FormattingEnabled = True
        Me.cb_Q2.Items.AddRange(New Object() {"et", "est", "ait"})
        Me.cb_Q2.Location = New System.Drawing.Point(185, 348)
        Me.cb_Q2.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Q2.Name = "cb_Q2"
        Me.cb_Q2.Size = New System.Drawing.Size(80, 32)
        Me.cb_Q2.TabIndex = 12
        '
        'lbl_phrase2
        '
        Me.lbl_phrase2.AutoSize = True
        Me.lbl_phrase2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phrase2.Location = New System.Drawing.Point(268, 350)
        Me.lbl_phrase2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_phrase2.Name = "lbl_phrase2"
        Me.lbl_phrase2.Size = New System.Drawing.Size(127, 24)
        Me.lbl_phrase2.TabIndex = 13
        Me.lbl_phrase2.Text = " dans le jardin."
        '
        'lbl_phrase1
        '
        Me.lbl_phrase1.AutoSize = True
        Me.lbl_phrase1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phrase1.Location = New System.Drawing.Point(100, 350)
        Me.lbl_phrase1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_phrase1.Name = "lbl_phrase1"
        Me.lbl_phrase1.Size = New System.Drawing.Size(90, 24)
        Me.lbl_phrase1.TabIndex = 11
        Me.lbl_phrase1.Text = "Mon chien"
        '
        'txtbox_Q3
        '
        Me.txtbox_Q3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Q3.Location = New System.Drawing.Point(240, 488)
        Me.txtbox_Q3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbox_Q3.Name = "txtbox_Q3"
        Me.txtbox_Q3.Size = New System.Drawing.Size(125, 31)
        Me.txtbox_Q3.TabIndex = 18
        '
        'lbl_phraseQ3
        '
        Me.lbl_phraseQ3.AutoSize = True
        Me.lbl_phraseQ3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phraseQ3.Location = New System.Drawing.Point(100, 490)
        Me.lbl_phraseQ3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_phraseQ3.Name = "lbl_phraseQ3"
        Me.lbl_phraseQ3.Size = New System.Drawing.Size(139, 24)
        Me.lbl_phraseQ3.TabIndex = 17
        Me.lbl_phraseQ3.Text = "Un cheval -> des"
        '
        'cmd_aideQ3
        '
        Me.cmd_aideQ3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ3.Location = New System.Drawing.Point(180, 400)
        Me.cmd_aideQ3.Name = "cmd_aideQ3"
        Me.cmd_aideQ3.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ3.TabIndex = 15
        Me.cmd_aideQ3.Text = "Instruction"
        Me.cmd_aideQ3.UseVisualStyleBackColor = False
        '
        'cmd_next
        '
        Me.cmd_next.BackColor = System.Drawing.Color.White
        Me.cmd_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_next.Image = CType(resources.GetObject("cmd_next.Image"), System.Drawing.Image)
        Me.cmd_next.Location = New System.Drawing.Point(460, 460)
        Me.cmd_next.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(60, 60)
        Me.cmd_next.TabIndex = 19
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.BackColor = System.Drawing.Color.Transparent
        Me.lbl_min.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_min.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_min.Location = New System.Drawing.Point(410, 77)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(2, 30)
        Me.lbl_min.TabIndex = 21
        '
        'lbl_deuxpt
        '
        Me.lbl_deuxpt.AutoSize = True
        Me.lbl_deuxpt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_deuxpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_deuxpt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deuxpt.Location = New System.Drawing.Point(445, 77)
        Me.lbl_deuxpt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_deuxpt.Name = "lbl_deuxpt"
        Me.lbl_deuxpt.Size = New System.Drawing.Size(20, 30)
        Me.lbl_deuxpt.TabIndex = 22
        Me.lbl_deuxpt.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sec.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sec.Location = New System.Drawing.Point(465, 77)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(2, 30)
        Me.lbl_sec.TabIndex = 23
        '
        'TimerQ1
        '
        Me.TimerQ1.Interval = 1000
        '
        'Questions1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(578, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_deuxpt)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_aideQ3)
        Me.Controls.Add(Me.txtbox_Q3)
        Me.Controls.Add(Me.lbl_phraseQ3)
        Me.Controls.Add(Me.cb_Q2)
        Me.Controls.Add(Me.lbl_phrase2)
        Me.Controls.Add(Me.lbl_phrase1)
        Me.Controls.Add(Me.cmd_aideQ2)
        Me.Controls.Add(Me.cmd_aideQ1)
        Me.Controls.Add(Me.rb_option4)
        Me.Controls.Add(Me.rb_option3)
        Me.Controls.Add(Me.rb_option2)
        Me.Controls.Add(Me.rb_option1)
        Me.Controls.Add(Me.lbl_coq)
        Me.Controls.Add(Me.lbl_consigneQ3)
        Me.Controls.Add(Me.lbl_consigneQ2)
        Me.Controls.Add(Me.lbl_consigneQ1)
        Me.Controls.Add(Me.lbl_NumQ1)
        Me.Controls.Add(Me.lblQ3)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblQ1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Questions1"
        Me.Text = "Questions de français"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ1 As Label
    Friend WithEvents lblQ2 As Label
    Friend WithEvents lblQ3 As Label
    Friend WithEvents lbl_NumQ1 As Label
    Friend WithEvents lbl_consigneQ1 As Label
    Friend WithEvents lbl_consigneQ2 As Label
    Friend WithEvents lbl_consigneQ3 As Label
    Friend WithEvents lbl_coq As Label
    Friend WithEvents rb_option1 As RadioButton
    Friend WithEvents rb_option2 As RadioButton
    Friend WithEvents rb_option3 As RadioButton
    Friend WithEvents rb_option4 As RadioButton
    Friend WithEvents cmd_aideQ1 As Button
    Friend WithEvents cmd_aideQ2 As Button
    Friend WithEvents cb_Q2 As ComboBox
    Friend WithEvents lbl_phrase2 As Label
    Friend WithEvents lbl_phrase1 As Label
    Friend WithEvents txtbox_Q3 As TextBox
    Friend WithEvents lbl_phraseQ3 As Label
    Friend WithEvents cmd_aideQ3 As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_deuxpt As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents TimerQ1 As Timer
End Class

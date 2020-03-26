<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question10))
        Me.lblQ10 = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_chiffres = New System.Windows.Forms.Label()
        Me.lbl_30 = New System.Windows.Forms.Label()
        Me.lbl_somme1 = New System.Windows.Forms.Label()
        Me.lbl_30000 = New System.Windows.Forms.Label()
        Me.lbl_7 = New System.Windows.Forms.Label()
        Me.lbl_7000 = New System.Windows.Forms.Label()
        Me.lbl_700 = New System.Windows.Forms.Label()
        Me.lbl_somme2 = New System.Windows.Forms.Label()
        Me.lbl_somme3 = New System.Windows.Forms.Label()
        Me.lbl_somme4 = New System.Windows.Forms.Label()
        Me.lbl_somme5 = New System.Windows.Forms.Label()
        Me.lbl_9 = New System.Windows.Forms.Label()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.lbl_français = New System.Windows.Forms.Label()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.TimerQ10 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ10
        '
        Me.lblQ10.AutoSize = True
        Me.lblQ10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ10.Location = New System.Drawing.Point(63, 42)
        Me.lblQ10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQ10.Name = "lblQ10"
        Me.lblQ10.Size = New System.Drawing.Size(231, 42)
        Me.lblQ10.TabIndex = 1
        Me.lblQ10.Text = "Question 10"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(64, 114)
        Me.lbl_consigne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(658, 32)
        Me.lbl_consigne.TabIndex = 4
        Me.lbl_consigne.Text = "Choisi les nombres de la décomposition de 30 739."
        '
        'lbl_chiffres
        '
        Me.lbl_chiffres.AutoSize = True
        Me.lbl_chiffres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chiffres.Location = New System.Drawing.Point(118, 198)
        Me.lbl_chiffres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_chiffres.Name = "lbl_chiffres"
        Me.lbl_chiffres.Size = New System.Drawing.Size(144, 33)
        Me.lbl_chiffres.TabIndex = 5
        Me.lbl_chiffres.Text = "30 739  = "
        '
        'lbl_30
        '
        Me.lbl_30.AutoSize = True
        Me.lbl_30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_30.Location = New System.Drawing.Point(402, 202)
        Me.lbl_30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_30.Name = "lbl_30"
        Me.lbl_30.Size = New System.Drawing.Size(47, 32)
        Me.lbl_30.TabIndex = 6
        Me.lbl_30.Text = "30"
        '
        'lbl_somme1
        '
        Me.lbl_somme1.AutoSize = True
        Me.lbl_somme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme1.Location = New System.Drawing.Point(362, 198)
        Me.lbl_somme1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somme1.Name = "lbl_somme1"
        Me.lbl_somme1.Size = New System.Drawing.Size(32, 33)
        Me.lbl_somme1.TabIndex = 7
        Me.lbl_somme1.Text = "+"
        '
        'lbl_30000
        '
        Me.lbl_30000.AutoSize = True
        Me.lbl_30000.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_30000.Location = New System.Drawing.Point(250, 202)
        Me.lbl_30000.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_30000.Name = "lbl_30000"
        Me.lbl_30000.Size = New System.Drawing.Size(102, 32)
        Me.lbl_30000.TabIndex = 8
        Me.lbl_30000.Text = "30 000"
        '
        'lbl_7
        '
        Me.lbl_7.AutoSize = True
        Me.lbl_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7.Location = New System.Drawing.Point(516, 202)
        Me.lbl_7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(31, 32)
        Me.lbl_7.TabIndex = 9
        Me.lbl_7.Text = "7"
        '
        'lbl_7000
        '
        Me.lbl_7000.AutoSize = True
        Me.lbl_7000.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7000.Location = New System.Drawing.Point(608, 202)
        Me.lbl_7000.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_7000.Name = "lbl_7000"
        Me.lbl_7000.Size = New System.Drawing.Size(86, 32)
        Me.lbl_7000.TabIndex = 10
        Me.lbl_7000.Text = "7 000"
        '
        'lbl_700
        '
        Me.lbl_700.AutoSize = True
        Me.lbl_700.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_700.Location = New System.Drawing.Point(764, 202)
        Me.lbl_700.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_700.Name = "lbl_700"
        Me.lbl_700.Size = New System.Drawing.Size(63, 32)
        Me.lbl_700.TabIndex = 11
        Me.lbl_700.Text = "700"
        '
        'lbl_somme2
        '
        Me.lbl_somme2.AutoSize = True
        Me.lbl_somme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme2.Location = New System.Drawing.Point(476, 198)
        Me.lbl_somme2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somme2.Name = "lbl_somme2"
        Me.lbl_somme2.Size = New System.Drawing.Size(32, 33)
        Me.lbl_somme2.TabIndex = 12
        Me.lbl_somme2.Text = "+"
        '
        'lbl_somme3
        '
        Me.lbl_somme3.AutoSize = True
        Me.lbl_somme3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme3.Location = New System.Drawing.Point(567, 198)
        Me.lbl_somme3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somme3.Name = "lbl_somme3"
        Me.lbl_somme3.Size = New System.Drawing.Size(32, 33)
        Me.lbl_somme3.TabIndex = 13
        Me.lbl_somme3.Text = "+"
        '
        'lbl_somme4
        '
        Me.lbl_somme4.AutoSize = True
        Me.lbl_somme4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme4.Location = New System.Drawing.Point(705, 198)
        Me.lbl_somme4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somme4.Name = "lbl_somme4"
        Me.lbl_somme4.Size = New System.Drawing.Size(32, 33)
        Me.lbl_somme4.TabIndex = 14
        Me.lbl_somme4.Text = "+"
        '
        'lbl_somme5
        '
        Me.lbl_somme5.AutoSize = True
        Me.lbl_somme5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme5.Location = New System.Drawing.Point(840, 198)
        Me.lbl_somme5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_somme5.Name = "lbl_somme5"
        Me.lbl_somme5.Size = New System.Drawing.Size(32, 33)
        Me.lbl_somme5.TabIndex = 15
        Me.lbl_somme5.Text = "+"
        '
        'lbl_9
        '
        Me.lbl_9.AutoSize = True
        Me.lbl_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_9.Location = New System.Drawing.Point(888, 202)
        Me.lbl_9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_9.Name = "lbl_9"
        Me.lbl_9.Size = New System.Drawing.Size(31, 32)
        Me.lbl_9.TabIndex = 16
        Me.lbl_9.Text = "9"
        '
        'cmd_Next
        '
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Next.Location = New System.Drawing.Point(802, 347)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Next.TabIndex = 17
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = True
        '
        'cmd_Back
        '
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Back.Location = New System.Drawing.Point(70, 347)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Back.TabIndex = 21
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = True
        '
        'lbl_français
        '
        Me.lbl_français.AutoSize = True
        Me.lbl_français.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_français.Location = New System.Drawing.Point(300, 406)
        Me.lbl_français.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_français.Name = "lbl_français"
        Me.lbl_français.Size = New System.Drawing.Size(357, 32)
        Me.lbl_français.TabIndex = 25
        Me.lbl_français.Text = "Question de Mathématique"
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(442, 347)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 26
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(465, 347)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 27
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(494, 347)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 28
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(846, 42)
        Me.lbl_NumQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(68, 27)
        Me.lbl_NumQ.TabIndex = 29
        Me.lbl_NumQ.Text = "10/10"
        Me.lbl_NumQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(812, 91)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(120, 36)
        Me.cmd_Aide.TabIndex = 30
        Me.cmd_Aide.Text = "Instruction"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'TimerQ10
        '
        Me.TimerQ10.Interval = 1000
        '
        'Question10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(982, 483)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.lbl_français)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.lbl_9)
        Me.Controls.Add(Me.lbl_somme5)
        Me.Controls.Add(Me.lbl_somme4)
        Me.Controls.Add(Me.lbl_somme3)
        Me.Controls.Add(Me.lbl_somme2)
        Me.Controls.Add(Me.lbl_700)
        Me.Controls.Add(Me.lbl_7000)
        Me.Controls.Add(Me.lbl_7)
        Me.Controls.Add(Me.lbl_30000)
        Me.Controls.Add(Me.lbl_somme1)
        Me.Controls.Add(Me.lbl_30)
        Me.Controls.Add(Me.lbl_chiffres)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lblQ10)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Question10"
        Me.Text = "Question10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ10 As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_chiffres As Label
    Friend WithEvents lbl_30 As Label
    Friend WithEvents lbl_somme1 As Label
    Friend WithEvents lbl_30000 As Label
    Friend WithEvents lbl_7 As Label
    Friend WithEvents lbl_7000 As Label
    Friend WithEvents lbl_700 As Label
    Friend WithEvents lbl_somme2 As Label
    Friend WithEvents lbl_somme3 As Label
    Friend WithEvents lbl_somme4 As Label
    Friend WithEvents lbl_somme5 As Label
    Friend WithEvents lbl_9 As Label
    Friend WithEvents cmd_Next As Button
    Friend WithEvents cmd_Back As Button
    Friend WithEvents lbl_français As Label
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents cmd_Aide As Button
    Friend WithEvents TimerQ10 As Timer
End Class

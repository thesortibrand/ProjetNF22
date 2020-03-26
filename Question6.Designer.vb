<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question6))
        Me.lblQ6 = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.lbl_Math = New System.Windows.Forms.Label()
        Me.Panel_reponse = New System.Windows.Forms.Panel()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.pb_horloge2 = New System.Windows.Forms.PictureBox()
        Me.pb_horloge1 = New System.Windows.Forms.PictureBox()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.TimerQ6 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_Aide = New System.Windows.Forms.Button()
        CType(Me.pb_horloge2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_horloge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQ6
        '
        Me.lblQ6.AutoSize = True
        Me.lblQ6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ6.Location = New System.Drawing.Point(74, 41)
        Me.lblQ6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQ6.Name = "lblQ6"
        Me.lblQ6.Size = New System.Drawing.Size(209, 42)
        Me.lblQ6.TabIndex = 0
        Me.lblQ6.Text = "Question 6"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(75, 114)
        Me.lbl_consigne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(357, 32)
        Me.lbl_consigne.TabIndex = 1
        Me.lbl_consigne.Text = "Quel est la bonne horloge?"
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Location = New System.Drawing.Point(184, 625)
        Me.lbl_heure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(157, 25)
        Me.lbl_heure.TabIndex = 5
        Me.lbl_heure.Text = "Il est 7h 45 min"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(992, 41)
        Me.lbl_NumQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 7
        Me.lbl_NumQ.Text = "6/10"
        Me.lbl_NumQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Math
        '
        Me.lbl_Math.AutoSize = True
        Me.lbl_Math.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Math.Location = New System.Drawing.Point(405, 886)
        Me.lbl_Math.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Math.Name = "lbl_Math"
        Me.lbl_Math.Size = New System.Drawing.Size(357, 32)
        Me.lbl_Math.TabIndex = 8
        Me.lbl_Math.Text = "Question de Mathématique"
        '
        'Panel_reponse
        '
        Me.Panel_reponse.AutoSize = True
        Me.Panel_reponse.BackColor = System.Drawing.Color.White
        Me.Panel_reponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_reponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_reponse.Location = New System.Drawing.Point(81, 228)
        Me.Panel_reponse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel_reponse.Name = "Panel_reponse"
        Me.Panel_reponse.Size = New System.Drawing.Size(350, 347)
        Me.Panel_reponse.TabIndex = 11
        '
        'cmd_Next
        '
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Next.Location = New System.Drawing.Point(948, 827)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Next.TabIndex = 10
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = True
        '
        'cmd_Back
        '
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_Back.Location = New System.Drawing.Point(81, 827)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(100, 94)
        Me.cmd_Back.TabIndex = 9
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = True
        '
        'pb_horloge2
        '
        Me.pb_horloge2.BackColor = System.Drawing.SystemColors.Control
        Me.pb_horloge2.Image = Global.ProjetNF22.My.Resources.Resources.heure2
        Me.pb_horloge2.Location = New System.Drawing.Point(537, 114)
        Me.pb_horloge2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb_horloge2.Name = "pb_horloge2"
        Me.pb_horloge2.Size = New System.Drawing.Size(150, 150)
        Me.pb_horloge2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_horloge2.TabIndex = 3
        Me.pb_horloge2.TabStop = False
        '
        'pb_horloge1
        '
        Me.pb_horloge1.BackColor = System.Drawing.SystemColors.Control
        Me.pb_horloge1.Image = Global.ProjetNF22.My.Resources.Resources.heure1
        Me.pb_horloge1.Location = New System.Drawing.Point(537, 486)
        Me.pb_horloge1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pb_horloge1.Name = "pb_horloge1"
        Me.pb_horloge1.Size = New System.Drawing.Size(150, 150)
        Me.pb_horloge1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_horloge1.TabIndex = 2
        Me.pb_horloge1.TabStop = False
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(495, 827)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 15
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(532, 827)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 16
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(580, 827)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 17
        '
        'TimerQ6
        '
        Me.TimerQ6.Interval = 1000
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(948, 109)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(126, 36)
        Me.cmd_Aide.TabIndex = 18
        Me.cmd_Aide.Text = "Instruction"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'Question6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1112, 939)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.Panel_reponse)
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.lbl_Math)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lbl_heure)
        Me.Controls.Add(Me.pb_horloge2)
        Me.Controls.Add(Me.pb_horloge1)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lblQ6)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Question6"
        Me.Text = "Question 6"
        CType(Me.pb_horloge2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_horloge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ6 As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents pb_horloge1 As PictureBox
    Friend WithEvents pb_horloge2 As PictureBox
    Friend WithEvents lbl_heure As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents lbl_Math As Label
    Friend WithEvents cmd_Back As Button
    Friend WithEvents cmd_Next As Button
    Friend WithEvents Panel_reponse As Panel
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents TimerQ6 As Timer
    Friend WithEvents cmd_Aide As Button
End Class

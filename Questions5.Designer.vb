<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Questions5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Questions5))
        Me.lbl_consigneQ10 = New System.Windows.Forms.Label()
        Me.lbl_heure = New System.Windows.Forms.Label()
        Me.Panel_reponse = New System.Windows.Forms.Panel()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.pb_horloge2 = New System.Windows.Forms.PictureBox()
        Me.pb_horloge1 = New System.Windows.Forms.PictureBox()
        Me.TimerQ5 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_secQ10 = New System.Windows.Forms.Label()
        Me.lbl_deuxptQ10 = New System.Windows.Forms.Label()
        Me.lbl_minQ10 = New System.Windows.Forms.Label()
        Me.lbl_NumQ5 = New System.Windows.Forms.Label()
        Me.lblQ10 = New System.Windows.Forms.Label()
        Me.cmd_aideQ10 = New System.Windows.Forms.Button()
        CType(Me.pb_horloge2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_horloge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_consigneQ10
        '
        Me.lbl_consigneQ10.AutoSize = True
        Me.lbl_consigneQ10.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ10.Location = New System.Drawing.Point(50, 80)
        Me.lbl_consigneQ10.Name = "lbl_consigneQ10"
        Me.lbl_consigneQ10.Size = New System.Drawing.Size(262, 27)
        Me.lbl_consigneQ10.TabIndex = 2
        Me.lbl_consigneQ10.Text = "Quelle est la bonne horloge?"
        '
        'lbl_heure
        '
        Me.lbl_heure.AutoSize = True
        Me.lbl_heure.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heure.Location = New System.Drawing.Point(150, 450)
        Me.lbl_heure.Name = "lbl_heure"
        Me.lbl_heure.Size = New System.Drawing.Size(139, 21)
        Me.lbl_heure.TabIndex = 5
        Me.lbl_heure.Text = "Il est 7 h 45 min"
        '
        'Panel_reponse
        '
        Me.Panel_reponse.AutoSize = True
        Me.Panel_reponse.BackColor = System.Drawing.Color.White
        Me.Panel_reponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_reponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_reponse.Location = New System.Drawing.Point(100, 160)
        Me.Panel_reponse.Name = "Panel_reponse"
        Me.Panel_reponse.Size = New System.Drawing.Size(234, 251)
        Me.Panel_reponse.TabIndex = 4
        '
        'cmd_Next
        '
        Me.cmd_Next.BackColor = System.Drawing.Color.White
        Me.cmd_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.terminer
        Me.cmd_Next.Location = New System.Drawing.Point(632, 540)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(67, 68)
        Me.cmd_Next.TabIndex = 6
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = False
        '
        'cmd_Back
        '
        Me.cmd_Back.BackColor = System.Drawing.Color.White
        Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(50, 540)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(67, 68)
        Me.cmd_Back.TabIndex = 7
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = False
        '
        'pb_horloge2
        '
        Me.pb_horloge2.BackColor = System.Drawing.SystemColors.Control
        Me.pb_horloge2.Image = Global.ProjetNF22.My.Resources.Resources.heure2
        Me.pb_horloge2.Location = New System.Drawing.Point(410, 80)
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
        Me.pb_horloge1.Location = New System.Drawing.Point(410, 350)
        Me.pb_horloge1.Name = "pb_horloge1"
        Me.pb_horloge1.Size = New System.Drawing.Size(150, 150)
        Me.pb_horloge1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_horloge1.TabIndex = 2
        Me.pb_horloge1.TabStop = False
        '
        'TimerQ5
        '
        Me.TimerQ5.Interval = 1000
        '
        'lbl_secQ10
        '
        Me.lbl_secQ10.AutoSize = True
        Me.lbl_secQ10.BackColor = System.Drawing.Color.Transparent
        Me.lbl_secQ10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_secQ10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secQ10.Location = New System.Drawing.Point(658, 83)
        Me.lbl_secQ10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_secQ10.Name = "lbl_secQ10"
        Me.lbl_secQ10.Size = New System.Drawing.Size(2, 30)
        Me.lbl_secQ10.TabIndex = 11
        '
        'lbl_deuxptQ10
        '
        Me.lbl_deuxptQ10.AutoSize = True
        Me.lbl_deuxptQ10.BackColor = System.Drawing.Color.Transparent
        Me.lbl_deuxptQ10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_deuxptQ10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deuxptQ10.Location = New System.Drawing.Point(638, 83)
        Me.lbl_deuxptQ10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_deuxptQ10.Name = "lbl_deuxptQ10"
        Me.lbl_deuxptQ10.Size = New System.Drawing.Size(20, 30)
        Me.lbl_deuxptQ10.TabIndex = 10
        Me.lbl_deuxptQ10.Text = ":"
        '
        'lbl_minQ10
        '
        Me.lbl_minQ10.AutoSize = True
        Me.lbl_minQ10.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minQ10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_minQ10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minQ10.Location = New System.Drawing.Point(603, 83)
        Me.lbl_minQ10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_minQ10.Name = "lbl_minQ10"
        Me.lbl_minQ10.Size = New System.Drawing.Size(2, 30)
        Me.lbl_minQ10.TabIndex = 9
        '
        'lbl_NumQ5
        '
        Me.lbl_NumQ5.AutoSize = True
        Me.lbl_NumQ5.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumQ5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_NumQ5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumQ5.Location = New System.Drawing.Point(653, 30)
        Me.lbl_NumQ5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NumQ5.Name = "lbl_NumQ5"
        Me.lbl_NumQ5.Size = New System.Drawing.Size(49, 30)
        Me.lbl_NumQ5.TabIndex = 8
        Me.lbl_NumQ5.Text = "5/5"
        '
        'lblQ10
        '
        Me.lblQ10.AutoSize = True
        Me.lblQ10.BackColor = System.Drawing.Color.Transparent
        Me.lblQ10.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ10.Location = New System.Drawing.Point(50, 30)
        Me.lblQ10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ10.Name = "lblQ10"
        Me.lblQ10.Size = New System.Drawing.Size(157, 35)
        Me.lblQ10.TabIndex = 0
        Me.lblQ10.Text = "Question 10"
        '
        'cmd_aideQ10
        '
        Me.cmd_aideQ10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ10.Location = New System.Drawing.Point(180, 32)
        Me.cmd_aideQ10.Name = "cmd_aideQ10"
        Me.cmd_aideQ10.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ10.TabIndex = 1
        Me.cmd_aideQ10.Text = "Instruction"
        Me.cmd_aideQ10.UseVisualStyleBackColor = False
        '
        'Questions5
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(728, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_aideQ10)
        Me.Controls.Add(Me.lblQ10)
        Me.Controls.Add(Me.lbl_secQ10)
        Me.Controls.Add(Me.lbl_deuxptQ10)
        Me.Controls.Add(Me.lbl_minQ10)
        Me.Controls.Add(Me.lbl_NumQ5)
        Me.Controls.Add(Me.Panel_reponse)
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.lbl_heure)
        Me.Controls.Add(Me.pb_horloge2)
        Me.Controls.Add(Me.pb_horloge1)
        Me.Controls.Add(Me.lbl_consigneQ10)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Questions5"
        Me.Text = "Questions de Mathématiques"
        CType(Me.pb_horloge2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_horloge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_consigneQ10 As Label
    Friend WithEvents pb_horloge1 As PictureBox
    Friend WithEvents pb_horloge2 As PictureBox
    Friend WithEvents lbl_heure As Label
    Friend WithEvents cmd_Back As Button
    Friend WithEvents cmd_Next As Button
    Friend WithEvents Panel_reponse As Panel
    Friend WithEvents TimerQ5 As Timer
    Friend WithEvents lbl_secQ10 As Label
    Friend WithEvents lbl_deuxptQ10 As Label
    Friend WithEvents lbl_minQ10 As Label
    Friend WithEvents lbl_NumQ5 As Label
    Friend WithEvents lblQ10 As Label
    Friend WithEvents cmd_aideQ10 As Button
End Class

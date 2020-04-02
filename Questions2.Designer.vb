<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questions2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Questions2))
        Me.lblQ4 = New System.Windows.Forms.Label()
        Me.lbl_consigneQ4 = New System.Windows.Forms.Label()
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
        Me.TimerQ2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_NumQ2 = New System.Windows.Forms.Label()
        Me.cmd_aideQ4 = New System.Windows.Forms.Button()
        Me.lbl_secQ2 = New System.Windows.Forms.Label()
        Me.lbl_deuxptQ2 = New System.Windows.Forms.Label()
        Me.lbl_minQ2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQ4
        '
        Me.lblQ4.AutoSize = True
        Me.lblQ4.BackColor = System.Drawing.Color.Transparent
        Me.lblQ4.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ4.Location = New System.Drawing.Point(50, 30)
        Me.lblQ4.Name = "lblQ4"
        Me.lblQ4.Size = New System.Drawing.Size(142, 35)
        Me.lblQ4.TabIndex = 0
        Me.lblQ4.Text = "Question 4"
        '
        'lbl_consigneQ4
        '
        Me.lbl_consigneQ4.AutoSize = True
        Me.lbl_consigneQ4.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ4.Location = New System.Drawing.Point(75, 80)
        Me.lbl_consigneQ4.Name = "lbl_consigneQ4"
        Me.lbl_consigneQ4.Size = New System.Drawing.Size(594, 27)
        Me.lbl_consigneQ4.TabIndex = 2
        Me.lbl_consigneQ4.Text = "Remets les mots suivants dans l'ordre pour constituer une phrase."
        '
        'lbl_mot1
        '
        Me.lbl_mot1.AutoSize = True
        Me.lbl_mot1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot1.Location = New System.Drawing.Point(90, 150)
        Me.lbl_mot1.Name = "lbl_mot1"
        Me.lbl_mot1.Size = New System.Drawing.Size(39, 21)
        Me.lbl_mot1.TabIndex = 3
        Me.lbl_mot1.Text = "chat"
        '
        'lbl_mot2
        '
        Me.lbl_mot2.AutoSize = True
        Me.lbl_mot2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot2.Location = New System.Drawing.Point(185, 150)
        Me.lbl_mot2.Name = "lbl_mot2"
        Me.lbl_mot2.Size = New System.Drawing.Size(66, 21)
        Me.lbl_mot2.TabIndex = 4
        Me.lbl_mot2.Text = "blanches"
        '
        'lbl_mot3
        '
        Me.lbl_mot3.AutoSize = True
        Me.lbl_mot3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot3.Location = New System.Drawing.Point(315, 150)
        Me.lbl_mot3.Name = "lbl_mot3"
        Me.lbl_mot3.Size = New System.Drawing.Size(34, 21)
        Me.lbl_mot3.TabIndex = 5
        Me.lbl_mot3.Text = "Les"
        '
        'lbl_mot4
        '
        Me.lbl_mot4.AutoSize = True
        Me.lbl_mot4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot4.Location = New System.Drawing.Point(420, 150)
        Me.lbl_mot4.Name = "lbl_mot4"
        Me.lbl_mot4.Size = New System.Drawing.Size(39, 21)
        Me.lbl_mot4.TabIndex = 6
        Me.lbl_mot4.Text = "sont"
        '
        'lbl_mot5
        '
        Me.lbl_mot5.AutoSize = True
        Me.lbl_mot5.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot5.Location = New System.Drawing.Point(525, 150)
        Me.lbl_mot5.Name = "lbl_mot5"
        Me.lbl_mot5.Size = New System.Drawing.Size(54, 21)
        Me.lbl_mot5.TabIndex = 7
        Me.lbl_mot5.Text = "pattes"
        '
        'lbl_mot6
        '
        Me.lbl_mot6.AutoSize = True
        Me.lbl_mot6.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot6.Location = New System.Drawing.Point(645, 150)
        Me.lbl_mot6.Name = "lbl_mot6"
        Me.lbl_mot6.Size = New System.Drawing.Size(36, 21)
        Me.lbl_mot6.TabIndex = 8
        Me.lbl_mot6.Text = "mon"
        '
        'lbl_mot7
        '
        Me.lbl_mot7.AutoSize = True
        Me.lbl_mot7.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mot7.Location = New System.Drawing.Point(760, 150)
        Me.lbl_mot7.Name = "lbl_mot7"
        Me.lbl_mot7.Size = New System.Drawing.Size(27, 21)
        Me.lbl_mot7.TabIndex = 9
        Me.lbl_mot7.Text = "de"
        '
        'txtbox_mot1
        '
        Me.txtbox_mot1.Enabled = False
        Me.txtbox_mot1.Location = New System.Drawing.Point(75, 250)
        Me.txtbox_mot1.Name = "txtbox_mot1"
        Me.txtbox_mot1.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot1.TabIndex = 10
        '
        'txtbox_mot2
        '
        Me.txtbox_mot2.Enabled = False
        Me.txtbox_mot2.Location = New System.Drawing.Point(180, 250)
        Me.txtbox_mot2.Name = "txtbox_mot2"
        Me.txtbox_mot2.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot2.TabIndex = 11
        '
        'txtbox_mot3
        '
        Me.txtbox_mot3.Enabled = False
        Me.txtbox_mot3.Location = New System.Drawing.Point(292, 250)
        Me.txtbox_mot3.Name = "txtbox_mot3"
        Me.txtbox_mot3.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot3.TabIndex = 12
        '
        'txtbox_mot4
        '
        Me.txtbox_mot4.Enabled = False
        Me.txtbox_mot4.Location = New System.Drawing.Point(405, 250)
        Me.txtbox_mot4.Name = "txtbox_mot4"
        Me.txtbox_mot4.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot4.TabIndex = 13
        '
        'txtbox_mot5
        '
        Me.txtbox_mot5.Enabled = False
        Me.txtbox_mot5.Location = New System.Drawing.Point(515, 250)
        Me.txtbox_mot5.Name = "txtbox_mot5"
        Me.txtbox_mot5.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot5.TabIndex = 14
        '
        'txtbox_mot6
        '
        Me.txtbox_mot6.Enabled = False
        Me.txtbox_mot6.Location = New System.Drawing.Point(625, 250)
        Me.txtbox_mot6.Name = "txtbox_mot6"
        Me.txtbox_mot6.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot6.TabIndex = 15
        '
        'txtbox_mot7
        '
        Me.txtbox_mot7.Enabled = False
        Me.txtbox_mot7.Location = New System.Drawing.Point(735, 250)
        Me.txtbox_mot7.Name = "txtbox_mot7"
        Me.txtbox_mot7.Size = New System.Drawing.Size(73, 26)
        Me.txtbox_mot7.TabIndex = 16
        '
        'cmd_Back
        '
        Me.cmd_Back.BackColor = System.Drawing.Color.White
        Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(50, 350)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(60, 60)
        Me.cmd_Back.TabIndex = 18
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = False
        '
        'cmd_Next
        '
        Me.cmd_Next.BackColor = System.Drawing.Color.White
        Me.cmd_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.Location = New System.Drawing.Point(754, 350)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(60, 60)
        Me.cmd_Next.TabIndex = 17
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = False
        '
        'TimerQ2
        '
        Me.TimerQ2.Interval = 1000
        '
        'lbl_NumQ2
        '
        Me.lbl_NumQ2.AutoSize = True
        Me.lbl_NumQ2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumQ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_NumQ2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumQ2.Location = New System.Drawing.Point(765, 30)
        Me.lbl_NumQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NumQ2.Name = "lbl_NumQ2"
        Me.lbl_NumQ2.Size = New System.Drawing.Size(49, 30)
        Me.lbl_NumQ2.TabIndex = 19
        Me.lbl_NumQ2.Text = "2/5"
        '
        'cmd_aideQ4
        '
        Me.cmd_aideQ4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ4.Location = New System.Drawing.Point(180, 32)
        Me.cmd_aideQ4.Name = "cmd_aideQ4"
        Me.cmd_aideQ4.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ4.TabIndex = 1
        Me.cmd_aideQ4.Text = "Instruction"
        Me.cmd_aideQ4.UseVisualStyleBackColor = False
        '
        'lbl_secQ2
        '
        Me.lbl_secQ2.AutoSize = True
        Me.lbl_secQ2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_secQ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_secQ2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secQ2.Location = New System.Drawing.Point(776, 77)
        Me.lbl_secQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_secQ2.Name = "lbl_secQ2"
        Me.lbl_secQ2.Size = New System.Drawing.Size(2, 30)
        Me.lbl_secQ2.TabIndex = 22
        '
        'lbl_deuxptQ2
        '
        Me.lbl_deuxptQ2.AutoSize = True
        Me.lbl_deuxptQ2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_deuxptQ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_deuxptQ2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deuxptQ2.Location = New System.Drawing.Point(756, 77)
        Me.lbl_deuxptQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_deuxptQ2.Name = "lbl_deuxptQ2"
        Me.lbl_deuxptQ2.Size = New System.Drawing.Size(20, 30)
        Me.lbl_deuxptQ2.TabIndex = 21
        Me.lbl_deuxptQ2.Text = ":"
        '
        'lbl_minQ2
        '
        Me.lbl_minQ2.AutoSize = True
        Me.lbl_minQ2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minQ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_minQ2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minQ2.Location = New System.Drawing.Point(721, 77)
        Me.lbl_minQ2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_minQ2.Name = "lbl_minQ2"
        Me.lbl_minQ2.Size = New System.Drawing.Size(2, 30)
        Me.lbl_minQ2.TabIndex = 20
        '
        'Questions2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(868, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_secQ2)
        Me.Controls.Add(Me.lbl_deuxptQ2)
        Me.Controls.Add(Me.lbl_minQ2)
        Me.Controls.Add(Me.cmd_aideQ4)
        Me.Controls.Add(Me.lbl_NumQ2)
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
        Me.Controls.Add(Me.lbl_consigneQ4)
        Me.Controls.Add(Me.lblQ4)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Questions2"
        Me.Text = "Questions de français"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ4 As Label
    Friend WithEvents lbl_consigneQ4 As Label
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
    Friend WithEvents TimerQ2 As Timer
    Friend WithEvents lbl_NumQ2 As Label
    Friend WithEvents cmd_aideQ4 As Button
    Friend WithEvents lbl_secQ2 As Label
    Friend WithEvents lbl_deuxptQ2 As Label
    Friend WithEvents lbl_minQ2 As Label
End Class

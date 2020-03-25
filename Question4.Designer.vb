<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question4
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
        Me.lblQ4 = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.lbl_Francais = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_ennonce = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.lbl_2points = New System.Windows.Forms.Label()
        Me.lbl_sec = New System.Windows.Forms.Label()
        Me.TimerQ4 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_Aide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQ4
        '
        Me.lblQ4.AutoSize = True
        Me.lblQ4.BackColor = System.Drawing.Color.Transparent
        Me.lblQ4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ4.Location = New System.Drawing.Point(38, 36)
        Me.lblQ4.Name = "lblQ4"
        Me.lblQ4.Size = New System.Drawing.Size(209, 42)
        Me.lblQ4.TabIndex = 3
        Me.lblQ4.Text = "Question 4"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(732, 9)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 5
        Me.lbl_NumQ.Text = "4/10"
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
        Me.cmd_back.TabIndex = 6
        Me.cmd_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'cmd_next
        '
        Me.cmd_next.BackColor = System.Drawing.Color.White
        Me.cmd_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_next.Location = New System.Drawing.Point(687, 345)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(100, 94)
        Me.cmd_next.TabIndex = 7
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'lbl_Francais
        '
        Me.lbl_Francais.AutoSize = True
        Me.lbl_Francais.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Francais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Francais.Location = New System.Drawing.Point(232, 403)
        Me.lbl_Francais.Name = "lbl_Francais"
        Me.lbl_Francais.Size = New System.Drawing.Size(338, 31)
        Me.lbl_Francais.TabIndex = 8
        Me.lbl_Francais.Text = "Question de mathématique"
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigne.Location = New System.Drawing.Point(38, 111)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(334, 31)
        Me.lbl_consigne.TabIndex = 9
        Me.lbl_consigne.Text = "Sélectionne la bonne date."
        '
        'lbl_ennonce
        '
        Me.lbl_ennonce.AutoSize = True
        Me.lbl_ennonce.Location = New System.Drawing.Point(68, 161)
        Me.lbl_ennonce.Name = "lbl_ennonce"
        Me.lbl_ennonce.Size = New System.Drawing.Size(695, 50)
        Me.lbl_ennonce.TabIndex = 10
        Me.lbl_ennonce.Text = "Le 22 février 2020, Jean part en vacances et revient 18 jours plus tard. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Quel e" &
    "st la date de son retour de vacances ?"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(216, 248)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(370, 31)
        Me.DateTimePicker.TabIndex = 11
        Me.DateTimePicker.Value = New Date(2020, 3, 23, 0, 0, 0, 0)
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(345, 362)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(0, 25)
        Me.lbl_min.TabIndex = 13
        '
        'lbl_2points
        '
        Me.lbl_2points.AutoSize = True
        Me.lbl_2points.Location = New System.Drawing.Point(381, 362)
        Me.lbl_2points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_2points.Name = "lbl_2points"
        Me.lbl_2points.Size = New System.Drawing.Size(18, 25)
        Me.lbl_2points.TabIndex = 14
        Me.lbl_2points.Text = ":"
        '
        'lbl_sec
        '
        Me.lbl_sec.AutoSize = True
        Me.lbl_sec.Location = New System.Drawing.Point(408, 362)
        Me.lbl_sec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sec.Name = "lbl_sec"
        Me.lbl_sec.Size = New System.Drawing.Size(0, 25)
        Me.lbl_sec.TabIndex = 15
        '
        'TimerQ4
        '
        Me.TimerQ4.Interval = 1000
        '
        'cmd_Aide
        '
        Me.cmd_Aide.Location = New System.Drawing.Point(676, 56)
        Me.cmd_Aide.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_Aide.Name = "cmd_Aide"
        Me.cmd_Aide.Size = New System.Drawing.Size(112, 36)
        Me.cmd_Aide.TabIndex = 31
        Me.cmd_Aide.Text = "Aide"
        Me.cmd_Aide.UseVisualStyleBackColor = True
        '
        'Question4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_Aide)
        Me.Controls.Add(Me.lbl_sec)
        Me.Controls.Add(Me.lbl_2points)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.lbl_ennonce)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.lbl_Francais)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_back)
        Me.Controls.Add(Me.lbl_NumQ)
        Me.Controls.Add(Me.lblQ4)
        Me.Name = "Question4"
        Me.Text = "Question4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ4 As Label
    Friend WithEvents lbl_NumQ As Label
    Friend WithEvents cmd_back As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents lbl_Francais As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_ennonce As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents lbl_min As Label
    Friend WithEvents lbl_2points As Label
    Friend WithEvents lbl_sec As Label
    Friend WithEvents TimerQ4 As Timer
    Friend WithEvents cmd_Aide As Button
End Class

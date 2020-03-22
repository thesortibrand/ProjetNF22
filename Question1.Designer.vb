<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question1
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
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lbl_Francais = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_vous = New System.Windows.Forms.Label()
        Me.txtBox_repQ1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.BackColor = System.Drawing.Color.Transparent
        Me.lblQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ1.Location = New System.Drawing.Point(37, 32)
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
        Me.lbl_Francais.Location = New System.Drawing.Point(262, 406)
        Me.lbl_Francais.Name = "lbl_Francais"
        Me.lbl_Francais.Size = New System.Drawing.Size(263, 31)
        Me.lbl_Francais.TabIndex = 1
        Me.lbl_Francais.Text = "Question de français"
        '
        'lbl_NumQ
        '
        Me.lbl_NumQ.AutoSize = True
        Me.lbl_NumQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_NumQ.Location = New System.Drawing.Point(732, 9)
        Me.lbl_NumQ.Name = "lbl_NumQ"
        Me.lbl_NumQ.Size = New System.Drawing.Size(56, 27)
        Me.lbl_NumQ.TabIndex = 2
        Me.lbl_NumQ.Text = "1/10"
        '
        'cmd_next
        '
        Me.cmd_next.BackColor = System.Drawing.Color.White
        Me.cmd_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_next.Location = New System.Drawing.Point(687, 348)
        Me.cmd_next.Name = "cmd_next"
        Me.cmd_next.Size = New System.Drawing.Size(101, 93)
        Me.cmd_next.TabIndex = 4
        Me.cmd_next.Text = "Suivant"
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.White
        Me.cmd_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_back.Image = Global.ProjetNF22.My.Resources.Resources.left_arrow2
        Me.cmd_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_back.Location = New System.Drawing.Point(12, 348)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(101, 93)
        Me.cmd_back.TabIndex = 3
        Me.cmd_back.Text = "Retour"
        Me.cmd_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 5
        '
        'lbl_consigne
        '
        Me.lbl_consigne.AutoSize = True
        Me.lbl_consigne.Location = New System.Drawing.Point(39, 113)
        Me.lbl_consigne.Name = "lbl_consigne"
        Me.lbl_consigne.Size = New System.Drawing.Size(549, 25)
        Me.lbl_consigne.TabIndex = 6
        Me.lbl_consigne.Text = "Conjuguez le verbe ""voir"" au pronom personnel suivant :"
        '
        'lbl_vous
        '
        Me.lbl_vous.AutoSize = True
        Me.lbl_vous.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vous.Location = New System.Drawing.Point(123, 199)
        Me.lbl_vous.Name = "lbl_vous"
        Me.lbl_vous.Size = New System.Drawing.Size(91, 37)
        Me.lbl_vous.TabIndex = 7
        Me.lbl_vous.Text = "Vous"
        '
        'txtBox_repQ1
        '
        Me.txtBox_repQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_repQ1.Location = New System.Drawing.Point(220, 196)
        Me.txtBox_repQ1.Name = "txtBox_repQ1"
        Me.txtBox_repQ1.Size = New System.Drawing.Size(289, 44)
        Me.txtBox_repQ1.TabIndex = 8
        '
        'Question1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBox_repQ1)
        Me.Controls.Add(Me.lbl_vous)
        Me.Controls.Add(Me.lbl_consigne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_next)
        Me.Controls.Add(Me.cmd_back)
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
    Friend WithEvents cmd_back As Button
    Friend WithEvents cmd_next As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_consigne As Label
    Friend WithEvents lbl_vous As Label
    Friend WithEvents txtBox_repQ1 As TextBox
End Class

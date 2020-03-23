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
        Me.lblQ5 = New System.Windows.Forms.Label()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.cmd_next = New System.Windows.Forms.Button()
        Me.lbl_Francais = New System.Windows.Forms.Label()
        Me.lbl_NumQ = New System.Windows.Forms.Label()
        Me.lbl_consigne = New System.Windows.Forms.Label()
        Me.lbl_phrase = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQ5
        '
        Me.lblQ5.AutoSize = True
        Me.lblQ5.BackColor = System.Drawing.Color.Transparent
        Me.lblQ5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ5.Location = New System.Drawing.Point(43, 31)
        Me.lblQ5.Name = "lblQ5"
        Me.lblQ5.Size = New System.Drawing.Size(209, 42)
        Me.lblQ5.TabIndex = 4
        Me.lblQ5.Text = "Question 5"
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.White
        Me.cmd_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_back.Image = Global.ProjetNF22.My.Resources.Resources.left_arrow2
        Me.cmd_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_back.Location = New System.Drawing.Point(12, 345)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(101, 93)
        Me.cmd_back.TabIndex = 7
        Me.cmd_back.Text = "Retour"
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
        Me.cmd_next.Size = New System.Drawing.Size(101, 93)
        Me.cmd_next.TabIndex = 8
        Me.cmd_next.Text = "Suivant"
        Me.cmd_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_next.UseVisualStyleBackColor = False
        '
        'lbl_Francais
        '
        Me.lbl_Francais.AutoSize = True
        Me.lbl_Francais.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Francais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Francais.Location = New System.Drawing.Point(271, 403)
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
        Me.lbl_phrase.Location = New System.Drawing.Point(157, 204)
        Me.lbl_phrase.Name = "lbl_phrase"
        Me.lbl_phrase.Size = New System.Drawing.Size(218, 31)
        Me.lbl_phrase.TabIndex = 12
        Me.lbl_phrase.Text = "Un cheval -> des"
        '
        'TextBox
        '
        Me.TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(381, 201)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(188, 38)
        Me.TextBox.TabIndex = 13
        '
        'Question5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class

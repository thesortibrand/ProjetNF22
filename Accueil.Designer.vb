<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_evaluation = New System.Windows.Forms.Label()
        Me.lbl_niveau = New System.Windows.Forms.Label()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.cmd_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 0
        '
        'lbl_evaluation
        '
        Me.lbl_evaluation.AutoSize = True
        Me.lbl_evaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_evaluation.Location = New System.Drawing.Point(136, 58)
        Me.lbl_evaluation.Name = "lbl_evaluation"
        Me.lbl_evaluation.Size = New System.Drawing.Size(368, 55)
        Me.lbl_evaluation.TabIndex = 1
        Me.lbl_evaluation.Text = "EVALUTATION"
        '
        'lbl_niveau
        '
        Me.lbl_niveau.AutoSize = True
        Me.lbl_niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_niveau.Location = New System.Drawing.Point(176, 122)
        Me.lbl_niveau.Name = "lbl_niveau"
        Me.lbl_niveau.Size = New System.Drawing.Size(281, 55)
        Me.lbl_niveau.TabIndex = 2
        Me.lbl_niveau.Text = "Niveau CE2"
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_start.Location = New System.Drawing.Point(103, 288)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(170, 143)
        Me.cmd_start.TabIndex = 3
        Me.cmd_start.Text = "Demarrer l'évaluation"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'cmd_quitter
        '
        Me.cmd_quitter.BackColor = System.Drawing.Color.IndianRed
        Me.cmd_quitter.Location = New System.Drawing.Point(414, 288)
        Me.cmd_quitter.Name = "cmd_quitter"
        Me.cmd_quitter.Size = New System.Drawing.Size(170, 143)
        Me.cmd_quitter.TabIndex = 4
        Me.cmd_quitter.Text = "Quitter l'évaluation"
        Me.cmd_quitter.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 553)
        Me.Controls.Add(Me.cmd_quitter)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.lbl_niveau)
        Me.Controls.Add(Me.lbl_evaluation)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Accueil"
        Me.Text = "Accueil / Page de démarrage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_evaluation As Label
    Friend WithEvents lbl_niveau As Label
    Friend WithEvents cmd_start As Button
    Friend WithEvents cmd_quitter As Button
End Class

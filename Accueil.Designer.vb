<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.lbl_evaluation = New System.Windows.Forms.Label()
        Me.lbl_niveau = New System.Windows.Forms.Label()
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.lbl_explicationtest = New System.Windows.Forms.Label()
        Me.cmd_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_evaluation
        '
        Me.lbl_evaluation.AutoSize = True
        Me.lbl_evaluation.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_evaluation.Location = New System.Drawing.Point(244, 58)
        Me.lbl_evaluation.Name = "lbl_evaluation"
        Me.lbl_evaluation.Size = New System.Drawing.Size(338, 55)
        Me.lbl_evaluation.TabIndex = 0
        Me.lbl_evaluation.Text = "EVALUATION"
        '
        'lbl_niveau
        '
        Me.lbl_niveau.AutoSize = True
        Me.lbl_niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_niveau.Location = New System.Drawing.Point(266, 135)
        Me.lbl_niveau.Name = "lbl_niveau"
        Me.lbl_niveau.Size = New System.Drawing.Size(281, 55)
        Me.lbl_niveau.TabIndex = 1
        Me.lbl_niveau.Text = "Niveau CE2"
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_start.Location = New System.Drawing.Point(345, 395)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(364, 120)
        Me.cmd_start.TabIndex = 3
        Me.cmd_start.Text = "Démarrer l'évaluation"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'lbl_explicationtest
        '
        Me.lbl_explicationtest.AutoSize = True
        Me.lbl_explicationtest.Location = New System.Drawing.Point(118, 214)
        Me.lbl_explicationtest.Name = "lbl_explicationtest"
        Me.lbl_explicationtest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_explicationtest.Size = New System.Drawing.Size(564, 50)
        Me.lbl_explicationtest.TabIndex = 2
        Me.lbl_explicationtest.Text = "Cette évaluation comprend 10 questions : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 questions de français et 5 questions" &
    " de mathématiques."
        Me.lbl_explicationtest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_quitter
        '
        Me.cmd_quitter.AutoSize = True
        Me.cmd_quitter.BackColor = System.Drawing.Color.White
        Me.cmd_quitter.Image = CType(resources.GetObject("cmd_quitter.Image"), System.Drawing.Image)
        Me.cmd_quitter.Location = New System.Drawing.Point(108, 375)
        Me.cmd_quitter.Name = "cmd_quitter"
        Me.cmd_quitter.Size = New System.Drawing.Size(150, 156)
        Me.cmd_quitter.TabIndex = 4
        Me.cmd_quitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quitter.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(788, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_explicationtest)
        Me.Controls.Add(Me.cmd_quitter)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.lbl_niveau)
        Me.Controls.Add(Me.lbl_evaluation)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Accueil"
        Me.Text = "Accueil / Page de démarrage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_evaluation As Label
    Friend WithEvents lbl_niveau As Label
    Friend WithEvents cmd_start As Button
    Friend WithEvents cmd_quitter As Button
    Friend WithEvents lbl_explicationtest As Label
End Class

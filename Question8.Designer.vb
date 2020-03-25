<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question8
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
        Me.lblQ8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQ8
        '
        Me.lblQ8.AutoSize = True
        Me.lblQ8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ8.Location = New System.Drawing.Point(45, 34)
        Me.lblQ8.Name = "lblQ8"
        Me.lblQ8.Size = New System.Drawing.Size(139, 29)
        Me.lblQ8.TabIndex = 1
        Me.lblQ8.Text = "Question 8"
        '
        'Question8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.lblQ8)
        Me.Name = "Question8"
        Me.Text = "Question 8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ8 As Label
End Class

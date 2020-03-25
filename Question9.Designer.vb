<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question9
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
        Me.lblQ9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQ9
        '
        Me.lblQ9.AutoSize = True
        Me.lblQ9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ9.Location = New System.Drawing.Point(46, 31)
        Me.lblQ9.Name = "lblQ9"
        Me.lblQ9.Size = New System.Drawing.Size(139, 29)
        Me.lblQ9.TabIndex = 1
        Me.lblQ9.Text = "Question 9"
        '
        'Question9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.lblQ9)
        Me.Name = "Question9"
        Me.Text = "Question 9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ9 As Label
End Class

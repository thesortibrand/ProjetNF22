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
        Me.btn_Manuel = New System.Windows.Forms.Button()
        Me.lbl_nouveau = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_evaluation
        '
        Me.lbl_evaluation.AutoSize = True
        Me.lbl_evaluation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_evaluation.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_evaluation.Location = New System.Drawing.Point(210, 20)
        Me.lbl_evaluation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_evaluation.Name = "lbl_evaluation"
        Me.lbl_evaluation.Size = New System.Drawing.Size(247, 45)
        Me.lbl_evaluation.TabIndex = 0
        Me.lbl_evaluation.Text = "EVALUATION"
        '
        'lbl_niveau
        '
        Me.lbl_niveau.AutoSize = True
        Me.lbl_niveau.BackColor = System.Drawing.Color.Transparent
        Me.lbl_niveau.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_niveau.Location = New System.Drawing.Point(250, 60)
        Me.lbl_niveau.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_niveau.Name = "lbl_niveau"
        Me.lbl_niveau.Size = New System.Drawing.Size(164, 39)
        Me.lbl_niveau.TabIndex = 1
        Me.lbl_niveau.Text = "Niveau CE2"
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.Color.LimeGreen
        Me.cmd_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_start.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_start.Location = New System.Drawing.Point(250, 405)
        Me.cmd_start.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(260, 80)
        Me.cmd_start.TabIndex = 5
        Me.cmd_start.Text = "Démarrer l'évaluation"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'lbl_explicationtest
        '
        Me.lbl_explicationtest.AutoSize = True
        Me.lbl_explicationtest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_explicationtest.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_explicationtest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_explicationtest.Location = New System.Drawing.Point(50, 335)
        Me.lbl_explicationtest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_explicationtest.Name = "lbl_explicationtest"
        Me.lbl_explicationtest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_explicationtest.Size = New System.Drawing.Size(466, 48)
        Me.lbl_explicationtest.TabIndex = 4
        Me.lbl_explicationtest.Text = "Cette évaluation comprend 10 questions : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 questions de français et 5 questions" &
    " de mathématiques."
        Me.lbl_explicationtest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_quitter
        '
        Me.cmd_quitter.AutoSize = True
        Me.cmd_quitter.BackColor = System.Drawing.Color.White
        Me.cmd_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_quitter.Image = CType(resources.GetObject("cmd_quitter.Image"), System.Drawing.Image)
        Me.cmd_quitter.Location = New System.Drawing.Point(50, 405)
        Me.cmd_quitter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_quitter.Name = "cmd_quitter"
        Me.cmd_quitter.Size = New System.Drawing.Size(80, 80)
        Me.cmd_quitter.TabIndex = 6
        Me.cmd_quitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quitter.UseVisualStyleBackColor = False
        '
        'btn_Manuel
        '
        Me.btn_Manuel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Manuel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Manuel.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Manuel.Location = New System.Drawing.Point(50, 275)
        Me.btn_Manuel.Name = "btn_Manuel"
        Me.btn_Manuel.Size = New System.Drawing.Size(90, 50)
        Me.btn_Manuel.TabIndex = 3
        Me.btn_Manuel.Text = "Manuel"
        Me.btn_Manuel.UseVisualStyleBackColor = False
        '
        'lbl_nouveau
        '
        Me.lbl_nouveau.AutoSize = True
        Me.lbl_nouveau.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nouveau.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_nouveau.Location = New System.Drawing.Point(50, 225)
        Me.lbl_nouveau.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nouveau.Name = "lbl_nouveau"
        Me.lbl_nouveau.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_nouveau.Size = New System.Drawing.Size(176, 48)
        Me.lbl_nouveau.TabIndex = 2
        Me.lbl_nouveau.Text = "Nouveau utilisateur?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clique sur ""Manuel""."
        Me.lbl_nouveau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accueil
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.ProjetNF22.My.Resources.Resources.test_background
        Me.ClientSize = New System.Drawing.Size(582, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_nouveau)
        Me.Controls.Add(Me.btn_Manuel)
        Me.Controls.Add(Me.lbl_explicationtest)
        Me.Controls.Add(Me.cmd_quitter)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.lbl_niveau)
        Me.Controls.Add(Me.lbl_evaluation)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
    Friend WithEvents btn_Manuel As Button
    Friend WithEvents lbl_nouveau As Label
End Class

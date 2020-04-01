<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questions4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Questions4))
        Me.lblQ3 = New System.Windows.Forms.Label()
        Me.lblQ7 = New System.Windows.Forms.Label()
        Me.lblQ6 = New System.Windows.Forms.Label()
        Me.lb_Q6 = New System.Windows.Forms.ListBox()
        Me.lbl_calcul = New System.Windows.Forms.Label()
        Me.lbl_consigneQ6 = New System.Windows.Forms.Label()
        Me.DateTimePickerQ7 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ennonce = New System.Windows.Forms.Label()
        Me.lbl_consigneQ7 = New System.Windows.Forms.Label()
        Me.rbQ8_option3 = New System.Windows.Forms.RadioButton()
        Me.rbQ8_option2 = New System.Windows.Forms.RadioButton()
        Me.rbQ8_option1 = New System.Windows.Forms.RadioButton()
        Me.lbl_enonceQ8 = New System.Windows.Forms.Label()
        Me.lbl_consigneQ8 = New System.Windows.Forms.Label()
        Me.lbl_9 = New System.Windows.Forms.Label()
        Me.lbl_somme5 = New System.Windows.Forms.Label()
        Me.lbl_somme4 = New System.Windows.Forms.Label()
        Me.lbl_somme3 = New System.Windows.Forms.Label()
        Me.lbl_somme2 = New System.Windows.Forms.Label()
        Me.lbl_700 = New System.Windows.Forms.Label()
        Me.lbl_7000 = New System.Windows.Forms.Label()
        Me.lbl_7 = New System.Windows.Forms.Label()
        Me.lbl_30000 = New System.Windows.Forms.Label()
        Me.lbl_somme1 = New System.Windows.Forms.Label()
        Me.lbl_30 = New System.Windows.Forms.Label()
        Me.lbl_chiffres = New System.Windows.Forms.Label()
        Me.lbl_consigneQ9 = New System.Windows.Forms.Label()
        Me.lbl_Q9 = New System.Windows.Forms.Label()
        Me.cmd_aideQ9 = New System.Windows.Forms.Button()
        Me.cmd_aideQ8 = New System.Windows.Forms.Button()
        Me.cmd_aideQ6 = New System.Windows.Forms.Button()
        Me.cmd_aideQ7 = New System.Windows.Forms.Button()
        Me.lbl_secQ4 = New System.Windows.Forms.Label()
        Me.lbl_deuxptQ4 = New System.Windows.Forms.Label()
        Me.lbl_minQ4 = New System.Windows.Forms.Label()
        Me.lbl_NumQ4 = New System.Windows.Forms.Label()
        Me.cmd_Next = New System.Windows.Forms.Button()
        Me.cmd_Back = New System.Windows.Forms.Button()
        Me.TimerQ4 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ3
        '
        Me.lblQ3.AutoSize = True
        Me.lblQ3.BackColor = System.Drawing.Color.Transparent
        Me.lblQ3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ3.Location = New System.Drawing.Point(50, 220)
        Me.lblQ3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ3.Name = "lblQ3"
        Me.lblQ3.Size = New System.Drawing.Size(142, 35)
        Me.lblQ3.TabIndex = 10
        Me.lblQ3.Text = "Question 8"
        '
        'lblQ7
        '
        Me.lblQ7.AutoSize = True
        Me.lblQ7.BackColor = System.Drawing.Color.Transparent
        Me.lblQ7.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ7.Location = New System.Drawing.Point(324, 30)
        Me.lblQ7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ7.Name = "lblQ7"
        Me.lblQ7.Size = New System.Drawing.Size(142, 35)
        Me.lblQ7.TabIndex = 5
        Me.lblQ7.Text = "Question 7"
        '
        'lblQ6
        '
        Me.lblQ6.AutoSize = True
        Me.lblQ6.BackColor = System.Drawing.Color.Transparent
        Me.lblQ6.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ6.Location = New System.Drawing.Point(50, 30)
        Me.lblQ6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQ6.Name = "lblQ6"
        Me.lblQ6.Size = New System.Drawing.Size(142, 35)
        Me.lblQ6.TabIndex = 0
        Me.lblQ6.Text = "Question 6"
        '
        'lb_Q6
        '
        Me.lb_Q6.FormattingEnabled = True
        Me.lb_Q6.ItemHeight = 18
        Me.lb_Q6.Items.AddRange(New Object() {"15", "45", "20", "4", "54", "95", "14"})
        Me.lb_Q6.Location = New System.Drawing.Point(180, 115)
        Me.lb_Q6.Margin = New System.Windows.Forms.Padding(2)
        Me.lb_Q6.Name = "lb_Q6"
        Me.lb_Q6.Size = New System.Drawing.Size(81, 76)
        Me.lb_Q6.TabIndex = 4
        '
        'lbl_calcul
        '
        Me.lbl_calcul.AutoSize = True
        Me.lbl_calcul.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calcul.Location = New System.Drawing.Point(100, 115)
        Me.lbl_calcul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_calcul.Name = "lbl_calcul"
        Me.lbl_calcul.Size = New System.Drawing.Size(81, 26)
        Me.lbl_calcul.TabIndex = 3
        Me.lbl_calcul.Text = "9 x 5 = "
        '
        'lbl_consigneQ6
        '
        Me.lbl_consigneQ6.AutoSize = True
        Me.lbl_consigneQ6.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ6.Location = New System.Drawing.Point(75, 80)
        Me.lbl_consigneQ6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_consigneQ6.Name = "lbl_consigneQ6"
        Me.lbl_consigneQ6.Size = New System.Drawing.Size(220, 27)
        Me.lbl_consigneQ6.TabIndex = 2
        Me.lbl_consigneQ6.Text = "Choisi la bonne réponse."
        '
        'DateTimePickerQ7
        '
        Me.DateTimePickerQ7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerQ7.Location = New System.Drawing.Point(399, 190)
        Me.DateTimePickerQ7.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerQ7.Name = "DateTimePickerQ7"
        Me.DateTimePickerQ7.Size = New System.Drawing.Size(248, 31)
        Me.DateTimePickerQ7.TabIndex = 9
        Me.DateTimePickerQ7.Value = New Date(2020, 3, 23, 0, 0, 0, 0)
        '
        'lbl_ennonce
        '
        Me.lbl_ennonce.AutoSize = True
        Me.lbl_ennonce.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ennonce.Location = New System.Drawing.Point(374, 115)
        Me.lbl_ennonce.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ennonce.Name = "lbl_ennonce"
        Me.lbl_ennonce.Size = New System.Drawing.Size(372, 72)
        Me.lbl_ennonce.TabIndex = 8
        Me.lbl_ennonce.Text = "Le 22 février 2020, Jean part en vacances.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Il revient 18 jours plus tard. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Qu" &
    "el est la date de son retour de vacances ?"
        '
        'lbl_consigneQ7
        '
        Me.lbl_consigneQ7.AutoSize = True
        Me.lbl_consigneQ7.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ7.Location = New System.Drawing.Point(349, 80)
        Me.lbl_consigneQ7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_consigneQ7.Name = "lbl_consigneQ7"
        Me.lbl_consigneQ7.Size = New System.Drawing.Size(243, 27)
        Me.lbl_consigneQ7.TabIndex = 7
        Me.lbl_consigneQ7.Text = "Sélectionne la bonne date."
        '
        'rbQ8_option3
        '
        Me.rbQ8_option3.AutoSize = True
        Me.rbQ8_option3.Image = Global.ProjetNF22.My.Resources.Resources._4pommes
        Me.rbQ8_option3.Location = New System.Drawing.Point(435, 370)
        Me.rbQ8_option3.Name = "rbQ8_option3"
        Me.rbQ8_option3.Size = New System.Drawing.Size(137, 100)
        Me.rbQ8_option3.TabIndex = 16
        Me.rbQ8_option3.TabStop = True
        Me.rbQ8_option3.UseVisualStyleBackColor = True
        '
        'rbQ8_option2
        '
        Me.rbQ8_option2.AutoSize = True
        Me.rbQ8_option2.Image = Global.ProjetNF22.My.Resources.Resources._3pommes
        Me.rbQ8_option2.Location = New System.Drawing.Point(280, 370)
        Me.rbQ8_option2.Name = "rbQ8_option2"
        Me.rbQ8_option2.Size = New System.Drawing.Size(137, 100)
        Me.rbQ8_option2.TabIndex = 15
        Me.rbQ8_option2.TabStop = True
        Me.rbQ8_option2.UseVisualStyleBackColor = True
        '
        'rbQ8_option1
        '
        Me.rbQ8_option1.AutoSize = True
        Me.rbQ8_option1.Image = Global.ProjetNF22.My.Resources.Resources._2pommes
        Me.rbQ8_option1.Location = New System.Drawing.Point(125, 370)
        Me.rbQ8_option1.Name = "rbQ8_option1"
        Me.rbQ8_option1.Size = New System.Drawing.Size(137, 100)
        Me.rbQ8_option1.TabIndex = 14
        Me.rbQ8_option1.TabStop = True
        Me.rbQ8_option1.UseVisualStyleBackColor = True
        '
        'lbl_enonceQ8
        '
        Me.lbl_enonceQ8.AutoSize = True
        Me.lbl_enonceQ8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enonceQ8.Location = New System.Drawing.Point(100, 300)
        Me.lbl_enonceQ8.Name = "lbl_enonceQ8"
        Me.lbl_enonceQ8.Size = New System.Drawing.Size(483, 48)
        Me.lbl_enonceQ8.TabIndex = 13
        Me.lbl_enonceQ8.Text = "Maman partage 12 pommes également entre ses 3 enfants. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Combien de pommes chaq" &
    "ue enfant reçoit-il?"
        '
        'lbl_consigneQ8
        '
        Me.lbl_consigneQ8.AutoSize = True
        Me.lbl_consigneQ8.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ8.Location = New System.Drawing.Point(75, 265)
        Me.lbl_consigneQ8.Name = "lbl_consigneQ8"
        Me.lbl_consigneQ8.Size = New System.Drawing.Size(220, 27)
        Me.lbl_consigneQ8.TabIndex = 12
        Me.lbl_consigneQ8.Text = "Choisi la bonne réponse."
        '
        'lbl_9
        '
        Me.lbl_9.AutoSize = True
        Me.lbl_9.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_9.Location = New System.Drawing.Point(603, 570)
        Me.lbl_9.Name = "lbl_9"
        Me.lbl_9.Size = New System.Drawing.Size(20, 24)
        Me.lbl_9.TabIndex = 31
        Me.lbl_9.Text = "9"
        '
        'lbl_somme5
        '
        Me.lbl_somme5.AutoSize = True
        Me.lbl_somme5.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme5.Location = New System.Drawing.Point(562, 570)
        Me.lbl_somme5.Name = "lbl_somme5"
        Me.lbl_somme5.Size = New System.Drawing.Size(21, 26)
        Me.lbl_somme5.TabIndex = 30
        Me.lbl_somme5.Text = "+"
        '
        'lbl_somme4
        '
        Me.lbl_somme4.AutoSize = True
        Me.lbl_somme4.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme4.Location = New System.Drawing.Point(479, 570)
        Me.lbl_somme4.Name = "lbl_somme4"
        Me.lbl_somme4.Size = New System.Drawing.Size(21, 26)
        Me.lbl_somme4.TabIndex = 28
        Me.lbl_somme4.Text = "+"
        '
        'lbl_somme3
        '
        Me.lbl_somme3.AutoSize = True
        Me.lbl_somme3.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme3.Location = New System.Drawing.Point(385, 570)
        Me.lbl_somme3.Name = "lbl_somme3"
        Me.lbl_somme3.Size = New System.Drawing.Size(21, 26)
        Me.lbl_somme3.TabIndex = 26
        Me.lbl_somme3.Text = "+"
        '
        'lbl_somme2
        '
        Me.lbl_somme2.AutoSize = True
        Me.lbl_somme2.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme2.Location = New System.Drawing.Point(314, 570)
        Me.lbl_somme2.Name = "lbl_somme2"
        Me.lbl_somme2.Size = New System.Drawing.Size(21, 26)
        Me.lbl_somme2.TabIndex = 24
        Me.lbl_somme2.Text = "+"
        '
        'lbl_700
        '
        Me.lbl_700.AutoSize = True
        Me.lbl_700.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_700.Location = New System.Drawing.Point(515, 570)
        Me.lbl_700.Name = "lbl_700"
        Me.lbl_700.Size = New System.Drawing.Size(40, 24)
        Me.lbl_700.TabIndex = 29
        Me.lbl_700.Text = "700"
        '
        'lbl_7000
        '
        Me.lbl_7000.AutoSize = True
        Me.lbl_7000.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7000.Location = New System.Drawing.Point(412, 570)
        Me.lbl_7000.Name = "lbl_7000"
        Me.lbl_7000.Size = New System.Drawing.Size(55, 24)
        Me.lbl_7000.TabIndex = 27
        Me.lbl_7000.Text = "7 000"
        '
        'lbl_7
        '
        Me.lbl_7.AutoSize = True
        Me.lbl_7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_7.Location = New System.Drawing.Point(351, 570)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(20, 24)
        Me.lbl_7.TabIndex = 25
        Me.lbl_7.Text = "7"
        '
        'lbl_30000
        '
        Me.lbl_30000.AutoSize = True
        Me.lbl_30000.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_30000.Location = New System.Drawing.Point(180, 570)
        Me.lbl_30000.Name = "lbl_30000"
        Me.lbl_30000.Size = New System.Drawing.Size(65, 24)
        Me.lbl_30000.TabIndex = 21
        Me.lbl_30000.Text = "30 000"
        '
        'lbl_somme1
        '
        Me.lbl_somme1.AutoSize = True
        Me.lbl_somme1.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_somme1.Location = New System.Drawing.Point(245, 570)
        Me.lbl_somme1.Name = "lbl_somme1"
        Me.lbl_somme1.Size = New System.Drawing.Size(21, 26)
        Me.lbl_somme1.TabIndex = 22
        Me.lbl_somme1.Text = "+"
        '
        'lbl_30
        '
        Me.lbl_30.AutoSize = True
        Me.lbl_30.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_30.Location = New System.Drawing.Point(272, 570)
        Me.lbl_30.Name = "lbl_30"
        Me.lbl_30.Size = New System.Drawing.Size(30, 24)
        Me.lbl_30.TabIndex = 23
        Me.lbl_30.Text = "30"
        '
        'lbl_chiffres
        '
        Me.lbl_chiffres.AutoSize = True
        Me.lbl_chiffres.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chiffres.Location = New System.Drawing.Point(100, 570)
        Me.lbl_chiffres.Name = "lbl_chiffres"
        Me.lbl_chiffres.Size = New System.Drawing.Size(106, 26)
        Me.lbl_chiffres.TabIndex = 20
        Me.lbl_chiffres.Text = "30 739  = "
        '
        'lbl_consigneQ9
        '
        Me.lbl_consigneQ9.AutoSize = True
        Me.lbl_consigneQ9.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consigneQ9.Location = New System.Drawing.Point(75, 535)
        Me.lbl_consigneQ9.Name = "lbl_consigneQ9"
        Me.lbl_consigneQ9.Size = New System.Drawing.Size(455, 27)
        Me.lbl_consigneQ9.TabIndex = 19
        Me.lbl_consigneQ9.Text = "Choisi les nombres de la décomposition de 30 739."
        '
        'lbl_Q9
        '
        Me.lbl_Q9.AutoSize = True
        Me.lbl_Q9.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Q9.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Q9.Location = New System.Drawing.Point(50, 490)
        Me.lbl_Q9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Q9.Name = "lbl_Q9"
        Me.lbl_Q9.Size = New System.Drawing.Size(142, 35)
        Me.lbl_Q9.TabIndex = 17
        Me.lbl_Q9.Text = "Question 9"
        '
        'cmd_aideQ9
        '
        Me.cmd_aideQ9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ9.Location = New System.Drawing.Point(180, 490)
        Me.cmd_aideQ9.Name = "cmd_aideQ9"
        Me.cmd_aideQ9.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ9.TabIndex = 18
        Me.cmd_aideQ9.Text = "Instruction"
        Me.cmd_aideQ9.UseVisualStyleBackColor = False
        '
        'cmd_aideQ8
        '
        Me.cmd_aideQ8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ8.Location = New System.Drawing.Point(180, 222)
        Me.cmd_aideQ8.Name = "cmd_aideQ8"
        Me.cmd_aideQ8.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ8.TabIndex = 11
        Me.cmd_aideQ8.Text = "Instruction"
        Me.cmd_aideQ8.UseVisualStyleBackColor = False
        '
        'cmd_aideQ6
        '
        Me.cmd_aideQ6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ6.Location = New System.Drawing.Point(180, 32)
        Me.cmd_aideQ6.Name = "cmd_aideQ6"
        Me.cmd_aideQ6.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ6.TabIndex = 6
        Me.cmd_aideQ6.Text = "Instruction"
        Me.cmd_aideQ6.UseVisualStyleBackColor = False
        '
        'cmd_aideQ7
        '
        Me.cmd_aideQ7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_aideQ7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_aideQ7.Location = New System.Drawing.Point(454, 32)
        Me.cmd_aideQ7.Name = "cmd_aideQ7"
        Me.cmd_aideQ7.Size = New System.Drawing.Size(90, 25)
        Me.cmd_aideQ7.TabIndex = 6
        Me.cmd_aideQ7.Text = "Instruction"
        Me.cmd_aideQ7.UseVisualStyleBackColor = False
        '
        'lbl_secQ4
        '
        Me.lbl_secQ4.AutoSize = True
        Me.lbl_secQ4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_secQ4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_secQ4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secQ4.Location = New System.Drawing.Point(728, 77)
        Me.lbl_secQ4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_secQ4.Name = "lbl_secQ4"
        Me.lbl_secQ4.Size = New System.Drawing.Size(2, 30)
        Me.lbl_secQ4.TabIndex = 36
        '
        'lbl_deuxptQ4
        '
        Me.lbl_deuxptQ4.AutoSize = True
        Me.lbl_deuxptQ4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_deuxptQ4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_deuxptQ4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_deuxptQ4.Location = New System.Drawing.Point(708, 77)
        Me.lbl_deuxptQ4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_deuxptQ4.Name = "lbl_deuxptQ4"
        Me.lbl_deuxptQ4.Size = New System.Drawing.Size(20, 30)
        Me.lbl_deuxptQ4.TabIndex = 35
        Me.lbl_deuxptQ4.Text = ":"
        '
        'lbl_minQ4
        '
        Me.lbl_minQ4.AutoSize = True
        Me.lbl_minQ4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minQ4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_minQ4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minQ4.Location = New System.Drawing.Point(673, 77)
        Me.lbl_minQ4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_minQ4.Name = "lbl_minQ4"
        Me.lbl_minQ4.Size = New System.Drawing.Size(2, 30)
        Me.lbl_minQ4.TabIndex = 34
        '
        'lbl_NumQ4
        '
        Me.lbl_NumQ4.AutoSize = True
        Me.lbl_NumQ4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumQ4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_NumQ4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumQ4.Location = New System.Drawing.Point(717, 30)
        Me.lbl_NumQ4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NumQ4.Name = "lbl_NumQ4"
        Me.lbl_NumQ4.Size = New System.Drawing.Size(49, 30)
        Me.lbl_NumQ4.TabIndex = 34
        Me.lbl_NumQ4.Text = "4/5"
        '
        'cmd_Next
        '
        Me.cmd_Next.BackColor = System.Drawing.Color.White
        Me.cmd_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Next.Image = Global.ProjetNF22.My.Resources.Resources.right_arrow
        Me.cmd_Next.Location = New System.Drawing.Point(699, 610)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(67, 60)
        Me.cmd_Next.TabIndex = 32
        Me.cmd_Next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Next.UseVisualStyleBackColor = False
        '
        'cmd_Back
        '
        Me.cmd_Back.BackColor = System.Drawing.Color.White
        Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(50, 610)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(67, 60)
        Me.cmd_Back.TabIndex = 33
        Me.cmd_Back.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_Back.UseVisualStyleBackColor = False
        '
        'TimerQ4
        '
        Me.TimerQ4.Interval = 1000
        '
        'Questions4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(798, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_Next)
        Me.Controls.Add(Me.cmd_Back)
        Me.Controls.Add(Me.lbl_secQ4)
        Me.Controls.Add(Me.lbl_deuxptQ4)
        Me.Controls.Add(Me.lbl_minQ4)
        Me.Controls.Add(Me.lbl_NumQ4)
        Me.Controls.Add(Me.cmd_aideQ7)
        Me.Controls.Add(Me.cmd_aideQ9)
        Me.Controls.Add(Me.cmd_aideQ8)
        Me.Controls.Add(Me.cmd_aideQ6)
        Me.Controls.Add(Me.lbl_Q9)
        Me.Controls.Add(Me.lbl_9)
        Me.Controls.Add(Me.lbl_somme5)
        Me.Controls.Add(Me.lbl_somme4)
        Me.Controls.Add(Me.lbl_somme3)
        Me.Controls.Add(Me.lbl_somme2)
        Me.Controls.Add(Me.lbl_700)
        Me.Controls.Add(Me.lbl_7000)
        Me.Controls.Add(Me.lbl_7)
        Me.Controls.Add(Me.lbl_30000)
        Me.Controls.Add(Me.lbl_somme1)
        Me.Controls.Add(Me.lbl_30)
        Me.Controls.Add(Me.lbl_chiffres)
        Me.Controls.Add(Me.lbl_consigneQ9)
        Me.Controls.Add(Me.rbQ8_option3)
        Me.Controls.Add(Me.rbQ8_option2)
        Me.Controls.Add(Me.rbQ8_option1)
        Me.Controls.Add(Me.lbl_enonceQ8)
        Me.Controls.Add(Me.lbl_consigneQ8)
        Me.Controls.Add(Me.DateTimePickerQ7)
        Me.Controls.Add(Me.lbl_ennonce)
        Me.Controls.Add(Me.lbl_consigneQ7)
        Me.Controls.Add(Me.lb_Q6)
        Me.Controls.Add(Me.lbl_calcul)
        Me.Controls.Add(Me.lbl_consigneQ6)
        Me.Controls.Add(Me.lblQ3)
        Me.Controls.Add(Me.lblQ7)
        Me.Controls.Add(Me.lblQ6)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Questions4"
        Me.Text = "Questions de Mathématiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ3 As Label
    Friend WithEvents lblQ7 As Label
    Friend WithEvents lblQ6 As Label
    Friend WithEvents lb_Q6 As ListBox
    Friend WithEvents lbl_calcul As Label
    Friend WithEvents lbl_consigneQ6 As Label
    Friend WithEvents DateTimePickerQ7 As DateTimePicker
    Friend WithEvents lbl_ennonce As Label
    Friend WithEvents lbl_consigneQ7 As Label
    Friend WithEvents rbQ8_option3 As RadioButton
    Friend WithEvents rbQ8_option2 As RadioButton
    Friend WithEvents rbQ8_option1 As RadioButton
    Friend WithEvents lbl_enonceQ8 As Label
    Friend WithEvents lbl_consigneQ8 As Label
    Friend WithEvents lbl_9 As Label
    Friend WithEvents lbl_somme5 As Label
    Friend WithEvents lbl_somme4 As Label
    Friend WithEvents lbl_somme3 As Label
    Friend WithEvents lbl_somme2 As Label
    Friend WithEvents lbl_700 As Label
    Friend WithEvents lbl_7000 As Label
    Friend WithEvents lbl_7 As Label
    Friend WithEvents lbl_30000 As Label
    Friend WithEvents lbl_somme1 As Label
    Friend WithEvents lbl_30 As Label
    Friend WithEvents lbl_chiffres As Label
    Friend WithEvents lbl_consigneQ9 As Label
    Friend WithEvents lbl_Q9 As Label
    Friend WithEvents cmd_aideQ9 As Button
    Friend WithEvents cmd_aideQ8 As Button
    Friend WithEvents cmd_aideQ6 As Button
    Friend WithEvents cmd_aideQ7 As Button
    Friend WithEvents lbl_secQ4 As Label
    Friend WithEvents lbl_deuxptQ4 As Label
    Friend WithEvents lbl_minQ4 As Label
    Friend WithEvents lbl_NumQ4 As Label
    Friend WithEvents cmd_Next As Button
    Friend WithEvents cmd_Back As Button
    Friend WithEvents TimerQ4 As Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDice1 = New System.Windows.Forms.TextBox()
        Me.txtDice2 = New System.Windows.Forms.TextBox()
        Me.txtDice3 = New System.Windows.Forms.TextBox()
        Me.txtDice4 = New System.Windows.Forms.TextBox()
        Me.txtDice5 = New System.Windows.Forms.TextBox()
        Me.btnKeep1 = New System.Windows.Forms.Button()
        Me.btnKeep2 = New System.Windows.Forms.Button()
        Me.btnKeep3 = New System.Windows.Forms.Button()
        Me.btnKeep4 = New System.Windows.Forms.Button()
        Me.btnKeep5 = New System.Windows.Forms.Button()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.chkAce = New System.Windows.Forms.CheckBox()
        Me.btnSaveDice = New System.Windows.Forms.Button()
        Me.lstCombos = New System.Windows.Forms.ListBox()
        Me.chkTwos = New System.Windows.Forms.CheckBox()
        Me.chkThrees = New System.Windows.Forms.CheckBox()
        Me.chkSmStraight = New System.Windows.Forms.CheckBox()
        Me.chkFullHouse = New System.Windows.Forms.CheckBox()
        Me.chk4ofaKind = New System.Windows.Forms.CheckBox()
        Me.chkLgStraight = New System.Windows.Forms.CheckBox()
        Me.chkScratch = New System.Windows.Forms.CheckBox()
        Me.chk3ofaKind = New System.Windows.Forms.CheckBox()
        Me.chkSixes = New System.Windows.Forms.CheckBox()
        Me.chkFives = New System.Windows.Forms.CheckBox()
        Me.chkFours = New System.Windows.Forms.CheckBox()
        Me.chkChance = New System.Windows.Forms.CheckBox()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtDice1
        '
        Me.txtDice1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDice1.Location = New System.Drawing.Point(24, 30)
        Me.txtDice1.Name = "txtDice1"
        Me.txtDice1.ReadOnly = True
        Me.txtDice1.Size = New System.Drawing.Size(100, 26)
        Me.txtDice1.TabIndex = 0
        '
        'txtDice2
        '
        Me.txtDice2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDice2.Location = New System.Drawing.Point(176, 30)
        Me.txtDice2.Name = "txtDice2"
        Me.txtDice2.ReadOnly = True
        Me.txtDice2.Size = New System.Drawing.Size(100, 26)
        Me.txtDice2.TabIndex = 1
        '
        'txtDice3
        '
        Me.txtDice3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDice3.Location = New System.Drawing.Point(321, 30)
        Me.txtDice3.Name = "txtDice3"
        Me.txtDice3.ReadOnly = True
        Me.txtDice3.Size = New System.Drawing.Size(100, 26)
        Me.txtDice3.TabIndex = 2
        '
        'txtDice4
        '
        Me.txtDice4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDice4.Location = New System.Drawing.Point(475, 30)
        Me.txtDice4.Name = "txtDice4"
        Me.txtDice4.ReadOnly = True
        Me.txtDice4.Size = New System.Drawing.Size(100, 26)
        Me.txtDice4.TabIndex = 3
        '
        'txtDice5
        '
        Me.txtDice5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDice5.Location = New System.Drawing.Point(618, 30)
        Me.txtDice5.Name = "txtDice5"
        Me.txtDice5.ReadOnly = True
        Me.txtDice5.Size = New System.Drawing.Size(100, 26)
        Me.txtDice5.TabIndex = 4
        '
        'btnKeep1
        '
        Me.btnKeep1.Location = New System.Drawing.Point(24, 80)
        Me.btnKeep1.Name = "btnKeep1"
        Me.btnKeep1.Size = New System.Drawing.Size(100, 40)
        Me.btnKeep1.TabIndex = 5
        Me.btnKeep1.Text = "Keep"
        Me.btnKeep1.UseVisualStyleBackColor = True
        '
        'btnKeep2
        '
        Me.btnKeep2.Location = New System.Drawing.Point(176, 80)
        Me.btnKeep2.Name = "btnKeep2"
        Me.btnKeep2.Size = New System.Drawing.Size(100, 40)
        Me.btnKeep2.TabIndex = 6
        Me.btnKeep2.Text = "Keep"
        Me.btnKeep2.UseVisualStyleBackColor = True
        '
        'btnKeep3
        '
        Me.btnKeep3.Location = New System.Drawing.Point(321, 80)
        Me.btnKeep3.Name = "btnKeep3"
        Me.btnKeep3.Size = New System.Drawing.Size(100, 40)
        Me.btnKeep3.TabIndex = 7
        Me.btnKeep3.Text = "Keep"
        Me.btnKeep3.UseVisualStyleBackColor = True
        '
        'btnKeep4
        '
        Me.btnKeep4.Location = New System.Drawing.Point(475, 80)
        Me.btnKeep4.Name = "btnKeep4"
        Me.btnKeep4.Size = New System.Drawing.Size(100, 40)
        Me.btnKeep4.TabIndex = 8
        Me.btnKeep4.Text = "Keep"
        Me.btnKeep4.UseVisualStyleBackColor = True
        '
        'btnKeep5
        '
        Me.btnKeep5.Location = New System.Drawing.Point(618, 80)
        Me.btnKeep5.Name = "btnKeep5"
        Me.btnKeep5.Size = New System.Drawing.Size(100, 40)
        Me.btnKeep5.TabIndex = 9
        Me.btnKeep5.Text = "Keep"
        Me.btnKeep5.UseVisualStyleBackColor = True
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(24, 159)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(196, 50)
        Me.btnRollDice.TabIndex = 10
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(358, 326)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(94, 20)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Total Score:"
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.Location = New System.Drawing.Point(471, 326)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(15, 20)
        Me.lblTotalScore.TabIndex = 12
        Me.lblTotalScore.Text = "*"
        '
        'chkAce
        '
        Me.chkAce.AutoSize = True
        Me.chkAce.Location = New System.Drawing.Point(24, 234)
        Me.chkAce.Name = "chkAce"
        Me.chkAce.Size = New System.Drawing.Size(71, 24)
        Me.chkAce.TabIndex = 13
        Me.chkAce.Text = "Aces"
        Me.chkAce.UseVisualStyleBackColor = True
        '
        'btnSaveDice
        '
        Me.btnSaveDice.Location = New System.Drawing.Point(535, 403)
        Me.btnSaveDice.Name = "btnSaveDice"
        Me.btnSaveDice.Size = New System.Drawing.Size(196, 44)
        Me.btnSaveDice.TabIndex = 14
        Me.btnSaveDice.Text = "Save Dice"
        Me.btnSaveDice.UseVisualStyleBackColor = True
        '
        'lstCombos
        '
        Me.lstCombos.FormattingEnabled = True
        Me.lstCombos.ItemHeight = 20
        Me.lstCombos.Location = New System.Drawing.Point(549, 154)
        Me.lstCombos.Name = "lstCombos"
        Me.lstCombos.Size = New System.Drawing.Size(169, 224)
        Me.lstCombos.TabIndex = 15
        '
        'chkTwos
        '
        Me.chkTwos.AutoSize = True
        Me.chkTwos.Location = New System.Drawing.Point(24, 265)
        Me.chkTwos.Name = "chkTwos"
        Me.chkTwos.Size = New System.Drawing.Size(72, 24)
        Me.chkTwos.TabIndex = 16
        Me.chkTwos.Text = "Twos"
        Me.chkTwos.UseVisualStyleBackColor = True
        '
        'chkThrees
        '
        Me.chkThrees.AutoSize = True
        Me.chkThrees.Location = New System.Drawing.Point(24, 295)
        Me.chkThrees.Name = "chkThrees"
        Me.chkThrees.Size = New System.Drawing.Size(84, 24)
        Me.chkThrees.TabIndex = 17
        Me.chkThrees.Text = "Threes"
        Me.chkThrees.UseVisualStyleBackColor = True
        '
        'chkSmStraight
        '
        Me.chkSmStraight.AutoSize = True
        Me.chkSmStraight.Location = New System.Drawing.Point(193, 326)
        Me.chkSmStraight.Name = "chkSmStraight"
        Me.chkSmStraight.Size = New System.Drawing.Size(134, 24)
        Me.chkSmStraight.TabIndex = 20
        Me.chkSmStraight.Text = "Small Straight"
        Me.chkSmStraight.UseVisualStyleBackColor = True
        '
        'chkFullHouse
        '
        Me.chkFullHouse.AutoSize = True
        Me.chkFullHouse.Location = New System.Drawing.Point(193, 296)
        Me.chkFullHouse.Name = "chkFullHouse"
        Me.chkFullHouse.Size = New System.Drawing.Size(111, 24)
        Me.chkFullHouse.TabIndex = 19
        Me.chkFullHouse.Text = "Full House"
        Me.chkFullHouse.UseVisualStyleBackColor = True
        '
        'chk4ofaKind
        '
        Me.chk4ofaKind.AutoSize = True
        Me.chk4ofaKind.Location = New System.Drawing.Point(193, 265)
        Me.chk4ofaKind.Name = "chk4ofaKind"
        Me.chk4ofaKind.Size = New System.Drawing.Size(134, 24)
        Me.chk4ofaKind.TabIndex = 18
        Me.chk4ofaKind.Text = "Four of a Kind"
        Me.chk4ofaKind.UseVisualStyleBackColor = True
        '
        'chkLgStraight
        '
        Me.chkLgStraight.AutoSize = True
        Me.chkLgStraight.Location = New System.Drawing.Point(193, 353)
        Me.chkLgStraight.Name = "chkLgStraight"
        Me.chkLgStraight.Size = New System.Drawing.Size(136, 24)
        Me.chkLgStraight.TabIndex = 23
        Me.chkLgStraight.Text = "Large Straight"
        Me.chkLgStraight.UseVisualStyleBackColor = True
        '
        'chkScratch
        '
        Me.chkScratch.AutoSize = True
        Me.chkScratch.Location = New System.Drawing.Point(193, 383)
        Me.chkScratch.Name = "chkScratch"
        Me.chkScratch.Size = New System.Drawing.Size(90, 24)
        Me.chkScratch.TabIndex = 22
        Me.chkScratch.Text = "Scratch"
        Me.chkScratch.UseVisualStyleBackColor = True
        '
        'chk3ofaKind
        '
        Me.chk3ofaKind.AutoSize = True
        Me.chk3ofaKind.Location = New System.Drawing.Point(193, 235)
        Me.chk3ofaKind.Name = "chk3ofaKind"
        Me.chk3ofaKind.Size = New System.Drawing.Size(142, 24)
        Me.chk3ofaKind.TabIndex = 21
        Me.chk3ofaKind.Text = "Three of a Kind"
        Me.chk3ofaKind.UseVisualStyleBackColor = True
        '
        'chkSixes
        '
        Me.chkSixes.AutoSize = True
        Me.chkSixes.Location = New System.Drawing.Point(24, 387)
        Me.chkSixes.Name = "chkSixes"
        Me.chkSixes.Size = New System.Drawing.Size(73, 24)
        Me.chkSixes.TabIndex = 26
        Me.chkSixes.Text = "Sixes"
        Me.chkSixes.UseVisualStyleBackColor = True
        '
        'chkFives
        '
        Me.chkFives.AutoSize = True
        Me.chkFives.Location = New System.Drawing.Point(24, 357)
        Me.chkFives.Name = "chkFives"
        Me.chkFives.Size = New System.Drawing.Size(72, 24)
        Me.chkFives.TabIndex = 25
        Me.chkFives.Text = "Fives"
        Me.chkFives.UseVisualStyleBackColor = True
        '
        'chkFours
        '
        Me.chkFours.AutoSize = True
        Me.chkFours.Location = New System.Drawing.Point(24, 326)
        Me.chkFours.Name = "chkFours"
        Me.chkFours.Size = New System.Drawing.Size(76, 24)
        Me.chkFours.TabIndex = 24
        Me.chkFours.Text = "Fours"
        Me.chkFours.UseVisualStyleBackColor = True
        '
        'chkChance
        '
        Me.chkChance.AutoSize = True
        Me.chkChance.Location = New System.Drawing.Point(193, 414)
        Me.chkChance.Name = "chkChance"
        Me.chkChance.Size = New System.Drawing.Size(94, 24)
        Me.chkChance.TabIndex = 27
        Me.chkChance.Text = "Chance!"
        Me.chkChance.UseVisualStyleBackColor = True
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.ItemHeight = 20
        Me.lstPlayers.Location = New System.Drawing.Point(356, 180)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(142, 104)
        Me.lstPlayers.TabIndex = 28
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 459)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.chkChance)
        Me.Controls.Add(Me.chkSixes)
        Me.Controls.Add(Me.chkFives)
        Me.Controls.Add(Me.chkFours)
        Me.Controls.Add(Me.chkLgStraight)
        Me.Controls.Add(Me.chkScratch)
        Me.Controls.Add(Me.chk3ofaKind)
        Me.Controls.Add(Me.chkSmStraight)
        Me.Controls.Add(Me.chkFullHouse)
        Me.Controls.Add(Me.chk4ofaKind)
        Me.Controls.Add(Me.chkThrees)
        Me.Controls.Add(Me.chkTwos)
        Me.Controls.Add(Me.lstCombos)
        Me.Controls.Add(Me.btnSaveDice)
        Me.Controls.Add(Me.chkAce)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.btnKeep5)
        Me.Controls.Add(Me.btnKeep4)
        Me.Controls.Add(Me.btnKeep3)
        Me.Controls.Add(Me.btnKeep2)
        Me.Controls.Add(Me.btnKeep1)
        Me.Controls.Add(Me.txtDice5)
        Me.Controls.Add(Me.txtDice4)
        Me.Controls.Add(Me.txtDice3)
        Me.Controls.Add(Me.txtDice2)
        Me.Controls.Add(Me.txtDice1)
        Me.Name = "MainFrm"
        Me.Text = "Chance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDice1 As TextBox
    Friend WithEvents txtDice2 As TextBox
    Friend WithEvents txtDice3 As TextBox
    Friend WithEvents txtDice4 As TextBox
    Friend WithEvents txtDice5 As TextBox
    Friend WithEvents btnKeep1 As Button
    Friend WithEvents btnKeep2 As Button
    Friend WithEvents btnKeep3 As Button
    Friend WithEvents btnKeep4 As Button
    Friend WithEvents btnKeep5 As Button
    Friend WithEvents btnRollDice As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents chkAce As CheckBox
    Friend WithEvents btnSaveDice As Button
    Friend WithEvents lstCombos As ListBox
    Friend WithEvents chkTwos As CheckBox
    Friend WithEvents chkThrees As CheckBox
    Friend WithEvents chkSmStraight As CheckBox
    Friend WithEvents chkFullHouse As CheckBox
    Friend WithEvents chk4ofaKind As CheckBox
    Friend WithEvents chkLgStraight As CheckBox
    Friend WithEvents chkScratch As CheckBox
    Friend WithEvents chk3ofaKind As CheckBox
    Friend WithEvents chkSixes As CheckBox
    Friend WithEvents chkFives As CheckBox
    Friend WithEvents chkFours As CheckBox
    Friend WithEvents chkChance As CheckBox
    Friend WithEvents lstPlayers As System.Windows.Forms.ListBox
End Class

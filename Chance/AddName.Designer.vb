<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddName
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
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblEntername = New System.Windows.Forms.Label()
        Me.btnAddName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(207, 75)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(150, 26)
        Me.txtPlayerName.TabIndex = 0
        '
        'lblEntername
        '
        Me.lblEntername.AutoSize = True
        Me.lblEntername.Location = New System.Drawing.Point(58, 78)
        Me.lblEntername.Name = "lblEntername"
        Me.lblEntername.Size = New System.Drawing.Size(94, 20)
        Me.lblEntername.TabIndex = 1
        Me.lblEntername.Text = "Enter Name"
        '
        'btnAddName
        '
        Me.btnAddName.Location = New System.Drawing.Point(26, 150)
        Me.btnAddName.Name = "btnAddName"
        Me.btnAddName.Size = New System.Drawing.Size(338, 49)
        Me.btnAddName.TabIndex = 2
        Me.btnAddName.Text = "Add to High Scores and Play Again"
        Me.btnAddName.UseVisualStyleBackColor = True
        '
        'AddName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 244)
        Me.Controls.Add(Me.btnAddName)
        Me.Controls.Add(Me.lblEntername)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Name = "AddName"
        Me.Text = "High Score List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents lblEntername As System.Windows.Forms.Label
    Friend WithEvents btnAddName As System.Windows.Forms.Button
End Class

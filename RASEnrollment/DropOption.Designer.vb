<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DropOption
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
        Me.OfficialDropRadioButton = New System.Windows.Forms.RadioButton
        Me.UnOfficialDropRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProceedButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OfficialDropRadioButton
        '
        Me.OfficialDropRadioButton.AutoSize = True
        Me.OfficialDropRadioButton.Checked = True
        Me.OfficialDropRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficialDropRadioButton.Location = New System.Drawing.Point(15, 19)
        Me.OfficialDropRadioButton.Name = "OfficialDropRadioButton"
        Me.OfficialDropRadioButton.Size = New System.Drawing.Size(96, 17)
        Me.OfficialDropRadioButton.TabIndex = 0
        Me.OfficialDropRadioButton.TabStop = True
        Me.OfficialDropRadioButton.Text = "Official Drop"
        Me.OfficialDropRadioButton.UseVisualStyleBackColor = True
        '
        'UnOfficialDropRadioButton
        '
        Me.UnOfficialDropRadioButton.AutoSize = True
        Me.UnOfficialDropRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnOfficialDropRadioButton.ForeColor = System.Drawing.Color.Red
        Me.UnOfficialDropRadioButton.Location = New System.Drawing.Point(117, 19)
        Me.UnOfficialDropRadioButton.Name = "UnOfficialDropRadioButton"
        Me.UnOfficialDropRadioButton.Size = New System.Drawing.Size(112, 17)
        Me.UnOfficialDropRadioButton.TabIndex = 1
        Me.UnOfficialDropRadioButton.Text = "UnOfficial Drop"
        Me.UnOfficialDropRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OfficialDropRadioButton)
        Me.GroupBox1.Controls.Add(Me.UnOfficialDropRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 54)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose on the following drop option"
        '
        'ProceedButton
        '
        Me.ProceedButton.Location = New System.Drawing.Point(45, 61)
        Me.ProceedButton.Name = "ProceedButton"
        Me.ProceedButton.Size = New System.Drawing.Size(75, 23)
        Me.ProceedButton.TabIndex = 3
        Me.ProceedButton.Text = "&Proceed"
        Me.ProceedButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(126, 61)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Cancel"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DropOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(251, 89)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ProceedButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DropOption"
        Me.Text = "DropOption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OfficialDropRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents UnOfficialDropRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ProceedButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class

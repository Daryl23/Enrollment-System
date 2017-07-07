<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NameLabel = New System.Windows.Forms.Label
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.UserTypeTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.CancelUserButton = New System.Windows.Forms.Button
        Me.SaveUserButton = New System.Windows.Forms.Button
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.ConfirmTextBox = New System.Windows.Forms.TextBox
        Me.UserListBox = New System.Windows.Forms.ListBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 0
        Me.ColumnHeader6.Text = "UserName"
        Me.ColumnHeader6.Width = 154
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 1
        Me.ColumnHeader7.Text = "Password"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 124
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 2
        Me.ColumnHeader13.Text = "UserType"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 120
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.DisplayIndex = 3
        Me.ColumnHeader14.Text = "Security Question"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 228
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.DisplayIndex = 4
        Me.ColumnHeader15.Text = "Answer"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 228
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.UserListBox)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(-2, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(395, 204)
        Me.GroupBox7.TabIndex = 28
        Me.GroupBox7.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.UserTypeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.CancelUserButton)
        Me.GroupBox1.Controls.Add(Me.SaveUserButton)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.ConfirmTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(144, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 185)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.Black
        Me.NameLabel.Location = New System.Drawing.Point(62, 21)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(38, 13)
        Me.NameLabel.TabIndex = 34
        Me.NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(109, 18)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(107, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.Enabled = False
        Me.UserTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeTextBox.Location = New System.Drawing.Point(109, 70)
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(107, 20)
        Me.UserTypeTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(43, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "UserName:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(47, 100)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 13)
        Me.Label43.TabIndex = 11
        Me.Label43.Text = "Password:"
        '
        'CancelUserButton
        '
        Me.CancelUserButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelUserButton.Location = New System.Drawing.Point(163, 149)
        Me.CancelUserButton.Name = "CancelUserButton"
        Me.CancelUserButton.Size = New System.Drawing.Size(53, 28)
        Me.CancelUserButton.TabIndex = 7
        Me.CancelUserButton.Text = "&Cancel"
        Me.CancelUserButton.UseVisualStyleBackColor = True
        '
        'SaveUserButton
        '
        Me.SaveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUserButton.Location = New System.Drawing.Point(104, 149)
        Me.SaveUserButton.Name = "SaveUserButton"
        Me.SaveUserButton.Size = New System.Drawing.Size(53, 28)
        Me.SaveUserButton.TabIndex = 6
        Me.SaveUserButton.Text = "&Save"
        Me.SaveUserButton.UseVisualStyleBackColor = True
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(109, 44)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(107, 20)
        Me.UserNameTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Confirm Password:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(47, 73)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 13)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "UserType:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(109, 97)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(107, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'ConfirmTextBox
        '
        Me.ConfirmTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmTextBox.Location = New System.Drawing.Point(109, 123)
        Me.ConfirmTextBox.Name = "ConfirmTextBox"
        Me.ConfirmTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmTextBox.Size = New System.Drawing.Size(107, 20)
        Me.ConfirmTextBox.TabIndex = 5
        '
        'UserListBox
        '
        Me.UserListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserListBox.FormattingEnabled = True
        Me.UserListBox.Location = New System.Drawing.Point(6, 36)
        Me.UserListBox.Name = "UserListBox"
        Me.UserListBox.Size = New System.Drawing.Size(132, 160)
        Me.UserListBox.TabIndex = 33
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(6, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(132, 29)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "New User:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-2, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(395, 25)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "Users Management"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(154, 224)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 39)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "&Main"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(394, 264)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents CancelUserButton As System.Windows.Forms.Button
    Friend WithEvents SaveUserButton As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConfirmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserListBox As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents UserTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolYear
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
        Me.components = New System.ComponentModel.Container
        Me.BackButton = New System.Windows.Forms.Button
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.GradingsDomainUpDown = New System.Windows.Forms.DomainUpDown
        Me.SYTypeComboBox = New System.Windows.Forms.ComboBox
        Me.SYComboBox = New System.Windows.Forms.ComboBox
        Me.EditSYButton = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.EPGroupBox = New System.Windows.Forms.GroupBox
        Me.EnrollmentPeriodToDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.EnrollmentPeriodFromDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NewSYButton = New System.Windows.Forms.Button
        Me.SaveSYButton = New System.Windows.Forms.Button
        Me.OpenButton = New System.Windows.Forms.Button
        Me.GradingGroupBox = New System.Windows.Forms.GroupBox
        Me.GradingPanel = New System.Windows.Forms.Panel
        Me.SYGroupBox = New System.Windows.Forms.GroupBox
        Me.SchoolYearToDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SchoolYearFromDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SettingsGroupBox.SuspendLayout()
        Me.EPGroupBox.SuspendLayout()
        Me.GradingGroupBox.SuspendLayout()
        Me.SYGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Black
        Me.BackButton.Location = New System.Drawing.Point(118, 335)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(76, 46)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "&Main"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.GradingsDomainUpDown)
        Me.SettingsGroupBox.Controls.Add(Me.SYTypeComboBox)
        Me.SettingsGroupBox.Controls.Add(Me.SYComboBox)
        Me.SettingsGroupBox.Controls.Add(Me.EditSYButton)
        Me.SettingsGroupBox.Controls.Add(Me.TextBox2)
        Me.SettingsGroupBox.Controls.Add(Me.ExitButton)
        Me.SettingsGroupBox.Controls.Add(Me.EPGroupBox)
        Me.SettingsGroupBox.Controls.Add(Me.NewSYButton)
        Me.SettingsGroupBox.Controls.Add(Me.SaveSYButton)
        Me.SettingsGroupBox.Controls.Add(Me.OpenButton)
        Me.SettingsGroupBox.Controls.Add(Me.GradingGroupBox)
        Me.SettingsGroupBox.Controls.Add(Me.SYGroupBox)
        Me.SettingsGroupBox.Controls.Add(Me.TextBox3)
        Me.SettingsGroupBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsGroupBox.ForeColor = System.Drawing.Color.Black
        Me.SettingsGroupBox.Location = New System.Drawing.Point(0, 15)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Size = New System.Drawing.Size(316, 317)
        Me.SettingsGroupBox.TabIndex = 15
        Me.SettingsGroupBox.TabStop = False
        '
        'GradingsDomainUpDown
        '
        Me.GradingsDomainUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingsDomainUpDown.Location = New System.Drawing.Point(101, 138)
        Me.GradingsDomainUpDown.Name = "GradingsDomainUpDown"
        Me.GradingsDomainUpDown.Size = New System.Drawing.Size(35, 20)
        Me.GradingsDomainUpDown.TabIndex = 16
        Me.GradingsDomainUpDown.Text = "0"
        '
        'SYTypeComboBox
        '
        Me.SYTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYTypeComboBox.FormattingEnabled = True
        Me.SYTypeComboBox.Items.AddRange(New Object() {"Regular"})
        Me.SYTypeComboBox.Location = New System.Drawing.Point(146, 32)
        Me.SYTypeComboBox.Name = "SYTypeComboBox"
        Me.SYTypeComboBox.Size = New System.Drawing.Size(94, 21)
        Me.SYTypeComboBox.TabIndex = 65
        '
        'SYComboBox
        '
        Me.SYComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYComboBox.FormattingEnabled = True
        Me.SYComboBox.Location = New System.Drawing.Point(5, 32)
        Me.SYComboBox.Name = "SYComboBox"
        Me.SYComboBox.Size = New System.Drawing.Size(137, 21)
        Me.SYComboBox.TabIndex = 3
        '
        'EditSYButton
        '
        Me.EditSYButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSYButton.ForeColor = System.Drawing.Color.Black
        Me.EditSYButton.Location = New System.Drawing.Point(227, 186)
        Me.EditSYButton.Name = "EditSYButton"
        Me.EditSYButton.Size = New System.Drawing.Size(82, 41)
        Me.EditSYButton.TabIndex = 2
        Me.EditSYButton.Text = "&Edit School Year"
        Me.EditSYButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(3, 15)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(141, 40)
        Me.TextBox2.TabIndex = 62
        Me.TextBox2.Text = "Opened School Year"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(227, 266)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 41)
        Me.ExitButton.TabIndex = 61
        Me.ExitButton.Text = "&Cancel"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EPGroupBox
        '
        Me.EPGroupBox.Controls.Add(Me.EnrollmentPeriodToDateTimePicker)
        Me.EPGroupBox.Controls.Add(Me.Label3)
        Me.EPGroupBox.Controls.Add(Me.Label4)
        Me.EPGroupBox.Controls.Add(Me.EnrollmentPeriodFromDateTimePicker)
        Me.EPGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EPGroupBox.ForeColor = System.Drawing.Color.Black
        Me.EPGroupBox.Location = New System.Drawing.Point(3, 61)
        Me.EPGroupBox.Name = "EPGroupBox"
        Me.EPGroupBox.Size = New System.Drawing.Size(154, 76)
        Me.EPGroupBox.TabIndex = 13
        Me.EPGroupBox.TabStop = False
        Me.EPGroupBox.Text = "Enrollment Period"
        '
        'EnrollmentPeriodToDateTimePicker
        '
        Me.EnrollmentPeriodToDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentPeriodToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EnrollmentPeriodToDateTimePicker.Location = New System.Drawing.Point(45, 46)
        Me.EnrollmentPeriodToDateTimePicker.Name = "EnrollmentPeriodToDateTimePicker"
        Me.EnrollmentPeriodToDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.EnrollmentPeriodToDateTimePicker.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "From:"
        '
        'EnrollmentPeriodFromDateTimePicker
        '
        Me.EnrollmentPeriodFromDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentPeriodFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EnrollmentPeriodFromDateTimePicker.Location = New System.Drawing.Point(45, 20)
        Me.EnrollmentPeriodFromDateTimePicker.Name = "EnrollmentPeriodFromDateTimePicker"
        Me.EnrollmentPeriodFromDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.EnrollmentPeriodFromDateTimePicker.TabIndex = 0
        '
        'NewSYButton
        '
        Me.NewSYButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewSYButton.ForeColor = System.Drawing.Color.Black
        Me.NewSYButton.Location = New System.Drawing.Point(227, 146)
        Me.NewSYButton.Name = "NewSYButton"
        Me.NewSYButton.Size = New System.Drawing.Size(82, 41)
        Me.NewSYButton.TabIndex = 0
        Me.NewSYButton.Text = "&New School Year"
        Me.NewSYButton.UseVisualStyleBackColor = True
        '
        'SaveSYButton
        '
        Me.SaveSYButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSYButton.ForeColor = System.Drawing.Color.Black
        Me.SaveSYButton.Location = New System.Drawing.Point(227, 226)
        Me.SaveSYButton.Name = "SaveSYButton"
        Me.SaveSYButton.Size = New System.Drawing.Size(82, 41)
        Me.SaveSYButton.TabIndex = 15
        Me.SaveSYButton.Text = "&Save School Year"
        Me.SaveSYButton.UseVisualStyleBackColor = True
        '
        'OpenButton
        '
        Me.OpenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenButton.ForeColor = System.Drawing.Color.Black
        Me.OpenButton.Location = New System.Drawing.Point(241, 14)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(65, 41)
        Me.OpenButton.TabIndex = 4
        Me.OpenButton.Text = "&Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'GradingGroupBox
        '
        Me.GradingGroupBox.Controls.Add(Me.GradingPanel)
        Me.GradingGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingGroupBox.ForeColor = System.Drawing.Color.Black
        Me.GradingGroupBox.Location = New System.Drawing.Point(5, 143)
        Me.GradingGroupBox.Name = "GradingGroupBox"
        Me.GradingGroupBox.Size = New System.Drawing.Size(219, 166)
        Me.GradingGroupBox.TabIndex = 63
        Me.GradingGroupBox.TabStop = False
        Me.GradingGroupBox.Text = "Grading Period"
        '
        'GradingPanel
        '
        Me.GradingPanel.AutoScroll = True
        Me.GradingPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingPanel.Location = New System.Drawing.Point(6, 15)
        Me.GradingPanel.Name = "GradingPanel"
        Me.GradingPanel.Size = New System.Drawing.Size(210, 145)
        Me.GradingPanel.TabIndex = 0
        '
        'SYGroupBox
        '
        Me.SYGroupBox.Controls.Add(Me.SchoolYearToDateTimePicker)
        Me.SYGroupBox.Controls.Add(Me.Label2)
        Me.SYGroupBox.Controls.Add(Me.Label1)
        Me.SYGroupBox.Controls.Add(Me.SchoolYearFromDateTimePicker)
        Me.SYGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYGroupBox.ForeColor = System.Drawing.Color.Black
        Me.SYGroupBox.Location = New System.Drawing.Point(155, 61)
        Me.SYGroupBox.Name = "SYGroupBox"
        Me.SYGroupBox.Size = New System.Drawing.Size(154, 76)
        Me.SYGroupBox.TabIndex = 12
        Me.SYGroupBox.TabStop = False
        Me.SYGroupBox.Text = "School Year Period"
        '
        'SchoolYearToDateTimePicker
        '
        Me.SchoolYearToDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolYearToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SchoolYearToDateTimePicker.Location = New System.Drawing.Point(45, 45)
        Me.SchoolYearToDateTimePicker.Name = "SchoolYearToDateTimePicker"
        Me.SchoolYearToDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.SchoolYearToDateTimePicker.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'SchoolYearFromDateTimePicker
        '
        Me.SchoolYearFromDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolYearFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SchoolYearFromDateTimePicker.Location = New System.Drawing.Point(45, 19)
        Me.SchoolYearFromDateTimePicker.Name = "SchoolYearFromDateTimePicker"
        Me.SchoolYearFromDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.SchoolYearFromDateTimePicker.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(144, 15)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(98, 40)
        Me.TextBox3.TabIndex = 66
        Me.TextBox3.Text = "Type"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 25)
        Me.TextBox1.TabIndex = 43
        Me.TextBox1.Text = "School Year"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SchoolYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(316, 381)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.Name = "SchoolYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Year"
        Me.SettingsGroupBox.ResumeLayout(False)
        Me.SettingsGroupBox.PerformLayout()
        Me.EPGroupBox.ResumeLayout(False)
        Me.EPGroupBox.PerformLayout()
        Me.GradingGroupBox.ResumeLayout(False)
        Me.SYGroupBox.ResumeLayout(False)
        Me.SYGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EnrollmentPeriodFromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SYGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SchoolYearFromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EditSYButton As System.Windows.Forms.Button
    Friend WithEvents NewSYButton As System.Windows.Forms.Button
    Friend WithEvents SYComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveSYButton As System.Windows.Forms.Button
    Friend WithEvents GradingsDomainUpDown As System.Windows.Forms.DomainUpDown
    Friend WithEvents EnrollmentPeriodToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SchoolYearToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EPGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents GradingPanel As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GradingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SYTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class

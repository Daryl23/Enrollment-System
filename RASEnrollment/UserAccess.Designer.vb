<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccess
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
        Me.ExitButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LimitTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ClearButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.AccountCheckBox = New System.Windows.Forms.CheckBox
        Me.ReservedCheckBox = New System.Windows.Forms.CheckBox
        Me.GradesCheckBox = New System.Windows.Forms.CheckBox
        Me.ClassCheckBox = New System.Windows.Forms.CheckBox
        Me.UserTypeTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.MaintainanceBackupCheckBox = New System.Windows.Forms.CheckBox
        Me.MaintainanceWebsiteCheckBox = New System.Windows.Forms.CheckBox
        Me.MaintainanceFeeCheckBox = New System.Windows.Forms.CheckBox
        Me.MaintainanceTeacherCheckBox = New System.Windows.Forms.CheckBox
        Me.MaintainanceYearCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ReportsCheckBox = New System.Windows.Forms.CheckBox
        Me.PaymentCheckBox = New System.Windows.Forms.CheckBox
        Me.AssessmentCheckBox = New System.Windows.Forms.CheckBox
        Me.RegistrationCheckBox = New System.Windows.Forms.CheckBox
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.UsersListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.DeleteUserButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SYEditingCheckBox = New System.Windows.Forms.CheckBox
        Me.SYViewCheckBox = New System.Windows.Forms.CheckBox
        Me.CheckAllCheckBox = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(194, 316)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 41)
        Me.ExitButton.TabIndex = 52
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(6, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(464, 25)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Text = "Year"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LimitTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.UserTypeTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.UsersListView)
        Me.GroupBox1.Controls.Add(Me.DeleteUserButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.CheckAllCheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 289)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'LimitTextBox
        '
        Me.LimitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimitTextBox.Location = New System.Drawing.Point(296, 36)
        Me.LimitTextBox.MaxLength = 20
        Me.LimitTextBox.Name = "LimitTextBox"
        Me.LimitTextBox.Size = New System.Drawing.Size(20, 20)
        Me.LimitTextBox.TabIndex = 42
        Me.LimitTextBox.Text = "1"
        Me.LimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Limit:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(410, 260)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(40, 27)
        Me.ClearButton.TabIndex = 41
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(324, 260)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(87, 27)
        Me.SaveButton.TabIndex = 39
        Me.SaveButton.Text = "&Save Changes"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "UserType/ Position:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AccountCheckBox)
        Me.GroupBox5.Controls.Add(Me.ReservedCheckBox)
        Me.GroupBox5.Controls.Add(Me.GradesCheckBox)
        Me.GroupBox5.Controls.Add(Me.ClassCheckBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(317, 144)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 115)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Manage"
        '
        'AccountCheckBox
        '
        Me.AccountCheckBox.AutoSize = True
        Me.AccountCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountCheckBox.Location = New System.Drawing.Point(6, 89)
        Me.AccountCheckBox.Name = "AccountCheckBox"
        Me.AccountCheckBox.Size = New System.Drawing.Size(71, 17)
        Me.AccountCheckBox.TabIndex = 3
        Me.AccountCheckBox.Text = "Accounts"
        Me.AccountCheckBox.UseVisualStyleBackColor = True
        '
        'ReservedCheckBox
        '
        Me.ReservedCheckBox.AutoSize = True
        Me.ReservedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservedCheckBox.Location = New System.Drawing.Point(6, 66)
        Me.ReservedCheckBox.Name = "ReservedCheckBox"
        Me.ReservedCheckBox.Size = New System.Drawing.Size(117, 17)
        Me.ReservedCheckBox.TabIndex = 2
        Me.ReservedCheckBox.Text = "Reserved Students"
        Me.ReservedCheckBox.UseVisualStyleBackColor = True
        '
        'GradesCheckBox
        '
        Me.GradesCheckBox.AutoSize = True
        Me.GradesCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradesCheckBox.Location = New System.Drawing.Point(6, 43)
        Me.GradesCheckBox.Name = "GradesCheckBox"
        Me.GradesCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.GradesCheckBox.TabIndex = 1
        Me.GradesCheckBox.Text = "Grades"
        Me.GradesCheckBox.UseVisualStyleBackColor = True
        '
        'ClassCheckBox
        '
        Me.ClassCheckBox.AutoSize = True
        Me.ClassCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.ClassCheckBox.Name = "ClassCheckBox"
        Me.ClassCheckBox.Size = New System.Drawing.Size(51, 17)
        Me.ClassCheckBox.TabIndex = 0
        Me.ClassCheckBox.Text = "Class"
        Me.ClassCheckBox.UseVisualStyleBackColor = True
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeTextBox.Location = New System.Drawing.Point(194, 36)
        Me.UserTypeTextBox.MaxLength = 20
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(69, 20)
        Me.UserTypeTextBox.TabIndex = 37
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MaintainanceBackupCheckBox)
        Me.GroupBox4.Controls.Add(Me.MaintainanceWebsiteCheckBox)
        Me.GroupBox4.Controls.Add(Me.MaintainanceFeeCheckBox)
        Me.GroupBox4.Controls.Add(Me.MaintainanceTeacherCheckBox)
        Me.GroupBox4.Controls.Add(Me.MaintainanceYearCheckBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(317, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(137, 133)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Maintainance"
        '
        'MaintainanceBackupCheckBox
        '
        Me.MaintainanceBackupCheckBox.AutoSize = True
        Me.MaintainanceBackupCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintainanceBackupCheckBox.Location = New System.Drawing.Point(6, 112)
        Me.MaintainanceBackupCheckBox.Name = "MaintainanceBackupCheckBox"
        Me.MaintainanceBackupCheckBox.Size = New System.Drawing.Size(125, 17)
        Me.MaintainanceBackupCheckBox.TabIndex = 5
        Me.MaintainanceBackupCheckBox.Text = "Backup And Restore"
        Me.MaintainanceBackupCheckBox.UseVisualStyleBackColor = True
        '
        'MaintainanceWebsiteCheckBox
        '
        Me.MaintainanceWebsiteCheckBox.AutoSize = True
        Me.MaintainanceWebsiteCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintainanceWebsiteCheckBox.Location = New System.Drawing.Point(6, 89)
        Me.MaintainanceWebsiteCheckBox.Name = "MaintainanceWebsiteCheckBox"
        Me.MaintainanceWebsiteCheckBox.Size = New System.Drawing.Size(65, 17)
        Me.MaintainanceWebsiteCheckBox.TabIndex = 4
        Me.MaintainanceWebsiteCheckBox.Text = "Website"
        Me.MaintainanceWebsiteCheckBox.UseVisualStyleBackColor = True
        '
        'MaintainanceFeeCheckBox
        '
        Me.MaintainanceFeeCheckBox.AutoSize = True
        Me.MaintainanceFeeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintainanceFeeCheckBox.Location = New System.Drawing.Point(6, 43)
        Me.MaintainanceFeeCheckBox.Name = "MaintainanceFeeCheckBox"
        Me.MaintainanceFeeCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.MaintainanceFeeCheckBox.TabIndex = 3
        Me.MaintainanceFeeCheckBox.Text = "Fees Information"
        Me.ToolTip1.SetToolTip(Me.MaintainanceFeeCheckBox, "Fees Per level, Reservation Fee, Unit Cost")
        Me.MaintainanceFeeCheckBox.UseVisualStyleBackColor = True
        '
        'MaintainanceTeacherCheckBox
        '
        Me.MaintainanceTeacherCheckBox.AutoSize = True
        Me.MaintainanceTeacherCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintainanceTeacherCheckBox.Location = New System.Drawing.Point(6, 66)
        Me.MaintainanceTeacherCheckBox.Name = "MaintainanceTeacherCheckBox"
        Me.MaintainanceTeacherCheckBox.Size = New System.Drawing.Size(112, 17)
        Me.MaintainanceTeacherCheckBox.TabIndex = 1
        Me.MaintainanceTeacherCheckBox.Text = "Teachers/ Rooms"
        Me.MaintainanceTeacherCheckBox.UseVisualStyleBackColor = True
        '
        'MaintainanceYearCheckBox
        '
        Me.MaintainanceYearCheckBox.AutoSize = True
        Me.MaintainanceYearCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintainanceYearCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.MaintainanceYearCheckBox.Name = "MaintainanceYearCheckBox"
        Me.MaintainanceYearCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.MaintainanceYearCheckBox.TabIndex = 0
        Me.MaintainanceYearCheckBox.Text = "Year Information"
        Me.ToolTip1.SetToolTip(Me.MaintainanceYearCheckBox, "Year, Section, Subjects")
        Me.MaintainanceYearCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ReportsCheckBox)
        Me.GroupBox2.Controls.Add(Me.PaymentCheckBox)
        Me.GroupBox2.Controls.Add(Me.AssessmentCheckBox)
        Me.GroupBox2.Controls.Add(Me.RegistrationCheckBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(194, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 115)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transactions"
        '
        'ReportsCheckBox
        '
        Me.ReportsCheckBox.AutoSize = True
        Me.ReportsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsCheckBox.Location = New System.Drawing.Point(6, 89)
        Me.ReportsCheckBox.Name = "ReportsCheckBox"
        Me.ReportsCheckBox.Size = New System.Drawing.Size(111, 17)
        Me.ReportsCheckBox.TabIndex = 3
        Me.ReportsCheckBox.Text = "Records/ Reports"
        Me.ReportsCheckBox.UseVisualStyleBackColor = True
        '
        'PaymentCheckBox
        '
        Me.PaymentCheckBox.AutoSize = True
        Me.PaymentCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentCheckBox.Location = New System.Drawing.Point(6, 66)
        Me.PaymentCheckBox.Name = "PaymentCheckBox"
        Me.PaymentCheckBox.Size = New System.Drawing.Size(67, 17)
        Me.PaymentCheckBox.TabIndex = 2
        Me.PaymentCheckBox.Text = "Payment"
        Me.PaymentCheckBox.UseVisualStyleBackColor = True
        '
        'AssessmentCheckBox
        '
        Me.AssessmentCheckBox.AutoSize = True
        Me.AssessmentCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssessmentCheckBox.Location = New System.Drawing.Point(6, 43)
        Me.AssessmentCheckBox.Name = "AssessmentCheckBox"
        Me.AssessmentCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.AssessmentCheckBox.TabIndex = 1
        Me.AssessmentCheckBox.Text = "Assessment"
        Me.AssessmentCheckBox.UseVisualStyleBackColor = True
        '
        'RegistrationCheckBox
        '
        Me.RegistrationCheckBox.AutoSize = True
        Me.RegistrationCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrationCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.RegistrationCheckBox.Name = "RegistrationCheckBox"
        Me.RegistrationCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.RegistrationCheckBox.TabIndex = 0
        Me.RegistrationCheckBox.Text = "Registration"
        Me.RegistrationCheckBox.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCheckBox.Location = New System.Drawing.Point(12, 20)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 33
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'UsersListView
        '
        Me.UsersListView.BackColor = System.Drawing.Color.White
        Me.UsersListView.CheckBoxes = True
        Me.UsersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.UsersListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsersListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersListView.FullRowSelect = True
        Me.UsersListView.Location = New System.Drawing.Point(6, 42)
        Me.UsersListView.Name = "UsersListView"
        Me.UsersListView.Size = New System.Drawing.Size(182, 241)
        Me.UsersListView.TabIndex = 16
        Me.UsersListView.UseCompatibleStateImageBehavior = False
        Me.UsersListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 25
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 27
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Users"
        Me.ColumnHeader3.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Limit"
        Me.ColumnHeader4.Width = 37
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteUserButton.Location = New System.Drawing.Point(33, 13)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(55, 27)
        Me.DeleteUserButton.TabIndex = 32
        Me.DeleteUserButton.Text = "&Delete"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SYEditingCheckBox)
        Me.GroupBox3.Controls.Add(Me.SYViewCheckBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(194, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(122, 65)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "School Year"
        '
        'SYEditingCheckBox
        '
        Me.SYEditingCheckBox.AutoSize = True
        Me.SYEditingCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYEditingCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.SYEditingCheckBox.Name = "SYEditingCheckBox"
        Me.SYEditingCheckBox.Size = New System.Drawing.Size(99, 17)
        Me.SYEditingCheckBox.TabIndex = 1
        Me.SYEditingCheckBox.Text = "Adding/ Editing"
        Me.SYEditingCheckBox.UseVisualStyleBackColor = True
        '
        'SYViewCheckBox
        '
        Me.SYViewCheckBox.AutoSize = True
        Me.SYViewCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYViewCheckBox.Location = New System.Drawing.Point(6, 43)
        Me.SYViewCheckBox.Name = "SYViewCheckBox"
        Me.SYViewCheckBox.Size = New System.Drawing.Size(111, 17)
        Me.SYViewCheckBox.TabIndex = 0
        Me.SYViewCheckBox.Text = "Opening/ Viewing"
        Me.SYViewCheckBox.UseVisualStyleBackColor = True
        '
        'CheckAllCheckBox
        '
        Me.CheckAllCheckBox.AutoSize = True
        Me.CheckAllCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAllCheckBox.Location = New System.Drawing.Point(200, 266)
        Me.CheckAllCheckBox.Name = "CheckAllCheckBox"
        Me.CheckAllCheckBox.Size = New System.Drawing.Size(123, 17)
        Me.CheckAllCheckBox.TabIndex = 40
        Me.CheckAllCheckBox.Text = "Check/ Uncheck All"
        Me.CheckAllCheckBox.UseVisualStyleBackColor = True
        '
        'UserAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(468, 357)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserAccess"
        Me.Text = "UserAccess"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UsersListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteUserButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents MaintainanceFeeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MaintainanceTeacherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MaintainanceYearCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReportsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PaymentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AssessmentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RegistrationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SYEditingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SYViewCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents AccountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReservedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GradesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CheckAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MaintainanceWebsiteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaintainanceBackupCheckBox As System.Windows.Forms.CheckBox
End Class

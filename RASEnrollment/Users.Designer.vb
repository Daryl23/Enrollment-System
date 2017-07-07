<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.UsersManagementGroupBox = New System.Windows.Forms.GroupBox
        Me.WithAccountGroupBox = New System.Windows.Forms.GroupBox
        Me.DeleteAccountButton = New System.Windows.Forms.Button
        Me.CheckWithCheckBox = New System.Windows.Forms.CheckBox
        Me.UserListView = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.WithoutAccountGroupBox = New System.Windows.Forms.GroupBox
        Me.CheckOutCheckBox = New System.Windows.Forms.CheckBox
        Me.CreateUserButton = New System.Windows.Forms.Button
        Me.UserWithoutListView = New System.Windows.Forms.ListView
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox24 = New System.Windows.Forms.GroupBox
        Me.UpdateAccountButton = New System.Windows.Forms.Button
        Me.NewAccountButton = New System.Windows.Forms.Button
        Me.GroupBox28 = New System.Windows.Forms.GroupBox
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CreateAccountButton = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.WOListView = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.WithListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.CloseButton = New System.Windows.Forms.Button
        Me.UserAccessButton = New System.Windows.Forms.Button
        Me.UsersManagementGroupBox.SuspendLayout()
        Me.WithAccountGroupBox.SuspendLayout()
        Me.WithoutAccountGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsersManagementGroupBox
        '
        Me.UsersManagementGroupBox.Controls.Add(Me.WithAccountGroupBox)
        Me.UsersManagementGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.UsersManagementGroupBox.Name = "UsersManagementGroupBox"
        Me.UsersManagementGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.UsersManagementGroupBox.TabIndex = 0
        Me.UsersManagementGroupBox.TabStop = False
        '
        'WithAccountGroupBox
        '
        Me.WithAccountGroupBox.Controls.Add(Me.DeleteAccountButton)
        Me.WithAccountGroupBox.Controls.Add(Me.CheckWithCheckBox)
        Me.WithAccountGroupBox.Controls.Add(Me.UserListView)
        Me.WithAccountGroupBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithAccountGroupBox.Location = New System.Drawing.Point(6, 139)
        Me.WithAccountGroupBox.Name = "WithAccountGroupBox"
        Me.WithAccountGroupBox.Size = New System.Drawing.Size(562, 395)
        Me.WithAccountGroupBox.TabIndex = 32
        Me.WithAccountGroupBox.TabStop = False
        Me.WithAccountGroupBox.Text = "With Accounts"
        '
        'DeleteAccountButton
        '
        Me.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteAccountButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteAccountButton.Location = New System.Drawing.Point(89, 21)
        Me.DeleteAccountButton.Name = "DeleteAccountButton"
        Me.DeleteAccountButton.Size = New System.Drawing.Size(58, 41)
        Me.DeleteAccountButton.TabIndex = 36
        Me.DeleteAccountButton.Text = "Delete  Account"
        Me.DeleteAccountButton.UseVisualStyleBackColor = True
        '
        'CheckWithCheckBox
        '
        Me.CheckWithCheckBox.AutoSize = True
        Me.CheckWithCheckBox.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckWithCheckBox.ForeColor = System.Drawing.Color.Black
        Me.CheckWithCheckBox.Location = New System.Drawing.Point(11, 25)
        Me.CheckWithCheckBox.Name = "CheckWithCheckBox"
        Me.CheckWithCheckBox.Size = New System.Drawing.Size(82, 36)
        Me.CheckWithCheckBox.TabIndex = 35
        Me.CheckWithCheckBox.Text = "Check/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck All"
        Me.CheckWithCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckWithCheckBox.UseVisualStyleBackColor = True
        '
        'UserListView
        '
        Me.UserListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.UserListView.BackColor = System.Drawing.SystemColors.Control
        Me.UserListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserListView.CheckBoxes = True
        Me.UserListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17})
        Me.UserListView.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserListView.FullRowSelect = True
        Me.UserListView.GridLines = True
        Me.UserListView.HotTracking = True
        Me.UserListView.HoverSelection = True
        Me.UserListView.Location = New System.Drawing.Point(9, 65)
        Me.UserListView.Name = "UserListView"
        Me.UserListView.Size = New System.Drawing.Size(550, 324)
        Me.UserListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.UserListView.TabIndex = 26
        Me.UserListView.UseCompatibleStateImageBehavior = False
        Me.UserListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 119
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Name"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 146
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "User Name"
        Me.ColumnHeader14.Width = 99
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "User Type"
        Me.ColumnHeader15.Width = 94
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Password"
        Me.ColumnHeader17.Width = 92
        '
        'WithoutAccountGroupBox
        '
        Me.WithoutAccountGroupBox.Controls.Add(Me.CheckOutCheckBox)
        Me.WithoutAccountGroupBox.Controls.Add(Me.CreateUserButton)
        Me.WithoutAccountGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.WithoutAccountGroupBox.Name = "WithoutAccountGroupBox"
        Me.WithoutAccountGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.WithoutAccountGroupBox.TabIndex = 0
        Me.WithoutAccountGroupBox.TabStop = False
        '
        'CheckOutCheckBox
        '
        Me.CheckOutCheckBox.AutoSize = True
        Me.CheckOutCheckBox.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutCheckBox.ForeColor = System.Drawing.Color.Black
        Me.CheckOutCheckBox.Location = New System.Drawing.Point(6, 24)
        Me.CheckOutCheckBox.Name = "CheckOutCheckBox"
        Me.CheckOutCheckBox.Size = New System.Drawing.Size(82, 36)
        Me.CheckOutCheckBox.TabIndex = 37
        Me.CheckOutCheckBox.Text = "Check/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck All"
        Me.CheckOutCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckOutCheckBox.UseVisualStyleBackColor = True
        '
        'CreateUserButton
        '
        Me.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateUserButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateUserButton.Location = New System.Drawing.Point(87, 20)
        Me.CreateUserButton.Name = "CreateUserButton"
        Me.CreateUserButton.Size = New System.Drawing.Size(58, 41)
        Me.CreateUserButton.TabIndex = 34
        Me.CreateUserButton.Text = "Create Account"
        Me.CreateUserButton.UseVisualStyleBackColor = True
        '
        'UserWithoutListView
        '
        Me.UserWithoutListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.UserWithoutListView.BackColor = System.Drawing.SystemColors.Control
        Me.UserWithoutListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserWithoutListView.CheckBoxes = True
        Me.UserWithoutListView.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserWithoutListView.GridLines = True
        Me.UserWithoutListView.HotTracking = True
        Me.UserWithoutListView.HoverSelection = True
        Me.UserWithoutListView.Location = New System.Drawing.Point(0, 0)
        Me.UserWithoutListView.Name = "UserWithoutListView"
        Me.UserWithoutListView.Size = New System.Drawing.Size(121, 97)
        Me.UserWithoutListView.TabIndex = 0
        Me.UserWithoutListView.UseCompatibleStateImageBehavior = False
        Me.UserWithoutListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 0
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 140
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.DisplayIndex = 1
        Me.ColumnHeader13.Text = "Name"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 141
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox24)
        Me.GroupBox1.Controls.Add(Me.Label77)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 521)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Without Accounts"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox24
        '
        Me.GroupBox24.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox24.Controls.Add(Me.UpdateAccountButton)
        Me.GroupBox24.Controls.Add(Me.NewAccountButton)
        Me.GroupBox24.Controls.Add(Me.GroupBox28)
        Me.GroupBox24.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox24.ForeColor = System.Drawing.Color.Black
        Me.GroupBox24.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(233, 96)
        Me.GroupBox24.TabIndex = 33
        Me.GroupBox24.TabStop = False
        '
        'UpdateAccountButton
        '
        Me.UpdateAccountButton.Enabled = False
        Me.UpdateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateAccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAccountButton.Location = New System.Drawing.Point(7, 48)
        Me.UpdateAccountButton.Name = "UpdateAccountButton"
        Me.UpdateAccountButton.Size = New System.Drawing.Size(65, 37)
        Me.UpdateAccountButton.TabIndex = 29
        Me.UpdateAccountButton.Text = "Update Account"
        Me.UpdateAccountButton.UseVisualStyleBackColor = True
        '
        'NewAccountButton
        '
        Me.NewAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NewAccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewAccountButton.Location = New System.Drawing.Point(7, 12)
        Me.NewAccountButton.Name = "NewAccountButton"
        Me.NewAccountButton.Size = New System.Drawing.Size(65, 37)
        Me.NewAccountButton.TabIndex = 15
        Me.NewAccountButton.Text = "&New Account"
        Me.NewAccountButton.UseVisualStyleBackColor = True
        '
        'GroupBox28
        '
        Me.GroupBox28.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox28.Controls.Add(Me.UserTypeComboBox)
        Me.GroupBox28.Controls.Add(Me.Label22)
        Me.GroupBox28.Controls.Add(Me.TextBox1)
        Me.GroupBox28.ForeColor = System.Drawing.Color.Black
        Me.GroupBox28.Location = New System.Drawing.Point(78, 14)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(137, 71)
        Me.GroupBox28.TabIndex = 31
        Me.GroupBox28.TabStop = False
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UserTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Location = New System.Drawing.Point(54, 19)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(73, 21)
        Me.UserTypeComboBox.TabIndex = 21
        Me.UserTypeComboBox.Text = "Student"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(5, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Sort by:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "Search by Name..."
        Me.TextBox1.Visible = False
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(237, 18)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(524, 25)
        Me.Label77.TabIndex = 157
        Me.Label77.Text = "With Accounts"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CreateAccountButton)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.WOListView)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 395)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'CreateAccountButton
        '
        Me.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CreateAccountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccountButton.Location = New System.Drawing.Point(86, 21)
        Me.CreateAccountButton.Name = "CreateAccountButton"
        Me.CreateAccountButton.Size = New System.Drawing.Size(58, 41)
        Me.CreateAccountButton.TabIndex = 34
        Me.CreateAccountButton.Text = "Create Account"
        Me.CreateAccountButton.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(6, 24)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 30)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "Check/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck All"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'WOListView
        '
        Me.WOListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.WOListView.BackColor = System.Drawing.Color.White
        Me.WOListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WOListView.CheckBoxes = True
        Me.WOListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.WOListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WOListView.FullRowSelect = True
        Me.WOListView.GridLines = True
        Me.WOListView.HotTracking = True
        Me.WOListView.HoverSelection = True
        Me.WOListView.Location = New System.Drawing.Point(6, 65)
        Me.WOListView.Name = "WOListView"
        Me.WOListView.Size = New System.Drawing.Size(222, 324)
        Me.WOListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.WOListView.TabIndex = 26
        Me.WOListView.UseCompatibleStateImageBehavior = False
        Me.WOListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ID"
        Me.ColumnHeader9.Width = 94
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Name"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 107
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteButton)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.WithListView)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(235, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 482)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(89, 21)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(58, 41)
        Me.DeleteButton.TabIndex = 36
        Me.DeleteButton.Text = "Delete  Account"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(11, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 30)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Check/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Uncheck All"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'WithListView
        '
        Me.WithListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.WithListView.BackColor = System.Drawing.Color.White
        Me.WithListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WithListView.CheckBoxes = True
        Me.WithListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8})
        Me.WithListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithListView.FullRowSelect = True
        Me.WithListView.GridLines = True
        Me.WithListView.HotTracking = True
        Me.WithListView.HoverSelection = True
        Me.WithListView.Location = New System.Drawing.Point(9, 65)
        Me.WithListView.Name = "WithListView"
        Me.WithListView.Size = New System.Drawing.Size(501, 411)
        Me.WithListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.WithListView.TabIndex = 26
        Me.WithListView.UseCompatibleStateImageBehavior = False
        Me.WithListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "User Name"
        Me.ColumnHeader3.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "User Type"
        Me.ColumnHeader4.Width = 94
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Password"
        Me.ColumnHeader8.Width = 92
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(0, 1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(761, 25)
        Me.TextBox2.TabIndex = 45
        Me.TextBox2.Text = "User Accounts"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(335, 545)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(105, 43)
        Me.CloseButton.TabIndex = 46
        Me.CloseButton.Text = "&Main"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'UserAccessButton
        '
        Me.UserAccessButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UserAccessButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserAccessButton.Location = New System.Drawing.Point(446, 545)
        Me.UserAccessButton.Name = "UserAccessButton"
        Me.UserAccessButton.Size = New System.Drawing.Size(105, 43)
        Me.UserAccessButton.TabIndex = 47
        Me.UserAccessButton.Text = "&Shortcut to Users Access"
        Me.UserAccessButton.UseVisualStyleBackColor = False
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(762, 588)
        Me.Controls.Add(Me.UserAccessButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Users"
        Me.Text = "Users"
        Me.UsersManagementGroupBox.ResumeLayout(False)
        Me.WithAccountGroupBox.ResumeLayout(False)
        Me.WithAccountGroupBox.PerformLayout()
        Me.WithoutAccountGroupBox.ResumeLayout(False)
        Me.WithoutAccountGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsersManagementGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WithAccountGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteAccountButton As System.Windows.Forms.Button
    Friend WithEvents CheckWithCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UserListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents WithoutAccountGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckOutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CreateUserButton As System.Windows.Forms.Button
    Friend WithEvents UserWithoutListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents WithListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CreateAccountButton As System.Windows.Forms.Button
    Friend WithEvents WOListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents UpdateAccountButton As System.Windows.Forms.Button
    Friend WithEvents NewAccountButton As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents UserAccessButton As System.Windows.Forms.Button
End Class

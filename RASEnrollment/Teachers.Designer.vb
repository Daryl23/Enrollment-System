<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teachers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teachers))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TeacherIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TeacherLNameTextBox = New System.Windows.Forms.TextBox()
        Me.TeacherFNameTextBox = New System.Windows.Forms.TextBox()
        Me.TeacherMNameTextBox = New System.Windows.Forms.TextBox()
        Me.TeacherAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TeacherEmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TeacherContactTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox()
        Me.TeacherListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SubjectCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SectionComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.YearNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FeesButton = New System.Windows.Forms.Button()
        Me.RoomsButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FeesPictureBox = New System.Windows.Forms.PictureBox()
        Me.RoomsPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FeesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.TeacherListView)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 401)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TeacherIDTextBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TeacherLNameTextBox)
        Me.GroupBox2.Controls.Add(Me.TeacherFNameTextBox)
        Me.GroupBox2.Controls.Add(Me.TeacherMNameTextBox)
        Me.GroupBox2.Controls.Add(Me.TeacherAddressTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TeacherEmailTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TeacherContactTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(39, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 128)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Teacher's Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(251, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "*Optional"
        '
        'TeacherIDTextBox
        '
        Me.TeacherIDTextBox.Enabled = False
        Me.TeacherIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherIDTextBox.Location = New System.Drawing.Point(79, 20)
        Me.TeacherIDTextBox.Name = "TeacherIDTextBox"
        Me.TeacherIDTextBox.Size = New System.Drawing.Size(119, 20)
        Me.TeacherIDTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Teacher ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name:"
        '
        'TeacherLNameTextBox
        '
        Me.TeacherLNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherLNameTextBox.Location = New System.Drawing.Point(79, 46)
        Me.TeacherLNameTextBox.Name = "TeacherLNameTextBox"
        Me.TeacherLNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.TeacherLNameTextBox.TabIndex = 4
        '
        'TeacherFNameTextBox
        '
        Me.TeacherFNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherFNameTextBox.Location = New System.Drawing.Point(79, 72)
        Me.TeacherFNameTextBox.Name = "TeacherFNameTextBox"
        Me.TeacherFNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.TeacherFNameTextBox.TabIndex = 5
        '
        'TeacherMNameTextBox
        '
        Me.TeacherMNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherMNameTextBox.Location = New System.Drawing.Point(79, 98)
        Me.TeacherMNameTextBox.Name = "TeacherMNameTextBox"
        Me.TeacherMNameTextBox.Size = New System.Drawing.Size(40, 20)
        Me.TeacherMNameTextBox.TabIndex = 6
        '
        'TeacherAddressTextBox
        '
        Me.TeacherAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherAddressTextBox.Location = New System.Drawing.Point(285, 20)
        Me.TeacherAddressTextBox.Multiline = True
        Me.TeacherAddressTextBox.Name = "TeacherAddressTextBox"
        Me.TeacherAddressTextBox.Size = New System.Drawing.Size(159, 39)
        Me.TeacherAddressTextBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(215, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email:"
        '
        'TeacherEmailTextBox
        '
        Me.TeacherEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherEmailTextBox.Location = New System.Drawing.Point(307, 91)
        Me.TeacherEmailTextBox.Name = "TeacherEmailTextBox"
        Me.TeacherEmailTextBox.Size = New System.Drawing.Size(137, 20)
        Me.TeacherEmailTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(218, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contact No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "M.I.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Address:"
        '
        'TeacherContactTextBox
        '
        Me.TeacherContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherContactTextBox.Location = New System.Drawing.Point(285, 65)
        Me.TeacherContactTextBox.Name = "TeacherContactTextBox"
        Me.TeacherContactTextBox.Size = New System.Drawing.Size(90, 20)
        Me.TeacherContactTextBox.TabIndex = 8
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(264, 351)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(71, 44)
        Me.ClearButton.TabIndex = 31
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(25, 14)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(57, 24)
        Me.DeleteButton.TabIndex = 23
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(26, 17)
        Me.CheckCheckBox.TabIndex = 22
        Me.CheckCheckBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'TeacherListView
        '
        Me.TeacherListView.CheckBoxes = True
        Me.TeacherListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.TeacherListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherListView.FullRowSelect = True
        Me.TeacherListView.Location = New System.Drawing.Point(6, 44)
        Me.TeacherListView.Name = "TeacherListView"
        Me.TeacherListView.Size = New System.Drawing.Size(493, 173)
        Me.TeacherListView.TabIndex = 21
        Me.TeacherListView.UseCompatibleStateImageBehavior = False
        Me.TeacherListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Teacher ID"
        Me.ColumnHeader2.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Address"
        Me.ColumnHeader5.Width = 128
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact No."
        Me.ColumnHeader6.Width = 78
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Email"
        Me.ColumnHeader7.Width = 98
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(186, 351)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(72, 44)
        Me.SaveButton.TabIndex = 24
        Me.SaveButton.Text = "&Save Changes"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RemoveButton)
        Me.GroupBox3.Controls.Add(Me.SubjectCheckBox)
        Me.GroupBox3.Controls.Add(Me.AddSubjectButton)
        Me.GroupBox3.Controls.Add(Me.SubjectComboBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.SectionComboBox)
        Me.GroupBox3.Controls.Add(Me.SubjectListView)
        Me.GroupBox3.Controls.Add(Me.YearNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(523, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 65)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Subjects to Teach:"
        Me.GroupBox3.Visible = False
        '
        'RemoveButton
        '
        Me.RemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveButton.Location = New System.Drawing.Point(227, 10)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(60, 27)
        Me.RemoveButton.TabIndex = 34
        Me.RemoveButton.Text = "&Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'SubjectCheckBox
        '
        Me.SubjectCheckBox.AutoSize = True
        Me.SubjectCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCheckBox.Location = New System.Drawing.Point(208, 16)
        Me.SubjectCheckBox.Name = "SubjectCheckBox"
        Me.SubjectCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.SubjectCheckBox.TabIndex = 33
        Me.SubjectCheckBox.UseVisualStyleBackColor = True
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubjectButton.Location = New System.Drawing.Point(142, 101)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(49, 27)
        Me.AddSubjectButton.TabIndex = 32
        Me.AddSubjectButton.Text = "&Add"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(78, 74)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SubjectComboBox.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Subject:"
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Location = New System.Drawing.Point(78, 47)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SectionComboBox.TabIndex = 29
        '
        'SubjectListView
        '
        Me.SubjectListView.CheckBoxes = True
        Me.SubjectListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader3})
        Me.SubjectListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectListView.Location = New System.Drawing.Point(208, 39)
        Me.SubjectListView.Name = "SubjectListView"
        Me.SubjectListView.Size = New System.Drawing.Size(143, 144)
        Me.SubjectListView.TabIndex = 19
        Me.SubjectListView.UseCompatibleStateImageBehavior = False
        Me.SubjectListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = ""
        Me.ColumnHeader10.Width = 37
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject"
        Me.ColumnHeader3.Width = 102
        '
        'YearNameComboBox
        '
        Me.YearNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearNameComboBox.FormattingEnabled = True
        Me.YearNameComboBox.Location = New System.Drawing.Point(78, 20)
        Me.YearNameComboBox.Name = "YearNameComboBox"
        Me.YearNameComboBox.Size = New System.Drawing.Size(113, 21)
        Me.YearNameComboBox.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Section:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Year Level:"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(227, 428)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(65, 56)
        Me.ExitButton.TabIndex = 47
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'FeesButton
        '
        Me.FeesButton.BackColor = System.Drawing.SystemColors.Control
        Me.FeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FeesButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesButton.Location = New System.Drawing.Point(161, 428)
        Me.FeesButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.FeesButton.Name = "FeesButton"
        Me.FeesButton.Size = New System.Drawing.Size(65, 56)
        Me.FeesButton.TabIndex = 45
        Me.FeesButton.Text = "Fees"
        Me.FeesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FeesButton.UseVisualStyleBackColor = False
        '
        'RoomsButton
        '
        Me.RoomsButton.BackColor = System.Drawing.SystemColors.Control
        Me.RoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomsButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsButton.Location = New System.Drawing.Point(293, 428)
        Me.RoomsButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RoomsButton.Name = "RoomsButton"
        Me.RoomsButton.Size = New System.Drawing.Size(65, 56)
        Me.RoomsButton.TabIndex = 43
        Me.RoomsButton.Text = "Rooms"
        Me.RoomsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RoomsButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(505, 25)
        Me.TextBox1.TabIndex = 48
        Me.TextBox1.Text = "Teacher"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FeesPictureBox
        '
        Me.FeesPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.FeesPictureBox.Image = CType(resources.GetObject("FeesPictureBox.Image"), System.Drawing.Image)
        Me.FeesPictureBox.Location = New System.Drawing.Point(173, 451)
        Me.FeesPictureBox.Name = "FeesPictureBox"
        Me.FeesPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.FeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FeesPictureBox.TabIndex = 46
        Me.FeesPictureBox.TabStop = False
        '
        'RoomsPictureBox
        '
        Me.RoomsPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RoomsPictureBox.Image = CType(resources.GetObject("RoomsPictureBox.Image"), System.Drawing.Image)
        Me.RoomsPictureBox.Location = New System.Drawing.Point(303, 451)
        Me.RoomsPictureBox.Name = "RoomsPictureBox"
        Me.RoomsPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.RoomsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoomsPictureBox.TabIndex = 44
        Me.RoomsPictureBox.TabStop = False
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(515, 492)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FeesPictureBox)
        Me.Controls.Add(Me.FeesButton)
        Me.Controls.Add(Me.RoomsPictureBox)
        Me.Controls.Add(Me.RoomsButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Teachers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teachers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FeesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeacherEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherMNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherFNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherLNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeacherIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TeacherListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents FeesPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FeesButton As System.Windows.Forms.Button
    Friend WithEvents RoomsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RoomsButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents YearNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AddSubjectButton As System.Windows.Forms.Button
    Friend WithEvents SubjectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

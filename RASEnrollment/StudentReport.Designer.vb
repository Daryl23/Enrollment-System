<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentReport
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
        Me.SortByGroupBox = New System.Windows.Forms.GroupBox
        Me.GradesRadioButton = New System.Windows.Forms.RadioButton
        Me.RegDateRadioButton = New System.Windows.Forms.RadioButton
        Me.NameRadioButton = New System.Windows.Forms.RadioButton
        Me.OrderByGroupBox = New System.Windows.Forms.GroupBox
        Me.DESCRadioButton = New System.Windows.Forms.RadioButton
        Me.ASCRadioButton = New System.Windows.Forms.RadioButton
        Me.FilterByGroupBox = New System.Windows.Forms.GroupBox
        Me.AsofGroupBox = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.STGroupBox = New System.Windows.Forms.GroupBox
        Me.STComboBox = New System.Windows.Forms.ComboBox
        Me.STCheckBox = New System.Windows.Forms.CheckBox
        Me.SSGroupBox = New System.Windows.Forms.GroupBox
        Me.SSComboBox = New System.Windows.Forms.ComboBox
        Me.SSCheckBox = New System.Windows.Forms.CheckBox
        Me.PTGroupBox = New System.Windows.Forms.GroupBox
        Me.PTComboBox = New System.Windows.Forms.ComboBox
        Me.PTCheckBox = New System.Windows.Forms.CheckBox
        Me.forGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SYComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.YGPGroupBox = New System.Windows.Forms.GroupBox
        Me.YGPListView = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListOfComboBox = New System.Windows.Forms.ComboBox
        Me.ViewButton = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.SortByGroupBox.SuspendLayout()
        Me.OrderByGroupBox.SuspendLayout()
        Me.FilterByGroupBox.SuspendLayout()
        Me.AsofGroupBox.SuspendLayout()
        Me.STGroupBox.SuspendLayout()
        Me.SSGroupBox.SuspendLayout()
        Me.PTGroupBox.SuspendLayout()
        Me.forGroupBox.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.YGPGroupBox.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'SortByGroupBox
        '
        Me.SortByGroupBox.Controls.Add(Me.GradesRadioButton)
        Me.SortByGroupBox.Controls.Add(Me.RegDateRadioButton)
        Me.SortByGroupBox.Controls.Add(Me.NameRadioButton)
        Me.SortByGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SortByGroupBox.Location = New System.Drawing.Point(6, 77)
        Me.SortByGroupBox.Name = "SortByGroupBox"
        Me.SortByGroupBox.Size = New System.Drawing.Size(134, 85)
        Me.SortByGroupBox.TabIndex = 3
        Me.SortByGroupBox.TabStop = False
        Me.SortByGroupBox.Text = "Sort By:"
        '
        'GradesRadioButton
        '
        Me.GradesRadioButton.AutoSize = True
        Me.GradesRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.GradesRadioButton.Name = "GradesRadioButton"
        Me.GradesRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.GradesRadioButton.TabIndex = 2
        Me.GradesRadioButton.Text = "Grades"
        Me.GradesRadioButton.UseVisualStyleBackColor = True
        '
        'RegDateRadioButton
        '
        Me.RegDateRadioButton.AutoSize = True
        Me.RegDateRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.RegDateRadioButton.Name = "RegDateRadioButton"
        Me.RegDateRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.RegDateRadioButton.TabIndex = 1
        Me.RegDateRadioButton.Text = "Registration Date"
        Me.RegDateRadioButton.UseVisualStyleBackColor = True
        '
        'NameRadioButton
        '
        Me.NameRadioButton.AutoSize = True
        Me.NameRadioButton.Checked = True
        Me.NameRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.NameRadioButton.Name = "NameRadioButton"
        Me.NameRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.NameRadioButton.TabIndex = 0
        Me.NameRadioButton.TabStop = True
        Me.NameRadioButton.Text = "Name"
        Me.NameRadioButton.UseVisualStyleBackColor = True
        '
        'OrderByGroupBox
        '
        Me.OrderByGroupBox.Controls.Add(Me.DESCRadioButton)
        Me.OrderByGroupBox.Controls.Add(Me.ASCRadioButton)
        Me.OrderByGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderByGroupBox.Location = New System.Drawing.Point(146, 77)
        Me.OrderByGroupBox.Name = "OrderByGroupBox"
        Me.OrderByGroupBox.Size = New System.Drawing.Size(101, 85)
        Me.OrderByGroupBox.TabIndex = 6
        Me.OrderByGroupBox.TabStop = False
        Me.OrderByGroupBox.Text = "Order By:"
        '
        'DESCRadioButton
        '
        Me.DESCRadioButton.AutoSize = True
        Me.DESCRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.DESCRadioButton.Name = "DESCRadioButton"
        Me.DESCRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.DESCRadioButton.TabIndex = 1
        Me.DESCRadioButton.Text = "Descending"
        Me.DESCRadioButton.UseVisualStyleBackColor = True
        '
        'ASCRadioButton
        '
        Me.ASCRadioButton.AutoSize = True
        Me.ASCRadioButton.Checked = True
        Me.ASCRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.ASCRadioButton.Name = "ASCRadioButton"
        Me.ASCRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.ASCRadioButton.TabIndex = 0
        Me.ASCRadioButton.TabStop = True
        Me.ASCRadioButton.Text = "Ascending"
        Me.ASCRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByGroupBox
        '
        Me.FilterByGroupBox.Controls.Add(Me.AsofGroupBox)
        Me.FilterByGroupBox.Controls.Add(Me.STGroupBox)
        Me.FilterByGroupBox.Controls.Add(Me.SSGroupBox)
        Me.FilterByGroupBox.Controls.Add(Me.PTGroupBox)
        Me.FilterByGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterByGroupBox.Location = New System.Drawing.Point(6, 165)
        Me.FilterByGroupBox.Name = "FilterByGroupBox"
        Me.FilterByGroupBox.Size = New System.Drawing.Size(241, 141)
        Me.FilterByGroupBox.TabIndex = 7
        Me.FilterByGroupBox.TabStop = False
        Me.FilterByGroupBox.Text = "Filter By:"
        '
        'AsofGroupBox
        '
        Me.AsofGroupBox.Controls.Add(Me.DateTimePicker2)
        Me.AsofGroupBox.Controls.Add(Me.Label3)
        Me.AsofGroupBox.Controls.Add(Me.DateTimePicker1)
        Me.AsofGroupBox.Location = New System.Drawing.Point(7, 91)
        Me.AsofGroupBox.Name = "AsofGroupBox"
        Me.AsofGroupBox.Size = New System.Drawing.Size(228, 44)
        Me.AsofGroupBox.TabIndex = 17
        Me.AsofGroupBox.TabStop = False
        Me.AsofGroupBox.Text = "As of"
        Me.AsofGroupBox.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(120, 17)
        Me.DateTimePicker2.MinDate = New Date(2014, 6, 24, 23, 59, 59, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "to"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 17)
        Me.DateTimePicker1.MinDate = New Date(2014, 6, 24, 23, 59, 59, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(94, 21)
        Me.DateTimePicker1.TabIndex = 15
        '
        'STGroupBox
        '
        Me.STGroupBox.Controls.Add(Me.STComboBox)
        Me.STGroupBox.Controls.Add(Me.STCheckBox)
        Me.STGroupBox.Location = New System.Drawing.Point(7, 13)
        Me.STGroupBox.Name = "STGroupBox"
        Me.STGroupBox.Size = New System.Drawing.Size(228, 31)
        Me.STGroupBox.TabIndex = 14
        Me.STGroupBox.TabStop = False
        '
        'STComboBox
        '
        Me.STComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.STComboBox.Enabled = False
        Me.STComboBox.FormattingEnabled = True
        Me.STComboBox.Items.AddRange(New Object() {"Old", "New", "Transferee", "Foreign"})
        Me.STComboBox.Location = New System.Drawing.Point(100, 8)
        Me.STComboBox.Name = "STComboBox"
        Me.STComboBox.Size = New System.Drawing.Size(121, 21)
        Me.STComboBox.TabIndex = 13
        '
        'STCheckBox
        '
        Me.STCheckBox.AutoSize = True
        Me.STCheckBox.Location = New System.Drawing.Point(6, 11)
        Me.STCheckBox.Name = "STCheckBox"
        Me.STCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.STCheckBox.TabIndex = 11
        Me.STCheckBox.Text = "Student Type"
        Me.STCheckBox.UseVisualStyleBackColor = True
        '
        'SSGroupBox
        '
        Me.SSGroupBox.Controls.Add(Me.SSComboBox)
        Me.SSGroupBox.Controls.Add(Me.SSCheckBox)
        Me.SSGroupBox.Location = New System.Drawing.Point(7, 36)
        Me.SSGroupBox.Name = "SSGroupBox"
        Me.SSGroupBox.Size = New System.Drawing.Size(228, 31)
        Me.SSGroupBox.TabIndex = 15
        Me.SSGroupBox.TabStop = False
        '
        'SSComboBox
        '
        Me.SSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SSComboBox.Enabled = False
        Me.SSComboBox.FormattingEnabled = True
        Me.SSComboBox.Items.AddRange(New Object() {"Enrolled", "Registered", "Reserved", "Graduated", "Dropped"})
        Me.SSComboBox.Location = New System.Drawing.Point(100, 8)
        Me.SSComboBox.Name = "SSComboBox"
        Me.SSComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SSComboBox.TabIndex = 13
        '
        'SSCheckBox
        '
        Me.SSCheckBox.AutoSize = True
        Me.SSCheckBox.Location = New System.Drawing.Point(6, 11)
        Me.SSCheckBox.Name = "SSCheckBox"
        Me.SSCheckBox.Size = New System.Drawing.Size(96, 17)
        Me.SSCheckBox.TabIndex = 11
        Me.SSCheckBox.Text = "Student Status"
        Me.SSCheckBox.UseVisualStyleBackColor = True
        '
        'PTGroupBox
        '
        Me.PTGroupBox.Controls.Add(Me.PTComboBox)
        Me.PTGroupBox.Controls.Add(Me.PTCheckBox)
        Me.PTGroupBox.Location = New System.Drawing.Point(7, 59)
        Me.PTGroupBox.Name = "PTGroupBox"
        Me.PTGroupBox.Size = New System.Drawing.Size(228, 31)
        Me.PTGroupBox.TabIndex = 16
        Me.PTGroupBox.TabStop = False
        Me.PTGroupBox.Visible = False
        '
        'PTComboBox
        '
        Me.PTComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PTComboBox.Enabled = False
        Me.PTComboBox.FormattingEnabled = True
        Me.PTComboBox.Items.AddRange(New Object() {"Enrolled", "Registered", "Reserved", "Graduated", "Dropped"})
        Me.PTComboBox.Location = New System.Drawing.Point(100, 8)
        Me.PTComboBox.Name = "PTComboBox"
        Me.PTComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PTComboBox.TabIndex = 13
        '
        'PTCheckBox
        '
        Me.PTCheckBox.AutoSize = True
        Me.PTCheckBox.Location = New System.Drawing.Point(6, 11)
        Me.PTCheckBox.Name = "PTCheckBox"
        Me.PTCheckBox.Size = New System.Drawing.Size(94, 17)
        Me.PTCheckBox.TabIndex = 11
        Me.PTCheckBox.Text = "Payment Type"
        Me.PTCheckBox.UseVisualStyleBackColor = True
        '
        'forGroupBox
        '
        Me.forGroupBox.Controls.Add(Me.Label2)
        Me.forGroupBox.Controls.Add(Me.SYComboBox)
        Me.forGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forGroupBox.Location = New System.Drawing.Point(6, 40)
        Me.forGroupBox.Name = "forGroupBox"
        Me.forGroupBox.Size = New System.Drawing.Size(241, 31)
        Me.forGroupBox.TabIndex = 12
        Me.forGroupBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "for:"
        '
        'SYComboBox
        '
        Me.SYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYComboBox.FormattingEnabled = True
        Me.SYComboBox.Location = New System.Drawing.Point(50, 8)
        Me.SYComboBox.Name = "SYComboBox"
        Me.SYComboBox.Size = New System.Drawing.Size(178, 21)
        Me.SYComboBox.TabIndex = 12
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.YGPGroupBox)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.ViewButton)
        Me.GroupBox7.Controls.Add(Me.forGroupBox)
        Me.GroupBox7.Controls.Add(Me.SortByGroupBox)
        Me.GroupBox7.Controls.Add(Me.OrderByGroupBox)
        Me.GroupBox7.Controls.Add(Me.FilterByGroupBox)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(1, 25)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(442, 341)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Student Report Menu"
        '
        'YGPGroupBox
        '
        Me.YGPGroupBox.Controls.Add(Me.YGPListView)
        Me.YGPGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YGPGroupBox.Location = New System.Drawing.Point(253, 17)
        Me.YGPGroupBox.Name = "YGPGroupBox"
        Me.YGPGroupBox.Size = New System.Drawing.Size(179, 289)
        Me.YGPGroupBox.TabIndex = 16
        Me.YGPGroupBox.TabStop = False
        Me.YGPGroupBox.Text = "Year/Grade/Program"
        '
        'YGPListView
        '
        Me.YGPListView.BackColor = System.Drawing.Color.White
        Me.YGPListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YGPListView.CheckBoxes = True
        Me.YGPListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1})
        Me.YGPListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YGPListView.ForeColor = System.Drawing.Color.Black
        Me.YGPListView.FullRowSelect = True
        Me.YGPListView.Location = New System.Drawing.Point(6, 19)
        Me.YGPListView.Name = "YGPListView"
        Me.YGPListView.Size = New System.Drawing.Size(164, 264)
        Me.YGPListView.TabIndex = 154
        Me.YGPListView.UseCompatibleStateImageBehavior = False
        Me.YGPListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.Width = 33
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Year"
        Me.ColumnHeader1.Width = 106
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.ListOfComboBox)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(241, 31)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "List of:"
        '
        'ListOfComboBox
        '
        Me.ListOfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListOfComboBox.FormattingEnabled = True
        Me.ListOfComboBox.Items.AddRange(New Object() {"Students", "Grades", "Payments"})
        Me.ListOfComboBox.Location = New System.Drawing.Point(50, 8)
        Me.ListOfComboBox.Name = "ListOfComboBox"
        Me.ListOfComboBox.Size = New System.Drawing.Size(80, 21)
        Me.ListOfComboBox.TabIndex = 12
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(149, 309)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(98, 23)
        Me.ViewButton.TabIndex = 9
        Me.ViewButton.Text = "&View Report"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(444, 25)
        Me.TextBox2.TabIndex = 39
        Me.TextBox2.Text = "Student Report"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StudentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(444, 369)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "StudentReport"
        Me.Text = "StudentReport"
        Me.SortByGroupBox.ResumeLayout(False)
        Me.SortByGroupBox.PerformLayout()
        Me.OrderByGroupBox.ResumeLayout(False)
        Me.OrderByGroupBox.PerformLayout()
        Me.FilterByGroupBox.ResumeLayout(False)
        Me.AsofGroupBox.ResumeLayout(False)
        Me.AsofGroupBox.PerformLayout()
        Me.STGroupBox.ResumeLayout(False)
        Me.STGroupBox.PerformLayout()
        Me.SSGroupBox.ResumeLayout(False)
        Me.SSGroupBox.PerformLayout()
        Me.PTGroupBox.ResumeLayout(False)
        Me.PTGroupBox.PerformLayout()
        Me.forGroupBox.ResumeLayout(False)
        Me.forGroupBox.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.YGPGroupBox.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SortByGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RegDateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NameRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OrderByGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DESCRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ASCRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FilterByGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents forGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SYComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents STGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents STCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents STComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ViewButton As System.Windows.Forms.Button
    Friend WithEvents SSGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SSComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ListOfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GradesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AsofGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PTGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PTComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents YGPGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents YGPListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subjects))
        Me.SubjectTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.SubjectListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ClearButton = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.SaveButton = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UnitTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.YearNameComboBox = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SectionPictureBox = New System.Windows.Forms.PictureBox
        Me.SectionButton = New System.Windows.Forms.Button
        Me.FeesPictureBox = New System.Windows.Forms.PictureBox
        Me.FeesButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SectionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FeesPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(72, 41)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SubjectTextBox.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.SubjectListView)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 350)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(28, 14)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(54, 28)
        Me.DeleteButton.TabIndex = 20
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCheckBox.Location = New System.Drawing.Point(7, 22)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 19
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'SubjectListView
        '
        Me.SubjectListView.BackColor = System.Drawing.Color.White
        Me.SubjectListView.CheckBoxes = True
        Me.SubjectListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader2})
        Me.SubjectListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectListView.FullRowSelect = True
        Me.SubjectListView.Location = New System.Drawing.Point(7, 42)
        Me.SubjectListView.Name = "SubjectListView"
        Me.SubjectListView.Size = New System.Drawing.Size(222, 162)
        Me.SubjectListView.TabIndex = 15
        Me.SubjectListView.UseCompatibleStateImageBehavior = False
        Me.SubjectListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 26
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject Code"
        Me.ColumnHeader3.Width = 79
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Subject Name"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Unit"
        Me.ColumnHeader2.Width = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.UnitTextBox)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ClearButton)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox3.Controls.Add(Me.SaveButton)
        Me.GroupBox3.Controls.Add(Me.YearNameComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 210)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 134)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Subject Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(269, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 175)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parts"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Unit(s):"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(64, 46)
        Me.TextBox3.MaxLength = 3
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(32, 20)
        Me.TextBox3.TabIndex = 38
        Me.TextBox3.Text = "1"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(15, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(235, 95)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "#"
        Me.ColumnHeader5.Width = 26
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Subject Code"
        Me.ColumnHeader6.Width = 79
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Subject Name"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Unit"
        Me.ColumnHeader8.Width = 32
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(134, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 19)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.Text = "w/ parts"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(162, 67)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(45, 32)
        Me.ClearButton.TabIndex = 35
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Subject:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(49, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 19)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "w/ o parts"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(110, 67)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(46, 32)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(64, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Unit(s):"
        '
        'UnitTextBox
        '
        Me.UnitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitTextBox.Location = New System.Drawing.Point(72, 67)
        Me.UnitTextBox.MaxLength = 3
        Me.UnitTextBox.Name = "UnitTextBox"
        Me.UnitTextBox.Size = New System.Drawing.Size(32, 20)
        Me.UnitTextBox.TabIndex = 36
        Me.UnitTextBox.Text = "1"
        Me.UnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Year Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Subject:"
        '
        'YearNameComboBox
        '
        Me.YearNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearNameComboBox.FormattingEnabled = True
        Me.YearNameComboBox.Location = New System.Drawing.Point(72, 16)
        Me.YearNameComboBox.Name = "YearNameComboBox"
        Me.YearNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.YearNameComboBox.TabIndex = 14
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
        Me.TextBox1.Size = New System.Drawing.Size(239, 25)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "Subject"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.White
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(78, 367)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(70, 50)
        Me.ExitButton.TabIndex = 42
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SectionPictureBox
        '
        Me.SectionPictureBox.Image = CType(resources.GetObject("SectionPictureBox.Image"), System.Drawing.Image)
        Me.SectionPictureBox.Location = New System.Drawing.Point(18, 386)
        Me.SectionPictureBox.Name = "SectionPictureBox"
        Me.SectionPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.SectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SectionPictureBox.TabIndex = 41
        Me.SectionPictureBox.TabStop = False
        '
        'SectionButton
        '
        Me.SectionButton.BackColor = System.Drawing.Color.White
        Me.SectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SectionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionButton.Location = New System.Drawing.Point(2, 367)
        Me.SectionButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SectionButton.Name = "SectionButton"
        Me.SectionButton.Size = New System.Drawing.Size(75, 50)
        Me.SectionButton.TabIndex = 40
        Me.SectionButton.Text = "Section"
        Me.SectionButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SectionButton.UseVisualStyleBackColor = False
        '
        'FeesPictureBox
        '
        Me.FeesPictureBox.Image = CType(resources.GetObject("FeesPictureBox.Image"), System.Drawing.Image)
        Me.FeesPictureBox.Location = New System.Drawing.Point(168, 385)
        Me.FeesPictureBox.Name = "FeesPictureBox"
        Me.FeesPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.FeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FeesPictureBox.TabIndex = 39
        Me.FeesPictureBox.TabStop = False
        '
        'FeesButton
        '
        Me.FeesButton.BackColor = System.Drawing.Color.White
        Me.FeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FeesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesButton.Location = New System.Drawing.Point(149, 367)
        Me.FeesButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.FeesButton.Name = "FeesButton"
        Me.FeesButton.Size = New System.Drawing.Size(79, 50)
        Me.FeesButton.TabIndex = 38
        Me.FeesButton.Text = "Fees"
        Me.FeesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FeesButton.UseVisualStyleBackColor = False
        '
        'Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(242, 425)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SectionPictureBox)
        Me.Controls.Add(Me.SectionButton)
        Me.Controls.Add(Me.FeesPictureBox)
        Me.Controls.Add(Me.FeesButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Subjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subjects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SectionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FeesPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SubjectListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents YearNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SectionPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SectionButton As System.Windows.Forms.Button
    Friend WithEvents FeesPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FeesButton As System.Windows.Forms.Button
    Friend WithEvents UnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

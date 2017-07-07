<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fees))
        Me.YearComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TotalGroupBox = New System.Windows.Forms.GroupBox
        Me.EditButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.FeesPanel = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.FeeComboBox = New System.Windows.Forms.ComboBox
        Me.FeeGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SetButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.AmountShowedTextBox = New System.Windows.Forms.TextBox
        Me.SubFeeTextBox = New System.Windows.Forms.TextBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.SubFeeListView = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.CheckOrUnCheckAllCheckBox = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SubjectButton = New System.Windows.Forms.Button
        Me.TeacherButton = New System.Windows.Forms.Button
        Me.SubjectPictureBox = New System.Windows.Forms.PictureBox
        Me.TeacherPictureBox = New System.Windows.Forms.PictureBox
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.TotalGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FeeGroupBox.SuspendLayout()
        CType(Me.SubjectPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YearComboBox
        '
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(45, 13)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(106, 21)
        Me.YearComboBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Year:"
        '
        'TotalGroupBox
        '
        Me.TotalGroupBox.Controls.Add(Me.EditButton)
        Me.TotalGroupBox.Controls.Add(Me.SaveButton)
        Me.TotalGroupBox.Controls.Add(Me.TotalTextBox)
        Me.TotalGroupBox.Controls.Add(Me.FeesPanel)
        Me.TotalGroupBox.Controls.Add(Me.GroupBox3)
        Me.TotalGroupBox.Controls.Add(Me.FeeGroupBox)
        Me.TotalGroupBox.Controls.Add(Me.DeleteButton)
        Me.TotalGroupBox.Controls.Add(Me.SubFeeListView)
        Me.TotalGroupBox.Controls.Add(Me.CheckOrUnCheckAllCheckBox)
        Me.TotalGroupBox.Controls.Add(Me.Label3)
        Me.TotalGroupBox.Location = New System.Drawing.Point(3, 35)
        Me.TotalGroupBox.Name = "TotalGroupBox"
        Me.TotalGroupBox.Size = New System.Drawing.Size(520, 404)
        Me.TotalGroupBox.TabIndex = 11
        Me.TotalGroupBox.TabStop = False
        '
        'EditButton
        '
        Me.EditButton.AutoSize = True
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(201, 193)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(51, 26)
        Me.EditButton.TabIndex = 6
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(258, 193)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(49, 26)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.BackColor = System.Drawing.Color.Black
        Me.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalTextBox.Location = New System.Drawing.Point(64, 265)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(131, 26)
        Me.TotalTextBox.TabIndex = 33
        Me.TotalTextBox.Text = "0."
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FeesPanel
        '
        Me.FeesPanel.AutoScroll = True
        Me.FeesPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesPanel.Location = New System.Drawing.Point(201, 225)
        Me.FeesPanel.Name = "FeesPanel"
        Me.FeesPanel.Size = New System.Drawing.Size(312, 173)
        Me.FeesPanel.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.FeeComboBox)
        Me.GroupBox3.Controls.Add(Me.YearComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 68)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fee:"
        '
        'FeeComboBox
        '
        Me.FeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FeeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeeComboBox.FormattingEnabled = True
        Me.FeeComboBox.Items.AddRange(New Object() {"Miscellaneous", "Tuition & Computer Fee", "Other Fees"})
        Me.FeeComboBox.Location = New System.Drawing.Point(45, 40)
        Me.FeeComboBox.Name = "FeeComboBox"
        Me.FeeComboBox.Size = New System.Drawing.Size(137, 21)
        Me.FeeComboBox.TabIndex = 15
        '
        'FeeGroupBox
        '
        Me.FeeGroupBox.Controls.Add(Me.Label2)
        Me.FeeGroupBox.Controls.Add(Me.SetButton)
        Me.FeeGroupBox.Controls.Add(Me.Label1)
        Me.FeeGroupBox.Controls.Add(Me.AmountShowedTextBox)
        Me.FeeGroupBox.Controls.Add(Me.SubFeeTextBox)
        Me.FeeGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeeGroupBox.Location = New System.Drawing.Point(8, 297)
        Me.FeeGroupBox.Name = "FeeGroupBox"
        Me.FeeGroupBox.Size = New System.Drawing.Size(189, 101)
        Me.FeeGroupBox.TabIndex = 30
        Me.FeeGroupBox.TabStop = False
        Me.FeeGroupBox.Text = "Input the desired total for the ff.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Computer Fees:"
        '
        'SetButton
        '
        Me.SetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetButton.Location = New System.Drawing.Point(132, 70)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(49, 26)
        Me.SetButton.TabIndex = 29
        Me.SetButton.Text = "&Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tuition Fees:"
        '
        'AmountShowedTextBox
        '
        Me.AmountShowedTextBox.BackColor = System.Drawing.Color.White
        Me.AmountShowedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountShowedTextBox.Location = New System.Drawing.Point(89, 44)
        Me.AmountShowedTextBox.Name = "AmountShowedTextBox"
        Me.AmountShowedTextBox.Size = New System.Drawing.Size(92, 20)
        Me.AmountShowedTextBox.TabIndex = 19
        Me.AmountShowedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubFeeTextBox
        '
        Me.SubFeeTextBox.BackColor = System.Drawing.Color.White
        Me.SubFeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubFeeTextBox.Location = New System.Drawing.Point(88, 19)
        Me.SubFeeTextBox.Name = "SubFeeTextBox"
        Me.SubFeeTextBox.Size = New System.Drawing.Size(92, 20)
        Me.SubFeeTextBox.TabIndex = 18
        Me.SubFeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(19, 9)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(87, 24)
        Me.DeleteButton.TabIndex = 21
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SubFeeListView
        '
        Me.SubFeeListView.BackColor = System.Drawing.Color.White
        Me.SubFeeListView.CheckBoxes = True
        Me.SubFeeListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader2})
        Me.SubFeeListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubFeeListView.FullRowSelect = True
        Me.SubFeeListView.Location = New System.Drawing.Point(6, 35)
        Me.SubFeeListView.Name = "SubFeeListView"
        Me.SubFeeListView.Size = New System.Drawing.Size(507, 152)
        Me.SubFeeListView.TabIndex = 0
        Me.SubFeeListView.UseCompatibleStateImageBehavior = False
        Me.SubFeeListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sub"
        Me.ColumnHeader4.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        Me.ColumnHeader5.Width = 108
        '
        'CheckOrUnCheckAllCheckBox
        '
        Me.CheckOrUnCheckAllCheckBox.AutoSize = True
        Me.CheckOrUnCheckAllCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOrUnCheckAllCheckBox.Location = New System.Drawing.Point(4, 10)
        Me.CheckOrUnCheckAllCheckBox.Name = "CheckOrUnCheckAllCheckBox"
        Me.CheckOrUnCheckAllCheckBox.Size = New System.Drawing.Size(26, 17)
        Me.CheckOrUnCheckAllCheckBox.TabIndex = 14
        Me.CheckOrUnCheckAllCheckBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckOrUnCheckAllCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckOrUnCheckAllCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(4, 15)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(519, 25)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Text = "Fees"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(218, 441)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 58)
        Me.ExitButton.TabIndex = 42
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SubjectButton
        '
        Me.SubjectButton.BackColor = System.Drawing.SystemColors.Control
        Me.SubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubjectButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectButton.Location = New System.Drawing.Point(142, 441)
        Me.SubjectButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SubjectButton.Name = "SubjectButton"
        Me.SubjectButton.Size = New System.Drawing.Size(75, 58)
        Me.SubjectButton.TabIndex = 40
        Me.SubjectButton.Text = "Subject"
        Me.SubjectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SubjectButton.UseVisualStyleBackColor = False
        '
        'TeacherButton
        '
        Me.TeacherButton.BackColor = System.Drawing.SystemColors.Control
        Me.TeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeacherButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherButton.Location = New System.Drawing.Point(294, 441)
        Me.TeacherButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TeacherButton.Name = "TeacherButton"
        Me.TeacherButton.Size = New System.Drawing.Size(75, 58)
        Me.TeacherButton.TabIndex = 38
        Me.TeacherButton.Text = "Teacher"
        Me.TeacherButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TeacherButton.UseVisualStyleBackColor = False
        '
        'SubjectPictureBox
        '
        Me.SubjectPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SubjectPictureBox.Image = CType(resources.GetObject("SubjectPictureBox.Image"), System.Drawing.Image)
        Me.SubjectPictureBox.Location = New System.Drawing.Point(158, 464)
        Me.SubjectPictureBox.Name = "SubjectPictureBox"
        Me.SubjectPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.SubjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubjectPictureBox.TabIndex = 41
        Me.SubjectPictureBox.TabStop = False
        '
        'TeacherPictureBox
        '
        Me.TeacherPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TeacherPictureBox.Image = CType(resources.GetObject("TeacherPictureBox.Image"), System.Drawing.Image)
        Me.TeacherPictureBox.Location = New System.Drawing.Point(310, 464)
        Me.TeacherPictureBox.Name = "TeacherPictureBox"
        Me.TeacherPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.TeacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TeacherPictureBox.TabIndex = 39
        Me.TeacherPictureBox.TabStop = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Payment Date"
        '
        'Fees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(525, 503)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubjectPictureBox)
        Me.Controls.Add(Me.SubjectButton)
        Me.Controls.Add(Me.TeacherPictureBox)
        Me.Controls.Add(Me.TeacherButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TotalGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Fees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees"
        Me.TotalGroupBox.ResumeLayout(False)
        Me.TotalGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FeeGroupBox.ResumeLayout(False)
        Me.FeeGroupBox.PerformLayout()
        CType(Me.SubjectPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SubFeeListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckOrUnCheckAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SubFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SubjectPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SubjectButton As System.Windows.Forms.Button
    Friend WithEvents TeacherPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TeacherButton As System.Windows.Forms.Button
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents FeeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AmountShowedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FeesPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class

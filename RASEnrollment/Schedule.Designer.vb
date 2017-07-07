<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Me.ClassScheduleGroupBox = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ScheduleTextBox = New System.Windows.Forms.TextBox
        Me.SubjectTextBox = New System.Windows.Forms.TextBox
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PasteScheduleButton = New System.Windows.Forms.Button
        Me.CopyScheduleButton = New System.Windows.Forms.Button
        Me.DeleteScheduleButton = New System.Windows.Forms.Button
        Me.SaveScheduleButton = New System.Windows.Forms.Button
        Me.YearLevelScheduleComboBox = New System.Windows.Forms.ComboBox
        Me.SectionScheduleComboBox = New System.Windows.Forms.ComboBox
        Me.NextScheduleButton = New System.Windows.Forms.Button
        Me.PrevScheduleButton = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.DayScheduleComboBox = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.ScheduleListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.SchedConflictsListView = New System.Windows.Forms.ListView
        Me.Day = New System.Windows.Forms.ColumnHeader
        Me.Time = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.ClassScheduleGroupBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClassScheduleGroupBox
        '
        Me.ClassScheduleGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClassScheduleGroupBox.Controls.Add(Me.TextBox1)
        Me.ClassScheduleGroupBox.Controls.Add(Me.GroupBox6)
        Me.ClassScheduleGroupBox.Controls.Add(Me.GroupBox17)
        Me.ClassScheduleGroupBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassScheduleGroupBox.ForeColor = System.Drawing.Color.Green
        Me.ClassScheduleGroupBox.Location = New System.Drawing.Point(2, 21)
        Me.ClassScheduleGroupBox.Name = "ClassScheduleGroupBox"
        Me.ClassScheduleGroupBox.Size = New System.Drawing.Size(573, 571)
        Me.ClassScheduleGroupBox.TabIndex = 13
        Me.ClassScheduleGroupBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(5, 408)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(562, 25)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Text = "List Of Conflicts"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.ScheduleTextBox)
        Me.GroupBox6.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox6.Controls.Add(Me.ButtonSearch)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.PasteScheduleButton)
        Me.GroupBox6.Controls.Add(Me.CopyScheduleButton)
        Me.GroupBox6.Controls.Add(Me.DeleteScheduleButton)
        Me.GroupBox6.Controls.Add(Me.SaveScheduleButton)
        Me.GroupBox6.Controls.Add(Me.YearLevelScheduleComboBox)
        Me.GroupBox6.Controls.Add(Me.SectionScheduleComboBox)
        Me.GroupBox6.Controls.Add(Me.NextScheduleButton)
        Me.GroupBox6.Controls.Add(Me.PrevScheduleButton)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.DayScheduleComboBox)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.ScheduleListView)
        Me.GroupBox6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(562, 393)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        '
        'ScheduleTextBox
        '
        Me.ScheduleTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ScheduleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleTextBox.Location = New System.Drawing.Point(6, 62)
        Me.ScheduleTextBox.Name = "ScheduleTextBox"
        Me.ScheduleTextBox.Size = New System.Drawing.Size(549, 22)
        Me.ScheduleTextBox.TabIndex = 44
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(328, 37)
        Me.SubjectTextBox.MaxLength = 2
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(45, 20)
        Me.SubjectTextBox.TabIndex = 43
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearch.Location = New System.Drawing.Point(379, 14)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(63, 44)
        Me.ButtonSearch.TabIndex = 42
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(271, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Subjects:"
        '
        'PasteScheduleButton
        '
        Me.PasteScheduleButton.BackColor = System.Drawing.Color.White
        Me.PasteScheduleButton.Enabled = False
        Me.PasteScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PasteScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasteScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.PasteScheduleButton.Location = New System.Drawing.Point(503, 318)
        Me.PasteScheduleButton.Name = "PasteScheduleButton"
        Me.PasteScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.PasteScheduleButton.TabIndex = 39
        Me.PasteScheduleButton.Text = "&Paste Schedule"
        Me.PasteScheduleButton.UseVisualStyleBackColor = False
        '
        'CopyScheduleButton
        '
        Me.CopyScheduleButton.BackColor = System.Drawing.Color.White
        Me.CopyScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CopyScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.CopyScheduleButton.Location = New System.Drawing.Point(452, 318)
        Me.CopyScheduleButton.Name = "CopyScheduleButton"
        Me.CopyScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.CopyScheduleButton.TabIndex = 38
        Me.CopyScheduleButton.Text = "Copy Schedule"
        Me.CopyScheduleButton.UseVisualStyleBackColor = False
        '
        'DeleteScheduleButton
        '
        Me.DeleteScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.DeleteScheduleButton.Location = New System.Drawing.Point(503, 352)
        Me.DeleteScheduleButton.Name = "DeleteScheduleButton"
        Me.DeleteScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.DeleteScheduleButton.TabIndex = 32
        Me.DeleteScheduleButton.Text = "&Delete"
        Me.DeleteScheduleButton.UseVisualStyleBackColor = True
        '
        'SaveScheduleButton
        '
        Me.SaveScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.SaveScheduleButton.Location = New System.Drawing.Point(452, 352)
        Me.SaveScheduleButton.Name = "SaveScheduleButton"
        Me.SaveScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.SaveScheduleButton.TabIndex = 31
        Me.SaveScheduleButton.Text = "&Save"
        Me.SaveScheduleButton.UseVisualStyleBackColor = True
        '
        'YearLevelScheduleComboBox
        '
        Me.YearLevelScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearLevelScheduleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLevelScheduleComboBox.FormattingEnabled = True
        Me.YearLevelScheduleComboBox.Location = New System.Drawing.Point(159, 14)
        Me.YearLevelScheduleComboBox.Name = "YearLevelScheduleComboBox"
        Me.YearLevelScheduleComboBox.Size = New System.Drawing.Size(126, 21)
        Me.YearLevelScheduleComboBox.TabIndex = 27
        '
        'SectionScheduleComboBox
        '
        Me.SectionScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionScheduleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionScheduleComboBox.FormattingEnabled = True
        Me.SectionScheduleComboBox.Location = New System.Drawing.Point(159, 37)
        Me.SectionScheduleComboBox.Name = "SectionScheduleComboBox"
        Me.SectionScheduleComboBox.Size = New System.Drawing.Size(99, 21)
        Me.SectionScheduleComboBox.TabIndex = 28
        '
        'NextScheduleButton
        '
        Me.NextScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.NextScheduleButton.Location = New System.Drawing.Point(503, 284)
        Me.NextScheduleButton.Name = "NextScheduleButton"
        Me.NextScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.NextScheduleButton.TabIndex = 34
        Me.NextScheduleButton.Text = "&Next"
        Me.NextScheduleButton.UseVisualStyleBackColor = True
        '
        'PrevScheduleButton
        '
        Me.PrevScheduleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevScheduleButton.ForeColor = System.Drawing.Color.Black
        Me.PrevScheduleButton.Location = New System.Drawing.Point(452, 284)
        Me.PrevScheduleButton.Name = "PrevScheduleButton"
        Me.PrevScheduleButton.Size = New System.Drawing.Size(51, 34)
        Me.PrevScheduleButton.TabIndex = 33
        Me.PrevScheduleButton.Text = "&Prev"
        Me.PrevScheduleButton.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(293, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Day:"
        '
        'DayScheduleComboBox
        '
        Me.DayScheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DayScheduleComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayScheduleComboBox.FormattingEnabled = True
        Me.DayScheduleComboBox.Items.AddRange(New Object() {"M", "T", "W", "TH", "F"})
        Me.DayScheduleComboBox.Location = New System.Drawing.Point(328, 14)
        Me.DayScheduleComboBox.Name = "DayScheduleComboBox"
        Me.DayScheduleComboBox.Size = New System.Drawing.Size(45, 21)
        Me.DayScheduleComboBox.TabIndex = 36
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(107, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 13)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Section:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(121, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(32, 13)
        Me.Label27.TabIndex = 25
        Me.Label27.Text = "Year:"
        '
        'ScheduleListView
        '
        Me.ScheduleListView.BackColor = System.Drawing.Color.White
        Me.ScheduleListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ScheduleListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ScheduleListView.Location = New System.Drawing.Point(3, 83)
        Me.ScheduleListView.Name = "ScheduleListView"
        Me.ScheduleListView.Size = New System.Drawing.Size(551, 304)
        Me.ScheduleListView.TabIndex = 0
        Me.ScheduleListView.UseCompatibleStateImageBehavior = False
        Me.ScheduleListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Start Time"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "End Time"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Subject"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Teacher"
        Me.ColumnHeader4.Width = 84
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Room"
        Me.ColumnHeader5.Width = 97
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.SchedConflictsListView)
        Me.GroupBox17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(6, 424)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(561, 141)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        '
        'SchedConflictsListView
        '
        Me.SchedConflictsListView.BackColor = System.Drawing.Color.White
        Me.SchedConflictsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Day, Me.Time, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.SchedConflictsListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchedConflictsListView.FullRowSelect = True
        Me.SchedConflictsListView.Location = New System.Drawing.Point(3, 14)
        Me.SchedConflictsListView.Name = "SchedConflictsListView"
        Me.SchedConflictsListView.Size = New System.Drawing.Size(551, 121)
        Me.SchedConflictsListView.TabIndex = 27
        Me.SchedConflictsListView.UseCompatibleStateImageBehavior = False
        Me.SchedConflictsListView.View = System.Windows.Forms.View.Details
        '
        'Day
        '
        Me.Day.Text = "Day"
        Me.Day.Width = 85
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 103
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Year"
        Me.ColumnHeader8.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Section"
        Me.ColumnHeader9.Width = 69
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Subject"
        Me.ColumnHeader10.Width = 87
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Teacher"
        Me.ColumnHeader11.Width = 126
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Room"
        Me.ColumnHeader12.Width = 75
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(2, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(573, 25)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "Schedule"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(242, 600)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 39)
        Me.ExitButton.TabIndex = 29
        Me.ExitButton.Text = "&Main"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(576, 640)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ClassScheduleGroupBox)
        Me.Name = "Schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.ClassScheduleGroupBox.ResumeLayout(False)
        Me.ClassScheduleGroupBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClassScheduleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PasteScheduleButton As System.Windows.Forms.Button
    Friend WithEvents CopyScheduleButton As System.Windows.Forms.Button
    Friend WithEvents DeleteScheduleButton As System.Windows.Forms.Button
    Friend WithEvents SaveScheduleButton As System.Windows.Forms.Button
    Friend WithEvents YearLevelScheduleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionScheduleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NextScheduleButton As System.Windows.Forms.Button
    Friend WithEvents PrevScheduleButton As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DayScheduleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents SchedConflictsListView As System.Windows.Forms.ListView
    Friend WithEvents Day As System.Windows.Forms.ColumnHeader
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ScheduleListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScheduleTextBox As System.Windows.Forms.TextBox
End Class

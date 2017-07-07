<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grading
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
        Me.GradingSystemGroupBox = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GradingPeriodComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SYComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GradingDataGridView = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradingGroupBox = New System.Windows.Forms.GroupBox
        Me.GoButton = New System.Windows.Forms.Button
        Me.TeacherComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.YearComboBox = New System.Windows.Forms.ComboBox
        Me.SectionComboBox = New System.Windows.Forms.ComboBox
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CloseButton = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GradingSystemGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GradingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradingGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GradingSystemGroupBox
        '
        Me.GradingSystemGroupBox.Controls.Add(Me.GroupBox3)
        Me.GradingSystemGroupBox.Controls.Add(Me.GroupBox2)
        Me.GradingSystemGroupBox.Controls.Add(Me.GradingGroupBox)
        Me.GradingSystemGroupBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingSystemGroupBox.Location = New System.Drawing.Point(-1, 16)
        Me.GradingSystemGroupBox.Name = "GradingSystemGroupBox"
        Me.GradingSystemGroupBox.Size = New System.Drawing.Size(564, 467)
        Me.GradingSystemGroupBox.TabIndex = 0
        Me.GradingSystemGroupBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GradingPeriodComboBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.SYComboBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 105)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'GradingPeriodComboBox
        '
        Me.GradingPeriodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradingPeriodComboBox.FormattingEnabled = True
        Me.GradingPeriodComboBox.Location = New System.Drawing.Point(15, 72)
        Me.GradingPeriodComboBox.Name = "GradingPeriodComboBox"
        Me.GradingPeriodComboBox.Size = New System.Drawing.Size(166, 21)
        Me.GradingPeriodComboBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Grading Period:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "School Year:"
        '
        'SYComboBox
        '
        Me.SYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYComboBox.FormattingEnabled = True
        Me.SYComboBox.Location = New System.Drawing.Point(15, 32)
        Me.SYComboBox.Name = "SYComboBox"
        Me.SYComboBox.Size = New System.Drawing.Size(166, 21)
        Me.SYComboBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GradingDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(204, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 450)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'GradingDataGridView
        '
        Me.GradingDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GradingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GradingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.GradingDataGridView.Location = New System.Drawing.Point(6, 16)
        Me.GradingDataGridView.Name = "GradingDataGridView"
        Me.GradingDataGridView.Size = New System.Drawing.Size(344, 429)
        Me.GradingDataGridView.TabIndex = 1
        '
        'Column4
        '
        Me.Column4.HeaderText = "Student ID"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Student Name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Grading"
        Me.Column6.Name = "Column6"
        '
        'GradingGroupBox
        '
        Me.GradingGroupBox.Controls.Add(Me.GoButton)
        Me.GradingGroupBox.Controls.Add(Me.TeacherComboBox)
        Me.GradingGroupBox.Controls.Add(Me.Label1)
        Me.GradingGroupBox.Controls.Add(Me.YearComboBox)
        Me.GradingGroupBox.Controls.Add(Me.SectionComboBox)
        Me.GradingGroupBox.Controls.Add(Me.SubjectComboBox)
        Me.GradingGroupBox.Controls.Add(Me.Label2)
        Me.GradingGroupBox.Controls.Add(Me.Label3)
        Me.GradingGroupBox.Controls.Add(Me.Label4)
        Me.GradingGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingGroupBox.Location = New System.Drawing.Point(6, 110)
        Me.GradingGroupBox.Name = "GradingGroupBox"
        Me.GradingGroupBox.Size = New System.Drawing.Size(200, 161)
        Me.GradingGroupBox.TabIndex = 10
        Me.GradingGroupBox.TabStop = False
        '
        'GoButton
        '
        Me.GoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoButton.Location = New System.Drawing.Point(68, 121)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(113, 36)
        Me.GoButton.TabIndex = 10
        Me.GoButton.Text = "&Search"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TeacherComboBox
        '
        Me.TeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TeacherComboBox.FormattingEnabled = True
        Me.TeacherComboBox.Location = New System.Drawing.Point(68, 13)
        Me.TeacherComboBox.Name = "TeacherComboBox"
        Me.TeacherComboBox.Size = New System.Drawing.Size(113, 21)
        Me.TeacherComboBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Teacher:"
        '
        'YearComboBox
        '
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(68, 40)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(113, 21)
        Me.YearComboBox.TabIndex = 6
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Location = New System.Drawing.Point(68, 67)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SectionComboBox.TabIndex = 9
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(68, 94)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SubjectComboBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Section:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Subject:"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(227, 485)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(107, 40)
        Me.CloseButton.TabIndex = 16
        Me.CloseButton.Text = "&Main"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(563, 25)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "Grading System"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Grading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(563, 527)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GradingSystemGroupBox)
        Me.Name = "Grading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading"
        Me.GradingSystemGroupBox.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GradingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradingGroupBox.ResumeLayout(False)
        Me.GradingGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GradingSystemGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GradingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TeacherComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GradingPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SYComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GradingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

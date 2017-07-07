<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.DisableSystemButton = New System.Windows.Forms.Button
        Me.SaveSystemDTButton = New System.Windows.Forms.Button
        Me.EditSystemDateTimeButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BackButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.UnitDataGridView = New System.Windows.Forms.DataGridView
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BackSubjectTextBox = New System.Windows.Forms.TextBox
        Me.ReservationFeeTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.UnitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisableSystemButton
        '
        Me.DisableSystemButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableSystemButton.ForeColor = System.Drawing.Color.Black
        Me.DisableSystemButton.Location = New System.Drawing.Point(8, 88)
        Me.DisableSystemButton.Name = "DisableSystemButton"
        Me.DisableSystemButton.Size = New System.Drawing.Size(71, 27)
        Me.DisableSystemButton.TabIndex = 2
        Me.DisableSystemButton.Text = "&Cancel"
        Me.DisableSystemButton.UseVisualStyleBackColor = True
        '
        'SaveSystemDTButton
        '
        Me.SaveSystemDTButton.Enabled = False
        Me.SaveSystemDTButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSystemDTButton.ForeColor = System.Drawing.Color.Black
        Me.SaveSystemDTButton.Location = New System.Drawing.Point(8, 62)
        Me.SaveSystemDTButton.Name = "SaveSystemDTButton"
        Me.SaveSystemDTButton.Size = New System.Drawing.Size(71, 27)
        Me.SaveSystemDTButton.TabIndex = 1
        Me.SaveSystemDTButton.Text = "&Save"
        Me.SaveSystemDTButton.UseVisualStyleBackColor = True
        '
        'EditSystemDateTimeButton
        '
        Me.EditSystemDateTimeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSystemDateTimeButton.ForeColor = System.Drawing.Color.Black
        Me.EditSystemDateTimeButton.Location = New System.Drawing.Point(8, 36)
        Me.EditSystemDateTimeButton.Name = "EditSystemDateTimeButton"
        Me.EditSystemDateTimeButton.Size = New System.Drawing.Size(71, 27)
        Me.EditSystemDateTimeButton.TabIndex = 0
        Me.EditSystemDateTimeButton.Text = "&Edit"
        Me.EditSystemDateTimeButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 25)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "Settings"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Black
        Me.BackButton.Location = New System.Drawing.Point(102, 325)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(76, 42)
        Me.BackButton.TabIndex = 46
        Me.BackButton.Text = "&Main"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(53, 62)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 26)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.Value = New Date(2014, 2, 18, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(53, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 26)
        Me.DateTimePicker2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.EditSystemDateTimeButton)
        Me.GroupBox2.Controls.Add(Me.DisableSystemButton)
        Me.GroupBox2.Controls.Add(Me.SaveSystemDTButton)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 300)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(85, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(189, 281)
        Me.TabControl1.TabIndex = 47
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(181, 255)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Others"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.BackSubjectTextBox)
        Me.GroupBox1.Controls.Add(Me.ReservationFeeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 248)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UnitDataGridView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 172)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edit the cost of subject per unit"
        '
        'UnitDataGridView
        '
        Me.UnitDataGridView.AllowUserToAddRows = False
        Me.UnitDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.UnitDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5})
        Me.UnitDataGridView.Location = New System.Drawing.Point(-11, 31)
        Me.UnitDataGridView.Name = "UnitDataGridView"
        Me.UnitDataGridView.Size = New System.Drawing.Size(169, 135)
        Me.UnitDataGridView.TabIndex = 72
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 40
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cost"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 80
        '
        'BackSubjectTextBox
        '
        Me.BackSubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackSubjectTextBox.Location = New System.Drawing.Point(100, 44)
        Me.BackSubjectTextBox.Name = "BackSubjectTextBox"
        Me.BackSubjectTextBox.Size = New System.Drawing.Size(66, 20)
        Me.BackSubjectTextBox.TabIndex = 70
        Me.BackSubjectTextBox.Text = "0"
        Me.BackSubjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ReservationFeeTextBox
        '
        Me.ReservationFeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationFeeTextBox.Location = New System.Drawing.Point(100, 18)
        Me.ReservationFeeTextBox.Name = "ReservationFeeTextBox"
        Me.ReservationFeeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.ReservationFeeTextBox.TabIndex = 66
        Me.ReservationFeeTextBox.Text = "0"
        Me.ReservationFeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Reservation Fee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "BackSubject Limit:"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(291, 367)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.UnitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisableSystemButton As System.Windows.Forms.Button
    Friend WithEvents SaveSystemDTButton As System.Windows.Forms.Button
    Friend WithEvents EditSystemDateTimeButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ReservationFeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackSubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Year
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Year))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.YearListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.DeleteYearButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ClearButton = New System.Windows.Forms.Button
        Me.YearLabel = New System.Windows.Forms.Label
        Me.YearLevelTextBox = New System.Windows.Forms.TextBox
        Me.SaveButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SectionPictureBox = New System.Windows.Forms.PictureBox
        Me.SectionButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SectionPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.YearListView)
        Me.GroupBox1.Controls.Add(Me.DeleteYearButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 283)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 33
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'YearListView
        '
        Me.YearListView.BackColor = System.Drawing.Color.White
        Me.YearListView.CheckBoxes = True
        Me.YearListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1})
        Me.YearListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearListView.FullRowSelect = True
        Me.YearListView.Location = New System.Drawing.Point(6, 42)
        Me.YearListView.Name = "YearListView"
        Me.YearListView.Size = New System.Drawing.Size(214, 136)
        Me.YearListView.TabIndex = 16
        Me.YearListView.UseCompatibleStateImageBehavior = False
        Me.YearListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "#"
        Me.ColumnHeader2.Width = 37
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Year"
        Me.ColumnHeader1.Width = 138
        '
        'DeleteYearButton
        '
        Me.DeleteYearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteYearButton.Location = New System.Drawing.Point(27, 13)
        Me.DeleteYearButton.Name = "DeleteYearButton"
        Me.DeleteYearButton.Size = New System.Drawing.Size(55, 27)
        Me.DeleteYearButton.TabIndex = 32
        Me.DeleteYearButton.Text = "&Delete"
        Me.DeleteYearButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.GradeComboBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ClearButton)
        Me.GroupBox3.Controls.Add(Me.YearLabel)
        Me.GroupBox3.Controls.Add(Me.YearLevelTextBox)
        Me.GroupBox3.Controls.Add(Me.SaveButton)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 100)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Year Information"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Items.AddRange(New Object() {"Grade School", "High School"})
        Me.GradeComboBox.Location = New System.Drawing.Point(78, 20)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(110, 21)
        Me.GradeComboBox.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Grade:"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(138, 70)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(50, 27)
        Me.ClearButton.TabIndex = 31
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLabel.Location = New System.Drawing.Point(11, 50)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(61, 13)
        Me.YearLabel.TabIndex = 0
        Me.YearLabel.Text = "Year Level:"
        '
        'YearLevelTextBox
        '
        Me.YearLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLevelTextBox.Location = New System.Drawing.Point(78, 47)
        Me.YearLevelTextBox.Name = "YearLevelTextBox"
        Me.YearLevelTextBox.Size = New System.Drawing.Size(110, 20)
        Me.YearLevelTextBox.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(91, 70)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(48, 27)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(0, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 25)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "=====Year======"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(75, 302)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 56)
        Me.ExitButton.TabIndex = 47
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SectionPictureBox
        '
        Me.SectionPictureBox.Image = CType(resources.GetObject("SectionPictureBox.Image"), System.Drawing.Image)
        Me.SectionPictureBox.Location = New System.Drawing.Point(166, 325)
        Me.SectionPictureBox.Name = "SectionPictureBox"
        Me.SectionPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.SectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SectionPictureBox.TabIndex = 44
        Me.SectionPictureBox.TabStop = False
        '
        'SectionButton
        '
        Me.SectionButton.BackColor = System.Drawing.SystemColors.Control
        Me.SectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SectionButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionButton.Location = New System.Drawing.Point(151, 302)
        Me.SectionButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SectionButton.Name = "SectionButton"
        Me.SectionButton.Size = New System.Drawing.Size(75, 56)
        Me.SectionButton.TabIndex = 43
        Me.SectionButton.Text = "Section"
        Me.SectionButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SectionButton.UseVisualStyleBackColor = False
        '
        'Year
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(228, 360)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SectionPictureBox)
        Me.Controls.Add(Me.SectionButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Year"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SectionPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents YearLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearLabel As System.Windows.Forms.Label
    Friend WithEvents YearListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents DeleteYearButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SectionPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SectionButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
End Class

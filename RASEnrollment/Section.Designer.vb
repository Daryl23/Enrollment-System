<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SaveButton = New System.Windows.Forms.Button
        Me.MaxTextBox = New System.Windows.Forms.TextBox
        Me.YearNameComboBox = New System.Windows.Forms.ComboBox
        Me.SectionTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SectionListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.YearButton = New System.Windows.Forms.Button
        Me.SubjectButton = New System.Windows.Forms.Button
        Me.SubjectPictureBox = New System.Windows.Forms.PictureBox
        Me.YearPictureBox = New System.Windows.Forms.PictureBox
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SubjectPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ClearButton)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.SaveButton)
        Me.GroupBox5.Controls.Add(Me.MaxTextBox)
        Me.GroupBox5.Controls.Add(Me.YearNameComboBox)
        Me.GroupBox5.Controls.Add(Me.SectionTextBox)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(6, 197)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 127)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Section Information"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(144, 92)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(48, 28)
        Me.ClearButton.TabIndex = 33
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Maximum Capacity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Year Level:"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(92, 92)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(48, 28)
        Me.SaveButton.TabIndex = 19
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'MaxTextBox
        '
        Me.MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxTextBox.Location = New System.Drawing.Point(110, 66)
        Me.MaxTextBox.Name = "MaxTextBox"
        Me.MaxTextBox.Size = New System.Drawing.Size(30, 20)
        Me.MaxTextBox.TabIndex = 28
        '
        'YearNameComboBox
        '
        Me.YearNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearNameComboBox.FormattingEnabled = True
        Me.YearNameComboBox.Location = New System.Drawing.Point(73, 16)
        Me.YearNameComboBox.Name = "YearNameComboBox"
        Me.YearNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.YearNameComboBox.TabIndex = 20
        '
        'SectionTextBox
        '
        Me.SectionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionTextBox.Location = New System.Drawing.Point(73, 41)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SectionTextBox.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Section:"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Section"
        Me.ColumnHeader7.Width = 92
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 39
        '
        'SectionListView
        '
        Me.SectionListView.BackColor = System.Drawing.SystemColors.Control
        Me.SectionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2})
        Me.SectionListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionListView.FullRowSelect = True
        Me.SectionListView.Location = New System.Drawing.Point(6, 43)
        Me.SectionListView.Name = "SectionListView"
        Me.SectionListView.Size = New System.Drawing.Size(200, 158)
        Me.SectionListView.TabIndex = 16
        Me.SectionListView.UseCompatibleStateImageBehavior = False
        Me.SectionListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Max"
        Me.ColumnHeader2.Width = 64
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.SectionListView)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 330)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(6, 13)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(119, 28)
        Me.DeleteButton.TabIndex = 34
        Me.DeleteButton.Text = "&Delete Last Section"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 25)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "Section"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(72, 352)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(67, 48)
        Me.ExitButton.TabIndex = 28
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'YearButton
        '
        Me.YearButton.BackColor = System.Drawing.SystemColors.Control
        Me.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearButton.ForeColor = System.Drawing.Color.Black
        Me.YearButton.Location = New System.Drawing.Point(4, 352)
        Me.YearButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.YearButton.Name = "YearButton"
        Me.YearButton.Size = New System.Drawing.Size(67, 48)
        Me.YearButton.TabIndex = 26
        Me.YearButton.Text = "Year"
        Me.YearButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.YearButton.UseVisualStyleBackColor = False
        '
        'SubjectButton
        '
        Me.SubjectButton.BackColor = System.Drawing.SystemColors.Control
        Me.SubjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubjectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectButton.ForeColor = System.Drawing.Color.Black
        Me.SubjectButton.Location = New System.Drawing.Point(140, 352)
        Me.SubjectButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SubjectButton.Name = "SubjectButton"
        Me.SubjectButton.Size = New System.Drawing.Size(67, 48)
        Me.SubjectButton.TabIndex = 24
        Me.SubjectButton.Text = "Subject"
        Me.SubjectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SubjectButton.UseVisualStyleBackColor = False
        '
        'SubjectPictureBox
        '
        Me.SubjectPictureBox.Image = CType(resources.GetObject("SubjectPictureBox.Image"), System.Drawing.Image)
        Me.SubjectPictureBox.Location = New System.Drawing.Point(152, 372)
        Me.SubjectPictureBox.Name = "SubjectPictureBox"
        Me.SubjectPictureBox.Size = New System.Drawing.Size(41, 26)
        Me.SubjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SubjectPictureBox.TabIndex = 29
        Me.SubjectPictureBox.TabStop = False
        '
        'YearPictureBox
        '
        Me.YearPictureBox.Image = CType(resources.GetObject("YearPictureBox.Image"), System.Drawing.Image)
        Me.YearPictureBox.Location = New System.Drawing.Point(17, 372)
        Me.YearPictureBox.Name = "YearPictureBox"
        Me.YearPictureBox.Size = New System.Drawing.Size(41, 26)
        Me.YearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.YearPictureBox.TabIndex = 27
        Me.YearPictureBox.TabStop = False
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(210, 400)
        Me.Controls.Add(Me.SubjectPictureBox)
        Me.Controls.Add(Me.YearPictureBox)
        Me.Controls.Add(Me.YearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubjectButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SubjectPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents YearNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SectionListView As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents YearPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents YearButton As System.Windows.Forms.Button
    Friend WithEvents SubjectButton As System.Windows.Forms.Button
    Friend WithEvents SubjectPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class

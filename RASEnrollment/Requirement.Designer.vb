<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requirement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requirement))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.RequirementTextBox = New System.Windows.Forms.TextBox
        Me.RequirementDescriptionTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.RequirementsListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.RequirementsGroupBox = New System.Windows.Forms.GroupBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ClearButton = New System.Windows.Forms.Button
        Me.StudTypeComboBox = New System.Windows.Forms.ComboBox
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.RefundPictureBox = New System.Windows.Forms.PictureBox
        Me.RefundButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.RequirementsGroupBox.SuspendLayout()
        CType(Me.RefundPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Requirement:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(281, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "(Optional)"
        '
        'RequirementTextBox
        '
        Me.RequirementTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequirementTextBox.Location = New System.Drawing.Point(90, 74)
        Me.RequirementTextBox.Name = "RequirementTextBox"
        Me.RequirementTextBox.Size = New System.Drawing.Size(116, 20)
        Me.RequirementTextBox.TabIndex = 3
        '
        'RequirementDescriptionTextBox
        '
        Me.RequirementDescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequirementDescriptionTextBox.Location = New System.Drawing.Point(230, 36)
        Me.RequirementDescriptionTextBox.Multiline = True
        Me.RequirementDescriptionTextBox.Name = "RequirementDescriptionTextBox"
        Me.RequirementDescriptionTextBox.Size = New System.Drawing.Size(184, 58)
        Me.RequirementDescriptionTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.RequirementsListView)
        Me.GroupBox1.Controls.Add(Me.RequirementsGroupBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 356)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(30, 13)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(50, 28)
        Me.DeleteButton.TabIndex = 20
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Location = New System.Drawing.Point(9, 20)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 19
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'RequirementsListView
        '
        Me.RequirementsListView.BackColor = System.Drawing.Color.White
        Me.RequirementsListView.CheckBoxes = True
        Me.RequirementsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.RequirementsListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequirementsListView.FullRowSelect = True
        Me.RequirementsListView.Location = New System.Drawing.Point(6, 42)
        Me.RequirementsListView.Name = "RequirementsListView"
        Me.RequirementsListView.Size = New System.Drawing.Size(429, 171)
        Me.RequirementsListView.TabIndex = 10
        Me.RequirementsListView.UseCompatibleStateImageBehavior = False
        Me.RequirementsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Student Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 79
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grade/Year"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Requirement"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.Width = 120
        '
        'RequirementsGroupBox
        '
        Me.RequirementsGroupBox.Controls.Add(Me.GradeComboBox)
        Me.RequirementsGroupBox.Controls.Add(Me.Label5)
        Me.RequirementsGroupBox.Controls.Add(Me.ClearButton)
        Me.RequirementsGroupBox.Controls.Add(Me.StudTypeComboBox)
        Me.RequirementsGroupBox.Controls.Add(Me.SaveButton)
        Me.RequirementsGroupBox.Controls.Add(Me.Label4)
        Me.RequirementsGroupBox.Controls.Add(Me.Label1)
        Me.RequirementsGroupBox.Controls.Add(Me.RequirementTextBox)
        Me.RequirementsGroupBox.Controls.Add(Me.RequirementDescriptionTextBox)
        Me.RequirementsGroupBox.Controls.Add(Me.Label3)
        Me.RequirementsGroupBox.Controls.Add(Me.Label2)
        Me.RequirementsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequirementsGroupBox.Location = New System.Drawing.Point(6, 212)
        Me.RequirementsGroupBox.Name = "RequirementsGroupBox"
        Me.RequirementsGroupBox.Size = New System.Drawing.Size(429, 139)
        Me.RequirementsGroupBox.TabIndex = 9
        Me.RequirementsGroupBox.TabStop = False
        Me.RequirementsGroupBox.Text = "Requirements' Information"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Items.AddRange(New Object() {"Grade School ", "High School"})
        Me.GradeComboBox.Location = New System.Drawing.Point(90, 47)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(116, 21)
        Me.GradeComboBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Grade:"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(213, 100)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(57, 32)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StudTypeComboBox
        '
        Me.StudTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StudTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudTypeComboBox.FormattingEnabled = True
        Me.StudTypeComboBox.Items.AddRange(New Object() {"Old", "New", "Transferee", "Foreign", "ALL"})
        Me.StudTypeComboBox.Location = New System.Drawing.Point(90, 20)
        Me.StudTypeComboBox.Name = "StudTypeComboBox"
        Me.StudTypeComboBox.Size = New System.Drawing.Size(116, 21)
        Me.StudTypeComboBox.TabIndex = 6
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(150, 100)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(57, 32)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Student Type:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(443, 25)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "Requirement"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(217, 376)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(84, 54)
        Me.ExitButton.TabIndex = 28
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'RefundPictureBox
        '
        Me.RefundPictureBox.Image = CType(resources.GetObject("RefundPictureBox.Image"), System.Drawing.Image)
        Me.RefundPictureBox.Location = New System.Drawing.Point(151, 397)
        Me.RefundPictureBox.Name = "RefundPictureBox"
        Me.RefundPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.RefundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefundPictureBox.TabIndex = 27
        Me.RefundPictureBox.TabStop = False
        '
        'RefundButton
        '
        Me.RefundButton.BackColor = System.Drawing.SystemColors.Control
        Me.RefundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefundButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundButton.Location = New System.Drawing.Point(131, 376)
        Me.RefundButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RefundButton.Name = "RefundButton"
        Me.RefundButton.Size = New System.Drawing.Size(84, 54)
        Me.RefundButton.TabIndex = 26
        Me.RefundButton.Text = "Refund"
        Me.RefundButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RefundButton.UseVisualStyleBackColor = False
        '
        'Requirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(443, 431)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RefundPictureBox)
        Me.Controls.Add(Me.RefundButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Requirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requirement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RequirementsGroupBox.ResumeLayout(False)
        Me.RequirementsGroupBox.PerformLayout()
        CType(Me.RefundPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RequirementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequirementDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StudTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RequirementsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents RequirementsListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents RefundPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RefundButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class

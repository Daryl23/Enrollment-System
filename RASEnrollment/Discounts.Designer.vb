<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discounts))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.AmountRadioButton = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.PercentageRadioButton = New System.Windows.Forms.RadioButton
        Me.DiscountTypeComboBox = New System.Windows.Forms.ComboBox
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DiscountRateTextBox = New System.Windows.Forms.TextBox
        Me.DiscountTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DiscountListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ExitButton = New System.Windows.Forms.Button
        Me.RoomsPictureBox = New System.Windows.Forms.PictureBox
        Me.RoomsButton = New System.Windows.Forms.Button
        Me.RefundPictureBox = New System.Windows.Forms.PictureBox
        Me.RefundButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.RoomsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefundPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AmountRadioButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PercentageRadioButton)
        Me.GroupBox1.Controls.Add(Me.DiscountTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.GradeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DiscountRateTextBox)
        Me.GroupBox1.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 159)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Discount Information"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(201, 123)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(44, 26)
        Me.ClearButton.TabIndex = 56
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(157, 123)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(44, 26)
        Me.SaveButton.TabIndex = 55
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Discount by:"
        '
        'AmountRadioButton
        '
        Me.AmountRadioButton.AutoSize = True
        Me.AmountRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountRadioButton.Location = New System.Drawing.Point(179, 76)
        Me.AmountRadioButton.Name = "AmountRadioButton"
        Me.AmountRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.AmountRadioButton.TabIndex = 51
        Me.AmountRadioButton.TabStop = True
        Me.AmountRadioButton.Text = "Amount"
        Me.AmountRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Type:"
        '
        'PercentageRadioButton
        '
        Me.PercentageRadioButton.AutoSize = True
        Me.PercentageRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageRadioButton.Location = New System.Drawing.Point(95, 76)
        Me.PercentageRadioButton.Name = "PercentageRadioButton"
        Me.PercentageRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.PercentageRadioButton.TabIndex = 50
        Me.PercentageRadioButton.TabStop = True
        Me.PercentageRadioButton.Text = "Percentage"
        Me.PercentageRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountTypeComboBox
        '
        Me.DiscountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiscountTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTypeComboBox.FormattingEnabled = True
        Me.DiscountTypeComboBox.Items.AddRange(New Object() {"Default Discount", "Honor Discount", "Other Discount"})
        Me.DiscountTypeComboBox.Location = New System.Drawing.Point(85, 47)
        Me.DiscountTypeComboBox.Name = "DiscountTypeComboBox"
        Me.DiscountTypeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.DiscountTypeComboBox.TabIndex = 53
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Items.AddRange(New Object() {"Grade School ", "High School"})
        Me.GradeComboBox.Location = New System.Drawing.Point(85, 20)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(147, 21)
        Me.GradeComboBox.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Grade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "%"
        '
        'DiscountRateTextBox
        '
        Me.DiscountRateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountRateTextBox.Location = New System.Drawing.Point(85, 127)
        Me.DiscountRateTextBox.Name = "DiscountRateTextBox"
        Me.DiscountRateTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DiscountRateTextBox.TabIndex = 46
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextBox.Location = New System.Drawing.Point(85, 101)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(107, 20)
        Me.DiscountTextBox.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Percent:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Discount:"
        '
        'DiscountListView
        '
        Me.DiscountListView.BackColor = System.Drawing.Color.White
        Me.DiscountListView.CheckBoxes = True
        Me.DiscountListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.DiscountListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountListView.FullRowSelect = True
        Me.DiscountListView.Location = New System.Drawing.Point(6, 38)
        Me.DiscountListView.Name = "DiscountListView"
        Me.DiscountListView.Size = New System.Drawing.Size(283, 126)
        Me.DiscountListView.TabIndex = 0
        Me.DiscountListView.UseCompatibleStateImageBehavior = False
        Me.DiscountListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Discount Name"
        Me.ColumnHeader3.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 33
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "By"
        Me.ColumnHeader2.Width = 55
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Percent/ Amount"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(106, 361)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(71, 57)
        Me.ExitButton.TabIndex = 37
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'RoomsPictureBox
        '
        Me.RoomsPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RoomsPictureBox.Image = CType(resources.GetObject("RoomsPictureBox.Image"), System.Drawing.Image)
        Me.RoomsPictureBox.Location = New System.Drawing.Point(48, 381)
        Me.RoomsPictureBox.Name = "RoomsPictureBox"
        Me.RoomsPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.RoomsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoomsPictureBox.TabIndex = 36
        Me.RoomsPictureBox.TabStop = False
        '
        'RoomsButton
        '
        Me.RoomsButton.BackColor = System.Drawing.SystemColors.Control
        Me.RoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsButton.Location = New System.Drawing.Point(34, 361)
        Me.RoomsButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RoomsButton.Name = "RoomsButton"
        Me.RoomsButton.Size = New System.Drawing.Size(71, 57)
        Me.RoomsButton.TabIndex = 35
        Me.RoomsButton.Text = "Rooms"
        Me.RoomsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RoomsButton.UseVisualStyleBackColor = False
        '
        'RefundPictureBox
        '
        Me.RefundPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RefundPictureBox.Image = CType(resources.GetObject("RefundPictureBox.Image"), System.Drawing.Image)
        Me.RefundPictureBox.Location = New System.Drawing.Point(192, 381)
        Me.RefundPictureBox.Name = "RefundPictureBox"
        Me.RefundPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.RefundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefundPictureBox.TabIndex = 34
        Me.RefundPictureBox.TabStop = False
        '
        'RefundButton
        '
        Me.RefundButton.BackColor = System.Drawing.SystemColors.Control
        Me.RefundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefundButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundButton.Location = New System.Drawing.Point(178, 361)
        Me.RefundButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RefundButton.Name = "RefundButton"
        Me.RefundButton.Size = New System.Drawing.Size(71, 57)
        Me.RefundButton.TabIndex = 33
        Me.RefundButton.Text = "Refund"
        Me.RefundButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RefundButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteButton)
        Me.GroupBox2.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox2.Controls.Add(Me.DiscountListView)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 331)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(29, 11)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(51, 26)
        Me.DeleteButton.TabIndex = 34
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCheckBox.Location = New System.Drawing.Point(8, 18)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 33
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 25)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = "Discount"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Discounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(300, 417)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RoomsPictureBox)
        Me.Controls.Add(Me.RoomsButton)
        Me.Controls.Add(Me.RefundPictureBox)
        Me.Controls.Add(Me.RefundButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Discounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RoomsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefundPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents RoomsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RoomsButton As System.Windows.Forms.Button
    Friend WithEvents RefundPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RefundButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AmountRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PercentageRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DiscountTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DiscountRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class

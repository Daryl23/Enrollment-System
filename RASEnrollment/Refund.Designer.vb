<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Refund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Refund))
        Me.ExitButton = New System.Windows.Forms.Button
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.RefundListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PercentageTextBox = New System.Windows.Forms.TextBox
        Me.DaysTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Days = New System.Windows.Forms.Label
        Me.DiscountsButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DiscountsPictureBox = New System.Windows.Forms.PictureBox
        Me.RequirementPictureBox = New System.Windows.Forms.PictureBox
        Me.RequirementButton = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DiscountsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequirementPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(90, 311)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(49, 55)
        Me.ExitButton.TabIndex = 45
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Percentage"
        Me.ColumnHeader3.Width = 79
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteButton)
        Me.GroupBox2.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox2.Controls.Add(Me.RefundListView)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 289)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(27, 11)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(50, 24)
        Me.DeleteButton.TabIndex = 34
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Location = New System.Drawing.Point(6, 17)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 33
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'RefundListView
        '
        Me.RefundListView.BackColor = System.Drawing.Color.White
        Me.RefundListView.CheckBoxes = True
        Me.RefundListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.RefundListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundListView.FullRowSelect = True
        Me.RefundListView.Location = New System.Drawing.Point(6, 37)
        Me.RefundListView.Name = "RefundListView"
        Me.RefundListView.Size = New System.Drawing.Size(214, 134)
        Me.RefundListView.TabIndex = 0
        Me.RefundListView.UseCompatibleStateImageBehavior = False
        Me.RefundListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Days"
        Me.ColumnHeader2.Width = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PercentageTextBox)
        Me.GroupBox1.Controls.Add(Me.DaysTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Days)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(165, 110)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Refund Information"
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(86, 72)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(41, 32)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(39, 72)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(41, 32)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "%"
        '
        'PercentageTextBox
        '
        Me.PercentageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageTextBox.Location = New System.Drawing.Point(86, 46)
        Me.PercentageTextBox.MaxLength = 2
        Me.PercentageTextBox.Name = "PercentageTextBox"
        Me.PercentageTextBox.Size = New System.Drawing.Size(35, 20)
        Me.PercentageTextBox.TabIndex = 3
        Me.PercentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DaysTextBox
        '
        Me.DaysTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaysTextBox.Location = New System.Drawing.Point(86, 20)
        Me.DaysTextBox.MaxLength = 3
        Me.DaysTextBox.Name = "DaysTextBox"
        Me.DaysTextBox.Size = New System.Drawing.Size(35, 20)
        Me.DaysTextBox.TabIndex = 2
        Me.DaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Percentage:"
        '
        'Days
        '
        Me.Days.AutoSize = True
        Me.Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days.Location = New System.Drawing.Point(46, 23)
        Me.Days.Name = "Days"
        Me.Days.Size = New System.Drawing.Size(34, 13)
        Me.Days.TabIndex = 0
        Me.Days.Text = "Days:"
        '
        'DiscountsButton
        '
        Me.DiscountsButton.BackColor = System.Drawing.SystemColors.Control
        Me.DiscountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiscountsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountsButton.Location = New System.Drawing.Point(1, 311)
        Me.DiscountsButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DiscountsButton.Name = "DiscountsButton"
        Me.DiscountsButton.Size = New System.Drawing.Size(88, 55)
        Me.DiscountsButton.TabIndex = 43
        Me.DiscountsButton.Text = "Discounts"
        Me.DiscountsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DiscountsButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 25)
        Me.TextBox1.TabIndex = 42
        Me.TextBox1.Text = "Refund"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiscountsPictureBox
        '
        Me.DiscountsPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DiscountsPictureBox.Image = CType(resources.GetObject("DiscountsPictureBox.Image"), System.Drawing.Image)
        Me.DiscountsPictureBox.Location = New System.Drawing.Point(22, 333)
        Me.DiscountsPictureBox.Name = "DiscountsPictureBox"
        Me.DiscountsPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.DiscountsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiscountsPictureBox.TabIndex = 44
        Me.DiscountsPictureBox.TabStop = False
        '
        'RequirementPictureBox
        '
        Me.RequirementPictureBox.Image = CType(resources.GetObject("RequirementPictureBox.Image"), System.Drawing.Image)
        Me.RequirementPictureBox.Location = New System.Drawing.Point(161, 333)
        Me.RequirementPictureBox.Name = "RequirementPictureBox"
        Me.RequirementPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.RequirementPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RequirementPictureBox.TabIndex = 49
        Me.RequirementPictureBox.TabStop = False
        '
        'RequirementButton
        '
        Me.RequirementButton.BackColor = System.Drawing.SystemColors.Control
        Me.RequirementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RequirementButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequirementButton.ForeColor = System.Drawing.Color.Black
        Me.RequirementButton.Location = New System.Drawing.Point(140, 311)
        Me.RequirementButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RequirementButton.Name = "RequirementButton"
        Me.RequirementButton.Size = New System.Drawing.Size(88, 55)
        Me.RequirementButton.TabIndex = 48
        Me.RequirementButton.Text = "Requirement"
        Me.RequirementButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RequirementButton.UseVisualStyleBackColor = False
        '
        'Refund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(230, 368)
        Me.Controls.Add(Me.RequirementPictureBox)
        Me.Controls.Add(Me.RequirementButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DiscountsPictureBox)
        Me.Controls.Add(Me.DiscountsButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Refund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DiscountsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequirementPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RefundListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PercentageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Days As System.Windows.Forms.Label
    Friend WithEvents DiscountsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DiscountsButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RequirementPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RequirementButton As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateAndTime
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
        Me.SystemGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SystemTimeDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SystemDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DisableSystemButton = New System.Windows.Forms.Button
        Me.SaveSystemDTButton = New System.Windows.Forms.Button
        Me.EditSystemDateTimeButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.BackButton = New System.Windows.Forms.Button
        Me.SystemGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SystemGroupBox
        '
        Me.SystemGroupBox.Controls.Add(Me.Label2)
        Me.SystemGroupBox.Controls.Add(Me.Label1)
        Me.SystemGroupBox.Controls.Add(Me.SystemTimeDateTimePicker)
        Me.SystemGroupBox.Controls.Add(Me.SystemDateDateTimePicker)
        Me.SystemGroupBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemGroupBox.ForeColor = System.Drawing.Color.Green
        Me.SystemGroupBox.Location = New System.Drawing.Point(103, 30)
        Me.SystemGroupBox.Name = "SystemGroupBox"
        Me.SystemGroupBox.Size = New System.Drawing.Size(186, 106)
        Me.SystemGroupBox.TabIndex = 21
        Me.SystemGroupBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Date:"
        '
        'SystemTimeDateTimePicker
        '
        Me.SystemTimeDateTimePicker.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.SystemTimeDateTimePicker.Location = New System.Drawing.Point(53, 62)
        Me.SystemTimeDateTimePicker.Name = "SystemTimeDateTimePicker"
        Me.SystemTimeDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SystemTimeDateTimePicker.ShowUpDown = True
        Me.SystemTimeDateTimePicker.Size = New System.Drawing.Size(109, 26)
        Me.SystemTimeDateTimePicker.TabIndex = 3
        Me.SystemTimeDateTimePicker.Value = New Date(2014, 2, 18, 0, 0, 0, 0)
        '
        'SystemDateDateTimePicker
        '
        Me.SystemDateDateTimePicker.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SystemDateDateTimePicker.Location = New System.Drawing.Point(53, 16)
        Me.SystemDateDateTimePicker.Name = "SystemDateDateTimePicker"
        Me.SystemDateDateTimePicker.Size = New System.Drawing.Size(109, 26)
        Me.SystemDateDateTimePicker.TabIndex = 0
        '
        'DisableSystemButton
        '
        Me.DisableSystemButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableSystemButton.ForeColor = System.Drawing.Color.Black
        Me.DisableSystemButton.Location = New System.Drawing.Point(6, 104)
        Me.DisableSystemButton.Name = "DisableSystemButton"
        Me.DisableSystemButton.Size = New System.Drawing.Size(91, 32)
        Me.DisableSystemButton.TabIndex = 2
        Me.DisableSystemButton.Text = "&Cancel"
        Me.DisableSystemButton.UseVisualStyleBackColor = True
        '
        'SaveSystemDTButton
        '
        Me.SaveSystemDTButton.Enabled = False
        Me.SaveSystemDTButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSystemDTButton.ForeColor = System.Drawing.Color.Black
        Me.SaveSystemDTButton.Location = New System.Drawing.Point(6, 72)
        Me.SaveSystemDTButton.Name = "SaveSystemDTButton"
        Me.SaveSystemDTButton.Size = New System.Drawing.Size(91, 32)
        Me.SaveSystemDTButton.TabIndex = 1
        Me.SaveSystemDTButton.Text = "&Save"
        Me.SaveSystemDTButton.UseVisualStyleBackColor = True
        '
        'EditSystemDateTimeButton
        '
        Me.EditSystemDateTimeButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSystemDateTimeButton.ForeColor = System.Drawing.Color.Black
        Me.EditSystemDateTimeButton.Location = New System.Drawing.Point(6, 40)
        Me.EditSystemDateTimeButton.Name = "EditSystemDateTimeButton"
        Me.EditSystemDateTimeButton.Size = New System.Drawing.Size(91, 32)
        Me.EditSystemDateTimeButton.TabIndex = 0
        Me.EditSystemDateTimeButton.Text = "&Edit"
        Me.EditSystemDateTimeButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 25)
        Me.TextBox1.TabIndex = 44
        Me.TextBox1.Text = "Date/ Time"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape1.CornerRadius = 9
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 3)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(289, 34)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(292, 142)
        Me.ShapeContainer2.TabIndex = 45
        Me.ShapeContainer2.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.Black
        Me.BackButton.Location = New System.Drawing.Point(213, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(76, 28)
        Me.BackButton.TabIndex = 46
        Me.BackButton.Text = "&Main"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DateAndTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 142)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SystemGroupBox)
        Me.Controls.Add(Me.EditSystemDateTimeButton)
        Me.Controls.Add(Me.DisableSystemButton)
        Me.Controls.Add(Me.SaveSystemDTButton)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Name = "DateAndTime"
        Me.Text = "DateAndTime"
        Me.SystemGroupBox.ResumeLayout(False)
        Me.SystemGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SystemGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SystemTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DisableSystemButton As System.Windows.Forms.Button
    Friend WithEvents SaveSystemDTButton As System.Windows.Forms.Button
    Friend WithEvents EditSystemDateTimeButton As System.Windows.Forms.Button
    Friend WithEvents SystemDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.SaveButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ClearButton = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.CheckCheckBox = New System.Windows.Forms.CheckBox
        Me.RoomsListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RoomNoTextBox = New System.Windows.Forms.TextBox
        Me.RoomTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FloorTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BuildingTextBox = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DiscountButton = New System.Windows.Forms.Button
        Me.DiscountPictureBox = New System.Windows.Forms.PictureBox
        Me.TeacherButton = New System.Windows.Forms.Button
        Me.TeacherPictureBox = New System.Windows.Forms.PictureBox
        Me.ExitButton = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DiscountPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(269, 12)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(49, 30)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.CheckCheckBox)
        Me.GroupBox1.Controls.Add(Me.RoomsListView)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 315)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(269, 42)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(49, 30)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(24, 16)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(56, 24)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CheckCheckBox
        '
        Me.CheckCheckBox.AutoSize = True
        Me.CheckCheckBox.Location = New System.Drawing.Point(6, 21)
        Me.CheckCheckBox.Name = "CheckCheckBox"
        Me.CheckCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CheckCheckBox.TabIndex = 17
        Me.CheckCheckBox.UseVisualStyleBackColor = True
        '
        'RoomsListView
        '
        Me.RoomsListView.BackColor = System.Drawing.Color.White
        Me.RoomsListView.CheckBoxes = True
        Me.RoomsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.RoomsListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsListView.FullRowSelect = True
        Me.RoomsListView.Location = New System.Drawing.Point(6, 41)
        Me.RoomsListView.Name = "RoomsListView"
        Me.RoomsListView.Size = New System.Drawing.Size(324, 185)
        Me.RoomsListView.TabIndex = 16
        Me.RoomsListView.UseCompatibleStateImageBehavior = False
        Me.RoomsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 32
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room No."
        Me.ColumnHeader3.Width = 61
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Name"
        Me.ColumnHeader5.Width = 64
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type"
        Me.ColumnHeader7.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Building"
        Me.ColumnHeader2.Width = 53
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Floor"
        Me.ColumnHeader4.Width = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ClearButton)
        Me.GroupBox2.Controls.Add(Me.RoomNoTextBox)
        Me.GroupBox2.Controls.Add(Me.RoomTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.FloorTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BuildingTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 76)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Information"
        '
        'RoomNoTextBox
        '
        Me.RoomNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNoTextBox.Location = New System.Drawing.Point(77, 22)
        Me.RoomNoTextBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RoomNoTextBox.Name = "RoomNoTextBox"
        Me.RoomNoTextBox.Size = New System.Drawing.Size(87, 20)
        Me.RoomNoTextBox.TabIndex = 2
        '
        'RoomTypeComboBox
        '
        Me.RoomTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeComboBox.FormattingEnabled = True
        Me.RoomTypeComboBox.Items.AddRange(New Object() {"Lecture", "Laboratory"})
        Me.RoomTypeComboBox.Location = New System.Drawing.Point(77, 47)
        Me.RoomTypeComboBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.RoomTypeComboBox.Name = "RoomTypeComboBox"
        Me.RoomTypeComboBox.Size = New System.Drawing.Size(87, 21)
        Me.RoomTypeComboBox.TabIndex = 10
        Me.RoomTypeComboBox.Text = "Lecture"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Floor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "In Building:"
        '
        'FloorTextBox
        '
        Me.FloorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FloorTextBox.Location = New System.Drawing.Point(232, 47)
        Me.FloorTextBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.FloorTextBox.Name = "FloorTextBox"
        Me.FloorTextBox.Size = New System.Drawing.Size(35, 20)
        Me.FloorTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Room Type:"
        '
        'BuildingTextBox
        '
        Me.BuildingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildingTextBox.Location = New System.Drawing.Point(232, 22)
        Me.BuildingTextBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BuildingTextBox.Name = "BuildingTextBox"
        Me.BuildingTextBox.Size = New System.Drawing.Size(35, 20)
        Me.BuildingTextBox.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(334, 25)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Room"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiscountButton
        '
        Me.DiscountButton.BackColor = System.Drawing.SystemColors.Control
        Me.DiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiscountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountButton.Location = New System.Drawing.Point(211, 334)
        Me.DiscountButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DiscountButton.Name = "DiscountButton"
        Me.DiscountButton.Size = New System.Drawing.Size(71, 54)
        Me.DiscountButton.TabIndex = 19
        Me.DiscountButton.Text = "Discount"
        Me.DiscountButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DiscountButton.UseVisualStyleBackColor = False
        '
        'DiscountPictureBox
        '
        Me.DiscountPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DiscountPictureBox.Image = CType(resources.GetObject("DiscountPictureBox.Image"), System.Drawing.Image)
        Me.DiscountPictureBox.Location = New System.Drawing.Point(226, 355)
        Me.DiscountPictureBox.Name = "DiscountPictureBox"
        Me.DiscountPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.DiscountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DiscountPictureBox.TabIndex = 20
        Me.DiscountPictureBox.TabStop = False
        '
        'TeacherButton
        '
        Me.TeacherButton.BackColor = System.Drawing.SystemColors.Control
        Me.TeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeacherButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherButton.Location = New System.Drawing.Point(67, 334)
        Me.TeacherButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TeacherButton.Name = "TeacherButton"
        Me.TeacherButton.Size = New System.Drawing.Size(71, 54)
        Me.TeacherButton.TabIndex = 21
        Me.TeacherButton.Text = "Teacher"
        Me.TeacherButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TeacherButton.UseVisualStyleBackColor = False
        '
        'TeacherPictureBox
        '
        Me.TeacherPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TeacherPictureBox.Image = CType(resources.GetObject("TeacherPictureBox.Image"), System.Drawing.Image)
        Me.TeacherPictureBox.Location = New System.Drawing.Point(81, 355)
        Me.TeacherPictureBox.Name = "TeacherPictureBox"
        Me.TeacherPictureBox.Size = New System.Drawing.Size(41, 28)
        Me.TeacherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TeacherPictureBox.TabIndex = 22
        Me.TeacherPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Control
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(139, 334)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(71, 54)
        Me.ExitButton.TabIndex = 23
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(341, 388)
        Me.Controls.Add(Me.DiscountPictureBox)
        Me.Controls.Add(Me.DiscountButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TeacherPictureBox)
        Me.Controls.Add(Me.TeacherButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DiscountPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RoomTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FloorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuildingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RoomsListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CheckCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DiscountButton As System.Windows.Forms.Button
    Friend WithEvents DiscountPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TeacherButton As System.Windows.Forms.Button
    Friend WithEvents TeacherPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
End Class

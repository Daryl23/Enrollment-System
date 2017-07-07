<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GradeComboBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SearchTextBox = New System.Windows.Forms.TextBox
        Me.ReservationGroupBox = New System.Windows.Forms.GroupBox
        Me.ReservationListView = New System.Windows.Forms.ListView
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ReservationGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sort:"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(46, 12)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GradeComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search:"
        Me.Label2.Visible = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(223, 13)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(135, 20)
        Me.SearchTextBox.TabIndex = 3
        Me.SearchTextBox.Visible = False
        '
        'ReservationGroupBox
        '
        Me.ReservationGroupBox.Controls.Add(Me.CheckBox1)
        Me.ReservationGroupBox.Controls.Add(Me.Button1)
        Me.ReservationGroupBox.Controls.Add(Me.ReservationListView)
        Me.ReservationGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationGroupBox.Location = New System.Drawing.Point(0, 63)
        Me.ReservationGroupBox.Name = "ReservationGroupBox"
        Me.ReservationGroupBox.Size = New System.Drawing.Size(372, 311)
        Me.ReservationGroupBox.TabIndex = 4
        Me.ReservationGroupBox.TabStop = False
        Me.ReservationGroupBox.Text = "List of Reserved Students"
        '
        'ReservationListView
        '
        Me.ReservationListView.BackColor = System.Drawing.Color.White
        Me.ReservationListView.CheckBoxes = True
        Me.ReservationListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ReservationListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReservationListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationListView.FullRowSelect = True
        Me.ReservationListView.Location = New System.Drawing.Point(6, 48)
        Me.ReservationListView.Name = "ReservationListView"
        Me.ReservationListView.Size = New System.Drawing.Size(360, 257)
        Me.ReservationListView.TabIndex = 1
        Me.ReservationListView.UseCompatibleStateImageBehavior = False
        Me.ReservationListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "#"
        Me.ColumnHeader29.Width = 34
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Student ID "
        Me.ColumnHeader30.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Grade/Year"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Reservation Date "
        Me.ColumnHeader3.Width = 100
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(-3, -1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(375, 25)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "Class Management"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GradeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 42)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancel Reservation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(372, 375)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ReservationGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        Me.ReservationGroupBox.ResumeLayout(False)
        Me.ReservationGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GradeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReservationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ReservationListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

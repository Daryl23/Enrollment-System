<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.Label3 = New System.Windows.Forms.Label
        Me.NameLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SystemTimeLabel = New System.Windows.Forms.Label
        Me.SystemDateLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ProceedPictureBox = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.ProceedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(152, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Welcome!"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.White
        Me.NameLabel.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.NameLabel.Location = New System.Drawing.Point(237, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(61, 15)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Daryl,"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(152, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "You just logged in at "
        '
        'SystemTimeLabel
        '
        Me.SystemTimeLabel.AutoSize = True
        Me.SystemTimeLabel.BackColor = System.Drawing.Color.White
        Me.SystemTimeLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SystemTimeLabel.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemTimeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SystemTimeLabel.Location = New System.Drawing.Point(151, 69)
        Me.SystemTimeLabel.Name = "SystemTimeLabel"
        Me.SystemTimeLabel.Size = New System.Drawing.Size(70, 15)
        Me.SystemTimeLabel.TabIndex = 11
        Me.SystemTimeLabel.Text = "9:30 AM"
        '
        'SystemDateLabel
        '
        Me.SystemDateLabel.AutoSize = True
        Me.SystemDateLabel.BackColor = System.Drawing.Color.White
        Me.SystemDateLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SystemDateLabel.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemDateLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SystemDateLabel.Location = New System.Drawing.Point(152, 49)
        Me.SystemDateLabel.Name = "SystemDateLabel"
        Me.SystemDateLabel.Size = New System.Drawing.Size(160, 15)
        Me.SystemDateLabel.TabIndex = 12
        Me.SystemDateLabel.Text = "February 21, 2014"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(222, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(5, 87)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(143, 40)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "RAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enrollment System"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProceedPictureBox
        '
        Me.ProceedPictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ProceedPictureBox.Image = CType(resources.GetObject("ProceedPictureBox.Image"), System.Drawing.Image)
        Me.ProceedPictureBox.Location = New System.Drawing.Point(328, 87)
        Me.ProceedPictureBox.Name = "ProceedPictureBox"
        Me.ProceedPictureBox.Size = New System.Drawing.Size(80, 29)
        Me.ProceedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProceedPictureBox.TabIndex = 15
        Me.ProceedPictureBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 126)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SystemDateLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ProceedPictureBox)
        Me.Controls.Add(Me.SystemTimeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        CType(Me.ProceedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SystemTimeLabel As System.Windows.Forms.Label
    Friend WithEvents SystemDateLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ProceedPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.LoginPictureBox = New System.Windows.Forms.PictureBox
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.UserIDTextBox.Location = New System.Drawing.Point(178, 35)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(148, 27)
        Me.UserIDTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(178, 74)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(148, 27)
        Me.PasswordTextBox.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(85, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(85, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-2, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(345, 23)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "User Login"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(-2, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(345, 20)
        Me.TextBox2.TabIndex = 13
        '
        'LoginPictureBox
        '
        Me.LoginPictureBox.Image = CType(resources.GetObject("LoginPictureBox.Image"), System.Drawing.Image)
        Me.LoginPictureBox.Location = New System.Drawing.Point(178, 107)
        Me.LoginPictureBox.Name = "LoginPictureBox"
        Me.LoginPictureBox.Size = New System.Drawing.Size(68, 34)
        Me.LoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LoginPictureBox.TabIndex = 14
        Me.LoginPictureBox.TabStop = False
        '
        'ExitPictureBox
        '
        Me.ExitPictureBox.Image = CType(resources.GetObject("ExitPictureBox.Image"), System.Drawing.Image)
        Me.ExitPictureBox.Location = New System.Drawing.Point(252, 108)
        Me.ExitPictureBox.Name = "ExitPictureBox"
        Me.ExitPictureBox.Size = New System.Drawing.Size(74, 33)
        Me.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ExitPictureBox.TabIndex = 15
        Me.ExitPictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LoginForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(343, 165)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.Controls.Add(Me.LoginPictureBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAS User Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LoginPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExitPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class

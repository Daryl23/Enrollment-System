<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.DateTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.ListOfLabel = New System.Windows.Forms.Label
        Me.TransactionNoTextBox = New System.Windows.Forms.TextBox
        Me.PrintPreviewButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ReceiptListView = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DateTextBox
        '
        Me.DateTextBox.BackColor = System.Drawing.Color.White
        Me.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateTextBox.Enabled = False
        Me.DateTextBox.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.ForeColor = System.Drawing.Color.Black
        Me.DateTextBox.Location = New System.Drawing.Point(467, 114)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(168, 18)
        Me.DateTextBox.TabIndex = 303
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(420, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 302
        Me.Label10.Text = "Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(450, 683)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 16)
        Me.Label9.TabIndex = 301
        Me.Label9.Text = "Authorized Signature"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.Color.White
        Me.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.ForeColor = System.Drawing.Color.Gray
        Me.UserNameTextBox.Location = New System.Drawing.Point(456, 665)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(133, 15)
        Me.UserNameTextBox.TabIndex = 300
        Me.UserNameTextBox.Text = "Romina Fabella"
        Me.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListOfLabel
        '
        Me.ListOfLabel.AutoSize = True
        Me.ListOfLabel.BackColor = System.Drawing.Color.White
        Me.ListOfLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListOfLabel.Location = New System.Drawing.Point(18, 112)
        Me.ListOfLabel.Name = "ListOfLabel"
        Me.ListOfLabel.Size = New System.Drawing.Size(62, 22)
        Me.ListOfLabel.TabIndex = 291
        Me.ListOfLabel.Text = "List of"
        '
        'TransactionNoTextBox
        '
        Me.TransactionNoTextBox.BackColor = System.Drawing.Color.White
        Me.TransactionNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransactionNoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.TransactionNoTextBox.Location = New System.Drawing.Point(443, 112)
        Me.TransactionNoTextBox.Name = "TransactionNoTextBox"
        Me.TransactionNoTextBox.Size = New System.Drawing.Size(185, 22)
        Me.TransactionNoTextBox.TabIndex = 290
        Me.TransactionNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPreviewButton.ForeColor = System.Drawing.Color.Black
        Me.PrintPreviewButton.Location = New System.Drawing.Point(86, 664)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Size = New System.Drawing.Size(111, 35)
        Me.PrintPreviewButton.TabIndex = 284
        Me.PrintPreviewButton.Text = "&Print Preview"
        Me.PrintPreviewButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Location = New System.Drawing.Point(6, 664)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(74, 35)
        Me.PrintButton.TabIndex = 283
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(203, 664)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 35)
        Me.Button2.TabIndex = 285
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ReceiptListView
        '
        Me.ReceiptListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiptListView.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptListView.Location = New System.Drawing.Point(9, 137)
        Me.ReceiptListView.Name = "ReceiptListView"
        Me.ReceiptListView.Size = New System.Drawing.Size(626, 522)
        Me.ReceiptListView.TabIndex = 304
        Me.ReceiptListView.UseCompatibleStateImageBehavior = False
        Me.ReceiptListView.View = System.Windows.Forms.View.Details
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 308
        Me.Label4.Text = "Tel. No. (043) 321-3763"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 19)
        Me.Label3.TabIndex = 307
        Me.Label3.Text = "Non Vat Reg. TIN: 007-778-001-000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Namunga . Rosario, Batangas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 24)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "ROSARIO ADVENTIST SCHOOL, RAS, INC."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 309
        Me.PictureBox1.TabStop = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 712)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.ListOfLabel)
        Me.Controls.Add(Me.TransactionNoTextBox)
        Me.Controls.Add(Me.PrintPreviewButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ReceiptListView)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListOfLabel As System.Windows.Forms.Label
    Friend WithEvents TransactionNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintPreviewButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ReceiptListView As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

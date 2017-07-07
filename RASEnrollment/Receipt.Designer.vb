<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.PrintButton = New System.Windows.Forms.Button
        Me.PrintPreviewButton = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TransactionNoTextBox = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.YearSectionTextBox = New System.Windows.Forms.TextBox
        Me.SchoolYearTextBox = New System.Windows.Forms.TextBox
        Me.ReceiptListView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.AmountTextBox = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.Label8 = New System.Windows.Forms.Label
        Me.ChangeTextBox = New System.Windows.Forms.TextBox
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DateTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.MisTextBox = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TotalBalanceTextBox = New System.Windows.Forms.TextBox
        Me.OtherTextBox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(638, 523)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Location = New System.Drawing.Point(110, 541)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(144, 35)
        Me.PrintButton.TabIndex = 157
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPreviewButton.ForeColor = System.Drawing.Color.Black
        Me.PrintPreviewButton.Location = New System.Drawing.Point(260, 541)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Size = New System.Drawing.Size(144, 35)
        Me.PrintPreviewButton.TabIndex = 158
        Me.PrintPreviewButton.Text = "&Print Preview"
        Me.PrintPreviewButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(410, 541)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 35)
        Me.Button2.TabIndex = 159
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 31)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "ROSARIO ADVENTIST SCHOOL, RAS, INC."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Namunga . Rosario, Batangas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 19)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Non Vat Reg. TIN: 007-778-001-000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Tel. No. (043) 321-3763"
        '
        'TransactionNoTextBox
        '
        Me.TransactionNoTextBox.BackColor = System.Drawing.Color.White
        Me.TransactionNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransactionNoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.TransactionNoTextBox.Location = New System.Drawing.Point(449, 119)
        Me.TransactionNoTextBox.Name = "TransactionNoTextBox"
        Me.TransactionNoTextBox.Size = New System.Drawing.Size(185, 22)
        Me.TransactionNoTextBox.TabIndex = 165
        Me.TransactionNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(362, 118)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 23)
        Me.Label38.TabIndex = 164
        Me.Label38.Text = "OR No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "OFFICIAL RECEIPT"
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.BackColor = System.Drawing.Color.White
        Me.StudentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentNameTextBox.Enabled = False
        Me.StudentNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.StudentNameTextBox.Location = New System.Drawing.Point(410, 146)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(152, 22)
        Me.StudentNameTextBox.TabIndex = 174
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.BackColor = System.Drawing.Color.White
        Me.StudentNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentNoTextBox.Enabled = False
        Me.StudentNoTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.StudentNoTextBox.Location = New System.Drawing.Point(184, 146)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(111, 22)
        Me.StudentNoTextBox.TabIndex = 173
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(304, 175)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 26)
        Me.Label23.TabIndex = 172
        Me.Label23.Text = "Year/ Section:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(89, 175)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(97, 26)
        Me.Label41.TabIndex = 171
        Me.Label41.Text = "School Year:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(298, 146)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(112, 26)
        Me.Label50.TabIndex = 170
        Me.Label50.Text = "Student Name:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.White
        Me.Label62.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(87, 146)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(96, 26)
        Me.Label62.TabIndex = 169
        Me.Label62.Text = "Student No.:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YearSectionTextBox
        '
        Me.YearSectionTextBox.BackColor = System.Drawing.Color.White
        Me.YearSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YearSectionTextBox.Enabled = False
        Me.YearSectionTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearSectionTextBox.Location = New System.Drawing.Point(410, 175)
        Me.YearSectionTextBox.Name = "YearSectionTextBox"
        Me.YearSectionTextBox.Size = New System.Drawing.Size(152, 22)
        Me.YearSectionTextBox.TabIndex = 168
        '
        'SchoolYearTextBox
        '
        Me.SchoolYearTextBox.BackColor = System.Drawing.Color.White
        Me.SchoolYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchoolYearTextBox.Enabled = False
        Me.SchoolYearTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolYearTextBox.Location = New System.Drawing.Point(184, 175)
        Me.SchoolYearTextBox.Name = "SchoolYearTextBox"
        Me.SchoolYearTextBox.Size = New System.Drawing.Size(111, 22)
        Me.SchoolYearTextBox.TabIndex = 167
        '
        'ReceiptListView
        '
        Me.ReceiptListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiptListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ReceiptListView.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptListView.Location = New System.Drawing.Point(90, 203)
        Me.ReceiptListView.Name = "ReceiptListView"
        Me.ReceiptListView.Size = New System.Drawing.Size(472, 168)
        Me.ReceiptListView.TabIndex = 175
        Me.ReceiptListView.UseCompatibleStateImageBehavior = False
        Me.ReceiptListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Fee Description"
        Me.ColumnHeader1.Width = 339
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.Width = 131
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 26)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Total:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalTextBox
        '
        Me.TotalTextBox.BackColor = System.Drawing.Color.White
        Me.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(429, 373)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(133, 26)
        Me.TotalTextBox.TabIndex = 176
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(299, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 18)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Amount Tendered:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountTextBox
        '
        Me.AmountTextBox.BackColor = System.Drawing.Color.White
        Me.AmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountTextBox.Enabled = False
        Me.AmountTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(429, 401)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(133, 26)
        Me.AmountTextBox.TabIndex = 178
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(90, 370)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(472, 94)
        Me.ListView2.TabIndex = 180
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Change:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeTextBox
        '
        Me.ChangeTextBox.BackColor = System.Drawing.Color.White
        Me.ChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeTextBox.Enabled = False
        Me.ChangeTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeTextBox.Location = New System.Drawing.Point(429, 429)
        Me.ChangeTextBox.Name = "ChangeTextBox"
        Me.ChangeTextBox.Size = New System.Drawing.Size(133, 26)
        Me.ChangeTextBox.TabIndex = 181
        Me.ChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.Color.White
        Me.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.ForeColor = System.Drawing.Color.Gray
        Me.UserNameTextBox.Location = New System.Drawing.Point(427, 476)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(133, 19)
        Me.UserNameTextBox.TabIndex = 183
        Me.UserNameTextBox.Text = "Romina Fabella"
        Me.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 19)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Authorized Signature"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(14, 469)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(219, 66)
        Me.TextBox1.TabIndex = 185
        Me.TextBox1.Text = "100 Bklts. 50x2 0001-5000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BIR Permit RD No. OCN 1AU0000746857" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date Issued: 06/0" & _
            "9/2011" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Non Vat Reg. TIN: 906-877-196-000"
        '
        'DateTextBox
        '
        Me.DateTextBox.BackColor = System.Drawing.Color.White
        Me.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateTextBox.Enabled = False
        Me.DateTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.ForeColor = System.Drawing.Color.Black
        Me.DateTextBox.Location = New System.Drawing.Point(482, 93)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(168, 19)
        Me.DateTextBox.TabIndex = 187
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(442, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 18)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(110, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 26)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "Remaining Balance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(92, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 189
        Me.Label12.Text = "Miscellaneous Fees: "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(92, 405)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 15)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "Tuition and Computer Fees:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(119, 448)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "Total Balance:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(201, 435)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 193
        Me.Label16.Text = "___________"
        '
        'MisTextBox
        '
        Me.MisTextBox.BackColor = System.Drawing.Color.White
        Me.MisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MisTextBox.Enabled = False
        Me.MisTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MisTextBox.Location = New System.Drawing.Point(197, 389)
        Me.MisTextBox.Name = "MisTextBox"
        Me.MisTextBox.Size = New System.Drawing.Size(82, 14)
        Me.MisTextBox.TabIndex = 194
        Me.MisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(231, 404)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(70, 14)
        Me.TextBox2.TabIndex = 195
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalBalanceTextBox
        '
        Me.TotalBalanceTextBox.BackColor = System.Drawing.Color.White
        Me.TotalBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TotalBalanceTextBox.Enabled = False
        Me.TotalBalanceTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBalanceTextBox.Location = New System.Drawing.Point(197, 449)
        Me.TotalBalanceTextBox.Name = "TotalBalanceTextBox"
        Me.TotalBalanceTextBox.Size = New System.Drawing.Size(82, 14)
        Me.TotalBalanceTextBox.TabIndex = 197
        Me.TotalBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OtherTextBox
        '
        Me.OtherTextBox.BackColor = System.Drawing.Color.White
        Me.OtherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OtherTextBox.Enabled = False
        Me.OtherTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherTextBox.Location = New System.Drawing.Point(197, 433)
        Me.OtherTextBox.Name = "OtherTextBox"
        Me.OtherTextBox.Size = New System.Drawing.Size(82, 14)
        Me.OtherTextBox.TabIndex = 198
        Me.OtherTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(129, 433)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 15)
        Me.Label17.TabIndex = 199
        Me.Label17.Text = "Other Fees:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(662, 588)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.OtherTextBox)
        Me.Controls.Add(Me.TotalBalanceTextBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MisTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChangeTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.SchoolYearTextBox)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.YearSectionTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TransactionNoTextBox)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PrintPreviewButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ReceiptListView)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TransactionNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents YearSectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceiptListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TotalBalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents OtherTextBox As System.Windows.Forms.TextBox
End Class

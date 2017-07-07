<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssessmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssessmentForm))
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.DiscountLabel = New System.Windows.Forms.Label
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ListOfSchedulesListView = New System.Windows.Forms.ListView
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label8 = New System.Windows.Forms.Label
        Me.TuitionListView = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.DownPaymentTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.OthersListView = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.DateTextBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.SchoolYearTextBox = New System.Windows.Forms.TextBox
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.YearSectionTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.TransactionNoTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.PrintPreviewButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MisListView = New System.Windows.Forms.ListView
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ReceiptListView = New System.Windows.Forms.ListView
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TuitionandComputerTextBox = New System.Windows.Forms.TextBox
        Me.DisclaimerAssessLabel = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Payments"
        Me.ColumnHeader5.Width = 113
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 133
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.BackColor = System.Drawing.Color.White
        Me.DiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountLabel.ForeColor = System.Drawing.Color.Red
        Me.DiscountLabel.Location = New System.Drawing.Point(332, 444)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(112, 13)
        Me.DiscountLabel.TabIndex = 279
        Me.DiscountLabel.Text = "*Tution Discounted by"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Payment Date"
        Me.ColumnHeader9.Width = 95
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Subject"
        Me.ColumnHeader16.Width = 109
        '
        'ListOfSchedulesListView
        '
        Me.ListOfSchedulesListView.BackColor = System.Drawing.Color.White
        Me.ListOfSchedulesListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23})
        Me.ListOfSchedulesListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListOfSchedulesListView.Location = New System.Drawing.Point(19, 507)
        Me.ListOfSchedulesListView.Name = "ListOfSchedulesListView"
        Me.ListOfSchedulesListView.Size = New System.Drawing.Size(606, 149)
        Me.ListOfSchedulesListView.TabIndex = 271
        Me.ListOfSchedulesListView.UseCompatibleStateImageBehavior = False
        Me.ListOfSchedulesListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Day(s)"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader20.Width = 127
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Time"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader21.Width = 131
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Teacher"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader22.Width = 121
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Room"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader23.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = ""
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 110
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(296, 24)
        Me.Label8.TabIndex = 267
        Me.Label8.Text = "-Tuition and Computer Fees-"
        '
        'TuitionListView
        '
        Me.TuitionListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TuitionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader9})
        Me.TuitionListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuitionListView.Location = New System.Drawing.Point(328, 265)
        Me.TuitionListView.Name = "TuitionListView"
        Me.TuitionListView.Size = New System.Drawing.Size(296, 175)
        Me.TuitionListView.TabIndex = 269
        Me.TuitionListView.UseCompatibleStateImageBehavior = False
        Me.TuitionListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "List of Schedules"
        Me.ColumnHeader8.Width = 604
        '
        'ListView4
        '
        Me.ListView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8})
        Me.ListView4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.Location = New System.Drawing.Point(19, 483)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(606, 136)
        Me.ListView4.TabIndex = 276
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'DownPaymentTextBox
        '
        Me.DownPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DownPaymentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownPaymentTextBox.Location = New System.Drawing.Point(177, 461)
        Me.DownPaymentTextBox.Multiline = True
        Me.DownPaymentTextBox.Name = "DownPaymentTextBox"
        Me.DownPaymentTextBox.ReadOnly = True
        Me.DownPaymentTextBox.Size = New System.Drawing.Size(152, 23)
        Me.DownPaymentTextBox.TabIndex = 275
        Me.DownPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(19, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 23)
        Me.Label12.TabIndex = 273
        Me.Label12.Text = "Downpayment:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OthersListView
        '
        Me.OthersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OthersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader7})
        Me.OthersListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OthersListView.Location = New System.Drawing.Point(177, 242)
        Me.OthersListView.Name = "OthersListView"
        Me.OthersListView.Size = New System.Drawing.Size(152, 220)
        Me.OthersListView.TabIndex = 274
        Me.OthersListView.UseCompatibleStateImageBehavior = False
        Me.OthersListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 110
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 24)
        Me.Label6.TabIndex = 263
        Me.Label6.Text = "-Miscellaneous and Other Fees-"
        '
        'DateTextBox
        '
        Me.DateTextBox.BackColor = System.Drawing.Color.White
        Me.DateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateTextBox.Enabled = False
        Me.DateTextBox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTextBox.ForeColor = System.Drawing.Color.Black
        Me.DateTextBox.Location = New System.Drawing.Point(473, 83)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(168, 19)
        Me.DateTextBox.TabIndex = 261
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(433, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 18)
        Me.Label10.TabIndex = 260
        Me.Label10.Text = "Date:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(447, 680)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 16)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "Authorized Signature"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.Color.White
        Me.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.ForeColor = System.Drawing.Color.Gray
        Me.UserNameTextBox.Location = New System.Drawing.Point(453, 662)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(133, 15)
        Me.UserNameTextBox.TabIndex = 258
        Me.UserNameTextBox.Text = "Romina Fabella"
        Me.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SchoolYearTextBox
        '
        Me.SchoolYearTextBox.BackColor = System.Drawing.Color.White
        Me.SchoolYearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchoolYearTextBox.Enabled = False
        Me.SchoolYearTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolYearTextBox.Location = New System.Drawing.Point(134, 165)
        Me.SchoolYearTextBox.Name = "SchoolYearTextBox"
        Me.SchoolYearTextBox.Size = New System.Drawing.Size(145, 22)
        Me.SchoolYearTextBox.TabIndex = 250
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.BackColor = System.Drawing.Color.White
        Me.StudentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentNameTextBox.Enabled = False
        Me.StudentNameTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.StudentNameTextBox.Location = New System.Drawing.Point(438, 136)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(178, 22)
        Me.StudentNameTextBox.TabIndex = 257
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.BackColor = System.Drawing.Color.White
        Me.StudentNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudentNoTextBox.Enabled = False
        Me.StudentNoTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.StudentNoTextBox.Location = New System.Drawing.Point(134, 136)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(145, 22)
        Me.StudentNoTextBox.TabIndex = 256
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(332, 165)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 26)
        Me.Label23.TabIndex = 255
        Me.Label23.Text = "Year/ Section:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(39, 165)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(97, 26)
        Me.Label41.TabIndex = 254
        Me.Label41.Text = "School Year:"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(326, 136)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(112, 26)
        Me.Label50.TabIndex = 253
        Me.Label50.Text = "Student Name:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.White
        Me.Label62.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(37, 136)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(96, 26)
        Me.Label62.TabIndex = 252
        Me.Label62.Text = "Student No.:"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YearSectionTextBox
        '
        Me.YearSectionTextBox.BackColor = System.Drawing.Color.White
        Me.YearSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YearSectionTextBox.Enabled = False
        Me.YearSectionTextBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearSectionTextBox.Location = New System.Drawing.Point(438, 165)
        Me.YearSectionTextBox.Name = "YearSectionTextBox"
        Me.YearSectionTextBox.Size = New System.Drawing.Size(178, 22)
        Me.YearSectionTextBox.TabIndex = 251
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Assessment Form"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "List of Fees"
        Me.ColumnHeader1.Width = 604
        '
        'TransactionNoTextBox
        '
        Me.TransactionNoTextBox.BackColor = System.Drawing.Color.White
        Me.TransactionNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransactionNoTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.TransactionNoTextBox.Location = New System.Drawing.Point(440, 109)
        Me.TransactionNoTextBox.Name = "TransactionNoTextBox"
        Me.TransactionNoTextBox.Size = New System.Drawing.Size(185, 22)
        Me.TransactionNoTextBox.TabIndex = 248
        Me.TransactionNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 19)
        Me.Label4.TabIndex = 247
        Me.Label4.Text = "Tel. No. (043) 321-3763"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 19)
        Me.Label3.TabIndex = 246
        Me.Label3.Text = "Non Vat Reg. TIN: 007-778-001-000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 19)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "Namunga . Rosario, Batangas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 24)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "ROSARIO ADVENTIST SCHOOL, RAS, INC."
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(401, 709)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 35)
        Me.Button2.TabIndex = 243
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPreviewButton.ForeColor = System.Drawing.Color.Black
        Me.PrintPreviewButton.Location = New System.Drawing.Point(251, 709)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Size = New System.Drawing.Size(144, 35)
        Me.PrintPreviewButton.TabIndex = 242
        Me.PrintPreviewButton.Text = "&Print Preview"
        Me.PrintPreviewButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MisListView
        '
        Me.MisListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MisListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.MisListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MisListView.Location = New System.Drawing.Point(19, 242)
        Me.MisListView.Name = "MisListView"
        Me.MisListView.Size = New System.Drawing.Size(162, 220)
        Me.MisListView.TabIndex = 265
        Me.MisListView.UseCompatibleStateImageBehavior = False
        Me.MisListView.View = System.Windows.Forms.View.Details
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
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Location = New System.Drawing.Point(101, 709)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(144, 35)
        Me.PrintButton.TabIndex = 241
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ReceiptListView
        '
        Me.ReceiptListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceiptListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ReceiptListView.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiptListView.Location = New System.Drawing.Point(19, 194)
        Me.ReceiptListView.Name = "ReceiptListView"
        Me.ReceiptListView.Size = New System.Drawing.Size(389, 509)
        Me.ReceiptListView.TabIndex = 262
        Me.ReceiptListView.UseCompatibleStateImageBehavior = False
        Me.ReceiptListView.View = System.Windows.Forms.View.Details
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(-7, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(638, 705)
        Me.RichTextBox1.TabIndex = 240
        Me.RichTextBox1.Text = ""
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(430, 219)
        Me.GrandTotalTextBox.Multiline = True
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.ReadOnly = True
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(194, 24)
        Me.GrandTotalTextBox.TabIndex = 281
        Me.GrandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Silver
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(328, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 24)
        Me.Label15.TabIndex = 280
        Me.Label15.Text = "Grand Total:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 282
        Me.PictureBox1.TabStop = False
        '
        'TuitionandComputerTextBox
        '
        Me.TuitionandComputerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TuitionandComputerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuitionandComputerTextBox.Location = New System.Drawing.Point(520, 242)
        Me.TuitionandComputerTextBox.Multiline = True
        Me.TuitionandComputerTextBox.Name = "TuitionandComputerTextBox"
        Me.TuitionandComputerTextBox.ReadOnly = True
        Me.TuitionandComputerTextBox.Size = New System.Drawing.Size(104, 24)
        Me.TuitionandComputerTextBox.TabIndex = 283
        Me.TuitionandComputerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisclaimerAssessLabel
        '
        Me.DisclaimerAssessLabel.AutoSize = True
        Me.DisclaimerAssessLabel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisclaimerAssessLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DisclaimerAssessLabel.Location = New System.Drawing.Point(21, 659)
        Me.DisclaimerAssessLabel.Name = "DisclaimerAssessLabel"
        Me.DisclaimerAssessLabel.Size = New System.Drawing.Size(414, 30)
        Me.DisclaimerAssessLabel.TabIndex = 284
        Me.DisclaimerAssessLabel.Text = "Note: Section is  temporary until the student is able to settle his/ her downpaym" & _
            "ent. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Slot will be taken once another student enrolled."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(326, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "*Downpayment( 50% of Total Miscellaneous & Other Fees)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(332, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(294, 13)
        Me.Label11.TabIndex = 286
        Me.Label11.Text = "*DownPayment(50 % of Total Miscellaneous and Other Fees)"
        '
        'AssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 746)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DisclaimerAssessLabel)
        Me.Controls.Add(Me.TuitionandComputerTextBox)
        Me.Controls.Add(Me.GrandTotalTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DiscountLabel)
        Me.Controls.Add(Me.ListOfSchedulesListView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TuitionListView)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.DownPaymentTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.OthersListView)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserNameTextBox)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PrintPreviewButton)
        Me.Controls.Add(Me.MisListView)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ReceiptListView)
        Me.Name = "AssessmentForm"
        Me.Text = "AssessmentForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListOfSchedulesListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TuitionListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents DownPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OthersListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolYearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents YearSectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TransactionNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents MisListView As System.Windows.Forms.ListView
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ReceiptListView As System.Windows.Forms.ListView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GrandTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TuitionandComputerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DisclaimerAssessLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class

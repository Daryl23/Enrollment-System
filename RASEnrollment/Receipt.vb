Option Strict On
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Receipt
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SqlString As String
    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserNameTextBox.Text = Main.UserName
        Try
            SqlString = "SELECT schoolyearstart,schoolyearend  From tblSchoolYear where schoolyearid='" & Main.SYID & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SchoolYearTextBox.Text = CStr(DatePart(DateInterval.Year, CDate(myreader.GetMySqlDateTime("schoolyearstart")))) & "-" & CStr(DatePart(DateInterval.Year, CDate(myreader.GetMySqlDateTime("schoolyearend"))))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        DateTextBox.Text = System.DateTime.Now.ToString
        TransactionNoTextBox.Text = Main.TransactionNoPaymentTextBox.Text
        StudentNoTextBox.Text = Main.StudentNoPaymentTextBox.Text
        StudentNameTextBox.Text = Main.StudentNameTextBox.Text
        YearSectionTextBox.Text = Main.YearLevelPaymentTextBox.Text & "-" & Main.SectionPaymentTextBox.Text

        AmountTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.AmountTenderedPaymentTextBox.Text)
        ChangeTextBox.Text = Main.ChangePaymentTextBox.Text
        Dim Total As Decimal
        Dim Change As Decimal
        Try
            Change = CDec(Main.AmountTenderedPaymentTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        For i = 0 To Main.FeeIDToPayList.Count - 1
            If Change > 0 Then
                ReceiptListView.Items.Add(Main.FeeNameToPayList.Item(i))
                If Change > Main.FeeAmountToPayList.Item(i) Then
                    Change = Change - Main.FeeAmountToPayList.Item(i)
                    ReceiptListView.Items(ReceiptListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P " + "#,##0.00}", Main.FeeAmountToPayList.Item(i)))
                Else
                    ReceiptListView.Items(ReceiptListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P " + "#,##0.00}", Change))
                    Exit For
                End If
                Total = Total + Main.FeeAmountToPayList.Item(i)
            End If

        Next
        TotalTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Total)
        Main.ViewFees()
        MisTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.MiscellaneousBalancePayment)
        TextBox2.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.TuitionBalancePayment)
        'ComputerTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.ComputerBalancePayment)
        OtherTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.OtherBalancePayment)
        TotalBalanceTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", Main.TotalBalance)
    End Sub

    Private Sub EditDiscountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintForm1.Print()
        End If
    End Sub


    ' Declare a string to hold the entire document contents. 
    Private documentContents As String

    ' Declare a variable to hold the portion of the document that 
    ' is not printed. 
    Private stringToPrint As String
    Private Sub PrintPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewButton.Click
        PrintForm1.Form = Me
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 1
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CInt(250)
        PrintButton.Visible = False
        PrintPreviewButton.Visible = False
        Button2.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        PrintButton.Visible = True
        Button2.Visible = True
        PrintPreviewButton.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub


End Class
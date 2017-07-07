Option Strict On
Imports MySql.Data.MySqlClient
Public Class Fees
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;" ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim LoadInfo As String
    Dim SYType As String = Main.SYType
    Dim SQLString As String
    Dim YearLevel As New List(Of String)
    Private Sub Fees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EditButton.Enabled = False
        SaveButton.Enabled = False
        FeeGroupBox.Enabled = False
        Dim Fee As String = "Fee"
        Dim SQLYearLevel As String = "Select distinct yearlevelcode,yearlevelname FROM tblYearLevel"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLYearLevel
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearLevel.Add(myreader("yearlevelcode").ToString)
                YearComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Public z As Integer = 0
    Dim TuitionAmountArray As New List(Of TextBox)
    Dim ComputerAmountArray As New List(Of TextBox)
    'Dim SubArray As New List(Of TextBox)
    Dim NumberOfPaymentArray As New List(Of System.Windows.Forms.Label)
    'Dim CheckBoxArray As New List(Of CheckBox)
    Dim PaymentDateArray As New List(Of DateTimePicker)


    Private Sub CheckOrUnCheckAllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOrUnCheckAllCheckBox.CheckedChanged
        For c = 0 To SubFeeListView.Items.Count - 1
            If CheckOrUnCheckAllCheckBox.Checked = True Then
                SubFeeListView.Items(c).Checked = True
            Else
                SubFeeListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub SubViewFeeListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SQLYearSection As String = "SELECT tblYearLevelFees.feeid As feeid,fee_name,fee_category,fee_amount,fee_paymentdate  from tblYearLevel,tblYearLevelFee where tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode AND " & _
            " AND schoolyeartype='" & SYType & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLYearSection
            myreader = mycommand.ExecuteReader
            Do While myreader.Read

            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub SubFees()
        Label1.Text = "Sub Fee:"
        Label2.Text = "Amount:"
        SubFeeTextBox.Text = ""
        AmountShowedTextBox.Text = "0"
        SetButton.Text = "&Save"
    End Sub


    Dim FeePaymentDateList As New List(Of Date)
    Sub ViewTuition()
        FeePaymentDateList.Clear()
        TuitionAmount = 0
        ComputerAmount = 0
        SQLString = "SELECT fee_amount,fee_category,fee_paymentdate  from tblYearLevel,tblYearLevelFee where tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode " & _
               " AND yearlevelname='" & YearComboBox.Text & "'" & _
               " AND fee_category='Tuition' AND schoolyeartype='" & SYType & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                FeePaymentDateList.Add(myreader.GetDateTime("fee_paymentdate"))
                TuitionAmount = CDec(CDbl(myreader("fee_amount").ToString) + TuitionAmount)
            Loop
            myconn.Close()
            SubFeeTextBox.Text = TuitionAmount.ToString
        Catch ex As Exception
            MessageBox.Show("Err_2.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        SQLString = "SELECT fee_amount,fee_category  from tblYearLevel,tblYearLevelFee where tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode" & _
       " AND schoolyeartype='" & SYType & "'" & _
       " AND yearlevelname='" & YearComboBox.Text & "'" & _
       " AND  fee_category='Computer Fee' "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                ComputerAmount = CDec(CDbl(myreader("fee_amount").ToString) + ComputerAmount)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_3.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        AmountShowedTextBox.Text = ComputerAmount.ToString
        If FeePaymentDateList.Count > 0 Then
            FeeGroupBox.Enabled = False
            EditButton.Enabled = True
            SubFeeTextBox.Text = TuitionAmount.ToString
            AmountShowedTextBox.Text = ComputerAmount.ToString
            PaymentNumber = FeePaymentDateList.Count
            TuitionAndComputerFee()
            FeesPanel.Enabled = False
            EditButton.Focus()
        Else
            FeesPanel.Enabled = True
            EditButton.Enabled = False
            SaveButton.Enabled = False
            SubFeeTextBox.Focus()
        End If
    End Sub
    Dim ComputerAmount As Decimal
    Dim TuitionAmount As Decimal
    Private Sub FeeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeComboBox.SelectedIndexChanged
        If FeeComboBox.SelectedIndex > -1 Then
            FeeGroupBox.Enabled = True
            FeePaymentDateList.Clear()

            If FeeComboBox.Text = "Tuition & Computer Fee" Then
                Label1.Text = "Tuition Fee:"
                Label2.Text = "Computer Fee:"
                SubFeeTextBox.Text = "0"
                AmountShowedTextBox.Text = "0"
                SetButton.Text = "&Set"
            ElseIf FeeComboBox.Text = "Miscellaneous" Then
                SubFees()
            ElseIf FeeComboBox.Text = "Other Fees" Then
                SubFees()
            End If
        End If
    End Sub
    Dim TotalPayment As Decimal
    Private Sub ShowFees()
        SubFeeListView.Items.Clear()
        Dim LoadInfo As String = "SELECT distinct yearlevelname,fee_category,fee_name,fee_amount, fee_paymentdate " & "FROM tblYearLevel,tblYearLevelFee" & _
            " where tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode " & _
            " AND yearlevelname='" & YearComboBox.Text & "'" & _
            " AND schoolyeartype='" & SYType & "' AND fee_category!='Tuition' AND fee_category!='Computer Fee' "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SubFeeListView.Items.Add(myreader("fee_category").ToString)
                SubFeeListView.Items(SubFeeListView.Items.Count - 1).SubItems.Add(myreader("fee_name").ToString)
                SubFeeListView.Items(SubFeeListView.Items.Count - 1).SubItems.Add(myreader("fee_amount").ToString)
                If myreader("fee_paymentdate").ToString = "" Then
                    SubFeeListView.Items(SubFeeListView.Items.Count - 1).SubItems.Add("-------")
                Else
                    SubFeeListView.Items(SubFeeListView.Items.Count - 1).SubItems.Add(myreader.GetMySqlDateTime("fee_paymentdate").ToString)
                End If
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_1." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            myconn.Close()
        End Try
        Dim TotalYearFee As Decimal = 0
        SQLString = "SELECT SUM(fee_amount) As balance" & " FROM tblYearLevelFee,tblYearLevel" & _
    " WHERE tblyearlevel.yearlevelcode=tblYearLevelFee.yearlevelcode" & _
    " AND yearlevelname='" & YearComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                TotalYearFee = CDec(myreader("balance").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            myconn.Close()
        End Try
        TotalTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", TotalYearFee)
    End Sub
    Dim NY As Integer
    Private Sub YearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearComboBox.SelectedIndexChanged
        FeesPanel.Controls.Clear()
        FeeComboBox.Enabled = False
        SubFeeTextBox.Text = ""
        AmountShowedTextBox.Text = ""
        FeeComboBox.SelectedIndex = -1
        FeeGroupBox.Enabled = False
        ShowFees()
        ViewTuition()
        FeeComboBox.Enabled = True
        NY = YearComboBox.SelectedIndex
    End Sub

    Private Sub AddFeeToListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim PaymentDate As Date
        Dim SQLString As String
        Dim NPaymentNumber As Integer = PaymentNumber

        For i = 1 To NPaymentNumber
            If i = NPaymentNumber - 1 Then
                Exit For
            ElseIf CDate(PaymentDateArray(i).Text) >= CDate(PaymentDateArray(i + 1).Text) Then
                MessageBox.Show("Payment Date must not equal to each other or it must be in lowest to highest date.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NPaymentNumber = 0
                Exit For
            Else
                NPaymentNumber = PaymentNumber
            End If
        Next
        SQLString = "DELETE FROM tblYearLevelFee WHERE fee_category='Tuition' AND yearlevelcode='" & YearLevel.Item(NY) & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        mycommand.ExecuteNonQuery()
        myconn.Close()
        SQLString = "DELETE FROM tblYearLevelFee WHERE fee_category='Computer Fee' AND yearlevelcode='" & YearLevel.Item(NY) & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        mycommand.ExecuteNonQuery()
        myconn.Close()

        For i = 1 To NPaymentNumber
            Try
                PaymentDate = CDate(PaymentDateArray(i - 1).Text)
                SQLString = "INSERT INTO tblYearLevelFee(yearlevelcode,feeid,fee_category,fee_name,fee_amount,fee_paymentdate,schoolyeartype) " & "VALUES ('" & YearLevel.Item(NY) & "','" & ("CF" & YearLevel.Item(NY) & NumberOfPaymentArray.Item(i - 1).Text & SYType).Trim & "','Computer Fee'," & "'" & NumberOfPaymentArray.Item(i - 1).Text & "','" & CDec(ComputerAmountArray.Item(i - 1).Text) & "','" & PaymentDate.ToString("yyyy/MM/dd") & "','" & SYType & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()

                SQLString = "INSERT INTO tblYearLevelFee(yearlevelcode,feeid,fee_category,fee_name,fee_amount,fee_paymentdate,schoolyeartype) " & "VALUES ('" & YearLevel.Item(NY) & "','" & ("TF" & YearLevel.Item(NY) & NumberOfPaymentArray.Item(i - 1).Text & SYType).Trim & "','Tuition'," & "'" & NumberOfPaymentArray.Item(i - 1).Text & "','" & CDec(TuitionAmountArray.Item(i - 1).Text) & "','" & PaymentDate.ToString("yyyy/MM/dd") & "','" & SYType & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch
                myconn.Close()
            End Try

        Next
        FeeComboBox.Enabled = True
        If NPaymentNumber > 0 Then
            MessageBox.Show("Successfully added fee information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowFees()
        End If
    End Sub

    Private Sub SubjectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectButton.Click
        Me.Close()
        Subjects.Show()
    End Sub

    Private Sub SubjectPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectPictureBox.Click
        Me.Close()
        Subjects.Show()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TeacherButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherButton.Click
        Me.Close()
        Teachers.Show()
    End Sub

    Private Sub TeacherPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherPictureBox.Click
        Me.Close()
        Teachers.Show()
    End Sub
    Dim PaymentNumber As Integer = 0
    Dim TotalComputerFee As Decimal
    Public Sub TuitionAndComputerFee()
        TuitionAmountArray.Clear()
        ComputerAmountArray.Clear()
        NumberOfPaymentArray.Clear()
        PaymentDateArray.Clear()
        TotalPayment = CDec(CDbl(SubFeeTextBox.Text) / PaymentNumber)
        TotalComputerFee = CDec(CDbl(AmountShowedTextBox.Text) / PaymentNumber)
        Dim numberfee As Integer = 0
        Dim NumberOfPaymentHeader As New System.Windows.Forms.Label()
        Dim TuitionAmountHeader As New System.Windows.Forms.Label()
        Dim ComputerAmountHeader As New System.Windows.Forms.Label()
        Dim PaymentDateHeader As New System.Windows.Forms.Label()


        NumberOfPaymentHeader.Text = "Payments"
        NumberOfPaymentHeader.Width = 55
        NumberOfPaymentHeader.Left = 5
        NumberOfPaymentHeader.Top = 1

        TuitionAmountHeader.Text = "Tuition"
        TuitionAmountHeader.Width = 55
        TuitionAmountHeader.Left = 75
        TuitionAmountHeader.Top = 1

        ComputerAmountHeader.Text = "Computer"
        ComputerAmountHeader.Width = 55
        ComputerAmountHeader.Left = 145
        ComputerAmountHeader.Top = 1

        PaymentDateHeader.Text = "Payment Date"
        PaymentDateHeader.Width = 90
        PaymentDateHeader.Left = 215
        PaymentDateHeader.Top = 1

        FeesPanel.Controls.Add(NumberOfPaymentHeader)
        FeesPanel.Controls.Add(TuitionAmountHeader)
        FeesPanel.Controls.Add(ComputerAmountHeader)
        FeesPanel.Controls.Add(PaymentDateHeader)

        For i = 1 To PaymentNumber
            Dim suff As String = "th"
            If i = 1 Then
                suff = "st"
            ElseIf i = 2 Then
                suff = "nd"
            ElseIf i = 3 Then
                suff = "rd"
            End If
            numberfee = numberfee + 1
            Dim NumberOfPaymentsLabel As New System.Windows.Forms.Label()
            Dim TuitionAmountTextBox As New System.Windows.Forms.TextBox()
            Dim ComputerAmountTextBox As New System.Windows.Forms.TextBox()
            Dim PaymentDateDateTimePicker As New System.Windows.Forms.DateTimePicker()

            NumberOfPaymentsLabel.Name = "NumberOfPaymentsLabel" & i.ToString
            NumberOfPaymentsLabel.Text = i.ToString & suff & " Payment"
            NumberOfPaymentsLabel.Width = 90
            NumberOfPaymentsLabel.Left = 5
            NumberOfPaymentsLabel.Top = i * 25

            TuitionAmountTextBox.Name = "Amount" & i.ToString
            TuitionAmountTextBox.Enabled = False
            TuitionAmountTextBox.TextAlign = HorizontalAlignment.Right
            TuitionAmountTextBox.Text = TotalPayment.ToString
            TuitionAmountTextBox.Width = 65
            TuitionAmountTextBox.Left = 75
            TuitionAmountTextBox.Top = i * 25

            ComputerAmountTextBox.Name = "Amount" & i.ToString
            ComputerAmountTextBox.Enabled = False
            ComputerAmountTextBox.TextAlign = HorizontalAlignment.Right
            ComputerAmountTextBox.Text = TotalComputerFee.ToString
            ComputerAmountTextBox.Width = 65
            ComputerAmountTextBox.Left = 145
            ComputerAmountTextBox.Top = i * 25

            PaymentDateDateTimePicker.Name = "PaymentDate" & i.ToString
            PaymentDateDateTimePicker.Format = DateTimePickerFormat.Short
            If FeePaymentDateList.Count > 0 Then
                PaymentDateDateTimePicker.Text = FeePaymentDateList.Item(i - 1).ToString
            Else
                Dim Dte As Date = FirstMonday(6, Date.Today.Year)
                PaymentDateDateTimePicker.Text = CStr(Dte.AddMonths((i * 2) - 2))
            End If
            PaymentDateDateTimePicker.Width = 100
            PaymentDateDateTimePicker.Left = 215
            PaymentDateDateTimePicker.Top = i * 25

            FeesPanel.Controls.Add(TuitionAmountTextBox)
            FeesPanel.Controls.Add(ComputerAmountTextBox)
            FeesPanel.Controls.Add(NumberOfPaymentsLabel)
            FeesPanel.Controls.Add(PaymentDateDateTimePicker)

            NumberOfPaymentArray.Add(NumberOfPaymentsLabel)
            PaymentDateArray.Add(PaymentDateDateTimePicker)
            TuitionAmountArray.Add(TuitionAmountTextBox)
            ComputerAmountArray.Add(ComputerAmountTextBox)

        Next
    End Sub


    Private Function FirstMonday(ByVal Mnth As Integer, ByVal year As Integer) As Date
        Dim Dte As Date = New Date(year, Mnth, 1)
        Do While Dte.DayOfWeek <> DayOfWeek.Monday
            Dte = Dte.AddDays(1)
        Loop
        Return Dte
    End Function



    Private Sub SetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetButton.Click
        If SubFeeTextBox.Text = "" Or AmountShowedTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Required Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            SaveButton.Enabled = True
            FeesPanel.Controls.Clear()
            If FeeComboBox.Text = "Tuition & Computer Fee" Then
                If CInt(SubFeeTextBox.Text) >= 0 Then
                    If CInt(AmountShowedTextBox.Text) <= 0 Then
                        MessageBox.Show("Value must not be less than or equal to 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Else
                        Try
                            PaymentNumber = CInt(InputBox("Enter the number of payment(s):", "Number of Payments", "5"))
                        Catch
                            PaymentNumber = 0
                        End Try
                        If PaymentNumber > 0 Then
                            TuitionAndComputerFee()
                        Else
                            MessageBox.Show("Number of payments must not be less than or equal to 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    End If
                Else
                    MessageBox.Show("Value must not be less than or equal to 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            ElseIf FeeComboBox.Text = "Miscellaneous" Or FeeComboBox.Text = "Other Fees" Then
                Dim err As Integer = 0
                Try
                    Dim Amount As Integer = CInt(AmountShowedTextBox.Text)
                Catch
                    err = 1
                    MessageBox.Show("Fee amount must be a number.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                If err = 0 Then
                    SQLString = "INSERT INTO tblYearLevelFee(yearlevelcode,feeid,fee_category,fee_name,fee_amount,fee_paymentdate,schoolyeartype) " & "VALUES ('" & YearLevel.Item(YearComboBox.SelectedIndex) & "','" & (YearLevel.Item(YearComboBox.SelectedIndex) & SubFeeTextBox.Text & SYType).Trim & "','" & FeeComboBox.Text & "'," & "'" & SubFeeTextBox.Text & "','" & CDec(AmountShowedTextBox.Text) & "',NULL,'" & SYType & "')"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()

                    SubFeeTextBox.Text = ""
                    AmountShowedTextBox.Text = "0"
                    MessageBox.Show("Successfully added fee information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowFees()
                Else
                    myconn.Close()
                    LoadInfo = "UPDATE tblYearLevelFee SET fee_amount=" & CDec(AmountShowedTextBox.Text) & " Where yearlevelcode = '" & YearLevel(YearComboBox.SelectedIndex) & "'" & _
                " AND fee_name='" & SubFeeTextBox.Text & "' AND fee_category='" & FeeComboBox.Text & "'" & _
                " schoolyeartype='" & SYType & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = LoadInfo
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    MessageBox.Show("Successfully  updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        SubFeeTextBox.Focus()
        FeeGroupBox.Enabled = True
        FeesPanel.Enabled = True
    End Sub

    Private Sub SubFeeListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubFeeListView.SelectedIndexChanged
        For g = 0 To SubFeeListView.Items.Count - 1
            If SubFeeListView.Items.Item(g).Selected = True Then
                FeeComboBox.Enabled = False
                SubFeeTextBox.Text = SubFeeListView.Items(g).SubItems(0).Text
                AmountShowedTextBox.Text = SubFeeListView.Items(g).SubItems(2).Text
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To SubFeeListView.Items.Count - 1
            If SubFeeListView.Items.Item(g).Checked = True Then
                LoadInfo = "Delete from tblYearLevelFee where yearlevelcode = '" & YearLevel(YearComboBox.SelectedIndex) & "'" & _
                " AND fee_name='" & SubFeeListView.Items(g).SubItems(1).Text & "' AND fee_category='" & SubFeeListView.Items(g).SubItems(0).Text & "'" & _
                " AND schoolyeartype='" & SYType & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = LoadInfo
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ShowFees()
    End Sub
End Class
Option Strict On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Drawing.Printing

Public Class Main
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Dim MaxStudentSYID As String
    Dim GroupBoxShow As Integer = 0
    Dim ERFrom As Date
    Dim ERTo As Date
    Public UserName As String
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Refresh()
    End Sub
    Public Sub ButtonsVisibility()
        StudentRegistrationGroupBox.Visible = False
        PaymentBalanceGroupBox.Visible = False
        AssessmentGroupBox.Visible = False
        TimeLabel.BringToFront()
    End Sub
    Public SYFrom As Date
    Public SYTo As Date
    Public SYID As String
    Public SYType As String

    Private Sub AdminHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UserName = Welcome.NameOfUser
        Catch
        End Try
        Call ButtonsVisibility()
        Dim MaintainanceYear As Boolean = True
        Dim MaintainanceTeacher As Boolean = True
        Dim MaintainanceFee As Boolean = True
        Dim MaintainanceWebsite As Boolean = True
        Dim TransactionRegistration As Boolean = True
        Dim TransactionAssessment As Boolean = True
        Dim TransactionPayment As Boolean = True
        Dim TransactionReports As Boolean = True
        Dim ManageClass As Boolean = True
        Dim ManageGrades As Boolean = True
        Dim ManageReserved As Boolean = True
        Dim ManageAccount As Boolean = True
        Dim BackUpRestore As Boolean = True
        Dim SYView As Boolean = True
        Dim SYEdit As Boolean = True
        
            Dim LoadSY As String = "Select schoolyearid,(date(schoolyearstart)) AS systart,(date(schoolyearend)) As syend,schoolyeartype from tblSchoolYear " & _
            " where schoolyearid='" & SchoolYear.CurrentSYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = LoadSY
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    SYID = myreader("schoolyearid").ToString
                    SYFrom = CDate((myreader("systart")))
                    SYTo = CDate((myreader("syend")))
                    SYType = myreader("schoolyeartype").ToString
                Loop
                myconn.Close()
            Catch
                myconn.Close()
                SQLString = "Select MAX(schoolyearid),(date(schoolyearstart)) AS systart,(date(schoolyearend)) As syend,schoolyeartype from tblSchoolYear "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    SYID = myreader("schoolyearid").ToString
                    SYFrom = CDate((myreader("systart")))
                    SYTo = CDate((myreader("syend")))
                    SYType = myreader("schoolyeartype").ToString
                Loop
                myconn.Close()
            End Try

            SQLString = "Select enrollmentstart,enrollmentend from tblenrollmentperiod,tblschoolyear WHERE tblenrollmentperiod.schoolyearid=tblschoolyear.schoolyearid AND tblschoolyear.schoolyearid='" & SYID & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                ERFrom = CDate(myreader.GetDateTime("enrollmentstart").ToString("yyyy/MM/dd"))
                ERTo = CDate(myreader.GetDateTime("enrollmentend").ToString("yyyy/MM/dd"))
            Loop
            myconn.Close()


            SYFromLabel.Text = SYFrom.ToShortDateString
            SYToLabel.Text = SYTo.ToShortDateString
            Timer1.Interval = 1000
            Timer1.Start()
            Timer2.Interval = 5000
            Timer2.Start()
    End Sub


    ''' RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG
    ''' IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
    ''' SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    ''' TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
    Dim studid As Integer

    Public Sub StudentRegistrationClearAll()
        studid = 0
        NewOrOld = 0
        SearchStudNameTextBox.Clear()
        StudentTypeComboBox.Enabled = True
        YearLevelRegistrationComboBox.Enabled = False
        StudentTypeComboBox.Text = ""
        YearLevelRegistrationComboBox.Text = ""
        'Dim NDateTime As String = CStr(DatePart(Date.Today.Year)) '& "/" & DatePart(Date.Today.Day) & "/" & DatePart(Date.Today.Day)
        'BirthDateTimePicker.Value = CDate(CStr(DatePart(Date.Today.Year)DatePart(Date.Today.Day))
        ReligionComboBox.Enabled = False
        ReligionComboBox.Text = "Adventist"
        StudNoRegistrationTextBox.Text = ""
        StudLastNameRegistrationTextBox.Enabled = False
        StudFirstNameRegistrationTextBox.Enabled = False
        StudMiddleNameRegistrationTextBox.Enabled = False
        BirthDateTimePicker.Enabled = False
        GenderRegistrationComboBox.Enabled = False
        AddressRegistrationTextBox.Enabled = False
        ContactNoRegistrationTextBox.Enabled = False
        FatherNameTextBox.Enabled = False
        FatherOccupationTextBox.Enabled = False
        FatherContactNoRegistrationTextBox.Enabled = False
        ParentsRadioButton.Enabled = False
        OthersRadioButton.Enabled = False
        MotherNameTextBox.Enabled = False
        MotherOccupationTextBox.Enabled = False
        MotherContactNoRegistrationTextBox.Enabled = False
        RequirementsDataGridView.Rows.Clear()
        DiscountRegistrationListView.Enabled = False
        DiscountRegistrationListView.Items.Clear()
        StudLastNameRegistrationTextBox.Clear()
        StudFirstNameRegistrationTextBox.Clear()
        StudMiddleNameRegistrationTextBox.Clear()
        BirthDateTimePicker.Text = CStr(Date.Now)
        AddressRegistrationTextBox.Clear()
        ContactNoRegistrationTextBox.Clear()
        FatherNameTextBox.Clear()
        FatherContactNoRegistrationTextBox.Clear()
        FatherOccupationTextBox.Clear()
        MotherNameTextBox.Clear()
        MotherContactNoRegistrationTextBox.Clear()
        MotherOccupationTextBox.Clear()
        GuardianRegistrationTextBox.Clear()
        GuardianRelationshipTextBox.Clear()
        GuardianContactTextBox.Clear()
        ParentsRadioButton.Checked = True
    End Sub

    Private Sub BirthDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDateTimePicker.ValueChanged
        Dim Age As Integer
        If DatePart(DateInterval.Year, Date.Today) >= DatePart(DateInterval.Year, CDate(BirthDateTimePicker.Text)) Then
            Age = DatePart(DateInterval.Year, Date.Today) - DatePart(DateInterval.Year, CDate(BirthDateTimePicker.Text))
            If DatePart(DateInterval.Month, Date.Today) < DatePart(DateInterval.Month, CDate(BirthDateTimePicker.Text)) Then
                Age = Age - 1
            ElseIf DatePart(DateInterval.Month, Date.Today) = DatePart(DateInterval.Month, CDate(BirthDateTimePicker.Text)) Then
                If DatePart(DateInterval.Day, Date.Today) > DatePart(DateInterval.Day, CDate(BirthDateTimePicker.Text)) Then
                    Age = Age - 1
                    If Age < 0 Then
                        Age = 0
                    End If
                ElseIf DatePart(DateInterval.Day, Date.Today) = DatePart(DateInterval.Day, CDate(BirthDateTimePicker.Text)) Then
                    Age = Age
                End If
            End If
        Else
            'MessageBox.Show("Invalid input.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        BirthDateTimePicker.Focus()
        AgeTextBox.Text = Age.ToString
    End Sub
    Private Sub ParentsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentsRadioButton.CheckedChanged
        GuardianNameLabel.Visible = False
        GuardianContactLabel.Visible = False
        GuardianRelationshipLabel.Visible = False
        GuardianRegistrationTextBox.Visible = False
        GuardianContactTextBox.Visible = False
        GuardianRelationshipTextBox.Visible = False
        GuardianRegistrationTextBox.Visible = False
        GuardianContactTextBox.Clear()
        GuardianRelationshipTextBox.Text = "Parents"
        GuardianRegistrationTextBox.Clear()
    End Sub
    Public Sub Guardian()
        GuardianRegistrationTextBox.Visible = True
        GuardianContactTextBox.Visible = True
        GuardianRegistrationTextBox.Visible = True
        GuardianRelationshipTextBox.Visible = True
        GuardianNameLabel.Visible = True
        GuardianContactLabel.Visible = True
        GuardianRelationshipLabel.Visible = True
        GuardianContactTextBox.Clear()
        GuardianRelationshipTextBox.Text = "Relative"
        GuardianRegistrationTextBox.Clear()
    End Sub
    Private Sub OthersRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersRadioButton.CheckedChanged
        Guardian()
    End Sub
    Private Sub SubmitRegistrationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitRegistrationButton.Click
        Dim err As Double = 0
        If OthersRadioButton.Checked = True Then
            If GuardianRegistrationTextBox.Text = "" Or GuardianContactTextBox.Text = "" Or GuardianRelationshipTextBox.Text = "" Then
                err = 1
            End If
        End If
        Try
            If ContactNoRegistrationTextBox.Text IsNot String.Empty Then
                ' err = CDbl(ContactNoRegistrationTextBox.Text)
            End If
            err = CDbl(FatherContactNoRegistrationTextBox.Text)
            err = CDbl(MotherContactNoRegistrationTextBox.Text)
            If OthersRadioButton.Checked = True Then
                err = CDbl(GuardianContactTextBox.Text)
            End If
            err = 0
        Catch
            err = 2
        End Try

        If err = 0 Then
            If StudentTypeComboBox.Text = "" Or YearLevelRegistrationComboBox.Text = "" Or StudLastNameRegistrationTextBox.Text = "" Or StudFirstNameRegistrationTextBox.Text = "" Or StudFirstNameRegistrationTextBox.Text = "" Or StudMiddleNameRegistrationTextBox.Text = "" _
            Or ReligionComboBox.Text = "" Or AddressRegistrationTextBox.Text = "" Or FatherNameTextBox.Text = "" Or FatherContactNoRegistrationTextBox.Text = "" Or FatherOccupationTextBox.Text = "" _
            Or MotherContactNoRegistrationTextBox.Text = "" Or MotherNameTextBox.Text = "" Or MotherOccupationTextBox.Text = "" Then

                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf MaxStudentSYID = SYID Then
                MessageBox.Show("The student you are trying to register is already enrolled in the current school year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf CInt(AgeTextBox.Text) < 5 Then
                MessageBox.Show("Check the birth date of the student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf MaxStudentSYID = "" Then
                Register()
            Else
                Dim outstandingbalance As Decimal = 0
                Try
                    SQLString = "SELECT SUM(Balance) As balance" & " FROM tblStudentTransactions,tblStudentYear" & _
      " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
      " AND studentid='" & StudNoRegistrationTextBox.Text & "'" & _
      " AND schoolyearid='" & MaxStudentSYID & "'"

                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        outstandingbalance = CDec(myreader("balance"))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                If outstandingbalance = 0 Then
                    Register()
                Else
                    MessageBox.Show("There is a problem with the accountabilities of the student you are trying to register. First check his/ her account.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        ElseIf err = 2 Then
            MessageBox.Show("Invalid Input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("All fields are required.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub Register()
        Dim RegDate As Date = CDate(DateLabel.Text.ToString)
        Dim SQLString As String
        Dim YearAndSection As String = ""
        Dim FeeAmount As New List(Of Decimal)
        Try
            Dim SQLYear As String = " SELECT yearlevelcode from tblYearLevel where yearlevelname='" & YearLevelRegistrationComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLYear
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearAndSection = CStr(myreader("yearlevelcode"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim BDate As Date = CDate(BirthDateTimePicker.Text)
        Try
            SQLString = "INSERT INTO tblStudents(studentid,st_lname,st_fname,st_mname,st_type,st_bdate,st_gender,st_religion,st_address,st_contactno,fa_name ,fa_contactno,fa_occupation,mo_name,mo_contactno,mo_occupation,st_registration,gua_name,gua_relationship,gua_contactno)" & _
            " VALUES('" & StudNoRegistrationTextBox.Text & "','" & StudLastNameRegistrationTextBox.Text & "','" & StudFirstNameRegistrationTextBox.Text & _
            "','" & StudMiddleNameRegistrationTextBox.Text & "','" & StudentTypeComboBox.Text & "','" & BDate.ToString("yyyy/MM/dd") & _
             "','" & GenderRegistrationComboBox.Text & "','" & ReligionComboBox.Text & "','" & AddressRegistrationTextBox.Text & "','" & ContactNoRegistrationTextBox.Text & _
             "','" & FatherNameTextBox.Text & "','" & FatherContactNoRegistrationTextBox.Text & "','" & FatherOccupationTextBox.Text & "','" & MotherNameTextBox.Text & _
            "','" & MotherContactNoRegistrationTextBox.Text & "','" & MotherOccupationTextBox.Text & "','" & RegDate.ToString("yyyy/MM/dd") & "'" & _
            ",'" & GuardianRegistrationTextBox.Text & "','" & GuardianRelationshipTextBox.Text & "','" & GuardianContactTextBox.Text & "')"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            myconn.Close()
            SQLString = "Update tblStudents SET st_religion='" & ReligionComboBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET st_address='" & AddressRegistrationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET st_contactno='" & ContactNoRegistrationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET st_religion='" & ReligionComboBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET fa_contactno='" & FatherContactNoRegistrationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET fa_occupation='" & FatherOccupationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET mo_contactno='" & MotherContactNoRegistrationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET mo_occupation='" & MotherOccupationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET gua_name='" & GuardianRegistrationTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET gua_contactno='" & GuardianContactTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            SQLString = "Update tblStudents SET gua_relationship='" & GuardianRelationshipTextBox.Text & "' where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        End Try

        Try
            Dim SQlInsert As String = "INSERT INTO tblStudentYear(studentschoolyear,studentid,studentstatus,schoolyearid) VALUES('" & SYID & StudNoRegistrationTextBox.Text & "','" & StudNoRegistrationTextBox.Text & "','Registered','" & SYID & "')"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQlInsert
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            SQLString = "INSERT INTO tblStudentAccounts(studentid,username,userpass)" & "VALUES ('" & StudNoRegistrationTextBox.Text & "','" & StudNoRegistrationTextBox.Text & "','" & StudLastNameRegistrationTextBox.Text & StudFirstNameRegistrationTextBox.Text & "')"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch
            myconn.Close()
        End Try
        Try
            Dim SQlInsert As String = "DELETE FROM tblStudentDiscounts WHERE studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQlInsert
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        For i = 0 To DiscountRegistrationListView.Items.Count - 1
            If DiscountRegistrationListView.Items(i).Checked = True Then
                Try
                    SQLString = "INSERT INTO tblStudentDiscounts(studentid,studentdiscount,studentdiscountrate) VALUES('" & StudNoRegistrationTextBox.Text & "','" & DiscountRegistrationListView.Items(i).SubItems(0).Text & "','" & DiscountRegistrationListView.Items(i).SubItems(1).Text & "')"

                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
            End If
        Next


        Try
            Dim SQlInsert As String = "DELETE FROM tblStudentRequirements WHERE studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQlInsert
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        For i = 0 To RequirementsDataGridView.Rows.Count - 1
            Try
                SQLString = "INSERT INTO tblStudentRequirements(studentid,studentrequirements,studentschoolyear,requirementcleared) VALUES('" & StudNoRegistrationTextBox.Text & "','" & RequirementsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "','" & SYID & StudNoRegistrationTextBox.Text & "','" & RequirementsDataGridView.Rows.Item(i).Cells(1).Value.ToString & "')"

                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
            End Try
        Next

        Try
            Dim SQlInsert As String = "INSERT INTO tblStudentYearLevel VALUES('" & SYID & StudNoRegistrationTextBox.Text & "','" & YearAndSection & "')"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQlInsert
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAAAA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Dim StudentFee As New List(Of String)
        Dim FeeCategory As New List(Of String)
        Dim FeeBalanceDate As New List(Of DateTime)
        Dim FeeName As New List(Of String)
        Try
            Dim SQLSelectFee As String = " SELECT distinct feeid,fee_name,fee_amount,fee_category,fee_paymentdate" & _
            " From tblStudents,tblStudentYear,tblStudentYearLevel,tblYearLevelFee" & _
            " where tblStudentYear.studentschoolyear = tblStudentYearLevel.studentschoolyear " & _
            " AND tblStudents.studentid=tblStudentYear.studentid" & _
            " AND tblStudentYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode" & _
            " AND st_lname='" & StudLastNameRegistrationTextBox.Text & "' AND st_fname='" & StudFirstNameRegistrationTextBox.Text & "' AND st_mname='" & StudMiddleNameRegistrationTextBox.Text & "'" & _
            " AND tblYearLevelFee.schoolyeartype='" & SYType & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSelectFee
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudentFee.Add(CStr(myreader("feeid")))
                FeeName.Add(CStr(myreader("fee_name")))
                FeeAmount.Add(CDec(myreader("fee_amount")))
                FeeCategory.Add(CStr(myreader("fee_category")))
                If myreader("fee_paymentdate").ToString = "" Then
                    FeeBalanceDate.Add(CDate(("0001/1/01")))
                Else
                    FeeBalanceDate.Add(CDate(myreader("fee_paymentdate")))
                End If
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim TotalDiscount As Decimal
        Try
            SQLString = " SELECT SUM(studentdiscountrate) As rate from tblStudentDiscounts where studentid='" & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                TotalDiscount = CDec(CStr(myreader("rate")))
            Loop
            myconn.Close()
        Catch
            TotalDiscount = 0
            myconn.Close()
        End Try
        If TotalDiscount > 100 Then
            TotalDiscount = 100
        End If
        TotalDiscount = TotalDiscount / 100
        For f As Integer = 0 To StudentFee.Count - 1
            If FeeCategory.Item(f) = "Tuition" Then
                Dim AmountXDiscount As Decimal = FeeAmount.Item(f) * TotalDiscount
                FeeAmount.Item(f) = FeeAmount.Item(f) - AmountXDiscount
            End If
            Try
                Dim SQLInsertStudentTransactions As String = "INSERT INTO tblStudentTransactions(studentfee,studentschoolyear,balancename,balancecategory,paymentmode,balance,balancedate)" & "VALUES ('" & StudNoRegistrationTextBox.Text & StudentFee.Item(f) & SYID & "','" & SYID & StudNoRegistrationTextBox.Text & "','" & FeeName.Item(f) & "','" & FeeCategory.Item(f) & "',NULL,'" & FeeAmount.Item(f) & "','" & FeeBalanceDate.Item(f).ToString("yyyy/MM/dd") & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLInsertStudentTransactions
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLInsertStudentTransactions = "INSERT INTO tblTransactions(studentfee,transacno,paymenttype,dateofpayment,amountpaid)" & "VALUES ('" & StudNoRegistrationTextBox.Text & StudentFee.Item(f) & SYID & "',NULL,NULL,NULL,0)"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLInsertStudentTransactions
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Next
        InsertBackSubject.Clear()
        For i = 0 To SubjectsDataGridView.Rows.Count - 1
            If SubjectsDataGridView.Rows.Item(i).Cells(1).Value.ToString = "Failed" Then
                InsertBackSubject.Add(Subject.Item(i))
            End If
        Next
        Dim GradingPeriodID As New List(Of String)
        Try
            Dim SQLSubjects As String = "Select distinct gradingperiodid  From tblGradings,tblSchoolYear" & _
            " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
            " AND tblSchoolYear.schoolyearid='" & SYID & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSubjects
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                GradingPeriodID.Add(myreader("gradingperiodid").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'pupu
        For i = 0 To GradingPeriodID.Count - 1
            For j = 0 To InsertBackSubject.Count - 1

                Try
                    SQLString = "INSERT INTO tblStudentSubjects VALUES ('" & (SYID & StudNoRegistrationTextBox.Text & InsertBackSubject.Item(j) & GradingPeriodID.Item(i)).Trim & "','" & SYID & StudNoRegistrationTextBox.Text & "','NULL','" & InsertBackSubject.Item(j) & "','Failed','" & GradingPeriodID.Item(i) & "',0)"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
            Next
        Next
        MessageBox.Show("Successfully added new student.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If AssessmentPictureBox.Enabled = True Then
            Dim result As Integer = MessageBox.Show("Would you like to assess the student?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                StudentSearch = StudNoRegistrationTextBox.Text
                TransactionComboBox.Text = "Payments"
                AssessStartup()
                ViewAssess()
                AssessmentGroupBox.BringToFront()
                AssessmentGroupBox.Visible = True
                IndicatorLabel.BringToFront()
                IndicatorLabel.Text = "Assessment"
            End If

        End If
        StudentRegistrationClearAll()


    End Sub
    Public Sub PaymentBalanceClearAll()
        MiscellaneousDataGridView.Rows.Clear()
        TotalTextBox.Text = ""
        MiscellaneousTotalTextBox.Clear()
        OthersDataGridView.Rows.Clear()
        TuitionDataGridView.Rows.Clear()
        PaymentsListView.Items.Clear()
        AmountTenderedPaymentTextBox.Enabled = False
        YearLevelPaymentTextBox.Clear()
        SectionPaymentTextBox.Clear()
        TotalAmountDuePaymentTextBox.Clear()
        BalancePaymentTextBox.Clear()
        TotalTextBox.Clear()
        TransactionNoPaymentTextBox.Clear()
        AmountTenderedPaymentTextBox.Clear()
        ChangePaymentTextBox.Clear()
        CheckTextBox.Text = ""
        CashPaymentRadioButton.Checked = True
        StudentNoPaymentTextBox.Text = ""
        StudentNameTextBox.Text = ""
        StatusPaymentTextBox.Text = ""
        SectionPaymentTextBox.Text = ""
        AmountTenderedPaymentTextBox.Text = ""

    End Sub
    Private Sub PaymentBalanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    ''' MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
    ''' AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    ''' IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
    ''' NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    ''' TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    ''' AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    ''' NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    ''' CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE

    Sub InsertSubjects()
        Dim StudentSubjectsList As New List(Of String)
        Try
            Dim SQLSubjects As String = "Select distinct tblSubjects.subjectcode As subjects from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                 " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND  " & _
                 " tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND " & _
                 " tblYearLevelSchedule.roomno=tblRooms.roomno AND " & _
                 " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
            " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
               " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" '& _
            '" AND tblSubjects.schoolyearid='" & SYID & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSubjects
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudentSubjectsList.Add(myreader("subjects").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            myconn.Close()
        End Try
        Dim GradingPeriodID As New List(Of String)
        Try
            Dim SQLSubjects As String = "Select distinct gradingperiodid  From tblGradings,tblSchoolYear" & _
            " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
            " AND tblSchoolYear.schoolyearid='" & SYID & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSubjects
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                GradingPeriodID.Add(myreader("gradingperiodid").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        For i = 0 To GradingPeriodID.Count - 1
            For j = 0 To StudentSubjectsList.Count - 1
                Try
                    SQLString = "INSERT INTO tblStudentSubjects VALUES ('" & (SYID & StudentSearch & StudentSubjectsList.Item(j) & GradingPeriodID.Item(i)).Trim & "','" & SYID & StudentSearch & "','" & StudentSection & "','" & StudentSubjectsList.Item(j) & "','Taking','" & GradingPeriodID.Item(i) & "',0)"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
            Next
        Next
    End Sub








    Dim StudentSection As String
    Dim BalancePaymentDecimal As Decimal
    Dim NewBalancePaymentDecimal As Decimal
    Private Sub ProceedPaymentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedPaymentButton.Click
        Dim err As Integer = 0
        If CheckPaymentRadioButton.Checked = True Then
            If CheckTextBox.Text = "" Then
                MessageBox.Show("Oops!, you FORGOT to FILL in the CHECK NO. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                err = 1
            End If
        End If
        If err = 0 Then
            If TotalAmountDuePaymentTextBox.Text = "" Then
                MessageBox.Show("Oops!, NO PAYMENTS SELECTED  ", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf AmountTenderedPaymentTextBox.Text = "" Or AmountTenderedPaymentTextBox.Text = "0" Then
                MessageBox.Show("Oops!, the AMOUNT you INPUT is 0 or NULL. ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If StatusPaymentTextBox.Text = "Assessed" Then
                    Dim DownPaymentFee As Decimal = 0
                    SQLString = "SELECT SUM(fee_amount) As fee " & "FROM tblYearLevelFee,tblYearLevel" & _
                   " where fee_category='Miscellaneous'" & _
                   " AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
                   " AND yearlevelname='" & YearLevelPaymentTextBox.Text & "'" & _
                    " AND schoolyeartype='" & SYType & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            DownPaymentFee = CDec(myreader("fee"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        myconn.Close()
                        'MessageBox.Show("Dec." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLString = "SELECT SUM(fee_amount) As fee " & "FROM tblStudentTransactions,tblYearLevelFee,tblYearLevel,tblStudentYear,tblStudentYearLevel" & _
           " where fee_category='Other Fees'" & _
           " AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
           " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
           " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
           " AND tblStudentTransactions.studentschoolyear=tblStudentYear.studentschoolyear" & _
           " AND fee_name=balancename" & _
           " AND schoolyearid='" & SYID & "'" & _
           " AND yearlevelname='" & YearLevelPaymentTextBox.Text & "'" & _
            " AND schoolyeartype='" & SYType & "'" & _
            " AND studentid='" & StudentNoPaymentTextBox.Text & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            DownPaymentFee = DownPaymentFee + CDec(myreader("fee"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        myconn.Close()
                        'MessageBox.Show("Dec" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    Dim totalamount As Decimal = 0
                    Try
                        SQLString = "Select SUM(amountpaid) As totalamount FROM tblStudentTransactions,tblStudentYear,tblTransactions" & _
             " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear " & _
             " AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
             " AND  tblStudentYear.studentschoolyear='" & SYID & StudentNoPaymentTextBox.Text & "'" & _
                " AND balancecategory!='Tuition'  AND dateofpayment!='NULL'" & _
            " ORDER By dateofpayment"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            totalamount = CDec(myreader("totalamount").ToString)
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        totalamount = 0
                        myconn.Close()
                    End Try
                    Try
                        DownPaymentFee = DownPaymentFee / 2
                    Catch
                        DownPaymentFee = 0
                    End Try
                    'MessageBox.Show(DownPaymentFee.ToString)

                    totalamount = totalamount + AmountTenderedPaymentDecimal
                    If DownPaymentFee > totalamount Then
                        err = 1
                    End If
                End If
                Dim StudentToChange As String = ""
                Dim StudentTOChangeSection As String = ""
                Dim OldSectionID As String = ""
                Dim OldAssessedID As Integer = 0
                Dim NewAssessedID As Integer = 0
                If StatusPaymentTextBox.Text = "Assessed" Then
                    SQLString = "SELECT assessedid,studentid,tblStudentSections.yearlevelsectioncode As studentsection,sectioncode " & "FROM tblStudentSections,tblStudentYear,tblYearLevelSections" & _
           " where tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND assessedid>0 AND schoolyearid='" & SYID & "' AND studentid!='" & StudentNoPaymentTextBox.Text & "' LIMIT 1 "
                    Try

                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            StudentToChange = CStr(myreader("studentid"))
                            StudentTOChangeSection = CStr(myreader("sectioncode"))
                            OldSectionID = CStr(myreader("studentsection"))
                            OldAssessedID = CInt(myreader("assessedid"))
                        Loop
                        myconn.Close()

                    Catch ex As Exception
                        MessageBox.Show("No records foundaa." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLString = "Select assessedid  From tblStudentYear" & _
           " WHERE studentschoolyear='" & SYID & StudentNoPaymentTextBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        NewAssessedID = CInt(myreader("assessedid"))
                    Loop
                    myconn.Close()
                    If OldAssessedID > 0 Then
                        Dim result As Integer = MessageBox.Show("Transfer student to Section " & StudentTOChangeSection & " and get slot of student: " & StudentToChange & " .", "Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                        If result = DialogResult.Yes Then
                            StudentSection = ""
                            Dim Sections As New List(Of String)
                            Try
                                SQLString = "Select tblYearLevelSections.yearlevelsectioncode AS section from tblYearLevelSections,tblYearLevel" & _
                                " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
                                 " AND yearlevelname='" & YearLevelAssessTextBox.Text & "' " & _
                                " ORDER BY sectionorder"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                myreader = mycommand.ExecuteReader
                                Do While myreader.Read
                                    Sections.Add(myreader("section").ToString)
                                Loop
                                myconn.Close()
                            Catch ex As Exception
                                MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Try
                            Dim Capacity As New List(Of Integer)
                            For i = 0 To Sections.Count - 1
                                Try
                                    SQLString = "Select sectioncode,yearlevelsectioncode,sectionmaximum-(Select Count(studentsection)  from tblYearLevelSections,tblYearLevel,tblStudentSections,tblStudentYear" & _
                                    " where tblStudentSections.yearlevelsectioncode = tblYearLevelSections.yearlevelsectioncode" & _
                                     " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear  " & _
                                      " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
                                      " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'  AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "' AND tblStudentYear.schoolyearid='" & SYID & "') As Capacity from tblYearLevelSections,tblYearLevel" & _
                                    " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                                      " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
                                      " AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "'" & _
                                      " GROUP by tblYearLevelSections.sectioncode,sectionorder,sectionmaximum"
                                    myconn.ConnectionString = CONNECTION_STRING
                                    myconn.Open()
                                    mycommand.Connection = myconn
                                    mycommand.CommandText = SQLString
                                    myreader = mycommand.ExecuteReader
                                    Do While myreader.Read
                                        Capacity.Add(CInt(myreader("capacity")))
                                        If Capacity.Item(i) > 0 Then
                                            SectionName = myreader("sectioncode").ToString
                                            StudentSection = myreader("yearlevelsectioncode").ToString
                                        End If
                                    Loop
                                    myconn.Close()

                                Catch ex As Exception
                                    MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End Try
                                If StudentSection IsNot "" Then
                                    Exit For
                                End If
                            Next
                            If OldSectionID = StudentSection Then
                            Else
                                SQLString = "Update tblStudentYear SET assessedid=" & NewAssessedID & " where studentschoolyear = '" & SYID & StudentToChange & "'"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                                SQLString = "Update tblStudentSections SET yearlevelsectioncode='" & StudentSection & "' where studentschoolyear = '" & SYID & StudentToChange & "'"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                                SQLString = "Update tblStudentYear SET assessedid=0 where studentschoolyear = '" & SYID & StudentNoPaymentTextBox.Text & "'"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                                SQLString = "Update tblStudentSections SET yearlevelsectioncode='" & OldSectionID & "' where studentschoolyear = '" & SYID & StudentNoPaymentTextBox.Text & "'"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                            End If


                        End If
                    End If
                End If
                Dim AmountToDeduct As Decimal = AmountTenderedPaymentDecimal
                If OverDue > AmountToDeduct Then
                    Dim result As Integer = MessageBox.Show("Please remind the student that he/she must settled the remaining overdue accounts.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                Dim TotalFees As Decimal = MiscellaneousBalancePayment
                For i = 0 To FeeIDList.Count - 1
                    TotalFees = TotalFees + FeeAmountList.Item(i)
                Next
                If AmountTenderedPaymentDecimal < TotalFees Then
                    If AmountTenderedPaymentDecimal > AmountToPayInteger Then
                        Dim ToNextPayment As Decimal = AmountTenderedPaymentDecimal - AmountToPayInteger
                        Dim result As Integer = MessageBox.Show("Would you like to include the change to the next payment(s)?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If result = DialogResult.Yes Then
                            For i = 0 To FeeIDList.Count - 1
                                If FeeAdded.Item(i) = 0 Then
                                    If ToNextPayment <= 0 Then
                                        Exit For
                                    Else
                                        FeeIDToPayList.Add(FeeIDList.Item(i))
                                        FeeNameToPayList.Add(FeeNameList.Item(i))
                                        FeeAmountToPayList.Add(FeeAmountList.Item(i))
                                        FeeCategoryToPayList.Add(FeeCategoryList.Item(i))
                                        FeePaymentDateToPayList.Add(FeePaymentDate.Item(i))
                                        FeeAdded.Item(i) = 1
                                        PaymentToList()
                                        ToNextPayment = ToNextPayment - FeeAmountList.Item(i)
                                    End If
                                End If
                            Next
                        End If
                    End If
                End If
                InsertSubjects()
                Try
                    Dim SQLSection As String = "Select studentsection from tblYearLevelSections,tblYearLevel,tblStudentSections,tblStudentYear" & _
                    " where tblStudentSections.yearlevelsectioncode = tblYearLevelSections.yearlevelsectioncode" & _
                    " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear " & _
                     " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
                    " AND schoolyearid='" & SYID & "'"

                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSection
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        StudentSection = myreader("studentsection").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                'End If
                Dim AmountDeducted As Decimal
                For i = 0 To FeeIDToPayList.Count - 1
                    Try
                        Dim SQLSelectFee As String = " Select balance from tblStudentTransactions,tblStudentYear,tblStudents" & _
                        " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear " & _
                        " AND tblStudents.studentid=tblStudentYear.studentid" & _
                        " AND tblSTudentYear.studentid='" & StudentSearch & "'" & _
                        " AND studentfee='" & FeeIDToPayList.Item(i) & "'" & _
                        " AND schoolyearid='" & SYID & "'"

                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLSelectFee
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            BalancePaymentDecimal = CDec((myreader("balance")))
                            If AmountToDeduct > BalancePaymentDecimal Then
                                AmountToDeduct = AmountToDeduct - BalancePaymentDecimal
                                AmountDeducted = BalancePaymentDecimal
                                NewBalancePaymentDecimal = 0
                            Else
                                AmountDeducted = AmountToDeduct
                                NewBalancePaymentDecimal = BalancePaymentDecimal - AmountToDeduct
                                AmountToDeduct = 0
                            End If
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    'Select studentfee
                    'Insert studenttransaction
                    Dim DatePaid As Date = CDate(DateLabel.Text)
                    Dim TimePaid As DateTime = CDate(TimeLabel.Text)
                    Try
                        SQLString = "UPDATE tblStudentTransactions " & " SET balance='" & NewBalancePaymentDecimal & "'" & _
                        " WHERE studentschoolyear='" & SYID & StudentSearch & "' AND studentfee='" & FeeIDToPayList.Item(i) & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()

                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    Dim TypeOfPayment As String
                    If CashPaymentRadioButton.Checked = True Then
                        TypeOfPayment = "Cash"
                    Else
                        TypeOfPayment = "Check #" & CheckTextBox.Text
                    End If
                    Try
                        SQLString = "INSERT INTO tblTransactions " & " VALUES ('" & FeeIDToPayList.Item(i) & "','" & TransactionNoPaymentTextBox.Text & "','" & TypeOfPayment & "','" & DatePaid.ToString("yyyy/MM/dd") & " " & TimePaid.ToString("hh:MM") & "'," & AmountDeducted & ")"

                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()

                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
                If StatusPaymentTextBox.Text = "Reserved" Then
                Else
                    If err = 0 Then
                        Try
                            SQLString = "UPDATE tblStudentYear " & " SET studentstatus='Enrolled'" & _
                            " WHERE studentschoolyear='" & SYID & StudentSearch & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLString = "UPDATE tblStudentYear " & " SET assessedid=0" & _
                           " WHERE studentschoolyear='" & SYID & StudentSearch & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()

                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Else
                        MessageBox.Show("The student is required to pay half of his/ her miscellaneous & other fees to be enrolled.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
                MessageBox.Show("Payment Received.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Receipt.Show()
                '
                '
                '

            End If
        Else
            End If

    End Sub
    Dim StudNoPaymentList As New List(Of String)
    Dim TotalTuitionAssess As Decimal
    Dim DiscountRateAssess As Decimal
    Dim TuitionXDiscount As Decimal

    Public Sub ClearAssessment()
        GroupBoxShow = 2
        TransactionComboBox.Text = "Payments"
        PartialRadioButton.Checked = False
        ReservationRadioButton.Enabled = True
        FullButton.Checked = False
        ReservationRadioButton.Checked = False
        PaymentModeGroupBox.Enabled = False
        DiscountAssessListView.Items.Clear()
        discountrate = 0
        TuitionAssessListView.Items.Clear()
        MiscellaneousAssessListView.Items.Clear()
        OthersAssessListView.Text = String.Format("{0:" + "P" + "#,##0.00}", 0)
        MiscellaneousTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", 0)
        GrandTotalTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", 0)
        TuitionTotalAssessTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", 0)
        YearLevelAssessTextBox.Clear()
        SectionAssessTextBox.Clear()
        ListOfSchedulesListView.Items.Clear()
        CashPaymentRadioButton.Checked = True
        StudentNoAssessTextBox.Text = ""
        StatusAssessTextBox.Text = ""
        StudentNameAssessTextBox.Text = ""
        DiscountAssessTextBox.Text = "0%"
        EditDiscountButton.Enabled = False
        CategoryAssessTextBox.Text = ""
    End Sub

    Private Sub WebsiteMaintenceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebsiteMaintenance.Show()
    End Sub

    Public NewTime As DateTime = System.DateTime.Now
    Public NewDate As Date = System.DateTime.Now
    Dim Seconds As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Seconds = Seconds + 50
        NewDate = System.DateTime.Now
        NewTime = System.DateTime.Now
        DateLabel.Text = NewDate.ToLongDateString
        'TimeLabel.Text = NewTime.AddSeconds(Seconds).ToShortTimeString
        TimeLabel.Text = NewTime.ToString("T")
        'DisclaimerAssessLabel.Location = New Point(274 - Seconds, 139)
    End Sub

    Public MiscellaneousAssess As Decimal = 0
    Dim GrandTotal As Decimal
    Public DiscountTotal As Integer
    Dim DiscountsList As New List(Of Integer)
    Dim yeargrade As String = ""
    'Dim IncludeOtherFeeList As New List(Of String)
    'Dim IncludeOtherFeeBalanceList As New List(Of Decimal)
    'Dim IncludeDiscountList As New List(Of String)
    'Dim IncludeDiscountPercentageList As New List(Of Integer)
    Public TuitionBalanceAssess As New List(Of Decimal)
    Public ComputerBalanceAssess As New List(Of Decimal)
    Public FullTuitionBalance As Decimal
    Public FullComputerBalance As Decimal
    Dim reservationfee As Decimal
    Public Sub ViewAssess()
        If TransactionComboBox.Text = "Payments" Then
            PaymentAssessPanel.BringToFront()
            OthersAssessListView.Items.Clear()
            MiscellaneousAssessListView.Items.Clear()
            TuitionAssessListView.Items.Clear()
            MiscellaneousAssess = 0
            For i = 0 To MiscellaneousNameList.Count - 1
                MiscellaneousAssessListView.Items.Add(MiscellaneousNameList.Item(i))
                MiscellaneousAssessListView.Items(MiscellaneousAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", MiscellaneousAmountAssess.Item(i)))
                MiscellaneousAssess = MiscellaneousAssess + MiscellaneousAmountAssess.Item(i)
            Next
            For i = 0 To OtherNameList.Count - 1
                If OtherNameList.Item(i) = "Reservation Fee" Then
                Else
                    OthersAssessListView.Items.Add(OtherNameList.Item(i))
                    OthersAssessListView.Items(OthersAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", OtherAmountAssess.Item(i)))
                End If
            Next
            Dim TotalBackSubjectCost As Decimal = 0
            For i = 0 To BackSubjectCodeList.Count - 1
                TotalBackSubjectCost = TotalBackSubjectCost + BackSubjectCost.Item(i)
                'MessageBox.Show(BackSubjectCost.Item(i).ToString)
            Next
            Try
                TotalBackSubjectCost = TotalBackSubjectCost / TuitionNameList.Count
            Catch
                TotalBackSubjectCost = 0
            End Try

            Dim NewDiscount As Double
            NewDiscount = DiscountTotal / 100
            Dim NewBalance As Decimal
            Dim NewTuitionAmountPaid As Decimal = TuitionAmountPaidAssess
            Dim NewComputerAmountPaid As Decimal = ComputerAmountPaidAssess
            TuitionBalanceAssess.Clear()
            ComputerBalanceAssess.Clear()
            FullTuitionBalance = 0
            FullComputerBalance = 0
            If PartialRadioButton.Checked = True Then
                For i = 0 To TuitionNameList.Count - 1
                    TuitionAssessListView.Items.Add(TuitionNameList.Item(i))
                    NewBalance = CDec(TuitionAmountAssess.Item(i) * NewDiscount)
                    NewBalance = (TuitionAmountAssess.Item(i) + ComputerAmountAssess.Item(i) + TotalBackSubjectCost) - NewBalance
                    If NewBalance >= NewTuitionAmountPaid Then
                        NewBalance = NewBalance - NewTuitionAmountPaid
                        NewTuitionAmountPaid = 0
                    Else
                        NewTuitionAmountPaid = NewTuitionAmountPaid - NewBalance
                        NewBalance = 0
                    End If
                    TuitionBalanceAssess.Add(NewBalance)
                    FullTuitionBalance = FullTuitionBalance + NewBalance
                    TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", TuitionBalanceAssess.Item(i)))

                    'NewBalance = ComputerAmountAssess.Item(i)
                    'If NewBalance >= NewComputerAmountPaid Then
                    '  NewBalance = NewBalance - NewComputerAmountPaid
                    '   NewComputerAmountPaid = 0
                    'Else
                    '  NewComputerAmountPaid = NewComputerAmountPaid - NewBalance
                    '   NewBalance = 0
                    'End If

                    'ComputerBalanceAssess.Add(NewBalance)
                    'FullComputerBalance = FullComputerBalance + NewBalance
                    'TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", ComputerBalanceAssess.Item(i)))
                    TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(TuitionDateAssess.Item(i).ToString("yyyy/MM/dd"))
                Next
            ElseIf FullButton.Checked = True Then
                For i = 0 To TuitionNameList.Count - 1
                    NewBalance = CDec(TuitionAmountAssess.Item(i) * NewDiscount)
                    NewBalance = (TuitionAmountAssess.Item(i) + ComputerAmountAssess.Item(i) + TotalBackSubjectCost) - NewBalance
                    If NewBalance >= NewTuitionAmountPaid Then
                        NewBalance = NewBalance - NewTuitionAmountPaid
                        NewTuitionAmountPaid = 0
                    Else
                        NewTuitionAmountPaid = NewTuitionAmountPaid - NewBalance
                        NewBalance = 0
                    End If
                    FullTuitionBalance = FullTuitionBalance + NewBalance

                    'NewBalance = CDec(ComputerAmountAssess.Item(i))
                    'If NewBalance >= NewComputerAmountPaid Then
                    'NewBalance = NewBalance - NewComputerAmountPaid
                    'NewComputerAmountPaid = 0
                    'Else
                    'NewComputerAmountPaid = NewComputerAmountPaid - NewBalance
                    'NewBalance = 0
                    'End If
                    'FullComputerBalance = FullComputerBalance + NewBalance
                Next

                TuitionBalanceAssess.Add(FullTuitionBalance)
                'ComputerBalanceAssess.Add(FullComputerBalance)

                TuitionAssessListView.Items.Add("Full Payment")
                TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", TuitionBalanceAssess.Item(0)))
                'TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", ComputerBalanceAssess.Item(0)))
                TuitionAssessListView.Items(TuitionAssessListView.Items.Count - 1).SubItems.Add(Date.Today.ToString("yyyy/MM/dd"))
            ElseIf ReservationRadioButton.Checked = True Then
                DiscountAssessListView.Items.Clear()
                DiscountAssessTextBox.Text = ""
                OtherAmountAssess.Clear()
                OtherNameList.Clear()
                OthersAssessListView.Items.Clear()
                MiscellaneousAssessListView.Items.Clear()
                MiscellaneousAssess = 0
                OthersTotal = 0
                reservationfee = 0
                SQLString = "SELECT distinct fee_name,fee_amount from tblYearLevelfee where fee_name='Reservation Fee'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        reservationfee = CDec((myreader("fee_amount").ToString))
                        OtherNameList.Add((myreader("fee_name").ToString))
                        OtherAmountAssess.Add(reservationfee)
                        OthersAssessListView.Items.Add("Reservation Fee")
                        OthersAssessListView.Items(OthersAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", reservationfee))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Assess_Err_Res.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                For i = 0 To OthersAssessListView.Items.Count - 1
                    If OthersAssessListView.Items(i).SubItems(0).Text = "Reservation Fee" Then
                        OthersAssessListView.Items(i).Checked = True
                    End If
                Next
            End If
            'MessageBox.Show("TF:" & FullTuitionBalance & " CF:" & FullComputerBalance & " OF:" & OthersTotal & " MF:" & MiscellaneousAssess)
            If ReservationRadioButton.Checked = True Then
                GrandTotal = CDec(OthersTotal)
            Else
                GrandTotal = CDec(FullTuitionBalance + FullComputerBalance + OthersTotal + MiscellaneousAssess)
            End If
            MiscellaneousTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", MiscellaneousAssess)
            DownPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", (MiscellaneousAssess + OthersTotal) / 2)
            TuitionTotalAssessTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", FullTuitionBalance)
            GrandTotalTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", GrandTotal)
        ElseIf TransactionComboBox.Text = "Grades" Then
            GradesAssessPanel.BringToFront()
        End If
    End Sub
    Private Sub ClearAssessmentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearAssessment()
    End Sub
    Public SectionReservation As String = ""
    Public Sub ViewDiscount()
        If BackSubjectCodeList.Count = BackSubjectSection.Count Then
            If StatusAssessTextBox.Text = "Registered" Then
                Dim MaxAssessedID As Integer = 0
                Try
                    Dim SQLSubjects As String = "Select MAX(assessedid) As assessedid From tblStudentYear" & _
                    " WHERE schoolyearid='" & SYID & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSubjects
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        MaxAssessedID = CInt(myreader("assessedid"))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
                Try
                    SQLString = "Update tblStudentYear SET assessedid=" & MaxAssessedID + 1 & " where studentschoolyear = '" & SYID & StudentNoAssessTextBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch
                    myconn.Close()
                End Try
            End If
            Try
                Dim SQLSubjects As String = " INSERT INTO tblStudentSections VALUES ('" & StudentSearch & SYID & StudentSection & "','" & SYID & StudentSearch & "','" & StudentSection & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSubjects
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                'MessageBox.Show("Unable to connect to sdsd.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim GradingPeriodID As New List(Of String)
            Try
                Dim SQLSubjects As String = "Select distinct gradingperiodid  From tblGradings,tblSchoolYear" & _
                " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
                " AND tblSchoolYear.schoolyearid='" & SYID & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSubjects
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    GradingPeriodID.Add(myreader("gradingperiodid").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If SectionAssessTextBox.Text IsNot String.Empty Then
                StudentSection = (YearLevelAssessTextBox.Text & SectionAssessTextBox.Text).Trim
                For i = 0 To GradingPeriodID.Count - 1
                    For j = 0 To BackSubjectCodeList.Count - 1
                        Try
                            SQLString = "INSERT INTO tblStudentSubjects VALUES ('" & (SYID & StudentSearch & BackSubject.Item(j) & GradingPeriodID.Item(i)).Trim & "','" & SYID & StudentSearch & "','" & BackSubjectSection.Item(j) & "','" & BackSubjectCodeList.Item(j) & "','Taking','" & GradingPeriodID.Item(i) & "',0)"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        Catch ex As Exception
                            myconn.Close()
                        End Try

                    Next
                Next
            End If
            InsertSubjects()
            SQLString = "DELETE FROM tblStudentTransactions WHERE studentschoolyear='" & SYID & StudentNoAssessTextBox.Text & "'" & _
             " AND balancecategory='Other Fees'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            Try
                For i = 0 To OtherAmountAssess.Count - 1
                    Try
                        If OthersAssessListView.Items(i).Checked = True Then
                            SQLString = "INSERT INTO tblStudentTransactions VALUES('" & StudentNoAssessTextBox.Text & "Other" & i + 1 & SYID & "','" & SYID & StudentNoAssessTextBox.Text & "','" & OthersAssessListView.Items(i).SubItems(0).Text & "','Other Fees',NULL,'" & OtherAmountAssess.Item(i) & "','" & Date.Today.ToString("yyyy/MM/dd") & "')"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        End If
                    Catch
                    End Try
                Next
            Catch
            End Try
            If PaymentMode = "" And ReservationRadioButton.Checked = True Then
                PaymentMode = "Reserved"
                StudentSection = ""
                Dim StudentSubjectsList As New List(Of String)


                If StudentSection = "" Then
                    MessageBox.Show("No more available reservation slots.Try again.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else

                    Dim result As Integer = MessageBox.Show("Would you like to reserve him/her to " & YearLevelAssessTextBox.Text & "-" & SectionReservation & "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If result = DialogResult.Yes Then
                        SQLString = "Update tblStudentTransactions SET paymentmode='For Reservation' where studentschoolyear = '" & SYID & StudentNoAssessTextBox.Text & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        SQLString = "Update tblStudentYear SET studentstatus='Reserved' where schoolyearid = '" & SYID & "'" & _
                    " AND studentid='" & StudentNoAssessTextBox.Text & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        ViewAssess()
                        AssessmentForm.Show()
                    End If
                End If
            Else
                Try
                    SQLString = "DELETE FROM tblStudentDiscounts WHERE studentid='" & StudentNoAssessTextBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                For i = 0 To DiscountAssessListView.Items.Count - 1
                    If DiscountAssessListView.Items(i).Checked = True Then
                        Try
                            SQLString = "INSERT INTO tblStudentDiscounts(studentid,studentdiscount,studentdiscountrate) VALUES('" & StudentNoAssessTextBox.Text & "','" & DiscountAssessListView.Items(i).SubItems(0).Text & "','" & DiscountAssessListView.Items(i).SubItems(1).Text & "')"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        Catch ex As Exception
                            myconn.Close()
                        End Try
                    End If
                Next

                Dim StudentStatus As String = ""
                SQLString = " SELECT studentstatus from tblStudentYear where studentschoolyear='" & SYID & StudentNoAssessTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    StudentStatus = myreader("studentstatus").ToString
                Loop
                myconn.Close()

                If FullButton.Checked = True Then
                    PaymentMode = "Full Payment"
                    Dim FullDate As Date = CDate(DateLabel.Text)
                    SQLString = "DELETE FROM tblStudentTransactions WHERE studentschoolyear='" & SYID & StudentNoAssessTextBox.Text & "'" & _
                    " AND balancecategory='Tuition' OR balancecategory='Computer Fee'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    SQLString = "INSERT INTO tblStudentTransactions VALUES('" & StudentNoAssessTextBox.Text & "FullTuitionFee" & SYID & "','" & SYID & StudentNoAssessTextBox.Text & "','Full Payment','Tuition','Full Payment','" & TuitionBalanceAssess.Item(0) & "','" & FullDate.ToString("yyyy/MM/dd") & "')"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    'SQLString = "INSERT INTO tblStudentTransactions VALUES('" & StudentNoAssessTextBox.Text & "FullComputerFee" & SYID & "','" & SYID & StudentNoAssessTextBox.Text & "','Full Payment','Computer Fee','Full Payment','" & ComputerBalanceAssess.Item(0) & "','" & FullDate.ToString("yyyy/MM/dd") & "')"
                    'myconn.ConnectionString = CONNECTION_STRING
                    'myconn.Open()
                    'mycommand.Connection = myconn
                    'mycommand.CommandText = SQLString
                    'mycommand.ExecuteNonQuery()
                    'myconn.Close()
                    If StudentStatus = "Registered" Or StudentStatus = "Reserved" Then
                        SQLString = "UPDATE tblStudentYear " & " SET studentstatus='Assessed'" & _
                            " WHERE studentschoolyear='" & SYID & StudentSearch & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                    End If
                ElseIf PartialRadioButton.Checked = True Then
                    PaymentMode = "Partial Payment"
                    Try
                        SQLString = "DELETE FROM tblStudentTransactions WHERE studentschoolyear='" & SYID & StudentNoAssessTextBox.Text & "'" & _
                      " AND balancecategory='Tuition' OR balancecategory='Computer Fee'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        For i = 0 To TuitionNameList.Count - 1
                            SQLString = "INSERT INTO tblStudentTransactions VALUES('" & StudentNoAssessTextBox.Text & "TF" & 5 + i & SYID & "','" & SYID & StudentNoAssessTextBox.Text & "','" & TuitionNameList.Item(i) & "','Tuition','" & PaymentMode & "','" & TuitionBalanceAssess.Item(i) & "','" & TuitionDateAssess.Item(i).ToString("yyyy/MM/dd") & "')"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            'SQLString = "INSERT INTO tblStudentTransactions VALUES('" & StudentNoAssessTextBox.Text & "CF" & 5 + i & SYID & "','" & SYID & StudentNoAssessTextBox.Text & "','" & TuitionNameList.Item(i) & "','Computer Fee','" & PaymentMode & "','" & ComputerBalanceAssess.Item(i) & "','" & TuitionDateAssess.Item(i).ToString("yyyy/MM/dd") & "')"
                            'myconn.ConnectionString = CONNECTION_STRING
                            'myconn.Open()
                            'mycommand.Connection = myconn
                            'mycommand.CommandText = SQLString
                            'mycommand.ExecuteNonQuery()
                            'myconn.Close()
                        Next
                        If StudentStatus = "Registered" Or StudentStatus = "Reserved" Then
                            SQLString = "UPDATE tblStudentYear " & " SET studentstatus='Assessed'" & _
                                " WHERE studentschoolyear='" & SYID & StudentSearch & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        End If
                        MessageBox.Show("Successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        StudentSearch = StudentSearch
                        AmountTenderedPaymentTextBox.Enabled = False
                        'AmountTendered()
                    Catch ex As Exception
                        myconn.Close()
                        ' MessageBox.Show("..." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If
                AssessmentForm.Show()
            End If
            'PaymentBalanceGroupBox.Visible = True
            'PaymentBalanceGroupBox.BringToFront()
            'ClearAssessment()
        Else
            MessageBox.Show("Add the remaining backsubjects to subject schedules.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim discountrate As Decimal = 0
    Dim StudentDiscountList As New List(Of String)
    Sub ViewStudentDiscount()
        OthersTotal = 0
        DiscountAssessTextBox.Text = "0 %"
        DiscountAssessListView.Items.Clear()
        DiscountsList.Clear()
        DiscountTotal = 0
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                DiscountsList.Add(CInt(myreader("dis_rate").ToString))
                DiscountAssessListView.Items.Add(CStr(myreader("dis_name")))
                DiscountAssessListView.Items(DiscountAssessListView.Items.Count - 1).SubItems.Add(myreader("dis_rate").ToString & "%")
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Error_Dis.Unable to connect to DaaB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        StudentDiscountList.Clear()
        SQLString = "SELECT studentdiscount" & " FROM tblStudentDiscounts" & _
   " WHERE studentdiscount!='Cash' And studentid='" & StudentSearch & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudentDiscountList.Add(CStr(myreader("studentdiscount")))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBghgh.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If StudentDiscountList.Count > 0 Then
            For i = 0 To StudentDiscountList.Count - 1
                For j = 0 To DiscountAssessListView.Items.Count - 1
                    If StudentDiscountList.Item(i) = DiscountAssessListView.Items(j).SubItems(0).Text Then
                        DiscountAssessListView.Items(j).Checked = True
                        DiscountTotal = DiscountTotal + DiscountsList.Item(i)
                    ElseIf FullButton.Checked = True And DiscountAssessListView.Items(j).SubItems(0).Text = "Cash" Then
                        DiscountAssessListView.Items(j).Checked = True
                    End If
                Next
            Next
        Else
            Dim a As Integer = 0
            For j = 0 To DiscountAssessListView.Items.Count - 1
                If FullButton.Checked = True And DiscountAssessListView.Items(j).SubItems(0).Text = "Cash" Then
                    DiscountAssessListView.Items(j).Checked = True
                    a = 1
                End If
            Next
            ViewAssess()
        End If
        If DiscountAssessListView.Items.Count = 0 Then
            ViewAssess()
        End If
    End Sub
    Private Sub FullButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullButton.CheckedChanged
        If FullButton.Checked = True Then
            OtherNameList.Clear()
            OtherAmountAssess.Clear()
            OthersAssessListView.Items.Clear()
            OthersTotal = 0
            SQLString = "SELECT fee_name,fee_amount " & "FROM tblYearLevelFee,tblYearLevel" & _
           " WHERE fee_category='Other Fees'" & _
           " AND tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode" & _
           " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
           " AND schoolyeartype='" & SYType & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    OtherNameList.Add(myreader("fee_name").ToString)
                    OtherAmountAssess.Add(CDec(myreader("fee_amount").ToString))
                    OthersAssessListView.Items.Add(myreader("fee_name").ToString)
                    OthersAssessListView.Items(OthersAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", myreader("fee_amount")))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("OtherList_Err." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim k As Integer = 0
            SQLString = "SELECT balancename,balance " & "FROM tblStudentTransactions,tblStudentYear" & _
         " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
         " AND tblStudentYear.studentid='" & StudentSearch & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND balancecategory='Other Fees'" & _
            " GROUP BY studentfee"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim j As Integer = 0
                    For l = 0 To OthersAssessListView.Items.Count - 1
                        If OthersAssessListView.Items(l).Text = myreader("balancename").ToString Then
                            j = 1
                            OtherAmountAssess.Item(l) = CDec(myreader("balance"))
                            OthersAssessListView.Items(l).Checked = True
                            Exit For
                        End If
                    Next
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("OtherBal_Err." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            For l = 0 To OthersAssessListView.Items.Count - 1
                If OthersAssessListView.Items(l).Checked = True Then
                    OthersTotal = CDec(OthersTotal + OtherAmountAssess.Item(l))
                End If
            Next
            OthersTotalAssessTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", OthersTotal)

            If FullButton.Checked = True Then
                SQLString = "SELECT dis_name,dis_rate" & " FROM tblDiscounts" & _
              " WHERE  yeargrade='" & yeargrade & "'"
                ViewStudentDiscount()
            End If
        End If
    End Sub
    Private Sub PartialRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialRadioButton.CheckedChanged
        If PartialRadioButton.Checked = True Then
            OtherNameList.Clear()
            OtherAmountAssess.Clear()
            OthersAssessListView.Items.Clear()
            OthersTotal = 0
            SQLString = "SELECT fee_name,fee_amount " & "FROM tblYearLevelFee,tblYearLevel" & _
           " WHERE fee_category='Other Fees'" & _
           " AND tblYearLevel.yearlevelcode=tblYearLevelFee.yearlevelcode" & _
           " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
           " AND schoolyeartype='" & SYType & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    OtherNameList.Add(myreader("fee_name").ToString)
                    OtherAmountAssess.Add(CDec(myreader("fee_amount").ToString))
                    OthersAssessListView.Items.Add(myreader("fee_name").ToString)
                    OthersAssessListView.Items(OthersAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", myreader("fee_amount")))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("OtherList_Err." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim k As Integer = 0
            SQLString = "SELECT balancename,balance " & "FROM tblStudentTransactions,tblStudentYear" & _
         " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
         " AND tblStudentYear.studentid='" & StudentSearch & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND balancecategory='Other Fees'" & _
            " GROUP BY studentfee"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim j As Integer = 0
                    For l = 0 To OthersAssessListView.Items.Count - 1
                        If OthersAssessListView.Items(l).Text = myreader("balancename").ToString Then
                            j = 1
                            OtherAmountAssess.Item(l) = CDec(myreader("balance"))
                            OthersAssessListView.Items(l).Checked = True
                            Exit For
                        End If
                    Next
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("OtherBal_Err." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            For l = 0 To OthersAssessListView.Items.Count - 1
                If OthersAssessListView.Items(l).Checked = True Then
                    OthersTotal = CDec(OthersTotal + OtherAmountAssess.Item(l))
                End If
            Next
            OthersTotalAssessTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", OthersTotal)

            If PartialRadioButton.Checked = True Then
                SQLString = "SELECT dis_name,dis_rate" & " FROM tblDiscounts" & _
            " WHERE yeargrade='" & yeargrade & "' AND dis_name !='Cash'"

                ViewStudentDiscount()
            End If
        End If
    End Sub
    ''' PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
    ''' AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    ''' YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
    ''' MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    ''' TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    Dim FeeNameList As New List(Of String)
    Dim FeeCategoryList As New List(Of String)
    Dim FeeAmountList As New List(Of Decimal)
    Dim FeePaymentDate As New List(Of DateTime)
    Dim FeeIDList As New List(Of String)
    Dim FeeAdded As New List(Of Integer)

    Dim ComputerFeeNameList As New List(Of String)
    Dim ComputerFeeCategoryList As New List(Of String)
    Dim ComputerFeeAmountList As New List(Of Decimal)
    Dim ComputerFeePaymentDate As New List(Of DateTime)
    Dim ComputerFeeIDList As New List(Of String)
    Dim ComputerFeeAdded As New List(Of Integer)

    Dim OtherFeeNameList As New List(Of String)
    Dim OtherFeeCategoryList As New List(Of String)
    Dim OtherFeeAmountList As New List(Of Decimal)
    Dim OtherFeeIDList As New List(Of String)

    Dim OverDue As Decimal
    Public MiscellaneousBalancePayment As Decimal
    Public TuitionBalancePayment As Decimal
    Public ComputerBalancePayment As Decimal
    Public OtherBalancePayment As Decimal
    Public TotalBalance As Decimal
    Public Sub ViewFees()
        OverDue = 0
        PaymentBalanceClearAll()
        FeeIDList.Clear()
        FeeNameList.Clear()
        FeeAdded.Clear()
        FeeCategoryList.Clear()
        FeeAmountList.Clear()
        FeePaymentDate.Clear()
        FeeIDToPayList.Clear()
        FeePaymentDateToPayList.Clear()
        FeeNameToPayList.Clear()
        FeeCategoryToPayList.Clear()
        FeeAmountToPayList.Clear()
        MiscellaneousBalancePayment = 0
        OtherBalancePayment = 0
        TuitionBalancePayment = 0
        ComputerBalancePayment = 0
        Dim LoadInfo As String = "SELECT yearlevelname,tblStudents.studentid As studentid,Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus  " & "FROM tblYearLevel,tblStudentYearLevel,tblStudents,tblStudentYear where " & _
" tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode AND tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
" AND tblStudents.studentid='" & StudentSearch & "'" & _
" AND tblStudents.studentid=tblStudentYear.studentid" & _
" AND schoolyearid='" & SYID & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudentNoPaymentTextBox.Text = (myreader("studentid").ToString)
                StudentNameTextBox.Text = (myreader("Name").ToString)
                StatusPaymentTextBox.Text = (myreader("studentstatus").ToString)
                YearLevelPaymentTextBox.Text = (myreader("yearlevelname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            'myconn.Close()
        End Try

        Dim TransactionCounter As Integer
        Dim SQLTransacNo As String = " Select Count(distinct transacno) As trans From tblTransactions" & _
        " WHERE transacno!='NULL'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLTransacNo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                TransactionCounter = CInt(myreader("trans"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        TransactionNoPaymentTextBox.Text = (TransactionCounter + 1).ToString("000000000000")
        Dim StudSection As String = ""
        Dim SQLSection As String = "SELECT sectioncode from tblStudentYear,tblStudentSections,tblYearLevelSections" & _
        " where tblStudentYear.studentschoolyear = tblStudentSections.studentschoolyear And tblYearLevelSections.yearlevelsectioncode = tblStudentSections.yearlevelsectioncode" & _
         " AND studentid='" & StudentSearch & "'" & _
        " AND tblStudentYear.schoolyearid='" & SYID & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSection
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudSection = myreader("sectioncode").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        TotalBalance = 0
        SectionPaymentTextBox.Text = StudSection
        If StatusPaymentTextBox.Text = "Reserved" Then
            OthersDataGridView.Rows.Clear()
            OtherBalancePayment = 0
            SQLString = "SELECT studentfee As feeid,balancename,balancecategory,balance,balancedate " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Other Fees' AND balancename='Reservation Fee'" & _
          " AND balance!=0" & _
          " AND schoolyearid='" & SYID & "'" & _
          " GROUP BY balancename"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = OthersDataGridView.Rows.Add()
                    If myreader("balancename").ToString = "Reservation Fee" Then
                        FeeIDToPayList.Add(CStr(myreader("feeid")))
                        FeeNameToPayList.Add(CStr(myreader("balancename")))
                        FeeAmountToPayList.Add(CDec(myreader("balance")))
                        FeeCategoryToPayList.Add("Tuition")
                        FeePaymentDateToPayList.Add(CDate(myreader.GetDateTime("balancedate").ToString("yyyy/MM/dd")))
                    Else
                        FeeIDToPayList.Add(CStr(myreader("feeid")))
                        FeeNameToPayList.Add(CStr(myreader("balancename")))
                        FeeAmountToPayList.Add(CDec(myreader("balance")))
                        FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                        FeePaymentDateToPayList.Add(CDate(myreader.GetDateTime("balancedate").ToString("yyyy/MM/dd")))
                    End If
                    OtherFeeIDList.Add(CStr(myreader("feeid")))
                    OtherFeeNameList.Add(CStr(myreader("balancename")))
                    OtherFeeCategoryList.Add(CStr(myreader("balancecategory")))
                    OtherFeeAmountList.Add(CDec(myreader("balance")))
                    OthersDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                    OthersDataGridView.Rows.Item(n).Cells(1).Value = myreader("balance").ToString
                    OtherBalancePayment = OtherBalancePayment + CDec(myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                'MessageBox.Show("Err_res_Other." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                myconn.Close()
            End Try
            OthersTotalPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", OtherBalancePayment)
            SQLString = "SELECT SUM(Balance) As balance" & " FROM tblStudentTransactions,tblStudentYear" & _
        " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
        " AND studentid='" & StudentSearch & "'" & _
         " AND schoolyearid='" & SYID & "'" & _
         " AND balance!=0 AND balancename='Reservation Fee'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TotalBalance = CDec(myreader("balance"))
                    TotalTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", TotalBalance)
                Loop
                myconn.Close()
            Catch ex As Exception
                TotalBalance = 0
                myconn.Close()
            End Try
        ElseIf StatusPaymentTextBox.Text = "Official Dropped" Then
            Dim RegDate As Date
            SQLString = "Select date(st_registration) As RegDate FROM tblStudents,tblStudentYear" & _
    " WHERE tblStudents.studentid=tblStudentYear.studentid AND studentschoolyear='" & SYID & StudNoRegistrationTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                RegDate = CDate(myreader("RegDate"))
            Loop
            myconn.Close()
            Dim refund As Double = 0
            SQLString = "Select refund,refunddays FROM tblRefunds"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim days As Double = (Date.Today.Subtract(RegDate)).TotalDays
                If days <= CInt(myreader("refunddays")) Then
                    refund = CInt(myreader("refund").ToString)
                    Exit Do
                End If
            Loop
            myconn.Close()
            If refund = 0 Then
                SQLString = "Select SUM(balance) As balance FROM tblStudentTransactions,tblStudentYear" & _
        " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
        " AND  tblStudentYear.schoolyearid='" & SYID & "'" & " AND tblStudentYear.studentid='" & StudNoRegistrationTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    MessageBox.Show("Successfully dropped student. Outstanding Balance:" & myreader("balance").ToString & ".", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loop
                myconn.Close()
            Else
                refund = CDbl(refund / 100)
                Dim totalamount As Decimal = 0
                Try
                    SQLString = "Select SUM(amountpaid) As totalamount FROM tblStudentTransactions,tblStudentYear,tblTransactions" & _
         " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear " & _
         " AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
         " AND  tblStudentYear.studentschoolyear='" & SYID & StudNoRegistrationTextBox.Text & "'" & _
            " AND balancecategory='Tuition' AND dateofpayment!='NULL'" & _
        " ORDER By dateofpayment"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        totalamount = CDec(myreader("totalamount").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    totalamount = 0
                    myconn.Close()
                End Try
                MessageBox.Show(totalamount.ToString)
                If totalamount > 0 Then
                    totalamount = CDec(totalamount * refund)
                End If
                Dim TotalRefund As Decimal = totalamount
                Dim AmountToRefundList As New List(Of Double)
                Dim TransacnoList As New List(Of String)
                Dim FeeToRefundList As New List(Of String)
                Try
                    SQLString = "Select studentfee,transacno,amountpaid As amountpaid FROM tblStudentTransactions,tblStudentYear,tblTransactions" & _
         " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear " & _
         " AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
         " AND  tblStudentYear.studentschoolyear='" & SYID & StudNoRegistrationTextBox.Text & "'" & _
            " AND balancecategory='Tuition' AND dateofpayment!='NULL'" & _
        " ORDER By dateofpayment"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        If totalamount >= CDec(myreader("amountpaid").ToString) Then
                            FeeToRefundList.Add(myreader("studentfee").ToString)
                            TransacnoList.Add(myreader("transacno").ToString)
                            AmountToRefundList.Add(CDbl(0))
                        Else
                            FeeToRefundList.Add(myreader("studentfee").ToString)
                            AmountToRefundList.Add(totalamount)
                            TransacnoList.Add(myreader("transacno").ToString)
                            Exit Do
                        End If
                        totalamount = totalamount - CDec(myreader("amountpaid").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    totalamount = 0
                    myconn.Close()
                End Try
                For i = 0 To TransacnoList.Count - 1
                    SQLString = "UPDATE Transactions " & " SET amountpaid='" & AmountToRefundList.Item(i) & "'" & _
                        " WHERE studentfee='" & FeeToRefundList.Item(i) & "' AND Transacno='" & TransacnoList.Item(i) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Next

            End If
        Else
            SQLString = "SELECT SUM(Balance) As balance" & " FROM tblStudentTransactions,tblStudentYear" & _
        " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
        " AND studentid='" & StudentSearch & "'" & _
         " AND schoolyearid='" & SYID & "'" & _
         " AND balance!=0"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TotalBalance = CDec(myreader("balance"))
                    TotalTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", TotalBalance)
                Loop
                myconn.Close()
            Catch ex As Exception
                TotalBalance = 0
                myconn.Close()
            End Try
            Dim DownPaymentFee As Decimal = 0
            SQLString = "SELECT SUM(fee_amount) As fee " & "FROM tblYearLevelFee,tblYearLevel" & _
           " where fee_category='Miscellaneous'" & _
           " AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
           " AND yearlevelname='" & YearLevelPaymentTextBox.Text & "'" & _
            " AND schoolyeartype='" & SYType & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    DownPaymentFee = CDec(myreader("fee"))
                Loop
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                'MessageBox.Show("Dec." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            SQLString = "SELECT SUM(fee_amount) As fee " & "FROM tblStudentTransactions,tblYearLevelFee,tblYearLevel,tblStudentYear,tblStudentYearLevel" & _
           " where fee_category='Other Fees'" & _
           " AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
           " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
           " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
           " AND tblStudentTransactions.studentschoolyear=tblStudentYear.studentschoolyear" & _
           " AND fee_name=balancename" & _
           " AND schoolyearid='" & SYID & "'" & _
           " AND yearlevelname='" & YearLevelPaymentTextBox.Text & "'" & _
            " AND schoolyeartype='" & SYType & "'" & _
            " AND studentid='" & StudentNoPaymentTextBox.Text & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    DownPaymentFee = DownPaymentFee + CDec(myreader("fee"))
                Loop
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                'MessageBox.Show("Dec" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim totalamount As Decimal = 0
            Try
                SQLString = "Select SUM(amountpaid) As totalamount FROM tblStudentTransactions,tblStudentYear,tblTransactions" & _
             " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear " & _
             " AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
             " AND  tblStudentYear.studentschoolyear='" & SYID & StudentNoPaymentTextBox.Text & "'" & _
                " AND balancecategory!='Tuition'  AND dateofpayment!='NULL'" & _
            " ORDER By dateofpayment"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    totalamount = CDec(myreader("totalamount").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                totalamount = 0
                myconn.Close()
            End Try
            Try
                DownPaymentFee = DownPaymentFee / 2
                DownPaymentFee = DownPaymentFee - totalamount
            Catch
                DownPaymentFee = 0
            End Try
            If totalamount > DownPaymentFee Then
                DownPaymentFee = 0
            End If
            TotalDownPaymentPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", DownPaymentFee)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            MiscellaneousDataGridView.Rows.Clear()
            SQLString = "SELECT studentfee As feeid,balancename,balancecategory,balance " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Miscellaneous'" & _
          " AND balance !=0" & _
          " AND schoolyearid='" & SYID & "'" & _
          " GROUP BY feeid"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = MiscellaneousDataGridView.Rows.Add()
                    MiscellaneousDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                    MiscellaneousDataGridView.Rows.Item(n).Cells(1).Value = String.Format("{0:" + "P" + "#,##0.00}", myreader("balance"))
                    OverDue = OverDue + CDec(myreader("balance"))
                    MiscellaneousBalancePayment = MiscellaneousBalancePayment + CDec(myreader("balance"))
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                'myconn.Close()
            End Try
            MiscellaneousTotalPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", MiscellaneousBalancePayment)
            If MiscellaneousBalancePayment > 0 Then
                MiscellaneousTotalTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", MiscellaneousBalancePayment)
                PaymentsListView.Items.Add("Miscellaneous")
                PaymentsListView.Items(PaymentsListView.Items.Count - 1).SubItems.Add("P " & MiscellaneousBalancePayment.ToString & ".00")
                SQLString = "SELECT studentfee As feeid,balancename,balance,balancecategory " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Miscellaneous'" & _
          " AND balance!=0" & _
          " AND schoolyearid='" & SYID & "'" & _
          " GROUP BY feeid"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        Dim n As Integer = MiscellaneousDataGridView.Rows.Add()
                        FeeIDToPayList.Add(CStr(myreader("feeid")))
                        FeeNameToPayList.Add(CStr(myreader("balancename")))
                        FeeAmountToPayList.Add(CDec(myreader("balance")))
                        FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                        FeePaymentDateToPayList.Add(Date.Today)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Err_Mis." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No records found.")
                    'myconn.Close()
                End Try
            End If
            ''''''''''
            OthersDataGridView.Rows.Clear()
            SQLString = "SELECT studentfee As feeid,balancename,balancecategory,balance,balancedate " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Other Fees'" & _
          " AND balance!=0" & _
          " AND schoolyearid='" & SYID & "'" & _
          " GROUP BY balancename"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = OthersDataGridView.Rows.Add()

                    FeeIDToPayList.Add(CStr(myreader("feeid")))
                    FeeNameToPayList.Add(CStr(myreader("balancename")))
                    FeeAmountToPayList.Add(CDec(myreader("balance")))
                    FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                    FeePaymentDateToPayList.Add(CDate(myreader.GetDateTime("balancedate").ToString("yyyy/MM/dd")))

                    OtherFeeIDList.Add(CStr(myreader("feeid")))
                    OtherFeeNameList.Add(CStr(myreader("balancename")))
                    OtherFeeCategoryList.Add(CStr(myreader("balancecategory")))
                    OtherFeeAmountList.Add(CDec(myreader("balance")))
                    OthersDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                    OthersDataGridView.Rows.Item(n).Cells(1).Value = myreader("balance").ToString
                    OtherBalancePayment = OtherBalancePayment + CDec(myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Err_Other." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                'myconn.Close()
            End Try
            OthersTotalPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", OtherBalancePayment)
            TuitionDataGridView.Rows.Clear()

            SQLString = "SELECT studentfee As feeid,balancename,balancecategory,balance,balancedate " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Tuition'" & _
          " AND schoolyearid='" & SYID & "'" & _
          " AND balance !=0" & _
          " GROUP BY feeid"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim PaymentDate As Date = CDate(DateLabel.Text)
                    Dim n As Integer = TuitionDataGridView.Rows.Add()
                    If CDate(myreader.GetMySqlDateTime("balancedate")) <= CDate(PaymentDate.ToString("yyyy/MM/dd")) Then
                        FeeIDToPayList.Add(CStr(myreader("feeid")))
                        FeeNameToPayList.Add(CStr(myreader("balancename")))
                        FeeAmountToPayList.Add(CDec(myreader("balance")))
                        FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                        FeePaymentDateToPayList.Add(CDate(myreader.GetMySqlDateTime("balancedate")))
                        FeeIDList.Add(CStr(myreader("feeid")))
                        FeeNameList.Add(CStr(myreader("balancename")))
                        FeeCategoryList.Add(CStr(myreader("balancecategory")))
                        FeeAmountList.Add(CDec(myreader("balance")))
                        FeeAdded.Add(1)
                        FeePaymentDate.Add(CDate(myreader.GetMySqlDateTime("balancedate")))
                        TuitionDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                        TuitionDataGridView.Rows.Item(n).Cells(1).Value = "P " & myreader("balance").ToString
                        TuitionDataGridView.Rows.Item(n).Cells(2).Value = FeePaymentDate.Item(n).ToString("yyyy/MM/dd")
                        OverDue = OverDue + CDec(myreader("balance"))
                    Else
                        FeeIDList.Add(CStr(myreader("feeid")))
                        FeeNameList.Add(CStr(myreader("balancename")) & "(T)")
                        FeeCategoryList.Add(CStr(myreader("balancecategory")))
                        FeeAmountList.Add(CDec(myreader("balance")))
                        FeeAdded.Add(0)
                        FeePaymentDate.Add(CDate(myreader.GetMySqlDateTime("balancedate")))
                        TuitionDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                        TuitionDataGridView.Rows.Item(n).Cells(1).Value = "P " & myreader("balance").ToString
                        TuitionDataGridView.Rows.Item(n).Cells(2).Value = FeePaymentDate.Item(n).ToString("yyyy/MM/dd")
                    End If
                    TuitionBalancePayment = TuitionBalancePayment + CDec(myreader("balance"))
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Err_Tuition." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                'myconn.Close()
            End Try
            TuitionTotalPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", TuitionBalancePayment)
            ComputerFeeDataGridView.Rows.Clear()

            SQLString = "SELECT studentfee As feeid,balancename,balancecategory,balance,balancedate " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
       " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
       " AND tblStudents.studentid=tblStudentYear.studentid " & _
       " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND balancecategory='Computer Fee'" & _
          " AND schoolyearid='" & SYID & "'" & _
          " AND balance !=0" & _
          " GROUP BY feeid"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim PaymentDate As Date = CDate(DateLabel.Text)
                    Dim n As Integer = ComputerFeeDataGridView.Rows.Add()
                    If CDate(myreader.GetMySqlDateTime("balancedate")) <= CDate(PaymentDate.ToString("yyyy/MM/dd")) Then
                        FeeIDToPayList.Add(CStr(myreader("feeid")))
                        FeeNameToPayList.Add(CStr(myreader("balancename")) & "(CF)")
                        FeeAmountToPayList.Add(CDec(myreader("balance")))
                        FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                        FeePaymentDateToPayList.Add(CDate((myreader.GetMySqlDateTime("balancedate"))))
                        ComputerFeeIDList.Add(CStr(myreader("feeid")))
                        ComputerFeeNameList.Add(CStr(myreader("balancename")))
                        ComputerFeeCategoryList.Add(CStr(myreader("balancecategory")))
                        ComputerFeeAmountList.Add(CDec(myreader("balance")))
                        ComputerFeeAdded.Add(1)
                        ComputerFeePaymentDate.Add(CDate(myreader.GetMySqlDateTime("balancedate")))

                        ComputerFeeDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                        ComputerFeeDataGridView.Rows.Item(n).Cells(1).Value = "P " & myreader("balance").ToString
                        ComputerFeeDataGridView.Rows.Item(n).Cells(2).Value = ComputerFeePaymentDate.Item(n).ToString("yyyy/MM/dd")
                        OverDue = OverDue + CDec(myreader("balance"))
                    Else
                        ComputerFeeIDList.Add(CStr(myreader("feeid")))
                        ComputerFeeNameList.Add(CStr(myreader("balancename")) & "(CF)")
                        ComputerFeeCategoryList.Add(CStr(myreader("balancecategory")))
                        ComputerFeeAmountList.Add(CDec(myreader("balance")))
                        ComputerFeeAdded.Add(0)
                        ComputerFeePaymentDate.Add(CDate(myreader.GetMySqlDateTime("balancedate")))

                        ComputerFeeDataGridView.Rows.Item(n).Cells(0).Value = myreader("balancename").ToString
                        ComputerFeeDataGridView.Rows.Item(n).Cells(1).Value = "P " & myreader("balance").ToString
                        ComputerFeeDataGridView.Rows.Item(n).Cells(2).Value = ComputerFeePaymentDate.Item(n).ToString("yyyy/MM/dd")
                    End If
                    ComputerBalancePayment = ComputerBalancePayment + CDec(myreader("balance"))
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Err_Computer." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                'myconn.Close()
            End Try
            ComputerTotalPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", ComputerBalancePayment)
            If MiscellaneousBalancePayment = 0 Then
                IncludePaymentComboBox.SelectedIndex = 1
            ElseIf TuitionBalancePayment = 0 Then
                IncludePaymentComboBox.SelectedIndex = 2
            End If
        End If
        PaymentToList()
    End Sub
    Private Sub TuitionDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TuitionDataGridView.CellContentClick
        Try
            Dim n As Integer = e.RowIndex
            Dim cnt As Integer = 0
            For i = 0 To FeeIDList.Count - 1
                If FeeAdded.Item(i) = 0 Then
                    If FeePaymentDate.Item(n) > FeePaymentDate.Item(i) Then
                        cnt = 1
                    End If
                End If
            Next
            For i = 0 To FeeIDToPayList.Count - 1
                If FeeIDList.Item(n) = FeeIDToPayList.Item(i) Then
                    cnt = 2
                End If
            Next
            If cnt = 0 Then
                FeeIDToPayList.Add(FeeIDList.Item(n))
                FeeNameToPayList.Add(FeeNameList.Item(n))
                FeeAmountToPayList.Add(FeeAmountList.Item(n))
                FeeCategoryToPayList.Add(FeeCategoryList.Item(n))
                FeePaymentDateToPayList.Add(FeePaymentDate.Item(n))
                FeeAdded.Item(n) = 1
            ElseIf cnt = 2 Then
                MessageBox.Show("Oops!, adding SAME FEE is not allowed. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cnt = 1 Then
                MessageBox.Show("Oops!, first add the fee(s) with lower PAYMENT DATE. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch
        End Try
        PaymentToList()
    End Sub
    Private Sub ComputerFeeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ComputerFeeDataGridView.CellContentClick
        Try
            Dim n As Integer = e.RowIndex
            Dim cnt As Integer = 0
            For i = 0 To ComputerFeeIDList.Count - 1
                If ComputerFeeAdded.Item(i) = 0 Then
                    If ComputerFeePaymentDate.Item(n) > ComputerFeePaymentDate.Item(i) Then
                        cnt = 1
                    End If
                End If
            Next
            For i = 0 To FeeIDToPayList.Count - 1
                If ComputerFeeIDList.Item(n) = FeeIDToPayList.Item(i) Then
                    cnt = 2
                End If
            Next
            If cnt = 0 Then
                FeeIDToPayList.Add(ComputerFeeIDList.Item(n))
                FeeNameToPayList.Add(ComputerFeeNameList.Item(n))
                FeeAmountToPayList.Add(ComputerFeeAmountList.Item(n))
                FeeCategoryToPayList.Add(ComputerFeeCategoryList.Item(n))
                FeePaymentDateToPayList.Add(ComputerFeePaymentDate.Item(n))
                ComputerFeeAdded.Item(n) = 1
            ElseIf cnt = 2 Then
                MessageBox.Show("Oops!, adding SAME FEE is not allowed. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf cnt = 1 Then
                MessageBox.Show("Oops!, first add the fee(s) with lower PAYMENT DATE. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch
        End Try
        PaymentToList()
    End Sub
    Public Sub PaymentToList()
        Dim amount As Decimal
        PaymentsListView.Items.Clear()
        AmountToPayInteger = 0
        If FeeIDToPayList.Count > 0 Then
            AmountTenderedPaymentTextBox.Enabled = True
            AmountTenderedPaymentTextBox.Focus()
            For i = 0 To FeeIDToPayList.Count - 1
                PaymentsListView.Items.Add(FeeNameToPayList.Item(i))
                PaymentsListView.Items(PaymentsListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", FeeAmountToPayList.Item(i)))
                amount = FeeAmountToPayList.Item(i) + 0
            Next
            For i = 0 To FeeAmountToPayList.Count - 1
                AmountToPayInteger = AmountToPayInteger + FeeAmountToPayList.Item(i)
            Next

            AmountTendered()
        Else
            AmountTenderedPaymentTextBox.Enabled = False
            PaymentsListView.Focus()
        End If
        TotalAmountDuePaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", AmountToPayInteger)
    End Sub


    Private Sub SearchStudentPaymentPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewFees()
    End Sub








    Public AmountTenderedPaymentDecimal As Decimal
    Dim ChangePaymentDecimal As Decimal
    Dim TotalBalancePayment As Decimal
    Public Sub AmountTendered()
        If AmountTenderedPaymentTextBox.Text = "" Then
            AmountTenderedPaymentDecimal = 0
        Else
            Try
                AmountTenderedPaymentDecimal = CDec(AmountTenderedPaymentTextBox.Text)
            Catch
                AmountTenderedPaymentTextBox.Text = "0"
            End Try
        End If
        If AmountTenderedPaymentDecimal > AmountToPayInteger Then
            ChangePaymentDecimal = AmountTenderedPaymentDecimal - AmountToPayInteger
            TotalBalancePayment = 0
        Else
            ChangePaymentDecimal = 0
            TotalBalancePayment = AmountToPayInteger - AmountTenderedPaymentDecimal
        End If

        ChangePaymentTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", ChangePaymentDecimal)
        BalancePaymentTextBox.Text = String.Format("{0:" + "P " + "#,##0.00}", TotalBalancePayment)
    End Sub
    Private Sub AmountTenderedPaymentTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmountTenderedPaymentTextBox.TextChanged
        AmountTendered()
    End Sub
    Dim AmountToPayInteger As Decimal
    Public FeeIDToPayList As New List(Of String)
    Public FeeAmountToPayList As New List(Of Decimal)
    Public FeeNameToPayList As New List(Of String)
    Public FeeCategoryToPayList As New List(Of String)
    Public FeePaymentDateToPayList As New List(Of Date)


    Private Sub PaymentsListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsListView.Click
        For i = 0 To PaymentsListView.Items.Count - 1
            If PaymentsListView.Items(i).Selected = True Then
                If FeeCategoryToPayList.Item(i) = "Tuition" Or FeeCategoryToPayList.Item(i) = "Computer Fee" Then
                    Dim k As Integer = 0
                    For l = 0 To FeeIDToPayList.Count - 1
                        If FeePaymentDateToPayList.Item(l) > FeePaymentDateToPayList.Item(PaymentsListView.SelectedIndices(0)) _
                        And FeeCategoryToPayList.Item(l) = FeeCategoryToPayList.Item(PaymentsListView.SelectedIndices(0)) Then
                            k = 1
                        End If
                    Next
                    For l = 0 To FeeIDToPayList.Count - 1
                        If FeePaymentDateToPayList.Item(PaymentsListView.SelectedIndices(0)) <= Date.Today Then
                            k = 2
                        End If
                    Next
                    If k = 0 Then
                        For j = 0 To FeeIDList.Count - 1
                            If FeeIDList.Item(j) = FeeIDToPayList.Item(PaymentsListView.SelectedIndices(0)) Then
                                FeeAdded.Item(j) = 0
                            End If
                        Next
                        FeeIDToPayList.RemoveAt(i)
                        FeeAmountToPayList.RemoveAt(i)
                        FeeNameToPayList.RemoveAt(i)
                        FeeCategoryToPayList.RemoveAt(i)
                        FeePaymentDateToPayList.RemoveAt(i)
                    Else
                        If k = 1 Then
                            MessageBox.Show("Oops!, removing CANNOT be done, first remove the " & FeeCategoryToPayList.Item(PaymentsListView.SelectedIndices(0)) & " with highest payment date from the list", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ElseIf k = 2 Then
                            MessageBox.Show("Oops!, removing CANNOT be done, it's already a DEFERRED PAYMENT. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                ElseIf FeeCategoryToPayList.Item(i) = "Miscellaneous" Then
                    MessageBox.Show("Oops!, Miscellaneous CANNOT be removed. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    FeeIDToPayList.RemoveAt(i)
                    FeeAmountToPayList.RemoveAt(i)
                    FeeNameToPayList.RemoveAt(i)
                    FeeCategoryToPayList.RemoveAt(i)
                    FeePaymentDateToPayList.RemoveAt(i)
                End If
            End If
        Next
        PaymentToList()
    End Sub


    ''' SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
    ''' TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    ''' IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
    ''' OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
    ''' NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    ''' SSSSSSSSSSSSSSSSSSSSSS
    Private Sub ExitHomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchoolYear.Show()
    End Sub

    ''' UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
    ''' SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    ''' EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
    ''' RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
    ''' SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    ''' <remarks></remarks>

    Private Sub EnrollmentSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As Integer = MessageBox.Show("Are you sure you want to create a new enrollment system? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            SQLString = "INSERT INTO tblEnrollmentSystem " & "VALUES ()"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        End If
    End Sub

    Private Sub YearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearToolStripMenuItem.Click
        Year.Show()
    End Sub

    Private Sub SectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionToolStripMenuItem.Click
        Section.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem.Click
        Subjects.Show()
    End Sub

    Private Sub FeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeeToolStripMenuItem.Click
        Fees.Show()
    End Sub





    Private Sub DiscountsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountsToolStripMenuItem1.Click
        Discounts.Show()
    End Sub

    Private Sub RefundsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundsToolStripMenuItem.Click
        Refund.Show()
    End Sub


    Private Sub RoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsToolStripMenuItem.Click
        Rooms.Show()
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleToolStripMenuItem.Click
        Schedule.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentsToolStripMenuItem.Click
        StudentClass.Show()
    End Sub

    Private Sub UsersAccountsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersAccountsToolStripMenuItem.Click
        Users.Show()
    End Sub


    Private Sub TeachersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeachersToolStripMenuItem.Click
        Teachers.Show()
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsiteToolStripMenuItem.Click
        WebsiteMaintenance.Show()
    End Sub
    Public AdminOrTeacherGrade As Integer

    Private Sub UsersAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesToolStripMenuItem.Click
        AdminOrTeacherGrade = 1
        Grading.Show()
    End Sub

    Private Sub RequirementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequirementsToolStripMenuItem.Click
        Requirement.Show()
    End Sub
    Dim NewOrOld As Integer = 0
    Dim StudentType As String
    Dim Subject As New List(Of String)
    Public Sub ViewStudent()
        Subject.Clear()
        BackSubject.Clear()
        Dim yeargrade As String = ""
        DropButton.Enabled = False
        MaxStudentSYID = SYID
        Try
            SQLString = "SELECT tblStudents.studentid,MAX(schoolyearid) As SYID " & "FROM tblStudents,tblStudentYear where " & _
            "tblStudents.studentid='" & StudentSearch & "' AND tblStudents.studentid=tblStudentYear.studentid"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                StudentSearch = myreader("studentid").ToString
                MaxStudentSYID = myreader("SYID").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        StudentTypeComboBox.Enabled = False
        Dim GuardianName As String = ""
        Dim GuardianRelationship = "Relative"
        Dim GuardianContact As Double = 0

        SQLString = "SELECT tblStudents.studentid,st_lname,st_fname,st_mname,st_type,st_bdate,st_gender,st_religion,st_address,st_contactno,fa_name,fa_contactno," & _
   "fa_occupation,mo_name,mo_contactno,mo_occupation,gua_name,gua_relationship,gua_contactno " & "FROM tblStudents,tblStudentYear " & _
 " WHERE tblStudents.studentid='" & StudentSearch & "' AND tblStudents.studentid=tblStudentYear.studentid"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim BDate As Date = myreader.GetDateTime("st_bdate")
                StudLastNameRegistrationTextBox.Text = myreader("st_lname").ToString
                StudFirstNameRegistrationTextBox.Text = (myreader("st_fname").ToString)
                StudMiddleNameRegistrationTextBox.Text = (myreader("st_mname").ToString)
                StudentType = (myreader("st_type").ToString)
                BirthDateTimePicker.Text = BDate.ToString("MM/dd/yyyy")
                GenderRegistrationComboBox.Text = (myreader("st_gender").ToString)
                ReligionComboBox.Text = (myreader("st_religion").ToString)
                AddressRegistrationTextBox.Text = (myreader("st_address").ToString)
                ContactNoRegistrationTextBox.Text = (myreader("st_contactno").ToString)
                FatherNameTextBox.Text = (myreader("fa_name").ToString)
                FatherContactNoRegistrationTextBox.Text = (myreader("fa_contactno").ToString)
                FatherOccupationTextBox.Text = (myreader("fa_occupation").ToString)
                MotherNameTextBox.Text = (myreader("mo_name").ToString)
                MotherContactNoRegistrationTextBox.Text = (myreader("mo_contactno").ToString)
                MotherOccupationTextBox.Text = (myreader("mo_occupation").ToString)
                GuardianName = (myreader("gua_name").ToString)
                GuardianRelationship = (myreader("gua_relationship").ToString)
                GuardianContact = CDbl((myreader("gua_contactno").ToString))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            myconn.Close()
        End Try
        If GuardianName = "" Then
            ParentsRadioButton.Checked = True
        Else
            OthersRadioButton.Checked = True
        End If
        GuardianRegistrationTextBox.Text = GuardianName
        GuardianRelationshipTextBox.Text = GuardianRelationship
        GuardianContactTextBox.Text = CStr(GuardianContact)
        YearLevelRegistrationComboBox.Text = ""
        Dim yearlevel As String = ""
        If StudentSearch IsNot String.Empty Then
            If MaxStudentSYID < SYID Then
                NewOrOld = 1
                If CDbl(SYID) - CDbl(MaxStudentSYID) > 1 Then
                    StudentTypeComboBox.Text = "Returnee"
                Else
                    StudentTypeComboBox.Text = "Old"
                End If
                YearLevelRegistrationComboBox.Enabled = False
                StudNoRegistrationTextBox.Text = StudentSearch
                SQLString = "Select yeargrade FROM tblStudentYear,tblStudentYearLevel,tblYearLevel WHERE tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
            " AND studentid='" & StudentSearch & "' AND schoolyearid='" & MaxStudentSYID & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        yeargrade = myreader("yeargrade").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Dim grade As Decimal
                If yeargrade = "Grade School" Then
                    Try
                        SQLString = "Select ROUND(AVG(grade),2) As grade FROM tblStudentSubjects,tblStudentYear" & _
                " WHERE tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear " & _
                " AND studentid='" & StudentSearch & "'" & _
                " AND tblStudentYear.schoolyearid='" & MaxStudentSYID & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            grade = CDec(myreader("grade"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        grade = 0
                        myconn.Close()
                    End Try
                    If grade < 75 Then
                        SQLString = "Select yearlevelname FROM tblStudentYear,tblStudentYearLevel,tblYearLevel WHERE tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
           " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
            " AND studentid='" & StudentSearch & "' AND implemented='True'" & _
                   " HAVING MAX(schoolyearid)"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                yearlevel = (myreader("yearlevelname").ToString)
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("No records found.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        YearLevelRegistrationComboBox.Text = yearlevel
                        MessageBox.Show("Important: This STUDENT CANNOT LEVEL UP as his records show that he did not passed one or more of his subjects. Proceeding only means the student was unable to settle his grades. ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        SQLString = "SELECT yearlevelname " & "FROM tblYearLevel where " & _
            " yearorder>(Select yearorder FROM tblStudentYear,tblStudentYearLevel,tblYearLevel WHERE tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
            " AND studentid='" & StudentSearch & "' AND schoolyearid='" & MaxStudentSYID & "')" & _
            " AND yeargrade='" & yeargrade & "' AND implemented='True' LIMIT 1"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                yearlevel = (myreader("yearlevelname").ToString)
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        If yearlevel = "" Then
                            SQLString = "SELECT yearlevelname " & "FROM tblYearLevel where " & _
                 " yearorder=1" & _
                 " AND yeargrade='High School' AND implemented='True'"
                            Try
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                myreader = mycommand.ExecuteReader
                                Do While myreader.Read
                                    yearlevel = (myreader("yearlevelname").ToString)
                                Loop
                                myconn.Close()
                            Catch ex As Exception
                                MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Try
                            YearLevelRegistrationComboBox.Text = yearlevel
                        End If
                    End If
                Else
                    Dim FailNo As Integer = 0

                    SubjectsDataGridView.Rows.Clear()
                    SQLString = "Select distinct tblSubjects.subjectcode As subjectcode,sub_code from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                               " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                              " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                              " AND studentid='" & StudNoRegistrationTextBox.Text & "'" & _
                              " AND tblStudentYear.schoolyearid='" & MaxStudentSYID & "'" & _
                              " ORDER BY sub_code"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            Subject.Add(myreader("subjectcode").ToString)
                            BackSubject.Add(myreader("sub_code").ToString)
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        myconn.Close()
                    End Try
                    For i = 0 To BackSubject.Count - 1
                        Try
                            SQLString = "Select  (ROUND(AVG(grade),2)) As grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                                      " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                                      " AND sub_code='" & BackSubject.Item(i) & "'" & _
                             " AND tblStudentYear.studentschoolyear='" & MaxStudentSYID & StudNoRegistrationTextBox.Text & "'" & _
                             " GROUP BY sub_code"
                            'Select highesst SYID ng student
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                Dim n As Integer = SubjectsDataGridView.Rows.Add()
                                If myreader("grade").ToString = "" Then
                                    FailNo = FailNo + 1
                                    SubjectsDataGridView.Rows.Item(n).Cells(0).Value = BackSubject.Item(i)
                                    SubjectsDataGridView.Rows.Item(n).Cells(1).Value = "Failed"
                                ElseIf CInt(myreader("grade").ToString) >= 0 Then
                                    SubjectsDataGridView.Rows.Item(n).Cells(0).Value = BackSubject.Item(i)
                                    If CInt(myreader("grade").ToString) >= 75 Then
                                        SubjectsDataGridView.Rows.Item(n).Cells(1).Value = "Passed"
                                    Else
                                        SubjectsDataGridView.Rows.Item(n).Cells(1).Value = "Failed"
                                        FailNo = FailNo + 1
                                    End If
                                End If
                                SubjectsDataGridView.Rows(n).ReadOnly = True
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("Err_Back", ex.Message)
                        End Try
                    Next
                    Dim BackSubjectLimit As Integer = 0
                    SQLString = "Select  backsubjectlimit from Others"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            BackSubjectLimit = CInt(myreader("backsubjectlimit"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Err_Back", ex.Message)
                    End Try
                    If FailNo >= BackSubjectLimit Then
                        SQLString = "Select yearlevelname FROM tblStudentYear,tblStudentYearLevel,tblYearLevel WHERE tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
           " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
            " AND studentid='" & StudentSearch & "' AND implemented='True'" & _
                   " HAVING MAX(schoolyearid)"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                yearlevel = (myreader("yearlevelname").ToString)
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("No records found.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        YearLevelRegistrationComboBox.Text = yearlevel
                        MessageBox.Show("Important: This STUDENT CANNOT LEVEL UP as his records show that he did not passed one or more of his subjects. Proceeding only means the student was unable to settle his grades. ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            Else
                DropButton.Enabled = True
                StudentTypeComboBox.Text = StudentType
                YearLevelRegistrationComboBox.Enabled = False
                StudNoRegistrationTextBox.Text = StudentSearch
                SQLString = "Select distinct yearlevelname FROM tblStudentYear,tblStudentYearLevel,tblYearLevel WHERE tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
         " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND studentid='" & StudentSearch & "'" & _
                " HAVING MAX(schoolyearid)"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    If myconn.State = ConnectionState.Open Then
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            yearlevel = (myreader("yearlevelname").ToString)
                        Loop
                    End If
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
                YearLevelRegistrationComboBox.Text = yearlevel
            End If
        End If
    End Sub
    Dim InsertBackSubject As New List(Of String)
    Private Sub YearLevelRegistrationComboBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelRegistrationComboBox.TextChanged
        RequirementsDataGridView.Rows.Clear()
        ContactNoRegistrationTextBox.Enabled = True
        FatherOccupationTextBox.Enabled = True
        FatherContactNoRegistrationTextBox.Enabled = True
        MotherOccupationTextBox.Enabled = True
        MotherContactNoRegistrationTextBox.Enabled = True
        DiscountRegistrationListView.Items.Clear()
        DiscountRegistrationListView.Enabled = True
        ParentsRadioButton.Enabled = True
        OthersRadioButton.Enabled = True
        ReligionComboBox.Enabled = True
        RepeaterLabel.Visible = False
        YesRepeaterRadioButton.Visible = False
        NoRepeaterRadioButton.Visible = False
        Dim i As Integer = 0
        Dim yeargrade As String = ""
        If NewOrOld = 0 Then
            StudLastNameRegistrationTextBox.Enabled = True
            StudFirstNameRegistrationTextBox.Enabled = True
            StudMiddleNameRegistrationTextBox.Enabled = True
            BirthDateTimePicker.Enabled = True
            GenderRegistrationComboBox.Enabled = True
            AddressRegistrationTextBox.Enabled = True
            FatherNameTextBox.Enabled = True
            MotherNameTextBox.Enabled = True
        End If
        If StudentSearch IsNot String.Empty Then
            StudLastNameRegistrationTextBox.Enabled = False
            StudFirstNameRegistrationTextBox.Enabled = False
            StudMiddleNameRegistrationTextBox.Enabled = False
            BirthDateTimePicker.Enabled = False
            GenderRegistrationComboBox.Enabled = False
            AddressRegistrationTextBox.Enabled = False
            FatherNameTextBox.Enabled = False
            MotherNameTextBox.Enabled = False
        End If
        Dim yearorder As Integer
        SQLString = "Select yeargrade,yearorder FROM tblYearLevel WHERE yearlevelname='" & YearLevelRegistrationComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                yeargrade = myreader("yeargrade").ToString
                yearorder = CInt(myreader("yearorder").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found.d" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If StudentTypeComboBox.Text = "New" Then
            SubjectsDataGridView.Rows.Clear()
        End If
        If yeargrade = "High School" And yearorder > 1 Then
            SubjectsDataGridView.Rows.Clear()
            GroupBox18.Visible = True
            If StudentTypeComboBox.Text = "Transferee" Or StudentTypeComboBox.Text = "Foreign" Then
                RepeaterLabel.Visible = True
                YesRepeaterRadioButton.Visible = True
                NoRepeaterRadioButton.Visible = True
                SubjectsDataGridView.Rows.Clear()
                Subject.Clear()
                SQLString = "Select distinct tblSubjects.subjectcode as subjectcode,sub_code from tblSubjects,tblYearLevelSubjects,tblYearLevel" & _
                " WHERE tblYearLevelSubjects.subjectcode=tblSubjects.subjectcode" & _
                " AND tblYearLevelSubjects.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND yeargrade='High School'" & _
                " AND yearorder=" & yearorder - 1 & " " & _
                " ORDER BY sub_code"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        Dim n As Integer = SubjectsDataGridView.Rows.Add()
                        Subject.Add(myreader("subjectcode").ToString)
                        SubjectsDataGridView.Rows.Item(n).Cells(0).Value = myreader("sub_code").ToString
                        SubjectsDataGridView.Rows.Item(n).Cells(1).Value = "(Select)"
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    myconn.Close()
                End Try

            End If
        End If
        'BackSubjectsTextBox.Visible = True
        ''''Select subject where grade<75 then
        SQLString = "SELECT distinct dis_name,dis_rate" & " FROM tblDiscounts" & _
              " WHERE  yeargrade='" & yeargrade & "' AND dis_name!='Cash'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                DiscountRegistrationListView.Items.Add(CStr(myreader("dis_name")))
                DiscountRegistrationListView.Items(DiscountRegistrationListView.Items.Count - 1).SubItems.Add(myreader("dis_rate").ToString & "%")
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DaB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim LoadRequirements As String = "SELECT distinct req_name FROM tblRequirements,tblYearLevel" & _
       " WHERE tblYearLevel.yeargrade=tblRequirements.yeargrade" & _
       " AND tblYearLevel.yeargrade='" & yeargrade & "'" & _
        " AND student_type='" & StudentTypeComboBox.Text & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = LoadRequirements
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            Dim n As Integer = RequirementsDataGridView.Rows.Add()
            RequirementsDataGridView.Rows.Item(n).Cells(0).Value = myreader("req_name").ToString
            RequirementsDataGridView.Rows.Item(n).Cells(1).Value = "To Follow"
        Loop
        myconn.Close()
        SQLString = "SELECT studentrequirements,requirementcleared FROM tblStudentRequirements " & _
       " WHERE studentid='" & StudNoRegistrationTextBox.Text & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            Dim j As Integer = 0
            For i = 0 To RequirementsDataGridView.Rows.Count - 1
                If RequirementsDataGridView.Rows.Item(i).Cells(0).Value.ToString = myreader("studentrequirements").ToString Then
                    RequirementsDataGridView.Rows.Item(i).Cells(1).Value = myreader("requirementcleared").ToString
                    RequirementsDataGridView.Rows(i).ReadOnly = True
                    RequirementsDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    j = 1
                    Exit For
                End If
            Next
            If j = 0 Then
                Dim n As Integer = RequirementsDataGridView.Rows.Add
                RequirementsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentrequirements").ToString
                RequirementsDataGridView.Rows.Item(n).Cells(1).Value = myreader("requirementcleared").ToString
            End If
        Loop
        myconn.Close()
        For i = 0 To DiscountRegistrationListView.Items.Count - 1
            SQLString = "SELECT studentdiscount" & " FROM tblStudentDiscounts" & _
       " WHERE studentdiscount!='Cash' ANd studentid='" & StudNoRegistrationTextBox.Text & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim Discount As String = CStr(myreader("studentdiscount"))
                    If Discount = DiscountRegistrationListView.Items(i).SubItems(0).Text Then
                        DiscountRegistrationListView.Items(i).Checked = True
                    End If
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBghgh.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Next
        SearchStudNameTextBox.Clear()
    End Sub

    Private Sub CashPaymentRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashPaymentRadioButton.CheckedChanged
        AmountTenderedPaymentTextBox.Enabled = True
        ProceedPaymentButton.Enabled = True
        CheckLabel.Visible = False
        CheckTextBox.Visible = False
    End Sub

    Private Sub CheckPaymentRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPaymentRadioButton.CheckedChanged
        AmountTenderedPaymentTextBox.Enabled = True
        CheckLabel.Visible = True
        CheckTextBox.Visible = True
    End Sub

    Private Sub OthersDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OthersDataGridView.CellContentClick
        Dim y As Integer = OthersDataGridView.CurrentCellAddress.Y

        SQLString = "SELECT studentfee As feeid,balancename,balance,balancecategory,balance " & "FROM tblStudentTransactions,tblStudentYear,tblStudents" & _
" WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
" AND tblStudents.studentid=tblStudentYear.studentid " & _
" AND tblStudents.studentid='" & StudentSearch & "'" & _
   " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
   " AND balancecategory='Other Fees'" & _
   " AND balancename='" & OthersDataGridView.Rows(y).Cells(0).Value.ToString & "'" & _
   " AND balance!=0" & _
   " GROUP BY feeid"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim cnt As Integer = 0
                For i = 0 To FeeIDToPayList.Count - 1
                    If myreader("feeid").ToString = FeeIDToPayList.Item(i) Then
                        cnt = 1
                    End If
                Next
                If cnt = 0 Then
                    FeeIDToPayList.Add(myreader("feeid").ToString)
                    FeeNameToPayList.Add(myreader("balancename").ToString)
                    FeeAmountToPayList.Add(CDec(myreader("balance")))
                    FeeCategoryToPayList.Add(CStr(myreader("balancecategory")))
                    FeePaymentDateToPayList.Add(Date.Today)
                Else
                    MessageBox.Show("Oops!, adding SAME FEE is not allowed. ", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("aaNo records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        PaymentToList()
    End Sub

    Private Sub TotalAmountDuePaymentTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalAmountDuePaymentTextBox.TextChanged

    End Sub

    Private Sub SearchStudentNameAssessListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StudNoPaymentTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AmountTenderedPaymentTextBox.Enabled = True
        PaymentsListView.Items.Clear()
        FeeIDList.Clear()
        FeeNameList.Clear()
        FeeCategoryList.Clear()
        FeeAmountList.Clear()
        FeePaymentDate.Clear()
        FeeIDToPayList.Clear()
        FeePaymentDateToPayList.Clear()
        FeeNameToPayList.Clear()
        FeeCategoryToPayList.Clear()
        FeeAmountToPayList.Clear()
        SectionPaymentTextBox.Text = ""
        AmountTenderedPaymentTextBox.Text = ""
        CheckTextBox.Clear()
    End Sub

    Private Sub RegisterOldLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RegistrationLinkLabel.LinkClicked
        LinkRegistration()
    End Sub
    Private Sub LinkRegistration()
        If ERTo > Date.Today Then
            IndicatorLabel.Text = "Registration"
            SearchStudNameTextBox.Text = ""
            StudentSearch = ""
            MaxStudentSYID = ""
            GroupBoxShow = 1
            TransactionComboBox.Items.Clear()
            TransactionComboBox.Items.Add("Student")
            TransactionComboBox.Text = "Student"
            TransactionComboBox.Enabled = True
            SearchStudNameTextBox.Enabled = True
            SearchPictureBox.Enabled = True
            StudentRegistrationClearAll()
            StudentRegistrationGroupBox.Visible = True
            StudentRegistrationGroupBox.BringToFront()
            IndicatorLabel.BringToFront()
        Else
            MessageBox.Show("Enrollment Period has already ended so as registration of students.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AssessLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AssessLinkLabel.LinkClicked
        LinkAssessment()
    End Sub
    Private Sub LinkAssessment()
        If ERTo > Date.Today Then
            IndicatorLabel.Text = "Assessment"
            SearchStudNameTextBox.Text = ""
            StudentSearch = ""
            GroupBoxShow = 2
            TransactionComboBox.Items.Clear()
            TransactionComboBox.Items.Add("Payments")
            TransactionComboBox.Items.Add("Grades")
            TransactionComboBox.Text = "Payments"
            TransactionComboBox.Enabled = True
            SearchStudNameTextBox.Enabled = True
            SearchPictureBox.Enabled = True
            ClearAssessment()
            AssessmentGroupBox.Visible = True
            AssessmentGroupBox.BringToFront()
            IndicatorLabel.BringToFront()
        Else
            MessageBox.Show("Enrollment Period has already ended so as assessment of students.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PaymentLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PaymentLinkLabel.LinkClicked
        LinkPayment()
    End Sub
    Private Sub LinkPayment()
        IndicatorLabel.Text = "Payment"
        SearchStudNameTextBox.Text = ""
        StudentSearch = ""
        GroupBoxShow = 3
        TransactionComboBox.Items.Clear()
        TransactionComboBox.Items.Add("Balance")
        TransactionComboBox.Text = "Balance"
        TransactionComboBox.Enabled = True
        SearchStudNameTextBox.Enabled = True
        SearchPictureBox.Enabled = True
        PaymentBalanceClearAll()
        PaymentBalanceGroupBox.Visible = True
        PaymentBalanceGroupBox.BringToFront()
        IndicatorLabel.BringToFront()
    End Sub
    Private Sub DateTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Settings.Show()
    End Sub
    Dim StudNoRegList As New List(Of String)
    Private Sub SearchStudNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudNameTextBox.TextChanged
        StudNoRegList.Clear()
        If SearchStudNameTextBox.Text = "" Then 'Or Studentnametextbox.Text = "Search by name..." Then
            SearchListBox.Visible = False
            SearchListBox.Height = 0
        Else
            Dim x As Integer = 30
            SearchListBox.Items.Clear()
            SearchListBox.BringToFront()
            Dim SQLAutoSearch As String = ""
            If GroupBoxShow = 1 Then
                If SYType = "Summer" Then
                    SQLAutoSearch = "SELECT distinct Concat(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') StudentName,tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear,tblStudentYearLevel,tblYearLevel " & _
               " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
                " AND tblStudents.studentid IN (SELECT tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
               " WHERE tblStudents.studentid=tblStudentYear.studentid" & _
                "AND instr( st_lname,'" & SearchStudNameTextBox.Text & "')!=0  OR instr( st_fname,'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,st_lname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,' ',st_lname),'" & SearchStudNameTextBox.Text & "' ) !=0 OR instr(concat(st_lname,st_fname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_lname,' ',st_fname),'" & SearchStudNameTextBox.Text & "') !=0)" & _
                " AND schoolyearid='" & SYID & "'" & _
               "  AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                " AND yeargrade='High School' AND yearorder!=1"
                Else
                    SQLAutoSearch = "SELECT distinct Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') StudentName,tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
                    " WHERE instr( st_lname,'" & SearchStudNameTextBox.Text & "')!=0  OR instr( st_fname,'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,st_lname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,' ',st_lname),'" & SearchStudNameTextBox.Text & "' ) !=0 OR instr(concat(st_lname,st_fname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_lname,' ',st_fname),'" & SearchStudNameTextBox.Text & "') !=0 " & _
                    " AND tblStudents.studentid=tblStudentYear.studentid"
                End If
            ElseIf GroupBoxShow = 2 Then
                SQLAutoSearch = "SELECT distinct Concat(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') StudentName,tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
               " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
                " AND tblStudents.studentid IN (SELECT tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
               " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
                "AND instr( st_lname,'" & SearchStudNameTextBox.Text & "')!=0  OR instr( st_fname,'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,st_lname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,' ',st_lname),'" & SearchStudNameTextBox.Text & "' ) !=0 OR instr(concat(st_lname,st_fname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_lname,' ',st_fname),'" & SearchStudNameTextBox.Text & "') !=0)" & _
                " AND schoolyearid='" & SYID & "'"
            ElseIf GroupBoxShow = 3 Then
                SQLAutoSearch = "SELECT distinct Concat(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') StudentName,tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
           " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudents.studentid IN (SELECT tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
           " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            "AND instr( st_lname,'" & SearchStudNameTextBox.Text & "')!=0  OR instr( st_fname,'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,st_lname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,' ',st_lname),'" & SearchStudNameTextBox.Text & "' ) !=0 OR instr(concat(st_lname,st_fname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_lname,' ',st_fname),'" & SearchStudNameTextBox.Text & "') !=0)" & _
            " AND schoolyearid='" & SYID & "' AND studentstatus!='Registered'"
            ElseIf GroupBoxShow = 4 Then
                SQLAutoSearch = "SELECT distinct Concat(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') StudentName,tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
             " AND tblStudents.studentid IN (SELECT tblStudents.studentid As studentid" & " FROM tblStudents,tblStudentYear " & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
             "AND instr( st_lname,'" & SearchStudNameTextBox.Text & "')!=0  OR instr( st_fname,'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,st_lname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_fname,' ',st_lname),'" & SearchStudNameTextBox.Text & "' ) !=0 OR instr(concat(st_lname,st_fname),'" & SearchStudNameTextBox.Text & "') !=0 OR instr(concat(st_lname,' ',st_fname),'" & SearchStudNameTextBox.Text & "') !=0)" & _
             " AND schoolyearid='" & SYID & "' AND studentstatus!='Registered'"
            End If
            If SQLAutoSearch = "" Then
            Else
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLAutoSearch
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        SearchListBox.Items.Add(myreader("StudentName").ToString)
                        StudNoRegList.Add(myreader("studentid").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    'myconn.Close()
                End Try
            End If
            If StudNoRegList.Count > 6 Then
                SearchListBox.Visible = True
                SearchListBox.Height = 150
            ElseIf StudNoRegList.Count > 0 Then
                SearchListBox.Visible = True
                SearchListBox.Height = SearchListBox.Items.Count * x
            End If
        End If
    End Sub
    Public StudentSearch As String
    Private Sub SearchListBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchListBox.Click
        For a = 0 To StudNoRegList.Count - 1
            If SearchListBox.SelectedIndex = a Then
                StudentSearch = StudNoRegList.Item(a).ToString()
                SearchStudNameTextBox.Text = SearchListBox.SelectedItem.ToString
            End If
        Next
        SearchListBox.Visible = False
    End Sub
    Private Sub CancelRegistrationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StudentRegistrationClearAll()
    End Sub
    Public Drop As String
    Private Sub DropButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropButton.Click
        'If NewOrOld = 1 Then
        'If MaxStudentSYID = SYID Then
        'Pag Stopped lipat ko ito
        'SQLString = "Update tblStudentYear SET studentstatus='Dropped' where schoolyearid = '" & SYID & "'" & _
        '" AND studentid='" & StudentID & "'"
        'myconn.ConnectionString = CONNECTION_STRING
        'myconn.Open()
        'mycommand.Connection = myconn
        'mycommand.CommandText = SQLString
        'mycommand.ExecuteNonQuery()
        'myconn.Close()
        ''Select ung date ng 1st grading
        'Dim StudentSubject As List(Of String)
        Drop = ""
        DropOption.ShowDialog()
    End Sub
    Private Sub StudentTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentTypeComboBox.SelectedIndexChanged
        YearLevelRegistrationComboBox.Text = ""
        YearLevelRegistrationComboBox.Items.Clear()
        If NewOrOld = 0 Then
            YearLevelRegistrationComboBox.Enabled = True
            If StudentTypeComboBox.Text = "New" Then
                SQLString = "SELECT distinct yearlevelname " & "FROM tblYearLevel" & _
           " where yearorder=1"
            ElseIf StudentTypeComboBox.Text = "Transferee" Or StudentTypeComboBox.Text = "Transferee" Then
                SQLString = "SELECT distinct yearlevelname " & "FROM tblYearLevel" & _
           " where yearorder>1"
            End If
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    YearLevelRegistrationComboBox.Items.Add(myreader("yearlevelname").ToString)
                Loop
                myconn.Close()

            Catch ex As Exception
                'MessageBox.Show("No records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("No records found.")
                'myconn.Close()
            End Try
            Dim SQLStudID As String = "Select Count(studentid) As studid FROM tblStudentYear where schoolyearid='" & SYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLStudID
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    studid = CInt(myreader("studid"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            StudNoRegistrationTextBox.Text = CStr(SYID & "-" & (studid + 1).ToString("0000"))
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem2.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to log out it?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        SchoolYear.Show()
    End Sub
    Private Sub ClearPaymentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PaymentBalanceClearAll()
    End Sub
    Private Sub AssessComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionComboBox.SelectedIndexChanged
        If GroupBoxShow = 1 Then
            ViewStudent()
        ElseIf GroupBoxShow = 2 Then
            ViewAssess()
        ElseIf GroupBoxShow = 3 Then
            ViewFees()
        ElseIf GroupBoxShow = 4 Then
            YearRecordComboBox.Enabled = True
            SectionRecordComboBox.Enabled = True
            SubjectComboBox.Enabled = False
            SubjectComboBox.Items.Clear()
            SubjectComboBox.Text = ""
            SectionRecordComboBox.Items.Clear()
            SectionRecordComboBox.Text = ""
            YearRecordComboBox.Items.Clear()
            YearRecordComboBox.Text = ""
            SQLString = "SELECT yearlevelname " & "FROM tblYearLevel WHERE implemented='True'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    YearRecordComboBox.Items.Add(myreader("yearlevelname").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            RecordsPaging()
            ViewRecords()
        End If
    End Sub
    Dim PaymentMode As String


    Dim TuitionNameList As New List(Of String)
    Dim TuitionAmountAssess As New List(Of Decimal)
    Dim ComputerAmountAssess As New List(Of Decimal)
    Dim TuitionAmountPaidAssess As Decimal
    Dim ComputerAmountPaidAssess As Decimal
    Dim MiscellaneousNameList As New List(Of String)
    Dim MiscellaneousAmountAssess As New List(Of Decimal)

    Dim OtherNameList As New List(Of String)
    Dim OtherAmountAssess As New List(Of Decimal)
    Dim OtherBalance As New List(Of Decimal)

    Dim TuitionDateAssess As New List(Of Date)
    Dim StudentReligion As String

    Dim BackSubject As New List(Of String)
    Dim BackSubjectAdded As New List(Of Integer)

    Dim SectionName As String

    Dim BackSubjectUnitList As New List(Of Decimal)
    Dim BackSubjectCodeList As New List(Of String)
    Dim BackSubjectCost As New List(Of Decimal)

    Sub AssessStartup()
        EditDiscountButton.Enabled = True
        SectionName = ""
        CategoryAssessTextBox.Text = ""
        BackSubjectComboBox.Text = ""
        BackSubjectComboBox.Items.Clear()
        BackSubjectListView.Items.Clear()
        BackSubjectSectionComboBox.Text = ""
        BackSubjectSectionComboBox.Items.Clear()
        BackSubjectSection.Clear()
        If TransactionComboBox.Text = "Payments" Then
            StudentSection = ""
            ClearAssessment()
            StudentReligion = ""
            Try
                SQLString = "SELECT yeargrade,yearlevelname,tblStudents.studentid As studentid,Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus,st_religion  " & "FROM tblYearLevel,tblStudentYearLevel,tblStudents,tblStudentYear where " & _
          " tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode AND tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
          " AND tblStudents.studentid='" & StudentSearch & "'" & _
          " AND tblStudents.studentid=tblStudentYear.studentid" & _
          " AND schoolyearid='" & SYID & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        StudentNoAssessTextBox.Text = (myreader("studentid").ToString)
                        ReportName = (myreader("studentid").ToString)
                        StudentNameAssessTextBox.Text = (myreader("Name").ToString)
                        StatusAssessTextBox.Text = (myreader("studentstatus").ToString)
                        StudentReligion = (myreader("st_religion").ToString)
                        YearLevelAssessTextBox.Text = (myreader("yearlevelname").ToString)
                        yeargrade = (myreader("yeargrade").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found.rarar" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                MaxStudentSYID = ""
                SQLString = "SELECT Max(schoolyearid) As MaxSYID  " & "FROM tblStudents,tblStudentYear" & _
          " WHERE tblStudents.studentid='" & StudentNoAssessTextBox.Text & "'" & _
          " AND tblStudents.studentid=tblStudentYear.studentid"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        MaxStudentSYID = (myreader("MaxSYID").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found.rarar" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                'If StatusAssessTextBox.Text="Regis
                SQLString = "SELECT sectioncode from tblStudentYear,tblStudentSections,tblYearLevelSections" & _
                   " where tblStudentYear.studentschoolyear = tblStudentSections.studentschoolyear And tblYearLevelSections.yearlevelsectioncode = tblStudentSections.yearlevelsectioncode" & _
                    " AND studentid='" & StudentSearch & "'" & _
                   " AND schoolyearid='" & SYID & "'"
                Try

                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        SectionName = myreader("sectioncode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                If SectionName = "" Then
                    Dim Sections As New List(Of String)
                    Try
                        SQLString = "Select tblYearLevelSections.yearlevelsectioncode AS section from tblYearLevelSections,tblYearLevel" & _
                        " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
                         " AND yearlevelname='" & YearLevelAssessTextBox.Text & "' " & _
                        " ORDER BY sectionorder"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            Sections.Add(myreader("section").ToString)
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                    Dim Capacity As New List(Of Integer)
                    For i = 0 To Sections.Count - 1
                        Try
                            SQLString = "Select sectioncode,yearlevelsectioncode,sectionmaximum-(Select Count(studentsection)  from tblYearLevelSections,tblYearLevel,tblStudentSections,tblStudentYear" & _
                            " where tblStudentSections.yearlevelsectioncode = tblYearLevelSections.yearlevelsectioncode" & _
                             " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear  " & _
                              " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
                              " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'  AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "' AND tblStudentYear.schoolyearid='" & SYID & "') As Capacity from tblYearLevelSections,tblYearLevel" & _
                            " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                              " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
                              " AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "'" & _
                              " GROUP by tblYearLevelSections.sectioncode,sectionorder,sectionmaximum"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                Capacity.Add(CInt(myreader("capacity")))
                                If Capacity.Item(i) > 0 Then
                                    SectionName = myreader("sectioncode").ToString
                                    StudentSection = myreader("yearlevelsectioncode").ToString
                                End If
                            Loop
                            myconn.Close()

                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        If SectionName IsNot "" Then
                            Exit For
                        End If
                    Next
                End If
                SectionAssessTextBox.Text = SectionName
                If SectionAssessTextBox.Text = "" Then
                    MessageBox.Show("No more available slots for the current level. Expand a current capacity of an existing section or add another section to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    EditDiscountButton.Enabled = False
                Else
                    EditDiscountButton.Enabled = True
                End If

                SubjectGradeDataGridView.Rows.Clear()
                SubjectGradeDataGridView.Columns.Clear()
                Dim coln As New DataGridViewTextBoxColumn
                coln.Width = 60
                coln.HeaderText = "Subject"
                coln.Name = "Subject"
                SubjectGradeDataGridView.Columns.Add(coln)
                Dim SQLSubjects As String = "Select tblStudentSubjects.subjectcode,sub_code from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                        " WHERE tblSubjects.subjectcode=tblStudentSubjects.subjectcode AND" & _
                       " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                       " AND studentid='" & StudentNoAssessTextBox.Text & "'" & _
                       " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                       " GROUP BY tblStudentSubjects.subjectcode"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSubjects
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        Dim n As Integer = SubjectGradeDataGridView.Rows.Add()
                        SubjectGradeDataGridView.Rows.Item(n).Cells(0).Value = myreader("sub_code").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                SQLString = "Select gradingname from tblGradings" & _
                      " WHERE schoolyearid='" & SYID & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        Dim col As New DataGridViewTextBoxColumn
                        col.Width = 50
                        col.HeaderText = myreader("gradingname").ToString
                        col.Name = myreader("gradingname").ToString
                        SubjectGradeDataGridView.Columns.Add(col)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Dim GradeVal As Integer = 0
                For i = 0 To SubjectGradeDataGridView.Rows.Count - 2
                    For j = 1 To SubjectGradeDataGridView.Columns.Count - 1
                        SQLString = "Select gradingname,grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                           " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                          " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                          " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                          " AND studentid='" & StudentNoAssessTextBox.Text & "'" & _
                          " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                          " AND sub_code='" & SubjectGradeDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                        " AND gradingname='" & SubjectGradeDataGridView.Columns(j).HeaderText & "'" & _
                        " GROUP BY gradingname"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                SubjectGradeDataGridView.Rows.Item(i).Cells(j).Value = myreader("grade").ToString
                                If CDec(myreader("grade").ToString) > 0 Then
                                    MessageBox.Show(myreader("grade").ToString)
                                    EditDiscountButton.Enabled = False
                                End If
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Next
                Next
                PaymentAssessPanel.BringToFront()
                PaymentMode = ""
                SQLString = "SELECT distinct paymentmode " & "FROM tblStudentTransactions,tblStudents,tblStudentYear" & _
            " where tblStudents.studentid='" & StudentSearch & "'" & _
            " AND tblStudentYear.studentid=tblStudents.studentid" & _
            " AND tblStudentTransactions.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND schoolyearid='" & SYID & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        PaymentMode = myreader("paymentmode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records foundcc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                MiscellaneousNameList.Clear()
                MiscellaneousAmountAssess.Clear()
                MiscellaneousAssessListView.Items.Clear()
                MiscellaneousAssess = 0
                SQLString = "SELECT balancename,balance " & "FROM tblStudentTransactions,tblStudentYear" & _
             " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
             " AND tblStudentYear.studentid='" & StudentSearch & "'" & _
                " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                " AND balancecategory='Miscellaneous'" & _
                " GROUP BY balancename"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        MiscellaneousNameList.Add(myreader("balancename").ToString)
                        MiscellaneousAmountAssess.Add(CDec(myreader("balance").ToString))
                        MiscellaneousAssessListView.Items.Add(myreader("balancename").ToString)
                        MiscellaneousAssessListView.Items(MiscellaneousAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", myreader("balance")))
                        MiscellaneousAssess = MiscellaneousAssess + CDec(myreader("balance").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No rf." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No records found.")
                    'myconn.Close()
                End Try
                MiscellaneousTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", MiscellaneousAssess)


                ''''BackSubject
                Dim SubjectAssess As New List(Of String)
                Dim Grade As New List(Of Decimal)
                Dim BackSubjectConflict As New List(Of Integer)
                '''''Subject na tinetake ng bata o "Passed"
                '''''
                FailedSubjectDataGridView.Rows.Clear()
                Dim FailNo As Integer = 0
                'BackSubjectsListView.Items.Clear()
                BackSubject.Clear()
                SQLString = "Select distinct sub_code from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                           " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                          " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                          " ORDER BY sub_code"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        BackSubject.Add(myreader("sub_code").ToString)
                        BackSubjectAdded.Add(0)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try

                If SectionAssessTextBox.Text IsNot String.Empty Or SYType = "Summer" Then
                    For i = 0 To BackSubject.Count - 1

                        Dim subjectgrade As Decimal = 0
                        SQLString = "Select  (ROUND(AVG(grade),2)) As grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                                   " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                                  " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                                  " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                                  " AND sub_code='" & BackSubject.Item(i) & "'" & _
                         " AND tblStudentYear.studentschoolyear='" & MaxStudentSYID & StudentNoAssessTextBox.Text & "'" & _
                         " GROUP BY sub_code"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            subjectgrade = (CDec(myreader("grade").ToString))
                        Loop
                        myconn.Close()
                        Grade.Add(subjectgrade)
                        For j = 0 To BackSubject.Count - 1
                            Dim BackSubjectDay As New List(Of String)
                            Dim BackSubjectStartTime As New List(Of DateTime)
                            Dim BackSubjectEndTime As New List(Of DateTime)
                            Try
                                SQLString = "Select sched_day,sched_starttime,sched_endtime from tblYearLevelSchedule,tblSubjects,tblStudentYear,tblStudentSubjects,tblStudentSections" & _
                        " where tblStudentSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                        " tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear AND" & _
                        " tblYearLevelSchedule.yearlevelsectioncode=tblStudentSections.yearlevelsectioncode AND" & _
                       " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear AND" & _
                       " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                       " AND tblStudentYear.studentid='" & StudentNoAssessTextBox.Text & "'" & _
                       " AND schoolyeartype='" & SYType & "'" & _
                       " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                       " GROUP BY tblSubjects.subjectcode" & _
                       " ORDER BY sched_day,sched_starttime ASC"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                myreader = mycommand.ExecuteReader
                                Do While myreader.Read
                                    BackSubjectDay.Add(myreader("sched_day").ToString)
                                    BackSubjectStartTime.Add(CDate(myreader("sched_starttime").ToString))
                                    BackSubjectEndTime.Add(CDate(myreader("sched_endtime").ToString))
                                Loop
                                myconn.Close()
                            Catch ex As Exception
                                MessageBox.Show("Err_Back", ex.Message)
                            End Try
                            Dim ConflictAdd As Integer = 0
                            For k = 0 To BackSubjectDay.Count - 1
                                SQLString = "Select yearlevelschedulekey As conflict from tblYearLevelSchedule,tblStudentSubjects,tblStudentYear " & _
                  " WHERE sched_starttime>='" & BackSubjectStartTime.Item(k).ToString & "'" & _
                  " AND sched_endtime<='" & BackSubjectEndTime.Item(k).ToString & "'" & _
                   " AND sched_day='" & BackSubjectDay.Item(k) & "'" & _
                    " AND tblStudentSubjects.subjectcode=tblYearLevelSchedule.subjectcode" & _
                    " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                    " AND schoolyearid='" & SYID & "'" & _
                   " GROUP BY tblStudentSubjects.subjectcode"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                myreader = mycommand.ExecuteReader
                                Do While myreader.Read
                                    ConflictAdd = ConflictAdd + 1
                                Loop
                                myconn.Close()
                                SQLString = "Select yearlevelschedulekey As conflict from tblYearLevelSchedule,tblStudentSubjects,tblStudentYear " & _
                  " WHERE sched_starttime<='" & BackSubjectStartTime.Item(k).ToString & "'" & _
                  " AND sched_endtime>='" & BackSubjectEndTime.Item(k).ToString & "'" & _
                   " AND sched_day='" & BackSubjectDay.Item(k) & "'" & _
                    " AND tblStudentSubjects.subjectcode=tblYearLevelSchedule.subjectcode" & _
                    " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                    " AND schoolyearid='" & SYID & "'" & _
                   " GROUP BY tblStudentSubjects.subjectcode"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQLString
                                myreader = mycommand.ExecuteReader
                                Do While myreader.Read
                                    ConflictAdd = ConflictAdd + 1
                                Loop
                                myconn.Close()
                            Next
                            BackSubjectConflict.Add(ConflictAdd)
                        Next
                    Next
                    FailedSubjectDataGridView.Rows.Clear()
                    If BackSubject.Count > 0 Then
                        For m = 0 To BackSubject.Count - 1
                            ''''''''Dynamic Buttons that 
                            Dim n As Integer = FailedSubjectDataGridView.Rows.Add()
                            FailedSubjectDataGridView.Rows.Item(n).Cells(0).Value = BackSubject.Item(m)
                            FailedSubjectDataGridView.Rows.Item(n).Cells(1).Value = Grade.Item(m)
                            If BackSubjectConflict.Item(m) > 0 Then
                                FailedSubjectDataGridView.Rows.Item(n).Cells(2).Value = BackSubjectConflict.Item(m)
                                FailedSubjectDataGridView.Rows.Item(n).Cells(3).Value = "Conflict"
                                FailedSubjectDataGridView.Rows(n).DefaultCellStyle.BackColor = Color.Red
                                FailedSubjectDataGridView.Rows(n).ReadOnly = True
                            Else
                                FailedSubjectDataGridView.Rows.Item(n).Cells(2).Value = BackSubjectConflict.Item(m)
                                FailedSubjectDataGridView.Rows.Item(n).Cells(3).Value = "Add"
                            End If
                        Next
                    End If
                End If
                ''''''Schedule
                ListOfSchedulesListView.Items.Clear()
                SQLString = "Select sub_code,GROUP_CONCAT(distinct sched_day ORDER BY schedorder) As sched_day,sched_starttime,sched_endtime,Concat(tea_lname ,tea_fname) As teacher,room_name from tblYearLevelSchedule,tblTeachers,tblRooms,tblSubjects,tblStudentYear,tblStudentSubjects,tblStudentSections" & _
                         " where tblStudentSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                         " tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear AND" & _
                         " tblYearLevelSchedule.yearlevelsectioncode=tblStudentSections.yearlevelsectioncode AND" & _
                        " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear AND" & _
                        " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                        " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                        " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                        " AND tblStudentYear.studentid='" & StudentNoAssessTextBox.Text & "'" & _
                        " AND schoolyeartype='" & SYType & "'" & _
                        " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                        " GROUP BY tblSubjects.subjectcode" & _
                        " ORDER BY sched_day,sched_starttime ASC"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSubjects
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        ' SubjectAssess.Add(myreader("sub_code").ToString)

                        'ListOfSchedulesListView.Items.Add(myreader("sub_code").ToString)
                        'ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("sched_day").ToString)
                        'ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString))
                        'ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("teacher").ToString)
                        'ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                DataGridView1.Rows.Clear()
                SQLString = "Select sub_code,GROUP_CONCAT(distinct sched_day ORDER BY schedorder) As sched_day,sched_starttime,sched_endtime,Concat(tea_lname,', ',tea_fname,' ',tea_mname) As teacher,room_name from tblYearLevelSchedule,tblTeachers,tblRooms,tblSubjects,tblYearLevelSections,tblYearLevel" & _
                         " where tblSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                        " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                        " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                        " tblYearLevelSections.yearlevelsectioncode=tblYearLevelSchedule.yearlevelsectioncode" & _
                        " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
                        " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
                        " AND sectioncode='" & SectionAssessTextBox.Text & "'" & _
                        " AND schoolyeartype='" & SYType & "'" & _
                        " GROUP BY tblSubjects.subjectcode" & _
                        " ORDER BY sched_day,sched_starttime ASC"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        'SubjectAssess.Add(myreader("sub_code").ToString)
                        Dim n As Integer = DataGridView1.Rows.Add
                        DataGridView1.Rows.Item(n).Cells(0).Value = myreader("sub_code").ToString
                        DataGridView1.Rows.Item(n).Cells(1).Value = myreader("sched_day").ToString
                        DataGridView1.Rows.Item(n).Cells(2).Value = CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString)
                        DataGridView1.Rows.Item(n).Cells(3).Value = myreader("teacher").ToString
                        DataGridView1.Rows.Item(n).Cells(4).Value = myreader("room_name").ToString
                        DataGridView1.Rows.Item(n).Cells(5).Value = "---"
                        DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.Red
                        DataGridView1.Rows(n).DefaultCellStyle.BackColor = Color.LightGray
                        DataGridView1.Rows(n).Cells(5).ReadOnly = True
                        ListOfSchedulesListView.Items.Add(myreader("sub_code").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("sched_day").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString))
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("teacher").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                'shortcuta
                BackSubjectUnitList.Clear()
                BackSubjectCodeList.Clear()
                BackSubjectCost.Clear()
                BackSubjectComboBox.Items.Clear()
                BackSubjectComboBox.Text = ""
                BackSubjectListView.Items.Clear()
                UnitTextBox.Text = ""
                CostTextBox.Text = ""
                TotalBackSubjectsTextBox.Text = ""
                SQLString = "Select tblSubjects.subjectcode As subjectcode,sub_code,unit from tblSubjects,tblStudentSubjects,tblStudentYear" & _
                       " where tblStudentYear.studentschoolyear='" & SYID & StudentNoAssessTextBox.Text & "'" & _
                       " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
                      " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
                      " AND subjectstatus='Failed'" & _
                      " GROUP BY tblSubjects.subjectcode"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        BackSubjectComboBox.Items.Add(myreader("sub_code").ToString)
                        BackSubjectCodeList.Add(myreader("subjectcode").ToString)
                        BackSubjectUnitList.Add(CDec(myreader("unit").ToString))
                        BackSubjectCost.Add(0)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
                TotalBackSubjectsTextBox.Text = BackSubjectCodeList.Count.ToString
                CategoryAssessTextBox.Text = ""
                If BackSubjectCodeList.Count > 0 Then
                    CategoryAssessTextBox.Text = "Irregular"
                Else
                    CategoryAssessTextBox.Text = "Regular"
                End If
                SQLString = "Select sub_code,GROUP_CONCAT(distinct sched_day ORDER BY schedorder) As sched_day,sched_starttime,sched_endtime,Concat(tea_lname,', ',tea_fname,' ',tea_mname) As teacher,room_name from tblYearLevelSchedule,tblTeachers,tblRooms,tblSubjects,tblYearLevelSections,tblYearLevel,tblStudentSubjects" & _
                        " where tblSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                       " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                       " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                       " tblYearLevelSections.yearlevelsectioncode=tblYearLevelSchedule.yearlevelsectioncode" & _
                       " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
                       " AND schoolyeartype='" & SYType & "'" & _
                       " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
                       " AND subjectstatus='Failed'" & _
                       " GROUP BY tblSubjects.subjectcode" & _
                       " ORDER BY sched_day,sched_starttime ASC"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        'Dim n As Integer = DataGridView1.Rows.Add
                        'DataGridView1.Rows.Item(n).Cells(0).Value = myreader("sub_code").ToString
                        'DataGridView1.Rows.Item(n).Cells(1).Value = myreader("sched_day").ToString
                        'DataGridView1.Rows.Item(n).Cells(2).Value = CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString)
                        'DataGridView1.Rows.Item(n).Cells(3).Value = myreader("teacher").ToString
                        'DataGridView1.Rows.Item(n).Cells(4).Value = myreader("room_name").ToString
                        'DataGridView1.Rows.Item(n).Cells(5).Value = "Delete"
                        ListOfSchedulesListView.Items.Add(myreader("sub_code").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("sched_day").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString))
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("teacher").ToString)
                        ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    myconn.Close()
                End Try
                TuitionNameList.Clear()
                TuitionAmountAssess.Clear()
                ComputerAmountAssess.Clear()
                TuitionAmountPaidAssess = 0
                ComputerAmountPaidAssess = 0
                TuitionDateAssess.Clear()
                SQLString = "Select fee_name,fee_amount,fee_paymentdate  FROM tblYearLevelFee,tblYearLevel" & _
                " WHERE fee_category ='Tuition'  AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
           " AND schoolyeartype='" & SYType & "'" & _
                " ORDER BY fee_paymentdate"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        TuitionNameList.Add(myreader("fee_name").ToString)
                        TuitionAmountAssess.Add(CDec(myreader("fee_amount")))
                        TuitionDateAssess.Add(CDate(myreader.GetDateTime("fee_paymentdate")))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records foundaaa." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                SQLString = "Select fee_amount  FROM tblYearLevelFee,tblYearLevel" & _
                " WHERE fee_category ='Computer Fee'  AND tblYearLevelFee.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND yearlevelname='" & YearLevelAssessTextBox.Text & "'" & _
           " AND schoolyeartype='" & SYType & "'" & _
                " ORDER BY fee_paymentdate"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        ComputerAmountAssess.Add(CDec(myreader("fee_amount")))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records foundaaa." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MessageBox.Show("No records found.")
                    'myconn.Close()
                End Try
                SQLString = "Select SUM(amountpaid) As amount FROM tblStudentTransactions,tblTransactions,tblStudentYear" & _
               " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
               " AND balancecategory ='Tuition' AND tblStudentTransactions.studentschoolyear='" & SYID & StudentSearch & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        TuitionAmountPaidAssess = CDec(myreader("amount"))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    TuitionAmountPaidAssess = 0
                    myconn.Close()
                End Try
                SQLString = "Select SUM(amountpaid) As amount FROM tblStudentTransactions,tblStudentYear,tblTransactions" & _
               " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear AND tblStudentTransactions.studentfee=tblTransactions.studentfee" & _
               " AND balancecategory ='Computer Fee' AND tblStudentYear.studentid='" & StudentSearch & "'" & _
               " AND schoolyearid='" & SYID & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        ComputerAmountPaidAssess = CDec(myreader("amount"))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    ComputerAmountPaidAssess = 0
                    myconn.Close()
                End Try
                If PaymentMode = "Full Payment" Then
                    FullButton.Checked = True
                    ReservationRadioButton.Enabled = False
                    PaymentModeGroupBox.Enabled = True
                ElseIf PaymentMode = "Partial Payment" Then
                    PartialRadioButton.Checked = True
                    ReservationRadioButton.Enabled = False
                    PaymentModeGroupBox.Enabled = True
                ElseIf PaymentMode = "For Reservation" Then
                    ReservationRadioButton.Checked = True
                    ReservationRadioButton.Enabled = False
                    PaymentModeGroupBox.Enabled = True
                    SQLString = "SELECT fee_amount from tblYearLevelfee where fee_name='Reservation Fee'" & _
           " AND schoolyeartype='" & SYType & "'"

                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        reservationfee = CDec((myreader("fee_amount").ToString))
                    Loop
                    myconn.Close()
                    If reservationfee > TuitionAmountPaidAssess Then
                        If TuitionAmountPaidAssess > reservationfee Then
                            OthersAssessListView.Items(0).SubItems(1).Text = String.Format("{0:" + "P" + "#,##0.00}", 0)
                        Else
                            OthersAssessListView.Items(0).SubItems(1).Text = String.Format("{0:" + "P" + "#,##0.00}", reservationfee - TuitionAmountPaidAssess)
                        End If

                        PartialRadioButton.Enabled = False
                        FullButton.Enabled = False
                    Else
                        PartialRadioButton.Enabled = True
                        FullButton.Enabled = True
                    End If
                ElseIf StudentSearch IsNot "" Then
                    PaymentModeGroupBox.Enabled = True
                    PartialRadioButton.Checked = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub FailedSubjectDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FailedSubjectDataGridView.CellClick
        Try
            If e.ColumnIndex = 3 Then
                If FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "Conflict" Then
                    MessageBox.Show("There other subjects conflicting to the specified failed subject.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "Add" Then
                Dim unitcost As Decimal
                Dim SQLSubjects As String = "Select fee_amount from tblYearLevel where fee_name='Unit Cost'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSubjects
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        ListOfSchedulesListView.Items.Add(myreader("sub_code").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Dim result As Integer = MessageBox.Show("Are you sure you want to add specified failed subject to current subjects of the student? It will cost: P " & unitcost.ToString, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    For i = 0 To BackSubject.Count - 1
                        If BackSubject.Item(i) = FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString Then
                            BackSubjectAdded.Item(i) = 1
                        End If
                    Next
                    OtherNameList.Add(FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString & " Fee")
                    OtherAmountAssess.Add(unitcost)
                    OthersAssessListView.Items.Add(FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString)
                    OthersAssessListView.Items(OthersAssessListView.Items.Count - 1).SubItems.Add(String.Format("{0:" + "P" + "#,##0.00}", 200))
                    SQLString = "Select sub_code,GROUP_CONCAT(distinct sched_day ORDER BY schedorder) As sched_day,sched_starttime,sched_endtime,Concat(tea_lname ,tea_fname) As teacher,room_name from tblYearLevelSchedule,tblTeachers,tblRooms,tblSubjects,tblStudentYear,tblStudentSubjects,tblStudentSections" & _
                             " where tblStudentSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                             " tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear AND" & _
                             " tblYearLevelSchedule.yearlevelsectioncode=tblStudentSections.yearlevelsectioncode AND" & _
                            " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear AND" & _
                            " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                            " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                            " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                            " AND tblStudentYear.studentid='" & StudentNoAssessTextBox.Text & "'" & _
                            " AND schoolyeartype='" & SYType & "'" & _
                            " AND sub_code='" & FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString & "'" & _
                            " ORDER BY sched_day,sched_starttime ASC"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            'SubjectAssess.Add(myreader("sub_code").ToString)
                            ListOfSchedulesListView.Items.Add(myreader("sub_code").ToString)
                            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("sched_day").ToString)
                            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString))
                            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("teacher").ToString)
                            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                    FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value = "Remove"
                End If
            ElseIf FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "Remove" Then
                Dim result As Integer = MessageBox.Show("Are you sure you want to remove specified failed subject to current subjects of the student?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    For i = 0 To OtherNameList.Count - 1
                        If OtherNameList.Item(i) = FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString Then
                            OtherNameList.RemoveAt(i)
                            OtherAmountAssess.RemoveAt(i)
                        End If
                    Next
                    For i = 0 To BackSubject.Count - 1
                        If BackSubject.Item(i) = FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString Then
                            BackSubjectAdded.Item(i) = 0
                        End If
                    Next
                    For i = 0 To OthersAssessListView.Items.Count - 1
                        If OthersAssessListView.Items(i).SubItems(0).Text = FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString Then
                            OthersAssessListView.Items(i).Remove()
                        End If
                    Next
                    For i = 0 To ListOfSchedulesListView.Items.Count - 1
                        If ListOfSchedulesListView.Items(i).SubItems(0).Text = FailedSubjectDataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString Then
                            ListOfSchedulesListView.Items(i).Remove()
                        End If
                    Next

                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub SearchPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPictureBox.Click
        If GroupBoxShow = 1 Then
            If StudentSearch = "" Then
                StudentRegistrationClearAll()
            Else
                ViewStudent()
            End If
        ElseIf GroupBoxShow = 2 Then
            AssessStartup()
        ElseIf GroupBoxShow = 3 Then
            ViewFees()
        ElseIf GroupBoxShow = 4 Then
            SearchStudNameTextBox.Text = ""
            SubjectComboBox.Enabled = False
            SubjectComboBox.Items.Clear()
            SubjectComboBox.Text = ""
            SectionRecordComboBox.Items.Clear()
            SectionRecordComboBox.Text = ""
            YearRecordComboBox.Items.Clear()
            YearRecordComboBox.Text = ""
            SQLString = "SELECT yearlevelname " & "FROM tblYearLevel WHERE implemented='True'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    YearRecordComboBox.Items.Add(myreader("yearlevelname").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            RecordsPaging()
            ViewRecords()
        End If
    End Sub
    Private Sub IncludePaymentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncludePaymentComboBox.SelectedIndexChanged
        TuitionDataGridView.SendToBack()
        ComputerFeeGroupBox.SendToBack()
        OtherFeesGroupBox.SendToBack()
        MiscellaneousFeeGroupBox.SendToBack()
        If IncludePaymentComboBox.Text = "Miscellaneous Fees" Then 'And MiscellaneousBalancePayment > 0 Then
            MiscellaneousFeeGroupBox.BringToFront()
        ElseIf IncludePaymentComboBox.Text = "Tuition Fees" Then 'And TuitionBalancePayment > 0 Then
            TuitionFeeGroupBox.BringToFront()
        ElseIf IncludePaymentComboBox.Text = "Computer Fees" Then 'And ComputerBalancePayment > 0 Then
            ComputerFeeGroupBox.BringToFront()
        ElseIf IncludePaymentComboBox.Text = "Other Fees" Then 'And OtherBalancePayment > 0 Then
            OtherFeesGroupBox.BringToFront()
        End If
    End Sub
    Private Sub RecordsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RecordsLinkLabel.LinkClicked
        LinkRecords()
    End Sub
    Private Sub LinkRecords()
        IndicatorLabel.Text = "Records"
        SearchStudNameTextBox.Text = ""
        StudentSearch = ""
        GroupBoxShow = 4
        TransactionComboBox.Items.Clear()
        TransactionComboBox.Items.Add("Student Records")
        TransactionComboBox.Items.Add("Student Grades")
        TransactionComboBox.Items.Add("Balance Records")
        TransactionComboBox.Items.Add("Payments Records")
        TransactionComboBox.Items.Add("DEPED Reports")
        TransactionComboBox.Text = "Student Records"
        TransactionComboBox.Enabled = True
        SearchStudNameTextBox.Enabled = True
        SearchPictureBox.Enabled = True
        RecordsGroupBox.Visible = True
        RecordsGroupBox.BringToFront()
        IndicatorLabel.BringToFront()
        ViewRecords()
    End Sub
    Dim PageFrom As Integer
    Dim PageTo As Integer
    Dim PageAdd As Integer
    Dim Pages As Integer
    Public Sub RecordsPaging()
        PageFrom = 1
        PageTo = 0
        PageAdd = 0
        Pages = 0

        If TransactionComboBox.Text = "Student Records" And StudentSearch IsNot String.Empty Then
            SQLString = " Select COUNT(tblStudents.studentid)As pages FROM tblStudentYear,tblStudents" & _
              " where tblStudents.studentid=tblStudentYear.studentid " & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
              " AND tblStudentYear.studentid='" & StudentSearch & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundb." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf TransactionComboBox.Text = "Student Records" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentYear,tblStudents" & _
              " where tblStudents.studentid=tblStudentYear.studentid " & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundb." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Records" And SectionRecordComboBox.Text = "" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
                  " where tblStudents.studentid=tblStudentYear.studentid " & _
                  " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
                " GROUP BY tblStudents.studentid" & _
                  " ORDER BY st_lname,st_fname,st_mname"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf TransactionComboBox.Text = "Student Records" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentSections,tblStudentYearLevel,tblYearLevel,tblYearLevelSections,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " ORDER BY st_lname,st_fname,st_mname"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundd." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf TransactionComboBox.Text = "Student Grades" And StudentSearch IsNot String.Empty Then

            Dim SQLSubjects As String = "Select COunt(tblStudentSubjects.subjectcode) As pages from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                    " WHERE tblSubjects.subjectcode=tblStudentSubjects.subjectcode AND" & _
                   " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                   " AND studentid='" & StudentSearch & "'" & _
                   " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                   " GROUP BY tblStudentSubjects.subjectcode"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSubjects
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then
            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC "
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
             " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC "
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SubjectComboBox.Text = "" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
            " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
             " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC "
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SectionRecordComboBox.Text = "" Then

            SQLString = " Select COUNT(tblStudents.studentid) AS pages FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " ORDER BY st_lname,st_fname,st_mname"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" Then

            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentSections,tblStudentYearLevel,tblYearLevel,tblYearLevelSections,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
             " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " ORDER BY st_lname,st_fname,st_mname"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" Then

            SQLString = "SELECT COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Bal_Err1." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Balance Records" And StudentSearch IsNot String.Empty Then
            SQLString = "SELECT COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND tblStudents.Studentid='" & StudentSearch & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            StudentSearch = ""
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text IsNot String.Empty And SectionRecordComboBox.Text = "" Then
            SQLString = "SELECT COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text IsNot String.Empty And SectionRecordComboBox.Text IsNot String.Empty Then
            SQLString = "SELECT COUNT(tblStudents.studentid) As pages FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
    " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf YearRecordComboBox.Text = "" And TransactionComboBox.Text = "Payments Records" Then
            SQLString = " Select COUNT(tblStudents.studentid) As pages FROM tblStudentTransactions,tblTransactions,tblStudentYear,tblStudents" & _
            " where tblStudentTransactions.studentfee = tblTransactions.studentfee " & _
            " AND tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
            " AND transacno !='NULL' " & _
            " AND tblStudents.studentid='" & StudentSearch & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " ORDER BY dateofpayment DESC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Pages = CInt(myreader("pages"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        PageFromTextBox.Text = PageFrom.ToString
        PageTo = CInt(Math.Ceiling(Pages / 29))
        If PageTo = 0 Then
            PageTo = 1
        End If
        PageToLabel.Text = PageTo.ToString
    End Sub
    Public Sub ViewRecords()
        ReportName = ""
        DepedReportLabel.Visible = False
        DepedReportGroupBox.Visible = False

        RecordsDataGridView.Rows.Clear()
        RecordsDataGridView.Columns.Clear()
        If TransactionComboBox.Text = "Student Records" And StudentSearch IsNot String.Empty Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Year & Section"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid As studentid ,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus FROM tblStudentYear,tblStudents" & _
              " where tblStudents.studentid=tblStudentYear.studentid " & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
              " AND tblStudentYear.studentid='" & StudentSearch & "'" & _
              " AND studentstatus='Enrolled'" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundb." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim year As String = ""
            SQLString = " Select yearlevelname As year FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
              " where tblStudents.studentid=tblStudentYear.studentid " & _
              " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
              " AND tblYearLevel.yearlevelcode= tblStudentYearLevel.yearlevelcode" & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
              " AND tblStudentYear.studentid='" & StudentSearch & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    year = myreader("year").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Year." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            SQLString = " Select sectioncode FROM tblStudentSections,tblYearLevelSections,tblStudentYear" & _
              " where  tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
              " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
              " AND tblStudentYear.studentid='" & StudentSearch & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    year = year & " " & myreader("sectioncode").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records founda." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                RecordsDataGridView.Rows.Item(0).Cells(2).Value = year
            Catch
            End Try
            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Action"
            btn.Text = "Show Records"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            RecordsDataGridView.Columns.Add(btn)
            StudentSearch = ""
        ElseIf TransactionComboBox.Text = "Student Records" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Year & Section"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus FROM tblStudentYear,tblStudents" & _
              " where tblStudents.studentid=tblStudentYear.studentid " & _
              " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
              " AND studentstatus='Enrolled'" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundb." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim year As String = ""
            For i = 0 To RecordsDataGridView.Rows.Count - 1
                SQLString = " Select yearlevelname As year FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
                  " where tblStudents.studentid=tblStudentYear.studentid " & _
                  " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                  " AND tblYearLevel.yearlevelcode= tblStudentYearLevel.yearlevelcode" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND tblStudentYear.studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        year = myreader("year").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records founda." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                SQLString = " Select sectioncode FROM tblStudentSections,tblYearLevelSections,tblStudentYear" & _
                  " where tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                  " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND tblStudentYear.studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        year = year & " " & myreader("sectioncode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records founda." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                RecordsDataGridView.Rows.Item(i).Cells(2).Value = year
            Next
            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Action"
            btn.Text = "Show Records"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            RecordsDataGridView.Columns.Add(btn)
        ElseIf TransactionComboBox.Text = "Student Records" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Section"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next

            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
                  " where tblStudents.studentid=tblStudentYear.studentid " & _
                  " AND tblStudentYearLevel.yearlevelcode=tblYearLevel.yearlevelcode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
              " AND studentstatus='Enrolled'" & _
                " GROUP BY tblStudents.studentid" & _
                  " ORDER BY st_lname,st_fname,st_mname" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            For i = 0 To RecordsDataGridView.Rows.Count - 1
                Dim year As String = ""
                SQLString = " Select sectioncode FROM tblStudentSections,tblYearLevelSections,tblStudentYear" & _
                  " where tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                  " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND tblStudentYear.studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        year = myreader("sectioncode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records founda." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                RecordsDataGridView.Rows.Item(i).Cells(2).Value = year
            Next
            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Action"
            btn.Text = "Show Records"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            RecordsDataGridView.Columns.Add(btn)
        ElseIf TransactionComboBox.Text = "Student Records" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus FROM tblStudentSections,tblStudentYearLevel,tblYearLevel,tblYearLevelSections,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
              " AND studentstatus='Enrolled'" & _
            " ORDER BY st_lname,st_fname,st_mname" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundd." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Action"
            btn.Text = "Show Records"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            RecordsDataGridView.Columns.Add(btn)
        ElseIf TransactionComboBox.Text = "Student Records" Then
            Dim TotalRecord As Integer = 0
            Dim RecordsArray As String() = {"Student ID", "Name"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,studentstatus FROM tblStudentSections,tblStudentYearLevel,tblYearLevel,tblYearLevelSections,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " AND st_gender='" & SubjectComboBox.Text & "'" & _
              " AND studentstatus='Enrolled'" & _
            " ORDER BY st_lname,st_fname,st_mname" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TotalRecord = TotalRecord + 1
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundd." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim btn As New DataGridViewButtonColumn
            btn.HeaderText = "Action"
            btn.Text = "Show Records"
            btn.Name = "btn"
            btn.UseColumnTextForButtonValue = True
            RecordsDataGridView.Columns.Add(btn)
        ElseIf TransactionComboBox.Text = "Student Grades" And StudentSearch IsNot String.Empty Then
            ReportName = StudentSearch
            Dim coln As New DataGridViewTextBoxColumn
            coln.HeaderText = "Subject"
            coln.Name = "Subject"
            RecordsDataGridView.Columns.Add(coln)
            Dim RecordSubjectCode As New List(Of String)
            Dim SQLSubjects As String = "Select tblStudentSubjects.subjectcode As subjectcode,sub_code from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                    " WHERE tblSubjects.subjectcode=tblStudentSubjects.subjectcode AND" & _
                   " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                   " AND studentid='" & StudentSearch & "'" & _
                   " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                   " GROUP BY tblStudentSubjects.subjectcode" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSubjects
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add()
                    RecordSubjectCode.Add(myreader("subjectcode").ToString)
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("sub_code").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            SQLString = "Select gradingname from tblGradings" & _
                  " WHERE schoolyearid='" & SYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim col As New DataGridViewTextBoxColumn
                    col.HeaderText = myreader("gradingname").ToString
                    col.Name = myreader("gradingname").ToString
                    RecordsDataGridView.Columns.Add(col)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            For i = 0 To RecordsDataGridView.Rows.Count - 1
                For j = 1 To RecordsDataGridView.Columns.Count - 1
                    SQLString = "Select gradingname,grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                      " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                      " AND studentid='" & StudentSearch & "'" & _
                      " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                      " AND tblStudentSubjects.subjectcode='" & RecordSubjectCode.Item(i) & "'" & _
                      " AND gradingname='" & RecordsDataGridView.Columns(j).HeaderText & "'" & _
                      " GROUP BY gradingname"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            RecordsDataGridView.Rows.Item(i).Cells(j).Value = myreader("grade").ToString
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
            Next
            StudentSearch = ""
        ElseIf TransactionComboBox.Text = "Student Grades" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Grade Average"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,AVG(grade) As grade FROM tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC " & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("grade").ToString

                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SectionRecordComboBox.Text = "" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Year & Section", "Grade Average"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,CONCAT(yearlevelname,' ',sectioncode) As year,ROUND(AVG(grade),2) As grade FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
             " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC " & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("year").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(3).Value = myreader("grade").ToString

                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SubjectComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Grade Average"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,ROUND(AVG(grade),2) As grade FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
            " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
            " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
             " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY tblStudents.studentid" & _
            " ORDER BY grade DESC " & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("grade").ToString

                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Grades" And SectionRecordComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name FROM tblStudentYearLevel,tblYearLevel,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " ORDER BY st_lname,st_fname,st_mname" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            SQLString = "Select gradingname from tblGradings" & _
                  " WHERE schoolyearid='" & SYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim col As New DataGridViewTextBoxColumn
                    col.HeaderText = myreader("gradingname").ToString
                    col.Name = myreader("gradingname").ToString
                    RecordsDataGridView.Columns.Add(col)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            For i = 0 To RecordsDataGridView.Rows.Count - 1
                For j = 2 To RecordsDataGridView.Columns.Count - 1
                    SQLString = "Select grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                      " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                      " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                      " AND studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                      " AND sub_code='" & SubjectComboBox.Text & "'" & _
                        " AND gradingname='" & RecordsDataGridView.Columns(j).HeaderText & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            RecordsDataGridView.Rows.Item(i).Cells(j).Value = myreader("grade").ToString
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
            Next
        ElseIf TransactionComboBox.Text = "Student Grades" Then
            Dim RecordsArray As String() = {"Student ID", "Name"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name FROM tblStudentSections,tblStudentYearLevel,tblYearLevel,tblYearLevelSections,tblStudentYear,tblStudents" & _
            " where tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
             " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
            " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
            " ORDER BY st_lname,st_fname,st_mname" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            SQLString = "Select gradingname from tblGradings" & _
                  " WHERE schoolyearid='" & SYID & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim col As New DataGridViewTextBoxColumn
                    col.HeaderText = myreader("gradingname").ToString
                    col.Name = myreader("gradingname").ToString
                    RecordsDataGridView.Columns.Add(col)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Dim colg As New DataGridViewTextBoxColumn
            colg.HeaderText = "Grade Average"
            colg.Name = "Grade Average"
            RecordsDataGridView.Columns.Add(colg)
            For i = 0 To RecordsDataGridView.Rows.Count - 1
                For j = 2 To RecordsDataGridView.Columns.Count - 1
                    SQLString = "Select grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                      " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                      " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                      " AND studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                      " AND sub_code='" & SubjectComboBox.Text & "'" & _
                        " AND gradingname='" & RecordsDataGridView.Columns(j).HeaderText & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            RecordsDataGridView.Rows.Item(i).Cells(j).Value = myreader("grade").ToString
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLString = "Select ROUND(AVG(grade),2) As grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
                      " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                      " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                      " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                      " AND studentid='" & RecordsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                      " AND sub_code='" & SubjectComboBox.Text & "'" & _
                        " GROUP BY tblStudentYear.studentschoolyear"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            RecordsDataGridView.Rows.Item(i).Cells(RecordsDataGridView.Columns.Count - 1).Value = myreader("grade").ToString
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DBBBD.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
            Next
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text = "" And SectionRecordComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Year & Section", "Balance"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = "SELECT tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,Concat(yearlevelname,' ',sectioncode) As year,SUM(Balance) As balance" & " FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("year").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(3).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("balance"))
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Bal_Err1." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Balance Records" And StudentSearch IsNot String.Empty Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Year & Section", "Balance"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = "SELECT tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,Concat(yearlevelname,' ',sectioncode) As year,SUM(Balance) As balance" & " FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND tblStudents.Studentid='" & StudentSearch & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("year").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(3).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            StudentSearch = ""
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text IsNot String.Empty And SectionRecordComboBox.Text = "" Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Section", "Balance"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = "SELECT tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,sectioncode As year,SUM(Balance) As balance" & " FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("year").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(3).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Balance Records" And YearRecordComboBox.Text IsNot String.Empty And SectionRecordComboBox.Text IsNot String.Empty Then
            Dim RecordsArray As String() = {"Student ID", "Name", "Balance"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = "SELECT tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,SUM(Balance) As balance" & " FROM tblYearLevelSections,tblStudentSections,tblYearLevel,tblStudents,tblStudentTransactions,tblStudentYear" & _
    " WHERE tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
    " AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear" & _
    " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
    " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
    " AND schoolyearid='" & SYID & "'" & _
    " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
    " AND sectioncode='" & SectionRecordComboBox.Text & "'" & _
    "  AND balancecategory !='Other Fees'" & _
    " AND tblStudents.studentid=tblStudentYear.studentid" & _
    " GROUP BY tblStudents.studentid" & _
    " ORDER BY balance ASC" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf YearRecordComboBox.Text = "" And TransactionComboBox.Text = "Payments Records" Then
            YearRecordComboBox.Enabled = False
            SectionRecordComboBox.Enabled = False
            Dim RecordsArray As String() = {"OR #", "Particulars", "Date Paid", "Amount Paid"}
            For i = 0 To RecordsArray.Count - 1
                Dim coln As New DataGridViewTextBoxColumn
                coln.HeaderText = RecordsArray(i)
                coln.Name = RecordsArray(i).Trim
                RecordsDataGridView.Columns.Add(coln)
            Next
            SQLString = " Select transacno,tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,GROUP_CONCAT(balancename) As balancename,dateofpayment,SUM(amountpaid) As amountpaid FROM tblStudentTransactions,tblTransactions,tblStudentYear,tblStudents" & _
            " where tblStudentTransactions.studentfee = tblTransactions.studentfee " & _
            " AND tblStudents.studentid=tblStudentYear.studentid " & _
            " AND tblStudentYear.studentschoolyear=tblStudentTransactions.studentschoolyear" & _
            " AND transacno !='NULL' " & _
            " AND tblStudents.studentid='" & StudentSearch & "'" & _
            " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " GROUP BY transacno" & _
            " ORDER BY dateofpayment DESC" & _
              " LIMIT " & PageAdd & ",29"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Dim n As Integer = RecordsDataGridView.Rows.Add
                    RecordsDataGridView.Rows.Item(n).Cells(0).Value = "#" & myreader("transacno").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(1).Value = myreader("balancename").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(2).Value = myreader("dateofpayment").ToString
                    RecordsDataGridView.Rows.Item(n).Cells(3).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("amountpaid"))
                    ' RecordsDataGridView.Rows.Item(n).Cells(4).Value = String.Format("{0:" + "P " + "#,##0.00}", myreader("balance"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "DEPED Reports" Then
            'shorta
            DepedReportLabel.Visible = True
            DepedReportGroupBox.Visible = True
        End If
    End Sub
    Private Sub ChangeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AmountTendered()
    End Sub
    Private Sub YearRecordComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearRecordComboBox.SelectedIndexChanged
        SectionRecordComboBox.Items.Clear()
        SectionRecordComboBox.Text = ""
        SQLString = "SELECT sectioncode from tblYearLevel,tblYearLevelSections" & _
          " where tblYearLevelSections.yearlevelcode = tblYearLevel.yearlevelcode" & _
          " AND yearlevelname='" & YearRecordComboBox.Text & "'"
        Try

            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SectionRecordComboBox.Items.Add(myreader("sectioncode").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If TransactionComboBox.Text = "Student Grades" Then
            SubjectLabel.Text = "Subject:"
            SubjectComboBox.Items.Clear()
            SubjectComboBox.Text = ""
            SubjectComboBox.Enabled = True
            SQLString = "SELECT sub_code from tblYearLevel,tblYearLevelSections,tblSubjects,tblYearLevelSubjects" & _
        " where tblYearLevelSections.yearlevelcode = tblYearLevel.yearlevelcode" & _
        " AND tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode" & _
        " AND tblYearLevel.yearlevelcode =tblYearLevelSubjects.yearlevelcode" & _
        " AND yearlevelname='" & YearRecordComboBox.Text & "'" & _
        " GROUP BY sub_code"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    SubjectComboBox.Items.Add(myreader("sub_code").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf TransactionComboBox.Text = "Student Records" Then
            SubjectLabel.Text = "Gender:"
            SubjectComboBox.Items.Clear()
            SubjectComboBox.Text = ""
            SubjectComboBox.Items.Add("Male")
            SubjectComboBox.Items.Add("Female")
            SubjectComboBox.Enabled = True
        Else
            SubjectComboBox.Enabled = False
        End If
        RecordsPaging()
        ViewRecords()
    End Sub

    Private Sub SectionRecordComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionRecordComboBox.SelectedIndexChanged
        RecordsPaging()
        ViewRecords()
    End Sub

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        RecordsPaging()
        ViewRecords()
    End Sub
    Public StudentRecord As String
    Private Sub RecordsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecordsDataGridView.CellContentClick
        Try
            Dim n As String = RecordsDataGridView.CurrentCell.Value.ToString
            Dim y As Integer = RecordsDataGridView.CurrentCellAddress.Y
            If n = "Show Records" Then
                StudentRecord = RecordsDataGridView.Rows.Item(y).Cells(0).Value.ToString
                Records.Show()
            End If
        Catch
        End Try
    End Sub

    Private Sub ReligionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReligionComboBox.SelectedIndexChanged
        If ReligionComboBox.Text = "Adventist" Then
            'ReligionComboBox.Items.Clear()

            'ReligionComboBox.TabStop = True
            'ReligionComboBox.Items.Add("Adventist")
            'ReligionComboBox.Items.Add("Other: Specify")
            For i = 0 To DiscountRegistrationListView.Items.Count - 1
                If DiscountRegistrationListView.Items(i).SubItems(0).Text = "Adventist" Then
                    DiscountRegistrationListView.Items(i).Checked = True
                End If
            Next
        Else
            ReligionComboBox.Text = ""
            For i = 0 To DiscountRegistrationListView.Items.Count - 1
                If DiscountRegistrationListView.Items(i).SubItems(0).Text = "Adventist" Then
                    DiscountRegistrationListView.Items(i).Checked = False
                End If
            Next
        End If
    End Sub

    Private Sub DiscountRegistrationListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountRegistrationListView.ItemChecked
        For i = 0 To DiscountRegistrationListView.Items.Count - 1
            'If DiscountRegistrationListView.Items(i).Focused Then
            If DiscountRegistrationListView.Items(i).SubItems(0).Text = "Adventist" Then
                If ReligionComboBox.SelectedIndex = 0 Then
                    DiscountRegistrationListView.Items(i).Checked = True
                Else
                    DiscountRegistrationListView.Items(i).Checked = False
                End If
            End If
            'End If
        Next
    End Sub
    Private Sub DiscountAssessListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountAssessListView.ItemChecked
        For i = 0 To DiscountAssessListView.Items.Count - 1
            If DiscountAssessListView.Items(i).SubItems(0).Text = "Adventist" Then
                If StudentReligion = "Adventist" Then
                    DiscountAssessListView.Items(i).Checked = True
                Else
                    DiscountAssessListView.Items(i).Checked = False
                End If
                Exit For
            Else
                If DiscountAssessListView.Items(i).Selected = True Then
                    'For j=0 to Sub
                    'DiscountAssessListView.Items(i).SubItems(0).Text=
                End If
            End If
        Next
        DiscountTotal = 0
        Dim a As Integer = 0
        For i = 0 To DiscountAssessListView.Items.Count - 1
            If DiscountAssessListView.Items(i).Checked = True Then
                DiscountTotal = DiscountTotal + DiscountsList.Item(i)
            End If
        Next
        If DiscountTotal > 100 Then
            DiscountTotal = 100
        End If
        DiscountAssessTextBox.Text = DiscountTotal.ToString & " %"
        ViewAssess()
    End Sub
    Public OthersTotal As Decimal
    Private Sub OthersAssessListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersAssessListView.ItemChecked
        Try
            OthersTotal = 0
            If ReservationRadioButton.Checked = True Then
                For i = 0 To OtherNameList.Count - 1
                    If OtherNameList.Item(i) = "Reservation Fee" Then
                        OthersTotal = OthersTotal + OtherAmountAssess.Item(i)
                        Exit For
                    End If
                Next
            Else
                For i = 0 To OtherAmountAssess.Count - 1
                    If OthersAssessListView.Items(i).Checked = True Then
                        OthersTotal = OthersTotal + OtherAmountAssess.Item(i)
                    End If
                Next
            End If
            GrandTotal = CDec(FullTuitionBalance + FullComputerBalance + OthersTotal + MiscellaneousAssess)
            DownPaymentTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", (MiscellaneousAssess + OthersTotal) / 2)
            OthersTotalAssessTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", OthersTotal)
            GrandTotalTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", GrandTotal)
        Catch
        End Try
    End Sub

    Private Sub EditDiscountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDiscountButton.Click
        ViewDiscount()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    ''' 
    '''
    Private Sub ReportsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ReportsLinkLabel.LinkClicked
        StudentReport.Show()
    End Sub

    Private Sub ViewReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dt As New DataSet
        With dt
            '.Columns.Add("studentid")
            '.Columns.Add("studentname")
        End With
        For Each dr As DataGridViewRow In Me.RecordsDataGridView.Rows
            'dt.Rows.Add(dr.Cells("Student ID").Value, dr.Cells("Name").Value)
        Next
        myconn = New MySqlConnection
        Try
            With myconn
                If .State = ConnectionState.Open Then .Close()

                .ConnectionString = CONNECTION_STRING
                .Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            Dim StudentReport As String = "SELECT * FROM tblStudents,tblStudentYear where schoolyearid='" & SYID & "'"

            myadapter.SelectCommand = New MySqlCommand(StudentReport, myconn)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myadapter)

            myadapter.Fill(dt, "tblStudents,tblSTudentYear")
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            myconn.Close()
        End Try

        'Dim objRpt As Permit
        'objRpt.SetDataSource(dt.Tables("tblStudents"))
        'rptViewer.ReportSource = objRpt
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport2
        rptDoc.SetDataSource(dt)
        CrystalReport.CrystalReportViewer1.ReportSource = rptDoc
        CrystalReport.ShowDialog()
        CrystalReport.Dispose()
    End Sub








    Private Sub ReservationRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationRadioButton.CheckedChanged
        If ReservationRadioButton.Checked = True Then
            ViewAssess()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Maintenance.Show()
    End Sub
    Private Sub SettingsLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SettingsLinkLabel.LinkClicked
        Settings.Show()
    End Sub
    Private Sub ReserveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReserveToolStripMenuItem.Click
        Reservation.Show()
    End Sub

    Private Sub AssessmentGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessmentGroupBox.Enter

    End Sub

    Private Sub MiscellaneousDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MiscellaneousDataGridView.CellContentClick

    End Sub

    Private Sub PaymentsListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsListView.SelectedIndexChanged

    End Sub

    ''' <summary>
    ''' REGISTRATION ISNUMERIC VALIDATION
    ''' </summary>
    ''' <param name="sender"></param>

    Private Sub StudLastNameRegistrationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudLastNameRegistrationTextBox.TextChanged
        If IsNumeric(StudLastNameRegistrationTextBox.Text) = True Then
            StudLastNameRegistrationTextBox.Text = ""
        End If
    End Sub
    Private Sub StudFirstNameRegistrationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudFirstNameRegistrationTextBox.TextChanged
        If IsNumeric(StudFirstNameRegistrationTextBox.Text) = True Then
            StudFirstNameRegistrationTextBox.Text = ""
        End If
    End Sub
    Private Sub StudMiddleNameRegistrationTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudMiddleNameRegistrationTextBox.TextChanged
        If IsNumeric(StudMiddleNameRegistrationTextBox.Text) = True Then
            StudMiddleNameRegistrationTextBox.Text = ""
        End If
    End Sub
    Private Sub DiscountAssessListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountAssessListView.SelectedIndexChanged

    End Sub

    Private Sub PageFromTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFromTextBox.TextChanged
        Try
            Dim Page As Integer = CInt(PageFromTextBox.Text)
            If Page > PageTo Then
                PageFrom = PageFrom
            Else
                If Page > PageFrom Then
                    PageAdd = PageAdd + (29 * (Page - PageFrom))
                Else
                    PageAdd = PageAdd - (29 * (PageFrom - Page))
                End If
                PageFrom = Page
            End If
        Catch
            PageFrom = PageFrom
        End Try
        PageFromTextBox.Text = PageFrom.ToString
        ViewRecords()
    End Sub
    Private Sub FirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstButton.Click
        PageFrom = 1
        PageAdd = 0
        PageFromTextBox.Text = PageFrom.ToString
    End Sub
    Private Sub PrevButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevButton.Click
        If PageFrom = 1 Then
            PageFrom = 1
        Else
            PageFrom = PageFrom - 1
            PageAdd = PageAdd - 29
        End If
        PageFromTextBox.Text = PageFrom.ToString
    End Sub
    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        If PageFrom = PageTo Then
            PageFrom = PageTo
        Else
            PageFrom = PageFrom + 1
            PageAdd = PageAdd + 29
        End If
        PageFromTextBox.Text = PageFrom.ToString
    End Sub
    Private Sub LastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastButton.Click
        PageFrom = PageTo
        Dim LastPage As Integer = Pages Mod 29
        PageAdd = Pages - LastPage
        PageFromTextBox.Text = PageFrom.ToString
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to log out it?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub


    Private Sub RegistrationPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationPictureBox.Click
        LinkRegistration()
    End Sub
    Private Sub AssessmentPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessmentPictureBox.Click
        LinkAssessment()
    End Sub
    Private Sub PaymentPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentPictureBox.Click
        LinkPayment()
    End Sub
    Private Sub RecordsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordsPictureBox.Click
        LinkRecords()
    End Sub
    Private Sub ReportsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsPictureBox.Click
        StudentReport.Show()
    End Sub
    Private Sub SettingsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPictureBox.Click
        Settings.Show()
    End Sub
    Public ReportName As String
    Private Sub CreateReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateReportButton.Click
        If ReportName IsNot String.Empty Then
            ProgressAssessOrRecord = 1
            ProgressReportCard.Show()
        Else
            Report.Show()
        End If
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to backup the database of the system?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:/wamp/bin/mysql/mysql5.6.12/bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump.exe -uroot dbenrollment -r """ & FolderBrowserDialog1.SelectedPath & "\dbenrollmentbackup.sql""")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MessageBox.Show("Successfully Backup Database.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Would you like to first backup the database of the system?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            result = FolderBrowserDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:/wamp/bin/mysql/mysql5.6.12/bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump.exe -uroot dbenrollment -r """ & FolderBrowserDialog1.SelectedPath & "\dbenrollmentbackup.sql""")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MessageBox.Show("Successfully Backup Database.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            OpenFileDialog1.Filter = "(SQL File) |*.sql;*.txt;*.doc|.sql | *.sql|.txt | *.txt|.doc | *.doc" ', .Multiselect = False, .Title = "Select Image"
            result = OpenFileDialog1.ShowDialog()
            If result = DialogResult.Cancel Then
            Else
                Process.Start("C:/wamp/bin/mysql/mysql5.6.12/bin/mysql.exe", "-u root -p dbenrollment < """ & OpenFileDialog1.FileName & "")
                MessageBox.Show("Successfully Restored Database.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            result = OpenFileDialog1.ShowDialog()
            If result = DialogResult.Cancel Then
            Else
                Process.Start("C:/wamp/bin/mysql/mysql5.6.12/bin/mysql.exe", "-u root -p dbenrollment < """ & OpenFileDialog1.FileName & "")
                MessageBox.Show("Successfully Restored Database.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub StudentRegistrationGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRegistrationGroupBox.Enter

    End Sub

    Private Sub FailedSubjectDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FailedSubjectDataGridView.CellContentClick

    End Sub

    Private Sub OthersAssessListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersAssessListView.SelectedIndexChanged

    End Sub

    Private Sub YearLevelRegistrationComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelRegistrationComboBox.SelectedIndexChanged

    End Sub

    Private Sub DiscountRegistrationListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountRegistrationListView.SelectedIndexChanged

    End Sub

    Private Sub NoRepeaterRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoRepeaterRadioButton.CheckedChanged
        If NoRepeaterRadioButton.Checked = True Then
            GroupBox18.Visible = True
        End If
    End Sub

    Private Sub YesRepeaterRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesRepeaterRadioButton.CheckedChanged
        If YesRepeaterRadioButton.Checked = True Then
            GroupBox18.Visible = False
        End If
    End Sub



    Private Sub Panel3_Scroll(ByVal Sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Panel3.Scroll
        'Panel3.AutoScrollPosition = New Point(0, -Panel3.AutoScrollPosition.Y)
    End Sub
    Private Sub PaymentAssessPanel_Scroll(ByVal Sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PaymentAssessPanel.Scroll
        'PaymentAssessPanel.AutoScrollPosition = New Point(Panel3.AutoScrollPosition.X, Panel3.AutoScrollPosition.Y)
    End Sub


    Public ReportYearLevel As String
    Public ReportSection As String
    Private Sub SF1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SF1Button.Click
        ReportYearLevel = ""
        ReportSection = ""
        If YearRecordComboBox.Text = "" Or SectionRecordComboBox.Text = "" Then
            MessageBox.Show("Select a Year and Section first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ReportYearLevel = YearRecordComboBox.Text
            ReportSection = SectionRecordComboBox.Text
            SF1.Show()
        End If
    End Sub

    Private Sub SF5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SF5Button.Click
        ReportYearLevel = ""
        ReportSection = ""
        If YearRecordComboBox.Text = "" Or SectionRecordComboBox.Text = "" Then
            MessageBox.Show("Select a Year and Section first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ReportYearLevel = YearRecordComboBox.Text
            ReportSection = SectionRecordComboBox.Text
            SF2.Show()
        End If
    End Sub

    Private Sub SF6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public ProgressAssessOrRecord As Integer
    Private Sub GradeFormPrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeFormPrintButton.Click
        ProgressAssessOrRecord = 0
        ProgressReportCard.Show()
    End Sub


 
    Private Sub BackSubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackSubjectComboBox.SelectedIndexChanged
        BackSubjectListView.Items.Clear()
        BackSubjectSectionComboBox.Items.Clear()
        SQLString = "Select sectioncode from tblSubjects,tblYearLevelSections,tblYearLevelSubjects" & _
                        " where tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode" & _
                       " AND tblYearLevelSubjects.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                       " AND tblSubjects.subjectcode='" & BackSubjectCodeList.Item(BackSubjectComboBox.SelectedIndex) & "'" & _
                       " GROUP BY sectioncode"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                BackSubjectSectionComboBox.Items.Add(myreader("sectioncode").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Dim unit As Decimal
    Dim cost As Decimal
    Dim yearlevelsectioncode As String
    Private Sub BackSubjectSectionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackSubjectSectionComboBox.SelectedIndexChanged
        BackSubjectListView.Items.Clear()
        Try
            unit = 0
            cost = 0
            yearlevelsectioncode = ""
            SQLString = "Select sub_code,unit,tblYearLevelSections.yearlevelsectioncode As yearlevelsectioncode,GROUP_CONCAT(distinct sched_day ORDER BY schedorder) As sched_day,sched_starttime,sched_endtime,Concat(tea_lname,', ',tea_fname,' ',tea_mname) As teacher,room_name from tblYearLevelSchedule,tblTeachers,tblRooms,tblSubjects,tblYearLevelSections" & _
                            " where tblSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND" & _
                           " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                           " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                           " tblYearLevelSections.yearlevelsectioncode=tblYearLevelSchedule.yearlevelsectioncode" & _
                           " AND sectioncode='" & BackSubjectSectionComboBox.Text & "'" & _
                           " AND tblSubjects.subjectcode='" & BackSubjectCodeList.Item(BackSubjectComboBox.SelectedIndex) & "'" & _
                           " AND schoolyeartype='" & SYType & "'" & _
                           " GROUP BY tblSubjects.subjectcode" & _
                           " ORDER BY sched_day,sched_starttime ASC"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    unit = CDec(myreader("unit").ToString)
                    yearlevelsectioncode = (myreader("yearlevelsectioncode").ToString)
                    BackSubjectListView.Items.Add(myreader("sub_code").ToString)
                    BackSubjectListView.Items(BackSubjectListView.Items.Count - 1).SubItems.Add(myreader("sched_day").ToString)
                    BackSubjectListView.Items(BackSubjectListView.Items.Count - 1).SubItems.Add(CDate(myreader("sched_starttime").ToString) & "-" & CDate(myreader("sched_endtime").ToString))
                    BackSubjectListView.Items(BackSubjectListView.Items.Count - 1).SubItems.Add(myreader("teacher").ToString)
                    BackSubjectListView.Items(BackSubjectListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            SQLString = "Select cost from tblunits WHERE unit=" & unit & ""
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    cost = CDec(myreader("cost").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBA.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            UnitTextBox.Text = unit.ToString
            CostTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", cost)
        Catch
        End Try
    End Sub
    Dim BackSubjectSection As New List(Of String)
    Private Sub AddBackSubjectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBackSubjectButton.Click
        If BackSubjectComboBox.Text = "" Or BackSubjectSectionComboBox.Text = "" Then
            MessageBox.Show("Please select a subject and available section.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim err As Integer = 0
                Dim k As New List(Of Integer)
                For i = 0 To BackSubjectListView.Items.Count - 1
                    For j = 0 To DataGridView1.Rows.Count - 1
                        If BackSubjectListView.Items(i).SubItems(0).Text = DataGridView1.Rows.Item(j).Cells(0).Value.ToString And DataGridView1.Rows(j).Visible = True Then
                            err = 1
                        End If
                    Next
                    k.Add(i)
                Next
                If err = 0 Then
                    Dim a As Integer = BackSubjectComboBox.SelectedIndex
                    BackSubjectCost.Item(a) = cost
                    BackSubjectSection.Add(yearlevelsectioncode)
                    For i = 0 To k.Count - 1
                        For j = 0 To DataGridView1.Rows.Count - 1
                            If BackSubjectListView.Items(i).SubItems(0).Text = DataGridView1.Rows.Item(j).Cells(0).Value.ToString And DataGridView1.Rows(j).Visible = True Then
                                Exit For
                            End If
                        Next
                        Dim n As Integer = DataGridView1.Rows.Add
                        DataGridView1.Rows.Item(n).Cells(0).Value = BackSubjectListView.Items(i).SubItems(0).Text
                        DataGridView1.Rows.Item(n).Cells(1).Value = BackSubjectListView.Items(i).SubItems(1).Text
                        DataGridView1.Rows.Item(n).Cells(2).Value = BackSubjectListView.Items(i).SubItems(2).Text
                        DataGridView1.Rows.Item(n).Cells(3).Value = BackSubjectListView.Items(i).SubItems(3).Text
                        DataGridView1.Rows.Item(n).Cells(4).Value = BackSubjectListView.Items(i).SubItems(4).Text
                        DataGridView1.Rows.Item(n).Cells(5).Value = "Remove"

                    Next
                    If PartialRadioButton.Checked = True Then
                        PartialRadioButton.Checked = False
                        PartialRadioButton.Checked = True
                    ElseIf CashPaymentRadioButton.Checked = True Then
                        CashPaymentRadioButton.Checked = False
                        CashPaymentRadioButton.Checked = True
                    End If
                    BackSubjectComboBox.Text = ""
                    BackSubjectSectionComboBox.Text = ""
                    BackSubjectListView.Items.Clear()
                    MessageBox.Show("Successfully Added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Schedule has already been added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch
            End Try
        End If

    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim x As Integer = DataGridView1.CurrentCellAddress.X
            Dim y As Integer = DataGridView1.CurrentCellAddress.Y
            If x = 5 And DataGridView1.Rows(y).Cells(0).Value.ToString = "Remove" Then
                For i = 0 To BackSubjectCodeList.Count - 1
                    If BackSubject.Item(i) = DataGridView1.Rows(y).Cells(0).Value.ToString Then
                        BackSubjectSection.RemoveAt(i)
                        BackSubjectCost.Item(i) = 0
                    End If
                Next
                DataGridView1.Rows(y).Visible = False
                If PartialRadioButton.Checked = True Then
                    PartialRadioButton.Checked = False
                    PartialRadioButton.Checked = True
                ElseIf CashPaymentRadioButton.Checked = True Then
                    CashPaymentRadioButton.Checked = False
                    CashPaymentRadioButton.Checked = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub SF137GSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SF137GSButton.Click
        SF137.Show()
    End Sub

    Private Sub PaymentAssessPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles PaymentAssessPanel.Scroll
        If PaymentAssessPanel.AutoScrollPosition.Y <= -498 Then
            BackSubjectListView.Focus()
        ElseIf PaymentAssessPanel.AutoScrollPosition.Y <= -354 Then
            DataGridView1.Focus()
        ElseIf PaymentAssessPanel.AutoScrollPosition.Y <= -111 Then
            TuitionAssessListView.Focus()
        Else
            MiscellaneousAssessListView.Focus()
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Panel3.Scroll
        If Panel3.AutoScrollPosition.Y <= -182 Then
            GroupBox18.Focus()
        ElseIf Panel3.AutoScrollPosition.Y <= -50 Then
            MotherContactNoRegistrationTextBox.Focus()
        End If
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PaymentBalanceGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentBalanceGroupBox.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
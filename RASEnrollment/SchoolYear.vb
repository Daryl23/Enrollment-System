Option Strict On
Imports MySql.Data.MySqlClient
Public Class SchoolYear
    Public CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SYID As New List(Of String)
    Public CurrentSYID As String
    Dim SQLString As String
    Dim SYView As Boolean = Welcome.SYView
    Dim SYEdit As Boolean = Welcome.SYEdit
    Dim MaxSYFrom As Date
    Dim MaxSYTo As Date
    Dim MaxERFrom As Date
    Dim MaxERTo As Date
    Dim MaxSYID As String
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Dte As Date = FirstMonday(3, Date.Today.Year)
        EnrollmentPeriodFromDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(6, Date.Today.Year)
        EnrollmentPeriodToDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(6, Date.Today.Year)
        SchoolYearFromDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(3, CInt(Date.Today.Year) + 1)
        SchoolYearToDateTimePicker.Text = CStr(Dte)
        GradingsDomainUpDown.Items.Clear()
        GradingsDomainUpDown.Items.Add(0)
        GradingsDomainUpDown.Items.Add(1)
        GradingsDomainUpDown.Items.Add(2)
        GradingsDomainUpDown.Items.Add(3)
        GradingsDomainUpDown.Items.Add(4)
        GradingsDomainUpDown.Items.Add(5)
        GradingsDomainUpDown.Items.Add(6)
        ClearAll()
       
        Timer1.Interval = 1000
        Timer1.Start()
        If SYView = True Then
            OpenButton.Enabled = True
        Else
            OpenButton.Enabled = False
        End If
        If SYEdit = True Then
            EPGroupBox.Enabled = True
            SYGroupBox.Enabled = True
            NewSYButton.Enabled = True
            EditSYButton.Enabled = True
            SaveSYButton.Enabled = True
            ExitButton.Enabled = True
            GradingGroupBox.Enabled = True
        Else
            EPGroupBox.Enabled = False
            SYGroupBox.Enabled = False
            NewSYButton.Enabled = False
            EditSYButton.Enabled = False
            SaveSYButton.Enabled = False
            ExitButton.Enabled = False
            GradingGroupBox.Enabled = False
        End If
        SYTypeComboBox.Text = "Regular"
    End Sub
    Dim EPeriod As Integer
    Dim NewInteger As Integer = 0
    Private Sub NewSYButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSYButton.Click
        NewInteger = 1
        SYComboBox.Text = ""
        SYTypeComboBox.Enabled = True
        NewSYButton.Enabled = False
        SYComboBox.Enabled = False
        OpenButton.Enabled = False
        EPGroupBox.Enabled = True
        SYGroupBox.Enabled = True
        GradingsDomainUpDown.Enabled = True
        SaveSYButton.Enabled = True
        EditSYButton.Enabled = False
        GradingsDomainUpDown.SelectedItem = 0
        GradingsDomainUpDown.Enabled = True
        GradingGroupBox.Enabled = True
        EditSYButton.Enabled = False
        ExitButton.Enabled = True
        For i = 0 To NumberOfGradingsList.Count - 1
            GradingPanel.Controls.Remove(NumberOfGradingsList.Item(i))
            GradingPanel.Controls.Remove(GradingDateList.Item(i))
        Next
        Dim Dte As Date = FirstMonday(3, Date.Today.Year)
        EnrollmentPeriodFromDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(6, Date.Today.Year)
        EnrollmentPeriodToDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(6, Date.Today.Year)
        SchoolYearFromDateTimePicker.Text = CStr(Dte)
        Dte = FirstMonday(3, CInt(Date.Today.Year) + 1)
        SchoolYearToDateTimePicker.Text = CStr(Dte)
    End Sub
    Private Function FirstMonday(ByVal Mnth As Integer, ByVal year As Integer) As Date
        Dim Dte As Date = New Date(year, Mnth, 1)
        Do While Dte.DayOfWeek <> DayOfWeek.Monday
            Dte = Dte.AddDays(1)
        Loop
        Return Dte
    End Function
    Dim EPFrom As New List(Of Date)
    Dim EPTo As New List(Of Date)
    Dim SYFrom As New List(Of Date)
    Dim SyTo As New List(Of Date)
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Try
            CurrentSYID = SYID.Item(SYSelected)
            Main.Close()
            Main.Show()
            Me.Hide()
        Catch
            ' Kelangan pa ng Message Name
            MessageBox.Show("No SchoolYear Selected.")
        End Try
    End Sub
    Private Sub SaveSYButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSYButton.Click
        SQLString = "Select MAX(schoolyearid) As schoolyearid,(date(schoolyearstart)) AS systart,(date(schoolyearend)) As syend from tblSchoolYear " & _
        "WHERE schoolyeartype='" & SYTypeComboBox.Text & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            MaxSYID = myreader("schoolyearid").ToString
            MaxSYFrom = CDate((myreader("systart")))
            MaxSYTo = CDate((myreader("syend")))
        Loop
        myconn.Close()
        SQLString = "Select enrollmentstart,enrollmentend from tblenrollmentperiod,tblschoolyear WHERE tblschoolyear.schoolyearid='" & MaxSYID & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            MaxERFrom = CDate(myreader.GetDateTime("enrollmentstart").ToString("yyyy/MM/dd"))
            MaxERTo = CDate(myreader.GetDateTime("enrollmentend").ToString("yyyy/MM/dd"))
        Loop
        myconn.Close()


        Dim b As Integer = CInt(GradingsDomainUpDown.Text)
        Dim c As Integer = 0
        If b > 0 Then
            For i = 0 To cnt - 1
                Try
                    If CDate(GradingDateList.Item(i).Text) < CDate(SchoolYearFromDateTimePicker.Text) Or CDate(GradingDateList.Item(i).Text) > CDate(SchoolYearToDateTimePicker.Text) Then
                        c = 1
                        Exit For
                    ElseIf i < cnt Then
                        If CDate(GradingDateList.Item(i + 1).Text) < CDate(GradingDateList.Item(i).Text) Then
                            c = 1
                            Exit For
                        End If
                    End If
                Catch ex As Exception
                    Exit For
                End Try
            Next
            If CDate(EnrollmentPeriodFromDateTimePicker.Text) < CDate(EnrollmentPeriodToDateTimePicker.Text) Then
                If CDate(SchoolYearFromDateTimePicker.Text) < CDate(SchoolYearToDateTimePicker.Text) Then
                    If c = 0 Then
                        If SYComboBox.Text = "" Then
                            If MaxERTo < CDate(EnrollmentPeriodFromDateTimePicker.Text) And MaxSYTo < CDate(SchoolYearFromDateTimePicker.Text) Then
                                Dim result As Integer = MessageBox.Show("Are you sure you want to create a new school year?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                                If result = DialogResult.Yes Then
                                    If SYTypeComboBox.Text = "Regular" Then
                                        SQLString = "INSERT INTO tblSchoolYear " & "VALUES ('" & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "','" & SchoolYearFromDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & SchoolYearToDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & SYTypeComboBox.Text & "')"
                                    Else
                                        SQLString = "INSERT INTO tblSchoolYear " & "VALUES ('" & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "S','" & SchoolYearFromDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & SchoolYearToDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & SYTypeComboBox.Text & "')"
                                    End If
                                    myconn.ConnectionString = CONNECTION_STRING
                                    myconn.Open()
                                    mycommand.Connection = myconn
                                    mycommand.CommandText = SQLString
                                    mycommand.ExecuteNonQuery()
                                    myconn.Close()

                                    SQLString = "INSERT INTO tblEnrollmentPeriod " & "VALUES ('" & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "','" & EnrollmentPeriodFromDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & EnrollmentPeriodToDateTimePicker.Value.ToString("yyyy/MM/dd") & "','" & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "')"
                                    myconn.ConnectionString = CONNECTION_STRING
                                    myconn.Open()
                                    mycommand.Connection = myconn
                                    mycommand.CommandText = SQLString
                                    mycommand.ExecuteNonQuery()
                                    myconn.Close()
                                    For i = 0 To cnt - 1
                                        Dim GradingDate As Date = CDate(GradingDateList(i).Text)
                                        SQLString = "INSERT INTO tblGradings " & "VALUES ('" & i & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "','" & GradingDate.ToString("yyyy/MM/dd") & "','" & DatePart(DateInterval.Year, SchoolYearFromDateTimePicker.Value) & "','" & NumberOfGradingsList.Item(i).Text & "')"
                                        myconn.ConnectionString = CONNECTION_STRING
                                        myconn.Open()
                                        mycommand.Connection = myconn
                                        mycommand.CommandText = SQLString
                                        mycommand.ExecuteNonQuery()
                                        myconn.Close()
                                    Next
                                    MessageBox.Show("Successfully added new school year and enrollment period.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Else
                                MessageBox.Show("Enrollment Period and SchoolYear Period must be greater than the old corresponding periods.")
                            End If
                        Else
                            Dim result As Integer = MessageBox.Show("Are you sure you want to update the current school year?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If result = DialogResult.Yes Then

                                Try
                                    SQLString = "UPDATE tblSchoolYear " & "SET schoolyearend='" & SchoolYearToDateTimePicker.Value.ToString("yyyy/MM/dd") & "'" & _
                                    " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "' AND schoolyeartype='" & SYComboBox.Text & "'"
                                    myconn.ConnectionString = CONNECTION_STRING
                                    myconn.Open()
                                    mycommand.Connection = myconn
                                    mycommand.CommandText = SQLString
                                    mycommand.ExecuteNonQuery()
                                    myconn.Close()
                                Catch ex As Exception
                                    MessageBox.Show("No records found.tblSchoolYear" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    myconn.Close()
                                End Try
                                Try
                                    SQLString = "UPDATE tblEnrollmentPeriod " & "SET enrollmentend='" & EnrollmentPeriodToDateTimePicker.Value.ToString("yyyy/MM/dd") & "'" & _
                                    " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'"
                                    myconn.ConnectionString = CONNECTION_STRING
                                    myconn.Open()
                                    mycommand.Connection = myconn
                                    mycommand.CommandText = SQLString
                                    mycommand.ExecuteNonQuery()
                                    myconn.Close()
                                Catch ex As Exception
                                    MessageBox.Show("No records found.tblSchoolYear" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    myconn.Close()
                                End Try
                            End If
                        End If
                        SchoolYear()
                        Open()
                    Else
                        MessageBox.Show("Error in Grading Period.")
                        GradingPanel.Focus()
                    End If
                Else
                    MessageBox.Show("Error in School Year Period.")
                    SchoolYearFromDateTimePicker.Focus()
                End If
            Else
                MessageBox.Show("Error in Enrollment Period.")
                EnrollmentPeriodFromDateTimePicker.Focus()
            End If
        Else
            MessageBox.Show("Kindly change the number of grading period into non-zero value..")
            EnrollmentPeriodFromDateTimePicker.Focus()
        End If


    End Sub
    Dim NumberOfGradingsList As New List(Of Label)
    Dim GradingDateList As New List(Of DateTimePicker)
    Dim cnt As Integer = 0
    Private Sub GradingsDomainUpDown_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingsDomainUpDown.SelectedItemChanged
        If NewInteger = 0 Then
            'Open()
        Else
            NumberOfGradingsList.Clear()
            GradingDateList.Clear()
            GradingsDomainUpDown.Refresh()
            GradingPanel.Controls.Clear()
            cnt = CInt(GradingsDomainUpDown.Text)
            For i = 1 To cnt
                Dim suff As String = "th"
                If i = 1 Then
                    suff = "st"
                ElseIf i = 2 Then
                    suff = "nd"
                ElseIf i = 3 Then
                    suff = "rd"
                End If
                Dim NumberOfGradingsLabel As New System.Windows.Forms.Label()
                Dim GradingDateTimePicker As New System.Windows.Forms.DateTimePicker()

                NumberOfGradingsLabel.Name = "NumberOfGradingsLabel" & i.ToString
                NumberOfGradingsLabel.Top = i * 22
                NumberOfGradingsLabel.Text = i.ToString & suff & " Grading"
                NumberOfGradingsLabel.Width = 75
                NumberOfGradingsLabel.Left = 5


                GradingDateTimePicker.Name = "GradingDateTimePicker" & i.ToString
                GradingDateTimePicker.Top = i * 22
                GradingDateTimePicker.Format = DateTimePickerFormat.Short
                GradingDateTimePicker.Text = CStr(CDate(SchoolYearFromDateTimePicker.Text).AddMonths((i * 2)))
                GradingDateTimePicker.Width = 120
                GradingDateTimePicker.Left = 80

                GradingPanel.Controls.Add(NumberOfGradingsLabel)
                GradingPanel.Controls.Add(GradingDateTimePicker)

                NumberOfGradingsList.Add(NumberOfGradingsLabel)
                GradingDateList.Add(GradingDateTimePicker)
            Next
        End If

    End Sub

    Private Sub EditSYButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSYButton.Click
        SYTypeComboBox.Enabled = True
        NewSYButton.Enabled = False
        SYTypeComboBox.Enabled = False
        SYComboBox.Enabled = False
        OpenButton.Enabled = False
        EPGroupBox.Enabled = True
        SYGroupBox.Enabled = True
        GradingsDomainUpDown.Enabled = True
        SaveSYButton.Enabled = True
        EditSYButton.Enabled = False
        GradingsDomainUpDown.Enabled = False
        GradingGroupBox.Enabled = True
        EditSYButton.Enabled = False
        ExitButton.Enabled = True
    End Sub

    Sub CloseSY()
        Dim result As Integer = MessageBox.Show("Are you sure you want to close the current school year?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Try
                SQLString = "UPDATE tblSchoolYear " & "SET schoolyearend='" & SchoolYearToDateTimePicker.Value.ToString("yyyy/MM/dd") & "'" & _
                " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "' AND schoolyeartype='" & SYComboBox.Text & "' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found.tblSchoolYear" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myconn.Close()
            End Try
            Try
                SQLString = "UPDATE tblEnrollmentPeriod " & "SET enrollmentend='" & EnrollmentPeriodToDateTimePicker.Value.ToString("yyyy/MM/dd") & "'" & _
                " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found.tblSchoolYear" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myconn.Close()
            End Try
            SchoolYear()
            Open()
        End If
    End Sub
    Private Sub MaintenanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CurrentSYID = SYID.Item(SYComboBox.SelectedIndex)
        Year.Show()
        Me.Close()
    End Sub

    Private Sub MaintenancePictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CurrentSYID = SYID.Item(SYComboBox.SelectedIndex)
        Year.Show()
        Me.Close()
    End Sub
    Public Sub ClearAll()
        GradingsDomainUpDown.SelectedItem = 0
        For i = 0 To NumberOfGradingsList.Count - 1
            GradingPanel.Controls.Remove(NumberOfGradingsList.Item(i))
            GradingPanel.Controls.Remove(GradingDateList.Item(i))
            Me.Controls.Remove(NumberOfGradingsList.Item(i))
            Me.Controls.Remove(GradingDateList.Item(i))
        Next
        SchoolYear()
        Open()
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        SchoolYear()
        Open()
    End Sub
    Public Sub Open()
        ExitButton.Enabled = False
        If SYComboBox.Items.Count = 0 Then
            SYComboBox.Enabled = True
            SYTypeComboBox.Enabled = True
            EPGroupBox.Enabled = False
            SYGroupBox.Enabled = False
            GradingGroupBox.Enabled = True
            NewSYButton.Enabled = True
            EditSYButton.Enabled = False
            SaveSYButton.Enabled = False
            OpenButton.Enabled = False
            GradingsDomainUpDown.Enabled = False
        ElseIf SYComboBox.SelectedIndex = 0 Then
            SYComboBox.Enabled = True
            SYTypeComboBox.Enabled = False
            EPGroupBox.Enabled = True
            SYGroupBox.Enabled = True
            GradingGroupBox.Enabled = True
            NewSYButton.Enabled = True
            EditSYButton.Enabled = True
            SaveSYButton.Enabled = False
            OpenButton.Enabled = True
            GradingsDomainUpDown.Enabled = False
        Else
            SYComboBox.Enabled = False
            SYTypeComboBox.Enabled = False
            EPGroupBox.Enabled = False
            SYGroupBox.Enabled = False
            GradingGroupBox.Enabled = False
            NewSYButton.Enabled = False
            EditSYButton.Enabled = True
            SaveSYButton.Enabled = False
            OpenButton.Enabled = False
            ExitButton.Enabled = True
            GradingsDomainUpDown.Enabled = False
        End If
        NewInteger = 0
        Try
            SQLString = "Select schoolyearstart As datefrom,schoolyearend As dateto,enrollmentstart,enrollmentend  from tblSchoolYear,tblEnrollmentPeriod,tblGradings" & _
            " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid AND tblEnrollmentPeriod.schoolyearid=tblSchoolYear.schoolyearid" & _
            " AND tblSchoolYear.schoolyearid='" & SYID.Item(SYSelected) & "'"

            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SchoolYearFromDateTimePicker.Text = CStr(myreader("datefrom"))
                SchoolYearToDateTimePicker.Text = CStr(myreader("dateto"))
                EnrollmentPeriodFromDateTimePicker.Text = CStr(myreader("enrollmentstart"))
                EnrollmentPeriodToDateTimePicker.Text = CStr(myreader("enrollmentend"))
            Loop
            myconn.Close()
            GradingPanel.Controls.Clear()
            Dim j As Integer
            SQLString = "Select (gradingperiod) As gradingperiod from tblSchoolYear,tblGradings" & _
            " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
            " AND tblSchoolYear.schoolyearid='" & SYID.Item(SYSelected) & "'" & _
            " ORDER BY gradingperiod ASC"

            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                j = j + 1
                Dim suff As String = "th"
                If j = 1 Then
                    suff = "st"
                ElseIf j = 2 Then
                    suff = "nd"
                ElseIf j = 3 Then
                    suff = "rd"
                End If
                Dim NumberOfGradingsLabel As New System.Windows.Forms.Label()
                Dim GradingDateTimePicker As New System.Windows.Forms.DateTimePicker()

                NumberOfGradingsLabel.Top = j * 22
                NumberOfGradingsLabel.Text = j.ToString & suff & " Grading"
                NumberOfGradingsLabel.Width = 75
                NumberOfGradingsLabel.Left = 5
                NumberOfGradingsLabel.BringToFront()

                GradingDateTimePicker.Top = j * 22
                GradingDateTimePicker.Format = DateTimePickerFormat.Short
                GradingDateTimePicker.Text = (myreader.GetDateTime("gradingperiod")).ToString("yyyy/MM/dd")
                GradingDateTimePicker.Width = 120
                GradingDateTimePicker.Left = 80
                GradingDateTimePicker.BringToFront()

                GradingPanel.Controls.Add(NumberOfGradingsLabel)
                GradingPanel.Controls.Add(GradingDateTimePicker)
            Loop
            myconn.Close()

            GradingsDomainUpDown.Enabled = False
            GradingsDomainUpDown.Text = j.ToString
        Catch ex As Exception
            myconn.Close()
        End Try

    End Sub
    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenButton.Click
        Open()
    End Sub
    Dim SYSelected As New Integer
    Private Sub SYTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYTypeComboBox.SelectedIndexChanged
        SchoolYear()
        Open()
    End Sub
    Sub SchoolYear()
        Dim i As Integer = 0
        SYID.Clear()
        SYFrom.Clear()
        SyTo.Clear()
        SYComboBox.Items.Clear()
        SQLString = "Select schoolyearid As schoolyearid,date(schoolyearstart) As datefrom,date(schoolyearend) As dateto  from tblSchoolYear" & _
        " WHERE schoolyeartype='" & SYTypeComboBox.Text & "' ORDER BY schoolyearstart DESC"

        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            SYID.Add(CStr(myreader("schoolyearid")))
            SYFrom.Add(CDate(myreader("datefrom")))
            SyTo.Add(CDate(myreader("dateto")))
            SYComboBox.Items.Add(SYFrom.Item(i) & "-" & SyTo.Item(i))
            i = i + 1
        Loop
        myconn.Close()
        If SYID.Count > 0 Then
            SYComboBox.Text = (SYFrom.Item(0) & "-" & SyTo.Item(0))
        End If
    End Sub

    Private Sub SYComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYComboBox.SelectedIndexChanged
        SYSelected = SYComboBox.SelectedIndex
    End Sub
End Class
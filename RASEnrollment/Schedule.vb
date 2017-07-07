Option Strict On
Imports MySql.Data.MySqlClient
Public Class Schedule
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim yearcnt As Integer
    Dim SQLString As String
    Dim SYType As String = Main.SYType
    Private Sub Schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearLevelScheduleComboBox.Items.Clear()
        SectionScheduleComboBox.Items.Clear()
        ClassScheduleGroupBox.Visible = True
        YearLevelList.Clear()
        SectionList.Clear()
        Dim LoadInfo As String = "SELECT yearlevelname " & "FROM tblYearLevel" & _
        " WHERE implemented='True' ORDER BY yeargrade,yearorder "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearLevelList.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("No records foundc." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        For i = 0 To YearLevelList.Count - 1
            YearLevelScheduleComboBox.Items.Add(YearLevelList.Item(i))
        Next
        Schedule()
    End Sub
    Dim YearLevelList As New List(Of String)
    Dim SectionList As New List(Of String)
    Dim YearCounter As Integer = 0
    Dim SectionCounter As Integer = 0
    Dim DayCounter As Integer = 0
    Public Sub Schedule()
        Try
            YearLevelScheduleComboBox.Text = YearLevelList.Item(YearCounter)
            SectionScheduleComboBox.Text = SectionList.Item(SectionCounter)
            DayScheduleComboBox.SelectedIndex = DayCounter
        Catch
            myconn.Close()
            MessageBox.Show("Please input section/s for " & YearLevelList.Item(YearCounter), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveScheduleButton.Click
        Dim SQLInsert As String
        CopyScheduleButton.Enabled = True
        PasteScheduleButton.Enabled = False
        Dim yearlevelsectioncodeonsave As String = ""
        Dim CheckInput As Integer = 0
        Dim CheckError As Integer = 0
        Dim StartTimeValue As New DateTime
        Dim EndTimeValue As New DateTime
        Dim StartTimeList As New List(Of DateTime)
        Dim EndTimeList As New List(Of DateTime)
        Dim CompareTime As Integer = 0
        Dim CompareTwoTime As New Integer
        Dim SchedKey As New List(Of String)
        For x = 1 To subjectschedulecnt
            StartTimeValue = CDate(StartTimeScheduleArray(x).Text)
            EndTimeValue = CDate(EndTimeScheduleArray(x).Text)
            CompareTime = CInt(StartTimeValue.CompareTo(EndTimeValue))
            ErrorLabelArray(x).Text = ""
            TeacherScheduleArray(x).ForeColor = Color.Black
            RoomScheduleArray(x).ForeColor = Color.Black
            SubjectScheduleArray(x).ForeColor = Color.Black
            If x > 1 Then
                CompareTwoTime = CInt(CDate(StartTimeScheduleArray(x).Text).CompareTo(CDate(EndTimeScheduleArray(x - 1).Text)))
                If CompareTwoTime = -1 Then
                    ErrorLabelArray(x).Text = " X Check the time input."
                    CheckInput = CheckInput + 1
                End If
            End If
            If CompareTime = 1 Or CompareTime = 0 Then
                ErrorLabelArray(x).Text = " X Check the time input."
                CheckInput = CheckInput + 1
            End If
            If TeacherScheduleArray(x).Text = "Teacher" Then
                TeacherScheduleArray(x).ForeColor = Color.Red
                ErrorLabelArray(x).Text = " X Invalid Input."
                CheckInput = CheckInput + 1
            End If
            If RoomScheduleArray(x).Text = "Room" Then
                RoomScheduleArray(x).ForeColor = Color.Red
                ErrorLabelArray(x).Text = " X Invalid Input."
                CheckInput = CheckInput + 1
            End If
            If SubjectScheduleArray(x).Text = "Subject" Then
                SubjectScheduleArray(x).ForeColor = Color.Red
                ErrorLabelArray(x).Text = " X Invalid Input."
                CheckInput = CheckInput + 1
            End If
        Next
        If CheckInput = 0 Then
            For x = 1 To subjectschedulecnt
                For a = 2 To subjectschedulecnt
                    If x = a Then
                    Else
                        If SubjectScheduleArray(x).Text = SubjectScheduleArray(a).Text Then
                            SubjectScheduleArray(x).ForeColor = Color.Red
                            SubjectScheduleArray(a).ForeColor = Color.Red
                            CheckError = CheckError + 1
                            ErrorLabelArray(x).Text = " X Line Error"
                            ErrorLabelArray(a).Text = " X Line Error"
                        End If
                    End If
                Next
            Next
            Dim SQLSection As String = "Select yearlevelsectioncode from tblYearLevel,tblYearLevelSections" & _
                 " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND" & _
                 " yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
                 " AND sectioncode='" & SectionScheduleComboBox.Text & "'" 
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSection
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    yearlevelsectioncodeonsave = CStr((myreader("yearlevelsectioncode")))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("aaUnable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If CheckError > 0 Then
                MessageBox.Show("There are " & CheckError.ToString & " error(s).", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                SchedConflictsListView.Items.Clear()
                Dim tea As Integer
                Dim rm As Integer
                Dim subj As Integer
                For x = 1 To subjectschedulecnt

                    For i = 0 To TeacherName.Count - 1
                        If TeacherScheduleArray(x).Text = TeacherName.Item(i) Then
                            tea = i
                            Exit For
                        End If
                    Next
                    For i = 0 To RoomName.Count - 1
                        If RoomScheduleArray(x).Text = RoomName.Item(i) Then
                            rm = i
                            Exit For
                        End If
                    Next
                    For i = 0 To SubjectName.Count - 1
                        If SubjectScheduleArray(x).Text = SubjectName.Item(i) Then
                            subj = i
                            Exit For
                        End If
                    Next
                    Dim StartTime As DateTime = CDate(StartTimeScheduleArray(x).Text)
                    Dim SQLSched As String = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections where sched_day='" & DayScheduleComboBox.Text & "'" & _
                    " AND sched_starttime<='" & StartTime.ToString("HH:mm:ss") & "'" & _
                    " AND sched_endtime>'" & StartTime.ToString("HH:mm:ss") & "'" & _
                    " AND teacherid='" & TeacherIDScheduleList.Item(tea) & "'" & _
                    " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'" & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                    " AND tblYearLevelSections.yearlevelsectioncode!='" & yearlevelsectioncodeonsave & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLSched
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            SchedKey.Add(CStr(myreader("yearlevelschedulekey")))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("bbUnable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    Dim YrLevelSchedCount As Integer
                    SQLSched = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections where sched_day='" & DayScheduleComboBox.Text & "'" & _
                   " AND sched_starttime>'" & StartTime.ToString("HH:mm:ss") & "'" & _
                   " AND sched_endtime<='" & StartTime.ToString("HH:mm:ss") & "'" & _
                    " AND teacherid='" & TeacherIDScheduleList.Item(tea) & "'" & _
                    " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'" & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                    " AND tblYearLevelSections.yearlevelsectioncode!='" & yearlevelsectioncodeonsave & "'"


                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLSched
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            For i = 0 To SchedKey.Count - 1
                                If SchedKey.Item(i) = CStr(myreader("yearlevelschedulekey")) Then
                                    YrLevelSchedCount = YrLevelSchedCount + 1
                                End If
                            Next
                            If YrLevelSchedCount > 0 Then
                                YrLevelSchedCount = 0
                            Else
                                YrLevelSchedCount = 0
                                SchedKey.Add(CStr(myreader("yearlevelschedulekey")))
                            End If
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLSched = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections where sched_day='" & DayScheduleComboBox.Text & "'" & _
                   " AND sched_starttime<='" & StartTime.ToString("HH:mm:ss") & "'" & _
                   " AND sched_endtime>'" & StartTime.ToString("HH:mm:ss") & "'" & _
                    " AND roomno='" & RoomNoScheduleList.Item(rm) & "'" & _
                     " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'" & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                    " AND tblYearLevelSections.yearlevelsectioncode!='" & yearlevelsectioncodeonsave & "'"

                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLSched
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            For i = 0 To SchedKey.Count - 1
                                If SchedKey.Item(i) = CStr(myreader("yearlevelschedulekey")) Then
                                    YrLevelSchedCount = YrLevelSchedCount + 1
                                End If
                            Next
                            If YrLevelSchedCount > 0 Then
                                YrLevelSchedCount = 0
                            Else
                                YrLevelSchedCount = 0
                                SchedKey.Add(CStr(myreader("yearlevelschedulekey")))
                            End If
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("ffUnable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLSched = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections where sched_day='" & DayScheduleComboBox.Text & "'" & _
                   " AND sched_starttime>'" & StartTime.ToString("HH:mm:ss") & "'" & _
                   " AND sched_endtime<='" & StartTime.ToString("HH:mm:ss") & "'" & _
                     " AND roomno='" & RoomNoScheduleList.Item(rm) & "'" & _
                    " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'" & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                    " AND tblYearLevelSections.yearlevelsectioncode!='" & yearlevelsectioncodeonsave & "'"

                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLSched
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            For i = 0 To SchedKey.Count - 1
                                If SchedKey.Item(i) = CStr(myreader("yearlevelschedulekey")) Then
                                    YrLevelSchedCount = YrLevelSchedCount + 1
                                End If
                            Next
                            If YrLevelSchedCount > 0 Then
                                YrLevelSchedCount = 0
                            Else
                                YrLevelSchedCount = 0
                                SchedKey.Add(CStr(myreader("yearlevelschedulekey")))
                            End If
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("zzUnable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
                If SchedKey.Count > 0 Then
                    For i = 0 To SchedKey.Count - 1
                        Dim SQLSchedN As String = "Select sched_day,concat(sched_starttime,'-',sched_endtime) As time,yearlevelname,sectioncode,room_name,sub_code,Concat(tea_lname,',',tea_fname,' ',tea_mname) As Teacher from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND" & _
                " tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND" & _
                " tblYearLevelSchedule.roomno=tblRooms.roomno AND " & _
                " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND " & _
                " tblSubjects.subjectcode=tblYearLevelSchedule.subjectcode AND " & _
                " tblYearLevelSchedule.yearlevelschedulekey='" & SchedKey.Item(i) & "'" & _
                        " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLSchedN
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                SchedConflictsListView.Items.Add(myreader("sched_day").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("time").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("yearlevelname").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("sectioncode").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("sub_code").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("Teacher").ToString)
                                SchedConflictsListView.Items(SchedConflictsListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("ssUnable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Next
                Else
                    For x = 1 To subjectschedulecnt
                        Dim StartTime As DateTime = CDate(StartTimeScheduleArray(x).Text)
                        Dim EndTime As DateTime = CDate(EndTimeScheduleArray(x).Text)
                        For i = 0 To TeacherName.Count - 1
                            If TeacherScheduleArray(x).Text = TeacherName.Item(i) Then
                                tea = i
                                Exit For
                            End If
                        Next
                        For i = 0 To RoomName.Count - 1
                            If RoomScheduleArray(x).Text = RoomName.Item(i) Then
                                rm = i
                                Exit For
                            End If
                        Next
                        For i = 0 To SubjectName.Count - 1
                            If SubjectScheduleArray(x).Text = SubjectName.Item(i) Then
                                subj = i
                                Exit For
                            End If
                        Next
                        Try
                            SQLInsert = "INSERT INTO tblYearLevelSchedule(yearlevelschedulekey,sched_day,sched_starttime,sched_endtime,yearlevelsectioncode,subjectcode,teacherid,roomno,schoolyeartype,schedorder)" & _
                            " VALUES ('" & (YearLevelScheduleComboBox.Text & SectionScheduleComboBox.Text & SubjectCodeList.Item(subj) & SYType & DayScheduleComboBox.Text).Trim & "','" & DayScheduleComboBox.Text.Trim() & "'," & "time('" & StartTime.ToString("HH:mm:ss") & "')" & _
                            ",time('" & EndTime.ToString("HH:mm:ss") & "')" & ",'" & yearlevelsectioncodeonsave & "','" & SubjectCodeList.Item(subj) & "','" & TeacherIDScheduleList.Item(tea) & "','" & RoomNoScheduleList.Item(rm) & "','" & SYType & "'," & DayScheduleComboBox.SelectedIndex + 1 & ")"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()

                        Catch ex As Exception
                            myconn.Close()
                            SQLInsert = "UPDATE tblYearLevelSchedule SET sched_starttime=time('" & StartTime.ToString("HH:mm:ss") & "') WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SubjectCodeList.Item(subj) & SYType & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLInsert = "UPDATE tblYearLevelSchedule SET sched_endtime=time('" & EndTime.ToString("HH:mm:ss") & "') WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SubjectCodeList.Item(subj) & SYType & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLInsert = "UPDATE  tblYearLevelSchedule SET yearlevelsectioncode='" & yearlevelsectioncodeonsave & "' WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SubjectCodeList.Item(subj) & SYType & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLInsert = "UPDATE tblYearLevelSchedule SET subjectcode='" & SubjectCodeList.Item(subj) & "' WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SYType & SubjectCodeList.Item(subj) & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLInsert = "UPDATE tblYearLevelSchedule SET teacherid='" & TeacherIDScheduleList.Item(tea) & "' WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SYType & SubjectCodeList.Item(subj) & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQLInsert = "UPDATE tblYearLevelSchedule SET roomno='" & RoomNoScheduleList.Item(rm) & "' WHERE yearlevelschedulekey='" & (YearLevelScheduleComboBox.Text.Trim & SectionScheduleComboBox.Text & SYType & SubjectCodeList.Item(subj) & DayScheduleComboBox.Text).Trim & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLInsert
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        End Try

                    Next
                    MessageBox.Show("Successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("There are " & CheckInput.ToString & " error(s).", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim SQLInsert As String
    Dim CopyYearKey As New List(Of String)
    Dim CopyYear As String
    Private Sub CopyScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyScheduleButton.Click
        CopyYearKey.Clear()
        CopyYear = YearLevelScheduleComboBox.Text
        Dim SQLSe As String = "Select distinct yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                "where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND " & _
                "tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND" & _
                " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
               " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
               " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
               " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
               " AND sectioncode='" & SectionScheduleComboBox.Text & "'" & _
               " AND sched_day='" & DayScheduleComboBox.Text & "'" & _
               " GROUP BY sched_starttime"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSe
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                CopyYearKey.Add(myreader("yearlevelschedulekey").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAA.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If CopyYearKey.Count = 0 Then
            MessageBox.Show("There's no available data to copy.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            CopyScheduleButton.Enabled = False
            PasteScheduleButton.Enabled = True
        End If
    End Sub
    Private Sub PasteScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteScheduleButton.Click
        If CopyYear = YearLevelScheduleComboBox.Text Then
            For x = 1 To CopyYearKey.Count
                CopyScheduleButton.Enabled = True
                Dim SQLString As String = "Select sched_starttime As starttime,sched_endtime As endtime,room_name,sub_code,Concat(tea_lname,',',tea_fname,' ',tea_mname,'.') As Teacher from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                     "where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND " & _
                     "tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND" & _
                     " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                    " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                    " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                " AND yearlevelschedulekey='" & CopyYearKey.Item(x - 1) & "'"

                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        StartTimeScheduleArray(x).Text = myreader("starttime").ToString
                        EndTimeScheduleArray(x).Text = myreader("endtime").ToString
                        SubjectScheduleArray(x).Text = myreader("sub_code").ToString
                        RoomScheduleArray(x).Text = myreader("room_name").ToString
                        TeacherScheduleArray(x).Text = myreader("Teacher").ToString
                    Loop

                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBA.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Next
            CopyYearKey.Clear()
            PasteScheduleButton.Enabled = False
        Else
            MessageBox.Show("Not allowed to copy schedule information from another year level.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Dim CountYear As Integer
    Private Sub YrLevelScheduleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelScheduleComboBox.SelectedIndexChanged
        YearCounter = YearLevelScheduleComboBox.SelectedIndex
        CopyScheduleButton.Enabled = True
        PasteScheduleButton.Enabled = False
        SectionList.Clear()
        SectionScheduleComboBox.Items.Clear()
        SectionScheduleComboBox.Text = ""
        DayScheduleComboBox.Text = "Monday"
        Dim SQLSections As String = "SELECT sectioncode" & " FROM tblYearlevelSections,tblYearLevel where tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
        " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSections
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SectionList.Add(myreader("sectioncode").ToString)
                SectionScheduleComboBox.Items.Add(myreader("sectioncode"))
            Loop
            myconn.Close()
            SectionScheduleComboBox.Text = SectionList.Item(0)
        Catch ex As Exception
            myconn.Close()
        End Try
        SubjectTextBox.Text = "0"
        Dim SQLSelect As String = "SELECT Count(tblYearLevelSubjects.subjectcode) As subject " & "FROM tblYearLevel,tblSubjects,tblYearLevelSubjects where " & _
        "tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode AND tblYearLevelSubjects.yearlevelcode=tblYearLevel.yearlevelcode AND " & _
        "yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
        " GROUP BY yearlevelname"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSelect
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SubjectTextBox.Text = CStr(CInt(myreader("subject")))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBAA.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        CountYear = CInt(SubjectTextBox.Text)
    End Sub
    Dim StartTimeScheduleArray(12) As System.Windows.Forms.DateTimePicker
    Dim EndTimeScheduleArray(12) As System.Windows.Forms.DateTimePicker
    Dim TeacherScheduleArray(12) As System.Windows.Forms.ComboBox
    Dim SubjectScheduleArray(12) As System.Windows.Forms.ComboBox
    Dim RoomScheduleArray(12) As System.Windows.Forms.ComboBox
    Dim subjectschedulecnt As Integer
    Dim ErrorLabelArray(12) As System.Windows.Forms.Label
    Dim TeacherIDScheduleList As New List(Of String)
    Dim RoomNoScheduleList As New List(Of String)
    Dim TeacherName As New List(Of String)
    Dim RoomName As New List(Of String)
    Dim SubjectCodeList As New List(Of String)
    Dim SubjectName As New List(Of String)
    Dim YearKey As New List(Of String)

    Private Sub SectionScheduleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionScheduleComboBox.SelectedIndexChanged
        SectionCounter = SectionScheduleComboBox.SelectedIndex
        'DayScheduleComboBox.Text = "Monday"
    End Sub
    Public Sub Sched()
        If CountYear = 0 Then
            MessageBox.Show(YearLevelScheduleComboBox.Text & " has " & CountYear.ToString & " subject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If CInt(SubjectTextBox.Text) = 0 Then
                MessageBox.Show("Zero is not a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf CInt(SubjectTextBox.Text) > CountYear Then
                MessageBox.Show(YearLevelScheduleComboBox.Text & " only has " & CountYear.ToString & " subjects.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf IsNumeric(SubjectTextBox.Text) Then
                ScheduleTextBox.Text = "List of Schedule for: " & YearLevelScheduleComboBox.Text & " - " & SectionScheduleComboBox.Text & " - " & DayScheduleComboBox.Text
                TeacherIDScheduleList.Clear()
                RoomNoScheduleList.Clear()
                RoomName.Clear()
                TeacherName.Clear()
                SubjectName.Clear()
                SubjectCodeList.Clear()
                YearKey.Clear()
                Dim YearKeyNo As Integer
                For i = 0 To subjectschedulecnt
                    ScheduleListView.Controls.Remove(StartTimeScheduleArray(i))
                    ScheduleListView.Controls.Remove(EndTimeScheduleArray(i))
                    ScheduleListView.Controls.Remove(TeacherScheduleArray(i))
                    ScheduleListView.Controls.Remove(SubjectScheduleArray(i))
                    ScheduleListView.Controls.Remove(RoomScheduleArray(i))
                Next
                Dim SQLSe As String = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                             "where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND " & _
                             "tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND" & _
                             " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                            " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                            " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                            " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
                            " AND sectioncode='" & SectionScheduleComboBox.Text & "'" & _
                            " AND sched_day='" & DayScheduleComboBox.Text & "'" & _
                            " GROUP By sched_starttime"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLSe
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        YearKey.Add(myreader("yearlevelschedulekey").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBAA.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                YearKeyNo = YearKey.Count
                subjectschedulecnt = CInt(SubjectTextBox.Text)
                For x = 1 To subjectschedulecnt
                    Dim StartTimeDateTimePicker As New Windows.Forms.DateTimePicker
                    StartTimeDateTimePicker.Name = "StartTimeComboBox" & x.ToString
                    StartTimeDateTimePicker.ShowUpDown = True
                    StartTimeDateTimePicker.Format = DateTimePickerFormat.Custom
                    StartTimeDateTimePicker.CustomFormat = "hh : mm tt"
                    Dim NDate As DateTime = CDate("06:00").AddHours(x)
                    StartTimeDateTimePicker.Text = CStr(NDate)
                    StartTimeDateTimePicker.Width = 80
                    StartTimeDateTimePicker.Left = 8
                    StartTimeDateTimePicker.Top = x * 30
                    ScheduleListView.Controls.Add(StartTimeDateTimePicker)
                    StartTimeScheduleArray(x) = StartTimeDateTimePicker


                    Dim EndTimeDateTimePicker As New Windows.Forms.DateTimePicker
                    EndTimeDateTimePicker.Name = "EndTimeComboBox" & x.ToString
                    EndTimeDateTimePicker.ShowUpDown = True
                    EndTimeDateTimePicker.Format = DateTimePickerFormat.Custom
                    EndTimeDateTimePicker.CustomFormat = "hh : mm tt"
                    NDate = CDate("07:00").AddHours(x)
                    EndTimeDateTimePicker.Text = CStr(NDate)
                    EndTimeDateTimePicker.Width = 80
                    EndTimeDateTimePicker.Left = 95
                    EndTimeDateTimePicker.Top = x * 30
                    ScheduleListView.Controls.Add(EndTimeDateTimePicker)
                    EndTimeScheduleArray(x) = EndTimeDateTimePicker

                    Dim SubjectComboBox As New Windows.Forms.ComboBox
                    SubjectComboBox.Name = "SubjectComboBox" & x.ToString
                    SubjectComboBox.Text = "Subject"
                    SubjectComboBox.Tag = x
                    SubjectComboBox.Width = 80
                    SubjectComboBox.Left = 180
                    SubjectComboBox.Top = x * 30
                    ScheduleListView.Controls.Add(SubjectComboBox)
                    SubjectScheduleArray(x) = SubjectComboBox

                    AddHandler SubjectComboBox.SelectedIndexChanged, AddressOf Me.Combobox_SelectedIndexChanged

                    Dim TeacherComboBox As New Windows.Forms.ComboBox
                    TeacherComboBox.Name = "TeacherComboBox" & x.ToString
                    TeacherComboBox.Text = "Teacher"
                    TeacherComboBox.Width = 100
                    TeacherComboBox.Left = 265
                    TeacherComboBox.Top = x * 30
                    ScheduleListView.Controls.Add(TeacherComboBox)
                    TeacherScheduleArray(x) = TeacherComboBox


                    Dim RoomComboBox As New Windows.Forms.ComboBox
                    RoomComboBox.Name = "RoomComboBox" & x.ToString
                    RoomComboBox.Text = "Room"
                    RoomComboBox.Width = 60
                    RoomComboBox.Left = 365
                    RoomComboBox.Top = x * 30
                    ScheduleListView.Controls.Add(RoomComboBox)
                    RoomScheduleArray(x) = RoomComboBox


                    Dim ErrorMsgLabel As New Windows.Forms.Label
                    ErrorMsgLabel.Name = "ErrorMsgLabel" & x.ToString
                    ErrorMsgLabel.ForeColor = Color.Red
                    ErrorMsgLabel.Width = 150
                    ErrorMsgLabel.Left = 430
                    ErrorMsgLabel.Top = x * 30
                    ScheduleListView.Controls.Add(ErrorMsgLabel)
                    ErrorLabelArray(x) = ErrorMsgLabel
                    YearKeyNo = YearKeyNo - 1
                    If YearKeyNo > -1 Then
                        CopyScheduleButton.Enabled = True
                        Dim SQLString As String = "Select sched_starttime As starttime,sched_endtime As endtime,room_name,sub_code,Concat(tea_lname,',',tea_fname,' ',tea_mname,'.') As Teacher from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections,tblTeachers,tblRooms,tblSubjects " & _
                             "where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode AND " & _
                             "tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode AND" & _
                             " tblYearLevelSchedule.roomno=tblRooms.roomno AND" & _
                            " tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND" & _
                            " tblSubjects.subjectcode = tblYearLevelSchedule.subjectcode" & _
                            " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
                            " AND sectioncode='" & SectionScheduleComboBox.Text & "'" & _
                            " AND sched_day='" & DayScheduleComboBox.Text & "'" & _
                            " AND tblYearLevelSchedule.schoolyeartype='" & SYType & "'" & _
                        " AND yearlevelschedulekey='" & YearKey.Item(x - 1) & "'" & _
                        " GROUP by sched_starttime "
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                Dim StartTime As TimeSpan = CType(myreader("starttime"), TimeSpan)
                                Dim EndTime As TimeSpan = CType(myreader("endtime"), TimeSpan)
                                StartTimeScheduleArray(x).Text = StartTime.ToString
                                EndTimeScheduleArray(x).Text = EndTime.ToString
                                SubjectScheduleArray(x).Text = myreader("sub_code").ToString
                                RoomScheduleArray(x).Text = myreader("room_name").ToString
                                TeacherScheduleArray(x).Text = myreader("Teacher").ToString
                            Loop

                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to DBA.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    End If
                    SQLString = "SELECT Concat(tea_lname,',',tea_fname,' ',tea_mname,'.') As Teacher " & " FROM tblTeachers WHERE teacherstatus='OK'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            TeacherComboBox.Items.Add(myreader("Teacher"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLString = " Select sub_code From tblSubjects,tblYearLevelSubjects,tblYearLevel,tblYearLevelSections" & _
                  " where tblSubjects.subjectcode = tblYearLevelSubjects.subjectcode And tblYearlevel.yearlevelcode = tblYearLevelSubjects.yearlevelcode " & _
                   " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                 " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
                  "  AND sectioncode='" & SectionScheduleComboBox.Text & "'" & _
                      " GROUP BY tblSubjects.subjectcode"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            SubjectComboBox.Items.Add(myreader("sub_code"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    SQLString = "SELECT  room_name" & " FROM tblRooms"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            RoomComboBox.Items.Add(myreader("room_name"))
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
                SQLString = "SELECT Concat(tea_lname,',',tea_fname,' ',tea_mname,'.') As Teacher,teacherid" & " FROM tblTeachers WHERE teacherstatus!='Resigned'"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        TeacherIDScheduleList.Add(CStr(myreader("teacherid")))
                        TeacherName.Add(CStr(myreader("Teacher")))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                SQLString = " Select tblSubjects.subjectcode As subjectcode,sub_code From tblSubjects,tblYearLevelSubjects,tblYearLevel,tblYearLevelSections" & _
                " where tblSubjects.subjectcode = tblYearLevelSubjects.subjectcode And tblYearlevel.yearlevelcode = tblYearLevelSubjects.yearlevelcode " & _
                 " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
               " AND yearlevelname='" & YearLevelScheduleComboBox.Text & "'" & _
                " AND sectioncode='" & SectionScheduleComboBox.Text & "'" & _
                    " GROUP BY subjectcode"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        SubjectCodeList.Add(myreader("subjectcode").ToString)
                        SubjectName.Add(myreader("sub_code").ToString)
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                SQLString = "SELECT roomno,room_name" & " FROM tblRooms"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        RoomNoScheduleList.Add(CStr(myreader("roomno")))
                        RoomName.Add(CStr(myreader("room_name")))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Must be Numeric Value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    Private Sub DayScheduleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayScheduleComboBox.SelectedIndexChanged
        DayCounter = DayScheduleComboBox.SelectedIndex
    End Sub
    Private Sub NextScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextScheduleButton.Click
        If DayCounter = DayScheduleComboBox.Items.Count - 1 Then
            If SectionCounter = SectionList.Count - 1 Then
                If YearCounter = YearLevelList.Count - 1 Then
                    YearCounter = 0
                    SectionCounter = 0
                    DayCounter = 0
                Else
                    YearCounter = YearCounter + 1
                    SectionCounter = 0
                    DayCounter = 0
                End If
            Else
                SectionCounter = SectionCounter + 1
                DayCounter = 0
            End If
        Else
            DayCounter = DayCounter + 1
        End If
        Schedule()
    End Sub
    Private Sub PrevScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevScheduleButton.Click
        If DayCounter = 0 Then
            If SectionCounter = 0 Then
                YearCounter = YearLevelScheduleComboBox.Items.Count - 1

            Else
                SectionCounter = SectionScheduleComboBox.Items.Count - 1
            End If
        Else
            DayCounter = DayCounter - 1
        End If
        Schedule()
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub Combobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ComboBox Then
            Dim cb As ComboBox = DirectCast(sender, ComboBox)
            'TeacherScheduleArray(CInt(cb.Tag.ToString) - 1).SelectedIndex = CInt(cb.SelectedIndex)
        End If
    End Sub
    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Sub ButtonSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
        Sched()
    End Sub

    Private Sub ClassScheduleGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassScheduleGroupBox.Enter

    End Sub

    
    Private Sub DeleteScheduleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteScheduleButton.Click

    End Sub
End Class
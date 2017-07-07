Option Strict On
Imports MySql.Data.MySqlClient
Public Class StudentClass
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim yearcnt As Integer
    Dim SYID As String = Main.SYID
    Dim SQLString As String
    Private Sub ClassStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LoadInfo As String = "SELECT distinct yearlevelname " & "FROM tblYearLevel"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearLevelClassComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'myconn.Close()
        End Try
    End Sub
    Dim ClassInteger As Integer
    Private Sub YearLevelClassComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelClassComboBox.SelectedIndexChanged
        AdviserId.Clear()
        ClassListView.Items.Clear()
        AdviserClassFirstComboBox.Text = ""
        AdviserClassFirstComboBox.Items.Clear()
        SectionFirstClassComboBox.Items.Clear()
        SectionFirstClassComboBox.Text = "(none)"
        SectionFirstClassComboBox.Items.Add("(none)")
        AvailableSectionComboBox.Items.Clear()
        AvailableSectionComboBox.Text = ""
        Dim yeargrade As String = ""
        Dim SQLSections As String = "SELECT distinct sectioncode,yeargrade" & " FROM tblYearlevelSections,tblYearLevel" & _
        " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
        " AND yearlevelname='" & YearLevelClassComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSections
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SectionFirstClassComboBox.Items.Add(myreader("sectioncode"))
                DepartmentLabel.Text = "Pre School and Grade School Department"
                yeargrade = myreader("yeargrade").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unablet to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        If yeargrade = "Grade School" Then
            SchoolLabel.Text = "ROSARIO ADVENTIST ELEMENTARY SCHOOL"
            DepartmentLabel.Text = "Pre School and Grade School Department"
            SchoolLabel.Location = New Point(86, 31)
            LogoPictureBox.Location = New Point(16, 31)
            DepartmentLabel.Location = New Point(168, 97)
        Else 'If yeargrade = "High School" Then
            SchoolLabel.Text = "ROSARIO ADVENT HIGH SCHOOL"
            DepartmentLabel.Text = "High School Department"
            SchoolLabel.Location = New Point(135, 31)
            LogoPictureBox.Location = New Point(65, 31)
            DepartmentLabel.Location = New Point(210, 97)
        End If
        AvailableSection()
        SecondSection()
    End Sub


    Private Sub SectionFirstClassComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionFirstClassComboBox.SelectedIndexChanged
        ClassListView.Items.Clear()
        If SectionFirstClassComboBox.Text = "(none)" Then
            SecondSection()
        Else
            FirstSection()
        End If
    End Sub
    Dim AdviserId As New List(Of String)

    Public Sub AvailableSection()
        AvailableSectionComboBox.Items.Clear()
        AvailableSectionComboBox.Text = ""
        Capacity.Clear()
        StudentSection.Clear()
        Dim Sections As New List(Of String)
        Try
            Dim SQLSection As String = "SELECT distinct yearlevelsectioncode" & " FROM tblYearlevelSections,tblYearLevel" & _
        " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
        " AND yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
            " ORDER BY sectionorder"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSection
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Sections.Add(myreader("yearlevelsectioncode").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        For i = 0 To Sections.Count - 1
            Try
                Dim SQLSection As String = "Select yearlevelsectioncode,sectioncode,sectionmaximum-(Select Count(studentsection)  from tblYearLevelSections,tblStudentSections,tblStudentYear,tblYearLevel" & _
                " where tblStudentSections.yearlevelsectioncode = tblYearLevelSections.yearlevelsectioncode" & _
                 " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear  " & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                  " AND yearlevelname='" & YearLevelClassComboBox.Text & "'  AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "') As Capacity from tblYearLevelSections,tblYearLevel" & _
                  " WHERE yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
                  " AND tblYearLevelSections.yearlevelsectioncode='" & Sections.Item(i) & "'" & _
                    " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                  " GROUP by tblYearLevelSections.sectioncode,sectionorder,sectionmaximum" & _
                  " ORDER BY sectionorder DESC"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLSection
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    If CInt(myreader("capacity")) > 0 Then
                        StudentSection.Add(myreader("yearlevelsectioncode").ToString)
                        Capacity.Add(CInt(myreader("capacity")))
                        AvailableSectionComboBox.Items.Add(myreader("sectioncode").ToString)
                    End If
                Loop
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DBBBB.Please try again.a" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Next
    End Sub
    Public Sub FirstSection()
        AdviserId.Clear()
        ClassListView.Items.Clear()
        AdviserClassFirstComboBox.Text = ""
        AdviserClassFirstComboBox.Items.Clear()
        ClassInteger = 0
        Try
            SQLString = "SELECT yearlevelsectioncode,sectionmaximum From tblYearLevelSections,tblYearLevel" & _
            " WHERE yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
        " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND sectioncode='" & SectionFirstClassComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearLevelSection = myreader("yearlevelsectioncode").ToString
                MaxTextBox.Text = myreader("sectionmaximum").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim SQLStudent As String = "SELECT distinct tblStudents.studentid,Concat(st_lname,', ', st_fname) As StudName" & " FROM tblStudents,tblStudentYear,tblYearLevelSections,tblYearLevel,tblStudentSections" & _
      " WHERE tblStudentYear.studentid=tblStudents.studentid AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
      " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
        " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
      " AND yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
      " AND sectioncode='" & SectionFirstClassComboBox.Text & "'" & _
       " ORDER BY st_lname,st_fname,st_mname"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLStudent
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                ClassInteger = ClassInteger + 1
                ClassListView.Items.Add("")
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(ClassInteger.ToString)
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(myreader("studentid").ToString)
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(myreader("StudName").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim SQLTeacher As String = "SELECT distinct tblTeachers.teacherid,Concat(tea_lname,', ', tea_fname) As Teacher" & " FROM tblTeachers,tblYearLevelSchedule,tblYearLevelSections" & _
       " WHERE tblTeachers.teacherid=tblYearLevelSchedule.teacherid AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLTeacher
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                AdviserId.Add(myreader("teacherid").ToString)
                AdviserClassFirstComboBox.Items.Add(myreader("Teacher"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        SQLTeacher = "SELECT Concat(tea_lname,', ', tea_fname) As Teacher" & " FROM tblTeachers,tblYearLevelSections,tblYearLevel" & _
                " WHERE tblTeachers.teacherid=tblYearLevelSections.adviserid " & _
                " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
       " AND yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
       " AND sectioncode='" & SectionFirstClassComboBox.Text & "'"

        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLTeacher
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                MessageBox.Show((myreader("Teacher")).ToString)
                AdviserClassFirstComboBox.Text = CStr((myreader("Teacher")))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        AvailableSection()
    End Sub

    Public Sub SecondSection()
        Dim i As Integer = 0
        Try
            SQLString = "SELECT distinct tblStudents.studentid As studentid, Concat(st_lname,', ', st_fname,' ', st_mname) As StudName FROM tblStudents,tblStudentYear,tblYearLevel,tblStudentYearLevel" & _
          " where tblStudentYear.schoolyearid='" & SYID & "' AND tblStudentYear.studentschoolyear NOT IN (Select tblStudentYear.studentschoolyear FROM tblStudentYear,tblStudentYearLevel,tblStudentSections" & _
           " where tblStudentYear.studentschoolyear =tblStudentYearLevel.studentschoolyear AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
            "  AND tblStudentYear.schoolyearid='" & SYID & "'" & _
            " AND yearlevelname='" & YearLevelClassComboBox.Text & "' AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode)" & _
            " AND yearlevelname='" & YearLevelClassComboBox.Text & "'" & _
            " AND tblStudentYear.studentid =tblStudents.studentid" & _
            " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
            " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
            " ORDER BY st_lname,st_fname,st_mname"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                ClassListView.Items.Add("")
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(i.ToString)
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(myreader("studentid").ToString)
                ClassListView.Items(ClassListView.Items.Count - 1).SubItems.Add(myreader("StudName").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'myconn.Close()
        End Try
    End Sub
    Dim YearLevelSection As String = ""

    Private Sub SaveClassFirstButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveClassFirstButton.Click
        Try
            SQLString = " UPDATE tblYearLevelSections SET adviserid='" & AdviserId.Item(AdviserClassFirstComboBox.SelectedIndex) & "'" & _
                        " WHERE yearlevelsectioncode='" & YearLevelSection & "'"
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch
        End Try
    End Sub


    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To ClassListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                ClassListView.Items(c).Checked = True
            Else
                ClassListView.Items(c).Checked = False
            End If
        Next
    End Sub
    Dim StudentSection As New List(Of String)
    Dim Capacity As New List(Of Integer)

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        For i = 0 To ClassListView.Items.Count - 1
            If ClassListView.Items.Item(i).Checked = True Then
                Try
                    SQLString = " DELETE FROM tblStudentSections WHERE yearlevelsectioncode='" & YearLevelSection & "'" & _
                    " AND studentschoolyear='" & SYID & ClassListView.Items(i).SubItems(2).Text & "'"
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Next
        FirstSection()
    End Sub

    Private Sub TransferButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferButton.Click
        'MessageBox.Show("Check the number of the students you are trying to transfer or change the value of the maximum limit of the section for this message to don't show.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            Dim j As Integer = 0
            For i = 0 To ClassListView.Items.Count - 1
                If ClassListView.Items.Item(i).Checked = True Then

                    AdviserClassFirstComboBox.Text = CStr(Capacity.Item(AvailableSectionComboBox.SelectedIndex))
                    j = j + 1
                    If j <= Capacity.Item(AvailableSectionComboBox.SelectedIndex) Then

                        SQLString = " DELETE FROM tblStudentSections WHERE yearlevelsectioncode='" & YearLevelSection & "'" & _
                        " AND studentschoolyear='" & SYID & ClassListView.Items(i).SubItems(2).Text & "'"
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        Try
                            SQLString = " INSERT INTO tblStudentSections VALUES('" & SYID & ClassListView.Items(i).SubItems(2).Text & YearLevelSection & "','" & SYID & ClassListView.Items(i).SubItems(2).Text & "','" & StudentSection.Item(AvailableSectionComboBox.SelectedIndex) & "')"
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        Catch ex As Exception
                        End Try
                    Else
                        j = j - 1
                        Exit For
                    End If
                End If
            Next
            If j > 0 Then
                MessageBox.Show("Successfully transferred " & j.ToString & " student(s).", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SectionFirstClassComboBox.Text = AvailableSectionComboBox.Text
                AvailableSectionComboBox.Text = ""
            End If
            FirstSection()
        Catch
            MessageBox.Show("No section to transfer.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub


    Private Sub ClassListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassListView.ItemChecked
        If ClassListView.CheckedItems.Count > 0 Then
            AvailableSectionGroupBox.Enabled = True
        Else
            CheckCheckBox.Checked = False
            AvailableSectionGroupBox.Enabled = False
        End If
    End Sub



    
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Main.Show()
        Me.Close()

    End Sub
End Class

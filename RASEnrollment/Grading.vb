Option Strict On
Imports MySql.Data.MySqlClient
Public Class Grading
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SqlString As String
    Dim TeacherID As New List(Of String)
    Dim TeacherName As New List(Of String)
    Dim GradingPeriod As New List(Of String)
    Dim SYID As New List(Of String)
    Private Sub Grading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GradingPeriodComboBox.Enabled = False
        GradingGroupBox.Enabled = False
        TeacherID.Clear()
        TeacherName.Clear()
        Try
            SqlString = "SELECT schoolyearid,schoolyearstart,schoolyearend  From tblSchoolYear"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SYID.Add(myreader("schoolyearid").ToString)
                SYComboBox.Items.Add(myreader.GetMySqlDateTime("schoolyearstart").ToString & "-" & myreader.GetMySqlDateTime("schoolyearend").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        If Main.AdminOrTeacherGrade = 1 Then
            Try
                SqlString = "SELECT Concat(tea_lname,', ',tea_fname,' ',LEFT(tea_mname,1),'.') As Name,teacherid  From tblTeachers" '& _
                '" WHERE teacherstatus='OK'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TeacherID.Add(myreader("teacherid").ToString)
                    TeacherName.Add(myreader("Name").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("vvNo records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            TeacherComboBox.Enabled = True
        Else
            Try
                TeacherID.Add(Welcome.UserID)
                SqlString = "SELECT Concat(tea_lname,', ',tea_mname,' ',LEFT(tea_mname,1),'.')As Name ,teacherid  From tblTeachers" & _
               " WHERE teacherid='" & TeacherID.Item(0) & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TeacherName.Add(myreader("Name").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            TeacherComboBox.Enabled = False
            TeacherComboBox.Text = TeacherName.Item(0)
        End If
        For i = 0 To TeacherID.Count - 1
            TeacherComboBox.Items.Add(TeacherName.Item(i))
        Next
        If Main.AdminOrTeacherGrade = 0 Then
            CloseButton.Visible = False
            TeacherComboBox.Text = TeacherName.Item(0)
        End If
    End Sub
    Dim SubjectCode As String
    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        GradingDataGridView.Columns.Clear()
        GradingDataGridView.Rows.Clear()
        Dim col As New DataGridViewTextBoxColumn
        col.DataPropertyName = "PropertyName"
        col.HeaderText = "Student ID"
        col.Name = "colWhateverName"
        GradingDataGridView.Columns.Add(col)
        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "PropertyName"
        col.HeaderText = "Student Name"
        col.Name = "colWhateverName"
        GradingDataGridView.Columns.Add(col)
        col = New DataGridViewTextBoxColumn
        col.DataPropertyName = "PropertyName"
        col.HeaderText = GradingPeriodComboBox.Text
        col.Name = "colWhateverName"
        GradingDataGridView.Columns.Add(col)
       
        SqlString = "SELECT tblStudents.studentid,Concat(st_lname,',',st_fname,' ',LEFT(st_mname,1)) As Name" & " FROM tblStudents,tblStudentYear,tblSubjects,tblStudentSubjects" & _
         " WHERE tblStudents.studentid=tblStudentYear.studentid" & _
         " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
         " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
  " AND tblStudentSubjects.yearlevelsectioncode='" & YearComboBox.Text & SectionComboBox.Text & "'" & _
  " AND sub_code='" & SubjectComboBox.Text & "'" & _
  " AND tblStudentYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
  " AND studentstatus!='Officially Dropped' AND studentstatus!='UnOfficially Dropped'" & _
  " GROUP BY tblStudents.studentid"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            Dim n As Integer = GradingDataGridView.Rows.Add()
            GradingDataGridView.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
            GradingDataGridView.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
        Loop
        myconn.Close()


        If GradingPeriodComboBox.Text = "Average" Then
            For i = 0 To GradingDataGridView.Rows.Count - 2
                Try
                    SqlString = "SELECT AVG(grade) AS grade " & " FROM tblStudents,tblStudentYear,tblSubjects,tblStudentSubjects" & _
         " WHERE tblStudents.studentid=tblStudentYear.studentid" & _
         " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
         " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
  " AND tblStudentSubjects.yearlevelsectioncode='" & YearComboBox.Text & SectionComboBox.Text & "'" & _
  " AND sub_code='" & SubjectComboBox.Text & "'" & _
  " AND tblStudentYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
  " AND studentstatus!='Officially Dropped' AND studentstatus!='UnOfficially Dropped'" & _
  " AND tblStudents.studentid='" & GradingDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
  " GROUP BY tblStudents.studentid"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SqlString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        GradingDataGridView.Rows.Item(i).Cells(2).Value = myreader("grade").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Next
        ElseIf GradingPeriodComboBox.Text = "ALL" Then
            For j = 0 To GradingPeriodComboBox.Items.Count - 3
                If j = 0 Then
                    GradingDataGridView.Columns(2).HeaderText = GradingPeriodComboBox.Items(j).ToString
                Else
                    col = New DataGridViewTextBoxColumn
                    col.DataPropertyName = "PropertyName"
                    col.HeaderText = GradingPeriodComboBox.Items(j).ToString
                    col.Name = "colWhateverName"
                    GradingDataGridView.Columns.Add(col)
                End If
                For i = 0 To GradingDataGridView.Rows.Count - 2
                    Try
                        SqlString = "SELECT grade " & " FROM tblStudents,tblStudentYear,tblSubjects,tblStudentSubjects,tblGradings" & _
      " WHERE tblStudents.studentid=tblStudentYear.studentid" & _
      " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
      " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
" AND tblStudentSubjects.yearlevelsectioncode='" & YearComboBox.Text & SectionComboBox.Text & "'" & _
" AND sub_code='" & SubjectComboBox.Text & "'" & _
" AND tblStudentYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
" AND studentstatus!='Officially Dropped' AND studentstatus!='UnOfficially Dropped'" & _
" AND tblGradings.gradingperiodid='" & GradingPeriod.Item(j) & "'" & _
" AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                     " AND tblStudents.studentid='" & GradingDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SqlString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            GradingDataGridView.Rows.Item(i).Cells(j + 2).Value = myreader("grade").ToString
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
            Next
        Else
            For i = 0 To GradingDataGridView.Rows.Count - 2
                Try
                    SqlString = "SELECT grade " & " FROM tblStudents,tblStudentYear,tblSubjects,tblStudentSubjects,tblGradings" & _
      " WHERE tblStudents.studentid=tblStudentYear.studentid" & _
      " AND tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
      " AND tblStudentSubjects.subjectcode=tblSubjects.subjectcode" & _
" AND tblStudentSubjects.yearlevelsectioncode='" & YearComboBox.Text & SectionComboBox.Text & "'" & _
" AND sub_code='" & SubjectComboBox.Text & "'" & _
" AND tblStudentYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
" AND studentstatus!='Officially Dropped' AND studentstatus!='UnOfficially Dropped'" & _
" AND tblGradings.gradingperiodid='" & GradingPeriod.Item(GradingPeriodComboBox.SelectedIndex) & "'" & _
" AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                     " AND tblStudents.studentid='" & GradingDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
 " AND tblStudents.studentid='" & GradingDataGridView.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                    " AND tblStudentYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SqlString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        GradingDataGridView.Rows.Item(i).Cells(2).Value = myreader("grade").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Next
        End If

    End Sub

    Private Sub GradingDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GradingDataGridView.CellEndEdit

    End Sub

    Private Sub YearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearComboBox.SelectedIndexChanged

        SectionComboBox.Items.Clear()
        SubjectComboBox.Items.Clear()
        Try
            SqlString = "SELECT distinct sectioncode From tblTeachers,tblYearLevelSchedule,tblYearLevel,tblYearLevelSections" & _
            " WHERE  tblTeachers.teacherid=tblYearLevelSchedule.teacherid" & _
            " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblTeachers.teacherid='" & TeacherID.Item(TeacherComboBox.SelectedIndex) & "'" & _
            " AND yearlevelname='" & YearComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SectionComboBox.Items.Add(myreader("sectioncode").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GradingDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingDataGridView.CellEndEdit
        Try
            Dim y As Integer = GradingDataGridView.CurrentCellAddress.Y
            Dim x As Integer = GradingDataGridView.CurrentCellAddress.X
            Dim grading As String = ""
            Try
                If GradingPeriodComboBox.Text = "ALL" Then
                    For i = 0 To GradingPeriodComboBox.Items.Count - 3
                        If GradingPeriodComboBox.Items(i).ToString = GradingDataGridView.Columns(x).HeaderText Then
                            SqlString = " INSERT INTO tblStudentSubjects VALUES('" & (SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString & Subject.Item(SubjectComboBox.SelectedIndex) & GradingPeriod.Item(i)).Trim & "','" & GradingPeriod.Item(i) & "','" & GradingDataGridView.Rows.Item(y).Cells(x).Value.ToString & "')"
                            Exit For
                        End If
                    Next
                Else
                    SqlString = " INSERT INTO tblStudentSubjects VALUES('" & (SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString & Subject.Item(SubjectComboBox.SelectedIndex) & GradingPeriod.Item(GradingPeriodComboBox.SelectedIndex)).Trim & "','" & GradingPeriod.Item(GradingPeriodComboBox.SelectedIndex) & "','" & GradingDataGridView.Rows.Item(y).Cells(x).Value.ToString & "')"
                End If
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch
                myconn.Close()
                If GradingPeriodComboBox.Text = "ALL" Then
                    For i = 0 To GradingPeriodComboBox.Items.Count - 1
                        If GradingPeriodComboBox.Items(i).ToString = GradingDataGridView.Columns(x).HeaderText Then
                            'MessageBox.Show(GradingDataGridView.Rows.Item(y).Cells(x).Value.ToString)
                            'MessageBox.Show(GradingPeriod.Item(i).ToString)
                            'MessageBox.Show(SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString)
                            'MessageBox.Show(Subject.Item(SubjectComboBox.SelectedIndex))
                            SqlString = " UPDATE tblStudentSubjects SET grade='" & GradingDataGridView.Rows.Item(y).Cells(x).Value.ToString & "'" & _
                            " WHERE gradingperiodid='" & GradingPeriod.Item(i) & "'" & _
                            " AND studentschoolyear='" & SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString & "'" & _
                            " AND subjectcode='" & Subject.Item(SubjectComboBox.SelectedIndex) & "'"
                            Exit For
                        End If
                    Next
                Else
                    SqlString = " UPDATE tblStudentSubjects SET grade='" & GradingDataGridView.Rows.Item(y).Cells(x).Value.ToString & "'" & _
               " WHERE gradingperiodid='" & GradingPeriod.Item(GradingPeriodComboBox.SelectedIndex) & "'" & _
                " AND studentschoolyear='" & SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString & "'" & _
                " AND subjectcode='" & Subject.Item(SubjectComboBox.SelectedIndex) & "'"
                    '" AND studentsubject='" & SYID.Item(SYComboBox.SelectedIndex) & GradingDataGridView.Rows.Item(y).Cells(0).Value.ToString & Subject.Item(SubjectComboBox.SelectedIndex) & GradingPeriod.Item(GradingPeriodComboBox.SelectedIndex) & "'"
                End If
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End Try
        Catch

        End Try
    End Sub
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Main.AdminOrTeacherGrade = 0
        Main.Show()
        Me.Close()
    End Sub

    Private Sub TeacherComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherComboBox.SelectedIndexChanged
        YearComboBox.Text = ""
        YearComboBox.Items.Clear()
        SectionComboBox.Items.Clear()
        SectionComboBox.Text = ""
        SubjectComboBox.Items.Clear()
        SubjectComboBox.Text = ""
        Try
            SqlString = "SELECT distinct yearlevelname From tblTeachers,tblYearLevelSchedule,tblYearLevel,tblYearLevelSections" & _
            " WHERE  tblTeachers.teacherid=tblYearLevelSchedule.teacherid" & _
            " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblTeachers.teacherid='" & TeacherID.Item(TeacherComboBox.SelectedIndex) & "'" & _
            " AND implemented='True'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Dim Subject As New List(Of String)
    Private Sub SectionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionComboBox.SelectedIndexChanged
        SubjectComboBox.Text = ""
        SubjectComboBox.Items.Clear()
        Subject.Clear()
        Try
            SqlString = "SELECT distinct tblSubjects.subjectcode,sub_code From tblSubjects,tblTeachers,tblYearLevelSchedule,tblYearLevel,tblYearLevelSections" & _
            " WHERE  tblTeachers.teacherid=tblYearLevelSchedule.teacherid" & _
            " AND tblSubjects.subjectcode=tblYearLevelSchedule.subjectcode" & _
            " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
            " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
            " AND tblTeachers.teacherid='" & TeacherID.Item(TeacherComboBox.SelectedIndex) & "'" & _
            " AND yearlevelname='" & YearComboBox.Text & "'" & _
            " AND sectioncode='" & SectionComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Subject.Add(myreader("subjectcode").ToString)
                SubjectComboBox.Items.Add(myreader("sub_code").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SYComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYComboBox.SelectedIndexChanged
        GradingPeriodComboBox.Enabled = True
        GradingPeriod.Clear()
        GradingPeriodComboBox.Items.Clear()
        GradingPeriodComboBox.Text = ""
        Try
            SqlString = "SELECT gradingperiodid,gradingname  From tblGradings,tblSchoolYear" & _
            " WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
            " AND tblSchoolYear.schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                GradingPeriod.Add(myreader("gradingperiodid").ToString)
                GradingPeriodComboBox.Items.Add(myreader("gradingname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        GradingPeriodComboBox.Items.Add("ALL")
        GradingPeriodComboBox.Items.Add("Average")
    End Sub
    Private Sub GradingDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GradingDataGridView.CellContentClick

    End Sub
    Private Sub GradingPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingPeriodComboBox.SelectedIndexChanged
        GradingGroupBox.Enabled = True
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingGroupBox.Enter

    End Sub
    Private Sub GradingSystemGroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingSystemGroupBox.Enter

    End Sub
End Class
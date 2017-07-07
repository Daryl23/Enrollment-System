Option Strict On
Imports MySql.Data.MySqlClient
Public Class Teachers
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim LoadInfo As String
    Dim TeaIDCNT As Integer
    Dim MaxSYID As String
    Public Sub TeacherID()
        Dim SqlSelect As String = "Select MAX(schoolyearid) As syid,date(schoolyearstart) As datefrom,date(schoolyearend) As dateto  from tblSchoolYear" & _
            " ORDER BY schoolyearstart DESC"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlSelect
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            MaxSYID = myreader("syid").ToString
        Loop
        myconn.Close()
        LoadInfo = "Select Count(teacherid) As teacher From tblTeachers"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                TeaIDCNT = CInt(myreader("teacher")) + 1
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        TeacherIDTextBox.Text = MaxSYID & "-" & "T" & TeaIDCNT.ToString("000")

        LoadInfo = "SELECT yearlevelname " & "FROM tblYearLevel" & _
        " ORDER BY yeargrade,yearorder"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearNameComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("No records foundc." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Teachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ViewTeachers()
        TeacherIDTextBox.Enabled = False
        TeacherID()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If TeacherLNameTextBox.Text = "" Or TeacherContactTextBox.Text = "" Or TeacherAddressTextBox.Text = "" _
        Or TeacherFNameTextBox.Text = "" Or TeacherMNameTextBox.Text = "" Then
            MessageBox.Show("All fields are required except Email Field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(TeacherLNameTextBox.Text) Or IsNumeric(TeacherFNameTextBox.Text) Or IsNumeric(TeacherMNameTextBox.Text) _
        Or IsNumeric(TeacherAddressTextBox.Text) Or IsNumeric(TeacherEmailTextBox.Text) Then
            MessageBox.Show("ONLY contact information should BE numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not IsNumeric(TeacherContactTextBox.Text) Then
            MessageBox.Show("Teacher contact information field should BE numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TeacherLNameTextBox.Enabled = False Then
            LoadInfo = "UPDATE tblTeachers SET tea_address='" & TeacherAddressTextBox.Text & "' WHERE teacherid='" & TeacherIDTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            mycommand.ExecuteNonQuery()
            myconn.Close()
            LoadInfo = "UPDATE tblTeachers SET tea_contactno='" & TeacherContactTextBox.Text & "' WHERE teacherid='" & TeacherIDTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            mycommand.ExecuteNonQuery()
            myconn.Close()
            LoadInfo = "UPDATE tblTeachers SET tea_email='" & TeacherEmailTextBox.Text & "' WHERE teacherid='" & TeacherIDTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            mycommand.ExecuteNonQuery()
            myconn.Close()
            TeacherID()
            ViewTeachers()
            MessageBox.Show("Successfully updated teacher information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim SQLString As String

            SQLString = "INSERT INTO tblTeachers(teacherid,tea_lname,tea_fname,tea_mname,tea_address,tea_contactno,tea_email,teacherstatus)" & "VALUES ('" & TeacherIDTextBox.Text.Trim() & "','" & TeacherLNameTextBox.Text.Trim() & "','" & TeacherFNameTextBox.Text.Trim() & "','" & TeacherMNameTextBox.Text.Trim() & "','" & TeacherAddressTextBox.Text.Trim() & "','" & TeacherContactTextBox.Text.Trim() & "','" & TeacherEmailTextBox.Text.Trim() & "','OK'" & ")"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            TeacherID()
            ViewTeachers()
            MessageBox.Show("Successfully added new teacher information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' LoadInfo = "Delete from tblTeacherSubjects where teacherid = '" & TeacherIDTextBox.Text.Trim() & "'"
            ' myconn.ConnectionString = CONNECTION_STRING
            'myconn.Open()
            'mycommand.Connection = myconn
            'mycommand.CommandText = LoadInfo
            'mycommand.ExecuteNonQuery()
            'myconn.Close()
            'For i = 0 To SubjectListView.Items.Count - 1
            'SQLString = "INSERT INTO tblTeacherSubjects(teacherid,subjectcode)" & "VALUES ('" & TeacherIDTextBox.Text.Trim() & "','" & SubjectListView.Items(i).Text.Trim() & "')"
            'myconn.ConnectionString = CONNECTION_STRING
            ' myconn.Open()
            'mycommand.Connection = myconn
            'mycommand.CommandText = SQLString
            'mycommand.ExecuteNonQuery()
            'myconn.Close()
            'Next
        End If
       
        'ViewSubject()
    End Sub
    Private Sub FeesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesButton.Click
        Me.Close()
        Fees.Show()
    End Sub
    Private Sub FeesPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesPictureBox.Click
        Me.Close()
        Fees.Show()
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub RoomsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsButton.Click
        Me.Close()
        Rooms.Show()
    End Sub
    Private Sub RoomsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsPictureBox.Click
        Me.Close()
        Rooms.Show()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To TeacherListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                TeacherListView.Items(c).Checked = True
            Else
                TeacherListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To TeacherListView.Items.Count - 1
            If TeacherListView.Items.Item(g).Checked = True Then
                LoadInfo = "UPDATE tblTeachers SET teacherstatus='Resigned' Where teacherid = '" & TeacherListView.Items(g).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = LoadInfo
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        TeacherID()
        ViewTeachers()
        'ViewSubject()
    End Sub
    Public Sub ViewTeachers()
        ClearAll()
        TeacherListView.Items.Clear()
        Dim i As Integer = 0
        Dim SQLTeachers As String = "SELECT teacherid,Concat(tea_lname, tea_fname,tea_mname) As Name,tea_address,tea_contactno,tea_email" & " FROM tblTeachers "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLTeachers
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                TeacherListView.Items.Add(i.ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("teacherid").ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("Name").ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("tea_address").ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("tea_contactno").ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("tea_email").ToString)
                TeacherListView.Items(TeacherListView.Items.Count - 1).SubItems.Add(myreader("Name").ToString)

            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub ClearAll()

        TeacherLNameTextBox.Enabled = True
        TeacherMNameTextBox.Enabled = True
        TeacherFNameTextBox.Enabled = True

        'SpecializationTextBox.Enabled = True
        TeacherLNameTextBox.Text = ""
        TeacherMNameTextBox.Text = ""
        TeacherFNameTextBox.Text = ""
        TeacherEmailTextBox.Text = ""
        TeacherContactTextBox.Text = ""
        TeacherAddressTextBox.Text = ""
        'SpecializationTextBox.Text = ""
    End Sub
    Dim teacherlname As String
    Dim teacherfname As String
    Dim teachermname As String
    Private Sub TeachersListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherListView.Click
        For a = 0 To TeacherListView.Items.Count - 1
            If TeacherListView.Items.Item(a).Selected = True Then
                TeacherIDTextBox.Enabled = False
                TeacherLNameTextBox.Enabled = False
                TeacherMNameTextBox.Enabled = False
                TeacherFNameTextBox.Enabled = False
                'SpecializationTextBox.Enabled = False

                TeacherIDTextBox.Text = TeacherListView.Items(a).SubItems(1).Text
                TeacherEmailTextBox.Text = TeacherListView.Items(a).SubItems(5).Text
                TeacherContactTextBox.Text = TeacherListView.Items(a).SubItems(4).Text
                TeacherAddressTextBox.Text = TeacherListView.Items(a).SubItems(3).Text
                LoadInfo = "SELECT tea_lname,tea_fname,tea_mname " & "FROM tblTeachers" & _
           " WHERE teacherid='" & TeacherListView.Items(a).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = LoadInfo
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    teacherlname = myreader("tea_lname").ToString
                    teacherfname = myreader("tea_fname").ToString
                    teachermname = myreader("tea_mname").ToString
                Loop
                TeacherLNameTextBox.Text = teacherlname
                TeacherMNameTextBox.Text = teachermname
                TeacherFNameTextBox.Text = teacherfname
                myconn.Close()
            End If
        Next
    End Sub


    Private Sub YearNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearNameComboBox.SelectedIndexChanged
        SectionComboBox.Items.Clear()
        SectionComboBox.Text = ""
        Dim SQLSections As String = "SELECT sectioncode" & " FROM tblYearlevelSections,tblYearLevel where tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
        " AND yearlevelname='" & YearNameComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLSections
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                'SectionList.Add(myreader("sectioncode").ToString)
                SectionComboBox.Items.Add(myreader("sectioncode"))
            Loop

            myconn.Close()
        Catch ex As Exception
            myconn.Close()
        End Try
    End Sub


    Private Sub SectionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionComboBox.SelectedIndexChanged
        SubjectComboBox.Items.Clear()
        SubjectList.Clear()
        SubjectComboBox.Text = ""
        LoadInfo = " Select tblSubjects.subjectcode,sub_code From tblSubjects,tblYearLevelSubjects,tblYearLevel,tblYearLevelSections" & _
         " where tblSubjects.subjectcode = tblYearLevelSubjects.subjectcode And tblYearlevel.yearlevelcode = tblYearLevelSubjects.yearlevelcode " & _
          " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
        " AND yearlevelname='" & YearNameComboBox.Text & "'" & _
         " AND sectioncode='" & SectionComboBox.Text & "'" & _
             " GROUP BY tblSubjects.subjectcode"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SubjectList.Add(myreader("subjectcode").ToString)
                SubjectComboBox.Items.Add(myreader("sub_code"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub AddSubjectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectButton.Click
        If SubjectListView.Items.Count > 0 Then
            Dim j As Integer = 0
            For i = 0 To SubjectListView.Items.Count - 1
                If SubjectComboBox.Text = SubjectListView.Items(i).SubItems(1).Text Then
                    j = 1
                End If
            Next
            If j = 1 Then
                MessageBox.Show("Unable to add. There's already a same subject name in the list.")
            Else
                SubjectListView.Items.Add((SubjectListView.Items.Count + 1).ToString)
                SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(SubjectComboBox.Text)
            End If
        Else
            SubjectListView.Items.Add((SubjectListView.Items.Count + 1).ToString)
            SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(SubjectComboBox.Text)
        End If
    End Sub

    Private Sub TeacherListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherListView.SelectedIndexChanged

    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        For g = 0 To SubjectListView.Items.Count - 1
            If SubjectListView.Items.Item(g).Checked = True Then
                SubjectListView.Items(g).Remove()
            End If
        Next
        ViewSubject()
    End Sub
    Dim SubjectList As New List(Of String)
    Public Sub ViewSubject()
        SubjectListView.Items.Clear()
        SubjectList.Clear()
        Dim i As Integer = 0
        LoadInfo = " Select tblSubjects.subjectcode,sub_code From tblSubjects,tblTeachers,tblTeacherSubjects" & _
      " where tblSubjects.subjectcode = tblTeacherSubjects.subjectcode " & _
      " AND tblTeachers.teacherid=tblTeacherSubjects.teacherid" & _
      " AND tblTeachers.teacherid='" & TeacherIDTextBox.Text & "'"

        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                SubjectList.Add(myreader("sub_code").ToString)
                SubjectListView.Items.Add(i.ToString)
                SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(myreader("sub_code").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
        TeacherID()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
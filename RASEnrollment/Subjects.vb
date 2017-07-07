Option Strict On
Imports MySql.Data.MySqlClient
Public Class Subjects
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SQLString As String
    Dim ValidationCount As Integer = 0
    Dim SYID As String = Main.SYID
    Public Sub MaintainanceValidation()
        SQLString = "SELECT  Count(tblStudents.studentid) As validationcount from tblStudents,tblStudentYear " & _
        " WHERE tblStudents.studentid=tblStudentYear.studentid AND schoolyearid='" & SYID & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            ValidationCount = CInt(myreader("validationcount"))
        Loop
        myconn.Close()
    End Sub
    Private Sub Subjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MaintainanceValidation()
        If ValidationCount > 0 Then
            CheckCheckBox.Enabled = False
            DeleteButton.Enabled = False
            GroupBox3.Enabled = False
        Else
            CheckCheckBox.Enabled = True
            DeleteButton.Enabled = True
            GroupBox3.Enabled = True
        End If
        SQLString = "SELECT distinct yearlevelname" & " FROM tblYearLevel"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            YearNameComboBox.Items.Add(myreader("yearlevelname").ToString)
        Loop
        myconn.Close()
    End Sub
    Public Sub ViewSubject()
        ClearAll()
        SubjectTextBox.Clear()
        SubjectListView.Items.Clear()
        Dim i As Integer = 0
        SQLString = "SELECT yearlevelname,sub_code,sub_name,unit " & "FROM tblSubjects,tblYearLevel,tblYearLevelSubjects" & _
        " WHERE tblYearLevel.yearlevelcode=tblYearLevelSubjects.yearlevelcode" & _
        " AND tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode" & _
        " AND yearlevelname='" & YearNameComboBox.Text & "'" & _
        " GROUP BY sub_code" & _
        " ORDER BY sub_name"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            i = i + 1
            SubjectListView.Items.Add(i.ToString)
            SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(myreader("sub_code").ToString)
            SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(myreader("sub_name").ToString)
            SubjectListView.Items(SubjectListView.Items.Count - 1).SubItems.Add(myreader("unit").ToString)
        Loop
        myconn.Close()
    End Sub
    Dim yearlevel As String
    Private Sub AddSubjectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If IsNumeric(SubjectTextBox.Text) Then
            MessageBox.Show("Subject field should NOT be numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'ElseIf Not IsNumeric(UnitTextBox.Text) Then
            ' MessageBox.Show("Unit field should BE numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf YearNameComboBox.Enabled = False Then
            Try
                SQLString = "UPDATE tblSubjects SET sub_name='" & SubjectTextBox.Text & "' where sub_code = '" & subjectcode & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblSubjects SET unit='" & CDec(UnitTextBox.Text) & "' where sub_code = '" & subjectcode & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch
                myconn.Close()
                MessageBox.Show("1 Entry Detected: (Subject)", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            ViewSubject()
        Else

            Dim yeargrade As String = ""
            SQLString = "SELECT yearlevelcode,yearlevelname " & "FROM tblYearLevel" & _
            " WHERE yearlevelname='" & YearNameComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                yearlevel = myreader("yearlevelcode").ToString
                yeargrade = myreader("yearlevelname").ToString.Substring(myreader("yearlevelname").ToString.LastIndexOf(" ") + 1)
            Loop
            myconn.Close()

            Try
                SQLString = "INSERT INTO tblSubjects(subjectcode,sub_code,sub_name,unit)" & "VALUES ('" & (SubjectTextBox.Text & YearNameComboBox.Text).Trim & "','" & SubjectTextBox.Text & yeargrade & "','" & SubjectTextBox.Text.Trim() & "'," & CDec(UnitTextBox.Text) & ")"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = " INSERT INTO tblYearLevelSubjects(yearlevelcode,subjectcode)" & "VALUES ('" & yearlevel & "','" & (SubjectTextBox.Text & YearNameComboBox.Text).Trim & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                MessageBox.Show("Duplicate Entry Detected: (Subject)" & ex.Message, "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                SQLString = " INSERT INTO tblunits(unit,cost)" & "VALUES (" & CDec(UnitTextBox.Text) & ",0)"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
            End Try
            ViewSubject()
        End If

    End Sub
    Private Sub YearNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearNameComboBox.SelectedIndexChanged
        ViewSubject()
    End Sub
    Dim subjectcode As String
    Private Sub SubjectListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectListView.Click
        ClearAll()
        SubjectTextBox.Text = ""
        For a = 0 To SubjectListView.Items.Count - 1
            If SubjectListView.Items.Item(a).Selected = True Then
                SQLString = "SELECT yearlevelname,unit " & "FROM tblSubjects,tblYearLevel,tblYearLevelSubjects" & _
                " WHERE tblYearLevel.yearlevelcode=tblYearLevelSubjects.yearlevelcode" & _
                " AND tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode" & _
                " AND sub_code='" & SubjectListView.Items(a).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    yearlevel = myreader("yearlevelname").ToString
                Loop
                myconn.Close()
                YearNameComboBox.Text = yearlevel
                SubjectTextBox.Text = SubjectListView.Items(a).SubItems(2).Text
                YearNameComboBox.Enabled = False
                subjectcode = SubjectListView.Items(a).SubItems(1).Text
                UnitTextBox.Text = SubjectListView.Items(a).SubItems(3).Text
            End If
        Next
    End Sub
    Public Sub ClearAll()
        YearNameComboBox.Enabled = True
        SubjectTextBox.Text = ""
        'UnitTextBox.Text = ""
        SaveButton.Enabled = True
        ClearButton.Enabled = True
        SubjectTextBox.Enabled = True
        UnitTextBox.Enabled = True
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

    Private Sub SectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionButton.Click
        Me.Close()
        Section.Show()
    End Sub

    Private Sub SectionPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionPictureBox.Click
        Me.Close()
        Section.Show()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To SubjectListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                SubjectListView.Items(c).Checked = True
            Else
                SubjectListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To SubjectListView.Items.Count - 1
            If SubjectListView.Items.Item(g).Checked = True Then
                Dim subjectcode As String = ""
                SQLString = "SELECT tblSubjects.subjectcode As subjectcode " & "FROM tblSubjects,tblYearLevelSubjects,tblYearLevel" & _
                " WHERE sub_code='" & SubjectListView.Items(g).SubItems(1).Text & "'" & _
                " AND tblSubjects.subjectcode=tblYearLevelSubjects.subjectcode" & _
                " AND tblYearLevelSubjects.yearlevelcode=tblYearLevel.yearlevelcode" & _
                " AND yearlevelname='" & YearNameComboBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    subjectcode = myreader("subjectcode").ToString
                Loop
                myconn.Close()
                SQLString = "Delete from tblYearLevelSubjects where subjectcode= '" & subjectcode & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Delete from tblSubjects where subjectcode = '" & subjectcode & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewSubject()
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    Private Sub SubjectListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectListView.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
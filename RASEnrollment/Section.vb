Option Strict On
Imports MySql.Data.MySqlClient
Public Class Section
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim yearcnt As Integer
    Dim SQLString As String
    Dim yearlevel As String
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
    Private Sub AddSectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If Not IsNumeric(MaxTextBox.Text) Then
            MessageBox.Show("Maximum capacity field should BE numeric.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf YearNameComboBox.Text = "" Or SectionTextBox.Text = "" Or MaxTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf YearNameComboBox.Enabled = False Then
            Dim MaximumInteger As Integer = CInt(MaxTextBox.Text)
            Try
                SQLString = "UPDATE tblYearLevelSections" & " SET sectionmaximum= '" & MaximumInteger.ToString & "'" & " WHERE yearlevelsectioncode= '" & yearsection & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            Dim MaximumInteger As Integer = CInt(MaxTextBox.Text)
            Try
                SQLString = "SELECT yearlevelcode " & "FROM tblYearLevel" & _
                " WHERE yearlevelname='" & YearNameComboBox.Text & "'" 
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    yearlevel = myreader("yearlevelcode").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
          
            Try

                SQLString = " INSERT INTO tblYearLevelSections(yearlevelsectioncode,yearlevelcode,sectioncode,sectionorder,sectionmaximum)" & _
                " VALUES ('" & YearNameComboBox.Text.Trim & SectionTextBox.Text & "','" & yearlevel & "','" & SectionTextBox.Text & "'," & SectionListView.Items.Count & "," & MaximumInteger.ToString & ")"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                MessageBox.Show("There's already a same data in the database." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        ClearAll()
        ViewSections()
    End Sub
    Public Sub ViewSections()
        SectionTextBox.Clear()
        SectionListView.Items.Clear()
        Dim i As Integer = 0
        Try
            SQLString = "SELECT  sectioncode,sectionmaximum from tblYearLevel,tblYearLevelSections" & _
            " where tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode " & _
            " AND yearlevelname='" & YearNameComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                SectionListView.Items.Add(i.ToString)
                SectionListView.Items(SectionListView.Items.Count - 1).SubItems.Add(myreader("sectioncode").ToString)
                SectionListView.Items(SectionListView.Items.Count - 1).SubItems.Add(myreader("sectionmaximum").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_View." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



    Dim yearsection As String
    Dim section As String

    Private Sub SectionListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionListView.Click
        For a = 0 To SectionListView.Items.Count - 1
            If SectionListView.Items.Item(a).Selected = True Then

                YearNameComboBox.Enabled = False
                SectionTextBox.Text = SectionListView.SelectedItems(0).SubItems(1).Text
                MaxTextBox.Text = SectionListView.SelectedItems(0).SubItems(2).Text
                MaxTextBox.Enabled = True
                SaveButton.Enabled = True
                ClearButton.Enabled = True
                Try
                    SQLString = "SELECT yearlevelcode " & "FROM tblYearLevel" & _
                    " WHERE yearlevelname='" & YearNameComboBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        yearlevel = myreader("yearlevelcode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Try
                    SQLString = "SELECT yearlevelsectioncode" & " FROM tblYearLevel,tblYearLevelSections" & _
                    " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND sectioncode='" & SectionListView.SelectedItems(0).SubItems(1).Text & "'" & _
                    " AND yearlevelname='" & YearNameComboBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        yearsection = myreader("yearlevelsectioncode").ToString
                    Loop
                    'YearNameComboBox.Text = yearsection
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Next
    End Sub

    Private Sub Section_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearAll()
        MaintainanceValidation()
        If ValidationCount > 0 Then
            DeleteButton.Enabled = False
        Else
            DeleteButton.Enabled = True
        End If
        myconn.Close()
        SQLString = "Select MAX(schoolyearid) As sy from tblSchoolYear"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                'SYID = CStr(myreader("sy"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        YearNameComboBox.Text = ""
        YearNameComboBox.Items.Clear()
        Try
            SQLString = "SELECT yearlevelname " & "FROM tblYearLevel"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YearNameComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubjectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectButton.Click
        Me.Close()
        Subjects.Show()
    End Sub

    Private Sub SubjectPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectPictureBox.Click
        Me.Close()
        Subjects.Show()
    End Sub

    Private Sub YearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearButton.Click
        Me.Close()

        Year.Show()
    End Sub

    Private Sub YearPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearPictureBox.Click
        Me.Close()
        Year.Show()
    End Sub



    Public Sub ClearAll()
        YearNameComboBox.Enabled = True
        SectionTextBox.Text = ""
        MaxTextBox.Text = ""
        SaveButton.Enabled = False
        ClearButton.Enabled = False
        SectionTextBox.Enabled = False
        MaxTextBox.Enabled = False
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    Private Sub YearNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearNameComboBox.SelectedIndexChanged
        If YearNameComboBox.Text = "" Then
            ClearAll()
        Else
            ClearButton.Enabled = True
            SaveButton.Enabled = True
            MaxTextBox.Enabled = True
            SectionTextBox.Enabled = True
        End If
        ViewSections()
    End Sub


    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Try
            Dim ScheduleKey As New List(Of String)
            SQLString = "Select yearlevelschedulekey from tblYearLevelSchedule,tblYearLevel,tblYearLevelSections " & _
                " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                " AND tblYearLevelSchedule.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                " AND yearlevelname='" & YearNameComboBox.Text & "'" & _
                " AND sectioncode='" & SectionListView.Items(SectionListView.Items.Count - 1).SubItems(1).Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                ScheduleKey.Add(myreader("yearlevelschedulekey").ToString)
            Loop
            myconn.Close()
            If ScheduleKey.Count > 0 Then
                Dim result As Integer = MessageBox.Show("There are schedule information for " & YearNameComboBox.Text & "-" & SectionListView.Items(SectionListView.Items.Count - 1).SubItems(1).Text & " that will also be deleted once proceeding. Do you want to proceed?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Try
                        SQLString = "SELECT  yearlevelsectioncode" & " FROM tblYearLevel,tblYearLevelSections" & _
                        " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                        " AND sectioncode='" & SectionListView.Items(SectionListView.Items.Count - 1).SubItems(1).Text & "'" & _
                        " AND yearlevelname='" & YearNameComboBox.Text & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            yearsection = myreader("sectioncode").ToString
                        Loop
                        'YearNameComboBox.Text = yearsection
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("Err_Section_Delete" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    Try
                        SQLString = "DELETE FROM tblYearLevelSections WHERE yearlevelsectioncode='" & yearsection & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If
            Else
                Try
                    SQLString = "SELECT yearlevelsectioncode " & " FROM tblYearLevel,tblYearLevelSections" & _
                    " WHERE tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                    " AND sectioncode='" & SectionListView.Items(SectionListView.Items.Count - 1).SubItems(1).Text & "'" & _
                    " AND yearlevelname='" & YearNameComboBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        yearsection = myreader("yearlevelsectioncode").ToString
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Try
                    SQLString = "DELETE FROM tblYearLevelSections WHERE yearlevelsectioncode='" & yearsection & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
            ViewSections()
        Catch
            MessageBox.Show("No section to delete.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub SectionListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionListView.SelectedIndexChanged

    End Sub

    Private Sub SectionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionTextBox.TextChanged

    End Sub
End Class
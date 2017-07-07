Option Strict On
Imports MySql.Data.MySqlClient
Public Class Records
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"    ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SQLString As String
    Dim Discount As New List(Of String)
    Dim Rate As New List(Of Decimal)
    Dim StudentRate As Decimal
    Dim yeargrade As String
    Dim yearorder As Integer
    Dim studenttype As String
    Dim SYID As String
    Private Sub Records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLString = "SELECT tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,st_type,st_bdate,st_gender,st_religion,st_address,st_contactno,fa_name,fa_contactno," & _
        "fa_occupation,mo_name,yearlevelname,mo_contactno,mo_occupation,MAX(Schoolyearid) As SYID,gua_name,gua_relationship,gua_contactno " & "FROM tblStudents,tblStudentYear,tblStudentYearLevel,tblYearLevel " & _
      " WHERE tblStudents.studentid='" & Main.StudentRecord & "' AND tblStudents.studentid=tblStudentYear.studentid" & _
      " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode AND tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear"

        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim BDate As Date = myreader.GetDateTime("st_bdate")
                StudentIDTextBox.Text = myreader("studentid").ToString
                StudentNameTextBox.Text = myreader("Name").ToString
                BirthDateTextBox.Text = BDate.ToString("MM/dd/yyyy")
                GradeTextBox.Text = myreader("yearlevelname").ToString
                GenderTextBox.Text = (myreader("st_gender").ToString)
                studenttype = (myreader("st_type").ToString)
                ReligionComboBox.Text = (myreader("st_religion").ToString)
                AddressTextBox.Text = (myreader("st_address").ToString)
                ContactTextBox.Text = (myreader("st_contactno").ToString)
                FatherNameTextBox.Text = (myreader("fa_name").ToString)
                FatherContactNoTextBox.Text = (myreader("fa_contactno").ToString)
                FatherOccupationTextBox.Text = (myreader("fa_occupation").ToString)
                MotherNameTextBox.Text = (myreader("mo_name").ToString)
                MotherContactNoTextBox.Text = (myreader("mo_contactno").ToString)
                MotherOccupationTextBox.Text = (myreader("mo_occupation").ToString)
                SYID = myreader("SYID").ToString
                If myreader("gua_relationship").ToString = "Parents" Then
                    ParentsRadioButton.Checked = True
                Else
                    GuardianContactTextBox.Clear()
                    GuardianRelationshipTextBox.Text = "Relative"
                    GuardianNameTextBox.Clear()
                    GuardianNameTextBox.Text = myreader("gua_name").ToString
                    GuardianRelationshipTextBox.Text = myreader("gua_relationship").ToString
                    GuardianContactTextBox.Text = myreader("gua_contactno").ToString
                End If
                ParentsRadioButton.Enabled = False
                OthersRadioButton.Enabled = False
                ReligionComboBox.Enabled = False
                GroupBox16.Enabled = False
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found.a" & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        SQLString = "Select yeargrade,yearorder FROM tblYearLevel WHERE yearlevelname='" & GradeTextBox.Text & "'"
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
        Dim LoadRequirements As String = "SELECT distinct req_name FROM tblRequirements,tblYearLevel" & _
      " WHERE tblYearLevel.yeargrade=tblRequirements.yeargrade" & _
      " AND tblYearLevel.yeargrade='" & yeargrade & "'" & _
       " AND student_type='" & studenttype & "'"
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
       " WHERE studentid='" & StudentIDTextBox.Text & "'"
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
    End Sub
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub EditSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            ReligionComboBox.Enabled = True
            ParentsRadioButton.Enabled = True
            OthersRadioButton.Enabled = True
            ContactTextBox.Enabled = True
            FatherOccupationTextBox.Enabled = True
            FatherContactNoTextBox.Enabled = True
            MotherContactNoTextBox.Enabled = True
            MotherOccupationTextBox.Enabled = True
            GuardianNameTextBox.Enabled = True
            GuardianRelationshipTextBox.Enabled = True
            GuardianContactTextBox.Enabled = True
            GroupBox16.Enabled = True
            EditSaveButton.Text = "&Save"
        Else
            Dim err As Integer = 0
            Dim contact As Integer
            Try
                contact = CInt(ContactTextBox.Text)
                contact = CInt(FatherContactNoTextBox.Text)
                contact = CInt(MotherContactNoTextBox.Text)
                contact = CInt(GuardianContactTextBox.Text)
            Catch
                err = 2
            End Try
            If ReligionComboBox.Text = "" Or FatherOccupationTextBox.Text = "" Or ContactTextBox.Text = "" _
            Or FatherOccupationTextBox.Text = "" Or FatherContactNoTextBox.Text = "" Or MotherOccupationTextBox.Text = "" Or MotherContactNoTextBox.Text = "" Then
                err = 2
            End If
            If OthersRadioButton.Checked = True Then
                If GuardianNameTextBox.Text = "" Or GuardianRelationshipTextBox.Text = "" Or GuardianContactTextBox.Text = "" Then
                    err = 2
                End If
            End If
            If err = 0 Then
                SQLString = "UPDATE tblStudents " & " SET st_contactno='" & ContactTextBox.Text & "'" & _
                            " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()

                SQLString = "UPDATE tblStudents " & " SET fa_contactno='" & FatherContactNoTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET fa_occupation='" & FatherOccupationTextBox.Text & "'" & _
                                       " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET mo_contactno='" & MotherContactNoTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET mo_occupation='" & MotherOccupationTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET gua_name='" & GuardianNameTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET gua_relationship='" & GuardianRelationshipTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET gua_contactno='" & GuardianContactTextBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "UPDATE tblStudents " & " SET st_religion='" & ReligionComboBox.Text & "'" & _
                           " WHERE studentid='" & Main.StudentRecord & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                Try
                    Dim SQlInsert As String = "DELETE FROM tblStudentRequirements WHERE studentid='" & StudentIDTextBox.Text & "'"
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
                        SQLString = "INSERT INTO tblStudentRequirements(studentid,studentrequirements,studentschoolyear,requirementcleared) VALUES('" & StudentIDTextBox.Text & "','" & RequirementsDataGridView.Rows.Item(i).Cells(0).Value.ToString & "','" & SYID & StudentIDTextBox.Text & "','" & RequirementsDataGridView.Rows.Item(i).Cells(1).Value.ToString & "')"

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
                ReligionComboBox.Enabled = False
                ParentsRadioButton.Enabled = False
                OthersRadioButton.Enabled = False
                ContactTextBox.Enabled = False
                FatherOccupationTextBox.Enabled = False
                FatherContactNoTextBox.Enabled = False
                MotherContactNoTextBox.Enabled = False
                MotherOccupationTextBox.Enabled = False
                GuardianNameTextBox.Enabled = False
                GuardianRelationshipTextBox.Enabled = False
                GuardianContactTextBox.Enabled = False
                GroupBox16.Enabled = False
                EditSaveButton.Text = "&Edit"

            ElseIf err = 1 Then
                MessageBox.Show("Invalid Input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("All fields are required", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ParentsRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentsRadioButton.CheckedChanged
        GuardianNameLabel.Visible = False
        GuardianContactLabel.Visible = False
        GuardianRelationshipLabel.Visible = False
        GuardianNameTextBox.Visible = False
        GuardianContactTextBox.Visible = False
        GuardianRelationshipTextBox.Visible = False
        GuardianNameTextBox.Visible = False
        GuardianContactTextBox.Clear()
        GuardianRelationshipTextBox.Text = "Parents"
        GuardianNameTextBox.Clear()
    End Sub


    Private Sub OthersRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersRadioButton.CheckedChanged
        GuardianNameTextBox.Visible = True
        GuardianContactTextBox.Visible = True
        GuardianNameTextBox.Visible = True
        GuardianRelationshipTextBox.Visible = True
        GuardianNameLabel.Visible = True
        GuardianContactLabel.Visible = True
        GuardianRelationshipLabel.Visible = True
    End Sub

    Private Sub BirthDateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDateTextBox.TextChanged
        Dim Age As Integer
        If DatePart(DateInterval.Year, Date.Today) >= DatePart(DateInterval.Year, CDate(BirthDateTextBox.Text)) Then
            Age = DatePart(DateInterval.Year, Date.Today) - DatePart(DateInterval.Year, CDate(BirthDateTextBox.Text))
            If DatePart(DateInterval.Month, Date.Today) < DatePart(DateInterval.Month, CDate(BirthDateTextBox.Text)) Then
                Age = Age - 1
            ElseIf DatePart(DateInterval.Month, Date.Today) = DatePart(DateInterval.Month, CDate(BirthDateTextBox.Text)) Then
                If DatePart(DateInterval.Day, Date.Today) > DatePart(DateInterval.Day, CDate(BirthDateTextBox.Text)) Then
                    Age = Age - 1
                    If Age < 0 Then
                        Age = 0
                    End If
                ElseIf DatePart(DateInterval.Day, Date.Today) = DatePart(DateInterval.Day, CDate(BirthDateTextBox.Text)) Then
                    Age = Age
                End If
            End If
        Else
            MessageBox.Show("Invalid input.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        AgeTextBox.Text = Age.ToString
    End Sub

    Private Sub ReligionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReligionComboBox.SelectedIndexChanged
        If ReligionComboBox.Text = "Adventist" Then
        Else
            ReligionComboBox.Text = ""
        End If
    End Sub
End Class
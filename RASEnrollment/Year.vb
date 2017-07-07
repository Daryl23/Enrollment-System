Option Strict On
Imports MySql.Data.MySqlClient
Public Class Year
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SYID As String = Main.SYID
    Dim ValidationCount As Integer = 0
    Public Sub MaintainanceValidation()
        SqlString = "SELECT  Count(tblStudents.studentid) As validationcount from tblStudents,tblStudentYear " & _
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
    Private Sub YrLevelSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' MaintainanceValidation()
        If ValidationCount > 0 Then
            CheckCheckBox.Enabled = False
            DeleteYearButton.Enabled = False
            GroupBox3.Enabled = False
        Else
            CheckCheckBox.Enabled = True
            DeleteYearButton.Enabled = True
            GroupBox3.Enabled = True
        End If
        ClearAll()
        ViewYear()
    End Sub
    Public Sub UponClose()
        Me.Close()
    End Sub
    Dim SqlString As String
    Public Sub ViewYear()
        YearLevelTextBox.Clear()
        YearListView.Items.Clear()
        Dim i As Integer = 0
        SqlString = "SELECT  yearlevelname from tblYearLevel WHERE yeargrade='" & GradeComboBox.Text & "'"

        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            i = i + 1
            YearListView.Items.Add(i.ToString)
            YearListView.Items(YearListView.Items.Count - 1).SubItems.Add(myreader("yearlevelname").ToString)
        Loop
        myconn.Close()
    End Sub
    Dim yearlevel As String
    Dim grade As String
    Private Sub YearListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearListView.Click
        ClearAll()
        For a = 0 To YearListView.Items.Count - 1
            If YearListView.Items.Item(a).Selected = True Then
                YearLevelTextBox.Text = YearListView.SelectedItems(0).SubItems(1).Text
                GradeComboBox.Enabled = False
                SqlString = "SELECT yearlevelcode,yeargrade " & "FROM tblYearLevel" & _
           " WHERE yearlevelname='" & YearListView.SelectedItems(0).SubItems(1).Text & "'" 
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    yearlevel = myreader("yearlevelcode").ToString
                    grade = myreader("yeargrade").ToString
                    GradeComboBox.Text = grade
                Loop
                myconn.Close()
            End If
        Next
    End Sub
  
    Private Sub SectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionButton.Click
        Me.Close()
        Section.Show()
    End Sub

    Private Sub DeleteYearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteYearButton.Click
        For i = 0 To YearListView.Items.Count - 1
            If YearListView.Items.Item(i).Checked = True Then
                SqlString = "DELETE FROM tblYearLevel WHERE" & _
                "  yearlevelname='" & YearListView.Items(i).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewYear()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If YearLevelTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GradeComboBox.Enabled = False Then
            Try
                SqlString = "UPDATE tblYearLevel" & " SET yearlevelname= '" & YearLevelTextBox.Text & "'" & " WHERE yearlevelcode= '" & yearlevel & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                MessageBox.Show("Successfully updated year level.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            Dim Grade As String = ""
            If GradeComboBox.Text = "Grade School" Then
                Grade = "Grade"
            ElseIf GradeComboBox.Text = "High School" Then
                Grade = "Year"
            ElseIf GradeComboBox.Text = "Junior High" Then
                Grade = "JR_H"
            ElseIf GradeComboBox.Text = "Senior High" Then
                Grade = "SR_H"
            End If
            Try
                SqlString = "INSERT INTO tblYearLevel" & " VALUES ('" & (Grade & YearLevelTextBox.Text).Trim & "','" & Grade & " " & YearLevelTextBox.Text.Trim() & "','" & (YearListView.Items.Count + 1).ToString & "','" & GradeComboBox.Text & "','True')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                MessageBox.Show("Duplicate entry detected: (Year Level)", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        ClearAll()
        ViewYear()
    End Sub

    Public Sub ClearAll()
        GradeComboBox.Enabled = True
        'GradeComboBox.SelectedIndex = -1
        YearLevelTextBox.Enabled = False
        YearLevelTextBox.Text = ""
        SaveButton.Enabled = False
        ClearButton.Enabled = False
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To YearListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                YearListView.Items(c).Checked = True
            Else
                YearListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub SectionPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionPictureBox.Click
        Me.Close()
        Section.Show()
    End Sub
    Private Sub GradeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If GradeComboBox.Text = "" Then
            YearLevelTextBox.Enabled = False
        ElseIf GradeComboBox.Text = "Grade School" Then
            YearLevelTextBox.Enabled = True
            YearLabel.Text = "Grade Level:"
            ClearButton.Enabled = True
            SaveButton.Enabled = True
        ElseIf GradeComboBox.Text = "High School" Then
            YearLevelTextBox.Enabled = True
            YearLabel.Text = "Year Level:"
            ClearButton.Enabled = True
            SaveButton.Enabled = True
        ElseIf GradeComboBox.Text = "Junior High" Then
            YearLevelTextBox.Enabled = True
            YearLabel.Text = "Program:"
            ClearButton.Enabled = True
            SaveButton.Enabled = True
        ElseIf GradeComboBox.Text = "Senior High" Then
            YearLevelTextBox.Enabled = True
            YearLabel.Text = "Program:"
            ClearButton.Enabled = True
            SaveButton.Enabled = True
        End If
        ViewYear()
    End Sub
    Private Sub YearLevelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelTextBox.TextChanged
        If YearLevelTextBox.Text IsNot String.Empty Then
            SaveButton.Enabled = True
        End If
    End Sub

    Private Sub YearListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearListView.SelectedIndexChanged

    End Sub
End Class
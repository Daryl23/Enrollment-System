Option Strict On
Imports MySql.Data.MySqlClient
Public Class Requirement
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader

    Dim SQLString As String
    Private Sub Requirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StudTypeComboBox.Text = "ALL"
        ViewReq()
       

    End Sub

    Private Sub StudTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudTypeComboBox.SelectedIndexChanged
        ViewReq()
    End Sub
    Dim reqcnt As Integer
    Public Sub ViewReq()
        ClearAll()
        RequirementsListView.Items.Clear()
        Dim i As Integer = 0
        If StudTypeComboBox.Text = "ALL" Then
            SQLString = "SELECT req_name,yeargrade,student_type,req_desc " & "FROM tblRequirements"
        Else
            SQLString = "SELECT req_name,yeargrade,student_type,req_desc " & "FROM tblRequirements" & _
        " WHERE student_type='" & StudTypeComboBox.Text & "'"
        End If
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            i = i + 1
            RequirementsListView.Items.Add(i.ToString)
            RequirementsListView.Items(RequirementsListView.Items.Count - 1).SubItems.Add(myreader("student_type").ToString)
            RequirementsListView.Items(RequirementsListView.Items.Count - 1).SubItems.Add(myreader("yeargrade").ToString)
            RequirementsListView.Items(RequirementsListView.Items.Count - 1).SubItems.Add(myreader("req_name").ToString)
            RequirementsListView.Items(RequirementsListView.Items.Count - 1).SubItems.Add(myreader("req_desc").ToString)
        Loop
        myconn.Close()
    End Sub
    Private Sub AddRequirementButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Try
            If StudTypeComboBox.Text = "" Or GradeComboBox.Text = "" Or RequirementTextBox.Text = "" Then
                MessageBox.Show("All fields are required except the requirement description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf StudTypeComboBox.Enabled = False Then
                SQLString = "UPDATE tblRequirements SET req_name='" & RequirementTextBox.Text & "'" & _
                " where student_type = '" & StudType & "'" & _
                    " AND yeargrade='" & Grade & "'" & _
                    " AND req_name='" & Requirement & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Else
                If StudTypeComboBox.Text = "ALL" Then
                    Dim StudTypeList(4) As String
                    StudTypeList(0) = "New"
                    StudTypeList(1) = "Old"
                    StudTypeList(2) = "Transferee"
                    StudTypeList(3) = "Foreign"
                    For i = 0 To 3
                        SQLString = "INSERT INTO tblRequirements(requirementkey,req_name,student_type,req_desc,yeargrade)" & "VALUES ('" & (StudTypeList(i) & RequirementTextBox.Text).Trim & " ','" & RequirementTextBox.Text & "','" & StudTypeList(i) & "','" & RequirementDescriptionTextBox.Text.Trim() & "','" & GradeComboBox.Text & "')"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        reqcnt = reqcnt + 1
                    Next

                    MessageBox.Show("Successfully added new requirement information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    SQLString = "INSERT INTO tblRequirements(requirementkey,req_name,student_type,req_desc,yeargrade)" & "VALUES ('" & (StudTypeComboBox.Text & RequirementTextBox.Text).Trim & " ','" & RequirementTextBox.Text & "','" & StudTypeComboBox.Text & "','" & RequirementDescriptionTextBox.Text.Trim() & "','" & GradeComboBox.Text & "')"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    MessageBox.Show("Successfully added new requirement information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            ViewReq()
        Catch ex As Exception
            myconn.Close()
            MessageBox.Show("Duplicate entry detected: (Requirement)", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



  

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Main.Show()
        Me.Close()
    End Sub

  
    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To RequirementsListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                RequirementsListView.Items(c).Checked = True
            Else
                RequirementsListView.Items(c).Checked = False
            End If
        Next
    End Sub
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To RequirementsListView.Items.Count - 1
            If RequirementsListView.Items.Item(g).Checked = True Then
                SQLString = "Delete from tblRequirements where student_type = '" & RequirementsListView.Items(g).SubItems(1).Text & "'" & _
                " AND yeargrade='" & RequirementsListView.Items(g).SubItems(2).Text & "'" & _
                " AND req_name='" & RequirementsListView.Items(g).SubItems(3).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewReq()
    End Sub
    Dim StudType As String
    Dim Grade As String
    Dim Requirement As String
    Private Sub RequirementsListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequirementsListView.Click
        For a = 0 To RequirementsListView.Items.Count - 1
            Try
                If RequirementsListView.Items.Item(a).Selected = True Then
                    StudTypeComboBox.Enabled = False
                    GradeComboBox.Enabled = False
                    StudTypeComboBox.Text = RequirementsListView.Items(a).SubItems(1).Text
                    GradeComboBox.Text = RequirementsListView.Items(a).SubItems(2).Text
                    RequirementTextBox.Text = RequirementsListView.Items(a).SubItems(3).Text
                    RequirementDescriptionTextBox.Text = RequirementsListView.Items(a).SubItems(4).Text
                    StudType = RequirementsListView.Items(a).SubItems(1).Text
                    Grade = RequirementsListView.Items(a).SubItems(2).Text
                    Requirement = RequirementsListView.Items(a).SubItems(3).Text
                End If
            Catch
            End Try

        Next
    End Sub
    Public Sub ClearAll()
        StudTypeComboBox.Enabled = True
        GradeComboBox.Enabled = True
        RequirementTextBox.Text = ""
        RequirementDescriptionTextBox.Text = ""
    End Sub

 
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub
End Class
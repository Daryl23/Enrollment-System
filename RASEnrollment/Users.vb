Option Strict On
Imports MySql.Data.MySqlClient
Public Class Users

    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim yearcnt As Integer
    Dim SYID As String

    Dim SQLUsers As String
  
    Public Sub ViewAccounts()
        WithListView.Items.Clear()
        WOListView.Items.Clear()
        If UserTypeComboBox.Text = "Student" Then
            Try
                SQLUsers = "SELECT tblStudents.studentid As studentid, Concat(st_lname,', ', st_fname,' ', st_mname) As StudName,username,userpass" & " FROM tblStudents,tblStudentAccounts" & _
                " where tblStudents.studentid=tblStudentAccounts.studentid"

                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    WithListView.Items.Add(myreader("studentid").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("StudName").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("username").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add("Student")
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("userpass").ToString)
                Loop

                myconn.Close()

                SQLUsers = "SELECT tblStudents.studentid As studentid, Concat(st_lname,', ', st_fname,' ', st_mname) As StudName FROM tblStudents" & _
              " where studentid NOT IN (Select tblStudents.studentid FROM tblStudents,tblStudentAccounts" & _
              " where tblStudents.studentid =tblstudentAccounts.studentid)" & _
              " GROUP BY tblstudents.studentid"

                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    WOListView.Items.Add(myreader("studentid").ToString)
                    WOListView.Items(WOListView.Items.Count - 1).SubItems.Add(myreader("StudName").ToString)
                Loop

                myconn.Close()

            Catch ex As Exception
                myconn.Close()
            End Try
        ElseIf UserTypeComboBox.Text = "Teacher" Then
            SQLUsers = "SELECT tblTeachers.teacherid As teacherid, Concat(tea_lname,', ',tea_fname,' ',tea_mname) As TeacherName,username,userpass" & " FROM tblTeachers,tblTeacherAccounts" & _
           " where tblTeachers.teacherid=tblTeacherAccounts.teacherid AND teacherstatus!='Resigned'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    WithListView.Items.Add(myreader("teacherid").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("TeacherName").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("username").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(("Teacher"))
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("userpass").ToString)
                Loop

                myconn.Close()

            Catch ex As Exception
                myconn.Close()
            End Try
            SQLUsers = "SELECT teacherid As teacherid, Concat(tea_lname,', ',tea_fname,' ',tea_mname) As TeacherName" & " FROM tblTeachers" & _
           " where teacherid NOT IN (Select teacherid from tblTeacherAccounts) AND teacherstatus='OK'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    WOListView.Items.Add(myreader("teacherid").ToString)
                    WOListView.Items(WOListView.Items.Count - 1).SubItems.Add(myreader("TeacherName").ToString)
                Loop

                myconn.Close()

            Catch ex As Exception
                myconn.Close()
            End Try
        Else
            Dim AccountInteger As Integer = 0

            SQLUsers = "SELECT *" & " FROM tblAccounts" & _
            " where usertype='" & UserTypeComboBox.Text & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    AccountInteger = AccountInteger + 1
                    WithListView.Items.Add(AccountInteger.ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("name").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("username").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("usertype").ToString)
                    WithListView.Items(WithListView.Items.Count - 1).SubItems.Add(myreader("userpass").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

    End Sub
    Private Sub UserTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserTypeComboBox.SelectedIndexChanged
        CreateOrDeleteInteger = 0
        ViewAccounts()
    End Sub





    Dim InstructionInteger As Integer = 0
    Dim ListOfInstructionsUser As String() = {"TIP: With accounts are those accounts with username and passwords.", _
                                              "TIP: Without accounts are those students or teachers that are ready to have an account.", _
                                              "TIP: NEW account button enables Without accounts.", _
                                              "TIP: In with accounts list, check the name that need to have an account.", _
                                              "TIP: In without accounts list, check the account that need to be edited or deleted."}
    Dim ListOfInstructionsAssess As String() = {"TIP: Only students that already paid could view his/ her schedules."}

    Public CreateOrDeleteInteger As Integer = 0
    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserTypeComboBox.Items.Add("Student")
        UserTypeComboBox.Items.Add("Teacher")
        SQLUsers = "SELECT distinct usertype" & " FROM useraccess"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLUsers
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                UserTypeComboBox.Items.Add(myreader("usertype").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        UserTypeComboBox.Items.Add("ADMIN")
        ViewAccounts()
        UsersManagementGroupBox.Visible = True
        UserTypeComboBox.Text = "Student"
    End Sub

    Private Sub CheckWithCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckWithCheckBox.CheckedChanged
        For c = 0 To WithListView.Items.Count - 1
            If CheckWithCheckBox.Checked = True Then
                WithListView.Items(c).Checked = True
            Else
                WithListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub CheckOutCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutCheckBox.CheckedChanged
        For c = 0 To WOListView.Items.Count - 1
            If CheckOutCheckBox.Checked = True Then
                WOListView.Items(c).Checked = True
            Else
                WOListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub WOListView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WOListView.DoubleClick
        If WOListView.CheckedItems.Count = 0 Then
            CheckOutCheckBox.Checked = False
        End If
    End Sub




    Private Sub UpdateAccountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccountButton.Click
        CreateOrDeleteInteger = 0
        For c = 0 To WOListView.Items.Count - 1
            WOListView.Items(c).Checked = False
        Next

        GroupBox2.Enabled = True
        CheckOutCheckBox.Checked = False
        GroupBox3.Enabled = False
        UpdateAccountButton.Enabled = False
        NewAccountButton.Enabled = True
    End Sub


    Private Sub WithListView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithListView.DoubleClick
        If WithListView.SelectedItems.Count > 0 Then
            CheckWithCheckBox.Checked = False
            CreateOrDeleteInteger = 1
            User.Show()
        End If
        
    End Sub

    Private Sub NewAccountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAccountButton.Click
        CreateOrDeleteInteger = 0
        For c = 0 To WithListView.Items.Count - 1
            WithListView.Items(c).Checked = False
        Next
        GroupBox2.Enabled = False
        CheckWithCheckBox.Checked = False
        GroupBox3.Enabled = True
        NewAccountButton.Enabled = False
        UpdateAccountButton.Enabled = True
    End Sub


    Private Sub CreateAccountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAccountButton.Click
        If WOListView.CheckedItems.Count > 0 Then
            CreateOrDeleteInteger = 2
            User.Show()
        Else
            Dim limit As Integer = 0
            SQLUsers = "SELECT userslimit-(Select COUNT(username) from tblAccounts" & _
            " WHERE usertype='" & UserTypeComboBox.Text & "') As userslimit" & _
            " FROM useraccess" & _
            " where usertype='" & UserTypeComboBox.Text & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLUsers
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    limit = CInt(myreader("userslimit").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If limit > 0 Then
                User.ShowDialog()
            ElseIf UserTypeComboBox.Text = "Student" Or UserTypeComboBox.Text = "Teacher" Then
                If WOListView.CheckedItems.Count = 0 Then
                    MessageBox.Show("Please select an account.", "Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    User.ShowDialog()
                End If
            ElseIf UserTypeComboBox.Text = "ADMIN" Then
                MessageBox.Show("Only 1 ADMIN account must be available in the system.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                MessageBox.Show("Users limit exceeded.", "Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If

    End Sub

    Private Sub UsersInstructionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserAccessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccessButton.Click
        UserAccess.ShowDialog()
    End Sub

    
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For i = 0 To WithListView.Items.Count - 1
            If WithListView.Items(i).Checked = True Then
                If UserTypeComboBox.Text = "Student" Then
                    SQLUsers = "Delete from tblStudentAccounts where studentid = '" & WithListView.Items.Item(i).Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLUsers
                    mycommand.ExecuteNonQuery()
                    myconn.Close()


                ElseIf UserTypeComboBox.Text = "Teacher" Then
                    SQLUsers = "Delete from tblTeacherAccounts where teacherid = '" & WithListView.Items.Item(i).Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLUsers
                    mycommand.ExecuteNonQuery()
                    myconn.Close()

                Else
                    SQLUsers = "Delete from tblAccounts where username = '" & WithListView.Items(i).SubItems(2).Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLUsers
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                End If
            End If
        Next
        WithListView.Items.Clear()
        ViewAccounts()
    End Sub

    Private Sub WithListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithListView.SelectedIndexChanged

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Main.Show()
        Me.Close()
    End Sub
End Class
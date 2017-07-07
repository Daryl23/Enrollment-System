Option Strict On
Imports MySql.Data.MySqlClient
Public Class User
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim UserIDList As New List(Of String)
    Dim UserNameList As New List(Of String)
    Dim UserPassList As New List(Of String)
    Dim NameList As New List(Of String)
    Dim UserType As String
    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserType = Users.UserTypeComboBox.Text
        UserTypeTextBox.Text = UserType
        If UserType = "Student" Or UserType = "Teacher" Then
            NameLabel.Visible = False
            NameTextBox.Visible = False
        Else
            NameLabel.Visible = True
            NameTextBox.Visible = True
        End If
        Dim j As Integer = 0
        If Users.CreateOrDeleteInteger = 2 Then
            For i = 0 To Users.WOListView.Items.Count - 1
                If Users.WOListView.Items(i).Checked = True Then
                    UserListBox.Items.Add(Users.WOListView.Items(i).Text)
                    If UserType = "Student" Then
                        SQlString = "Select studentid,Concat(st_lname,st_fname) As StudName from tblStudents where studentid='" & UserListBox.Items.Item(j).ToString & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQlString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            UserIDList.Add(CStr(myreader("studentid")))
                            UserNameList.Add(CStr((myreader("StudName"))))
                        Loop
                        myconn.Close()
                        UserTypeTextBox.Text = "Student"
                    ElseIf UserType = "Teacher" Then
                        SQlString = "Select teacherid,Concat(tea_lname,tea_fname) As TeaName from tblTeachers where teacherid='" & UserListBox.Items.Item(j).ToString & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQlString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            UserIDList.Add(CStr(myreader("teacherid")))
                            UserNameList.Add(CStr((myreader("TeaName"))))
                        Loop
                        myconn.Close()
                        UserTypeTextBox.Text = "Teacher"
                    End If
                    j = j + 1
                End If
            Next
            UserNameTextBox.Text = UserNameList.Item(0)
        ElseIf Users.CreateOrDeleteInteger = 1 Then
            For i = 0 To Users.WithListView.Items.Count - 1
                If Users.WithListView.Items.Item(i).Selected = True Then
                    UserListBox.Items.Add(Users.WithListView.Items(i).Text)
                    If UserType = "Student" Then
                        SQlString = "Select tblStudents.studentid,username,userpass from tblStudents,tblStudentAccounts" & _
                        " where tblStudents.studentid=tblStudentAccounts.studentid AND tblStudents.studentid='" & Users.WithListView.Items(i).Text & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQlString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            UserIDList.Add(CStr(myreader("studentid")))
                            UserNameList.Add(CStr(myreader("username")))
                            UserPassList.Add(myreader("userpass").ToString)
                        Loop
                        myconn.Close()
                        UserTypeTextBox.Text = "Student"
                        Exit For
                    ElseIf UserType = "Teacher" Then
                        SQlString = "SELECT tblTeachers.teacherid As teacherid,username,userpass" & " FROM tblTeachers,tblTeacherAccounts" & _
                        " where tblTeachers.teacherid=tblTeacherAccounts.teacherid "
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                UserIDList.Add(CStr(myreader("teacherid")))
                                UserNameList.Add(CStr(myreader("username")))
                                UserPassList.Add(myreader("userpass").ToString)
                            Loop

                            myconn.Close()

                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        UserTypeTextBox.Text = "Teacher"
                        Exit For
                    Else
                        SQlString = "SELECT name,username,userpass" & " FROM tblAccounts" & _
                        " where usertype='" & Users.UserTypeComboBox.Text & "'"
                        Try
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            myreader = mycommand.ExecuteReader
                            Do While myreader.Read
                                NameList.Add(CStr(myreader("name")))
                                UserNameList.Add(CStr(myreader("username")))
                                UserPassList.Add(myreader("userpass").ToString)
                            Loop
                            myconn.Close()
                        Catch ex As Exception
                            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        Exit For
                    End If
                End If
            Next
            If NameList.Count > 0 Then
                NameTextBox.Text = NameList.Item(0)
            End If
            UserNameTextBox.Text = UserNameList.Item(0)
            PasswordTextBox.Text = UserPassList.Item(0)
            ConfirmTextBox.Text = UserPassList.Item(0)
        Else
            NameTextBox.Enabled = True
            UserListBox.Enabled = False
            UserNameTextBox.Focus()
        End If
    End Sub
    Dim SQlString As String

    Private Sub SaveUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveUserButton.Click
        Dim err As Integer = 0
        If NameTextBox.Visible = True Then
            If NameTextBox.Text = "" Then
                err = 1
                MessageBox.Show("All fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        If err = 0 Then
            Try
                If PasswordTextBox.Text = "" Or UserNameTextBox.Text = "" Then
                    MessageBox.Show("All fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf PasswordTextBox.Text = ConfirmTextBox.Text Then

                    If Users.CreateOrDeleteInteger = 2 Then

                        For i = 0 To UserListBox.Items.Count - 1
                            If UserType = "Student" Then
                                SQlString = "INSERT INTO tblStudentAccounts(studentid,username,userpass)" & "VALUES ('" & UserIDList.Item(i).ToString & "','" & UserNameList.Item(i).ToString & "','" & PasswordTextBox.Text & "')"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQlString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                            ElseIf UserType = "Teacher" Then
                                SQlString = "INSERT INTO tblTeacherAccounts(teacherid,username,userpass)" & "VALUES ('" & UserIDList.Item(i).ToString & "','" & UserNameList.Item(i).ToString & "','" & PasswordTextBox.Text & "')"
                                myconn.ConnectionString = CONNECTION_STRING
                                myconn.Open()
                                mycommand.Connection = myconn
                                mycommand.CommandText = SQlString
                                mycommand.ExecuteNonQuery()
                                myconn.Close()
                            End If
                        Next
                        MessageBox.Show("Successfully added new account.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf Users.CreateOrDeleteInteger = 1 Then
                        If UserType = "Student" Then
                            SQlString = "Update tblStudentAccounts SET username='" & UserNameTextBox.Text & "' where studentid='" & UserListBox.Items.Item(0).ToString & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQlString = "Update tblStudentAccounts SET userpass='" & PasswordTextBox.Text & "' where studentid='" & UserListBox.Items.Item(0).ToString & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        ElseIf UserType = "Teacher" Then
                            SQlString = "Update tblTeacherAccounts SET username='" & UserNameTextBox.Text & "' where teacherid='" & UserListBox.Items.Item(0).ToString & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQlString = " Update tblTeacherAccounts SET userpass='" & PasswordTextBox.Text & "' where teacherid='" & UserListBox.Items.Item(0).ToString & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        Else
                            SQlString = "Update tblAccounts SET username='" & UserNameTextBox.Text & "' where name='" & NameTextBox.Text & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                            SQlString = "Update tblAccounts SET userpass='" & PasswordTextBox.Text & "' where name='" & NameTextBox.Text & "'"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQlString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()
                        End If
                    Else
                        SQlString = "INSERT INTO tblAccounts(name,username,userpass,usertype)" & "VALUES ('" & NameTextBox.Text & "','" & UserNameTextBox.Text & "','" & PasswordTextBox.Text & "','" & UserTypeTextBox.Text & "')"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQlString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                    End If
                    MessageBox.Show("Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    PasswordTextBox.BackColor = Color.Red
                    PasswordTextBox.Focus()
                    ConfirmTextBox.BackColor = Color.Red
                End If
                Users.CreateOrDeleteInteger = 0
                Users.ViewAccounts()
                Me.Close()
            Catch
                myconn.Close()
                MessageBox.Show("Duplicate Entry detected: (UserName).", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub CancelUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelUserButton.Click
        Users.CreateOrDeleteInteger = 0
        Users.ViewAccounts()
        Me.Close()
    End Sub

    Private Sub UserListBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserListBox.Click
        Try
            UserNameTextBox.Clear()
            UserNameTextBox.Text = UserNameList.Item(UserListBox.SelectedIndex)
        Catch
        End Try
    End Sub

    Private Sub UserListBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserListBox.DoubleClick
        If UserListBox.Items.Count > 0 Then
            Try
                UserListBox.Items.Remove(UserIDList.Item(UserListBox.SelectedIndex))
                UserIDList.Clear()
                UserNameList.Clear()
                For i = 0 To UserListBox.Items.Count - 1
                    SQlString = "Select studentid,st_lname+''+st_fname As StudName from tblStudents where studentid='" & UserListBox.Items.Item(i).ToString & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQlString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        UserIDList.Add(CStr(myreader("studentid")))
                        UserNameList.Add(CStr((myreader("StudName"))))
                    Loop
                    myconn.Close()
                Next
                UserListBox.Items.Clear()
                For i = 0 To UserIDList.Count - 1
                    UserListBox.Items.Add(UserIDList.Item(i).ToString)
                Next
                UserNameTextBox.Text = UserNameList.Item(0)
            Catch
            End Try
            If UserListBox.Items.Count = 0 Then
                Users.Show()
                Me.Close()
            End If
        End If
    End Sub


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
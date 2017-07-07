Option Strict On
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class LoginForm

    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader

    Public NameOfUser As String
    Public UserName As String
    Public UserType As String
    Public UserID As String
    Dim tries As Integer = 0

    Private Sub LoginPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginPictureBox.Click
        Dim SQLYearLevel As String = "Select usertype,name FROM tblAccounts where username='" & UserIDTextBox.Text & _
        "' AND userpass='" & PasswordTextBox.Text & "' "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLYearLevel
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                NameOfUser = CStr(myreader("name"))
                UserType = CStr(myreader("usertype"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        If UserType = String.Empty Then
            SQLYearLevel = "Select tblTeachers.teacherid, Concat(tea_fname,' ',LEFT(tea_mname,1),'. ',tea_lname) As TeaName FROM tblTeacherAccounts,tblTeachers where username='" & UserIDTextBox.Text & _
        "' AND userpass='" & PasswordTextBox.Text & "' " & _
        " AND tblTeachers.teacherid=tblTeacherAccounts.teacherid"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLYearLevel
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    UserID = myreader("teacherid").ToString
                    UserName = myreader("TeaName").ToString
                    UserType = "Teacher"
                Loop

                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If tries = 5 Then
            MessageBox.Show("Sorry, you have exceeded the maximum number of attempts to login. The system will close.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Me.Close()

        ElseIf UserType = String.Empty Then
            MessageBox.Show("Invalid username or password. Please try again. You only have " & 4 - tries & " attempt to login.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tries = tries + 1

        ElseIf UserType = "Teacher" Then
            Me.Hide()
            Welcome.Show()
        Else
            Me.Hide()
            UserName = UserIDTextBox.Text
            Welcome.Show()
        End If
    End Sub

    Private Sub ExitPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitPictureBox.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim result As Integer
        result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.Cancel Then
        Else
            MessageBox.Show("C:\wamp\bin\mysql\mysql5.6.12\bin\mysql.exe", "-host localhost -u root -p dbenrollment < " & OpenFileDialog1.FileName & "")
            If result = DialogResult.Cancel Then
            Else
                Process.Start("C:\wamp\bin\mysql\mysql5.6.12\bin\mysql.exe", "-host localhost -u root -p dbenrollment <""" & OpenFileDialog1.FileName & "")
                MessageBox.Show("Successfully Restored Database.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class

Option Strict On
Imports MySql.Data.MySqlClient
Public Class Welcome
    Public CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Public NameOfUser As String = LoginForm.NameOfUser
    Public UserType As String = LoginForm.Usertype
    Public UserName As String = LoginForm.UserName
    Public UserID As String = LoginForm.UserID
    Public SYView As Boolean = True
    Public SYEdit As Boolean = True
    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NameLabel.Text = NameOfUser & ","
        SystemDateLabel.Text = CStr(System.DateTime.Now.ToLongDateString)
        SystemTimeLabel.Text = CStr(System.DateTime.Now.ToShortTimeString)
    End Sub

    Private Sub SystemTimeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemTimeLabel.Click
        SchoolYear.Show()
    End Sub

    Private Sub SystemDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemDateLabel.Click
        SchoolYear.Show()
    End Sub

    Dim SQLString As String
    Private Sub ProceedPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedPictureBox.Click
        If UserType = "Admin" Then
            Me.Close()
            SchoolYear.Show()
        ElseIf UserType = "Teacher" Then
            Grading.Show()
            Me.Close()
        Else
            SQLString = "Select schoolyearviewing,schoolyearediting from useraccess WHERE usertype='" & UserType & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SYView = CBool(myreader("schoolyearviewing").ToString)
                SYEdit = CBool(myreader("schoolyearediting").ToString)
            Loop
            myconn.Close()
            If SYView = True Or SYEdit = True Then
                SchoolYear.Show()
            Else
                Main.Show()
            End If
            Me.Close()
        End If
    End Sub
End Class
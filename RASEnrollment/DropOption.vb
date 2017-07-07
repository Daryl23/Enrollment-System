Option Strict On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class DropOption
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Public Drop As String
    Private Sub ProceedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProceedButton.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to proceed?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            If OfficialDropRadioButton.Checked = True Then
                Drop = "Official Dropped"
                SQLString = "UPDATE tblStudentYear " & " SET studentstatus='Official Dropped'" & _
                       " WHERE studentschoolyear='" & Main.SYID & Main.StudNoRegistrationTextBox.Text & "'"
            Else
                Drop = "UnOfficial Dropped"
                SQLString = "UPDATE tblStudentYear " & " SET studentstatus='UnOfficial Dropped'" & _
                       " WHERE studentschoolyear='" & Main.SYID & Main.StudNoRegistrationTextBox.Text & "'"

            End If
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
            Main.Drop = Drop
        End If
        Me.Close()
    End Sub

    Private Sub DropOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
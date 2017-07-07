Option Strict On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Reservation
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SQLString As String
    Dim SYID As String
    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLString = "Select schoolyearid from tblSchoolYear " & _
        " where schoolyearid='" & Main.SYID & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SYID = myreader("schoolyearid").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("aaaNo records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            myconn.Close()
        End Try
        Dim LoadInfo As String = "SELECT yearlevelname " & "FROM tblYearLevel" & _
        " ORDER BY yeargrade,yearorder"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                GradeComboBox.Items.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show("No records foundc." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeComboBox.SelectedIndexChanged
        ReservationListView.Items.Clear()
        Dim i As Integer
        If GradeComboBox.Text = "ALL" Then
            SQLString = "SELECT yearlevelname,tblStudents.studentid As studentid,Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') As Name,date(st_registration) As RegDate " & "FROM tblYearLevel,tblStudentYearLevel,tblStudents,tblStudentYear where " & _
      " tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode AND tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
      " AND tblStudents.studentid=tblStudentYear.studentid" & _
      " AND schoolyearid='" & SYID & "' AND studentstatus='Reserved'"
        Else
            SQLString = "SELECT yearlevelname,tblStudents.studentid As studentid,Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') As Name,date(st_registration) As RegDate " & "FROM tblYearLevel,tblStudentYearLevel,tblStudents,tblStudentYear where " & _
     " tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode AND tblStudentYearLevel.studentschoolyear=tblStudentYear.studentschoolyear" & _
     " AND tblStudents.studentid=tblStudentYear.studentid" & _
     " AND schoolyearid='" & SYID & "' AND studentstatus='Reserved' AND yearlevelname='" & GradeComboBox.Text & "'"
        End If
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                Dim RegDate As Date = CDate(myreader("RegDate"))
                ReservationListView.Items.Add(i.ToString)
                ReservationListView.Items(ReservationListView.Items.Count - 1).SubItems.Add(myreader("studentid").ToString)
                ReservationListView.Items(ReservationListView.Items.Count - 1).SubItems.Add(myreader("Name").ToString)
                ReservationListView.Items(ReservationListView.Items.Count - 1).SubItems.Add(myreader("yearlevelname").ToString)
                ReservationListView.Items(ReservationListView.Items.Count - 1).SubItems.Add(RegDate.ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            'myconn.Close()
        End Try
    End Sub

    Private Sub ReservationListView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationListView.DoubleClick
        For i = 0 To ReservationListView.Items.Count - 1
            If ReservationListView.SelectedItems(i).Selected = True Then
                Main.StudentSearch = ReservationListView.Items(i).SubItems(1).Text
                Main.ViewAssess()
                Me.Close()
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        For i = 0 To ReservationListView.Items.Count - 1
            ReservationListView.Items(i).Checked = True
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For i = 0 To ReservationListView.Items.Count - 1
            If ReservationListView.Items(i).Checked = True Then
                SQLString = "UPDATE tblStudentYear " & " SET studentstatus='Canceled' WHERE studentid='" & ReservationListView.Items(i).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                MessageBox.Show("Successful!!!.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Next
    End Sub
End Class
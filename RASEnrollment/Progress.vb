Option Strict On
Imports MySql.Data.MySqlClient
Public Class ProgressReportCard
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SqlString As String
    Dim SYID As String

    Private Sub ProgressReportCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SYID = Main.SYID
        SYTextBox.Text = DatePart(DateInterval.Year, Main.SYFrom) & "- " & DatePart(DateInterval.Year, Main.SYTo)
        SqlString = "SELECT tblStudents.studentid As studentid,Concat(st_lname,', ',st_fname,' ',LEFT(st_mname,1),'.') As Name,st_gender,yearlevelname,sectioncode,date(st_bdate) As st_bdate " & "FROM tblYearLevel,tblYearLevelSections,tblStudentSections,tblStudents,tblStudentYear where " & _
          " tblYearLevelSections.yearlevelsectioncode=tblStudentSections.yearlevelsectioncode AND tblStudentSections.studentschoolyear=tblStudentYear.studentschoolyear AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
          " AND tblStudents.studentid=tblStudentYear.studentid" & _
          " AND tblStudents.studentid='" & Main.ReportName & "'" & _
          " AND tblStudentYear.schoolyearid='" & SYID & "'"

        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim bdate As Date = myreader.GetDateTime("st_bdate")
                Dim Age As Integer
                If DatePart(DateInterval.Year, Date.Today) >= DatePart(DateInterval.Year, CDate(bdate)) Then
                    Age = DatePart(DateInterval.Year, Date.Today) - DatePart(DateInterval.Year, CDate(bdate))
                    If DatePart(DateInterval.Month, Date.Today) < DatePart(DateInterval.Month, CDate(bdate)) Then
                        Age = Age - 1
                    ElseIf DatePart(DateInterval.Month, Date.Today) = DatePart(DateInterval.Month, CDate(bdate)) Then
                        If DatePart(DateInterval.Day, Date.Today) > DatePart(DateInterval.Day, CDate(bdate)) Then
                            Age = Age - 1
                            If Age < 0 Then
                                Age = 0
                            End If
                        ElseIf DatePart(DateInterval.Day, Date.Today) = DatePart(DateInterval.Day, CDate(bdate)) Then
                            Age = Age
                        End If
                    End If
                Else
                    'MessageBox.Show("Invalid input.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                AgeTextBox.Text = Age.ToString
                NameTextBox.Text = (myreader("Name").ToString)
                SexTextBox.Text = (myreader("st_gender").ToString)
                LevelTextBox.Text = (myreader("yearlevelname").ToString) & " " & (myreader("sectionname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found.rarar" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'ListView1.Columns.Add("SUBJECTS")
        Dim gradings As Integer
        SqlString = "SELECT COUNT(gradingperiodid) As gradings From tblGradings,tblSchoolYear WHERE tblGradings.schoolyearid=tblSchoolYear.schoolyearid" & _
        " AND tblSchoolYear.schoolyearid='" & SYID & "'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            gradings = CInt(myreader("gradings").ToString)
        Loop
        myconn.Close()
        Label18.Width = gradings * 30
        For i = 1 To gradings
            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "PropertyName"
            col.HeaderText = "     " & i.ToString
            col.Width = 30
            col.Name = "colWhateverName"
            DataGridView1.Columns.Add(col)
        Next
        For i = 1 To 2
            Dim NewArray() As String = {"Final Rating", "Remarks"}
            Dim col As New DataGridViewTextBoxColumn
            col.DataPropertyName = "PropertyName"
            col.HeaderText = NewArray(i - 1)
            If i = 1 Then
                col.Width = 40
            Else
                col.Width = 55
            End If
            col.Name = "colWhateverName"
            DataGridView1.Columns.Add(col)
        Next
        Dim ave As Decimal
        If Main.ProgressAssessOrRecord = 0 Then
            Try
                For i = 0 To Main.SubjectGradeDataGridView.Rows.Count - 1
                    ave = 0
                    For j = 0 To Main.SubjectGradeDataGridView.ColumnCount - 1
                        DataGridView1.Rows.Add()
                        Label19.Text = CStr(Main.SubjectGradeDataGridView.Rows.Item(i).Cells(j).Value)
                        DataGridView1.Rows(i).Cells(j).Value = Label19.Text
                        If j > 0 Then
                            ave = ave + CDec(Label19.Text)
                        End If
                    Next
                    Try
                        ave = ave / gradings
                    Catch
                        ave = 0
                    End Try
                    DataGridView1.Rows(i).Cells(gradings + 1).Value = ave
                    If ave >= 75 Then
                        DataGridView1.Rows(i).Cells(gradings + 2).Value = "pasa"
                    Else
                        DataGridView1.Rows(i).Cells(gradings + 2).Value = "hulog"
                    End If
                Next
            Catch
            End Try
        Else
            Try
                For i = 0 To Main.RecordsDataGridView.Rows.Count - 1
                    ave = 0
                    For j = 0 To Main.RecordsDataGridView.ColumnCount - 1
                        DataGridView1.Rows.Add()
                        Label19.Text = CStr(Main.RecordsDataGridView.Rows.Item(i).Cells(j).Value)
                        DataGridView1.Rows(i).Cells(j).Value = Label19.Text
                        If j > 0 Then
                            ave = ave + CDec(Label19.Text)
                        End If
                    Next
                    Try
                        ave = ave / gradings
                    Catch
                        ave = 0
                    End Try
                    DataGridView1.Rows(i).Cells(gradings + 1).Value = ave
                    If ave >= 75 Then
                        DataGridView1.Rows(i).Cells(gradings + 2).Value = "pasa"
                    Else
                        DataGridView1.Rows(i).Cells(gradings + 2).Value = "hulog"
                    End If
                Next
            Catch
            End Try
        End If
    End Sub

    Private Sub PrintPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewButton.Click
        PrintForm1.Form = Me
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 1
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = CInt(250)
        PrintButton.Visible = False
        PrintPreviewButton.Visible = False
        Button2.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        PrintButton.Visible = True
        Button2.Visible = True
        PrintPreviewButton.Visible = True
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintForm1.Print()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
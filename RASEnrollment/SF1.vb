Option Strict On
Imports MySql.Data.MySqlClient

Public Class SF1
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Dim SYID As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SYID = Main.SYID
        SYTextBox.Text = DatePart(DateInterval.Year, Main.SYFrom) & "- " & DatePart(DateInterval.Year, Main.SYTo)
        YearLevelTextBox.Text = Main.ReportYearLevel
        SectionTextBox.Text = Main.ReportSection
        SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,st_gender,date(st_bdate) As bdate,st_religion,st_address,fa_name,mo_name,gua_name,gua_relationship,gua_contactno,fa_contactno,mo_contactno FROM tblYearLevel,tblStudentYear,tblStudents,tblStudentSections,tblYearLevelSections" & _
                 " where tblStudents.studentid=tblStudentYear.studentid " & _
                 " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
                 " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                 " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                 " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                 " AND yearlevelname='" & YearLevelTextBox.Text & "'" & _
                 " AND sectioncode='" & SectionTextBox.Text & "'" & _
             " AND studentstatus='Enrolled'" & _
               " GROUP BY tblStudents.studentid" & _
                 " ORDER BY tblStudents.studentid"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim n As Integer = DataGridView1.Rows.Add
                DataGridView1.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
                DataGridView1.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
                DataGridView1.Rows.Item(n).Cells(2).Value = myreader("st_gender").ToString
                DataGridView1.Rows.Item(n).Cells(3).Value = myreader("bdate").ToString
                Dim Age As Integer
                If DatePart(DateInterval.Year, Date.Today) >= DatePart(DateInterval.Year, CDate(myreader("bdate").ToString)) Then
                    Age = DatePart(DateInterval.Year, Date.Today) - DatePart(DateInterval.Year, CDate(myreader("bdate").ToString))
                    If DatePart(DateInterval.Month, Date.Today) < DatePart(DateInterval.Month, CDate(myreader("bdate").ToString)) Then
                        Age = Age - 1
                    ElseIf DatePart(DateInterval.Month, Date.Today) = DatePart(DateInterval.Month, CDate(myreader("bdate").ToString)) Then
                        If DatePart(DateInterval.Day, Date.Today) > DatePart(DateInterval.Day, CDate(myreader("bdate").ToString)) Then
                            Age = Age - 1
                            If Age < 0 Then
                                Age = 0
                            End If
                        ElseIf DatePart(DateInterval.Day, Date.Today) = DatePart(DateInterval.Day, CDate(myreader("bdate").ToString)) Then
                            Age = Age
                        End If
                    End If
                End If
                DataGridView1.Rows.Item(n).Cells(4).Value = Age.ToString
                DataGridView1.Rows.Item(n).Cells(5).Value = myreader("st_religion").ToString
                DataGridView1.Rows.Item(n).Cells(6).Value = myreader("st_address").ToString
                DataGridView1.Rows.Item(n).Cells(7).Value = myreader("fa_name").ToString
                DataGridView1.Rows.Item(n).Cells(8).Value = myreader("mo_name").ToString
                DataGridView1.Rows.Item(n).Cells(9).Value = myreader("gua_name").ToString
                DataGridView1.Rows.Item(n).Cells(10).Value = myreader("gua_relationship").ToString
                If myreader("gua_contactno").ToString = "" Then
                    DataGridView1.Rows.Item(n).Cells(11).Value = myreader("fa_contactno").ToString & "/ " & myreader("mo_contactno").ToString
                Else
                    DataGridView1.Rows.Item(n).Cells(11).Value = myreader("gua_contactno").ToString
                End If
                'DataGridView1.Rows.Item(n).Cells(2).Value = myreader("st_gender").ToString

            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records foundc." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim graph As Graphics = Nothing
        Try
            Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            graph = Graphics.FromImage(bmp)
            graph.CopyFromScreen(0, 0, 0, 0, bmp.Size)
            bmp.Save("pic" & "bmp", _
                    System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
        End Try

    End Sub

 
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintForm1.Print()
        End If
    End Sub

    Private Sub PrintPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewButton.Click
        PrintForm1.Form = Me
        'PrintForm1.Form = PrintDocument1
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintButton.Visible = False
        PrintPreviewButton.Visible = False
        Button2.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        PrintButton.Visible = True
        Button2.Visible = True
        PrintPreviewButton.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myImage As New Bitmap(Me.Width, Me.Height)
        Dim PrintSize As Size = e.MarginBounds.Size
        Dim scale As Double = 1
        Me.DrawToBitmap(myImage, New Rectangle(Point.Empty, Me.Size))
        PrintSize.Width = CInt(PrintSize.Width * 0.96) 'convert to pixels
        PrintSize.Height = CInt(PrintSize.Height * 0.96)
        If myImage.Width > PrintSize.Width Then
            'Form is to big. Scale it down.
            scale = PrintSize.Width / myImage.Width
            e.Graphics.ScaleTransform(CSng(scale), CSng(scale))
        End If
        If (myImage.Height * scale) > PrintSize.Height Then
            'The form is still to big. Scale it again.
            scale = PrintSize.Height / (myImage.Height * scale)
            e.Graphics.ScaleTransform(CSng(scale), CSng(scale))
        End If
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.DrawImage(myImage, e.MarginBounds.Location)
        myImage.Dispose()
    End Sub
End Class
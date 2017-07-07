Option Strict On
Imports MySql.Data.MySqlClient
Public Class SF2
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Dim SYID As String
    Dim yeargrade As String

    Private Sub SF2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SYID = Main.SYID
        SYTextBox.Text = DatePart(DateInterval.Year, Main.SYFrom) & "- " & DatePart(DateInterval.Year, Main.SYTo)
        YearLevelTextBox.Text = Main.ReportYearLevel
        SQLString = "Select yeargrade FROM tblYearLevel WHERE yearlevelname='" & YearLevelTextBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                yeargrade = myreader("yeargrade").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found.b" & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        SectionTextBox.Text = Main.ReportSection
        Dim TotalMale As Integer = 0
        Dim TotalFemale As Integer = 0

        Dim MalePromoted As Integer = 0
        Dim FemalePromoted As Integer = 0

        Dim MaleIrregular As Integer = 0
        Dim FemaleIrregular As Integer = 0

        Dim MaleRetained As Integer = 0
        Dim FemaleRetained As Integer = 0

        Dim MaleBeginning As Integer = 0
        Dim MaleDeveloping As Integer = 0
        Dim MaleApproaching As Integer = 0
        Dim MaleProficient As Integer = 0
        Dim MaleAdvanced As Integer = 0

        Dim FemaleBeginning As Integer = 0
        Dim FemaleDeveloping As Integer = 0
        Dim FemaleApproaching As Integer = 0
        Dim FemaleProficient As Integer = 0
        Dim FemaleAdvanced As Integer = 0


        Dim BackSubjectLimit As Integer = 0
        SQLString = "Select  backsubjectlimit from Others"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                BackSubjectLimit = CInt(myreader("backsubjectlimit"))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_Back", ex.Message)
        End Try
        SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,ROUND(AVG(grade),3) As grade FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
                  " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
                  " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
                   " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
                  " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                  " AND yearlevelname='" & YearLevelTextBox.Text & "'" & _
                  " AND sectioncode='" & SectionTextBox.Text & "'" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND st_gender='Male'" & _
                " GROUP BY tblStudents.studentid" & _
                " ORDER BY tblStudents.studentid"
        myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Dim n As Integer = DataGridView1.Rows.Add
                DataGridView1.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
            DataGridView1.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
            DataGridView1.Rows.Item(n).Cells(2).Value = myreader("grade").ToString
            If CInt(myreader("grade").ToString) > 90 Then
                MaleAdvanced = MaleAdvanced + 1
            ElseIf CInt(myreader("grade").ToString) > 84 Then
                MaleProficient = MaleProficient + 1
            ElseIf CInt(myreader("grade").ToString) > 79 Then
                MaleApproaching = MaleApproaching + 1
            ElseIf CInt(myreader("grade").ToString) > 74 Then
                MaleDeveloping = MaleDeveloping + 1
            Else
                MaleBeginning = MaleBeginning + 1
            End If
            TotalMale = TotalMale + 1
        Loop
        myconn.Close()
        Dim Subject As New List(Of String)
        Dim BackSubject As New List(Of String)
        For i = 0 To TotalMale - 1
            Dim FailNo As Integer = 0
            Subject.Clear()
            BackSubject.Clear()
            SQLString = "Select distinct sub_name from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                     " AND tblStudentYear.studentschoolyear='" & SYID & DataGridView1.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                      " ORDER BY sub_name"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Subject.Add(myreader("sub_name").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
            For j = 0 To Subject.Count - 1
                Try
                    SQLString = "Select  (ROUND(AVG(grade),2)) As grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                               " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                              " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                              " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                              " AND sub_name='" & Subject.Item(j) & "'" & _
                     " AND tblStudentYear.studentschoolyear='" & SYID & DataGridView1.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                     " GROUP BY sub_name"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        If myreader("grade").ToString = "" Then
                            FailNo = FailNo + 1
                            BackSubject.Add(Subject.Item(j))
                        ElseIf CInt(myreader("grade").ToString) >= 0 Then

                            If CInt(myreader("grade").ToString) < 75 Then
                                FailNo = FailNo + 1
                                BackSubject.Add(Subject.Item(j))
                            End If
                        End If
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Err_Back", ex.Message)
                End Try
            Next
            If FailNo > BackSubjectLimit Then
                DataGridView1.Rows.Item(i).Cells(3).Value = "Retained"
                MaleRetained = MaleRetained + 1
            ElseIf BackSubject.Count > 0 Then
                DataGridView1.Rows.Item(i).Cells(3).Value = "Irregular"
                MaleIrregular = MaleIrregular + 1
            Else
                MalePromoted = MalePromoted + 1
                DataGridView1.Rows.Item(i).Cells(3).Value = "Promoted"
            End If
            If yeargrade = "High School" Then
                For k = 0 To BackSubject.Count - 1
                    If k = 0 Then
                        DataGridView1.Rows.Item(i).Cells(4).Value = BackSubject.Item(k)
                    Else
                        DataGridView1.Rows.Item(i).Cells(4).Value = DataGridView1.Rows.Item(i).Cells(4).Value.ToString & ", " & BackSubject.Item(k)
                    End If
                Next
            End If
        Next
        DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(TotalMale).Cells(0).Value = TotalMale
        DataGridView1.Rows.Item(TotalMale).Cells(1).Value = "<-- TOTAL MALE"
        DataGridView1.Rows.Item(TotalMale).Cells(2).Value = ""
        DataGridView1.Rows.Item(TotalMale).Cells(3).Value = ""
        DataGridView1.Rows.Item(TotalMale).Cells(4).Value = ""

        SQLString = " Select tblStudents.studentid,CONCAT(st_lname,',',st_fname,' ',LEFT(st_mname,1),'.') As Name,ROUND(AVG(grade),3) As grade FROM tblYearLevelSections,tblStudentSections,tblStudentYearLevel,tblYearLevel,tblStudentSubjects,tblStudentYear,tblStudents" & _
                  " WHERE tblStudents.studentid=tblStudentYear.studentid " & _
                  " AND tblYearLevelSections.yearlevelcode=tblYearLevel.yearlevelcode" & _
                   " AND tblStudentSections.yearlevelsectioncode=tblYearLevelSections.yearlevelsectioncode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentSubjects.studentschoolyear" & _
                  " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
                  " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                  " AND yearlevelname='" & YearLevelTextBox.Text & "'" & _
                  " AND sectioncode='" & SectionTextBox.Text & "'" & _
                  " AND tblStudentYear.schoolyearid='" & SYID & "'" & _
                  " AND st_gender='Female'" & _
                " GROUP BY tblStudents.studentid" & _
                " ORDER BY tblStudents.studentid"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            Dim n As Integer = DataGridView1.Rows.Add
            DataGridView1.Rows.Item(n).Cells(0).Value = myreader("studentid").ToString
            DataGridView1.Rows.Item(n).Cells(1).Value = myreader("Name").ToString
            DataGridView1.Rows.Item(n).Cells(2).Value = myreader("grade").ToString
            If CInt(myreader("grade").ToString) > 90 Then
                FemaleAdvanced = FemaleAdvanced + 1
            ElseIf CInt(myreader("grade").ToString) > 84 Then
                FemaleProficient = FemaleProficient + 1
            ElseIf CInt(myreader("grade").ToString) > 79 Then
                FemaleApproaching = FemaleApproaching + 1
            ElseIf CInt(myreader("grade").ToString) > 74 Then
                FemaleDeveloping = FemaleDeveloping + 1
            Else
                FemaleBeginning = FemaleBeginning + 1
            End If
            TotalFemale = TotalFemale + 1
        Loop
        myconn.Close()


        For i = TotalMale + 1 To TotalMale + TotalFemale

            Dim FailNo As Integer = 0
            Subject.Clear()
            BackSubject.Clear()
            SQLString = "Select distinct sub_name from tblSubjects,tblStudentYear,tblStudentSubjects" & _
                       " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                      " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                     " AND tblStudentYear.studentschoolyear='" & SYID & DataGridView1.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                      " ORDER BY sub_name"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    Subject.Add(myreader("sub_name").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
            For j = 0 To Subject.Count - 1
                Try
                    SQLString = "Select  (ROUND(AVG(grade),2)) As grade from tblSubjects,tblStudentYear,tblStudentSubjects,tblGradings" & _
                               " where tblStudentSubjects.subjectcode=tblSubjects.subjectcode AND" & _
                              " tblStudentSubjects.studentschoolyear=tblStudentYear.studentschoolyear" & _
                              " AND tblGradings.gradingperiodid=tblStudentSubjects.gradingperiodid" & _
                              " AND sub_name='" & Subject.Item(j) & "'" & _
                     " AND tblStudentYear.studentschoolyear='" & SYID & DataGridView1.Rows.Item(i).Cells(0).Value.ToString & "'" & _
                     " GROUP BY sub_name"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        If myreader("grade").ToString = "" Then
                            FailNo = FailNo + 1
                            BackSubject.Add(Subject.Item(j))
                        ElseIf CInt(myreader("grade").ToString) >= 0 Then

                            If CInt(myreader("grade").ToString) < 75 Then
                                FailNo = FailNo + 1
                                BackSubject.Add(Subject.Item(j))
                            End If
                        End If
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Err_Back", ex.Message)
                End Try
            Next
            If FailNo > BackSubjectLimit Then
                DataGridView1.Rows.Item(i).Cells(3).Value = "Retained"
                FemaleRetained = FemaleRetained + 1
            ElseIf BackSubject.Count > 0 Then
                DataGridView1.Rows.Item(i).Cells(3).Value = "Irregular"
                FemaleIrregular = FemaleIrregular + 1
            Else
                FemalePromoted = FemalePromoted + 1
                DataGridView1.Rows.Item(i).Cells(3).Value = "Promoted"
            End If
            If yeargrade = "High School" Then
                For k = 0 To BackSubject.Count - 1
                    If k = 0 Then
                        DataGridView1.Rows.Item(i).Cells(4).Value = BackSubject.Item(k)
                    Else
                        DataGridView1.Rows.Item(i).Cells(4).Value = DataGridView1.Rows.Item(i).Cells(4).Value.ToString & ", " & BackSubject.Item(k)
                    End If
                Next
            End If
        Next
        Dim m As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(m).Cells(0).Value = TotalFemale
        DataGridView1.Rows.Item(m).Cells(1).Value = "<- Total Female"
        m = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(m).Cells(0).Value = TotalFemale + TotalMale
        DataGridView1.Rows.Item(m).Cells(1).Value = "<- COMBINED"

        ListView1.Items.Add("Promoted")
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(MalePromoted.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FemalePromoted.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add((MalePromoted + FemalePromoted).ToString)

        ListView1.Items.Add("Irregular")
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(MaleIrregular.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FemaleIrregular.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add((MaleIrregular + FemaleIrregular).ToString)

        ListView1.Items.Add("Retained")
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(MaleRetained.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FemaleRetained.ToString)
        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add((MaleRetained + FemaleRetained).ToString)



        ListView2.Items.Add("BEGINNING (B: 74% and below)")
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(MaleBeginning.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FemaleBeginning.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add((MaleBeginning + FemaleBeginning).ToString)

        ListView2.Items.Add("DEVELOPING (B: 75%-79%)")
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(MaleDeveloping.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FemaleDeveloping.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add((MaleDeveloping + FemaleDeveloping).ToString)

        ListView2.Items.Add("APPROACHING (B: 80% and 84%)")
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(MaleApproaching.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FemaleApproaching.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add((MaleApproaching + FemaleApproaching).ToString)

        ListView2.Items.Add("PROFICIENT (B: 85% and 89%)")
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(MaleProficient.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FemaleProficient.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add((MaleProficient + FemaleProficient).ToString)

        ListView2.Items.Add("ADVANCED (B: 90% and above)")
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(MaleAdvanced.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FemaleAdvanced.ToString)
        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add((MaleAdvanced + FemaleAdvanced).ToString)


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

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Dim printDialog1 As PrintDialog = New PrintDialog
        printDialog1.Document = PrintDocument1
        Dim result As DialogResult = printDialog1.ShowDialog
        If (result = DialogResult.OK) Then
            PrintForm1.Print()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub
End Class
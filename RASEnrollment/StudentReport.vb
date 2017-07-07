Option Strict On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class StudentReport
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Dim SYID As New List(Of String)
    Dim SYFrom As Date
    Dim SYTo As Date

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        Dim Order As String
        Dim OrderBy As String
        Dim dt As New DataSet
        If NameRadioButton.Checked = True Then
            OrderBy = "st_lname"
        Else
            OrderBy = "st_registration"
        End If
        If ASCRadioButton.Checked = True Then
            Order = "Asc"
        Else
            Order = "Desc"
        End If
        myconn = New MySqlConnection
        Try
            With myconn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = CONNECTION_STRING
                .Open()
            End With
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
        Try
            Try
                If ListOfComboBox.SelectedIndex = 0 Then
                    SQLString = "Select * from tblStudents,tblStudentYear,tblYearLevel,tblStudentYearLevel,tblStudentSections,tblYearLevelSections" & _
                                               " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
                                               " AND tblStudents.studentid=tblStudentYear.studentid" & _
                                               " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                                               " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
                                               " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                                               " AND tblYearLevelSections.yearlevelsectioncode = tblStudentSections.yearlevelsectioncode" & _
                                               " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                                               " GROUP BY tblstudentyear.studentschoolyear,tblYearLEvelSections.yearlevelsectioncode"
                    '" AND ORDER BY " & OrderBy & " " & Order & ""  
                    myadapter.SelectCommand = New MySqlCommand(SQLString, myconn)
                    myadapter.Fill(dt)
                    Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New CrystalReport1
                    Dim user As String = "root"
                    Dim pwd As String = ""

                    rptDoc.SetDatabaseLogon(user, pwd)
                    rptDoc.SetParameterValue("p_1", CrystalReport.CrystalReportViewer1)
                    rptDoc.Load(".\CrystalReport1.rpt")
                    rptDoc.SetDataSource(dt.Tables(0))
                    CrystalReport.CrystalReportViewer1.RefreshReport()
                    CrystalReport.CrystalReportViewer1.ReportSource = rptDoc
                ElseIf ListOfComboBox.SelectedIndex = 1 Then
                    SQLString = "Select * from tblStudents,tblStudentYear,tblYearLevel,tblStudentYearLevel,tblStudentSections,tblYearLevelSections" & _
                                               " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
                                               " AND tblStudents.studentid=tblStudentYear.studentid" & _
                                               " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                                               " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
                                               " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                                               " AND tblYearLevelSections.yearlevelsectioncode = tblStudentSections.yearlevelsectioncode" & _
                                               " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                                               " GROUP BY tblstudentyear.studentschoolyear,tblYearLEvelSections.yearlevelsectioncode"
                    '" AND ORDER BY " & OrderBy & " " & Order & ""  
                    myadapter.SelectCommand = New MySqlCommand(SQLString, myconn)
                    myadapter.Fill(dt)
                    Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New CrystalReport2
                    Dim user As String = "root"
                    Dim pwd As String = ""

                    rptDoc.SetDatabaseLogon(user, pwd)
                    rptDoc.SetParameterValue("p_1", CrystalReport.CrystalReportViewer1)
                    rptDoc.Load(".\CrystalReport2.rpt")
                    rptDoc.SetDataSource(dt.Tables(0))
                    CrystalReport.CrystalReportViewer1.RefreshReport()
                    CrystalReport.CrystalReportViewer1.ReportSource = rptDoc
                Else
                    SQLString = "Select * from tblStudents,tblStudentYear,tblYearLevel,tblStudentYearLevel,tblStudentSections,tblYearLevelSections" & _
                                              " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
                                              " AND tblStudents.studentid=tblStudentYear.studentid" & _
                                              " AND tblStudentYear.studentschoolyear=tblStudentYearLevel.studentschoolyear" & _
                                              " AND tblYearLevel.yearlevelcode=tblStudentYearLevel.yearlevelcode" & _
                                              " AND tblStudentYear.studentschoolyear=tblStudentSections.studentschoolyear" & _
                                              " AND tblYearLevelSections.yearlevelsectioncode = tblStudentSections.yearlevelsectioncode" & _
                                              " AND tblYearLevel.yearlevelcode=tblYearLevelSections.yearlevelcode" & _
                                              " GROUP BY tblstudentyear.studentschoolyear,tblYearLEvelSections.yearlevelsectioncode"
                    '" AND ORDER BY " & OrderBy & " " & Order & ""  
                    myadapter.SelectCommand = New MySqlCommand(SQLString, myconn)
                    myadapter.Fill(dt)
                    Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New CrystalReport3
                    Dim user As String = "root"
                    Dim pwd As String = ""

                    rptDoc.SetDatabaseLogon(user, pwd)
                    rptDoc.SetParameterValue("p_1", CrystalReport.CrystalReportViewer1)
                    rptDoc.Load(".\CrystalReport3.rpt")
                    rptDoc.SetDataSource(dt.Tables(0))
                    CrystalReport.CrystalReportViewer1.RefreshReport()
                    CrystalReport.CrystalReportViewer1.ReportSource = rptDoc
                End If
            Catch ex As Exception
                MessageBox.Show("Indicate the SchoolYear")
            End Try
            Dim StudentSelection As String = ""
            For i = 0 To YGPListView.Items.Count - 1
                If YGPListView.Items(i).Checked = True Then
                    If StudentSelection = "" Then
                        StudentSelection = StudentSelection & " {tblYearLevel.yearlevelname}='" & YGPListView.Items(i).SubItems(1).Text & "'"
                    Else
                        StudentSelection = StudentSelection & " OR {tblYearLevel.yearlevelname}='" & YGPListView.Items(i).SubItems(1).Text & "'"
                    End If
                End If
            Next
            ' If STCheckBox.Checked = True Then

            'ElseIf SSCheckBox.Checked = True Then
            ' CrystalReport.CrystalReportViewer1.SelectionFormula = "{tblstudentYear.studentstatus}='" & SSComboBox.SelectedItem.ToString & "'"
            ' End If
            If STCheckBox.Checked = True Then
                If StudentSelection = "" Then
                    StudentSelection = " {tblStudents.st_type}='" & STComboBox.SelectedItem.ToString & "'"
                Else
                    StudentSelection = StudentSelection & " AND {tblStudents.st_type}='" & STComboBox.SelectedItem.ToString & "'"
                End If
            End If
            If SSCheckBox.Checked = True Then
                If StudentSelection = "" Then
                    StudentSelection = " {tblStudentYear.studentstatus}='" & SSComboBox.SelectedItem.ToString & "'"
                Else
                    StudentSelection = StudentSelection & " AND {tblStudentYear.studentstatus}='" & SSComboBox.SelectedItem.ToString & "'"
                End If
            End If
            CrystalReport.CrystalReportViewer1.SelectionFormula = StudentSelection

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            myconn.Close()
        End Try
            CrystalReport.ShowDialog()
            CrystalReport.Dispose()
    End Sub

    Private Sub StudentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        forGroupBox.Enabled = False
        SortByGroupBox.Enabled = False
        OrderByGroupBox.Enabled = False
        FilterByGroupBox.Enabled = False
        Dim LoadSY As String = "Select schoolyearid As schoolyearid,date(schoolyearstart) As datefrom,date(schoolyearend) As dateto  from tblSchoolYear" & _
            " ORDER BY schoolyearstart DESC"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadSY
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                SYID.Add(myreader("schoolyearid").ToString)
                SYComboBox.Items.Add(CDate(myreader("datefrom").ToString) & " - " & CDate((myreader("dateto")).ToString))
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("aaaNo records found." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            myconn.Close()
        End Try
    End Sub

























  
   

    Private Sub STCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STCheckBox.CheckedChanged
        If STCheckBox.Checked = True Then
            STComboBox.Enabled = True
            STComboBox.SelectedIndex = 0
        Else
            STComboBox.Enabled = False
            STComboBox.Text = ""
        End If
    End Sub

    Private Sub SSCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSCheckBox.CheckedChanged
        If SSCheckBox.Checked = True Then
            SSComboBox.Enabled = True
            SSComboBox.SelectedIndex = 0
        Else
            SSComboBox.Enabled = False
            SSComboBox.Text = ""
        End If
    End Sub

 
    Private Sub ListOfComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfComboBox.SelectedIndexChanged
        forGroupBox.Enabled = True
        SortByGroupBox.Enabled = True
        OrderByGroupBox.Enabled = True
        FilterByGroupBox.Enabled = True
        If ListOfComboBox.Text = "Students" Then
            AsofGroupBox.Visible = False
            PTGroupBox.Visible = False
            RegDateRadioButton.Enabled = True
            RegDateRadioButton.Text = "Registration Date"
            GradesRadioButton.Enabled = False
        ElseIf ListOfComboBox.Text = "Grades" Then
            AsofGroupBox.Visible = False
            PTGroupBox.Visible = False
            RegDateRadioButton.Enabled = False
            GradesRadioButton.Enabled = True
        Else
            AsofGroupBox.Visible = True
            PTGroupBox.Visible = True
            RegDateRadioButton.Enabled = True
            RegDateRadioButton.Text = "Payment Date"
            GradesRadioButton.Enabled = False
        End If
        YGPListView.Items.Clear()
        SQLString = "Select yearlevelname from tblYearLevel"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                YGPListView.Items.Add("")
                YGPListView.Items(YGPListView.Items.Count - 1).SubItems.Add(myreader("yearlevelname").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_year." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("No records found.")
            myconn.Close()
        End Try
    End Sub

  
End Class
Option Strict On
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class AssessmentForm
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SqlString As String
    Private Sub AssessmentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTextBox.Text = System.DateTime.Now.ToString
        UserNameTextBox.Text = Main.UserName
        StudentNoTextBox.Text = Main.StudentNoAssessTextBox.Text
        StudentNameTextBox.Text = Main.StudentNameAssessTextBox.Text
        SchoolYearTextBox.Text = Main.SYFromLabel.Text & "-" & Main.SYToLabel.Text
        If Main.ReservationRadioButton.Checked = True Then
            YearSectionTextBox.Text = Main.YearLevelAssessTextBox.Text & "-" & Main.SectionReservation
        Else
            YearSectionTextBox.Text = Main.YearLevelAssessTextBox.Text & "-" & Main.SectionAssessTextBox.Text
        End If

        For i = 0 To Main.MiscellaneousAssessListView.Items.Count - 1
            MisListView.Items.Add(Main.MiscellaneousAssessListView.Items(i).SubItems(0).Text)
            MisListView.Items(MisListView.Items.Count - 1).SubItems.Add(Main.MiscellaneousAssessListView.Items(i).SubItems(1).Text)
        Next
        If Main.DiscountTotal > 0 Then
            DiscountLabel.Text = DiscountLabel.Text & " " & Main.DiscountAssessTextBox.Text & "."
        Else
            DiscountLabel.Visible = False
        End If
        For i = 0 To Main.TuitionAssessListView.Items.Count - 1
            TuitionListView.Items.Add(Main.TuitionAssessListView.Items(i).SubItems(0).Text)
            TuitionListView.Items(TuitionListView.Items.Count - 1).SubItems.Add(Main.TuitionAssessListView.Items(i).SubItems(1).Text)
            TuitionListView.Items(TuitionListView.Items.Count - 1).SubItems.Add(Main.TuitionAssessListView.Items(i).SubItems(2).Text)
        Next
        For i = 0 To Main.OthersAssessListView.Items.Count - 1
            If Main.OthersAssessListView.Items(i).Checked Then
                'MessageBox.Show(Main.OthersAssessListView.Items(i).SubItems(1).Text)
                OthersListView.Items.Add(Main.OthersAssessListView.Items(i).SubItems(0).Text)
                OthersListView.Items(OthersListView.Items.Count - 1).SubItems.Add(Main.OthersAssessListView.Items(i).SubItems(1).Text)
            End If
        Next
        For i = 0 To Main.DataGridView1.Rows.Count - 1
            ListOfSchedulesListView.Items.Add(Main.DataGridView1.Rows.Item(i).Cells(0).Value.ToString)
            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(Main.DataGridView1.Rows.Item(i).Cells(1).Value.ToString)
            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(Main.DataGridView1.Rows.Item(i).Cells(2).Value.ToString)
            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(Main.DataGridView1.Rows.Item(i).Cells(3).Value.ToString)
            ListOfSchedulesListView.Items(ListOfSchedulesListView.Items.Count - 1).SubItems.Add(Main.DataGridView1.Rows.Item(i).Cells(4).Value.ToString)
        Next
        DiscountLabel.Text = DiscountLabel.Text & " " & Main.DiscountAssessTextBox.Text
        DownPaymentTextBox.Text = Main.DownPaymentTextBox.Text
        TuitionandComputerTextBox.Text = String.Format("{0:" + "P" + "#,##0.00}", Main.FullTuitionBalance + Main.FullComputerBalance)
        GrandTotalTextBox.Text = Main.GrandTotalTextBox.Text
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
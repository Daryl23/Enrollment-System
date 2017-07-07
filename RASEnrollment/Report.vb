Public Class Report

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserNameTextBox.Text = Main.UserName
        DateTextBox.Text = Date.Today.ToString
        'ReceiptListView.Clear()
        ListOfLabel.Text = "List Of"
        If Main.YearRecordComboBox.Text = "" And Main.SectionRecordComboBox.Text = "" Then
            ListOfLabel.Text = ListOfLabel.Text & " " & Main.TransactionComboBox.Text
        ElseIf Main.YearRecordComboBox.SelectedIndex >= 0 And Main.SectionRecordComboBox.SelectedIndex >= 0 Then
            ListOfLabel.Text = ListOfLabel.Text & " " & Main.TransactionComboBox.Text & " for " & Main.YearRecordComboBox.Text & "-" & Main.SectionRecordComboBox.Text
        ElseIf Main.YearRecordComboBox.SelectedIndex >= 0 Then
            ListOfLabel.Text = ListOfLabel.Text & " " & Main.TransactionComboBox.Text & " for " & Main.YearRecordComboBox.Text & ""
        End If
        Dim Less As Integer = 0
        If Main.TransactionComboBox.Text = "Student Records" Then
            Less = 2
        Else
            Less = 1
        End If
        For i = 0 To Main.RecordsDataGridView.ColumnCount - Less
            ReceiptListView.Columns.Add(Main.RecordsDataGridView.Columns(i).HeaderText)
            ReceiptListView.Columns(i).Width = 80
        Next
        For i = 0 To Main.RecordsDataGridView.RowCount - 1
            ReceiptListView.Items.Add(Main.RecordsDataGridView.Rows.Item(i).Cells(0).Value)
            For j = 1 To Main.RecordsDataGridView.ColumnCount - 1
                Dim Record As String = Main.RecordsDataGridView.Rows.Item(i).Cells(j).Value
                ReceiptListView.Items(ReceiptListView.Items.Count - 1).SubItems.Add(Record)
            Next
        Next
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
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
        Main.Show()
        Me.Close()
    End Sub
End Class
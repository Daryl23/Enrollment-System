Public Class ProgressReportCard

    Private Sub ProgressReportCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To Main.SubjectGradeDataGridView.ColumnCount - 1
            ListView1.Columns.Add(Main.SubjectGradeDataGridView.Columns.Item(i).HeaderText)
        Next
        ListView1.Columns.Add("FINAL RATING")
        ListView1.Columns.Add("REMARKS")
        For i = 0 To Main.SubjectGradeDataGridView.Rows.Count - 1
            'Dim n As String = Main.SubjectGradeDataGridView.Rows.Item(i).Cells(1).Value.ToString
            'ListView1.Items.Add(n)
            'For j = 1 To Main.SubjectGradeDataGridView.ColumnCount - 1
            'ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Main.SubjectGradeDataGridView.Rows.Item(i).Cells(j).Value.ToString)
            'Next
        Next
    End Sub
End Class
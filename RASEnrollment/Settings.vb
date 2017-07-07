Option Strict On
Imports MySql.Data.MySqlClient
Public Class Settings
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Main.Show()
        Me.Close()
    End Sub


    Private Sub SaveSystemDTButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSystemDTButton.Click
        If ReservationFeeTextBox.Text = "" Or BackSubjectTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If TabControl1.SelectedIndex = 0 Then
                ' Main.NewDate = CDate(SystemDateDateTimePicker.Text)
                ' Main.NewTime = CDate(SystemTimeDateTimePicker.Text)
                Try
              
                    SQLString = "UPDATE tblYearLevelFee " & " SET fee_amount='" & CDec(ReservationFeeTextBox.Text) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    SQLString = "UPDATE Others " & " SET backsubjectlimit='" & CInt(BackSubjectTextBox.Text) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                    MessageBox.Show("Successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch
                    MessageBox.Show("Input must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else

                SQLString = "UPDATE tblYearLevelFee " & " SET fee_amount='" & CDec(ReservationFeeTextBox.Text) & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
            Clear()
        End If
    End Sub

    Private Sub EditSystemDateTimeButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSystemDateTimeButton.Click
        SaveSystemDTButton.Enabled = True
        EditSystemDateTimeButton.Enabled = False
        ReservationFeeTextBox.Enabled = True
        UnitDataGridView.Enabled = True
        BackSubjectTextBox.Enabled = True
        'SystemDateDateTimePicker.Enabled = True
        'SystemTimeDateTimePicker.Enabled = True
    End Sub
    Public Sub Clear()
        EditSystemDateTimeButton.Enabled = True
        SaveSystemDTButton.Enabled = False
        ReservationFeeTextBox.Text = ""
        BackSubjectTextBox.Text = ""
        ReservationFeeTextBox.Enabled = False
        UnitDataGridView.Rows.Clear()
        UnitDataGridView.Enabled = False
        BackSubjectTextBox.Enabled = False
        SQLString = "SELECT fee_amount from tblYearLevelfee where fee_name='Reservation Fee'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            ReservationFeeTextBox.Text = myreader("fee_amount").ToString
        Loop
        myconn.Close()
        SQLString = "SELECT fee_amount from tblYearLevelfee where fee_name='Unit Cost'"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            ReservationFeeTextBox.Text = myreader("fee_amount").ToString
        Loop
        myconn.Close()

        SQLString = "Select  backsubjectlimit from Others"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            BackSubjectTextBox.Text = CStr(CInt(myreader("backsubjectlimit")))
        Loop
        myconn.Close()

        SQLString = "Select  * from tblUnits "
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            Dim n As Integer = UnitDataGridView.Rows.Add
            UnitDataGridView.Rows.Item(n).Cells(0).Value = myreader("unit").ToString
            UnitDataGridView.Rows.Item(n).Cells(1).Value = myreader("cost").ToString
        Loop
        myconn.Close()

        'SystemTimeDateTimePicker.Text = System.DateTime.Now.ToShortDateString
        'SystemDateDateTimePicker.Text = System.DateTime.Now.ToShortTimeString

        'SystemDateDateTimePicker.Enabled = True
        'SystemTimeDateTimePicker.Enabled = True
        SaveSystemDTButton.Enabled = False
    End Sub
    Private Sub DisableSystemButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableSystemButton.Click
        Clear()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Clear()
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub ReservationFeeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationFeeTextBox.TextChanged
        If IsNumeric(ReservationFeeTextBox.Text) = False Then
            ReservationFeeTextBox.Text = "0"
        End If
    End Sub

    Private Sub UnitDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UnitDataGridView.CellEndEdit
        Try
            Dim y As Integer = UnitDataGridView.CurrentCellAddress.Y
            Dim x As Integer = UnitDataGridView.CurrentCellAddress.X
            Dim grading As String = ""
            If UnitDataGridView.Rows.Count > 0 Then
                 For i = 0 To UnitDataGridView.Rows.Count - 1
                    SQLString = " UPDATE tblUnits SET cost=" & UnitDataGridView.Rows.Item(y).Cells(1).Value.ToString & "" & _
  " WHERE unit='" & UnitDataGridView.Rows.Item(y).Cells(0).Value.ToString & "'"
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub UnitDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UnitDataGridView.CellContentClick

    End Sub
End Class
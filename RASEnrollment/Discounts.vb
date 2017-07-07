Option Strict On
Imports MySql.Data.MySqlClient
Public Class Discounts
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;" ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Private Sub Discounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewDiscounts()
    End Sub

    Dim SQLString As String
    Dim DiscountBy As String
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If GradeComboBox.Text = "" Or DiscountTextBox.Text = "" Or DiscountRateTextBox.Text = "" Or DiscountTypeComboBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf DiscountTextBox.Text = "Cash" Or DiscountTextBox.Enabled = True Then
            If PercentageRadioButton.Checked = True Then
                DiscountBy = "Percent"
            Else
                DiscountBy = "Amount"
            End If
           
            Try
                SQLString = "INSERT INTO tblDiscounts " & "VALUES ('" & (GradeComboBox.Text & DiscountTextBox.Text.Trim()).Trim & "','" & DiscountTextBox.Text.Trim() & "','" & DiscountRateTextBox.Text.Trim() & "','" & GradeComboBox.Text & "','" & DiscountTypeComboBox.Text & "','" & DiscountBy & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()

                MessageBox.Show("Successfully added new discount information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("There's already a same discount in the database." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                myconn.Close()
            End Try

        Else

            SQLString = "UPDATE tblDiscounts SET dis_rate='" & DiscountRateTextBox.Text & "'" & _
            " WHERE dis_name='" & DiscountTextBox.Text & "' AND yeargrade='" & GradeComboBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        End If
        DiscountTextBox.Clear()
        DiscountRateTextBox.Clear()
        DiscountTextBox.Enabled = True
        ViewDiscounts()
    End Sub
    Public Sub ClearAll()
        'DiscountTextBox.Text = ""
        DiscountTypeComboBox.Enabled = True
        PercentageRadioButton.Enabled = True
        AmountRadioButton.Enabled = True
        PercentageRadioButton.Checked = True
        DiscountRateTextBox.Text = ""
    End Sub
    Public Sub ViewDiscounts()
        ClearAll()
        DiscountListView.Items.Clear()
        Dim i As Integer = 0
        SQLString = "SELECT * " & " FROM tblDiscounts WHERE yeargrade='" & GradeComboBox.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                DiscountListView.Items.Add("")
                DiscountListView.Items(DiscountListView.Items.Count - 1).SubItems.Add(myreader("dis_name").ToString)
                DiscountListView.Items(DiscountListView.Items.Count - 1).SubItems.Add(myreader("discounttype").ToString)
                DiscountListView.Items(DiscountListView.Items.Count - 1).SubItems.Add(myreader("discountby").ToString)
                DiscountListView.Items(DiscountListView.Items.Count - 1).SubItems.Add(myreader("dis_rate").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub



    Private Sub RoomsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Rooms.Show()
    End Sub

    Private Sub RoomsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Rooms.Show()
    End Sub


    Private Sub RefundButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Refund.Show()
    End Sub

    Private Sub RefundPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Refund.Show()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To DiscountListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                DiscountListView.Items(c).Checked = True
            Else
                DiscountListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim err As Integer = 0
        For g = 0 To DiscountListView.Items.Count - 1
            If DiscountListView.Items.Item(g).Checked = True Then
                If DiscountListView.Items(g).SubItems(3).Text = "Default Discount" Then
                    err = 1
                End If
            End If
        Next
        If err = 0 Then
            For g = 0 To DiscountListView.Items.Count - 1
                If DiscountListView.Items.Item(g).Checked = True Then
                    Try
                        SQLString = "Delete from tblDiscounts where dis_name = '" & DiscountListView.Items(g).SubItems(1).Text & "'" & _
                        " AND yeargrade='" & GradeComboBox.Text & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                    Catch ex As Exception
                    End Try
                End If
            Next
            ViewDiscounts()
        Else
            MessageBox.Show("Default Discounts could not be deleted. Action was not able to continue", "Action Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        GradeComboBox.SelectedIndex = -1
        GradeComboBox.Enabled = True
        DiscountTextBox.Text = ""
        DiscountTextBox.Enabled = True
        DiscountRateTextBox.Text = ""
        DiscountTypeComboBox.SelectedIndex = -1
    End Sub
    Private Sub DiscountListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountListView.Click
        For a = 0 To DiscountListView.Items.Count - 1
            If DiscountListView.Items.Item(a).Selected = True Then
                DiscountTextBox.Enabled = False
                GradeComboBox.Enabled = False
                DiscountTypeComboBox.Enabled = False
                PercentageRadioButton.Enabled = False
                AmountRadioButton.Enabled = False
                DiscountTextBox.Text = DiscountListView.SelectedItems(0).SubItems(1).Text
                DiscountRateTextBox.Text = DiscountListView.SelectedItems(0).SubItems(4).Text
                DiscountTypeComboBox.Text = DiscountListView.SelectedItems(0).SubItems(2).Text
                If DiscountListView.Items(a).SubItems(3).Text = "Percent" Then
                    PercentageRadioButton.Checked = True
                Else
                    AmountRadioButton.Checked = True
                End If
                'SaveButton.Enabled = True
            End If
        Next
    End Sub

    Private Sub DiscountListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountListView.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeComboBox.SelectedIndexChanged
        If GradeComboBox.Text = "Grade School" Then
            DiscountTypeComboBox.Items.Clear()
            DiscountTypeComboBox.Items.Add("Default Discount")
            DiscountTypeComboBox.Items.Add("Other Discount")
        Else
            DiscountTypeComboBox.Items.Clear()
            DiscountTypeComboBox.Items.Add("Default Discount")
            DiscountTypeComboBox.Items.Add("Honor Discount")
            DiscountTypeComboBox.Items.Add("Other Discount")
        End If
        ViewDiscounts()
    End Sub

    Private Sub PercentageRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercentageRadioButton.CheckedChanged
        Label2.Text = "Percent:"
        Label3.Visible = True
    End Sub

    Private Sub AmountRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmountRadioButton.CheckedChanged
        Label2.Text = "Amount:"
        Label3.Visible = False
    End Sub

    Private Sub DiscountTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountTypeComboBox.SelectedIndexChanged
        If DiscountTypeComboBox.Text = "Default Discount" Then
            'SaveButton.Enabled = False
        Else
            SaveButton.Enabled = True
        End If
    End Sub

    Private Sub GradeComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
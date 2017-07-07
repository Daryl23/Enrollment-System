Option Strict On
Imports MySql.Data.MySqlClient
Public Class Refund
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;" ';;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim SQLString As String
    Public Sub ViewRefunds()
        ClearAll()
        RefundListView.Items.Clear()
        Dim i As Integer = 0
        SQLString = "SELECT refunddays,refund " & " FROM tblRefunds" & _
        " ORDER BY refunddays"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                RefundListView.Items.Add(i.ToString)
                RefundListView.Items(RefundListView.Items.Count - 1).SubItems.Add(myreader("refunddays").ToString)
                RefundListView.Items(RefundListView.Items.Count - 1).SubItems.Add(myreader("refund").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DiscountsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountsButton.Click
        Me.Close()
        Discounts.Show()
    End Sub

    Private Sub DiscountsPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountsPictureBox.Click
        Me.Close()
        Discounts.Show()
    End Sub
    Dim DayInteger As Integer
    Dim Percentage As Integer
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If DaysTextBox.Text = "" Or PercentageTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim err As Integer = 0
            Try
                DayInteger = CInt(DaysTextBox.Text)
                Percentage = CInt(PercentageTextBox.Text)
            Catch
                err = 1
            End Try
            If DaysTextBox.Enabled = False Then
                Try
                    SQLString = "UPDATE tblRefunds SET refund='" & PercentageTextBox.Text & "'" & _
                    " WHERE refunddays='" & DaysTextBox.Text & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    mycommand.ExecuteNonQuery()
                    myconn.Close()

                    MessageBox.Show("Successfully updated refund information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                Dim RefundList As New List(Of Integer)
                SQLString = "SELECT refunddays " & " FROM tblRefunds"
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        RefundList.Add(CInt(myreader("refunddays")))
                    Loop
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                If err = 0 Then
                    For i = 0 To RefundList.Count - 1
                        If DayInteger = RefundList.Item(i) Then
                            err = 1
                            Exit For
                        End If
                    Next
                    If err = 0 Then
                        Try
                            SQLString = "INSERT INTO tblRefunds " & "VALUES ('" & "Day" & DayInteger.ToString & "'," & DayInteger.ToString & ",'" & PercentageTextBox.Text.Trim() & "')"
                            myconn.ConnectionString = CONNECTION_STRING
                            myconn.Open()
                            mycommand.Connection = myconn
                            mycommand.CommandText = SQLString
                            mycommand.ExecuteNonQuery()
                            myconn.Close()

                            MessageBox.Show("Successfully added new refund information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            myconn.Close()
                            MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    Else
                        MessageBox.Show("Days must be greater than any of the other refund days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                End If
                ViewRefunds()
        End If
    End Sub
 
    Private Sub RequirementButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequirementButton.Click
        Requirement.Show()
        Me.Close()
    End Sub

    Private Sub RequirementPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequirementPictureBox.Click
        Requirement.Show()
        Me.Close()
    End Sub
    Public Sub ClearAll()
        DaysTextBox.Enabled = True
        DaysTextBox.Text = ""
        PercentageTextBox.Text = ""
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    Private Sub RefundListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundListView.Click
        For a = 0 To RefundListView.Items.Count - 1
            If RefundListView.Items.Item(a).Selected = True Then
                DaysTextBox.Enabled = False
                DaysTextBox.Text = RefundListView.Items(a).SubItems(1).Text
                PercentageTextBox.Text = RefundListView.Items(a).SubItems(2).Text
                myconn.Close()
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To RefundListView.Items.Count - 1
            If RefundListView.Items.Item(g).Checked = True Then
                SQLString = "Delete from tblRefunds where refunddays = '" & RefundListView.Items(g).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewRefunds()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To RefundListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                RefundListView.Items(c).Checked = True
            Else
                RefundListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub Refund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewRefunds()
    End Sub

    Private Sub PercentageTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercentageTextBox.TextChanged

    End Sub

    Private Sub RefundListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefundListView.SelectedIndexChanged

    End Sub
End Class
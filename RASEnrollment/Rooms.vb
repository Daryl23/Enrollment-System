Option Strict On
Imports MySql.Data.MySqlClient
Public Class Rooms
     Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim LoadInfo As String
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If RoomNoTextBox.Text = "" Or BuildingTextBox.Text = "" Or FloorTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf RoomNoTextBox.Enabled = False Then
            LoadInfo = "UPDATE tblRooms SET room_name='" & "RM" & RoomNoTextBox.Text.Trim() & " ' WHERE roomno='" & RoomNoTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            mycommand.ExecuteNonQuery()
            myconn.Close()
            LoadInfo = "UPDATE tblRooms SET room_type='" & RoomTypeComboBox.Text.Trim() & "' WHERE roomno='" & RoomNoTextBox.Text & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            mycommand.ExecuteNonQuery()
            myconn.Close()

            MessageBox.Show("Successfully updated information.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Dim SQLString As String
            Try

                SQLString = "INSERT INTO tblRooms(roomno,room_name,room_building,room_floor,room_type)" & "VALUES ('" & RoomNoTextBox.Text.Trim() & "','" & "RM" & RoomNoTextBox.Text.Trim() & "','" & RoomTypeComboBox.Text.Trim() & "','" & BuildingTextBox.Text.Trim() & "','" & FloorTextBox.Text.Trim() & "')"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()

                MessageBox.Show("Successfully added new room information.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                myconn.Close()
                MessageBox.Show("Duplicate Entry Detected: (Room).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
        ViewRooms()
    End Sub
    Public Sub ViewRooms()
        ClearAll()
        RoomsListView.Items.Clear()
        Dim i As Integer = 0
        LoadInfo = "SELECT roomno,room_name,room_building,room_floor,room_type" & " FROM tblRooms "
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = LoadInfo
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                i = i + 1
                RoomsListView.Items.Add(i.ToString)
                RoomsListView.Items(RoomsListView.Items.Count - 1).SubItems.Add(myreader("roomno").ToString)
                RoomsListView.Items(RoomsListView.Items.Count - 1).SubItems.Add(myreader("room_name").ToString)
                RoomsListView.Items(RoomsListView.Items.Count - 1).SubItems.Add(myreader("room_building").ToString)
                RoomsListView.Items(RoomsListView.Items.Count - 1).SubItems.Add(myreader("room_floor").ToString)
                RoomsListView.Items(RoomsListView.Items.Count - 1).SubItems.Add(myreader("room_type").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Rooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewRooms()
    End Sub

  
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TeacherPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherPictureBox.Click
        Me.Close()
        Teachers.Show()
    End Sub

    Private Sub TeacherButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherButton.Click
        Me.Close()
        Teachers.Show()
    End Sub

    Private Sub DiscountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountButton.Click
        Me.Close()
        Discounts.Show()
    End Sub

    Private Sub DiscountPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscountPictureBox.Click
        Me.Close()
        Discounts.Show()
    End Sub
    Public Sub ClearAll()
        RoomNoTextBox.Enabled = True
        BuildingTextBox.Enabled = True
        FloorTextBox.Enabled = True
        RoomNoTextBox.Text = ""
        RoomTypeComboBox.Text = "Lecture"
        BuildingTextBox.Text = ""
        FloorTextBox.Text = ""
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    Private Sub CheckCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckCheckBox.CheckedChanged
        For c = 0 To RoomsListView.Items.Count - 1
            If CheckCheckBox.Checked = True Then
                RoomsListView.Items(c).Checked = True
            Else
                RoomsListView.Items(c).Checked = False
            End If
        Next
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        For g = 0 To RoomsListView.Items.Count - 1
            If RoomsListView.Items.Item(g).Checked = True Then
                LoadInfo = "Delete from tblRooms where roomno = '" & RoomsListView.Items(g).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = LoadInfo
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewRooms()
    End Sub

    Private Sub RoomsListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsListView.Click
        For a = 0 To RoomsListView.Items.Count - 1
            If RoomsListView.Items.Item(a).Selected = True Then
                RoomNoTextBox.Enabled = False
                BuildingTextBox.Enabled = False
                FloorTextBox.Enabled = False
                RoomNoTextBox.Text = RoomsListView.Items(a).SubItems(0).Text
                RoomTypeComboBox.Text = RoomsListView.Items(a).SubItems(3).Text
                BuildingTextBox.Text = RoomsListView.Items(a).SubItems(4).Text
                FloorTextBox.Text = RoomsListView.Items(a).SubItems(5).Text
            End If
        Next
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RoomsListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsListView.SelectedIndexChanged

    End Sub

    Private Sub FloorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorTextBox.TextChanged

    End Sub
End Class
Option Strict On
Imports MySql.Data.MySqlClient
Imports System.IO


Public Class WebsiteMaintenance

    Public CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            ViewNews()
        ElseIf TabControl1.SelectedIndex = 1 Then
        ElseIf TabControl1.SelectedIndex = 2 Then
            ViewContacts()
        ElseIf TabControl1.SelectedIndex = 3 Then
        ElseIf TabControl1.SelectedIndex = 4 Then
        ElseIf TabControl1.SelectedIndex = 5 Then
        End If
    End Sub
    Dim NewsId As New List(Of Integer)
    Sub ViewNews()
        ListView2.Items.Clear()
        NewsId.Clear()
        TitleSlideshowTextBox.Text = ""
        ContentSlideShowTextBox.Text = ""
        DateTimePicker1.Text = Date.Today.ToString
        TitleSlideshowTextBox.Enabled = False
        ContentSlideShowTextBox.Enabled = False
        DateTimePicker1.Enabled = False
        SqlString = "Select Newsid,newstitle from newsevents where newscategory='" & ComboBox1.Text & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                NewsId.Add(CInt(myreader("newsid")))
                ListView2.Items.Add(myreader("newstitle").ToString)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Err_ViewNews.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub ViewNewsContent()
        Dim SelectedNews As Integer
        For i = 0 To ListView2.Items.Count - 1
            If ListView2.Items(i).Selected = True Then
                SelectedNews = i
                Exit For
            End If
        Next
        Try
            SqlString = "Select * from newsevents where newsid='" & NewsId.Item(SelectedNews) & "'"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                ContentSlideShowTextBox.Text = myreader("newscontent").ToString
                TitleSlideshowTextBox.Text = myreader("newstitle").ToString
                'Dim byteImage() As Byte = CType(myreader("newsimage"), Byte())
                'Dim frmImageView As New System.IO.MemoryStream(byteImage)
                'frmImageView.pctImage.Image = Image.FromStream(stmFoto)
                'frmImageView.pctImage.SizeMode = PictureBoxSizeMode.Zoom
                'frmImageView.Show()
                DateTimePicker1.Text = CStr(CDate(myreader.GetDateTime("newsdate").ToString("MM/dd/yyyy")))
                BrowsePictureBox.Image = CType(myreader("newsimage"), Image)
            Loop
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            myconn.Close()
        End Try
    End Sub
    Sub ViewContacts()
        TextBox8.Text = ""
        SqlString = "Select * from schoolinfo "
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            TextBox8.Text = myreader("contactno").ToString
        Loop
        myconn.Close()
        ListView5.Items.Clear()
        SqlString = "Select * from tblcontacts "
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            ListView5.Items.Add("")
            ListView5.Items(ListView5.Items.Count - 1).SubItems.Add(myreader("email").ToString)
            ListView5.Items(ListView5.Items.Count - 1).SubItems.Add(myreader("name").ToString)
            ListView5.Items(ListView5.Items.Count - 1).SubItems.Add(myreader("isread").ToString)
        Loop
        myconn.Close()
    End Sub




    Dim SqlString As String
    Dim filename As String
    Dim FileSize As UInt32
    Dim ImageData() As Byte

    Dim fs As FileStream
    Dim br As BinaryReader

    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        'BrowseTextBox.Text = ""
        BrowsePictureBox.Image = Nothing

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "(Image Files) |*.jpg;*.png;*.bmp;*.gif;*.ico|.jpg | *.jpg|.png | *.png|.bmp | *.bmp|.gif | *.gif|.ico | *.ico" ', .Multiselect = False, .Title = "Select Image"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim FileName As String = strFileName
            fs = New FileStream(FileName, FileMode.Open, FileAccess.Read)
            br = New BinaryReader(fs)
            ImageData = br.ReadBytes(CType(fs.Length, Integer))
            br.Close()
            fs.Close()
            BrowsePictureBox.Image = System.Drawing.Bitmap.FromFile(strFileName)
            'BrowseTextBox.Text = fInfo.ToString
            TitleSlideshowTextBox.Enabled = True
            ContentSlideShowTextBox.Enabled = True
        Else

            TitleSlideshowTextBox.Enabled = False
            ContentSlideShowTextBox.Enabled = False
        End If
    End Sub
   
    Private Sub WebsiteMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = "News"
        ViewNews()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        'Dim lb() As Byte = Data.Rows(0).Item("picture")
        'Dim lstr As New System.IO.MemoryStream(lb)
        'PbPicture.Image = Image.FromStream(lstr)
    End Sub

    Private Sub AddSlideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSlideButton.Click
        If TitleSlideshowTextBox.Text = "" Or ContentSlideShowTextBox.Text = "" Then
            MessageBox.Show("All fields are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CDate(DateTimePicker1.Text) < Date.Today Then
            MessageBox.Show("Only updated news/ events could be added. Check the date.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SqlString = "insert into newsevents " & _
                                    "VALUES('','" & TitleSlideshowTextBox.Text & "','" & ComboBox1.Text & "','" & ContentSlideShowTextBox.Text & "',@Image," & DateTimePicker1.Text & ")"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                With mycommand
                    .CommandText = SqlString
                    .Connection = myconn
                    mycommand.Parameters.Add("@Image", MySqlDbType.Blob)
                    mycommand.Parameters("@Image").Value = ImageData
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                myconn.Close()
            End Try
            ViewNews()
        End If
    End Sub
    Dim About As Integer = 1

    Private Sub HistoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HistoryGroupBox.BringToFront()
        About = 1
    End Sub

    Private Sub VisionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VisionMissionGroupBox.BringToFront()
        About = 2
    End Sub

    Private Sub FacilitiesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilitiesButton.Click
        FacilitiesGroupBox.BringToFront()
        About = 3
    End Sub

    Private Sub OrganizationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizationButton.Click
        OrganizationGroupBox.BringToFront()
        About = 4
    End Sub

    Dim facilitycnt As Integer

    Private Sub SaveAboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAboutButton.Click
        If About = 1 Then
            Try
                SqlString = "UPDATE aboutus " & " SET History ='" & HistoryContentTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                SqlString = "UPDATE aboutus " & " SET Historypic ='" & HistoryImageLocationTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf About = 2 Then
            Try
                SqlString = "UPDATE aboutus " & " SET Vision ='" & VisionTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                SqlString = "UPDATE aboutus " & " SET Mission ='" & MissionTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        ElseIf About = 3 Then
            Try
                SqlString = " Select COUNT(facilityID) from facility"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read

                    facilitycnt = CInt(myreader("facility"))
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show("No records found." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myconn.Close()
            End Try

            Try
                'SqlString = "INSERT INTO facility " & "VALUES ('" & "facility" & facilitycnt + 1 & "','" & FacilityNameTextBox.Text & "','" & FacilityImageLocationTextBox.Text & "')"
                'myconn.ConnectionString = CONNECTION_STRING
                'myconn.Open()
                'mycommand.Connection = myconn
                'mycommand.CommandText = SqlString
                'mycommand.ExecuteNonQuery()
                'myconn.Close()
            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.tblYearLevelPlease try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf About = 4 Then
            Try
                SqlString = "UPDATE aboutus " & " SET Organization ='" & OrganizationNameTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                SqlString = "UPDATE aboutus " & " SET OrganizationPic ='" & OrganizationImageLocationTextBox.Text & "'" & _
                " WHERE AboutusID ='AboutID' "
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()

            Catch ex As Exception
                MessageBox.Show("Unable to connect to DB.Please try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub




    Dim Faqid As New List(Of Integer)
    Public Sub ViewFAQ()
        FAQListView.Items.Clear()
        SqlString = " Select faqid,faqquestion,faqanswer from faq"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SqlString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            FAQListView.Items.Add(myreader("faqquestion").ToString)
            FAQListView.Items(FAQListView.Items.Count - 1).SubItems.Add(myreader("faqanswer").ToString)
        Loop
        myconn.Close()
    End Sub
    Private Sub AddToListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SqlString = "INSERT INTO faq " & "VALUES ('" & QuestionTextBox.Text & "','" & AnswerTextBox.Text & "')"
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to DB.tblYearLevelPlease try again." & ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        ViewFAQ()
    End Sub
    Private Sub DeleteFAQButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To FAQListView.Items.Count - 1
            If ListView2.Items(i).Checked = True Then
                Try
                    Dim SQlInsert As String = "DELETE FROM faq WHERE newsid='" & NewsId.Item(i) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQlInsert
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ViewNews()
    End Sub

    Private Sub ListView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.Click
        ViewNewsContent()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        For i = 0 To ListView2.Items.Count - 1
            If ListView2.Items(i).Checked = True Then
                Try
                    Dim SQlInsert As String = "DELETE FROM newsevents WHERE newsid='" & NewsId.Item(i) & "'"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQlInsert
                    mycommand.ExecuteNonQuery()
                    myconn.Close()
                Catch ex As Exception
                    MessageBox.Show("Unable to connect to DBAcc.Please try again." & ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        Next
        ViewNews()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ViewNews()
    End Sub

    Private Sub AddContactNoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddContactNoButton.Click
        If TextBox8.Text = "" Then
            MessageBox.Show("Contact number cannot be left blank.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SqlString = "UPDATE schoolinfo " & " SET  contactno='" & TextBox8.Text & "'" & _
               " WHERE AboutusID ='AboutID' "
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SqlString
            mycommand.ExecuteNonQuery()
            myconn.Close()
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox8.Text = ""
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Main.Show()
    End Sub

    Private Sub AddToListButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToListButton.Click

    End Sub

    Private Sub ListView5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView5.SelectedIndexChanged
        TextBox9.Clear()
        For i = 0 To ListView5.Items.Count - 1
            If ListView5.Items(i).Selected = True Then
                SqlString = "Select vmessages from tblcontacts where email='" & ListView5.Items(i).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    TextBox9.Text = myreader("vmessages").ToString
                Loop
                myconn.Close()
                SqlString = "UPDATE tblcontacts " & " SET  isread='Read'" & _
              " WHERE email='" & ListView5.Items(i).SubItems(1).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SqlString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
        ViewContacts()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

    End Sub
End Class
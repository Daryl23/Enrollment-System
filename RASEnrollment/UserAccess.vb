Option Strict On
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class UserAccess
    Const CONNECTION_STRING As String = "Data Source=localhost;Database=DBEnrollment;User ID=root;Password=;"
    Private myconn As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myreader As MySqlDataReader
    Dim myadapter As New MySqlDataAdapter
    Dim SQLString As String
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Users.Show()
        Me.Close()
    End Sub
    Private Sub Check()
        SYEditingCheckBox.Checked = True
        SYViewCheckBox.Checked = True
        MaintainanceYearCheckBox.Checked = True
        MaintainanceTeacherCheckBox.Checked = True
        MaintainanceFeeCheckBox.Checked = True
        MaintainanceWebsiteCheckBox.Checked = True
        RegistrationCheckBox.Checked = True
        AssessmentCheckBox.Checked = True
        PaymentCheckBox.Checked = True
        ReportsCheckBox.Checked = True
        ClassCheckBox.Checked = True
        GradesCheckBox.Checked = True
        ReservedCheckBox.Checked = True
        AccountCheckBox.Checked = True
        MaintainanceBackupCheckBox.Checked = True
    End Sub
    Private Sub ViewUsers()
        UserTypeTextBox.Enabled = True
        UserTypeTextBox.Text = ""
        LimitTextBox.Text = "1"
        CheckAllCheckBox.Checked = True
        UsersListView.Items.Clear()
        Dim cnt As Integer = 0
        SQLString = "Select usertype,userslimit from useraccess"
        myconn.ConnectionString = CONNECTION_STRING
        myconn.Open()
        mycommand.Connection = myconn
        mycommand.CommandText = SQLString
        myreader = mycommand.ExecuteReader
        Do While myreader.Read
            cnt = cnt + 1
            UsersListView.Items.Add("")
            UsersListView.Items(UsersListView.Items.Count - 1).SubItems.Add(cnt.ToString)
            UsersListView.Items(UsersListView.Items.Count - 1).SubItems.Add(myreader("usertype").ToString)
            UsersListView.Items(UsersListView.Items.Count - 1).SubItems.Add(myreader("userslimit").ToString)
        Loop
        myconn.Close()
    End Sub
    Private Sub UserAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewUsers()
    End Sub
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If UserTypeTextBox.Text = "" Then
            MessageBox.Show("Fill the UserType/ Position field first.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf LimitTextBox.Text = "" Then
            MessageBox.Show("Fill the Limit field first.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf SYEditingCheckBox.Checked = False And SYViewCheckBox.Checked = False And MaintainanceYearCheckBox.Checked = False And _
                MaintainanceTeacherCheckBox.Checked = False And MaintainanceFeeCheckBox.Checked = False And MaintainanceWebsiteCheckBox.Checked = False _
                And RegistrationCheckBox.Checked = False And AssessmentCheckBox.Checked = False And PaymentCheckBox.Checked = False And _
                ReportsCheckBox.Checked = False And ClassCheckBox.Checked = False And GradesCheckBox.Checked = False And _
                ReservedCheckBox.Checked = False And AccountCheckBox.Checked = False Then
            MessageBox.Show("No Access Checked.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf CInt(LimitTextBox.Text) < 0 Then
            MessageBox.Show("Limit must be greater that 0.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf IsNumeric(LimitTextBox.Text) Then
            Try
                SQLString = "INSERT INTO useraccess(usertype,schoolyearviewing,schoolyearediting,maintainanceyear,maintainancefees," & _
                "maintainancetr,maintainancewebsite,transactionsregistration,transactionsassessment,transactionspayment,transactionsrecord," & _
                "manageclass,managegrades,managereservedstudent,manageaccount,backuprestore,userslimit) VALUES('" & UserTypeTextBox.Text & "','" & SYViewCheckBox.Checked.ToString & "','" & SYEditingCheckBox.Checked.ToString & "','" & _
                CBool(MaintainanceYearCheckBox.Checked) & "','" & MaintainanceFeeCheckBox.Checked.ToString & "','" & MaintainanceTeacherCheckBox.Checked.ToString & "','" & _
                MaintainanceWebsiteCheckBox.Checked.ToString & "','" & RegistrationCheckBox.Checked.ToString & "','" & AssessmentCheckBox.Checked.ToString & "','" & _
                PaymentCheckBox.Checked.ToString & "','" & ReportsCheckBox.Checked.ToString & "','" & ClassCheckBox.Checked.ToString & "','" & _
                GradesCheckBox.Checked.ToString & "','" & ReservedCheckBox.Checked.ToString & "','" & AccountCheckBox.Checked.ToString & "','" & MaintainanceBackupCheckBox.Checked.ToString & "'," & CInt(LimitTextBox.Text) & ")"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
                SQLString = "Update useraccess SET schoolyearediting='" & SYEditingCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET schoolyearviewing='" & SYViewCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET maintainanceyear='" & MaintainanceYearCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET maintainancefees='" & MaintainanceFeeCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET maintainancetr='" & MaintainanceTeacherCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET maintainancewebsite='" & MaintainanceWebsiteCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET transactionsregistration='" & RegistrationCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET transactionsassessment='" & AssessmentCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET transactionspayment='" & PaymentCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET transactionsrecord='" & ReportsCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET manageclass='" & ClassCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET managegrades='" & GradesCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET managereservedstudent='" & ReservedCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET manageaccount='" & AccountCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET backuprestore='" & MaintainanceBackupCheckBox.Checked.ToString & "' where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                SQLString = "Update useraccess SET userslimit=" & CInt(LimitTextBox.Text) & " where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End Try
            ViewUsers()
        Else
            MessageBox.Show("Limit field must be a number.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CheckAllCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAllCheckBox.CheckedChanged
        If CheckAllCheckBox.Checked = True Then
            Check()
        Else
            SYEditingCheckBox.Checked = False
            SYViewCheckBox.Checked = False
            MaintainanceYearCheckBox.Checked = False
            MaintainanceTeacherCheckBox.Checked = False
            MaintainanceFeeCheckBox.Checked = False
            MaintainanceWebsiteCheckBox.Checked = False
            RegistrationCheckBox.Checked = False
            AssessmentCheckBox.Checked = False
            PaymentCheckBox.Checked = False
            ReportsCheckBox.Checked = False
            ClassCheckBox.Checked = False
            GradesCheckBox.Checked = False
            ReservedCheckBox.Checked = False
            AccountCheckBox.Checked = False
        End If
    End Sub

    Private Sub SYEditingCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYEditingCheckBox.CheckedChanged
        If SYEditingCheckBox.Checked = True Then
            SYViewCheckBox.Checked = True
        End If
    End Sub
    Private Sub SYViewCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYViewCheckBox.CheckedChanged
        If SYEditingCheckBox.Checked = True Then
            SYViewCheckBox.Checked = True
        End If
    End Sub

    Private Sub UsersListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersListView.Click
        For i = 0 To UsersListView.Items.Count - 1
            If UsersListView.Items.Item(i).Selected = True Then
                UserTypeTextBox.Text = UsersListView.SelectedItems(0).SubItems(2).Text
                UserTypeTextBox.Enabled = False
                SQLString = "SELECT * from useraccess where usertype='" & UserTypeTextBox.Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    SYEditingCheckBox.Checked = CBool(myreader("schoolyearediting").ToString)
                    SYViewCheckBox.Checked = CBool(myreader("schoolyearviewing").ToString)
                    MaintainanceYearCheckBox.Checked = CBool(myreader("maintainanceyear").ToString)
                    MaintainanceFeeCheckBox.Checked = CBool(myreader("maintainancefees").ToString)
                    MaintainanceTeacherCheckBox.Checked = CBool(myreader("maintainancetr").ToString)
                    MaintainanceWebsiteCheckBox.Checked = CBool(myreader("maintainancewebsite").ToString)
                    RegistrationCheckBox.Checked = CBool(myreader("transactionsregistration").ToString)
                    AssessmentCheckBox.Checked = CBool(myreader("transactionsassessment").ToString)
                    PaymentCheckBox.Checked = CBool(myreader("transactionspayment").ToString)
                    ReportsCheckBox.Checked = CBool(myreader("transactionsrecord").ToString)
                    ClassCheckBox.Checked = CBool(myreader("manageclass").ToString)
                    GradesCheckBox.Checked = CBool(myreader("managegrades").ToString)
                    ReservedCheckBox.Checked = CBool(myreader("managereservedstudent").ToString)
                    AccountCheckBox.Checked = CBool(myreader("manageaccount").ToString)
                    MaintainanceBackupCheckBox.Checked = CBool(myreader("backuprestore").ToString)
                    LimitTextBox.Text = myreader("userslimit").ToString
                Loop
                myconn.Close()
            End If
        Next
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ViewUsers()
    End Sub

   
    Private Sub DeleteUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserButton.Click
        For i = 0 To UsersListView.Items.Count - 1
            If UsersListView.Items.Item(i).Checked = True Then
                Dim SQlInsert As String = "DELETE FROM useraccess WHERE usertype='" & UsersListView.Items(i).SubItems(2).Text & "'"
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQlInsert
                mycommand.ExecuteNonQuery()
                myconn.Close()
            End If
        Next
    End Sub
End Class
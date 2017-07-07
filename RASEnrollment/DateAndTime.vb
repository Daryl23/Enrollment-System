Public Class DateAndTime


   

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Main.Show()
        Me.Close()
    End Sub

  
    Private Sub SaveSystemDTButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSystemDTButton.Click
        Main.NewDate = CDate(SystemDateDateTimePicker.Text)
        Main.NewTime = CDate(SystemTimeDateTimePicker.Text)
    End Sub

    Private Sub EditSystemDateTimeButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSystemDateTimeButton.Click
        SaveSystemDTButton.Enabled = True
        SystemDateDateTimePicker.Enabled = True
        SystemTimeDateTimePicker.Enabled = True
    End Sub

    Private Sub DisableSystemButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableSystemButton.Click
        SystemTimeDateTimePicker.Text = System.DateTime.Now.ToShortDateString
        SystemDateDateTimePicker.Text = System.DateTime.Now.ToShortTimeString
        SystemDateDateTimePicker.Enabled = True
        SystemTimeDateTimePicker.Enabled = True
        SaveSystemDTButton.Enabled = False
    End Sub
End Class
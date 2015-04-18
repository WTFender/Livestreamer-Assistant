Public Class OtherServices
    Dim timerCounter As Integer
    Dim selectedQuality As String
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub OtherServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServiceComboBox.Sorted = True
        ServiceComboBox.DropDownHeight = ServiceComboBox.Height * 7
    End Sub

    Private Sub StreamButton_Click(sender As Object, e As EventArgs) Handles StreamButton.Click
        StreamSpinner.Visible = True
        Timer1.Enabled = True
        Dim service As String = ServiceComboBox.Text
        Dim channel As String = ChanTextBox.Text.Replace("/", "")
        Dim p As New ProcessStartInfo("cmd", "/c livestreamer " & service & "/" & channel & " " & selectedQuality)
        p.UseShellExecute = False
        p.CreateNoWindow = True
        Process.Start(p)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerCounter = timerCounter + 1
        Dim proc = Process.GetProcessesByName("vlc")
        For i As Integer = 0 To proc.Count - 1
            If proc(i).ProcessName = "vlc" Then
                StreamSpinner.Visible = False
                Timer1.Enabled = False
            End If
        Next
        If timerCounter = 100 Then
            StreamSpinner.Visible = False
            Timer1.Enabled = False

            If selectedQuality = "medium" Then
                MessageBox.Show("This stream does not support ""medium"" quality. Please select low or high quality.", "Unsupported Quality", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("This stream is taking longer than usual to open. Possible issues include unsupported stream quality, the streamer has gone offline, or the application is suffering performance issues.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub HighButton_Click(sender As Object, e As EventArgs) Handles HighButton.Click
        HighButton.BackColor = Color.FromArgb(0, 163, 0)
        MediumButton.BackColor = Color.FromArgb(80, 80, 80)
        LowButton.BackColor = Color.FromArgb(80, 80, 80)
        selectedQuality = "best"
        StreamButton.Visible = True
    End Sub

    Private Sub MediumButton_Click(sender As Object, e As EventArgs) Handles MediumButton.Click
        HighButton.BackColor = Color.FromArgb(80, 80, 80)
        MediumButton.BackColor = Color.FromArgb(227, 162, 26)
        LowButton.BackColor = Color.FromArgb(80, 80, 80)
        selectedQuality = "medium"
        StreamButton.Visible = True
    End Sub

    Private Sub LowButton_Click(sender As Object, e As EventArgs) Handles LowButton.Click
        HighButton.BackColor = Color.FromArgb(80, 80, 80)
        MediumButton.BackColor = Color.FromArgb(80, 80, 80)
        LowButton.BackColor = Color.FromArgb(185, 29, 71)
        selectedQuality = "worst"
        StreamButton.Visible = True
    End Sub

    Private Sub ChanTextBox_Click(sender As Object, e As EventArgs) Handles ChanTextBox.Click
        HighButton.Visible = True
        MediumButton.Visible = True
        LowButton.Visible = True
    End Sub
End Class
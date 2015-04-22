Public Class OtherServices
    Dim timerCounter As Integer
    Dim selectedQuality As String

    'Hide all, back to HomeScreen
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        Me.Close()
    End Sub

    'ComboBox formatting (hardcoded values)
    Private Sub OtherServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServiceComboBox.Sorted = True
        ServiceComboBox.DropDownHeight = ServiceComboBox.Height * 7
    End Sub

    'Sends cmd stream commands and starts timer
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

    'Timer - Throws error after 10s of searching for stream, enables loading icon
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

    #Region "Quality Buttons: Sets quality selection and button colors"
    Private Sub HighTile_Click(sender As Object, e As EventArgs) Handles HighQualityTile.Click
        HighQualityTile.setQuality(MediumQualityTile, LowQualityTile)
        selectedQuality = "high"
        StreamButton.Visible = True
    End Sub

    Private Sub MediumTile_Click(sender As Object, e As EventArgs) Handles MediumQualityTile.Click
        MediumQualityTile.setQuality(HighQualityTile, LowQualityTile)
        selectedQuality = "medium"
        StreamButton.Visible = True
    End Sub

    Private Sub LowTile_Click(sender As Object, e As EventArgs) Handles LowQualityTile.Click
        LowQualityTile.setQuality(HighQualityTile, MediumQualityTile)
        selectedQuality = "low"
        StreamButton.Visible = True
    End Sub
#End Region

    'On click, show quality buttons
    Private Sub ChanTextBox_Click(sender As Object, e As EventArgs) Handles ChanTextBox.Click
        HighQualityTile.Visible = True
        MediumQualityTile.Visible = True
        LowQualityTile.Visible = True
    End Sub
End Class
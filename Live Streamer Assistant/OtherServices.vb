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
        If timerCounter = 50 Then
            StreamSpinner.Visible = False
            Timer1.Enabled = False
            MessageBox.Show("This stream does not support ""medium"" quality. Please select low or high quality. If it still doesn't work then it probably means I'm a shitty developer.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
#Region "Hover Zoom"
    Private Sub BackButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.MouseEnter
        hoverZoom(BackButton)
    End Sub
    Private Sub BackButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.MouseLeave
        hoverZoomOut(BackButton)
    End Sub
    Private Sub StreamButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamButton.MouseEnter
        hoverZoom(StreamButton)
    End Sub
    Private Sub StreamButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamButton.MouseLeave
        hoverZoomOut(StreamButton)
    End Sub

    Private Sub HighButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighButton.MouseEnter
        hoverZoom(HighButton)
    End Sub
    Private Sub HighButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighButton.MouseLeave
        hoverZoomOut(HighButton)
    End Sub

    Private Sub MediumButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumButton.MouseEnter
        hoverZoom(MediumButton)
    End Sub
    Private Sub MediumButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumButton.MouseLeave
        hoverZoomOut(MediumButton)
    End Sub

    Private Sub LowButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowButton.MouseEnter
        hoverZoom(LowButton)
    End Sub
    Private Sub LowButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowButton.MouseLeave
        hoverZoomOut(LowButton)
    End Sub
#End Region
End Class
Option Strict On
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.IO
Imports System.Net
Imports System.Globalization
Imports System.Drawing
Public Class TopGames
    Dim selectedGame As String
    Dim selectedStreamer As String
    Dim selectedQuality As String
    Dim timerCounter As Integer
    Dim streamer0 As String
    Dim streamer1 As String
    Dim streamer2 As String

    Private Sub TopGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStreamerInfo()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        Me.Close()
    End Sub

    Private Sub loadStreamerInfo()
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/streams?game=" & topGame.Replace(" ", "%20"))
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)

        Dim image0 As String = streamlist.Item("streams").Item(0).Item("preview").Item("medium").ToString
        Dim image1 As String = streamlist.Item("streams").Item(1).Item("preview").Item("medium").ToString
        Dim image2 As String = streamlist.Item("streams").Item(2).Item("preview").Item("medium").ToString
        Dim imageClient As WebClient = New WebClient

        MetroTile1.TileImage = Bitmap.FromStream(New MemoryStream(imageClient.DownloadData(image0)))
        MetroTile2.TileImage = Bitmap.FromStream(New MemoryStream(imageClient.DownloadData(image1)))
        MetroTile3.TileImage = Bitmap.FromStream(New MemoryStream(imageClient.DownloadData(image2)))
        MetroTile1.BackgroundImageLayout = ImageLayout.Stretch
        MetroTile2.BackgroundImageLayout = ImageLayout.Stretch
        MetroTile3.BackgroundImageLayout = ImageLayout.Stretch

        streamer0 = streamlist.Item("streams").Item(0).Item("channel").Item("display_name").ToString
        streamer1 = streamlist.Item("streams").Item(1).Item("channel").Item("display_name").ToString
        streamer2 = streamlist.Item("streams").Item(2).Item("channel").Item("display_name").ToString
        Dim viewers0 As String = streamlist.Item("streams").Item(0).Item("viewers").ToString
        Dim viewers1 As String = streamlist.Item("streams").Item(1).Item("viewers").ToString
        Dim viewers2 As String = streamlist.Item("streams").Item(2).Item("viewers").ToString
        Dim title0 As String = streamlist.Item("streams").Item(0).Item("channel").Item("status").ToString
        Dim title1 As String = streamlist.Item("streams").Item(1).Item("channel").Item("status").ToString
        Dim title2 As String = streamlist.Item("streams").Item(2).Item("channel").Item("status").ToString

        MetroTile1.Text = streamer0 & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", Decimal.Parse(viewers0)) & " Viewers" & Environment.NewLine & title0
        MetroTile2.Text = streamer1 & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", Decimal.Parse(viewers1)) & " Viewers" & Environment.NewLine & title1
        MetroTile3.Text = streamer2 & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", Decimal.Parse(viewers2)) & " Viewers" & Environment.NewLine & title2
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

    Private Sub StreamButton_Click(sender As Object, e As EventArgs) Handles StreamButton.Click
        StreamSpinner.Visible = True
        Timer2.Enabled = True
        Dim p As New ProcessStartInfo("cmd", "/c livestreamer twitch.tv/" & selectedStreamer.ToLower & " " & selectedQuality)
        p.UseShellExecute = False
        p.CreateNoWindow = True
        Process.Start(p)
    End Sub

    Private Sub showQualityButtons()
        LowButton.Visible = True
        MediumButton.Visible = True
        HighButton.Visible = True
    End Sub

    Private Sub TopGameButton0_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        MetroTile1.UseTileImage = False
        MetroTile2.UseTileImage = True
        MetroTile3.UseTileImage = True
        MetroTile1.BackColor = Color.FromArgb(27, 161, 226)
        MetroTile2.BackColor = Color.FromArgb(80, 80, 80)
        MetroTile3.BackColor = Color.FromArgb(80, 80, 80)
        showQualityButtons()
        selectedStreamer = streamer0.ToString
    End Sub

    Private Sub TopGameButton1_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        MetroTile1.UseTileImage = True
        MetroTile2.UseTileImage = False
        MetroTile3.UseTileImage = True
        MetroTile1.BackColor = Color.FromArgb(80, 80, 80)
        MetroTile2.BackColor = Color.FromArgb(27, 161, 226)
        MetroTile3.BackColor = Color.FromArgb(80, 80, 80)
        showQualityButtons()
        selectedStreamer = streamer1.ToString
    End Sub

    Private Sub TopGameButton2_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        MetroTile1.UseTileImage = True
        MetroTile2.UseTileImage = True
        MetroTile3.UseTileImage = False
        MetroTile1.BackColor = Color.FromArgb(80, 80, 80)
        MetroTile2.BackColor = Color.FromArgb(80, 80, 80)
        MetroTile3.BackColor = Color.FromArgb(27, 161, 226)
        showQualityButtons()
        selectedStreamer = streamer2.ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        timerCounter = timerCounter + 1
        Dim proc = Process.GetProcessesByName("vlc")
        For i As Integer = 0 To proc.Count - 1
            If proc(i).ProcessName = "vlc" Then
                StreamSpinner.Visible = False
                Timer2.Enabled = False
            End If
        Next
        If timerCounter = 50 Then
            StreamSpinner.Visible = False
            Timer2.Enabled = False
            MessageBox.Show("This stream does not support ""medium"" quality. Please select low or high quality. If it still doesn't work then it probably means I'm a shitty developer.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#Region "Button Zoom"
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

    Private Sub MetroTile2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.MouseEnter
        hoverZoom(MetroTile2)
    End Sub
    Private Sub MetroTile2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.MouseLeave
        hoverZoomOut(MetroTile2)
    End Sub
    Private Sub MetroTile1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.MouseEnter
        hoverZoom(MetroTile1)
    End Sub
    Private Sub MetroTile1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.MouseLeave
        hoverZoomOut(MetroTile1)
    End Sub
    Private Sub MetroTile3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile3.MouseEnter
        hoverZoom(MetroTile3)
    End Sub
    Private Sub MetroTile3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile3.MouseLeave
        hoverZoomOut(MetroTile3)
    End Sub
#End Region

End Class
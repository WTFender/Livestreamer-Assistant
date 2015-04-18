Option Strict On
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.IO
Imports System.Net
Imports System.Globalization
Imports System.Drawing

Public Class BrowseScreen
    Dim selectedGame As String
    Dim selectedStreamer As Integer
    Dim selectedQuality As String
    Dim timerCounter As Integer

    Private Sub BrowseScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGameComboBox()
        GameComboBox.Visible = True
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        Me.Close()
        LowButton.Visible = False
        MediumButton.Visible = False
        HighButton.Visible = False
        StreamButton.Visible = False
        PreviewPictureBox.Visible = False
        StreamerComboBox.Visible = False
        GameComboBox.Visible = False
        StreamSpinner.Visible = False
    End Sub

    Private Sub loadGameComboBox()
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=100&offset=")
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        For x As Integer = 0 To streamlist.Item("top").Count - 1
            GameComboBox.BeginUpdate()
            GameComboBox.Items.Add(streamlist.Item("top").Item(x).Item("game").Item("name").ToString.Replace("Ã©", "é").Replace("刀", "").Replace("塔", "").Replace("傳", "").Replace("奇", ""))
            GameComboBox.EndUpdate()
            GameComboBox.Update()
            GameComboBox.Sorted = True
            GameComboBox.DropDownHeight = GameComboBox.Height * 7
        Next
    End Sub

    Private Sub loadStreamerComboBox()
        StreamerComboBox.Visible = True
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/streams?game=" & selectedGame)
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        For x As Integer = 0 To streamlist.Item("streams").Count - 1
            StreamerComboBox.BeginUpdate()
            StreamerComboBox.Items.Add(streamlist.Item("streams").Item(x).Item("channel").Item("display_name").ToString)
            StreamerComboBox.EndUpdate()
            StreamerComboBox.Update()
            StreamerComboBox.DropDownHeight = StreamerComboBox.Height * 7
        Next
    End Sub

    Private Sub loadStreamerInfo(ByVal selectedStreamer As Integer)
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/streams?game=" & selectedGame)
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        Dim image As String
        image = streamlist.Item("streams").Item(selectedStreamer).Item("preview").Item("medium").ToString
        Dim imageClient As WebClient = New WebClient
        PreviewPictureBox.Image = Bitmap.FromStream(New MemoryStream(imageClient.DownloadData(image)))
        PreviewPictureBox.BackgroundImageLayout = ImageLayout.Stretch
        PreviewPictureBox.Visible = True
        Dim viewers As String = streamlist.Item("streams").Item(selectedStreamer).Item("viewers").ToString
        FavoritesButton.Visible = True
        LowButton.Visible = True
        MediumButton.Visible = True
        HighButton.Visible = True
        searchFavorites()
    End Sub

    Private Sub GameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GameComboBox.SelectedIndexChanged
        StreamerComboBox.Items.Clear()
        selectedGame = GameComboBox.Text.Replace(" ", "%20")
        loadStreamerComboBox()
        PreviewPictureBox.Visible = False
        FavoritesButton.Visible = False
        LowButton.Visible = False
        MediumButton.Visible = False
        HighButton.Visible = False

    End Sub

    Private Sub StreamerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StreamerComboBox.SelectedIndexChanged
        selectedStreamer = StreamerComboBox.SelectedIndex
        loadStreamerInfo(selectedStreamer)
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

    Private Sub StreamButton_Click_1(sender As Object, e As EventArgs) Handles StreamButton.Click
        StreamSpinner.Visible = True
        Timer1.Enabled = True
        Dim channel As String = StreamerComboBox.Text
        Dim p As New ProcessStartInfo("cmd", "/c livestreamer twitch.tv/" & channel.ToLower & " " & selectedQuality)
        p.UseShellExecute = False
        p.CreateNoWindow = True
        Process.Start(p)
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

    Private Function searchFavorites() As Integer
        Dim search As String = StreamerComboBox.Text
        Dim text As String = File.ReadAllText(favePath)
        Dim index As Integer = text.IndexOf(search)
        If index >= 1 Then
            FavoritesButton.Text = "Favorite" & Environment.NewLine & "Saved"
            FavoritesButton.BackColor = Color.FromArgb(150, 150, 150)
            Return 1
        Else
            FavoritesButton.BackColor = Color.FromArgb(27, 161, 226)
            FavoritesButton.Text = "Add to" & Environment.NewLine & "Favorites"
            Return 0
        End If
    End Function

    Private Sub FavoritesButton_Click(sender As Object, e As EventArgs) Handles FavoritesButton.Click
        If searchFavorites() = 1 Then
            MessageBox.Show("Channel already added to favorites.", "Channel Saved", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf searchFavorites() = 0 Then
            Dim faveWriter As New StreamWriter(favePath, True)
            faveWriter.WriteLine(StreamerComboBox.Text)
            faveWriter.Close()
            FavoritesButton.Text = "Favorite" & Environment.NewLine & "Saved"
            FavoritesButton.BackColor = Color.FromArgb(150, 150, 150)
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

    Private Sub FavoritesButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesButton.MouseEnter
        hoverZoom(FavoritesButton)
    End Sub
    Private Sub FavoritesButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesButton.MouseLeave
        hoverZoomOut(FavoritesButton)
    End Sub
#End Region
End Class
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

    'On load, show populate and show GameComboBox
    Private Sub BrowseScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGameComboBox()
        GameComboBox.Visible = True
    End Sub

    'Hide all, back to HomeScreen
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        hideControls()
        Me.Close()
        
    End Sub

#Region "Show/Hide commands for form controls"
    Private Sub hideControls()
        LowQualityTile.Visible = False
        MediumQualityTile.Visible = False
        HighQualityTile.Visible = False
        StreamButton.Visible = False
        PreviewPictureBox.Visible = False
        StreamerComboBox.Visible = False
        GameComboBox.Visible = False
        StreamSpinner.Visible = False
    End Sub

    Private Sub showQualityButtons()
        FavoritesButton.Visible = True
        LowQualityTile.Visible = True
        MediumQualityTile.Visible = True
        HighQualityTile.Visible = True
    End Sub

    Private Sub hideAllButtons()
        StreamButton.Visible = False
        PreviewPictureBox.Visible = False
        FavoritesButton.Visible = False
        LowQualityTile.Visible = False
        LowQualityTile.setInactive()
        MediumQualityTile.Visible = False
        MediumQualityTile.setInactive()
        HighQualityTile.Visible = False
        HighQualityTile.setInactive()
    End Sub
#End Region

    'Populates GameComboBox
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

    'Populates StreamerComboBox
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

    'Shows stream snapshot/picture
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
        showQualityButtons()
        searchFavorites()
    End Sub

    'Selects game and populates StreamerComboBox
    Private Sub GameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GameComboBox.SelectedIndexChanged
        StreamerComboBox.Items.Clear()
        'Formatting for web browser
        selectedGame = GameComboBox.Text.Replace(" ", "%20")
        loadStreamerComboBox()
        hideAllButtons()
    End Sub

    'Load Streamer ComboBox and set selection
    Private Sub StreamerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StreamerComboBox.SelectedIndexChanged
        selectedStreamer = StreamerComboBox.SelectedIndex
        loadStreamerInfo(selectedStreamer)
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

    'Sends cmd stream commands and starts timer
    Private Sub StreamButton_Click_1(sender As Object, e As EventArgs) Handles StreamButton.Click
        StreamSpinner.Visible = True
        Timer1.Enabled = True
        Dim channel As String = StreamerComboBox.Text
        Dim p As New ProcessStartInfo("cmd", "/c livestreamer twitch.tv/" & channel.ToLower & " " & selectedQuality)
        p.UseShellExecute = False
        p.CreateNoWindow = True
        Process.Start(p)
    End Sub

    'Searches favorites and formats "Add Favorites" button
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

    'Adds selection to favorites file
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

    'Refresh Games and Streamers comboboxes
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        hideAllButtons()
        StreamerComboBox.Visible = False
        GameComboBox.Items.Clear()
        loadGameComboBox()
    End Sub
End Class
Option Strict On
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.IO
Imports System.Net
Imports System.Globalization

Public Class Favorites
    Dim selectedStreamer As String
    Dim selectedQuality As String
    Dim timerCounter As Integer

    'On form load, load favorites ComboBox
    Private Sub Favorites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFavorites()
    End Sub

    'Hide all, back to HomeScreen
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomeScreen.StartPosition = FormStartPosition.Manual
        HomeScreen.Location = Me.Location
        HomeScreen.Show()
        hideAllButtons()
        Me.Close()
    End Sub

    'Populate favorites ComboBox
    Private Sub loadFavorites()
        FaveComboBox.Items.Clear()
        Dim faveReader As New StreamReader(favePath)
        For Each line As String In File.ReadAllLines(favePath)
            If line <> String.Empty Then FaveComboBox.Items.Add(line)
        Next
        faveReader.Close()
        FaveComboBox.Sorted = True
    End Sub

    'Streamer selection, display online status
    Private Sub FaveComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FaveComboBox.SelectedIndexChanged
        selectedStreamer = FaveComboBox.Text
        onlineStatus()
    End Sub

    'Determine and display onlinestatus
    Private Sub onlineStatus()
        Try
            Dim getlivegamesClient As New System.Net.WebClient
            Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/streams/" & selectedStreamer.ToLower)
            Dim streamlist As New JObject
            streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
            Dim status As String = streamlist.Item("stream").ToString
            If status = "" Then
                StatusButton.BackColor = Color.FromArgb(229, 20, 0)
                StatusButton.Text = selectedStreamer & Environment.NewLine & "Offline"
                StreamInfoPanel.Visible = False
                hideQualityButtons()
            Else
                StatusButton.BackColor = Color.FromArgb(51, 153, 51)
                StatusButton.Text = selectedStreamer & Environment.NewLine & "Online"
                Dim title As String = streamlist.Item("stream").Item("channel").Item("status").ToString
                Dim viewers As String = streamlist.Item("stream").Item("viewers").ToString
                Dim game As String = streamlist.Item("stream").Item("game").ToString
                StreamInfoPanel.Text = title.ToString & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", Decimal.Parse(viewers)) & " Viewers" & Environment.NewLine & "Playing " & game.ToString
                StreamInfoPanel.TileImage = setInfoImage(game)
                StreamInfoPanel.Visible = True
                showQualityButtons()
            End If
            StatusButton.Visible = True
        Catch
            MessageBox.Show("Check that the channel entered actually exists.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#Region "Show/Hide Buttons/Controls"
    Private Sub hideQualityButtons()
        LowQualityTile.Visible = False
        MediumQualityTile.Visible = False
        HighQualityTile.Visible = False
    End Sub

    Private Sub showQualityButtons()
        LowQualityTile.Visible = True
        MediumQualityTile.Visible = True
        HighQualityTile.Visible = True
    End Sub

    Private Sub hideAllButtons()
        StreamButton.Visible = False
        StatusButton.Visible = False
        LowQualityTile.Visible = False
        LowQualityTile.setInactive()
        MediumQualityTile.Visible = False
        MediumQualityTile.setInactive()
        HighQualityTile.Visible = False
        HighQualityTile.setInactive()
    End Sub
#End Region

    'Sets game image
    Private Function setInfoImage(ByVal game As String) As Bitmap
        Select Case game.ToLower
            Case "league of legends"
                Return My.Resources.lol
            Case "hearthstone: heroes of warcraft"
                Return My.Resources.hs
            Case "grand theft auto v"
                Return My.Resources.gta5
            Case "mortal kombat x"
                Return My.Resources.mc
            Case "dota 2"
                Return My.Resources.dota2
            Case "counter-strike: global offensive"
                Return My.Resources.csgo
            Case "diablo iii: reaper of souls"
                Return My.Resources.d3
            Case "h1z1"
                Return My.Resources.h1z1
            Case "minecraft"
                Return My.Resources.mc
            Case "starcraft ii: heart of the swarm"
                Return My.Resources.sc2
            Case Else
                Return Nothing
        End Select
    End Function

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

    'Sends cmd stream commands and starts timer
    Private Sub StreamButton_Click_1(sender As Object, e As EventArgs) Handles StreamButton.Click
        StreamSpinner.Visible = True
        Timer1.Enabled = True
        Dim channel As String = FaveComboBox.Text
        Dim p As New ProcessStartInfo("cmd", "/c livestreamer twitch.tv/" & channel.ToLower & " " & selectedQuality)
        p.UseShellExecute = False
        p.CreateNoWindow = True
        Process.Start(p)
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

    'Open text file for editing
    Private Sub ManageFavoritesButton_Click(sender As Object, e As EventArgs) Handles ManageFavoritesButton.Click
        hideAllButtons()
        MessageBox.Show("Favorites are saved in a simple text file." & Environment.NewLine & "Add/Remove favorites and save the file." & Environment.NewLine & "Refresh Favorites after changing", "Manage Favorites", MessageBoxButtons.OK, MessageBoxIcon.Information)
        System.Diagnostics.Process.Start("Notepad.exe", favePath)
    End Sub

    'Refresh ComboBox with file 
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        hideAllButtons()
        loadFavorites()
    End Sub
End Class
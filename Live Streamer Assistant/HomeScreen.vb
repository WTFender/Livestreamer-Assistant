Option Strict On
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Globalization
Imports System.Drawing.Imaging
Imports MetroFramework.Controls.MetroTile

Public Class HomeScreen
    Dim search As String

    'Reads splash screen pref, loads top games
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(favePath) Then
            Dim faveWriter As StreamWriter = New StreamWriter(favePath, True)
            faveWriter.Close()
        End If
        If Not File.Exists(prefPath) Then
            Dim prefWriter As StreamWriter = New StreamWriter(prefPath, True)
            prefWriter.Close()
        End If
        If getStartPref() = 0 Then
            Me.Opacity = 0
            Splash.Show()
        End If
        MetroTile1.BackgroundImageLayout = ImageLayout.Stretch
        setTopGame(0, MetroTile1)
        setTopGame(1, MetroTile2)
        setTopGame(2, MetroTile3)

    End Sub

    'Reads splash screen pref
    Private Function getStartPref() As Integer
        Dim pref As String
        Dim prefReader As New StreamReader(prefPath)
        pref = prefReader.ReadLine()
        If pref = "" Then
            prefReader.Close()
            FileClose()
            Return 0
        Else
            prefReader.Close()
            FileClose()
            Return 1
        End If
    End Function

    'Sets top games names
    Private Function getGameName(ByVal x As Integer) As String
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        Dim gameName As String
        gameName = streamlist.Item("top").Item(x).Item("game").Item("name").ToString.Replace("Ã©", "é")
        Return gameName
    End Function

    'Sets top games viewer count
    Private Function getViewerCount(ByVal x As Integer) As Integer
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        Dim viewers As Integer
        viewers = Integer.Parse(CStr(streamlist.Item("top").Item(x).Item("viewers")))
        Return viewers
    End Function

    'Sets top games image
    Private Function getGamePicture(ByVal x As Integer) As Bitmap
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = CType(JsonConvert.DeserializeObject(result), JObject)
        Dim gameName As String
        gameName = streamlist.Item("top").Item(x).Item("game").Item("name").ToString
        Select Case gameName.ToLower
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

    'Sets top games
    Private Sub setTopGame(ByVal x As Integer, ByVal y As MetroFramework.Controls.MetroTile)

        y.Text = getGameName(x) & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", getViewerCount(x)) & " Viewers"

        Dim z As Bitmap = getGamePicture(x)
        y.TileImage = z
    End Sub

#Region "Screen Navigation"

    'Twitch Directory / Browse All
    Private Sub BrowseAllButton_Click(sender As Object, e As EventArgs) Handles BrowseAllButton.Click
        BrowseScreen.StartPosition = FormStartPosition.Manual
        BrowseScreen.Location = Me.Location
        BrowseScreen.Show()
        Me.Hide()
    End Sub

    'TopGame1
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        topGame = getGameName(0).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    'TopGame2
    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        topGame = getGameName(1).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    'TopGame3
    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        topGame = getGameName(2).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    'Favorites
    Private Sub FavoritesButton_Click(sender As Object, e As EventArgs) Handles FavoritesButton.Click
        Favorites.StartPosition = FormStartPosition.Manual
        Favorites.Location = Me.Location
        Favorites.Show()
        Me.Hide()
    End Sub

    'Other Services
    Private Sub OtherButton_Click(sender As Object, e As EventArgs) Handles OtherButton.Click
        OtherServices.StartPosition = FormStartPosition.Manual
        OtherServices.Location = Me.Location
        OtherServices.Show()
        Me.Hide()
    End Sub
#End Region
End Class
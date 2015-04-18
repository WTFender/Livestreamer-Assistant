Option Explicit On
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Globalization
Imports System.Drawing.Imaging

Public Class HomeScreen
    Dim search As String

#Region "Button Zoom"
    Private Sub BrowseAllButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseAllButton.MouseEnter
        hoverZoom(BrowseAllButton)
    End Sub
    Private Sub BrowseAllButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseAllButton.MouseLeave
        hoverZoomOut(BrowseAllButton)
    End Sub
    Private Sub FavoritesButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesButton.MouseEnter
        hoverZoom(FavoritesButton)
    End Sub
    Private Sub FavoritesButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavoritesButton.MouseLeave
        hoverZoomOut(FavoritesButton)
    End Sub
    Private Sub OtherButton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherButton.MouseEnter
        hoverZoom(OtherButton)
    End Sub
    Private Sub OtherButton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherButton.MouseLeave
        hoverZoomOut(OtherButton)
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

        Return pref
    End Function

    Private Function getGameName(ByVal x) As String
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = JsonConvert.DeserializeObject(result)
        Dim gameName As String
        gameName = streamlist.Item("top").Item(x).Item("game").Item("name").ToString.Replace("Ã©", "é")
        Return gameName
    End Function

    Private Function getViewerCount(ByVal x) As Integer
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = JsonConvert.DeserializeObject(result)
        Dim viewers As String
        viewers = Integer.Parse(streamlist.Item("top").Item(x).Item("viewers"))
        Return viewers
    End Function

    Private Function getGamePicture(ByVal x) As Bitmap
        Dim getlivegamesClient As New System.Net.WebClient
        Dim result As String = getlivegamesClient.DownloadString("https://api.twitch.tv/kraken/games/top?limit=10&offset=")
        Dim streamlist As New JObject
        streamlist = JsonConvert.DeserializeObject(result)
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

    Private Sub setTopGame(ByVal x, ByVal y)

        y.Text = getGameName(x) & Environment.NewLine & String.Format(CultureInfo.InvariantCulture, "{0:0,0.}", getViewerCount(x)) & " Viewers"

        x = getGamePicture(x)
        y.TileImage = x
    End Sub

    Private Sub BrowseAllButton_Click(sender As Object, e As EventArgs) Handles BrowseAllButton.Click
        BrowseScreen.StartPosition = FormStartPosition.Manual
        BrowseScreen.Location = Me.Location
        BrowseScreen.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        topGame = getGameName(0).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        topGame = getGameName(1).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        topGame = getGameName(2).ToLower
        TopGames.StartPosition = FormStartPosition.Manual
        TopGames.Location = Me.Location
        TopGames.Show()
        Me.Hide()
    End Sub

    Private Sub FavoritesButton_Click(sender As Object, e As EventArgs) Handles FavoritesButton.Click
        Favorites.StartPosition = FormStartPosition.Manual
        Favorites.Location = Me.Location
        Favorites.Show()
        Me.Hide()
    End Sub

    Private Sub OtherButton_Click(sender As Object, e As EventArgs) Handles OtherButton.Click
        OtherServices.StartPosition = FormStartPosition.Manual
        OtherServices.Location = Me.Location
        OtherServices.Show()
        Me.Hide()
    End Sub
End Class
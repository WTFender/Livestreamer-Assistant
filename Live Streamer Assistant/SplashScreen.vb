Option Strict On
Imports System.IO
Imports System.Environment
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Splash
    Dim lsVersion As String
    Dim lsConfig As String()
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim fullConfigPath As String = appData & "\livestreamer\livestreamerrc"
    Dim fullVersionPath As String = appData & "\livestreamer\cli.json"

    'On load, Check LS Version
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Set splash pref, display HomeScreen
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If MetroCheckBox1.Checked Then
            setStartInfoPref(1)
        Else
            setStartInfoPref(0)
        End If
        Me.Hide()
        HomeScreen.Opacity = 100
    End Sub

    'Save splash screen pref
    Private Sub setStartInfoPref(ByVal pref As Integer)
        'Check for start info preference from stream file
        Dim prefWriter As New StreamWriter(prefPath, False)
        prefWriter.WriteLine(pref.ToString)
        prefWriter.Close()
    End Sub


    'Exit button closes app
    Private Sub SplashScreen_OnClose(sender As Object, e As EventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    'Search livestreamerrc file and compare with vlc directory
    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        OpenFileDialog1.InitialDirectory = "C:\Program Files (x86)\VideoLAN\VLC"
        OpenFileDialog1.FileName = "vlc.exe"
        lsConfig = File.ReadAllLines(fullConfigPath)
        OpenFileDialog1.ShowDialog()
        Dim vlcPath = "player=" & Chr(34) & OpenFileDialog1.FileName & Chr(34)
        Dim vlcSearch As Boolean = False
        For count = 0 To lsConfig.GetUpperBound(0)
            If lsConfig(count).Contains(vlcPath) Then
                vlcSearch = True
                VerifyButton.Text = "VLC Path Found!"
                VerifyButton.Enabled = False
                VerifyButton.UseCustomBackColor = True
                VerifyButton.BackColor = Color.FromArgb(51, 153, 51)
                OKButton.Visible = True
                MetroCheckBox1.Visible = True
            End If
        Next
        If vlcSearch = False Then
            VerifyButton.Text = "VLC Path Not Found!"
            VerifyButton.UseCustomBackColor = True
            VerifyButton.BackColor = Color.Firebrick
            MessageBox.Show("Unable to find the selected VLC.exe path in your livestreamer configuration file. Update your VLC path in your LS config file.", "Directory Problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateButton.Visible = True
            OKButton.Visible = True
            MetroCheckBox1.Visible = True
        End If
    End Sub

    'Open livestreamerrc config file to let use manually add vlc.exe path
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        MessageBox.Show("Update your vlc.exe path and Verify again." & Environment.NewLine & "Example: (no # sign)" & Environment.NewLine & "player=" & Chr(34) & "C:\Program Files (x86)\VideoLAN\VLC\vlc.exe" & Chr(34), "Update Config", MessageBoxButtons.OK, MessageBoxIcon.Information)
        System.Diagnostics.Process.Start("Notepad.exe", fullConfigPath)
        VerifyButton.Enabled = True
        VerifyButton.BackColor = Color.FromArgb(27, 161, 226)
        VerifyButton.Text = "Verify VLC Path"
        UpdateButton.Visible = False
        OKButton.Visible = True
        MetroCheckBox1.Visible = True
    End Sub

    'LS Download Link
    Private Sub VersionButton_Click(sender As Object, e As EventArgs) Handles VersionButton.Click
        System.Diagnostics.Process.Start("https://github.com/chrippa/livestreamer/releases/download/v1.12.1/livestreamer-v1.12.1-win32-setup.exe")
        VersionButton.UseCustomBackColor = True
        VersionButton.BackColor = Color.FromArgb(51, 153, 51)
        VerifyButton.Visible = True
        VerifyButton.Enabled = True
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Hide()
    End Sub
End Class
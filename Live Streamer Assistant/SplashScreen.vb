Option Strict On
Imports System.IO
Imports Microsoft.Win32


Public Class Splash
    Dim lsVersion As String
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroCheckBox1.Checked Then
            setStartInfoPref(1)
        Else
            setStartInfoPref(0)
        End If
        Me.Close()
        HomeScreen.Opacity = 100
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink.Click
        System.Diagnostics.Process.Start("http://docs.livestreamer.io/")
    End Sub

    Private Sub setStartInfoPref(ByVal pref As Integer)
        'Check for start info preference from stream file
        Dim prefWriter As New StreamWriter(prefPath, False)
        prefWriter.WriteLine(pref.ToString)
        prefWriter.Close()
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkVersion()
    End Sub

    Private Sub checkVersion()
        Dim p As New Process
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        p.StandardInput.WriteLine("livestreamer --version-check")
        p.StandardInput.WriteLine("exit")
        Dim lsVersion As String = p.StandardOutput.ReadToEnd
        p.WaitForExit()
        If lsVersion.Contains("1.12.1") Then
            MetroLink.Text = "Livestreamer Version 1.12.1" & Environment.NewLine & "No Update Required"
        End If
    End Sub

End Class
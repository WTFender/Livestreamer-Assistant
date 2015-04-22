Option Strict On
Imports Livestreamer_Assistant
Public Class TestForm
    Dim quality As String
    Private Sub HighTile_Click(sender As Object, e As EventArgs) Handles HighQualityTile.Click
        HighQualityTile.setQuality(MediumQualityTile, LowQualityTile)
        Label1.Text = quality
    End Sub

    Private Sub MediumTile_Click(sender As Object, e As EventArgs) Handles MediumQualityTile.Click
        MediumQualityTile.setQuality(HighQualityTile, LowQualityTile)
        Label1.Text = quality
    End Sub

    Private Sub LowTile_Click(sender As Object, e As EventArgs) Handles LowQualityTile.Click
        LowQualityTile.setQuality(HighQualityTile, MediumQualityTile)
        Label1.Text = quality
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
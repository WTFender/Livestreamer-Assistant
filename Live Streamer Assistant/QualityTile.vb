Imports Livestreamer_Assistant.AnimTile
Public Class QualityTile
    Inherits Livestreamer_Assistant.AnimTile

    ''' <summary>
    ''' Sets button formatting and quality string.
    ''' </summary>
    ''' <param name="tile1"></param>
    ''' <param name="tile2"></param>
    ''' <remarks></remarks>
    Friend Sub setQuality(tile1 As QualityTile, tile2 As QualityTile)
        tile1.setInactive()
        tile2.setInactive()
        Me.setActive(Me.Text)
    End Sub
    Friend Sub setActive(tile As String)
        Me.UseCustomBackColor = True
        Select Case tile.ToLower
            Case "high"
                BackColor = Color.FromArgb(51, 153, 51)
            Case "medium"
                Me.BackColor = Color.FromArgb(227, 162, 26)
            Case "low"
                Me.BackColor = Color.Firebrick
        End Select
    End Sub

    Friend Sub setInactive()
        Me.UseCustomBackColor = True
        Me.BackColor = Color.FromArgb(80, 80, 80)
    End Sub
End Class

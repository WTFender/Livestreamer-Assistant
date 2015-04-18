Imports MetroFramework.Controls.MetroTile
Public Class AnimTile
    Inherits MetroFramework.Controls.MetroTile

    Private Sub AnimTile_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        hoverZoom(Me)
    End Sub

    Private Sub BAnimTile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        hoverZoomOut(Me)
    End Sub

End Class

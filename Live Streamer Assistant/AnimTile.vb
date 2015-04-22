Imports MetroFramework.Controls.MetroTile
Public Class AnimTile
    Inherits MetroFramework.Controls.MetroTile

    Friend Sub AnimTile_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        hoverZoom(Me)
    End Sub

    Friend Sub BAnimTile_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        hoverZoomOut(Me)
    End Sub

    Private Sub hoverZoom(ByVal item As AnimTile)
        item.Location = New Point((item.Location.X - 2), (item.Location.Y - 2))
        item.Width = item.Width + 4
        item.Height = item.Height + 4
    End Sub
    Private Sub hoverZoomOut(ByVal item As AnimTile)
        item.Location = New Point((item.Location.X + 2), (item.Location.Y + 2))
        item.Width = item.Width - 4
        item.Height = item.Height - 4
    End Sub

End Class

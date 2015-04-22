Public Class AnimPictureBox
    Inherits Windows.Forms.PictureBox

    Private Sub AnimPictureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        hoverZoomPicture(Me)
    End Sub

    Private Sub BAnimPictureBox_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        hoverZoomOutPicture(Me)
    End Sub

    Private Sub hoverZoomPicture(ByVal item As AnimPictureBox)
        item.Location = New Point((item.Location.X - 2), (item.Location.Y - 2))
        item.Width = item.Width + 4
        item.Height = item.Height + 4
    End Sub
    Private Sub hoverZoomOutPicture(ByVal item As AnimPictureBox)
        item.Location = New Point((item.Location.X + 2), (item.Location.Y + 2))
        item.Width = item.Width - 4
        item.Height = item.Height - 4
    End Sub
End Class

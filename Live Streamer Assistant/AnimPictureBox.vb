Public Class AnimPictureBox
    Inherits Windows.Forms.PictureBox

    Private Sub AnimPictureBox_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        hoverZoom(Me)
    End Sub

    Private Sub BAnimPictureBox_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        hoverZoomOut(Me)
    End Sub
End Class

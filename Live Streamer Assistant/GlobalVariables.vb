
Module GlobalVariables
    Public prefPath As String = "C:\Users\Public\Documents\pref.txt"
    Public favePath As String = "C:\Users\Public\Documents\channels.txt"
    Public topGame As String

    Public Sub hoverZoom(ByVal item As Object)
        item.Location = New Point((item.Location.X - 2), (item.Location.Y - 2))
        item.Width = item.Width + 4
        item.Height = item.Height + 4
    End Sub
    Public Sub hoverZoomOut(ByVal item As Object)
        item.Location = New Point((item.Location.X + 2), (item.Location.Y + 2))
        item.Width = item.Width - 4
        item.Height = item.Height - 4
    End Sub
End Module

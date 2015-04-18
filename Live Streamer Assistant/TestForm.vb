Public Class TestForm

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Tile1 As New AnimTile With {.Name = "Tile1", .Text = "test button", .Location = New Point(20, 50), .Size = New Size(200, 50)}
        Me.Controls.Add(Tile1)
    End Sub
End Class
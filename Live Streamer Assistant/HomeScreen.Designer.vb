<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.BrowseAllButton = New MetroFramework.Controls.MetroTile()
        Me.FavoritesButton = New MetroFramework.Controls.MetroTile()
        Me.OtherButton = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile1.Location = New System.Drawing.Point(23, 188)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile1.TabIndex = 9
        Me.MetroTile1.Text = "TopGameButton1"
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile2.Location = New System.Drawing.Point(23, 254)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile2.TabIndex = 13
        Me.MetroTile2.Text = "TopGameButton2"
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile3.Location = New System.Drawing.Point(23, 320)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile3.TabIndex = 14
        Me.MetroTile3.Text = "TopGameButton3"
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'BrowseAllButton
        '
        Me.BrowseAllButton.ActiveControl = Nothing
        Me.BrowseAllButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BrowseAllButton.Location = New System.Drawing.Point(23, 76)
        Me.BrowseAllButton.Name = "BrowseAllButton"
        Me.BrowseAllButton.Size = New System.Drawing.Size(98, 106)
        Me.BrowseAllButton.TabIndex = 16
        Me.BrowseAllButton.Text = "Twitch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Directory"
        Me.BrowseAllButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BrowseAllButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.BrowseAllButton.UseCustomBackColor = True
        Me.BrowseAllButton.UseSelectable = True
        Me.BrowseAllButton.UseTileImage = True
        '
        'FavoritesButton
        '
        Me.FavoritesButton.ActiveControl = Nothing
        Me.FavoritesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.FavoritesButton.Location = New System.Drawing.Point(127, 76)
        Me.FavoritesButton.Name = "FavoritesButton"
        Me.FavoritesButton.Size = New System.Drawing.Size(98, 106)
        Me.FavoritesButton.TabIndex = 21
        Me.FavoritesButton.Text = "Browse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favorites"
        Me.FavoritesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FavoritesButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.FavoritesButton.UseCustomBackColor = True
        Me.FavoritesButton.UseSelectable = True
        Me.FavoritesButton.UseTileImage = True
        '
        'OtherButton
        '
        Me.OtherButton.ActiveControl = Nothing
        Me.OtherButton.BackColor = System.Drawing.Color.Firebrick
        Me.OtherButton.Location = New System.Drawing.Point(231, 76)
        Me.OtherButton.Name = "OtherButton"
        Me.OtherButton.Size = New System.Drawing.Size(98, 106)
        Me.OtherButton.TabIndex = 22
        Me.OtherButton.Text = "Other" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Services"
        Me.OtherButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OtherButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.OtherButton.UseCustomBackColor = True
        Me.OtherButton.UseSelectable = True
        Me.OtherButton.UseTileImage = True
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.Controls.Add(Me.OtherButton)
        Me.Controls.Add(Me.FavoritesButton)
        Me.Controls.Add(Me.BrowseAllButton)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HomeScreen"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Livestreamer Assistant"
        Me.TransparencyKey = System.Drawing.Color.DeepPink
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents BrowseAllButton As MetroFramework.Controls.MetroTile
    Friend WithEvents FavoritesButton As MetroFramework.Controls.MetroTile
    Friend WithEvents OtherButton As MetroFramework.Controls.MetroTile
End Class

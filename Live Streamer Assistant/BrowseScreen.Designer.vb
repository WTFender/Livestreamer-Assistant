<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowseScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.BackButton = New Livestreamer_Assistant.AnimPictureBox()
        Me.GameComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StreamerComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StreamButton = New Livestreamer_Assistant.AnimTile()
        Me.FavoritesButton = New Livestreamer_Assistant.AnimTile()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.HighQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.LowQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.MediumQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.RefreshButton = New Livestreamer_Assistant.AnimPictureBox()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Livestreamer_Assistant.My.Resources.Resources.BackIcon
        Me.BackButton.Location = New System.Drawing.Point(255, 20)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 29
        Me.BackButton.TabStop = False
        '
        'GameComboBox
        '
        Me.GameComboBox.FormattingEnabled = True
        Me.GameComboBox.ItemHeight = 23
        Me.GameComboBox.Location = New System.Drawing.Point(23, 76)
        Me.GameComboBox.Name = "GameComboBox"
        Me.GameComboBox.PromptText = "Select a Game"
        Me.GameComboBox.Size = New System.Drawing.Size(304, 29)
        Me.GameComboBox.TabIndex = 30
        Me.GameComboBox.UseSelectable = True
        '
        'StreamerComboBox
        '
        Me.StreamerComboBox.FormattingEnabled = True
        Me.StreamerComboBox.ItemHeight = 23
        Me.StreamerComboBox.Location = New System.Drawing.Point(23, 111)
        Me.StreamerComboBox.Name = "StreamerComboBox"
        Me.StreamerComboBox.PromptText = "Select a Streamer"
        Me.StreamerComboBox.Size = New System.Drawing.Size(304, 29)
        Me.StreamerComboBox.TabIndex = 34
        Me.StreamerComboBox.UseSelectable = True
        Me.StreamerComboBox.Visible = False
        '
        'StreamSpinner
        '
        Me.StreamSpinner.Location = New System.Drawing.Point(144, 15)
        Me.StreamSpinner.Maximum = 100
        Me.StreamSpinner.Name = "StreamSpinner"
        Me.StreamSpinner.Size = New System.Drawing.Size(16, 16)
        Me.StreamSpinner.Speed = 2.0!
        Me.StreamSpinner.TabIndex = 52
        Me.StreamSpinner.UseCustomBackColor = True
        Me.StreamSpinner.UseSelectable = True
        Me.StreamSpinner.Value = 36
        Me.StreamSpinner.Visible = False
        '
        'Timer1
        '
        '
        'StreamButton
        '
        Me.StreamButton.ActiveControl = Nothing
        Me.StreamButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StreamButton.Controls.Add(Me.StreamSpinner)
        Me.StreamButton.Location = New System.Drawing.Point(23, 320)
        Me.StreamButton.Name = "StreamButton"
        Me.StreamButton.Size = New System.Drawing.Size(304, 60)
        Me.StreamButton.TabIndex = 57
        Me.StreamButton.Text = "Stream"
        Me.StreamButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StreamButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StreamButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.StreamButton.UseCustomBackColor = True
        Me.StreamButton.UseSelectable = True
        Me.StreamButton.UseTileImage = True
        Me.StreamButton.Visible = False
        '
        'FavoritesButton
        '
        Me.FavoritesButton.ActiveControl = Nothing
        Me.FavoritesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FavoritesButton.Location = New System.Drawing.Point(230, 146)
        Me.FavoritesButton.Name = "FavoritesButton"
        Me.FavoritesButton.Size = New System.Drawing.Size(97, 112)
        Me.FavoritesButton.TabIndex = 59
        Me.FavoritesButton.Text = "Add to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favorites"
        Me.FavoritesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FavoritesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FavoritesButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.FavoritesButton.UseCustomBackColor = True
        Me.FavoritesButton.UseSelectable = True
        Me.FavoritesButton.UseTileImage = True
        Me.FavoritesButton.Visible = False
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.Location = New System.Drawing.Point(23, 146)
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.Size = New System.Drawing.Size(201, 112)
        Me.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PreviewPictureBox.TabIndex = 60
        Me.PreviewPictureBox.TabStop = False
        Me.PreviewPictureBox.Visible = False
        '
        'HighQualityTile
        '
        Me.HighQualityTile.ActiveControl = Nothing
        Me.HighQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HighQualityTile.Location = New System.Drawing.Point(230, 264)
        Me.HighQualityTile.Name = "HighQualityTile"
        Me.HighQualityTile.Size = New System.Drawing.Size(97, 50)
        Me.HighQualityTile.TabIndex = 62
        Me.HighQualityTile.Text = "High"
        Me.HighQualityTile.UseCustomBackColor = True
        Me.HighQualityTile.UseSelectable = True
        Me.HighQualityTile.Visible = False
        '
        'LowQualityTile
        '
        Me.LowQualityTile.ActiveControl = Nothing
        Me.LowQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowQualityTile.Location = New System.Drawing.Point(23, 264)
        Me.LowQualityTile.Name = "LowQualityTile"
        Me.LowQualityTile.Size = New System.Drawing.Size(97, 50)
        Me.LowQualityTile.TabIndex = 63
        Me.LowQualityTile.Text = "Low"
        Me.LowQualityTile.UseCustomBackColor = True
        Me.LowQualityTile.UseSelectable = True
        Me.LowQualityTile.Visible = False
        '
        'MediumQualityTile
        '
        Me.MediumQualityTile.ActiveControl = Nothing
        Me.MediumQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumQualityTile.Location = New System.Drawing.Point(126, 264)
        Me.MediumQualityTile.Name = "MediumQualityTile"
        Me.MediumQualityTile.Size = New System.Drawing.Size(98, 50)
        Me.MediumQualityTile.TabIndex = 64
        Me.MediumQualityTile.Text = "Medium"
        Me.MediumQualityTile.UseCustomBackColor = True
        Me.MediumQualityTile.UseSelectable = True
        Me.MediumQualityTile.Visible = False
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.Livestreamer_Assistant.My.Resources.Resources.refresh
        Me.RefreshButton.Location = New System.Drawing.Point(209, 20)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(40, 40)
        Me.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefreshButton.TabIndex = 66
        Me.RefreshButton.TabStop = False
        '
        'BrowseScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.MediumQualityTile)
        Me.Controls.Add(Me.LowQualityTile)
        Me.Controls.Add(Me.HighQualityTile)
        Me.Controls.Add(Me.PreviewPictureBox)
        Me.Controls.Add(Me.FavoritesButton)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.StreamerComboBox)
        Me.Controls.Add(Me.GameComboBox)
        Me.Controls.Add(Me.BackButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BrowseScreen"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Browse Streams"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamButton.ResumeLayout(False)
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StreamerComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PreviewPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As Livestreamer_Assistant.AnimPictureBox
    Friend WithEvents StreamButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents HighQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents LowQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents MediumQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents RefreshButton As Livestreamer_Assistant.AnimPictureBox
    Friend WithEvents FavoritesButton As Livestreamer_Assistant.AnimTile
End Class

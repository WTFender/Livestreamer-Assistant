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
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.GameComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StreamerComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HighButton = New MetroFramework.Controls.MetroTile()
        Me.MediumButton = New MetroFramework.Controls.MetroTile()
        Me.LowButton = New MetroFramework.Controls.MetroTile()
        Me.StreamButton = New MetroFramework.Controls.MetroTile()
        Me.FavoritesButton = New MetroFramework.Controls.MetroTile()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Live_Streamer_Assistant.My.Resources.Resources.BackIcon
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
        'HighButton
        '
        Me.HighButton.ActiveControl = Nothing
        Me.HighButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HighButton.Location = New System.Drawing.Point(230, 264)
        Me.HighButton.Name = "HighButton"
        Me.HighButton.Size = New System.Drawing.Size(97, 50)
        Me.HighButton.Style = MetroFramework.MetroColorStyle.Green
        Me.HighButton.TabIndex = 54
        Me.HighButton.Text = "High"
        Me.HighButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HighButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HighButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.HighButton.UseCustomBackColor = True
        Me.HighButton.UseSelectable = True
        Me.HighButton.UseTileImage = True
        Me.HighButton.Visible = False
        '
        'MediumButton
        '
        Me.MediumButton.ActiveControl = Nothing
        Me.MediumButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumButton.Location = New System.Drawing.Point(127, 264)
        Me.MediumButton.Name = "MediumButton"
        Me.MediumButton.Size = New System.Drawing.Size(97, 50)
        Me.MediumButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.MediumButton.TabIndex = 55
        Me.MediumButton.Text = "Medium"
        Me.MediumButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MediumButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MediumButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MediumButton.UseCustomBackColor = True
        Me.MediumButton.UseSelectable = True
        Me.MediumButton.UseTileImage = True
        Me.MediumButton.Visible = False
        '
        'LowButton
        '
        Me.LowButton.ActiveControl = Nothing
        Me.LowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowButton.Location = New System.Drawing.Point(23, 264)
        Me.LowButton.Name = "LowButton"
        Me.LowButton.Size = New System.Drawing.Size(97, 50)
        Me.LowButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.LowButton.TabIndex = 56
        Me.LowButton.Text = "Low"
        Me.LowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LowButton.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LowButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.LowButton.UseCustomBackColor = True
        Me.LowButton.UseSelectable = True
        Me.LowButton.Visible = False
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
        'BrowseScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.PreviewPictureBox)
        Me.Controls.Add(Me.FavoritesButton)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.LowButton)
        Me.Controls.Add(Me.MediumButton)
        Me.Controls.Add(Me.HighButton)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents GameComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StreamerComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HighButton As MetroFramework.Controls.MetroTile
    Friend WithEvents MediumButton As MetroFramework.Controls.MetroTile
    Friend WithEvents LowButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamButton As MetroFramework.Controls.MetroTile
    Friend WithEvents FavoritesButton As MetroFramework.Controls.MetroTile
    Friend WithEvents PreviewPictureBox As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Favorites
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
        Me.FaveComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StatusButton = New MetroFramework.Controls.MetroTile()
        Me.StreamInfoPanel = New MetroFramework.Controls.MetroTile()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MediumQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.LowQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.HighQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.RefreshButton = New Livestreamer_Assistant.AnimPictureBox()
        Me.StreamButton = New Livestreamer_Assistant.AnimTile()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ManageFavoritesButton = New Livestreamer_Assistant.AnimTile()
        Me.BackButton = New Livestreamer_Assistant.AnimPictureBox()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FaveComboBox
        '
        Me.FaveComboBox.FormattingEnabled = True
        Me.FaveComboBox.ItemHeight = 23
        Me.FaveComboBox.Location = New System.Drawing.Point(23, 76)
        Me.FaveComboBox.Name = "FaveComboBox"
        Me.FaveComboBox.PromptText = "Select a Saved Stream"
        Me.FaveComboBox.Size = New System.Drawing.Size(304, 29)
        Me.FaveComboBox.TabIndex = 32
        Me.FaveComboBox.UseSelectable = True
        '
        'StatusButton
        '
        Me.StatusButton.ActiveControl = Nothing
        Me.StatusButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StatusButton.Location = New System.Drawing.Point(23, 111)
        Me.StatusButton.Name = "StatusButton"
        Me.StatusButton.Size = New System.Drawing.Size(200, 81)
        Me.StatusButton.TabIndex = 38
        Me.StatusButton.Text = "mEclipse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Online"
        Me.StatusButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StatusButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.StatusButton.UseCustomBackColor = True
        Me.StatusButton.UseSelectable = True
        Me.StatusButton.UseTileImage = True
        Me.StatusButton.Visible = False
        '
        'StreamInfoPanel
        '
        Me.StreamInfoPanel.ActiveControl = Nothing
        Me.StreamInfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StreamInfoPanel.Location = New System.Drawing.Point(23, 198)
        Me.StreamInfoPanel.Name = "StreamInfoPanel"
        Me.StreamInfoPanel.Size = New System.Drawing.Size(304, 60)
        Me.StreamInfoPanel.TabIndex = 64
        Me.StreamInfoPanel.Text = "MetroTile1"
        Me.StreamInfoPanel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StreamInfoPanel.UseCustomBackColor = True
        Me.StreamInfoPanel.UseSelectable = True
        Me.StreamInfoPanel.UseTileImage = True
        Me.StreamInfoPanel.Visible = False
        '
        'Timer1
        '
        '
        'MediumQualityTile
        '
        Me.MediumQualityTile.ActiveControl = Nothing
        Me.MediumQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumQualityTile.Location = New System.Drawing.Point(126, 264)
        Me.MediumQualityTile.Name = "MediumQualityTile"
        Me.MediumQualityTile.Size = New System.Drawing.Size(98, 50)
        Me.MediumQualityTile.TabIndex = 68
        Me.MediumQualityTile.Text = "Medium"
        Me.MediumQualityTile.UseCustomBackColor = True
        Me.MediumQualityTile.UseSelectable = True
        Me.MediumQualityTile.Visible = False
        '
        'LowQualityTile
        '
        Me.LowQualityTile.ActiveControl = Nothing
        Me.LowQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowQualityTile.Location = New System.Drawing.Point(23, 264)
        Me.LowQualityTile.Name = "LowQualityTile"
        Me.LowQualityTile.Size = New System.Drawing.Size(97, 50)
        Me.LowQualityTile.TabIndex = 67
        Me.LowQualityTile.Text = "Low"
        Me.LowQualityTile.UseCustomBackColor = True
        Me.LowQualityTile.UseSelectable = True
        Me.LowQualityTile.Visible = False
        '
        'HighQualityTile
        '
        Me.HighQualityTile.ActiveControl = Nothing
        Me.HighQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HighQualityTile.Location = New System.Drawing.Point(230, 264)
        Me.HighQualityTile.Name = "HighQualityTile"
        Me.HighQualityTile.Size = New System.Drawing.Size(97, 50)
        Me.HighQualityTile.TabIndex = 66
        Me.HighQualityTile.Text = "High"
        Me.HighQualityTile.UseCustomBackColor = True
        Me.HighQualityTile.UseSelectable = True
        Me.HighQualityTile.Visible = False
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.Livestreamer_Assistant.My.Resources.Resources.refresh
        Me.RefreshButton.Location = New System.Drawing.Point(209, 20)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(40, 40)
        Me.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefreshButton.TabIndex = 65
        Me.RefreshButton.TabStop = False
        '
        'StreamButton
        '
        Me.StreamButton.ActiveControl = Nothing
        Me.StreamButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StreamButton.Controls.Add(Me.StreamSpinner)
        Me.StreamButton.Location = New System.Drawing.Point(23, 320)
        Me.StreamButton.Name = "StreamButton"
        Me.StreamButton.Size = New System.Drawing.Size(304, 60)
        Me.StreamButton.TabIndex = 58
        Me.StreamButton.Text = "Stream"
        Me.StreamButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StreamButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StreamButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.StreamButton.UseCustomBackColor = True
        Me.StreamButton.UseSelectable = True
        Me.StreamButton.UseTileImage = True
        Me.StreamButton.Visible = False
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
        'ManageFavoritesButton
        '
        Me.ManageFavoritesButton.ActiveControl = Nothing
        Me.ManageFavoritesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ManageFavoritesButton.Location = New System.Drawing.Point(230, 111)
        Me.ManageFavoritesButton.Name = "ManageFavoritesButton"
        Me.ManageFavoritesButton.Size = New System.Drawing.Size(97, 81)
        Me.ManageFavoritesButton.TabIndex = 37
        Me.ManageFavoritesButton.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favorites"
        Me.ManageFavoritesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManageFavoritesButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.ManageFavoritesButton.UseCustomBackColor = True
        Me.ManageFavoritesButton.UseSelectable = True
        Me.ManageFavoritesButton.UseTileImage = True
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Livestreamer_Assistant.My.Resources.Resources.BackIcon
        Me.BackButton.Location = New System.Drawing.Point(255, 20)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 31
        Me.BackButton.TabStop = False
        '
        'Favorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.MediumQualityTile)
        Me.Controls.Add(Me.LowQualityTile)
        Me.Controls.Add(Me.HighQualityTile)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.StreamInfoPanel)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.StatusButton)
        Me.Controls.Add(Me.ManageFavoritesButton)
        Me.Controls.Add(Me.FaveComboBox)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "Favorites"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Favorites"
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamButton.ResumeLayout(False)
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FaveComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StatusButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents StreamInfoPanel As MetroFramework.Controls.MetroTile
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackButton As Livestreamer_Assistant.AnimPictureBox
    Friend WithEvents StreamButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents ManageFavoritesButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents RefreshButton As Livestreamer_Assistant.AnimPictureBox
    Friend WithEvents MediumQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents LowQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents HighQualityTile As Livestreamer_Assistant.QualityTile
End Class

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
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.FaveComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.StatusButton = New MetroFramework.Controls.MetroTile()
        Me.StreamButton = New MetroFramework.Controls.MetroTile()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.LowButton = New MetroFramework.Controls.MetroTile()
        Me.MediumButton = New MetroFramework.Controls.MetroTile()
        Me.HighButton = New MetroFramework.Controls.MetroTile()
        Me.ManageFavoritesButton = New MetroFramework.Controls.MetroTile()
        Me.StreamInfoPanel = New MetroFramework.Controls.MetroTile()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RefreshButton = New System.Windows.Forms.PictureBox()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Live_Streamer_Assistant.My.Resources.Resources.BackIcon
        Me.BackButton.Location = New System.Drawing.Point(255, 20)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 31
        Me.BackButton.TabStop = False
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
        Me.StatusButton.Size = New System.Drawing.Size(200, 60)
        Me.StatusButton.TabIndex = 38
        Me.StatusButton.Text = "mEclipse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Online"
        Me.StatusButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StatusButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.StatusButton.UseCustomBackColor = True
        Me.StatusButton.UseSelectable = True
        Me.StatusButton.UseTileImage = True
        Me.StatusButton.Visible = False
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
        'LowButton
        '
        Me.LowButton.ActiveControl = Nothing
        Me.LowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowButton.Location = New System.Drawing.Point(23, 243)
        Me.LowButton.Name = "LowButton"
        Me.LowButton.Size = New System.Drawing.Size(97, 71)
        Me.LowButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.LowButton.TabIndex = 61
        Me.LowButton.Text = "Low"
        Me.LowButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LowButton.TileImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LowButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.LowButton.UseCustomBackColor = True
        Me.LowButton.UseSelectable = True
        Me.LowButton.Visible = False
        '
        'MediumButton
        '
        Me.MediumButton.ActiveControl = Nothing
        Me.MediumButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumButton.Location = New System.Drawing.Point(126, 243)
        Me.MediumButton.Name = "MediumButton"
        Me.MediumButton.Size = New System.Drawing.Size(97, 71)
        Me.MediumButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.MediumButton.TabIndex = 60
        Me.MediumButton.Text = "Medium"
        Me.MediumButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MediumButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MediumButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MediumButton.UseCustomBackColor = True
        Me.MediumButton.UseSelectable = True
        Me.MediumButton.UseTileImage = True
        Me.MediumButton.Visible = False
        '
        'HighButton
        '
        Me.HighButton.ActiveControl = Nothing
        Me.HighButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HighButton.Location = New System.Drawing.Point(230, 243)
        Me.HighButton.Name = "HighButton"
        Me.HighButton.Size = New System.Drawing.Size(97, 71)
        Me.HighButton.Style = MetroFramework.MetroColorStyle.Green
        Me.HighButton.TabIndex = 59
        Me.HighButton.Text = "High"
        Me.HighButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HighButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HighButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.HighButton.UseCustomBackColor = True
        Me.HighButton.UseSelectable = True
        Me.HighButton.UseTileImage = True
        Me.HighButton.Visible = False
        '
        'ManageFavoritesButton
        '
        Me.ManageFavoritesButton.ActiveControl = Nothing
        Me.ManageFavoritesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ManageFavoritesButton.Location = New System.Drawing.Point(230, 111)
        Me.ManageFavoritesButton.Name = "ManageFavoritesButton"
        Me.ManageFavoritesButton.Size = New System.Drawing.Size(97, 60)
        Me.ManageFavoritesButton.TabIndex = 37
        Me.ManageFavoritesButton.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favorites"
        Me.ManageFavoritesButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ManageFavoritesButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.ManageFavoritesButton.UseCustomBackColor = True
        Me.ManageFavoritesButton.UseSelectable = True
        Me.ManageFavoritesButton.UseTileImage = True
        '
        'StreamInfoPanel
        '
        Me.StreamInfoPanel.ActiveControl = Nothing
        Me.StreamInfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StreamInfoPanel.Location = New System.Drawing.Point(23, 177)
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
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.Live_Streamer_Assistant.My.Resources.Resources.refresh
        Me.RefreshButton.Location = New System.Drawing.Point(209, 20)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(40, 40)
        Me.RefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RefreshButton.TabIndex = 65
        Me.RefreshButton.TabStop = False
        '
        'Favorites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.StreamInfoPanel)
        Me.Controls.Add(Me.LowButton)
        Me.Controls.Add(Me.MediumButton)
        Me.Controls.Add(Me.HighButton)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.StatusButton)
        Me.Controls.Add(Me.ManageFavoritesButton)
        Me.Controls.Add(Me.FaveComboBox)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "Favorites"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Favorites"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamButton.ResumeLayout(False)
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents FaveComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents StatusButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents LowButton As MetroFramework.Controls.MetroTile
    Friend WithEvents MediumButton As MetroFramework.Controls.MetroTile
    Friend WithEvents HighButton As MetroFramework.Controls.MetroTile
    Friend WithEvents ManageFavoritesButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamInfoPanel As MetroFramework.Controls.MetroTile
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RefreshButton As System.Windows.Forms.PictureBox
End Class

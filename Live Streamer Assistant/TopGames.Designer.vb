<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopGames
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
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.LowButton = New MetroFramework.Controls.MetroTile()
        Me.MediumButton = New MetroFramework.Controls.MetroTile()
        Me.HighButton = New MetroFramework.Controls.MetroTile()
        Me.StreamButton = New MetroFramework.Controls.MetroTile()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Live_Streamer_Assistant.My.Resources.Resources.BackIcon
        Me.BackButton.Location = New System.Drawing.Point(255, 20)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 30
        Me.BackButton.TabStop = False
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile3.Location = New System.Drawing.Point(23, 208)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile3.TabIndex = 31
        Me.MetroTile3.Text = "TopGameButton3"
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile2.Location = New System.Drawing.Point(23, 142)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile2.TabIndex = 34
        Me.MetroTile2.Text = "TopGameButton3"
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroTile1.Location = New System.Drawing.Point(23, 76)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(304, 60)
        Me.MetroTile1.TabIndex = 35
        Me.MetroTile1.Text = "TopGameButton3"
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'LowButton
        '
        Me.LowButton.ActiveControl = Nothing
        Me.LowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowButton.Location = New System.Drawing.Point(23, 274)
        Me.LowButton.Name = "LowButton"
        Me.LowButton.Size = New System.Drawing.Size(97, 40)
        Me.LowButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.LowButton.TabIndex = 59
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
        Me.MediumButton.Location = New System.Drawing.Point(126, 274)
        Me.MediumButton.Name = "MediumButton"
        Me.MediumButton.Size = New System.Drawing.Size(97, 40)
        Me.MediumButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.MediumButton.TabIndex = 58
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
        Me.HighButton.Location = New System.Drawing.Point(230, 274)
        Me.HighButton.Name = "HighButton"
        Me.HighButton.Size = New System.Drawing.Size(97, 40)
        Me.HighButton.Style = MetroFramework.MetroColorStyle.Green
        Me.HighButton.TabIndex = 57
        Me.HighButton.Text = "High"
        Me.HighButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HighButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HighButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.HighButton.UseCustomBackColor = True
        Me.HighButton.UseSelectable = True
        Me.HighButton.UseTileImage = True
        Me.HighButton.Visible = False
        '
        'StreamButton
        '
        Me.StreamButton.ActiveControl = Nothing
        Me.StreamButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StreamButton.Controls.Add(Me.StreamSpinner)
        Me.StreamButton.Location = New System.Drawing.Point(23, 320)
        Me.StreamButton.Name = "StreamButton"
        Me.StreamButton.Size = New System.Drawing.Size(304, 60)
        Me.StreamButton.TabIndex = 60
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
        'Timer2
        '
        '
        'TopGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.LowButton)
        Me.Controls.Add(Me.MediumButton)
        Me.Controls.Add(Me.HighButton)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "TopGames"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Top Streamers"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents LowButton As MetroFramework.Controls.MetroTile
    Friend WithEvents MediumButton As MetroFramework.Controls.MetroTile
    Friend WithEvents HighButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class

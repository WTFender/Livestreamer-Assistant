<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherServices
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
        Me.BackButton = New Livestreamer_Assistant.AnimPictureBox
        Me.LowButton = New Livestreamer_Assistant.AnimTile
        Me.MediumButton = New Livestreamer_Assistant.AnimTile
        Me.HighButton = New Livestreamer_Assistant.AnimTile
        Me.StreamButton = New Livestreamer_Assistant.AnimTile
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.ChanTextBox = New MetroFramework.Controls.MetroTextBox()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Image = Global.Livestreamer_Assistant.My.Resources.Resources.BackIcon
        Me.BackButton.Location = New System.Drawing.Point(255, 20)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(40, 40)
        Me.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackButton.TabIndex = 32
        Me.BackButton.TabStop = False
        '
        'LowButton
        '
        Me.LowButton.ActiveControl = Nothing
        Me.LowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowButton.Location = New System.Drawing.Point(23, 243)
        Me.LowButton.Name = "LowButton"
        Me.LowButton.Size = New System.Drawing.Size(97, 71)
        Me.LowButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.LowButton.TabIndex = 65
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
        Me.MediumButton.TabIndex = 64
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
        Me.HighButton.TabIndex = 63
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
        Me.StreamButton.TabIndex = 62
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
        'Timer1
        '
        '
        'ServiceComboBox
        '
        Me.ServiceComboBox.FormattingEnabled = True
        Me.ServiceComboBox.ItemHeight = 23
        Me.ServiceComboBox.Items.AddRange(New Object() {"afreecatv.com", "afreeca.tv", "aftonbladet.se", "aliez.tv", "live.daserste.de", "ardmediathek.de", "arte.tv", "azubu.tv", "be-at.tv", "bambuser.com", "chaturbate.com", "connectcast.tv", "crunchyroll.com", "cybergame.tv", "dailymotion.com", "video.disney.de", "disneychannel.de", "dommune.com", "douyutv.com", "api.dmcloud.net", "dr.dk", "euronews.com", "filmon.com", "filmon.us", "furstre.am", "gaminglive.tv", "gomexp.com", "goodgame.ru", "hitbox.tv", "itv.com/itvplayer", "leton.tv", "livestation.com", "new.livestream.com", "mips.tv", "mlg.tv", "nhk.or.jp/nhkworld", "nos.nl", "npo.nl", "tv.nrk.no", "radio.nrk.no", "livestream.com", "picarto.tv", "rtve.es", "seemeplay.ru", "speedrunslive.com", "streamlive.to", "svtplay.se", "svtflow.se", "oppetarkiv.se", "star.plu.cn", "star.tga.plu.cn", "tv3.cat", "tv4play.se", "fotbollskanalen.se", "tvcatchup.com", "tvplayer.com", "twitch.tv", "ustream.tv", "vaughnlive.tv", "breakers.tv", "instagib.tv", "vapers.tv", "veetle.com", "vgtv.no", "viagame.com", "tv3play.se", "tv3play.no", "tv3play.dk", "tv3play.ee", "tv3play.lt", "tv3play.lv", "tv6play.se", "tv6play.no", "tv8play.se", "tv10play.se", "viasat4play.no", "wat.tv", "weeb.tv", "youtube.com", "youtu.be", "zdf.de"})
        Me.ServiceComboBox.Location = New System.Drawing.Point(23, 76)
        Me.ServiceComboBox.Name = "ServiceComboBox"
        Me.ServiceComboBox.PromptText = "Select a Streaming Service"
        Me.ServiceComboBox.Size = New System.Drawing.Size(304, 29)
        Me.ServiceComboBox.TabIndex = 66
        Me.ServiceComboBox.UseSelectable = True
        '
        'ChanTextBox
        '
        Me.ChanTextBox.Lines = New String(-1) {}
        Me.ChanTextBox.Location = New System.Drawing.Point(23, 111)
        Me.ChanTextBox.MaxLength = 32767
        Me.ChanTextBox.Name = "ChanTextBox"
        Me.ChanTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ChanTextBox.PromptText = "Enter a Channel/Stream"
        Me.ChanTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ChanTextBox.SelectedText = ""
        Me.ChanTextBox.Size = New System.Drawing.Size(304, 29)
        Me.ChanTextBox.TabIndex = 67
        Me.ChanTextBox.UseSelectable = True
        '
        'OtherServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.ChanTextBox)
        Me.Controls.Add(Me.ServiceComboBox)
        Me.Controls.Add(Me.LowButton)
        Me.Controls.Add(Me.MediumButton)
        Me.Controls.Add(Me.HighButton)
        Me.Controls.Add(Me.StreamButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "OtherServices"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "OtherServices"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents LowButton As MetroFramework.Controls.MetroTile
    Friend WithEvents MediumButton As MetroFramework.Controls.MetroTile
    Friend WithEvents HighButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamButton As MetroFramework.Controls.MetroTile
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ServiceComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ChanTextBox As MetroFramework.Controls.MetroTextBox
End Class

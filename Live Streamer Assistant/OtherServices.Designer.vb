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
        Me.BackButton = New Livestreamer_Assistant.AnimPictureBox()
        Me.StreamButton = New Livestreamer_Assistant.AnimTile()
        Me.StreamSpinner = New MetroFramework.Controls.MetroProgressSpinner()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.ChanTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MediumQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.LowQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.HighQualityTile = New Livestreamer_Assistant.QualityTile()
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
        'MediumQualityTile
        '
        Me.MediumQualityTile.ActiveControl = Nothing
        Me.MediumQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumQualityTile.Location = New System.Drawing.Point(126, 264)
        Me.MediumQualityTile.Name = "MediumQualityTile"
        Me.MediumQualityTile.Size = New System.Drawing.Size(98, 50)
        Me.MediumQualityTile.TabIndex = 70
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
        Me.LowQualityTile.TabIndex = 69
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
        Me.HighQualityTile.TabIndex = 68
        Me.HighQualityTile.Text = "High"
        Me.HighQualityTile.UseCustomBackColor = True
        Me.HighQualityTile.UseSelectable = True
        Me.HighQualityTile.Visible = False
        '
        'OtherServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.MediumQualityTile)
        Me.Controls.Add(Me.LowQualityTile)
        Me.Controls.Add(Me.HighQualityTile)
        Me.Controls.Add(Me.ChanTextBox)
        Me.Controls.Add(Me.ServiceComboBox)
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
    Friend WithEvents StreamSpinner As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ServiceComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ChanTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MediumQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents LowQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents HighQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents BackButton As Livestreamer_Assistant.AnimPictureBox
    Friend WithEvents StreamButton As Livestreamer_Assistant.AnimTile
End Class

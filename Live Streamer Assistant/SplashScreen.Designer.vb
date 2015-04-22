<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.OKButton = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VersionButton = New Livestreamer_Assistant.AnimTile()
        Me.UpdateButton = New Livestreamer_Assistant.AnimTile()
        Me.VerifyButton = New Livestreamer_Assistant.AnimTile()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Highlight = True
        Me.OKButton.Location = New System.Drawing.Point(113, 227)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseSelectable = True
        Me.OKButton.Visible = False
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(77, 258)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(147, 15)
        Me.MetroCheckBox1.TabIndex = 1
        Me.MetroCheckBox1.Text = "Do not show this again."
        Me.MetroCheckBox1.UseSelectable = True
        Me.MetroCheckBox1.Visible = False
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'VersionButton
        '
        Me.VersionButton.ActiveControl = Nothing
        Me.VersionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VersionButton.Location = New System.Drawing.Point(68, 79)
        Me.VersionButton.Name = "VersionButton"
        Me.VersionButton.Size = New System.Drawing.Size(165, 40)
        Me.VersionButton.TabIndex = 6
        Me.VersionButton.Text = "Download Livestreamer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.12.1"
        Me.VersionButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VersionButton.UseCustomBackColor = True
        Me.VersionButton.UseSelectable = True
        '
        'UpdateButton
        '
        Me.UpdateButton.ActiveControl = Nothing
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UpdateButton.Location = New System.Drawing.Point(68, 171)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(165, 40)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "Update Livestreamer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Config Path"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UpdateButton.UseCustomBackColor = True
        Me.UpdateButton.UseSelectable = True
        Me.UpdateButton.Visible = False
        '
        'VerifyButton
        '
        Me.VerifyButton.ActiveControl = Nothing
        Me.VerifyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VerifyButton.Location = New System.Drawing.Point(68, 125)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(165, 40)
        Me.VerifyButton.TabIndex = 4
        Me.VerifyButton.Text = "Verify" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VLC Path"
        Me.VerifyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.VerifyButton.UseCustomBackColor = True
        Me.VerifyButton.UseSelectable = True
        Me.VerifyButton.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(257, 298)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(38, 23)
        Me.MetroButton1.TabIndex = 7
        Me.MetroButton1.Text = "Skip"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.Visible = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 325)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.VersionButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.OKButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Before you begin..."
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UpdateButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents VerifyButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents VersionButton As Livestreamer_Assistant.AnimTile
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class

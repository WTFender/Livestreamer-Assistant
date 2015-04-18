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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink = New MetroFramework.Controls.MetroLink()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(113, 256)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "OK"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(77, 287)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(147, 15)
        Me.MetroCheckBox1.TabIndex = 1
        Me.MetroCheckBox1.Text = "Do not show this again."
        Me.MetroCheckBox1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(41, 134)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(218, 57)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "This interface requires Livestreamer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.12.1 to be installed and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "config" & _
    "ured with VLC media player."
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MetroLink
        '
        Me.MetroLink.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroLink.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.MetroLink.Location = New System.Drawing.Point(23, 73)
        Me.MetroLink.Name = "MetroLink"
        Me.MetroLink.Size = New System.Drawing.Size(254, 58)
        Me.MetroLink.TabIndex = 3
        Me.MetroLink.Text = "Unable to determine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Livestreamer Version." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click to Update."
        Me.MetroLink.UseSelectable = True
        Me.MetroLink.UseStyleColors = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 325)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLink)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.MetroButton1)
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
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
End Class

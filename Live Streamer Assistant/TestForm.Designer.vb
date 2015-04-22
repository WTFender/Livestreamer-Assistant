<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LowQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.MediumQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.HighQualityTile = New Livestreamer_Assistant.QualityTile()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'LowQualityTile
        '
        Me.LowQualityTile.ActiveControl = Nothing
        Me.LowQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LowQualityTile.Location = New System.Drawing.Point(23, 109)
        Me.LowQualityTile.Name = "LowQualityTile"
        Me.LowQualityTile.Size = New System.Drawing.Size(75, 23)
        Me.LowQualityTile.TabIndex = 3
        Me.LowQualityTile.Text = "Low"
        Me.LowQualityTile.UseCustomBackColor = True
        Me.LowQualityTile.UseSelectable = True
        '
        'MediumQualityTile
        '
        Me.MediumQualityTile.ActiveControl = Nothing
        Me.MediumQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MediumQualityTile.Location = New System.Drawing.Point(122, 108)
        Me.MediumQualityTile.Name = "MediumQualityTile"
        Me.MediumQualityTile.Size = New System.Drawing.Size(75, 23)
        Me.MediumQualityTile.TabIndex = 4
        Me.MediumQualityTile.Text = "Medium"
        Me.MediumQualityTile.UseCustomBackColor = True
        Me.MediumQualityTile.UseSelectable = True
        '
        'HighQualityTile
        '
        Me.HighQualityTile.ActiveControl = Nothing
        Me.HighQualityTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HighQualityTile.Location = New System.Drawing.Point(230, 108)
        Me.HighQualityTile.Name = "HighQualityTile"
        Me.HighQualityTile.Size = New System.Drawing.Size(75, 23)
        Me.HighQualityTile.TabIndex = 5
        Me.HighQualityTile.Text = "High"
        Me.HighQualityTile.UseCustomBackColor = True
        Me.HighQualityTile.UseSelectable = True
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.Controls.Add(Me.HighQualityTile)
        Me.Controls.Add(Me.MediumQualityTile)
        Me.Controls.Add(Me.LowQualityTile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LowQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents MediumQualityTile As Livestreamer_Assistant.QualityTile
    Friend WithEvents HighQualityTile As Livestreamer_Assistant.QualityTile
End Class

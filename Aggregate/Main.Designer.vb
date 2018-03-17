<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

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
        Me.steam = New System.Windows.Forms.PictureBox()
        Me.Blizzard = New System.Windows.Forms.PictureBox()
        Me.Emulators = New System.Windows.Forms.Button()
        CType(Me.steam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blizzard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'steam
        '
        Me.steam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.steam.Image = Global.Aggregate.My.Resources.customresources.steam_logo
        Me.steam.InitialImage = Nothing
        Me.steam.Location = New System.Drawing.Point(12, 12)
        Me.steam.Name = "steam"
        Me.steam.Size = New System.Drawing.Size(250, 80)
        Me.steam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.steam.TabIndex = 0
        Me.steam.TabStop = False
        '
        'Blizzard
        '
        Me.Blizzard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Blizzard.Image = Global.Aggregate.My.Resources.customresources.blizz_logo
        Me.Blizzard.InitialImage = Nothing
        Me.Blizzard.Location = New System.Drawing.Point(268, 12)
        Me.Blizzard.Name = "Blizzard"
        Me.Blizzard.Size = New System.Drawing.Size(250, 80)
        Me.Blizzard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Blizzard.TabIndex = 0
        Me.Blizzard.TabStop = False
        '
        'Emulators
        '
        Me.Emulators.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emulators.Location = New System.Drawing.Point(12, 98)
        Me.Emulators.Name = "Emulators"
        Me.Emulators.Size = New System.Drawing.Size(250, 80)
        Me.Emulators.TabIndex = 1
        Me.Emulators.Text = "Emulation"
        Me.Emulators.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 382)
        Me.Controls.Add(Me.Emulators)
        Me.Controls.Add(Me.Blizzard)
        Me.Controls.Add(Me.steam)
        Me.Name = "Main"
        Me.Text = "Aggregate"
        CType(Me.steam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blizzard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents steam As PictureBox
    Friend WithEvents Blizzard As PictureBox
    Friend WithEvents Emulators As Button
End Class

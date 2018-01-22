<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Steam_Games
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
        Me.steamBox = New System.Windows.Forms.ListBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.launchSettings = New System.Windows.Forms.TextBox()
        Me.saveSettings = New System.Windows.Forms.Button()
        Me.GameImage = New System.Windows.Forms.PictureBox()
        CType(Me.GameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'steamBox
        '
        Me.steamBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steamBox.FormattingEnabled = True
        Me.steamBox.ItemHeight = 18
        Me.steamBox.Location = New System.Drawing.Point(12, 20)
        Me.steamBox.Name = "steamBox"
        Me.steamBox.Size = New System.Drawing.Size(304, 724)
        Me.steamBox.TabIndex = 0
        '
        'playButton
        '
        Me.playButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playButton.Location = New System.Drawing.Point(358, 670)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(289, 74)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'launchSettings
        '
        Me.launchSettings.Location = New System.Drawing.Point(358, 147)
        Me.launchSettings.Name = "launchSettings"
        Me.launchSettings.Size = New System.Drawing.Size(380, 20)
        Me.launchSettings.TabIndex = 2
        '
        'saveSettings
        '
        Me.saveSettings.Location = New System.Drawing.Point(663, 173)
        Me.saveSettings.Name = "saveSettings"
        Me.saveSettings.Size = New System.Drawing.Size(75, 23)
        Me.saveSettings.TabIndex = 3
        Me.saveSettings.Text = "Save"
        Me.saveSettings.UseVisualStyleBackColor = True
        '
        'GameImage
        '
        Me.GameImage.Location = New System.Drawing.Point(358, 20)
        Me.GameImage.Name = "GameImage"
        Me.GameImage.Size = New System.Drawing.Size(380, 112)
        Me.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameImage.TabIndex = 4
        Me.GameImage.TabStop = False
        '
        'Steam_Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 769)
        Me.Controls.Add(Me.GameImage)
        Me.Controls.Add(Me.saveSettings)
        Me.Controls.Add(Me.launchSettings)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.steamBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Steam_Games"
        Me.Text = "Steam Games"
        CType(Me.GameImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents steamBox As ListBox
    Friend WithEvents playButton As Button
    Friend WithEvents launchSettings As TextBox
    Friend WithEvents saveSettings As Button
    Friend WithEvents GameImage As PictureBox
End Class

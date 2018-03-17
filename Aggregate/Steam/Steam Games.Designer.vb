<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Steam_Games
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.steamBox = New System.Windows.Forms.ListBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.launchSettings = New System.Windows.Forms.TextBox()
        Me.saveSettings = New System.Windows.Forms.Button()
        Me.GameImage = New System.Windows.Forms.PictureBox()
        Me.ExtraProgram1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ExtraSelect1 = New System.Windows.Forms.Button()
        Me.ExtraSelect2 = New System.Windows.Forms.Button()
        Me.ExtraProgram2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Alternate = New System.Windows.Forms.TextBox()
        Me.AlternateSelect = New System.Windows.Forms.Button()
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
        Me.steamBox.Size = New System.Drawing.Size(426, 724)
        Me.steamBox.TabIndex = 0
        '
        'playButton
        '
        Me.playButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playButton.Location = New System.Drawing.Point(558, 670)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(289, 74)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'launchSettings
        '
        Me.launchSettings.Location = New System.Drawing.Point(469, 193)
        Me.launchSettings.Name = "launchSettings"
        Me.launchSettings.Size = New System.Drawing.Size(380, 20)
        Me.launchSettings.TabIndex = 2
        '
        'saveSettings
        '
        Me.saveSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveSettings.Location = New System.Drawing.Point(558, 507)
        Me.saveSettings.Name = "saveSettings"
        Me.saveSettings.Size = New System.Drawing.Size(132, 55)
        Me.saveSettings.TabIndex = 3
        Me.saveSettings.Text = "Save"
        Me.saveSettings.UseVisualStyleBackColor = True
        '
        'GameImage
        '
        Me.GameImage.Location = New System.Drawing.Point(469, 12)
        Me.GameImage.Name = "GameImage"
        Me.GameImage.Size = New System.Drawing.Size(380, 112)
        Me.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameImage.TabIndex = 4
        Me.GameImage.TabStop = False
        '
        'ExtraProgram1
        '
        Me.ExtraProgram1.Location = New System.Drawing.Point(469, 283)
        Me.ExtraProgram1.Name = "ExtraProgram1"
        Me.ExtraProgram1.Size = New System.Drawing.Size(297, 20)
        Me.ExtraProgram1.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(469, 243)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(331, 33)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "Programs to start with the game"
        '
        'ExtraSelect1
        '
        Me.ExtraSelect1.Location = New System.Drawing.Point(772, 282)
        Me.ExtraSelect1.Name = "ExtraSelect1"
        Me.ExtraSelect1.Size = New System.Drawing.Size(75, 22)
        Me.ExtraSelect1.TabIndex = 7
        Me.ExtraSelect1.Text = "Select"
        Me.ExtraSelect1.UseVisualStyleBackColor = True
        '
        'ExtraSelect2
        '
        Me.ExtraSelect2.Location = New System.Drawing.Point(772, 309)
        Me.ExtraSelect2.Name = "ExtraSelect2"
        Me.ExtraSelect2.Size = New System.Drawing.Size(75, 22)
        Me.ExtraSelect2.TabIndex = 9
        Me.ExtraSelect2.Text = "Select"
        Me.ExtraSelect2.UseVisualStyleBackColor = True
        '
        'ExtraProgram2
        '
        Me.ExtraProgram2.Location = New System.Drawing.Point(469, 309)
        Me.ExtraProgram2.Name = "ExtraProgram2"
        Me.ExtraProgram2.Size = New System.Drawing.Size(297, 20)
        Me.ExtraProgram2.TabIndex = 8
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Enabled = False
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(469, 154)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(331, 33)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = "Game launch options"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Enabled = False
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(469, 366)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(331, 33)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = "Alternate launch program"
        '
        'Alternate
        '
        Me.Alternate.Location = New System.Drawing.Point(469, 405)
        Me.Alternate.Name = "Alternate"
        Me.Alternate.Size = New System.Drawing.Size(297, 20)
        Me.Alternate.TabIndex = 10
        '
        'AlternateSelect
        '
        Me.AlternateSelect.Location = New System.Drawing.Point(772, 405)
        Me.AlternateSelect.Name = "AlternateSelect"
        Me.AlternateSelect.Size = New System.Drawing.Size(75, 22)
        Me.AlternateSelect.TabIndex = 9
        Me.AlternateSelect.Text = "Select"
        Me.AlternateSelect.UseVisualStyleBackColor = True
        '
        'Steam_Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 769)
        Me.Controls.Add(Me.Alternate)
        Me.Controls.Add(Me.AlternateSelect)
        Me.Controls.Add(Me.ExtraSelect2)
        Me.Controls.Add(Me.ExtraProgram2)
        Me.Controls.Add(Me.ExtraSelect1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ExtraProgram1)
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
    Friend WithEvents ExtraProgram1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ExtraSelect1 As Button
    Friend WithEvents ExtraSelect2 As Button
    Friend WithEvents ExtraProgram2 As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Alternate As TextBox
    Friend WithEvents AlternateSelect As Button
End Class

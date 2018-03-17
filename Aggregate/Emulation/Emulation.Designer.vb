<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emulation
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
        Me.EmulatorList = New System.Windows.Forms.ListBox()
        Me.AddEmu = New System.Windows.Forms.Button()
        Me.RemEmu = New System.Windows.Forms.Button()
        Me.LaunchEmu = New System.Windows.Forms.Button()
        Me.GameList = New System.Windows.Forms.ListBox()
        Me.AddGame = New System.Windows.Forms.Button()
        Me.RemGame = New System.Windows.Forms.Button()
        Me.LaunchGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EmulatorList
        '
        Me.EmulatorList.FormattingEnabled = True
        Me.EmulatorList.Location = New System.Drawing.Point(0, 0)
        Me.EmulatorList.Name = "EmulatorList"
        Me.EmulatorList.Size = New System.Drawing.Size(445, 706)
        Me.EmulatorList.TabIndex = 0
        '
        'AddEmu
        '
        Me.AddEmu.Location = New System.Drawing.Point(12, 712)
        Me.AddEmu.Name = "AddEmu"
        Me.AddEmu.Size = New System.Drawing.Size(95, 37)
        Me.AddEmu.TabIndex = 1
        Me.AddEmu.Text = "Add"
        Me.AddEmu.UseVisualStyleBackColor = True
        '
        'RemEmu
        '
        Me.RemEmu.Location = New System.Drawing.Point(113, 712)
        Me.RemEmu.Name = "RemEmu"
        Me.RemEmu.Size = New System.Drawing.Size(95, 37)
        Me.RemEmu.TabIndex = 1
        Me.RemEmu.Text = "Remove"
        Me.RemEmu.UseVisualStyleBackColor = True
        '
        'LaunchEmu
        '
        Me.LaunchEmu.Location = New System.Drawing.Point(350, 712)
        Me.LaunchEmu.Name = "LaunchEmu"
        Me.LaunchEmu.Size = New System.Drawing.Size(95, 37)
        Me.LaunchEmu.TabIndex = 1
        Me.LaunchEmu.Text = "Start"
        Me.LaunchEmu.UseVisualStyleBackColor = True
        '
        'GameList
        '
        Me.GameList.FormattingEnabled = True
        Me.GameList.Location = New System.Drawing.Point(465, 12)
        Me.GameList.Name = "GameList"
        Me.GameList.Size = New System.Drawing.Size(445, 706)
        Me.GameList.TabIndex = 0
        '
        'AddGame
        '
        Me.AddGame.Location = New System.Drawing.Point(465, 712)
        Me.AddGame.Name = "AddGame"
        Me.AddGame.Size = New System.Drawing.Size(95, 37)
        Me.AddGame.TabIndex = 1
        Me.AddGame.Text = "Add"
        Me.AddGame.UseVisualStyleBackColor = True
        '
        'RemGame
        '
        Me.RemGame.Location = New System.Drawing.Point(566, 712)
        Me.RemGame.Name = "RemGame"
        Me.RemGame.Size = New System.Drawing.Size(95, 37)
        Me.RemGame.TabIndex = 1
        Me.RemGame.Text = "Remove"
        Me.RemGame.UseVisualStyleBackColor = True
        '
        'LaunchGame
        '
        Me.LaunchGame.Location = New System.Drawing.Point(815, 712)
        Me.LaunchGame.Name = "LaunchGame"
        Me.LaunchGame.Size = New System.Drawing.Size(95, 37)
        Me.LaunchGame.TabIndex = 1
        Me.LaunchGame.Text = "Start"
        Me.LaunchGame.UseVisualStyleBackColor = True
        '
        'Emulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 761)
        Me.Controls.Add(Me.LaunchGame)
        Me.Controls.Add(Me.LaunchEmu)
        Me.Controls.Add(Me.RemGame)
        Me.Controls.Add(Me.RemEmu)
        Me.Controls.Add(Me.AddGame)
        Me.Controls.Add(Me.AddEmu)
        Me.Controls.Add(Me.GameList)
        Me.Controls.Add(Me.EmulatorList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Emulation"
        Me.Text = "Emulation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmulatorList As ListBox
    Friend WithEvents AddEmu As Button
    Friend WithEvents RemEmu As Button
    Friend WithEvents LaunchEmu As Button
    Friend WithEvents GameList As ListBox
    Friend WithEvents AddGame As Button
    Friend WithEvents RemGame As Button
    Friend WithEvents LaunchGame As Button
End Class

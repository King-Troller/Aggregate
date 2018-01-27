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
        CType(Me.steam, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 382)
        Me.Controls.Add(Me.steam)
        Me.Name = "Main"
        Me.Text = "Aggregate"
        CType(Me.steam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents steam As PictureBox
End Class

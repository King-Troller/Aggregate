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
        Me.Steam = New System.Windows.Forms.PictureBox()
        CType(Me.Steam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Steam
        '
        Me.Steam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Steam.Image = Global.Aggregate.My.Resources.Resources.steam_logo
        Me.Steam.InitialImage = Nothing
        Me.Steam.Location = New System.Drawing.Point(12, 12)
        Me.Steam.Name = "Steam"
        Me.Steam.Size = New System.Drawing.Size(312, 111)
        Me.Steam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Steam.TabIndex = 0
        Me.Steam.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 543)
        Me.Controls.Add(Me.Steam)
        Me.Name = "Main"
        Me.Text = "Aggregate"
        CType(Me.Steam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Steam As PictureBox
End Class

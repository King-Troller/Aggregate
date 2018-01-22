Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory(settingsFolder)
    End Sub

    Private Sub Steam_Click(sender As Object, e As EventArgs) Handles Steam.Click
        Steam_Scanner.Show()
    End Sub
End Class

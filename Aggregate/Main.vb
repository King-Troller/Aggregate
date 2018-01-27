Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(settingsFolder) = False Then
            My.Computer.FileSystem.CreateDirectory(settingsFolder)
        End If

    End Sub

    Private Sub Steam_Click(sender As Object, e As EventArgs) Handles Steam.Click
        Steam_Scanner.Show()
    End Sub
End Class

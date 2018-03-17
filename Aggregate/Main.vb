Public Class Main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(settingsFolder) = False Then
            My.Computer.FileSystem.CreateDirectory(settingsFolder)
        End If

    End Sub

    Private Sub Steam_Click(sender As Object, e As EventArgs) Handles Steam.Click
        Steam_Scanner.Show()
    End Sub

    Private Sub Emulators_Click(sender As Object, e As EventArgs) Handles Emulators.Click
        Emulation.Show()
    End Sub

    Private Sub Blizzard_Click(sender As Object, e As EventArgs) Handles Blizzard.Click
        Dim BattlenetPath As String = BlizzardFinder()
        If BattlenetPath IsNot Nothing Then
            Process.Start(BattlenetPath)
        End If
    End Sub
End Class

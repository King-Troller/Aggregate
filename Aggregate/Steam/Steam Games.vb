
Imports System.Text.RegularExpressions

Public Class Steam_Games

    Dim gameIndex As String
    Private Sub Steam_Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        steamBox.Items.Clear()
        steamBox.Items.AddRange(gamelist.ToArray)
    End Sub

    Private Sub steamBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles steamBox.SelectedIndexChanged
        Dim i As Integer = 0
        For Each entry In gamelist

            If Regex.IsMatch(entry, "\b" + Regex.Escape(steamBox.SelectedItem) + "\b") Then
                Dim count As Integer = steamBox.SelectedItem.Length
                If entry.length - count = 0 Then
                    gameIndex = idlist(i)
                Else
                End If

            Else
            End If
            i = i + 1
        Next entry

    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        Process.Start("steam://rungameid/" & gameIndex)
    End Sub
End Class
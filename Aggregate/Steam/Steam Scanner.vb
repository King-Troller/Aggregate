Public Class Steam_Scanner

    Private Sub Steam_Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the alignment of the text that follows.
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        ' Set the font for the text.
        RichTextBox1.SelectionFont = New Font("Lucinda Console", 16)
        ' Set the text within the control.
        RichTextBox1.SelectedText = "Please wait while your Steam games are found"

        Call SteamFiles.SteamFiles()

        Steam_Games.Show()
        Me.Close()
    End Sub

End Class
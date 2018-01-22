
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.IO

Public Class Steam_Games

    Dim gameIndex As String
    Dim spacelessName As String
    Private Sub Steam_Games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        steamBox.Items.Clear()
        steamBox.Items.AddRange(gamelist.ToArray)
    End Sub

    Private Sub SteamBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles steamBox.SelectedIndexChanged
        Dim i As Integer = 0
        For Each entry In gamelist
            'Loop through the list of games until the correct one is found and retrieve the correct number to launch the game
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

        'Display the correct launch options for selected game

        spacelessName = steamBox.SelectedItem.Replace(" ", "")
        launchSettings.Text = ""
        Dim settingsXml As New XmlDocument
        settingsXml.Load(settingsFolder & "\steamsettings.xml")
        Dim childNodes As XmlNodeList = settingsXml.GetElementsByTagName(spacelessName)
        Dim nodeTxt As String = ""
        For Each child As XmlNode In childNodes
            nodeTxt = child.InnerText
            launchSettings.Text = nodeTxt
        Next child

        'Load the images from the steam servers
        Dim imageLocation As String = settingsFolder & "\" & spacelessName & ".jpg"
        If File.Exists(imageLocation) = False Then
            My.Computer.Network.DownloadFile("http://cdn.akamai.steamstatic.com/steam/apps/" & gameIndex & "/header.jpg", imageLocation)
            GameImage.Image = Image.FromFile(imageLocation)
        Else
            GameImage.Image = Image.FromFile(imageLocation)
        End If

    End Sub

    'Start the game when button is pressed
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        Process.Start("steam://rungameid/" & gameIndex & " " & launchSettings.Text)
    End Sub

    'Save launch options on button press
    Private Sub SaveSettings_Click(sender As Object, e As EventArgs) Handles saveSettings.Click
        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.Load(settingsFolder & "\steamsettings.xml")

        Dim newNode = spacelessName
        With xmlDoc.SelectSingleNode("/GameOptions").CreateNavigator().AppendChild()
            .WriteElementString(spacelessName, launchSettings.Text)
            .Close()
        End With
        xmlDoc.Save(settingsFolder & "\steamsettings.xml")
    End Sub
End Class
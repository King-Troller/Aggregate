
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.IO
Imports System.Net

Public Class Steam_Games

    Dim gameIndex As String
    Dim spacelessName As String

    Private Sub Steam_Games_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        If finalList Is Nothing Then
            finalList = gamelist.ToArray
        End If
        steamBox.Items.AddRange(finalList)
        steamBox.Sorted = True
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
        ExtraProgram1.Text = ""
        ExtraProgram2.Text = ""
        Alternate.Text = ""
        Dim settingsXml As New XmlDocument
        settingsXml.Load(settingsFolder & "\steamsettings.xml")
        Dim childNodes As XmlNodeList = settingsXml.GetElementsByTagName(spacelessName)
        Dim nodeTxt As String = ""

        Dim root As XmlNode = childNodes(0)
        If root IsNot Nothing Then
            If root.HasChildNodes Then
                Dim cycle As Integer
                For cycle = 0 To root.ChildNodes.Count - 1
                    Dim chosenValue As String = root.ChildNodes(cycle).InnerText
                    If cycle = 0 Then
                        launchSettings.Text = chosenValue
                    ElseIf cycle = 1 Then
                        ExtraProgram1.Text = chosenValue
                    ElseIf cycle = 2 Then
                        ExtraProgram2.Text = chosenValue
                    Else
                        Alternate.Text = chosenValue
                    End If
                Next cycle
            Else
            End If
        End If


        'Load the images from the steam servers/cache folder
        Dim imageLocation As String = settingsFolder & "\imagecache\" & spacelessName & ".jpg"
        If File.Exists(imageLocation) = True Then
            GameImage.Image = Image.FromFile(imageLocation)
        Else
            If CheckURL("http://cdn.akamai.steamstatic.com/steam/apps/" & gameIndex & "/header.jpg") = True Then
                My.Computer.Network.DownloadFile("http://cdn.akamai.steamstatic.com/steam/apps/" & gameIndex & "/header.jpg", imageLocation)
                GameImage.Image = Image.FromFile(imageLocation)
            Else
                GameImage.Image = My.Resources.customresources.noimage
            End If

        End If

    End Sub

    'Start the game when button is pressed
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles playButton.Click

        If Alternate.Text = "" Then
            Process.Start("steam://rungameid/" & gameIndex & " " & launchSettings.Text)
        Else
            Process.Start(Alternate.Text & " " & launchSettings.Text)
        End If
        If ExtraProgram1 IsNot Nothing Then
            If File.Exists(ExtraProgram1.Text) Then
                Process.Start(ExtraProgram1.Text)
            End If
        End If
        If ExtraProgram2 IsNot Nothing Then
            If File.Exists(ExtraProgram2.Text) Then
                Process.Start(ExtraProgram2.Text)
            End If
        End If
    End Sub

    'Save launch options on button press
    Private Sub SaveSettings_Click(sender As Object, e As EventArgs) Handles saveSettings.Click
        Dim xmlDoc As XmlDocument = New XmlDocument()
        xmlDoc.Load(settingsFolder & "\steamsettings.xml")
        Dim objTest As XmlElement
        objTest = xmlDoc.SelectSingleNode("/GameOptions/" & spacelessName)
        If objTest Is Nothing Then

            Dim newNode = spacelessName
            With xmlDoc.SelectSingleNode("/GameOptions").CreateNavigator().AppendChild()
                .WriteStartElement(spacelessName)
                .WriteElementString("LaunchOptions", launchSettings.Text)
                .WriteElementString("ExtraProgram1", ExtraProgram1.Text)
                .WriteElementString("ExtraProgram2", ExtraProgram2.Text)
                .WriteElementString("Alternate", Alternate.Text)
                .WriteEndElement()
                .Close()
            End With
        Else
            Dim replaceNode As XmlNode = xmlDoc.SelectSingleNode("/GameOptions/" & spacelessName)
            If replaceNode IsNot Nothing Then
                replaceNode.ChildNodes(0).InnerText = launchSettings.Text
                replaceNode.ChildNodes(1).InnerText = ExtraProgram1.Text
                replaceNode.ChildNodes(2).InnerText = ExtraProgram2.Text
                replaceNode.ChildNodes(3).InnerText = Alternate.Text
            End If
        End If

        xmlDoc.Save(settingsFolder & "\steamsettings.xml")
    End Sub

    'Allow user to select extra programs
    Private Sub ExtraSelect1_Click(sender As Object, e As EventArgs) Handles ExtraSelect1.Click
        Dim selectedFile As OpenFileDialog = New OpenFileDialog()
        Dim fileName As String

        selectedFile.Title = "Select program"
        selectedFile.InitialDirectory = settingsFolder
        selectedFile.RestoreDirectory = True
        If selectedFile.ShowDialog() = DialogResult.OK Then
            fileName = selectedFile.FileName
            ExtraProgram1.Text = fileName
        End If

    End Sub

    Private Sub ExtraSelect2_Click(sender As Object, e As EventArgs) Handles ExtraSelect2.Click
        Dim selectedFile As OpenFileDialog = New OpenFileDialog()
        Dim fileName As String

        selectedFile.Title = "Select program"
        selectedFile.InitialDirectory = settingsFolder
        selectedFile.RestoreDirectory = True
        If selectedFile.ShowDialog() = DialogResult.OK Then
            fileName = selectedFile.FileName
            ExtraProgram2.Text = fileName
        End If
    End Sub

    'Allows user to choose alternative target to launch (eg. Nexus MM, Mod Organizer, etc)
    Private Sub AlternateSelect_Click(sender As Object, e As EventArgs) Handles AlternateSelect.Click
        Dim selectedFile As OpenFileDialog = New OpenFileDialog()
        Dim fileName As String

        selectedFile.Title = "Select program"
        selectedFile.InitialDirectory = settingsFolder
        selectedFile.RestoreDirectory = True
        If selectedFile.ShowDialog() = DialogResult.OK Then
            fileName = selectedFile.FileName
            Alternate.Text = fileName
        End If
    End Sub

End Class
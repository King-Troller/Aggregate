Module GlobalVal

    Public userFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Public settingsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Aggregate"

    Public finalList As Array

    'Check if a URL is online. Returns Boolean
    Public Function CheckURL(ByVal urltocheck As String)
        Dim url As New System.Uri(urltocheck)
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    'Function to return the path of the Battle.net launcher if it's installed
    Public Function BlizzardFinder()
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Blizzard Entertainment\Battle.net\Capabilities") Is Nothing Then
            MsgBox("Battle.net installation not found")
            Return Nothing
        Else
            Dim regkey As Object = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Blizzard Entertainment\Battle.net\Capabilities", True).GetValue("ApplicationIcon")
            If regkey Is Nothing Then
                MsgBox("Battle.net installation not found")
                Return Nothing
            Else
                Dim location As String = regkey.ToString
                location = location.Substring(1, location.Length - 4)
                Return location
            End If
        End If
    End Function
End Module

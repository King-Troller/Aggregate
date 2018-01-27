Module GlobalVal

    Public userFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
    Public settingsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Aggregate"

    Public finalList As Array

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
End Module

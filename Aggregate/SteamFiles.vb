Imports System.IO
Imports System.Text.RegularExpressions

Module SteamFiles

    Dim steamPath As String = My.Computer.Registry.GetValue(
            "HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
    Dim steamLibraryFolderVdf As String() = File.ReadAllLines(steamPath & "\steamapps\libraryfolders.vdf")
    Dim vdfLineCount As Int16 = File.ReadAllLines(steamPath & "\steamapps\libraryfolders.vdf").Length

    Dim Lib1 As String = steamPath & "\steamapps\"
    Dim Lib2 As String
    Dim Lib3 As String
    Dim Lib4 As String
    Dim twoE As Boolean = False
    Dim threeE As Boolean = False
    Dim fourE As Boolean = False

    'Create array to store games
    Public gamelist As New ArrayList
    Public idlist As New ArrayList

    Public Sub SteamFiles()
        'Finding any additional steam library folders
        If vdfLineCount > 5 Then
            Lib2 = steamLibraryFolderVdf(4).Trim
            Lib2 = Lib2.Remove(0, 6)
            Lib2 = Lib2.Remove(3, 1)
            Lib2 = Lib2.Remove(Lib2.Length - 1)
            Lib2 = Lib2 & "\steamapps\"

            twoE = True
        Else
        End If

        If vdfLineCount > 6 Then
            Lib3 = steamLibraryFolderVdf(5).Trim
            Lib3 = Lib3.Remove(0, 6)
            Lib3 = Lib3.Remove(3, 1)
            Lib3 = Lib3.Remove(Lib3.Length - 1)
            Lib3 = Lib3 & "\steamapps\"
            threeE = True
        Else
        End If

        If vdfLineCount > 7 Then
            Lib4 = steamLibraryFolderVdf(6).Trim
            Lib4 = Lib4.Remove(0, 6)
            Lib4 = Lib4.Remove(3, 1)
            Lib4 = Lib4.Remove(Lib4.Length - 1)
            Lib4 = Lib4 & "\steamapps\"
            fourE = True
        Else
        End If

        'Locate each individual game from the manifests in the steamapps folder

        Dim library As New DirectoryInfo(Lib1)
        Dim manifests As FileInfo() = library.GetFiles("*.acf")
        Dim manifestlist As FileInfo
        For Each manifestlist In manifests
            Dim temptext As String() = File.ReadAllLines(Lib1 & manifestlist.Name)
            Dim appId As String = temptext(2).Trim
            Dim name As String = temptext(4).Trim
            appId = appId.Remove(0, 10)
            appId = appId.Remove(appId.Length - 1)
            name = name.Remove(0, 9)
            name = name.Remove(name.Length - 1)
            name = name.Trim
            appId = appId.Trim
            name = Regex.Replace(name, "[^A-Za-z0-9\-/\s']", "")
            appId = Regex.Replace(appId, "[^A-Za-z0-9\-/\s']", "")
            gamelist.Add(name)
            idlist.Add(appId)
        Next manifestlist

        If twoE = True Then
            Dim library2 As New DirectoryInfo(Lib2)
            Dim manifests2 As FileInfo() = library2.GetFiles("*.acf")
            Dim manifestlist2 As FileInfo
            For Each manifestlist2 In manifests2
                Dim temptext2 As String() = File.ReadAllLines(Lib2 & manifestlist2.Name)
                Dim appId As String = temptext2(2).Trim
                Dim name As String = temptext2(4).Trim
                appId = appId.Remove(0, 10)
                appId = appId.Remove(appId.Length - 1)
                name = name.Remove(0, 9)
                name = name.Remove(name.Length - 1)
                name = name.Trim
                appId = appId.Trim
                name = Regex.Replace(name, "[^A-Za-z0-9\-/\s']", "")
                appId = Regex.Replace(appId, "[^A-Za-z0-9\-/\s']", "")
                gamelist.Add(name)
                idlist.Add(appId)
            Next manifestlist2

        End If

        If threeE = True Then
            Dim library3 As New DirectoryInfo(Lib3)
            Dim manifests3 As FileInfo() = library3.GetFiles("*.acf")
            Dim manifestlist3 As FileInfo
            For Each manifestlist3 In manifests3
                Dim temptext3 As String() = File.ReadAllLines(Lib3 & manifestlist3.Name)
                Dim appId As String = temptext3(2).Trim
                Dim name As String = temptext3(4).Trim
                appId = appId.Remove(0, 10)
                appId = appId.Remove(appId.Length - 1)
                name = name.Remove(0, 9)
                name = name.Remove(name.Length - 1)
                name = name.Trim
                appId = appId.Trim
                name = Regex.Replace(name, "[^A-Za-z0-9\-/\s']", "")
                appId = Regex.Replace(appId, "[^A-Za-z0-9\-/\s']", "")
                gamelist.Add(name)
                idlist.Add(appId)
            Next manifestlist3

        End If

        If fourE = True Then
            Dim library4 As New DirectoryInfo(Lib4)
            Dim manifests4 As FileInfo() = library4.GetFiles("*.acf")
            Dim manifestlist4 As FileInfo
            For Each manifestlist4 In manifests4
                Dim temptext4 As String() = File.ReadAllLines(Lib4 & manifestlist4.Name)
                Dim appId As String = temptext4(2).Trim
                Dim name As String = temptext4(4).Trim
                appId = appId.Remove(0, 10)
                appId = appId.Remove(appId.Length - 1)
                name = name.Remove(0, 9)
                name = name.Remove(name.Length - 1)
                name = name.Trim
                appId = appId.Trim
                name = Regex.Replace(name, "[^A-Za-z0-9\-/\s']", "")
                appId = Regex.Replace(appId, "[^A-Za-z0-9\-/\s']", "")
                gamelist.Add(name)
                idlist.Add(appId)
            Next manifestlist4
        End If
    End Sub
End Module

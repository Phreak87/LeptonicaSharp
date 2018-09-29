Partial Public Class Natives
    Public Shared Sub Initialize()
        If My.Computer.FileSystem.FileExists(DllPath) = True Then Exit Sub

        Console.WriteLine("Leptonica.dll missing - Copy from nuget path if exists")
        Dim NugetP As String = Environment.CurrentDirectory
        Do Until My.Computer.FileSystem.DirectoryExists(NugetP & "\Packages")
            If NugetP.Length = 3 Then
                MsgBox("Leptonica Library not found! Based on your configuration copy the Leptonica Dll-File(s) for your application folder.")
                Exit Sub
            End If : NugetP = My.Computer.FileSystem.GetParentPath(NugetP)
        Loop

        If Not IsNothing(NugetP) Then
            NugetP = NugetP & "\Packages"
            For Each Folder In My.Computer.FileSystem.GetDirectories(NugetP)
                If Folder.ToLower.Contains("leptonica") Then
                    If My.Computer.FileSystem.FileExists(Folder & "\build\x86\" & DllPath) Then
                        My.Computer.FileSystem.CopyFile(Folder & "\build\x86\" & DllPath, Environment.CurrentDirectory & "\" & DllPath)
                        Console.WriteLine("Restored file from Nuget-Package")
                    End If
                End If
            Next
        Else
            MsgBox("Please copy the Leptonica-1.77.0.dll manually to your bin folder")
        End If

    End Sub
End Class

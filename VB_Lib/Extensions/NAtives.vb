Partial Public Class Natives
    Private Shared Sub CopyNuget()
        ' Suche den Pfad der Nuget-Pakete
        Dim NugetP As String = Environment.CurrentDirectory
        Do Until My.Computer.FileSystem.DirectoryExists(NugetP & "\Packages")
            If NugetP.Length = 3 Then Console.WriteLine("No Package found") : Exit Sub
            NugetP = My.Computer.FileSystem.GetParentPath(NugetP)
        Loop

        If Not IsNothing(NugetP) Then
            NugetP = NugetP & "\Packages"
            For Each Folder In My.Computer.FileSystem.GetDirectories(NugetP)
                If Folder.ToLower.Contains("leptonica") Then
                    If My.Computer.FileSystem.DirectoryExists("Lib") Then
                        My.Computer.FileSystem.CopyDirectory(Folder & "\Lib", Environment.CurrentDirectory & "\Lib")
                        Console.WriteLine("Restored file from Nuget-Package")
                    End If
                End If
            Next
        Else
            MsgBox("Please copy the Leptonica-1.77.0.dll manually to your bin folder")
        End If
    End Sub
    Private Shared Sub CopyFiles()
        If IntPtr.Size = 4 Then
            Console.WriteLine("Init " & DllPath & " for X86")
            My.Computer.FileSystem.CopyFile("Lib\X86\" & DllPath, DllPath, True)
        Else
            Console.WriteLine("Init " & DllPath & " for X64")
            My.Computer.FileSystem.CopyFile("Lib\X64\" & DllPath, DllPath, True)
        End If
    End Sub
    Public Shared Sub Initialize()
        CopyNuget()
        CopyFiles()
    End Sub
End Class

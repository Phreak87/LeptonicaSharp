Imports System.Runtime.InteropServices

Partial Public Class Natives
    <DllImport("shlwapi.dll", CharSet:=CharSet.Unicode, SetLastError:=False, EntryPoint:="PathFindOnPath")>
    Friend Shared Function PathFindOnPath(
        ByVal pszFile As System.Text.StringBuilder,
        ByVal ppszOtherDirs As String()) As Boolean
    End Function

    Private Shared Sub CopyNuget()
        Console.WriteLine("Leptonica.dll missing - Copy from Nuget Package")

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
    Const MAX_PATH = 260

    Public Shared Function GetFullPathFromWindows(ByVal exeName As String) As String
        If exeName.Length > MAX_PATH Then
            Throw New ArgumentException("The exe name is longer than Max Path")
        End If
        Dim sb As Text.StringBuilder = New Text.StringBuilder(exeName, MAX_PATH)
        Dim retStr = If(Natives.PathFindOnPath(sb, Nothing) = True, sb.ToString(), Nothing)
        Return retStr
    End Function
End Class

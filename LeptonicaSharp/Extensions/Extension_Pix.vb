Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Reflection
Imports System.Drawing.Imaging

Partial Public Class Pix
#Region "Redirects"
    'ReadOnly Property Data32_First100B As List(Of Byte())
    '    Get
    '        If d <> 32 Then Return Nothing
    '        Dim Sep4 As New List(Of Byte())
    '        For i As Integer = 0 To data.Count - 1 Step 4
    '            Dim B(3) As Byte : Array.Copy(data, i, B, 0, B.Length)
    '            Sep4.Add(B) : If i > 100 Then Exit For
    '        Next
    '        Return Sep4
    '    End Get
    'End Property
    'ReadOnly Property Data24_First100B As List(Of Byte())
    '    Get
    '        If d <> 24 Then Return Nothing
    '        Dim Sep3 As New List(Of Byte())
    '        For i As Integer = 0 To data.Count - 1 Step 3
    '            Dim B(2) As Byte : Array.Copy(data, i, B, 0, B.Length)
    '            Sep3.Add(B) : If i > 100 Then Exit For
    '        Next
    '        Return Sep3
    '    End Get
    'End Property
    'ReadOnly Property Data16_First100B As List(Of Byte())
    '    Get
    '        If d <> 16 Then Return Nothing
    '        Dim Sep2 As New List(Of Byte())
    '        For i As Integer = 0 To data.Count - 1 Step 2
    '            Dim B(1) As Byte : Array.Copy(data, i, B, 0, B.Length)
    '            Sep2.Add(B) : If i > 100 Then Exit For
    '        Next
    '        Return Sep2
    '    End Get
    'End Property
    ReadOnly Property Bitmap As Bitmap
        Get
            Dim BMP = Me.ToBitmap
            Dim TIM As New Timers.Timer(5000)
            AddHandler TIM.Elapsed, Sub() BMP.Dispose()
            TIM.Start()
            Return BMP
        End Get
    End Property


#Region "Konstruktoren"
    Sub New(w As Integer, h As Integer)
        Dim OBJ = LeptonicaSharp._All.pixCreate(w, h, 32)
        Pointer = OBJ.Pointer
    End Sub
    Sub New(ByVal Bitmap As Bitmap)
        Dim Stream As New System.IO.MemoryStream : Bitmap.Save(Stream, Imaging.ImageFormat.Bmp)
        Dim OBJ = _All.pixReadMemBmp(Stream.GetBuffer, Stream.Length)
        Pointer = OBJ.Pointer
    End Sub
#End Region

#Region "Speichern"
    Public Sub save_jpg(ByVal filename As String, Optional ByVal quality As Integer = 95, Optional ByVal progressive As Integer = 0)
        LeptonicaSharp.Natives.pixWriteJpeg(filename, Pointer, quality, progressive)
    End Sub
    Public Sub save_png(ByVal filename As String, Optional ByVal gamma As Single = 95, Optional ByVal progressive As Integer = 0)
        LeptonicaSharp.Natives.pixWritePng(filename, Pointer, gamma)
    End Sub
    Public Sub save_tiff(ByVal filename As String)
        LeptonicaSharp.Natives.pixWriteTiff(filename, Pointer, LeptonicaSharp.Enumerations.IFF.IFF_TIFF, "a")
    End Sub
    Public Function save_format(ByVal filename As String, ByVal format As LeptonicaSharp.Enumerations.IFF) As Boolean
        Return LeptonicaSharp.Natives.pixWrite(filename, Pointer, format)
    End Function
    Public Function save_autoformat(ByVal filename As String, ByVal format As LeptonicaSharp.Enumerations.IFF) As Boolean
        Return LeptonicaSharp.Natives.pixWriteAutoFormat(filename, Pointer)
    End Function
#End Region
#End Region

#Region "Functions"
    Sub Display(Optional Text As String = "")
        Dim n As New ShowPix(Me, Text)
    End Sub
    Public Function ToBitmap() As Image
        Dim Size As Integer = 0
        Dim Bytes As Byte() = Nothing
        Dim PixU As Pix = Me

        If Me.d = 1 Then PixU = Me.pixConvertTo16
        _All.pixWriteMemBmp(Bytes, Size, Me)
        Dim MemStrm As New IO.MemoryStream(Bytes)
        Return New Bitmap(MemStrm, True)
    End Function
#End Region
End Class

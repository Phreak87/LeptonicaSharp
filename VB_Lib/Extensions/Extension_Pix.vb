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
    ReadOnly Property DataStatic As Byte()
        Get
            If Pointer = IntPtr.Zero Then Return Nothing
            If Caching.ContainsKey("Data1") Then Return Caching("Data1")
            Caching.Add("Data1", Me.data) : Return Caching("Data1")
        End Get
    End Property
    ReadOnly Property Bitmap As Bitmap
        Get
            If Pointer = IntPtr.Zero Then Return Nothing
            If Caching.ContainsKey("Bitmap") Then Caching("Bitmap").dispose() : Caching.Remove("Bitmap")
            Caching.Add("Bitmap", Me.ToBitmap) : Return Caching("Bitmap")
        End Get
    End Property
#Region "Constructors"
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

#Region "Saving"
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

    Public Function Convert() As Bitmap
        Dim pixelFormat As PixelFormat = GetPixelFormat(Me)
        Dim depth As Integer = Me.d
        Dim img As Bitmap = New Bitmap(Me.w, Me.h, pixelFormat)
        Dim imgData As BitmapData = Nothing
        Dim pixNew As Pix = Nothing

        'Don't swap channels on 24bpp, which in Leptonica is d=32, spp=3
        If (Me.d = 32 And Me.spp = 4) Or (Me.d = 8) Or (Me.d = 1) Then
            pixNew = _All.pixEndianByteSwapNew(Me)
        Else
            pixNew = Me
        End If

        Try
            Dim flag As Boolean = (pixelFormat And PixelFormat.Indexed) = PixelFormat.Indexed

            If flag Then
                TransferPalette(pixNew, img)
            End If

            imgData = img.LockBits(New Rectangle(0, 0, img.Width, img.Height), ImageLockMode.[WriteOnly], pixelFormat)

            If depth = 32 Then
                TransferData32(pixNew, imgData)
                'ElseIf depth = 16 Then
                '    TransferData16(pix, imgData)
            ElseIf depth = 8 Then
                TransferData8(pixNew, imgData)
            ElseIf depth = 1 Then
                TransferData1(pixNew, imgData)
            End If

            If pixNew.xres > 0 AndAlso pixNew.yres > 0 Then img.SetResolution(pixNew.xres, pixNew.yres)
            Return img
        Catch __unusedException1__ As Exception
            img.Dispose()
            Throw
        Finally

            If imgData IsNot Nothing Then
                img.UnlockBits(imgData)
            End If
        End Try
    End Function
    Private Shared Sub TransferData32(pix As Pix, imgData As BitmapData)
        Dim height As Integer = imgData.Height
        Dim width As Integer = imgData.Width
        Dim pixData As IntPtr = pix.Values.data
        Dim stride As Integer = pix.wpl * 4
        Dim curBytes() As Byte = {0, 0, 0, 0}
        Dim pixelIndex As Integer = 0
        Dim bytesPerPixel As Integer = 4
        Dim alphaMask As Integer = 0
        'This works
        'For y = 0 To height - 1
        '    For x = 0 To width - 1
        '        pixelIndex = (y * stride) + (x * bytesPerPixel)
        '        curBytes(0) = Marshal.ReadByte(pixData, pixelIndex)     'B
        '        curBytes(1) = Marshal.ReadByte(pixData, pixelIndex + 1) 'G
        '        curBytes(2) = Marshal.ReadByte(pixData, pixelIndex + 2) 'R
        '        curBytes(3) = Marshal.ReadByte(pixData, pixelIndex + 3) 'A
        '        Marshal.WriteByte(imgData.Scan0, pixelIndex, curBytes(0))
        '        Marshal.WriteByte(imgData.Scan0, pixelIndex + 1, curBytes(1))
        '        Marshal.WriteByte(imgData.Scan0, pixelIndex + 2, curBytes(2))
        '        Marshal.WriteByte(imgData.Scan0, pixelIndex + 3, curBytes(3))
        '    Next
        'Next
        Threading.Tasks.Parallel.For(0, height, Sub(y)
                                                    For x As Integer = 0 To width
                                                        Dim valB As Integer = Marshal.ReadByte(pixData, (stride * y) + (x * bytesPerPixel))
                                                        Dim valG As Integer = Marshal.ReadByte(pixData, (stride * y) + (x * bytesPerPixel) + 1)
                                                        Dim valR As Integer = Marshal.ReadByte(pixData, (stride * y) + (x * bytesPerPixel) + 2)
                                                        Dim valA As Integer = Marshal.ReadByte(pixData, (stride * y) + (x * bytesPerPixel) + 3)
                                                        Marshal.WriteByte(imgData.Scan0, (stride * y) + (x * bytesPerPixel), CType(valB, Byte))
                                                        Marshal.WriteByte(imgData.Scan0, (stride * y) + (x * bytesPerPixel) + 1, CType(valG, Byte))
                                                        Marshal.WriteByte(imgData.Scan0, (stride * y) + (x * bytesPerPixel) + 2, CType(valR, Byte))
                                                        Marshal.WriteByte(imgData.Scan0, (stride * y) + (x * bytesPerPixel) + 3, CType(valA, Byte))
                                                    Next
                                                End Sub)
    End Sub
    Private Shared Sub TransferData8(pix As Pix, imgData As BitmapData)
        Dim height As Integer = imgData.Height
        Dim width As Integer = imgData.Width
        Dim pixData As IntPtr = pix.Values.data
        Dim stride As Integer = pix.wpl * 4
        Dim curByte As Byte = 0
        Dim pixelIndex As Integer = 0
        Dim bytesPerPixel As Integer = 1
        'This works
        'For y = 0 To height - 1
        '    For x = 0 To width - 1
        '        pixelIndex = (y * stride) + (x * bytesPerPixel)
        '        curByte = Marshal.ReadByte(pixData, pixelIndex)
        '        Marshal.WriteByte(imgData.Scan0, pixelIndex, curByte)
        '    Next
        'Next
        Threading.Tasks.Parallel.For(0, height, Sub(y)
                                                    For x As Integer = 0 To width
                                                        Dim val As Integer = Marshal.ReadByte(pixData, (stride * y) + (x * bytesPerPixel))
                                                        Marshal.WriteByte(imgData.Scan0, (stride * y) + (x * bytesPerPixel), CType(val, Byte))
                                                    Next
                                                End Sub)
    End Sub
    Private Shared Sub TransferData1(pix As Pix, imgData As BitmapData)
        Dim height As Integer = imgData.Height
        Dim width As Integer = imgData.Width
        Dim pixData As IntPtr = pix.Values.data
        Dim stride As Integer = pix.wpl * 4
        Dim bytesPerPixel As Integer = 1
        Dim outByte As Byte = 0
        For y = 0 To height - 1
            For x = 0 To width - 1 Step 8
                Dim index As Integer = (y * stride) + (x >> 3)
                Dim curPixel As Byte = 255 - Marshal.ReadByte(pix.Values.data, index)
                Marshal.WriteByte(imgData.Scan0, index, curPixel)
            Next
        Next
    End Sub
    Private Shared Sub TransferPalette(pix As Pix, img As Bitmap)
        Dim pallete As ColorPalette = img.Palette
        Dim maxColors As Integer = pallete.Entries.Length
        Dim lastColor As Integer = maxColors - 1
        Dim colormap As PixColormap = _All.pixGetColormap(pix)
        Dim flag As Boolean = colormap IsNot Nothing AndAlso _All.pixcmapGetCount(colormap) <= maxColors
        If flag Then
            Dim colormapCount As Integer = _All.pixcmapGetCount(colormap)
            For i As Integer = 0 To colormapCount - 1
                pallete.Entries(i) = colormap.Array_Color(i)
            Next
        Else
            For j As Integer = 0 To maxColors - 1
                Dim value As Byte = CByte((j * 255 / lastColor))
                pallete.Entries(j) = Color.FromArgb(CInt(value), CInt(value), CInt(value))
            Next
        End If
        img.Palette = pallete
    End Sub
    Private Shared Function GetPixelFormat(pix As Pix) As PixelFormat
        Dim depth As Integer
        If (pix.d = 32 And pix.spp = 4) Then
            depth = 32
        ElseIf (pix.d = 32 And pix.spp = 3) Then
            depth = 24
        Else
            depth = pix.d
        End If

        If depth = 1 Then
            Return PixelFormat.Format1bppIndexed
        End If
        If depth = 8 Then
            Return PixelFormat.Format8bppIndexed
        End If
        If depth = 16 Then
            Return PixelFormat.Format16bppGrayScale
        End If
        If depth = 24 Then
            Return PixelFormat.Format32bppRgb
        End If
        If depth = 32 Then
            Return PixelFormat.Format32bppArgb
        End If
        Throw New InvalidOperationException(String.Format("Pix depth {0} is not supported.", pix.d))
    End Function
#End Region
End Class

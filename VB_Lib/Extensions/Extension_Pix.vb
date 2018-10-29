Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Reflection
Imports System.Drawing.Imaging

Partial Public Class Pix
#Region "Redirects"
    ''' <summary>
    ''' This Property returns a cached value of the data array 
    ''' for iterating. 
    ''' </summary>
    ReadOnly Property DataStatic As Byte()
        Get
            If Pointer = IntPtr.Zero Then Return Nothing
            If Caching.ContainsKey("Data1") Then Return Caching("Data1")
            Caching.Add("Data1", Me.data) : Return Caching("Data1")
        End Get
    End Property

    ''' <summary>
    ''' This Property returns a pix as a system-bitmap
    ''' this value is cached. For Bitmaps from Pointer
    ''' use the ToBitmap-Function.
    ''' </summary>
    ReadOnly Property BitmapStatic As Bitmap
        Get
            If Pointer = IntPtr.Zero Then Return Nothing
            If Caching.ContainsKey("Bitmap") Then Caching("Bitmap").dispose() : Caching.Remove("Bitmap")
            Caching.Add("Bitmap", Me.ToBitmap) : Return Caching("Bitmap")
        End Get
    End Property

#Region "Constructors"
    ''' <summary>
    ''' Use this for Construct a empty Pix (to be filled ByRef)
    ''' </summary>
    Sub New()
    End Sub
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
    Public Function save_autoformat(ByVal filename As String) As Boolean
        Return LeptonicaSharp.Natives.pixWriteAutoFormat(filename, Pointer)
    End Function
#End Region
#End Region

#Region "Functions"
    Sub RefreshStatic()
        For Each Entry In Caching
            Try : Entry.Value.dispose() : Catch : End Try
        Next : Caching.Clear()
    End Sub
    Sub Display(Optional ByVal Text As String = "")
        Dim n As New ShowPix(Me, Text)
    End Sub
    Public Function ToBitmap() As Image
        Dim Size As Integer = 0
        Dim Bytes As Byte() = Nothing

        If Me.d = 1 Then Return ConvertTo1BPPBMP(Me)
        _All.pixWriteMemBmp(Bytes, Size, IIf(Me.d = 24, Me.pixConvertTo32, Me))
        Dim MemStrm As New IO.MemoryStream(Bytes)
        Return New Bitmap(MemStrm, True)
    End Function
    Public Function ConvertTo1BPPBMP(ByVal Pix As Pix) As Bitmap
        Dim pixelFormat As PixelFormat = pixelFormat.Format1bppIndexed
        Dim img As Bitmap = New Bitmap(Pix.w, Pix.h, pixelFormat)
        Using pixNew As Pix = _All.pixEndianByteSwapNew(Pix)
            Try
                Dim imgData As BitmapData = img.LockBits(New Rectangle(0, 0, img.Width, img.Height), 2, pixelFormat)
                For y = 0 To imgData.Height - 1
                    For x = 0 To imgData.Width - 1 Step 8
                        Dim index As Integer = (y * pixNew.wpl * 4) + (x >> 3)
                        If index > pixNew.DataStatic.Count - 1 Then Continue For
                        Marshal.WriteByte(imgData.Scan0, index, Not pixNew.DataStatic(index))
                    Next
                Next : img.UnlockBits(imgData) : Return img
            Catch ex As Exception
                img.Dispose()
            End Try
        End Using
        Return Nothing
    End Function
#End Region
End Class
Partial Public Class Pixa
    Sub display(w As Integer, h As Integer)
        Dim pixc = LeptonicaSharp._All.pixaDisplayRandomCmap(Me, w, h)
        pixc.pixInvert.Display()
    End Sub
End Class
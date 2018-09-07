Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging

Partial Public Class Pix

#Region "Redirects"
    Sub New(ByVal filename As String)
        Me.new(LeptonicaSharp.Natives.pixRead(filename))
    End Sub
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

#Region "Functions"
    Sub Display()
        Dim n As New ShowPix(Me)
        n.ShowDialog()
    End Sub
    Sub New(ByVal Bitmap As Bitmap)
        ' Funktioniert nur teilweise > Überarbeiten
        Me.New(LeptonicaSharp.Natives.pixCreate(Bitmap.Width, Bitmap.Height, GetBPP(Bitmap)))
        Dim BMPDAT As BitmapData = Bitmap.LockBits(New Rectangle(0, 0, Bitmap.Width, Bitmap.Height), ImageLockMode.WriteOnly, Bitmap.PixelFormat)
        Dim BMPBYT((BMPDAT.Height * BMPDAT.Stride) - 1) As Byte : Marshal.Copy(BMPDAT.Scan0, BMPBYT, 0, BMPBYT.Length)
        Marshal.Copy(BMPBYT, 0, Me.Values.data, BMPBYT.Length) : Bitmap.UnlockBits(BMPDAT)
    End Sub
    Public Function ToBitmap() As Image
        If Me.Pointer = IntPtr.Zero Then Return Nothing
        If w = 0 And h = 0 Then Return New Bitmap(1, 1)
        If w = -1 And h = -1 Then Return New Bitmap(1, 1)
        Dim bmp As New Bitmap(w, h, PixelFormat.Format32bppArgb)
        Dim wpl As Pix = LeptonicaSharp._AllFunctions.pixConvertTo32(Me)
        Dim dat As Imaging.BitmapData = bmp.LockBits(New Rectangle(0, 0, w, h), _
                                                     ImageLockMode.ReadWrite, _
                                                     PixelFormat.Format32bppArgb)

        Dim cnt As Integer = (wpl.w * wpl.h * (wpl.d / 8) - 1)
        Dim i(cnt) As Byte : Marshal.Copy(LeptonicaSharp.Natives.pixGetData(wpl.Pointer), i, 0, cnt)

        For i2 As Integer = 0 To cnt - 3 Step 4
            Dim a As Integer = 255 '  (i(i2))
            Dim b As Integer = i(i2 + 1)
            Dim g As Integer = i(i2 + 2)
            Dim r As Integer = i(i2 + 3)
            i(i2 + 0) = b
            i(i2 + 1) = g
            i(i2 + 2) = r
            i(i2 + 3) = a
        Next
        Marshal.Copy(i, 0, dat.Scan0, i.Length)
        bmp.UnlockBits(dat)
        Return bmp
    End Function

    Public Shared Function GetBPP(ByVal bitmap As System.Drawing.Bitmap) As Integer
        Select Case bitmap.PixelFormat
            Case System.Drawing.Imaging.PixelFormat.Format1bppIndexed : Return 1
            Case System.Drawing.Imaging.PixelFormat.Format4bppIndexed : Return 4
            Case System.Drawing.Imaging.PixelFormat.Format8bppIndexed : Return 8
            Case System.Drawing.Imaging.PixelFormat.Format16bppArgb1555,
                System.Drawing.Imaging.PixelFormat.Format16bppGrayScale,
                System.Drawing.Imaging.PixelFormat.Format16bppRgb555,
                System.Drawing.Imaging.PixelFormat.Format16bppRgb565 : Return 16
            Case System.Drawing.Imaging.PixelFormat.Format24bppRgb : Return 24
            Case System.Drawing.Imaging.PixelFormat.Format32bppArgb,
                System.Drawing.Imaging.PixelFormat.Format32bppPArgb,
                System.Drawing.Imaging.PixelFormat.Format32bppRgb : Return 32
            Case System.Drawing.Imaging.PixelFormat.Format48bppRgb : Return 48
            Case System.Drawing.Imaging.PixelFormat.Format64bppArgb,
                System.Drawing.Imaging.PixelFormat.Format64bppPArgb : Return 64
            Case Else : Throw New ArgumentException([String].Format("The bitmap's pixel format of {0} was not recognised.", bitmap.PixelFormat), "bitmap")
        End Select
    End Function
#End Region

End Class

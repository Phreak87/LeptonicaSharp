Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging

Partial Public Class pix
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

    Public Function tobitmap() As Image
        If Me.Pointer = IntPtr.Zero Then Return Nothing
        If w = 0 And h = 0 Then Return New Bitmap(1, 1)
        If w = -1 And h = -1 Then Return New Bitmap(1, 1)
        Dim bmp As New Bitmap(w, h, PixelFormat.Format32bppArgb)
        Dim wpl As pix = LeptonicaSharp._AllFunctions.pixConvertTo32(Me)
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
End Class

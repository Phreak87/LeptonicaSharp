Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging

Partial Public Class pix
    Property _filename As String
    Sub New(ByVal filename As String)
        Me.new(leptonicasharp.natives.pixread(filename))
    End Sub

    Public Sub save_jpg(ByVal filename As String, Optional ByVal quality As Integer = 95, Optional ByVal progressive As Integer = 0)
        leptonicasharp.natives.pixwritejpeg(filename, pointer, quality, progressive)
    End Sub
    Public Sub save_png(ByVal filename As String, Optional ByVal gamma As Single = 95, Optional ByVal progressive As Integer = 0)
        leptonicasharp.natives.pixwritepng(filename, pointer, gamma)
    End Sub
    Public Sub save_tiff(ByVal filename As String)
        leptonicasharp.natives.pixwritetiff(filename, pointer, leptonicasharp.enumerations.iff.iff_tiff, "a")
    End Sub
    Public Function save_format(ByVal filename As String, ByVal format As leptonicasharp.enumerations.iff) As Boolean
        Return leptonicasharp.natives.pixwrite(filename, pointer, format)
    End Function
    Public Function save_autoformat(ByVal filename As String, ByVal format As leptonicasharp.enumerations.iff) As Boolean
        Return leptonicasharp.natives.pixwriteautoformat(filename, pointer)
    End Function

    Public Function tobitmap() As image
        If w = 0 And h = 0 Then Return New bitmap(1, 1)
        If w = -1 And h = -1 Then Return New bitmap(1, 1)
        Dim bmp As New bitmap(w, h, pixelformat.format32bppargb)
        Dim dat As imaging.bitmapdata = bmp.lockbits(New rectangle(0, 0, w, h), imaging.imagelockmode.readwrite, pixelformat.format32bppargb)

        Select Case d
            Case 1 : Return New pix(leptonicasharp.natives.pixconvert1to32(Nothing, pointer, 0, 1024)).tobitmap
            Case 8 : Return New pix(leptonicasharp.natives.pixconvert8to32(pointer)).tobitmap
            Case 16 : Return New pix(leptonicasharp.natives.pixconvertto32(pointer)).tobitmap
            Case 32
                Dim cnt As Integer = (w * h * 4) - 1
                Dim i(cnt) As Byte
                marshal.copy(leptonicasharp.natives.pixgetdata(pointer), i, 0, cnt)
                For i2 As Integer = 0 To cnt - 1 Step 4
                    Dim a As Integer = 255 '  (i(i2))
                    Dim b As Integer = i(i2 + 1)
                    Dim g As Integer = i(i2 + 2)
                    Dim r As Integer = i(i2 + 3)
                    i(i2 + 0) = b
                    i(i2 + 1) = g
                    i(i2 + 2) = r
                    i(i2 + 3) = a
                Next
                marshal.copy(i, 0, dat.scan0, cnt)
                bmp.unlockbits(dat)
                Return bmp
        End Select
        Return Nothing
    End Function
End Class
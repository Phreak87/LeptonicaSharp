Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Reflection
Imports System.Drawing.Imaging

#Region "Functional"
Partial Public Class Box
    Public Function GetBitmap(Optional ByVal Pix As Pix = Nothing) As Pix
        If IsNothing(Pix) Then Pix = New Pix(Me.w + Me.x + 5, Me.h + Me.y + 5)
        Dim n As New Bitmap(Pix.w, Pix.h, Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(n)
        Dim p As New Pen(Brushes.Red, 3)
        g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h)
        g.DrawRectangle(p, New Rectangle(Me.x, Me.y, Me.w, Me.h))
        Dim RPix As New Pix(n) : n.Dispose() : Return RPix
    End Function
    Public Sub Display(Optional Pix As Pix = Nothing)
        Dim n As New ShowPix(GetBitmap(Pix))
    End Sub
End Class

Partial Public Class Boxa
    Public Function GetBitmap(Optional ByVal Pix As Pix = Nothing) As Pix
        Dim MaxW As Integer = 0
        Dim MaxH As Integer = 0
        For Each Entry In Me.box
            If Entry.x + Entry.w + 5 > MaxW Then MaxW = Entry.x + Entry.w + 5
            If Entry.y + Entry.h + 5 > MaxH Then MaxH = Entry.y + Entry.h + 5
        Next
        If IsNothing(Pix) Then Pix = New Pix(MaxW, MaxH)
        Dim n As New Bitmap(Pix.w, Pix.h, Imaging.PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(n)
        Dim p As New Pen(Brushes.Red, 3)
        g.DrawImage(Pix.BitmapStatic, 0, 0, Pix.w, Pix.h)
        For Each Boxe In Me.box
            g.DrawRectangle(p, New Rectangle(Boxe.x, Boxe.y, Boxe.w, Boxe.h))
        Next
        Dim RPix As New Pix(n) : n.Dispose() : Return RPix
    End Function
    Public Sub Display(Optional Pix As Pix = Nothing)
        Dim n As New ShowPix(GetBitmap(Pix))
    End Sub
End Class

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

    ReadOnly Property BitmapStatic As Bitmap
        Get
            If Pointer = IntPtr.Zero Then Return Nothing
            If Caching.ContainsKey("Bitmap") Then Return Caching("Bitmap")
            Caching.Add("Bitmap", Me.ToBitmap) : Return Caching("Bitmap")
        End Get
    End Property

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
        _All.pixWriteMemBmp(Bytes, Size, IIf(Me.d = 24, Me.ConvertTo32, Me))
        Dim MemStrm As New IO.MemoryStream(Bytes)
        Return New Bitmap(MemStrm, True)
    End Function

    Public Function ConvertTo1BPPBMP(ByVal Pix As Pix) As Bitmap
        Dim MSH As New Marshal_Pix
        Dim PixSwap As Pix = LeptonicaSharp._All.pixEndianByteSwapNew(Pix)

        Try
            Dim img As Bitmap = New Bitmap(Pix.w, Pix.h, PixelFormat.Format1bppIndexed)
            Dim imgData As BitmapData = img.LockBits(New Rectangle(0, 0, img.Width, img.Height), 2, PixelFormat.Format1bppIndexed)
            For Line As Integer = 0 To Pix.h - 1
                For Col = 0 To Pix.w - 1 Step 8
                    Dim index As Integer = (Line * PixSwap.wpl * 4) + (Col >> 3)
                    Marshal.WriteByte(imgData.Scan0, index, Not PixSwap.DataStatic(index))
                Next
            Next
            img.UnlockBits(imgData) : Return img
        Catch

        End Try
        Return Nothing
    End Function
#End Region
End Class

Partial Public Class Pixa
    Function GetBitmap(Optional NCols As Integer = 4) As Pix
        Dim pixc = LeptonicaSharp._All.pixaDisplayTiledAndScaled(Me, 32, 500, NCols, 0, 1, 3)
        Return pixc
    End Function
    Sub Display(Optional NCols As Integer = 4)
        Dim n As New ShowPix(GetBitmap)
    End Sub
End Class

Partial Public Class Numa
    Sub DisplayNumaBarGraph(Optional ByVal NumaH As Numa = Nothing,
                            Optional ByVal BgPix As Pix = Nothing,
                            Optional ByVal Swap As Boolean = False)

        Dim NumaW As Numa = Me
        If Swap = True Then
            Dim TMpH = NumaH
            Dim TmpW = Me
            NumaH = TmpW
            NumaW = TMpH
        End If
        Dim NumaHCnt As Integer = 1 : If Not IsNothing(NumaH) Then NumaHCnt = NumaH.n
        Dim NumaWCnt As Integer = 1 : If Not IsNothing(NumaW) Then NumaWCnt = NumaW.n
        Dim NumaHMax As Double = 1 : If Not IsNothing(NumaH) Then NumaHMax = NumaH.array.Max
        Dim NumaWMax As Double = 1 : If Not IsNothing(NumaW) Then NumaWMax = NumaW.array.Max
        Dim VMaxH As Integer = Math.Max(NumaHMax, NumaWCnt) : If VMaxH > 2000 Then VMaxH = 2000
        Dim VMaxW As Integer = Math.Max(NumaWMax, NumaHCnt) : If VMaxW > 2000 Then VMaxW = 2000
        If Not IsNothing(BgPix) Then VMaxH = BgPix.h : VMaxW = BgPix.w
        Dim DiffH As Double = VMaxH / NumaHMax
        Dim DiffW As Double = VMaxW / NumaWMax

        Dim n As Bitmap = New Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb)
        Dim Pen1 As New Pen(Drawing.Color.FromArgb(150, 0, 255, 0), 1)
        Dim Pen2 As New Pen(Drawing.Color.FromArgb(150, 255, 0, 0), 1)
        Dim g As Graphics = Graphics.FromImage(n)

        If IsNothing(BgPix) Then g.FillRectangle(Brushes.WhiteSmoke, New Rectangle(0, 0, VMaxW, VMaxH))
        If Not IsNothing(BgPix) Then g.DrawImage(BgPix.ToBitmap, New System.Drawing.Point(0, 0))

        If Not IsNothing(NumaW) Then
            For i As Integer = 0 To NumaW.n - 1
                g.DrawLine(Pen1, New Drawing.Point(0, i + 1), New Drawing.Point(NumaW.array(i) * DiffW, i + 1))
            Next
        End If
        If Not IsNothing(NumaH) Then
            For i As Integer = 0 To NumaH.n - 1
                g.DrawLine(Pen2, New Drawing.Point(i + 1, VMaxH - (NumaH.array(i) * DiffH)), New Drawing.Point(i + 1, VMaxH))
            Next
        End If
        Dim PX As New Pix(n)
        PX.Display()
        PX.Dispose()
    End Sub
    Sub DisplayNumaHeatmap(Optional ByVal NumaH As Numa = Nothing,
                           Optional ByVal BgPix As Pix = Nothing,
                           Optional ByVal Swap As Boolean = False)

        Dim NumaW As Numa = Me
        If Swap = True Then
            Dim TMpH = NumaH
            Dim TmpW = NumaW
            NumaH = TmpW
            NumaW = TMpH
        End If
        Dim NumaHCnt As Integer = 1 : If Not IsNothing(NumaH) Then NumaHCnt = NumaH.n
        Dim NumaWCnt As Integer = 1 : If Not IsNothing(NumaW) Then NumaWCnt = NumaW.n
        Dim NumaHMax As Double = 1 : If Not IsNothing(NumaH) Then NumaHMax = NumaH.array.Max
        Dim NumaWMax As Double = 1 : If Not IsNothing(NumaW) Then NumaWMax = NumaW.array.Max
        Dim VMaxH As Integer = Math.Max(NumaHMax, NumaWCnt) : If VMaxH > 2000 Then VMaxH = 2000
        Dim VMaxW As Integer = Math.Max(NumaWMax, NumaHCnt) : If VMaxW > 2000 Then VMaxW = 2000
        If Not IsNothing(BgPix) Then VMaxH = BgPix.h : VMaxW = BgPix.w
        Dim VDiffH As Double = VMaxH / NumaHMax
        Dim VDiffW As Double = VMaxW / NumaWMax

        Dim n As Bitmap = New Bitmap(VMaxW, VMaxH, PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(n)

        If IsNothing(BgPix) Then g.FillRectangle(Brushes.WhiteSmoke, New Rectangle(0, 0, VMaxW, VMaxH))
        If Not IsNothing(BgPix) Then g.DrawImage(BgPix.ToBitmap, New System.Drawing.Point(0, 0))

        If Not IsNothing(NumaW) Then
            Dim BarHeight As Integer = CInt(VMaxH / NumaWCnt)
            For i As Integer = 0 To NumaW.n - 1
                Dim BarPos As Integer = ((i) * BarHeight) + IIf(BarHeight = 1, 0, (BarHeight / 2))
                Dim Pen As New Pen(Color.FromArgb(CInt((130 / NumaWMax) * NumaW.array(i)), 0, 255, 0), BarHeight)
                Dim P1 As New Drawing.Point(0, BarPos)
                Dim P2 As New Drawing.Point(VMaxW, BarPos)
                g.DrawLine(Pen, P1, P2)
            Next
        End If

        If Not IsNothing(NumaH) Then
            Dim BarWidth As Integer = Math.Max(CInt(VMaxW / NumaHCnt), 1)
            For i As Integer = 0 To NumaH.n - 1
                Dim BarPos As Integer = ((i) * BarWidth) + IIf(BarWidth = 1, 0, (BarWidth / 2))
                Dim Pen As New Pen(Color.FromArgb(CInt((130 / NumaHMax) * NumaH.array(i)), 0, 0, 255), BarWidth)
                Dim P1 As New Drawing.Point(BarPos, 0)
                Dim P2 As New Drawing.Point(BarPos, VMaxH)
                g.DrawLine(Pen, P1, P2)
            Next
        End If

        Dim PX As New Pix(n)
        PX.Display()
        PX.Dispose()
    End Sub
End Class

Partial Public Class Sel
    Sub Display()
        Dim n As New ShowPix(LeptonicaSharp._All.selDisplayInPix(Me, 1, 1))
    End Sub
    Sub Display(ByVal Pix As Pix)
        Dim CRed As UInt32 = BitConverter.ToUInt32({255, 0, 0, 0}, 0)
        Dim CBlu As UInt32 = BitConverter.ToUInt32({0, 255, 0, 0}, 0)
        Dim n As New ShowPix(LeptonicaSharp._All.pixDisplayHitMissSel(Pix, Me, 1, CRed, CBlu))
    End Sub
End Class
#End Region

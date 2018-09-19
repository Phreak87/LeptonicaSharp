Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Reflection
Imports System.Drawing.Imaging

Partial Public Class Pix

#Region "Redirects"
    ReadOnly Property Data4 As List(Of Byte())
        Get
            Dim Sep4 As New List(Of Byte())
            For i As Integer = 0 To data.Count - 1 Step 4
                Dim B(3) As Byte : Array.Copy(data, i, B, 0, B.Length)
                Sep4.Add(B)
            Next
            Return Sep4
        End Get
    End Property
    ReadOnly Property Data3 As List(Of Byte())
        Get
            Dim Sep3 As New List(Of Byte())
            For i As Integer = 0 To data.Count - 1 Step 3
                Dim B(2) As Byte : Array.Copy(data, i, B, 0, B.Length)
                Sep3.Add(B)
            Next
            Return Sep3
        End Get
    End Property
    ReadOnly Property Data2 As List(Of Byte())
        Get
            Dim Sep2 As New List(Of Byte())
            For i As Integer = 0 To data.Count - 1 Step 2
                Dim B(1) As Byte : Array.Copy(data, i, B, 0, B.Length)
                Sep2.Add(B)
            Next
            Return Sep2
        End Get
    End Property

    Sub New()
        Pointer = LeptonicaSharp._AllFunctions.pixCreate(1, 1, 32).Pointer
        Values = New Marshal_Pix : Marshal.PtrToStructure(Pointer, Values)
    End Sub
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
        Dim BPPIDX As Integer = GetBPP(Bitmap) / 8
        Dim BMPDAT As BitmapData = Bitmap.LockBits(New Rectangle(0, 0, Bitmap.Width, Bitmap.Height), ImageLockMode.WriteOnly, Bitmap.PixelFormat)
        Dim BMPBYT((BMPDAT.Height * BMPDAT.Stride) - 1) As Byte
        Marshal.Copy(BMPDAT.Scan0, BMPBYT, 0, BMPBYT.Length)
        Select Case BPPIDX
            Case 1 ' : Throw New NotImplementedException
            Case 2 : Throw New NotImplementedException
            Case 3 : BMPBYT = SwapBytes(BMPBYT, "RGB", "BGR")
            Case 4 : BMPBYT = SwapBytes(BMPBYT, "RGBA", "ARGB")
            Case 5 : Throw New NotImplementedException
            Case 6 : Throw New NotImplementedException
        End Select
        Marshal.Copy(BMPBYT, 0, Me.Values.data, BMPBYT.Length)
        Bitmap.UnlockBits(BMPDAT)
        Me.save_png("CheckPoint1.png")
    End Sub
    Public Function ToBitmap() As Image
        If Me.Pointer = IntPtr.Zero Then Return Nothing
        If w = 0 And h = 0 Then Return New Bitmap(1, 1)
        If w = -1 And h = -1 Then Return New Bitmap(1, 1)
        Dim BPPIDX As Integer = (d / 8)
        Dim BMP As New Bitmap(w, h, GetBPP(Me.d))
        Dim BMPDAT As Imaging.BitmapData = BMP.LockBits(New Rectangle(0, 0, w, h), _
                                                     ImageLockMode.ReadWrite, _
                                                     GetBPP(d))

        Dim CNT As Integer = (BMPDAT.Height * BMPDAT.Width * BPPIDX) - 1

        Dim BMPBYT(CNT) As Byte : Marshal.Copy(LeptonicaSharp.Natives.pixGetData(Pointer), BMPBYT, 0, BMPBYT.Count)
        Select Case BPPIDX
            Case 1 : Throw New NotImplementedException
            Case 2 : Throw New NotImplementedException
            Case 3 : BMPBYT = SwapBytes(BMPBYT, "BGR", "RGB")
            Case 4 : BMPBYT = SwapBytes(BMPBYT, "ARGB", "RGBA")
            Case 5 : Throw New NotImplementedException
            Case 6 : Throw New NotImplementedException
        End Select
        Marshal.Copy(BMPBYT, 0, BMPDAT.Scan0, BMPBYT.Length)
        BMP.UnlockBits(BMPDAT)
        Return bmp
    End Function

    Public Function SwapBytes(Array As Byte(), Source As String, Target As String) As Byte()
        If Source = Target Then Return Array
        Dim BDST(((Array.Length / Source.Length) * Target.Length) - 1) As Byte
        Dim BNXT As Integer = 0

        Dim SSPL As Char() = Source.ToCharArray ' QuellString als char()
        Dim DSPL As Char() = Target.ToCharArray ' ZielString as char()
        Dim RSPL As Char() = DSPL.Except(SSPL).ToArray ' Reste als char()
        Dim SWAPS As New List(Of Integer()) ' Swap-Liste generieren
        For SWAP As Integer = 0 To Source.Length - 1
            Dim IDXNew As Integer = System.Array.IndexOf(DSPL, SSPL(SWAP))
            SWAPS.Add({SWAP, IDXNew})
        Next
        Dim AIDX As Integer = System.Array.IndexOf(DSPL, "A"c)

        Dim ValI((w * h) - 1) As Integer : System.Array.Copy(Array, ValI, ValI.Length)

        For i As Integer = 0 To Array.Length - Source.Length - 1 Step Source.Length
            Dim ValS(Source.Length - 1) As Byte : System.Array.Copy(Array, i, ValS, 0, ValS.Length)
            Dim ValT(Target.Length - 1) As Byte

            If SSPL = DSPL.Reverse.ToArray Then
                ' Little Endian => Big Endian
                ValT = ValS.Reverse.ToArray
                System.Array.Copy(ValT, 0, BDST, BNXT, ValT.Length)
                BNXT += ValT.Length : Continue For
            End If
            'If Source = "RGBA" And Target = "ARGB" Then
            '    Dim C As Integer = BitConverter.ToInt32(ValS, 0)
            '    C = RotateCircularLeft(C, 8) : ValT = BitConverter.GetBytes(C)
            '    System.Array.Copy(ValT, 0, BDST, BNXT, ValT.Length)
            '    BNXT += ValT.Length : Continue For
            'End If
            'If Source = "ARGB" And Target = "RGBA" Then
            '    Dim C As Integer = BitConverter.ToInt32(ValS, 0)
            '    C = RotateCircularRight(C, 8) : ValT = BitConverter.GetBytes(C)
            '    System.Array.Copy(ValT, 0, BDST, BNXT, ValT.Length)
            '    BNXT += ValT.Length : Continue For
            'End If

            For Each Swap In Swaps
                ValT(Swap(1)) = IIf(Swap(1) = AIDX, 255, ValS(Swap(0)))
            Next
            If Target.Length > Source.Length Then
                Dim TIndex As Integer = System.Array.IndexOf(DSPL, RSPL(0))
                ValT(TIndex) = 255
            End If

            System.Array.Copy(ValT, 0, BDST, BNXT, ValT.Length) : BNXT += ValT.Length
        Next : Return BDST
    End Function
    Public Function RotateCircularLeft(ByVal n As Int32, ByVal nBits As Byte) As Int32
        Return (n << nBits) Or ((n >> (32 - nBits)) And (Not (-1 << nBits)))
    End Function
    Public Function RotateCircularRight(ByVal n As Int32, ByVal nBits As Byte) As Int32
        Return (n << (32 - nBits)) Or ((n >> nBits) And (Not (-1 << (32 - nBits))))
    End Function

    Public Shared Function GetBPP(ByVal bitmap As System.Drawing.Bitmap) As Integer
        Dim BPP As Integer = System.Text.RegularExpressions.Regex.Match(bitmap.PixelFormat.ToString, "Format([0-9]*)").Groups(1).Value
        Return BPP
    End Function
    Public Shared Function GetBPP(ByVal BPP As Integer) As PixelFormat
        Select Case BPP
            Case 1 : Return PixelFormat.Format1bppIndexed
            Case 4 : Return PixelFormat.Format4bppIndexed
            Case 8 : Return PixelFormat.Format8bppIndexed
            Case 16 : Return PixelFormat.Format16bppGrayScale
            Case 24 : Return PixelFormat.Format24bppRgb
            Case 32 : Return PixelFormat.Format32bppArgb
            Case Else : Return PixelFormat.Undefined
        End Select
    End Function

#End Region

End Class

Imports LeptonicaSharp

Public Class NoteShrink
    Sub CleanUp2(Pix As LeptonicaSharp.Pix)
        Dim px = LeptonicaSharp._All.pixOctcubeQuantMixedWithGray(Pix, 8, 2, 36)

        Dim palette = ProcessColorMap(px)
        SaturatePalette(palette)
        Dim cm = CreateNewColorMap(px, palette)
        LeptonicaSharp._All.pixSetColormap(px, cm)
        px.Display()
    End Sub
    Private Function CreateNewColorMap(px As Pix, ByRef aPalette As Byte()()) As PixColormap
        Dim newCmap = LeptonicaSharp._All.pixcmapCreate(px.d)
        For i As Integer = 0 To aPalette.Length - 1
            LeptonicaSharp._All.pixcmapAddColor(newCmap, aPalette(i)(0), aPalette(i)(1), aPalette(i)(2))
        Next
        Return newCmap
    End Function

    Private Sub SaturatePalette(ByRef pal As Byte()())
        Dim colors = pal.Length
        Dim floatPal = New Single(colors - 1)() {}
        For i As Integer = 0 To pal.Length - 1
            floatPal(i) = New Single() {pal(i)(0), pal(i)(1), pal(i)(2)}
        Next
        Dim pmin = floatPal.SelectMany(Function(x) x).Where(Function(o) o > 1 AndAlso o < 255).Min()
        Dim pmax = floatPal.SelectMany(Function(x) x).Where(Function(o) o > 1 AndAlso o < 255).Max()

        For i As Integer = 0 To floatPal.Length - 1

            If floatPal(i)(0) <= 1 AndAlso floatPal(i)(1) <= 1 AndAlso floatPal(i)(2) <= 1 Then
                pal(i)(0) = CByte(floatPal(i)(0))
                pal(i)(1) = CByte(floatPal(i)(1))
                pal(i)(2) = CByte(floatPal(i)(2))
                Continue For
            End If

            If floatPal(i)(0) >= 255 AndAlso floatPal(i)(1) >= 255 AndAlso floatPal(i)(2) >= 255 Then
                pal(i)(0) = CByte(floatPal(i)(0))
                pal(i)(1) = CByte(floatPal(i)(1))
                pal(i)(2) = CByte(floatPal(i)(2))
                Continue For
            End If

            floatPal(i)(0) = 255 * (floatPal(i)(0) - pmin) / (pmax - pmin)
            floatPal(i)(1) = 255 * (floatPal(i)(1) - pmin) / (pmax - pmin)
            floatPal(i)(2) = 255 * (floatPal(i)(2) - pmin) / (pmax - pmin)
            pal(i)(0) = CByte(floatPal(i)(0))
            pal(i)(1) = CByte(floatPal(i)(1))
            pal(i)(2) = CByte(floatPal(i)(2))
        Next
    End Sub

    Function ProcessColorMap(px As Pix) As Byte()()
        Dim cmap = LeptonicaSharp._All.pixGetColormap(px)
        Dim cmapCnt = LeptonicaSharp._All.pixcmapGetCount(cmap)

        Dim pal(cmapCnt - 1)() As Byte
        Dim b(cmapCnt - 1)() As Byte
        For i As Integer = 0 To cmapCnt - 1
            Dim RVal As Integer = 0
            Dim GVal As Integer = 0
            Dim BVal As Integer = 0
            LeptonicaSharp._All.pixcmapGetColor(cmap, i, RVal, GVal, BVal)
            pal(i) = New Byte() {RVal, GVal, BVal}
        Next
        Return pal
    End Function
End Class

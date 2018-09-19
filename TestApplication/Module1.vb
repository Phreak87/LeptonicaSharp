Imports System.Drawing
Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Module Module1

    Sub Main()

        TestPDF()
        'TestPix()
        'TestColorMap()
        'TestMem()
        'TestString()
        'TestDisplay()
        'TestSimpleClass()
        'TestDewaFunctions()

    End Sub

    Private Sub TestDisplay()
        Dim PIX32 As New Pix("Test.jpg")
        'PIX32.save_autoformat("PIX32.jpg", IFF.IFF_JFIF_JPEG)
        PIX32.Display()

        Dim PIX16 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To16(PIX32, L_16_bit_conversion.L_MS_TWO_BYTES)
        'PIX16.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX16.Display()

        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert16To8(PIX16, L_16_bit_conversion.L_MS_BYTE)
        'PIX8.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX8.Display()

        Dim PIX4 As Pix = LeptonicaSharp._AllFunctions.pixConvert8To4(PIX8)
        'PIX4.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX4.Display()

        Dim PIX2 As Pix = LeptonicaSharp._AllFunctions.pixConvert8To2(PIX8)
        'PIX2.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX2.Display()

        Dim PIX1 As Pix = LeptonicaSharp._AllFunctions.pixConvertTo1(PIX8, 128)
        'PIX1.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX1.Display()
    End Sub
    Private Sub TestDewaFunctions()
        Dim PIXD As Pix = Nothing ' ByRef
        Dim DEWA As L_Dewarpa = Nothing ' ByRef
        Dim PIX32 As New Pix("Test.jpg") : PIX32.Display()
        Dim RSU = LeptonicaSharp._AllFunctions.dewarpSinglePage(PIX32, 0, 1, 1, 0, PIXD)
        PIXD.save_jpg("DewarpSinglePageTest.jpg")

        'Dim dewa1 As LeptonicaSharp.L_Dewarpa = LeptonicaSharp._AllFunctions.dewarpaCreate(1, 0, 2, 0, -1)
        'Dim Dew As LeptonicaSharp.L_Dewarp = LeptonicaSharp._AllFunctions.dewarpCreate(PIX32, 0)
        PIX32 = LeptonicaSharp._AllFunctions.pixDeskew(PIX32, 2) : PIX32.save_jpg("pixDeskewTest.jpg")
    End Sub
    Private Sub TestNumaFunctions()
        Dim PIX32 As New Pix("Test.jpg") ': PIX32.Display()
        'Dim histo As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.pixGetRGBHistogram(PIX32, 2, 1)
        'Dim norma As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.numaNormalizeHistogram(histo, 1)
    End Sub
    Private Sub TestPixFunctions()
        'Dim PixS As LeptonicaSharp.Pix = LeptonicaSharp._AllFunctions.pixHMT(PIX1, Sel)
        'PixS = LeptonicaSharp._AllFunctions.pixInvert(PixS)
        'PixS = LeptonicaSharp._AllFunctions.pixDilateBrick(PixS, 1, 2)

        'PIXD = LeptonicaSharp._AllFunctions.pixSauvolaBinarize(PIX8, 2, 0.35, 0, , , , PIX1) ': PIX1.Display()
        'PIXD = LeptonicaSharp._AllFunctions.pixBackgroundNormSimple(PIXD)
        'PIXD = LeptonicaSharp._AllFunctions.pixCleanBackgroundToWhite(PIXD, 1, 30, 190)
        'PIXD = LeptonicaSharp._AllFunctions.pixContrastNorm(PIXD, 100, 100, 55, 4, 4)
        'PIXD = LeptonicaSharp._AllFunctions.pixUnsharpMasking(PIX8, 7, 0.1)
        'PIXD = LeptonicaSharp._AllFunctions.pixEqualizeTRC(PIXD, 0.5, 1)
        'PIXD = LeptonicaSharp._AllFunctions.pixConvert32To16(PIXD, L_16_bit_conversion.L_CLIP_TO_FFFF)
        'PIXD = LeptonicaSharp._AllFunctions.pixConvert16To8(PIXD, L_16_bit_conversion.L_AUTO_BYTE)
        'PIXD = LeptonicaSharp._AllFunctions.pixConvert1To16(PIX1, 255, 0)
        'PIXD = LeptonicaSharp._AllFunctions.pixThresholdToBinary(PIX8, 130)
        'PIXD = LeptonicaSharp._AllFunctions.pixClipRectangle(PIXD, new Box (50,50,50,50))

        'Pix = LeptonicaSharp._AllFunctions.pixDeskew(Pix)
        'Pix = LeptonicaSharp._AllFunctions.pixClipRectangle(Pix, New LeptonicaSharp.Box(50, 50, 100, 100))
        'Pix = LeptonicaSharp._AllFunctions.pixConvertRGBToLuminance(Pix)
        'Pix = LeptonicaSharp._AllFunctions.pixConvertRGBToGrayFast(Pix)
        'Pix = LeptonicaSharp._AllFunctions.pixEqualizeTRC(Nothing, Pix, 0.5, 1)
        'Pix = LeptonicaSharp._AllFunctions.pixInvert(Pix)

        'Dim B As Byte() = LeptonicaSharp._AllFunctions.pixExtractData(PIX32)
        'Dim histo As LeptonicaSharp.Numa = LeptonicaSharp.ByGroup.Pix.pixGetGrayHistogram(Pixg, 1)
        'Dim norma As LeptonicaSharp.Numa = LeptonicaSharp.Unordered.numaNormalizeHistogram(histo, 1)
        'Dim Pixg2 As LeptonicaSharp.Pix = LeptonicaSharp.Unordered.pixConvert16To8(Pixg, LeptonicaSharp._8BitConversionFlags.LSB)
        'Dim BYREF_PixB As New LeptonicaSharp.Pix

        ' Dim STAT As LeptonicaSharp.Status = LeptonicaSharp.Unordered.pixSauvolaBinarizeTiled(Pixg, 8, 0.34, 1, 1, Nothing, BYREF_PixB)
        'Dim Dew As LeptonicaSharp.Dewarp = LeptonicaSharp.Unordered.dewarpCreate(BYREF_PixB, 7, 30, 15, 1)

        'Dim closed As LeptonicaSharp.Numa = LeptonicaSharp.NumaFunc2.numaDilate(norma, 5)

        'Pix = LeptonicaSharp.Implementations.Edge.pixTwoSidedEdgeFilter(Pix, LeptonicaSharp.EdgeOrientationFlags2.L_HORIZONTAL_EDGES)

        ' Leptonica Fails - Auch beim nativen Speichern falsch!
        'Pix = LeptonicaSharp.PixConv.pixConvert32To8(Pix, LeptonicaSharp._16BitConversionFlags.L_CLIP_TO_FFFF, LeptonicaSharp._16BitConversionFlags.L_CLIP_TO_FF)

    End Sub

    Sub TestSimpleClass()
        Dim PIX32 As New Pix("Test.jpg") ' : PIX32.Display()

        Dim T As String = LeptonicaSharp._AllFunctions.pixGetText(PIX32)
        Dim SArray As LeptonicaSharp.Sarray = LeptonicaSharp._AllFunctions.getFilenamesInDirectory("C:\")
        Dim Sel = New LeptonicaSharp.Sel("ooooo" & "oC  o" & "o   o" & "ooooo", 5, 4, "Test")
        Dim Box As New LeptonicaSharp.Box(50, 50, 100, 100)
        Dim numa = New LeptonicaSharp.Numa("2.5,5,7")
        Dim SY = LeptonicaSharp._AllFunctions.create2dIntArray(2, 5)
    End Sub
    Sub TestColorMap()
        Dim PIX32_2 As New Pix("weasel2.4c.png") ' : PIX32_2.Display()
        Dim CM As PixColormap = LeptonicaSharp._AllFunctions.pixGetColormap(PIX32_2)
    End Sub
    Sub TestPix()
        Dim PIX32 As New Pix("Test.jpg") ' : PIX32.Display()
        Dim PIX32_2 As New Pix(New Bitmap("rgb.png")) ' : PIX32_2.Display()
        Dim PIX16 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To16(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF)
        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To8(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF, L_16_bit_conversion.L_CLIP_TO_FF)
        Dim PIXD As New Pix

        PIX32.save_autoformat("Test3.jp2", Enumerations.IFF.IFF_JP2)
        PIX32.save_format("After_BGNormSimple.jpg", IFF.IFF_JFIF_JPEG)
        PIX32.save_autoformat("Test_dewa.jpg", IFF.IFF_PNG)
    End Sub
    Sub TestString()
        Dim Stri = LeptonicaSharp._AllFunctions.sarrayCreateWordsFromString("Das ist ein Test")
        Dim stri1 = LeptonicaSharp._AllFunctions.sarrayAddString(Stri, "Halllo", 1)
        Dim Stri2 = LeptonicaSharp._AllFunctions.sarrayGetArray(Stri)
        Dim Stri3 As Integer = LeptonicaSharp._AllFunctions.sarrayGetCount(Stri)
        Dim Stri4 As String = LeptonicaSharp._AllFunctions.sarrayGetString(Stri, 4, 1)
    End Sub
    Sub TestMem()

        ' ----------------------------------------
        ' Tests: 
        ' ----------------------------------------
        ' Lesen von Byte()                      => OK
        ' Schreiben von Byte()                  => OK, Todo:    Byte()-Definition UInt **, 
        '                                                       Funktion überladen
        '                                                       ByRef-Rückgabewerte fehlen
        ' Pix Display Fehler (1BPP)             => Todo:        Ansicht anpassen (Indexed ??=Fehler)
        ' Datentypen: UInt8 * und UInt8 ** 
        ' ----------------------------------------

        ' Schreibt als Workaround für JPEG in eine Temp.Datei
        Dim BMPBYT1 As Byte() = My.Computer.FileSystem.ReadAllBytes("Test.jpg")
        Dim PX1 As Pix = LeptonicaSharp._AllFunctions.pixReadMem(BMPBYT1, BMPBYT1.Length)
        PX1.save_jpg("FromMemFile.jpg")

        ' Wird direkt aus dem Speicher gelesen
        Dim BMPBYT2 As Byte() = My.Computer.FileSystem.ReadAllBytes("Test.tif")
        Dim PX2 As Pix = LeptonicaSharp._AllFunctions.pixReadMem(BMPBYT2, BMPBYT2.Length)
        PX2.save_jpg("FromMemDirect.jpg")

        ' ------------------------------------------------------------
        ' Erzeuge leeres Byte(), in dem später die Daten liegen sollen
        ' Erzeuge leeres UInt für die befüllung mit der Dateigröße
        ' ------------------------------------------------------------
        Dim BRet1(0) As Byte
        Dim LRet1 As UInteger = 0
        LeptonicaSharp._AllFunctions.pixWriteMemJpeg(BRet1, LRet1, PX1, 85, 0)
        My.Computer.FileSystem.WriteAllBytes("ToMemFile.jpg", BRet1, False)

    End Sub
    Sub TestPDF()
        Dim PIX32 As New Pix("Test.jpg")
        Dim C0 As New L_Pdf_Data()
        Dim C1 As New L_Pdf_Data()
        Dim C2 As New L_Pdf_Data()
        Dim C3 As New L_Pdf_Data()

        ' schreibt nur das erste Bild ?!?!
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_FIRST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_NEXT_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)

        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_FLATE_ENCODE, "Test1.pdf", C1, L_T_IMAGE.L_LAST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_G4_ENCODE, "Test2.pdf", C2, L_T_IMAGE.L_LAST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "Test3.pdf", C3, L_T_IMAGE.L_LAST_IMAGE)
    End Sub

End Module

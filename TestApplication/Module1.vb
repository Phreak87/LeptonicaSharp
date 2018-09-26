Imports System.Drawing
Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Module Module1

    Sub Main()
        ' ---------------------------------------------
        ' Copy the required dll-files to your path if 
        ' they dont exists.
        ' ---------------------------------------------
        LeptonicaSharp.Natives.Initialize()

        ' ---------------------------------------------
        ' Set to 1 to enable debug images.
        ' requires i_view32.exe in the application path.
        ' ---------------------------------------------
        LeptonicaSharp._AllFunctions.setLeptDebugOK(1)

        Dim PIX32 As New Pix("s1.jpg")    ' 32 BPP Pix
        'PIX32.Display()

        'TestPDF()
        'TestPDF2()
        TestPix()
        'TestMem()
        'TestString()
        'TestDisplay()
        'TestColorMap()
        'TestSimpleClass()
        'TestPixFunctions()
        'TestDewaFunctions()
        'TestNumaFunctions()


    End Sub

    Private Sub TestDisplay()
        Dim PIX32 As New Pix("test.jpg")
        PIX32.save_autoformat("PIX32.jpg", IFF.IFF_JFIF_JPEG)
        'PIX32.Display()

        Dim PIX16 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To16(PIX32, L_16_bit_conversion.L_MS_TWO_BYTES)
        PIX16.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        'PIX16.Display()

        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert16To8(PIX16, L_16_bit_conversion.L_MS_BYTE)
        PIX8.save_autoformat("Pix8.jpg", IFF.IFF_JFIF_JPEG)
        'PIX8.Display()

        Dim PIX4 As Pix = LeptonicaSharp._AllFunctions.pixConvert8To4(PIX8)
        PIX4.save_autoformat("Pix4.jpg", IFF.IFF_JFIF_JPEG)
        'PIX4.Display() 

        Dim PIX2 As Pix = LeptonicaSharp._AllFunctions.pixConvert8To2(PIX8)
        PIX2.save_autoformat("Pix2.jpg", IFF.IFF_JFIF_JPEG)
        'PIX2.Display() 

        Dim PIX1 As Pix = LeptonicaSharp._AllFunctions.pixConvertTo1(PIX8, 128)
        PIX1.save_autoformat("Pix1.jpg", IFF.IFF_JFIF_JPEG)
        'PIX1.Display() 

        PIX32.Dispose()
        PIX16.Dispose()
        PIX8.Dispose()
        PIX4.Dispose()
        PIX2.Dispose()
        PIX1.Dispose()
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
        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To8(PIX32, 5, 2)

        ' ------------------
        ' NUMA-Functions:
        ' ------------------
        Dim histoRGB As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.pixGetRGBHistogram(PIX32, 2, 1)                             ' OK
        Dim normaRGB As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.numaNormalizeHistogram(histoRGB, 1)                         ' OK
        Dim histo As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.pixGetGrayHistogram(PIX8, 1)                                   ' OK
        Dim norma As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.numaNormalizeHistogram(histo, 1)                               ' OK
        Dim closed As LeptonicaSharp.Numa = LeptonicaSharp._AllFunctions.numaDilate(norma, 5)                                          ' OK

    End Sub
    Private Sub TestPixFunctions()

        Dim PIX32 As New Pix("test.jpg")    ' 32 BPP Pix
        Dim PIXG As Pix = Nothing           ' ByRef Result Pix 
        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To8(PIX32, 5, 2)

        ' ------------------
        ' 32BPPFunctions
        ' ------------------
        ' PIX32 = LeptonicaSharp._AllFunctions.pixInvert(PIX32) : PIX32.Display()                                                       ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixBackgroundNormSimple(PIX32) : PIX32.Display()                                         ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixCleanBackgroundToWhite(PIX32, 1, 30, 190) : PIX32.Display()                           ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixClipRectangle(PIX32, New Box(9, 9, 90, 90)) : PIX32.Display()                         ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixUnsharpMasking(PIX32, 3, 0.1) : PIX32.Display()                                       ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixEqualizeTRC(PIX32, 0.5, 1) : PIX32.Display()                                          ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixDeskew(PIX32) : PIX32.Display()                                                       ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixConvertRGBToLuminance(PIX32) : PIX32.Display()                                        ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixConvertRGBToGrayFast(PIX32) : PIX32.Display()                                         ' OK
        ' PIX32 = LeptonicaSharp._AllFunctions.pixEqualizeTRC(PIX32, 0.5, 2) : PIX32.Display()                                          ' OK


        ' ------------------
        ' 8BPP-Functions
        ' ------------------
        'PIX8 = LeptonicaSharp._AllFunctions.pixContrastNorm(PIX8, 100, 100, 55, 4, 4) : PIX8.Display()                                 ' OK
        'PIX8 = LeptonicaSharp._AllFunctions.pixThresholdToBinary(PIX8, 130) : PIX8.Display()                                           ' OK
        'PIX8 = LeptonicaSharp._AllFunctions.pixTwoSidedEdgeFilter(PIX8, L_L_EDGES.L_HORIZONTAL_EDGES) : PIX8.Display()                 ' OK
        Dim STAT As Integer = LeptonicaSharp._AllFunctions.pixSauvolaBinarizeTiled(PIX8, 8, 0.3, 1, 1, Nothing, PIXG) ': PIXG.Display() ' OK
        'Dim Dew As LeptonicaSharp.L_Dewarp = LeptonicaSharp._AllFunctions.dewarpCreate(PIXG, 0)                                        ' OK

        ' ------------------
        ' 1BPP-Functions:
        ' ------------------
        PIX32.Display()
        Dim SEL As New LeptonicaSharp.Sel("ooooCoooo", 3, 3, "TEST")
        PIXG = LeptonicaSharp._AllFunctions.pixHMT(PIXG.InvertColors, SEL)                             ' OK
        PIXG = LeptonicaSharp._AllFunctions.pixDilateBrick(PIXG, 4, 4)
        PIXG.Display()
        Sel.Display()


        Dim B As Byte() = LeptonicaSharp._AllFunctions.pixExtractData(PIX32)                                                            ' Byte() Größe undefiniert

    End Sub

    Sub TestSimpleClass()
        Dim PIX32 As New Pix("Test.jpg") ' : PIX32.Display()

        Dim T As String = LeptonicaSharp._AllFunctions.pixGetText(PIX32)
        Dim SArray As LeptonicaSharp.Sarray = LeptonicaSharp._AllFunctions.getFilenamesInDirectory("C:\")
        Dim Sel = New LeptonicaSharp.Sel("ooooo" & "oC  o" & "o   o" & "ooooo", 5, 4, "Test") : Sel.Display() ' : Sel.Display(PIX32)
        Dim Box As New LeptonicaSharp.Box(50, 50, 100, 100)
        Dim pta = LeptonicaSharp._AllFunctions.ptraCreate(3)
        Dim numa = New LeptonicaSharp.Numa("2.5,5,7")
        Dim SY = LeptonicaSharp._AllFunctions.create2dIntArray(2, 5)

        ' Speicher bereinigen
        SArray.Dispose()
        Sel.Dispose()
        Box.Dispose()
        numa.Dispose()
        PIX32.Dispose()
    End Sub
    Sub TestColorMap()
        Dim PIX32_2 As New Pix("weasel4.16c.png") ' : PIX32_2.Display()
        Dim CM As PixColormap = LeptonicaSharp._AllFunctions.pixGetColormap(PIX32_2)
        PIX32_2.Dispose()
    End Sub
    Sub TestPix()
        Dim PIX32 As New Pix("Test.jpg") ' : PIX32.Display()
        Dim PIX32_2 As New Pix(New Bitmap("test.jpg")) : PIX32_2.Display()
        Dim PIX16 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To16(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF)
        Dim PIX8 As Pix = LeptonicaSharp._AllFunctions.pixConvert32To8(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF, L_16_bit_conversion.L_CLIP_TO_FF)
        Dim PIXD As New Pix

        PIX32.save_autoformat("Test_Format_JPG.jpg", IFF.IFF_JFIF_JPEG)
        PIX32.save_autoformat("Test_Format_JP2.jp2", IFF.IFF_JP2)
        PIX32.save_autoformat("Test_Format_PNG.png", IFF.IFF_PNG)
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

        Dim n As New System.IO.FileStream("pix32.jpg", System.IO.FileMode.Open)
        Dim P As Pix = LeptonicaSharp._AllFunctions.pixReadStreamJpeg(New FILE("pix32.jpg"), 0, 1, 0)
        P.Display()


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
        Dim C0 As L_Pdf_Data = Nothing

        ' Diese Funktionen schreiben nur 1 PDF-Seite mit mehreren Bildern!
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_FIRST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_NEXT_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "TestMax.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_FLATE_ENCODE, "Test1.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_G4_ENCODE, "Test2.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)
        LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, "Test3.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)
    End Sub
    Sub TestPDF2()
        ' -----------------------------------
        ' Create Multipage-PDF from Filenames
        ' -----------------------------------
        'Dim Stri = LeptonicaSharp._AllFunctions.sarrayCreateWordsFromString("Test.jpg Test.jpg Test.jpg")
        'LeptonicaSharp._AllFunctions.saConvertFilesToPdf(Stri, 0, 0.0, 0, 0, "newTextMax.pdf", "multipage pdf")

        ' -----------------------------------
        ' Create Multipage-PDF from PIXs
        ' -----------------------------------
        'Dim PIX32 As New Pix("Test.jpg")
        'Dim pixadb = New Pixa(3)
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        '_AllFunctions.pixaConvertToPdf(pixadb, PIX32.xres, 0, L_ENCODE.L_JPEG_ENCODE, 0, "fileout.pdf")

        ' Dim C0 As L_Pdf_Data = Nothing '        Will be created on L_FIRST_IMAGE call
        Dim C0 As New L_Pdf_Data
        Dim PIX32 As New Pix("Test.jpg") '      The Pix 
        Dim pa_data = New L_Ptra(3) '           Pointer Array

        Dim OK As L_OK = _AllFunctions.selectDefaultPdfEncoding(PIX32, L_ENCODE.L_JPEG_ENCODE)

        Dim imdata As Byte() = Nothing
        Dim imbytes As UInteger

        '_AllFunctions.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, imdata, imbytes, C0, L_T_IMAGE.L_FIRST_IMAGE)
        '_AllFunctions.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, imdata, imbytes, C0, L_T_IMAGE.L_NEXT_IMAGE)
        _AllFunctions.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, imdata, imbytes, C0, L_T_IMAGE.L_LAST_IMAGE) ' C0 is beeing Destroyed here! 
        Dim ba = _AllFunctions.l_byteaInitFromMem(imdata, imbytes)
        _AllFunctions.ptraAdd(pa_data, ba)

        'Need more work here but I can't get this far in debugging due to the wrapper.
        'Dim pages As Integer = _AllFunctions.ptraGetActualCount(pa_data, pages)'
        Dim RETPData As Byte() = Nothing
        Dim RETPNBytes As UInteger = 0
        _AllFunctions.ptraConcatenatePdfToData(pa_data, RETPData, RETPNBytes)
    End Sub
End Module

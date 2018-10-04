Imports System.Drawing
Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Module Module1

    Sub Main()

        ' ---------------------------------------------
        ' Copy the required dll-files to your path if
        ' they dont exists. (Nuget)
        ' ---------------------------------------------
        LeptonicaSharp.Natives.Initialize()

        ' ---------------------------------------------
        ' Set to 1 to enable debug images.
        ' requires i_view32.exe in the application path.
        ' ---------------------------------------------
        _All.setLeptDebugOK(1)

        Dim PIX32 As New Pix("Test.jpg")    ' 32 BPP Pix
        Dim BMP As Bitmap = PIX32.Bitmap
        'PIX32.pixGetRegionsBinary(New Pixa(3), Nothing, Nothing, Nothing)
        PIX32.Dispose()
        'PIX32.Display()

        'TestPDF()              ' OK
        'TestPDF2()             ' OK
        'TestPix()              ' OK
        'TestMem()              ' OK
        'TestString()           ' OK
        'TestDisplay()          ' OK
        'TestColorMap()         ' OK
        'TestSimpleClass()      ' OK
        'TestPixFunctions()     ' OK
        'TestDewaFunctions()    ' OK
        'TestNumaFunctions()    ' OK
        'TestExtensions()       ' OK

    End Sub

    Sub TestExtensions()
        ' --------------------------------------------------------------------------------
        ' <Extend Name="pixRead" Type="Construct" Source="pixs"/>
        ' --------------------------------------------------------------------------------
        Dim PIX32 As New Pix("Test.jpg")

        ' --------------------------------------------------------------------------------
        ' <Extend Name="PixConvert32to16" Type="Function" Source="pixs" return="return"/>
        ' --------------------------------------------------------------------------------
        Dim PIX16 As Pix = PIX32.pixConvertTo16() ' Nur 1-8 Bpp

        ' --------------------------------------------------------------------------------
        ' <Extend Name="dewarpSinglePage" Type="Function" Source="pixs" return="ppixd"/>
        ' --------------------------------------------------------------------------------
        Dim PixD As Pix = PIX32.dewarpSinglePage(1, 1, 0, 1)

        ' --------------------------------------------------------------------------------
        ' <Extend Name="pixConvertToPdf" Type="Sub" Source="pix"/>
        ' --------------------------------------------------------------------------------
        Dim LPDFDATA As L_Pdf_Data = Nothing
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test.pdf", LPDFDATA, L_T_IMAGE.L_FIRST_IMAGE)

        ' --------------------------------------------------------------------------------
        ' Multiple Actions on a Pix
        ' --------------------------------------------------------------------------------
        PIX32.pixInvert.pixDeskew.Display()

    End Sub
    Private Sub TestDisplay()
        Dim PIX32 As New Pix("test2.jpg")
        PIX32.save_autoformat("PIX32.jpg", IFF.IFF_JFIF_JPEG)
        Dim B As Byte() = LeptonicaSharp._All.pixGetData(PIX32)
        PIX32.Display(32)

        Dim PIX16 As Pix = _All.pixConvert32To16(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF)
        PIX16.save_autoformat("Pix16.jpg", IFF.IFF_JFIF_JPEG)
        PIX16.Display(16)

        Dim PIX8 As Pix = _All.pixConvert32To8(PIX32, L_16_bit_conversion.L_MS_TWO_BYTES, L_16_bit_conversion.L_MS_BYTE)
        PIX8.save_autoformat("Pix8.jpg", IFF.IFF_JFIF_JPEG)
        PIX8.Display(8)

        Dim PIX4 As Pix = _All.pixConvert8To4(PIX8)
        PIX4.save_autoformat("Pix4.jpg", IFF.IFF_JFIF_JPEG)
        PIX4.Display(4)

        Dim PIX2 As Pix = _All.pixConvert8To2(PIX8)
        PIX2.save_autoformat("Pix2.jpg", IFF.IFF_JFIF_JPEG)
        PIX2.Display(2)

        Dim PIX1 As Pix = _All.pixConvertTo1(PIX8, 128)
        PIX1.save_autoformat("Pix1.jpg", IFF.IFF_JFIF_JPEG)
        PIX1.ToBitmap.Save("PixToBMP1.jpg", Imaging.ImageFormat.Jpeg)
        PIX1.Display(1)

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
        Dim PIX32 As New Pix("img\cat.007.jpg") : PIX32.Display()
        Dim RSU = _All.dewarpSinglePage(PIX32, 1, 1, 0, 0, PIXD, DEWA, DebugOnOff.DebugOn)
        PIXD.save_jpg("DewarpSinglePageTest.jpg")

        Dim dewa1 As LeptonicaSharp.L_Dewarpa = _All.dewarpaCreate(1, 0, 2, 0, -1)
        Dim Dew As LeptonicaSharp.L_Dewarp = _All.dewarpCreate(PIX32.pixConvertTo1(128), 0)
        PIX32 = _All.pixDeskew(PIX32, 2) : PIX32.save_jpg("pixDeskewTest.jpg")
    End Sub
    Private Sub TestNumaFunctions()
        Dim PIX32 As New Pix("img\cat.007.jpg") ': PIX32.Display()
        Dim PIX8 As Pix = PIX32.pixConvertTo8(False)
        ' PIX8.Display()

        ' ------------------
        ' NUMA-Functions:
        ' ------------------
        Dim histoRGB As LeptonicaSharp.Numa = _All.pixGetRGBHistogram(PIX32, 2, 1)                             ' OK
        Dim normaRGB As LeptonicaSharp.Numa = _All.numaNormalizeHistogram(histoRGB, 1)                         ' OK
        Dim histo As LeptonicaSharp.Numa = _All.pixGetGrayHistogram(PIX8, 1)                                   ' OK
        Dim norma As LeptonicaSharp.Numa = _All.numaNormalizeHistogram(histo, 1)                               ' OK
        Dim closed As LeptonicaSharp.Numa = _All.numaDilate(norma, 5)                                          ' OK

    End Sub
    Private Sub TestPixFunctions()

        Dim PIX32 As New Pix("test2.jpg")    ' 32 BPP Pix
        Dim PIXG As Pix = Nothing           ' ByRef Result Pix
        Dim PIX8 As Pix = PIX32.pixConvertTo8(False) : PIX8.Display()

        ' -----------------------------------------------
        ' 32BPPFunctions (via Allfunctions and Optional)
        ' Maybe comment-out upper Functions to work
        ' -----------------------------------------------
        PIX32 = LeptonicaSharp._All.pixInvert(PIX32, PIX32) : PIX32.Display()                                                  ' OK
        PIX32 = PIX32.pixInvert                                                                                                         ' OK, Short Extension
        PIX32 = LeptonicaSharp._All.pixBackgroundNormSimple(PIX32, Nothing, Nothing) : PIX32.Display()                         ' OK
        PIX32 = PIX32.pixBackgroundNormSimple                                                                                           ' OK, Short Extension
        PIX32 = LeptonicaSharp._All.pixCleanBackgroundToWhite(PIX32, Nothing, Nothing, 1, 30, 190) : PIX32.Display()           ' OK
        PIX32 = PIX32.pixCleanBackgroundToWhite(1, 30, 190)                                                                             ' OK, Short Extension
        PIX32 = LeptonicaSharp._All.pixClipRectangle(PIX32, New Box(280, 280, 100, 100), Nothing) : PIX32.Display()            ' OK
        PIX32 = LeptonicaSharp._All.pixUnsharpMasking(PIX32, 3, 0.1) : PIX32.Display()                                         ' OK
        PIX32 = LeptonicaSharp._All.pixEqualizeTRC(PIX32, PIX32, 0.5, 3) : PIX32.Display()                                     ' OK
        PIX32 = LeptonicaSharp._All.pixDeskew(PIX32, 4) : PIX32.Display()                                                      ' OK
        PIX32 = PIX32.pixDeskew                                                                                                ' OK, Short Extension
        PIX32 = LeptonicaSharp._All.pixConvertRGBToLuminance(PIX32) : PIX32.Display()                                          ' OK
        PIX32 = LeptonicaSharp._All.pixConvertRGBToGrayFast(PIX32) : PIX32.Display()                                           ' OK
        PIX32 = LeptonicaSharp._All.pixEqualizeTRC(PIX32, PIX32, 0.5, 2) : PIX32.Display()                                     ' OK

        ' -----------------------------------------------
        ' 8BPPFunctions (via Allfunctions, Non-Optional)
        ' Maybe comment-out upper Functions to work
        ' -----------------------------------------------
        PIX8 = LeptonicaSharp._All.pixContrastNorm(Nothing, PIX8, 100, 100, 55, 4, 4) : PIX8.Display()                         ' OK
        PIX8 = LeptonicaSharp._All.pixThresholdToBinary(PIX8, 130) : PIX8.Display()                                            ' OK
        PIX8 = LeptonicaSharp._All.pixTwoSidedEdgeFilter(PIX8, L_L_EDGES.L_HORIZONTAL_EDGES) : PIX8.pixInvert.Display()        ' OK
        Dim STAT As Integer = LeptonicaSharp._All.pixSauvolaBinarizeTiled(PIX8, 8, 0.3, 1, 1, Nothing, PIXG) : PIXG.Display()  ' OK
        Dim Dew As LeptonicaSharp.L_Dewarp = LeptonicaSharp._All.dewarpCreate(PIXG, 0)                                         ' OK

        ' ------------------
        ' 1BPP-Functions:
        ' ------------------
        PIX32.Display()
        Dim SEL As New LeptonicaSharp.Sel("ooooCoooo", 3, 3, "TEST")                                                            ' OK
        PIXG = LeptonicaSharp._All.pixHMT(Nothing, PIXG.pixInvert, SEL)                                                        ' OK
        PIXG = LeptonicaSharp._All.pixDilateBrick(Nothing, PIXG, 4, 4)                                                         ' OK
        PIXG.Display()
        SEL.Display()


        Dim B As Byte() = LeptonicaSharp._All.pixExtractData(PIX32)                                                            ' Byte() Größe undefiniert, Fehler!

    End Sub

    Sub TestSimpleClass()
        Dim PIX32 As New Pix("img\cat.007.jpg") ' : PIX32.Display()

        Dim T As String = LeptonicaSharp._All.pixGetText(PIX32)
        Dim SArray As LeptonicaSharp.Sarray = LeptonicaSharp._All.getFilenamesInDirectory("C:\")
        Dim Sel = New LeptonicaSharp.Sel("ooooo" & "oC  o" & "o   o" & "ooooo", 5, 4, "Test") : Sel.Display() ' : Sel.Display(PIX32)
        Dim Box As New LeptonicaSharp.Box(50, 50, 100, 100)
        Dim pta = LeptonicaSharp._All.ptraCreate(3)
        Dim numa = New LeptonicaSharp.Numa("2.5,5,7")
        Dim SY = LeptonicaSharp._All.create2dIntArray(2, 5)

        ' Speicher bereinigen
        SArray.Dispose()
        Sel.Dispose()
        Box.Dispose()
        numa.Dispose()
        PIX32.Dispose()
    End Sub
    Sub TestColorMap()
        Dim PIX32_2 As New Pix("img\weasel4.16c.png") ' : PIX32_2.Display()
        Dim CM As PixColormap = LeptonicaSharp._All.pixGetColormap(PIX32_2)
        PIX32_2.Dispose()
    End Sub
    Sub TestPix()
        Dim PIX32 As New Pix("Test.jpg") ' : PIX32.Display()

        Dim PIX32_2 As New Pix(New Bitmap("test.jpg")) : PIX32_2.Display()
        Dim PIX16 As Pix = LeptonicaSharp._All.pixConvert32To16(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF)
        Dim PIX8 As Pix = LeptonicaSharp._All.pixConvert32To8(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF, L_16_bit_conversion.L_CLIP_TO_FF)
        Dim PIXD As New Pix(1, 1)

        PIX32.save_autoformat("Test_Format_JPG.jpg", IFF.IFF_JFIF_JPEG)
        PIX32.save_autoformat("Test_Format_JP2.jp2", IFF.IFF_JP2)
        PIX32.save_autoformat("Test_Format_PNG.png", IFF.IFF_PNG)
    End Sub
    Sub TestString()
        Dim Stri = LeptonicaSharp._All.sarrayCreateWordsFromString("Das ist ein Test")
        Dim stri1 = LeptonicaSharp._All.sarrayAddString(Stri, "Halllo", 1)
        Dim Stri2 = LeptonicaSharp._All.sarrayGetArray(Stri, Nothing, Nothing)
        Dim Stri3 As Integer = LeptonicaSharp._All.sarrayGetCount(Stri)
        Dim Stri4 As String = LeptonicaSharp._All.sarrayGetString(Stri, 4, 1)
    End Sub
    Sub TestMem()

        ' ----------------------------------------
        ' Tests:
        ' ----------------------------------------
        ' Schreiben von Byte()                  => OK, Todo:    Byte()-Definition UInt **,
        '                                                       Funktion überladen
        '                                                       ByRef-Rückgabewerte fehlen
        ' Pix Display Fehler (1BPP)             => Todo:        Ansicht anpassen (Indexed ??=Fehler)
        ' Datentypen: UInt8 * und UInt8 **
        ' ----------------------------------------

        ' ----------------------------------------------------------------
        ' Lesen von Byte()                                          => OK
        ' ----------------------------------------------------------------
        Dim B As Byte() = My.Computer.FileSystem.ReadAllBytes("Test2.jpg")
        Dim P1 As Pix = LeptonicaSharp._All.pixReadMemJpeg(B, B.Length, 0, 1, Nothing, 0)
        P1.Display()

        ' ----------------------------------------------------------------
        ' Lesen von FILE-Struct (Workaround)                        => OK
        ' ----------------------------------------------------------------
        Dim P2 As Pix = LeptonicaSharp._All.pixReadStreamJpeg(New FILE("test2.jpg"), 0, 1, Nothing, 0)
        P2.Display()

        ' ----------------------------------------------------------------
        ' Schreibt als Workaround für JPEG in eine Temp.Datei       => OK
        ' ----------------------------------------------------------------
        Dim BMPBYT1 As Byte() = My.Computer.FileSystem.ReadAllBytes("Test2.jpg")
        Dim PX1 As Pix = LeptonicaSharp._All.pixReadMem(BMPBYT1, BMPBYT1.Length)
        PX1.save_jpg("FromMemFile.jpg") : PX1.save_tiff("Test.tif")

        ' ----------------------------------------------------------------
        ' Schreibt direkt aus einem Byte()                          => OK
        ' ----------------------------------------------------------------
        Dim BMPBYT2 As Byte() = My.Computer.FileSystem.ReadAllBytes("Test.tif")
        Dim PX2 As Pix = LeptonicaSharp._All.pixReadMem(BMPBYT2, BMPBYT2.Length)
        PX2.save_jpg("FromMemDirect.jpg")

        ' ------------------------------------------------------------
        ' Erzeuge leeres Byte(), in dem später die Daten liegen sollen
        ' Erzeuge leeres UInt für die befüllung mit der Dateigröße
        ' ------------------------------------------------------------
        Dim BRet1(0) As Byte
        Dim LRet1 As UInteger = 0
        LeptonicaSharp._All.pixWriteMemJpeg(BRet1, LRet1, PX1, 85, 0)
        My.Computer.FileSystem.WriteAllBytes("ToMemFile.jpg", BRet1, False)

    End Sub
    Sub TestPDF()
        Dim PIX32 As New Pix("Test.jpg")

        Dim C0 As L_Pdf_Data = Nothing
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test1.pdf", C0, L_T_IMAGE.L_FIRST_IMAGE)
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test1.pdf", C0, L_T_IMAGE.L_NEXT_IMAGE)
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test1.pdf", C0, L_T_IMAGE.L_LAST_IMAGE)

        Dim C1 As L_Pdf_Data = Nothing
        _All.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, "TestMax.pdf", 0, 0, 0, "Title", C1, L_T_IMAGE.L_FIRST_IMAGE)
        LeptonicaSharp._All.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, "TestMax.pdf", 0, 0, 0, "Title", C1, L_T_IMAGE.L_NEXT_IMAGE)
        LeptonicaSharp._All.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, "TestMax.pdf", 0, 0, 0, "Title", C1, L_T_IMAGE.L_LAST_IMAGE)

        C0 = New L_Pdf_Data ' Wird geleert bei LastImage (immer nur 1 Zeile verwenden!)
        'LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_FLATE_ENCODE, 0, "TestMax2.pdf", 0, 0, 0, "Title", C0, L_T_IMAGE.L_LAST_IMAGE)
        'LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_G4_ENCODE, 0, "TestMax2.pdf", 0, 0, 0, "Title", C0, L_T_IMAGE.L_LAST_IMAGE)
        'LeptonicaSharp._AllFunctions.pixConvertToPdf(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, "TestMax2.pdf", 0, 0, 0, "Title", C0, L_T_IMAGE.L_LAST_IMAGE)

    End Sub
    Sub TestPDF2()
        ' -----------------------------------
        ' Create Multipage-PDF from Filenames
        ' -----------------------------------
        'Dim Stri = LeptonicaSharp._AllFunctions.sarrayCreateWordsFromString("Test.jpg Test2.jpg Test.jpg")         ' OK
        'LeptonicaSharp._AllFunctions.saConvertFilesToPdf(Stri, 0, 0.0, 0, 0, "newTextMax.pdf", "multipage.pdf")    ' OK (created Multipage-PDF)

        ' -----------------------------------
        ' Create Multipage-PDF from PIXs
        ' -----------------------------------
        'Dim PIX32 As New Pix("Test.jpg")
        'Dim pixadb = New Pixa(3)
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)                                            ' OK
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)                                            ' OK
        '_AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)                                            ' OK
        '_AllFunctions.pixaConvertToPdf(pixadb, 0, 1, L_ENCODE.L_JPEG_ENCODE, 0, "Test", "Pixadb.pdf")               ' OK (created Multipage-PDF)

        ' -----------------------------------
        ' Create Multipage-PDF from PIX-V2
        ' -----------------------------------
        Dim C0 As L_Pdf_Data = Nothing '        Init via L_First_Image
        Dim PIX32 As New Pix("Test.jpg") '      The Pix
        Dim pa_data = New L_Ptra(3) '           Pointer Array
        Dim imdata As Byte() = Nothing
        Dim imbytes As UInteger
        _All.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, imdata, imbytes, 0, 0, 0, "Title", C0, L_T_IMAGE.L_FIRST_IMAGE)
        _All.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, imdata, imbytes, 0, 0, 0, "Title", C0, L_T_IMAGE.L_NEXT_IMAGE)
        _All.pixConvertToPdfData(PIX32, L_ENCODE.L_JPEG_ENCODE, 0, imdata, imbytes, 0, 0, 0, "Title", C0, L_T_IMAGE.L_LAST_IMAGE) ' C0 is Destroyed here!
        Dim ba = _All.l_byteaInitFromMem(imdata, imbytes)
        _All.ptraAdd(pa_data, ba)

        Dim RETPData As Byte() = Nothing
        Dim RETPNBytes As UInteger = 0
        _All.ptraConcatenatePdfToData(pa_data, Nothing, RETPData, RETPNBytes)
    End Sub
End Module

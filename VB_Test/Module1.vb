Imports System.Drawing
Imports LeptonicaSharp
Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Module Module1

    Sub Main()

        Dim P1 As New Example1 : P1.Test1()
        ' Dim N1 As New NoteShrink(): N1.CleanUp2(New Pix("img\Examples\Notea1.jpg"))

        Dim pixs = New Pix("contrast-orig-60.jpg")
        Dim pixt1 = LeptonicaSharp._All.pixCloseGray(pixs, 11, 11)
        ' or ... Dim pixt2 = LeptonicaSharp._All.pixScaleGrayMinMax(pixs, 11, 11, L_CHOOSE_M.L_CHOOSE_MAX)
        Dim pixt2 = LeptonicaSharp._All.pixBlockconv(pixt1, 15, 15)
        Dim PixT3 = LeptonicaSharp._All.pixSubtract(Nothing, pixs, pixt2.pixInvert)
        PixT3.Display()
        Dim pa As New Pixa(3)
        pixs.pixCleanBackgroundToWhite().Display()
        pa.display(50, 50)

        Dim NotesA1 As Pix = New Pix("img\Examples\Note1.jpg")
        Dim SNoteasA1 As Pix = LeptonicaSharp._All.pixOctcubeQuantMixedWithGray(NotesA1, 8, 2, 64).pixConvertTo32
        LeptonicaSharp._All.pixGammaTRC(SNoteasA1, SNoteasA1, 0.7F, 0, 255)

        Dim Dave As New LineRemoval_Reg() : Dave.Test()


        ' ---------------------------------------------
        ' Copy the required dll-files to your path if
        ' they dont exists. (Nuget)
        ' ---------------------------------------------
        ' LeptonicaSharp.Natives.Initialize()

        ' ---------------------------------------------
        ' Set to 1 to enable debug images.
        ' requires i_view32.exe in the application path.
        ' ---------------------------------------------
        _All.setLeptDebugOK(1)

        Dim PIX32 As New Pix("Test.jpg")    ' 32 BPP Pix
        Dim PIX01 As Pix = PIX32.pixConvertTo1(128)

        Dim BMP As Bitmap = PIX01.BitmapStatic

        'Dim PIxs As New Pix("..\..\..\All_Images\Leptonica\contrast-orig-60.jpg")
        'Dim pixt1 As Pix = LeptonicaSharp._All.pixCloseGray(PIxs, 11, 11)
        'Dim pixt2 As Pix = LeptonicaSharp._All.pixOpenGray(PIxs, 11, 11)
        'Dim pixt3 As Integer = LeptonicaSharp._All.pixCombineMasked(PIxs, pixt1, Nothing)
        Dim PixG1 As Pix = LeptonicaSharp._All.pixConvertRGBToGray(PIX32, 0, 0, 0)

        PIxs = PIxs.pixBackgroundNormSimple()
        Dim bmp1 As Bitmap = PIxs.ToBitmap

        PIX32.Dispose()
        'PIX32.Display()

        TestErrorChecks()  ' Vor Release immer prüfen!

        'TestPix01()
        'TestPix24()
        'TestPDF()              ' OK
        'TestPDF2()             ' OK
        'TestPix()              ' OK
        'TestMem()              ' OK
        'TestString()           ' OK
        'TestDisplay()          ' OK
        'TestColorMap()         ' OK
        'TestSimpleClass()      ' OK
        'TestPixFunctions()     ' OK

        'Dim Quan As New Examples_Quantization
        'Quan.QuantizationTest()

        'Dim Dewa As New Examples_Dewarping
        'Dewa.TestDewarp()

        'TestNumaFunctions()    ' OK
        'TestExtensions()       ' OK

    End Sub

    Sub TestErrorChecks()
        ' ------------------------------------------------------------------------------
        ' Teste Raw-Check wenn "I_View32.exe" nicht existiert                   => OK
        ' ------------------------------------------------------------------------------
        _All.setLeptDebugOK(1)              ' Muss Dateiprüfung oder RawCode enthalten

        ' ------------------------------------------------------------------------------
        ' Teste Config-Extension Konstruktur: PixRead()                         => OK
        ' ------------------------------------------------------------------------------
        Dim PIX32 As New Pix("Test2.jpg")                                ' Muss laden

        ' ------------------------------------------------------------------------------
        ' Teste Arraygröße per Config                                           => OK
        ' ------------------------------------------------------------------------------
        If LeptonicaSharp._All.pixGetData(PIX32).Count < 3 Then Throw New Exception ' = OK

        ' ------------------------------------------------------------------------------
        ' Teste Dateiprüfung per Config                                         => OK                                    
        ' ------------------------------------------------------------------------------
        Dim PIXER As New Pix("MissingFile.jpg")                 ' Muss fehler ausgeben

        ' ------------------------------------------------------------------------------
        ' Teste Extension Funktion mit Klasse als PixS-Default                  => OK
        ' Teste CommentCheck Deklaration (Nur 1 oder 8 Bpp)                     => OK
        ' ------------------------------------------------------------------------------
        PIX32.pixConvertTo16()                                  ' Muss Fehler ausgeben

        ' ------------------------------------------------------------------------------
        ' Teste Kommentar zu Optional "0.0 for default" => 0                    => OK
        ' ------------------------------------------------------------------------------
        PIX32.pixConvertRGBToGray()                                 ' muss funktionieren

        ' ------------------------------------------------------------------------------
        ' Teste Enumeration von Config                                          => ##
        ' Teste isNothing                                                       => OK
        ' ------------------------------------------------------------------------------
        LeptonicaSharp._All.pixWrite(Nothing, PIX32, IFF.IFF_JFIF_JPEG)
        ' Muss Fehler wegen Nothing ausgeben und IFF as Enum enthalten

        ' ------------------------------------------------------------------------------
        ' Teste Extension SUB                                                   => OK
        ' Teste Funktion/Sub Defaults per Parameter                             => OK
        ' ------------------------------------------------------------------------------
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test.pdf", Nothing, L_T_IMAGE.L_FIRST_IMAGE)
        ' Muss Funktionieren

        ' ------------------------------------------------------------------------------
        ' Teste CheckRange (2-16)                                               => OK
        ' ------------------------------------------------------------------------------
        PIX32.pixDeskew(64)                             ' Muss Fehler ausgeben (2 - 8)

        ' ------------------------------------------------------------------------------
        ' Teste CheckArray
        ' Teste explizite Defaults für Parameternamen für jede Funktion
        ' ------------------------------------------------------------------------------
        '<Parameter Name="redsearch"> 		
        '	<Default>0</Default>
        '	<CheckArray>{0,1,2,4,8}</CheckArray>
        '</Parameter>

    End Sub
    Sub TestPix01()
        Dim PIX32 As New Pix("Test2.jpg")    ' 32 BPP Pix
        Dim PIX01 As Pix = PIX32.pixConvertTo1(128)

        ' Save Pix01 as BMP and load from Bytes - OK
        PIX01.save_format("01Test.bmp", IFF.IFF_BMP)
        Dim PixB01 As Byte() = My.Computer.FileSystem.ReadAllBytes("01Test.bmp")
        Dim BMP1 As Bitmap = Bitmap.FromStream(New IO.MemoryStream(PixB01))

        Dim B02 As Byte() = Nothing
        Dim INT As Integer
        LeptonicaSharp._All.pixWriteMemBmp(B02, INT, PIX01)
        Dim BMP2 As Bitmap = New Bitmap(New IO.MemoryStream(B02))

    End Sub
    Sub TestPix24()
        Dim PIX32 As New Pix("Test.jpg")    ' 32 BPP Pix
        Dim PIX24 As Pix = LeptonicaSharp._All.pixConvert32To24(PIX32)
        PIX24.Display(24)
        PIX24.pixConvertTo1(128).Display()
        PIX24.Dispose() : PIX32.Dispose()
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
        Dim PIX24 As Pix = LeptonicaSharp._All.pixConvert32To24(PIX32)

        ' --------------------------------------------------------------------------------
        ' <Extend Name="dewarpSinglePage" Type="Function" Source="pixs" return="ppixd"/>
        ' --------------------------------------------------------------------------------
        Dim PixD As Pix = PIX32.dewarpSinglePage(1, 1, 0, 1)

        ' --------------------------------------------------------------------------------
        ' <Extend Name="pixConvertToPdf" Type="Sub" Source="pix"/>
        ' --------------------------------------------------------------------------------
        Dim LPDFDATA As L_Pdf_Data = Nothing
        '<Function Name="pixConvertToPdf">
        '	<Parameter Name="x"><Default>0</Default></Parameter>
        '	<Parameter Name="y"><Default>0</Default></Parameter>
        '	<Parameter Name="res"><Default>0</Default></Parameter>
        '	<Parameter Name="quality"><Default>0</Default></Parameter>
        '</Function>
        PIX32.pixConvertToPdf(L_ENCODE.L_JPEG_ENCODE, "Test.pdf", LPDFDATA, L_T_IMAGE.L_FIRST_IMAGE)

        ' --------------------------------------------------------------------------------
        ' Multiple Actions on a Pix
        ' --------------------------------------------------------------------------------
        PIX32.pixInvert.pixDeskew.Display()

    End Sub
    Private Sub TestDisplay()
        Dim PIX32 As New Pix("test2.jpg")
        PIX32.save_autoformat("PIX32.jpg")
        Dim B As Byte() = LeptonicaSharp._All.pixGetData(PIX32)
        PIX32.Display(32)

        ' -------------------------------------------------------------
        ' Leptonica-WriteMemory schreibt kein 24Bpp in den speicher
        ' -------------------------------------------------------------
        Dim PIX24 As Pix = LeptonicaSharp._All.pixConvert32To24(PIX32)
        PIX24.save_autoformat("Pix24.bmp")
        PIX24.Display()

        Dim PIX16 As Pix = _All.pixConvert32To16(PIX32, L_16_bit_conversion.L_CLIP_TO_FFFF)
        PIX16.save_autoformat("Pix16.jpg")
        PIX16.Display(16)

        Dim PIX8 As Pix = _All.pixConvert32To8(PIX32, L_16_bit_conversion.L_MS_TWO_BYTES, L_16_bit_conversion.L_MS_BYTE)
        PIX8.save_autoformat("Pix8.jpg")
        PIX8.Display(8)

        Dim PIX4 As Pix = _All.pixConvert8To4(PIX8)
        PIX4.save_autoformat("Pix4.jpg")
        PIX4.Display(4)

        Dim PIX2 As Pix = _All.pixConvert8To2(PIX8)
        PIX2.save_autoformat("Pix2.jpg")
        PIX2.Display(2)

        Dim PIX1 As Pix = _All.pixConvertTo1(PIX8, 128)
        PIX1.save_autoformat("Pix1.jpg")
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
        PIX32 = PIX32.pixCleanBackgroundToWhite()                                                                              ' OK, Short Extension
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

        Dim PIXA As New Pixa(1)
        Dim A As Pix = Nothing : Dim B As Pix = Nothing : Dim C As Pix = Nothing
        PIX32.pixConvertTo1(128).pixGetRegionsBinary(PIXA, A, B, C)
        For Each Pix In PIXA.pix : Pix.Display() : Next

        ' Speicher bereinigen
        SArray.Dispose()
        Sel.Dispose()
        Box.Dispose()
        numa.Dispose()
        PIX32.Dispose()
        PIXA.Dispose()
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

        PIX32.save_autoformat("Test_Format_JPG.jpg")
        PIX32.save_autoformat("Test_Format_JP2.jp2")
        PIX32.save_autoformat("Test_Format_PNG.png")
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

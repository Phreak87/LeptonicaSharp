Imports LeptonicaSharp

Public Class Release

    Sub ReleaseTests()
        ' -----------------------------------------
        ' Pix-Testing
        ' -----------------------------------------
        Dim PIXD As New Pix(50, 50) : If PIXD.w <> 50 Then Throw New Exception
        Dim Pix8 As New Pix("Lic.png") : If IsNothing(Pix8) Then Throw New Exception

        Dim PixSkw As Pix = Pix8._Deskew(2) : If IsNothing(PixSkw) Then Throw New Exception
        'Dim PixSkw2 As Pix = Pix8.pixDeskew() : If IsNothing(PixSkw2) Then Throw New Exception ' VB-Defaulted

        Dim Pix32 As Pix = Pix8._ConvertTo32 : If IsNothing(Pix32) Then Throw New Exception
        Dim Pix33 As Pix = Pix32._Bilateral(1, 50, 10, 4)
        Dim Pix1 As Pix = Pix8._ConvertTo1(128) : If IsNothing(Pix1) Then Throw New Exception
        Dim FPIX1 As FPix = New FPix(50, 50) : If IsNothing(FPIX1) Then Throw New Exception
        Dim DPIX1 As DPix = New DPix(50, 50) : If IsNothing(DPIX1) Then Throw New Exception

        Dim PixT1 As Pix = Pix8._BackgroundNormSimple(Nothing, Nothing) : If IsNothing(PixT1) Then Throw New Exception
        ' Dim PixT12 As Pix = Pix8.pixBackgroundNormSimple() : If IsNothing(PixT1) Then Throw New Exception ' VB-Defaulted
        Dim PixT2 As Pix = Pix8._CleanBackgroundToWhite(Nothing, Nothing, 1, 180, 70) : If IsNothing(PixT2) Then Throw New Exception
        ' Dim PixT22 As Pix = Pix8.pixCleanBackgroundToWhite() : If IsNothing(PixT2) Then Throw New Exception ' VB-Defaulted

        Dim Test = PixT2.BitmapStatic
        PixT1.Dispose() : If Not IsNothing(PixT1.data) Then Throw New Exception

        ' -----------------------------------------
        ' Colormap Testing 
        ' -----------------------------------------
        Dim CM As PixColormap = Pix8.pixGetColormap
        If CM.Array_Color.Count <> 256 Then Throw New Exception
        If CM.Array_RGBAQ.Count <> 256 Then Throw New Exception
        If CM.Array_Bytes.Count <> 1024 Then Throw New Exception
        CM._Clear()
        CM.Dispose()

        ' -----------------------------------------
        ' L_ByteA Testing
        ' -----------------------------------------
        Dim x As New L_Bytea(CUInt(1))
        If x.data.Count <> 0 Then Throw New Exception
        If x.nalloc <> 2 Then Throw New Exception
        _All.l_byteaAppendString(x, "Hallo") : If x.data.Count <> 5 Then Throw New Exception
        Dim x1 As New L_Bytea(New Byte() {4, 5, 6}, CUInt(3)) : If x1.data.Count <> 3 Then Throw New Exception
        Dim x2 As New L_Bytea(New Byte() {1, 2, 3}, CUInt(3)) : If x2.data.Count <> 3 Then Throw New Exception
        _All.l_byteaJoin(x1, x2) : If x1.data.Count <> 6 Or Not IsNothing(x2) Then Throw New Exception
        LeptonicaSharp._All.l_binaryWrite("Test", "w", New Byte() {1, 2, 2}, 3)
        LeptonicaSharp._All.l_binaryWrite("Test", "w", Pix1, Pix1.data.Length)
        LeptonicaSharp._All.l_binaryWrite("Test", "w", Pix1.Pointer, 1)
        Dim X1Res = x1._GetSize()

        ' -----------------------------------------
        ' PixA-Testing
        ' -----------------------------------------
        Dim Pixa1 As New Pixa(1) : If Pixa1.nalloc <> 1 Then Throw New Exception
        Dim LicPixa2 As Pixa = _All.pixExtractTextlines(Pix32, 25, 25, 15, 15, 1, 1, Pixa1)
        If Pixa1.pix.Count < 5 Then Throw New Exception
        Pixa1.Dispose() : If Not IsNothing(Pixa1.pix) Then Throw New Exception
        Pixa1._GetCount()

        ' -----------------------------------------
        ' Byte-Arrays
        ' -----------------------------------------
        Dim B As Byte() = My.Computer.FileSystem.ReadAllBytes("Lic.png") : If B.Length <> 26543 Then Throw New Exception
        Dim P1 As Pix = LeptonicaSharp._All.pixReadMemPng(B, B.Length) : If IsNothing(P1) Then Throw New Exception
        Dim P2 As Pix = LeptonicaSharp._All.pixReadStreamPng(New FILE("Lic.png")) : If IsNothing(P2) Then Throw New Exception()

        ' ------------------
        ' NUMA-Functions:
        ' ------------------
        Dim numa = New Numa("2.5,5,7") : If numa.array.Count <> 3 Then Throw New Exception
        Dim histoRGB As Numa = _All.pixGetRGBHistogram(Pix32, 2, 1) : If IsNothing(histoRGB) Then Throw New Exception
        Dim normaRGB As Numa = _All.numaNormalizeHistogram(histoRGB, 1) : If IsNothing(normaRGB) Then Throw New Exception
        Dim histo As Numa = _All.pixGetGrayHistogram(Pix8, 1) : If IsNothing(histo) Then Throw New Exception
        Dim norma As Numa = _All.numaNormalizeHistogram(histo, 1) : If IsNothing(norma) Then Throw New Exception
        Dim closed As Numa = _All.numaDilate(norma, 5) : If IsNothing(closed) Then Throw New Exception
        numa._AddBorder(numa, 1, 1, 2)

        ' --------------------------
        ' String-Functions
        ' --------------------------
        Dim SArray As Sarray = LeptonicaSharp._All.getFilenamesInDirectory("C:\") : If SArray.array.Count < 1 Then Throw New Exception
        Dim Stri As Sarray = LeptonicaSharp._All.sarrayCreateWordsFromString("Das ist ein Test") : If Stri.array.Count <> 4 Then Throw New Exception
        Dim Stri2 = LeptonicaSharp._All.sarrayGetArray(Stri, Nothing, Nothing) : If Stri2.Count <> 4 Then Throw New Exception
        Dim Stri3 As Integer = LeptonicaSharp._All.sarrayGetCount(Stri) : If Stri3 <> 4 Then Throw New Exception
        Dim Stri4 As String = LeptonicaSharp._All.sarrayGetString(Stri, 0, 1) : If Stri4 <> "Das" Then Throw New Exception
        Stri._AddString("Programm", 1) : If Stri.n <> 5 Then Throw New Exception

        ' --------------------------
        ' Sel Functions
        ' --------------------------
        Dim Sel = New Sel("ooooo" & "oC  o" & "o   o" & "ooooo", 5, 4, "Test")
        If Sel.data.Count <> 4 Then Throw New Exception
        If Sel.data(0).Count <> 5 Then Throw New Exception
        Sel._GetName()

        ' --------------------------
        ' Dewa-Tests
        ' --------------------------
        Dim dewa1 As L_Dewarpa = _All.dewarpaCreate(1, 0, 2, 0, -1) : If dewa1.redfactor <> 2 Then Throw New Exception
        Dim Dew As L_Dewarp = _All.dewarpCreate(Pix32._ConvertTo1(128), 0) : If IsNothing(Dew) Then Throw New Exception

        ' --------------------------
        ' Box Functions
        ' --------------------------
        Dim Box As New Box(50, 50, 100, 100) : If Box.w <> 100 Then Throw New Exception
        Box._AdjustSides(1, 1, 1, 1, Nothing)

        ' --------------------------
        ' PTA Functions
        ' --------------------------
        Dim ptra As L_Ptra = LeptonicaSharp._All.ptraCreate(3)
        If ptra.nalloc <> 3 Then Throw New Exception
        ptra._GetActualCount(0)

        ' --------------------------
        ' Int-Array (Todo: VB,C#)
        ' --------------------------
        Dim SY = LeptonicaSharp._All.create2dIntArray(2, 5)
        If IsNothing(SY) Or SY.Count <> 2 Or SY(0).Count <> 5 Then Throw New Exception

        ' --------------------------
        ' PDF-Tests
        ' --------------------------
        Dim LPDFDATA As L_Pdf_Data = Nothing
        _All.pixConvertToPdf(Pix32, Enumerations.L_ENCODE.L_JPEG_ENCODE, 95, "Test.pdf", 0, 0, 0, "", LPDFDATA, Enumerations.L_T_IMAGE.L_FIRST_IMAGE) : If IsNothing(LPDFDATA) Then Throw New Exception
        _All.pixConvertToPdf(Pix32, Enumerations.L_ENCODE.L_JPEG_ENCODE, 95, "Test.pdf", 0, 0, 0, "", LPDFDATA, Enumerations.L_T_IMAGE.L_LAST_IMAGE) : If Not IsNothing(LPDFDATA) Then Throw New Exception
        If My.Computer.FileSystem.FileExists("Test.pdf") = False Then Throw New Exception

        Pix32.Display()
        MsgBox("Alle checks OK. ab jetzt kommen die Fehlerprüfungen, die Fehler auswerfen!")
    End Sub

    Sub TestErrorChecks()
        Dim Pix32 As New Pix("Lic.png") : Pix32 = Pix32._ConvertTo32

        _All.setLeptDebugOK(1)                                              ' Muss Dateiprüfung oder RawCode enthalten (I_View32 exists)
        Dim PIXER As New Pix("MissingFile.jpg")                             ' Muss fehler ausgeben (FileCheck)
        'Pix32.pixDeskew(10)                                                 ' Muss Fehler ausgeben (0 - 8)
        LeptonicaSharp._All.pixWrite(Nothing, Pix32, Enumerations.IFF.IFF_JFIF_JPEG)     ' Muss Fehler wegen Nothing ausgeben und IFF as Enum enthalten
        Pix32._ConvertTo16()                                              ' Muss Fehler ausgeben Convert nur 1-8 BPP
    End Sub

End Class

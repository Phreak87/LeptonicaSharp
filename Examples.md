FDNCRED-Examples:

        ' -----------------------------------
        ' Create Multipage-PDF from Filenames
        ' -----------------------------------
        'Dim Stri = LeptonicaSharp._AllFunctions.sarrayCreateWordsFromString("Test.jpg Test.jpg Test.jpg")
        'LeptonicaSharp._AllFunctions.saConvertFilesToPdf(Stri, 0, 0.0, 0, 0, "newTextMax.pdf", "multipage pdf")

        ' -----------------------------------
        ' Create Multipage-PDF from PIXs
        ' -----------------------------------
        Dim PIX32 As New Pix("Test.jpg")
        Dim pixadb = New Pixa(3)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaConvertToPdf(pixadb, PIX32.xres, 0, L_ENCODE.L_JPEG_ENCODE, 0, "fileout.pdf")

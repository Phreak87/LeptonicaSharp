FDNCRED-Examples:

# Create a Multipage-PDF
        Dim PIX32 As New Pix("Test.jpg") 
        Dim pixadb = _AllFunctions.pixaCreate(3)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaAddPix(pixadb, PIX32, L_access_storage.L_COPY)
        _AllFunctions.pixaConvertToPdf(pixadb, PIX32.xres, 0, L_ENCODE.L_JPEG_ENCODE, 0, "fileout.pdf")

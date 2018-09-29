Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\pdfio1.c (239, 1)
' convertFilesToPdf()
' convertFilesToPdf(const char *, const char *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) If %substr is not NULL, only image filenames that contain
''' the substring can be used.  If %substr == NULL, all files
''' in the directory are used.
''' (2) The files in the directory, after optional filtering by
''' the substring, are lexically sorted in increasing order
''' before concatenation.
''' (3) The scalefactor is applied to each image before encoding.
''' If you enter a value LT= 0.0, it will be set to 1.0.
''' (4) Specifying one of the three encoding types for %type forces
''' all images to be compressed with that type.  Use 0 to have
''' the type determined for each image based on depth and whether
''' or not it has a colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing images</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image; GT 0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFilesToPdf(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal res as Integer, 
				ByVal scalefactor as Single, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesToPdf( dirname, substr, res, scalefactor, type, quality, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (287, 1)
' saConvertFilesToPdf()
' saConvertFilesToPdf(SARRAY *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertFilesToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for images</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image; GT 0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConvertFilesToPdf(
				ByVal sa as Sarray, 
				ByVal res as Integer, 
				ByVal scalefactor as Single, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.saConvertFilesToPdf( sa.Pointer, res, scalefactor, type, quality, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (340, 1)
' saConvertFilesToPdfData()
' saConvertFilesToPdfData(SARRAY *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertFilesToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for images</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image; GT 0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="pdata">[out] - output pdf data (of all images</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConvertFilesToPdfData(
				ByVal sa as Sarray, 
				ByVal res as Integer, 
				ByVal scalefactor as Single, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.saConvertFilesToPdfData( sa.Pointer, res, scalefactor, type, quality, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (457, 1)
' selectDefaultPdfEncoding()
' selectDefaultPdfEncoding(PIX *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This attempts to choose an encoding for the pix that results
''' in the smallest file, assuming that if jpeg encoded, it will
''' use quality = 75.  The decision is approximate, in that
''' (a) all colormapped images will be losslessly encoded with
''' gzip (flate), and (b) an image with less than about 20 colors
''' is likely to be smaller if flate encoded than if encoded
''' as a jpeg (dct).  For example, an image made by pixScaleToGray3()
''' will have 10 colors, and flate encoding will give about
''' twice the compression as jpeg with quality = 75.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="ptype">[out] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selectDefaultPdfEncoding(
				ByVal pix as Pix, 
				ByRef ptype as Enumerations.L_ENCODE) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.selectDefaultPdfEncoding( pix.Pointer, ptype)

	Return _Result
End Function

' SRC\pdfio1.c (520, 1)
' convertUnscaledFilesToPdf()
' convertUnscaledFilesToPdf(const char *, const char *, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) If %substr is not NULL, only image filenames that contain
''' the substring can be used.  If %substr == NULL, all files
''' in the directory are used.
''' (2) The files in the directory, after optional filtering by
''' the substring, are lexically sorted in increasing order
''' before concatenation.
''' (3) For jpeg and jp2k, this is very fast because the compressed
''' data is wrapped up and concatenated.  For png and tiffg4,
''' the images must be read and recompressed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing images</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertUnscaledFilesToPdf(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertUnscaledFilesToPdf( dirname, substr, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (558, 1)
' saConvertUnscaledFilesToPdf()
' saConvertUnscaledFilesToPdf(SARRAY *, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertUnscaledFilesToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for images</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConvertUnscaledFilesToPdf(
				ByVal sa as Sarray, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.saConvertUnscaledFilesToPdf( sa.Pointer, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (596, 1)
' saConvertUnscaledFilesToPdfData()
' saConvertUnscaledFilesToPdfData(SARRAY *, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for images</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="pdata">[out] - output pdf data (of all images)</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConvertUnscaledFilesToPdfData(
				ByVal sa as Sarray, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.saConvertUnscaledFilesToPdfData( sa.Pointer, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (668, 1)
' convertUnscaledToPdfData()
' convertUnscaledToPdfData(const char *, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - of image file</param>
'''  <param name="title">[in][optional] - pdf title; can be NULL</param>
'''  <param name="pdata">[out] - output pdf data for image</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertUnscaledToPdfData(
				ByVal fname as String, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.convertUnscaledToPdfData( fname, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (752, 1)
' pixaConvertToPdf()
' pixaConvertToPdf(PIXA *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) The images are encoded with G4 if 1 bpp; JPEG if 8 bpp without
''' colormap and many colors, or 32 bpp; FLATE for anything else.
''' (2) The scalefactor must be GT 0.0; otherwise it is set to 1.0.
''' (3) Specifying one of the three encoding types for %type forces
''' all images to be compressed with that type.  Use 0 to have
''' the type determined for each image based on depth and whether
''' or not it has a colormap.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - containing images all at the same resolution</param>
'''  <param name="res">[in] - override the resolution of each input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image; GT 0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaConvertToPdf(
				ByVal pixa as Pixa, 
				ByVal res as Integer, 
				ByVal scalefactor as Single, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaConvertToPdf( pixa.Pointer, res, scalefactor, type, quality, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (804, 1)
' pixaConvertToPdfData()
' pixaConvertToPdfData(PIXA *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) See pixaConvertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - containing images all at the same resolution</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image; GT 0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or 0 for default</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="pdata">[out] - output pdf data (of all images</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaConvertToPdfData(
				ByVal pixa as Pixa, 
				ByVal res as Integer, 
				ByVal scalefactor as Single, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaConvertToPdfData( pixa.Pointer, res, scalefactor, type, quality, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (950, 1)
' convertToPdf()
' convertToPdf(const char *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) To wrap only one image in pdf, input %plpd = NULL, and
''' the value of %position will be ignored
''' convertToPdf(...  type, quality, x, y, res, NULL, 0);
''' (2) To wrap multiple images on a single pdf page, this is called
''' once for each successive image.  Do it this way
''' L_PDF_DATA   lpd;
''' convertToPdf(...  type, quality, x, y, res, lpd, L_FIRST_IMAGE);
''' convertToPdf(...  type, quality, x, y, res, lpd, L_NEXT_IMAGE);
''' ...
''' convertToPdf(...  type, quality, x, y, res, lpd, L_LAST_IMAGE);
''' This will write the result to the value of %fileout specified
''' in the first call; succeeding values of %fileout are ignored.
''' On the last call the pdf data bytes are computed and written
''' to %fileout, lpd is destroyed internally, and the returned
''' value of lpd is null.  So the client has nothing to clean up.
''' (3) (a) Set %res == 0 to respect the resolution embedded in the
''' image file.  If no resolution is embedded, it will be set
''' to the default value.
''' (b) Set %res to some other value to override the file resolution.
''' (4) (a) If the input %res and the resolution of the output device
''' are equal, the image will be "displayed" at the same size
''' as the original.
''' (b) If the input %res is 72, the output device will render
''' the image at 1 pt/pixel.
''' (c) Some possible choices for the default input pix resolution are
''' 72 ppi  Render pix on any output device at one pt/pixel
''' 96 ppi  Windows default for generated display images
''' 300 ppi  Typical default for scanned images.
''' We choose 300, which is sensible for rendering page images.
''' However,  images come from a variety of sources, and
''' some are explicitly created for viewing on a display.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file -- any format</param>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="fileout">[in] - output pdf file; only required on last image on page</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from filein</param>
'''  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
'''  <param name="position">[in] - in image sequence L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertToPdf(
				ByVal filein as String, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal fileout as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal title as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim plpdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plpd) Then plpdPTR = plpd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPdf( filein, type, quality, fileout, x, y, res, title, plpdPTR, position)
	if plpdPTR <> IntPtr.Zero then plpd = new L_Pdf_Data(plpdPTR)

	Return _Result
End Function

' SRC\pdfio1.c (1021, 1)
' convertImageDataToPdf()
' convertImageDataToPdf(l_uint8 *, size_t, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If %res == 0 and the input resolution field is 0,
''' this will use DEFAULT_INPUT_RES.
''' (2) See comments in convertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="imdata">[in] - array of formatted image data; e.g., png, jpeg</param>
'''  <param name="size">[in] - size of image data</param>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="fileout">[in] - output pdf file; only required on last image on page</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
'''  <param name="position">[in] - in image sequence L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertImageDataToPdf(
				ByVal imdata as Byte(), 
				ByVal size as UInteger, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal fileout as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal title as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE) as Integer

	If IsNothing (imdata) then Throw New ArgumentNullException  ("imdata cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim plpdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plpd) Then plpdPTR = plpd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertImageDataToPdf( imdata, size, type, quality, fileout, x, y, res, title, plpdPTR, position)
	if plpdPTR <> IntPtr.Zero then plpd = new L_Pdf_Data(plpdPTR)

	Return _Result
End Function

' SRC\pdfio1.c (1086, 1)
' convertToPdfData()
' convertToPdfData(const char *, l_int32, l_int32, l_uint8 **, size_t *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If %res == 0 and the input resolution field is 0,
''' this will use DEFAULT_INPUT_RES.
''' (2) See comments in convertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file -- any format</param>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="pdata">[out] - pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title; if null, use filein</param>
'''  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
'''  <param name="position">[in] - in image sequence L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertToPdfData(
				ByVal filein as String, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal title as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero
	Dim plpdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plpd) Then plpdPTR = plpd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPdfData( filein, type, quality, pdataPTR, pnbytes, x, y, res, title, plpdPTR, position)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)
	if plpdPTR <> IntPtr.Zero then plpd = new L_Pdf_Data(plpdPTR)

	Return _Result
End Function

' SRC\pdfio1.c (1154, 1)
' convertImageDataToPdfData()
' convertImageDataToPdfData(l_uint8 *, size_t, l_int32, l_int32, l_uint8 **, size_t *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If %res == 0 and the input resolution field is 0,
''' this will use DEFAULT_INPUT_RES.
''' (2) See comments in convertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="imdata">[in] - array of formatted image data; e.g., png, jpeg</param>
'''  <param name="size">[in] - size of image data</param>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="pdata">[out] - pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0) at the lower-left corner of the page</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="plpd">[out] - ptr to lpd, which is created on the first invocation and returned until last image is processed, at which time it is destroyed</param>
'''  <param name="position">[in] - in image sequence L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertImageDataToPdfData(
				ByVal imdata as Byte(), 
				ByVal size as UInteger, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal title as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE) as Integer

	If IsNothing (imdata) then Throw New ArgumentNullException  ("imdata cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero
	Dim plpdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plpd) Then plpdPTR = plpd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertImageDataToPdfData( imdata, size, type, quality, pdataPTR, pnbytes, x, y, res, title, plpdPTR, position)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)
	if plpdPTR <> IntPtr.Zero then plpd = new L_Pdf_Data(plpdPTR)

	Return _Result
End Function

' SRC\pdfio1.c (1223, 1)
' pixConvertToPdf()
' pixConvertToPdf(PIX *, l_int32, l_int32, const char *, l_int32, l_int32, l_int32, const char *, L_PDF_DATA **, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If %res == 0 and the input resolution field is 0,
''' this will use DEFAULT_INPUT_RES.
''' (2) This only writes data to fileout if it is the last
''' image to be written on the page.
''' (3) See comments in convertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="type">[in] - L_G4_ENCODE, L_JPEG_ENCODE, L_FLATE_ENCODE</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="fileout">[in] - output pdf file; only required on last image on page</param>
'''  <param name="x">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
'''  <param name="y">[in] - location of lower-left corner of image, in pixels, relative to the PostScript origin (0,0 at the lower-left corner of the page)</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="plpd">[in,out] - ptr to lpd, which is created on the first invocation and returned until last image is processed</param>
'''  <param name="position">[in] - in image sequence L_FIRST_IMAGE, L_NEXT_IMAGE, L_LAST_IMAGE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixConvertToPdf(
				ByVal pix as Pix, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal quality as Integer, 
				ByVal fileout as String, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal res as Integer, 
				ByVal title as String, 
				ByRef plpd as L_Pdf_Data, 
				ByVal position as Enumerations.L_T_IMAGE) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim plpdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plpd) Then plpdPTR = plpd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixConvertToPdf( pix.Pointer, type, quality, fileout, x, y, res, title, plpdPTR, position)
	if plpdPTR <> IntPtr.Zero then plpd = new L_Pdf_Data(plpdPTR)

	Return _Result
End Function

' SRC\pdfio1.c (1286, 1)
' pixWriteStreamPdf()
' pixWriteStreamPdf(FILE *, PIX *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is the simplest interface for writing a single image
''' with pdf encoding to a stream.  It uses G4 encoding for 1 bpp,
''' JPEG encoding for 8 bpp (no cmap) and 32 bpp, and FLATE
''' encoding for everything else.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for writing</param>
'''  <param name="pix">[in] - all depths, cmap OK</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title; taken from the first image placed on a page; e.g., an input image filename</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamPdf(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal res as Integer, 
				ByVal title as String) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamPdf( fp.Pointer, pix.Pointer, res, title)

	Return _Result
End Function

' SRC\pdfio1.c (1335, 1)
' pixWriteMemPdf()
' pixWriteMemPdf(l_uint8 **, size_t *, PIX *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is the simplest interface for writing a single image
''' with pdf encoding to memory.  It uses G4 encoding for 1 bpp,
''' JPEG encoding for 8 bpp (no cmap) and 32 bpp, and FLATE
''' encoding for everything else.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - pdf as byte array</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf array</param>
'''  <param name="pix">[in] - all depths, cmap OK</param>
'''  <param name="res">[in] - override the resolution of the input image, in ppi; use 0 to respect the resolution embedded in the input</param>
'''  <param name="title">[in][optional] - pdf title; taken from the first image placed on a page; e.g., an input image filename</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPdf(
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger, 
				ByVal pix as Pix, 
				ByVal res as Integer, 
				ByVal title as String) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemPdf( pdataPTR, pnbytes, pix.Pointer, res, title)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (1415, 1)
' convertSegmentedFilesToPdf()
' convertSegmentedFilesToPdf(const char *, const char *, l_int32, l_int32, l_int32, BOXAA *, l_int32, l_float32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) If %substr is not NULL, only image filenames that contain
''' the substring can be used.  If %substr == NULL, all files
''' in the directory are used.
''' (2) The files in the directory, after optional filtering by
''' the substring, are lexically sorted in increasing order
''' before concatenation.
''' (3) The images are encoded with G4 if 1 bpp; JPEG if 8 bpp without
''' colormap and many colors, or 32 bpp; FLATE for anything else.
''' (4) The boxaa, if it exists, contains one boxa of "image regions"
''' for each image file.  The boxa must be aligned with the
''' sorted set of images.
''' (5) The scalefactor is applied to each image region.  It is
''' typically LT 1.0, to save bytes in the final pdf, because
''' the resolution is often not critical in non-text regions.
''' (6) If the non-image regions have pixel depth GT 1 and the encoding
''' type is G4, they are automatically scaled up by 2x and
''' thresholded.  Otherwise, no scaling is performed on them.
''' (7) Note that this function can be used to generate multipage
''' G4 compressed pdf from any input, by using %boxaa == NULL
''' and %type == L_G4_ENCODE.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing images</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="type">[in] - compression type for non-image regions; the image regions are always compressed with L_JPEG_ENCODE</param>
'''  <param name="thresh">[in] - used for converting gray --GT 1 bpp with L_G4_ENCODE</param>
'''  <param name="baa">[in][optional] - boxaa of image regions</param>
'''  <param name="quality">[in] - used for JPEG only; 0 for default (75)</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image region</param>
'''  <param name="title">[in][optional] - pdf title; if null, taken from the first image filename</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertSegmentedFilesToPdf(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal res as Integer, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal thresh as Enumerations.L_ENCODE, 
				ByVal baa as Boxaa, 
				ByVal quality as Integer, 
				ByVal scalefactor as Single, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim baaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(baa) Then baaPTR = baa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertSegmentedFilesToPdf( dirname, substr, res, type, thresh, baaPTR, quality, scalefactor, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (1535, 1)
' convertNumberedMasksToBoxaa()
' convertNumberedMasksToBoxaa(const char *, const char *, l_int32, l_int32) as BOXAA *
'''  <summary>
''' Notes
''' (1) This is conveniently used to generate the input boxaa
''' for convertSegmentedFilesToPdf().  It guarantees that the
''' boxa will be aligned with the page images, even if some
''' of the boxa are empty.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing mask images</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="numpre">[in] - number of characters in name before number</param>
'''  <param name="numpost">[in] - number of characters in name after number, up to a dot before an extension including an extension and the dot separator</param>
'''   <returns>boxaa of mask regions, or NULL on error</returns>
Public Shared Function convertNumberedMasksToBoxaa(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal numpre as Integer, 
				ByVal numpost as Integer) as Boxaa

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.convertNumberedMasksToBoxaa( dirname, substr, numpre, numpost)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\pdfio1.c (1644, 1)
' convertToPdfSegmented()
' convertToPdfSegmented(const char *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) If there are no image regions, set %boxa == NULL;
''' %quality and %scalefactor are ignored.
''' (2) Typically, %scalefactor is LT 1.0, because the image regions
''' can be rendered at a lower resolution (for better compression)
''' than the text regions.  If %scalefactor == 0, we use 1.0.
''' If the input image is 1 bpp and scalefactor LT 1.0, we
''' use scaleToGray() to downsample the image regions to gray
''' before compressing them.
''' (3) If the compression type for non-image regions is L_G4_ENCODE
''' and bpp GT 1, the image is upscaled 2x and thresholded
''' to 1 bpp.  That is the only situation where %thresh is used.
''' (4) The parameter %quality is only used for image regions.
''' If %type == L_JPEG_ENCODE, default jpeg quality (75) is
''' used for the non-image regions.
''' (5) Processing matrix for non-image regions.
''' Input  G4  JPEG FLATE
''' ----------|---------------------------------------------------
''' 1 bpp  |  1x, 1 bpp 1x flate, 1 bpp  1x, 1 bpp
''' |
''' cmap   |  2x, 1 bpp 1x flate, cmap   1x, cmap
''' |
''' 2,4 bpp   |  2x, 1 bpp 1x flate   1x, 2,4 bpp
''' no cmap   |   2,4 bpp
''' |
''' 8,32 bpp  |  2x, 1 bpp 1x (jpeg)  1x, 8,32 bpp
''' no cmap   |   8,32 bpp
''' Summary
''' (a) if G4 is requested, G4 is used, with 2x upscaling
''' for all cases except 1 bpp.
''' (b) if JPEG is requested, use flate encoding for all cases
''' except 8 bpp without cmap and 32 bpp (rgb).
''' (c) if FLATE is requested, use flate with no transformation
''' of the raster data.
''' (6) Calling options/sequence for these functions
''' file  --GT  file   (convertToPdfSegmented)
''' pix  --GT  file   (pixConvertToPdfSegmented)
''' pix  --GT  data   (pixConvertToPdfDataSegmented)
''' file  --GT  data   (convertToPdfDataSegmented)
''' pix  --GT  data   (pixConvertToPdfDataSegmented)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file -- any format</param>
'''  <param name="res">[in] - input image resolution; typ. 300 ppi; use 0 for default</param>
'''  <param name="type">[in] - compression type for non-image regions; the image regions are always compressed with L_JPEG_ENCODE</param>
'''  <param name="thresh">[in] - used for converting gray --GT 1 bpp with L_G4_ENCODE</param>
'''  <param name="boxa">[in][optional] - of image regions; can be null</param>
'''  <param name="quality">[in] - used for jpeg image regions; 0 for default</param>
'''  <param name="scalefactor">[in] - used for jpeg regions; must be LT= 1.0</param>
'''  <param name="title">[in][optional] - pdf title; typically taken from the input file for the pix</param>
'''  <param name="fileout">[in] - output pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertToPdfSegmented(
				ByVal filein as String, 
				ByVal res as Integer, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal thresh as Enumerations.L_ENCODE, 
				ByVal boxa as Boxa, 
				ByVal quality as Integer, 
				ByVal scalefactor as Single, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim boxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxa) Then boxaPTR = boxa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPdfSegmented( filein, res, type, thresh, boxaPTR, quality, scalefactor, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (1704, 1)
' pixConvertToPdfSegmented()
' pixConvertToPdfSegmented(PIX *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertToPdfSegmented() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, cmap OK</param>
'''  <param name="res">[in] - input image resolution; typ. 300 ppi; use 0 for default</param>
'''  <param name="type">[in] - compression type for non-image regions; the image regions are always compressed with L_JPEG_ENCODE</param>
'''  <param name="thresh">[in] - used for converting gray --GT 1 bpp with L_G4_ENCODE</param>
'''  <param name="boxa">[in][optional] - of image regions; can be null</param>
'''  <param name="quality">[in] - used for jpeg image regions; 0 for default</param>
'''  <param name="scalefactor">[in] - used for jpeg regions; must be LT= 1.0</param>
'''  <param name="title">[in][optional] - pdf title; typically taken from the input file for the pix</param>
'''  <param name="fileout">[in] - output pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixConvertToPdfSegmented(
				ByVal pixs as Pix, 
				ByVal res as Integer, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal thresh as Enumerations.L_ENCODE, 
				ByVal boxa as Boxa, 
				ByVal quality as Integer, 
				ByVal scalefactor as Single, 
				ByVal title as String, 
				ByVal fileout as String) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

	Dim boxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxa) Then boxaPTR = boxa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixConvertToPdfSegmented( pixs.Pointer, res, type, thresh, boxaPTR, quality, scalefactor, title, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (1767, 1)
' convertToPdfDataSegmented()
' convertToPdfDataSegmented(const char *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) If there are no image regions, set %boxa == NULL;
''' %quality and %scalefactor are ignored.
''' (2) Typically, %scalefactor is LT 1.0.  The image regions are
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - input image file -- any format</param>
'''  <param name="res">[in] - input image resolution; typ. 300 ppi; use 0 for default</param>
'''  <param name="type">[in] - compression type for non-image regions; the image regions are always compressed with L_JPEG_ENCODE</param>
'''  <param name="thresh">[in] - used for converting gray --GT 1 bpp with L_G4_ENCODE</param>
'''  <param name="boxa">[in][optional] - image regions; can be null</param>
'''  <param name="quality">[in] - used for jpeg image regions; 0 for default</param>
'''  <param name="scalefactor">[in] - used for jpeg regions; must be LT= 1.0</param>
'''  <param name="title">[in][optional] - pdf title; if null, uses filein</param>
'''  <param name="pdata">[out] - pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertToPdfDataSegmented(
				ByVal filein as String, 
				ByVal res as Integer, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal thresh as Enumerations.L_ENCODE, 
				ByVal boxa as Boxa, 
				ByVal quality as Integer, 
				ByVal scalefactor as Single, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")

	Dim boxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxa) Then boxaPTR = boxa.Pointer
	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPdfDataSegmented( filein, res, type, thresh, boxaPTR, quality, scalefactor, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (1834, 1)
' pixConvertToPdfDataSegmented()
' pixConvertToPdfDataSegmented(PIX *, l_int32, l_int32, l_int32, BOXA *, l_int32, l_float32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) See convertToPdfSegmented() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - any depth, cmap OK</param>
'''  <param name="res">[in] - input image resolution; typ. 300 ppi; use 0 for default</param>
'''  <param name="type">[in] - compression type for non-image regions; the image regions are always compressed with L_JPEG_ENCODE</param>
'''  <param name="thresh">[in] - used for converting gray --GT 1 bpp with L_G4_ENCODE</param>
'''  <param name="boxa">[in][optional] - of image regions; can be null</param>
'''  <param name="quality">[in] - used for jpeg image regions; 0 for default</param>
'''  <param name="scalefactor">[in] - used for jpeg regions; must be LT= 1.0</param>
'''  <param name="title">[in][optional] - pdf title; typically taken from the input file for the pix</param>
'''  <param name="pdata">[out] - pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixConvertToPdfDataSegmented(
				ByVal pixs as Pix, 
				ByVal res as Integer, 
				ByVal type as Enumerations.L_ENCODE, 
				ByVal thresh as Enumerations.L_ENCODE, 
				ByVal boxa as Boxa, 
				ByVal quality as Integer, 
				ByVal scalefactor as Single, 
				ByVal title as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")

	Dim boxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(boxa) Then boxaPTR = boxa.Pointer
	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixConvertToPdfDataSegmented( pixs.Pointer, res, type, thresh, boxaPTR, quality, scalefactor, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (1998, 1)
' concatenatePdf()
' concatenatePdf(const char *, const char *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This only works with leptonica-formatted single-page pdf files.
''' (2) If %substr is not NULL, only filenames that contain
''' the substring can be returned.  If %substr == NULL,
''' none of the filenames are filtered out.
''' (3) The files in the directory, after optional filtering by
''' the substring, are lexically sorted in increasing order
''' before concatenation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing single-page pdf files</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="fileout">[in] - concatenated pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function concatenatePdf(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal fileout as String) as Integer

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.concatenatePdf( dirname, substr, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (2033, 1)
' saConcatenatePdf()
' saConcatenatePdf(SARRAY *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This only works with leptonica-formatted single-page pdf files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for single-page pdf files</param>
'''  <param name="fileout">[in] - concatenated pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConcatenatePdf(
				ByVal sa as Sarray, 
				ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.saConcatenatePdf( sa.Pointer, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (2069, 1)
' ptraConcatenatePdf()
' ptraConcatenatePdf(L_PTRA *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This only works with leptonica-formatted single-page pdf files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pa">[in] - array of pdf strings, each for a single-page pdf file</param>
'''  <param name="fileout">[in] - concatenated pdf file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptraConcatenatePdf(
				ByVal pa as L_Ptra, 
				ByVal fileout as String) as Integer

	If IsNothing (pa) then Throw New ArgumentNullException  ("pa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptraConcatenatePdf( pa.Pointer, fileout)

	Return _Result
End Function

' SRC\pdfio1.c (2113, 1)
' concatenatePdfToData()
' concatenatePdfToData(const char *, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) This only works with leptonica-formatted single-page pdf files.
''' (2) If %substr is not NULL, only filenames that contain
''' the substring can be returned.  If %substr == NULL,
''' none of the filenames are filtered out.
''' (3) The files in the directory, after optional filtering by
''' the substring, are lexically sorted in increasing order
''' before concatenation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name containing single-page pdf files</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="pdata">[out] - concatenated pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function concatenatePdfToData(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.concatenatePdfToData( dirname, substr, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pdfio1.c (2154, 1)
' saConcatenatePdfToData()
' saConcatenatePdfToData(SARRAY *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' Notes
''' (1) This only works with leptonica-formatted single-page pdf files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of pathnames for single-page pdf files</param>
'''  <param name="pdata">[out] - concatenated pdf data in memory</param>
'''  <param name="pnbytes">[out] - number of bytes in pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function saConcatenatePdfToData(
				ByVal sa as Sarray, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.saConcatenatePdfToData( sa.Pointer, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class

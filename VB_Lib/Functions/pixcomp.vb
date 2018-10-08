Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixcomp.c (185, 1)
' pixcompCreateFromPix(pix, comptype) as PixComp
' pixcompCreateFromPix(PIX *, l_int32) as PIXC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use %comptype == IFF_DEFAULT to have the compression<para/>
''' type automatically determined.<para/>
''' (2) To compress jpeg with a quality other than the default (75), use<para/>
''' l_jpegSetQuality()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromPix(
				 ByVal pix as Pix, 
				 ByVal comptype as Enumerations.IFF) as PixComp

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcompCreateFromPix( pix.Pointer, comptype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixComp(_Result)
End Function

' SRC\pixcomp.c (242, 1)
' pixcompCreateFromString(data, size, copyflag) as PixComp
' pixcompCreateFromString(l_uint8 *, size_t, l_int32) as PIXC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This works when the compressed string is png, jpeg or tiffg4.<para/>
''' (2) The copyflag determines if the data in the new Pixcomp is<para/>
''' a copy of the input data.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - compressed string</param>
'''  <param name="size">[in] - number of bytes</param>
'''  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromString(
				 ByVal data as Byte(), 
				 ByVal size as UInteger, 
				 ByVal copyflag as Enumerations.L_access_storage) as PixComp

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcompCreateFromString( data, size, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixComp(_Result)
End Function

' SRC\pixcomp.c (291, 1)
' pixcompCreateFromFile(filename, comptype) as PixComp
' pixcompCreateFromFile(const char *, l_int32) as PIXC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use %comptype == IFF_DEFAULT to have the compression<para/>
''' type automatically determined.<para/>
''' (2) If the comptype is invalid for this file, the default will<para/>
''' be substituted.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromFile(
				 ByVal filename as String, 
				 ByVal comptype as Enumerations.IFF) as PixComp

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcompCreateFromFile( filename, comptype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixComp(_Result)
End Function

' SRC\pixcomp.c (354, 1)
' pixcompDestroy(ppixc) as Object
' pixcompDestroy(PIXC **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppixc">[in,out] - will be nulled</param>
Public Shared Sub pixcompDestroy(
				 ByRef ppixc as PixComp)




	Dim ppixcPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixc) Then ppixcPTR = ppixc.Pointer

	LeptonicaSharp.Natives.pixcompDestroy( ppixcPTR)
	if ppixcPTR <> IntPtr.Zero then ppixc = new PixComp(ppixcPTR)

End Sub

' SRC\pixcomp.c (384, 1)
' pixcompCopy(pixcs) as PixComp
' pixcompCopy(PIXC *) as PIXC *
'''  <remarks>
'''  </remarks>
'''  <param name="pixcs">[in] - </param>
'''   <returns>pixcd, or NULL on error</returns>
Public Shared Function pixcompCopy(
				 ByVal pixcs as PixComp) as PixComp

	If IsNothing (pixcs) then Throw New ArgumentNullException  ("pixcs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixcompCopy( pixcs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixComp(_Result)
End Function

' SRC\pixcomp.c (429, 1)
' pixcompGetDimensions(pixc, pw, ph, pd) as Integer
' pixcompGetDimensions(PIXC *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixc">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompGetDimensions(
				 ByVal pixc as PixComp, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pd as Integer) as Integer

	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixcompGetDimensions( pixc.Pointer, pw, ph, pd)

	Return _Result
End Function

' SRC\pixcomp.c (453, 1)
' pixcompGetParameters(pixc, pxres, pyres, pcomptype, pcmapflag) as Integer
' pixcompGetParameters(PIXC *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixc">[in] - </param>
'''  <param name="pxres">[out][all optional] - </param>
'''  <param name="pyres">[out][all optional] - </param>
'''  <param name="pcomptype">[out][all optional] - </param>
'''  <param name="pcmapflag">[out][all optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompGetParameters(
				 ByVal pixc as PixComp, 
				<Out()> ByRef pxres as Integer, 
				<Out()> ByRef pyres as Integer, 
				<Out()> ByRef pcomptype as Integer, 
				<Out()> ByRef pcmapflag as Integer) as Integer

	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixcompGetParameters( pixc.Pointer, pxres, pyres, pcomptype, pcmapflag)

	Return _Result
End Function

' SRC\pixcomp.c (495, 1)
' pixcompDetermineFormat(comptype, d, cmapflag, pformat) as Integer
' pixcompDetermineFormat(l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This determines the best format for a pix, given both<para/>
''' the request (%comptype) and the image characteristics.<para/>
''' (2) If %comptype == IFF_DEFAULT, this does not necessarily result<para/>
''' in png encoding.  Instead, it returns one of the three formats<para/>
''' that is both valid and most likely to give best compression.<para/>
''' (3) If the pix cannot be compressed by the input value of<para/>
''' %comptype, this selects IFF_PNG, which can compress all pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''  <param name="d">[in] - pix depth</param>
'''  <param name="cmapflag">[in] - 1 if pix to be compressed as a colormap 0 otherwise</param>
'''  <param name="pformat">[out] - return IFF_TIFF, IFF_PNG or IFF_JFIF_JPEG</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcompDetermineFormat(
				 ByVal comptype as Enumerations.IFF, 
				 ByVal d as Integer, 
				 ByVal cmapflag as Integer, 
				<Out()> ByRef pformat as Integer) as Integer





	Dim _Result as Integer = LeptonicaSharp.Natives.pixcompDetermineFormat( comptype, d, cmapflag, pformat)

	Return _Result
End Function

' SRC\pixcomp.c (537, 1)
' pixCreateFromPixcomp(pixc) as Pix
' pixCreateFromPixcomp(PIXC *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixc">[in] - </param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixCreateFromPixcomp(
				 ByVal pixc as PixComp) as Pix

	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixCreateFromPixcomp( pixc.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixcomp.c (590, 1)
' pixacompCreate(n) as PixaComp
' pixacompCreate(l_int32) as PIXAC *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreate(
				 ByVal n as Integer) as PixaComp





	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (657, 1)
' pixacompCreateWithInit(n, offset, pix, comptype) as PixaComp
' pixacompCreateWithInit(l_int32, l_int32, PIX *, l_int32) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Initializes a pixacomp to be fully populated with %pix,<para/>
''' compressed using %comptype.  If %pix == NULL, %comptype<para/>
''' is ignored.<para/>
''' (2) Typically, the array is initialized with a tiny pix.<para/>
''' This is most easily done by setting %pix == NULL, causing<para/>
''' initialization of each array element with a tiny placeholder<para/>
''' pix (w = h = d = 1), using comptype = IFF_TIFF_G4 .<para/>
''' (3) Example usage:<para/>
''' // Generate pixacomp for pages 30 - 49.  This has an array<para/>
''' // size of 20 and the page number offset is 30.<para/>
''' PixaComp pixac = pixacompCreateWithInit(20, 30, NULL,<para/>
''' IFF_TIFF_G4)<para/>
''' // Now insert png-compressed images into the initialized array<para/>
''' for (pageno = 30 pageno  is lower  50 pageno++) {<para/>
''' Pix pixt = ... // derived from image[pageno]<para/>
''' if (pixt)<para/>
''' pixacompReplacePix(pixac, pageno, pixt, IFF_PNG)<para/>
''' pixDestroy( and pixt)<para/>
''' }<para/>
''' The result is a pixac with 20 compressed strings, and with<para/>
''' selected pixt replacing the placeholders.<para/>
''' To extract the image for page 38, which is decompressed<para/>
''' from element 8 in the array, use:<para/>
''' pixt = pixacompGetPix(pixac, 38)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of ptrs</param>
'''  <param name="offset">[in] - difference: accessor index - pixacomp array index</param>
'''  <param name="pix">[in][optional] - initialize each ptr in pixacomp to this pix can be NULL</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreateWithInit(
				 ByVal n as Integer, 
				 ByVal offset as Integer, 
				 ByVal pix as Pix, 
				 ByVal comptype as Enumerations.IFF) as PixaComp




	Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompCreateWithInit( n, offset, pixPTR, comptype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (721, 1)
' pixacompCreateFromPixa(pixa, comptype, accesstype) as PixaComp
' pixacompCreateFromPixa(PIXA *, l_int32, l_int32) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If %format == IFF_DEFAULT, the conversion format for each<para/>
''' image is chosen automatically.  Otherwise, we use the<para/>
''' specified format unless it can't be done (e.g., jpeg<para/>
''' for a 1, 2 or 4 bpp pix, or a pix with a colormap),<para/>
''' in which case we use the default (assumed best) compression.<para/>
''' (2) %accesstype is used to extract a boxa from %pixa.<para/>
''' (3) To compress jpeg with a quality other than the default (75), use<para/>
''' l_jpegSetQuality()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompCreateFromPixa(
				 ByVal pixa as Pixa, 
				 ByVal comptype as Enumerations.IFF, 
				 ByVal accesstype as Enumerations.L_access_storage) as PixaComp

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompCreateFromPixa( pixa.Pointer, comptype, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (780, 1)
' pixacompCreateFromFiles(dirname, substr, comptype) as PixaComp
' pixacompCreateFromFiles(const char *, const char *, l_int32) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %dirname is the full path for the directory.<para/>
''' (2) %substr is the part of the file name (excluding<para/>
''' the directory) that is to be matched.  All matching<para/>
''' filenames are read into the Pixa.  If substr is NULL,<para/>
''' all filenames are read into the Pixa.<para/>
''' (3) Use %comptype == IFF_DEFAULT to have the compression<para/>
''' type automatically determined for each file.<para/>
''' (4) If the comptype is invalid for a file, the default will<para/>
''' be substituted.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - </param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be null</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreateFromFiles(
				 ByVal dirname as String, 
				 ByVal substr as String, 
				 ByVal comptype as Enumerations.IFF) as PixaComp

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompCreateFromFiles( dirname, substr, comptype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (819, 1)
' pixacompCreateFromSA(sa, comptype) as PixaComp
' pixacompCreateFromSA(SARRAY *, l_int32) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use %comptype == IFF_DEFAULT to have the compression<para/>
''' type automatically determined for each file.<para/>
''' (2) If the comptype is invalid for a file, the default will<para/>
''' be substituted.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - full pathnames for all files</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreateFromSA(
				 ByVal sa as Sarray, 
				 ByVal comptype as Enumerations.IFF) as PixaComp

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompCreateFromSA( sa.Pointer, comptype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (861, 1)
' pixacompDestroy(ppixac) as Object
' pixacompDestroy(PIXAC **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppixac">[in,out] - to be nulled</param>
Public Shared Sub pixacompDestroy(
				 ByRef ppixac as PixaComp)




	Dim ppixacPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixac) Then ppixacPTR = ppixac.Pointer

	LeptonicaSharp.Natives.pixacompDestroy( ppixacPTR)
	if ppixacPTR <> IntPtr.Zero then ppixac = new PixaComp(ppixacPTR)

End Sub

' SRC\pixcomp.c (908, 1)
' pixacompAddPix(pixac, pix, comptype) as Integer
' pixacompAddPix(PIXAC *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The array is filled up to the (n-1)-th element, and this<para/>
''' converts the input pix to a pixc and adds it at<para/>
''' the n-th position.<para/>
''' (2) The pixc produced from the pix is owned by the pixac.<para/>
''' The input pix is not affected.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="pix">[in] - to be added</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompAddPix(
				 ByVal pixac as PixaComp, 
				 ByVal pix as Pix, 
				 ByVal comptype as Enumerations.IFF) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompAddPix( pixac.Pointer, pix.Pointer, comptype)

	Return _Result
End Function

' SRC\pixcomp.c (950, 1)
' pixacompAddPixcomp(pixac, pixc, copyflag) as Integer
' pixacompAddPixcomp(PIXAC *, PIXC *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Anything added to a pixac is owned by the pixac.<para/>
''' So do not L_INSERT a pixc that is owned by another pixac,<para/>
''' or destroy a pixc that has been L_INSERTed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="pixc">[in] - to be added by insertion</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompAddPixcomp(
				 ByVal pixac as PixaComp, 
				 ByVal pixc as PixComp, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompAddPixcomp( pixac.Pointer, pixc.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixcomp.c (1028, 1)
' pixacompReplacePix(pixac, index, pix, comptype) as Integer
' pixacompReplacePix(PIXAC *, l_int32, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
''' (2) The input %pix is converted to a pixc, which is then inserted<para/>
''' into the pixac.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="pix">[in] - owned by the caller</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompReplacePix(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				 ByVal pix as Pix, 
				 ByVal comptype as Enumerations.IFF) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompReplacePix( pixac.Pointer, index, pix.Pointer, comptype)

	Return _Result
End Function

' SRC\pixcomp.c (1073, 1)
' pixacompReplacePixcomp(pixac, index, pixc) as Integer
' pixacompReplacePixcomp(PIXAC *, l_int32, PIXC *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
''' (2) The inserted %pixc is now owned by the pixac.  The caller<para/>
''' must not destroy it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="pixc">[in] - to replace existing one, which is destroyed</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompReplacePixcomp(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				 ByVal pixc as PixComp) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompReplacePixcomp( pixac.Pointer, index, pixc.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1108, 1)
' pixacompAddBox(pixac, box, copyflag) as Integer
' pixacompAddBox(PIXAC *, BOX *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="box">[in] - </param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompAddBox(
				 ByVal pixac as PixaComp, 
				 ByVal box as Box, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompAddBox( pixac.Pointer, box.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixcomp.c (1136, 1)
' pixacompGetCount(pixac) as Integer
' pixacompGetCount(PIXAC *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''   <returns>count, or 0 if no pixa</returns>
Public Shared Function pixacompGetCount(
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompGetCount( pixac.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1164, 1)
' pixacompGetPixcomp(pixac, index, copyflag) as PixComp
' pixacompGetPixcomp(PIXAC *, l_int32, l_int32) as PIXC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
''' (2) If copyflag == L_NOCOPY, the pixc is owned by %pixac do<para/>
''' not destroy.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="copyflag">[in] - L_NOCOPY, L_COPY</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixacompGetPixcomp(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				 ByVal copyflag as Enumerations.L_access_storage) as PixComp

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompGetPixcomp( pixac.Pointer, index, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixComp(_Result)
End Function

' SRC\pixcomp.c (1201, 1)
' pixacompGetPix(pixac, index) as Pix
' pixacompGetPix(PIXAC *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixacompGetPix(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer) as Pix

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompGetPix( pixac.Pointer, index)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixcomp.c (1235, 1)
' pixacompGetPixDimensions(pixac, index, pw, ph, pd) as Integer
' pixacompGetPixDimensions(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''  <param name="pd">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompGetPixDimensions(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pd as Integer) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompGetPixDimensions( pixac.Pointer, index, pw, ph, pd)

	Return _Result
End Function

' SRC\pixcomp.c (1267, 1)
' pixacompGetBoxa(pixac, accesstype) as Boxa
' pixacompGetBoxa(PIXAC *, l_int32) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixacompGetBoxa(
				 ByVal pixac as PixaComp, 
				 ByVal accesstype as Enumerations.L_access_storage) as Boxa

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompGetBoxa( pixac.Pointer, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\pixcomp.c (1291, 1)
' pixacompGetBoxaCount(pixac) as Integer
' pixacompGetBoxaCount(PIXAC *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function pixacompGetBoxaCount(
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompGetBoxaCount( pixac.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1325, 1)
' pixacompGetBox(pixac, index, accesstype) as Box
' pixacompGetBox(PIXAC *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
''' (2) There is always a boxa with a pixac, and it is initialized so<para/>
''' that each box ptr is NULL.<para/>
''' (3) In general, we expect that there is either a box associated<para/>
''' with each pixc, or no boxes at all in the boxa.<para/>
''' (4) Having no boxes is thus not an automatic error.  Whether it<para/>
''' is an actual error is determined by the calling program.<para/>
''' If the caller expects to get a box, it is an error see, e.g.,<para/>
''' pixacGetBoxGeometry().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>box if null, not automatically an error, or NULL on error</returns>
Public Shared Function pixacompGetBox(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				 ByVal accesstype as Enumerations.L_access_storage) as Box

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompGetBox( pixac.Pointer, index, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\pixcomp.c (1371, 1)
' pixacompGetBoxGeometry(pixac, index, px, py, pw, ph) as Integer
' pixacompGetBoxGeometry(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The %index includes the offset, which must be subtracted<para/>
''' to get the actual index into the ptr array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="px">[out][optional] - each can be null</param>
'''  <param name="py">[out][optional] - each can be null</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompGetBoxGeometry(
				 ByVal pixac as PixaComp, 
				 ByVal index as Integer, 
				<Out()> ByRef px as Integer, 
				<Out()> ByRef py as Integer, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompGetBoxGeometry( pixac.Pointer, index, px, py, pw, ph)

	Return _Result
End Function

' SRC\pixcomp.c (1411, 1)
' pixacompGetOffset(pixac) as Integer
' pixacompGetOffset(PIXAC *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The offset is the difference between the caller's view of<para/>
''' the index into the array and the actual array index.<para/>
''' By default it is 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''   <returns>offset, or 0 on error</returns>
Public Shared Function pixacompGetOffset(
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompGetOffset( pixac.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1436, 1)
' pixacompSetOffset(pixac, offset) as Integer
' pixacompSetOffset(PIXAC *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The offset is the difference between the caller's view of<para/>
''' the index into the array and the actual array index.<para/>
''' By default it is 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="offset">[in] - non-negative</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompSetOffset(
				 ByVal pixac as PixaComp, 
				 ByVal offset as Integer) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompSetOffset( pixac.Pointer, offset)

	Return _Result
End Function

' SRC\pixcomp.c (1466, 1)
' pixaCreateFromPixacomp(pixac, accesstype) as Pixa
' pixaCreateFromPixacomp(PIXAC *, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Because the pixa has no notion of offset, the offset must<para/>
''' be set to 0 before the conversion, so that pixacompGetPix()<para/>
''' fetches all the pixcomps.  It is reset at the end.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE for boxa</param>
'''   <returns>pixa if OK, or NULL on error</returns>
Public Shared Function pixaCreateFromPixacomp(
				 ByVal pixac as PixaComp, 
				 ByVal accesstype as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCreateFromPixacomp( pixac.Pointer, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixcomp.c (1524, 1)
' pixacompJoin(pixacd, pixacs, istart, iend) as Integer
' pixacompJoin(PIXAC *, PIXAC *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a clone of each indicated pixc in pixcas to pixcad<para/>
''' (2) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (3) iend  is lower  0 means 'read to the end'<para/>
''' (4) If pixacs is NULL or contains no pixc, this is a no-op.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixacd">[in] - dest pixac add to this one</param>
'''  <param name="pixacs">[in][optional] - source pixac add from this one</param>
'''  <param name="istart">[in] - starting index in pixacs</param>
'''  <param name="iend">[in] - ending index in pixacs use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompJoin(
				 ByVal pixacd as PixaComp, 
				 ByVal pixacs as PixaComp, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (pixacd) then Throw New ArgumentNullException  ("pixacd cannot be Nothing")



	Dim pixacsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixacs) Then pixacsPTR = pixacs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompJoin( pixacd.Pointer, pixacsPTR, istart, iend)

	Return _Result
End Function

' SRC\pixcomp.c (1577, 1)
' pixacompInterleave(pixac1, pixac2) as PixaComp
' pixacompInterleave(PIXAC *, PIXAC *) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the two pixac have different sizes, a warning is issued,<para/>
''' and the number of pairs returned is the minimum size.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac1">[in] - first src pixac</param>
'''  <param name="pixac2">[in] - second src pixac</param>
'''   <returns>pixacd  interleaved from sources, or NULL on error.</returns>
Public Shared Function pixacompInterleave(
				 ByVal pixac1 as PixaComp, 
				 ByVal pixac2 as PixaComp) as PixaComp

	If IsNothing (pixac1) then Throw New ArgumentNullException  ("pixac1 cannot be Nothing")
	If IsNothing (pixac2) then Throw New ArgumentNullException  ("pixac2 cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompInterleave( pixac1.Pointer, pixac2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (1639, 1)
' pixacompRead(filename) as PixaComp
' pixacompRead(const char *) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Unlike the situation with serialized Pixa, where the image<para/>
''' data is stored in png format, the Pixacomp image data<para/>
''' can be stored in tiffg4, png and jpg formats.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompRead(
				 ByVal filename as String) as PixaComp

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (1666, 1)
' pixacompReadStream(fp) as PixaComp
' pixacompReadStream(FILE *) as PIXAC *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompReadStream(
				 ByVal fp as FILE) as PixaComp

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (1764, 1)
' pixacompReadMem(data, size) as PixaComp
' pixacompReadMem(const l_uint8 *, size_t) as PIXAC *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Deseralizes a buffer of pixacomp data into a pixac in memory.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const pixacomp format</param>
'''  <param name="size">[in] - of data</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompReadMem(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as PixaComp

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new PixaComp(_Result)
End Function

' SRC\pixcomp.c (1799, 1)
' pixacompWrite(filename, pixac) as Integer
' pixacompWrite(const char *, PIXAC *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Unlike the situation with serialized Pixa, where the image<para/>
''' data is stored in png format, the Pixacomp image data<para/>
''' can be stored in tiffg4, png and jpg formats.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWrite(
				 ByVal filename as String, 
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompWrite( filename, pixac.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1830, 1)
' pixacompWriteStream(fp, pixac) as Integer
' pixacompWriteStream(FILE *, PIXAC *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteStream(
				 ByVal fp as FILE, 
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompWriteStream( fp.Pointer, pixac.Pointer)

	Return _Result
End Function

' SRC\pixcomp.c (1878, 1)
' pixacompWriteMem(pdata, psize, pixac) as Integer
' pixacompWriteMem(l_uint8 **, size_t *, PIXAC *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a pixac in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - serialized data of pixac</param>
'''  <param name="psize">[out] - size of serialized data</param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteMem(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pixac as PixaComp) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompWriteMem( pdataPTR, psize, pixac.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pixcomp.c (1952, 1)
' pixacompConvertToPdf(pixac, res, scalefactor, type, quality, title, fileout) as Integer
' pixacompConvertToPdf(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This follows closely the function pixaConvertToPdf() in pdfio.c.<para/>
''' (2) The images are encoded with G4 if 1 bpp JPEG if 8 bpp without<para/>
''' colormap and many colors, or 32 bpp FLATE for anything else.<para/>
''' (3) The scalefactor must be  is greater  0.0 otherwise it is set to 1.0.<para/>
''' (4) Specifying one of the three encoding types for %type forces<para/>
''' all images to be compressed with that type.  Use 0 to have<para/>
''' the type determined for each image based on depth and whether<para/>
''' or not it has a colormap.<para/>
''' (5) If all images are jpeg compressed, don't require scaling<para/>
''' and have the same resolution, it is much faster to skip<para/>
''' transcoding with pixacompFastConvertToPdfData(), and then<para/>
''' write the data out to file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - containing images all at the same resolution</param>
'''  <param name="res">[in] - override the resolution of each input image, in ppi use 0 to respect the resolution embedded in the input</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or L_DEFAULT_ENCODE for default</param>
'''  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="fileout">[in] - pdf file of all images</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompConvertToPdf(
				 ByVal pixac as PixaComp, 
				 ByVal res as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal type as Enumerations.L_ENCODE, 
				 ByVal quality as Integer, 
				 ByVal title as String, 
				 ByVal fileout as String) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompConvertToPdf( pixac.Pointer, res, scalefactor, type, quality, title, fileout)

	Return _Result
End Function

' SRC\pixcomp.c (2004, 1)
' pixacompConvertToPdfData(pixac, res, scalefactor, type, quality, title, pdata, pnbytes) as Integer
' pixacompConvertToPdfData(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixacompConvertToPdf().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - containing images all at the same resolution</param>
'''  <param name="res">[in] - input resolution of all images</param>
'''  <param name="scalefactor">[in] - scaling factor applied to each image  is greater  0.0</param>
'''  <param name="type">[in] - encoding type (L_JPEG_ENCODE, L_G4_ENCODE, L_FLATE_ENCODE, or L_DEFAULT_ENCODE for default</param>
'''  <param name="quality">[in] - used for JPEG only 0 for default (75)</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="pdata">[out] - output pdf data (of all images</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompConvertToPdfData(
				 ByVal pixac as PixaComp, 
				 ByVal res as Integer, 
				 ByVal scalefactor as Single, 
				 ByVal type as Enumerations.L_ENCODE, 
				 ByVal quality as Integer, 
				 ByVal title as String, 
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompConvertToPdfData( pixac.Pointer, res, scalefactor, type, quality, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pixcomp.c (2115, 1)
' pixacompFastConvertToPdfData(pixac, title, pdata, pnbytes) as Integer
' pixacompFastConvertToPdfData(PIXAC *, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates the pdf without transcoding if all the<para/>
''' images in %pixac are compressed with jpeg.<para/>
''' Images not jpeg compressed are skipped.<para/>
''' (2) It assumes all images have the same resolution, and that<para/>
''' the resolution embedded in each jpeg file is correct.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - containing images all at the same resolution</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="pdata">[out] - output pdf data (of all images</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompFastConvertToPdfData(
				 ByVal pixac as PixaComp, 
				 ByVal title as String, 
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef pnbytes as UInteger) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompFastConvertToPdfData( pixac.Pointer, title, pdataPTR, pnbytes)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pixcomp.c (2240, 1)
' pixacompWriteStreamInfo(fp, pixac, text) as Integer
' pixacompWriteStreamInfo(FILE *, PIXAC *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixac">[in] - </param>
'''  <param name="text">[in][optional] - identifying string can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteStreamInfo(
				 ByVal fp as FILE, 
				 ByVal pixac as PixaComp, 
				 ByVal text as String) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompWriteStreamInfo( fp.Pointer, pixac.Pointer, text)

	Return _Result
End Function

' SRC\pixcomp.c (2284, 1)
' pixcompWriteStreamInfo(fp, pixc, text) as Integer
' pixcompWriteStreamInfo(FILE *, PIXC *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixc">[in] - </param>
'''  <param name="text">[in][optional] - identifying string can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompWriteStreamInfo(
				 ByVal fp as FILE, 
				 ByVal pixc as PixComp, 
				 ByVal text as String) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixcompWriteStreamInfo( fp.Pointer, pixc.Pointer, text)

	Return _Result
End Function

' SRC\pixcomp.c (2340, 1)
' pixacompDisplayTiledAndScaled(pixac, outdepth, tilewidth, ncols, background, spacing, border) as Pix
' pixacompDisplayTiledAndScaled(PIXAC *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is the same function as pixaDisplayTiledAndScaled(),<para/>
''' except it works on a Pixacomp instead of a Pix.  It is particularly<para/>
''' useful for showing the images in a Pixacomp at reduced resolution.<para/>
''' (2) See pixaDisplayTiledAndScaled() for details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="outdepth">[in] - output depth: 1, 8 or 32 bpp</param>
'''  <param name="tilewidth">[in] - each pix is scaled to this width</param>
'''  <param name="ncols">[in] - number of tiles in each row</param>
'''  <param name="background">[in] - 0 for white, 1 for black this is the color of the spacing between the images</param>
'''  <param name="spacing">[in] - between images, and on outside</param>
'''  <param name="border">[in] - width of additional black border on each image use 0 for no border</param>
'''   <returns>pix of tiled images, or NULL on error</returns>
Public Shared Function pixacompDisplayTiledAndScaled(
				 ByVal pixac as PixaComp, 
				 ByVal outdepth as Integer, 
				 ByVal tilewidth as Integer, 
				 ByVal ncols as Integer, 
				 ByVal background as Integer, 
				 ByVal spacing as Integer, 
				 ByVal border as Integer) as Pix

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixacompDisplayTiledAndScaled( pixac.Pointer, outdepth, tilewidth, ncols, background, spacing, border)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixcomp.c (2374, 1)
' pixacompWriteFiles(pixac, subdir) as Integer
' pixacompWriteFiles(PIXAC *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixac">[in] - </param>
'''  <param name="subdir">[in] - (subdirectory of /tmp)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteFiles(
				 ByVal pixac as PixaComp, 
				 ByVal subdir as String) as Integer

	If IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	If IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixacompWriteFiles( pixac.Pointer, subdir)

	Return _Result
End Function

' SRC\pixcomp.c (2414, 1)
' pixcompWriteFile(rootname, pixc) as Integer
' pixcompWriteFile(const char *, PIXC *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The compressed data is written to file, and the filename is<para/>
''' generated by appending the format extension to %rootname.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="rootname">[in] - </param>
'''  <param name="pixc">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompWriteFile(
				 ByVal rootname as String, 
				 ByVal pixc as PixComp) as Integer

	If IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixcompWriteFile( rootname, pixc.Pointer)

	Return _Result
End Function

End Class

Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' pixcomp.c (185, 1)
' pixcompCreateFromPix(pix, comptype) as PixComp
' pixcompCreateFromPix(PIX *, l_int32) as PIXC *
'''  <summary>
''' (1) Use %comptype == IFF_DEFAULT to have the compression
'''type automatically determined.<para/>
'''
'''(2) To compress jpeg with a quality other than the default (75), use
'''l_jpegSetQuality()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromPix/*"/>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromPix(
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as PixComp


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcompCreateFromPix(pix.Pointer,   comptype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixComp(_Result)
End Function

' pixcomp.c (242, 1)
' pixcompCreateFromString(data, size, copyflag) as PixComp
' pixcompCreateFromString(l_uint8 *, size_t, l_int32) as PIXC *
'''  <summary>
''' (1) This works when the compressed string is png, jpeg or tiffg4.<para/>
'''
'''(2) The copyflag determines if the data in the new Pixcomp is
'''a copy of the input data.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromString/*"/>
'''  <param name="data">[in] - compressed string</param>
'''  <param name="size">[in] - number of bytes</param>
'''  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromString(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				ByVal copyflag as Enumerations.L_access_storage) as PixComp


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcompCreateFromString(  data,   size,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixComp(_Result)
End Function

' pixcomp.c (291, 1)
' pixcompCreateFromFile(filename, comptype) as PixComp
' pixcompCreateFromFile(const char *, l_int32) as PIXC *
'''  <summary>
''' (1) Use %comptype == IFF_DEFAULT to have the compression
'''type automatically determined.<para/>
'''
'''(2) If the comptype is invalid for this file, the default will
'''be substituted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCreateFromFile/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixcompCreateFromFile(
				ByVal filename as String, 
				ByVal comptype as Enumerations.IFF) as PixComp


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.pixcompCreateFromFile(  filename,   comptype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixComp(_Result)
End Function

' pixcomp.c (354, 1)
' pixcompDestroy(ppixc) as Object
' pixcompDestroy(PIXC **) as void
'''  <summary>
''' (1) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompDestroy/*"/>
'''  <param name="ppixc">[in,out] - will be nulled</param>
Public Shared Sub pixcompDestroy(
				ByRef ppixc as PixComp)


	Dim ppixcPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(ppixc) Then ppixcPtr = ppixc.Pointer

	Natives.pixcompDestroy( ppixcPtr)
	
	if ppixcPtr = IntPtr.Zero then ppixc = Nothing else ppixc = new PixComp(ppixcPtr)
End Sub

' pixcomp.c (384, 1)
' pixcompCopy(pixcs) as PixComp
' pixcompCopy(PIXC *) as PIXC *
'''  <summary>
''' pixcompCopy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompCopy/*"/>
'''  <param name="pixcs">[in] - </param>
'''   <returns>pixcd, or NULL on error</returns>
Public Shared Function pixcompCopy(
				ByVal pixcs as PixComp) as PixComp


if IsNothing (pixcs) then Throw New ArgumentNullException  ("pixcs cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixcompCopy(pixcs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixComp(_Result)
End Function

' pixcomp.c (429, 1)
' pixcompGetDimensions(pixc, pw, ph, pd) as Integer
' pixcompGetDimensions(PIXC *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' pixcompGetDimensions()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompGetDimensions/*"/>
'''  <param name="pixc">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompGetDimensions(
				ByVal pixc as PixComp, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pd as Integer = 0) as Integer


if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixcompGetDimensions(pixc.Pointer,   pw,   ph,   pd)
	
	return _Result
End Function

' pixcomp.c (453, 1)
' pixcompGetParameters(pixc, pxres, pyres, pcomptype, pcmapflag) as Integer
' pixcompGetParameters(PIXC *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' pixcompGetParameters()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompGetParameters/*"/>
'''  <param name="pixc">[in] - </param>
'''  <param name="pxres">[out][all optional] - </param>
'''  <param name="pyres">[out][all optional] - </param>
'''  <param name="pcomptype">[out][all optional] - </param>
'''  <param name="pcmapflag">[out][all optional] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompGetParameters(
				ByVal pixc as PixComp, 
				<Out()> Optional  ByRef pxres as Integer = 0, 
				<Out()> Optional  ByRef pyres as Integer = 0, 
				<Out()> Optional  ByRef pcomptype as Integer = 0, 
				<Out()> Optional  ByRef pcmapflag as Integer = 0) as Integer


if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixcompGetParameters(pixc.Pointer,   pxres,   pyres,   pcomptype,   pcmapflag)
	
	return _Result
End Function

' pixcomp.c (495, 1)
' pixcompDetermineFormat(comptype, d, cmapflag, pformat) as Integer
' pixcompDetermineFormat(l_int32, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' (1) This determines the best format for a pix, given both
'''the request (%comptype) and the image characteristics.<para/>
'''
'''(2) If %comptype == IFF_DEFAULT, this does not necessarily result
'''in png encoding.  Instead, it returns one of the three formats
'''that is both valid and most likely to give best compression.<para/>
'''
'''(3) If the pix cannot be compressed by the input value of
'''%comptype, this selects IFF_PNG, which can compress all pix.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompDetermineFormat/*"/>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''  <param name="d">[in] - pix depth</param>
'''  <param name="cmapflag">[in] - 1 if pix to be compressed as a colormap 0 otherwise</param>
'''  <param name="pformat">[out] - return IFF_TIFF, IFF_PNG or IFF_JFIF_JPEG</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixcompDetermineFormat(
				ByVal comptype as Enumerations.IFF, 
				ByVal d as Integer, 
				ByVal cmapflag as Integer, 
				<Out()>  ByRef pformat as Integer) as Integer


	Dim _Result as Integer = Natives.pixcompDetermineFormat(  comptype,   d,   cmapflag,   pformat)
	
	return _Result
End Function

' pixcomp.c (537, 1)
' pixCreateFromPixcomp(pixc) as Pix
' pixCreateFromPixcomp(PIXC *) as PIX *
'''  <summary>
''' pixCreateFromPixcomp()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixCreateFromPixcomp/*"/>
'''  <param name="pixc">[in] - </param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixCreateFromPixcomp(
				ByVal pixc as PixComp) as Pix


if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixCreateFromPixcomp(pixc.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pixcomp.c (590, 1)
' pixacompCreate(n) as PixaComp
' pixacompCreate(l_int32) as PIXAC *
'''  <summary>
''' pixacompCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreate/*"/>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreate(
				ByVal n as Integer) as PixaComp


	Dim _Result as IntPtr = Natives.pixacompCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (657, 1)
' pixacompCreateWithInit(n, offset, pix, comptype) as PixaComp
' pixacompCreateWithInit(l_int32, l_int32, PIX *, l_int32) as PIXAC *
'''  <summary>
''' (1) Initializes a pixacomp to be fully populated with %pix,
'''compressed using %comptype.  If %pix == NULL, %comptype
'''is ignored.<para/>
'''
'''(2) Typically, the array is initialized with a tiny pix.
'''This is most easily done by setting %pix == NULL, causing
'''initialization of each array element with a tiny placeholder
'''pix (w = h = d = 1), using comptype = IFF_TIFF_G4 .<para/>
'''
'''(3) Example usage:
'''// Generate pixacomp for pages 30 - 49.  This has an array
'''// size of 20 and the page number offset is 30.
'''PixaComp pixac = pixacompCreateWithInit(20, 30, NULL,
'''IFF_TIFF_G4)
'''// Now insert png-compressed images into the initialized array
'''for (pageno = 30 pageno  is smaller 50 pageno++) {
'''Pix pixt = ... // derived from image[pageno]
'''if (pixt)
'''pixacompReplacePix(pixac, pageno, pixt, IFF_PNG)
'''pixDestroy([and]pixt)
'''}
'''The result is a pixac with 20 compressed strings, and with
'''selected pixt replacing the placeholders.
'''To extract the image for page 38, which is decompressed
'''from element 8 in the array, use:
'''pixt = pixacompGetPix(pixac, 38)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateWithInit/*"/>
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


	Dim pixPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as IntPtr = Natives.pixacompCreateWithInit(  n,   offset, pixPtr,   comptype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (721, 1)
' pixacompCreateFromPixa(pixa, comptype, accesstype) as PixaComp
' pixacompCreateFromPixa(PIXA *, l_int32, l_int32) as PIXAC *
'''  <summary>
''' (1) If %format == IFF_DEFAULT, the conversion format for each
'''image is chosen automatically.  Otherwise, we use the
'''specified format unless it can't be done (e.g., jpeg
'''for a 1, 2 or 4 bpp pix, or a pix with a colormap),
'''in which case we use the default (assumed best) compression.<para/>
'''
'''(2) %accesstype is used to extract a boxa from %pixa.<para/>
'''
'''(3) To compress jpeg with a quality other than the default (75), use
'''l_jpegSetQuality()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromPixa/*"/>
'''  <param name="pixa">[in] - </param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompCreateFromPixa(
				ByVal pixa as Pixa, 
				ByVal comptype as Enumerations.IFF, 
				ByVal accesstype as Enumerations.L_access_storage) as PixaComp


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompCreateFromPixa(pixa.Pointer,   comptype,   accesstype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (780, 1)
' pixacompCreateFromFiles(dirname, substr, comptype) as PixaComp
' pixacompCreateFromFiles(const char *, const char *, l_int32) as PIXAC *
'''  <summary>
''' (1) %dirname is the full path for the directory.<para/>
'''
'''(2) %substr is the part of the file name (excluding
'''the directory) that is to be matched.  All matching
'''filenames are read into the Pixa.  If substr is NULL,
'''all filenames are read into the Pixa.<para/>
'''
'''(3) Use %comptype == IFF_DEFAULT to have the compression
'''type automatically determined for each file.<para/>
'''
'''(4) If the comptype is invalid for a file, the default will
'''be substituted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromFiles/*"/>
'''  <param name="dirname">[in] - </param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be null</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreateFromFiles(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal comptype as Enumerations.IFF) as PixaComp


if IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompCreateFromFiles(  dirname,   substr,   comptype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (819, 1)
' pixacompCreateFromSA(sa, comptype) as PixaComp
' pixacompCreateFromSA(SARRAY *, l_int32) as PIXAC *
'''  <summary>
''' (1) Use %comptype == IFF_DEFAULT to have the compression
'''type automatically determined for each file.<para/>
'''
'''(2) If the comptype is invalid for a file, the default will
'''be substituted.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompCreateFromSA/*"/>
'''  <param name="sa">[in] - full pathnames for all files</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompCreateFromSA(
				ByVal sa as Sarray, 
				ByVal comptype as Enumerations.IFF) as PixaComp


if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompCreateFromSA(sa.Pointer,   comptype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (861, 1)
' pixacompDestroy(ppixac) as Object
' pixacompDestroy(PIXAC **) as void
'''  <summary>
''' (1) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompDestroy/*"/>
'''  <param name="ppixac">[in,out] - to be nulled</param>
Public Shared Sub pixacompDestroy(
				ByRef ppixac as PixaComp)


	Dim ppixacPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(ppixac) Then ppixacPtr = ppixac.Pointer

	Natives.pixacompDestroy( ppixacPtr)
	
	if ppixacPtr = IntPtr.Zero then ppixac = Nothing else ppixac = new PixaComp(ppixacPtr)
End Sub

' pixcomp.c (908, 1)
' pixacompAddPix(pixac, pix, comptype) as Integer
' pixacompAddPix(PIXAC *, PIX *, l_int32) as l_ok
'''  <summary>
''' (1) The array is filled up to the (n-1)-th element, and this
'''converts the input pix to a pixc and adds it at
'''the n-th position.<para/>
'''
'''(2) The pixc produced from the pix is owned by the pixac.
'''The input pix is not affected.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddPix/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="pix">[in] - to be added</param>
'''  <param name="comptype">[in] - IFF_DEFAULT, IFF_TIFF_G4, IFF_PNG, IFF_JFIF_JPEG</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompAddPix(
				ByVal pixac as PixaComp, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompAddPix(pixac.Pointer, pix.Pointer,   comptype)
	
	return _Result
End Function

' pixcomp.c (950, 1)
' pixacompAddPixcomp(pixac, pixc, copyflag) as Integer
' pixacompAddPixcomp(PIXAC *, PIXC *, l_int32) as l_ok
'''  <summary>
''' (1) Anything added to a pixac is owned by the pixac.
'''So do not L_INSERT a pixc that is owned by another pixac,
'''or destroy a pixc that has been L_INSERTed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddPixcomp/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="pixc">[in] - to be added by insertion</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompAddPixcomp(
				ByVal pixac as PixaComp, 
				ByVal pixc as PixComp, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompAddPixcomp(pixac.Pointer, pixc.Pointer,   copyflag)
	
	return _Result
End Function

' pixcomp.c (1028, 1)
' pixacompReplacePix(pixac, index, pix, comptype) as Integer
' pixacompReplacePix(PIXAC *, l_int32, PIX *, l_int32) as l_ok
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.<para/>
'''
'''(2) The input %pix is converted to a pixc, which is then inserted
'''into the pixac.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReplacePix/*"/>
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


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompReplacePix(pixac.Pointer,   index, pix.Pointer,   comptype)
	
	return _Result
End Function

' pixcomp.c (1073, 1)
' pixacompReplacePixcomp(pixac, index, pixc) as Integer
' pixacompReplacePixcomp(PIXAC *, l_int32, PIXC *) as l_ok
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.<para/>
'''
'''(2) The inserted %pixc is now owned by the pixac.  The caller
'''must not destroy it.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReplacePixcomp/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="pixc">[in] - to replace existing one, which is destroyed</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixacompReplacePixcomp(
				ByVal pixac as PixaComp, 
				ByVal index as Integer, 
				ByVal pixc as PixComp) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompReplacePixcomp(pixac.Pointer,   index, pixc.Pointer)
	
	return _Result
End Function

' pixcomp.c (1108, 1)
' pixacompAddBox(pixac, box, copyflag) as Integer
' pixacompAddBox(PIXAC *, BOX *, l_int32) as l_ok
'''  <summary>
''' pixacompAddBox()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompAddBox/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="box">[in] - </param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompAddBox(
				ByVal pixac as PixaComp, 
				ByVal box as Box, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompAddBox(pixac.Pointer, box.Pointer,   copyflag)
	
	return _Result
End Function

' pixcomp.c (1136, 1)
' pixacompGetCount(pixac) as Integer
' pixacompGetCount(PIXAC *) as l_int32
'''  <summary>
''' pixacompGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetCount/*"/>
'''  <param name="pixac">[in] - </param>
'''   <returns>count, or 0 if no pixa</returns>
Public Shared Function pixacompGetCount(
				ByVal pixac as PixaComp) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompGetCount(pixac.Pointer)
	
	return _Result
End Function

' pixcomp.c (1164, 1)
' pixacompGetPixcomp(pixac, index, copyflag) as PixComp
' pixacompGetPixcomp(PIXAC *, l_int32, l_int32) as PIXC *
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.<para/>
'''
'''(2) If copyflag == L_NOCOPY, the pixc is owned by %pixac do
'''not destroy.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPixcomp/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="copyflag">[in] - L_NOCOPY, L_COPY</param>
'''   <returns>pixc, or NULL on error</returns>
Public Shared Function pixacompGetPixcomp(
				ByVal pixac as PixaComp, 
				ByVal index as Integer, 
				ByVal copyflag as Enumerations.L_access_storage) as PixComp


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompGetPixcomp(pixac.Pointer,   index,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixComp(_Result)
End Function

' pixcomp.c (1201, 1)
' pixacompGetPix(pixac, index) as Pix
' pixacompGetPix(PIXAC *, l_int32) as PIX *
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPix/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixacompGetPix(
				ByVal pixac as PixaComp, 
				ByVal index as Integer) as Pix


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompGetPix(pixac.Pointer,   index)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pixcomp.c (1235, 1)
' pixacompGetPixDimensions(pixac, index, pw, ph, pd) as Integer
' pixacompGetPixDimensions(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetPixDimensions/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''  <param name="pd">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompGetPixDimensions(
				ByVal pixac as PixaComp, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pd as Integer = 0) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompGetPixDimensions(pixac.Pointer,   index,   pw,   ph,   pd)
	
	return _Result
End Function

' pixcomp.c (1267, 1)
' pixacompGetBoxa(pixac, accesstype) as Boxa
' pixacompGetBoxa(PIXAC *, l_int32) as BOXA *
'''  <summary>
''' pixacompGetBoxa()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxa/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixacompGetBoxa(
				ByVal pixac as PixaComp, 
				ByVal accesstype as Enumerations.L_access_storage) as Boxa


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompGetBoxa(pixac.Pointer,   accesstype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' pixcomp.c (1291, 1)
' pixacompGetBoxaCount(pixac) as Integer
' pixacompGetBoxaCount(PIXAC *) as l_int32
'''  <summary>
''' pixacompGetBoxaCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxaCount/*"/>
'''  <param name="pixac">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function pixacompGetBoxaCount(
				ByVal pixac as PixaComp) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompGetBoxaCount(pixac.Pointer)
	
	return _Result
End Function

' pixcomp.c (1325, 1)
' pixacompGetBox(pixac, index, accesstype) as Box
' pixacompGetBox(PIXAC *, l_int32, l_int32) as BOX *
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.<para/>
'''
'''(2) There is always a boxa with a pixac, and it is initialized so
'''that each box ptr is NULL.<para/>
'''
'''(3) In general, we expect that there is either a box associated
'''with each pixc, or no boxes at all in the boxa.<para/>
'''
'''(4) Having no boxes is thus not an automatic error.  Whether it
'''is an actual error is determined by the calling program.
'''If the caller expects to get a box, it is an error see, e.g.,
'''pixacGetBoxGeometry().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBox/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="index">[in] - caller's view of index within pixac includes offset</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>box if null, not automatically an error, or NULL on error</returns>
Public Shared Function pixacompGetBox(
				ByVal pixac as PixaComp, 
				ByVal index as Integer, 
				ByVal accesstype as Enumerations.L_access_storage) as Box


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompGetBox(pixac.Pointer,   index,   accesstype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' pixcomp.c (1371, 1)
' pixacompGetBoxGeometry(pixac, index, px, py, pw, ph) as Integer
' pixacompGetBoxGeometry(PIXAC *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) The %index includes the offset, which must be subtracted
'''to get the actual index into the ptr array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetBoxGeometry/*"/>
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
				<Out()> Optional  ByRef px as Integer = 0, 
				<Out()> Optional  ByRef py as Integer = 0, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompGetBoxGeometry(pixac.Pointer,   index,   px,   py,   pw,   ph)
	
	return _Result
End Function

' pixcomp.c (1411, 1)
' pixacompGetOffset(pixac) as Integer
' pixacompGetOffset(PIXAC *) as l_int32
'''  <summary>
''' (1) The offset is the difference between the caller's view of
'''the index into the array and the actual array index.
'''By default it is 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompGetOffset/*"/>
'''  <param name="pixac">[in] - </param>
'''   <returns>offset, or 0 on error</returns>
Public Shared Function pixacompGetOffset(
				ByVal pixac as PixaComp) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompGetOffset(pixac.Pointer)
	
	return _Result
End Function

' pixcomp.c (1436, 1)
' pixacompSetOffset(pixac, offset) as Integer
' pixacompSetOffset(PIXAC *, l_int32) as l_ok
'''  <summary>
''' (1) The offset is the difference between the caller's view of
'''the index into the array and the actual array index.
'''By default it is 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompSetOffset/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="offset">[in] - non-negative</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompSetOffset(
				ByVal pixac as PixaComp, 
				ByVal offset as Integer) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompSetOffset(pixac.Pointer,   offset)
	
	return _Result
End Function

' pixcomp.c (1466, 1)
' pixaCreateFromPixacomp(pixac, accesstype) as Pixa
' pixaCreateFromPixacomp(PIXAC *, l_int32) as PIXA *
'''  <summary>
''' (1) Because the pixa has no notion of offset, the offset must
'''be set to 0 before the conversion, so that pixacompGetPix()
'''fetches all the pixcomps.  It is reset at the end.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaCreateFromPixacomp/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE for boxa</param>
'''   <returns>pixa if OK, or NULL on error</returns>
Public Shared Function pixaCreateFromPixacomp(
				ByVal pixac as PixaComp, 
				ByVal accesstype as Integer) as Pixa


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaCreateFromPixacomp(pixac.Pointer,   accesstype)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' pixcomp.c (1524, 1)
' pixacompJoin(pixacd, pixacs, istart, iend) as Integer
' pixacompJoin(PIXAC *, PIXAC *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) This appends a clone of each indicated pixc in pixcas to pixcad<para/>
'''
'''(2) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
'''
'''(3) iend  is smaller 0 means 'read to the end'<para/>
'''
'''(4) If pixacs is NULL or contains no pixc, this is a no-op.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompJoin/*"/>
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


if IsNothing (pixacd) then Throw New ArgumentNullException  ("pixacd cannot be Nothing")
	Dim pixacsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixacs) Then pixacsPtr = pixacs.Pointer

	Dim _Result as Integer = Natives.pixacompJoin(pixacd.Pointer, pixacsPtr,   istart,   iend)
	
	return _Result
End Function

' pixcomp.c (1577, 1)
' pixacompInterleave(pixac1, pixac2) as PixaComp
' pixacompInterleave(PIXAC *, PIXAC *) as PIXAC *
'''  <summary>
''' (1) If the two pixac have different sizes, a warning is issued,
'''and the number of pairs returned is the minimum size.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompInterleave/*"/>
'''  <param name="pixac1">[in] - first src pixac</param>
'''  <param name="pixac2">[in] - second src pixac</param>
'''   <returns>pixacd  interleaved from sources, or NULL on error.</returns>
Public Shared Function pixacompInterleave(
				ByVal pixac1 as PixaComp, 
				ByVal pixac2 as PixaComp) as PixaComp


if IsNothing (pixac1) then Throw New ArgumentNullException  ("pixac1 cannot be Nothing")
		if IsNothing (pixac2) then Throw New ArgumentNullException  ("pixac2 cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompInterleave(pixac1.Pointer, pixac2.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (1639, 1)
' pixacompRead(filename) as PixaComp
' pixacompRead(const char *) as PIXAC *
'''  <summary>
''' (1) Unlike the situation with serialized Pixa, where the image
'''data is stored in png format, the Pixacomp image data
'''can be stored in tiffg4, png and jpg formats.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompRead(
				ByVal filename as String) as PixaComp


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.pixacompRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (1666, 1)
' pixacompReadStream(fp) as PixaComp
' pixacompReadStream(FILE *) as PIXAC *
'''  <summary>
''' pixacompReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompReadStream(
				ByVal fp as FILE) as PixaComp


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (1764, 1)
' pixacompReadMem(data, size) as PixaComp
' pixacompReadMem(const l_uint8 *, size_t) as PIXAC *
'''  <summary>
''' (1) Deseralizes a buffer of pixacomp data into a pixac in memory.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompReadMem/*"/>
'''  <param name="data">[in] - const pixacomp format</param>
'''  <param name="size">[in] - of data</param>
'''   <returns>pixac, or NULL on error</returns>
Public Shared Function pixacompReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as PixaComp


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new PixaComp(_Result)
End Function

' pixcomp.c (1799, 1)
' pixacompWrite(filename, pixac) as Integer
' pixacompWrite(const char *, PIXAC *) as l_ok
'''  <summary>
''' (1) Unlike the situation with serialized Pixa, where the image
'''data is stored in png format, the Pixacomp image data
'''can be stored in tiffg4, png and jpg formats.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWrite(
				ByVal filename as String, 
				ByVal pixac as PixaComp) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompWrite(  filename, pixac.Pointer)
	
	return _Result
End Function

' pixcomp.c (1830, 1)
' pixacompWriteStream(fp, pixac) as Integer
' pixacompWriteStream(FILE *, PIXAC *) as l_ok
'''  <summary>
''' pixacompWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteStream(
				ByVal fp as FILE, 
				ByVal pixac as PixaComp) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompWriteStream(fp.Pointer, pixac.Pointer)
	
	return _Result
End Function

' pixcomp.c (1878, 1)
' pixacompWriteMem(pdata, psize, pixac) as Integer
' pixacompWriteMem(l_uint8 **, size_t *, PIXAC *) as l_ok
'''  <summary>
''' (1) Serializes a pixac in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteMem/*"/>
'''  <param name="pdata">[out] - serialized data of pixac</param>
'''  <param name="psize">[out] - size of serialized data</param>
'''  <param name="pixac">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pixac as PixaComp) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixacompWriteMem(  pdataPtr,   psize, pixac.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' pixcomp.c (1952, 1)
' pixacompConvertToPdf(pixac, res, scalefactor, type, quality, title, fileout) as Integer
' pixacompConvertToPdf(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, const char *) as l_ok
'''  <summary>
''' (1) This follows closely the function pixaConvertToPdf() in pdfio.c.<para/>
'''
'''(2) The images are encoded with G4 if 1 bpp JPEG if 8 bpp without
'''colormap and many colors, or 32 bpp FLATE for anything else.<para/>
'''
'''(3) The scalefactor must be  is greater  0.0 otherwise it is set to 1.0.<para/>
'''
'''(4) Specifying one of the three encoding types for %type forces
'''all images to be compressed with that type.  Use 0 to have
'''the type determined for each image based on depth and whether
'''or not it has a colormap.<para/>
'''
'''(5) If all images are jpeg compressed, don't require scaling
'''and have the same resolution, it is much faster to skip
'''transcoding with pixacompFastConvertToPdfData(), and then
'''write the data out to file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompConvertToPdf/*"/>
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
				ByVal type as Integer, 
				ByVal quality as Integer, 
				ByVal title as String, 
				ByVal fileout as String) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompConvertToPdf(pixac.Pointer,   res,   scalefactor,   type,   quality,   title,   fileout)
	
	return _Result
End Function

' pixcomp.c (2004, 1)
' pixacompConvertToPdfData(pixac, res, scalefactor, type, quality, title, pdata, pnbytes) as Integer
' pixacompConvertToPdfData(PIXAC *, l_int32, l_float32, l_int32, l_int32, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' (1) See pixacompConvertToPdf().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompConvertToPdfData/*"/>
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
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef pnbytes as UInteger) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixacompConvertToPdfData(pixac.Pointer,   res,   scalefactor,   type,   quality,   title,   pdataPtr,   pnbytes)
	
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' pixcomp.c (2115, 1)
' pixacompFastConvertToPdfData(pixac, title, pdata, pnbytes) as Integer
' pixacompFastConvertToPdfData(PIXAC *, const char *, l_uint8 **, size_t *) as l_ok
'''  <summary>
''' (1) This generates the pdf without transcoding if all the
'''images in %pixac are compressed with jpeg.
'''Images not jpeg compressed are skipped.<para/>
'''
'''(2) It assumes all images have the same resolution, and that
'''the resolution embedded in each jpeg file is correct.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompFastConvertToPdfData/*"/>
'''  <param name="pixac">[in] - containing images all at the same resolution</param>
'''  <param name="title">[in][optional] - pdf title</param>
'''  <param name="pdata">[out] - output pdf data (of all images</param>
'''  <param name="pnbytes">[out] - size of output pdf data</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompFastConvertToPdfData(
				ByVal pixac as PixaComp, 
				ByVal title as String, 
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef pnbytes as UInteger) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixacompFastConvertToPdfData(pixac.Pointer,   title,   pdataPtr,   pnbytes)
	
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' pixcomp.c (2240, 1)
' pixacompWriteStreamInfo(fp, pixac, text) as Integer
' pixacompWriteStreamInfo(FILE *, PIXAC *, const char *) as l_ok
'''  <summary>
''' pixacompWriteStreamInfo()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteStreamInfo/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixac">[in] - </param>
'''  <param name="text">[in][optional] - identifying string can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteStreamInfo(
				ByVal fp as FILE, 
				ByVal pixac as PixaComp, 
				Optional ByVal text as String = "") as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompWriteStreamInfo(fp.Pointer, pixac.Pointer,   text)
	
	return _Result
End Function

' pixcomp.c (2284, 1)
' pixcompWriteStreamInfo(fp, pixc, text) as Integer
' pixcompWriteStreamInfo(FILE *, PIXC *, const char *) as l_ok
'''  <summary>
''' pixcompWriteStreamInfo()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompWriteStreamInfo/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixc">[in] - </param>
'''  <param name="text">[in][optional] - identifying string can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompWriteStreamInfo(
				ByVal fp as FILE, 
				ByVal pixc as PixComp, 
				Optional ByVal text as String = "") as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixcompWriteStreamInfo(fp.Pointer, pixc.Pointer,   text)
	
	return _Result
End Function

' pixcomp.c (2340, 1)
' pixacompDisplayTiledAndScaled(pixac, outdepth, tilewidth, ncols, background, spacing, border) as Pix
' pixacompDisplayTiledAndScaled(PIXAC *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' (1) This is the same function as pixaDisplayTiledAndScaled(),
'''except it works on a Pixacomp instead of a Pix.  It is particularly
'''useful for showing the images in a Pixacomp at reduced resolution.<para/>
'''
'''(2) See pixaDisplayTiledAndScaled() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompDisplayTiledAndScaled/*"/>
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


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixacompDisplayTiledAndScaled(pixac.Pointer,   outdepth,   tilewidth,   ncols,   background,   spacing,   border)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pixcomp.c (2374, 1)
' pixacompWriteFiles(pixac, subdir) as Integer
' pixacompWriteFiles(PIXAC *, const char *) as l_ok
'''  <summary>
''' pixacompWriteFiles()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixacompWriteFiles/*"/>
'''  <param name="pixac">[in] - </param>
'''  <param name="subdir">[in] - (subdirectory of /tmp)</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixacompWriteFiles(
				ByVal pixac as PixaComp, 
				ByVal subdir as String) as Integer


if IsNothing (pixac) then Throw New ArgumentNullException  ("pixac cannot be Nothing")
		if IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")
	Dim _Result as Integer = Natives.pixacompWriteFiles(pixac.Pointer,   subdir)
	
	return _Result
End Function

' pixcomp.c (2414, 1)
' pixcompWriteFile(rootname, pixc) as Integer
' pixcompWriteFile(const char *, PIXC *) as l_ok
'''  <summary>
''' (1) The compressed data is written to file, and the filename is
'''generated by appending the format extension to %rootname.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixcompWriteFile/*"/>
'''  <param name="rootname">[in] - </param>
'''  <param name="pixc">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixcompWriteFile(
				ByVal rootname as String, 
				ByVal pixc as PixComp) as Integer


if IsNothing (rootname) then Throw New ArgumentNullException  ("rootname cannot be Nothing")
		if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	Dim _Result as Integer = Natives.pixcompWriteFile(  rootname, pixc.Pointer)
	
	return _Result
End Function

End Class



Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' psio1.c (154, 1)
' convertFilesToPS(dirin, substr, res, fileout) as Integer
' convertFilesToPS(const char *, const char *, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesToPS/*"/>
'''   <returns></returns>
Public Shared Function convertFilesToPS(
				ByVal dirin as String, 
				ByVal substr as String, 
				ByVal res as Integer, 
				ByVal fileout as String) as Integer


if IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
		if IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.convertFilesToPS(  dirin,   substr,   res,   fileout)
	
	return _Result
End Function

' psio1.c (201, 1)
' sarrayConvertFilesToPS(sa, res, fileout) as Integer
' sarrayConvertFilesToPS(SARRAY *, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayConvertFilesToPS/*"/>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesToPS(
				ByVal sa as Sarray, 
				ByVal res as Integer, 
				ByVal fileout as String) as Integer


if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim saPtr as IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPtr = sa.Pointer

	Dim _Result as Integer = Natives.sarrayConvertFilesToPS(sa.Pointer,   res,   fileout)
	
	return _Result
End Function

' psio1.c (269, 1)
' convertFilesFittedToPS(dirin, substr, xpts, ypts, fileout) as Integer
' convertFilesFittedToPS(const char *, const char *, l_float32, l_float32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesFittedToPS/*"/>
'''   <returns></returns>
Public Shared Function convertFilesFittedToPS(
				ByVal dirin as String, 
				ByVal substr as String, 
				ByVal xpts as Single, 
				ByVal ypts as Single, 
				ByVal fileout as String) as Integer


if IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
		if IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.convertFilesFittedToPS(  dirin,   substr,   xpts,   ypts,   fileout)
	
	return _Result
End Function

' psio1.c (321, 1)
' sarrayConvertFilesFittedToPS(sa, xpts, ypts, fileout) as Integer
' sarrayConvertFilesFittedToPS(SARRAY *, l_float32, l_float32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayConvertFilesFittedToPS/*"/>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesFittedToPS(
				ByVal sa as Sarray, 
				ByVal xpts as Single, 
				ByVal ypts as Single, 
				ByVal fileout as String) as Integer


if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim saPtr as IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPtr = sa.Pointer

	Dim _Result as Integer = Natives.sarrayConvertFilesFittedToPS(sa.Pointer,   xpts,   ypts,   fileout)
	
	return _Result
End Function

' psio1.c (391, 1)
' writeImageCompressedToPSFile(filein, fileout, res, pfirstfile, pindex) as Integer
' writeImageCompressedToPSFile(const char *, const char *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeImageCompressedToPSFile/*"/>
'''   <returns></returns>
Public Shared Function writeImageCompressedToPSFile(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal res as Integer, 
				ByVal pfirstfile as object, 
				ByVal pindex as object) as Integer


if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
		if IsNothing (pfirstfile) then Throw New ArgumentNullException  ("pfirstfile cannot be Nothing")
		if IsNothing (pindex) then Throw New ArgumentNullException  ("pindex cannot be Nothing")
	Dim _Result as Integer = Natives.writeImageCompressedToPSFile(  filein,   fileout,   res,   pfirstfile,   pindex)
	
	return _Result
End Function

' psio1.c (498, 1)
' convertSegmentedPagesToPS(pagedir, pagestr, page_numpre, maskdir, maskstr, mask_numpre, numpost, maxnum, textscale, imagescale, threshold, fileout) as Integer
' convertSegmentedPagesToPS(const char *, const char *, l_int32, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertSegmentedPagesToPS/*"/>
'''   <returns></returns>
Public Shared Function convertSegmentedPagesToPS(
				ByVal pagedir as String, 
				ByVal pagestr as String, 
				ByVal page_numpre as Integer, 
				ByVal maskdir as String, 
				ByVal maskstr as String, 
				ByVal mask_numpre as Integer, 
				ByVal numpost as Integer, 
				ByVal maxnum as Integer, 
				ByVal textscale as Single, 
				ByVal imagescale as Single, 
				ByVal threshold as Integer, 
				ByVal fileout as String) as Integer


if IsNothing (pagedir) then Throw New ArgumentNullException  ("pagedir cannot be Nothing")
		if IsNothing (pagestr) then Throw New ArgumentNullException  ("pagestr cannot be Nothing")
		if IsNothing (maskdir) then Throw New ArgumentNullException  ("maskdir cannot be Nothing")
		if IsNothing (maskstr) then Throw New ArgumentNullException  ("maskstr cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.convertSegmentedPagesToPS(  pagedir,   pagestr,   page_numpre,   maskdir,   maskstr,   mask_numpre,   numpost,   maxnum,   textscale,   imagescale,   threshold,   fileout)
	
	return _Result
End Function

' psio1.c (596, 1)
' pixWriteSegmentedPageToPS(pixs, pixm, textscale, imagescale, threshold, pageno, fileout) as Integer
' pixWriteSegmentedPageToPS(PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteSegmentedPageToPS/*"/>
'''   <returns></returns>
Public Shared Function pixWriteSegmentedPageToPS(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal textscale as Single, 
				ByVal imagescale as Single, 
				ByVal threshold as Integer, 
				ByVal pageno as Integer, 
				ByVal fileout as String) as Integer


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim pixsPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer
	Dim pixmPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPtr = pixm.Pointer

	Dim _Result as Integer = Natives.pixWriteSegmentedPageToPS(pixs.Pointer, pixm.Pointer,   textscale,   imagescale,   threshold,   pageno,   fileout)
	
	return _Result
End Function

' psio1.c (747, 1)
' pixWriteMixedToPS(pixb, pixc, scale, pageno, fileout) as Integer
' pixWriteMixedToPS(PIX *, PIX *, l_float32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMixedToPS/*"/>
'''   <returns></returns>
Public Shared Function pixWriteMixedToPS(
				ByVal pixb as Pix, 
				ByVal pixc as Pix, 
				ByVal scale as Single, 
				ByVal pageno as Integer, 
				ByVal fileout as String) as Integer


if IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
		if IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim pixbPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixb) Then pixbPtr = pixb.Pointer
	Dim pixcPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixc) Then pixcPtr = pixc.Pointer

	Dim _Result as Integer = Natives.pixWriteMixedToPS(pixb.Pointer, pixc.Pointer,   scale,   pageno,   fileout)
	
	return _Result
End Function

' psio1.c (834, 1)
' convertToPSEmbed(filein, fileout, level) as Integer
' convertToPSEmbed(const char *, const char *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertToPSEmbed/*"/>
'''   <returns></returns>
Public Shared Function convertToPSEmbed(
				ByVal filein as String, 
				ByVal fileout as String, 
				ByVal level as Integer) as Integer


if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.convertToPSEmbed(  filein,   fileout,   level)
	
	return _Result
End Function

' psio1.c (935, 1)
' pixaWriteCompressedToPS(pixa, fileout, res, level) as Integer
' pixaWriteCompressedToPS(PIXA *, const char *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteCompressedToPS/*"/>
'''   <returns></returns>
Public Shared Function pixaWriteCompressedToPS(
				ByVal pixa as Pixa, 
				ByVal fileout as String, 
				ByVal res as Integer, 
				ByVal level as Integer) as Integer


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim pixaPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixa) Then pixaPtr = pixa.Pointer

	Dim _Result as Integer = Natives.pixaWriteCompressedToPS(pixa.Pointer,   fileout,   res,   level)
	
	return _Result
End Function

End Class



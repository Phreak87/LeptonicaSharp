Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\psio1.c (154, 1)
' 
' convertFilesToPS(const char *, const char *, l_int32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertFilesToPS(
				ByRef dirin as String, 
				ByRef substr as String, 
				ByRef res as Integer, 
				ByRef fileout as String) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesToPS( dirin, substr, res, fileout)

	Return _Result
End Function

' SRC\psio1.c (201, 1)
' 
' sarrayConvertFilesToPS(SARRAY *, l_int32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesToPS(
				ByRef sa as Sarray, 
				ByRef res as Integer, 
				ByRef fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayConvertFilesToPS( sa.Pointer, res, fileout)

	Return _Result
End Function

' SRC\psio1.c (269, 1)
' 
' convertFilesFittedToPS(const char *, const char *, l_float32, l_float32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertFilesFittedToPS(
				ByRef dirin as String, 
				ByRef substr as String, 
				ByRef xpts as Single, 
				ByRef ypts as Single, 
				ByRef fileout as String) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
	If IsNothing (xpts) then Throw New ArgumentNullException  ("xpts cannot be Nothing")
	If IsNothing (ypts) then Throw New ArgumentNullException  ("ypts cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesFittedToPS( dirin, substr, xpts, ypts, fileout)

	Return _Result
End Function

' SRC\psio1.c (321, 1)
' 
' sarrayConvertFilesFittedToPS(SARRAY *, l_float32, l_float32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesFittedToPS(
				ByRef sa as Sarray, 
				ByRef xpts as Single, 
				ByRef ypts as Single, 
				ByRef fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (xpts) then Throw New ArgumentNullException  ("xpts cannot be Nothing")
	If IsNothing (ypts) then Throw New ArgumentNullException  ("ypts cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayConvertFilesFittedToPS( sa.Pointer, xpts, ypts, fileout)

	Return _Result
End Function

' SRC\psio1.c (391, 1)
' 
' writeImageCompressedToPSFile(const char *, const char *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function writeImageCompressedToPSFile(
				ByRef filein as String, 
				ByRef fileout as String, 
				ByRef res as Integer, 
				ByRef pfirstfile as Object, 
				ByRef pindex as Object) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (pfirstfile) then Throw New ArgumentNullException  ("pfirstfile cannot be Nothing")
	If IsNothing (pindex) then Throw New ArgumentNullException  ("pindex cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.writeImageCompressedToPSFile( filein, fileout, res, pfirstfile, pindex)

	Return _Result
End Function

' SRC\psio1.c (498, 1)
' 
' convertSegmentedPagesToPS(const char *, const char *, l_int32, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertSegmentedPagesToPS(
				ByRef pagedir as String, 
				ByRef pagestr as String, 
				ByRef page_numpre as Integer, 
				ByRef maskdir as String, 
				ByRef maskstr as String, 
				ByRef mask_numpre as Integer, 
				ByRef numpost as Integer, 
				ByRef maxnum as Integer, 
				ByRef textscale as Single, 
				ByRef imagescale as Single, 
				ByRef threshold as Integer, 
				ByRef fileout as String) as Integer

	If IsNothing (pagedir) then Throw New ArgumentNullException  ("pagedir cannot be Nothing")
	If IsNothing (pagestr) then Throw New ArgumentNullException  ("pagestr cannot be Nothing")
	If IsNothing (maskdir) then Throw New ArgumentNullException  ("maskdir cannot be Nothing")
	If IsNothing (maskstr) then Throw New ArgumentNullException  ("maskstr cannot be Nothing")
	If IsNothing (textscale) then Throw New ArgumentNullException  ("textscale cannot be Nothing")
	If IsNothing (imagescale) then Throw New ArgumentNullException  ("imagescale cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertSegmentedPagesToPS( pagedir, pagestr, page_numpre, maskdir, maskstr, mask_numpre, numpost, maxnum, textscale, imagescale, threshold, fileout)

	Return _Result
End Function

' SRC\psio1.c (596, 1)
' 
' pixWriteSegmentedPageToPS(PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteSegmentedPageToPS(
				ByRef pixs as Pix, 
				ByRef pixm as Pix, 
				ByRef textscale as Single, 
				ByRef imagescale as Single, 
				ByRef threshold as Integer, 
				ByRef pageno as Integer, 
				ByRef fileout as String) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (textscale) then Throw New ArgumentNullException  ("textscale cannot be Nothing")
	If IsNothing (imagescale) then Throw New ArgumentNullException  ("imagescale cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer
Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteSegmentedPageToPS( pixs.Pointer, pixm.Pointer, textscale, imagescale, threshold, pageno, fileout)

	Return _Result
End Function

' SRC\psio1.c (747, 1)
' 
' pixWriteMixedToPS(PIX *, PIX *, l_float32, l_int32, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteMixedToPS(
				ByRef pixb as Pix, 
				ByRef pixc as Pix, 
				ByRef scale as Single, 
				ByRef pageno as Integer, 
				ByRef fileout as String) as Integer

	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

Dim pixbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixb) Then pixbPTR = pixb.Pointer
Dim pixcPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixc) Then pixcPTR = pixc.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMixedToPS( pixb.Pointer, pixc.Pointer, scale, pageno, fileout)

	Return _Result
End Function

' SRC\psio1.c (834, 1)
' 
' convertToPSEmbed(const char *, const char *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertToPSEmbed(
				ByRef filein as String, 
				ByRef fileout as String, 
				ByRef level as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPSEmbed( filein, fileout, level)

	Return _Result
End Function

' SRC\psio1.c (935, 1)
' 
' pixaWriteCompressedToPS(PIXA *, const char *, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixaWriteCompressedToPS(
				ByRef pixa as Pixa, 
				ByRef fileout as String, 
				ByRef res as Integer, 
				ByRef level as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")

Dim pixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixa) Then pixaPTR = pixa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteCompressedToPS( pixa.Pointer, fileout, res, level)

	Return _Result
End Function

End Class

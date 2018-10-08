Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\psio1.c (154, 1)
' convertFilesToPS(dirin, substr, res, fileout) as Integer
' convertFilesToPS(const char *, const char *, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertFilesToPS(
				 ByVal dirin as String, 
				 ByVal substr as String, 
				 ByVal res as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesToPS( dirin, substr, res, fileout)

	Return _Result
End Function

' SRC\psio1.c (201, 1)
' sarrayConvertFilesToPS(sa, res, fileout) as Integer
' sarrayConvertFilesToPS(SARRAY *, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesToPS(
				 ByVal sa as Sarray, 
				 ByVal res as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")



Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayConvertFilesToPS( sa.Pointer, res, fileout)

	Return _Result
End Function

' SRC\psio1.c (269, 1)
' convertFilesFittedToPS(dirin, substr, xpts, ypts, fileout) as Integer
' convertFilesFittedToPS(const char *, const char *, l_float32, l_float32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertFilesFittedToPS(
				 ByVal dirin as String, 
				 ByVal substr as String, 
				 ByVal xpts as Single, 
				 ByVal ypts as Single, 
				 ByVal fileout as String) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesFittedToPS( dirin, substr, xpts, ypts, fileout)

	Return _Result
End Function

' SRC\psio1.c (321, 1)
' sarrayConvertFilesFittedToPS(sa, xpts, ypts, fileout) as Integer
' sarrayConvertFilesFittedToPS(SARRAY *, l_float32, l_float32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function sarrayConvertFilesFittedToPS(
				 ByVal sa as Sarray, 
				 ByVal xpts as Single, 
				 ByVal ypts as Single, 
				 ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")



Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayConvertFilesFittedToPS( sa.Pointer, xpts, ypts, fileout)

	Return _Result
End Function

' SRC\psio1.c (391, 1)
' writeImageCompressedToPSFile(filein, fileout, res, pfirstfile, pindex) as Integer
' writeImageCompressedToPSFile(const char *, const char *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function writeImageCompressedToPSFile(
				 ByVal filein as String, 
				 ByVal fileout as String, 
				 ByVal res as Integer, 
				 ByVal pfirstfile as Object, 
				 ByVal pindex as Object) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	If IsNothing (pfirstfile) then Throw New ArgumentNullException  ("pfirstfile cannot be Nothing")
	If IsNothing (pindex) then Throw New ArgumentNullException  ("pindex cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.writeImageCompressedToPSFile( filein, fileout, res, pfirstfile, pindex)

	Return _Result
End Function

' SRC\psio1.c (498, 1)
' convertSegmentedPagesToPS(pagedir, pagestr, page_numpre, maskdir, maskstr, mask_numpre, numpost, maxnum, textscale, imagescale, threshold, fileout) as Integer
' convertSegmentedPagesToPS(const char *, const char *, l_int32, const char *, const char *, l_int32, l_int32, l_int32, l_float32, l_float32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
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

	If IsNothing (pagedir) then Throw New ArgumentNullException  ("pagedir cannot be Nothing")
	If IsNothing (pagestr) then Throw New ArgumentNullException  ("pagestr cannot be Nothing")
	If IsNothing (maskdir) then Throw New ArgumentNullException  ("maskdir cannot be Nothing")
	If IsNothing (maskstr) then Throw New ArgumentNullException  ("maskstr cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.convertSegmentedPagesToPS( pagedir, pagestr, page_numpre, maskdir, maskstr, mask_numpre, numpost, maxnum, textscale, imagescale, threshold, fileout)

	Return _Result
End Function

' SRC\psio1.c (596, 1)
' pixWriteSegmentedPageToPS(pixs, pixm, textscale, imagescale, threshold, pageno, fileout) as Integer
' pixWriteSegmentedPageToPS(PIX *, PIX *, l_float32, l_float32, l_int32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteSegmentedPageToPS(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal textscale as Single, 
				 ByVal imagescale as Single, 
				 ByVal threshold as Integer, 
				 ByVal pageno as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")



Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer
Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteSegmentedPageToPS( pixs.Pointer, pixm.Pointer, textscale, imagescale, threshold, pageno, fileout)

	Return _Result
End Function

' SRC\psio1.c (747, 1)
' pixWriteMixedToPS(pixb, pixc, scale, pageno, fileout) as Integer
' pixWriteMixedToPS(PIX *, PIX *, l_float32, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteMixedToPS(
				 ByVal pixb as Pix, 
				 ByVal pixc as Pix, 
				 ByVal scale as Single, 
				 ByVal pageno as Integer, 
				 ByVal fileout as String) as Integer

	If IsNothing (pixb) then Throw New ArgumentNullException  ("pixb cannot be Nothing")
	If IsNothing (pixc) then Throw New ArgumentNullException  ("pixc cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")



Dim pixbPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixb) Then pixbPTR = pixb.Pointer
Dim pixcPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixc) Then pixcPTR = pixc.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMixedToPS( pixb.Pointer, pixc.Pointer, scale, pageno, fileout)

	Return _Result
End Function

' SRC\psio1.c (834, 1)
' convertToPSEmbed(filein, fileout, level) as Integer
' convertToPSEmbed(const char *, const char *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function convertToPSEmbed(
				 ByVal filein as String, 
				 ByVal fileout as String, 
				 ByVal level as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.convertToPSEmbed( filein, fileout, level)

	Return _Result
End Function

' SRC\psio1.c (935, 1)
' pixaWriteCompressedToPS(pixa, fileout, res, level) as Integer
' pixaWriteCompressedToPS(PIXA *, const char *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixaWriteCompressedToPS(
				 ByVal pixa as Pixa, 
				 ByVal fileout as String, 
				 ByVal res as Integer, 
				 ByVal level as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")



Dim pixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixa) Then pixaPTR = pixa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteCompressedToPS( pixa.Pointer, fileout, res, level)

	Return _Result
End Function

End Class

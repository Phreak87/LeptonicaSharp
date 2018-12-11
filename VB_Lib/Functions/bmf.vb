Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' bmf.c (114, 1)
' bmfCreate(dir, fontsize) as L_Bmf
' bmfCreate(const char *, l_int32) as L_BMF *
'''  <summary>
''' (1) If %dir == null, this generates the font bitmaps from a
'''compiled string.<para/>
'''
'''(2) Otherwise, this tries to read a pre-computed pixa file with the
'''95 ascii chars in it.  If the file is not found, it then
'''attempts to generate the pixa and associated baseline
'''data from a tiff image containing all the characters.  If
'''that fails, it uses the compiled string.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfCreate/*"/>
'''  <param name="dir">[in][optional] - directory holding pixa of character set</param>
'''  <param name="fontsize">[in] - 4, 6, 8, ... , 20</param>
'''   <returns>bmf holding the bitmap font and associated information</returns>
Public Shared Function bmfCreate(
				ByVal dir as String, 
				ByVal fontsize as Integer) as L_Bmf


	Dim _Result as IntPtr = Natives.bmfCreate(  dir,   fontsize)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Bmf(_Result)
End Function

' bmf.c (166, 1)
' bmfDestroy(pbmf) as Object
' bmfDestroy(L_BMF **) as void
'''  <summary>
''' bmfDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfDestroy/*"/>
'''  <param name="pbmf">[in,out] - set to null</param>
Public Shared Sub bmfDestroy(
				ByRef pbmf as L_Bmf)


	Dim pbmfPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pbmf) Then pbmfPtr = pbmf.Pointer

	Natives.bmfDestroy( pbmfPtr)
	
	if pbmfPtr = IntPtr.Zero then pbmf = Nothing else pbmf = new L_Bmf(pbmfPtr)
End Sub

' bmf.c (202, 1)
' bmfGetPix(bmf, chr) as Pix
' bmfGetPix(L_BMF *, char) as PIX *
'''  <summary>
''' bmfGetPix()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetPix/*"/>
'''  <param name="bmf">[in] - </param>
'''  <param name="chr">[in] - should be one of the 95 supported printable bitmaps</param>
'''   <returns>pix clone of pix in bmf, or NULL on error</returns>
Public Shared Function bmfGetPix(
				ByVal bmf as L_Bmf, 
				ByVal chr as Char) as Pix


if IsNothing (bmf) then Throw New ArgumentNullException  ("bmf cannot be Nothing")
	Dim _Result as IntPtr = Natives.bmfGetPix(bmf.Pointer,   chr)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' bmf.c (237, 1)
' bmfGetWidth(bmf, chr, pw) as Integer
' bmfGetWidth(L_BMF *, char, l_int32 *) as l_ok
'''  <summary>
''' bmfGetWidth()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetWidth/*"/>
'''  <param name="bmf">[in] - </param>
'''  <param name="chr">[in] - should be one of the 95 supported bitmaps</param>
'''  <param name="pw">[out] - character width -1 if not printable</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bmfGetWidth(
				ByVal bmf as L_Bmf, 
				ByVal chr as Char, 
				<Out()>  ByRef pw as Integer) as Integer


if IsNothing (bmf) then Throw New ArgumentNullException  ("bmf cannot be Nothing")
	Dim _Result as Integer = Natives.bmfGetWidth(bmf.Pointer,   chr,   pw)
	
	return _Result
End Function

' bmf.c (276, 1)
' bmfGetBaseline(bmf, chr, pbaseline) as Integer
' bmfGetBaseline(L_BMF *, char, l_int32 *) as l_ok
'''  <summary>
''' bmfGetBaseline()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/bmfGetBaseline/*"/>
'''  <param name="bmf">[in] - </param>
'''  <param name="chr">[in] - should be one of the 95 supported bitmaps</param>
'''  <param name="pbaseline">[out] - distance below UL corner of bitmap char</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function bmfGetBaseline(
				ByVal bmf as L_Bmf, 
				ByVal chr as Char, 
				<Out()>  ByRef pbaseline as Integer) as Integer


if IsNothing (bmf) then Throw New ArgumentNullException  ("bmf cannot be Nothing")
	Dim _Result as Integer = Natives.bmfGetBaseline(bmf.Pointer,   chr,   pbaseline)
	
	return _Result
End Function

' bmf.c (322, 1)
' pixaGetFont(dir, fontsize, pbl0, pbl1, pbl2) as Pixa
' pixaGetFont(const char *, l_int32, l_int32 *, l_int32 *, l_int32 *) as PIXA *
'''  <summary>
''' (1) This reads a pre-computed pixa file with the 95 ascii chars.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaGetFont/*"/>
'''  <param name="dir">[in] - directory holding pixa of character set</param>
'''  <param name="fontsize">[in] - 4, 6, 8, ... , 20</param>
'''  <param name="pbl0">[out] - baseline of row 1</param>
'''  <param name="pbl1">[out] - baseline of row 2</param>
'''  <param name="pbl2">[out] - baseline of row 3</param>
'''   <returns>pixa of font bitmaps for 95 characters, or NULL on error</returns>
Public Shared Function pixaGetFont(
				ByVal dir as String, 
				ByVal fontsize as Integer, 
				<Out()>  ByRef pbl0 as Integer, 
				<Out()>  ByRef pbl1 as Integer, 
				<Out()>  ByRef pbl2 as Integer) as Pixa


if IsNothing (dir) then Throw New ArgumentNullException  ("dir cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaGetFont(  dir,   fontsize,   pbl0,   pbl1,   pbl2)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' bmf.c (372, 1)
' pixaSaveFont(indir, outdir, fontsize) as Integer
' pixaSaveFont(const char *, const char *, l_int32) as l_ok
'''  <summary>
''' (1) This saves a font of a particular size.<para/>
'''
'''(2) If %dir == null, this generates the font bitmaps from a
'''compiled string.<para/>
'''
'''(3) prog/genfonts calls this function for each of the
'''nine font sizes, to generate all the font pixa files.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaSaveFont/*"/>
'''  <param name="indir">[in][optional] - directory holding image of character set</param>
'''  <param name="outdir">[in] - directory into which the output pixa file will be written</param>
'''  <param name="fontsize">[in] - in pts, at 300 ppi</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSaveFont(
				ByVal indir as String, 
				ByVal outdir as String, 
				ByVal fontsize as Integer) as Integer


if IsNothing (outdir) then Throw New ArgumentNullException  ("outdir cannot be Nothing")
	Dim _Result as Integer = Natives.pixaSaveFont(  indir,   outdir,   fontsize)
	
	return _Result
End Function

End Class



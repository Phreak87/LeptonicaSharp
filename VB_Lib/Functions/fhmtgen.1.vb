Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' fhmtgen.1.c (37, 6)
' pixHMTDwa_1(pixd, pixs, selname) as Pix
' pixHMTDwa_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' (1) This simply adds a 32 pixel border, calls the appropriate
'''pixFHMTGen_(), and removes the border.
'''See notes below for that function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixHMTDwa_1/*"/>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixHMTDwa_1(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal selname as String) as Pix


if IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixHMTDwa_1(pixd.Pointer, pixs.Pointer,   selname)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' fhmtgen.1.c (38, 6)
' pixFHMTGen_1(pixd, pixs, selname) as Pix
' pixFHMTGen_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' (1) This is a dwa implementation of the hit-miss transform
'''on pixs by the sel.<para/>
'''
'''(2) The sel must be limited in size to not more than 31 pixels
'''about the origin.  It must have at least one hit, and it
'''can have any number of misses.<para/>
'''
'''(3) This handles all required setting of the border pixels
'''before erosion and dilation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFHMTGen_1/*"/>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixFHMTGen_1(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal selname as String) as Pix


if IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixFHMTGen_1(pixd.Pointer, pixs.Pointer,   selname)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' fhmtgen.1.c (39, 9)
' fhmtgen_low_1(datad, w, h, wpld, datas, wpls, index) as Integer
' fhmtgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fhmtgen_low_1/*"/>
'''   <returns></returns>
Public Shared Function fhmtgen_low_1(
				ByVal datad as object, 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal wpld as Integer, 
				ByVal datas as object, 
				ByVal wpls as Integer, 
				ByVal index as Integer) as Integer


if IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
		if IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")
	Dim _Result as Integer = Natives.fhmtgen_low_1(  datad,   w,   h,   wpld,   datas,   wpls,   index)
	
	return _Result
End Function

End Class



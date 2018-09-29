Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\fhmtgen.1.c (37, 6)
' pixHMTDwa_1()
' pixHMTDwa_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' Notes
''' (1) This simply adds a 32 pixel border, calls the appropriate
''' pixFHMTGen_(), and removes the border.
''' See notes below for that function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixHMTDwa_1(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByRef selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHMTDwa_1( pixd.Pointer, pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fhmtgen.1.c (38, 6)
' pixFHMTGen_1()
' pixFHMTGen_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a dwa implementation of the hit-miss transform
''' on pixs by the sel.
''' (2) The sel must be limited in size to not more than 31 pixels
''' about the origin.  It must have at least one hit, and it
''' can have any number of misses.
''' (3) This handles all required setting of the border pixels
''' before erosion and dilation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixFHMTGen_1(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByRef selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFHMTGen_1( pixd.Pointer, pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fhmtgen.1.c (39, 9)
' 
' fhmtgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fhmtgen_low_1(
				ByRef datad as Object, 
				ByRef w as Integer, 
				ByRef h as Integer, 
				ByRef wpld as Integer, 
				ByRef datas as Object, 
				ByRef wpls as Integer, 
				ByRef index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtgen_low_1( datad, w, h, wpld, datas, wpls, index)

	Return _Result
End Function

End Class

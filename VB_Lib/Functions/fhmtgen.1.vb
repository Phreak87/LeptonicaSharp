Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\fhmtgen.1.c (37, 6)
' pixHMTDwa_1(pixd, pixs, selname) as Pix
' pixHMTDwa_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simply adds a 32 pixel border, calls the appropriate<para/>
''' pixFHMTGen_(), and removes the border.<para/>
''' See notes below for that function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixHMTDwa_1(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHMTDwa_1( pixd.Pointer, pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fhmtgen.1.c (38, 6)
' pixFHMTGen_1(pixd, pixs, selname) as Pix
' pixFHMTGen_1(PIX *, PIX *, const char *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a dwa implementation of the hit-miss transform<para/>
''' on pixs by the sel.<para/>
''' (2) The sel must be limited in size to not more than 31 pixels<para/>
''' about the origin.  It must have at least one hit, and it<para/>
''' can have any number of misses.<para/>
''' (3) This handles all required setting of the border pixels<para/>
''' before erosion and dilation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd</returns>
Public Shared Function pixFHMTGen_1(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFHMTGen_1( pixd.Pointer, pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fhmtgen.1.c (39, 9)
' fhmtgen_low_1(datad, w, h, wpld, datas, wpls, index) as Integer
' fhmtgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fhmtgen_low_1(
				 ByVal datad as Object, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal wpld as Integer, 
				 ByVal datas as Object, 
				 ByVal wpls as Integer, 
				 ByVal index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtgen_low_1( datad, w, h, wpld, datas, wpls, index)

	Return _Result
End Function

End Class

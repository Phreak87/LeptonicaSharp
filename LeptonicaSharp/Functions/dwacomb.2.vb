Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\dwacomb.2.c (37, 6)
' pixMorphDwa_2()
' pixMorphDwa_2(PIX *, PIX *, l_int32, char *) as PIX *
'''  <summary>
''' Notes
''' (1) This simply adds a border, calls the appropriate
''' pixFMorphopGen_(), and removes the border.
''' See the notes for that function.
''' (2) The size of the border depends on the operation
''' and the boundary conditions.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
'''   <returns>pixd</returns>
Public Shared Function pixMorphDwa_2(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal operation as Enumerations.L_MORPH, 
				ByRef selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphDwa_2( pixd.Pointer, pixs.Pointer, operation, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\dwacomb.2.c (38, 6)
' pixFMorphopGen_2()
' pixFMorphopGen_2(PIX *, PIX *, l_int32, char *) as PIX *
'''  <summary>
''' Notes
''' (1) This is a dwa operation, and the Sels must be limited in
''' size to not more than 31 pixels about the origin.
''' (2) A border of appropriate size (32 pixels, or 64 pixels
''' for safe closing with asymmetric b.c.) must be added before
''' this function is called.
''' (3) This handles all required setting of the border pixels
''' before erosion and dilation.
''' (4) The closing operation is safe; no pixels can be removed
''' near the boundary.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixd">[in] - usual 3 choices null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
'''   <returns>pixd</returns>
Public Shared Function pixFMorphopGen_2(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal operation as Enumerations.L_MORPH, 
				ByRef selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFMorphopGen_2( pixd.Pointer, pixs.Pointer, operation, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\dwacomb.2.c (39, 9)
' 
' fmorphopgen_low_2(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fmorphopgen_low_2(
				ByRef datad as Object, 
				ByRef w as Integer, 
				ByRef h as Integer, 
				ByRef wpld as Integer, 
				ByRef datas as Object, 
				ByRef wpls as Integer, 
				ByRef index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphopgen_low_2( datad, w, h, wpld, datas, wpls, index)

	Return _Result
End Function

End Class

Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\fmorphgen.1.c (37, 6)
' pixMorphDwa_1(pixd, pixs, operation, selname) as Pix
' pixMorphDwa_1(PIX *, PIX *, l_int32, char *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simply adds a border, calls the appropriate<para/>
''' pixFMorphopGen_(), and removes the border.<para/>
''' See the notes for that function.<para/>
''' (2) The size of the border depends on the operation<para/>
''' and the boundary conditions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixMorphDwa_1/*"/>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
'''   <returns>pixd</returns>
Public Shared Function pixMorphDwa_1(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal operation as Enumerations.L_MORPH, 
				 ByVal selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphDwa_1( pixd.Pointer, pixs.Pointer, operation, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fmorphgen.1.c (38, 6)
' pixFMorphopGen_1(pixd, pixs, operation, selname) as Pix
' pixFMorphopGen_1(PIX *, PIX *, l_int32, char *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a dwa operation, and the Sels must be limited in<para/>
''' size to not more than 31 pixels about the origin.<para/>
''' (2) A border of appropriate size (32 pixels, or 64 pixels<para/>
''' for safe closing with asymmetric b.c.) must be added before<para/>
''' this function is called.<para/>
''' (3) This handles all required setting of the border pixels<para/>
''' before erosion and dilation.<para/>
''' (4) The closing operation is safe no pixels can be removed<para/>
''' near the boundary.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFMorphopGen_1/*"/>
'''  <param name="pixd">[in] - usual 3 choices: null, == pixs, != pixs</param>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="operation">[in] - L_MORPH_DILATE, L_MORPH_ERODE, L_MORPH_OPEN, L_MORPH_CLOSE</param>
'''   <returns>pixd</returns>
Public Shared Function pixFMorphopGen_1(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal operation as Enumerations.L_MORPH, 
				 ByVal selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFMorphopGen_1( pixd.Pointer, pixs.Pointer, operation, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\fmorphgen.1.c (39, 9)
' fmorphopgen_low_1(datad, w, h, wpld, datas, wpls, index) as Integer
' fmorphopgen_low_1(l_uint32 *, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fmorphopgen_low_1/*"/>
'''   <returns></returns>
Public Shared Function fmorphopgen_low_1(
				 ByVal datad as Object, 
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal wpld as Integer, 
				 ByVal datas as Object, 
				 ByVal wpls as Integer, 
				 ByVal index as Integer) as Integer

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphopgen_low_1( datad, w, h, wpld, datas, wpls, index)

	Return _Result
End Function

End Class

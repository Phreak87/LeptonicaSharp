Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixacc.c (90, 1)
' pixaccCreate(w, h, negflag) as Pixacc
' pixaccCreate(l_int32, l_int32, l_int32) as PIXACC *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Use %negflag = 1 for safety if any negative numbers are going
''' to be used in the chain of operations.  Negative numbers
''' arise, e.g., by subtracting a pix, or by adding a pix
''' that has been pre-multiplied by a negative number.<para/>
''' 
''' (2) Initializes the internal 32 bpp pix, similarly to the
''' initialization in pixInitAccumulate().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccCreate/*"/>
'''  <param name="w">[in] - of 32 bpp internal Pix</param>
'''  <param name="h">[in] - of 32 bpp internal Pix</param>
'''  <param name="negflag">[in] - 0 if only positive numbers are involved 1 if there will be negative numbers</param>
'''   <returns>pixacc, or NULL on error</returns>
Public Shared Function pixaccCreate(
				 ByVal w as Integer, 
				 ByVal h as Integer, 
				 ByVal negflag as Integer) as Pixacc

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaccCreate( w, h, negflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixacc(_Result)
End Function

' SRC\pixacc.c (131, 1)
' pixaccCreateFromPix(pix, negflag) as Pixacc
' pixaccCreateFromPix(PIX *, l_int32) as PIXACC *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) See pixaccCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccCreateFromPix/*"/>
'''  <param name="pix">[in] - </param>
'''  <param name="negflag">[in] - 0 if only positive numbers are involved 1 if there will be negative numbers</param>
'''   <returns>pixacc, or NULL on error</returns>
Public Shared Function pixaccCreateFromPix(
				 ByVal pix as Pix, 
				 ByVal negflag as Integer) as Pixacc

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaccCreateFromPix( pix.Pointer, negflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixacc(_Result)
End Function

' SRC\pixacc.c (160, 1)
' pixaccDestroy(ppixacc) as Object
' pixaccDestroy(PIXACC **) as void
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccDestroy/*"/>
'''  <param name="ppixacc">[in,out] - to be nulled</param>
Public Shared Sub pixaccDestroy(
				 ByRef ppixacc as Pixacc)

	Dim ppixaccPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixacc) Then ppixaccPTR = ppixacc.Pointer

	LeptonicaSharp.Natives.pixaccDestroy( ppixaccPTR)
	if ppixaccPTR <> IntPtr.Zero then ppixacc = new Pixacc(ppixaccPTR)

End Sub

' SRC\pixacc.c (192, 1)
' pixaccFinal(pixacc, outdepth) as Pix
' pixaccFinal(PIXACC *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccFinal/*"/>
'''  <param name="pixacc">[in] - </param>
'''  <param name="outdepth">[in] - 8, 16 or 32 bpp</param>
'''   <returns>pixd 8 , 16 or 32 bpp, or NULL on error</returns>
Public Shared Function pixaccFinal(
				 ByVal pixacc as Pixacc, 
				 ByVal outdepth as Integer) as Pix

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaccFinal( pixacc.Pointer, outdepth)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixacc.c (215, 1)
' pixaccGetPix(pixacc) as Pix
' pixaccGetPix(PIXACC *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccGetPix/*"/>
'''  <param name="pixacc">[in] - </param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaccGetPix(
				 ByVal pixacc as Pixacc) as Pix

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaccGetPix( pixacc.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixacc.c (232, 1)
' pixaccGetOffset(pixacc) as Integer
' pixaccGetOffset(PIXACC *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccGetOffset/*"/>
'''  <param name="pixacc">[in] - </param>
'''   <returns>offset, or -1 on error</returns>
Public Shared Function pixaccGetOffset(
				 ByVal pixacc as Pixacc) as Integer

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaccGetOffset( pixacc.Pointer)

	Return _Result
End Function

' SRC\pixacc.c (253, 1)
' pixaccAdd(pixacc, pix) as Integer
' pixaccAdd(PIXACC *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccAdd/*"/>
'''  <param name="pixacc">[in] - </param>
'''  <param name="pix">[in] - to be added</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaccAdd(
				 ByVal pixacc as Pixacc, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaccAdd( pixacc.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\pixacc.c (275, 1)
' pixaccSubtract(pixacc, pix) as Integer
' pixaccSubtract(PIXACC *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccSubtract/*"/>
'''  <param name="pixacc">[in] - </param>
'''  <param name="pix">[in] - to be subtracted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaccSubtract(
				 ByVal pixacc as Pixacc, 
				 ByVal pix as Pix) as Integer

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaccSubtract( pixacc.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\pixacc.c (297, 1)
' pixaccMultConst(pixacc, factor) as Integer
' pixaccMultConst(PIXACC *, l_float32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccMultConst/*"/>
'''  <param name="pixacc">[in] - </param>
'''  <param name="factor">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaccMultConst(
				 ByVal pixacc as Pixacc, 
				 ByVal factor as Single) as Integer

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaccMultConst( pixacc.Pointer, factor)

	Return _Result
End Function

' SRC\pixacc.c (325, 1)
' pixaccMultConstAccumulate(pixacc, pix, factor) as Integer
' pixaccMultConstAccumulate(PIXACC *, PIX *, l_float32) as l_ok
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This creates a temp pix that is %pix multiplied by the
''' constant %factor.  It then adds that into %pixacc.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixaccMultConstAccumulate/*"/>
'''  <param name="pixacc">[in] - </param>
'''  <param name="pix">[in] - </param>
'''  <param name="factor">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaccMultConstAccumulate(
				 ByVal pixacc as Pixacc, 
				 ByVal pix as Pix, 
				 ByVal factor as Single) as Integer

	If IsNothing (pixacc) then Throw New ArgumentNullException  ("pixacc cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaccMultConstAccumulate( pixacc.Pointer, pix.Pointer, factor)

	Return _Result
End Function

End Class

Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\pixabasic.c (162, 1)
' pixaCreate(n) as Pixa
' pixaCreate(l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This creates an empty boxa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaCreate(
				 ByVal n as Integer) as Pixa





	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (201, 1)
' pixaCreateFromPix(pixs, n, cellw, cellh) as Pixa
' pixaCreateFromPix(PIX *, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For bpp = 1, we truncate each retrieved pix to the ON<para/>
''' pixels, which we assume for now start at (0,0)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - with individual components on a lattice</param>
'''  <param name="n">[in] - number of components</param>
'''  <param name="cellw">[in] - width of each cell</param>
'''  <param name="cellh">[in] - height of each cell</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaCreateFromPix(
				 ByVal pixs as Pix, 
				 ByVal n as Integer, 
				 ByVal cellw as Integer, 
				 ByVal cellh as Integer) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCreateFromPix( pixs.Pointer, n, cellw, cellh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (264, 1)
' pixaCreateFromBoxa(pixs, boxa, pcropwarn) as Pixa
' pixaCreateFromBoxa(PIX *, BOXA *, l_int32 *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This simply extracts from pixs the region corresponding to each<para/>
''' box in the boxa.<para/>
''' (2) The 3rd arg is optional.  If the extent of the boxa exceeds the<para/>
''' size of the pixa, so that some boxes are either clipped<para/>
''' or entirely outside the pix, a warning is returned as TRUE.<para/>
''' (3) pixad will have only the properly clipped elements, and<para/>
''' the internal boxa will be correct.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''  <param name="pcropwarn">[out][optional] - TRUE if the boxa extent is larger than pixs.</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaCreateFromBoxa(
				 ByVal pixs as Pix, 
				 ByVal boxa as Boxa, 
				<Out()> ByRef pcropwarn as Integer) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCreateFromBoxa( pixs.Pointer, boxa.Pointer, pcropwarn)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (337, 1)
' pixaSplitPix(pixs, nx, ny, borderwidth, bordercolor) as Pixa
' pixaSplitPix(PIX *, l_int32, l_int32, l_int32, l_uint32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a variant on pixaCreateFromPix(), where we<para/>
''' simply divide the image up into (approximately) equal<para/>
''' subunits.  If you want the subimages to have essentially<para/>
''' the same aspect ratio as the input pix, use nx = ny.<para/>
''' (2) If borderwidth is 0, we ignore the input bordercolor and<para/>
''' redefine it to white.<para/>
''' (3) The bordercolor is always used to initialize each tiled pix,<para/>
''' so that if the src is clipped, the unblitted part will<para/>
''' be this color.  This avoids 1 pixel wide black stripes at the<para/>
''' left and lower edges.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - with individual components on a lattice</param>
'''  <param name="nx">[in] - number of mosaic cells horizontally</param>
'''  <param name="ny">[in] - number of mosaic cells vertically</param>
'''  <param name="borderwidth">[in] - of added border on all sides</param>
'''  <param name="bordercolor">[in] - in our RGBA format: 0xrrggbbaa</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaSplitPix(
				 ByVal pixs as Pix, 
				 ByVal nx as Integer, 
				 ByVal ny as Integer, 
				 ByVal borderwidth as Integer, 
				 ByVal bordercolor as UInteger) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaSplitPix( pixs.Pointer, nx, ny, borderwidth, bordercolor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (399, 1)
' pixaDestroy(ppixa) as Object
' pixaDestroy(PIXA **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Decrements the ref count and, if 0, destroys the pixa.<para/>
''' (2) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ppixa">[in,out]can be null - ed</param>
Public Shared Sub pixaDestroy(
				 ByRef ppixa as Pixa)




Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer

	LeptonicaSharp.Natives.pixaDestroy( ppixaPTR)
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)

End Sub

' SRC\pixabasic.c (441, 1)
' pixaCopy(pixa, copyflag) as Pixa
' pixaCopy(PIXA *, l_int32) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="copyflag">[in] - see pix.h for details: L_COPY makes a new pixa and copies each pix and each box L_CLONE gives a new ref-counted handle to the input pixa L_COPY_CLONE makes a new pixa and inserts clones of all pix and boxes</param>
'''   <returns>new pixa, or NULL on error</returns>
Public Shared Function pixaCopy(
				 ByVal pixa as Pixa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCopy( pixa.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (494, 1)
' pixaAddPix(pixa, pix, copyflag) as Integer
' pixaAddPix(PIXA *, PIX *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pix">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaAddPix(
				 ByVal pixa as Pixa, 
				 ByVal pix as Pix, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaAddPix( pixa.Pointer, pix.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixabasic.c (538, 1)
' pixaAddBox(pixa, box, copyflag) as Integer
' pixaAddBox(PIXA *, BOX *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="box">[in] - </param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaAddBox(
				 ByVal pixa as Pixa, 
				 ByVal box as Box, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaAddBox( pixa.Pointer, box.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixabasic.c (593, 1)
' pixaExtendArrayToSize(pixa, size) as Integer
' pixaExtendArrayToSize(PIXA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If necessary, reallocs new pixa and boxa ptrs arrays to %size.<para/>
''' The pixa and boxa ptr arrays must always be equal in size.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="size">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaExtendArrayToSize(
				 ByVal pixa as Pixa, 
				 ByVal size as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaExtendArrayToSize( pixa.Pointer, size)

	Return _Result
End Function

' SRC\pixabasic.c (622, 1)
' pixaGetCount(pixa) as Integer
' pixaGetCount(PIXA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''   <returns>count, or 0 if no pixa</returns>
Public Shared Function pixaGetCount(
				 ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetCount( pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (641, 1)
' pixaChangeRefcount(pixa, delta) as Integer
' pixaChangeRefcount(PIXA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="delta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaChangeRefcount(
				 ByVal pixa as Pixa, 
				 ByVal delta as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaChangeRefcount( pixa.Pointer, delta)

	Return _Result
End Function

' SRC\pixabasic.c (663, 1)
' pixaGetPix(pixa, index, accesstype) as Pix
' pixaGetPix(PIXA *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - to the index-th pix</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaGetPix(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				 ByVal accesstype as Enumerations.L_access_storage) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaGetPix( pixa.Pointer, index, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixabasic.c (698, 1)
' pixaGetPixDimensions(pixa, index, pw, ph, pd) as Integer
' pixaGetPixDimensions(PIXA *, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''  <param name="pd">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaGetPixDimensions(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer, 
				<Out()> ByRef pd as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetPixDimensions( pixa.Pointer, index, pw, ph, pd)

	Return _Result
End Function

' SRC\pixabasic.c (732, 1)
' pixaGetBoxa(pixa, accesstype) as Boxa
' pixaGetBoxa(PIXA *, l_int32) as BOXA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixaGetBoxa(
				 ByVal pixa as Pixa, 
				 ByVal accesstype as Enumerations.L_access_storage) as Boxa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaGetBoxa( pixa.Pointer, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\pixabasic.c (756, 1)
' pixaGetBoxaCount(pixa) as Integer
' pixaGetBoxaCount(PIXA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function pixaGetBoxaCount(
				 ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetBoxaCount( pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (788, 1)
' pixaGetBox(pixa, index, accesstype) as Box
' pixaGetBox(PIXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) There is always a boxa with a pixa, and it is initialized so<para/>
''' that each box ptr is NULL.<para/>
''' (2) In general, we expect that there is either a box associated<para/>
''' with each pix, or no boxes at all in the boxa.<para/>
''' (3) Having no boxes is thus not an automatic error.  Whether it<para/>
''' is an actual error is determined by the calling program.<para/>
''' If the caller expects to get a box, it is an error see, e.g.,<para/>
''' pixaGetBoxGeometry().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - to the index-th pix</param>
'''  <param name="accesstype">[in] - L_COPY or L_CLONE</param>
'''   <returns>box if null, not automatically an error, or NULL on error</returns>
Public Shared Function pixaGetBox(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				 ByVal accesstype as Enumerations.L_access_storage) as Box

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaGetBox( pixa.Pointer, index, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\pixabasic.c (826, 1)
' pixaGetBoxGeometry(pixa, index, px, py, pw, ph) as Integer
' pixaGetBoxGeometry(PIXA *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="px">[out][optional] - each can be null</param>
'''  <param name="py">[out][optional] - each can be null</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaGetBoxGeometry(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				<Out()> ByRef px as Integer, 
				<Out()> ByRef py as Integer, 
				<Out()> ByRef pw as Integer, 
				<Out()> ByRef ph as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaGetBoxGeometry( pixa.Pointer, index, px, py, pw, ph)

	Return _Result
End Function

' SRC\pixabasic.c (868, 1)
' pixaSetBoxa(pixa, boxa, accesstype) as Integer
' pixaSetBoxa(PIXA *, BOXA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This destroys the existing boxa in the pixa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''  <param name="accesstype">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaSetBoxa(
				 ByVal pixa as Pixa, 
				 ByVal boxa as Boxa, 
				 ByVal accesstype as Enumerations.L_access_storage) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSetBoxa( pixa.Pointer, boxa.Pointer, accesstype)

	Return _Result
End Function

' SRC\pixabasic.c (907, 1)
' pixaGetPixArray(pixa) as Pix
' pixaGetPixArray(PIXA *) as PIX **
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a ptr to the actual array.  The array is<para/>
''' owned by the pixa, so it must not be destroyed.<para/>
''' (2) The caller should always check if the return value is NULL<para/>
''' before accessing any of the pix ptrs in this array!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''   <returns>pix array, or NULL on error</returns>
Public Shared Function pixaGetPixArray(
				 ByVal pixa as Pixa) as Pix

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaGetPixArray( pixa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing
Dim B as new Pix(_Result)

	Return B
End Function

' SRC\pixabasic.c (932, 1)
' pixaVerifyDepth(pixa, psame, pmaxd) as Integer
' pixaVerifyDepth(PIXA *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is considered to be an error if there are no pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="psame">[out] - 1 if depth is the same for all pix 0 otherwise</param>
'''  <param name="pmaxd">[out][optional] - max depth of all pix</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaVerifyDepth(
				 ByVal pixa as Pixa, 
				<Out()> ByRef psame as Integer, 
				<Out()> ByRef pmaxd as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaVerifyDepth( pixa.Pointer, psame, pmaxd)

	Return _Result
End Function

' SRC\pixabasic.c (978, 1)
' pixaVerifyDimensions(pixa, psame, pmaxw, pmaxh) as Integer
' pixaVerifyDimensions(PIXA *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is considered to be an error if there are no pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="psame">[out] - 1 if dimensions are the same for all pix 0 otherwise</param>
'''  <param name="pmaxw">[out][optional] - max width of all pix</param>
'''  <param name="pmaxh">[out][optional] - max height of all pix</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaVerifyDimensions(
				 ByVal pixa as Pixa, 
				<Out()> ByRef psame as Integer, 
				<Out()> ByRef pmaxw as Integer, 
				<Out()> ByRef pmaxh as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaVerifyDimensions( pixa.Pointer, psame, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\pixabasic.c (1029, 1)
' pixaIsFull(pixa, pfullpa, pfullba) as Integer
' pixaIsFull(PIXA *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A pixa is "full" if the array of pix is fully<para/>
''' occupied from index 0 to index (pixa- is greater n - 1).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pfullpa">[out][optional] - 1 if pixa is full</param>
'''  <param name="pfullba">[out][optional] - 1 if boxa is full</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaIsFull(
				 ByVal pixa as Pixa, 
				<Out()> ByRef pfullpa as Integer, 
				<Out()> ByRef pfullba as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaIsFull( pixa.Pointer, pfullpa, pfullba)

	Return _Result
End Function

' SRC\pixabasic.c (1079, 1)
' pixaCountText(pixa, pntext) as Integer
' pixaCountText(PIXA *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) All pix have non-empty text strings if the returned value %ntext<para/>
''' equals the pixa count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="pntext">[out] - number of pix with non-empty text strings</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixaCountText(
				 ByVal pixa as Pixa, 
				<Out()> ByRef pntext as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaCountText( pixa.Pointer, pntext)

	Return _Result
End Function

' SRC\pixabasic.c (1122, 1)
' pixaSetText(pixa, sa) as Integer
' pixaSetText(PIXA *, SARRAY *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) To clear all the text fields, use sa == NULL<para/>
''' (2) If sa is defined, it must be the same size as %pixa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="sa">[in][optional] - array of text strings, to insert in each pix</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixaSetText(
				 ByVal pixa as Pixa, 
				 ByVal sa as Sarray) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")



	Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaSetText( pixa.Pointer, saPTR)

	Return _Result
End Function

' SRC\pixabasic.c (1180, 1)
' pixaGetLinePtrs(pixa, psize) as IntPtr
' pixaGetLinePtrs(PIXA *, l_int32 *) as void ***
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixGetLinePtrs() for details.<para/>
''' (2) It is best if all pix in the pixa are the same size.<para/>
''' The size of each line ptr array is equal to the height<para/>
''' of the pix that it refers to.<para/>
''' (3) This is an array of arrays.  To destroy it:<para/>
''' for (i = 0 i  is lower  size i++)<para/>
''' LEPT_FREE(lineset[i])<para/>
''' LEPT_FREE(lineset)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - of pix that all have the same depth</param>
'''  <param name="psize">[out][optional] - number of pix in the pixa</param>
'''   <returns>array of array of line ptrs, or NULL on error</returns>
Public Shared Function pixaGetLinePtrs(
				 ByVal pixa as Pixa, 
				<Out()> ByRef psize as Integer) as IntPtr

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaGetLinePtrs( pixa.Pointer, psize)

	Return _Result
End Function

' SRC\pixabasic.c (1228, 1)
' pixaWriteStreamInfo(fp, pixa) as Integer
' pixaWriteStreamInfo(FILE *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For each pix in the pixa, write out the pix dimensions, spp,<para/>
''' text string (if it exists), and cmap info.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function pixaWriteStreamInfo(
				 ByVal fp as FILE, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteStreamInfo( fp.Pointer, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (1286, 1)
' pixaReplacePix(pixa, index, pix, box) as Integer
' pixaReplacePix(PIXA *, l_int32, PIX *, BOX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place replacement of one pix.<para/>
''' (2) The previous pix at that location is destroyed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - to the index-th pix</param>
'''  <param name="pix">[in] - insert to replace existing one</param>
'''  <param name="box">[in][optional] - insert to replace existing</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaReplacePix(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				 ByVal pix as Pix, 
				 ByVal box as Box) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")



	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaReplacePix( pixa.Pointer, index, pix.Pointer, boxPTR)

	Return _Result
End Function

' SRC\pixabasic.c (1336, 1)
' pixaInsertPix(pixa, index, pixs, box) as Integer
' pixaInsertPix(PIXA *, l_int32, PIX *, BOX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts pixa[i] -- is greater  pixa[i + 1] for all i  is greater = index,<para/>
''' and then inserts at pixa[index].<para/>
''' (2) To insert at the beginning of the array, set index = 0.<para/>
''' (3) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
''' (4) To append a pix to a pixa, it's easier to use pixaAddPix().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - at which pix is to be inserted</param>
'''  <param name="pixs">[in] - new pix to be inserted</param>
'''  <param name="box">[in][optional] - new box to be inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaInsertPix(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				 ByVal pixs as Pix, 
				 ByVal box as Box) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")



	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaInsertPix( pixa.Pointer, index, pixs.Pointer, boxPTR)

	Return _Result
End Function

' SRC\pixabasic.c (1386, 1)
' pixaRemovePix(pixa, index) as Integer
' pixaRemovePix(PIXA *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts pixa[i] -- is greater  pixa[i - 1] for all i  is greater  index.<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
''' (3) The corresponding box is removed as well, if it exists.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - of pix to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaRemovePix(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaRemovePix( pixa.Pointer, index)

	Return _Result
End Function

' SRC\pixabasic.c (1438, 1)
' pixaRemovePixAndSave(pixa, index, ppix, pbox) as Integer
' pixaRemovePixAndSave(PIXA *, l_int32, PIX **, BOX **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This shifts pixa[i] -- is greater  pixa[i - 1] for all i  is greater  index.<para/>
''' (2) It should not be used repeatedly on large arrays,<para/>
''' because the function is O(n).<para/>
''' (3) The corresponding box is removed as well, if it exists.<para/>
''' (4) The removed pix and box can either be retained or destroyed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="index">[in] - of pix to be removed</param>
'''  <param name="ppix">[out][optional] - removed pix</param>
'''  <param name="pbox">[out][optional] - removed box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaRemovePixAndSave(
				 ByVal pixa as Pixa, 
				 ByVal index as Integer, 
				<Out()> ByRef ppix as Pix, 
				<Out()> ByRef pbox as Box) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")



Dim ppixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppix) Then ppixPTR = ppix.Pointer
Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaRemovePixAndSave( pixa.Pointer, index, ppixPTR, pboxPTR)
	if ppixPTR <> IntPtr.Zero then ppix = new Pix(ppixPTR)
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)

	Return _Result
End Function

' SRC\pixabasic.c (1513, 1)
' pixaInitFull(pixa, pix, box) as Integer
' pixaInitFull(PIXA *, PIX *, BOX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This initializes a pixa by filling up the entire pix ptr array<para/>
''' with copies of %pix.  If %pix == NULL, we use a tiny placeholder<para/>
''' pix (w = h = d = 1).  Any existing pix are destroyed.<para/>
''' It also optionally fills the boxa with copies of %box.<para/>
''' After this operation, the numbers of pix and (optionally)<para/>
''' boxes are equal to the number of allocated ptrs.<para/>
''' (2) Note that we use pixaReplacePix() instead of pixaInsertPix().<para/>
''' They both have the same effect when inserting into a NULL ptr<para/>
''' in the pixa ptr array:<para/>
''' (3) If the boxa is not initialized (i.e., filled with boxes),<para/>
''' later insertion of boxes will cause an error, because the<para/>
''' 'n' field is 0.<para/>
''' (4) Example usage.  This function is useful to prepare for a<para/>
''' random insertion (or replacement) of pix into a pixa.<para/>
''' To randomly insert pix into a pixa, without boxes, up to<para/>
''' some index "max":<para/>
''' Pixa pixa = pixaCreate(max)<para/>
''' pixaInitFull(pixa, NULL, NULL)<para/>
''' An existing pixa with a smaller ptr array can also be reused:<para/>
''' pixaExtendArrayToSize(pixa, max)<para/>
''' pixaInitFull(pixa, NULL, NULL)<para/>
''' The initialization allows the pixa to always be properly<para/>
''' filled, even if all pix (and boxes) are not later replaced.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - typically empty</param>
'''  <param name="pix">[in][optional] - to be replicated into the entire pixa ptr array</param>
'''  <param name="box">[in][optional] - to be replicated into the entire boxa ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaInitFull(
				 ByVal pixa as Pixa, 
				 ByVal pix as Pix, 
				 ByVal box as Box) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")



	Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer
	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaInitFull( pixa.Pointer, pixPTR, boxPTR)

	Return _Result
End Function

' SRC\pixabasic.c (1555, 1)
' pixaClear(pixa) as Integer
' pixaClear(PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This destroys all pix in the pixa, as well as<para/>
''' all boxes in the boxa.  The ptrs in the pix ptr array<para/>
''' are all null'd.  The number of allocated pix, n, is set to 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaClear(
				 ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaClear( pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (1593, 1)
' pixaJoin(pixad, pixas, istart, iend) as Integer
' pixaJoin(PIXA *, PIXA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a clone of each indicated pix in pixas to pixad<para/>
''' (2) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (3) iend  is lower  0 means 'read to the end'<para/>
''' (4) If pixas is NULL or contains no pix, this is a no-op.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixad">[in] - dest pixa add to this one</param>
'''  <param name="pixas">[in][optional] - source pixa add from this one</param>
'''  <param name="istart">[in] - starting index in pixas</param>
'''  <param name="iend">[in] - ending index in pixas use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaJoin(
				 ByVal pixad as Pixa, 
				 ByVal pixas as Pixa, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (pixad) then Throw New ArgumentNullException  ("pixad cannot be Nothing")



	Dim pixasPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixas) Then pixasPTR = pixas.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaJoin( pixad.Pointer, pixasPTR, istart, iend)

	Return _Result
End Function

' SRC\pixabasic.c (1649, 1)
' pixaInterleave(pixa1, pixa2, copyflag) as Pixa
' pixaInterleave(PIXA *, PIXA *, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %copyflag determines if the pix are copied or cloned.<para/>
''' The boxes, if they exist, are copied.<para/>
''' (2) If the two pixa have different sizes, a warning is issued,<para/>
''' and the number of pairs returned is the minimum size.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa1">[in] - first src pixa</param>
'''  <param name="pixa2">[in] - second src pixa</param>
'''  <param name="copyflag">[in] - L_CLONE, L_COPY</param>
'''   <returns>pixa  interleaved from sources, or NULL on error.</returns>
Public Shared Function pixaInterleave(
				 ByVal pixa1 as Pixa, 
				 ByVal pixa2 as Pixa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Pixa

	If IsNothing (pixa1) then Throw New ArgumentNullException  ("pixa1 cannot be Nothing")
	If IsNothing (pixa2) then Throw New ArgumentNullException  ("pixa2 cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaInterleave( pixa1.Pointer, pixa2.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (1714, 1)
' pixaaJoin(paad, paas, istart, iend) as Integer
' pixaaJoin(PIXAA *, PIXAA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a clone of each indicated pixa in paas to pixaad<para/>
''' (2) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (3) iend  is lower  0 means 'read to the end'<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paad">[in] - dest pixaa add to this one</param>
'''  <param name="paas">[in][optional] - source pixaa add from this one</param>
'''  <param name="istart">[in] - starting index in pixaas</param>
'''  <param name="iend">[in] - ending index in pixaas use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaJoin(
				 ByVal paad as Pixaa, 
				 ByVal paas as Pixaa, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (paad) then Throw New ArgumentNullException  ("paad cannot be Nothing")



	Dim paasPTR As IntPtr = IntPtr.Zero : If Not IsNothing(paas) Then paasPTR = paas.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaJoin( paad.Pointer, paasPTR, istart, iend)

	Return _Result
End Function

' SRC\pixabasic.c (1772, 1)
' pixaaCreate(n) as Pixaa
' pixaaCreate(l_int32) as PIXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A pixaa provides a 2-level hierarchy of images.<para/>
''' A common use is for segmentation masks, which are<para/>
''' inexpensive to store in png format.<para/>
''' (2) For example, suppose you want a mask for each textline<para/>
''' in a two-column page.  The textline masks for each column<para/>
''' can be represented by a pixa, of which there are 2 in the pixaa.<para/>
''' The boxes for the textline mask components within a column<para/>
''' can have their origin referred to the column rather than the page.<para/>
''' Then the boxa field can be used to represent the two box (regions)<para/>
''' for the columns, and the (x,y) components of each box can<para/>
''' be used to get the absolute position of the textlines on<para/>
''' the page.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of pixa ptrs</param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function pixaaCreate(
				 ByVal n as Integer) as Pixaa





	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (1817, 1)
' pixaaCreateFromPixa(pixa, n, type, copyflag) as Pixaa
' pixaaCreateFromPixa(PIXA *, l_int32, l_int32, l_int32) as PIXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This subdivides a pixa into a set of smaller pixa that<para/>
''' are accumulated into a pixaa.<para/>
''' (2) If type == L_CHOOSE_CONSECUTIVE, the first 'n' pix are<para/>
''' put in a pixa and added to pixaa, then the next 'n', etc.<para/>
''' If type == L_CHOOSE_SKIP_BY, the first pixa is made by<para/>
''' aggregating pix[0], pix[n], pix[2n], etc.<para/>
''' (3) The copyflag specifies if each new pix is a copy or a clone.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - </param>
'''  <param name="n">[in] - number specifying subdivision of pixa</param>
'''  <param name="type">[in] - L_CHOOSE_CONSECUTIVE, L_CHOOSE_SKIP_BY</param>
'''  <param name="copyflag">[in] - L_CLONE, L_COPY</param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function pixaaCreateFromPixa(
				 ByVal pixa as Pixa, 
				 ByVal n as Integer, 
				 ByVal type as Enumerations.L_CHOOSE, 
				 ByVal copyflag as Enumerations.L_access_storage) as Pixaa

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaCreateFromPixa( pixa.Pointer, n, type, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (1879, 1)
' pixaaDestroy(ppaa) as Object
' pixaaDestroy(PIXAA **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="ppaa">[in,out] - to be nulled</param>
Public Shared Sub pixaaDestroy(
				 ByRef ppaa as Pixaa)




	Dim ppaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppaa) Then ppaaPTR = ppaa.Pointer

	LeptonicaSharp.Natives.pixaaDestroy( ppaaPTR)
	if ppaaPTR <> IntPtr.Zero then ppaa = new Pixaa(ppaaPTR)

End Sub

' SRC\pixabasic.c (1923, 1)
' pixaaAddPixa(paa, pixa, copyflag) as Integer
' pixaaAddPixa(PIXAA *, PIXA *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="pixa">[in] - to be added</param>
'''  <param name="copyflag">[in] - : L_INSERT inserts the pixa directly L_COPY makes a new pixa and copies each pix and each box L_CLONE gives a new handle to the input pixa L_COPY_CLONE makes a new pixa and inserts clones of all pix and boxes</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaaAddPixa(
				 ByVal paa as Pixaa, 
				 ByVal pixa as Pixa, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaAddPixa( paa.Pointer, pixa.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixabasic.c (1964, 1)
' pixaaExtendArray(paa) as Integer
' pixaaExtendArray(PIXAA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaaExtendArray(
				 ByVal paa as Pixaa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaExtendArray( paa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (1992, 1)
' pixaaAddPix(paa, index, pix, box, copyflag) as Integer
' pixaaAddPix(PIXAA *, l_int32, PIX *, BOX *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - input paa</param>
'''  <param name="index">[in] - index of pixa in paa</param>
'''  <param name="pix">[in] - to be added</param>
'''  <param name="box">[in][optional] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaaAddPix(
				 ByVal paa as Pixaa, 
				 ByVal index as Integer, 
				 ByVal pix as Pix, 
				 ByVal box as Box, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")



	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaAddPix( paa.Pointer, index, pix.Pointer, boxPTR, copyflag)

	Return _Result
End Function

' SRC\pixabasic.c (2031, 1)
' pixaaAddBox(paa, box, copyflag) as Integer
' pixaaAddBox(PIXAA *, BOX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The box can be used, for example, to hold the support region<para/>
''' of a pixa that is being added to the pixaa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="box">[in] - </param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaAddBox(
				 ByVal paa as Pixaa, 
				 ByVal box as Box, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaAddBox( paa.Pointer, box.Pointer, copyflag)

	Return _Result
End Function

' SRC\pixabasic.c (2066, 1)
' pixaaGetCount(paa, pna) as Integer
' pixaaGetCount(PIXAA *, NUMA **) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If paa is empty, a returned na will also be empty.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="pna">[out][optional] - number of pix in each pixa</param>
'''   <returns>count, or 0 if no pixaa</returns>
Public Shared Function pixaaGetCount(
				 ByVal paa as Pixaa, 
				<Out()> ByRef pna as Numa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")



Dim pnaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pna) Then pnaPTR = pna.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaGetCount( paa.Pointer, pnaPTR)
	if pnaPTR <> IntPtr.Zero then pna = new Numa(pnaPTR)

	Return _Result
End Function

' SRC\pixabasic.c (2115, 1)
' pixaaGetPixa(paa, index, accesstype) as Pixa
' pixaaGetPixa(PIXAA *, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) L_COPY makes a new pixa with a copy of every pix<para/>
''' (2) L_CLONE just makes a new reference to the pixa,<para/>
''' and bumps the counter.  You would use this, for example,<para/>
''' when you need to extract some data from a pix within a<para/>
''' pixa within a pixaa.<para/>
''' (3) L_COPY_CLONE makes a new pixa with a clone of every pix<para/>
''' and box<para/>
''' (4) In all cases, you must invoke pixaDestroy() on the returned pixa<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="index">[in] - to the index-th pixa</param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaaGetPixa(
				 ByVal paa as Pixaa, 
				 ByVal index as Integer, 
				 ByVal accesstype as Enumerations.L_access_storage) as Pixa

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaGetPixa( paa.Pointer, index, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (2153, 1)
' pixaaGetBoxa(paa, accesstype) as Boxa
' pixaaGetBoxa(PIXAA *, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) L_COPY returns a copy L_CLONE returns a new reference to the boxa.<para/>
''' (2) In both cases, invoke boxaDestroy() on the returned boxa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="accesstype">[in] - L_COPY, L_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixaaGetBoxa(
				 ByVal paa as Pixaa, 
				 ByVal accesstype as Enumerations.L_access_storage) as Boxa

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaGetBoxa( paa.Pointer, accesstype)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\pixabasic.c (2177, 1)
' pixaaGetPix(paa, index, ipix, accessflag) as Pix
' pixaaGetPix(PIXAA *, l_int32, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="index">[in] - index into the pixa array in the pixaa</param>
'''  <param name="ipix">[in] - index into the pix array in the pixa</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixaaGetPix(
				 ByVal paa as Pixaa, 
				 ByVal index as Integer, 
				 ByVal ipix as Integer, 
				 ByVal accessflag as Enumerations.L_access_storage) as Pix

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaGetPix( paa.Pointer, index, ipix, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\pixabasic.c (2210, 1)
' pixaaVerifyDepth(paa, psame, pmaxd) as Integer
' pixaaVerifyDepth(PIXAA *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is considered to be an error if any pixa have no pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="psame">[out] - 1 if all pix have the same depth 0 otherwise</param>
'''  <param name="pmaxd">[out][optional] - max depth of all pix in pixaa</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaaVerifyDepth(
				 ByVal paa as Pixaa, 
				<Out()> ByRef psame as Integer, 
				<Out()> ByRef pmaxd as Integer) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaVerifyDepth( paa.Pointer, psame, pmaxd)

	Return _Result
End Function

' SRC\pixabasic.c (2260, 1)
' pixaaVerifyDimensions(paa, psame, pmaxw, pmaxh) as Integer
' pixaaVerifyDimensions(PIXAA *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is considered to be an error if any pixa have no pix.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="psame">[out] - 1 if all pix have the same depth 0 otherwise</param>
'''  <param name="pmaxw">[out][optional] - max width of all pix in pixaa</param>
'''  <param name="pmaxh">[out][optional] - max height of all pix in pixaa</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaaVerifyDimensions(
				 ByVal paa as Pixaa, 
				<Out()> ByRef psame as Integer, 
				<Out()> ByRef pmaxw as Integer, 
				<Out()> ByRef pmaxh as Integer) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaVerifyDimensions( paa.Pointer, psame, pmaxw, pmaxh)

	Return _Result
End Function

' SRC\pixabasic.c (2314, 1)
' pixaaIsFull(paa, pfull) as Integer
' pixaaIsFull(PIXAA *, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Does not require boxa associated with each pixa to be full.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="pfull">[out] - 1 if all pixa in the paa have full pix arrays</param>
'''   <returns>return 0 if OK, 1 on error</returns>
Public Shared Function pixaaIsFull(
				 ByVal paa as Pixaa, 
				<Out()> ByRef pfull as Integer) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaIsFull( paa.Pointer, pfull)

	Return _Result
End Function

' SRC\pixabasic.c (2366, 1)
' pixaaInitFull(paa, pixa) as Integer
' pixaaInitFull(PIXAA *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This initializes a pixaa by filling up the entire pixa ptr array<para/>
''' with copies of %pixa.  Any existing pixa are destroyed.<para/>
''' (2) Example usage.  This function is useful to prepare for a<para/>
''' random insertion (or replacement) of pixa into a pixaa.<para/>
''' To randomly insert pixa into a pixaa, up to some index "max":<para/>
''' Pixaa paa = pixaaCreate(max)<para/>
''' Pixa pixa = pixaCreate(1)  // if you want little memory<para/>
''' pixaaInitFull(paa, pixa)  // copy it to entire array<para/>
''' pixaDestroy( and pixa)  // no longer needed<para/>
''' The initialization allows the pixaa to always be properly filled.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - typically empty</param>
'''  <param name="pixa">[in] - to be replicated into the entire pixa ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaInitFull(
				 ByVal paa as Pixaa, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaInitFull( paa.Pointer, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2408, 1)
' pixaaReplacePixa(paa, index, pixa) as Integer
' pixaaReplacePixa(PIXAA *, l_int32, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allows random insertion of a pixa into a pixaa, with<para/>
''' destruction of any existing pixa at that location.<para/>
''' The input pixa is now owned by the pixaa.<para/>
''' (2) No other pixa in the array are affected.<para/>
''' (3) The index must be within the allowed set.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''  <param name="index">[in] - to the index-th pixa</param>
'''  <param name="pixa">[in] - insert to replace existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaReplacePixa(
				 ByVal paa as Pixaa, 
				 ByVal index as Integer, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaReplacePixa( paa.Pointer, index, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2441, 1)
' pixaaClear(paa) as Integer
' pixaaClear(PIXAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This destroys all pixa in the pixaa, and nulls the ptrs<para/>
''' in the pixa ptr array.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaClear(
				 ByVal paa as Pixaa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaClear( paa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2472, 1)
' pixaaTruncate(paa) as Integer
' pixaaTruncate(PIXAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This identifies the largest index containing a pixa that<para/>
''' has any pix within it, destroys all pixa above that index,<para/>
''' and resets the count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaTruncate(
				 ByVal paa as Pixaa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaTruncate( paa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2519, 1)
' pixaRead(filename) as Pixa
' pixaRead(const char *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaRead(
				 ByVal filename as String) as Pixa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (2556, 1)
' pixaReadStream(fp) as Pixa
' pixaReadStream(FILE *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaReadStream(
				 ByVal fp as FILE) as Pixa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (2615, 1)
' pixaReadMem(data, size) as Pixa
' pixaReadMem(const l_uint8 *, size_t) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - of serialized pixa</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaReadMem(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Pixa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (2652, 1)
' pixaWriteDebug(fname, pixa) as Integer
' pixaWriteDebug(const char *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Debug version, intended for use in the library when writing<para/>
''' to files in a temp directory with names that are compiled in.<para/>
''' This is used instead of pixaWrite() for all such library calls.<para/>
''' (2) The global variable LeptDebugOK defaults to 0, and can be set<para/>
''' or cleared by the function setLeptDebugOK().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixaWriteDebug(
				 ByVal fname as String, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteDebug( fname, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2680, 1)
' pixaWrite(filename, pixa) as Integer
' pixaWrite(const char *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWrite(
				 ByVal filename as String, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWrite( filename, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2721, 1)
' pixaWriteStream(fp, pixa) as Integer
' pixaWriteStream(FILE *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteStream(
				 ByVal fp as FILE, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteStream( fp.Pointer, pixa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (2768, 1)
' pixaWriteMem(pdata, psize, pixa) as Integer
' pixaWriteMem(l_uint8 **, size_t *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a pixa in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized pixa</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pixa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteMem(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteMem( pdataPTR, psize, pixa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\pixabasic.c (2821, 1)
' pixaReadBoth(filename) as Pixa
' pixaReadBoth(const char *) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This reads serialized files of either a pixa or a pixacomp,<para/>
''' and returns a pixa in memory.  It requires png and jpeg libraries.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaReadBoth(
				 ByVal filename as String) as Pixa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaReadBoth( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\pixabasic.c (2878, 1)
' pixaaReadFromFiles(dirname, substr, first, nfiles) as Pixaa
' pixaaReadFromFiles(const char *, const char *, l_int32, l_int32) as PIXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The files must be serialized pixa files (e.g., .pa)<para/>
''' If some files cannot be read, warnings are issued.<para/>
''' (2) Use %substr to filter filenames in the directory.  If<para/>
''' %substr == NULL, this takes all files.<para/>
''' (3) After filtering, use %first and %nfiles to select<para/>
''' a contiguous set of files, that have been lexically<para/>
''' sorted in increasing order.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="first">[in] - 0-based</param>
'''  <param name="nfiles">[in] - use 0 for everything from %first to the end</param>
'''   <returns>paa, or NULL on error or if no pixa files are found.</returns>
Public Shared Function pixaaReadFromFiles(
				 ByVal dirname as String, 
				 ByVal substr as String, 
				 ByVal first as Integer, 
				 ByVal nfiles as Integer) as Pixaa

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaReadFromFiles( dirname, substr, first, nfiles)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (2928, 1)
' pixaaRead(filename) as Pixaa
' pixaaRead(const char *) as PIXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function pixaaRead(
				 ByVal filename as String) as Pixaa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (2965, 1)
' pixaaReadStream(fp) as Pixaa
' pixaaReadStream(FILE *) as PIXAA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function pixaaReadStream(
				 ByVal fp as FILE) as Pixaa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (3023, 1)
' pixaaReadMem(data, size) as Pixaa
' pixaaReadMem(const l_uint8 *, size_t) as PIXAA *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - of serialized pixaa</param>
'''  <param name="size">[in] - of data in bytes</param>
'''   <returns>paa, or NULL on error</returns>
Public Shared Function pixaaReadMem(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as Pixaa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixaa(_Result)
End Function

' SRC\pixabasic.c (3057, 1)
' pixaaWrite(filename, paa) as Integer
' pixaaWrite(const char *, PIXAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaWrite(
				 ByVal filename as String, 
				 ByVal paa as Pixaa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaWrite( filename, paa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (3098, 1)
' pixaaWriteStream(fp, paa) as Integer
' pixaaWriteStream(FILE *, PIXAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The pix are stored in the file as png.<para/>
''' If the png library is not linked, this will fail.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for "wb"</param>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaWriteStream(
				 ByVal fp as FILE, 
				 ByVal paa as Pixaa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaWriteStream( fp.Pointer, paa.Pointer)

	Return _Result
End Function

' SRC\pixabasic.c (3144, 1)
' pixaaWriteMem(pdata, psize, paa) as Integer
' pixaaWriteMem(l_uint8 **, size_t *, PIXAA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a pixaa in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized pixaa</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="paa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaaWriteMem(
				<Out()> ByRef pdata as Byte(), 
				<Out()> ByRef psize as UInteger, 
				 ByVal paa as Pixaa) as Integer

	If IsNothing (paa) then Throw New ArgumentNullException  ("paa cannot be Nothing")



	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaaWriteMem( pdataPTR, psize, paa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class

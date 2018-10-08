Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\sel1.c (239, 1)
' selaCreate(n) as Sela
' selaCreate(l_int32) as SELA *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of sel ptrs use 0 for default</param>
'''   <returns>sela, or NULL on error</returns>
Public Shared Function selaCreate(
				 ByVal n as Integer) as Sela





	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel1.c (272, 1)
' selaDestroy(psela) as Object
' selaDestroy(SELA **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="psela">[in,out] - to be nulled</param>
Public Shared Sub selaDestroy(
				 ByRef psela as Sela)




	Dim pselaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(psela) Then pselaPTR = psela.Pointer

	LeptonicaSharp.Natives.selaDestroy( pselaPTR)
	if pselaPTR <> IntPtr.Zero then psela = new Sela(pselaPTR)

End Sub

' SRC\sel1.c (306, 1)
' selCreate(height, width, name) as Sel
' selCreate(l_int32, l_int32, const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) selCreate() initializes all values to 0.<para/>
''' (2) After this call, (cy,cx) and nonzero data values must be<para/>
''' assigned.  If a text name is not assigned here, it will<para/>
''' be needed later when the sel is put into a sela.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="height">[in] - </param>
'''  <param name="width">[in] - </param>
'''  <param name="name">[in][optional] - sel name can be null</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selCreate(
				 ByVal height as Integer, 
				 ByVal width as Integer, 
				 ByVal name as String) as Sel





	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreate( height, width, name)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (337, 1)
' selDestroy(psel) as Object
' selDestroy(SEL **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="psel">[in,out] - to be nulled</param>
Public Shared Sub selDestroy(
				 ByRef psel as Sel)




	Dim pselPTR As IntPtr = IntPtr.Zero : If Not IsNothing(psel) Then pselPTR = psel.Pointer

	LeptonicaSharp.Natives.selDestroy( pselPTR)
	if pselPTR <> IntPtr.Zero then psel = new Sel(pselPTR)

End Sub

' SRC\sel1.c (370, 1)
' selCopy(sel) as Sel
' selCopy(SEL *) as SEL *
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''   <returns>a copy of the sel, or NULL on error</returns>
Public Shared Function selCopy(
				 ByVal sel as Sel) as Sel

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCopy( sel.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (418, 1)
' selCreateBrick(h, w, cy, cx, type) as Sel
' selCreateBrick(l_int32, l_int32, l_int32, l_int32, l_int32) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a rectangular sel of all hits, misses or don't cares.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="h">[in] - height, width</param>
'''  <param name="w">[in] - height, width</param>
'''  <param name="cy">[in] - origin, relative to UL corner at 0,0</param>
'''  <param name="cx">[in] - origin, relative to UL corner at 0,0</param>
'''  <param name="type">[in] - SEL_HIT, SEL_MISS, or SEL_DONT_CARE</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selCreateBrick(
				 ByVal h as Integer, 
				 ByVal w as Integer, 
				 ByVal cy as Integer, 
				 ByVal cx as Integer, 
				 ByVal type as Enumerations.SEL) as Sel





	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateBrick( h, w, cy, cx, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (462, 1)
' selCreateComb(factor1, factor2, direction) as Sel
' selCreateComb(l_int32, l_int32, l_int32) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates a comb Sel of hits with the origin as<para/>
''' near the center as possible.<para/>
''' (2) In use, this is complemented by a brick sel of size %factor1,<para/>
''' Both brick and comb sels are made by selectComposableSels().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="factor1">[in] - contiguous space between comb tines</param>
'''  <param name="factor2">[in] - number of comb tines</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selCreateComb(
				 ByVal factor1 as Integer, 
				 ByVal factor2 as Integer, 
				 ByVal direction as Enumerations.L_direction) as Sel





	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateComb( factor1, factor2, direction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (515, 1)
' create2dIntArray(sy, sx) as List (of Integer())
' create2dIntArray(l_int32, l_int32) as l_int32 **
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The array[sy][sx] is indexed in standard "matrix notation",<para/>
''' with the row index first.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sy">[in] - rows == height</param>
'''  <param name="sx">[in] - columns == width</param>
'''   <returns>doubly indexed array i.e., an array of sy row pointers, each of which points to an array of sx ints</returns>
Public Shared Function create2dIntArray(
				 ByVal sy as Integer, 
				 ByVal sx as Integer) as List (of Integer())





	Dim _Result as IntPtr = LeptonicaSharp.Natives.create2dIntArray( sy, sx)
Dim PTRArr(1) As IntPtr : Marshal.Copy(_Result, PTRArr, 0, PTRArr.Length)
Dim B As New List(Of Integer())
For Each eintrag In PTRArr
Dim IntegerLST(1) As Integer
Marshal.Copy(eintrag, IntegerLST, 0, IntegerLST.Count)
B.Add(IntegerLST)
Next

	Return B
End Function

' SRC\sel1.c (566, 1)
' selaAddSel(sela, sel, selname, copyflag) as Integer
' selaAddSel(SELA *, SEL *, const char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This adds a sel, either inserting or making a copy.<para/>
''' (2) Because every sel in a sela must have a name, it copies<para/>
''' the input name if necessary.  You can input NULL for<para/>
''' selname if the sel already has a name.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="sel">[in] - to be added</param>
'''  <param name="selname">[in] - ignored if already defined in sel req'd in sel when added to a sela</param>
'''  <param name="copyflag">[in] - L_INSERT or L_COPY</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selaAddSel(
				 ByVal sela as Sela, 
				 ByVal sel as Sel, 
				 ByVal selname as String, 
				 ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selaAddSel( sela.Pointer, sel.Pointer, selname, copyflag)

	Return _Result
End Function

' SRC\sel1.c (639, 1)
' selaGetCount(sela) as Integer
' selaGetCount(SELA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function selaGetCount(
				 ByVal sela as Sela) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selaGetCount( sela.Pointer)

	Return _Result
End Function

' SRC\sel1.c (664, 1)
' selaGetSel(sela, i) as Sel
' selaGetSel(SELA *, l_int32) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a ptr to the sel, not a copy, so the caller<para/>
''' must not destroy it!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="i">[in] - index of sel to be retrieved not copied</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selaGetSel(
				 ByVal sela as Sela, 
				 ByVal i as Integer) as Sel

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaGetSel( sela.Pointer, i)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (685, 1)
' selGetName(sel) as String
' selGetName(SEL *) as char *
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''   <returns>sel name not copied, or NULL if no name or on error</returns>
Public Shared Function selGetName(
				 ByVal sel as Sel) as String

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as String = LeptonicaSharp.Natives.selGetName( sel.Pointer)

	Return _Result
End Function

' SRC\sel1.c (710, 1)
' selSetName(sel, name) as Integer
' selSetName(SEL *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Always frees the existing sel name, if defined.<para/>
''' (2) If name is not defined, just clears any existing sel name.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="name">[in][optional] - can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selSetName(
				 ByVal sel as Sel, 
				 ByVal name as String) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selSetName( sel.Pointer, name)

	Return _Result
End Function

' SRC\sel1.c (732, 1)
' selaFindSelByName(sela, name, pindex, psel) as Integer
' selaFindSelByName(SELA *, const char *, l_int32 *, SEL **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="name">[in] - sel name</param>
'''  <param name="pindex">[out][optional] - </param>
'''  <param name="psel">[in][optional] - sel (not a copy)</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selaFindSelByName(
				 ByVal sela as Sela, 
				 ByVal name as String, 
				<Out()> ByRef pindex as Integer, 
				 ByVal psel as List (of Sel)) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If IsNothing (name) then Throw New ArgumentNullException  ("name cannot be Nothing")



Dim pselPTR As IntPtr = Marshal.AllocHGlobal(Marshal.Sizeof(psel.ToArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.selaFindSelByName( sela.Pointer, name, pindex, pselPTR)

	Return _Result
End Function

' SRC\sel1.c (781, 1)
' selGetElement(sel, row, col, ptype) as Integer
' selGetElement(SEL *, l_int32, l_int32, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="row">[in] - </param>
'''  <param name="col">[in] - </param>
'''  <param name="ptype">[out] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selGetElement(
				 ByVal sel as Sel, 
				 ByVal row as Integer, 
				 ByVal col as Integer, 
				<Out()> ByRef ptype as Enumerations.SEL) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selGetElement( sel.Pointer, row, col, ptype)

	Return _Result
End Function

' SRC\sel1.c (821, 1)
' selSetElement(sel, row, col, type) as Integer
' selSetElement(SEL *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Because we use row and column to index into an array,<para/>
''' they are always non-negative.  The location of the origin<para/>
''' (and the type of operation) determine the actual<para/>
''' direction of the rasterop.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="row">[in] - </param>
'''  <param name="col">[in] - </param>
'''  <param name="type">[in] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selSetElement(
				 ByVal sel as Sel, 
				 ByVal row as Integer, 
				 ByVal col as Integer, 
				 ByVal type as Enumerations.SEL) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selSetElement( sel.Pointer, row, col, type)

	Return _Result
End Function

' SRC\sel1.c (850, 1)
' selGetParameters(sel, psy, psx, pcy, pcx) as Integer
' selGetParameters(SEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="psy">[out][optional] - each can be null</param>
'''  <param name="psx">[out][optional] - each can be null</param>
'''  <param name="pcy">[out][optional] - each can be null</param>
'''  <param name="pcx">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selGetParameters(
				 ByVal sel as Sel, 
				<Out()> ByRef psy as Integer, 
				<Out()> ByRef psx as Integer, 
				<Out()> ByRef pcy as Integer, 
				<Out()> ByRef pcx as Integer) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selGetParameters( sel.Pointer, psy, psx, pcy, pcx)

	Return _Result
End Function

' SRC\sel1.c (880, 1)
' selSetOrigin(sel, cy, cx) as Integer
' selSetOrigin(SEL *, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="cy">[in] - </param>
'''  <param name="cx">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selSetOrigin(
				 ByVal sel as Sel, 
				 ByVal cy as Integer, 
				 ByVal cx as Integer) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selSetOrigin( sel.Pointer, cy, cx)

	Return _Result
End Function

' SRC\sel1.c (902, 1)
' selGetTypeAtOrigin(sel, ptype) as Integer
' selGetTypeAtOrigin(SEL *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="ptype">[out] - SEL_HIT, SEL_MISS, SEL_DONT_CARE</param>
'''   <returns>0 if OK 1 on error or if origin is not found</returns>
Public Shared Function selGetTypeAtOrigin(
				 ByVal sel as Sel, 
				<Out()> ByRef ptype as Enumerations.SEL) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selGetTypeAtOrigin( sel.Pointer, ptype)

	Return _Result
End Function

' SRC\sel1.c (937, 1)
' selaGetBrickName(sela, hsize, vsize) as String
' selaGetBrickName(SELA *, l_int32, l_int32) as char *
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="hsize">[in] - of brick sel</param>
'''  <param name="vsize">[in] - of brick sel</param>
'''   <returns>sel name new string, or NULL if no name or on error</returns>
Public Shared Function selaGetBrickName(
				 ByVal sela as Sela, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer) as String

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as String = LeptonicaSharp.Natives.selaGetBrickName( sela.Pointer, hsize, vsize)

	Return _Result
End Function

' SRC\sel1.c (976, 1)
' selaGetCombName(sela, size, direction) as String
' selaGetCombName(SELA *, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Combs are by definition 1-dimensional, either horiz or vert.<para/>
''' (2) Use this with comb Sels e.g., from selaAddDwaCombs().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="size">[in] - the product of sizes of the brick and comb parts</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT</param>
'''   <returns>sel name new string, or NULL if name not found or on error</returns>
Public Shared Function selaGetCombName(
				 ByVal sela as Sela, 
				 ByVal size as Integer, 
				 ByVal direction as Enumerations.L_direction) as String

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as String = LeptonicaSharp.Natives.selaGetCombName( sela.Pointer, size, direction)

	Return _Result
End Function

' SRC\sel1.c (1104, 1)
' getCompositeParameters(size, psize1, psize2, pnameh1, pnameh2, pnamev1, pnamev2) as Integer
' getCompositeParameters(l_int32, l_int32 *, l_int32 *, char **, char **, char **, char **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the big lookup table at the top of this file.<para/>
''' (2) All returned strings are copies that must be freed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="size">[in] - </param>
'''  <param name="psize1">[out][optional] - brick factor size</param>
'''  <param name="psize2">[out][optional] - comb factor size</param>
'''  <param name="pnameh1">[out][optional] - name of horiz brick</param>
'''  <param name="pnameh2">[out][optional] - name of horiz comb</param>
'''  <param name="pnamev1">[out][optional] - name of vert brick</param>
'''  <param name="pnamev2">[out][optional] - name of vert comb</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function getCompositeParameters(
				 ByVal size as Integer, 
				<Out()> ByRef psize1 as Integer, 
				<Out()> ByRef psize2 as Integer, 
				<Out()> ByRef pnameh1 as String(), 
				<Out()> ByRef pnameh2 as String(), 
				<Out()> ByRef pnamev1 as String(), 
				<Out()> ByRef pnamev2 as String()) as Integer




Dim pnameh1PTR As IntPtr = pnameh1PTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnameh1.toArray))
Dim pnameh2PTR As IntPtr = pnameh2PTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnameh2.toArray))
Dim pnamev1PTR As IntPtr = pnamev1PTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnamev1.toArray))
Dim pnamev2PTR As IntPtr = pnamev2PTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnamev2.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.getCompositeParameters( size, psize1, psize2, pnameh1PTR, pnameh2PTR, pnamev1PTR, pnamev2PTR)

	Return _Result
End Function

' SRC\sel1.c (1148, 1)
' selaGetSelnames(sela) as Sarray
' selaGetSelnames(SELA *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''   <returns>sa of all sel names, or NULL on error</returns>
Public Shared Function selaGetSelnames(
				 ByVal sela as Sela) as Sarray

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaGetSelnames( sela.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sel1.c (1193, 1)
' selFindMaxTranslations(sel, pxp, pyp, pxn, pyn) as Integer
' selFindMaxTranslations(SEL *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' These are the maximum shifts for the erosion operation.<para/>
''' For example, when j  is lower  cx, the shift of the image<para/>
''' is +x to the cx.  This is a positive xp shift.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="pxp">[out] - max shifts</param>
'''  <param name="pyp">[out] - max shifts</param>
'''  <param name="pxn">[out] - max shifts</param>
'''  <param name="pyn">[out] - max shifts</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function selFindMaxTranslations(
				 ByVal sel as Sel, 
				<Out()> ByRef pxp as Integer, 
				<Out()> ByRef pyp as Integer, 
				<Out()> ByRef pxn as Integer, 
				<Out()> ByRef pyn as Integer) as Integer

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selFindMaxTranslations( sel.Pointer, pxp, pyp, pxn, pyn)

	Return _Result
End Function

' SRC\sel1.c (1243, 1)
' selRotateOrth(sel, quads) as Sel
' selRotateOrth(SEL *, l_int32) as SEL *
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="quads">[in] - 0 - 4 number of 90 degree cw rotations</param>
'''   <returns>seld, or NULL on error</returns>
Public Shared Function selRotateOrth(
				 ByVal sel as Sel, 
				 ByVal quads as Integer) as Sel

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selRotateOrth( sel.Pointer, quads)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (1310, 1)
' selaRead(fname) as Sela
' selaRead(const char *) as SELA *
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''   <returns>sela, or NULL on error</returns>
Public Shared Function selaRead(
				 ByVal fname as String) as Sela

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaRead( fname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel1.c (1339, 1)
' selaReadStream(fp) as Sela
' selaReadStream(FILE *) as SELA *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>sela, or NULL on error</returns>
Public Shared Function selaReadStream(
				 ByVal fp as FILE) as Sela

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel1.c (1380, 1)
' selRead(fname) as Sel
' selRead(const char *) as SEL *
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selRead(
				 ByVal fname as String) as Sel

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selRead( fname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (1409, 1)
' selReadStream(fp) as Sel
' selReadStream(FILE *) as SEL *
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selReadStream(
				 ByVal fp as FILE) as Sel

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (1464, 1)
' selaWrite(fname, sela) as Integer
' selaWrite(const char *, SELA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''  <param name="sela">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selaWrite(
				 ByVal fname as String, 
				 ByVal sela as Sela) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selaWrite( fname, sela.Pointer)

	Return _Result
End Function

' SRC\sel1.c (1493, 1)
' selaWriteStream(fp, sela) as Integer
' selaWriteStream(FILE *, SELA *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="sela">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selaWriteStream(
				 ByVal fp as FILE, 
				 ByVal sela as Sela) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selaWriteStream( fp.Pointer, sela.Pointer)

	Return _Result
End Function

' SRC\sel1.c (1526, 1)
' selWrite(fname, sel) as Integer
' selWrite(const char *, SEL *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''  <param name="sel">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selWrite(
				 ByVal fname as String, 
				 ByVal sel as Sel) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selWrite( fname, sel.Pointer)

	Return _Result
End Function

' SRC\sel1.c (1555, 1)
' selWriteStream(fp, sel) as Integer
' selWriteStream(FILE *, SEL *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="sel">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function selWriteStream(
				 ByVal fp as FILE, 
				 ByVal sel as Sel) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.selWriteStream( fp.Pointer, sel.Pointer)

	Return _Result
End Function

' SRC\sel1.c (1616, 1)
' selCreateFromString(text, h, w, name) as Sel
' selCreateFromString(const char *, l_int32, l_int32, const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The text is an array of chars (in row-major order) where<para/>
''' each char can be one of the following:<para/>
''' 'x': hit<para/>
''' 'o': miss<para/>
''' ' ': don't-care<para/>
''' (2) When the origin falls on a hit or miss, use an upper case<para/>
''' char (e.g., 'X' or 'O') to indicate it.  When the origin<para/>
''' falls on a don't-care, indicate this with a 'C'.<para/>
''' The string must have exactly one origin specified.<para/>
''' (3) The advantage of this method is that the text can be input<para/>
''' in a format that shows the 2D layout of the Sel e.g.,<para/>
''' \code<para/>
''' static const char seltext = "x  "<para/>
''' "x Oo "<para/>
''' "x  "<para/>
''' "xxxxx"<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="text">[in] - </param>
'''  <param name="h">[in] - height, width</param>
'''  <param name="w">[in] - height, width</param>
'''  <param name="name">[in][optional] - sel name can be null</param>
'''   <returns>sel of the given size, or NULL on error</returns>
Public Shared Function selCreateFromString(
				 ByVal text as String, 
				 ByVal h as Integer, 
				 ByVal w as Integer, 
				 ByVal name as String) as Sel

	If IsNothing (text) then Throw New ArgumentNullException  ("text cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateFromString( text, h, w, name)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (1704, 1)
' selPrintToString(sel) as String
' selPrintToString(SEL *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an inverse function of selCreateFromString.<para/>
''' It prints a textual representation of the SEL to a malloc'd<para/>
''' string.  The format is the same as selCreateFromString<para/>
''' except that newlines are inserted into the output<para/>
''' between rows.<para/>
''' (2) This is useful for debugging.  However, if you want to<para/>
''' save some Sels in a file, put them in a Sela and write<para/>
''' them out with selaWrite().  They can then be read in<para/>
''' with selaRead().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''   <returns>str string caller must free</returns>
Public Shared Function selPrintToString(
				 ByVal sel as Sel) as String

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as String = LeptonicaSharp.Natives.selPrintToString( sel.Pointer)

	Return _Result
End Function

' SRC\sel1.c (1779, 1)
' selaCreateFromFile(filename) as Sela
' selaCreateFromFile(const char *) as SELA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The file contains a sequence of Sel descriptions.<para/>
''' (2) Each Sel is formatted as follows:<para/>
''' ~ Any number of comment lines starting with '#' are ignored<para/>
''' ~ The next line contains the selname<para/>
''' ~ The next lines contain the Sel data.  They must be<para/>
''' formatted similarly to the string format in<para/>
''' selCreateFromString(), with each line beginning and<para/>
''' ending with a double-quote, and showing the 2D layout.<para/>
''' ~ Each Sel ends when a blank line, a comment line, or<para/>
''' the end of file is reached.<para/>
''' (3) See selCreateFromString() for a description of the string<para/>
''' format for the Sel data.  As an example, here are the lines<para/>
''' of is a valid file for a single Sel.  In the file, all lines<para/>
''' are left-justified:<para/>
''' # diagonal sel<para/>
''' sel_5diag<para/>
''' "x  "<para/>
''' " x "<para/>
''' "  X  "<para/>
''' " x "<para/>
''' "  x"<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>sela, or NULL on error</returns>
Public Shared Function selaCreateFromFile(
				 ByVal filename as String) as Sela

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")


	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaCreateFromFile( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel1.c (1959, 1)
' selCreateFromPta(pta, cy, cx, name) as Sel
' selCreateFromPta(PTA *, l_int32, l_int32, const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The origin and all points in the pta must be positive.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="cy">[in] - origin of sel</param>
'''  <param name="cx">[in] - origin of sel</param>
'''  <param name="name">[in][optional] - sel name can be null</param>
'''   <returns>sel of minimum required size, or NULL on error</returns>
Public Shared Function selCreateFromPta(
				 ByVal pta as Pta, 
				 ByVal cy as Integer, 
				 ByVal cx as Integer, 
				 ByVal name as String) as Sel

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateFromPta( pta.Pointer, cy, cx, name)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (2009, 1)
' selCreateFromPix(pix, cy, cx, name) as Sel
' selCreateFromPix(PIX *, l_int32, l_int32, const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The origin must be positive.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - </param>
'''  <param name="cy">[in] - origin of sel</param>
'''  <param name="cx">[in] - origin of sel</param>
'''  <param name="name">[in][optional] - sel name can be null</param>
'''   <returns>sel, or NULL on error</returns>
Public Shared Function selCreateFromPix(
				 ByVal pix as Pix, 
				 ByVal cy as Integer, 
				 ByVal cx as Integer, 
				 ByVal name as String) as Sel

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateFromPix( pix.Pointer, cy, cx, name)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (2060, 1)
' selReadFromColorImage(pathname) as Sel
' selReadFromColorImage(const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Loads an image from a file and creates a (hit-miss) sel.<para/>
''' (2) The sel name is taken from the pathname without the directory<para/>
''' and extension.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pathname">[in] - </param>
'''   <returns>sel if OK NULL on error</returns>
Public Shared Function selReadFromColorImage(
				 ByVal pathname as String) as Sel

	If IsNothing (pathname) then Throw New ArgumentNullException  ("pathname cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selReadFromColorImage( pathname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (2109, 1)
' selCreateFromColorPix(pixs, selname) as Sel
' selCreateFromColorPix(PIX *, const char *) as SEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The sel size is given by the size of pixs.<para/>
''' (2) In pixs, hits are represented by green pixels, misses by red<para/>
''' pixels, and don't-cares by white pixels.<para/>
''' (3) In pixs, there may be no misses, but there must be at least 1 hit.<para/>
''' (4) At most there can be only one origin pixel, which is optionally<para/>
''' specified by using a lower-intensity pixel:<para/>
''' if a hit:  dark green<para/>
''' if a miss: dark red<para/>
''' if a don't care: gray<para/>
''' If there is no such pixel, the origin defaults to the approximate<para/>
''' center of the sel.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - cmapped or rgb</param>
'''  <param name="selname">[in][optional] - sel name can be null</param>
'''   <returns>sel if OK, NULL on error</returns>
Public Shared Function selCreateFromColorPix(
				 ByVal pixs as Pix, 
				 ByVal selname as String) as Sel

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selCreateFromColorPix( pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sel(_Result)
End Function

' SRC\sel1.c (2200, 1)
' selDisplayInPix(sel, size, gthick) as Pix
' selDisplayInPix(SEL *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives a visual representation of a general (hit-miss) sel.<para/>
''' (2) The empty sel is represented by a grid of intersecting lines.<para/>
''' (3) Three different patterns are generated for the sel elements:<para/>
''' ~ hit (solid black circle)<para/>
''' ~ miss (black ring inner radius is radius2)<para/>
''' ~ origin (cross, XORed with whatever is there)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sel">[in] - </param>
'''  <param name="size">[in] - of grid interiors odd minimum size of 13 is enforced</param>
'''  <param name="gthick">[in] - grid thickness minimum size of 2 is enforced</param>
'''   <returns>pix display of sel, or NULL on error</returns>
Public Shared Function selDisplayInPix(
				 ByVal sel as Sel, 
				 ByVal size as Integer, 
				 ByVal gthick as Integer) as Pix

	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selDisplayInPix( sel.Pointer, size, gthick)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\sel1.c (2318, 1)
' selaDisplayInPix(sela, size, gthick, spacing, ncols) as Pix
' selaDisplayInPix(SELA *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This gives a visual representation of all the sels in a sela.<para/>
''' (2) See notes in selDisplayInPix() for display params of each sel.<para/>
''' (3) This gives the nicest results when all sels in the sela<para/>
''' are the same size.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="size">[in] - of grid interiors odd minimum size of 13 is enforced</param>
'''  <param name="gthick">[in] - grid thickness minimum size of 2 is enforced</param>
'''  <param name="spacing">[in] - between sels, both horizontally and vertically</param>
'''  <param name="ncols">[in] - number of sels per "line"</param>
'''   <returns>pix display of all sels in sela, or NULL on error</returns>
Public Shared Function selaDisplayInPix(
				 ByVal sela as Sela, 
				 ByVal size as Integer, 
				 ByVal gthick as Integer, 
				 ByVal spacing as Integer, 
				 ByVal ncols as Integer) as Pix

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaDisplayInPix( sela.Pointer, size, gthick, spacing, ncols)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class

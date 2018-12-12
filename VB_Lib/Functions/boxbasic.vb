Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' boxbasic.c (165, 1)
' boxCreate(x, y, w, h) as Box
' boxCreate(l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' (1) This clips the box to the +quad.  If no part of the
'''box is in the +quad, this returns NULL.<para/>
'''
'''(2) We allow you to make a box with w = 0 and/or h = 0.
'''This does not represent a valid region, but it is useful
'''as a placeholder in a boxa for which the index of the
'''box in the boxa is important.  This is an atypical
'''situation usually you want to put only valid boxes with
'''nonzero width and height in a boxa.  If you have a boxa
'''with invalid boxes, the accessor boxaGetValidBox()
'''will return NULL on each invalid box.<para/>
'''
'''(3) If you want to create only valid boxes, use boxCreateValid(),
'''which returns NULL if either w or h is 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCreate/*"/>
'''  <param name="x">[in] - </param>
'''  <param name="y">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function boxCreate(
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer) as Box


	Dim _Result as IntPtr = Natives.boxCreate(  x,   y,   w,   h)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (210, 1)
' boxCreateValid(x, y, w, h) as Box
' boxCreateValid(l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' (1) This returns NULL if either w = 0 or h = 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCreateValid/*"/>
'''  <param name="x">[in] - </param>
'''  <param name="y">[in] - </param>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function boxCreateValid(
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer) as Box


	Dim _Result as IntPtr = Natives.boxCreateValid(  x,   y,   w,   h)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (230, 1)
' boxCopy(box) as Box
' boxCopy(BOX *) as BOX *
'''  <summary>
''' boxCopy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxCopy/*"/>
'''  <param name="box">[in] - </param>
'''   <returns>copy of box, or NULL on error</returns>
Public Shared Function boxCopy(
				ByVal box as Box) as Box


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxCopy(box.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (252, 1)
' boxClone(box) as Box
' boxClone(BOX *) as BOX *
'''  <summary>
''' boxClone()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxClone/*"/>
'''  <param name="box">[in] - </param>
'''   <returns>ptr to same box, or NULL on error</returns>
Public Shared Function boxClone(
				ByVal box as Box) as Box


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxClone(box.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (278, 1)
' boxDestroy(pbox) as Object
' boxDestroy(BOX **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the box.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxDestroy/*"/>
'''  <param name="pbox">[in,out] - will be set to null before returning</param>
Public Shared Sub boxDestroy(
				ByRef pbox as Box)


	Dim pboxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pbox) Then pboxPtr = pbox.Pointer

	Natives.boxDestroy( pboxPtr)
	
	if pboxPtr = IntPtr.Zero then pbox = Nothing else pbox = new Box(pboxPtr)
End Sub

' boxbasic.c (310, 1)
' boxGetGeometry(box, px, py, pw, ph) as Integer
' boxGetGeometry(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' boxGetGeometry()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetGeometry/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="px">[out][optional] - each can be null</param>
'''  <param name="py">[out][optional] - each can be null</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetGeometry(
				ByVal box as Box, 
				<Out()> Optional  ByRef px as Integer = 0, 
				<Out()> Optional  ByRef py as Integer = 0, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxGetGeometry(box.Pointer,   px,   py,   pw,   ph)
	
	return _Result
End Function

' boxbasic.c (340, 1)
' boxSetGeometry(box, x, y, w, h) as Integer
' boxSetGeometry(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' boxSetGeometry()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSetGeometry/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="x">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="y">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="w">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="h">[in][optional] - use -1 to leave unchanged</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSetGeometry(
				ByVal box as Box, 
				Optional ByVal x as Integer = 0, 
				Optional ByVal y as Integer = 0, 
				Optional ByVal w as Integer = 0, 
				Optional ByVal h as Integer = 0) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxSetGeometry(box.Pointer,   x,   y,   w,   h)
	
	return _Result
End Function

' boxbasic.c (371, 1)
' boxGetSideLocations(box, pl, pr, pt, pb) as Integer
' boxGetSideLocations(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) All returned values are within the box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetSideLocations/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="pl">[out][optional] - each can be null</param>
'''  <param name="pr">[out][optional] - each can be null</param>
'''  <param name="pt">[out][optional] - each can be null</param>
'''  <param name="pb">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetSideLocations(
				ByVal box as Box, 
				<Out()> Optional  ByRef pl as Integer = 0, 
				<Out()> Optional  ByRef pr as Integer = 0, 
				<Out()> Optional  ByRef pt as Integer = 0, 
				<Out()> Optional  ByRef pb as Integer = 0) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxGetSideLocations(box.Pointer,   pl,   pr,   pt,   pb)
	
	return _Result
End Function

' boxbasic.c (405, 1)
' boxSetSideLocations(box, l, r, t, b) as Integer
' boxSetSideLocations(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' boxSetSideLocations()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxSetSideLocations/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="l">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="r">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="t">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="b">[in][optional] - use -1 to leave unchanged</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSetSideLocations(
				ByVal box as Box, 
				Optional ByVal l as Integer = 0, 
				Optional ByVal r as Integer = 0, 
				Optional ByVal t as Integer = 0, 
				Optional ByVal b as Integer = 0) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxSetSideLocations(box.Pointer,   l,   r,   t,   b)
	
	return _Result
End Function

' boxbasic.c (432, 1)
' boxGetRefcount(box) as Integer
' boxGetRefcount(BOX *) as l_int32
'''  <summary>
''' Return the current reference count of %box
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxGetRefcount/*"/>
'''  <param name="box">[in] - ptr to Box</param>
'''   <returns>refcount</returns>
Public Shared Function boxGetRefcount(
				ByVal box as Box) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxGetRefcount(box.Pointer)
	
	return _Result
End Function

' boxbasic.c (449, 1)
' boxChangeRefcount(box, delta) as Integer
' boxChangeRefcount(BOX *, l_int32) as l_ok
'''  <summary>
''' Adjust the current references count of %box by %delta
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxChangeRefcount/*"/>
'''  <param name="box">[in] - ptr to box</param>
'''  <param name="delta">[in] - adjustment, usually -1 or 1</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxChangeRefcount(
				ByVal box as Box, 
				ByVal delta as Integer) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxChangeRefcount(box.Pointer,   delta)
	
	return _Result
End Function

' boxbasic.c (470, 1)
' boxIsValid(box, pvalid) as Integer
' boxIsValid(BOX *, l_int32 *) as l_ok
'''  <summary>
''' boxIsValid()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxIsValid/*"/>
'''  <param name="box">[in] - </param>
'''  <param name="pvalid">[out] - 1 if valid 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxIsValid(
				ByVal box as Box, 
				<Out()>  ByRef pvalid as Integer) as Integer


if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxIsValid(box.Pointer,   pvalid)
	
	return _Result
End Function

' boxbasic.c (497, 1)
' boxaCreate(n) as Boxa
' boxaCreate(l_int32) as BOXA *
'''  <summary>
''' boxaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCreate/*"/>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaCreate(
				ByVal n as Integer) as Boxa


	Dim _Result as IntPtr = Natives.boxaCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (532, 1)
' boxaCopy(boxa, copyflag) as Boxa
' boxaCopy(BOXA *, l_int32) as BOXA *
'''  <summary>
''' (1) See pix.h for description of the copyflag.<para/>
'''
'''(2) The copy-clone makes a new boxa that holds clones of each box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaCopy/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>new boxa, or NULL on error</returns>
Public Shared Function boxaCopy(
				ByVal boxa as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxa


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaCopy(boxa.Pointer,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (578, 1)
' boxaDestroy(pboxa) as Object
' boxaDestroy(BOXA **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the boxa.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaDestroy/*"/>
'''  <param name="pboxa">[in,out] - will be set to null before returning</param>
Public Shared Sub boxaDestroy(
				ByRef pboxa as Boxa)


	Dim pboxaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pboxa) Then pboxaPtr = pboxa.Pointer

	Natives.boxaDestroy( pboxaPtr)
	
	if pboxaPtr = IntPtr.Zero then pboxa = Nothing else pboxa = new Boxa(pboxaPtr)
End Sub

' boxbasic.c (616, 1)
' boxaAddBox(boxa, box, copyflag) as Integer
' boxaAddBox(BOXA *, BOX *, l_int32) as l_ok
'''  <summary>
''' boxaAddBox()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaAddBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaAddBox(
				ByVal boxa as Boxa, 
				ByVal box as Box, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxaAddBox(boxa.Pointer, box.Pointer,   copyflag)
	
	return _Result
End Function

' boxbasic.c (663, 1)
' boxaExtendArray(boxa) as Integer
' boxaExtendArray(BOXA *) as l_ok
'''  <summary>
''' (1) Reallocs with doubled size of ptr array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtendArray/*"/>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function boxaExtendArray(
				ByVal boxa as Boxa) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaExtendArray(boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (687, 1)
' boxaExtendArrayToSize(boxa, size) as Integer
' boxaExtendArrayToSize(BOXA *, l_int32) as l_ok
'''  <summary>
''' (1) If necessary, reallocs new boxa ptr array to %size.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaExtendArrayToSize/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="size">[in] - new size of boxa array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function boxaExtendArrayToSize(
				ByVal boxa as Boxa, 
				ByVal size as Integer) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaExtendArrayToSize(boxa.Pointer,   size)
	
	return _Result
End Function

' boxbasic.c (716, 1)
' boxaGetCount(boxa) as Integer
' boxaGetCount(BOXA *) as l_int32
'''  <summary>
''' boxaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetCount/*"/>
'''  <param name="boxa">[in] - </param>
'''   <returns>count of all boxes 0 if no boxes or on error</returns>
Public Shared Function boxaGetCount(
				ByVal boxa as Boxa) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaGetCount(boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (733, 1)
' boxaGetValidCount(boxa) as Integer
' boxaGetValidCount(BOXA *) as l_int32
'''  <summary>
''' boxaGetValidCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetValidCount/*"/>
'''  <param name="boxa">[in] - </param>
'''   <returns>count of valid boxes 0 if no valid boxes or on error</returns>
Public Shared Function boxaGetValidCount(
				ByVal boxa as Boxa) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaGetValidCount(boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (761, 1)
' boxaGetBox(boxa, index, accessflag) as Box
' boxaGetBox(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' boxaGetBox()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function boxaGetBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Box


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaGetBox(boxa.Pointer,   index,   accessflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (800, 1)
' boxaGetValidBox(boxa, index, accessflag) as Box
' boxaGetValidBox(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' (1) This returns NULL for an invalid box in a boxa.
'''For a box to be valid, both the width and height must be  is greater  0.<para/>
'''
'''(2) We allow invalid boxes, with w = 0 or h = 0, as placeholders
'''in boxa for which the index of the box in the boxa is important.
'''This is an atypical situation usually you want to put only
'''valid boxes in a boxa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetValidBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>box, or NULL if box is not valid or on error</returns>
Public Shared Function boxaGetValidBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Box


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaGetValidBox(boxa.Pointer,   index,   accessflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (828, 1)
' boxaFindInvalidBoxes(boxa) as Numa
' boxaFindInvalidBoxes(BOXA *) as NUMA *
'''  <summary>
''' boxaFindInvalidBoxes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaFindInvalidBoxes/*"/>
'''  <param name="boxa">[in] - </param>
'''   <returns>na   numa of invalid boxes NULL if there are none or on error</returns>
Public Shared Function boxaFindInvalidBoxes(
				ByVal boxa as Boxa) as Numa


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaFindInvalidBoxes(boxa.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' boxbasic.c (861, 1)
' boxaGetBoxGeometry(boxa, index, px, py, pw, ph) as Integer
' boxaGetBoxGeometry(BOXA *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' boxaGetBoxGeometry()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaGetBoxGeometry/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="px">[out][optional] - each can be null</param>
'''  <param name="py">[out][optional] - each can be null</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaGetBoxGeometry(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef px as Integer = 0, 
				<Out()> Optional  ByRef py as Integer = 0, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaGetBoxGeometry(boxa.Pointer,   index,   px,   py,   pw,   ph)
	
	return _Result
End Function

' boxbasic.c (897, 1)
' boxaIsFull(boxa, pfull) as Integer
' boxaIsFull(BOXA *, l_int32 *) as l_ok
'''  <summary>
''' boxaIsFull()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaIsFull/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="pfull">[out] - 1 if boxa is full</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaIsFull(
				ByVal boxa as Boxa, 
				<Out()>  ByRef pfull as Integer) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaIsFull(boxa.Pointer,   pfull)
	
	return _Result
End Function

' boxbasic.c (943, 1)
' boxaReplaceBox(boxa, index, box) as Integer
' boxaReplaceBox(BOXA *, l_int32, BOX *) as l_ok
'''  <summary>
''' (1) In-place replacement of one box.<para/>
'''
'''(2) The previous box at that location, if any, is destroyed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReplaceBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="box">[in] - insert to replace existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaReplaceBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal box as Box) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxaReplaceBox(boxa.Pointer,   index, box.Pointer)
	
	return _Result
End Function

' boxbasic.c (981, 1)
' boxaInsertBox(boxa, index, box) as Integer
' boxaInsertBox(BOXA *, l_int32, BOX *) as l_ok
'''  <summary>
''' (1) This shifts box[i] to box[i + 1] for all i greater or equal index,
'''and then inserts box as box[index].<para/>
'''
'''(2) To insert at the beginning of the array, set index = 0.<para/>
'''
'''(3) To append to the array, it's easier to use boxaAddBox().<para/>
'''
'''(4) This should not be used repeatedly to insert into large arrays,
'''because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaInsertBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - location in boxa to insert new value</param>
'''  <param name="box">[in] - new box to be inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaInsertBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal box as Box) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxaInsertBox(boxa.Pointer,   index, box.Pointer)
	
	return _Result
End Function

' boxbasic.c (1026, 1)
' boxaRemoveBox(boxa, index) as Integer
' boxaRemoveBox(BOXA *, l_int32) as l_ok
'''  <summary>
''' (1) This removes box[index] and then shifts
'''box[i] to box[i - 1] for all i  is greater  index.<para/>
'''
'''(2) It should not be used repeatedly to remove boxes from
'''large arrays, because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRemoveBox/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - of box to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaRemoveBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaRemoveBox(boxa.Pointer,   index)
	
	return _Result
End Function

' boxbasic.c (1068, 1)
' boxaRemoveBoxAndSave(boxa, index, pbox) as Integer
' boxaRemoveBoxAndSave(BOXA *, l_int32, BOX **) as l_ok
'''  <summary>
''' (1) This removes box[index] and then shifts
'''box[i] to box[i - 1] for all i  is greater  index.<para/>
'''
'''(2) It should not be used repeatedly to remove boxes from
'''large arrays, because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRemoveBoxAndSave/*"/>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - of box to be removed</param>
'''  <param name="pbox">[out][optional] - removed box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaRemoveBoxAndSave(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef pbox as Box = Nothing) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim pboxPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.boxaRemoveBoxAndSave(boxa.Pointer,   index, pboxPtr)
	
	if pboxPtr = IntPtr.Zero then pbox = Nothing else pbox = new Box(pboxPtr)
	return _Result
End Function

' boxbasic.c (1110, 1)
' boxaSaveValid(boxas, copyflag) as Boxa
' boxaSaveValid(BOXA *, l_int32) as BOXA *
'''  <summary>
''' (1) This makes a copy/clone of each valid box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaSaveValid/*"/>
'''  <param name="boxas">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxad if OK, NULL on error</returns>
Public Shared Function boxaSaveValid(
				ByVal boxas as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxa


if IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaSaveValid(boxas.Pointer,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (1174, 1)
' boxaInitFull(boxa, box) as Integer
' boxaInitFull(BOXA *, BOX *) as l_ok
'''  <summary>
''' (1) This initializes a boxa by filling up the entire box ptr array
'''with copies of %box.  If %box == NULL, use a placeholder box
'''of zero size.  Any existing boxes are destroyed.
'''After this opepration, the number of boxes is equal to
'''the number of allocated ptrs.<para/>
'''
'''(2) Note that we use boxaReplaceBox() instead of boxaInsertBox().
'''They both have the same effect when inserting into a NULL ptr
'''in the boxa ptr array:<para/>
'''
'''(3) Example usage.  This function is useful to prepare for a
'''random insertion (or replacement) of boxes into a boxa.
'''To randomly insert boxes into a boxa, up to some index "max":
'''Boxa boxa = boxaCreate(max)
'''boxaInitFull(boxa, NULL)
'''If you want placeholder boxes of non-zero size:
'''Boxa boxa = boxaCreate(max)
'''Box box = boxCreate(...)
'''boxaInitFull(boxa, box)
'''boxDestroy([and]box)
'''If we have an existing boxa with a smaller ptr array, it can
'''be reused for up to max boxes:
'''boxaExtendArrayToSize(boxa, max)
'''boxaInitFull(boxa, NULL)
'''The initialization allows the boxa to always be properly
'''filled, even if all the boxes are not later replaced.
'''If you want to know which boxes have been replaced,
'''and you initialized with invalid zero-sized boxes,
'''use boxaGetValidBox() to return NULL for the invalid boxes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaInitFull/*"/>
'''  <param name="boxa">[in] - typically empty</param>
'''  <param name="box">[in][optional] - to be replicated into the entire ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaInitFull(
				ByVal boxa as Boxa, 
				Optional ByVal box as Box = Nothing) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as Integer = Natives.boxaInitFull(boxa.Pointer, boxPtr)
	
	return _Result
End Function

' boxbasic.c (1211, 1)
' boxaClear(boxa) as Integer
' boxaClear(BOXA *) as l_ok
'''  <summary>
''' (1) This destroys all boxes in the boxa, setting the ptrs
'''to null.  The number of allocated boxes, n, is set to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaClear/*"/>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaClear(
				ByVal boxa as Boxa) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaClear(boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1238, 1)
' boxaaCreate(n) as Boxaa
' boxaaCreate(l_int32) as BOXAA *
'''  <summary>
''' boxaaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaCreate/*"/>
'''  <param name="n">[in] - size of boxa ptr array to be alloc'd 0 for default</param>
'''   <returns>baa, or NULL on error</returns>
Public Shared Function boxaaCreate(
				ByVal n as Integer) as Boxaa


	Dim _Result as IntPtr = Natives.boxaaCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1273, 1)
' boxaaCopy(baas, copyflag) as Boxaa
' boxaaCopy(BOXAA *, l_int32) as BOXAA *
'''  <summary>
''' (1) L_COPY makes a copy of each boxa in baas.
'''L_CLONE makes a clone of each boxa in baas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaCopy/*"/>
'''  <param name="baas">[in] - input boxaa to be copied</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>baad new boxaa, composed of copies or clones of the boxa in baas, or NULL on error</returns>
Public Shared Function boxaaCopy(
				ByVal baas as Boxaa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxaa


if IsNothing (baas) then Throw New ArgumentNullException  ("baas cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaCopy(baas.Pointer,   copyflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1304, 1)
' boxaaDestroy(pbaa) as Object
' boxaaDestroy(BOXAA **) as void
'''  <summary>
''' boxaaDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaDestroy/*"/>
'''  <param name="pbaa">[in,out] - will be set to null before returning</param>
Public Shared Sub boxaaDestroy(
				ByRef pbaa as Boxaa)


	Dim pbaaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pbaa) Then pbaaPtr = pbaa.Pointer

	Natives.boxaaDestroy( pbaaPtr)
	
	if pbaaPtr = IntPtr.Zero then pbaa = Nothing else pbaa = new Boxaa(pbaaPtr)
End Sub

' boxbasic.c (1342, 1)
' boxaaAddBoxa(baa, ba, copyflag) as Integer
' boxaaAddBoxa(BOXAA *, BOXA *, l_int32) as l_ok
'''  <summary>
''' boxaaAddBoxa()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaAddBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="ba">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaAddBoxa(
				ByVal baa as Boxaa, 
				ByVal ba as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaAddBoxa(baa.Pointer, ba.Pointer,   copyflag)
	
	return _Result
End Function

' boxbasic.c (1379, 1)
' boxaaExtendArray(baa) as Integer
' boxaaExtendArray(BOXAA *) as l_ok
'''  <summary>
''' boxaaExtendArray()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendArray/*"/>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaExtendArray(
				ByVal baa as Boxaa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaExtendArray(baa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1410, 1)
' boxaaExtendArrayToSize(baa, size) as Integer
' boxaaExtendArrayToSize(BOXAA *, l_int32) as l_ok
'''  <summary>
''' (1) If necessary, reallocs the boxa ptr array to %size.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendArrayToSize/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="size">[in] - new size of boxa array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function boxaaExtendArrayToSize(
				ByVal baa as Boxaa, 
				ByVal size as Integer) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaExtendArrayToSize(baa.Pointer,   size)
	
	return _Result
End Function

' boxbasic.c (1439, 1)
' boxaaGetCount(baa) as Integer
' boxaaGetCount(BOXAA *) as l_int32
'''  <summary>
''' boxaaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetCount/*"/>
'''  <param name="baa">[in] - </param>
'''   <returns>count number of boxa, or 0 if no boxa or on error</returns>
Public Shared Function boxaaGetCount(
				ByVal baa as Boxaa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaGetCount(baa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1456, 1)
' boxaaGetBoxCount(baa) as Integer
' boxaaGetBoxCount(BOXAA *) as l_int32
'''  <summary>
''' boxaaGetBoxCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBoxCount/*"/>
'''  <param name="baa">[in] - </param>
'''   <returns>count number of boxes, or 0 if no boxes or on error</returns>
Public Shared Function boxaaGetBoxCount(
				ByVal baa as Boxaa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaGetBoxCount(baa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1486, 1)
' boxaaGetBoxa(baa, index, accessflag) as Boxa
' boxaaGetBoxa(BOXAA *, l_int32, l_int32) as BOXA *
'''  <summary>
''' boxaaGetBoxa()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - to the index-th boxa</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaaGetBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Boxa


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaGetBoxa(baa.Pointer,   index,   accessflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (1516, 1)
' boxaaGetBox(baa, iboxa, ibox, accessflag) as Box
' boxaaGetBox(BOXAA *, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' boxaaGetBox()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaGetBox/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="iboxa">[in] - index into the boxa array in the boxaa</param>
'''  <param name="ibox">[in] - index into the box array in the boxa</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function boxaaGetBox(
				ByVal baa as Boxaa, 
				ByVal iboxa as Integer, 
				ByVal ibox as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Box


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaGetBox(baa.Pointer,   iboxa,   ibox,   accessflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Box(_Result)
End Function

' boxbasic.c (1568, 1)
' boxaaInitFull(baa, boxa) as Integer
' boxaaInitFull(BOXAA *, BOXA *) as l_ok
'''  <summary>
''' (1) This initializes a boxaa by filling up the entire boxa ptr array
'''with copies of %boxa.  Any existing boxa are destroyed.
'''After this operation, the number of boxa is equal to
'''the number of allocated ptrs.<para/>
'''
'''(2) Note that we use boxaaReplaceBox() instead of boxaInsertBox().
'''They both have the same effect when inserting into a NULL ptr
'''in the boxa ptr array<para/>
'''
'''(3) Example usage.  This function is useful to prepare for a
'''random insertion (or replacement) of boxa into a boxaa.
'''To randomly insert boxa into a boxaa, up to some index "max":
'''Boxaa baa = boxaaCreate(max)
'''// initialize the boxa
'''Boxa boxa = boxaCreate(...)
'''...  [optionally fix with boxes]
'''boxaaInitFull(baa, boxa)
'''A typical use is to initialize the array with empty boxa,
'''and to replace only a subset that must be aligned with
'''something else, such as a pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaInitFull/*"/>
'''  <param name="baa">[in] - typically empty</param>
'''  <param name="boxa">[in] - to be replicated into the entire ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaInitFull(
				ByVal baa as Boxaa, 
				ByVal boxa as Boxa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaInitFull(baa.Pointer, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1608, 1)
' boxaaExtendWithInit(baa, maxindex, boxa) as Integer
' boxaaExtendWithInit(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' (1) This should be used on an existing boxaa that has been
'''fully loaded with boxa.  It then extends the boxaa,
'''loading all the additional ptrs with copies of boxa.
'''Typically, boxa will be empty.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaExtendWithInit/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="maxindex">[in] - </param>
'''  <param name="boxa">[in] - to be replicated into the extended ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaExtendWithInit(
				ByVal baa as Boxaa, 
				ByVal maxindex as Integer, 
				ByVal boxa as Boxa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaExtendWithInit(baa.Pointer,   maxindex, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1649, 1)
' boxaaReplaceBoxa(baa, index, boxa) as Integer
' boxaaReplaceBoxa(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' (1) Any existing boxa is destroyed, and the input one
'''is inserted in its place.<para/>
'''
'''(2) If the index is invalid, return 1 (error)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReplaceBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - to the index-th boxa</param>
'''  <param name="boxa">[in] - insert and replace any existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaReplaceBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal boxa as Boxa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaReplaceBoxa(baa.Pointer,   index, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1690, 1)
' boxaaInsertBoxa(baa, index, boxa) as Integer
' boxaaInsertBoxa(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' (1) This shifts boxa[i] to boxa[i + 1] for all i greater or equal index,
'''and then inserts boxa as boxa[index].<para/>
'''
'''(2) To insert at the beginning of the array, set index = 0.<para/>
'''
'''(3) To append to the array, it's easier to use boxaaAddBoxa().<para/>
'''
'''(4) This should not be used repeatedly to insert into large arrays,
'''because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaInsertBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - location in boxaa to insert new boxa</param>
'''  <param name="boxa">[in] - new boxa to be inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaInsertBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal boxa as Boxa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaInsertBoxa(baa.Pointer,   index, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1736, 1)
' boxaaRemoveBoxa(baa, index) as Integer
' boxaaRemoveBoxa(BOXAA *, l_int32) as l_ok
'''  <summary>
''' (1) This removes boxa[index] and then shifts
'''boxa[i] to boxa[i - 1] for all i  is greater  index.<para/>
'''
'''(2) The removed boxaa is destroyed.<para/>
'''
'''(2) This should not be used repeatedly on large arrays,
'''because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaRemoveBoxa/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - of the boxa to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaRemoveBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaRemoveBoxa(baa.Pointer,   index)
	
	return _Result
End Function

' boxbasic.c (1776, 1)
' boxaaAddBox(baa, index, box, accessflag) as Integer
' boxaaAddBox(BOXAA *, l_int32, BOX *, l_int32) as l_ok
'''  <summary>
''' (1) Adds to an existing boxa only.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaAddBox/*"/>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - of boxa with boxaa</param>
'''  <param name="box">[in] - to be added</param>
'''  <param name="accessflag">[in] - L_INSERT, L_COPY or L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaAddBox(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal box as Box, 
				ByVal accessflag as Enumerations.L_access_storage) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaAddBox(baa.Pointer,   index, box.Pointer,   accessflag)
	
	return _Result
End Function

' boxbasic.c (1824, 1)
' boxaaReadFromFiles(dirname, substr, first, nfiles) as Boxaa
' boxaaReadFromFiles(const char *, const char *, l_int32, l_int32) as BOXAA *
'''  <summary>
''' (1) The files must be serialized boxa files (e.g., .ba).
'''If some files cannot be read, warnings are issued.<para/>
'''
'''(2) Use %substr to filter filenames in the directory.  If
'''%substr == NULL, this takes all files.<para/>
'''
'''(3) After filtering, use %first and %nfiles to select
'''a contiguous set of files, that have been lexically
'''sorted in increasing order.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadFromFiles/*"/>
'''  <param name="dirname">[in] - directory</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="first">[in] - 0-based</param>
'''  <param name="nfiles">[in] - use 0 for everything from %first to the end</param>
'''   <returns>baa, or NULL on error or if no boxa files are found.</returns>
Public Shared Function boxaaReadFromFiles(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal first as Integer, 
				ByVal nfiles as Integer) as Boxaa


if IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaReadFromFiles(  dirname,   substr,   first,   nfiles)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1868, 1)
' boxaaRead(filename) as Boxaa
' boxaaRead(const char *) as BOXAA *
'''  <summary>
''' boxaaRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>boxaa, or NULL on error</returns>
Public Shared Function boxaaRead(
				ByVal filename as String) as Boxaa


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.boxaaRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1895, 1)
' boxaaReadStream(fp) as Boxaa
' boxaaReadStream(FILE *) as BOXAA *
'''  <summary>
''' boxaaReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>boxaa, or NULL on error</returns>
Public Shared Function boxaaReadStream(
				ByVal fp as FILE) as Boxaa


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1940, 1)
' boxaaReadMem(data, size) as Boxaa
' boxaaReadMem(const l_uint8 *, size_t) as BOXAA *
'''  <summary>
''' boxaaReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaReadMem/*"/>
'''  <param name="data">[in] - serialization of boxaa in ascii</param>
'''  <param name="size">[in] - of data in bytes can use strlen to get it</param>
'''   <returns>baa, or NULL on error</returns>
Public Shared Function boxaaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Boxaa


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaaReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxaa(_Result)
End Function

' boxbasic.c (1968, 1)
' boxaaWrite(filename, baa) as Integer
' boxaaWrite(const char *, BOXAA *) as l_ok
'''  <summary>
''' boxaaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWrite(
				ByVal filename as String, 
				ByVal baa as Boxaa) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaWrite(  filename, baa.Pointer)
	
	return _Result
End Function

' boxbasic.c (1999, 1)
' boxaaWriteStream(fp, baa) as Integer
' boxaaWriteStream(FILE *, BOXAA *) as l_ok
'''  <summary>
''' boxaaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWriteStream(
				ByVal fp as FILE, 
				ByVal baa as Boxaa) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaaWriteStream(fp.Pointer, baa.Pointer)
	
	return _Result
End Function

' boxbasic.c (2046, 1)
' boxaaWriteMem(pdata, psize, baa) as Integer
' boxaaWriteMem(l_uint8 **, size_t *, BOXAA *) as l_ok
'''  <summary>
''' (1) Serializes a boxaa in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaaWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized boxaa ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal baa as Boxaa) as Integer


if IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.boxaaWriteMem(  pdataPtr,   psize, baa.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' boxbasic.c (2096, 1)
' boxaRead(filename) as Boxa
' boxaRead(const char *) as BOXA *
'''  <summary>
''' boxaRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaRead(
				ByVal filename as String) as Boxa


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.boxaRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (2123, 1)
' boxaReadStream(fp) as Boxa
' boxaReadStream(FILE *) as BOXA *
'''  <summary>
''' boxaReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaReadStream(
				ByVal fp as FILE) as Boxa


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (2166, 1)
' boxaReadMem(data, size) as Boxa
' boxaReadMem(const l_uint8 *, size_t) as BOXA *
'''  <summary>
''' boxaReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaReadMem/*"/>
'''  <param name="data">[in] - serialization of boxa in ascii</param>
'''  <param name="size">[in] - of data in bytes can use strlen to get it</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Boxa


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.boxaReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Boxa(_Result)
End Function

' boxbasic.c (2203, 1)
' boxaWriteDebug(filename, boxa) as Integer
' boxaWriteDebug(const char *, BOXA *) as l_ok
'''  <summary>
''' (1) Debug version, intended for use in the library when writing
'''to files in a temp directory with names that are compiled in.
'''This is used instead of boxaWrite() for all such library calls.<para/>
'''
'''(2) The global variable LeptDebugOK defaults to 0, and can be set
'''or cleared by the function setLeptDebugOK().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteDebug/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function boxaWriteDebug(
				ByVal filename as String, 
				ByVal boxa as Boxa) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaWriteDebug(  filename, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (2225, 1)
' boxaWrite(filename, boxa) as Integer
' boxaWrite(const char *, BOXA *) as l_ok
'''  <summary>
''' boxaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWrite(
				ByVal filename as String, 
				ByVal boxa as Boxa) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaWrite(  filename, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (2257, 1)
' boxaWriteStream(fp, boxa) as Integer
' boxaWriteStream(FILE *, BOXA *) as l_ok
'''  <summary>
''' boxaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWriteStream(
				ByVal fp as FILE, 
				ByVal boxa as Boxa) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim _Result as Integer = Natives.boxaWriteStream(fp.Pointer, boxa.Pointer)
	
	return _Result
End Function

' boxbasic.c (2298, 1)
' boxaWriteMem(pdata, psize, boxa) as Integer
' boxaWriteMem(l_uint8 **, size_t *, BOXA *) as l_ok
'''  <summary>
''' (1) Serializes a boxa in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxaWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized boxa ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal boxa as Boxa) as Integer


if IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.boxaWriteMem(  pdataPtr,   psize, boxa.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' boxbasic.c (2355, 1)
' boxPrintStreamInfo(fp, box) as Integer
' boxPrintStreamInfo(FILE *, BOX *) as l_ok
'''  <summary>
''' (1) This outputs debug info.  Use serialization functions to
'''write to file if you want to read the data back.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/boxPrintStreamInfo/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="box">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxPrintStreamInfo(
				ByVal fp as FILE, 
				ByVal box as Box) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.boxPrintStreamInfo(fp.Pointer, box.Pointer)
	
	return _Result
End Function

End Class



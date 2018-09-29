Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\boxbasic.c (165, 1)
' boxCreate()
' boxCreate(l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This clips the box to the +quad.  If no part of the
''' box is in the +quad, this returns NULL.
''' (2) We allow you to make a box with w = 0 and/or h = 0.
''' This does not represent a valid region, but it is useful
''' as a placeholder in a boxa for which the index of the
''' box in the boxa is important.  This is an atypical
''' situation; usually you want to put only valid boxes with
''' nonzero width and height in a boxa.  If you have a boxa
''' with invalid boxes, the accessor boxaGetValidBox()
''' will return NULL on each invalid box.
''' (3) If you want to create only valid boxes, use boxCreateValid(),
''' which returns NULL if either w or h is 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
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



	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxCreate( x, y, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (210, 1)
' boxCreateValid()
' boxCreateValid(l_int32, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This returns NULL if either w = 0 or h = 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
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



	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxCreateValid( x, y, w, h)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (230, 1)
' boxCopy()
' boxCopy(BOX *) as BOX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''   <returns>copy of box, or NULL on error</returns>
Public Shared Function boxCopy(
				ByVal box as Box) as Box

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxCopy( box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (252, 1)
' boxClone()
' boxClone(BOX *) as BOX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''   <returns>ptr to same box, or NULL on error</returns>
Public Shared Function boxClone(
				ByVal box as Box) as Box

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxClone( box.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (278, 1)
' boxDestroy()
' boxDestroy(BOX **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the box.
''' (2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pbox">[in,out] - will be set to null before returning</param>
Public Shared Sub boxDestroy(
				ByRef pbox as Box)


	Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer

	LeptonicaSharp.Natives.boxDestroy( pboxPTR)
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)

End Sub

' SRC\boxbasic.c (310, 1)
' boxGetGeometry()
' boxGetGeometry(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="px">[out][optional] - each can be null</param>
'''  <param name="py">[out][optional] - each can be null</param>
'''  <param name="pw">[out][optional] - each can be null</param>
'''  <param name="ph">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetGeometry(
				ByVal box as Box, 
				ByRef px as Integer, 
				ByRef py as Integer, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxGetGeometry( box.Pointer, px, py, pw, ph)

	Return _Result
End Function

' SRC\boxbasic.c (340, 1)
' boxSetGeometry()
' boxSetGeometry(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="x">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="y">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="w">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="h">[in][optional] - use -1 to leave unchanged</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSetGeometry(
				ByVal box as Box, 
				ByVal x as Integer, 
				ByVal y as Integer, 
				ByVal w as Integer, 
				ByVal h as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxSetGeometry( box.Pointer, x, y, w, h)

	Return _Result
End Function

' SRC\boxbasic.c (371, 1)
' boxGetSideLocations()
' boxGetSideLocations(BOX *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) All returned values are within the box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="pl">[out][optional] - each can be null</param>
'''  <param name="pr">[out][optional] - each can be null</param>
'''  <param name="pt">[out][optional] - each can be null</param>
'''  <param name="pb">[out][optional] - each can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxGetSideLocations(
				ByVal box as Box, 
				ByRef pl as Integer, 
				ByRef pr as Integer, 
				ByRef pt as Integer, 
				ByRef pb as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxGetSideLocations( box.Pointer, pl, pr, pt, pb)

	Return _Result
End Function

' SRC\boxbasic.c (405, 1)
' boxSetSideLocations()
' boxSetSideLocations(BOX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="l">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="r">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="t">[in][optional] - use -1 to leave unchanged</param>
'''  <param name="b">[in][optional] - use -1 to leave unchanged</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxSetSideLocations(
				ByVal box as Box, 
				ByVal l as Integer, 
				ByVal r as Integer, 
				ByVal t as Integer, 
				ByVal b as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxSetSideLocations( box.Pointer, l, r, t, b)

	Return _Result
End Function

' SRC\boxbasic.c (432, 1)
' Return the current reference count of %box
' boxGetRefcount(BOX *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - ptr to Box</param>
'''   <returns>refcount</returns>
Public Shared Function boxGetRefcount(
				ByVal box as Box) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxGetRefcount( box.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (449, 1)
' Adjust the current references count of %box by %delta
' boxChangeRefcount(BOX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - ptr to box</param>
'''  <param name="delta">[in] - adjustment, usually -1 or 1</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxChangeRefcount(
				ByVal box as Box, 
				ByVal delta as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxChangeRefcount( box.Pointer, delta)

	Return _Result
End Function

' SRC\boxbasic.c (470, 1)
' boxIsValid()
' boxIsValid(BOX *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="box">[in] - </param>
'''  <param name="pvalid">[out] - 1 if valid; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxIsValid(
				ByVal box as Box, 
				ByRef pvalid as Integer) as Integer

	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxIsValid( box.Pointer, pvalid)

	Return _Result
End Function

' SRC\boxbasic.c (497, 1)
' boxaCreate()
' boxaCreate(l_int32) as BOXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaCreate(
				ByVal n as Integer) as Boxa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (532, 1)
' boxaCopy()
' boxaCopy(BOXA *, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) See pix.h for description of the copyflag.
''' (2) The copy-clone makes a new boxa that holds clones of each box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE, L_COPY_CLONE</param>
'''   <returns>new boxa, or NULL on error</returns>
Public Shared Function boxaCopy(
				ByVal boxa as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaCopy( boxa.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (578, 1)
' boxaDestroy()
' boxaDestroy(BOXA **) as void
'''  <summary>
''' Notes
''' (1) Decrements the ref count and, if 0, destroys the boxa.
''' (2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pboxa">[in,out] - will be set to null before returning</param>
Public Shared Sub boxaDestroy(
				ByRef pboxa as Boxa)


	Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	LeptonicaSharp.Natives.boxaDestroy( pboxaPTR)
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

End Sub

' SRC\boxbasic.c (616, 1)
' boxaAddBox()
' boxaAddBox(BOXA *, BOX *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="box">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaAddBox(
				ByVal boxa as Boxa, 
				ByVal box as Box, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaAddBox( boxa.Pointer, box.Pointer, copyflag)

	Return _Result
End Function

' SRC\boxbasic.c (663, 1)
' boxaExtendArray()
' boxaExtendArray(BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Reallocs with doubled size of ptr array.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function boxaExtendArray(
				ByVal boxa as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaExtendArray( boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (687, 1)
' boxaExtendArrayToSize()
' boxaExtendArrayToSize(BOXA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If necessary, reallocs new boxa ptr array to %size.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="size">[in] - new size of boxa array</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function boxaExtendArrayToSize(
				ByVal boxa as Boxa, 
				ByVal size as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaExtendArrayToSize( boxa.Pointer, size)

	Return _Result
End Function

' SRC\boxbasic.c (716, 1)
' boxaGetCount()
' boxaGetCount(BOXA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>count of all boxes; 0 if no boxes or on error</returns>
Public Shared Function boxaGetCount(
				ByVal boxa as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetCount( boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (733, 1)
' boxaGetValidCount()
' boxaGetValidCount(BOXA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>count of valid boxes; 0 if no valid boxes or on error</returns>
Public Shared Function boxaGetValidCount(
				ByVal boxa as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetValidCount( boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (761, 1)
' boxaGetBox()
' boxaGetBox(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>box, or NULL on error</returns>
Public Shared Function boxaGetBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Box

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaGetBox( boxa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (800, 1)
' boxaGetValidBox()
' boxaGetValidBox(BOXA *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This returns NULL for an invalid box in a boxa.
''' For a box to be valid, both the width and height must be GT 0.
''' (2) We allow invalid boxes, with w = 0 or h = 0, as placeholders
''' in boxa for which the index of the box in the boxa is important.
''' This is an atypical situation; usually you want to put only
''' valid boxes in a boxa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>box, or NULL if box is not valid or on error</returns>
Public Shared Function boxaGetValidBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Box

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaGetValidBox( boxa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (828, 1)
' boxaFindInvalidBoxes()
' boxaFindInvalidBoxes(BOXA *) as NUMA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>na   numa of invalid boxes; NULL if there are none or on error</returns>
Public Shared Function boxaFindInvalidBoxes(
				ByVal boxa as Boxa) as Numa

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaFindInvalidBoxes( boxa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\boxbasic.c (861, 1)
' boxaGetBoxGeometry()
' boxaGetBoxGeometry(BOXA *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				ByRef px as Integer, 
				ByRef py as Integer, 
				ByRef pw as Integer, 
				ByRef ph as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaGetBoxGeometry( boxa.Pointer, index, px, py, pw, ph)

	Return _Result
End Function

' SRC\boxbasic.c (897, 1)
' boxaIsFull()
' boxaIsFull(BOXA *, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="pfull">[out] - 1 if boxa is full</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaIsFull(
				ByVal boxa as Boxa, 
				ByRef pfull as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaIsFull( boxa.Pointer, pfull)

	Return _Result
End Function

' SRC\boxbasic.c (943, 1)
' boxaReplaceBox()
' boxaReplaceBox(BOXA *, l_int32, BOX *) as l_ok
'''  <summary>
''' Notes
''' (1) In-place replacement of one box.
''' (2) The previous box at that location, if any, is destroyed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - to the index-th box</param>
'''  <param name="box">[in] - insert to replace existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaReplaceBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal box as Box) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaReplaceBox( boxa.Pointer, index, box.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (981, 1)
' boxaInsertBox()
' boxaInsertBox(BOXA *, l_int32, BOX *) as l_ok
'''  <summary>
''' Notes
''' (1) This shifts box[i] --GT box[i + 1] for all i GT= index,
''' and then inserts box as box[index].
''' (2) To insert at the beginning of the array, set index = 0.
''' (3) To append to the array, it's easier to use boxaAddBox().
''' (4) This should not be used repeatedly to insert into large arrays,
''' because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - location in boxa to insert new value</param>
'''  <param name="box">[in] - new box to be inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaInsertBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByVal box as Box) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaInsertBox( boxa.Pointer, index, box.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1026, 1)
' boxaRemoveBox()
' boxaRemoveBox(BOXA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This removes box[index] and then shifts
''' box[i] --GT box[i - 1] for all i GT index.
''' (2) It should not be used repeatedly to remove boxes from
''' large arrays, because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - of box to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaRemoveBox(
				ByVal boxa as Boxa, 
				ByVal index as Integer) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaRemoveBox( boxa.Pointer, index)

	Return _Result
End Function

' SRC\boxbasic.c (1068, 1)
' boxaRemoveBoxAndSave()
' boxaRemoveBoxAndSave(BOXA *, l_int32, BOX **) as l_ok
'''  <summary>
''' Notes
''' (1) This removes box[index] and then shifts
''' box[i] --GT box[i - 1] for all i GT index.
''' (2) It should not be used repeatedly to remove boxes from
''' large arrays, because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''  <param name="index">[in] - of box to be removed</param>
'''  <param name="pbox">[out][optional] - removed box</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaRemoveBoxAndSave(
				ByVal boxa as Boxa, 
				ByVal index as Integer, 
				ByRef pbox as Box) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

Dim pboxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbox) Then pboxPTR = pbox.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaRemoveBoxAndSave( boxa.Pointer, index, pboxPTR)
	if pboxPTR <> IntPtr.Zero then pbox = new Box(pboxPTR)

	Return _Result
End Function

' SRC\boxbasic.c (1110, 1)
' boxaSaveValid()
' boxaSaveValid(BOXA *, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) This makes a copy/clone of each valid box.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - </param>
'''  <param name="copyflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxad if OK, NULL on error</returns>
Public Shared Function boxaSaveValid(
				ByVal boxas as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaSaveValid( boxas.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (1174, 1)
' boxaInitFull()
' boxaInitFull(BOXA *, BOX *) as l_ok
'''  <summary>
''' Notes
''' (1) This initializes a boxa by filling up the entire box ptr array
''' with copies of %box.  If %box == NULL, use a placeholder box
''' of zero size.  Any existing boxes are destroyed.
''' After this opepration, the number of boxes is equal to
''' the number of allocated ptrs.
''' (2) Note that we use boxaReplaceBox() instead of boxaInsertBox().
''' They both have the same effect when inserting into a NULL ptr
''' in the boxa ptr array
''' (3) Example usage.  This function is useful to prepare for a
''' random insertion (or replacement) of boxes into a boxa.
''' To randomly insert boxes into a boxa, up to some index "max"
''' Boxa boxa = boxaCreate(max);
''' boxaInitFull(boxa, NULL);
''' If you want placeholder boxes of non-zero size
''' Boxa boxa = boxaCreate(max);
''' Box box = boxCreate(...);
''' boxaInitFull(boxa, box);
''' boxDestroy(box);
''' If we have an existing boxa with a smaller ptr array, it can
''' be reused for up to max boxes
''' boxaExtendArrayToSize(boxa, max);
''' boxaInitFull(boxa, NULL);
''' The initialization allows the boxa to always be properly
''' filled, even if all the boxes are not later replaced.
''' If you want to know which boxes have been replaced,
''' and you initialized with invalid zero-sized boxes,
''' use boxaGetValidBox() to return NULL for the invalid boxes.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - typically empty</param>
'''  <param name="box">[in][optional] - to be replicated into the entire ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaInitFull(
				ByVal boxa as Boxa, 
				ByVal box as Box) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaInitFull( boxa.Pointer, boxPTR)

	Return _Result
End Function

' SRC\boxbasic.c (1211, 1)
' boxaClear()
' boxaClear(BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This destroys all boxes in the boxa, setting the ptrs
''' to null.  The number of allocated boxes, n, is set to 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaClear(
				ByVal boxa as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaClear( boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1238, 1)
' boxaaCreate()
' boxaaCreate(l_int32) as BOXAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of boxa ptr array to be alloc'd; 0 for default</param>
'''   <returns>baa, or NULL on error</returns>
Public Shared Function boxaaCreate(
				ByVal n as Integer) as Boxaa



	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1273, 1)
' boxaaCopy()
' boxaaCopy(BOXAA *, l_int32) as BOXAA *
'''  <summary>
''' Notes
''' (1) L_COPY makes a copy of each boxa in baas.
''' L_CLONE makes a clone of each boxa in baas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baas">[in] - input boxaa to be copied</param>
'''  <param name="copyflag">[in] - L_COPY, L_CLONE</param>
'''   <returns>baad new boxaa, composed of copies or clones of the boxa in baas, or NULL on error</returns>
Public Shared Function boxaaCopy(
				ByVal baas as Boxaa, 
				ByVal copyflag as Enumerations.L_access_storage) as Boxaa

	If IsNothing (baas) then Throw New ArgumentNullException  ("baas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaCopy( baas.Pointer, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1304, 1)
' boxaaDestroy()
' boxaaDestroy(BOXAA **) as void
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pbaa">[in,out] - will be set to null before returning</param>
Public Shared Sub boxaaDestroy(
				ByRef pbaa as Boxaa)


	Dim pbaaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pbaa) Then pbaaPTR = pbaa.Pointer

	LeptonicaSharp.Natives.boxaaDestroy( pbaaPTR)
	if pbaaPTR <> IntPtr.Zero then pbaa = new Boxaa(pbaaPTR)

End Sub

' SRC\boxbasic.c (1342, 1)
' boxaaAddBoxa()
' boxaaAddBoxa(BOXAA *, BOXA *, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="ba">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaAddBoxa(
				ByVal baa as Boxaa, 
				ByVal ba as Boxa, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (ba) then Throw New ArgumentNullException  ("ba cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaAddBoxa( baa.Pointer, ba.Pointer, copyflag)

	Return _Result
End Function

' SRC\boxbasic.c (1379, 1)
' boxaaExtendArray()
' boxaaExtendArray(BOXAA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaExtendArray(
				ByVal baa as Boxaa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaExtendArray( baa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1410, 1)
' boxaaExtendArrayToSize()
' boxaaExtendArrayToSize(BOXAA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) If necessary, reallocs the boxa ptr array to %size.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="size">[in] - new size of boxa array</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function boxaaExtendArrayToSize(
				ByVal baa as Boxaa, 
				ByVal size as Integer) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaExtendArrayToSize( baa.Pointer, size)

	Return _Result
End Function

' SRC\boxbasic.c (1439, 1)
' boxaaGetCount()
' boxaaGetCount(BOXAA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''   <returns>count number of boxa, or 0 if no boxa or on error</returns>
Public Shared Function boxaaGetCount(
				ByVal baa as Boxaa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaGetCount( baa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1456, 1)
' boxaaGetBoxCount()
' boxaaGetBoxCount(BOXAA *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''   <returns>count number of boxes, or 0 if no boxes or on error</returns>
Public Shared Function boxaaGetBoxCount(
				ByVal baa as Boxaa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaGetBoxCount( baa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1486, 1)
' boxaaGetBoxa()
' boxaaGetBoxa(BOXAA *, l_int32, l_int32) as BOXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - to the index-th boxa</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaaGetBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Boxa

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaGetBoxa( baa.Pointer, index, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (1516, 1)
' boxaaGetBox()
' boxaaGetBox(BOXAA *, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaGetBox( baa.Pointer, iboxa, ibox, accessflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\boxbasic.c (1568, 1)
' boxaaInitFull()
' boxaaInitFull(BOXAA *, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This initializes a boxaa by filling up the entire boxa ptr array
''' with copies of %boxa.  Any existing boxa are destroyed.
''' After this operation, the number of boxa is equal to
''' the number of allocated ptrs.
''' (2) Note that we use boxaaReplaceBox() instead of boxaInsertBox().
''' They both have the same effect when inserting into a NULL ptr
''' in the boxa ptr array
''' (3) Example usage.  This function is useful to prepare for a
''' random insertion (or replacement) of boxa into a boxaa.
''' To randomly insert boxa into a boxaa, up to some index "max"
''' Boxaa baa = boxaaCreate(max);
''' // initialize the boxa
''' Boxa boxa = boxaCreate(...);
''' ...  [optionally fix with boxes]
''' boxaaInitFull(baa, boxa);
''' A typical use is to initialize the array with empty boxa,
''' and to replace only a subset that must be aligned with
''' something else, such as a pixa.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - typically empty</param>
'''  <param name="boxa">[in] - to be replicated into the entire ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaInitFull(
				ByVal baa as Boxaa, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaInitFull( baa.Pointer, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1608, 1)
' boxaaExtendWithInit()
' boxaaExtendWithInit(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This should be used on an existing boxaa that has been
''' fully loaded with boxa.  It then extends the boxaa,
''' loading all the additional ptrs with copies of boxa.
''' Typically, boxa will be empty.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="maxindex">[in] - </param>
'''  <param name="boxa">[in] - to be replicated into the extended ptr array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaExtendWithInit(
				ByVal baa as Boxaa, 
				ByVal maxindex as Integer, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaExtendWithInit( baa.Pointer, maxindex, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1649, 1)
' boxaaReplaceBoxa()
' boxaaReplaceBoxa(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Any existing boxa is destroyed, and the input one
''' is inserted in its place.
''' (2) If the index is invalid, return 1 (error)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - to the index-th boxa</param>
'''  <param name="boxa">[in] - insert and replace any existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaReplaceBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaReplaceBoxa( baa.Pointer, index, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1690, 1)
' boxaaInsertBoxa()
' boxaaInsertBoxa(BOXAA *, l_int32, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) This shifts boxa[i] --GT boxa[i + 1] for all i GT= index,
''' and then inserts boxa as boxa[index].
''' (2) To insert at the beginning of the array, set index = 0.
''' (3) To append to the array, it's easier to use boxaaAddBoxa().
''' (4) This should not be used repeatedly to insert into large arrays,
''' because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - location in boxaa to insert new boxa</param>
'''  <param name="boxa">[in] - new boxa to be inserted</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaInsertBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaInsertBoxa( baa.Pointer, index, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1736, 1)
' boxaaRemoveBoxa()
' boxaaRemoveBoxa(BOXAA *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This removes boxa[index] and then shifts
''' boxa[i] --GT boxa[i - 1] for all i GT index.
''' (2) The removed boxaa is destroyed.
''' (2) This should not be used repeatedly on large arrays,
''' because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="baa">[in] - </param>
'''  <param name="index">[in] - of the boxa to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaRemoveBoxa(
				ByVal baa as Boxaa, 
				ByVal index as Integer) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaRemoveBoxa( baa.Pointer, index)

	Return _Result
End Function

' SRC\boxbasic.c (1776, 1)
' boxaaAddBox()
' boxaaAddBox(BOXAA *, l_int32, BOX *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Adds to an existing boxa only.
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaAddBox( baa.Pointer, index, box.Pointer, accessflag)

	Return _Result
End Function

' SRC\boxbasic.c (1824, 1)
' boxaaReadFromFiles()
' boxaaReadFromFiles(const char *, const char *, l_int32, l_int32) as BOXAA *
'''  <summary>
''' Notes
''' (1) The files must be serialized boxa files (e.g., .ba).
''' If some files cannot be read, warnings are issued.
''' (2) Use %substr to filter filenames in the directory.  If
''' %substr == NULL, this takes all files.
''' (3) After filtering, use %first and %nfiles to select
''' a contiguous set of files, that have been lexically
''' sorted in increasing order.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory</param>
'''  <param name="substr">[in][optional] - substring filter on filenames; can be NULL</param>
'''  <param name="first">[in] - 0-based</param>
'''  <param name="nfiles">[in] - use 0 for everything from %first to the end</param>
'''   <returns>baa, or NULL on error or if no boxa files are found.</returns>
Public Shared Function boxaaReadFromFiles(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal first as Integer, 
				ByVal nfiles as Integer) as Boxaa

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaReadFromFiles( dirname, substr, first, nfiles)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1868, 1)
' boxaaRead()
' boxaaRead(const char *) as BOXAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>boxaa, or NULL on error</returns>
Public Shared Function boxaaRead(
				ByVal filename as String) as Boxaa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1895, 1)
' boxaaReadStream()
' boxaaReadStream(FILE *) as BOXAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>boxaa, or NULL on error</returns>
Public Shared Function boxaaReadStream(
				ByVal fp as FILE) as Boxaa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1940, 1)
' boxaaReadMem()
' boxaaReadMem(const l_uint8 *, size_t) as BOXAA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of boxaa; in ascii</param>
'''  <param name="size">[in] - of data in bytes; can use strlen to get it</param>
'''   <returns>baa, or NULL on error</returns>
Public Shared Function boxaaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Boxaa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxaa(_Result)
End Function

' SRC\boxbasic.c (1968, 1)
' boxaaWrite()
' boxaaWrite(const char *, BOXAA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWrite(
				ByVal filename as String, 
				ByVal baa as Boxaa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaWrite( filename, baa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (1999, 1)
' boxaaWriteStream()
' boxaaWriteStream(FILE *, BOXAA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWriteStream(
				ByVal fp as FILE, 
				ByVal baa as Boxaa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaWriteStream( fp.Pointer, baa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (2046, 1)
' boxaaWriteMem()
' boxaaWriteMem(l_uint8 **, size_t *, BOXAA *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a boxaa in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized boxaa; ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="baa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaaWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal baa as Boxaa) as Integer

	If IsNothing (baa) then Throw New ArgumentNullException  ("baa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaaWriteMem( pdataPTR, psize, baa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\boxbasic.c (2096, 1)
' boxaRead()
' boxaRead(const char *) as BOXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaRead(
				ByVal filename as String) as Boxa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (2123, 1)
' boxaReadStream()
' boxaReadStream(FILE *) as BOXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaReadStream(
				ByVal fp as FILE) as Boxa

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (2166, 1)
' boxaReadMem()
' boxaReadMem(const l_uint8 *, size_t) as BOXA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization of boxa; in ascii</param>
'''  <param name="size">[in] - of data in bytes; can use strlen to get it</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function boxaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Boxa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\boxbasic.c (2203, 1)
' boxaWriteDebug()
' boxaWriteDebug(const char *, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Debug version, intended for use in the library when writing
''' to files in a temp directory with names that are compiled in.
''' This is used instead of boxaWrite() for all such library calls.
''' (2) The global variable LeptDebugOK defaults to 0, and can be set
''' or cleared by the function setLeptDebugOK().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function boxaWriteDebug(
				ByVal filename as String, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaWriteDebug( filename, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (2225, 1)
' boxaWrite()
' boxaWrite(const char *, BOXA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWrite(
				ByVal filename as String, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaWrite( filename, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (2257, 1)
' boxaWriteStream()
' boxaWriteStream(FILE *, BOXA *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWriteStream(
				ByVal fp as FILE, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxaWriteStream( fp.Pointer, boxa.Pointer)

	Return _Result
End Function

' SRC\boxbasic.c (2298, 1)
' boxaWriteMem()
' boxaWriteMem(l_uint8 **, size_t *, BOXA *) as l_ok
'''  <summary>
''' Notes
''' (1) Serializes a boxa in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized boxa; ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="boxa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxaWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal boxa as Boxa) as Integer

	If IsNothing (boxa) then Throw New ArgumentNullException  ("boxa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.boxaWriteMem( pdataPTR, psize, boxa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\boxbasic.c (2355, 1)
' boxPrintStreamInfo()
' boxPrintStreamInfo(FILE *, BOX *) as l_ok
'''  <summary>
''' Notes
''' (1) This outputs debug info.  Use serialization functions to
''' write to file if you want to read the data back.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="box">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function boxPrintStreamInfo(
				ByVal fp as FILE, 
				ByVal box as Box) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.boxPrintStreamInfo( fp.Pointer, box.Pointer)

	Return _Result
End Function

End Class

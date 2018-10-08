Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\list.c (236, 1)
' listDestroy(phead) as Object
' listDestroy(DLLIST **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This only destroys the cons cells.  Before destroying<para/>
''' the list, it is necessary to remove all data and set the<para/>
''' data pointers in each cons cell to NULL.<para/>
''' (2) listDestroy() will give a warning message for each data<para/>
''' ptr that is not NULL.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - to be nulled head of list</param>
Public Shared Sub listDestroy(
				 ByRef phead as DoubleLinkedList)




	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer

	LeptonicaSharp.Natives.listDestroy( pheadPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

End Sub

' SRC\list.c (277, 1)
' listAddToHead(phead, data) as Integer
' listAddToHead(DLLIST **, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This makes a new cell, attaches the data, and adds the<para/>
''' cell to the head of the list.<para/>
''' (2) When consing from NULL, be sure to initialize head to NULL<para/>
''' before calling this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out][optional] - input head</param>
'''  <param name="data">[in] - void ptr, to be added</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function listAddToHead(
				 ByRef phead as DoubleLinkedList, 
				 ByVal data as Object) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer
Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.listAddToHead( pheadPTR, dataPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (331, 1)
' listAddToTail(phead, ptail, data) as Integer
' listAddToTail(DLLIST **, DLLIST **, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This makes a new cell, attaches the data, and adds the<para/>
''' cell to the tail of the list.<para/>
''' (2)  and head is input to allow the list to be "cons'd" up from NULL.<para/>
''' (3)  and tail is input to allow the tail to be updated<para/>
''' for efficient sequential operation with this function.<para/>
''' (4) We assume that if phead and/or ptail are not NULL,<para/>
''' then they are valid addresses.  Therefore:<para/>
''' (a) when consing from NULL, be sure to initialize both<para/>
''' head and tail to NULL.<para/>
''' (b) when tail == NULL for an existing list, the tail<para/>
''' will be found and updated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - [may be updated], can be NULL</param>
'''  <param name="ptail">[in,out] - [updated], can be NULL</param>
'''  <param name="data">[in] - void ptr, to be hung on tail cons cell</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function listAddToTail(
				 ByRef phead as DoubleLinkedList, 
				 ByRef ptail as DoubleLinkedList, 
				 ByVal data as Object) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer
	Dim ptailPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ptail) Then ptailPTR = ptail.Pointer
Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.listAddToTail( pheadPTR, ptailPTR, dataPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)
	if ptailPTR <> IntPtr.Zero then ptail = new DoubleLinkedList(ptailPTR)

	Return _Result
End Function

' SRC\list.c (394, 1)
' listInsertBefore(phead, elem, data) as Integer
' listInsertBefore(DLLIST **, DLLIST *, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be called on a null list, in which case both<para/>
''' head and elem must be null.<para/>
''' (2) If you are searching through a list, looking for a condition<para/>
''' to add an element, you can do something like this:<para/>
''' \code<para/>
''' L_BEGIN_LIST_FORWARD(head, elem)<para/>
'''  is lower identify an elem to insert before is greater <para/>
''' listInsertBefore( and head, elem, data)<para/>
''' L_END_LIST<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out][optional] - input head</param>
'''  <param name="elem">[in] - list element to be inserted in front of must be NULL if head is NULL</param>
'''  <param name="data">[in] - void  address, to be added</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function listInsertBefore(
				 ByRef phead as DoubleLinkedList, 
				 ByVal elem as DoubleLinkedList, 
				 ByVal data as Object) as Integer

	If IsNothing (elem) then Throw New ArgumentNullException  ("elem cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer
Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.listInsertBefore( pheadPTR, elem.Pointer, dataPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (459, 1)
' listInsertAfter(phead, elem, data) as Integer
' listInsertAfter(DLLIST **, DLLIST *, void *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be called on a null list, in which case both<para/>
''' head and elem must be null.  The head is included<para/>
''' in the call to allow "consing" up from NULL.<para/>
''' (2) If you are searching through a list, looking for a condition<para/>
''' to add an element, you can do something like this:<para/>
''' \code<para/>
''' L_BEGIN_LIST_FORWARD(head, elem)<para/>
'''  is lower identify an elem to insert after is greater <para/>
''' listInsertAfter( and head, elem, data)<para/>
''' L_END_LIST<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out][optional] - input head</param>
'''  <param name="elem">[in] - list element to be inserted after must be NULL if head is NULL</param>
'''  <param name="data">[in] - void  ptr, to be added</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function listInsertAfter(
				 ByRef phead as DoubleLinkedList, 
				 ByVal elem as DoubleLinkedList, 
				 ByVal data as Object) as Integer

	If IsNothing (elem) then Throw New ArgumentNullException  ("elem cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer
Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.listInsertAfter( pheadPTR, elem.Pointer, dataPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (514, 1)
' listRemoveElement(phead, elem) as Object
' listRemoveElement(DLLIST **, DLLIST *) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) in ANSI C, it is not necessary to cast return to actual type e.g.,<para/>
''' pix = listRemoveElement( and head, elem)<para/>
''' but in ANSI C++, it is necessary to do the cast:<para/>
''' pix = (Pix )listRemoveElement( and head, elem)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - [can be changed] input head</param>
'''  <param name="elem">[in] - list element to be removed</param>
'''   <returns>data  void struct on cell</returns>
Public Shared Function listRemoveElement(
				 ByRef phead as DoubleLinkedList, 
				 ByVal elem as DoubleLinkedList) as Object

	If IsNothing (elem) then Throw New ArgumentNullException  ("elem cannot be Nothing")



	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.listRemoveElement( pheadPTR, elem.Pointer)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (566, 1)
' listRemoveFromHead(phead) as Object
' listRemoveFromHead(DLLIST **) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) in ANSI C, it is not necessary to cast return to actual type e.g.,<para/>
''' pix = listRemoveFromHead( and head)<para/>
''' but in ANSI C++, it is necessary to do the cast e.g.,<para/>
''' pix = (Pix )listRemoveFromHead( and head)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - head of list [to be updated]</param>
'''   <returns>data  void struct on cell, or NULL on error</returns>
Public Shared Function listRemoveFromHead(
				 ByRef phead as DoubleLinkedList) as Object




	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.listRemoveFromHead( pheadPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (614, 1)
' listRemoveFromTail(phead, ptail) as Object
' listRemoveFromTail(DLLIST **, DLLIST **) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We include  and head so that it can be set to NULL if<para/>
''' if the only element in the list is removed.<para/>
''' (2) The function is relying on the fact that if tail is<para/>
''' not NULL, then is is a valid address.  You can use<para/>
''' this function with tail == NULL for an existing list, in<para/>
''' which case  the tail is found and updated, and the<para/>
''' removed element is returned.<para/>
''' (3) In ANSI C, it is not necessary to cast return to actual type e.g.,<para/>
''' pix = listRemoveFromTail( and head,  and tail)<para/>
''' but in ANSI C++, it is necessary to do the cast e.g.,<para/>
''' pix = (Pix )listRemoveFromTail( and head,  and tail)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - [may be changed], head must NOT be NULL</param>
'''  <param name="ptail">[in,out] - [always updated], tail may be NULL</param>
'''   <returns>data  void struct on cell or NULL on error</returns>
Public Shared Function listRemoveFromTail(
				 ByRef phead as DoubleLinkedList, 
				 ByRef ptail as DoubleLinkedList) as Object




	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer
	Dim ptailPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ptail) Then ptailPTR = ptail.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.listRemoveFromTail( pheadPTR, ptailPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)
	if ptailPTR <> IntPtr.Zero then ptail = new DoubleLinkedList(ptailPTR)

	Return _Result
End Function

' SRC\list.c (668, 1)
' listFindElement(head, data) as DoubleLinkedList
' listFindElement(DLLIST *, void *) as DLLIST *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This returns a ptr to the cell, which is still embedded in<para/>
''' the list.<para/>
''' (2) This handle and the attached data have not been copied or<para/>
''' reference counted, so they must not be destroyed.  This<para/>
''' violates our basic rule that every handle returned from a<para/>
''' function is owned by that function and must be destroyed,<para/>
''' but if rules aren't there to be broken, why have them?<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="head">[in] - list head</param>
'''  <param name="data">[in] - void  address, to be searched for</param>
'''   <returns>cell  the containing cell, or NULL if not found or on error</returns>
Public Shared Function listFindElement(
				 ByVal head as DoubleLinkedList, 
				 ByVal data as Object) as DoubleLinkedList

	If IsNothing (head) then Throw New ArgumentNullException  ("head cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")



Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.listFindElement( head.Pointer, dataPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DoubleLinkedList(_Result)
End Function

' SRC\list.c (696, 1)
' listFindTail(head) as DoubleLinkedList
' listFindTail(DLLIST *) as DLLIST *
'''  <remarks>
'''  </remarks>
'''  <param name="head">[in] - </param>
'''   <returns>tail, or NULL on error</returns>
Public Shared Function listFindTail(
				 ByVal head as DoubleLinkedList) as DoubleLinkedList

	If IsNothing (head) then Throw New ArgumentNullException  ("head cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.listFindTail( head.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new DoubleLinkedList(_Result)
End Function

' SRC\list.c (721, 1)
' listGetCount(head) as Integer
' listGetCount(DLLIST *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="head">[in] - of list</param>
'''   <returns>number of elements 0 if no list or on error</returns>
Public Shared Function listGetCount(
				 ByVal head as DoubleLinkedList) as Integer

	If IsNothing (head) then Throw New ArgumentNullException  ("head cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.listGetCount( head.Pointer)

	Return _Result
End Function

' SRC\list.c (751, 1)
' listReverse(phead) as Integer
' listReverse(DLLIST **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This reverses the list in-place.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead">[in,out] - [may be changed] list head</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function listReverse(
				 ByRef phead as DoubleLinkedList) as Integer




	Dim pheadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead) Then pheadPTR = phead.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.listReverse( pheadPTR)
	if pheadPTR <> IntPtr.Zero then phead = new DoubleLinkedList(pheadPTR)

	Return _Result
End Function

' SRC\list.c (788, 1)
' listJoin(phead1, phead2) as Integer
' listJoin(DLLIST **, DLLIST **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The concatenated list is returned with head1 as the new head.<para/>
''' (2) Both input ptrs must exist, though either can have the value NULL.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="phead1">[in,out] - [may be changed] head of first list</param>
'''  <param name="phead2">[in,out] - to be nulled head of second list</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function listJoin(
				 ByRef phead1 as DoubleLinkedList, 
				 ByRef phead2 as DoubleLinkedList) as Integer




	Dim phead1PTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead1) Then phead1PTR = phead1.Pointer
	Dim phead2PTR As IntPtr = IntPtr.Zero : If Not IsNothing(phead2) Then phead2PTR = phead2.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.listJoin( phead1PTR, phead2PTR)
	if phead1PTR <> IntPtr.Zero then phead1 = new DoubleLinkedList(phead1PTR)
	if phead2PTR <> IntPtr.Zero then phead2 = new DoubleLinkedList(phead2PTR)

	Return _Result
End Function

End Class

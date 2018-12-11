Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' stack.c (78, 1)
' lstackCreate(nalloc) as L_Stack
' lstackCreate(l_int32) as L_STACK *
'''  <summary>
''' lstackCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackCreate/*"/>
'''  <param name="nalloc">[in] - initial ptr array size use 0 for default</param>
'''   <returns>lstack, or NULL on error</returns>
Public Shared Function lstackCreate(
				ByVal nalloc as Integer) as L_Stack


	Dim _Result as IntPtr = Natives.lstackCreate(  nalloc)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Stack(_Result)
End Function

' stack.c (121, 1)
' lstackDestroy(plstack, freeflag) as Object
' lstackDestroy(L_STACK **, l_int32) as void
'''  <summary>
''' (1) If freeflag is TRUE, frees each struct in the array.<para/>
'''
'''(2) If freeflag is FALSE but there are elements on the array,
'''gives a warning and destroys the array.  This will
'''cause a memory leak of all the items that were on the lstack.
'''So if the items require their own destroy function, they
'''must be destroyed before the lstack.<para/>
'''
'''(3) To destroy the lstack, we destroy the ptr array, then
'''the lstack, and then null the contents of the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackDestroy/*"/>
'''  <param name="plstack">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
Public Shared Sub lstackDestroy(
				ByRef plstack as L_Stack, 
				ByVal freeflag as Integer)


	Dim plstackPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(plstack) Then plstackPtr = plstack.Pointer

	Natives.lstackDestroy( plstackPtr,   freeflag)
	
	if plstackPtr = IntPtr.Zero then plstack = Nothing else plstack = new L_Stack(plstackPtr)
End Sub

' stack.c (167, 1)
' lstackAdd(lstack, item) as Integer
' lstackAdd(L_STACK *, void *) as l_ok
'''  <summary>
''' lstackAdd()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackAdd/*"/>
'''  <param name="lstack">[in] - </param>
'''  <param name="item">[in] - to be added to the lstack</param>
'''   <returns>0 if OK 1 on error.</returns>
Public Shared Function lstackAdd(
				ByVal lstack as L_Stack, 
				ByVal item as Object) as Integer


if IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")
		if IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")
		Dim itemPtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (item) Is IntPtr Then itemPtr = item
	If TypeOf (item) Is Byte() Then
	   Dim cdata = CType(item, Byte())
	   itemPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, itemPtr, cdata.Length)
	End If
	If Not IsNothing(item.GetType.GetProperty("data")) Then
	  Dim cdata = CType(item.data, Byte())
	  itemPtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, itemPtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.lstackAdd(lstack.Pointer,   itemPtr)
	
	Marshal.FreeHGlobal(itemPtr)
	return _Result
End Function

' stack.c (197, 1)
' lstackRemove(lstack) as Object
' lstackRemove(L_STACK *) as void *
'''  <summary>
''' lstackRemove()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackRemove/*"/>
'''  <param name="lstack">[in] - </param>
'''   <returns>ptr to item popped from the top of the lstack, or NULL if the lstack is empty or on error</returns>
Public Shared Function lstackRemove(
				ByVal lstack as L_Stack) as Object


if IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")
	Dim _Result as IntPtr = Natives.lstackRemove(lstack.Pointer)
	
	Dim B(1) As Byte
	Marshal.Copy(_Result, B, 0, B.Length)
	return B
End Function

' stack.c (247, 1)
' lstackGetCount(lstack) as Integer
' lstackGetCount(L_STACK *) as l_int32
'''  <summary>
''' lstackGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackGetCount/*"/>
'''  <param name="lstack">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function lstackGetCount(
				ByVal lstack as L_Stack) as Integer


if IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")
	Dim _Result as Integer = Natives.lstackGetCount(lstack.Pointer)
	
	return _Result
End Function

' stack.c (270, 1)
' lstackPrint(fp, lstack) as Integer
' lstackPrint(FILE *, L_STACK *) as l_ok
'''  <summary>
''' lstackPrint()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lstackPrint/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="lstack">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function lstackPrint(
				ByVal fp as FILE, 
				ByVal lstack as L_Stack) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")
	Dim _Result as Integer = Natives.lstackPrint(fp.Pointer, lstack.Pointer)
	
	return _Result
End Function

End Class



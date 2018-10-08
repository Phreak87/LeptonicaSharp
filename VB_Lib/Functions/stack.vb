Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\stack.c (78, 1)
' lstackCreate(nalloc) as L_Stack
' lstackCreate(l_int32) as L_STACK *
'''  <remarks>
'''  </remarks>
'''  <param name="nalloc">[in] - initial ptr array size use 0 for default</param>
'''   <returns>lstack, or NULL on error</returns>
Public Shared Function lstackCreate(
				 ByVal nalloc as Integer) as L_Stack





	Dim _Result as IntPtr = LeptonicaSharp.Natives.lstackCreate( nalloc)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Stack(_Result)
End Function

' SRC\stack.c (121, 1)
' lstackDestroy(plstack, freeflag) as Object
' lstackDestroy(L_STACK **, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If freeflag is TRUE, frees each struct in the array.<para/>
''' (2) If freeflag is FALSE but there are elements on the array,<para/>
''' gives a warning and destroys the array.  This will<para/>
''' cause a memory leak of all the items that were on the lstack.<para/>
''' So if the items require their own destroy function, they<para/>
''' must be destroyed before the lstack.<para/>
''' (3) To destroy the lstack, we destroy the ptr array, then<para/>
''' the lstack, and then null the contents of the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="plstack">[in,out] - to be nulled</param>
'''  <param name="freeflag">[in] - TRUE to free each remaining struct in the array</param>
Public Shared Sub lstackDestroy(
				 ByRef plstack as L_Stack, 
				 ByVal freeflag as Integer)




	Dim plstackPTR As IntPtr = IntPtr.Zero : If Not IsNothing(plstack) Then plstackPTR = plstack.Pointer

	LeptonicaSharp.Natives.lstackDestroy( plstackPTR, freeflag)
	if plstackPTR <> IntPtr.Zero then plstack = new L_Stack(plstackPTR)

End Sub

' SRC\stack.c (167, 1)
' lstackAdd(lstack, item) as Integer
' lstackAdd(L_STACK *, void *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="lstack">[in] - </param>
'''  <param name="item">[in] - to be added to the lstack</param>
'''   <returns>0 if OK 1 on error.</returns>
Public Shared Function lstackAdd(
				 ByVal lstack as L_Stack, 
				 ByVal item as Object) as Integer

	If IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")
	If IsNothing (item) then Throw New ArgumentNullException  ("item cannot be Nothing")



Dim itemPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.lstackAdd( lstack.Pointer, itemPTR)

	Return _Result
End Function

' SRC\stack.c (197, 1)
' lstackRemove(lstack) as Object
' lstackRemove(L_STACK *) as void *
'''  <remarks>
'''  </remarks>
'''  <param name="lstack">[in] - </param>
'''   <returns>ptr to item popped from the top of the lstack, or NULL if the lstack is empty or on error</returns>
Public Shared Function lstackRemove(
				 ByVal lstack as L_Stack) as Object

	If IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.lstackRemove( lstack.Pointer)

	Return _Result
End Function

' SRC\stack.c (247, 1)
' lstackGetCount(lstack) as Integer
' lstackGetCount(L_STACK *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="lstack">[in] - </param>
'''   <returns>count, or 0 on error</returns>
Public Shared Function lstackGetCount(
				 ByVal lstack as L_Stack) as Integer

	If IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.lstackGetCount( lstack.Pointer)

	Return _Result
End Function

' SRC\stack.c (270, 1)
' lstackPrint(fp, lstack) as Integer
' lstackPrint(FILE *, L_STACK *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="lstack">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function lstackPrint(
				 ByVal fp as FILE, 
				 ByVal lstack as L_Stack) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (lstack) then Throw New ArgumentNullException  ("lstack cannot be Nothing")




	Dim _Result as Integer = LeptonicaSharp.Natives.lstackPrint( fp.Pointer, lstack.Pointer)

	Return _Result
End Function

End Class

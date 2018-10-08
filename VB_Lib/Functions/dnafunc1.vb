Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dnafunc1.c (79, 1)
' l_dnaJoin(dad, das, istart, iend) as Integer
' l_dnaJoin(L_DNA *, L_DNA *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) istart  is lower  0 is taken to mean 'read from the start' (istart = 0)<para/>
''' (2) iend  is lower  0 means 'read to the end'<para/>
''' (3) if das == NULL, this is a no-op<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dad">[in] - dest dna add to this one</param>
'''  <param name="das">[in][optional] - source dna add from this one</param>
'''  <param name="istart">[in] - starting index in das</param>
'''  <param name="iend">[in] - ending index in das use -1 to cat all</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function l_dnaJoin(
				 ByVal dad as L_Dna, 
				 ByVal das as L_Dna, 
				 ByVal istart as Integer, 
				 ByVal iend as Integer) as Integer

	If IsNothing (dad) then Throw New ArgumentNullException  ("dad cannot be Nothing")



	Dim dasPTR As IntPtr = IntPtr.Zero : If Not IsNothing(das) Then dasPTR = das.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaJoin( dad.Pointer, dasPTR, istart, iend)

	Return _Result
End Function

' SRC\dnafunc1.c (125, 1)
' l_dnaaFlattenToDna(daa) as L_Dna
' l_dnaaFlattenToDna(L_DNAA *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This 'flattens' the dnaa to a dna, by joining successively<para/>
''' each dna in the dnaa.<para/>
''' (2) It leaves the input dnaa unchanged.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="daa">[in] - </param>
'''   <returns>dad, or NULL on error</returns>
Public Shared Function l_dnaaFlattenToDna(
				 ByVal daa as L_Dnaa) as L_Dna

	If IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaaFlattenToDna( daa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnafunc1.c (159, 1)
' l_dnaConvertToNuma(da) as Numa
' l_dnaConvertToNuma(L_DNA *) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function l_dnaConvertToNuma(
				 ByVal da as L_Dna) as Numa

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaConvertToNuma( da.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\dnafunc1.c (187, 1)
' numaConvertToDna(na) as L_Dna
' numaConvertToDna(NUMA *) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="na">[in] - </param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function numaConvertToDna(
				 ByVal na as Numa) as L_Dna

	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.numaConvertToDna( na.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnafunc1.c (226, 1)
' l_dnaUnionByAset(da1, da2) as L_Dna
' l_dnaUnionByAset(L_DNA *, L_DNA *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See sarrayUnionByAset() for the approach.<para/>
''' (2) Here, the key in building the sorted tree is the number itself.<para/>
''' (3) Operations using an underlying tree are O(nlogn), which is<para/>
''' typically less efficient than hashing, which is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da1">[in] - </param>
'''  <param name="da2">[in] - </param>
'''   <returns>dad with the union of the set of numbers, or NULL on error</returns>
Public Shared Function l_dnaUnionByAset(
				 ByVal da1 as L_Dna, 
				 ByVal da2 as L_Dna) as L_Dna

	If IsNothing (da1) then Throw New ArgumentNullException  ("da1 cannot be Nothing")
	If IsNothing (da2) then Throw New ArgumentNullException  ("da2 cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaUnionByAset( da1.Pointer, da2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnafunc1.c (256, 1)
' l_dnaRemoveDupsByAset(das) as L_Dna
' l_dnaRemoveDupsByAset(L_DNA *) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="das">[in] - </param>
'''   <returns>dad with duplicates removed, or NULL on error</returns>
Public Shared Function l_dnaRemoveDupsByAset(
				 ByVal das as L_Dna) as L_Dna

	If IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaRemoveDupsByAset( das.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnafunc1.c (301, 1)
' l_dnaIntersectionByAset(da1, da2) as L_Dna
' l_dnaIntersectionByAset(L_DNA *, L_DNA *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See sarrayIntersection() for the approach.<para/>
''' (2) Here, the key in building the sorted tree is the number itself.<para/>
''' (3) Operations using an underlying tree are O(nlogn), which is<para/>
''' typically less efficient than hashing, which is O(n).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da1">[in] - </param>
'''  <param name="da2">[in] - </param>
'''   <returns>dad with the intersection of the two arrays, or NULL on error</returns>
Public Shared Function l_dnaIntersectionByAset(
				 ByVal da1 as L_Dna, 
				 ByVal da2 as L_Dna) as L_Dna

	If IsNothing (da1) then Throw New ArgumentNullException  ("da1 cannot be Nothing")
	If IsNothing (da2) then Throw New ArgumentNullException  ("da2 cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaIntersectionByAset( da1.Pointer, da2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnafunc1.c (350, 1)
' l_asetCreateFromDna(da) as L_Rbtree
' l_asetCreateFromDna(L_DNA *) as L_ASET *
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - source dna</param>
'''   <returns>set using the doubles in %da as keys</returns>
Public Shared Function l_asetCreateFromDna(
				 ByVal da as L_Dna) as L_Rbtree

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetCreateFromDna( da.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\dnafunc1.c (385, 1)
' l_dnaDiffAdjValues(das) as L_Dna
' l_dnaDiffAdjValues(L_DNA *) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="das">[in] - input l_dna</param>
'''   <returns>dad of difference values val[i+1] - val[i], or NULL on error</returns>
Public Shared Function l_dnaDiffAdjValues(
				 ByVal das as L_Dna) as L_Dna

	If IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")




	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaDiffAdjValues( das.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

End Class

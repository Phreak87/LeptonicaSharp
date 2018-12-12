Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' dnafunc1.c (79, 1)
' l_dnaJoin(dad, das, istart, iend) as Integer
' l_dnaJoin(L_DNA *, L_DNA *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) istart  is smaller 0 is taken to mean 'read from the start' (istart = 0)<para/>
'''
'''(2) iend  is smaller 0 means 'read to the end'<para/>
'''
'''(3) if das == NULL, this is a no-op
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaJoin/*"/>
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


if IsNothing (dad) then Throw New ArgumentNullException  ("dad cannot be Nothing")
	Dim dasPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(das) Then dasPtr = das.Pointer

	Dim _Result as Integer = Natives.l_dnaJoin(dad.Pointer, dasPtr,   istart,   iend)
	
	return _Result
End Function

' dnafunc1.c (125, 1)
' l_dnaaFlattenToDna(daa) as L_Dna
' l_dnaaFlattenToDna(L_DNAA *) as L_DNA *
'''  <summary>
''' (1) This 'flattens' the dnaa to a dna, by joining successively
'''each dna in the dnaa.<para/>
'''
'''(2) It leaves the input dnaa unchanged.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaaFlattenToDna/*"/>
'''  <param name="daa">[in] - </param>
'''   <returns>dad, or NULL on error</returns>
Public Shared Function l_dnaaFlattenToDna(
				ByVal daa as L_Dnaa) as L_Dna


if IsNothing (daa) then Throw New ArgumentNullException  ("daa cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaaFlattenToDna(daa.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

' dnafunc1.c (159, 1)
' l_dnaConvertToNuma(da) as Numa
' l_dnaConvertToNuma(L_DNA *) as NUMA *
'''  <summary>
''' l_dnaConvertToNuma()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaConvertToNuma/*"/>
'''  <param name="da">[in] - </param>
'''   <returns>na, or NULL on error</returns>
Public Shared Function l_dnaConvertToNuma(
				ByVal da as L_Dna) as Numa


if IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaConvertToNuma(da.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Numa(_Result)
End Function

' dnafunc1.c (187, 1)
' numaConvertToDna(na) as L_Dna
' numaConvertToDna(NUMA *) as L_DNA *
'''  <summary>
''' numaConvertToDna
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/numaConvertToDna/*"/>
'''  <param name="na">[in] - </param>
'''   <returns>da, or NULL on error</returns>
Public Shared Function numaConvertToDna(
				ByVal na as Numa) as L_Dna


if IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")
	Dim _Result as IntPtr = Natives.numaConvertToDna(na.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

' dnafunc1.c (226, 1)
' l_dnaUnionByAset(da1, da2) as L_Dna
' l_dnaUnionByAset(L_DNA *, L_DNA *) as L_DNA *
'''  <summary>
''' (1) See sarrayUnionByAset() for the approach.<para/>
'''
'''(2) Here, the key in building the sorted tree is the number itself.<para/>
'''
'''(3) Operations using an underlying tree are O(nlogn), which is
'''typically less efficient than hashing, which is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaUnionByAset/*"/>
'''  <param name="da1">[in] - </param>
'''  <param name="da2">[in] - </param>
'''   <returns>dad with the union of the set of numbers, or NULL on error</returns>
Public Shared Function l_dnaUnionByAset(
				ByVal da1 as L_Dna, 
				ByVal da2 as L_Dna) as L_Dna


if IsNothing (da1) then Throw New ArgumentNullException  ("da1 cannot be Nothing")
		if IsNothing (da2) then Throw New ArgumentNullException  ("da2 cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaUnionByAset(da1.Pointer, da2.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

' dnafunc1.c (256, 1)
' l_dnaRemoveDupsByAset(das) as L_Dna
' l_dnaRemoveDupsByAset(L_DNA *) as L_DNA *
'''  <summary>
''' l_dnaRemoveDupsByAset()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaRemoveDupsByAset/*"/>
'''  <param name="das">[in] - </param>
'''   <returns>dad with duplicates removed, or NULL on error</returns>
Public Shared Function l_dnaRemoveDupsByAset(
				ByVal das as L_Dna) as L_Dna


if IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaRemoveDupsByAset(das.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

' dnafunc1.c (301, 1)
' l_dnaIntersectionByAset(da1, da2) as L_Dna
' l_dnaIntersectionByAset(L_DNA *, L_DNA *) as L_DNA *
'''  <summary>
''' (1) See sarrayIntersection() for the approach.<para/>
'''
'''(2) Here, the key in building the sorted tree is the number itself.<para/>
'''
'''(3) Operations using an underlying tree are O(nlogn), which is
'''typically less efficient than hashing, which is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaIntersectionByAset/*"/>
'''  <param name="da1">[in] - </param>
'''  <param name="da2">[in] - </param>
'''   <returns>dad with the intersection of the two arrays, or NULL on error</returns>
Public Shared Function l_dnaIntersectionByAset(
				ByVal da1 as L_Dna, 
				ByVal da2 as L_Dna) as L_Dna


if IsNothing (da1) then Throw New ArgumentNullException  ("da1 cannot be Nothing")
		if IsNothing (da2) then Throw New ArgumentNullException  ("da2 cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaIntersectionByAset(da1.Pointer, da2.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

' dnafunc1.c (350, 1)
' l_asetCreateFromDna(da) as L_Rbtree
' l_asetCreateFromDna(L_DNA *) as L_ASET *
'''  <summary>
''' l_asetCreateFromDna()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetCreateFromDna/*"/>
'''  <param name="da">[in] - source dna</param>
'''   <returns>set using the doubles in %da as keys</returns>
Public Shared Function l_asetCreateFromDna(
				ByVal da as L_Dna) as L_Rbtree


if IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_asetCreateFromDna(da.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Rbtree(_Result)
End Function

' dnafunc1.c (385, 1)
' l_dnaDiffAdjValues(das) as L_Dna
' l_dnaDiffAdjValues(L_DNA *) as L_DNA *
'''  <summary>
''' l_dnaDiffAdjValues()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaDiffAdjValues/*"/>
'''  <param name="das">[in] - input l_dna</param>
'''   <returns>dad of difference values val[i+1] - val[i], or NULL on error</returns>
Public Shared Function l_dnaDiffAdjValues(
				ByVal das as L_Dna) as L_Dna


if IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")
	Dim _Result as IntPtr = Natives.l_dnaDiffAdjValues(das.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Dna(_Result)
End Function

End Class



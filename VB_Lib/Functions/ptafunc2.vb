Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\ptafunc2.c (89, 1)
' ptaSort(ptas, sorttype, sortorder, pnaindex) as Pta
' ptaSort(PTA *, l_int32, l_int32, NUMA **) as PTA *
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out][optional] - index of sorted order into original array</param>
'''   <returns>ptad sorted version of ptas, or NULL on error</returns>
Public Shared Function ptaSort(
				 ByVal ptas as Pta, 
				 ByVal sorttype as Enumerations.L_SORT_BY, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> ByRef pnaindex as Numa) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaSort( ptas.Pointer, sorttype, sortorder, pnaindexPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (132, 1)
' ptaGetSortIndex(ptas, sorttype, sortorder, pnaindex) as Integer
' ptaGetSortIndex(PTA *, l_int32, l_int32, NUMA **) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y</param>
'''  <param name="sortorder">[in] - L_SORT_INCREASING, L_SORT_DECREASING</param>
'''  <param name="pnaindex">[out] - index of sorted order into original array</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetSortIndex(
				 ByVal ptas as Pta, 
				 ByVal sorttype as Enumerations.L_SORT_BY, 
				 ByVal sortorder as Enumerations.L_SORT_CREASING, 
				<Out()> ByRef pnaindex as Numa) as Integer

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim pnaindexPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pnaindex) Then pnaindexPTR = pnaindex.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetSortIndex( ptas.Pointer, sorttype, sortorder, pnaindexPTR)
	if pnaindexPTR <> IntPtr.Zero then pnaindex = new Numa(pnaindexPTR)

	Return _Result
End Function

' SRC\ptafunc2.c (182, 1)
' ptaSortByIndex(ptas, naindex) as Pta
' ptaSortByIndex(PTA *, NUMA *) as PTA *
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - </param>
'''  <param name="naindex">[in] - na that maps from the new pta to the input pta</param>
'''   <returns>ptad sorted, or NULL on  error</returns>
Public Shared Function ptaSortByIndex(
				 ByVal ptas as Pta, 
				 ByVal naindex as Numa) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	If IsNothing (naindex) then Throw New ArgumentNullException  ("naindex cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaSortByIndex( ptas.Pointer, naindex.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (218, 1)
' ptaaSortByIndex(ptaas, naindex) as Ptaa
' ptaaSortByIndex(PTAA *, NUMA *) as PTAA *
'''  <remarks>
'''  </remarks>
'''  <param name="ptaas">[in] - </param>
'''  <param name="naindex">[in] - na that maps from the new ptaa to the input ptaa</param>
'''   <returns>ptaad sorted, or NULL on error</returns>
Public Shared Function ptaaSortByIndex(
				 ByVal ptaas as Ptaa, 
				 ByVal naindex as Numa) as Ptaa

	If IsNothing (ptaas) then Throw New ArgumentNullException  ("ptaas cannot be Nothing")
	If IsNothing (naindex) then Throw New ArgumentNullException  ("naindex cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaaSortByIndex( ptaas.Pointer, naindex.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Ptaa(_Result)
End Function

' SRC\ptafunc2.c (257, 1)
' ptaGetRankValue(pta, fract, ptasort, sorttype, pval) as Integer
' ptaGetRankValue(PTA *, l_float32, PTA *, l_int32, l_float32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="fract">[in] - use 0.0 for smallest, 1.0 for largest</param>
'''  <param name="ptasort">[in][optional] - version of %pta sorted by %sorttype</param>
'''  <param name="sorttype">[in] - L_SORT_BY_X, L_SORT_BY_Y</param>
'''  <param name="pval">[out] - and rankval: the x or y value at %fract</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaGetRankValue(
				 ByVal pta as Pta, 
				 ByVal fract as Single, 
				 ByVal ptasort as Pta, 
				 ByVal sorttype as Enumerations.L_SORT_BY, 
				<Out()> ByRef pval as Single()) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")

	Dim ptasortPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ptasort) Then ptasortPTR = ptasort.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaGetRankValue( pta.Pointer, fract, ptasortPTR, sorttype, pval)

	Return _Result
End Function

' SRC\ptafunc2.c (317, 1)
' ptaUnionByAset(pta1, pta2) as Pta
' ptaUnionByAset(PTA *, PTA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See sarrayRemoveDupsByAset() for the approach.<para/>
''' (2) The key is a 64-bit hash from the (x,y) pair.<para/>
''' (3) This is slower than ptaUnionByHash(), mostly because of the<para/>
''' nlogn sort to build up the rbtree.  Do not use for large<para/>
''' numbers of points (say,  is greater  1M).<para/>
''' (4) The Aset() functions use the sorted l_Aset, which is just<para/>
''' an rbtree in disguise.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta1">[in] - </param>
'''  <param name="pta2">[in] - </param>
'''   <returns>ptad with the union of the set of points, or NULL on error</returns>
Public Shared Function ptaUnionByAset(
				 ByVal pta1 as Pta, 
				 ByVal pta2 as Pta) as Pta

	If IsNothing (pta1) then Throw New ArgumentNullException  ("pta1 cannot be Nothing")
	If IsNothing (pta2) then Throw New ArgumentNullException  ("pta2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaUnionByAset( pta1.Pointer, pta2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (354, 1)
' ptaRemoveDupsByAset(ptas) as Pta
' ptaRemoveDupsByAset(PTA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is slower than ptaRemoveDupsByHash(), mostly because<para/>
''' of the nlogn sort to build up the rbtree.  Do not use for<para/>
''' large numbers of points (say,  is greater  1M).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - assumed to be integer values</param>
'''   <returns>ptad with duplicates removed, or NULL on error</returns>
Public Shared Function ptaRemoveDupsByAset(
				 ByVal ptas as Pta) as Pta

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaRemoveDupsByAset( ptas.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (401, 1)
' ptaIntersectionByAset(pta1, pta2) as Pta
' ptaIntersectionByAset(PTA *, PTA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See sarrayIntersectionByAset() for the approach.<para/>
''' (2) The key is a 64-bit hash from the (x,y) pair.<para/>
''' (3) This is slower than ptaIntersectionByHash(), mostly because<para/>
''' of the nlogn sort to build up the rbtree.  Do not use for<para/>
''' large numbers of points (say,  is greater  1M).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta1">[in] - </param>
'''  <param name="pta2">[in] - </param>
'''   <returns>ptad intersection of the point sets, or NULL on error</returns>
Public Shared Function ptaIntersectionByAset(
				 ByVal pta1 as Pta, 
				 ByVal pta2 as Pta) as Pta

	If IsNothing (pta1) then Throw New ArgumentNullException  ("pta1 cannot be Nothing")
	If IsNothing (pta2) then Throw New ArgumentNullException  ("pta2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaIntersectionByAset( pta1.Pointer, pta2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (451, 1)
' l_asetCreateFromPta(pta) as L_Rbtree
' l_asetCreateFromPta(PTA *) as L_ASET *
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''   <returns>set using a 64-bit hash of (x,y) as the key</returns>
Public Shared Function l_asetCreateFromPta(
				 ByVal pta as Pta) as L_Rbtree

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_asetCreateFromPta( pta.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Rbtree(_Result)
End Function

' SRC\ptafunc2.c (493, 1)
' ptaUnionByHash(pta1, pta2) as Pta
' ptaUnionByHash(PTA *, PTA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is faster than ptaUnionByAset(), because the<para/>
''' bucket lookup is O(n).  It should be used if the pts are<para/>
''' integers (e.g., representing pixel positions).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta1">[in] - </param>
'''  <param name="pta2">[in] - </param>
'''   <returns>ptad with the union of the set of points, or NULL on error</returns>
Public Shared Function ptaUnionByHash(
				 ByVal pta1 as Pta, 
				 ByVal pta2 as Pta) as Pta

	If IsNothing (pta1) then Throw New ArgumentNullException  ("pta1 cannot be Nothing")
	If IsNothing (pta2) then Throw New ArgumentNullException  ("pta2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaUnionByHash( pta1.Pointer, pta2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (543, 1)
' ptaRemoveDupsByHash(ptas, pptad, pdahash) as Integer
' ptaRemoveDupsByHash(PTA *, PTA **, L_DNAHASH **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a pta with unique values.<para/>
''' (2) The dnahash is built up with ptad to assure uniqueness.<para/>
''' It can be used to find if a point is in the set:<para/>
''' ptaFindPtByHash(ptad, dahash, x, y,  and index)<para/>
''' (3) The hash of the (x,y) location is simple and fast.  It scales<para/>
''' up with the number of buckets to insure a fairly random<para/>
''' bucket selection for adjacent points.<para/>
''' (4) A Dna is used rather than a Numa because we need accurate<para/>
''' representation of 32-bit integers that are indices into ptas.<para/>
''' Integer -- is greater  float -- is greater  integer conversion makes errors for<para/>
''' integers larger than 10M.<para/>
''' (5) This is faster than ptaRemoveDupsByAset(), because the<para/>
''' bucket lookup is O(n), although there is a double-loop<para/>
''' lookup within the dna in each bucket.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptas">[in] - assumed to be integer values</param>
'''  <param name="pptad">[out] - unique set of pts duplicates removed</param>
'''  <param name="pdahash">[out][optional] - dnahash used for lookup</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaRemoveDupsByHash(
				 ByVal ptas as Pta, 
				<Out()> ByRef pptad as Pta, 
				<Out()> ByRef pdahash as L_DnaHash) as Integer

	If IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")

	Dim pptadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pptad) Then pptadPTR = pptad.Pointer
Dim pdahashPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdahash) Then pdahashPTR = pdahash.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.ptaRemoveDupsByHash( ptas.Pointer, pptadPTR, pdahashPTR)
	if pptadPTR <> IntPtr.Zero then pptad = new Pta(pptadPTR)
	if pdahashPTR <> IntPtr.Zero then pdahash = new L_DnaHash(pdahashPTR)

	Return _Result
End Function

' SRC\ptafunc2.c (600, 1)
' ptaIntersectionByHash(pta1, pta2) as Pta
' ptaIntersectionByHash(PTA *, PTA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is faster than ptaIntersectionByAset(), because the<para/>
''' bucket lookup is O(n).  It should be used if the pts are<para/>
''' integers (e.g., representing pixel positions).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta1">[in] - </param>
'''  <param name="pta2">[in] - </param>
'''   <returns>ptad intersection of the point sets, or NULL on error</returns>
Public Shared Function ptaIntersectionByHash(
				 ByVal pta1 as Pta, 
				 ByVal pta2 as Pta) as Pta

	If IsNothing (pta1) then Throw New ArgumentNullException  ("pta1 cannot be Nothing")
	If IsNothing (pta2) then Throw New ArgumentNullException  ("pta2 cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.ptaIntersectionByHash( pta1.Pointer, pta2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\ptafunc2.c (674, 1)
' ptaFindPtByHash(pta, dahash, x, y, pindex) as Integer
' ptaFindPtByHash(PTA *, L_DNAHASH *, l_int32, l_int32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Fast lookup in dnaHash associated with a pta, to see if a<para/>
''' random point (x,y) is already stored in the hash table.<para/>
''' (2) We use a strong hash function to minimize the chance that<para/>
''' two different points hash to the same key value.<para/>
''' (3) We select the number of buckets to be about 5% of the size<para/>
''' of the input %pta, so that when fully populated, each<para/>
''' bucket (dna) will have about 20 entries, each being an index<para/>
''' into %pta.  In lookup, after hashing to the key, and then<para/>
''' again to the bucket, we traverse the bucket (dna), using the<para/>
''' index into %pta to check if the point (x,y) has been found before.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''  <param name="dahash">[in] - built from pta</param>
'''  <param name="x">[in] - arbitrary points</param>
'''  <param name="y">[in] - arbitrary points</param>
'''  <param name="pindex">[out] - index into pta if (x,y) is in pta -1 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaFindPtByHash(
				 ByVal pta as Pta, 
				 ByVal dahash as L_DnaHash, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pindex as Integer) as Integer

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.ptaFindPtByHash( pta.Pointer, dahash.Pointer, x, y, pindex)

	Return _Result
End Function

' SRC\ptafunc2.c (720, 1)
' l_dnaHashCreateFromPta(pta) as L_DnaHash
' l_dnaHashCreateFromPta(PTA *) as L_DNAHASH *
'''  <remarks>
'''  </remarks>
'''  <param name="pta">[in] - </param>
'''   <returns>dahash, or NULL on error</returns>
Public Shared Function l_dnaHashCreateFromPta(
				 ByVal pta as Pta) as L_DnaHash

	If IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaHashCreateFromPta( pta.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_DnaHash(_Result)
End Function

End Class

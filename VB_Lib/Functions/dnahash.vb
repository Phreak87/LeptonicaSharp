Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dnahash.c (122, 1)
' l_dnaHashCreate(nbuckets, initsize) as L_DnaHash
' l_dnaHashCreate(l_int32, l_int32) as L_DNAHASH *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Actual dna are created only as required by l_dnaHashAdd()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="nbuckets">[in] - the number of buckets in the hash table, which should be prime.</param>
'''  <param name="initsize">[in] - initial size of each allocated dna 0 for default</param>
'''   <returns>ptr to new dnahash, or NULL on error</returns>
Public Shared Function l_dnaHashCreate(
				 ByVal nbuckets as Integer, 
				 ByVal initsize as Integer) as L_DnaHash

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaHashCreate( nbuckets, initsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_DnaHash(_Result)
End Function

' SRC\dnahash.c (152, 1)
' l_dnaHashDestroy(pdahash) as Object
' l_dnaHashDestroy(L_DNAHASH **) as void
'''  <remarks>
'''  </remarks>
'''  <param name="pdahash">[in,out] - to be nulled, if it exists</param>
Public Shared Sub l_dnaHashDestroy(
				 ByRef pdahash as L_DnaHash)

	Dim pdahashPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdahash) Then pdahashPTR = pdahash.Pointer

	LeptonicaSharp.Natives.l_dnaHashDestroy( pdahashPTR)
	if pdahashPTR <> IntPtr.Zero then pdahash = new L_DnaHash(pdahashPTR)

End Sub

' SRC\dnahash.c (185, 1)
' l_dnaHashGetCount(dahash) as Integer
' l_dnaHashGetCount(L_DNAHASH *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="dahash">[in] - </param>
'''   <returns>nbuckets allocated, or 0 on error</returns>
Public Shared Function l_dnaHashGetCount(
				 ByVal dahash as L_DnaHash) as Integer

	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaHashGetCount( dahash.Pointer)

	Return _Result
End Function

' SRC\dnahash.c (203, 1)
' l_dnaHashGetTotalCount(dahash) as Integer
' l_dnaHashGetTotalCount(L_DNAHASH *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="dahash">[in] - </param>
'''   <returns>n number of numbers in all dna, or 0 on error</returns>
Public Shared Function l_dnaHashGetTotalCount(
				 ByVal dahash as L_DnaHash) as Integer

	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaHashGetTotalCount( dahash.Pointer)

	Return _Result
End Function

' SRC\dnahash.c (232, 1)
' l_dnaHashGetDna(dahash, key, copyflag) as L_Dna
' l_dnaHashGetDna(L_DNAHASH *, l_uint64, l_int32) as L_DNA *
'''  <remarks>
'''  </remarks>
'''  <param name="dahash">[in] - </param>
'''  <param name="key">[in] - key to be hashed into a bucket number</param>
'''  <param name="copyflag">[in] - L_NOCOPY, L_COPY, L_CLONE</param>
'''   <returns>ptr to dna</returns>
Public Shared Function l_dnaHashGetDna(
				 ByVal dahash as L_DnaHash, 
				 ByVal key as ULong, 
				 ByVal copyflag as Enumerations.L_access_storage) as L_Dna

	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaHashGetDna( dahash.Pointer, key, copyflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnahash.c (267, 1)
' l_dnaHashAdd(dahash, key, value) as Integer
' l_dnaHashAdd(L_DNAHASH *, l_uint64, l_float64) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="dahash">[in] - </param>
'''  <param name="key">[in] - key to be hashed into a bucket number</param>
'''  <param name="value">[in] - float value to be appended to the specific dna</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaHashAdd(
				 ByVal dahash as L_DnaHash, 
				 ByVal key as ULong, 
				 ByVal value as Double) as Integer

	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")
	If IsNothing (key) then Throw New ArgumentNullException  ("key cannot be Nothing")
	If IsNothing (value) then Throw New ArgumentNullException  ("value cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaHashAdd( dahash.Pointer, key, value)

	Return _Result
End Function

' SRC\dnahash.c (306, 1)
' l_dnaHashCreateFromDna(da) as L_DnaHash
' l_dnaHashCreateFromDna(L_DNA *) as L_DNAHASH *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The values stored in the %dahash are indices into %da<para/>
''' %dahash has no use without %da.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''   <returns>dahash if OK 1 on error</returns>
Public Shared Function l_dnaHashCreateFromDna(
				 ByVal da as L_Dna) as L_DnaHash

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaHashCreateFromDna( da.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_DnaHash(_Result)
End Function

' SRC\dnahash.c (350, 1)
' l_dnaRemoveDupsByHash(das, pdad, pdahash) as Integer
' l_dnaRemoveDupsByHash(L_DNA *, L_DNA **, L_DNAHASH **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a dna with unique values.<para/>
''' (2) The dnahash is built up with dad to assure uniqueness.<para/>
''' It can be used to find if an element is in the set:<para/>
''' l_dnaFindValByHash(dad, dahash, val,  and index)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="das">[in] - </param>
'''  <param name="pdad">[out] - hash set</param>
'''  <param name="pdahash">[out][optional] - dnahash used for lookup</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaRemoveDupsByHash(
				 ByVal das as L_Dna, 
				<Out()> ByRef pdad as L_Dna, 
				<Out()> Optional ByRef pdahash as L_DnaHash = Nothing) as Integer

	If IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")

	Dim pdadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdad) Then pdadPTR = pdad.Pointer
Dim pdahashPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdahash) Then pdahashPTR = pdahash.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaRemoveDupsByHash( das.Pointer, pdadPTR, pdahashPTR)
	if pdadPTR <> IntPtr.Zero then pdad = new L_Dna(pdadPTR)
	if pdahashPTR <> IntPtr.Zero then pdahash = new L_DnaHash(pdahashPTR)

	Return _Result
End Function

' SRC\dnahash.c (421, 1)
' l_dnaMakeHistoByHash(das, pdahash, pdav, pdac) as Integer
' l_dnaMakeHistoByHash(L_DNA *, L_DNAHASH **, L_DNA **, L_DNA **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates and returns a dna of occurrences (histogram),<para/>
''' an aligned dna of values, and an associated hashmap.<para/>
''' The hashmap takes %dav and a value, and points into the<para/>
''' histogram in %dac.<para/>
''' (2) The dna of values, %dav, is aligned with the histogram %dac,<para/>
''' and is needed for fast lookup.  It is a hash set, because<para/>
''' the values are unique.<para/>
''' (3) Lookup is simple:<para/>
''' l_dnaFindValByHash(dav, dahash, val,  and index)<para/>
''' if (index  is greater = 0)<para/>
''' l_dnaGetIValue(dac, index,  and icount)<para/>
''' else<para/>
''' icount = 0<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="das">[in] - </param>
'''  <param name="pdahash">[out] - hash map: val -- is greater  index</param>
'''  <param name="pdav">[out] - array of values: index -- is greater  val</param>
'''  <param name="pdac">[out] - histo array of counts: index -- is greater  count</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaMakeHistoByHash(
				 ByVal das as L_Dna, 
				<Out()> ByRef pdahash as L_DnaHash, 
				<Out()> ByRef pdav as L_Dna, 
				<Out()> ByRef pdac as L_Dna) as Integer

	If IsNothing (das) then Throw New ArgumentNullException  ("das cannot be Nothing")

	Dim pdahashPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdahash) Then pdahashPTR = pdahash.Pointer
	Dim pdavPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdav) Then pdavPTR = pdav.Pointer
	Dim pdacPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pdac) Then pdacPTR = pdac.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaMakeHistoByHash( das.Pointer, pdahashPTR, pdavPTR, pdacPTR)
	if pdahashPTR <> IntPtr.Zero then pdahash = new L_DnaHash(pdahashPTR)
	if pdavPTR <> IntPtr.Zero then pdav = new L_Dna(pdavPTR)
	if pdacPTR <> IntPtr.Zero then pdac = new L_Dna(pdacPTR)

	Return _Result
End Function

' SRC\dnahash.c (485, 1)
' l_dnaIntersectionByHash(da1, da2) as L_Dna
' l_dnaIntersectionByHash(L_DNA *, L_DNA *) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the same method for building the intersection set<para/>
''' as ptaIntersectionByHash() and sarrayIntersectionByHash().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da1">[in] - </param>
'''  <param name="da2">[in] - </param>
'''   <returns>dad intersection of the number arrays, or NULL on error</returns>
Public Shared Function l_dnaIntersectionByHash(
				 ByVal da1 as L_Dna, 
				 ByVal da2 as L_Dna) as L_Dna

	If IsNothing (da1) then Throw New ArgumentNullException  ("da1 cannot be Nothing")
	If IsNothing (da2) then Throw New ArgumentNullException  ("da2 cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_dnaIntersectionByHash( da1.Pointer, da2.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\dnahash.c (553, 1)
' l_dnaFindValByHash(da, dahash, val, pindex) as Integer
' l_dnaFindValByHash(L_DNA *, L_DNAHASH *, l_float64, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Algo: hash %val into a key hash the key to get the dna<para/>
''' in %dahash (that holds indices into %da) traverse<para/>
''' the dna of indices looking for %val in %da.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="da">[in] - </param>
'''  <param name="dahash">[in] - containing indices into %da</param>
'''  <param name="val">[in] - searching for this number in %da</param>
'''  <param name="pindex">[out] - index into da if found -1 otherwise</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_dnaFindValByHash(
				 ByVal da as L_Dna, 
				 ByVal dahash as L_DnaHash, 
				 ByVal val as Double, 
				<Out()> ByRef pindex as Integer) as Integer

	If IsNothing (da) then Throw New ArgumentNullException  ("da cannot be Nothing")
	If IsNothing (dahash) then Throw New ArgumentNullException  ("dahash cannot be Nothing")
	If IsNothing (val) then Throw New ArgumentNullException  ("val cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.l_dnaFindValByHash( da.Pointer, dahash.Pointer, val, pindex)

	Return _Result
End Function

End Class

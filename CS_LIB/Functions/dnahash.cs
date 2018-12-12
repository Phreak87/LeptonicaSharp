using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// dnahash.c (122, 1)
// l_dnaHashCreate(nbuckets, initsize) as L_DnaHash
// l_dnaHashCreate(l_int32, l_int32) as L_DNAHASH *
///  <summary>
/// (1) Actual dna are created only as required by l_dnaHashAdd()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashCreate/*"/>
///  <param name="nbuckets">[in] - the number of buckets in the hash table, which should be prime.</param>
///  <param name="initsize">[in] - initial size of each allocated dna 0 for default</param>
///   <returns>ptr to new dnahash, or NULL on error</returns>
public static L_DnaHash l_dnaHashCreate(
				 int nbuckets, 
				 int initsize){

	IntPtr _Result = Natives.l_dnaHashCreate(  nbuckets,   initsize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_DnaHash(_Result);
}

// dnahash.c (152, 1)
// l_dnaHashDestroy(pdahash) as Object
// l_dnaHashDestroy(L_DNAHASH **) as void
///  <summary>
/// l_dnaHashDestroy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashDestroy/*"/>
///  <param name="pdahash">[in,out] - to be nulled, if it exists</param>
public static void l_dnaHashDestroy(
				ref L_DnaHash pdahash){

	IntPtr pdahashPtr = IntPtr.Zero; 	if (pdahash != null) {pdahashPtr = pdahash.Pointer;}

	Natives.l_dnaHashDestroy(ref pdahashPtr);
	
	if (pdahashPtr == IntPtr.Zero) {pdahash = null;} else { pdahash = new L_DnaHash(pdahashPtr); };
}

// dnahash.c (185, 1)
// l_dnaHashGetCount(dahash) as int
// l_dnaHashGetCount(L_DNAHASH *) as l_int32
///  <summary>
/// l_dnaHashGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashGetCount/*"/>
///  <param name="dahash">[in] - </param>
///   <returns>nbuckets allocated, or 0 on error</returns>
public static int l_dnaHashGetCount(
				 L_DnaHash dahash){

if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}
	int _Result = Natives.l_dnaHashGetCount(dahash.Pointer);
	
	return _Result;
}

// dnahash.c (203, 1)
// l_dnaHashGetTotalCount(dahash) as int
// l_dnaHashGetTotalCount(L_DNAHASH *) as l_int32
///  <summary>
/// l_dnaHashGetTotalCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashGetTotalCount/*"/>
///  <param name="dahash">[in] - </param>
///   <returns>n number of numbers in all dna, or 0 on error</returns>
public static int l_dnaHashGetTotalCount(
				 L_DnaHash dahash){

if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}
	int _Result = Natives.l_dnaHashGetTotalCount(dahash.Pointer);
	
	return _Result;
}

// dnahash.c (232, 1)
// l_dnaHashGetDna(dahash, key, copyflag) as L_Dna
// l_dnaHashGetDna(L_DNAHASH *, l_uint64, l_int32) as L_DNA *
///  <summary>
/// l_dnaHashGetDna()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashGetDna/*"/>
///  <param name="dahash">[in] - </param>
///  <param name="key">[in] - key to be hashed into a bucket number</param>
///  <param name="copyflag">[in] - L_NOCOPY, L_COPY, L_CLONE</param>
///   <returns>ptr to dna</returns>
public static L_Dna l_dnaHashGetDna(
				 L_DnaHash dahash, 
				 ulong key, 
				 int copyflag){

if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}
	IntPtr _Result = Natives.l_dnaHashGetDna(dahash.Pointer,   key,   copyflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Dna(_Result);
}

// dnahash.c (267, 1)
// l_dnaHashAdd(dahash, key, value) as int
// l_dnaHashAdd(L_DNAHASH *, l_uint64, l_float64) as l_ok
///  <summary>
/// l_dnaHashAdd()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashAdd/*"/>
///  <param name="dahash">[in] - </param>
///  <param name="key">[in] - key to be hashed into a bucket number</param>
///  <param name="value">[in] - float value to be appended to the specific dna</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaHashAdd(
				 L_DnaHash dahash, 
				 ulong key, 
				 double value){

if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}
	int _Result = Natives.l_dnaHashAdd(dahash.Pointer,   key,   value);
	
	return _Result;
}

// dnahash.c (306, 1)
// l_dnaHashCreateFromDna(da) as L_DnaHash
// l_dnaHashCreateFromDna(L_DNA *) as L_DNAHASH *
///  <summary>
/// (1) The values stored in the %dahash are indices into %da
/// %dahash has no use without %da.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashCreateFromDna/*"/>
///  <param name="da">[in] - </param>
///   <returns>dahash if OK 1 on error</returns>
public static L_DnaHash l_dnaHashCreateFromDna(
				 L_Dna da){

if (da == null) {throw new ArgumentNullException  ("da cannot be Nothing");}
	IntPtr _Result = Natives.l_dnaHashCreateFromDna(da.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_DnaHash(_Result);
}

// dnahash.c (350, 1)
// l_dnaRemoveDupsByHash(das, pdad, pdahash) as int
// l_dnaRemoveDupsByHash(L_DNA *, L_DNA **, L_DNAHASH **) as l_ok
///  <summary>
/// (1) Generates a dna with unique values.<para/>
/// 
/// (2) The dnahash is built up with dad to assure uniqueness.
/// It can be used to find if an element is in the set:
/// l_dnaFindValByHash(dad, dahash, val, [and]index)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaRemoveDupsByHash/*"/>
///  <param name="das">[in] - </param>
///  <param name="pdad">[out] - hash set</param>
///  <param name="pdahash">[out][optional] - dnahash used for lookup</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaRemoveDupsByHash(
				 L_Dna das, 
				out L_Dna pdad, 
				out L_DnaHash pdahash){

if (das == null) {throw new ArgumentNullException  ("das cannot be Nothing");}
	IntPtr pdadPtr = IntPtr.Zero;
	IntPtr pdahashPtr = IntPtr.Zero;

	int _Result = Natives.l_dnaRemoveDupsByHash(das.Pointer, out pdadPtr, out pdahashPtr);
	
	if (pdadPtr == IntPtr.Zero) {pdad = null;} else { pdad = new L_Dna(pdadPtr); };
	if (pdahashPtr == IntPtr.Zero) {pdahash = null;} else { pdahash = new L_DnaHash(pdahashPtr); };
	return _Result;
}

// dnahash.c (421, 1)
// l_dnaMakeHistoByHash(das, pdahash, pdav, pdac) as int
// l_dnaMakeHistoByHash(L_DNA *, L_DNAHASH **, L_DNA **, L_DNA **) as l_ok
///  <summary>
/// (1) Generates and returns a dna of occurrences (histogram),
/// an aligned dna of values, and an associated hashmap.
/// The hashmap takes %dav and a value, and points into the
/// histogram in %dac.<para/>
/// 
/// (2) The dna of values, %dav, is aligned with the histogram %dac,
/// and is needed for fast lookup.  It is a hash set, because
/// the values are unique.<para/>
/// 
/// (3) Lookup is simple:
/// l_dnaFindValByHash(dav, dahash, val, [and]index)
/// if (index greater or equal 0)
/// l_dnaGetIValue(dac, index, [and]icount)
/// else
/// icount = 0
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaMakeHistoByHash/*"/>
///  <param name="das">[in] - </param>
///  <param name="pdahash">[out] - hash map: val to index</param>
///  <param name="pdav">[out] - array of values: index to val</param>
///  <param name="pdac">[out] - histo array of counts: index to count</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaMakeHistoByHash(
				 L_Dna das, 
				out L_DnaHash pdahash, 
				out L_Dna pdav, 
				out L_Dna pdac){

if (das == null) {throw new ArgumentNullException  ("das cannot be Nothing");}
	IntPtr pdahashPtr = IntPtr.Zero;
	IntPtr pdavPtr = IntPtr.Zero;
	IntPtr pdacPtr = IntPtr.Zero;

	int _Result = Natives.l_dnaMakeHistoByHash(das.Pointer, out pdahashPtr, out pdavPtr, out pdacPtr);
	
	if (pdahashPtr == IntPtr.Zero) {pdahash = null;} else { pdahash = new L_DnaHash(pdahashPtr); };
	if (pdavPtr == IntPtr.Zero) {pdav = null;} else { pdav = new L_Dna(pdavPtr); };
	if (pdacPtr == IntPtr.Zero) {pdac = null;} else { pdac = new L_Dna(pdacPtr); };
	return _Result;
}

// dnahash.c (485, 1)
// l_dnaIntersectionByHash(da1, da2) as L_Dna
// l_dnaIntersectionByHash(L_DNA *, L_DNA *) as L_DNA *
///  <summary>
/// (1) This uses the same method for building the intersection set
/// as ptaIntersectionByHash() and sarrayIntersectionByHash().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaIntersectionByHash/*"/>
///  <param name="da1">[in] - </param>
///  <param name="da2">[in] - </param>
///   <returns>dad intersection of the number arrays, or NULL on error</returns>
public static L_Dna l_dnaIntersectionByHash(
				 L_Dna da1, 
				 L_Dna da2){

if (da1 == null) {throw new ArgumentNullException  ("da1 cannot be Nothing");}
		if (da2 == null) {throw new ArgumentNullException  ("da2 cannot be Nothing");}
	IntPtr _Result = Natives.l_dnaIntersectionByHash(da1.Pointer, da2.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new L_Dna(_Result);
}

// dnahash.c (553, 1)
// l_dnaFindValByHash(da, dahash, val, pindex) as int
// l_dnaFindValByHash(L_DNA *, L_DNAHASH *, l_float64, l_int32 *) as l_ok
///  <summary>
/// (1) Algo: hash %val into a key hash the key to get the dna
/// in %dahash (that holds indices into %da) traverse
/// the dna of indices looking for %val in %da.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaFindValByHash/*"/>
///  <param name="da">[in] - </param>
///  <param name="dahash">[in] - containing indices into %da</param>
///  <param name="val">[in] - searching for this number in %da</param>
///  <param name="pindex">[out] - index into da if found -1 otherwise</param>
///   <returns>0 if OK 1 on error</returns>
public static int l_dnaFindValByHash(
				 L_Dna da, 
				 L_DnaHash dahash, 
				 double val, 
				out int pindex){

if (da == null) {throw new ArgumentNullException  ("da cannot be Nothing");}
		if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}
	int _Result = Natives.l_dnaFindValByHash(da.Pointer, dahash.Pointer,   val, out  pindex);
	
	return _Result;
}


}
}

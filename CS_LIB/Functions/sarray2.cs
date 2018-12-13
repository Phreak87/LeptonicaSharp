using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// sarray2.c (95, 1)
		// sarraySort(saout, sain, sortorder) as Sarray
		// sarraySort(SARRAY *, SARRAY *, l_int32) as SARRAY *
		///  <summary>
		/// (1) Set saout = sain for in-place otherwise, set naout = NULL.<para/>
		///
		/// (2) Shell sort, modified from K[and]R, 2nd edition, p.62.
		/// Slow but simple O(n logn) sort.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarraySort/*"/>
		///  <param name="saout">[in] - output sarray can be NULL or equal to sain</param>
		///  <param name="sain">[in] - input sarray</param>
		///  <param name="sortorder">[in] - L_SORT_INCREASING or L_SORT_DECREASING</param>
		///   <returns>saout output sarray, sorted by ascii value, or NULL on error</returns>
		public static Sarray sarraySort(
						Sarray saout,
						Sarray sain,
						int sortorder)
		{
			if (saout == null) {throw new ArgumentNullException  ("saout cannot be Nothing");}

			if (sain == null) {throw new ArgumentNullException  ("sain cannot be Nothing");}

			IntPtr _Result = Natives.sarraySort(saout.Pointer, sain.Pointer,   sortorder);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (145, 1)
		// sarraySortByIndex(sain, naindex) as Sarray
		// sarraySortByIndex(SARRAY *, NUMA *) as SARRAY *
		///  <summary>
		/// sarraySortByIndex()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarraySortByIndex/*"/>
		///  <param name="sain">[in] - </param>
		///  <param name="naindex">[in] - na that maps from the new sarray to the input sarray</param>
		///   <returns>saout sorted, or NULL on error</returns>
		public static Sarray sarraySortByIndex(
						Sarray sain,
						Numa naindex)
		{
			if (sain == null) {throw new ArgumentNullException  ("sain cannot be Nothing");}

			if (naindex == null) {throw new ArgumentNullException  ("naindex cannot be Nothing");}

			IntPtr _Result = Natives.sarraySortByIndex(sain.Pointer, naindex.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (185, 1)
		// stringCompareLexical(str1, str2) as int
		// stringCompareLexical(const char *, const char *) as l_int32
		///  <summary>
		/// (1) If the lexical values are identical, return a 0, to
		/// indicate that no swapping is required to sort the strings.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringCompareLexical/*"/>
		///  <param name="str1">[in] - </param>
		///  <param name="str2">[in] - </param>
		///   <returns>1 if str1  is greater  str2 lexically 0 otherwise</returns>
		public static int stringCompareLexical(
						String str1,
						String str2)
		{
			if (str1 == null) {throw new ArgumentNullException  ("str1 cannot be Nothing");}

			if (str2 == null) {throw new ArgumentNullException  ("str2 cannot be Nothing");}

			int _Result = Natives.stringCompareLexical(  str1,   str2);
			return _Result;
		}

		// sarray2.c (237, 1)
		// sarrayUnionByAset(sa1, sa2) as Sarray
		// sarrayUnionByAset(SARRAY *, SARRAY *) as SARRAY *
		///  <summary>
		/// (1) Duplicates are removed from the concatenation of the two arrays.<para/>
		///
		/// (2) The key for each string is a 64-bit hash.<para/>
		///
		/// (2) Algorithm: Concatenate the two sarrays.  Then build a set,
		/// using hashed strings as keys.  As the set is built, first do
		/// a find if not found, add the key to the set and add the string
		/// to the output sarray.  This is O(nlogn).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayUnionByAset/*"/>
		///  <param name="sa1">[in] - </param>
		///  <param name="sa2">[in] - </param>
		///   <returns>sad with the union of the string set, or NULL on error</returns>
		public static Sarray sarrayUnionByAset(
						Sarray sa1,
						Sarray sa2)
		{
			if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}

			if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}

			IntPtr _Result = Natives.sarrayUnionByAset(sa1.Pointer, sa2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (277, 1)
		// sarrayRemoveDupsByAset(sas) as Sarray
		// sarrayRemoveDupsByAset(SARRAY *) as SARRAY *
		///  <summary>
		/// (1) This is O(nlogn), considerably slower than
		/// sarrayRemoveDupsByHash() for large string arrays.<para/>
		///
		/// (2) The key for each string is a 64-bit hash.<para/>
		///
		/// (3) Build a set, using hashed strings as keys.  As the set is
		/// built, first do a find if not found, add the key to the
		/// set and add the string to the output sarray.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayRemoveDupsByAset/*"/>
		///  <param name="sas">[in] - </param>
		///   <returns>sad with duplicates removed, or NULL on error</returns>
		public static Sarray sarrayRemoveDupsByAset(
						Sarray sas)
		{
			if (sas == null) {throw new ArgumentNullException  ("sas cannot be Nothing");}

			IntPtr _Result = Natives.sarrayRemoveDupsByAset(sas.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (328, 1)
		// sarrayIntersectionByAset(sa1, sa2) as Sarray
		// sarrayIntersectionByAset(SARRAY *, SARRAY *) as SARRAY *
		///  <summary>
		/// (1) Algorithm: put the larger sarray into a set, using the string
		/// hashes as the key values.  Then run through the smaller sarray,
		/// building an output sarray and a second set from the strings
		/// in the larger array: if a string is in the first set but
		/// not in the second, add the string to the output sarray and hash
		/// it into the second set.  The second set is required to make
		/// sure only one instance of each string is put into the output sarray.
		/// This is O(mlogn), {m,n} = sizes of {smaller,larger} input arrays.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayIntersectionByAset/*"/>
		///  <param name="sa1">[in] - </param>
		///  <param name="sa2">[in] - </param>
		///   <returns>sad with the intersection of the string set, or NULL on error</returns>
		public static Sarray sarrayIntersectionByAset(
						Sarray sa1,
						Sarray sa2)
		{
			if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}

			if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}

			IntPtr _Result = Natives.sarrayIntersectionByAset(sa1.Pointer, sa2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (379, 1)
		// l_asetCreateFromSarray(sa) as L_Rbtree
		// l_asetCreateFromSarray(SARRAY *) as L_ASET *
		///  <summary>
		/// l_asetCreateFromSarray()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_asetCreateFromSarray/*"/>
		///  <param name="sa">[in] - </param>
		///   <returns>set using a string hash into a uint64 as the key</returns>
		public static L_Rbtree l_asetCreateFromSarray(
						Sarray sa)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			IntPtr _Result = Natives.l_asetCreateFromSarray(sa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_Rbtree(_Result);
		}

		// sarray2.c (431, 1)
		// sarrayRemoveDupsByHash(sas, psad, pdahash) as int
		// sarrayRemoveDupsByHash(SARRAY *, SARRAY **, L_DNAHASH **) as l_ok
		///  <summary>
		/// (1) Generates a sarray with unique values.<para/>
		///
		/// (2) The dnahash is built up with sad to assure uniqueness.
		/// It can be used to find if a string is in the set:
		/// sarrayFindValByHash(sad, dahash, str, [and]index)<para/>
		///
		/// (3) The hash of the string location is simple and fast.  It scales
		/// up with the number of buckets to insure a fairly random
		/// bucket selection input strings.<para/>
		///
		/// (4) This is faster than sarrayRemoveDupsByAset(), because the
		/// bucket lookup is O(n), although there is a double-loop
		/// lookup within the dna in each bucket.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayRemoveDupsByHash/*"/>
		///  <param name="sas">[in] - </param>
		///  <param name="psad">[out] - unique set of strings duplicates removed</param>
		///  <param name="pdahash">[out][optional] - dnahash used for lookup</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int sarrayRemoveDupsByHash(
						Sarray sas,
						out Sarray psad,
						out L_DnaHash pdahash)
		{
			if (sas == null) {throw new ArgumentNullException  ("sas cannot be Nothing");}

			IntPtr psadPtr = IntPtr.Zero;
			IntPtr pdahashPtr = IntPtr.Zero;
			int _Result = Natives.sarrayRemoveDupsByHash(sas.Pointer, out psadPtr, out pdahashPtr);
			if (psadPtr == IntPtr.Zero) {psad = null;} else { psad = new Sarray(psadPtr); };
			if (pdahashPtr == IntPtr.Zero) {pdahash = null;} else { pdahash = new L_DnaHash(pdahashPtr); };

			return _Result;
		}

		// sarray2.c (488, 1)
		// sarrayIntersectionByHash(sa1, sa2) as Sarray
		// sarrayIntersectionByHash(SARRAY *, SARRAY *) as SARRAY *
		///  <summary>
		/// (1) This is faster than sarrayIntersectionByAset(), because the
		/// bucket lookup is O(n).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayIntersectionByHash/*"/>
		///  <param name="sa1">[in] - </param>
		///  <param name="sa2">[in] - </param>
		///   <returns>sad intersection of the strings, or NULL on error</returns>
		public static Sarray sarrayIntersectionByHash(
						Sarray sa1,
						Sarray sa2)
		{
			if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}

			if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}

			IntPtr _Result = Natives.sarrayIntersectionByHash(sa1.Pointer, sa2.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (563, 1)
		// sarrayFindStringByHash(sa, dahash, str, pindex) as int
		// sarrayFindStringByHash(SARRAY *, L_DNAHASH *, const char *, l_int32 *) as l_ok
		///  <summary>
		/// (1) Fast lookup in dnaHash associated with a sarray, to see if a
		/// random string %str is already stored in the hash table.<para/>
		///
		/// (2) We use a strong hash function to minimize the chance that
		/// two different strings hash to the same key value.<para/>
		///
		/// (3) We select the number of buckets to be about 5% of the size
		/// of the input sarray, so that when fully populated, each
		/// bucket (dna) will have about 20 entries, each being an index
		/// into sa.  In lookup, after hashing to the key, and then
		/// again to the bucket, we traverse the bucket (dna), using the
		/// index into sa to check if %str has been found before.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayFindStringByHash/*"/>
		///  <param name="sa">[in] - </param>
		///  <param name="dahash">[in] - built from sa</param>
		///  <param name="str">[in] - arbitrary string</param>
		///  <param name="pindex">[out] - index into %sa if %str is in %sa -1 otherwise</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int sarrayFindStringByHash(
						Sarray sa,
						L_DnaHash dahash,
						String str,
						out int pindex)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			if (dahash == null) {throw new ArgumentNullException  ("dahash cannot be Nothing");}

			if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}

			int _Result = Natives.sarrayFindStringByHash(sa.Pointer, dahash.Pointer,   str, out  pindex);
			return _Result;
		}

		// sarray2.c (609, 1)
		// l_dnaHashCreateFromSarray(sa) as L_DnaHash
		// l_dnaHashCreateFromSarray(SARRAY *) as L_DNAHASH *
		///  <summary>
		/// l_dnaHashCreateFromSarray()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_dnaHashCreateFromSarray/*"/>
		///  <param name="sa">[in] - </param>
		///   <returns>dahash, or NULL on error</returns>
		public static L_DnaHash l_dnaHashCreateFromSarray(
						Sarray sa)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			IntPtr _Result = Natives.l_dnaHashCreateFromSarray(sa.Pointer);

			if (_Result == IntPtr.Zero) {return null;}

			return  new L_DnaHash(_Result);
		}

		// sarray2.c (648, 1)
		// sarrayGenerateIntegers(n) as Sarray
		// sarrayGenerateIntegers(l_int32) as SARRAY *
		///  <summary>
		/// sarrayGenerateIntegers()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayGenerateIntegers/*"/>
		///  <param name="n">[in] - </param>
		///   <returns>sa  (of printed numbers, 1 - n, or NULL on error</returns>
		public static Sarray sarrayGenerateIntegers(
						int n)
		{
			IntPtr _Result = Natives.sarrayGenerateIntegers(  n);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Sarray(_Result);
		}

		// sarray2.c (688, 1)
		// sarrayLookupCSKV(sa, keystring, pvalstring) as int
		// sarrayLookupCSKV(SARRAY *, const char *, char **) as l_ok
		///  <summary>
		/// (1) The input %sa can have other strings that are not in
		/// comma-separated key-value format.  These will be ignored.<para/>
		///
		/// (2) This returns a copy of the first value string in %sa whose
		/// key string matches the input %keystring.<para/>
		///
		/// (3) White space is not ignored all white space before the ','
		/// is used for the keystring in matching.  This allows the
		/// key and val strings to have white space (e.g., multiple words).
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayLookupCSKV/*"/>
		///  <param name="sa">[in] - (of strings, each being a comma-separated pair of strings, the first being a key and the second a value)</param>
		///  <param name="keystring">[in] - (an input string to match with each key in %sa</param>
		///  <param name="pvalstring">[out] - (the returned value string corresponding to the input key string, if found otherwise NULL)</param>
		///   <returns>0 if OK, 1 on error</returns>
		public static int sarrayLookupCSKV(
						Sarray sa,
						String keystring,
						out String[] pvalstring)
		{
			if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}

			if (keystring == null) {throw new ArgumentNullException  ("keystring cannot be Nothing");}

			IntPtr pvalstringPtr = IntPtr.Zero;
			int _Result = Natives.sarrayLookupCSKV(sa.Pointer,   keystring, out  pvalstringPtr);
			if (pvalstringPtr == null) {pvalstring = null;} else { pvalstring = null; };

			return _Result;
		}


	}
}

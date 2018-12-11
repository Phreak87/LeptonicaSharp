using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// sarray1.c (163, 1)
// sarrayCreate(n) as Sarray
// sarrayCreate(l_int32) as SARRAY *
///  <summary>
/// sarrayCreate()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayCreate/*"/>
///  <param name="n">[in] - size of string ptr array to be alloc'd use 0 for default</param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayCreate(
				 int n){

	IntPtr _Result = Natives.sarrayCreate(  n);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (193, 1)
// sarrayCreateInitialized(n, initstr) as Sarray
// sarrayCreateInitialized(l_int32, const char *) as SARRAY *
///  <summary>
/// sarrayCreateInitialized()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayCreateInitialized/*"/>
///  <param name="n">[in] - size of string ptr array to be alloc'd</param>
///  <param name="initstr">[in] - string to be initialized on the full array</param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayCreateInitialized(
				 int n, 
				 String initstr){

if (initstr == null) {throw new ArgumentNullException  ("initstr cannot be Nothing");}
	IntPtr _Result = Natives.sarrayCreateInitialized(  n,   initstr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (226, 1)
// sarrayCreateWordsFromString(string) as Sarray
// sarrayCreateWordsFromString(const char *) as SARRAY *
///  <summary>
/// (1) This finds the number of word substrings, creates an sarray
/// of this size, and puts copies of each substring into the sarray.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayCreateWordsFromString/*"/>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayCreateWordsFromString(
				 String _string_){

if (_string_ == null) {throw new ArgumentNullException  ("_string_ cannot be Nothing");}
	IntPtr _Result = Natives.sarrayCreateWordsFromString(  _string_);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (276, 1)
// sarrayCreateLinesFromString(string, blankflag) as Sarray
// sarrayCreateLinesFromString(const char *, l_int32) as SARRAY *
///  <summary>
/// (1) This finds the number of line substrings, each of which
/// ends with a newline, and puts a copy of each substring
/// in a new sarray.<para/>
/// 
/// (2) The newline characters are removed from each substring.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayCreateLinesFromString/*"/>
///  <param name="blankflag">[in] - 0 to exclude blank lines 1 to include</param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayCreateLinesFromString(
				 String _string_, 
				 int blankflag){

if (_string_ == null) {throw new ArgumentNullException  ("_string_ cannot be Nothing");}
	IntPtr _Result = Natives.sarrayCreateLinesFromString(  _string_,   blankflag);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (355, 1)
// sarrayDestroy(psa) as Object
// sarrayDestroy(SARRAY **) as void
///  <summary>
/// (1) Decrements the ref count and, if 0, destroys the sarray.<para/>
/// 
/// (2) Always nulls the input ptr.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayDestroy/*"/>
///  <param name="psa">[in,out] - to be nulled</param>
public static void sarrayDestroy(
				ref Sarray psa){

	IntPtr psaPtr = IntPtr.Zero; 	if (psa != null) {psaPtr = psa.Pointer;}

	Natives.sarrayDestroy(ref psaPtr);
	
	if (psaPtr == IntPtr.Zero) {psa = null;} else { psa = new Sarray(psaPtr); };
}

// sarray1.c (393, 1)
// sarrayCopy(sa) as Sarray
// sarrayCopy(SARRAY *) as SARRAY *
///  <summary>
/// sarrayCopy()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayCopy/*"/>
///  <param name="sa">[in] - string array</param>
///   <returns>copy of sarray, or NULL on error</returns>
public static Sarray sarrayCopy(
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.sarrayCopy(sa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (420, 1)
// sarrayClone(sa) as Sarray
// sarrayClone(SARRAY *) as SARRAY *
///  <summary>
/// sarrayClone()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayClone/*"/>
///  <param name="sa">[in] - string array</param>
///   <returns>ptr to same sarray, or NULL on error</returns>
public static Sarray sarrayClone(
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.sarrayClone(sa.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (446, 1)
// sarrayAddString(sa, string, copyflag) as int
// sarrayAddString(SARRAY *, const char *, l_int32) as l_ok
///  <summary>
/// (1) See usage comments at the top of this file.  L_INSERT is
/// equivalent to L_NOCOPY.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayAddString/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="copyflag">[in] - L_INSERT, L_NOCOPY or L_COPY</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayAddString(
				 Sarray sa, 
				 String _string_, 
				 int copyflag){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (_string_ == null) {throw new ArgumentNullException  ("_string_ cannot be Nothing");}
	int _Result = Natives.sarrayAddString(sa.Pointer,   _string_,   copyflag);
	
	return _Result;
}

// sarray1.c (506, 1)
// sarrayRemoveString(sa, index) as String
// sarrayRemoveString(SARRAY *, l_int32) as char *
///  <summary>
/// sarrayRemoveString()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayRemoveString/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="index">[in] - of string within sarray</param>
///   <returns>removed string, or NULL on error</returns>
public static String sarrayRemoveString(
				 Sarray sa, 
				 int index){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	String _Result = Natives.sarrayRemoveString(sa.Pointer,   index);
	
	return _Result;
}

// sarray1.c (557, 1)
// sarrayReplaceString(sa, index, newstr, copyflag) as int
// sarrayReplaceString(SARRAY *, l_int32, char *, l_int32) as l_ok
///  <summary>
/// (1) This destroys an existing string and replaces it with
/// the new string or a copy of it.<para/>
/// 
/// (2) By design, an sarray is always compacted, so there are
/// never any holes (null ptrs) in the ptr array up to the
/// current count.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayReplaceString/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="index">[in] - of string within sarray to be replaced</param>
///  <param name="newstr">[in] - string to replace existing one</param>
///  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayReplaceString(
				 Sarray sa, 
				 int index, 
				 String newstr, 
				 int copyflag){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (newstr == null) {throw new ArgumentNullException  ("newstr cannot be Nothing");}
	int _Result = Natives.sarrayReplaceString(sa.Pointer,   index,   newstr,   copyflag);
	
	return _Result;
}

// sarray1.c (594, 1)
// sarrayClear(sa) as int
// sarrayClear(SARRAY *) as l_ok
///  <summary>
/// sarrayClear()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayClear/*"/>
///  <param name="sa">[in] - string array</param>
///   <returns>0 if OK 1 on error</returns>
public static int sarrayClear(
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayClear(sa.Pointer);
	
	return _Result;
}

// sarray1.c (621, 1)
// sarrayGetCount(sa) as int
// sarrayGetCount(SARRAY *) as l_int32
///  <summary>
/// sarrayGetCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayGetCount/*"/>
///  <param name="sa">[in] - string array</param>
///   <returns>count, or 0 if no strings or on error</returns>
public static int sarrayGetCount(
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayGetCount(sa.Pointer);
	
	return _Result;
}

// sarray1.c (646, 1)
// sarrayGetArray(sa, pnalloc, pn) as String[]
// sarrayGetArray(SARRAY *, l_int32 *, l_int32 *) as char **
///  <summary>
/// (1) Caution: the returned array is not a copy, so caller
/// must not destroy it!
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayGetArray/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="pnalloc">[out][optional] - number allocated string ptrs</param>
///  <param name="pn">[out][optional] - number allocated strings</param>
///   <returns>ptr to string array, or NULL on error</returns>
public static String[] sarrayGetArray(
				 Sarray sa, 
				out int pnalloc, 
				out int pn){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.sarrayGetArray(sa.Pointer, out  pnalloc, out  pn);
	
	IntPtr[] PTRArr = new IntPtr[pn];
	Marshal.Copy(_Result, PTRArr, 0, PTRArr.Length);
	List<String> BLST = new List<String>();
	foreach (IntPtr eintrag in PTRArr){
	   BLST.Add(Marshal.PtrToStringAnsi(eintrag));
	}
	String[] B = BLST.ToArray();
	return B;
}

// sarray1.c (681, 1)
// sarrayGetString(sa, index, copyflag) as String
// sarrayGetString(SARRAY *, l_int32, l_int32) as char *
///  <summary>
/// (1) See usage comments at the top of this file.<para/>
/// 
/// (2) To get a pointer to the string itself, use L_NOCOPY.
/// To get a copy of the string, use L_COPY.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayGetString/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="index">[in] - to the index-th string</param>
///  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
///   <returns>string, or NULL on error</returns>
public static String sarrayGetString(
				 Sarray sa, 
				 int index, 
				 int copyflag){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	String _Result = Natives.sarrayGetString(sa.Pointer,   index,   copyflag);
	
	return _Result;
}

// sarray1.c (708, 1)
// sarrayGetRefcount(sa) as int
// sarrayGetRefcount(SARRAY *) as l_int32
///  <summary>
/// sarrayGetRefCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayGetRefcount/*"/>
///  <param name="sa">[in] - string array</param>
///   <returns>refcount, or UNDEF on error</returns>
public static int sarrayGetRefcount(
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayGetRefcount(sa.Pointer);
	
	return _Result;
}

// sarray1.c (726, 1)
// sarrayChangeRefcount(sa, delta) as int
// sarrayChangeRefcount(SARRAY *, l_int32) as l_ok
///  <summary>
/// sarrayChangeRefCount()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayChangeRefcount/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="delta">[in] - change to be applied</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayChangeRefcount(
				 Sarray sa, 
				 int delta){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayChangeRefcount(sa.Pointer,   delta);
	
	return _Result;
}

// sarray1.c (763, 1)
// sarrayToString(sa, addnlflag) as String
// sarrayToString(SARRAY *, l_int32) as char *
///  <summary>
/// (1) Concatenates all the strings in the sarray, preserving
/// all white space.<para/>
/// 
/// (2) If addnlflag != 0, adds either a '\n' or a ' ' after
/// each substring.<para/>
/// 
/// (3) This function was NOT implemented as:
/// for (i = 0 i  is smaller n i++)
/// strcat(dest, sarrayGetString(sa, i, L_NOCOPY))
/// Do you see why?
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayToString/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="addnlflag">[in] - flag: 0 adds nothing to each substring 1 adds '\n' to each substring 2 adds ' ' to each substring</param>
///   <returns>dest string, or NULL on error</returns>
public static String sarrayToString(
				 Sarray sa, 
				 int addnlflag){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	String _Result = Natives.sarrayToString(sa.Pointer,   addnlflag);
	
	return _Result;
}

// sarray1.c (798, 1)
// sarrayToStringRange(sa, first, nstrings, addnlflag) as String
// sarrayToStringRange(SARRAY *, l_int32, l_int32, l_int32) as char *
///  <summary>
/// (1) Concatenates the specified strings inthe sarray, preserving
/// all white space.<para/>
/// 
/// (2) If addnlflag != 0, adds either a '\n' or a ' ' after
/// each substring.<para/>
/// 
/// (3) If the sarray is empty, this returns a string with just
/// the character corresponding to %addnlflag.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayToStringRange/*"/>
///  <param name="sa">[in] - string array</param>
///  <param name="first">[in] - index of first string to use starts with 0</param>
///  <param name="nstrings">[in] - number of strings to append into the result use 0 to append to the end of the sarray</param>
///  <param name="addnlflag">[in] - flag: 0 adds nothing to each substring 1 adds '\n' to each substring 2 adds ' ' to each substring</param>
///   <returns>dest string, or NULL on error</returns>
public static String sarrayToStringRange(
				 Sarray sa, 
				 int first, 
				 int nstrings, 
				 int addnlflag){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	String _Result = Natives.sarrayToStringRange(sa.Pointer,   first,   nstrings,   addnlflag);
	
	return _Result;
}

// sarray1.c (880, 1)
// sarrayJoin(sa1, sa2) as int
// sarrayJoin(SARRAY *, SARRAY *) as l_ok
///  <summary>
/// (1) Copies of the strings in sarray2 are added to sarray1.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayJoin/*"/>
///  <param name="sa1">[in] - to be added to</param>
///  <param name="sa2">[in] - append to sa1</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayJoin(
				 Sarray sa1, 
				 Sarray sa2){

if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}
		if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}
	int _Result = Natives.sarrayJoin(sa1.Pointer, sa2.Pointer);
	
	return _Result;
}

// sarray1.c (920, 1)
// sarrayAppendRange(sa1, sa2, start, end) as int
// sarrayAppendRange(SARRAY *, SARRAY *, l_int32, l_int32) as l_ok
///  <summary>
/// (1) Copies of the strings in sarray2 are added to sarray1.<para/>
/// 
/// (2) The [start ... end] range is truncated if necessary.<para/>
/// 
/// (3) Use end == -1 to append to the end of sa2.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayAppendRange/*"/>
///  <param name="sa1">[in] - to be added to</param>
///  <param name="sa2">[in] - append specified range of strings in sa2 to sa1</param>
///  <param name="start">[in] - index of first string of sa2 to append</param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayAppendRange(
				 Sarray sa1, 
				 Sarray sa2, 
				 int start, 
				 int _end_){

if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}
		if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}
	int _Result = Natives.sarrayAppendRange(sa1.Pointer, sa2.Pointer,   start,   _end_);
	
	return _Result;
}

// sarray1.c (972, 1)
// sarrayPadToSameSize(sa1, sa2, padstring) as int
// sarrayPadToSameSize(SARRAY *, SARRAY *, const char *) as l_ok
///  <summary>
/// (1) If two sarrays have different size, this adds enough
/// instances of %padstring to the smaller so that they are
/// the same size.  It is useful when two or more sarrays
/// are being sequenced in parallel, and it is necessary to
/// find a valid string at each index.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayPadToSameSize/*"/>
///  <param name="sa1">[in] - </param>
///  <param name="sa2">[in] - </param>
///  <param name="padstring">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayPadToSameSize(
				 Sarray sa1, 
				 Sarray sa2, 
				 String padstring){

if (sa1 == null) {throw new ArgumentNullException  ("sa1 cannot be Nothing");}
		if (sa2 == null) {throw new ArgumentNullException  ("sa2 cannot be Nothing");}
		if (padstring == null) {throw new ArgumentNullException  ("padstring cannot be Nothing");}
	int _Result = Natives.sarrayPadToSameSize(sa1.Pointer, sa2.Pointer,   padstring);
	
	return _Result;
}

// sarray1.c (1029, 1)
// sarrayConvertWordsToLines(sa, linesize) as Sarray
// sarrayConvertWordsToLines(SARRAY *, l_int32) as SARRAY *
///  <summary>
/// sarrayConvertWordsToLines()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayConvertWordsToLines/*"/>
///  <param name="sa">[in] - sa of individual words</param>
///  <param name="linesize">[in] - max num of chars in each line</param>
///   <returns>saout sa of formatted lines, or NULL on error This is useful for re-typesetting text to a specific maximum line length.  The individual words in the input sarray are concatenated into textlines.  An input word string of zero length is taken to be a paragraph separator.  Each time such a string is found, the current line is ended and a new line is also produced that contains just the string of zero length "".  When the output sarray of lines is eventually converted to a string with newlines typically appended to each line string, the empty strings are just converted to newlines, producing the visible paragraph separation. What happens when a word is larger than linesize? We write it out as a single line anyway!  Words preceding or following this long word are placed on lines preceding or following the line with the long word.  Why this choice? Long "words" found in text documents are typically URLs, and it's often desirable not to put newlines in the middle of a URL. The text display program e.g., text editor will typically wrap the long "word" to fit in the window.</returns>
public static Sarray sarrayConvertWordsToLines(
				 Sarray sa, 
				 int linesize){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.sarrayConvertWordsToLines(sa.Pointer,   linesize);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1098, 1)
// sarraySplitString(sa, str, separators) as int
// sarraySplitString(SARRAY *, const char *, const char *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarraySplitString/*"/>
///   <returns></returns>
public static int sarraySplitString(
				 Sarray sa, 
				 String str, 
				 String separators){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (str == null) {throw new ArgumentNullException  ("str cannot be Nothing");}
		if (separators == null) {throw new ArgumentNullException  ("separators cannot be Nothing");}
	IntPtr saPtr = IntPtr.Zero; if (sa != null) {saPtr = sa.Pointer;}

	int _Result = Natives.sarraySplitString(sa.Pointer,   str,   separators);
	
	return _Result;
}

// sarray1.c (1145, 1)
// sarraySelectBySubstring(sain, substr) as Sarray
// sarraySelectBySubstring(SARRAY *, const char *) as SARRAY *
///  <summary>
/// (1) This selects all strings in sain that have substr as a substring.
/// Note that we can't use strncmp() because we're looking for
/// a match to the substring anywhere within each filename.<para/>
/// 
/// (2) If substr == NULL, returns a copy of the sarray.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarraySelectBySubstring/*"/>
///  <param name="sain">[in] - input sarray</param>
///  <param name="substr">[in][optional] - substring for matching can be NULL</param>
///   <returns>saout output sarray, filtered with substring or NULL on error</returns>
public static Sarray sarraySelectBySubstring(
				 Sarray sain, 
				 String substr){

if (sain == null) {throw new ArgumentNullException  ("sain cannot be Nothing");}
	IntPtr _Result = Natives.sarraySelectBySubstring(sain.Pointer,   substr);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1191, 1)
// sarraySelectByRange(sain, first, last) as Sarray
// sarraySelectByRange(SARRAY *, l_int32, l_int32) as SARRAY *
///  <summary>
/// (1) This makes %saout consisting of copies of all strings in %sain
/// in the index set [first ... last].  Use %last == 0 to get all
/// strings from %first to the last string in the sarray.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarraySelectByRange/*"/>
///  <param name="sain">[in] - input sarray</param>
///  <param name="first">[in] - index of first string to be selected</param>
///  <param name="last">[in] - index of last string to be selected use 0 to go to the end of the sarray</param>
///   <returns>saout output sarray, or NULL on error</returns>
public static Sarray sarraySelectByRange(
				 Sarray sain, 
				 int first, 
				 int last){

if (sain == null) {throw new ArgumentNullException  ("sain cannot be Nothing");}
	IntPtr _Result = Natives.sarraySelectByRange(sain.Pointer,   first,   last);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1260, 1)
// sarrayParseRange(sa, start, pactualstart, pend, pnewstart, substr, loc) as int
// sarrayParseRange(SARRAY *, l_int32, l_int32 *, l_int32 *, l_int32 *, const char *, l_int32) as l_int32
///  <summary>
/// (1) This finds the range of the next set of strings in SA,
/// beginning the search at 'start', that does NOT have
/// the substring 'substr' either at the indicated location
/// in the string or anywhere in the string.  The input
/// variable 'loc' is the specified offset within the string
/// use -1 to indicate 'anywhere in the string'.<para/>
/// 
/// (2) Always check the return value to verify that a valid range
/// was found.<para/>
/// 
/// (3) If a valid range is not found, the values of actstart,
/// end and newstart are all set to the size of sa.<para/>
/// 
/// (4) If this is the last valid range, newstart returns the value n.
/// In use, this should be tested before calling the function.<para/>
/// 
/// (5) Usage example.  To find all the valid ranges in a file
/// where the invalid lines begin with two dashes, copy each
/// line in the file to a string in an sarray, and do:
/// start = 0
/// while (!sarrayParseRange(sa, start, [and]actstart, [and]end, [and]start,
/// "--", 0))
/// fprintf(stderr, "start = %d, end = %d\n", actstart, end)
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayParseRange/*"/>
///  <param name="sa">[in] - input sarray</param>
///  <param name="start">[in] - index to start range search</param>
///  <param name="pactualstart">[out] - index of actual start may be  is greater  'start'</param>
///  <param name="pend">[out] - index of end</param>
///  <param name="pnewstart">[out] - index of start of next range</param>
///  <param name="substr">[in] - substring for matching at beginning of string</param>
///  <param name="loc">[in] - byte offset within the string for the pattern use -1 if the location does not matter</param>
///   <returns>0 if valid range found 1 otherwise</returns>
public static int sarrayParseRange(
				 Sarray sa, 
				 int start, 
				out int pactualstart, 
				out int pend, 
				out int pnewstart, 
				 String substr, 
				 int loc){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
		if (substr == null) {throw new ArgumentNullException  ("substr cannot be Nothing");}
	int _Result = Natives.sarrayParseRange(sa.Pointer,   start, out  pactualstart, out  pend, out  pnewstart,   substr,   loc);
	
	return _Result;
}

// sarray1.c (1345, 1)
// sarrayRead(filename) as Sarray
// sarrayRead(const char *) as SARRAY *
///  <summary>
/// sarrayRead()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayRead/*"/>
///  <param name="filename">[in] - </param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayRead(
				 String filename){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	IntPtr _Result = Natives.sarrayRead(  filename);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1382, 1)
// sarrayReadStream(fp) as Sarray
// sarrayReadStream(FILE *) as SARRAY *
///  <summary>
/// (1) We store the size of each string along with the string.
/// The limit on the number of strings is 2^24.
/// The limit on the size of any string is 2^30 bytes.<para/>
/// 
/// (2) This allows a string to have embedded newlines.  By reading
/// the entire string, as determined by its size, we are
/// not affected by any number of embedded newlines.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayReadStream/*"/>
///  <param name="fp">[in] - file stream</param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayReadStream(
				 FILE fp){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
	IntPtr _Result = Natives.sarrayReadStream(fp.Pointer);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1449, 1)
// sarrayReadMem(data, size) as Sarray
// sarrayReadMem(const l_uint8 *, size_t) as SARRAY *
///  <summary>
/// sarrayReadMem()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayReadMem/*"/>
///  <param name="data">[in] - serialization in ascii</param>
///  <param name="size">[in] - of data can use strlen to get it</param>
///   <returns>sarray, or NULL on error</returns>
public static Sarray sarrayReadMem(
				 Byte[] data, 
				 uint size){

if (data == null) {throw new ArgumentNullException  ("data cannot be Nothing");}
	IntPtr _Result = Natives.sarrayReadMem(  data,   size);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1477, 1)
// sarrayWrite(filename, sa) as int
// sarrayWrite(const char *, SARRAY *) as l_ok
///  <summary>
/// sarrayWrite()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayWrite/*"/>
///  <param name="filename">[in] - </param>
///  <param name="sa">[in] - string array</param>
///   <returns>0 if OK 1 on error</returns>
public static int sarrayWrite(
				 String filename, 
				 Sarray sa){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayWrite(  filename, sa.Pointer);
	
	return _Result;
}

// sarray1.c (1514, 1)
// sarrayWriteStream(fp, sa) as int
// sarrayWriteStream(FILE *, SARRAY *) as l_ok
///  <summary>
/// (1) This appends a '\n' to each string, which is stripped
/// off by sarrayReadStream().
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayWriteStream/*"/>
///  <param name="fp">[in] - file stream</param>
///  <param name="sa">[in] - string array</param>
///   <returns>0 if OK 1 on error</returns>
public static int sarrayWriteStream(
				 FILE fp, 
				 Sarray sa){

if (fp == null) {throw new ArgumentNullException  ("fp cannot be Nothing");}
		if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	int _Result = Natives.sarrayWriteStream(fp.Pointer, sa.Pointer);
	
	return _Result;
}

// sarray1.c (1553, 1)
// sarrayWriteMem(pdata, psize, sa) as int
// sarrayWriteMem(l_uint8 **, size_t *, SARRAY *) as l_ok
///  <summary>
/// (1) Serializes a sarray in memory and puts the result in a buffer.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayWriteMem/*"/>
///  <param name="pdata">[out] - data of serialized sarray ascii</param>
///  <param name="psize">[out] - size of returned data</param>
///  <param name="sa">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int sarrayWriteMem(
				out Byte[] pdata, 
				out uint psize, 
				 Sarray sa){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr pdataPtr = IntPtr.Zero;

	int _Result = Natives.sarrayWriteMem(out  pdataPtr, out  psize, sa.Pointer);
	
	Byte[] pdataGen = new Byte[psize];
	if (pdataPtr != IntPtr.Zero) {
	  Marshal.Copy(pdataPtr, pdataGen, 0, pdataGen.Length);
	}
	pdata = pdataGen;
	return _Result;
}

// sarray1.c (1601, 1)
// sarrayAppend(filename, sa) as int
// sarrayAppend(const char *, SARRAY *) as l_ok
///  <summary>
/// sarrayAppend()
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sarrayAppend/*"/>
///  <param name="filename">[in] - </param>
///  <param name="sa">[in] - </param>
///   <returns>0 if OK 1 on error</returns>
public static int sarrayAppend(
				 String filename, 
				 Sarray sa){

if (filename == null) {throw new ArgumentNullException  ("filename cannot be Nothing");}
		if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
if (File.Exists (filename) == false) {   throw new ArgumentException ("File is missing");};
	int _Result = Natives.sarrayAppend(  filename, sa.Pointer);
	
	return _Result;
}

// sarray1.c (1669, 1)
// getNumberedPathnamesInDirectory(dirname, substr, numpre, numpost, maxnum) as Sarray
// getNumberedPathnamesInDirectory(const char *, const char *, l_int32, l_int32, l_int32) as SARRAY *
///  <summary>
/// (1) Returns the full pathnames of the numbered filenames in
/// the directory.  The number in the filename is the index
/// into the sarray.  For indices for which there are no filenames,
/// an empty string ("") is placed into the sarray.
/// This makes reading numbered files very simple.  For example,
/// the image whose filename includes number N can be retrieved using
/// pixReadIndexed(sa, N)<para/>
/// 
/// (2) If %substr is not NULL, only filenames that contain
/// the substring can be included.  If %substr is NULL,
/// all matching filenames are used.<para/>
/// 
/// (3) If no numbered files are found, it returns an empty sarray,
/// with no initialized strings.<para/>
/// 
/// (4) It is assumed that the page number is contained within
/// the basename (the filename without directory or extension).
/// %numpre is the number of characters in the basename
/// preceding the actual page number %numpost is the number
/// following the page number, up to either the end of the
/// basename or a ".", whichever comes first.<para/>
/// 
/// (5) This is useful when all filenames contain numbers that are
/// not necessarily consecutive.  0-padding is not required.<para/>
/// 
/// (6) To use a O(n) matching algorithm, the largest page number
/// is found and two internal arrays of this size are created.
/// This maximum is constrained not to exceed %maxsum,
/// to make sure that an unrealistically large number is not
/// accidentally used to determine the array sizes.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getNumberedPathnamesInDirectory/*"/>
///  <param name="dirname">[in] - directory name</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="numpre">[in] - number of characters in name before number</param>
///  <param name="numpost">[in] - number of characters in name after the number, up to a dot before an extension</param>
///  <param name="maxnum">[in] - only consider page numbers up to this value</param>
///   <returns>sarray of numbered pathnames, or NULL on error</returns>
public static Sarray getNumberedPathnamesInDirectory(
				 String dirname, 
				 String substr, 
				 int numpre, 
				 int numpost, 
				 int maxnum){

if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}
	IntPtr _Result = Natives.getNumberedPathnamesInDirectory(  dirname,   substr,   numpre,   numpost,   maxnum);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1717, 1)
// getSortedPathnamesInDirectory(dirname, substr, first, nfiles) as Sarray
// getSortedPathnamesInDirectory(const char *, const char *, l_int32, l_int32) as SARRAY *
///  <summary>
/// (1) Use %substr to filter filenames in the directory.  If
/// %substr == NULL, this takes all files.<para/>
/// 
/// (2) The files in the directory, after optional filtering by
/// the substring, are lexically sorted in increasing order.
/// Use %first and %nfiles to select a contiguous set of files.<para/>
/// 
/// (3) The full pathnames are returned for the requested sequence.
/// If no files are found after filtering, returns an empty sarray.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getSortedPathnamesInDirectory/*"/>
///  <param name="dirname">[in] - directory name</param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="first">[in] - 0-based</param>
///  <param name="nfiles">[in] - use 0 for all to the end</param>
///   <returns>sarray of sorted pathnames, or NULL on error</returns>
public static Sarray getSortedPathnamesInDirectory(
				 String dirname, 
				 String substr, 
				 int first, 
				 int nfiles){

if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}
	IntPtr _Result = Natives.getSortedPathnamesInDirectory(  dirname,   substr,   first,   nfiles);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1777, 1)
// convertSortedToNumberedPathnames(sa, numpre, numpost, maxnum) as Sarray
// convertSortedToNumberedPathnames(SARRAY *, l_int32, l_int32, l_int32) as SARRAY *
///  <summary>
/// (1) Typically, numpre = numpost = 0 e.g., when the filename
/// just has a number followed by an optional extension.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertSortedToNumberedPathnames/*"/>
///  <param name="sa">[in] - sorted pathnames including zero-padded integers</param>
///  <param name="numpre">[in] - number of characters in name before number</param>
///  <param name="numpost">[in] - number of characters in name after the number, up to a dot before an extension</param>
///  <param name="maxnum">[in] - only consider page numbers up to this value</param>
///   <returns>sarray of numbered pathnames, or NULL on error</returns>
public static Sarray convertSortedToNumberedPathnames(
				 Sarray sa, 
				 int numpre, 
				 int numpost, 
				 int maxnum){

if (sa == null) {throw new ArgumentNullException  ("sa cannot be Nothing");}
	IntPtr _Result = Natives.convertSortedToNumberedPathnames(sa.Pointer,   numpre,   numpost,   maxnum);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}

// sarray1.c (1917, 1)
// getFilenamesInDirectory(dirname) as Sarray
// getFilenamesInDirectory(const char *) as SARRAY *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getFilenamesInDirectory/*"/>
///   <returns></returns>
public static Sarray getFilenamesInDirectory(
				 String dirname){

if (dirname == null) {throw new ArgumentNullException  ("dirname cannot be Nothing");}
	IntPtr _Result = Natives.getFilenamesInDirectory(  dirname);
	
	if (_Result == IntPtr.Zero) {return null;}
	return  new Sarray(_Result);
}


}
}

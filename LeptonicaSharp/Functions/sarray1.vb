Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\sarray1.c (163, 1)
' sarrayCreate()
' sarrayCreate(l_int32) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of string ptr array to be alloc'd use 0 for default</param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayCreate(
				ByVal n as Integer) as Sarray



	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayCreate( n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (193, 1)
' sarrayCreateInitialized()
' sarrayCreateInitialized(l_int32, const char *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="n">[in] - size of string ptr array to be alloc'd</param>
'''  <param name="initstr">[in] - string to be initialized on the full array</param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayCreateInitialized(
				ByVal n as Integer, 
				ByVal initstr as String) as Sarray

	If IsNothing (initstr) then Throw New ArgumentNullException  ("initstr cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayCreateInitialized( n, initstr)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (226, 1)
' sarrayCreateWordsFromString()
' sarrayCreateWordsFromString(const char *) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the number of word substrings, creates an sarray<para/>
''' of this size, and puts copies of each substring into the sarray.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayCreateWordsFromString(
				ByVal _string_ as String) as Sarray

	If IsNothing (_string_) then Throw New ArgumentNullException  ("_string_ cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayCreateWordsFromString( _string_)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (276, 1)
' sarrayCreateLinesFromString()
' sarrayCreateLinesFromString(const char *, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the number of line substrings, each of which<para/>
''' ends with a newline, and puts a copy of each substring<para/>
''' in a new sarray.<para/>
''' (2) The newline characters are removed from each substring.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="blankflag">[in] - 0 to exclude blank lines 1 to include</param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayCreateLinesFromString(
				ByVal _string_ as String, 
				ByVal blankflag as Integer) as Sarray

	If IsNothing (_string_) then Throw New ArgumentNullException  ("_string_ cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayCreateLinesFromString( _string_, blankflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (355, 1)
' sarrayDestroy()
' sarrayDestroy(SARRAY **) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Decrements the ref count and, if 0, destroys the sarray.<para/>
''' (2) Always nulls the input ptr.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="psa">[in,out] - to be nulled</param>
Public Shared Sub sarrayDestroy(
				ByRef psa as Sarray)


	Dim psaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(psa) Then psaPTR = psa.Pointer

	LeptonicaSharp.Natives.sarrayDestroy( psaPTR)
	if psaPTR <> IntPtr.Zero then psa = new Sarray(psaPTR)

End Sub

' SRC\sarray1.c (393, 1)
' sarrayCopy()
' sarrayCopy(SARRAY *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''   <returns>copy of sarray, or NULL on error</returns>
Public Shared Function sarrayCopy(
				ByVal sa as Sarray) as Sarray

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayCopy( sa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (420, 1)
' sarrayClone()
' sarrayClone(SARRAY *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''   <returns>ptr to same sarray, or NULL on error</returns>
Public Shared Function sarrayClone(
				ByVal sa as Sarray) as Sarray

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayClone( sa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (446, 1)
' sarrayAddString()
' sarrayAddString(SARRAY *, const char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See usage comments at the top of this file.  L_INSERT is<para/>
''' equivalent to L_NOCOPY.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="copyflag">[in] - L_INSERT, L_NOCOPY or L_COPY</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayAddString(
				ByVal sa as Sarray, 
				ByVal _string_ as String, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (_string_) then Throw New ArgumentNullException  ("_string_ cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayAddString( sa.Pointer, _string_, copyflag)

	Return _Result
End Function

' SRC\sarray1.c (506, 1)
' sarrayRemoveString()
' sarrayRemoveString(SARRAY *, l_int32) as char *
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="index">[in] - of string within sarray</param>
'''   <returns>removed string, or NULL on error</returns>
Public Shared Function sarrayRemoveString(
				ByVal sa as Sarray, 
				ByVal index as Integer) as String

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.sarrayRemoveString( sa.Pointer, index)

	Return _Result
End Function

' SRC\sarray1.c (557, 1)
' sarrayReplaceString()
' sarrayReplaceString(SARRAY *, l_int32, char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This destroys an existing string and replaces it with<para/>
''' the new string or a copy of it.<para/>
''' (2) By design, an sarray is always compacted, so there are<para/>
''' never any holes (null ptrs) in the ptr array up to the<para/>
''' current count.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="index">[in] - of string within sarray to be replaced</param>
'''  <param name="newstr">[in] - string to replace existing one</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayReplaceString(
				ByVal sa as Sarray, 
				ByVal index as Integer, 
				ByVal newstr as String, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (newstr) then Throw New ArgumentNullException  ("newstr cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayReplaceString( sa.Pointer, index, newstr, copyflag)

	Return _Result
End Function

' SRC\sarray1.c (594, 1)
' sarrayClear()
' sarrayClear(SARRAY *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function sarrayClear(
				ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayClear( sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (621, 1)
' sarrayGetCount()
' sarrayGetCount(SARRAY *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''   <returns>count, or 0 if no strings or on error</returns>
Public Shared Function sarrayGetCount(
				ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayGetCount( sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (646, 1)
' sarrayGetArray()
' sarrayGetArray(SARRAY *, l_int32 *, l_int32 *) as char **
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Caution: the returned array is not a copy, so caller<para/>
''' must not destroy it!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="pnalloc">[out][optional] - number allocated string ptrs</param>
'''  <param name="pn">[out][optional] - number allocated strings</param>
'''   <returns>ptr to string array, or NULL on error</returns>
Public Shared Function sarrayGetArray(
				ByVal sa as Sarray, 
				ByRef pnalloc as Integer, 
				ByRef pn as Integer) as String()

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayGetArray( sa.Pointer, pnalloc, pn)
Dim PTRARR(pnalloc-1) As IntPtr : Marshal.Copy(_Result, PTRARR, 0, PTRARR.Length)
Dim BLST As New List(Of String) : For Each eintrag In PTRARR : BLST.Add(Marshal.PtrToStringAnsi(eintrag)) : Next
Dim B As String() = BLST.toArray()

	Return B
End Function

' SRC\sarray1.c (681, 1)
' sarrayGetString()
' sarrayGetString(SARRAY *, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See usage comments at the top of this file.<para/>
''' (2) To get a pointer to the string itself, use L_NOCOPY.<para/>
''' To get a copy of the string, use L_COPY.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="index">[in] - to the index-th string</param>
'''  <param name="copyflag">[in] - L_NOCOPY or L_COPY</param>
'''   <returns>string, or NULL on error</returns>
Public Shared Function sarrayGetString(
				ByVal sa as Sarray, 
				ByVal index as Integer, 
				ByVal copyflag as Enumerations.L_access_storage) as String

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.sarrayGetString( sa.Pointer, index, copyflag)

	Return _Result
End Function

' SRC\sarray1.c (708, 1)
' sarrayGetRefCount()
' sarrayGetRefcount(SARRAY *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''   <returns>refcount, or UNDEF on error</returns>
Public Shared Function sarrayGetRefcount(
				ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayGetRefcount( sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (726, 1)
' sarrayChangeRefCount()
' sarrayChangeRefcount(SARRAY *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="delta">[in] - change to be applied</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayChangeRefcount(
				ByVal sa as Sarray, 
				ByVal delta as Integer) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayChangeRefcount( sa.Pointer, delta)

	Return _Result
End Function

' SRC\sarray1.c (763, 1)
' sarrayToString()
' sarrayToString(SARRAY *, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Concatenates all the strings in the sarray, preserving<para/>
''' all white space.<para/>
''' (2) If addnlflag != 0, adds either a '\n' or a ' ' after<para/>
''' each substring.<para/>
''' (3) This function was NOT implemented as:<para/>
''' for (i = 0 i  is lower  n i++)<para/>
''' strcat(dest, sarrayGetString(sa, i, L_NOCOPY))<para/>
''' Do you see why?<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="addnlflag">[in] - flag: 0 adds nothing to each substring 1 adds '\n' to each substring 2 adds ' ' to each substring</param>
'''   <returns>dest string, or NULL on error</returns>
Public Shared Function sarrayToString(
				ByVal sa as Sarray, 
				ByVal addnlflag as Integer) as String

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.sarrayToString( sa.Pointer, addnlflag)

	Return _Result
End Function

' SRC\sarray1.c (798, 1)
' sarrayToStringRange()
' sarrayToStringRange(SARRAY *, l_int32, l_int32, l_int32) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Concatenates the specified strings inthe sarray, preserving<para/>
''' all white space.<para/>
''' (2) If addnlflag != 0, adds either a '\n' or a ' ' after<para/>
''' each substring.<para/>
''' (3) If the sarray is empty, this returns a string with just<para/>
''' the character corresponding to %addnlflag.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array</param>
'''  <param name="first">[in] - index of first string to use starts with 0</param>
'''  <param name="nstrings">[in] - number of strings to append into the result use 0 to append to the end of the sarray</param>
'''  <param name="addnlflag">[in] - flag: 0 adds nothing to each substring 1 adds '\n' to each substring 2 adds ' ' to each substring</param>
'''   <returns>dest string, or NULL on error</returns>
Public Shared Function sarrayToStringRange(
				ByVal sa as Sarray, 
				ByVal first as Integer, 
				ByVal nstrings as Integer, 
				ByVal addnlflag as Integer) as String

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.sarrayToStringRange( sa.Pointer, first, nstrings, addnlflag)

	Return _Result
End Function

' SRC\sarray1.c (880, 1)
' sarrayJoin()
' sarrayJoin(SARRAY *, SARRAY *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Copies of the strings in sarray2 are added to sarray1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa1">[in] - to be added to</param>
'''  <param name="sa2">[in] - append to sa1</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayJoin(
				ByVal sa1 as Sarray, 
				ByVal sa2 as Sarray) as Integer

	If IsNothing (sa1) then Throw New ArgumentNullException  ("sa1 cannot be Nothing")
	If IsNothing (sa2) then Throw New ArgumentNullException  ("sa2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayJoin( sa1.Pointer, sa2.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (920, 1)
' sarrayAppendRange()
' sarrayAppendRange(SARRAY *, SARRAY *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Copies of the strings in sarray2 are added to sarray1.<para/>
''' (2) The [start ... end] range is truncated if necessary.<para/>
''' (3) Use end == -1 to append to the end of sa2.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa1">[in] - to be added to</param>
'''  <param name="sa2">[in] - append specified range of strings in sa2 to sa1</param>
'''  <param name="start">[in] - index of first string of sa2 to append</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayAppendRange(
				ByVal sa1 as Sarray, 
				ByVal sa2 as Sarray, 
				ByVal start as Integer, 
				ByVal _end_ as Integer) as Integer

	If IsNothing (sa1) then Throw New ArgumentNullException  ("sa1 cannot be Nothing")
	If IsNothing (sa2) then Throw New ArgumentNullException  ("sa2 cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayAppendRange( sa1.Pointer, sa2.Pointer, start, _end_)

	Return _Result
End Function

' SRC\sarray1.c (972, 1)
' sarrayPadToSameSize()
' sarrayPadToSameSize(SARRAY *, SARRAY *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If two sarrays have different size, this adds enough<para/>
''' instances of %padstring to the smaller so that they are<para/>
''' the same size.  It is useful when two or more sarrays<para/>
''' are being sequenced in parallel, and it is necessary to<para/>
''' find a valid string at each index.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa1">[in] - </param>
'''  <param name="sa2">[in] - </param>
'''  <param name="padstring">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayPadToSameSize(
				ByVal sa1 as Sarray, 
				ByVal sa2 as Sarray, 
				ByVal padstring as String) as Integer

	If IsNothing (sa1) then Throw New ArgumentNullException  ("sa1 cannot be Nothing")
	If IsNothing (sa2) then Throw New ArgumentNullException  ("sa2 cannot be Nothing")
	If IsNothing (padstring) then Throw New ArgumentNullException  ("padstring cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayPadToSameSize( sa1.Pointer, sa2.Pointer, padstring)

	Return _Result
End Function

' SRC\sarray1.c (1029, 1)
' sarrayConvertWordsToLines()
' sarrayConvertWordsToLines(SARRAY *, l_int32) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - sa of individual words</param>
'''  <param name="linesize">[in] - max num of chars in each line</param>
'''   <returns>saout sa of formatted lines, or NULL on error This is useful for re-typesetting text to a specific maximum line length.  The individual words in the input sarray are concatenated into textlines.  An input word string of zero length is taken to be a paragraph separator.  Each time such a string is found, the current line is ended and a new line is also produced that contains just the string of zero length "".  When the output sarray of lines is eventually converted to a string with newlines typically appended to each line string, the empty strings are just converted to newlines, producing the visible paragraph separation. What happens when a word is larger than linesize? We write it out as a single line anyway!  Words preceding or following this long word are placed on lines preceding or following the line with the long word.  Why this choice? Long "words" found in text documents are typically URLs, and it's often desirable not to put newlines in the middle of a URL. The text display program e.g., text editor will typically wrap the long "word" to fit in the window.</returns>
Public Shared Function sarrayConvertWordsToLines(
				ByVal sa as Sarray, 
				ByVal linesize as Integer) as Sarray

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayConvertWordsToLines( sa.Pointer, linesize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1098, 1)
' 
' sarraySplitString(SARRAY *, const char *, const char *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function sarraySplitString(
				ByVal sa as Sarray, 
				ByVal str as String, 
				ByVal separators as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")
	If IsNothing (separators) then Throw New ArgumentNullException  ("separators cannot be Nothing")

Dim saPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sa) Then saPTR = sa.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.sarraySplitString( sa.Pointer, str, separators)

	Return _Result
End Function

' SRC\sarray1.c (1145, 1)
' sarraySelectBySubstring()
' sarraySelectBySubstring(SARRAY *, const char *) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This selects all strings in sain that have substr as a substring.<para/>
''' Note that we can't use strncmp() because we're looking for<para/>
''' a match to the substring anywhere within each filename.<para/>
''' (2) If substr == NULL, returns a copy of the sarray.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sain">[in] - input sarray</param>
'''  <param name="substr">[in][optional] - substring for matching can be NULL</param>
'''   <returns>saout output sarray, filtered with substring or NULL on error</returns>
Public Shared Function sarraySelectBySubstring(
				ByVal sain as Sarray, 
				ByVal substr as String) as Sarray

	If IsNothing (sain) then Throw New ArgumentNullException  ("sain cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarraySelectBySubstring( sain.Pointer, substr)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1191, 1)
' sarraySelectByRange()
' sarraySelectByRange(SARRAY *, l_int32, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This makes %saout consisting of copies of all strings in %sain<para/>
''' in the index set [first ... last].  Use %last == 0 to get all<para/>
''' strings from %first to the last string in the sarray.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sain">[in] - input sarray</param>
'''  <param name="first">[in] - index of first string to be selected</param>
'''  <param name="last">[in] - index of last string to be selected use 0 to go to the end of the sarray</param>
'''   <returns>saout output sarray, or NULL on error</returns>
Public Shared Function sarraySelectByRange(
				ByVal sain as Sarray, 
				ByVal first as Integer, 
				ByVal last as Integer) as Sarray

	If IsNothing (sain) then Throw New ArgumentNullException  ("sain cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarraySelectByRange( sain.Pointer, first, last)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1260, 1)
' sarrayParseRange()
' sarrayParseRange(SARRAY *, l_int32, l_int32 *, l_int32 *, l_int32 *, const char *, l_int32) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the range of the next set of strings in SA,<para/>
''' beginning the search at 'start', that does NOT have<para/>
''' the substring 'substr' either at the indicated location<para/>
''' in the string or anywhere in the string.  The input<para/>
''' variable 'loc' is the specified offset within the string<para/>
''' use -1 to indicate 'anywhere in the string'.<para/>
''' (2) Always check the return value to verify that a valid range<para/>
''' was found.<para/>
''' (3) If a valid range is not found, the values of actstart,<para/>
''' end and newstart are all set to the size of sa.<para/>
''' (4) If this is the last valid range, newstart returns the value n.<para/>
''' In use, this should be tested before calling the function.<para/>
''' (5) Usage example.  To find all the valid ranges in a file<para/>
''' where the invalid lines begin with two dashes, copy each<para/>
''' line in the file to a string in an sarray, and do:<para/>
''' start = 0<para/>
''' while (!sarrayParseRange(sa, start,  and actstart,  and end,  and start,<para/>
''' "--", 0))<para/>
''' fprintf(stderr, "start = %d, end = %d\n", actstart, end)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - input sarray</param>
'''  <param name="start">[in] - index to start range search</param>
'''  <param name="pactualstart">[out] - index of actual start may be  is greater  'start'</param>
'''  <param name="pend">[out] - index of end</param>
'''  <param name="pnewstart">[out] - index of start of next range</param>
'''  <param name="substr">[in] - substring for matching at beginning of string</param>
'''  <param name="loc">[in] - byte offset within the string for the pattern use -1 if the location does not matter</param>
'''   <returns>0 if valid range found 1 otherwise</returns>
Public Shared Function sarrayParseRange(
				ByVal sa as Sarray, 
				ByVal start as Integer, 
				ByRef pactualstart as Integer, 
				ByRef pend as Integer, 
				ByRef pnewstart as Integer, 
				ByVal substr as String, 
				ByVal loc as Integer) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (substr) then Throw New ArgumentNullException  ("substr cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayParseRange( sa.Pointer, start, pactualstart, pend, pnewstart, substr, loc)

	Return _Result
End Function

' SRC\sarray1.c (1345, 1)
' sarrayRead()
' sarrayRead(const char *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayRead(
				ByVal filename as String) as Sarray

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayRead( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1382, 1)
' sarrayReadStream()
' sarrayReadStream(FILE *) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We store the size of each string along with the string.<para/>
''' The limit on the number of strings is 2^24.<para/>
''' The limit on the size of any string is 2^30 bytes.<para/>
''' (2) This allows a string to have embedded newlines.  By reading<para/>
''' the entire string, as determined by its size, we are<para/>
''' not affected by any number of embedded newlines.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayReadStream(
				ByVal fp as FILE) as Sarray

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayReadStream( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1449, 1)
' sarrayReadMem()
' sarrayReadMem(const l_uint8 *, size_t) as SARRAY *
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - serialization in ascii</param>
'''  <param name="size">[in] - of data can use strlen to get it</param>
'''   <returns>sarray, or NULL on error</returns>
Public Shared Function sarrayReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Sarray

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.sarrayReadMem( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1477, 1)
' sarrayWrite()
' sarrayWrite(const char *, SARRAY *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="sa">[in] - string array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function sarrayWrite(
				ByVal filename as String, 
				ByVal sa as Sarray) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayWrite( filename, sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (1514, 1)
' sarrayWriteStream()
' sarrayWriteStream(FILE *, SARRAY *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This appends a '\n' to each string, which is stripped<para/>
''' off by sarrayReadStream().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="sa">[in] - string array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function sarrayWriteStream(
				ByVal fp as FILE, 
				ByVal sa as Sarray) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayWriteStream( fp.Pointer, sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (1553, 1)
' sarrayWriteMem()
' sarrayWriteMem(l_uint8 **, size_t *, SARRAY *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Serializes a sarray in memory and puts the result in a buffer.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of serialized sarray ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="sa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sarrayWriteMem(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal sa as Sarray) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayWriteMem( pdataPTR, psize, sa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\sarray1.c (1601, 1)
' sarrayAppend()
' sarrayAppend(const char *, SARRAY *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="sa">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function sarrayAppend(
				ByVal filename as String, 
				ByVal sa as Sarray) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.sarrayAppend( filename, sa.Pointer)

	Return _Result
End Function

' SRC\sarray1.c (1669, 1)
' getNumberedPathnamesInDirectory()
' getNumberedPathnamesInDirectory(const char *, const char *, l_int32, l_int32, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Returns the full pathnames of the numbered filenames in<para/>
''' the directory.  The number in the filename is the index<para/>
''' into the sarray.  For indices for which there are no filenames,<para/>
''' an empty string ("") is placed into the sarray.<para/>
''' This makes reading numbered files very simple.  For example,<para/>
''' the image whose filename includes number N can be retrieved using<para/>
''' pixReadIndexed(sa, N)<para/>
''' (2) If %substr is not NULL, only filenames that contain<para/>
''' the substring can be included.  If %substr is NULL,<para/>
''' all matching filenames are used.<para/>
''' (3) If no numbered files are found, it returns an empty sarray,<para/>
''' with no initialized strings.<para/>
''' (4) It is assumed that the page number is contained within<para/>
''' the basename (the filename without directory or extension).<para/>
''' %numpre is the number of characters in the basename<para/>
''' preceding the actual page number %numpost is the number<para/>
''' following the page number, up to either the end of the<para/>
''' basename or a ".", whichever comes first.<para/>
''' (5) This is useful when all filenames contain numbers that are<para/>
''' not necessarily consecutive.  0-padding is not required.<para/>
''' (6) To use a O(n) matching algorithm, the largest page number<para/>
''' is found and two internal arrays of this size are created.<para/>
''' This maximum is constrained not to exceed %maxsum,<para/>
''' to make sure that an unrealistically large number is not<para/>
''' accidentally used to determine the array sizes.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="numpre">[in] - number of characters in name before number</param>
'''  <param name="numpost">[in] - number of characters in name after the number, up to a dot before an extension</param>
'''  <param name="maxnum">[in] - only consider page numbers up to this value</param>
'''   <returns>sarray of numbered pathnames, or NULL on error</returns>
Public Shared Function getNumberedPathnamesInDirectory(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal numpre as Integer, 
				ByVal numpost as Integer, 
				ByVal maxnum as Integer) as Sarray

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.getNumberedPathnamesInDirectory( dirname, substr, numpre, numpost, maxnum)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1717, 1)
' getSortedPathnamesInDirectory()
' getSortedPathnamesInDirectory(const char *, const char *, l_int32, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use %substr to filter filenames in the directory.  If<para/>
''' %substr == NULL, this takes all files.<para/>
''' (2) The files in the directory, after optional filtering by<para/>
''' the substring, are lexically sorted in increasing order.<para/>
''' Use %first and %nfiles to select a contiguous set of files.<para/>
''' (3) The full pathnames are returned for the requested sequence.<para/>
''' If no files are found after filtering, returns an empty sarray.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirname">[in] - directory name</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="first">[in] - 0-based</param>
'''  <param name="nfiles">[in] - use 0 for all to the end</param>
'''   <returns>sarray of sorted pathnames, or NULL on error</returns>
Public Shared Function getSortedPathnamesInDirectory(
				ByVal dirname as String, 
				ByVal substr as String, 
				ByVal first as Integer, 
				ByVal nfiles as Integer) as Sarray

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.getSortedPathnamesInDirectory( dirname, substr, first, nfiles)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1777, 1)
' convertSortedToNumberedPathnames()
' convertSortedToNumberedPathnames(SARRAY *, l_int32, l_int32, l_int32) as SARRAY *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Typically, numpre = numpost = 0 e.g., when the filename<para/>
''' just has a number followed by an optional extension.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - sorted pathnames including zero-padded integers</param>
'''  <param name="numpre">[in] - number of characters in name before number</param>
'''  <param name="numpost">[in] - number of characters in name after the number, up to a dot before an extension</param>
'''  <param name="maxnum">[in] - only consider page numbers up to this value</param>
'''   <returns>sarray of numbered pathnames, or NULL on error</returns>
Public Shared Function convertSortedToNumberedPathnames(
				ByVal sa as Sarray, 
				ByVal numpre as Integer, 
				ByVal numpost as Integer, 
				ByVal maxnum as Integer) as Sarray

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.convertSortedToNumberedPathnames( sa.Pointer, numpre, numpost, maxnum)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

' SRC\sarray1.c (1917, 1)
' 
' getFilenamesInDirectory(const char *) as SARRAY *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function getFilenamesInDirectory(
				ByVal dirname as String) as Sarray

	If IsNothing (dirname) then Throw New ArgumentNullException  ("dirname cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.getFilenamesInDirectory( dirname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sarray(_Result)
End Function

End Class

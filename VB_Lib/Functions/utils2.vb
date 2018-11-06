Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\utils2.c (205, 1)
' stringNew(src) as String
' stringNew(const char *) as char *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringNew/*"/>
'''  <param name="src">[in] - string</param>
'''   <returns>dest copy of src string, or NULL on error</returns>
Public Shared Function stringNew(
				 ByVal src as String) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringNew( src)

	Return _Result
End Function

' SRC\utils2.c (245, 1)
' stringCopy(dest, src, n) as Integer
' stringCopy(char *, const char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Relatively safe wrapper for strncpy, that checks the input,<para/>
''' and does not complain if %src is null or %n  is lower  1.<para/>
''' If %n  is lower  1, this is a no-op.<para/>
''' (2) %dest needs to be at least %n bytes in size.<para/>
''' (3) We don't call strncpy() because valgrind complains about<para/>
''' use of uninitialized values.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringCopy/*"/>
'''  <param name="dest">[in] - existing byte buffer</param>
'''  <param name="src">[in] - string [optional] can be null</param>
'''  <param name="n">[in] - max number of characters to copy</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringCopy(
				 ByVal dest as String, 
				 ByVal src as String, 
				 ByVal n as Integer) as Integer

	If IsNothing (dest) then Throw New ArgumentNullException  ("dest cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.stringCopy( dest, src, n)

	Return _Result
End Function

' SRC\utils2.c (282, 1)
' stringReplace(pdest, src) as Integer
' stringReplace(char **, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Frees any existing dest string<para/>
''' (2) Puts a copy of src string in the dest<para/>
''' (3) If either or both strings are null, does something reasonable.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringReplace/*"/>
'''  <param name="pdest">[out] - string copy</param>
'''  <param name="src">[in] - string [optional] can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function stringReplace(
				<Out()> ByRef pdest as String(), 
				 Optional ByVal src as String = Nothing) as Integer

Dim pdestPTR As IntPtr = pdestPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pdest.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringReplace( pdestPTR, src)

	Return _Result
End Function

' SRC\utils2.c (318, 1)
' stringLength(src, size) as Integer
' stringLength(const char *, size_t) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Safe implementation of strlen that only checks size bytes<para/>
''' for trailing NUL.<para/>
''' (2) Valid returned string lengths are between 0 and size - 1.<para/>
''' If size bytes are checked without finding a NUL byte, then<para/>
''' an error is indicated by returning size.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringLength/*"/>
'''  <param name="src">[in] - string can be null or NULL-terminated string</param>
'''  <param name="size">[in] - size of src buffer</param>
'''   <returns>length of src in bytes.</returns>
Public Shared Function stringLength(
				 ByVal src as String, 
				 ByVal size as UInteger) as Integer

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.stringLength( src, size)

	Return _Result
End Function

' SRC\utils2.c (359, 1)
' stringCat(dest, size, src) as Integer
' stringCat(char *, size_t, const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Alternative implementation of strncat, that checks the input,<para/>
''' is easier to use (since the size of the dest buffer is specified<para/>
''' rather than the number of bytes to copy), and does not complain<para/>
''' if %src is null.<para/>
''' (2) Never writes past end of dest.<para/>
''' (3) If it can't append src (an error), it does nothing.<para/>
''' (4) N.B. The order of 2nd and 3rd args is reversed from that in<para/>
''' strncat, as in the Windows function strcat_s().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringCat/*"/>
'''  <param name="dest">[in] - null-terminated byte buffer</param>
'''  <param name="size">[in] - size of dest</param>
'''  <param name="src">[in] - string can be null or NULL-terminated string</param>
'''   <returns>number of bytes added to dest -1 on error</returns>
Public Shared Function stringCat(
				 ByVal dest as String, 
				 ByVal size as UInteger, 
				 ByVal src as String) as Integer

	If IsNothing (dest) then Throw New ArgumentNullException  ("dest cannot be Nothing")
	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.stringCat( dest, size, src)

	Return _Result
End Function

' SRC\utils2.c (407, 1)
' stringConcatNew(first) as String
' stringConcatNew(const char *, ...) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The last arg in the list of strings must be NULL.<para/>
''' (2) Caller must free the returned string.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringConcatNew/*"/>
'''  <param name="first">[in] - first string in list</param>
'''   <returns>result new string concatenating the input strings, or NULL if first == NULL</returns>
Public Shared Function stringConcatNew(
				 ByVal first as String) as String

	If IsNothing (first) then Throw New ArgumentNullException  ("first cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringConcatNew( first)

	Return _Result
End Function

' SRC\utils2.c (454, 1)
' stringJoin(src1, src2) as String
' stringJoin(const char *, const char *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a safe version of strcat it makes a new string.<para/>
''' (2) It is not an error if either or both of the strings<para/>
''' are empty, or if either or both of the pointers are null.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringJoin/*"/>
'''  <param name="src1">[in] - string [optional] can be null</param>
'''  <param name="src2">[in] - string [optional] can be null</param>
'''   <returns>concatenated string, or NULL on error</returns>
Public Shared Function stringJoin(
				 ByVal src1 as String, 
				 ByVal src2 as String) as String

	Dim _Result as String = LeptonicaSharp.Natives.stringJoin( src1, src2)

	Return _Result
End Function

' SRC\utils2.c (509, 1)
' stringJoinIP(psrc1, src2) as Integer
' stringJoinIP(char **, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a safe in-place version of strcat.  The contents of<para/>
''' src1 is replaced by the concatenation of src1 and src2.<para/>
''' (2) It is not an error if either or both of the strings<para/>
''' are empty (""), or if the pointers to the strings (psrc1, src2)<para/>
''' are null.<para/>
''' (3) src1 should be initialized to null or an empty string<para/>
''' before the first call.  Use one of these:<para/>
''' char src1 = NULL<para/>
''' char src1 = stringNew("")<para/>
''' Then call with:<para/>
''' stringJoinIP( and src1, src2)<para/>
''' (4) This can also be implemented as a macro:<para/>
''' \code<para/>
''' #define stringJoinIP(src1, src2) \<para/>
''' {tmpstr = stringJoin((src1),(src2)) \<para/>
''' LEPT_FREE(src1) \<para/>
''' (src1) = tmpstr}<para/>
''' \endcode<para/>
''' (5) Another function to consider for joining many strings is<para/>
''' stringConcatNew().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringJoinIP/*"/>
'''  <param name="psrc1">[in,out] - string address of src1 cannot be on the stack</param>
'''  <param name="src2">[in] - string [optional] can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringJoinIP(
				 ByRef psrc1 as String(), 
				 Optional ByVal src2 as String = Nothing) as Integer

Dim psrc1PTR As IntPtr = psrc1PTR = Marshal.AllocHGlobal(Marshal.sizeOf(psrc1.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringJoinIP( psrc1PTR, src2)

	Return _Result
End Function

' SRC\utils2.c (533, 1)
' stringReverse(src) as String
' stringReverse(const char *) as char *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringReverse/*"/>
'''  <param name="src">[in] - string</param>
'''   <returns>dest newly-allocated reversed string</returns>
Public Shared Function stringReverse(
				 ByVal src as String) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringReverse( src)

	Return _Result
End Function

' SRC\utils2.c (585, 1)
' strtokSafe(cstr, seps, psaveptr) as String
' strtokSafe(char *, const char *, char **) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a thread-safe implementation of strtok.<para/>
''' (2) It has the same interface as strtok_r.<para/>
''' (3) It differs from strtok_r in usage in two respects:<para/>
''' (a) the input string is not altered<para/>
''' (b) each returned substring is newly allocated and must<para/>
''' be freed after use.<para/>
''' (4) Let me repeat that.  This is "safe" because the input<para/>
''' string is not altered and because each returned string<para/>
''' is newly allocated on the heap.<para/>
''' (5) It is here because, surprisingly, some C libraries don't<para/>
''' include strtok_r.<para/>
''' (6) Important usage points:<para/>
''' ~ Input the string to be parsed on the first invocation.<para/>
''' ~ Then input NULL after that the value returned in saveptr<para/>
''' is used in all subsequent calls.<para/>
''' (7) This is only slightly slower than strtok_r.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/strtokSafe/*"/>
'''  <param name="seps">[in] - a string of character separators</param>
'''  <param name="psaveptr">[out] - ptr to the next char after the last encountered separator</param>
'''   <returns>substr a new string that is copied from the previous saveptr up to but not including the next separator character, or NULL if end of cstr.</returns>
Public Shared Function strtokSafe(
				 ByVal _cstr_ as String, 
				 ByVal seps as String, 
				<Out()> ByRef psaveptr as String()) as String

	If IsNothing (_cstr_) then Throw New ArgumentNullException  ("_cstr_ cannot be Nothing")
	If IsNothing (seps) then Throw New ArgumentNullException  ("seps cannot be Nothing")

Dim psaveptrPTR As IntPtr = psaveptrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(psaveptr.toArray))

	Dim _Result as String = LeptonicaSharp.Natives.strtokSafe( _cstr_, seps, psaveptrPTR)

	Return _Result
End Function

' SRC\utils2.c (679, 1)
' stringSplitOnToken(cstr, seps, phead, ptail) as Integer
' stringSplitOnToken(char *, const char *, char **, char **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The input string is not altered all split parts are new strings.<para/>
''' (2) The split occurs around the first consecutive sequence of<para/>
''' tokens encountered.<para/>
''' (3) The head goes from the beginning of the string up to<para/>
''' but not including the first token found.<para/>
''' (4) The tail contains the second part of the string, starting<para/>
''' with the first char in that part that is NOT a token.<para/>
''' (5) If no separator token is found, 'head' contains a copy<para/>
''' of the input string and 'tail' is null.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringSplitOnToken/*"/>
'''  <param name="seps">[in] - a string of character separators</param>
'''  <param name="phead">[out] - ptr to copy of the input string, up to the first separator token encountered</param>
'''  <param name="ptail">[out] - ptr to copy of the part of the input string starting with the first non-separator character that occurs after the first separator is found</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringSplitOnToken(
				 ByVal _cstr_ as String, 
				 ByVal seps as String, 
				<Out()> ByRef phead as String(), 
				<Out()> ByRef ptail as String()) as Integer

	If IsNothing (_cstr_) then Throw New ArgumentNullException  ("_cstr_ cannot be Nothing")
	If IsNothing (seps) then Throw New ArgumentNullException  ("seps cannot be Nothing")

Dim pheadPTR As IntPtr = pheadPTR = Marshal.AllocHGlobal(Marshal.sizeOf(phead.toArray))
Dim ptailPTR As IntPtr = ptailPTR = Marshal.AllocHGlobal(Marshal.sizeOf(ptail.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringSplitOnToken( _cstr_, seps, pheadPTR, ptailPTR)

	Return _Result
End Function

' SRC\utils2.c (723, 1)
' stringCheckForChars(src, chars, pfound) as Integer
' stringCheckForChars(const char *, const char *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This can be used to sanitize an operation by checking for<para/>
''' special characters that don't belong in a string.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringCheckForChars/*"/>
'''  <param name="src">[in] - input string can be of zero length</param>
'''  <param name="chars">[in] - string of chars to be searched for in %src</param>
'''  <param name="pfound">[out] - 1 if any characters are found 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringCheckForChars(
				 ByVal src as String, 
				 ByVal chars as String, 
				<Out()> ByRef pfound as Integer) as Integer

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (chars) then Throw New ArgumentNullException  ("chars cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.stringCheckForChars( src, chars, pfound)

	Return _Result
End Function

' SRC\utils2.c (758, 1)
' stringRemoveChars(src, remchars) as String
' stringRemoveChars(const char *, const char *) as char *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringRemoveChars/*"/>
'''  <param name="src">[in] - input string can be of zero length</param>
'''  <param name="remchars">[in] - string of chars to be removed from src</param>
'''   <returns>dest string with specified chars removed, or NULL on error</returns>
Public Shared Function stringRemoveChars(
				 ByVal src as String, 
				 ByVal remchars as String) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (remchars) then Throw New ArgumentNullException  ("remchars cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringRemoveChars( src, remchars)

	Return _Result
End Function

' SRC\utils2.c (803, 1)
' stringFindSubstr(src, sub, ploc) as Integer
' stringFindSubstr(const char *, const char *, l_int32 *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a wrapper around strstr().<para/>
''' (2) Both %src and %sub must be defined, and %sub must have<para/>
''' length of at least 1.<para/>
''' (3) If the substring is not found and loc is returned, it has<para/>
''' the value -1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringFindSubstr/*"/>
'''  <param name="src">[in] - input string can be of zero length</param>
'''  <param name="ploc">[out][optional] - location of substring in src</param>
'''   <returns>1 if found 0 if not found or on error</returns>
Public Shared Function stringFindSubstr(
				 ByVal src as String, 
				 ByVal _sub_ as String, 
				<Out()> Optional ByRef ploc as Integer = Nothing) as Integer

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (_sub_) then Throw New ArgumentNullException  ("_sub_ cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.stringFindSubstr( src, _sub_, ploc)

	Return _Result
End Function

' SRC\utils2.c (855, 1)
' stringReplaceSubstr(src, sub1, sub2, pfound, ploc) as String
' stringReplaceSubstr(const char *, const char *, const char *, l_int32 *, l_int32 *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Replaces the first instance.<para/>
''' (2) To only remove sub1, use "" for sub2<para/>
''' (3) Returns a new string if sub1 and sub2 are the same.<para/>
''' (4) The optional loc is input as the byte offset within the src<para/>
''' from which the search starts, and after the search it is the<para/>
''' char position in the string of the next character after<para/>
''' the substituted string.<para/>
''' (5) N.B. If ploc is not null, loc must always be initialized.<para/>
''' To search the string from the beginning, set loc = 0.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringReplaceSubstr/*"/>
'''  <param name="src">[in] - input string can be of zero length</param>
'''  <param name="sub1">[in] - substring to be replaced</param>
'''  <param name="sub2">[in] - substring to put in can be ""</param>
'''  <param name="pfound">[out][optional] - 1 if sub1 is found 0 otherwise</param>
'''  <param name="ploc">[out][optional] - location of ptr after replacement</param>
'''   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
Public Shared Function stringReplaceSubstr(
				 ByVal src as String, 
				 ByVal sub1 as String, 
				 ByVal sub2 as String, 
				<Out()> Optional ByRef pfound as Integer = Nothing, 
				<Out()> Optional ByRef ploc as Integer = Nothing) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (sub1) then Throw New ArgumentNullException  ("sub1 cannot be Nothing")
	If IsNothing (sub2) then Throw New ArgumentNullException  ("sub2 cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringReplaceSubstr( src, sub1, sub2, pfound, ploc)

	Return _Result
End Function

' SRC\utils2.c (922, 1)
' stringReplaceEachSubstr(src, sub1, sub2, pcount) as String
' stringReplaceEachSubstr(const char *, const char *, const char *, l_int32 *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Replaces every instance.<para/>
''' (2) To only remove each instance of sub1, use "" for sub2<para/>
''' (3) Returns NULL if sub1 and sub2 are the same.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/stringReplaceEachSubstr/*"/>
'''  <param name="src">[in] - input string can be of zero length</param>
'''  <param name="sub1">[in] - substring to be replaced</param>
'''  <param name="sub2">[in] - substring to put in can be ""</param>
'''  <param name="pcount">[out][optional] - the number of times that sub1 is found in src 0 if not found</param>
'''   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
Public Shared Function stringReplaceEachSubstr(
				 ByVal src as String, 
				 ByVal sub1 as String, 
				 ByVal sub2 as String, 
				<Out()> Optional ByRef pcount as Integer = Nothing) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (sub1) then Throw New ArgumentNullException  ("sub1 cannot be Nothing")
	If IsNothing (sub2) then Throw New ArgumentNullException  ("sub2 cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.stringReplaceEachSubstr( src, sub1, sub2, pcount)

	Return _Result
End Function

' SRC\utils2.c (977, 1)
' arrayFindEachSequence(data, datalen, sequence, seqlen) as L_Dna
' arrayFindEachSequence(const l_uint8 *, size_t, const l_uint8 *, size_t) as L_DNA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The byte arrays %data and %sequence are not C strings,<para/>
''' as they can contain null bytes.  Therefore, for each<para/>
''' we must give the length of the array.<para/>
''' (2) This finds every occurrence in %data of %sequence.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/arrayFindEachSequence/*"/>
'''  <param name="data">[in] - byte array</param>
'''  <param name="datalen">[in] - length of data, in bytes</param>
'''  <param name="sequence">[in] - subarray of bytes to find in data</param>
'''  <param name="seqlen">[in] - length of sequence, in bytes</param>
'''   <returns>dna of offsets where the sequence is found, or NULL if none are found or on error</returns>
Public Shared Function arrayFindEachSequence(
				 ByVal data as Byte(), 
				 ByVal datalen as UInteger, 
				 ByVal sequence as Byte(), 
				 ByVal seqlen as UInteger) as L_Dna

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.arrayFindEachSequence( data, datalen, sequence, seqlen)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Dna(_Result)
End Function

' SRC\utils2.c (1037, 1)
' arrayFindSequence(data, datalen, sequence, seqlen, poffset, pfound) as Integer
' arrayFindSequence(const l_uint8 *, size_t, const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The byte arrays 'data' and 'sequence' are not C strings,<para/>
''' as they can contain null bytes.  Therefore, for each<para/>
''' we must give the length of the array.<para/>
''' (2) This searches for the first occurrence in %data of %sequence,<para/>
''' which consists of %seqlen bytes.  The parameter %seqlen<para/>
''' must not exceed the actual length of the %sequence byte array.<para/>
''' (3) If the sequence is not found, the offset will be 0, so you<para/>
''' must check %found.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/arrayFindSequence/*"/>
'''  <param name="data">[in] - byte array</param>
'''  <param name="datalen">[in] - length of data, in bytes</param>
'''  <param name="sequence">[in] - subarray of bytes to find in data</param>
'''  <param name="seqlen">[in] - length of sequence, in bytes</param>
'''  <param name="poffset">[out] - offset from beginning of data where the sequence begins</param>
'''  <param name="pfound">[out] - 1 if sequence is found 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function arrayFindSequence(
				 ByVal data as Byte(), 
				 ByVal datalen as UInteger, 
				 ByVal sequence as Byte(), 
				 ByVal seqlen as UInteger, 
				<Out()> ByRef poffset as Integer, 
				<Out()> ByRef pfound as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.arrayFindSequence( data, datalen, sequence, seqlen, poffset, pfound)

	Return _Result
End Function

' SRC\utils2.c (1106, 1)
' reallocNew(pindata, oldsize, newsize) as Object
' reallocNew(void **, l_int32, l_int32) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If newsize  is lower =0, just frees input data and nulls ptr<para/>
''' (2) If input ptr is null, just callocs new memory<para/>
''' (3) This differs from realloc in that it always allocates<para/>
''' new memory (if newsize  is greater  0) and initializes it to 0,<para/>
''' it requires the amount of old data to be copied,<para/>
''' and it takes the address of the input ptr and<para/>
''' nulls the handle.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/reallocNew/*"/>
'''  <param name="pindata">[in,out][optional] - nulls indata</param>
'''  <param name="oldsize">[in] - size of input data to be copied, in bytes</param>
'''  <param name="newsize">[in] - size of data to be reallocated in bytes</param>
'''   <returns>ptr to new data, or NULL on error Action: !N.B. 3) and (4! 1 Allocates memory, initialized to 0 2 Copies as much of the input data as possible to the new block, truncating the copy if necessary 3 Frees the input data 4 Zeroes the input data ptr</returns>
Public Shared Function reallocNew(
				 ByRef pindata as IntPtr(), 
				 ByVal oldsize as Integer, 
				 ByVal newsize as Integer) as Object

Dim pindataPTR As IntPtr = IntPtr.Zero: if not isNothing (pindata) then pindataPTR = Marshal.AllocHGlobal(Marshal.SizeOf(pindata.toarray))

	Dim _Result as IntPtr = LeptonicaSharp.Natives.reallocNew( pindataPTR, oldsize, newsize)

	Return _Result
End Function

' SRC\utils2.c (1158, 1)
' l_binaryRead(filename, pnbytes) as Byte()
' l_binaryRead(const char *, size_t *) as l_uint8 *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryRead/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pnbytes">[out] - number of bytes read</param>
'''   <returns>data, or NULL on error</returns>
Public Shared Function l_binaryRead(
				 ByVal filename as String, 
				<Out()> ByRef pnbytes as UInteger) as Byte()

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryRead( filename, pnbytes)

	Return _Result
End Function

' SRC\utils2.c (1208, 1)
' l_binaryReadStream(fp, pnbytes) as Byte()
' l_binaryReadStream(FILE *, size_t *) as l_uint8 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned array is terminated with a null byte so that it can<para/>
''' be used to read ascii data from a file into a proper C string.<para/>
''' (2) This can be used to capture data that is piped in via stdin,<para/>
''' because it does not require seeking within the file.<para/>
''' (3) For example, you can read an image from stdin into memory<para/>
''' using shell redirection, with one of these shell commands:<para/>
''' \code<para/>
''' cat  is lower imagefile is greater  | readprog<para/>
''' readprog  is lower is lower imagefile is greater <para/>
''' \endcode<para/>
''' where readprog is:<para/>
''' \code<para/>
''' l_uint8 data = l_binaryReadStream(stdin,  and nbytes)<para/>
''' Pix pix = pixReadMem(data, nbytes)<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryReadStream/*"/>
'''  <param name="fp">[in] - file stream opened to read can be stdin</param>
'''  <param name="pnbytes">[out] - number of bytes read</param>
'''   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
Public Shared Function l_binaryReadStream(
				 ByVal fp as FILE, 
				<Out()> ByRef pnbytes as UInteger) as Byte()

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadStream( fp.Pointer, pnbytes)

	Return _Result
End Function

' SRC\utils2.c (1275, 1)
' l_binaryReadSelect(filename, start, nbytes, pnread) as Byte()
' l_binaryReadSelect(const char *, size_t, size_t, size_t *) as l_uint8 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned array is terminated with a null byte so that it can<para/>
''' be used to read ascii data from a file into a proper C string.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryReadSelect/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="start">[in] - first byte to read</param>
'''  <param name="nbytes">[in] - number of bytes to read use 0 to read to end of file</param>
'''  <param name="pnread">[out] - number of bytes actually read</param>
'''   <returns>data, or NULL on error</returns>
Public Shared Function l_binaryReadSelect(
				 ByVal filename as String, 
				 ByVal start as UInteger, 
				 ByVal nbytes as UInteger, 
				<Out()> ByRef pnread as UInteger) as Byte()

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadSelect( filename, start, nbytes, pnread)

	Return _Result
End Function

' SRC\utils2.c (1320, 1)
' l_binaryReadSelectStream(fp, start, nbytes, pnread) as Byte()
' l_binaryReadSelectStream(FILE *, size_t, size_t, size_t *) as l_uint8 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned array is terminated with a null byte so that it can<para/>
''' be used to read ascii data from a file into a proper C string.<para/>
''' If the file to be read is empty and %start == 0, an array<para/>
''' with a single null byte is returned.<para/>
''' (2) Side effect: the stream pointer is re-positioned to the<para/>
''' beginning of the file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryReadSelectStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="start">[in] - first byte to read</param>
'''  <param name="nbytes">[in] - number of bytes to read use 0 to read to end of file</param>
'''  <param name="pnread">[out] - number of bytes actually read</param>
'''   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
Public Shared Function l_binaryReadSelectStream(
				 ByVal fp as FILE, 
				 ByVal start as UInteger, 
				 ByVal nbytes as UInteger, 
				<Out()> ByRef pnread as UInteger) as Byte()

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadSelectStream( fp.Pointer, start, nbytes, pnread)

	Return _Result
End Function

' SRC\utils2.c (1375, 1)
' l_binaryWrite(filename, operation, data, nbytes) as Integer
' l_binaryWrite(const char *, const char *, const void *, size_t) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryWrite/*"/>
'''  <param name="filename">[in] - output</param>
'''  <param name="operation">[in] - "w" for write "a" for append</param>
'''  <param name="data">[in] - binary data to be written</param>
'''  <param name="nbytes">[in] - size of data array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function l_binaryWrite(
				 ByVal filename as String, 
				 ByVal operation as String, 
				 ByVal data as Object, 
				 ByVal nbytes as UInteger) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (operation) then Throw New ArgumentNullException  ("operation cannot be Nothing")
	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

Dim dataPTR As IntPtr = Marshal.AllocHGlobal(0)

	Dim _Result as Integer = LeptonicaSharp.Natives.l_binaryWrite( filename, operation, dataPTR, nbytes)

	Return _Result
End Function

' SRC\utils2.c (1417, 1)
' nbytesInFile(filename) as UInteger
' nbytesInFile(const char *) as size_t
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/nbytesInFile/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>nbytes in file 0 on error</returns>
Public Shared Function nbytesInFile(
				 ByVal filename as String) as UInteger

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as UInteger = LeptonicaSharp.Natives.nbytesInFile( filename)

	Return _Result
End Function

' SRC\utils2.c (1441, 1)
' fnbytesInFile(fp) as UInteger
' fnbytesInFile(FILE *) as size_t
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fnbytesInFile/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>nbytes in file 0 on error</returns>
Public Shared Function fnbytesInFile(
				 ByVal fp as FILE) as UInteger

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as UInteger = LeptonicaSharp.Natives.fnbytesInFile( fp.Pointer)

	Return _Result
End Function

' SRC\utils2.c (1479, 1)
' l_binaryCopy(datas, size) as Byte()
' l_binaryCopy(l_uint8 *, size_t) as l_uint8 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) We add 4 bytes to the zeroed output because in some cases<para/>
''' (e.g., string handling) it is important to have the data<para/>
''' be null terminated.  This guarantees that after the memcpy,<para/>
''' the result is automatically null terminated.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_binaryCopy/*"/>
'''  <param name="datas">[in] - </param>
'''  <param name="size">[in] - of data array</param>
'''   <returns>datad on heap, or NULL on error</returns>
Public Shared Function l_binaryCopy(
				 ByVal datas as Byte(), 
				 ByVal size as UInteger) as Byte()

	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")

	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryCopy( datas, size)

	Return _Result
End Function

' SRC\utils2.c (1507, 1)
' fileCopy(srcfile, newfile) as Integer
' fileCopy(const char *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fileCopy/*"/>
'''  <param name="srcfile">[in] - copy this file</param>
'''  <param name="newfile">[in] - to this file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fileCopy(
				 ByVal srcfile as String, 
				 ByVal newfile as String) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")
	If IsNothing (newfile) then Throw New ArgumentNullException  ("newfile cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fileCopy( srcfile, newfile)

	Return _Result
End Function

' SRC\utils2.c (1537, 1)
' fileConcatenate(srcfile, destfile) as Integer
' fileConcatenate(const char *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fileConcatenate/*"/>
'''  <param name="srcfile">[in] - file to append</param>
'''  <param name="destfile">[in] - file to add to</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fileConcatenate(
				 ByVal srcfile as String, 
				 ByVal destfile as String) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")
	If IsNothing (destfile) then Throw New ArgumentNullException  ("destfile cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fileConcatenate( srcfile, destfile)

	Return _Result
End Function

' SRC\utils2.c (1565, 1)
' fileAppendString(filename, str) as Integer
' fileAppendString(const char *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fileAppendString/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="str">[in] - string to append to file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function fileAppendString(
				 ByVal filename as String, 
				 ByVal str as String) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fileAppendString( filename, str)

	Return _Result
End Function

' SRC\utils2.c (1603, 1)
' fopenReadStream(filename) as FILE
' fopenReadStream(const char *) as FILE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This should be used whenever you want to run fopen() to<para/>
''' read from a stream.  Never call fopen() directory.<para/>
''' (2) This handles the temp directory pathname conversion on windows:<para/>
''' /tmp  == is greater [Windows Temp directory]<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fopenReadStream/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>stream, or NULL on error</returns>
Public Shared Function fopenReadStream(
				 ByVal filename as String) as FILE

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.fopenReadStream( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1646, 1)
' fopenWriteStream(filename, modestring) as FILE
' fopenWriteStream(const char *, const char *) as FILE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This should be used whenever you want to run fopen() to<para/>
''' write or append to a stream.  Never call fopen() directory.<para/>
''' (2) This handles the temp directory pathname conversion on windows:<para/>
''' /tmp  == is greater [Windows Temp directory]<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fopenWriteStream/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="modestring">[in] - </param>
'''   <returns>stream, or NULL on error</returns>
Public Shared Function fopenWriteStream(
				 ByVal filename as String, 
				 ByVal modestring as String) as FILE

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (modestring) then Throw New ArgumentNullException  ("modestring cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.fopenWriteStream( filename, modestring)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1680, 1)
' fopenReadFromMemory(data, size) as FILE
' fopenReadFromMemory(const l_uint8 *, size_t) as FILE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Work-around if fmemopen() not available.<para/>
''' (2) Windows tmpfile() writes into the root C:\ directory, which<para/>
''' requires admin privileges.  This also works around that.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fopenReadFromMemory/*"/>
'''  <param name="data">[in] - </param>
'''  <param name="size">[in] - </param>
'''   <returns>file stream, or NULL on error</returns>
Public Shared Function fopenReadFromMemory(
				 ByVal data as Byte(), 
				 ByVal size as UInteger) as FILE

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.fopenReadFromMemory( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1726, 1)
' fopenWriteWinTempfile() as FILE
' fopenWriteWinTempfile() as FILE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The Windows version of tmpfile() writes into the root<para/>
''' C:\ directory, which requires admin privileges.  This<para/>
''' function provides an alternative implementation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/fopenWriteWinTempfile/*"/>
'''   <returns>file stream, or NULL on error</returns>
Public Shared Function fopenWriteWinTempfile() as FILE

	Dim _Result as IntPtr = LeptonicaSharp.Natives.fopenWriteWinTempfile( )
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1784, 1)
' lept_fopen(filename, mode) as FILE
' lept_fopen(const char *, const char *) as FILE *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This must be used by any application that passes<para/>
''' a file handle to a leptonica Windows DLL.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_fopen/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="mode">[in] - same as for fopen() e.g., "rb"</param>
'''   <returns>stream or NULL on error</returns>
Public Shared Function lept_fopen(
				 ByVal filename as String, 
				 ByVal mode as String) as FILE

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (mode) then Throw New ArgumentNullException  ("mode cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lept_fopen( filename, mode)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1814, 1)
' lept_fclose(fp) as Integer
' lept_fclose(FILE *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This should be used by any application that accepts<para/>
''' a file handle generated by a leptonica Windows DLL.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_fclose/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lept_fclose(
				 ByVal fp as FILE) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_fclose( fp.Pointer)

	Return _Result
End Function

' SRC\utils2.c (1840, 1)
' lept_calloc(nmemb, size) as Object
' lept_calloc(size_t, size_t) as void *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For safety with windows DLLs, this can be used in conjunction<para/>
''' with lept_free() to avoid C-runtime boundary problems.<para/>
''' Just use these two functions throughout your application.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_calloc/*"/>
'''  <param name="nmemb">[in] - number of members</param>
'''  <param name="size">[in] - of each member</param>
'''   <returns>void ptr, or NULL on error</returns>
Public Shared Function lept_calloc(
				 ByVal nmemb as UInteger, 
				 ByVal size as UInteger) as Object

	Dim _Result as IntPtr = LeptonicaSharp.Natives.lept_calloc( nmemb, size)

	Return _Result
End Function

' SRC\utils2.c (1861, 1)
' lept_free(ptr) as Object
' lept_free(void *) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This should be used by any application that accepts<para/>
''' heap data allocated by a leptonica Windows DLL.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_free/*"/>
'''  <param name="ptr">[in] - </param>
Public Shared Sub lept_free(
				 ByVal ptr as Object)

	If IsNothing (ptr) then Throw New ArgumentNullException  ("ptr cannot be Nothing")

Dim ptrPTR As IntPtr = Marshal.AllocHGlobal(0)

	LeptonicaSharp.Natives.lept_free( ptrPTR)

End Sub

' SRC\utils2.c (1890, 1)
' lept_mkdir(subdir) as Integer
' lept_mkdir(const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %subdir is a partial path that can consist of one or more<para/>
''' directories.<para/>
''' (2) This makes any subdirectories of /tmp that are required.<para/>
''' (3) The root temp directory is:<para/>
''' /tmp  (unix)  [default]<para/>
''' [Temp]  (windows)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_mkdir/*"/>
'''  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_mkdir(
				 ByVal subdir as String) as Integer

	If IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_mkdir( subdir)

	Return _Result
End Function

' SRC\utils2.c (1967, 1)
' lept_rmdir(subdir) as Integer
' lept_rmdir(const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %subdir is a partial path that can consist of one or more<para/>
''' directories.<para/>
''' (2) This removes all files from the specified subdirectory of<para/>
''' the root temp directory:<para/>
''' /tmp  (unix)<para/>
''' [Temp]  (windows)<para/>
''' and then removes the subdirectory.<para/>
''' (3) The combination<para/>
''' lept_rmdir(subdir)<para/>
''' lept_mkdir(subdir)<para/>
''' is guaranteed to give you an empty subdirectory.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_rmdir/*"/>
'''  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rmdir(
				 ByVal subdir as String) as Integer

	If IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rmdir( subdir)

	Return _Result
End Function

' SRC\utils2.c (2041, 1)
' lept_direxists(dir, pexists) as Object
' lept_direxists(const char *, l_int32 *) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Always use unix pathname separators.<para/>
''' (2) By calling genPathname(), if the pathname begins with "/tmp"<para/>
''' this does an automatic directory translation on windows<para/>
''' to a path in the windows [Temp] directory:<para/>
''' "/tmp"  == is greater [Temp] (windows)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_direxists/*"/>
'''  <param name="dir">[in] - </param>
'''  <param name="pexists">[out] - 1 if it exists 0 otherwise</param>
Public Shared Sub lept_direxists(
				 ByVal dir as String, 
				<Out()> ByRef pexists as Integer)

	If IsNothing (dir) then Throw New ArgumentNullException  ("dir cannot be Nothing")

	LeptonicaSharp.Natives.lept_direxists( dir, pexists)

End Sub

' SRC\utils2.c (2099, 1)
' lept_rm_match(subdir, substr) as Integer
' lept_rm_match(const char *, const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes the matched files in /tmp or a subdirectory of /tmp.<para/>
''' Use NULL for %subdir if the files are in /tmp.<para/>
''' (2) If %substr == NULL, this removes all files in the directory.<para/>
''' If %substr == "" (empty), this removes no files.<para/>
''' If both %subdir == NULL and %substr == NULL, this removes<para/>
''' all files in /tmp.<para/>
''' (3) Use unix pathname separators.<para/>
''' (4) By calling genPathname(), if the pathname begins with "/tmp"<para/>
''' this does an automatic directory translation on windows<para/>
''' to a path in the windows [Temp] directory:<para/>
''' "/tmp"  == is greater [Temp] (windows)<para/>
''' (5) Error conditions:<para/>
''' returns -1 if the directory is not found<para/>
''' returns the number of files ( is greater  0) that it was unable to remove.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_rm_match/*"/>
'''  <param name="subdir">[in][optional] - If NULL, the removed files are in /tmp</param>
'''  <param name="substr">[in][optional] - pattern to match in filename</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rm_match(
				 ByVal subdir as String, 
				 ByVal substr as String) as Integer

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rm_match( subdir, substr)

	Return _Result
End Function

' SRC\utils2.c (2149, 1)
' lept_rm(subdir, tail) as Integer
' lept_rm(const char *, const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) By calling genPathname(), this does an automatic directory<para/>
''' translation on windows to a path in the windows [Temp] directory:<para/>
''' "/tmp/..."  == is greater [Temp]/... (windows)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_rm/*"/>
'''  <param name="subdir">[in][optional] - of '/tmp' can be NULL</param>
'''  <param name="tail">[in] - filename without the directory</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rm(
				 ByVal subdir as String, 
				 ByVal tail as String) as Integer

	If IsNothing (tail) then Throw New ArgumentNullException  ("tail cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rm( subdir, tail)

	Return _Result
End Function

' SRC\utils2.c (2189, 1)
' lept_rmfile(filepath) as Integer
' lept_rmfile(const char *) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes the named file.<para/>
''' (2) Use unix pathname separators.<para/>
''' (3) There is no name translation.<para/>
''' (4) Unlike the other lept_ functions in this section, this can remove<para/>
''' any file -- it is not restricted to files that are in /tmp or a<para/>
''' subdirectory of it.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_rmfile/*"/>
'''  <param name="filepath">[in] - full path to file including the directory</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rmfile(
				 ByVal filepath as String) as Integer

	If IsNothing (filepath) then Throw New ArgumentNullException  ("filepath cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rmfile( filepath)

	Return _Result
End Function

' SRC\utils2.c (2244, 1)
' lept_mv(srcfile, newdir, newtail, pnewpath) as Integer
' lept_mv(const char *, const char *, const char *, char **) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This moves %srcfile to /tmp or to a subdirectory of /tmp.<para/>
''' (2) %srcfile can either be a full path or relative to the<para/>
''' current directory.<para/>
''' (3) %newdir can either specify an existing subdirectory of /tmp<para/>
''' or can be NULL.  In the latter case, the file will be written<para/>
''' into /tmp.<para/>
''' (4) %newtail can either specify a filename tail or, if NULL,<para/>
''' the filename is taken from src-tail, the tail of %srcfile.<para/>
''' (5) For debugging, the computed newpath can be returned.  It must<para/>
''' be freed by the caller.<para/>
''' (6) Reminders:<para/>
''' (a) specify files using unix pathnames<para/>
''' (b) for windows, translates<para/>
''' /tmp  == is greater [Temp]<para/>
''' where [Temp] is the windows temp directory<para/>
''' (7) Examples:<para/>
''' newdir = NULL,  newtail = NULL  == is greater  /tmp/src-tail<para/>
''' newdir = NULL,  newtail = abc == is greater  /tmp/abc<para/>
''' newdir = def/ghi, newtail = NULL  == is greater  /tmp/def/ghi/src-tail<para/>
''' newdir = def/ghi, newtail = abc == is greater  /tmp/def/ghi/abc<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_mv/*"/>
'''  <param name="srcfile">[in] - </param>
'''  <param name="newdir">[in][optional] - can be NULL</param>
'''  <param name="newtail">[in][optional] - can be NULL</param>
'''  <param name="pnewpath">[out][optional] - of actual path can be NULL</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_mv(
				 ByVal srcfile as String, 
				 Optional ByVal newdir as String = Nothing, 
				 Optional ByVal newtail as String = Nothing, 
				<Out()> Optional ByRef pnewpath as String() = Nothing) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")

Dim pnewpathPTR As IntPtr = pnewpathPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnewpath.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_mv( srcfile, newdir, newtail, pnewpathPTR)

	Return _Result
End Function

' SRC\utils2.c (2343, 1)
' lept_cp(srcfile, newdir, newtail, pnewpath) as Integer
' lept_cp(const char *, const char *, const char *, char **) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This copies %srcfile to /tmp or to a subdirectory of /tmp.<para/>
''' (2) %srcfile can either be a full path or relative to the<para/>
''' current directory.<para/>
''' (3) %newdir can either specify an existing subdirectory of /tmp,<para/>
''' or can be NULL.  In the latter case, the file will be written<para/>
''' into /tmp.<para/>
''' (4) %newtail can either specify a filename tail or, if NULL,<para/>
''' the filename is taken from src-tail, the tail of %srcfile.<para/>
''' (5) For debugging, the computed newpath can be returned.  It must<para/>
''' be freed by the caller.<para/>
''' (6) Reminders:<para/>
''' (a) specify files using unix pathnames<para/>
''' (b) for windows, translates<para/>
''' /tmp  == is greater [Temp]<para/>
''' where [Temp] is the windows temp directory<para/>
''' (7) Examples:<para/>
''' newdir = NULL,  newtail = NULL  == is greater  /tmp/src-tail<para/>
''' newdir = NULL,  newtail = abc == is greater  /tmp/abc<para/>
''' newdir = def/ghi, newtail = NULL  == is greater  /tmp/def/ghi/src-tail<para/>
''' newdir = def/ghi, newtail = abc == is greater  /tmp/def/ghi/abc<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/lept_cp/*"/>
'''  <param name="srcfile">[in] - </param>
'''  <param name="newdir">[in][optional] - can be NULL</param>
'''  <param name="newtail">[in][optional] - can be NULL</param>
'''  <param name="pnewpath">[out][optional] - of actual path can be NULL</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_cp(
				 ByVal srcfile as String, 
				 Optional ByVal newdir as String = Nothing, 
				 Optional ByVal newtail as String = Nothing, 
				<Out()> Optional ByRef pnewpath as String() = Nothing) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")

Dim pnewpathPTR As IntPtr = pnewpathPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnewpath.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_cp( srcfile, newdir, newtail, pnewpathPTR)

	Return _Result
End Function

' SRC\utils2.c (2420, 1)
' callSystemDebug(cmd) as Object
' callSystemDebug(const char *) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The C library 'system' call is only made through this function.<para/>
''' It only works in debug/test mode, where the global variable<para/>
''' LeptDebugOK == TRUE.  This variable is set to FALSE in the<para/>
''' library as distributed, and calling this function will<para/>
''' generate an error message.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/callSystemDebug/*"/>
'''  <param name="cmd">[in] - command to be exec'd</param>
Public Shared Sub callSystemDebug(
				 ByVal cmd as String)

	If IsNothing (cmd) then Throw New ArgumentNullException  ("cmd cannot be Nothing")

	LeptonicaSharp.Natives.callSystemDebug( cmd)

End Sub

' SRC\utils2.c (2484, 1)
' splitPathAtDirectory(pathname, pdir, ptail) as Integer
' splitPathAtDirectory(const char *, char **, char **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If you only want the tail, input null for the root directory ptr.<para/>
''' (2) If you only want the root directory name, input null for the<para/>
''' tail ptr.<para/>
''' (3) This function makes decisions based only on the lexical<para/>
''' structure of the input.  Examples:<para/>
''' /usr/tmp/abc  -- is greater dir: /usr/tmp/ tail: abc<para/>
''' /usr/tmp/ -- is greater dir: /usr/tmp/ tail: [empty string]<para/>
''' /usr/tmp  -- is greater dir: /usr/   tail: tmp<para/>
''' abc   -- is greater dir: [empty string]  tail: abc<para/>
''' (4) The input can have either forward (unix) or backward (win)<para/>
''' slash separators.  The output has unix separators.<para/>
''' Note that Win32 pathname functions generally accept both<para/>
''' slash forms, but the windows command line interpreter<para/>
''' only accepts backward slashes, because forward slashes are<para/>
''' used to demarcate switches (vs. dashes in unix).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/splitPathAtDirectory/*"/>
'''  <param name="pathname">[in] - full path can be a directory</param>
'''  <param name="pdir">[out][optional] - root directory name of input path, including trailing '/'</param>
'''  <param name="ptail">[out][optional] - path tail, which is either the file name within the root directory or the last sub-directory in the path</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function splitPathAtDirectory(
				 ByVal pathname as String, 
				<Out()> Optional ByRef pdir as String() = Nothing, 
				<Out()> Optional ByRef ptail as String() = Nothing) as Integer

	If IsNothing (pathname) then Throw New ArgumentNullException  ("pathname cannot be Nothing")

Dim pdirPTR As IntPtr = pdirPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pdir.toArray))
Dim ptailPTR As IntPtr = ptailPTR = Marshal.AllocHGlobal(Marshal.sizeOf(ptail.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.splitPathAtDirectory( pathname, pdirPTR, ptailPTR)

	Return _Result
End Function

' SRC\utils2.c (2551, 1)
' splitPathAtExtension(pathname, pbasename, pextension) as Integer
' splitPathAtExtension(const char *, char **, char **) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If you only want the extension, input null for the basename ptr.<para/>
''' (2) If you only want the basename without extension, input null<para/>
''' for the extension ptr.<para/>
''' (3) This function makes decisions based only on the lexical<para/>
''' structure of the input.  Examples:<para/>
''' /usr/tmp/abc.jpg  -- is greater basename: /usr/tmp/abc  ext: .jpg<para/>
''' /usr/tmp/.jpg -- is greater basename: /usr/tmp/ ext: .jpg<para/>
''' /usr/tmp.jpg/ -- is greater basename: /usr/tmp.jpg/ ext: [empty str]<para/>
''' ./.jpg  -- is greater basename: ./  ext: .jpg<para/>
''' (4) The input can have either forward (unix) or backward (win)<para/>
''' slash separators.  The output has unix separators.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/splitPathAtExtension/*"/>
'''  <param name="pathname">[in] - full path can be a directory</param>
'''  <param name="pbasename">[out][optional] - pathname not including the last dot and characters after that</param>
'''  <param name="pextension">[out][optional] - path extension, which is the last dot and the characters after it.  If there is no extension, it returns the empty string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function splitPathAtExtension(
				 ByVal pathname as String, 
				<Out()> Optional ByRef pbasename as String() = Nothing, 
				<Out()> Optional ByRef pextension as String() = Nothing) as Integer

	If IsNothing (pathname) then Throw New ArgumentNullException  ("pathname cannot be Nothing")

Dim pbasenamePTR As IntPtr = pbasenamePTR = Marshal.AllocHGlobal(Marshal.sizeOf(pbasename.toArray))
Dim pextensionPTR As IntPtr = pextensionPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pextension.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.splitPathAtExtension( pathname, pbasenamePTR, pextensionPTR)

	Return _Result
End Function

' SRC\utils2.c (2630, 1)
' pathJoin(dir, fname) as String
' pathJoin(const char *, const char *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use unix-style pathname separators ('/').<para/>
''' (2) %fname can be the entire path, or part of the path containing<para/>
''' at least one directory, or a tail without a directory, or NULL.<para/>
''' (3) It produces a path that strips multiple slashes to a single<para/>
''' slash, joins %dir and %fname by a slash, and has no trailing<para/>
''' slashes (except in the cases where %dir == "/" and<para/>
''' %fname == NULL, or v.v.).<para/>
''' (4) If both %dir and %fname are null, produces an empty string.<para/>
''' (5) Neither %dir nor %fname can begin with '..'.<para/>
''' (6) The result is not canonicalized or tested for correctness:<para/>
''' garbage in (e.g., / and %), garbage out.<para/>
''' (7) Examples:<para/>
''' //tmp// + //abc/  -- is greater /tmp/abc<para/>
''' tmp/ + /abc/  -- is greater tmp/abc<para/>
''' tmp/ + abc/ -- is greater tmp/abc<para/>
''' /tmp/ + /// -- is greater /tmp<para/>
''' /tmp/ + NULL  -- is greater /tmp<para/>
''' // + /abc// -- is greater /abc<para/>
''' // + NULL -- is greater /<para/>
''' NULL + /abc/def/  -- is greater /abc/def<para/>
''' NULL + abc//  -- is greater abc<para/>
''' NULL + // -- is greater /<para/>
''' NULL + NULL -- is greater (empty string)<para/>
''' "" + ""   -- is greater (empty string)<para/>
''' "" + /  -- is greater /<para/>
''' ".." + /etc/foo -- is greater NULL<para/>
''' /tmp + ".." -- is greater NULL<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pathJoin/*"/>
'''  <param name="dir">[in][optional] - can be null</param>
'''  <param name="fname">[in][optional] - can be null</param>
'''   <returns>specially concatenated path, or NULL on error</returns>
Public Shared Function pathJoin(
				 ByVal dir as String, 
				 ByVal fname as String) as String

	Dim _Result as String = LeptonicaSharp.Natives.pathJoin( dir, fname)

	Return _Result
End Function

' SRC\utils2.c (2709, 1)
' appendSubdirs(basedir, subdirs) as String
' appendSubdirs(const char *, const char *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use unix pathname separators<para/>
''' (2) Allocates a new string:  [basedir]/[subdirs]<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/appendSubdirs/*"/>
'''  <param name="basedir">[in] - </param>
'''  <param name="subdirs">[in] - </param>
'''   <returns>concatenated full directory path without trailing slash, or NULL on error</returns>
Public Shared Function appendSubdirs(
				 ByVal basedir as String, 
				 ByVal subdirs as String) as String

	If IsNothing (basedir) then Throw New ArgumentNullException  ("basedir cannot be Nothing")
	If IsNothing (subdirs) then Throw New ArgumentNullException  ("subdirs cannot be Nothing")

	Dim _Result as String = LeptonicaSharp.Natives.appendSubdirs( basedir, subdirs)

	Return _Result
End Function

' SRC\utils2.c (2761, 1)
' convertSepCharsInPath(path, type) as Integer
' convertSepCharsInPath(char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In-place conversion.<para/>
''' (2) Type is the resulting type:<para/>
''' UNIX_PATH_SEPCHAR:  '\\' == is greater  '/'<para/>
''' WIN_PATH_SEPCHAR: '/' == is greater  '\\'<para/>
''' (3) Virtually all path operations in leptonica use unix separators.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/convertSepCharsInPath/*"/>
'''  <param name="path">[in] - </param>
'''  <param name="type">[in] - UNIX_PATH_SEPCHAR, WIN_PATH_SEPCHAR</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertSepCharsInPath(
				 ByVal path as String, 
				 ByVal type as Enumerations.PATH_SEPCHAR) as Integer

	If IsNothing (path) then Throw New ArgumentNullException  ("path cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.convertSepCharsInPath( path, type)

	Return _Result
End Function

' SRC\utils2.c (2824, 1)
' genPathname(dir, fname) as String
' genPathname(const char *, const char *) as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function generates actual paths in the following ways:<para/>
''' from two sub-parts (e.g., a directory and a file name).<para/>
''' from a single path full path, placed in %dir, with<para/>
''' %fname == NULL.<para/>
''' from the name of a file in the local directory placed in<para/>
''' %fname, with %dir == NULL.<para/>
''' if in a "/tmp" directory and on windows, the windows<para/>
''' temp directory is used.<para/>
''' (2) On windows, if the root of %dir is '/tmp', this does a name<para/>
''' translation:<para/>
''' "/tmp"  == is greater [Temp] (windows)<para/>
''' where [Temp] is the windows temp directory.<para/>
''' (3) On unix, the TMPDIR variable is ignored.  No rewriting<para/>
''' of temp directories is permitted.<para/>
''' (4) There are four cases for the input:<para/>
''' (a) %dir is a directory and %fname is defined: result is a full path<para/>
''' (b) %dir is a directory and %fname is null: result is a directory<para/>
''' (c) %dir is a full path and %fname is null: result is a full path<para/>
''' (d) %dir is null or an empty string: start in the current dir<para/>
''' result is a full path<para/>
''' (5) In all cases, the resulting pathname is not terminated with a slash<para/>
''' (6) The caller is responsible for freeing the returned pathname.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/genPathname/*"/>
'''  <param name="dir">[in][optional] - directory or full path name, with or without trailing '/'</param>
'''  <param name="fname">[in][optional] - file name within a directory</param>
'''   <returns>pathname either a directory or full path, or NULL on error</returns>
Public Shared Function genPathname(
				 ByVal dir as String, 
				 ByVal fname as String) as String

	Dim _Result as String = LeptonicaSharp.Natives.genPathname( dir, fname)

	Return _Result
End Function

' SRC\utils2.c (2930, 1)
' makeTempDirname(result, nbytes, subdir) as Integer
' makeTempDirname(char *, size_t, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This generates the directory path for output temp files,<para/>
''' written into %result with unix separators.<para/>
''' (2) Caller allocates %result, large enough to hold the path,<para/>
''' which is:<para/>
''' /tmp/%subdir (unix)<para/>
''' [Temp]/%subdir (windows)<para/>
''' where [Temp] is a path on windows determined by GenTempPath()<para/>
''' and %subdir is in general a set of nested subdirectories:<para/>
''' dir1/dir2/.../dirN<para/>
''' which in use would not typically exceed 2 levels.<para/>
''' (3) Usage example:<para/>
''' \code<para/>
''' char  result[256]<para/>
''' makeTempDirname(result, 256, "lept/golden")<para/>
''' \endcode<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/makeTempDirname/*"/>
'''  <param name="result">[in] - preallocated on stack or heap and passed in</param>
'''  <param name="nbytes">[in] - size of %result array, in bytes</param>
'''  <param name="subdir">[in][optional] - can be NULL or an empty string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function makeTempDirname(
				 ByVal result as String, 
				 ByVal nbytes as UInteger, 
				 Optional ByVal subdir as String = Nothing) as Integer

	If IsNothing (result) then Throw New ArgumentNullException  ("result cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.makeTempDirname( result, nbytes, subdir)

	Return _Result
End Function

' SRC\utils2.c (2980, 1)
' modifyTrailingSlash(path, nbytes, flag) as Integer
' modifyTrailingSlash(char *, size_t, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This carries out the requested action if necessary.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/modifyTrailingSlash/*"/>
'''  <param name="path">[in] - preallocated on stack or heap and passed in</param>
'''  <param name="nbytes">[in] - size of %path array, in bytes</param>
'''  <param name="flag">[in] - L_ADD_TRAIL_SLASH or L_REMOVE_TRAIL_SLASH</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function modifyTrailingSlash(
				 ByVal path as String, 
				 ByVal nbytes as UInteger, 
				 ByVal flag as Enumerations.L_TRAIL_SLASH) as Integer

	If IsNothing (path) then Throw New ArgumentNullException  ("path cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.modifyTrailingSlash( path, nbytes, flag)

	Return _Result
End Function

' SRC\utils2.c (3030, 1)
' l_makeTempFilename() as String
' l_makeTempFilename() as char *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) On unix, this makes a filename of the form<para/>
''' "/tmp/lept.XXXXXX",<para/>
''' where each X is a random character.<para/>
''' (2) On windows, this makes a filename of the form<para/>
''' "/[Temp]/lp.XXXXXX".<para/>
''' (3) On all systems, this fails if the file is not writable.<para/>
''' (4) Safest usage is to write to a subdirectory in debug code.<para/>
''' (5) The returned filename must be freed by the caller, using lept_free.<para/>
''' (6) The tail of the filename has a '.', so that cygwin interprets<para/>
''' the file as having an extension.  Otherwise, cygwin assumes it<para/>
''' is an executable and appends ".exe" to the filename.<para/>
''' (7) On unix, whenever possible use tmpfile() instead.  tmpfile()<para/>
''' hides the file name, returns a stream opened for write,<para/>
''' and deletes the temp file when the stream is closed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_makeTempFilename/*"/>
'''   <returns>fname : heap allocated filename returns NULL on failure.</returns>
Public Shared Function l_makeTempFilename() as String

	Dim _Result as String = LeptonicaSharp.Natives.l_makeTempFilename( )

	Return _Result
End Function

' SRC\utils2.c (3086, 1)
' extractNumberFromFilename(fname, numpre, numpost) as Integer
' extractNumberFromFilename(const char *, l_int32, l_int32) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The number is to be found in the basename, which is the<para/>
''' filename without either the directory or the last extension.<para/>
''' (2) When a number is found, it is non-negative.  If no number<para/>
''' is found, this returns -1, without an error message.  The<para/>
''' caller needs to check.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/extractNumberFromFilename/*"/>
'''  <param name="fname">[in] - </param>
'''  <param name="numpre">[in] - number of characters before the digits to be found</param>
'''  <param name="numpost">[in] - number of characters after the digits to be found</param>
'''   <returns>num number embedded in the filename -1 on error or if not found</returns>
Public Shared Function extractNumberFromFilename(
				 ByVal fname as String, 
				 ByVal numpre as Integer, 
				 ByVal numpost as Integer) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.extractNumberFromFilename( fname, numpre, numpost)

	Return _Result
End Function

End Class

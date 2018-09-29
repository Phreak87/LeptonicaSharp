Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\utils2.c (205, 1)
' stringNew()
' stringNew(const char *) as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - string</param>
'''   <returns>dest copy of src string, or NULL on error</returns>
Public Shared Function stringNew(
				ByVal src as String) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.stringNew( src)

	Return _Result
End Function

' SRC\utils2.c (245, 1)
' stringCopy()
' stringCopy(char *, const char *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) Relatively safe wrapper for strncpy, that checks the input,
''' and does not complain if %src is null or %n LT 1.
''' If %n LT 1, this is a no-op.
''' (2) %dest needs to be at least %n bytes in size.
''' (3) We don't call strncpy() because valgrind complains about
''' use of uninitialized values.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' stringReplace()
' stringReplace(char **, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) Frees any existing dest string
''' (2) Puts a copy of src string in the dest
''' (3) If either or both strings are null, does something reasonable.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdest">[out] - string copy</param>
'''  <param name="src">[in] - string [optional] can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function stringReplace(
				ByRef pdest as String(), 
				ByVal src as String) as Integer


Dim pdestPTR As IntPtr = pdestPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pdest.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringReplace( pdestPTR, src)

	Return _Result
End Function

' SRC\utils2.c (318, 1)
' stringLength()
' stringLength(const char *, size_t) as l_int32
'''  <summary>
''' Notes
''' (1) Safe implementation of strlen that only checks size bytes
''' for trailing NUL.
''' (2) Valid returned string lengths are between 0 and size - 1.
''' If size bytes are checked without finding a NUL byte, then
''' an error is indicated by returning size.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' stringCat()
' stringCat(char *, size_t, const char *) as l_int32
'''  <summary>
''' Notes
''' (1) Alternative implementation of strncat, that checks the input,
''' is easier to use (since the size of the dest buffer is specified
''' rather than the number of bytes to copy), and does not complain
''' if %src is null.
''' (2) Never writes past end of dest.
''' (3) If it can't append src (an error), it does nothing.
''' (4) N.B. The order of 2nd and 3rd args is reversed from that in
''' strncat, as in the Windows function strcat_s().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dest">[in] - null-terminated byte buffer</param>
'''  <param name="size">[in] - size of dest</param>
'''  <param name="src">[in] - string can be null or NULL-terminated string</param>
'''   <returns>number of bytes added to dest; -1 on error</returns>
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
' stringConcatNew()
' stringConcatNew(const char *, ...) as char *
'''  <summary>
''' Notes
''' (1) The last arg in the list of strings must be NULL.
''' (2) Caller must free the returned string.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="first">[in] - first string in list</param>
'''   <returns>result new string concatenating the input strings, or NULL if first == NULL</returns>
Public Shared Function stringConcatNew(
				ByVal first as String) as String

	If IsNothing (first) then Throw New ArgumentNullException  ("first cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.stringConcatNew( first)

	Return _Result
End Function

' SRC\utils2.c (454, 1)
' stringJoin()
' stringJoin(const char *, const char *) as char *
'''  <summary>
''' Notes
''' (1) This is a safe version of strcat; it makes a new string.
''' (2) It is not an error if either or both of the strings
''' are empty, or if either or both of the pointers are null.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' stringJoinIP()
' stringJoinIP(char **, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This is a safe in-place version of strcat.  The contents of
''' src1 is replaced by the concatenation of src1 and src2.
''' (2) It is not an error if either or both of the strings
''' are empty (""), or if the pointers to the strings (psrc1, src2)
''' are null.
''' (3) src1 should be initialized to null or an empty string
''' before the first call.  Use one of these
''' char src1 = NULL;
''' char src1 = stringNew("");
''' Then call with
''' stringJoinIP(src1, src2);
''' (4) This can also be implemented as a macro
''' \code
''' #define stringJoinIP(src1, src2) \
''' {tmpstr = stringJoin((src1),(src2)); \
''' LEPT_FREE(src1); \
''' (src1) = tmpstr;}
''' \endcode
''' (5) Another function to consider for joining many strings is
''' stringConcatNew().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="psrc1">[in,out] - string address of src1; cannot be on the stack</param>
'''  <param name="src2">[in] - string [optional] can be null</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringJoinIP(
				ByRef psrc1 as String(), 
				ByVal src2 as String) as Integer


Dim psrc1PTR As IntPtr = psrc1PTR = Marshal.AllocHGlobal(Marshal.sizeOf(psrc1.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringJoinIP( psrc1PTR, src2)

	Return _Result
End Function

' SRC\utils2.c (533, 1)
' stringReverse()
' stringReverse(const char *) as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - string</param>
'''   <returns>dest newly-allocated reversed string</returns>
Public Shared Function stringReverse(
				ByVal src as String) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.stringReverse( src)

	Return _Result
End Function

' SRC\utils2.c (585, 1)
' strtokSafe()
' strtokSafe(char *, const char *, char **) as char *
'''  <summary>
''' Notes
''' (1) This is a thread-safe implementation of strtok.
''' (2) It has the same interface as strtok_r.
''' (3) It differs from strtok_r in usage in two respects
''' (a) the input string is not altered
''' (b) each returned substring is newly allocated and must
''' be freed after use.
''' (4) Let me repeat that.  This is "safe" because the input
''' string is not altered and because each returned string
''' is newly allocated on the heap.
''' (5) It is here because, surprisingly, some C libraries don't
''' include strtok_r.
''' (6) Important usage points
''' ~ Input the string to be parsed on the first invocation.
''' ~ Then input NULL after that; the value returned in saveptr
''' is used in all subsequent calls.
''' (7) This is only slightly slower than strtok_r.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="seps">[in] - a string of character separators</param>
'''  <param name="psaveptr">[out] - ptr to the next char after the last encountered separator</param>
'''   <returns>substr a new string that is copied from the previous saveptr up to but not including the next separator character, or NULL if end of cstr.</returns>
Public Shared Function strtokSafe(
				ByRef _cstr_ as String, 
				ByVal seps as String, 
				ByRef psaveptr as String()) as String

	If IsNothing (_cstr_) then Throw New ArgumentNullException  ("_cstr_ cannot be Nothing")
	If IsNothing (seps) then Throw New ArgumentNullException  ("seps cannot be Nothing")

Dim psaveptrPTR As IntPtr = psaveptrPTR = Marshal.AllocHGlobal(Marshal.sizeOf(psaveptr.toArray))

	Dim _Result as String = LeptonicaSharp.Natives.strtokSafe( _cstr_, seps, psaveptrPTR)

	Return _Result
End Function

' SRC\utils2.c (679, 1)
' stringSplitOnToken()
' stringSplitOnToken(char *, const char *, char **, char **) as l_ok
'''  <summary>
''' Notes
''' (1) The input string is not altered; all split parts are new strings.
''' (2) The split occurs around the first consecutive sequence of
''' tokens encountered.
''' (3) The head goes from the beginning of the string up to
''' but not including the first token found.
''' (4) The tail contains the second part of the string, starting
''' with the first char in that part that is NOT a token.
''' (5) If no separator token is found, 'head' contains a copy
''' of the input string and 'tail' is null.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="seps">[in] - a string of character separators</param>
'''  <param name="phead">[out] - ptr to copy of the input string, up to the first separator token encountered</param>
'''  <param name="ptail">[out] - ptr to copy of the part of the input string starting with the first non-separator character that occurs after the first separator is found</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringSplitOnToken(
				ByRef _cstr_ as String, 
				ByVal seps as String, 
				ByRef phead as String(), 
				ByRef ptail as String()) as Integer

	If IsNothing (_cstr_) then Throw New ArgumentNullException  ("_cstr_ cannot be Nothing")
	If IsNothing (seps) then Throw New ArgumentNullException  ("seps cannot be Nothing")

Dim pheadPTR As IntPtr = pheadPTR = Marshal.AllocHGlobal(Marshal.sizeOf(phead.toArray))
Dim ptailPTR As IntPtr = ptailPTR = Marshal.AllocHGlobal(Marshal.sizeOf(ptail.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.stringSplitOnToken( _cstr_, seps, pheadPTR, ptailPTR)

	Return _Result
End Function

' SRC\utils2.c (723, 1)
' stringCheckForChars()
' stringCheckForChars(const char *, const char *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) This can be used to sanitize an operation by checking for
''' special characters that don't belong in a string.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - input string; can be of zero length</param>
'''  <param name="chars">[in] - string of chars to be searched for in %src</param>
'''  <param name="pfound">[out] - 1 if any characters are found; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function stringCheckForChars(
				ByVal src as String, 
				ByVal chars as String, 
				ByRef pfound as Integer) as Integer

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (chars) then Throw New ArgumentNullException  ("chars cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.stringCheckForChars( src, chars, pfound)

	Return _Result
End Function

' SRC\utils2.c (758, 1)
' stringRemoveChars()
' stringRemoveChars(const char *, const char *) as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - input string; can be of zero length</param>
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
' stringFindSubstr()
' stringFindSubstr(const char *, const char *, l_int32 *) as l_int32
'''  <summary>
''' Notes
''' (1) This is a wrapper around strstr().
''' (2) Both %src and %sub must be defined, and %sub must have
''' length of at least 1.
''' (3) If the substring is not found and loc is returned, it has
''' the value -1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - input string; can be of zero length</param>
'''  <param name="ploc">[out][optional] - location of substring in src</param>
'''   <returns>1 if found; 0 if not found or on error</returns>
Public Shared Function stringFindSubstr(
				ByVal src as String, 
				ByRef _sub_ as String, 
				ByRef ploc as Integer) as Integer

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (_sub_) then Throw New ArgumentNullException  ("_sub_ cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.stringFindSubstr( src, _sub_, ploc)

	Return _Result
End Function

' SRC\utils2.c (855, 1)
' stringReplaceSubstr()
' stringReplaceSubstr(const char *, const char *, const char *, l_int32 *, l_int32 *) as char *
'''  <summary>
''' Notes
''' (1) Replaces the first instance.
''' (2) To only remove sub1, use "" for sub2
''' (3) Returns a new string if sub1 and sub2 are the same.
''' (4) The optional loc is input as the byte offset within the src
''' from which the search starts, and after the search it is the
''' char position in the string of the next character after
''' the substituted string.
''' (5) N.B. If ploc is not null, loc must always be initialized.
''' To search the string from the beginning, set loc = 0.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - input string; can be of zero length</param>
'''  <param name="sub1">[in] - substring to be replaced</param>
'''  <param name="sub2">[in] - substring to put in; can be ""</param>
'''  <param name="pfound">[out][optional] - 1 if sub1 is found; 0 otherwise</param>
'''  <param name="ploc">[out][optional] - location of ptr after replacement</param>
'''   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
Public Shared Function stringReplaceSubstr(
				ByVal src as String, 
				ByVal sub1 as String, 
				ByVal sub2 as String, 
				ByRef pfound as Integer, 
				ByRef ploc as Integer) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (sub1) then Throw New ArgumentNullException  ("sub1 cannot be Nothing")
	If IsNothing (sub2) then Throw New ArgumentNullException  ("sub2 cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.stringReplaceSubstr( src, sub1, sub2, pfound, ploc)

	Return _Result
End Function

' SRC\utils2.c (922, 1)
' stringReplaceEachSubstr()
' stringReplaceEachSubstr(const char *, const char *, const char *, l_int32 *) as char *
'''  <summary>
''' Notes
''' (1) Replaces every instance.
''' (2) To only remove each instance of sub1, use "" for sub2
''' (3) Returns NULL if sub1 and sub2 are the same.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="src">[in] - input string; can be of zero length</param>
'''  <param name="sub1">[in] - substring to be replaced</param>
'''  <param name="sub2">[in] - substring to put in; can be ""</param>
'''  <param name="pcount">[out][optional] - the number of times that sub1 is found in src; 0 if not found</param>
'''   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
Public Shared Function stringReplaceEachSubstr(
				ByVal src as String, 
				ByVal sub1 as String, 
				ByVal sub2 as String, 
				ByRef pcount as Integer) as String

	If IsNothing (src) then Throw New ArgumentNullException  ("src cannot be Nothing")
	If IsNothing (sub1) then Throw New ArgumentNullException  ("sub1 cannot be Nothing")
	If IsNothing (sub2) then Throw New ArgumentNullException  ("sub2 cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.stringReplaceEachSubstr( src, sub1, sub2, pcount)

	Return _Result
End Function

' SRC\utils2.c (977, 1)
' arrayFindEachSequence()
' arrayFindEachSequence(const l_uint8 *, size_t, const l_uint8 *, size_t) as L_DNA *
'''  <summary>
''' Notes
''' (1) The byte arrays %data and %sequence are not C strings,
''' as they can contain null bytes.  Therefore, for each
''' we must give the length of the array.
''' (2) This finds every occurrence in %data of %sequence.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' arrayFindSequence()
' arrayFindSequence(const l_uint8 *, size_t, const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' Notes
''' (1) The byte arrays 'data' and 'sequence' are not C strings,
''' as they can contain null bytes.  Therefore, for each
''' we must give the length of the array.
''' (2) This searches for the first occurrence in %data of %sequence,
''' which consists of %seqlen bytes.  The parameter %seqlen
''' must not exceed the actual length of the %sequence byte array.
''' (3) If the sequence is not found, the offset will be 0, so you
''' must check %found.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - byte array</param>
'''  <param name="datalen">[in] - length of data, in bytes</param>
'''  <param name="sequence">[in] - subarray of bytes to find in data</param>
'''  <param name="seqlen">[in] - length of sequence, in bytes</param>
'''  <param name="poffset">[out] - offset from beginning of data where the sequence begins</param>
'''  <param name="pfound">[out] - 1 if sequence is found; 0 otherwise</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function arrayFindSequence(
				ByVal data as Byte(), 
				ByVal datalen as UInteger, 
				ByVal sequence as Byte(), 
				ByVal seqlen as UInteger, 
				ByRef poffset as Integer, 
				ByRef pfound as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.arrayFindSequence( data, datalen, sequence, seqlen, poffset, pfound)

	Return _Result
End Function

' SRC\utils2.c (1106, 1)
' reallocNew()
' reallocNew(void **, l_int32, l_int32) as void *
'''  <summary>
''' Notes
''' (1) If newsize LT=0, just frees input data and nulls ptr
''' (2) If input ptr is null, just callocs new memory
''' (3) This differs from realloc in that it always allocates
''' new memory (if newsize GT 0) and initializes it to 0,
''' it requires the amount of old data to be copied,
''' and it takes the address of the input ptr and
''' nulls the handle.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pindata">[in,out][optional] - ; nulls indata</param>
'''  <param name="oldsize">[in] - size of input data to be copied, in bytes</param>
'''  <param name="newsize">[in] - size of data to be reallocated in bytes</param>
'''   <returns>ptr to new data, or NULL on error Action !N.B. 3) and (4! 1 Allocates memory, initialized to 0 2 Copies as much of the input data as possible to the new block, truncating the copy if necessary 3 Frees the input data 4 Zeroes the input data ptr</returns>
Public Shared Function reallocNew(
				ByRef pindata as IntPtr(), 
				ByVal oldsize as Integer, 
				ByVal newsize as Integer) as Object


Dim pindataPTR As IntPtr = IntPtr.Zero: if not isNothing (pindata) then pindataPTR = Marshal.AllocHGlobal(Marshal.SizeOf(pindata.toarray))

	Dim _Result as IntPtr = LeptonicaSharp.Natives.reallocNew( pindataPTR, oldsize, newsize)

	Return _Result
End Function

' SRC\utils2.c (1158, 1)
' l_binaryRead()
' l_binaryRead(const char *, size_t *) as l_uint8 *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="pnbytes">[out] - number of bytes read</param>
'''   <returns>data, or NULL on error</returns>
Public Shared Function l_binaryRead(
				ByVal filename as String, 
				ByRef pnbytes as UInteger) as Byte()

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryRead( filename, pnbytes)

	Return _Result
End Function

' SRC\utils2.c (1208, 1)
' l_binaryReadStream()
' l_binaryReadStream(FILE *, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The returned array is terminated with a null byte so that it can
''' be used to read ascii data from a file into a proper C string.
''' (2) This can be used to capture data that is piped in via stdin,
''' because it does not require seeking within the file.
''' (3) For example, you can read an image from stdin into memory
''' using shell redirection, with one of these shell commands
''' \code
''' cat LTimagefileGT | readprog
''' readprog LT LTimagefileGT
''' \endcode
''' where readprog is
''' \code
''' l_uint8 data = l_binaryReadStream(stdin, nbytes);
''' Pix pix = pixReadMem(data, nbytes);
''' \endcode
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened to read; can be stdin</param>
'''  <param name="pnbytes">[out] - number of bytes read</param>
'''   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
Public Shared Function l_binaryReadStream(
				ByVal fp as FILE, 
				ByRef pnbytes as UInteger) as Byte()

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadStream( fp.Pointer, pnbytes)

	Return _Result
End Function

' SRC\utils2.c (1275, 1)
' l_binaryReadSelect()
' l_binaryReadSelect(const char *, size_t, size_t, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The returned array is terminated with a null byte so that it can
''' be used to read ascii data from a file into a proper C string.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="start">[in] - first byte to read</param>
'''  <param name="nbytes">[in] - number of bytes to read; use 0 to read to end of file</param>
'''  <param name="pnread">[out] - number of bytes actually read</param>
'''   <returns>data, or NULL on error</returns>
Public Shared Function l_binaryReadSelect(
				ByVal filename as String, 
				ByVal start as UInteger, 
				ByVal nbytes as UInteger, 
				ByRef pnread as UInteger) as Byte()

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadSelect( filename, start, nbytes, pnread)

	Return _Result
End Function

' SRC\utils2.c (1320, 1)
' l_binaryReadSelectStream()
' l_binaryReadSelectStream(FILE *, size_t, size_t, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The returned array is terminated with a null byte so that it can
''' be used to read ascii data from a file into a proper C string.
''' If the file to be read is empty and %start == 0, an array
''' with a single null byte is returned.
''' (2) Side effect the stream pointer is re-positioned to the
''' beginning of the file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="start">[in] - first byte to read</param>
'''  <param name="nbytes">[in] - number of bytes to read; use 0 to read to end of file</param>
'''  <param name="pnread">[out] - number of bytes actually read</param>
'''   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
Public Shared Function l_binaryReadSelectStream(
				ByVal fp as FILE, 
				ByVal start as UInteger, 
				ByVal nbytes as UInteger, 
				ByRef pnread as UInteger) as Byte()

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.l_binaryReadSelectStream( fp.Pointer, start, nbytes, pnread)

	Return _Result
End Function

' SRC\utils2.c (1375, 1)
' l_binaryWrite()
' l_binaryWrite(const char *, const char *, const void *, size_t) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - output</param>
'''  <param name="operation">[in] - "w" for write; "a" for append</param>
'''  <param name="data">[in] - binary data to be written</param>
'''  <param name="nbytes">[in] - size of data array</param>
'''   <returns>0 if OK; 1 on error</returns>
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
' nbytesInFile()
' nbytesInFile(const char *) as size_t
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''   <returns>nbytes in file; 0 on error</returns>
Public Shared Function nbytesInFile(
				ByVal filename as String) as UInteger

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.nbytesInFile( filename)

	Return _Result
End Function

' SRC\utils2.c (1441, 1)
' fnbytesInFile()
' fnbytesInFile(FILE *) as size_t
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>nbytes in file; 0 on error</returns>
Public Shared Function fnbytesInFile(
				ByVal fp as FILE) as UInteger

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as UInteger = LeptonicaSharp.Natives.fnbytesInFile( fp.Pointer)

	Return _Result
End Function

' SRC\utils2.c (1479, 1)
' l_binaryCopy()
' l_binaryCopy(l_uint8 *, size_t) as l_uint8 *
'''  <summary>
''' Notes
''' (1) We add 4 bytes to the zeroed output because in some cases
''' (e.g., string handling) it is important to have the data
''' be null terminated.  This guarantees that after the memcpy,
''' the result is automatically null terminated.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fileCopy()
' fileCopy(const char *, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fileConcatenate()
' fileConcatenate(const char *, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fileAppendString()
' fileAppendString(const char *, const char *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fopenReadStream()
' fopenReadStream(const char *) as FILE *
'''  <summary>
''' Notes
''' (1) This should be used whenever you want to run fopen() to
''' read from a stream.  Never call fopen() directory.
''' (2) This handles the temp directory pathname conversion on windows
''' /tmp  ==GT  [Windows Temp directory]
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fopenWriteStream()
' fopenWriteStream(const char *, const char *) as FILE *
'''  <summary>
''' Notes
''' (1) This should be used whenever you want to run fopen() to
''' write or append to a stream.  Never call fopen() directory.
''' (2) This handles the temp directory pathname conversion on windows
''' /tmp  ==GT  [Windows Temp directory]
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fopenReadFromMemory()
' fopenReadFromMemory(const l_uint8 *, size_t) as FILE *
'''  <summary>
''' Notes
''' (1) Work-around if fmemopen() not available.
''' (2) Windows tmpfile() writes into the root C\ directory, which
''' requires admin privileges.  This also works around that.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' fopenWriteWinTempfile()
' fopenWriteWinTempfile() as FILE *
'''  <summary>
''' Notes
''' (1) The Windows version of tmpfile() writes into the root
''' C\ directory, which requires admin privileges.  This
''' function provides an alternative implementation.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>file stream, or NULL on error</returns>
Public Shared Function fopenWriteWinTempfile() as FILE



	Dim _Result as IntPtr = LeptonicaSharp.Natives.fopenWriteWinTempfile( )
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new FILE(_Result)
End Function

' SRC\utils2.c (1784, 1)
' lept_fopen()
' lept_fopen(const char *, const char *) as FILE *
'''  <summary>
''' Notes
''' (1) This must be used by any application that passes
''' a file handle to a leptonica Windows DLL.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="mode">[in] - same as for fopen(); e.g., "rb"</param>
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
' lept_fclose()
' lept_fclose(FILE *) as l_ok
'''  <summary>
''' Notes
''' (1) This should be used by any application that accepts
''' a file handle generated by a leptonica Windows DLL.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function lept_fclose(
				ByVal fp as FILE) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_fclose( fp.Pointer)

	Return _Result
End Function

' SRC\utils2.c (1840, 1)
' lept_calloc()
' lept_calloc(size_t, size_t) as void *
'''  <summary>
''' Notes
''' (1) For safety with windows DLLs, this can be used in conjunction
''' with lept_free() to avoid C-runtime boundary problems.
''' Just use these two functions throughout your application.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' lept_free()
' lept_free(void *) as void
'''  <summary>
''' Notes
''' (1) This should be used by any application that accepts
''' heap data allocated by a leptonica Windows DLL.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="ptr">[in] - </param>
Public Shared Sub lept_free(
				ByVal ptr as Object)

	If IsNothing (ptr) then Throw New ArgumentNullException  ("ptr cannot be Nothing")

Dim ptrPTR As IntPtr = Marshal.AllocHGlobal(0)

	LeptonicaSharp.Natives.lept_free( ptrPTR)

End Sub

' SRC\utils2.c (1890, 1)
' lept_mkdir()
' lept_mkdir(const char *) as l_int32
'''  <summary>
''' Notes
''' (1) %subdir is a partial path that can consist of one or more
''' directories.
''' (2) This makes any subdirectories of /tmp that are required.
''' (3) The root temp directory is
''' /tmp (unix)  [default]
''' [Temp]  (windows)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_mkdir(
				ByVal subdir as String) as Integer

	If IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_mkdir( subdir)

	Return _Result
End Function

' SRC\utils2.c (1967, 1)
' lept_rmdir()
' lept_rmdir(const char *) as l_int32
'''  <summary>
''' Notes
''' (1) %subdir is a partial path that can consist of one or more
''' directories.
''' (2) This removes all files from the specified subdirectory of
''' the root temp directory
''' /tmp (unix)
''' [Temp]  (windows)
''' and then removes the subdirectory.
''' (3) The combination
''' lept_rmdir(subdir);
''' lept_mkdir(subdir);
''' is guaranteed to give you an empty subdirectory.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rmdir(
				ByVal subdir as String) as Integer

	If IsNothing (subdir) then Throw New ArgumentNullException  ("subdir cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rmdir( subdir)

	Return _Result
End Function

' SRC\utils2.c (2041, 1)
' lept_direxists()
' lept_direxists(const char *, l_int32 *) as void
'''  <summary>
''' Notes
''' (1) Always use unix pathname separators.
''' (2) By calling genPathname(), if the pathname begins with "/tmp"
''' this does an automatic directory translation on windows
''' to a path in the windows [Temp] directory
''' "/tmp"  ==GT  [Temp] (windows)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dir">[in] - </param>
'''  <param name="pexists">[out] - 1 if it exists; 0 otherwise</param>
Public Shared Sub lept_direxists(
				ByVal dir as String, 
				ByRef pexists as Integer)

	If IsNothing (dir) then Throw New ArgumentNullException  ("dir cannot be Nothing")


	LeptonicaSharp.Natives.lept_direxists( dir, pexists)

End Sub

' SRC\utils2.c (2099, 1)
' lept_rm_match()
' lept_rm_match(const char *, const char *) as l_int32
'''  <summary>
''' Notes
''' (1) This removes the matched files in /tmp or a subdirectory of /tmp.
''' Use NULL for %subdir if the files are in /tmp.
''' (2) If %substr == NULL, this removes all files in the directory.
''' If %substr == "" (empty), this removes no files.
''' If both %subdir == NULL and %substr == NULL, this removes
''' all files in /tmp.
''' (3) Use unix pathname separators.
''' (4) By calling genPathname(), if the pathname begins with "/tmp"
''' this does an automatic directory translation on windows
''' to a path in the windows [Temp] directory
''' "/tmp"  ==GT  [Temp] (windows)
''' (5) Error conditions
''' returns -1 if the directory is not found
''' returns the number of files (GT 0) that it was unable to remove.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' lept_rm()
' lept_rm(const char *, const char *) as l_int32
'''  <summary>
''' Notes
''' (1) By calling genPathname(), this does an automatic directory
''' translation on windows to a path in the windows [Temp] directory
''' "/tmp/..."  ==GT  [Temp]/... (windows)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="subdir">[in][optional] - of '/tmp'; can be NULL</param>
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
' lept_rmfile()
' lept_rmfile(const char *) as l_int32
'''  <summary>
''' Notes
''' (1) This removes the named file.
''' (2) Use unix pathname separators.
''' (3) There is no name translation.
''' (4) Unlike the other lept_ functions in this section, this can remove
''' any file -- it is not restricted to files that are in /tmp or a
''' subdirectory of it.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filepath">[in] - full path to file including the directory</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_rmfile(
				ByVal filepath as String) as Integer

	If IsNothing (filepath) then Throw New ArgumentNullException  ("filepath cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.lept_rmfile( filepath)

	Return _Result
End Function

' SRC\utils2.c (2244, 1)
' lept_mv()
' lept_mv(const char *, const char *, const char *, char **) as l_int32
'''  <summary>
''' Notes
''' (1) This moves %srcfile to /tmp or to a subdirectory of /tmp.
''' (2) %srcfile can either be a full path or relative to the
''' current directory.
''' (3) %newdir can either specify an existing subdirectory of /tmp
''' or can be NULL.  In the latter case, the file will be written
''' into /tmp.
''' (4) %newtail can either specify a filename tail or, if NULL,
''' the filename is taken from src-tail, the tail of %srcfile.
''' (5) For debugging, the computed newpath can be returned.  It must
''' be freed by the caller.
''' (6) Reminders
''' (a) specify files using unix pathnames
''' (b) for windows, translates
''' /tmp  ==GT  [Temp]
''' where [Temp] is the windows temp directory
''' (7) Examples
''' newdir = NULL, newtail = NULL ==GT /tmp/src-tail
''' newdir = NULL, newtail = abc  ==GT /tmp/abc
''' newdir = def/ghi, newtail = NULL ==GT /tmp/def/ghi/src-tail
''' newdir = def/ghi, newtail = abc  ==GT /tmp/def/ghi/abc
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="srcfile">[in] - </param>
'''  <param name="newdir">[in][optional] - ; can be NULL</param>
'''  <param name="newtail">[in][optional] - ; can be NULL</param>
'''  <param name="pnewpath">[out][optional] - of actual path; can be NULL</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_mv(
				ByVal srcfile as String, 
				ByVal newdir as String, 
				ByVal newtail as String, 
				ByRef pnewpath as String()) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")

Dim pnewpathPTR As IntPtr = pnewpathPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnewpath.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_mv( srcfile, newdir, newtail, pnewpathPTR)

	Return _Result
End Function

' SRC\utils2.c (2343, 1)
' lept_cp()
' lept_cp(const char *, const char *, const char *, char **) as l_int32
'''  <summary>
''' Notes
''' (1) This copies %srcfile to /tmp or to a subdirectory of /tmp.
''' (2) %srcfile can either be a full path or relative to the
''' current directory.
''' (3) %newdir can either specify an existing subdirectory of /tmp,
''' or can be NULL.  In the latter case, the file will be written
''' into /tmp.
''' (4) %newtail can either specify a filename tail or, if NULL,
''' the filename is taken from src-tail, the tail of %srcfile.
''' (5) For debugging, the computed newpath can be returned.  It must
''' be freed by the caller.
''' (6) Reminders
''' (a) specify files using unix pathnames
''' (b) for windows, translates
''' /tmp  ==GT  [Temp]
''' where [Temp] is the windows temp directory
''' (7) Examples
''' newdir = NULL, newtail = NULL ==GT /tmp/src-tail
''' newdir = NULL, newtail = abc  ==GT /tmp/abc
''' newdir = def/ghi, newtail = NULL ==GT /tmp/def/ghi/src-tail
''' newdir = def/ghi, newtail = abc  ==GT /tmp/def/ghi/abc
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="srcfile">[in] - </param>
'''  <param name="newdir">[in][optional] - ; can be NULL</param>
'''  <param name="newtail">[in][optional] - ; can be NULL</param>
'''  <param name="pnewpath">[out][optional] - of actual path; can be NULL</param>
'''   <returns>0 on success, non-zero on failure</returns>
Public Shared Function lept_cp(
				ByVal srcfile as String, 
				ByVal newdir as String, 
				ByVal newtail as String, 
				ByRef pnewpath as String()) as Integer

	If IsNothing (srcfile) then Throw New ArgumentNullException  ("srcfile cannot be Nothing")

Dim pnewpathPTR As IntPtr = pnewpathPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pnewpath.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.lept_cp( srcfile, newdir, newtail, pnewpathPTR)

	Return _Result
End Function

' SRC\utils2.c (2420, 1)
' callSystemDebug()
' callSystemDebug(const char *) as void
'''  <summary>
''' Notes
''' (1) The C library 'system' call is only made through this function.
''' It only works in debug/test mode, where the global variable
''' LeptDebugOK == TRUE.  This variable is set to FALSE in the
''' library as distributed, and calling this function will
''' generate an error message.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cmd">[in] - command to be exec'd</param>
Public Shared Sub callSystemDebug(
				ByVal cmd as String)

	If IsNothing (cmd) then Throw New ArgumentNullException  ("cmd cannot be Nothing")


	LeptonicaSharp.Natives.callSystemDebug( cmd)

End Sub

' SRC\utils2.c (2484, 1)
' splitPathAtDirectory()
' splitPathAtDirectory(const char *, char **, char **) as l_ok
'''  <summary>
''' Notes
''' (1) If you only want the tail, input null for the root directory ptr.
''' (2) If you only want the root directory name, input null for the
''' tail ptr.
''' (3) This function makes decisions based only on the lexical
''' structure of the input.  Examples
''' /usr/tmp/abc  --GT  dir /usr/tmp/ tail abc
''' /usr/tmp/  --GT  dir /usr/tmp/ tail [empty string]
''' /usr/tmp   --GT  dir /usr/  tail tmp
''' abc  --GT  dir [empty string]  tail abc
''' (4) The input can have either forward (unix) or backward (win)
''' slash separators.  The output has unix separators.
''' Note that Win32 pathname functions generally accept both
''' slash forms, but the windows command line interpreter
''' only accepts backward slashes, because forward slashes are
''' used to demarcate switches (vs. dashes in unix).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pathname">[in] - full path; can be a directory</param>
'''  <param name="pdir">[out][optional] - root directory name of input path, including trailing '/'</param>
'''  <param name="ptail">[out][optional] - path tail, which is either the file name within the root directory or the last sub-directory in the path</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function splitPathAtDirectory(
				ByVal pathname as String, 
				ByRef pdir as String(), 
				ByRef ptail as String()) as Integer

	If IsNothing (pathname) then Throw New ArgumentNullException  ("pathname cannot be Nothing")

Dim pdirPTR As IntPtr = pdirPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pdir.toArray))
Dim ptailPTR As IntPtr = ptailPTR = Marshal.AllocHGlobal(Marshal.sizeOf(ptail.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.splitPathAtDirectory( pathname, pdirPTR, ptailPTR)

	Return _Result
End Function

' SRC\utils2.c (2551, 1)
' splitPathAtExtension()
' splitPathAtExtension(const char *, char **, char **) as l_ok
'''  <summary>
''' Notes
''' (1) If you only want the extension, input null for the basename ptr.
''' (2) If you only want the basename without extension, input null
''' for the extension ptr.
''' (3) This function makes decisions based only on the lexical
''' structure of the input.  Examples
''' /usr/tmp/abc.jpg  --GT  basename /usr/tmp/abc ext .jpg
''' /usr/tmp/.jpg  --GT  basename /usr/tmp/ ext .jpg
''' /usr/tmp.jpg/  --GT  basename /usr/tmp.jpg/   ext [empty str]
''' ./.jpg   --GT  basename ./  ext .jpg
''' (4) The input can have either forward (unix) or backward (win)
''' slash separators.  The output has unix separators.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pathname">[in] - full path; can be a directory</param>
'''  <param name="pbasename">[out][optional] - pathname not including the last dot and characters after that</param>
'''  <param name="pextension">[out][optional] - path extension, which is the last dot and the characters after it.  If there is no extension, it returns the empty string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function splitPathAtExtension(
				ByVal pathname as String, 
				ByRef pbasename as String(), 
				ByRef pextension as String()) as Integer

	If IsNothing (pathname) then Throw New ArgumentNullException  ("pathname cannot be Nothing")

Dim pbasenamePTR As IntPtr = pbasenamePTR = Marshal.AllocHGlobal(Marshal.sizeOf(pbasename.toArray))
Dim pextensionPTR As IntPtr = pextensionPTR = Marshal.AllocHGlobal(Marshal.sizeOf(pextension.toArray))

	Dim _Result as Integer = LeptonicaSharp.Natives.splitPathAtExtension( pathname, pbasenamePTR, pextensionPTR)

	Return _Result
End Function

' SRC\utils2.c (2630, 1)
' pathJoin()
' pathJoin(const char *, const char *) as char *
'''  <summary>
''' Notes
''' (1) Use unix-style pathname separators ('/').
''' (2) %fname can be the entire path, or part of the path containing
''' at least one directory, or a tail without a directory, or NULL.
''' (3) It produces a path that strips multiple slashes to a single
''' slash, joins %dir and %fname by a slash, and has no trailing
''' slashes (except in the cases where %dir == "/" and
''' %fname == NULL, or v.v.).
''' (4) If both %dir and %fname are null, produces an empty string.
''' (5) Neither %dir nor %fname can begin with '..'.
''' (6) The result is not canonicalized or tested for correctness
''' garbage in (e.g., /%), garbage out.
''' (7) Examples
''' //tmp// + //abc/  --GT  /tmp/abc
''' tmp/ + /abc/   --GT  tmp/abc
''' tmp/ + abc/ --GT  tmp/abc
''' /tmp/ + /// --GT  /tmp
''' /tmp/ + NULL   --GT  /tmp
''' // + /abc// --GT  /abc
''' // + NULL   --GT  /
''' NULL + /abc/def/  --GT  /abc/def
''' NULL + abc//   --GT  abc
''' NULL + //   --GT  /
''' NULL + NULL --GT  (empty string)
''' "" + ""  --GT  (empty string)
''' "" + /   --GT  /
''' ".." + /etc/foo   --GT  NULL
''' /tmp + ".." --GT  NULL
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' appendSubdirs()
' appendSubdirs(const char *, const char *) as char *
'''  <summary>
''' Notes
''' (1) Use unix pathname separators
''' (2) Allocates a new string  [basedir]/[subdirs]
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' convertSepCharsInPath()
' convertSepCharsInPath(char *, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) In-place conversion.
''' (2) Type is the resulting type
''' UNIX_PATH_SEPCHAR  '\\' ==GT '/'
''' WIN_PATH_SEPCHAR   '/' ==GT '\\'
''' (3) Virtually all path operations in leptonica use unix separators.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' genPathname()
' genPathname(const char *, const char *) as char *
'''  <summary>
''' Notes
''' (1) This function generates actual paths in the following ways
''' from two sub-parts (e.g., a directory and a file name).
''' from a single path full path, placed in %dir, with
''' %fname == NULL.
''' from the name of a file in the local directory placed in
''' %fname, with %dir == NULL.
''' if in a "/tmp" directory and on windows, the windows
''' temp directory is used.
''' (2) On windows, if the root of %dir is '/tmp', this does a name
''' translation
''' "/tmp"  ==GT  [Temp] (windows)
''' where [Temp] is the windows temp directory.
''' (3) On unix, the TMPDIR variable is ignored.  No rewriting
''' of temp directories is permitted.
''' (4) There are four cases for the input
''' (a) %dir is a directory and %fname is defined result is a full path
''' (b) %dir is a directory and %fname is null result is a directory
''' (c) %dir is a full path and %fname is null result is a full path
''' (d) %dir is null or an empty string start in the current dir;
''' result is a full path
''' (5) In all cases, the resulting pathname is not terminated with a slash
''' (6) The caller is responsible for freeing the returned pathname.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' makeTempDirname()
' makeTempDirname(char *, size_t, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This generates the directory path for output temp files,
''' written into %result with unix separators.
''' (2) Caller allocates %result, large enough to hold the path,
''' which is
''' /tmp/%subdir (unix)
''' [Temp]/%subdir  (windows)
''' where [Temp] is a path on windows determined by GenTempPath()
''' and %subdir is in general a set of nested subdirectories
''' dir1/dir2/.../dirN
''' which in use would not typically exceed 2 levels.
''' (3) Usage example
''' \code
''' char  result[256];
''' makeTempDirname(result, 256, "lept/golden");
''' \endcode
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="result">[in] - preallocated on stack or heap and passed in</param>
'''  <param name="nbytes">[in] - size of %result array, in bytes</param>
'''  <param name="subdir">[in][optional] - ; can be NULL or an empty string</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function makeTempDirname(
				ByVal result as String, 
				ByVal nbytes as UInteger, 
				ByVal subdir as String) as Integer

	If IsNothing (result) then Throw New ArgumentNullException  ("result cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.makeTempDirname( result, nbytes, subdir)

	Return _Result
End Function

' SRC\utils2.c (2980, 1)
' modifyTrailingSlash()
' modifyTrailingSlash(char *, size_t, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This carries out the requested action if necessary.
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' l_makeTempFilename()
' l_makeTempFilename() as char *
'''  <summary>
''' Notes
''' (1) On unix, this makes a filename of the form
''' "/tmp/lept.XXXXXX",
''' where each X is a random character.
''' (2) On windows, this makes a filename of the form
''' "/[Temp]/lp.XXXXXX".
''' (3) On all systems, this fails if the file is not writable.
''' (4) Safest usage is to write to a subdirectory in debug code.
''' (5) The returned filename must be freed by the caller, using lept_free.
''' (6) The tail of the filename has a '.', so that cygwin interprets
''' the file as having an extension.  Otherwise, cygwin assumes it
''' is an executable and appends ".exe" to the filename.
''' (7) On unix, whenever possible use tmpfile() instead.  tmpfile()
''' hides the file name, returns a stream opened for write,
''' and deletes the temp file when the stream is closed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns>fname  heap allocated filename; returns NULL on failure.</returns>
Public Shared Function l_makeTempFilename() as String



	Dim _Result as String = LeptonicaSharp.Natives.l_makeTempFilename( )

	Return _Result
End Function

' SRC\utils2.c (3086, 1)
' extractNumberFromFilename()
' extractNumberFromFilename(const char *, l_int32, l_int32) as l_int32
'''  <summary>
''' Notes
''' (1) The number is to be found in the basename, which is the
''' filename without either the directory or the last extension.
''' (2) When a number is found, it is non-negative.  If no number
''' is found, this returns -1, without an error message.  The
''' caller needs to check.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - </param>
'''  <param name="numpre">[in] - number of characters before the digits to be found</param>
'''  <param name="numpost">[in] - number of characters after the digits to be found</param>
'''   <returns>num number embedded in the filename; -1 on error or if not found</returns>
Public Shared Function extractNumberFromFilename(
				ByVal fname as String, 
				ByVal numpre as Integer, 
				ByVal numpost as Integer) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.extractNumberFromFilename( fname, numpre, numpost)

	Return _Result
End Function

End Class

using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
    public partial class _All
    {

        // utils2.c (205, 1)
        // stringNew(src) as String
        // stringNew(const char *) as char *
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringNew/*"/>
        ///  <param name="src">[in] - string</param>
        ///   <returns>dest copy of src string, or NULL on error</returns>
        public static String stringNew(
                         String src)
        {

            String _Result = Natives.stringNew(src);




            return _Result;
        }

        // utils2.c (245, 1)
        // stringCopy(dest, src, n) as int
        // stringCopy(char *, const char *, l_int32) as l_ok
        ///  <summary>
        /// (1) Relatively safe wrapper for strncpy, that checks the input,
        /// and does not complain if %src is null or %n  is smaller 1.
        /// If %n  is smaller 1, this is a no-op.<para/>
        ///
        /// (2) %dest needs to be at least %n bytes in size.<para/>
        ///
        /// (3) We don't call strncpy() because valgrind complains about
        /// use of uninitialized values.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringCopy/*"/>
        ///  <param name="dest">[in] - existing byte buffer</param>
        ///  <param name="src">[in] - string [optional] can be null</param>
        ///  <param name="n">[in] - max number of characters to copy</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int stringCopy(
                         String dest,
                         String src,
                         int n)
        {

            int _Result = Natives.stringCopy(dest, src, n);




            return _Result;
        }

        // utils2.c (282, 1)
        // stringReplace(pdest, src) as int
        // stringReplace(char **, const char *) as l_ok
        ///  <summary>
        /// (1) Frees any existing dest string<para/>
        ///
        /// (2) Puts a copy of src string in the dest<para/>
        ///
        /// (3) If either or both strings are null, does something reasonable.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringReplace/*"/>
        ///  <param name="pdest">[out] - string copy</param>
        ///  <param name="src">[in] - string [optional] can be null</param>
        ///   <returns>0 if OK 1 on error</returns>
        public static int stringReplace(
                        out String[] pdest,
                         String src)
        {

            IntPtr pdestPtr = IntPtr.Zero;

            int _Result = Natives.stringReplace(out pdestPtr, src);


            if (pdestPtr == null) { pdest = null; } else { pdest = null; };


            return _Result;
        }

        // utils2.c (318, 1)
        // stringLength(src, size) as int
        // stringLength(const char *, size_t) as l_int32
        ///  <summary>
        /// (1) Safe implementation of strlen that only checks size bytes
        /// for trailing NUL.<para/>
        ///
        /// (2) Valid returned string lengths are between 0 and size - 1.
        /// If size bytes are checked without finding a NUL byte, then
        /// an error is indicated by returning size.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringLength/*"/>
        ///  <param name="src">[in] - string can be null or NULL-terminated string</param>
        ///  <param name="size">[in] - size of src buffer</param>
        ///   <returns>length of src in bytes.</returns>
        public static int stringLength(
                         String src,
                         uint size)
        {

            int _Result = Natives.stringLength(src, size);




            return _Result;
        }

        // utils2.c (359, 1)
        // stringCat(dest, size, src) as int
        // stringCat(char *, size_t, const char *) as l_int32
        ///  <summary>
        /// (1) Alternative implementation of strncat, that checks the input,
        /// is easier to use (since the size of the dest buffer is specified
        /// rather than the number of bytes to copy), and does not complain
        /// if %src is null.<para/>
        ///
        /// (2) Never writes past end of dest.<para/>
        ///
        /// (3) If it can't append src (an error), it does nothing.<para/>
        ///
        /// (4) N.B. The order of 2nd and 3rd args is reversed from that in
        /// strncat, as in the Windows function strcat_s().
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringCat/*"/>
        ///  <param name="dest">[in] - null-terminated byte buffer</param>
        ///  <param name="size">[in] - size of dest</param>
        ///  <param name="src">[in] - string can be null or NULL-terminated string</param>
        ///   <returns>number of bytes added to dest -1 on error</returns>
        public static int stringCat(
                         String dest,
                         uint size,
                         String src)
        {

            int _Result = Natives.stringCat(dest, size, src);




            return _Result;
        }

        // utils2.c (407, 1)
        // stringConcatNew(first) as String
        // stringConcatNew(const char *, ...) as char *
        ///  <summary>
        /// (1) The last arg in the list of strings must be NULL.<para/>
        ///
        /// (2) Caller must free the returned string.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringConcatNew/*"/>
        ///  <param name="first">[in] - first string in list</param>
        ///   <returns>result new string concatenating the input strings, or NULL if first == NULL</returns>
        public static String stringConcatNew(
                         String first)
        {

            String _Result = Natives.stringConcatNew(first);




            return _Result;
        }

        // utils2.c (454, 1)
        // stringJoin(src1, src2) as String
        // stringJoin(const char *, const char *) as char *
        ///  <summary>
        /// (1) This is a safe version of strcat it makes a new string.<para/>
        ///
        /// (2) It is not an error if either or both of the strings
        /// are empty, or if either or both of the pointers are null.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringJoin/*"/>
        ///  <param name="src1">[in] - string [optional] can be null</param>
        ///  <param name="src2">[in] - string [optional] can be null</param>
        ///   <returns>concatenated string, or NULL on error</returns>
        public static String stringJoin(
                         String src1,
                         String src2)
        {

            String _Result = Natives.stringJoin(src1, src2);




            return _Result;
        }

        // utils2.c (509, 1)
        // stringJoinIP(psrc1, src2) as int
        // stringJoinIP(char **, const char *) as l_ok
        ///  <summary>
        /// (1) This is a safe in-place version of strcat.  The contents of
        /// src1 is replaced by the concatenation of src1 and src2.<para/>
        ///
        /// (2) It is not an error if either or both of the strings
        /// are empty (""), or if the pointers to the strings (psrc1, src2)
        /// are null.<para/>
        ///
        /// (3) src1 should be initialized to null or an empty string
        /// before the first call.  Use one of these:
        /// char src1 = NULL
        /// char src1 = stringNew("")
        /// Then call with:
        /// stringJoinIP([and]src1, src2)<para/>
        ///
        /// (4) This can also be implemented as a macro:
        /// \code
        /// #define stringJoinIP(src1, src2) \
        /// {tmpstr = stringJoin((src1),(src2)) \
        /// LEPT_FREE(src1) \
        /// (src1) = tmpstr}
        /// \endcode<para/>
        ///
        /// (5) Another function to consider for joining many strings is
        /// stringConcatNew().
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringJoinIP/*"/>
        ///  <param name="psrc1">[in,out] - string address of src1 cannot be on the stack</param>
        ///  <param name="src2">[in] - string [optional] can be null</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int stringJoinIP(
                        ref String[] psrc1,
                         String src2)
        {

            IntPtr psrc1Ptr = Marshal.AllocHGlobal(Marshal.SizeOf(psrc1));

            int _Result = Natives.stringJoinIP(ref psrc1Ptr, src2);


            if (psrc1Ptr == null) { psrc1 = null; } else { psrc1 = null; };


            return _Result;
        }

        // utils2.c (533, 1)
        // stringReverse(src) as String
        // stringReverse(const char *) as char *
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringReverse/*"/>
        ///  <param name="src">[in] - string</param>
        ///   <returns>dest newly-allocated reversed string</returns>
        public static String stringReverse(
                         String src)
        {

            String _Result = Natives.stringReverse(src);




            return _Result;
        }

        // utils2.c (585, 1)
        // strtokSafe(cstr, seps, psaveptr) as String
        // strtokSafe(char *, const char *, char **) as char *
        ///  <summary>
        /// (1) This is a thread-safe implementation of strtok.<para/>
        ///
        /// (2) It has the same interface as strtok_r.<para/>
        ///
        /// (3) It differs from strtok_r in usage in two respects:
        /// (a) the input string is not altered
        /// (b) each returned substring is newly allocated and must
        /// be freed after use.<para/>
        ///
        /// (4) Let me repeat that.  This is "safe" because the input
        /// string is not altered and because each returned string
        /// is newly allocated on the heap.<para/>
        ///
        /// (5) It is here because, surprisingly, some C libraries don't
        /// include strtok_r.<para/>
        ///
        /// (6) Important usage points:
        /// ~ Input the string to be parsed on the first invocation.
        /// ~ Then input NULL after that the value returned in saveptr
        /// is used in all subsequent calls.<para/>
        ///
        /// (7) This is only slightly slower than strtok_r.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strtokSafe/*"/>
        ///  <param name="seps">[in] - a string of character separators</param>
        ///  <param name="psaveptr">[out] - ptr to the next char after the last encountered separator</param>
        ///   <returns>substr a new string that is copied from the previous saveptr up to but not including the next separator character, or NULL if end of cstr.</returns>
        public static String strtokSafe(
                         String _cstr_,
                         String seps,
                        out String[] psaveptr)
        {

            IntPtr psaveptrPtr = IntPtr.Zero;

            String _Result = Natives.strtokSafe(_cstr_, seps, out psaveptrPtr);


            if (psaveptrPtr == null) { psaveptr = null; } else { psaveptr = null; };


            return _Result;
        }

        // utils2.c (679, 1)
        // stringSplitOnToken(cstr, seps, phead, ptail) as int
        // stringSplitOnToken(char *, const char *, char **, char **) as l_ok
        ///  <summary>
        /// (1) The input string is not altered all split parts are new strings.<para/>
        ///
        /// (2) The split occurs around the first consecutive sequence of
        /// tokens encountered.<para/>
        ///
        /// (3) The head goes from the beginning of the string up to
        /// but not including the first token found.<para/>
        ///
        /// (4) The tail contains the second part of the string, starting
        /// with the first char in that part that is NOT a token.<para/>
        ///
        /// (5) If no separator token is found, 'head' contains a copy
        /// of the input string and 'tail' is null.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringSplitOnToken/*"/>
        ///  <param name="seps">[in] - a string of character separators</param>
        ///  <param name="phead">[out] - ptr to copy of the input string, up to the first separator token encountered</param>
        ///  <param name="ptail">[out] - ptr to copy of the part of the input string starting with the first non-separator character that occurs after the first separator is found</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int stringSplitOnToken(
                         String _cstr_,
                         String seps,
                        out String[] phead,
                        out String[] ptail)
        {

            IntPtr pheadPtr = IntPtr.Zero;
            IntPtr ptailPtr = IntPtr.Zero;

            int _Result = Natives.stringSplitOnToken(_cstr_, seps, out pheadPtr, out ptailPtr);


            if (pheadPtr == null) { phead = null; } else { phead = null; };
            if (ptailPtr == null) { ptail = null; } else { ptail = null; };


            return _Result;
        }

        // utils2.c (723, 1)
        // stringCheckForChars(src, chars, pfound) as int
        // stringCheckForChars(const char *, const char *, l_int32 *) as l_ok
        ///  <summary>
        /// (1) This can be used to sanitize an operation by checking for
        /// special characters that don't belong in a string.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringCheckForChars/*"/>
        ///  <param name="src">[in] - input string can be of zero length</param>
        ///  <param name="chars">[in] - string of chars to be searched for in %src</param>
        ///  <param name="pfound">[out] - 1 if any characters are found 0 otherwise</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int stringCheckForChars(
                         String src,
                         String chars,
                        out int pfound)
        {

            int _Result = Natives.stringCheckForChars(src, chars, out pfound);




            return _Result;
        }

        // utils2.c (758, 1)
        // stringRemoveChars(src, remchars) as String
        // stringRemoveChars(const char *, const char *) as char *
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringRemoveChars/*"/>
        ///  <param name="src">[in] - input string can be of zero length</param>
        ///  <param name="remchars">[in] - string of chars to be removed from src</param>
        ///   <returns>dest string with specified chars removed, or NULL on error</returns>
        public static String stringRemoveChars(
                         String src,
                         String remchars)
        {

            String _Result = Natives.stringRemoveChars(src, remchars);




            return _Result;
        }

        // utils2.c (803, 1)
        // stringFindSubstr(src, sub, ploc) as int
        // stringFindSubstr(const char *, const char *, l_int32 *) as l_int32
        ///  <summary>
        /// (1) This is a wrapper around strstr().<para/>
        ///
        /// (2) Both %src and %sub must be defined, and %sub must have
        /// length of at least 1.<para/>
        ///
        /// (3) If the substring is not found and loc is returned, it has
        /// the value -1.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringFindSubstr/*"/>
        ///  <param name="src">[in] - input string can be of zero length</param>
        ///  <param name="ploc">[out][optional] - location of substring in src</param>
        ///   <returns>1 if found 0 if not found or on error</returns>
        public static int stringFindSubstr(
                         String src,
                         String _sub_,
                        out int ploc)
        {

            int _Result = Natives.stringFindSubstr(src, _sub_, out ploc);




            return _Result;
        }

        // utils2.c (855, 1)
        // stringReplaceSubstr(src, sub1, sub2, pfound, ploc) as String
        // stringReplaceSubstr(const char *, const char *, const char *, l_int32 *, l_int32 *) as char *
        ///  <summary>
        /// (1) Replaces the first instance.<para/>
        ///
        /// (2) To only remove sub1, use "" for sub2<para/>
        ///
        /// (3) Returns a new string if sub1 and sub2 are the same.<para/>
        ///
        /// (4) The optional loc is input as the byte offset within the src
        /// from which the search starts, and after the search it is the
        /// char position in the string of the next character after
        /// the substituted string.<para/>
        ///
        /// (5) N.B. If ploc is not null, loc must always be initialized.
        /// To search the string from the beginning, set loc = 0.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringReplaceSubstr/*"/>
        ///  <param name="src">[in] - input string can be of zero length</param>
        ///  <param name="sub1">[in] - substring to be replaced</param>
        ///  <param name="sub2">[in] - substring to put in can be ""</param>
        ///  <param name="pfound">[out][optional] - 1 if sub1 is found 0 otherwise</param>
        ///  <param name="ploc">[out][optional] - location of ptr after replacement</param>
        ///   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
        public static String stringReplaceSubstr(
                         String src,
                         String sub1,
                         String sub2,
                        out int pfound,
                        out int ploc)
        {

            String _Result = Natives.stringReplaceSubstr(src, sub1, sub2, out pfound, out ploc);




            return _Result;
        }

        // utils2.c (922, 1)
        // stringReplaceEachSubstr(src, sub1, sub2, pcount) as String
        // stringReplaceEachSubstr(const char *, const char *, const char *, l_int32 *) as char *
        ///  <summary>
        /// (1) Replaces every instance.<para/>
        ///
        /// (2) To only remove each instance of sub1, use "" for sub2<para/>
        ///
        /// (3) Returns NULL if sub1 and sub2 are the same.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/stringReplaceEachSubstr/*"/>
        ///  <param name="src">[in] - input string can be of zero length</param>
        ///  <param name="sub1">[in] - substring to be replaced</param>
        ///  <param name="sub2">[in] - substring to put in can be ""</param>
        ///  <param name="pcount">[out][optional] - the number of times that sub1 is found in src 0 if not found</param>
        ///   <returns>dest string with substring replaced, or NULL if the substring not found or on error.</returns>
        public static String stringReplaceEachSubstr(
                         String src,
                         String sub1,
                         String sub2,
                        out int pcount)
        {

            String _Result = Natives.stringReplaceEachSubstr(src, sub1, sub2, out pcount);




            return _Result;
        }

        // utils2.c (977, 1)
        // arrayFindEachSequence(data, datalen, sequence, seqlen) as L_Dna
        // arrayFindEachSequence(const l_uint8 *, size_t, const l_uint8 *, size_t) as L_DNA *
        ///  <summary>
        /// (1) The byte arrays %data and %sequence are not C strings,
        /// as they can contain null bytes.  Therefore, for each
        /// we must give the length of the array.<para/>
        ///
        /// (2) This finds every occurrence in %data of %sequence.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/arrayFindEachSequence/*"/>
        ///  <param name="data">[in] - byte array</param>
        ///  <param name="datalen">[in] - length of data, in bytes</param>
        ///  <param name="sequence">[in] - subarray of bytes to find in data</param>
        ///  <param name="seqlen">[in] - length of sequence, in bytes</param>
        ///   <returns>dna of offsets where the sequence is found, or NULL if none are found or on error</returns>
        public static L_Dna arrayFindEachSequence(
                         Byte[] data,
                         uint datalen,
                         Byte[] sequence,
                         uint seqlen)
        {

            IntPtr _Result = Natives.arrayFindEachSequence(data, datalen, sequence, seqlen);



            if (_Result == IntPtr.Zero) { return null; }

            return new L_Dna(_Result);
        }

        // utils2.c (1037, 1)
        // arrayFindSequence(data, datalen, sequence, seqlen, poffset, pfound) as int
        // arrayFindSequence(const l_uint8 *, size_t, const l_uint8 *, size_t, l_int32 *, l_int32 *) as l_ok
        ///  <summary>
        /// (1) The byte arrays 'data' and 'sequence' are not C strings,
        /// as they can contain null bytes.  Therefore, for each
        /// we must give the length of the array.<para/>
        ///
        /// (2) This searches for the first occurrence in %data of %sequence,
        /// which consists of %seqlen bytes.  The parameter %seqlen
        /// must not exceed the actual length of the %sequence byte array.<para/>
        ///
        /// (3) If the sequence is not found, the offset will be 0, so you
        /// must check %found.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/arrayFindSequence/*"/>
        ///  <param name="data">[in] - byte array</param>
        ///  <param name="datalen">[in] - length of data, in bytes</param>
        ///  <param name="sequence">[in] - subarray of bytes to find in data</param>
        ///  <param name="seqlen">[in] - length of sequence, in bytes</param>
        ///  <param name="poffset">[out] - offset from beginning of data where the sequence begins</param>
        ///  <param name="pfound">[out] - 1 if sequence is found 0 otherwise</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int arrayFindSequence(
                         Byte[] data,
                         uint datalen,
                         Byte[] sequence,
                         uint seqlen,
                        out int poffset,
                        out int pfound)
        {

            int _Result = Natives.arrayFindSequence(data, datalen, sequence, seqlen, out poffset, out pfound);




            return _Result;
        }

        // utils2.c (1106, 1)
        // reallocNew(pindata, oldsize, newsize) as Object
        // reallocNew(void **, l_int32, l_int32) as void *
        ///  <summary>
        /// (1) If newsize smaller or equal0, just frees input data and nulls ptr<para/>
        ///
        /// (2) If input ptr is null, just callocs new memory<para/>
        ///
        /// (3) This differs from realloc in that it always allocates
        /// new memory (if newsize  is greater  0) and initializes it to 0,
        /// it requires the amount of old data to be copied,
        /// and it takes the address of the input ptr and
        /// nulls the handle.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/reallocNew/*"/>
        ///  <param name="pindata">[in,out][optional] - nulls indata</param>
        ///  <param name="oldsize">[in] - size of input data to be copied, in bytes</param>
        ///  <param name="newsize">[in] - size of data to be reallocated in bytes</param>
        ///   <returns>ptr to new data, or NULL on error Action: !N.B. 3) and (4! 1 Allocates memory, initialized to 0 2 Copies as much of the input data as possible to the new block, truncating the copy if necessary 3 Frees the input data 4 Zeroes the input data ptr</returns>
        public static Object reallocNew(
                        ref IntPtr[] pindata,
                         int oldsize,
                         int newsize)
        {

            IntPtr pindataPtr = IntPtr.Zero; if (pindata != null) { pindataPtr = Marshal.AllocHGlobal(Marshal.SizeOf(pindata)); }

            IntPtr _Result = Natives.reallocNew(ref pindataPtr, oldsize, newsize);


            if (pindataPtr == null) { pindata = null; } else { pindata = null; };

            Byte[] B = new Byte[1]; Marshal.Copy(_Result, B, 0, B.Length);

            return B;
        }

        // utils2.c (1158, 1)
        // l_binaryRead(filename, pnbytes) as Byte[]
        // l_binaryRead(const char *, size_t *) as l_uint8 *
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryRead/*"/>
        ///  <param name="filename">[in] - </param>
        ///  <param name="pnbytes">[out] - number of bytes read</param>
        ///   <returns>data, or NULL on error</returns>
        public static Byte[] l_binaryRead(
                         String filename,
                        out uint pnbytes)
        {

            Byte[] _Result = Natives.l_binaryRead(filename, out pnbytes);




            return _Result;
        }

        // utils2.c (1208, 1)
        // l_binaryReadStream(fp, pnbytes) as Byte[]
        // l_binaryReadStream(FILE *, size_t *) as l_uint8 *
        ///  <summary>
        /// (1) The returned array is terminated with a null byte so that it can
        /// be used to read ascii data from a file into a proper C string.<para/>
        ///
        /// (2) This can be used to capture data that is piped in via stdin,
        /// because it does not require seeking within the file.<para/>
        ///
        /// (3) For example, you can read an image from stdin into memory
        /// using shell redirection, with one of these shell commands:
        /// \code
        /// cat  is smallerimagefile is greater  | readprog
        /// readprog  is smaller  is smallerimagefile is greater
        /// \endcode
        /// where readprog is:
        /// \code
        /// l_uint8 data = l_binaryReadStream(stdin, [and]nbytes)
        /// Pix pix = pixReadMem(data, nbytes)
        /// \endcode
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryReadStream/*"/>
        ///  <param name="fp">[in] - file stream opened to read can be stdin</param>
        ///  <param name="pnbytes">[out] - number of bytes read</param>
        ///   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
        public static Byte[] l_binaryReadStream(
                         FILE fp,
                        out uint pnbytes)
        {

            Byte[] _Result = Natives.l_binaryReadStream(fp.Pointer, out pnbytes);




            return _Result;
        }

        // utils2.c (1275, 1)
        // l_binaryReadSelect(filename, start, nbytes, pnread) as Byte[]
        // l_binaryReadSelect(const char *, size_t, size_t, size_t *) as l_uint8 *
        ///  <summary>
        /// (1) The returned array is terminated with a null byte so that it can
        /// be used to read ascii data from a file into a proper C string.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryReadSelect/*"/>
        ///  <param name="filename">[in] - </param>
        ///  <param name="start">[in] - first byte to read</param>
        ///  <param name="nbytes">[in] - number of bytes to read use 0 to read to end of file</param>
        ///  <param name="pnread">[out] - number of bytes actually read</param>
        ///   <returns>data, or NULL on error</returns>
        public static Byte[] l_binaryReadSelect(
                         String filename,
                         uint start,
                         uint nbytes,
                        out uint pnread)
        {

            Byte[] _Result = Natives.l_binaryReadSelect(filename, start, nbytes, out pnread);




            return _Result;
        }

        // utils2.c (1320, 1)
        // l_binaryReadSelectStream(fp, start, nbytes, pnread) as Byte[]
        // l_binaryReadSelectStream(FILE *, size_t, size_t, size_t *) as l_uint8 *
        ///  <summary>
        /// (1) The returned array is terminated with a null byte so that it can
        /// be used to read ascii data from a file into a proper C string.
        /// If the file to be read is empty and %start == 0, an array
        /// with a single null byte is returned.<para/>
        ///
        /// (2) Side effect: the stream pointer is re-positioned to the
        /// beginning of the file.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryReadSelectStream/*"/>
        ///  <param name="fp">[in] - file stream</param>
        ///  <param name="start">[in] - first byte to read</param>
        ///  <param name="nbytes">[in] - number of bytes to read use 0 to read to end of file</param>
        ///  <param name="pnread">[out] - number of bytes actually read</param>
        ///   <returns>null-terminated array, or NULL on error reading 0 bytes is not an error</returns>
        public static Byte[] l_binaryReadSelectStream(
                         FILE fp,
                         uint start,
                         uint nbytes,
                        out uint pnread)
        {

            Byte[] _Result = Natives.l_binaryReadSelectStream(fp.Pointer, start, nbytes, out pnread);




            return _Result;
        }

        // utils2.c (1375, 1)
        // l_binaryWrite(filename, operation, data, nbytes) as int
        // l_binaryWrite(const char *, const char *, const void *, size_t) as l_ok
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryWrite/*"/>
        ///  <param name="filename">[in] - output</param>
        ///  <param name="operation">[in] - "w" for write "a" for append</param>
        ///  <param name="data">[in] - binary data to be written</param>
        ///  <param name="nbytes">[in] - size of data array</param>
        ///   <returns>0 if OK 1 on error</returns>
        public static int l_binaryWrite(
                         String filename,
                         String operation,
                         Object data,
                         uint nbytes)
        {

            IntPtr dataPtr = IntPtr.Zero;
            // Todo: Define coversation for object type
            if (data is Byte[])
            {
                dataPtr = Marshal.AllocHGlobal(((Byte[])data).Length);
                Marshal.Copy((Byte[])data, 0, dataPtr, ((Byte[])data).Length);
            }
            else
            {
                dataPtr = Marshal.AllocHGlobal(0);
            }

            int _Result = Natives.l_binaryWrite(filename, operation, dataPtr, nbytes);

            Marshal.FreeHGlobal(dataPtr);



            return _Result;
        }

        // utils2.c (1417, 1)
        // nbytesInFile(filename) as uint
        // nbytesInFile(const char *) as size_t
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/nbytesInFile/*"/>
        ///  <param name="filename">[in] - </param>
        ///   <returns>nbytes in file 0 on error</returns>
        public static uint nbytesInFile(
                         String filename)
        {

            uint _Result = Natives.nbytesInFile(filename);




            return _Result;
        }

        // utils2.c (1441, 1)
        // fnbytesInFile(fp) as uint
        // fnbytesInFile(FILE *) as size_t
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fnbytesInFile/*"/>
        ///  <param name="fp">[in] - file stream</param>
        ///   <returns>nbytes in file 0 on error</returns>
        public static uint fnbytesInFile(
                         FILE fp)
        {

            uint _Result = Natives.fnbytesInFile(fp.Pointer);




            return _Result;
        }

        // utils2.c (1479, 1)
        // l_binaryCopy(datas, size) as Byte[]
        // l_binaryCopy(l_uint8 *, size_t) as l_uint8 *
        ///  <summary>
        /// (1) We add 4 bytes to the zeroed output because in some cases
        /// (e.g., string handling) it is important to have the data
        /// be null terminated.  This guarantees that after the memcpy,
        /// the result is automatically null terminated.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_binaryCopy/*"/>
        ///  <param name="datas">[in] - </param>
        ///  <param name="size">[in] - of data array</param>
        ///   <returns>datad on heap, or NULL on error</returns>
        public static Byte[] l_binaryCopy(
                         Byte[] datas,
                         uint size)
        {

            Byte[] _Result = Natives.l_binaryCopy(datas, size);




            return _Result;
        }

        // utils2.c (1507, 1)
        // fileCopy(srcfile, newfile) as int
        // fileCopy(const char *, const char *) as l_ok
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileCopy/*"/>
        ///  <param name="srcfile">[in] - copy this file</param>
        ///  <param name="newfile">[in] - to this file</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int fileCopy(
                         String srcfile,
                         String newfile)
        {

            int _Result = Natives.fileCopy(srcfile, newfile);




            return _Result;
        }

        // utils2.c (1537, 1)
        // fileConcatenate(srcfile, destfile) as int
        // fileConcatenate(const char *, const char *) as l_ok
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileConcatenate/*"/>
        ///  <param name="srcfile">[in] - file to append</param>
        ///  <param name="destfile">[in] - file to add to</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int fileConcatenate(
                         String srcfile,
                         String destfile)
        {

            int _Result = Natives.fileConcatenate(srcfile, destfile);




            return _Result;
        }

        // utils2.c (1565, 1)
        // fileAppendString(filename, str) as int
        // fileAppendString(const char *, const char *) as l_ok
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fileAppendString/*"/>
        ///  <param name="filename">[in] - </param>
        ///  <param name="str">[in] - string to append to file</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int fileAppendString(
                         String filename,
                         String str)
        {

            int _Result = Natives.fileAppendString(filename, str);




            return _Result;
        }

        // utils2.c (1603, 1)
        // fopenReadStream(filename) as FILE
        // fopenReadStream(const char *) as FILE *
        ///  <summary>
        /// (1) This should be used whenever you want to run fopen() to
        /// read from a stream.  Never call fopen() directory.<para/>
        ///
        /// (2) This handles the temp directory pathname conversion on windows:
        /// /tmp  == is greater [Windows Temp directory]
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fopenReadStream/*"/>
        ///  <param name="filename">[in] - </param>
        ///   <returns>stream, or NULL on error</returns>
        public static FILE fopenReadStream(
                         String filename)
        {

            IntPtr _Result = Natives.fopenReadStream(filename);



            if (_Result == IntPtr.Zero) { return null; }

            return new FILE(_Result);
        }

        // utils2.c (1646, 1)
        // fopenWriteStream(filename, modestring) as FILE
        // fopenWriteStream(const char *, const char *) as FILE *
        ///  <summary>
        /// (1) This should be used whenever you want to run fopen() to
        /// write or append to a stream.  Never call fopen() directory.<para/>
        ///
        /// (2) This handles the temp directory pathname conversion on windows:
        /// /tmp  == is greater [Windows Temp directory]
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fopenWriteStream/*"/>
        ///  <param name="filename">[in] - </param>
        ///  <param name="modestring">[in] - </param>
        ///   <returns>stream, or NULL on error</returns>
        public static FILE fopenWriteStream(
                         String filename,
                         String modestring)
        {

            IntPtr _Result = Natives.fopenWriteStream(filename, modestring);



            if (_Result == IntPtr.Zero) { return null; }

            return new FILE(_Result);
        }

        // utils2.c (1680, 1)
        // fopenReadFromMemory(data, size) as FILE
        // fopenReadFromMemory(const l_uint8 *, size_t) as FILE *
        ///  <summary>
        /// (1) Work-around if fmemopen() not available.<para/>
        ///
        /// (2) Windows tmpfile() writes into the root C:\ directory, which
        /// requires admin privileges.  This also works around that.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fopenReadFromMemory/*"/>
        ///  <param name="data">[in] - </param>
        ///  <param name="size">[in] - </param>
        ///   <returns>file stream, or NULL on error</returns>
        public static FILE fopenReadFromMemory(
                         Byte[] data,
                         uint size)
        {

            IntPtr _Result = Natives.fopenReadFromMemory(data, size);



            if (_Result == IntPtr.Zero) { return null; }

            return new FILE(_Result);
        }

        // utils2.c (1726, 1)
        // fopenWriteWinTempfile() as FILE
        // fopenWriteWinTempfile() as FILE *
        ///  <summary>
        /// (1) The Windows version of tmpfile() writes into the root
        /// C:\ directory, which requires admin privileges.  This
        /// function provides an alternative implementation.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fopenWriteWinTempfile/*"/>
        ///   <returns>file stream, or NULL on error</returns>
        public static FILE fopenWriteWinTempfile()
        {

            IntPtr _Result = Natives.fopenWriteWinTempfile();



            if (_Result == IntPtr.Zero) { return null; }

            return new FILE(_Result);
        }

        // utils2.c (1784, 1)
        // lept_fopen(filename, mode) as FILE
        // lept_fopen(const char *, const char *) as FILE *
        ///  <summary>
        /// (1) This must be used by any application that passes
        /// a file handle to a leptonica Windows DLL.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_fopen/*"/>
        ///  <param name="filename">[in] - </param>
        ///  <param name="mode">[in] - same as for fopen() e.g., "rb"</param>
        ///   <returns>stream or NULL on error</returns>
        public static FILE lept_fopen(
                         String filename,
                         String mode)
        {

            IntPtr _Result = Natives.lept_fopen(filename, mode);



            if (_Result == IntPtr.Zero) { return null; }

            return new FILE(_Result);
        }

        // utils2.c (1814, 1)
        // lept_fclose(fp) as int
        // lept_fclose(FILE *) as l_ok
        ///  <summary>
        /// (1) This should be used by any application that accepts
        /// a file handle generated by a leptonica Windows DLL.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_fclose/*"/>
        ///  <param name="fp">[in] - file stream</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int lept_fclose(
                         FILE fp)
        {

            int _Result = Natives.lept_fclose(fp.Pointer);




            return _Result;
        }

        // utils2.c (1840, 1)
        // lept_calloc(nmemb, size) as Object
        // lept_calloc(size_t, size_t) as void *
        ///  <summary>
        /// (1) For safety with windows DLLs, this can be used in conjunction
        /// with lept_free() to avoid C-runtime boundary problems.
        /// Just use these two functions throughout your application.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_calloc/*"/>
        ///  <param name="nmemb">[in] - number of members</param>
        ///  <param name="size">[in] - of each member</param>
        ///   <returns>void ptr, or NULL on error</returns>
        public static Object lept_calloc(
                         uint nmemb,
                         uint size)
        {

            IntPtr _Result = Natives.lept_calloc(nmemb, size);



            Byte[] B = new Byte[size]; Marshal.Copy(_Result, B, 0, B.Length);

            return B;
        }

        // utils2.c (1861, 1)
        // lept_free(ptr) as Object
        // lept_free(void *) as void
        ///  <summary>
        /// (1) This should be used by any application that accepts
        /// heap data allocated by a leptonica Windows DLL.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_free/*"/>
        ///  <param name="ptr">[in] - </param>
        public static void lept_free(
                         Object ptr)
        {

            IntPtr ptrPtr = Marshal.AllocHGlobal(0);
            // Todo: Define coversation for object type

            Natives.lept_free(ptrPtr);

            Marshal.FreeHGlobal(ptrPtr);



        }

        // utils2.c (1890, 1)
        // lept_mkdir(subdir) as int
        // lept_mkdir(const char *) as l_int32
        ///  <summary>
        /// (1) %subdir is a partial path that can consist of one or more
        /// directories.<para/>
        ///
        /// (2) This makes any subdirectories of /tmp that are required.<para/>
        ///
        /// (3) The root temp directory is:
        /// /tmp  (unix)  [default]
        /// [Temp]  (windows)
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_mkdir/*"/>
        ///  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_mkdir(
                         String subdir)
        {

            int _Result = Natives.lept_mkdir(subdir);




            return _Result;
        }

        // utils2.c (1967, 1)
        // lept_rmdir(subdir) as int
        // lept_rmdir(const char *) as l_int32
        ///  <summary>
        /// (1) %subdir is a partial path that can consist of one or more
        /// directories.<para/>
        ///
        /// (2) This removes all files from the specified subdirectory of
        /// the root temp directory:
        /// /tmp  (unix)
        /// [Temp]  (windows)
        /// and then removes the subdirectory.<para/>
        ///
        /// (3) The combination
        /// lept_rmdir(subdir)
        /// lept_mkdir(subdir)
        /// is guaranteed to give you an empty subdirectory.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_rmdir/*"/>
        ///  <param name="subdir">[in] - of /tmp or its equivalent on Windows</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_rmdir(
                         String subdir)
        {

            int _Result = Natives.lept_rmdir(subdir);




            return _Result;
        }

        // utils2.c (2041, 1)
        // lept_direxists(dir, pexists) as Object
        // lept_direxists(const char *, l_int32 *) as void
        ///  <summary>
        /// (1) Always use unix pathname separators.<para/>
        ///
        /// (2) By calling genPathname(), if the pathname begins with "/tmp"
        /// this does an automatic directory translation on windows
        /// to a path in the windows [Temp] directory:
        /// "/tmp"  == is greater [Temp] (windows)
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_direxists/*"/>
        ///  <param name="dir">[in] - </param>
        ///  <param name="pexists">[out] - 1 if it exists 0 otherwise</param>
        public static void lept_direxists(
                         String dir,
                        out int pexists)
        {

            Natives.lept_direxists(dir, out pexists);




        }

        // utils2.c (2099, 1)
        // lept_rm_match(subdir, substr) as int
        // lept_rm_match(const char *, const char *) as l_int32
        ///  <summary>
        /// (1) This removes the matched files in /tmp or a subdirectory of /tmp.
        /// Use NULL for %subdir if the files are in /tmp.<para/>
        ///
        /// (2) If %substr == NULL, this removes all files in the directory.
        /// If %substr == "" (empty), this removes no files.
        /// If both %subdir == NULL and %substr == NULL, this removes
        /// all files in /tmp.<para/>
        ///
        /// (3) Use unix pathname separators.<para/>
        ///
        /// (4) By calling genPathname(), if the pathname begins with "/tmp"
        /// this does an automatic directory translation on windows
        /// to a path in the windows [Temp] directory:
        /// "/tmp"  == is greater [Temp] (windows)<para/>
        ///
        /// (5) Error conditions:
        /// returns -1 if the directory is not found
        /// returns the number of files ( is greater  0) that it was unable to remove.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_rm_match/*"/>
        ///  <param name="subdir">[in][optional] - If NULL, the removed files are in /tmp</param>
        ///  <param name="substr">[in][optional] - pattern to match in filename</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_rm_match(
                         String subdir,
                         String substr)
        {

            int _Result = Natives.lept_rm_match(subdir, substr);




            return _Result;
        }

        // utils2.c (2149, 1)
        // lept_rm(subdir, tail) as int
        // lept_rm(const char *, const char *) as l_int32
        ///  <summary>
        /// (1) By calling genPathname(), this does an automatic directory
        /// translation on windows to a path in the windows [Temp] directory:
        /// "/tmp/..."  == is greater [Temp]/... (windows)
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_rm/*"/>
        ///  <param name="subdir">[in][optional] - of '/tmp' can be NULL</param>
        ///  <param name="tail">[in] - filename without the directory</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_rm(
                         String subdir,
                         String tail)
        {

            int _Result = Natives.lept_rm(subdir, tail);




            return _Result;
        }

        // utils2.c (2189, 1)
        // lept_rmfile(filepath) as int
        // lept_rmfile(const char *) as l_int32
        ///  <summary>
        /// (1) This removes the named file.<para/>
        ///
        /// (2) Use unix pathname separators.<para/>
        ///
        /// (3) There is no name translation.<para/>
        ///
        /// (4) Unlike the other lept_ functions in this section, this can remove
        /// any file -- it is not restricted to files that are in /tmp or a
        /// subdirectory of it.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_rmfile/*"/>
        ///  <param name="filepath">[in] - full path to file including the directory</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_rmfile(
                         String filepath)
        {

            int _Result = Natives.lept_rmfile(filepath);




            return _Result;
        }

        // utils2.c (2244, 1)
        // lept_mv(srcfile, newdir, newtail, pnewpath) as int
        // lept_mv(const char *, const char *, const char *, char **) as l_int32
        ///  <summary>
        /// (1) This moves %srcfile to /tmp or to a subdirectory of /tmp.<para/>
        ///
        /// (2) %srcfile can either be a full path or relative to the
        /// current directory.<para/>
        ///
        /// (3) %newdir can either specify an existing subdirectory of /tmp
        /// or can be NULL.  In the latter case, the file will be written
        /// into /tmp.<para/>
        ///
        /// (4) %newtail can either specify a filename tail or, if NULL,
        /// the filename is taken from src-tail, the tail of %srcfile.<para/>
        ///
        /// (5) For debugging, the computed newpath can be returned.  It must
        /// be freed by the caller.<para/>
        ///
        /// (6) Reminders:
        /// (a) specify files using unix pathnames
        /// (b) for windows, translates
        /// /tmp  == is greater [Temp]
        /// where [Temp] is the windows temp directory<para/>
        ///
        /// (7) Examples:
        /// newdir = NULL,  newtail = NULL  == is greater  /tmp/src-tail
        /// newdir = NULL,  newtail = abc == is greater  /tmp/abc
        /// newdir = def/ghi, newtail = NULL  == is greater  /tmp/def/ghi/src-tail
        /// newdir = def/ghi, newtail = abc == is greater  /tmp/def/ghi/abc
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_mv/*"/>
        ///  <param name="srcfile">[in] - </param>
        ///  <param name="newdir">[in][optional] - can be NULL</param>
        ///  <param name="newtail">[in][optional] - can be NULL</param>
        ///  <param name="pnewpath">[out][optional] - of actual path can be NULL</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_mv(
                         String srcfile,
                         String newdir,
                         String newtail,
                        out String[] pnewpath)
        {

            IntPtr pnewpathPtr = IntPtr.Zero;

            int _Result = Natives.lept_mv(srcfile, newdir, newtail, out pnewpathPtr);


            if (pnewpathPtr == null) { pnewpath = null; } else { pnewpath = null; };


            return _Result;
        }

        // utils2.c (2343, 1)
        // lept_cp(srcfile, newdir, newtail, pnewpath) as int
        // lept_cp(const char *, const char *, const char *, char **) as l_int32
        ///  <summary>
        /// (1) This copies %srcfile to /tmp or to a subdirectory of /tmp.<para/>
        ///
        /// (2) %srcfile can either be a full path or relative to the
        /// current directory.<para/>
        ///
        /// (3) %newdir can either specify an existing subdirectory of /tmp,
        /// or can be NULL.  In the latter case, the file will be written
        /// into /tmp.<para/>
        ///
        /// (4) %newtail can either specify a filename tail or, if NULL,
        /// the filename is taken from src-tail, the tail of %srcfile.<para/>
        ///
        /// (5) For debugging, the computed newpath can be returned.  It must
        /// be freed by the caller.<para/>
        ///
        /// (6) Reminders:
        /// (a) specify files using unix pathnames
        /// (b) for windows, translates
        /// /tmp  == is greater [Temp]
        /// where [Temp] is the windows temp directory<para/>
        ///
        /// (7) Examples:
        /// newdir = NULL,  newtail = NULL  == is greater  /tmp/src-tail
        /// newdir = NULL,  newtail = abc == is greater  /tmp/abc
        /// newdir = def/ghi, newtail = NULL  == is greater  /tmp/def/ghi/src-tail
        /// newdir = def/ghi, newtail = abc == is greater  /tmp/def/ghi/abc
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/lept_cp/*"/>
        ///  <param name="srcfile">[in] - </param>
        ///  <param name="newdir">[in][optional] - can be NULL</param>
        ///  <param name="newtail">[in][optional] - can be NULL</param>
        ///  <param name="pnewpath">[out][optional] - of actual path can be NULL</param>
        ///   <returns>0 on success, non-zero on failure</returns>
        public static int lept_cp(
                         String srcfile,
                         String newdir,
                         String newtail,
                        out String[] pnewpath)
        {

            IntPtr pnewpathPtr = IntPtr.Zero;

            int _Result = Natives.lept_cp(srcfile, newdir, newtail, out pnewpathPtr);


            if (pnewpathPtr == null) { pnewpath = null; } else { pnewpath = null; };


            return _Result;
        }

        // utils2.c (2420, 1)
        // callSystemDebug(cmd) as Object
        // callSystemDebug(const char *) as void
        ///  <summary>
        /// (1) The C library 'system' call is only made through this function.
        /// It only works in debug/test mode, where the global variable
        /// LeptDebugOK == TRUE.  This variable is set to FALSE in the
        /// library as distributed, and calling this function will
        /// generate an error message.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/callSystemDebug/*"/>
        ///  <param name="cmd">[in] - command to be exec'd</param>
        public static void callSystemDebug(
                         String cmd)
        {

            Natives.callSystemDebug(cmd);




        }

        // utils2.c (2484, 1)
        // splitPathAtDirectory(pathname, pdir, ptail) as int
        // splitPathAtDirectory(const char *, char **, char **) as l_ok
        ///  <summary>
        /// (1) If you only want the tail, input null for the root directory ptr.<para/>
        ///
        /// (2) If you only want the root directory name, input null for the
        /// tail ptr.<para/>
        ///
        /// (3) This function makes decisions based only on the lexical
        /// structure of the input.  Examples:
        /// /usr/tmp/abc  to  dir: /usr/tmp/ tail: abc
        /// /usr/tmp/ to  dir: /usr/tmp/ tail: [empty string]
        /// /usr/tmp  to  dir: /usr/   tail: tmp
        /// abc   to  dir: [empty string]  tail: abc<para/>
        ///
        /// (4) The input can have either forward (unix) or backward (win)
        /// slash separators.  The output has unix separators.
        /// Note that Win32 pathname functions generally accept both
        /// slash forms, but the windows command line interpreter
        /// only accepts backward slashes, because forward slashes are
        /// used to demarcate switches (vs. dashes in unix).
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/splitPathAtDirectory/*"/>
        ///  <param name="pathname">[in] - full path can be a directory</param>
        ///  <param name="pdir">[out][optional] - root directory name of input path, including trailing '/'</param>
        ///  <param name="ptail">[out][optional] - path tail, which is either the file name within the root directory or the last sub-directory in the path</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int splitPathAtDirectory(
                         String pathname,
                        out String[] pdir,
                        out String[] ptail)
        {

            IntPtr pdirPtr = IntPtr.Zero;
            IntPtr ptailPtr = IntPtr.Zero;

            int _Result = Natives.splitPathAtDirectory(pathname, out pdirPtr, out ptailPtr);


            if (pdirPtr == null) { pdir = null; } else { pdir = null; };
            if (ptailPtr == null) { ptail = null; } else { ptail = null; };


            return _Result;
        }

        // utils2.c (2551, 1)
        // splitPathAtExtension(pathname, pbasename, pextension) as int
        // splitPathAtExtension(const char *, char **, char **) as l_ok
        ///  <summary>
        /// (1) If you only want the extension, input null for the basename ptr.<para/>
        ///
        /// (2) If you only want the basename without extension, input null
        /// for the extension ptr.<para/>
        ///
        /// (3) This function makes decisions based only on the lexical
        /// structure of the input.  Examples:
        /// /usr/tmp/abc.jpg  to  basename: /usr/tmp/abc  ext: .jpg
        /// /usr/tmp/.jpg to  basename: /usr/tmp/ ext: .jpg
        /// /usr/tmp.jpg/ to  basename: /usr/tmp.jpg/ ext: [empty str]
        /// ./.jpg  to  basename: ./  ext: .jpg<para/>
        ///
        /// (4) The input can have either forward (unix) or backward (win)
        /// slash separators.  The output has unix separators.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/splitPathAtExtension/*"/>
        ///  <param name="pathname">[in] - full path can be a directory</param>
        ///  <param name="pbasename">[out][optional] - pathname not including the last dot and characters after that</param>
        ///  <param name="pextension">[out][optional] - path extension, which is the last dot and the characters after it.  If there is no extension, it returns the empty string</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int splitPathAtExtension(
                         String pathname,
                        out String[] pbasename,
                        out String[] pextension)
        {

            IntPtr pbasenamePtr = IntPtr.Zero;
            IntPtr pextensionPtr = IntPtr.Zero;

            int _Result = Natives.splitPathAtExtension(pathname, out pbasenamePtr, out pextensionPtr);


            if (pbasenamePtr == null) { pbasename = null; } else { pbasename = null; };
            if (pextensionPtr == null) { pextension = null; } else { pextension = null; };


            return _Result;
        }

        // utils2.c (2630, 1)
        // pathJoin(dir, fname) as String
        // pathJoin(const char *, const char *) as char *
        ///  <summary>
        /// (1) Use unix-style pathname separators ('/').<para/>
        ///
        /// (2) %fname can be the entire path, or part of the path containing
        /// at least one directory, or a tail without a directory, or NULL.<para/>
        ///
        /// (3) It produces a path that strips multiple slashes to a single
        /// slash, joins %dir and %fname by a slash, and has no trailing
        /// slashes (except in the cases where %dir == "/" and
        /// %fname == NULL, or v.v.).<para/>
        ///
        /// (4) If both %dir and %fname are null, produces an empty string.<para/>
        ///
        /// (5) Neither %dir nor %fname can begin with '..'.<para/>
        ///
        /// (6) The result is not canonicalized or tested for correctness:
        /// garbage in (e.g., /[and]%), garbage out.<para/>
        ///
        /// (7) Examples:
        /// //tmp// + //abc/  to  /tmp/abc
        /// tmp/ + /abc/  to  tmp/abc
        /// tmp/ + abc/ to  tmp/abc
        /// /tmp/ + /// to  /tmp
        /// /tmp/ + NULL  to  /tmp
        /// // + /abc// to  /abc
        /// // + NULL to  /
        /// NULL + /abc/def/  to  /abc/def
        /// NULL + abc//  to  abc
        /// NULL + // to  /
        /// NULL + NULL to  (empty string)
        /// "" + ""   to  (empty string)
        /// "" + /  to  /
        /// ".." + /etc/foo to  NULL
        /// /tmp + ".." to  NULL
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pathJoin/*"/>
        ///  <param name="dir">[in][optional] - can be null</param>
        ///  <param name="fname">[in][optional] - can be null</param>
        ///   <returns>specially concatenated path, or NULL on error</returns>
        public static String pathJoin(
                         String dir,
                         String fname)
        {

            String _Result = Natives.pathJoin(dir, fname);




            return _Result;
        }

        // utils2.c (2709, 1)
        // appendSubdirs(basedir, subdirs) as String
        // appendSubdirs(const char *, const char *) as char *
        ///  <summary>
        /// (1) Use unix pathname separators<para/>
        ///
        /// (2) Allocates a new string:  [basedir]/[subdirs]
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/appendSubdirs/*"/>
        ///  <param name="basedir">[in] - </param>
        ///  <param name="subdirs">[in] - </param>
        ///   <returns>concatenated full directory path without trailing slash, or NULL on error</returns>
        public static String appendSubdirs(
                         String basedir,
                         String subdirs)
        {

            String _Result = Natives.appendSubdirs(basedir, subdirs);




            return _Result;
        }

        // utils2.c (2761, 1)
        // convertSepCharsInPath(path, type) as int
        // convertSepCharsInPath(char *, l_int32) as l_ok
        ///  <summary>
        /// (1) In-place conversion.<para/>
        ///
        /// (2) Type is the resulting type:
        /// UNIX_PATH_SEPCHAR:  '\\' == is greater  '/'
        /// WIN_PATH_SEPCHAR: '/' == is greater  '\\'<para/>
        ///
        /// (3) Virtually all path operations in leptonica use unix separators.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertSepCharsInPath/*"/>
        ///  <param name="path">[in] - </param>
        ///  <param name="type">[in] - UNIX_PATH_SEPCHAR, WIN_PATH_SEPCHAR</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int convertSepCharsInPath(
                         String path,
                         int type)
        {

            int _Result = Natives.convertSepCharsInPath(path, type);




            return _Result;
        }

        // utils2.c (2824, 1)
        // genPathname(dir, fname) as String
        // genPathname(const char *, const char *) as char *
        ///  <summary>
        /// (1) This function generates actual paths in the following ways:
        /// from two sub-parts (e.g., a directory and a file name).
        /// from a single path full path, placed in %dir, with
        /// %fname == NULL.
        /// from the name of a file in the local directory placed in
        /// %fname, with %dir == NULL.
        /// if in a "/tmp" directory and on windows, the windows
        /// temp directory is used.<para/>
        ///
        /// (2) On windows, if the root of %dir is '/tmp', this does a name
        /// translation:
        /// "/tmp"  == is greater [Temp] (windows)
        /// where [Temp] is the windows temp directory.<para/>
        ///
        /// (3) On unix, the TMPDIR variable is ignored.  No rewriting
        /// of temp directories is permitted.<para/>
        ///
        /// (4) There are four cases for the input:
        /// (a) %dir is a directory and %fname is defined: result is a full path
        /// (b) %dir is a directory and %fname is null: result is a directory
        /// (c) %dir is a full path and %fname is null: result is a full path
        /// (d) %dir is null or an empty string: start in the current dir
        /// result is a full path<para/>
        ///
        /// (5) In all cases, the resulting pathname is not terminated with a slash<para/>
        ///
        /// (6) The caller is responsible for freeing the returned pathname.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/genPathname/*"/>
        ///  <param name="dir">[in][optional] - directory or full path name, with or without trailing '/'</param>
        ///  <param name="fname">[in][optional] - file name within a directory</param>
        ///   <returns>pathname either a directory or full path, or NULL on error</returns>
        public static String genPathname(
                         String dir,
                         String fname)
        {

            String _Result = Natives.genPathname(dir, fname);




            return _Result;
        }

        // utils2.c (2930, 1)
        // makeTempDirname(result, nbytes, subdir) as int
        // makeTempDirname(char *, size_t, const char *) as l_ok
        ///  <summary>
        /// (1) This generates the directory path for output temp files,
        /// written into %result with unix separators.<para/>
        ///
        /// (2) Caller allocates %result, large enough to hold the path,
        /// which is:
        /// /tmp/%subdir (unix)
        /// [Temp]/%subdir (windows)
        /// where [Temp] is a path on windows determined by GenTempPath()
        /// and %subdir is in general a set of nested subdirectories:
        /// dir1/dir2/.../dirN
        /// which in use would not typically exceed 2 levels.<para/>
        ///
        /// (3) Usage example:
        /// \code
        /// char  result[256]
        /// makeTempDirname(result, 256, "lept/golden")
        /// \endcode
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/makeTempDirname/*"/>
        ///  <param name="result">[in] - preallocated on stack or heap and passed in</param>
        ///  <param name="nbytes">[in] - size of %result array, in bytes</param>
        ///  <param name="subdir">[in][optional] - can be NULL or an empty string</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int makeTempDirname(
                         String result,
                         uint nbytes,
                         String subdir)
        {

            int _Result = Natives.makeTempDirname(result, nbytes, subdir);




            return _Result;
        }

        // utils2.c (2980, 1)
        // modifyTrailingSlash(path, nbytes, flag) as int
        // modifyTrailingSlash(char *, size_t, l_int32) as l_ok
        ///  <summary>
        /// (1) This carries out the requested action if necessary.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/modifyTrailingSlash/*"/>
        ///  <param name="path">[in] - preallocated on stack or heap and passed in</param>
        ///  <param name="nbytes">[in] - size of %path array, in bytes</param>
        ///  <param name="flag">[in] - L_ADD_TRAIL_SLASH or L_REMOVE_TRAIL_SLASH</param>
        ///   <returns>0 if OK, 1 on error</returns>
        public static int modifyTrailingSlash(
                         String path,
                         uint nbytes,
                         int flag)
        {

            int _Result = Natives.modifyTrailingSlash(path, nbytes, flag);




            return _Result;
        }

        // utils2.c (3030, 1)
        // l_makeTempFilename() as String
        // l_makeTempFilename() as char *
        ///  <summary>
        /// (1) On unix, this makes a filename of the form
        /// "/tmp/lept.XXXXXX",
        /// where each X is a random character.<para/>
        ///
        /// (2) On windows, this makes a filename of the form
        /// "/[Temp]/lp.XXXXXX".<para/>
        ///
        /// (3) On all systems, this fails if the file is not writable.<para/>
        ///
        /// (4) Safest usage is to write to a subdirectory in debug code.<para/>
        ///
        /// (5) The returned filename must be freed by the caller, using lept_free.<para/>
        ///
        /// (6) The tail of the filename has a '.', so that cygwin interprets
        /// the file as having an extension.  Otherwise, cygwin assumes it
        /// is an executable and appends ".exe" to the filename.<para/>
        ///
        /// (7) On unix, whenever possible use tmpfile() instead.  tmpfile()
        /// hides the file name, returns a stream opened for write,
        /// and deletes the temp file when the stream is closed.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_makeTempFilename/*"/>
        ///   <returns>fname : heap allocated filename returns NULL on failure.</returns>
        public static String l_makeTempFilename()
        {

            String _Result = Natives.l_makeTempFilename();




            return _Result;
        }

        // utils2.c (3086, 1)
        // extractNumberFromFilename(fname, numpre, numpost) as int
        // extractNumberFromFilename(const char *, l_int32, l_int32) as l_int32
        ///  <summary>
        /// (1) The number is to be found in the basename, which is the
        /// filename without either the directory or the last extension.<para/>
        ///
        /// (2) When a number is found, it is non-negative.  If no number
        /// is found, this returns -1, without an error message.  The
        /// caller needs to check.
        ///  </summary>
        ///  <remarks>
        ///  </remarks>
        ///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractNumberFromFilename/*"/>
        ///  <param name="fname">[in] - </param>
        ///  <param name="numpre">[in] - number of characters before the digits to be found</param>
        ///  <param name="numpost">[in] - number of characters after the digits to be found</param>
        ///   <returns>num number embedded in the filename -1 on error or if not found</returns>
        public static int extractNumberFromFilename(
                         String fname,
                         int numpre,
                         int numpost)
        {

            int _Result = Natives.extractNumberFromFilename(fname, numpre, numpost);




            return _Result;
        }


    }
}

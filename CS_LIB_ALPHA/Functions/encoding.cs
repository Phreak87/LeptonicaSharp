using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// encoding.c (100, 1)
// encodeBase64(inarray, insize, poutsize) as String
// encodeBase64(l_uint8 *, l_int32, l_int32 *) as char *
///  <summary>
/// (1) The input character data is unrestricted binary.
/// The output encoded data consists of the 64 characters
/// in the base64 set, plus newlines and the pad character '='.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/encodeBase64/*"/>
///  <param name="inarray">[in] - input binary data</param>
///  <param name="insize">[in] - number of bytes in input array</param>
///  <param name="poutsize">[out] - number of bytes in output char array</param>
///   <returns>chara with MAX_BASE64_LINE characters + \n in each line</returns>
public static String encodeBase64(
				 Byte[] inarray, 
				 int insize, 
				out int poutsize){

	String _Result = Natives.encodeBase64(  inarray,   insize, out  poutsize);
	



	return _Result;
}

// encoding.c (188, 1)
// decodeBase64(inarray, insize, poutsize) as Byte[]
// decodeBase64(const char *, l_int32, l_int32 *) as l_uint8 *
///  <summary>
/// (1) The input character data should have only 66 different characters:
/// The 64 character set for base64 encoding, plus the pad
/// character '=' and newlines for formatting with fixed line
/// lengths.  If there are any other characters, the decoder
/// will declare the input data to be invalid and return NULL.<para/>
/// 
/// (2) The decoder ignores newlines and, for a valid input string,
/// stops reading input when a pad byte is found.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/decodeBase64/*"/>
///  <param name="inarray">[in] - input encoded char data, with 72 chars/line)</param>
///  <param name="insize">[in] - number of bytes in input array</param>
///  <param name="poutsize">[out] - number of bytes in output byte array</param>
///   <returns>bytea decoded byte data, or NULL on error</returns>
public static Byte[] decodeBase64(
				 String inarray, 
				 int insize, 
				out int poutsize){

	Byte[] _Result = Natives.decodeBase64(  inarray,   insize, out  poutsize);
	



	return _Result;
}

// encoding.c (339, 1)
// encodeAscii85(inarray, insize, poutsize) as String
// encodeAscii85(l_uint8 *, l_int32, l_int32 *) as char *
///  <summary>
/// (1) Ghostscript has a stack break if the last line of
/// data only has a ' is greater ', so we avoid the problem by
/// always putting '~ is greater ' on the last line.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/encodeAscii85/*"/>
///  <param name="inarray">[in] - input data</param>
///  <param name="insize">[in] - number of bytes in input array</param>
///  <param name="poutsize">[out] - number of bytes in output char array</param>
///   <returns>chara with 64 characters + \n in each line</returns>
public static String encodeAscii85(
				 Byte[] inarray, 
				 int insize, 
				out int poutsize){

	String _Result = Natives.encodeAscii85(  inarray,   insize, out  poutsize);
	



	return _Result;
}

// encoding.c (473, 1)
// decodeAscii85(inarray, insize, poutsize) as Byte[]
// decodeAscii85(char *, l_int32, l_int32 *) as l_uint8 *
///  <summary>
/// (1) We assume the data is properly encoded, so we do not check
/// for invalid characters or the final ' is greater ' character.<para/>
/// 
/// (2) We permit whitespace to be added to the encoding in an
/// arbitrary way.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/decodeAscii85/*"/>
///  <param name="inarray">[in] - ascii85 input data</param>
///  <param name="insize">[in] - number of bytes in input array</param>
///  <param name="poutsize">[out] - number of bytes in output l_uint8 array</param>
///   <returns>outarray binary</returns>
public static Byte[] decodeAscii85(
				 String inarray, 
				 int insize, 
				out int poutsize){

	Byte[] _Result = Natives.decodeAscii85(  inarray,   insize, out  poutsize);
	



	return _Result;
}

// encoding.c (587, 1)
// reformatPacked64(inarray, insize, leadspace, linechars, addquotes, poutsize) as String
// reformatPacked64(char *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as char *
///  <summary>
/// (1) Each line in the output array has %leadspace space characters,
/// followed optionally by a double-quote, followed by %linechars
/// bytes of base64 data, followed optionally by a double-quote,
/// followed by a newline.<para/>
/// 
/// (2) This can be used to convert a base64 encoded string to a
/// string formatted for inclusion in a C source file.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/reformatPacked64/*"/>
///  <param name="inarray">[in] - base64 encoded string with newlines</param>
///  <param name="insize">[in] - number of bytes in input array</param>
///  <param name="leadspace">[in] - number of spaces in each line before the data</param>
///  <param name="linechars">[in] - number of bytes of data in each line multiple of 4</param>
///  <param name="addquotes">[in] - 1 to add quotes to each line of data 0 to skip</param>
///  <param name="poutsize">[out] - number of bytes in output char array</param>
///   <returns>outarray ascii</returns>
public static String reformatPacked64(
				 String inarray, 
				 int insize, 
				 int leadspace, 
				 int linechars, 
				 int addquotes, 
				out int poutsize){

	String _Result = Natives.reformatPacked64(  inarray,   insize,   leadspace,   linechars,   addquotes, out  poutsize);
	



	return _Result;
}


}
}

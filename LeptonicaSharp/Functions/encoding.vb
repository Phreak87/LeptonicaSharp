Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\encoding.c (100, 1)
' encodeBase64()
' encodeBase64(l_uint8 *, l_int32, l_int32 *) as char *
'''  <summary>
''' Notes
''' (1) The input character data is unrestricted binary.
''' The output encoded data consists of the 64 characters
''' in the base64 set, plus newlines and the pad character '='.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="inarray">[in] - input binary data</param>
'''  <param name="insize">[in] - number of bytes in input array</param>
'''  <param name="poutsize">[out] - number of bytes in output char array</param>
'''   <returns>chara with MAX_BASE64_LINE characters + \n in each line</returns>
Public Shared Function encodeBase64(
				ByVal inarray as Byte(), 
				ByVal insize as Integer, 
				ByRef poutsize as Integer) as String

	If IsNothing (inarray) then Throw New ArgumentNullException  ("inarray cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.encodeBase64( inarray, insize, poutsize)

	Return _Result
End Function

' SRC\encoding.c (188, 1)
' decodeBase64()
' decodeBase64(const char *, l_int32, l_int32 *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) The input character data should have only 66 different characters
''' The 64 character set for base64 encoding, plus the pad
''' character '=' and newlines for formatting with fixed line
''' lengths.  If there are any other characters, the decoder
''' will declare the input data to be invalid and return NULL.
''' (2) The decoder ignores newlines and, for a valid input string,
''' stops reading input when a pad byte is found.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="inarray">[in] - input encoded char data, with 72 chars/line)</param>
'''  <param name="insize">[in] - number of bytes in input array</param>
'''  <param name="poutsize">[out] - number of bytes in output byte array</param>
'''   <returns>bytea decoded byte data, or NULL on error</returns>
Public Shared Function decodeBase64(
				ByVal inarray as String, 
				ByVal insize as Integer, 
				ByRef poutsize as Integer) as Byte()

	If IsNothing (inarray) then Throw New ArgumentNullException  ("inarray cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.decodeBase64( inarray, insize, poutsize)

	Return _Result
End Function

' SRC\encoding.c (339, 1)
' encodeAscii85()
' encodeAscii85(l_uint8 *, l_int32, l_int32 *) as char *
'''  <summary>
''' Notes
''' (1) Ghostscript has a stack break if the last line of
''' data only has a 'GT', so we avoid the problem by
''' always putting '~GT' on the last line.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="inarray">[in] - input data</param>
'''  <param name="insize">[in] - number of bytes in input array</param>
'''  <param name="poutsize">[out] - number of bytes in output char array</param>
'''   <returns>chara with 64 characters + \n in each line</returns>
Public Shared Function encodeAscii85(
				ByVal inarray as Byte(), 
				ByVal insize as Integer, 
				ByRef poutsize as Integer) as String

	If IsNothing (inarray) then Throw New ArgumentNullException  ("inarray cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.encodeAscii85( inarray, insize, poutsize)

	Return _Result
End Function

' SRC\encoding.c (473, 1)
' decodeAscii85()
' decodeAscii85(char *, l_int32, l_int32 *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) We assume the data is properly encoded, so we do not check
''' for invalid characters or the final 'GT' character.
''' (2) We permit whitespace to be added to the encoding in an
''' arbitrary way.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="inarray">[in] - ascii85 input data</param>
'''  <param name="insize">[in] - number of bytes in input array</param>
'''  <param name="poutsize">[out] - number of bytes in output l_uint8 array</param>
'''   <returns>outarray binary</returns>
Public Shared Function decodeAscii85(
				ByVal inarray as String, 
				ByVal insize as Integer, 
				ByRef poutsize as Integer) as Byte()

	If IsNothing (inarray) then Throw New ArgumentNullException  ("inarray cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.decodeAscii85( inarray, insize, poutsize)

	Return _Result
End Function

' SRC\encoding.c (587, 1)
' reformatPacked64()
' reformatPacked64(char *, l_int32, l_int32, l_int32, l_int32, l_int32 *) as char *
'''  <summary>
''' Notes
''' (1) Each line in the output array has %leadspace space characters,
''' followed optionally by a double-quote, followed by %linechars
''' bytes of base64 data, followed optionally by a double-quote,
''' followed by a newline.
''' (2) This can be used to convert a base64 encoded string to a
''' string formatted for inclusion in a C source file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="inarray">[in] - base64 encoded string with newlines</param>
'''  <param name="insize">[in] - number of bytes in input array</param>
'''  <param name="leadspace">[in] - number of spaces in each line before the data</param>
'''  <param name="linechars">[in] - number of bytes of data in each line; multiple of 4</param>
'''  <param name="addquotes">[in] - 1 to add quotes to each line of data; 0 to skip</param>
'''  <param name="poutsize">[out] - number of bytes in output char array</param>
'''   <returns>outarray ascii</returns>
Public Shared Function reformatPacked64(
				ByVal inarray as String, 
				ByVal insize as Integer, 
				ByVal leadspace as Integer, 
				ByVal linechars as Integer, 
				ByVal addquotes as Integer, 
				ByRef poutsize as Integer) as String

	If IsNothing (inarray) then Throw New ArgumentNullException  ("inarray cannot be Nothing")


	Dim _Result as String = LeptonicaSharp.Natives.reformatPacked64( inarray, insize, leadspace, linechars, addquotes, poutsize)

	Return _Result
End Function

End Class

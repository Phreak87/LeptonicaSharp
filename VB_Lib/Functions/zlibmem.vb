Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' zlibmem.c (92, 1)
' zlibCompress(datain, nin, pnout) as Byte()
' zlibCompress(l_uint8 *, size_t, size_t *) as l_uint8 *
'''  <summary>
''' (1) We repeatedly read in and fill up an input buffer,
'''compress the data, and read it back out.  zlib
'''uses two byte buffers internally in the z_stream
'''data structure.  We use the bbuffers to feed data
'''into the fixed bufferin, and feed it out of bufferout,
'''in the same way that a pair of streams would normally
'''be used if the data were being read from one file
'''and written to another.  This is done iteratively,
'''compressing L_BUF_SIZE bytes of input data at a time.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/zlibCompress/*"/>
'''  <param name="datain">[in] - byte buffer with input data</param>
'''  <param name="nin">[in] - number of bytes of input data</param>
'''  <param name="pnout">[out] - number of bytes of output data</param>
'''   <returns>dataout compressed data, or NULL on error</returns>
Public Shared Function zlibCompress(
				ByVal datain as Byte(), 
				ByVal nin as UInteger, 
				<Out()>  ByRef pnout as UInteger) as Byte()


if IsNothing (datain) then Throw New ArgumentNullException  ("datain cannot be Nothing")
	Dim _Result as Byte() = Natives.zlibCompress(  datain,   nin,   pnout)
	
	return _Result
End Function

' zlibmem.c (198, 1)
' zlibUncompress(datain, nin, pnout) as Byte()
' zlibUncompress(l_uint8 *, size_t, size_t *) as l_uint8 *
'''  <summary>
''' (1) See zlibCompress().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/zlibUncompress/*"/>
'''  <param name="datain">[in] - byte buffer with compressed input data</param>
'''  <param name="nin">[in] - number of bytes of input data</param>
'''  <param name="pnout">[out] - number of bytes of output data</param>
'''   <returns>dataout uncompressed data, or NULL on error</returns>
Public Shared Function zlibUncompress(
				ByVal datain as Byte(), 
				ByVal nin as UInteger, 
				<Out()>  ByRef pnout as UInteger) as Byte()


if IsNothing (datain) then Throw New ArgumentNullException  ("datain cannot be Nothing")
	Dim _Result as Byte() = Natives.zlibUncompress(  datain,   nin,   pnout)
	
	return _Result
End Function

End Class


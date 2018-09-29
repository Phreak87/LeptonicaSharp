Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\zlibmem.c (92, 1)
' zlibCompress()
' zlibCompress(l_uint8 *, size_t, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) We repeatedly read in and fill up an input buffer,
''' compress the data, and read it back out.  zlib
''' uses two byte buffers internally in the z_stream
''' data structure.  We use the bbuffers to feed data
''' into the fixed bufferin, and feed it out of bufferout,
''' in the same way that a pair of streams would normally
''' be used if the data were being read from one file
''' and written to another.  This is done iteratively,
''' compressing L_BUF_SIZE bytes of input data at a time.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="datain">[in] - byte buffer with input data</param>
'''  <param name="nin">[in] - number of bytes of input data</param>
'''  <param name="pnout">[out] - number of bytes of output data</param>
'''   <returns>dataout compressed data, or NULL on error</returns>
Public Shared Function zlibCompress(
				ByVal datain as Byte(), 
				ByVal nin as UInteger, 
				ByRef pnout as UInteger) as Byte()

	If IsNothing (datain) then Throw New ArgumentNullException  ("datain cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.zlibCompress( datain, nin, pnout)

	Return _Result
End Function

' SRC\zlibmem.c (198, 1)
' zlibUncompress()
' zlibUncompress(l_uint8 *, size_t, size_t *) as l_uint8 *
'''  <summary>
''' Notes
''' (1) See zlibCompress().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="datain">[in] - byte buffer with compressed input data</param>
'''  <param name="nin">[in] - number of bytes of input data</param>
'''  <param name="pnout">[out] - number of bytes of output data</param>
'''   <returns>dataout uncompressed data, or NULL on error</returns>
Public Shared Function zlibUncompress(
				ByVal datain as Byte(), 
				ByVal nin as UInteger, 
				ByRef pnout as UInteger) as Byte()

	If IsNothing (datain) then Throw New ArgumentNullException  ("datain cannot be Nothing")


	Dim _Result as Byte() = LeptonicaSharp.Natives.zlibUncompress( datain, nin, pnout)

	Return _Result
End Function

End Class

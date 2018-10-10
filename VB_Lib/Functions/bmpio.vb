Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\bmpio.c (89, 1)
' pixReadStreamBmp(fp) as Pix
' pixReadStreamBmp(FILE *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Here are references on the bmp file format:<para/>
''' http://en.wikipedia.org/wiki/BMP_file_format<para/>
''' http://www.fortunecity.com/skyscraper/windows/364/bmpffrmt.html<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadStreamBmp(
				 ByVal fp as FILE) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamBmp( fp.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bmpio.c (119, 1)
' pixReadMemBmp(cdata, size) as Pix
' pixReadMemBmp(const l_uint8 *, size_t) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="cdata">[in] - bmp data</param>
'''  <param name="size">[in] - number of bytes of bmp-formatted data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemBmp(
				 ByVal cdata as Byte(), 
				 ByVal size as UInteger) as Pix

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemBmp( cdata, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bmpio.c (351, 1)
' pixWriteStreamBmp(fp, pix) as Integer
' pixWriteStreamBmp(FILE *, PIX *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - all depths</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamBmp(
				 ByVal fp as FILE, 
				 ByVal pix as Pix) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamBmp( fp.Pointer, pix.Pointer)

	Return _Result
End Function

' SRC\bmpio.c (396, 1)
' pixWriteMemBmp(pfdata, pfsize, pixs) as Integer
' pixWriteMemBmp(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) 2 bpp bmp files are not valid in the spec, and are<para/>
''' written as 8 bpp.<para/>
''' (2) pix with depth  is lower = 8 bpp are written with a colormap.<para/>
''' 16 bpp gray and 32 bpp rgb pix are written without a colormap.<para/>
''' (3) The transparency component in an rgb pix is ignored.<para/>
''' All 32 bpp pix have the bmp alpha component set to 255 (opaque).<para/>
''' (4) The bmp colormap entries, RGBA_QUAD, are the same as<para/>
''' the ones used for colormaps in leptonica.  This allows<para/>
''' a simple memcpy for bmp output.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pfdata">[out] - data of bmp formatted image</param>
'''  <param name="pfsize">[out] - size of returned data</param>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemBmp(
				<Out()> ByRef pfdata as Byte(), 
				<Out()> ByRef pfsize as UInteger, 
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1,2,4,8,16,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16, 32 bpp")

	Dim pfdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemBmp( pfdataPTR, pfsize, pixs.Pointer)
	ReDim pfdata(IIf(pfsize > 0, pfsize, 1) - 1) : If pfdataPTR <> IntPtr.Zero Then Marshal.Copy(pfdataPTR, pfdata, 0, pfdata.count)

	Return _Result
End Function

End Class

Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\bmpio.c (89, 1)
' pixReadStreamBmp()
' pixReadStreamBmp(FILE *) as PIX *
'''  <summary>
''' Notes
''' (1) Here are references on the bmp file format
''' http//en.wikipedia.org/wiki/BMP_file_format
''' http//www.fortunecity.com/skyscraper/windows/364/bmpffrmt.html
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
' pixReadMemBmp()
' pixReadMemBmp(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cdata">[in] - bmp data</param>
'''  <param name="size">[in] - number of bytes of bmp-formatted data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemBmp(
				ByVal cdata as Byte(), 
				ByVal size as UInteger) as Pix

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")
	If IsNothing (size) then Throw New ArgumentNullException  ("size cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemBmp( cdata, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bmpio.c (351, 1)
' pixWriteStreamBmp()
' pixWriteStreamBmp(FILE *, PIX *) as l_ok
'''  <summary>
''' 
'''  </summary>
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
' pixWriteMemBmp()
' pixWriteMemBmp(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' Notes
''' (1) 2 bpp bmp files are not valid in the spec, and are
''' written as 8 bpp.
''' (2) pix with depth LT= 8 bpp are written with a colormap.
''' 16 bpp gray and 32 bpp rgb pix are written without a colormap.
''' (3) The transparency component in an rgb pix is ignored.
''' All 32 bpp pix have the bmp alpha component set to 255 (opaque).
''' (4) The bmp colormap entries, RGBA_QUAD, are the same as
''' the ones used for colormaps in leptonica.  This allows
''' a simple memcpy for bmp output.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pfdata">[out] - data of bmp formatted image</param>
'''  <param name="pfsize">[out] - size of returned data</param>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemBmp(
				ByRef pfdata as Byte(), 
				ByRef pfsize as UInteger, 
				ByVal pixs as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1,2,4,8,16,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16, 32 bpp") ' All Functions - All Parameters - CommentCheck

	Dim pfdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemBmp( pfdataPTR, pfsize, pixs.Pointer)
ReDim pfdata(IIf(1 > 0, 1, 1) - 1) : If pfdataPTR <> IntPtr.Zero Then Marshal.Copy(pfdataPTR, pfdata, 0, pfdata.count)

	Return _Result
End Function

End Class

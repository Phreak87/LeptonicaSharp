Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' pnmio.c (145, 1)
' pixReadStreamPnm(fp) as Pix
' pixReadStreamPnm(FILE *) as PIX *
'''  <summary>
''' pixReadStreamPnm()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamPnm/*"/>
'''  <param name="fp">[in] - file stream opened for read</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadStreamPnm(
				ByVal fp as FILE) as Pix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadStreamPnm(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pnmio.c (447, 1)
' readHeaderPnm(filename, pw, ph, pd, ptype, pbps, pspp) as Integer
' readHeaderPnm(const char *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' readHeaderPnm()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderPnm/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderPnm(
				ByVal filename as String, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pd as Integer = 0, 
				<Out()> Optional  ByRef ptype as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as Integer = Natives.readHeaderPnm(  filename,   pw,   ph,   pd,   ptype,   pbps,   pspp)
	
	return _Result
End Function

' pnmio.c (490, 1)
' freadHeaderPnm(fp, pw, ph, pd, ptype, pbps, pspp) as Integer
' freadHeaderPnm(FILE *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' freadHeaderPnm()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderPnm/*"/>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderPnm(
				ByVal fp as FILE, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pd as Integer = 0, 
				<Out()> Optional  ByRef ptype as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.freadHeaderPnm(fp.Pointer,   pw,   ph,   pd,   ptype,   pbps,   pspp)
	
	return _Result
End Function

' pnmio.c (667, 1)
' pixWriteStreamPnm(fp, pix) as Integer
' pixWriteStreamPnm(FILE *, PIX *) as l_ok
'''  <summary>
''' (1) This writes "raw" packed format only:
'''1 bpp to pbm (P4)
'''2, 4, 8, 16 bpp, no colormap or grayscale colormap to pgm (P5)
'''2, 4, 8 bpp with color-valued colormap, or rgb to rgb ppm (P6)<para/>
'''
'''(2) 24 bpp rgb are not supported in leptonica, but this will
'''write them out as a packed array of bytes (3 to a pixel).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPnm/*"/>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPnm(
				ByVal fp as FILE, 
				ByVal pix as Pix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteStreamPnm(fp.Pointer, pix.Pointer)
	
	return _Result
End Function

' pnmio.c (786, 1)
' pixWriteStreamAsciiPnm(fp, pix) as Integer
' pixWriteStreamAsciiPnm(FILE *, PIX *) as l_ok
'''  <summary>
''' pixWriteStreamAsciiPnm()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamAsciiPnm/*"/>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error Writes "ASCII" format only: 1 bpp to pbm P1 2, 4, 8, 16 bpp, no colormap or grayscale colormap to pgm P2 2, 4, 8 bpp with color-valued colormap, or rgb to rgb ppm P3</returns>
Public Shared Function pixWriteStreamAsciiPnm(
				ByVal fp as FILE, 
				ByVal pix as Pix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteStreamAsciiPnm(fp.Pointer, pix.Pointer)
	
	return _Result
End Function

' pnmio.c (908, 1)
' pixWriteStreamPam(fp, pix) as Integer
' pixWriteStreamPam(FILE *, PIX *) as l_ok
'''  <summary>
''' (1) This writes arbitrary PAM (P7) packed format.<para/>
'''
'''(2) 24 bpp rgb are not supported in leptonica, but this will
'''write them out as a packed array of bytes (3 to a pixel).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamPam/*"/>
'''  <param name="fp">[in] - file stream opened for write</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixWriteStreamPam(
				ByVal fp as FILE, 
				ByVal pix as Pix) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteStreamPam(fp.Pointer, pix.Pointer)
	
	return _Result
End Function

' pnmio.c (1084, 1)
' pixReadMemPnm(data, size) as Pix
' pixReadMemPnm(const l_uint8 *, size_t) as PIX *
'''  <summary>
''' (1) The %size byte of %data must be a null character.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemPnm/*"/>
'''  <param name="data">[in] - const pnm-encoded</param>
'''  <param name="size">[in] - of data</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemPnm(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Pix


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadMemPnm(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' pnmio.c (1117, 1)
' readHeaderMemPnm(data, size, pw, ph, pd, ptype, pbps, pspp) as Integer
' readHeaderMemPnm(const l_uint8 *, size_t, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' readHeaderMemPnm()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemPnm/*"/>
'''  <param name="data">[in] - const pnm-encoded</param>
'''  <param name="size">[in] - of data</param>
'''  <param name="pw">[out][optional] - </param>
'''  <param name="ph">[out][optional] - </param>
'''  <param name="pd">[out][optional] - </param>
'''  <param name="ptype">[out][optional] - pnm type</param>
'''  <param name="pbps">[out][optional] - bits/sample</param>
'''  <param name="pspp">[out][optional] - samples/pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemPnm(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pd as Integer = 0, 
				<Out()> Optional  ByRef ptype as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0) as Integer


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as Integer = Natives.readHeaderMemPnm(  data,   size,   pw,   ph,   pd,   ptype,   pbps,   pspp)
	
	return _Result
End Function

' pnmio.c (1159, 1)
' pixWriteMemPnm(pdata, psize, pix) as Integer
' pixWriteMemPnm(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' (1) See pixWriteStreamPnm() for usage.  This version writes to
'''memory instead of to a file stream.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPnm/*"/>
'''  <param name="pdata">[out] - data of PNM image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPnm(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pix as Pix) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixWriteMemPnm(  pdataPtr,   psize, pix.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' pnmio.c (1214, 1)
' pixWriteMemPam(pdata, psize, pix) as Integer
' pixWriteMemPam(l_uint8 **, size_t *, PIX *) as l_ok
'''  <summary>
''' (1) See pixWriteStreamPnm() for usage.  This version writes to
'''memory instead of to a file stream.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemPam/*"/>
'''  <param name="pdata">[out] - data of PAM image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteMemPam(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pix as Pix) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixWriteMemPam(  pdataPtr,   psize, pix.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

End Class



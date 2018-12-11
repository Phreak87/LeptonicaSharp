Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' jp2kiostub.c (47, 7)
' pixReadJp2k(filename, reduction, box, hint, debug) as Pix
' pixReadJp2k(const char *, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixReadJp2k(
				ByVal filename as String, 
				ByVal reduction as UInteger, 
				ByVal box as Box, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	If reduction < 2 or reduction > 16 then
	   Throw New ArgumentException ("")
	End if
	Dim boxPtr as IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixReadJp2k(  filename,   reduction, box.Pointer,   hint,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' jp2kiostub.c (55, 7)
' pixReadStreamJp2k(fp, reduction, box, hint, debug) as Pix
' pixReadStreamJp2k(FILE *, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixReadStreamJp2k(
				ByVal fp as FILE, 
				ByVal reduction as UInteger, 
				ByVal box as Box, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
If reduction < 2 or reduction > 16 then
	   Throw New ArgumentException ("")
	End if
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer
	Dim boxPtr as IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixReadStreamJp2k(fp.Pointer,   reduction, box.Pointer,   hint,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' jp2kiostub.c (63, 6)
' pixWriteJp2k(filename, pix, quality, nlevels, hint, debug) as Integer
' pixWriteJp2k(const char *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixWriteJp2k(
				ByVal filename as String, 
				ByVal pix as Pix, 
				ByVal quality as Integer, 
				ByVal nlevels as Integer, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pixPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as Integer = Natives.pixWriteJp2k(  filename, pix.Pointer,   quality,   nlevels,   hint,   debug)
	
	return _Result
End Function

' jp2kiostub.c (71, 6)
' pixWriteStreamJp2k(fp, pix, quality, nlevels, hint, debug) as Integer
' pixWriteStreamJp2k(FILE *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixWriteStreamJp2k(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal quality as Integer, 
				ByVal nlevels as Integer, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim fpPtr as IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPtr = fp.Pointer
	Dim pixPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as Integer = Natives.pixWriteStreamJp2k(fp.Pointer, pix.Pointer,   quality,   nlevels,   hint,   debug)
	
	return _Result
End Function

' jp2kiostub.c (79, 7)
' pixReadMemJp2k(data, size, reduction, box, hint, debug) as Pix
' pixReadMemJp2k(const l_uint8 *, size_t, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixReadMemJp2k(
				ByVal data as Byte(), 
				ByVal size as UInteger, 
				ByVal reduction as UInteger, 
				ByVal box as Box, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Pix


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
If reduction < 2 or reduction > 16 then
	   Throw New ArgumentException ("")
	End if
	Dim boxPtr as IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixReadMemJp2k(  data,   size,   reduction, box.Pointer,   hint,   debug)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' jp2kiostub.c (87, 6)
' pixWriteMemJp2k(pdata, psize, pix, quality, nlevels, hint, debug) as Integer
' pixWriteMemJp2k(l_uint8 **, size_t *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemJp2k/*"/>
'''   <returns></returns>
Public Shared Function pixWriteMemJp2k(
				ByVal pdata as object, 
				ByVal psize as object, 
				ByVal pix as Pix, 
				ByVal quality as Integer, 
				ByVal nlevels as Integer, 
				ByVal hint as Integer, 
				Optional ByVal debug as DebugOnOff = DebugOnOff.DebugOn) as Integer


if IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")
		if IsNothing (psize) then Throw New ArgumentNullException  ("psize cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pixPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPtr = pix.Pointer

	Dim _Result as Integer = Natives.pixWriteMemJp2k(  pdata,   psize, pix.Pointer,   quality,   nlevels,   hint,   debug)
	
	return _Result
End Function

End Class



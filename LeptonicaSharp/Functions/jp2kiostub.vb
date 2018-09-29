Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\jp2kiostub.c (47, 7)
' 
' pixReadJp2k(const char *, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadJp2k(
				ByRef filename as String, 
				ByRef reduction as UInteger, 
				ByRef box as Box, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Pix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("")

Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadJp2k( filename, reduction, box.Pointer, hint, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jp2kiostub.c (55, 7)
' 
' pixReadStreamJp2k(FILE *, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadStreamJp2k(
				ByRef fp as FILE, 
				ByRef reduction as UInteger, 
				ByRef box as Box, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamJp2k( fp.Pointer, reduction, box.Pointer, hint, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jp2kiostub.c (63, 6)
' 
' pixWriteJp2k(const char *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteJp2k(
				ByRef filename as String, 
				ByRef pix as Pix, 
				ByRef quality as Integer, 
				ByRef nlevels as Integer, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteJp2k( filename, pix.Pointer, quality, nlevels, hint, debug)

	Return _Result
End Function

' SRC\jp2kiostub.c (71, 6)
' 
' pixWriteStreamJp2k(FILE *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteStreamJp2k(
				ByRef fp as FILE, 
				ByRef pix as Pix, 
				ByRef quality as Integer, 
				ByRef nlevels as Integer, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim fpPTR As IntPtr = IntPtr.Zero : If Not IsNothing(fp) Then fpPTR = fp.Pointer
Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamJp2k( fp.Pointer, pix.Pointer, quality, nlevels, hint, debug)

	Return _Result
End Function

' SRC\jp2kiostub.c (79, 7)
' 
' pixReadMemJp2k(const l_uint8 *, size_t, l_uint32, BOX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixReadMemJp2k(
				ByRef data as Byte(), 
				ByRef size as UInteger, 
				ByRef reduction as UInteger, 
				ByRef box as Box, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Pix

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("")

Dim boxPTR As IntPtr = IntPtr.Zero : If Not IsNothing(box) Then boxPTR = box.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemJp2k( data, size, reduction, box.Pointer, hint, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\jp2kiostub.c (87, 6)
' 
' pixWriteMemJp2k(l_uint8 **, size_t *, PIX *, l_int32, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixWriteMemJp2k(
				ByRef pdata as Object, 
				ByRef psize as Object, 
				ByRef pix as Pix, 
				ByRef quality as Integer, 
				ByRef nlevels as Integer, 
				ByRef hint as Integer, 
				ByRef debug as Enumerations.DebugOnOff) as Integer

	If IsNothing (pdata) then Throw New ArgumentNullException  ("pdata cannot be Nothing")
	If IsNothing (psize) then Throw New ArgumentNullException  ("psize cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemJp2k( pdata, psize, pix.Pointer, quality, nlevels, hint, debug)

	Return _Result
End Function

End Class

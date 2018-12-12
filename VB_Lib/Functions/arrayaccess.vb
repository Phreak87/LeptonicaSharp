Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' arrayaccess.c (74, 1)
' l_getDataBit(line, n) as Integer
' l_getDataBit(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataBit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 1-bit pixel.</returns>
Public Shared Function l_getDataBit(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataBit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (91, 1)
' l_setDataBit(line, n) as Object
' l_setDataBit(void *, l_int32) as void
'''  <summary>
''' l_setDataBit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_setDataBit(
				ByVal line as Object, 
				ByVal n as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataBit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (108, 1)
' l_clearDataBit(line, n) as Object
' l_clearDataBit(void *, l_int32) as void
'''  <summary>
''' l_clearDataBit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataBit(
				ByVal line as Object, 
				ByVal n as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_clearDataBit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (134, 1)
' l_setDataBitVal(line, n, val) as Object
' l_setDataBitVal(void *, l_int32, l_int32) as void
'''  <summary>
''' (1) This is an accessor for a 1 bpp pix.<para/>
'''
'''(2) It is actually a little slower than using:
'''if (val == 0)
'''l_ClearDataBit(line, n)
'''else
'''l_SetDataBit(line, n)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataBitVal/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 or 1</param>
Public Shared Sub l_setDataBitVal(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataBitVal(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (155, 1)
' l_getDataDibit(line, n) as Integer
' l_getDataDibit(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataDibit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataDibit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 2-bit pixel.</returns>
Public Shared Function l_getDataDibit(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataDibit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (171, 1)
' l_setDataDibit(line, n, val) as Object
' l_setDataDibit(void *, l_int32, l_int32) as void
'''  <summary>
''' l_setDataDibit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataDibit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 - 3</param>
Public Shared Sub l_setDataDibit(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataDibit(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (194, 1)
' l_clearDataDibit(line, n) as Object
' l_clearDataDibit(void *, l_int32) as void
'''  <summary>
''' l_clearDataDibit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataDibit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataDibit(
				ByVal line as Object, 
				ByVal n as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_clearDataDibit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (209, 1)
' l_getDataQbit(line, n) as Integer
' l_getDataQbit(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataQbit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataQbit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 4-bit pixel.</returns>
Public Shared Function l_getDataQbit(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataQbit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (225, 1)
' l_setDataQbit(line, n, val) as Object
' l_setDataQbit(void *, l_int32, l_int32) as void
'''  <summary>
''' l_setDataQbit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataQbit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 - 0xf</param>
Public Shared Sub l_setDataQbit(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataQbit(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (248, 1)
' l_clearDataQbit(line, n) as Object
' l_clearDataQbit(void *, l_int32) as void
'''  <summary>
''' l_clearDataQbit()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataQbit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataQbit(
				ByVal line as Object, 
				ByVal n as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_clearDataQbit(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (263, 1)
' l_getDataByte(line, n) as Integer
' l_getDataByte(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataByte()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataByte/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th byte pixel</returns>
Public Shared Function l_getDataByte(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataByte(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (283, 1)
' l_setDataByte(line, n, val) as Object
' l_setDataByte(void *, l_int32, l_int32) as void
'''  <summary>
''' l_setDataByte()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataByte/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 - 0xff</param>
Public Shared Sub l_setDataByte(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataByte(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (303, 1)
' l_getDataTwoBytes(line, n) as Integer
' l_getDataTwoBytes(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataTwoBytes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataTwoBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th 2-byte pixel</returns>
Public Shared Function l_getDataTwoBytes(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataTwoBytes(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (323, 1)
' l_setDataTwoBytes(line, n, val) as Object
' l_setDataTwoBytes(void *, l_int32, l_int32) as void
'''  <summary>
''' l_setDataTwoBytes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataTwoBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 - 0xffff</param>
Public Shared Sub l_setDataTwoBytes(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataTwoBytes(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

' arrayaccess.c (343, 1)
' l_getDataFourBytes(line, n) as Integer
' l_getDataFourBytes(void *, l_int32) as l_int32
'''  <summary>
''' l_getDataFourBytes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataFourBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th 4-byte pixel</returns>
Public Shared Function l_getDataFourBytes(
				ByVal line as Object, 
				ByVal n as Integer) as Integer


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Dim _Result as Integer = Natives.l_getDataFourBytes(  linePtr,   n)
	
	Marshal.FreeHGlobal(linePtr)
	return _Result
End Function

' arrayaccess.c (359, 1)
' l_setDataFourBytes(line, n, val) as Object
' l_setDataFourBytes(void *, l_int32, l_int32) as void
'''  <summary>
''' l_setDataFourBytes()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataFourBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''  <param name="val">[in] - val to be inserted: 0 - 0xffffffff</param>
Public Shared Sub l_setDataFourBytes(
				ByVal line as Object, 
				ByVal n as Integer, 
				ByVal val as Integer)


if IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")
		Dim linePtr as IntPtr = 	Marshal.AllocHGlobal(0)
	If TypeOf (line) Is IntPtr Then linePtr = line
	If TypeOf (line) Is Byte() Then
	   Dim cdata = CType(line, Byte())
	   linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	   Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If
	If Not IsNothing(line.GetType.GetProperty("data")) Then
	  Dim cdata = CType(line.data, Byte())
	  linePtr = Marshal.AllocHGlobal(cdata.Length - 1)
	  Marshal.Copy(cdata, 0, linePtr, cdata.Length)
	End If

	Natives.l_setDataFourBytes(  linePtr,   n,   val)
	
	Marshal.FreeHGlobal(linePtr)
End Sub

End Class



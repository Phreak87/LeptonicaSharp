Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\arrayaccess.c (74, 1)
' l_getDataBit(line, n) as Integer
' l_getDataBit(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 1-bit pixel.</returns>
Public Shared Function l_getDataBit(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataBit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (91, 1)
' l_setDataBit(line, n) as Object
' l_setDataBit(void *, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_setDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_setDataBit(
				 ByVal line as Object, 
				 ByVal n as Integer)

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataBit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (108, 1)
' l_clearDataBit(line, n) as Object
' l_clearDataBit(void *, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataBit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataBit(
				 ByVal line as Object, 
				 ByVal n as Integer)

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_clearDataBit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (134, 1)
' l_setDataBitVal(line, n, val) as Object
' l_setDataBitVal(void *, l_int32, l_int32) as void
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is an accessor for a 1 bpp pix.<para/>
''' 
''' (2) It is actually a little slower than using:
''' if (val == 0)
''' l_ClearDataBit(line, n)
''' else
''' l_SetDataBit(line, n)
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataBitVal( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (155, 1)
' l_getDataDibit(line, n) as Integer
' l_getDataDibit(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataDibit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 2-bit pixel.</returns>
Public Shared Function l_getDataDibit(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataDibit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (171, 1)
' l_setDataDibit(line, n, val) as Object
' l_setDataDibit(void *, l_int32, l_int32) as void
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataDibit( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (194, 1)
' l_clearDataDibit(line, n) as Object
' l_clearDataDibit(void *, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataDibit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataDibit(
				 ByVal line as Object, 
				 ByVal n as Integer)

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_clearDataDibit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (209, 1)
' l_getDataQbit(line, n) as Integer
' l_getDataQbit(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataQbit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>val of the nth 4-bit pixel.</returns>
Public Shared Function l_getDataQbit(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataQbit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (225, 1)
' l_setDataQbit(line, n, val) as Object
' l_setDataQbit(void *, l_int32, l_int32) as void
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataQbit( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (248, 1)
' l_clearDataQbit(line, n) as Object
' l_clearDataQbit(void *, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_clearDataQbit/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
Public Shared Sub l_clearDataQbit(
				 ByVal line as Object, 
				 ByVal n as Integer)

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_clearDataQbit( linePTR, n)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (263, 1)
' l_getDataByte(line, n) as Integer
' l_getDataByte(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataByte/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th byte pixel</returns>
Public Shared Function l_getDataByte(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataByte( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (283, 1)
' l_setDataByte(line, n, val) as Object
' l_setDataByte(void *, l_int32, l_int32) as void
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataByte( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (303, 1)
' l_getDataTwoBytes(line, n) as Integer
' l_getDataTwoBytes(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataTwoBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th 2-byte pixel</returns>
Public Shared Function l_getDataTwoBytes(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataTwoBytes( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (323, 1)
' l_setDataTwoBytes(line, n, val) as Object
' l_setDataTwoBytes(void *, l_int32, l_int32) as void
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataTwoBytes( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

' SRC\arrayaccess.c (343, 1)
' l_getDataFourBytes(line, n) as Integer
' l_getDataFourBytes(void *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getDataFourBytes/*"/>
'''  <param name="line">[in] - ptr to beginning of data line</param>
'''  <param name="n">[in] - pixel index</param>
'''   <returns>value of the n-th 4-byte pixel</returns>
Public Shared Function l_getDataFourBytes(
				 ByVal line as Object, 
				 ByVal n as Integer) as Integer

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	Dim _Result as Integer = LeptonicaSharp.Natives.l_getDataFourBytes( linePTR, n)
Marshal.FreeHGlobal(linePTR)


	Return _Result
End Function

' SRC\arrayaccess.c (359, 1)
' l_setDataFourBytes(line, n, val) as Object
' l_setDataFourBytes(void *, l_int32, l_int32) as void
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

	If IsNothing (line) then Throw New ArgumentNullException  ("line cannot be Nothing")

	Dim linePtr As IntPtr = IntPtr.Zero
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

	LeptonicaSharp.Natives.l_setDataFourBytes( linePTR, n, val)
Marshal.FreeHGlobal(linePTR)


End Sub

End Class

Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' ptabasic.c (116, 1)
' ptaCreate(n) as Pta
' ptaCreate(l_int32) as PTA *
'''  <summary>
''' ptaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCreate/*"/>
'''  <param name="n">[in] - initial array sizes</param>
'''   <returns>pta, or NULL on error.</returns>
Public Shared Function ptaCreate(
				ByVal n as Integer) as Pta


	Dim _Result as IntPtr = Natives.ptaCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (149, 1)
' ptaCreateFromNuma(nax, nay) as Pta
' ptaCreateFromNuma(NUMA *, NUMA *) as PTA *
'''  <summary>
''' ptaCreateFromNuma()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCreateFromNuma/*"/>
'''  <param name="nax">[in][optional] - can be null</param>
'''  <param name="nay">[in] - </param>
'''   <returns>pta, or NULL on error.</returns>
Public Shared Function ptaCreateFromNuma(
				ByVal nax as Numa, 
				ByVal nay as Numa) as Pta


if IsNothing (nay) then Throw New ArgumentNullException  ("nay cannot be Nothing")
	Dim naxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nax) Then naxPtr = nax.Pointer

	Dim _Result as IntPtr = Natives.ptaCreateFromNuma(naxPtr, nay.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (192, 1)
' ptaDestroy(ppta) as Object
' ptaDestroy(PTA **) as void
'''  <summary>
''' (1) Decrements the ref count and, if 0, destroys the pta.<para/>
'''
'''(2) Always nulls the input ptr.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaDestroy/*"/>
'''  <param name="ppta">[in,out] - to be nulled</param>
Public Shared Sub ptaDestroy(
				ByRef ppta as Pta)


	Dim pptaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(ppta) Then pptaPtr = ppta.Pointer

	Natives.ptaDestroy( pptaPtr)
	
	if pptaPtr = IntPtr.Zero then ppta = Nothing else ppta = new Pta(pptaPtr)
End Sub

' ptabasic.c (225, 1)
' ptaCopy(pta) as Pta
' ptaCopy(PTA *) as PTA *
'''  <summary>
''' ptaCopy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCopy/*"/>
'''  <param name="pta">[in] - </param>
'''   <returns>copy of pta, or NULL on error</returns>
Public Shared Function ptaCopy(
				ByVal pta as Pta) as Pta


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaCopy(pta.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (257, 1)
' ptaCopyRange(ptas, istart, iend) as Pta
' ptaCopyRange(PTA *, l_int32, l_int32) as PTA *
'''  <summary>
''' ptaCopyRange()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaCopyRange/*"/>
'''  <param name="ptas">[in] - </param>
'''  <param name="istart">[in] - starting index in ptas</param>
'''  <param name="iend">[in] - ending index in ptas use 0 to copy to end</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaCopyRange(
				ByVal ptas as Pta, 
				ByVal istart as Integer, 
				ByVal iend as Integer) as Pta


if IsNothing (ptas) then Throw New ArgumentNullException  ("ptas cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaCopyRange(ptas.Pointer,   istart,   iend)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (296, 1)
' ptaClone(pta) as Pta
' ptaClone(PTA *) as PTA *
'''  <summary>
''' ptaClone()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaClone/*"/>
'''  <param name="pta">[in] - </param>
'''   <returns>ptr to same pta, or NULL on error</returns>
Public Shared Function ptaClone(
				ByVal pta as Pta) as Pta


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaClone(pta.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (320, 1)
' ptaEmpty(pta) as Integer
' ptaEmpty(PTA *) as l_ok
'''  <summary>
''' This only resets the Pta::n field, for reuse
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaEmpty/*"/>
'''  <param name="pta">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaEmpty(
				ByVal pta as Pta) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaEmpty(pta.Pointer)
	
	return _Result
End Function

' ptabasic.c (342, 1)
' ptaAddPt(pta, x, y) as Integer
' ptaAddPt(PTA *, l_float32, l_float32) as l_ok
'''  <summary>
''' ptaAddPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaAddPt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="x">[in] - </param>
'''  <param name="y">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaAddPt(
				ByVal pta as Pta, 
				ByVal x as Single, 
				ByVal y as Single) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaAddPt(pta.Pointer,   x,   y)
	
	return _Result
End Function

' ptabasic.c (404, 1)
' ptaInsertPt(pta, index, x, y) as Integer
' ptaInsertPt(PTA *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' ptaInsertPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaInsertPt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="index">[in] - at which pt is to be inserted</param>
'''  <param name="x">[in] - point values</param>
'''  <param name="y">[in] - point values</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaInsertPt(
				ByVal pta as Pta, 
				ByVal index as Integer, 
				ByVal x as Integer, 
				ByVal y as Integer) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaInsertPt(pta.Pointer,   index,   x,   y)
	
	return _Result
End Function

' ptabasic.c (447, 1)
' ptaRemovePt(pta, index) as Integer
' ptaRemovePt(PTA *, l_int32) as l_ok
'''  <summary>
''' (1) This shifts pta[i] to pta[i - 1] for all i  is greater  index.<para/>
'''
'''(2) It should not be used repeatedly on large arrays,
'''because the function is O(n).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaRemovePt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="index">[in] - of point to be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaRemovePt(
				ByVal pta as Pta, 
				ByVal index as Integer) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaRemovePt(pta.Pointer,   index)
	
	return _Result
End Function

' ptabasic.c (474, 1)
' ptaGetRefcount(pta) as Integer
' ptaGetRefcount(PTA *) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetRefcount/*"/>
'''   <returns></returns>
Public Shared Function ptaGetRefcount(
				ByVal pta as Pta) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim ptaPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pta) Then ptaPtr = pta.Pointer

	Dim _Result as Integer = Natives.ptaGetRefcount(pta.Pointer)
	
	return _Result
End Function

' ptabasic.c (485, 1)
' ptaChangeRefcount(pta, delta) as Integer
' ptaChangeRefcount(PTA *, l_int32) as l_int32
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaChangeRefcount/*"/>
'''   <returns></returns>
Public Shared Function ptaChangeRefcount(
				ByVal pta as Pta, 
				ByVal delta as Integer) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim ptaPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pta) Then ptaPtr = pta.Pointer

	Dim _Result as Integer = Natives.ptaChangeRefcount(pta.Pointer,   delta)
	
	return _Result
End Function

' ptabasic.c (504, 1)
' ptaGetCount(pta) as Integer
' ptaGetCount(PTA *) as l_int32
'''  <summary>
''' ptaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetCount/*"/>
'''  <param name="pta">[in] - </param>
'''   <returns>count, or 0 if no pta</returns>
Public Shared Function ptaGetCount(
				ByVal pta as Pta) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaGetCount(pta.Pointer)
	
	return _Result
End Function

' ptabasic.c (525, 1)
' ptaGetPt(pta, index, px, py) as Integer
' ptaGetPt(PTA *, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' ptaGetPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetPt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="index">[in] - into arrays</param>
'''  <param name="px">[out][optional] - float x value</param>
'''  <param name="py">[out][optional] - float y value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaGetPt(
				ByVal pta as Pta, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef px as Single = 0f, 
				<Out()> Optional  ByRef py as Single = 0f) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaGetPt(pta.Pointer,   index,   px,   py)
	
	return _Result
End Function

' ptabasic.c (555, 1)
' ptaGetIPt(pta, index, px, py) as Integer
' ptaGetIPt(PTA *, l_int32, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' ptaGetIPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetIPt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="index">[in] - into arrays</param>
'''  <param name="px">[out][optional] - integer x value</param>
'''  <param name="py">[out][optional] - integer y value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaGetIPt(
				ByVal pta as Pta, 
				ByVal index as Integer, 
				<Out()> Optional  ByRef px as Integer = 0, 
				<Out()> Optional  ByRef py as Integer = 0) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaGetIPt(pta.Pointer,   index,   px,   py)
	
	return _Result
End Function

' ptabasic.c (584, 1)
' ptaSetPt(pta, index, x, y) as Integer
' ptaSetPt(PTA *, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' ptaSetPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaSetPt/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="index">[in] - into arrays</param>
'''  <param name="x">[in] - </param>
'''  <param name="y">[in] - </param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaSetPt(
				ByVal pta as Pta, 
				ByVal index as Integer, 
				ByVal x as Single, 
				ByVal y as Single) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaSetPt(pta.Pointer,   index,   x,   y)
	
	return _Result
End Function

' ptabasic.c (616, 1)
' ptaGetArrays(pta, pnax, pnay) as Integer
' ptaGetArrays(PTA *, NUMA **, NUMA **) as l_ok
'''  <summary>
''' (1) This copies the internal arrays into new Numas.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaGetArrays/*"/>
'''  <param name="pta">[in] - </param>
'''  <param name="pnax">[out][optional] - numa of x array</param>
'''  <param name="pnay">[out][optional] - numa of y array</param>
'''   <returns>0 if OK 1 on error or if pta is empty</returns>
Public Shared Function ptaGetArrays(
				ByVal pta as Pta, 
				<Out()> Optional  ByRef pnax as Numa = Nothing, 
				<Out()> Optional  ByRef pnay as Numa = Nothing) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim pnaxPtr as IntPtr = IntPtr.Zero
	Dim pnayPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.ptaGetArrays(pta.Pointer, pnaxPtr, pnayPtr)
	
	if pnaxPtr = IntPtr.Zero then pnax = Nothing else pnax = new Numa(pnaxPtr)
	if pnayPtr = IntPtr.Zero then pnay = Nothing else pnay = new Numa(pnayPtr)
	return _Result
End Function

' ptabasic.c (664, 1)
' ptaRead(filename) as Pta
' ptaRead(const char *) as PTA *
'''  <summary>
''' ptaRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaRead(
				ByVal filename as String) as Pta


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.ptaRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (691, 1)
' ptaReadStream(fp) as Pta
' ptaReadStream(FILE *) as PTA *
'''  <summary>
''' ptaReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaReadStream(
				ByVal fp as FILE) as Pta


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (744, 1)
' ptaReadMem(data, size) as Pta
' ptaReadMem(const l_uint8 *, size_t) as PTA *
'''  <summary>
''' ptaReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaReadMem/*"/>
'''  <param name="data">[in] - serialization in ascii</param>
'''  <param name="size">[in] - of data in bytes can use strlen to get it</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Pta


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (782, 1)
' ptaWriteDebug(filename, pta, type) as Integer
' ptaWriteDebug(const char *, PTA *, l_int32) as l_ok
'''  <summary>
''' (1) Debug version, intended for use in the library when writing
'''to files in a temp directory with names that are compiled in.
'''This is used instead of ptaWrite() for all such library calls.<para/>
'''
'''(2) The global variable LeptDebugOK defaults to 0, and can be set
'''or cleared by the function setLeptDebugOK().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteDebug/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pta">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaWriteDebug(
				ByVal filename as String, 
				ByVal pta as Pta, 
				ByVal type as Integer) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaWriteDebug(  filename, pta.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (806, 1)
' ptaWrite(filename, pta, type) as Integer
' ptaWrite(const char *, PTA *, l_int32) as l_ok
'''  <summary>
''' ptaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="pta">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaWrite(
				ByVal filename as String, 
				ByVal pta as Pta, 
				ByVal type as Integer) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaWrite(  filename, pta.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (839, 1)
' ptaWriteStream(fp, pta, type) as Integer
' ptaWriteStream(FILE *, PTA *, l_int32) as l_ok
'''  <summary>
''' ptaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pta">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaWriteStream(
				ByVal fp as FILE, 
				ByVal pta as Pta, 
				ByVal type as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaWriteStream(fp.Pointer, pta.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (888, 1)
' ptaWriteMem(pdata, psize, pta, type) as Integer
' ptaWriteMem(l_uint8 **, size_t *, PTA *, l_int32) as l_ok
'''  <summary>
''' (1) Serializes a pta in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized pta ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pta">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pta as Pta, 
				ByVal type as Integer) as Integer


if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.ptaWriteMem(  pdataPtr,   psize, pta.Pointer,   type)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' ptabasic.c (939, 1)
' ptaaCreate(n) as Ptaa
' ptaaCreate(l_int32) as PTAA *
'''  <summary>
''' ptaaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaCreate/*"/>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaCreate(
				ByVal n as Integer) as Ptaa


	Dim _Result as IntPtr = Natives.ptaaCreate(  n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Ptaa(_Result)
End Function

' ptabasic.c (967, 1)
' ptaaDestroy(pptaa) as Object
' ptaaDestroy(PTAA **) as void
'''  <summary>
''' ptaaDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaDestroy/*"/>
'''  <param name="pptaa">[in,out] - to be nulled</param>
Public Shared Sub ptaaDestroy(
				ByRef pptaa as Ptaa)


	Dim pptaaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pptaa) Then pptaaPtr = pptaa.Pointer

	Natives.ptaaDestroy( pptaaPtr)
	
	if pptaaPtr = IntPtr.Zero then pptaa = Nothing else pptaa = new Ptaa(pptaaPtr)
End Sub

' ptabasic.c (1004, 1)
' ptaaAddPta(ptaa, pta, copyflag) as Integer
' ptaaAddPta(PTAA *, PTA *, l_int32) as l_ok
'''  <summary>
''' ptaaAddPta()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaAddPta/*"/>
'''  <param name="ptaa">[in] - </param>
'''  <param name="pta">[in] - to be added</param>
'''  <param name="copyflag">[in] - L_INSERT, L_COPY, L_CLONE</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaAddPta(
				ByVal ptaa as Ptaa, 
				ByVal pta as Pta, 
				ByVal copyflag as Enumerations.L_access_storage) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaAddPta(ptaa.Pointer, pta.Pointer,   copyflag)
	
	return _Result
End Function

' ptabasic.c (1074, 1)
' ptaaGetCount(ptaa) as Integer
' ptaaGetCount(PTAA *) as l_int32
'''  <summary>
''' ptaaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetCount/*"/>
'''  <param name="ptaa">[in] - </param>
'''   <returns>count, or 0 if no ptaa</returns>
Public Shared Function ptaaGetCount(
				ByVal ptaa as Ptaa) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaGetCount(ptaa.Pointer)
	
	return _Result
End Function

' ptabasic.c (1094, 1)
' ptaaGetPta(ptaa, index, accessflag) as Pta
' ptaaGetPta(PTAA *, l_int32, l_int32) as PTA *
'''  <summary>
''' ptaaGetPta()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetPta/*"/>
'''  <param name="ptaa">[in] - </param>
'''  <param name="index">[in] - to the i-th pta</param>
'''  <param name="accessflag">[in] - L_COPY or L_CLONE</param>
'''   <returns>pta, or NULL on error</returns>
Public Shared Function ptaaGetPta(
				ByVal ptaa as Ptaa, 
				ByVal index as Integer, 
				ByVal accessflag as Enumerations.L_access_storage) as Pta


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaaGetPta(ptaa.Pointer,   index,   accessflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ptabasic.c (1125, 1)
' ptaaGetPt(ptaa, ipta, jpt, px, py) as Integer
' ptaaGetPt(PTAA *, l_int32, l_int32, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' ptaaGetPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaGetPt/*"/>
'''  <param name="ptaa">[in] - </param>
'''  <param name="ipta">[in] - to the i-th pta</param>
'''  <param name="jpt">[in] - index to the j-th pt in the pta</param>
'''  <param name="px">[out][optional] - float x value</param>
'''  <param name="py">[out][optional] - float y value</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaaGetPt(
				ByVal ptaa as Ptaa, 
				ByVal ipta as Integer, 
				ByVal jpt as Integer, 
				<Out()> Optional  ByRef px as Single = 0f, 
				<Out()> Optional  ByRef py as Single = 0f) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaGetPt(ptaa.Pointer,   ipta,   jpt,   px,   py)
	
	return _Result
End Function

' ptabasic.c (1165, 1)
' ptaaInitFull(ptaa, pta) as Integer
' ptaaInitFull(PTAA *, PTA *) as l_ok
'''  <summary>
''' ptaaInitFull()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaInitFull/*"/>
'''  <param name="ptaa">[in] - can have non-null ptrs in the ptr array</param>
'''  <param name="pta">[in] - to be replicated into the entire ptr array</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaaInitFull(
				ByVal ptaa as Ptaa, 
				ByVal pta as Pta) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaInitFull(ptaa.Pointer, pta.Pointer)
	
	return _Result
End Function

' ptabasic.c (1204, 1)
' ptaaReplacePta(ptaa, index, pta) as Integer
' ptaaReplacePta(PTAA *, l_int32, PTA *) as l_ok
'''  <summary>
''' (1) Any existing pta is destroyed, and the input one
'''is inserted in its place.<para/>
'''
'''(2) If the index is invalid, return 1 (error)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReplacePta/*"/>
'''  <param name="ptaa">[in] - </param>
'''  <param name="index">[in] - to the index-th pta</param>
'''  <param name="pta">[in] - insert and replace any existing one</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaReplacePta(
				ByVal ptaa as Ptaa, 
				ByVal index as Integer, 
				ByVal pta as Pta) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaReplacePta(ptaa.Pointer,   index, pta.Pointer)
	
	return _Result
End Function

' ptabasic.c (1235, 1)
' ptaaAddPt(ptaa, ipta, x, y) as Integer
' ptaaAddPt(PTAA *, l_int32, l_float32, l_float32) as l_ok
'''  <summary>
''' ptaaAddPt()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaAddPt/*"/>
'''  <param name="ptaa">[in] - </param>
'''  <param name="ipta">[in] - to the i-th pta</param>
'''  <param name="x">[in] - ,y point coordinates</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaaAddPt(
				ByVal ptaa as Ptaa, 
				ByVal ipta as Integer, 
				ByVal x as Single, 
				ByVal y as Single) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaAddPt(ptaa.Pointer,   ipta,   x,   y)
	
	return _Result
End Function

' ptabasic.c (1270, 1)
' ptaaTruncate(ptaa) as Integer
' ptaaTruncate(PTAA *) as l_ok
'''  <summary>
''' (1) This identifies the largest index containing a pta that
'''has any points within it, destroys all pta above that index,
'''and resets the count.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaTruncate/*"/>
'''  <param name="ptaa">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaTruncate(
				ByVal ptaa as Ptaa) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaTruncate(ptaa.Pointer)
	
	return _Result
End Function

' ptabasic.c (1310, 1)
' ptaaRead(filename) as Ptaa
' ptaaRead(const char *) as PTAA *
'''  <summary>
''' ptaaRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaRead(
				ByVal filename as String) as Ptaa


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.ptaaRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Ptaa(_Result)
End Function

' ptabasic.c (1337, 1)
' ptaaReadStream(fp) as Ptaa
' ptaaReadStream(FILE *) as PTAA *
'''  <summary>
''' ptaaReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaReadStream(
				ByVal fp as FILE) as Ptaa


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaaReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Ptaa(_Result)
End Function

' ptabasic.c (1377, 1)
' ptaaReadMem(data, size) as Ptaa
' ptaaReadMem(const l_uint8 *, size_t) as PTAA *
'''  <summary>
''' ptaaReadMem()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaReadMem/*"/>
'''  <param name="data">[in] - serialization in ascii</param>
'''  <param name="size">[in] - of data in bytes can use strlen to get it</param>
'''   <returns>ptaa, or NULL on error</returns>
Public Shared Function ptaaReadMem(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Ptaa


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.ptaaReadMem(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Ptaa(_Result)
End Function

' ptabasic.c (1415, 1)
' ptaaWriteDebug(filename, ptaa, type) as Integer
' ptaaWriteDebug(const char *, PTAA *, l_int32) as l_ok
'''  <summary>
''' (1) Debug version, intended for use in the library when writing
'''to files in a temp directory with names that are compiled in.
'''This is used instead of ptaaWrite() for all such library calls.<para/>
'''
'''(2) The global variable LeptDebugOK defaults to 0, and can be set
'''or cleared by the function setLeptDebugOK().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteDebug/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="ptaa">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaWriteDebug(
				ByVal filename as String, 
				ByVal ptaa as Ptaa, 
				ByVal type as Integer) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaWriteDebug(  filename, ptaa.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (1439, 1)
' ptaaWrite(filename, ptaa, type) as Integer
' ptaaWrite(const char *, PTAA *, l_int32) as l_ok
'''  <summary>
''' ptaaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="ptaa">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaWrite(
				ByVal filename as String, 
				ByVal ptaa as Ptaa, 
				ByVal type as Integer) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaWrite(  filename, ptaa.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (1472, 1)
' ptaaWriteStream(fp, ptaa, type) as Integer
' ptaaWriteStream(FILE *, PTAA *, l_int32) as l_ok
'''  <summary>
''' ptaaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="ptaa">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ptaaWriteStream(
				ByVal fp as FILE, 
				ByVal ptaa as Ptaa, 
				ByVal type as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim _Result as Integer = Natives.ptaaWriteStream(fp.Pointer, ptaa.Pointer,   type)
	
	return _Result
End Function

' ptabasic.c (1514, 1)
' ptaaWriteMem(pdata, psize, ptaa, type) as Integer
' ptaaWriteMem(l_uint8 **, size_t *, PTAA *, l_int32) as l_ok
'''  <summary>
''' (1) Serializes a ptaa in memory and puts the result in a buffer.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ptaaWriteMem/*"/>
'''  <param name="pdata">[out] - data of serialized ptaa ascii</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="ptaa">[in] - </param>
'''  <param name="type">[in] - 0 for float values 1 for integer values</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ptaaWriteMem(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal ptaa as Ptaa, 
				ByVal type as Integer) as Integer


if IsNothing (ptaa) then Throw New ArgumentNullException  ("ptaa cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.ptaaWriteMem(  pdataPtr,   psize, ptaa.Pointer,   type)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

End Class



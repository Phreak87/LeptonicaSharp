Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' stringcode.c (156, 1)
' strcodeCreate(fileno) as L_StrCode
' strcodeCreate(l_int32) as L_STRCODE *
'''  <summary>
''' (1) This struct exists to build two files containing code for
'''any number of data objects.  The two files are named
'''autogen.[fileno].c
'''autogen.[fileno].h
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeCreate/*"/>
'''  <param name="fileno">[in] - integer that labels the two output files</param>
'''   <returns>initialized L_StrCode, or NULL on error</returns>
Public Shared Function strcodeCreate(
				ByVal fileno as Integer) as L_StrCode


	Dim _Result as IntPtr = Natives.strcodeCreate(  fileno)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_StrCode(_Result)
End Function

' stringcode.c (223, 1)
' strcodeCreateFromFile(filein, fileno, outdir) as Integer
' strcodeCreateFromFile(const char *, l_int32, const char *) as l_ok
'''  <summary>
''' (1) The %filein has one filename on each line.
'''Comment lines begin with "#".<para/>
'''
'''(2) The output is 2 files:
'''autogen.[fileno].c
'''autogen.[fileno].h
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeCreateFromFile/*"/>
'''  <param name="filein">[in] - containing filenames of serialized data</param>
'''  <param name="fileno">[in] - integer that labels the two output files</param>
'''  <param name="outdir">[in][optional] - if null, files are made in /tmp/lept/auto</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function strcodeCreateFromFile(
				ByVal filein as String, 
				ByVal fileno as Integer, 
				Optional ByVal outdir as String = "") as Integer


if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	Dim _Result as Integer = Natives.strcodeCreateFromFile(  filein,   fileno,   outdir)
	
	return _Result
End Function

' stringcode.c (289, 1)
' strcodeGenerate(strcode, filein, type) as Integer
' strcodeGenerate(L_STRCODE *, const char *, const char *) as l_ok
'''  <summary>
''' (1) The generated function name is
'''l_autodecode_[fileno]()
'''where [fileno] is the index label for the pair of output files.<para/>
'''
'''(2) To deserialize this data, the function is called with the
'''argument 'ifunc', which increments each time strcodeGenerate()
'''is called.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeGenerate/*"/>
'''  <param name="strcode">[in] - for accumulating data</param>
'''  <param name="filein">[in] - input file with serialized data</param>
'''  <param name="type">[in] - of data use the typedef string</param>
'''   <returns>0 if OK, 1 on error.</returns>
Public Shared Function strcodeGenerate(
				ByVal strcode as L_StrCode, 
				ByVal filein as String, 
				ByVal type as String) as Integer


if IsNothing (strcode) then Throw New ArgumentNullException  ("strcode cannot be Nothing")
		if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
		if IsNothing (type) then Throw New ArgumentNullException  ("type cannot be Nothing")
	Dim _Result as Integer = Natives.strcodeGenerate(strcode.Pointer,   filein,   type)
	
	return _Result
End Function

' stringcode.c (336, 1)
' strcodeFinalize(pstrcode, outdir) as Integer
' strcodeFinalize(L_STRCODE **, const char *) as l_int32
'''  <summary>
''' strcodeFinalize()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/strcodeFinalize/*"/>
'''  <param name="pstrcode">[in,out] - destroys after .c and .h files have been generated</param>
'''  <param name="outdir">[in][optional] - if NULL, files are made in /tmp/lept/auto</param>
'''   <returns>void</returns>
Public Shared Function strcodeFinalize(
				ByRef pstrcode as L_StrCode, 
				Optional ByVal outdir as String = "") as Integer


	Dim pstrcodePtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pstrcode) Then pstrcodePtr = pstrcode.Pointer

	Dim _Result as Integer = Natives.strcodeFinalize( pstrcodePtr,   outdir)
	
	if pstrcodePtr = IntPtr.Zero then pstrcode = Nothing else pstrcode = new L_StrCode(pstrcodePtr)
	return _Result
End Function

' stringcode.c (525, 1)
' l_getStructStrFromFile(filename, field, pstr) as Integer
' l_getStructStrFromFile(const char *, l_int32, char **) as l_int32
'''  <summary>
''' (1) For example, if %field == L_STR_NAME, and the file is a serialized
'''pixa, this will return "Pixa", the name of the struct.<para/>
'''
'''(2) Caller must free the returned string.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_getStructStrFromFile/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="field">[in] - (L_STR_TYPE, L_STR_NAME, L_STR_READER, L_STR_MEMREADER)</param>
'''  <param name="pstr">[out] - struct string for this file</param>
'''   <returns>0 if found, 1 on error.</returns>
Public Shared Function l_getStructStrFromFile(
				ByVal filename as String, 
				ByVal field as Enumerations.L_STR, 
				<Out()>  ByRef pstr as String()) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim pstrPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.l_getStructStrFromFile(  filename,   field,   pstrPtr)
	
	if IsNothing(pstr) then pstr = nothing else pstr = pstr
	return _Result
End Function

End Class



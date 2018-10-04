Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\fmorphauto.c (243, 1)
' fmorphautogen(sela, fileindex, filename) as Integer
' fmorphautogen(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function generates all the code for implementing<para/>
''' dwa morphological operations using all the sels in the sela.<para/>
''' (2) See fmorphautogen1() and fmorphautogen2() for details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fmorphautogen(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fmorphauto.c (283, 1)
' fmorphautogen1(sela, fileindex, filename) as Integer
' fmorphautogen1(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function uses morphtemplate1.txt to create a<para/>
''' top-level file that contains two functions.  These<para/>
''' functions will carry out dilation, erosion,<para/>
''' opening or closing for any of the sels in the input sela.<para/>
''' (2) The fileindex parameter is inserted into the output<para/>
''' filename, as described below.<para/>
''' (3) If filename == NULL, the output file is fmorphgen.[n].c,<para/>
''' where [n] is equal to the %fileindex parameter.<para/>
''' (4) If filename != NULL, the output file is [%filename].[n].c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fmorphautogen1(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen1( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fmorphauto.c (490, 1)
' fmorphautogen2(sela, fileindex, filename) as Integer
' fmorphautogen2(SELA *, l_int32, const char *) as l_int32
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fmorphautogen2(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen2( sela.Pointer, fileindex, filename)

	Return _Result
End Function

End Class

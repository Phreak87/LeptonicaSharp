Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\fmorphauto.c (243, 1)
' fmorphautogen()
' fmorphautogen(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function generates all the code for implementing
''' dwa morphological operations using all the sels in the sela.
''' (2) See fmorphautogen1() and fmorphautogen2() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - ; can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fmorphautogen(
				ByVal sela as Sela, 
				ByVal fileindex as Integer, 
				Optional ByVal filename as String = Nothing) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fmorphauto.c (283, 1)
' fmorphautogen1()
' fmorphautogen1(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function uses morphtemplate1.txt to create a
''' top-level file that contains two functions.  These
''' functions will carry out dilation, erosion,
''' opening or closing for any of the sels in the input sela.
''' (2) The fileindex parameter is inserted into the output
''' filename, as described below.
''' (3) If filename == NULL, the output file is fmorphgen.[n].c,
''' where [n] is equal to the %fileindex parameter.
''' (4) If filename != NULL, the output file is [%filename].[n].c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - ; can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fmorphautogen1(
				ByVal sela as Sela, 
				ByVal fileindex as Integer, 
				Optional ByVal filename as String = Nothing) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen1( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fmorphauto.c (490, 1)
' 
' fmorphautogen2(SELA *, l_int32, const char *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function fmorphautogen2(
				ByRef sela as Sela, 
				ByRef fileindex as Integer, 
				ByRef filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")

Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.fmorphautogen2( sela.Pointer, fileindex, filename)

	Return _Result
End Function

End Class

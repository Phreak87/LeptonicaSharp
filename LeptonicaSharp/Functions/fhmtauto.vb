Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\fhmtauto.c (207, 1)
' fhmtautogen()
' fhmtautogen(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function generates all the code for implementing
''' dwa morphological operations using all the sels in the sela.
''' (2) See fhmtautogen1() and fhmtautogen2() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - ; can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fhmtautogen(
				ByVal sela as Sela, 
				ByVal fileindex as Integer, 
				ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fhmtauto.c (249, 1)
' fhmtautogen1()
' fhmtautogen1(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function uses hmttemplate1.txt to create a
''' top-level file that contains two functions that carry
''' out the hit-miss transform for any of the sels in
''' the input sela.
''' (2) The fileindex parameter is inserted into the output
''' filename, as described below.
''' (3) If filename == NULL, the output file is fhmtgen.[n].c,
''' where [n] is equal to the 'fileindex' parameter.
''' (4) If filename != NULL, the output file is [filename].[n].c.
''' (5) Each sel must have at least one hit.  A sel with only misses
''' generates code that will abort the operation if it is called.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - array</param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - ; can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fhmtautogen1(
				ByVal sela as Sela, 
				ByVal fileindex as Integer, 
				ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen1( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fhmtauto.c (431, 1)
' fhmtautogen2()
' fhmtautogen2(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This function uses hmttemplate2.txt to create a
''' low-level file that contains the low-level functions for
''' implementing the hit-miss transform for every sel
''' in the input sela.
''' (2) The fileindex parameter is inserted into the output
''' filename, as described below.
''' (3) If filename == NULL, the output file is fhmtgenlow.[n].c,
''' where [n] is equal to the %fileindex parameter.
''' (4) If filename != NULL, the output file is [filename]low.[n].c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - array</param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - ; can be null</param>
'''   <returns>0 if OK; 1 on error</returns>
Public Shared Function fhmtautogen2(
				ByVal sela as Sela, 
				ByVal fileindex as Integer, 
				ByVal filename as String) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen2( sela.Pointer, fileindex, filename)

	Return _Result
End Function

End Class

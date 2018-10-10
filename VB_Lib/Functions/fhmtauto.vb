Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\fhmtauto.c (207, 1)
' fhmtautogen(sela, fileindex, filename) as Integer
' fhmtautogen(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function generates all the code for implementing<para/>
''' dwa morphological operations using all the sels in the sela.<para/>
''' (2) See fhmtautogen1() and fhmtautogen2() for details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - </param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fhmtautogen(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 Optional ByVal filename as String = Nothing) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fhmtauto.c (249, 1)
' fhmtautogen1(sela, fileindex, filename) as Integer
' fhmtautogen1(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function uses hmttemplate1.txt to create a<para/>
''' top-level file that contains two functions that carry<para/>
''' out the hit-miss transform for any of the sels in<para/>
''' the input sela.<para/>
''' (2) The fileindex parameter is inserted into the output<para/>
''' filename, as described below.<para/>
''' (3) If filename == NULL, the output file is fhmtgen.[n].c,<para/>
''' where [n] is equal to the 'fileindex' parameter.<para/>
''' (4) If filename != NULL, the output file is [filename].[n].c.<para/>
''' (5) Each sel must have at least one hit.  A sel with only misses<para/>
''' generates code that will abort the operation if it is called.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - array</param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fhmtautogen1(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 Optional ByVal filename as String = Nothing) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen1( sela.Pointer, fileindex, filename)

	Return _Result
End Function

' SRC\fhmtauto.c (431, 1)
' fhmtautogen2(sela, fileindex, filename) as Integer
' fhmtautogen2(SELA *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function uses hmttemplate2.txt to create a<para/>
''' low-level file that contains the low-level functions for<para/>
''' implementing the hit-miss transform for every sel<para/>
''' in the input sela.<para/>
''' (2) The fileindex parameter is inserted into the output<para/>
''' filename, as described below.<para/>
''' (3) If filename == NULL, the output file is fhmtgenlow.[n].c,<para/>
''' where [n] is equal to the %fileindex parameter.<para/>
''' (4) If filename != NULL, the output file is [filename]low.[n].c.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in] - array</param>
'''  <param name="fileindex">[in] - </param>
'''  <param name="filename">[in][optional] - can be null</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fhmtautogen2(
				 ByVal sela as Sela, 
				 ByVal fileindex as Integer, 
				 Optional ByVal filename as String = Nothing) as Integer

	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")

	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim _Result as Integer = LeptonicaSharp.Natives.fhmtautogen2( sela.Pointer, fileindex, filename)

	Return _Result
End Function

End Class

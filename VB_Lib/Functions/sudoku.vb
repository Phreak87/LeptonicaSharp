Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' sudoku.c (181, 1)
' sudokuReadFile(filename) as Integer()
' sudokuReadFile(const char *) as l_int32 *
'''  <summary>
''' (1) The file format has:
'''any number of comment lines beginning with '#'
'''a set of 9 lines, each having 9 digits (0-9) separated
'''by a space
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuReadFile/*"/>
'''  <param name="filename">[in] - of formatted sudoku file</param>
'''   <returns>array of 81 numbers, or NULL on error</returns>
Public Shared Function sudokuReadFile(
				ByVal filename as String) as Integer()


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as Integer() = Natives.sudokuReadFile(  filename)
	
	return _Result
End Function

' sudoku.c (260, 1)
' sudokuReadString(str) as Integer()
' sudokuReadString(const char *) as l_int32 *
'''  <summary>
''' (1) The string is formatted as 81 single digits, each separated
'''by 81 spaces.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuReadString/*"/>
'''  <param name="str">[in] - of input data</param>
'''   <returns>array of 81 numbers, or NULL on error</returns>
Public Shared Function sudokuReadString(
				ByVal str as String) as Integer()


if IsNothing (str) then Throw New ArgumentNullException  ("str cannot be Nothing")
	Dim _Result as Integer() = Natives.sudokuReadString(  str)
	
	return _Result
End Function

' sudoku.c (301, 1)
' sudokuCreate(array) as L_Sudoku
' sudokuCreate(l_int32 *) as L_SUDOKU *
'''  <summary>
''' (1) The input array has 0 for the unknown values, and 1-9
'''for the known initial values.  It is generated from
'''a file using sudokuReadInput(), which checks that the file
'''data has 81 numbers in 9 rows.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuCreate/*"/>
'''  <param name="array">[in] - of 81 numbers, 9 rows of 9 numbers each</param>
'''   <returns>l_sudoku, or NULL on error</returns>
Public Shared Function sudokuCreate(
				ByVal array as Integer()) as L_Sudoku


if IsNothing (array) then Throw New ArgumentNullException  ("array cannot be Nothing")
	Dim _Result as IntPtr = Natives.sudokuCreate(  array)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Sudoku(_Result)
End Function

' sudoku.c (337, 1)
' sudokuDestroy(psud) as Object
' sudokuDestroy(L_SUDOKU **) as void
'''  <summary>
''' sudokuDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuDestroy/*"/>
'''  <param name="psud">[in,out] - to be nulled</param>
Public Shared Sub sudokuDestroy(
				ByRef psud as L_Sudoku)


	Dim psudPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(psud) Then psudPtr = psud.Pointer

	Natives.sudokuDestroy( psudPtr)
	
	if psudPtr = IntPtr.Zero then psud = Nothing else psud = new L_Sudoku(psudPtr)
End Sub

' sudoku.c (371, 1)
' sudokuSolve(sud) as Integer
' sudokuSolve(L_SUDOKU *) as l_int32
'''  <summary>
''' sudokuSolve()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuSolve/*"/>
'''  <param name="sud">[in] - l_sudoku starting in initial state</param>
'''   <returns>1 on success, 0 on failure to solve note reversal of typical unix returns</returns>
Public Shared Function sudokuSolve(
				ByVal sud as L_Sudoku) as Integer


if IsNothing (sud) then Throw New ArgumentNullException  ("sud cannot be Nothing")
	Dim _Result as Integer = Natives.sudokuSolve(sud.Pointer)
	
	return _Result
End Function

' sudoku.c (562, 1)
' sudokuTestUniqueness(array, punique) as Integer
' sudokuTestUniqueness(l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) This applies the brute force method to all four 90 degree
'''rotations.  If there is more than one solution, it is highly
'''unlikely that all four results will be the same
'''consequently, if they are the same, the solution is
'''most likely to be unique.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuTestUniqueness/*"/>
'''  <param name="array">[in] - of 81 numbers, 9 lines of 9 numbers each</param>
'''  <param name="punique">[out] - 1 if unique, 0 if not</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function sudokuTestUniqueness(
				ByVal array as Integer(), 
				<Out()>  ByRef punique as Integer) as Integer


if IsNothing (array) then Throw New ArgumentNullException  ("array cannot be Nothing")
	Dim _Result as Integer = Natives.sudokuTestUniqueness(  array,   punique)
	
	return _Result
End Function

' sudoku.c (731, 1)
' sudokuGenerate(array, seed, minelems, maxtries) as L_Sudoku
' sudokuGenerate(l_int32 *, l_int32, l_int32, l_int32) as L_SUDOKU *
'''  <summary>
''' (1) This is a brute force generator.  It starts with a completed
'''sudoku solution and, by removing elements (setting them to 0),
'''generates a valid (unique) sudoku initial condition.<para/>
'''
'''(2) The process stops when either %minelems, the minimum
'''number of non-zero elements, is reached, or when the
'''number of attempts to remove the next element exceeds %maxtries.<para/>
'''
'''(3) No sudoku is known with less than 17 nonzero elements.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuGenerate/*"/>
'''  <param name="array">[in] - of 81 numbers, 9 rows of 9 numbers each</param>
'''  <param name="seed">[in] - random number</param>
'''  <param name="minelems">[in] - min non-zero elements allowed smaller or equal 80</param>
'''  <param name="maxtries">[in] - max tries to remove a number and get a valid sudoku</param>
'''   <returns>l_sudoku, or NULL on error</returns>
Public Shared Function sudokuGenerate(
				ByVal array as Integer(), 
				ByVal seed as Integer, 
				ByVal minelems as Integer, 
				ByVal maxtries as Integer) as L_Sudoku


if IsNothing (array) then Throw New ArgumentNullException  ("array cannot be Nothing")
	Dim _Result as IntPtr = Natives.sudokuGenerate(  array,   seed,   minelems,   maxtries)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_Sudoku(_Result)
End Function

' sudoku.c (854, 1)
' sudokuOutput(sud, arraytype) as Integer
' sudokuOutput(L_SUDOKU *, l_int32) as l_int32
'''  <summary>
''' (1) Prints either the initial array or the current state
'''of the solution.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/sudokuOutput/*"/>
'''  <param name="sud">[in] - l_sudoku at any stage</param>
'''  <param name="arraytype">[in] - L_SUDOKU_INIT, L_SUDOKU_STATE</param>
'''   <returns>void</returns>
Public Shared Function sudokuOutput(
				ByVal sud as L_Sudoku, 
				ByVal arraytype as Enumerations.L_SUDOKU) as Integer


if IsNothing (sud) then Throw New ArgumentNullException  ("sud cannot be Nothing")
	Dim _Result as Integer = Natives.sudokuOutput(sud.Pointer,   arraytype)
	
	return _Result
End Function

End Class



Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\sel2.c (92, 1)
' selaAddBasic()
' selaAddBasic(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds the following sels
''' ~ all linear (horiz, vert) brick sels that are
''' necessary for decomposable sels up to size 63
''' ~ square brick sels up to size 10
''' ~ 4 diagonal sels
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddBasic(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddBasic( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (181, 1)
' selaAddHitMiss()
' selaAddHitMiss(SELA *) as SELA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddHitMiss(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddHitMiss( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (319, 1)
' selaAddDwaLinear()
' selaAddDwaLinear(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds all linear (horizontal, vertical) sels from
''' 2 to 63 pixels in length, which are the sizes over
''' which dwa code can be generated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddDwaLinear(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddDwaLinear( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (361, 1)
' selaAddDwaCombs()
' selaAddDwaCombs(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds all comb (horizontal, vertical) Sels that are
''' used in composite linear morphological operations
''' up to 63 pixels in length, which are the sizes over
''' which dwa code can be generated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddDwaCombs(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddDwaCombs( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (423, 1)
' selaAddCrossJunctions()
' selaAddCrossJunctions(SELA *, l_float32, l_float32, l_int32, l_int32) as SELA *
'''  <summary>
''' Notes
''' (1) Adds hitmiss Sels for the intersection of two lines.
''' If the lines are very thin, they must be nearly orthogonal
''' to register.
''' (2) The number of Sels generated is equal to %norient.
''' (3) If %norient == 2, this generates 2 Sels of crosses, each with
''' two perpendicular lines of hits.  One Sel has horizontal and
''' vertical hits; the other has hits along lines at +-45 degrees.
''' Likewise, if %norient == 3, this generates 3 Sels of crosses
''' oriented at 30 degrees with each other.
''' (4) It is suggested that %hlsize be chosen at least 1 greater
''' than %mdist.  Try values of (%hlsize, %mdist) such as
''' (6,5), (7,6), (8,7), (9,7), etc.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''  <param name="hlsize">[in] - length of each line of hits from origin</param>
'''  <param name="mdist">[in] - distance of misses from the origin</param>
'''  <param name="norient">[in] - number of orientations; max of 8</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddCrossJunctions(
				ByVal hlsize as Single, 
				ByVal mdist as Single, 
				ByVal norient as Integer, 
				ByVal debugflag as Integer, 
				Optional ByVal sela as Sela = Nothing) as Sela

	If IsNothing (hlsize) then Throw New ArgumentNullException  ("hlsize cannot be Nothing")
	If IsNothing (mdist) then Throw New ArgumentNullException  ("mdist cannot be Nothing")

	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddCrossJunctions( selaPTR, hlsize, mdist, norient, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (548, 1)
' selaAddTJunctions()
' selaAddTJunctions(SELA *, l_float32, l_float32, l_int32, l_int32) as SELA *
'''  <summary>
''' Notes
''' (1) Adds hitmiss Sels for the T-junction of two lines.
''' If the lines are very thin, they must be nearly orthogonal
''' to register.
''' (2) The number of Sels generated is 4  %norient.
''' (3) It is suggested that %hlsize be chosen at least 1 greater
''' than %mdist.  Try values of (%hlsize, %mdist) such as
''' (6,5), (7,6), (8,7), (9,7), etc.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''  <param name="hlsize">[in] - length of each line of hits from origin</param>
'''  <param name="mdist">[in] - distance of misses from the origin</param>
'''  <param name="norient">[in] - number of orientations; max of 8</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function selaAddTJunctions(
				ByVal hlsize as Single, 
				ByVal mdist as Single, 
				ByVal norient as Integer, 
				ByVal debugflag as Integer, 
				Optional ByVal sela as Sela = Nothing) as Sela

	If IsNothing (hlsize) then Throw New ArgumentNullException  ("hlsize cannot be Nothing")
	If IsNothing (mdist) then Throw New ArgumentNullException  ("mdist cannot be Nothing")

	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaAddTJunctions( selaPTR, hlsize, mdist, norient, debugflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (749, 1)
' sela4ccThin()
' sela4ccThin(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds the 9 basic sels for 4-cc thinning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function sela4ccThin(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.sela4ccThin( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (790, 1)
' sela8ccThin()
' sela8ccThin(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds the 9 basic sels for 8-cc thinning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function sela8ccThin(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.sela8ccThin( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

' SRC\sel2.c (831, 1)
' sela4and8ccThin()
' sela4and8ccThin(SELA *) as SELA *
'''  <summary>
''' Notes
''' (1) Adds the 2 basic sels for either 4-cc or 8-cc thinning.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sela">[in][optional] - </param>
'''   <returns>sela with additional sels, or NULL on error</returns>
Public Shared Function sela4and8ccThin(
				Optional ByVal sela as Sela = Nothing) as Sela


	Dim selaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(sela) Then selaPTR = sela.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.sela4and8ccThin( selaPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

End Class

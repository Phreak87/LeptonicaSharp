Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' bootnumgen1.c (290, 1)
' l_bootnum_gen1() as Pixa
' l_bootnum_gen1() as PIXA *
'''  <summary>
''' Call this way:
'''PIXA  pixa = l_bootnum_gen1() (C)
'''Pixa  pixa = l_bootnum_gen1() (C++)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/l_bootnum_gen1/*"/>
'''   <returns>pixa  of labeled digits</returns>
Public Shared Function l_bootnum_gen1() as Pixa


	Dim _Result as IntPtr = Natives.l_bootnum_gen1()
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

End Class



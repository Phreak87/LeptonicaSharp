Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\bootnumgen2.c (273, 1)
' l_bootnum_gen2() as Pixa
' l_bootnum_gen2() as PIXA *
'''  <summary>
''' Call this way:
''' PIXA  pixa = l_bootnum_gen2() (C)
''' Pixa  pixa = l_bootnum_gen2() (C++)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/l_bootnum_gen2/*"/>
'''   <returns>pixa  of labeled digits</returns>
Public Shared Function l_bootnum_gen2() as Pixa

	Dim _Result as IntPtr = LeptonicaSharp.Natives.l_bootnum_gen2( )
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

End Class

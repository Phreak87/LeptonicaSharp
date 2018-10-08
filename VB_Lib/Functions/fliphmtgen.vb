Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\fliphmtgen.c (77, 1)
' pixFlipFHMTGen(pixd, pixs, selname) as Pix
' pixFlipFHMTGen(PIX *, PIX *, const char *) as PIX *
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixFlipFHMTGen(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 ByVal selname as String) as Pix

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")



Dim pixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPTR = pixd.Pointer
Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFlipFHMTGen( pixd.Pointer, pixs.Pointer, selname)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class

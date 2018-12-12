Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' fliphmtgen.c (77, 1)
' pixFlipFHMTGen(pixd, pixs, selname) as Pix
' pixFlipFHMTGen(PIX *, PIX *, const char *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFlipFHMTGen/*"/>
'''   <returns></returns>
Public Shared Function pixFlipFHMTGen(
				ByVal pixd as Pix, 
				ByVal pixs as Pix, 
				ByVal selname as String) as Pix


if IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (selname) then Throw New ArgumentNullException  ("selname cannot be Nothing")
	Dim pixdPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixd) Then pixdPtr = pixd.Pointer
	Dim pixsPtr as IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer

	Dim _Result as IntPtr = Natives.pixFlipFHMTGen(pixd.Pointer, pixs.Pointer,   selname)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

End Class



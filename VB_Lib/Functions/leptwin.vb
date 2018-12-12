Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' leptwin.c (303, 1)
' pixGetWindowsHBITMAP(pix) as IntPtr
' pixGetWindowsHBITMAP(PIX *) as HBITMAP
'''  <summary>
''' (1) It's the responsibility of the caller to destroy the
'''returned hBitmap with a call to DeleteObject (or with
'''something that eventually calls DeleteObject).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWindowsHBITMAP/*"/>
'''  <param name="pix">[in] - </param>
'''   <returns>Windows hBitmap, or NULL on error</returns>
Public Shared Function pixGetWindowsHBITMAP(
				ByVal pix as Pix) as IntPtr


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetWindowsHBITMAP(pix.Pointer)
	



	return _Result
End Function

End Class



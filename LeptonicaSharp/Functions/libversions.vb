Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\libversions.c (101, 1)
' getImagelibVersions() Return string of version numbers; e.g., libgif 5.0.3 libjpeg 8b (libjpeg-turbo 1.3.0) libpng 1.4.3 libtiff 3.9.5 zlib 1.2.5 libwebp 0.3.0 libopenjp2 2.1.0 Notes (1) The caller must free the memory.
' getImagelibVersions() as char *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function getImagelibVersions() as String



	Dim _Result as String = LeptonicaSharp.Natives.getImagelibVersions( )

	Return _Result
End Function

End Class

Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\convertfiles.c (67, 1)
' convertFilesTo1bpp(dirin, substr, upscaling, thresh, firstpage, npages, dirout, outformat) as Integer
' convertFilesTo1bpp(const char *, const char *, l_int32, l_int32, l_int32, l_int32, const char *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Images are sorted lexicographically, and the names in the<para/>
''' output directory are retained except for the extension.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirin">[in] - </param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="upscaling">[in] - 1, 2 or 4 only for input color or grayscale</param>
'''  <param name="thresh">[in] - global threshold for binarization use 0 for default</param>
'''  <param name="firstpage">[in] - </param>
'''  <param name="npages">[in] - use 0 to do all from %firstpage to the end</param>
'''  <param name="dirout">[in] - </param>
'''  <param name="outformat">[in] - IFF_PNG, IFF_TIFF_G4</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function convertFilesTo1bpp(
				 ByVal dirin as String, 
				 ByVal substr as String, 
				 ByVal upscaling as Integer, 
				 ByVal thresh as Integer, 
				 ByVal firstpage as Integer, 
				 ByVal npages as Integer, 
				 ByVal dirout as String, 
				 ByVal outformat as Enumerations.IFF) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (dirout) then Throw New ArgumentNullException  ("dirout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.convertFilesTo1bpp( dirin, substr, upscaling, thresh, firstpage, npages, dirout, outformat)

	Return _Result
End Function

End Class

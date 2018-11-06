Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\dewarp3.c (114, 1)
' dewarpaApplyDisparity(dewa, pageno, pixs, grayin, x, y, ppixd, debugfile) as Integer
' dewarpaApplyDisparity(L_DEWARPA *, l_int32, PIX *, l_int32, l_int32, l_int32, PIX **, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This applies the disparity arrays to the specified image.<para/>
''' (2) Specify gray color for pixels brought in from the outside:<para/>
''' 0 is black, 255 is white.  Use -1 to select pixels from the<para/>
''' boundary of the source image.<para/>
''' (3) If the models and ref models have not been validated, this<para/>
''' will do so by calling dewarpaInsertRefModels().<para/>
''' (4) This works with both stripped and full resolution page models.<para/>
''' If the full res disparity array(s) are missing, they are remade.<para/>
''' (5) The caller must handle errors that are returned because there<para/>
''' are no valid models or ref models for the page -- typically<para/>
''' by using the input pixs.<para/>
''' (6) If there is no model for %pageno, this will use the model for<para/>
''' 'refpage' and put the result in the dew for %pageno.<para/>
''' (7) This populates the full resolution disparity arrays if<para/>
''' necessary.  If x and/or y are positive, they are used,<para/>
''' in conjunction with pixs, to determine the required<para/>
''' slope-based extension of the full resolution disparity<para/>
''' arrays in each direction.  When (x,y) == (0,0), all<para/>
''' extension is to the right and down.  Nonzero values of (x,y)<para/>
''' are useful for dewarping when pixs is deliberately undercropped.<para/>
''' (8) Important: when applying disparity to a number of images,<para/>
''' after calling this function and saving the resulting pixd,<para/>
''' you should call dewarpMinimize(dew) on the dew for %pageno.<para/>
''' This will remove pixs and pixd (or their clones) stored in dew,<para/>
''' as well as the full resolution disparity arrays.  Together,<para/>
''' these hold approximately 16 bytes for each pixel in pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpaApplyDisparity/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="pageno">[in] - of page model to be used may be a ref model</param>
'''  <param name="pixs">[in] - image to be modified can be 1, 8 or 32 bpp</param>
'''  <param name="grayin">[in] - gray value, from 0 to 255, for pixels brought in use -1 to use pixels on the boundary of pixs</param>
'''  <param name="x">[in] - origin for generation of disparity arrays</param>
'''  <param name="y">[in] - origin for generation of disparity arrays</param>
'''  <param name="ppixd">[out] - disparity corrected image</param>
'''  <param name="debugfile">[in]use NULL to skip - writing this</param>
'''   <returns>0 if OK, 1 on error no models or ref models available</returns>
Public Shared Function dewarpaApplyDisparity(
				 ByVal dewa as L_Dewarpa, 
				 ByVal pageno as Integer, 
				 ByVal pixs as Pix, 
				 ByVal grayin as Integer, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef ppixd as Pix, 
				 Optional ByVal debugfile as String = Nothing) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim ppixdPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixd) Then ppixdPTR = ppixd.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaApplyDisparity( dewa.Pointer, pageno, pixs.Pointer, grayin, x, y, ppixdPTR, debugfile)
	if ppixdPTR <> IntPtr.Zero then ppixd = new Pix(ppixdPTR)

	Return _Result
End Function

' SRC\dewarp3.c (537, 1)
' dewarpaApplyDisparityBoxa(dewa, pageno, pixs, boxas, mapdir, x, y, pboxad, debugfile) as Integer
' dewarpaApplyDisparityBoxa(L_DEWARPA *, l_int32, PIX *, BOXA *, l_int32, l_int32, l_int32, BOXA **, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This applies the disparity arrays in one of two mapping directions<para/>
''' to the specified boxa.  It can be used in the backward direction<para/>
''' to locate a box in the original coordinates that would have<para/>
''' been dewarped to to the specified image.<para/>
''' (2) If there is no model for %pageno, this will use the model for<para/>
''' 'refpage' and put the result in the dew for %pageno.<para/>
''' (3) This works with both stripped and full resolution page models.<para/>
''' If the full res disparity array(s) are missing, they are remade.<para/>
''' (4) If an error occurs, a copy of the input boxa is returned.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpaApplyDisparityBoxa/*"/>
'''  <param name="dewa">[in] - </param>
'''  <param name="pageno">[in] - of page model to be used may be a ref model</param>
'''  <param name="pixs">[in] - initial pix reference for alignment and debugging</param>
'''  <param name="boxas">[in] - boxa to be mapped</param>
'''  <param name="mapdir">[in] - 1 if mapping forward from original to dewarped 0 if backward</param>
'''  <param name="x">[in] - origin for generation of disparity arrays with respect to the source region</param>
'''  <param name="y">[in] - origin for generation of disparity arrays with respect to the source region</param>
'''  <param name="pboxad">[out] - disparity corrected boxa</param>
'''  <param name="debugfile">[in]use NULL to skip - writing this</param>
'''   <returns>0 if OK, 1 on error no models or ref models available</returns>
Public Shared Function dewarpaApplyDisparityBoxa(
				 ByVal dewa as L_Dewarpa, 
				 ByVal pageno as Integer, 
				 ByVal pixs as Pix, 
				 ByVal boxas as Boxa, 
				 ByVal mapdir as Integer, 
				 ByVal x as Integer, 
				 ByVal y as Integer, 
				<Out()> ByRef pboxad as Boxa, 
				 Optional ByVal debugfile as String = Nothing) as Integer

	If IsNothing (dewa) then Throw New ArgumentNullException  ("dewa cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")

	Dim pboxadPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxad) Then pboxadPTR = pboxad.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpaApplyDisparityBoxa( dewa.Pointer, pageno, pixs.Pointer, boxas.Pointer, mapdir, x, y, pboxadPTR, debugfile)
	if pboxadPTR <> IntPtr.Zero then pboxad = new Boxa(pboxadPTR)

	Return _Result
End Function

' SRC\dewarp3.c (729, 1)
' dewarpMinimize(dew) as Integer
' dewarpMinimize(L_DEWARP *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This removes all data that is not needed for serialization.<para/>
''' It keeps the subsampled disparity array(s), so the full<para/>
''' resolution arrays can be reconstructed.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpMinimize/*"/>
'''  <param name="dew">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpMinimize(
				 ByVal dew as L_Dewarp) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpMinimize( dew.Pointer)

	Return _Result
End Function

' SRC\dewarp3.c (785, 1)
' dewarpPopulateFullRes(dew, pix, x, y) as Integer
' dewarpPopulateFullRes(L_DEWARP *, PIX *, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If the full resolution vertical and horizontal disparity<para/>
''' arrays do not exist, they are built from the subsampled ones.<para/>
''' (2) If pixs is not given, the size of the arrays is determined<para/>
''' by the original image from which the sampled version was<para/>
''' generated.  Any values of (x,y) are ignored.<para/>
''' (3) If pixs is given, the full resolution disparity arrays must<para/>
''' be large enough to accommodate it.<para/>
''' (a) If the arrays do not exist, the value of (x,y) determines<para/>
''' the origin of the full resolution arrays without extension,<para/>
''' relative to pixs.  Thus, (x,y) gives the amount of<para/>
''' slope extension in (left, top).  The (right, bottom)<para/>
''' extension is then determined by the size of pixs and<para/>
''' (x,y) the values should never be  is lower  0.<para/>
''' (b) If the arrays exist and pixs is too large, the existing<para/>
''' full res arrays are destroyed and new ones are made,<para/>
''' again using (x,y) to determine the extension in the<para/>
''' four directions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/dewarpPopulateFullRes/*"/>
'''  <param name="dew">[in] - </param>
'''  <param name="pix">[in][optional] - , to give size of actual image</param>
'''  <param name="x">[in] - origin for generation of disparity arrays</param>
'''  <param name="y">[in] - origin for generation of disparity arrays</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function dewarpPopulateFullRes(
				 ByVal dew as L_Dewarp, 
				 ByVal pix as Pix, 
				 ByVal x as Integer, 
				 ByVal y as Integer) as Integer

	If IsNothing (dew) then Throw New ArgumentNullException  ("dew cannot be Nothing")

	Dim pixPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pix) Then pixPTR = pix.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.dewarpPopulateFullRes( dew.Pointer, pixPTR, x, y)

	Return _Result
End Function

End Class

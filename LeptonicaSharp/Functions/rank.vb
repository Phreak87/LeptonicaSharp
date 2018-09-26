Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\rank.c (147, 1)
' pixRankFilter()
' pixRankFilter(PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This defines, for each pixel in pixs, a neighborhood of
''' pixels given by a rectangle "centered" on the pixel.
''' This set of wfhf pixels has a distribution of values.
''' For each component, if the values are sorted in increasing
''' order, we choose the component such that rank(wfhf-1)
''' pixels have a lower or equal value and
''' (1-rank)(wfhf-1) pixels have an equal or greater value.
''' (2) See notes in pixRankFilterGray() for further details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="wf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="hf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0]</param>
'''   <returns>pixd of rank values, or NULL on error</returns>
Public Shared Function pixRankFilter(
				ByVal pixs as Pix, 
				ByVal wf as Integer, 
				ByVal hf as Integer, 
				ByVal rank as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRankFilter( pixs.Pointer, wf, hf, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rank.c (199, 1)
' pixRankFilterRGB()
' pixRankFilterRGB(PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This defines, for each pixel in pixs, a neighborhood of
''' pixels given by a rectangle "centered" on the pixel.
''' This set of wfhf pixels has a distribution of values.
''' For each component, if the values are sorted in increasing
''' order, we choose the component such that rank(wfhf-1)
''' pixels have a lower or equal value and
''' (1-rank)(wfhf-1) pixels have an equal or greater value.
''' (2) Apply gray rank filtering to each component independently.
''' (3) See notes in pixRankFilterGray() for further details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp</param>
'''  <param name="wf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="hf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0]</param>
'''   <returns>pixd of rank values, or NULL on error</returns>
Public Shared Function pixRankFilterRGB(
				ByVal pixs as Pix, 
				ByVal wf as Integer, 
				ByVal hf as Integer, 
				ByVal rank as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRankFilterRGB( pixs.Pointer, wf, hf, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rank.c (267, 1)
' pixRankFilterGray()
' pixRankFilterGray(PIX *, l_int32, l_int32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This defines, for each pixel in pixs, a neighborhood of
''' pixels given by a rectangle "centered" on the pixel.
''' This set of wfhf pixels has a distribution of values,
''' and if they are sorted in increasing order, we choose
''' the pixel such that rank(wfhf-1) pixels have a lower
''' or equal value and (1-rank)(wfhf-1) pixels have an equal
''' or greater value.
''' (2) By this definition, the rank = 0.0 pixel has the lowest
''' value, and the rank = 1.0 pixel has the highest value.
''' (3) We add mirrored boundary pixels to avoid boundary effects,
''' and put the filter center at (0, 0).
''' (4) This dispatches to grayscale erosion or dilation if the
''' filter dimensions are odd and the rank is 0.0 or 1.0, rsp.
''' (5) Returns a copy if both wf and hf are 1.
''' (6) Uses row-major or column-major incremental updates to the
''' histograms depending on whether hf GT wf or hv LT= wf, rsp.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="wf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="hf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0]</param>
'''   <returns>pixd of rank values, or NULL on error</returns>
Public Shared Function pixRankFilterGray(
				ByVal pixs as Pix, 
				ByVal wf as Integer, 
				ByVal hf as Integer, 
				ByVal rank as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRankFilterGray( pixs.Pointer, wf, hf, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rank.c (467, 1)
' pixMedianFilter()
' pixMedianFilter(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="wf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="hf">[in] - width and height of filter; each is GT= 1</param>
'''   <returns>pixd of median values, or NULL on error</returns>
Public Shared Function pixMedianFilter(
				ByVal pixs as Pix, 
				ByVal wf as Integer, 
				ByVal hf as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMedianFilter( pixs.Pointer, wf, hf)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\rank.c (502, 1)
' pixRankFilterWithScaling()
' pixRankFilterWithScaling(PIX *, l_int32, l_int32, l_float32, l_float32) as PIX *
'''  <summary>
''' Notes
''' (1) This is a convenience function that downscales, does
''' the rank filtering, and upscales.  Because the down-
''' and up-scaling functions are very fast compared to
''' rank filtering, the time it takes is reduced from that
''' for the simple rank filtering operation by approximately
''' the square of the scaling factor.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 or 32 bpp; no colormap</param>
'''  <param name="wf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="hf">[in] - width and height of filter; each is GT= 1</param>
'''  <param name="rank">[in] - in [0.0 ... 1.0]</param>
'''  <param name="scalefactor">[in] - scale factor; must be GT= 0.2 and LT= 0.7</param>
'''   <returns>pixd of rank values, or NULL on error</returns>
Public Shared Function pixRankFilterWithScaling(
				ByVal pixs as Pix, 
				ByVal wf as Integer, 
				ByVal hf as Integer, 
				ByVal rank as Single, 
				ByVal scalefactor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (rank) then Throw New ArgumentNullException  ("rank cannot be Nothing")
	If IsNothing (scalefactor) then Throw New ArgumentNullException  ("scalefactor cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRankFilterWithScaling( pixs.Pointer, wf, hf, rank, scalefactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class

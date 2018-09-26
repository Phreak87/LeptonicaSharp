Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\edge.c (91, 1)
' pixSobelEdgeFilter()
' pixSobelEdgeFilter(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) Invert pixd to see larger gradients as darker (grayscale).
''' (2) To generate a binary image of the edges, threshold
''' the result using pixThresholdToBinary().  If the high
''' edge values are to be fg (1), invert after running
''' pixThresholdToBinary().
''' (3) Label the pixels as follows
''' 1 4 7
''' 2 5 8
''' 3 6 9
''' Read the data incrementally across the image and unroll
''' the loop.
''' (4) This runs at about 45 Mpix/sec on a 3 GHz processor.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="orientflag">[in] - L_HORIZONTAL_EDGES, L_VERTICAL_EDGES, L_ALL_EDGES</param>
'''   <returns>pixd 8 bpp, edges are brighter, or NULL on error</returns>
Public Shared Function pixSobelEdgeFilter(
				ByVal pixs as Pix, 
				ByVal orientflag as Enumerations.L_L_EDGES) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSobelEdgeFilter( pixs.Pointer, orientflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\edge.c (199, 1)
' pixTwoSidedEdgeFilter()
' pixTwoSidedEdgeFilter(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes
''' (1) For detecting vertical edges, this considers the
''' difference of the central pixel from those on the left
''' and right.  For situations where the gradient is the same
''' sign on both sides, this computes and stores the minimum
''' (absolute value of the) difference.  The reason for
''' checking the sign is that we are looking for pixels within
''' a transition.  By contrast, for single pixel noise, the pixel
''' value is either larger than or smaller than its neighbors,
''' so the gradient would change direction on each side.  Horizontal
''' edges are handled similarly, looking for vertical gradients.
''' (2) To generate a binary image of the edges, threshold
''' the result using pixThresholdToBinary().  If the high
''' edge values are to be fg (1), invert after running
''' pixThresholdToBinary().
''' (3) This runs at about 60 Mpix/sec on a 3 GHz processor.
''' It is about 30% faster than Sobel, and the results are
''' similar.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp; no colormap</param>
'''  <param name="orientflag">[in] - L_HORIZONTAL_EDGES, L_VERTICAL_EDGES</param>
'''   <returns>pixd 8 bpp, edges are brighter, or NULL on error</returns>
Public Shared Function pixTwoSidedEdgeFilter(
				ByVal pixs as Pix, 
				ByVal orientflag as Enumerations.L_L_EDGES) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {8}.contains (pixs.d) = false then Throw New ArgumentException ("8 bpp; no colormap") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixTwoSidedEdgeFilter( pixs.Pointer, orientflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\edge.c (309, 1)
' pixMeasureEdgeSmoothness()
' pixMeasureEdgeSmoothness(PIX *, l_int32, l_int32, l_int32, l_float32 *, l_float32 *, l_float32 *, const char *) as l_ok
'''  <summary>
''' Notes
''' (1) This computes three measures of smoothness of the edge of a
''' connected component
''' jumps/length (jpl) the number of jumps of size GT= %minjump,
''' normalized to the length of the side
''' jump sum/length (jspl) the sum of all jump lengths of
''' size GT= %minjump, normalized to the length of the side
''' reversals/length (rpl) the number of peak LT--GT valley
''' reversals, using %minreverse as a minimum deviation of
''' the peak or valley from its preceding extremum,
''' normalized to the length of the side
''' (2) The input pix should be a single connected component, but
''' this is not required.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="side">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
'''  <param name="minjump">[in] - minimum jump to be counted; GT= 1</param>
'''  <param name="minreversal">[in] - minimum reversal size for new peak or valley</param>
'''  <param name="pjpl">[out][optional] - jumps/length number of jumps, normalized to length of component side</param>
'''  <param name="pjspl">[out][optional] - jumpsum/length sum of all sufficiently large jumps, normalized to length of component side</param>
'''  <param name="prpl">[out][optional] - reversals/length number of peak-to-valley or valley-to-peak reversals, normalized to length of component side</param>
'''  <param name="debugfile">[in][optional] - displays constructed edge; use NULL for no output</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixMeasureEdgeSmoothness(
				ByVal pixs as Pix, 
				ByVal side as Enumerations.L_scan_direction, 
				ByVal minjump as Integer, 
				ByVal minreversal as Integer, 
				Optional ByRef pjpl as Single() = Nothing, 
				Optional ByRef pjspl as Single() = Nothing, 
				Optional ByRef prpl as Single() = Nothing, 
				Optional ByVal debugfile as String = Nothing) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as Integer = LeptonicaSharp.Natives.pixMeasureEdgeSmoothness( pixs.Pointer, side, minjump, minreversal, pjpl, pjspl, prpl, debugfile)

	Return _Result
End Function

' SRC\edge.c (386, 1)
' pixGetEdgeProfile()
' pixGetEdgeProfile(PIX *, l_int32, const char *) as NUMA *
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="side">[in] - L_FROM_LEFT, L_FROM_RIGHT, L_FROM_TOP, L_FROM_BOT</param>
'''  <param name="debugfile">[in][optional] - displays constructed edge; use NULL for no output</param>
'''   <returns>na of fg edge pixel locations, or NULL on error</returns>
Public Shared Function pixGetEdgeProfile(
				ByVal pixs as Pix, 
				ByVal side as Enumerations.L_scan_direction, 
				Optional ByVal debugfile as String = Nothing) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp") ' All Functions - All Parameters - CommentCheck


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixGetEdgeProfile( pixs.Pointer, side, debugfile)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\edge.c (515, 1)
' 
' pixGetLastOffPixelInRun(PIX *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetLastOffPixelInRun(
				ByRef pixs as Pix, 
				ByRef x as Integer, 
				ByRef y as Integer, 
				ByRef direction as Integer, 
				ByRef ploc as Object) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ploc) then Throw New ArgumentNullException  ("ploc cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetLastOffPixelInRun( pixs.Pointer, x, y, direction, ploc)

	Return _Result
End Function

' SRC\edge.c (587, 1)
' 
' pixGetLastOnPixelInRun(PIX *, l_int32, l_int32, l_int32, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''   <returns></returns>
Public Shared Function pixGetLastOnPixelInRun(
				ByRef pixs as Pix, 
				ByRef x as Integer, 
				ByRef y as Integer, 
				ByRef direction as Integer, 
				ByRef ploc as Object) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (ploc) then Throw New ArgumentNullException  ("ploc cannot be Nothing")

Dim pixsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixs) Then pixsPTR = pixs.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixGetLastOnPixelInRun( pixs.Pointer, x, y, direction, ploc)

	Return _Result
End Function

End Class

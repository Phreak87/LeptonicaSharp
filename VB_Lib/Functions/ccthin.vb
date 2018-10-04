Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\ccthin.c (68, 1)
' pixaThinConnected(pixas, type, connectivity, maxiters) as Pixa
' pixaThinConnected(PIXA *, l_int32, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in pixThinConnected().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - of 1 bpp pix</param>
'''  <param name="type">[in] - L_THIN_FG, L_THIN_BG</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="maxiters">[in] - max number of iters allowed use 0 to iterate until completion</param>
'''   <returns>pixds, or NULL on error</returns>
Public Shared Function pixaThinConnected(
				 ByVal pixas as Pixa, 
				 ByVal type as Enumerations.L_THIN_G, 
				 ByVal connectivity as Integer, 
				 ByVal maxiters as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaThinConnected( pixas.Pointer, type, connectivity, maxiters)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\ccthin.c (158, 1)
' pixThinConnected(pixs, type, connectivity, maxiters) as Pix
' pixThinConnected(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See "Connectivity-preserving morphological image transformations,"<para/>
''' Dan S. Bloomberg, in SPIE Visual Communications and Image<para/>
''' Processing, Conference 1606, pp. 320-334, November 1991,<para/>
''' Boston, MA. A web version is available at<para/>
''' http://www.leptonica.com/papers/conn.pdf<para/>
''' (2) This is a simple interface for two of the best iterative<para/>
''' morphological thinning algorithms, for 4-c.c and 8-c.c.<para/>
''' Each iteration uses a mixture of parallel operations<para/>
''' (using several different 3x3 Sels) and serial operations.<para/>
''' Specifically, each thinning iteration consists of<para/>
''' four sequential thinnings from each of four directions.<para/>
''' Each of these thinnings is a parallel composite<para/>
''' operation, where the union of a set of HMTs are set<para/>
''' subtracted from the input.  For 4-cc thinning, we<para/>
''' use 3 HMTs in parallel, and for 8-cc thinning we use 4 HMTs.<para/>
''' (3) A "good" thinning algorithm is one that generates a skeleton<para/>
''' that is near the medial axis and has neither pruned<para/>
''' real branches nor left extra dendritic branches.<para/>
''' (4) Duality between operations on fg and bg require switching<para/>
''' the connectivity.  To thin the foreground, which is the usual<para/>
''' situation, use type == L_THIN_FG.  Thickening the foreground<para/>
''' is equivalent to thinning the background (type == L_THIN_BG),<para/>
''' where the alternate connectivity gets preserved.<para/>
''' For example, to thicken the fg with 2 rounds of iterations<para/>
''' using 4-c.c., thin the bg using Sels that preserve 8-connectivity:<para/>
''' Pix pix = pixThinConnected(pixs, L_THIN_BG, 8, 2)<para/>
''' (5) This makes and destroys the sela set each time. It's not a large<para/>
''' overhead, but if you are calling this thousands of times on<para/>
''' very small images, you can avoid the overhead e.g.<para/>
''' Sela sela = selaMakeThinSets(1, 0)  // for 4-c.c.<para/>
''' Pix pix = pixThinConnectedBySet(pixs, L_THIN_FG, sela, 0)<para/>
''' using set 1 for 4-c.c. and set 5 for 8-c.c operations.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="type">[in] - L_THIN_FG, L_THIN_BG</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="maxiters">[in] - max number of iters allowed use 0 to iterate until completion</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixThinConnected(
				 ByVal pixs as Pix, 
				 ByVal type as Enumerations.L_THIN_G, 
				 ByVal connectivity as Integer, 
				 ByVal maxiters as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixThinConnected( pixs.Pointer, type, connectivity, maxiters)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ccthin.c (220, 1)
' pixThinConnectedBySet(pixs, type, sela, maxiters) as Pix
' pixThinConnectedBySet(PIX *, l_int32, SELA *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in pixThinConnected().<para/>
''' (2) This takes a sela representing one of 11 sets of HMT Sels.<para/>
''' The HMTs from this set are run in parallel and the result<para/>
''' is OR'd before being subtracted from the source.  For each<para/>
''' iteration, this "parallel" thin is performed four times<para/>
''' sequentially, for sels rotated by 90 degrees in all four<para/>
''' directions.<para/>
''' (3) The "parallel" and "sequential" nomenclature is standard<para/>
''' in digital filtering.  Here, "parallel" operations work on the<para/>
''' same source (pixd), and accumulate the results in a temp<para/>
''' image before actually applying them to the source (in this<para/>
''' case, using an in-place subtraction).  "Sequential" operations<para/>
''' operate directly on the source (pixd) to produce the result<para/>
''' (in this case, with four sequential thinning operations, one<para/>
''' from each of four directions).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="type">[in] - L_THIN_FG, L_THIN_BG</param>
'''  <param name="sela">[in] - of Sels for parallel composite HMTs</param>
'''  <param name="maxiters">[in] - max number of iters allowed use 0 to iterate until completion</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixThinConnectedBySet(
				 ByVal pixs as Pix, 
				 ByVal type as Enumerations.L_THIN_G, 
				 ByVal sela as Sela, 
				 ByVal maxiters as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixThinConnectedBySet( pixs.Pointer, type, sela.Pointer, maxiters)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\ccthin.c (341, 1)
' selaMakeThinSets(index, debug) as Sela
' selaMakeThinSets(l_int32, l_int32) as SELA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) These are specific sets of HMTs to be used in parallel for<para/>
''' for thinning from each of four directions.<para/>
''' (2) The sets are indexed as follows:<para/>
''' For thinning (e.g., run to completion):<para/>
''' index = 1 sel_4_1, sel_4_2, sel_4_3<para/>
''' index = 2 sel_4_1, sel_4_5, sel_4_6<para/>
''' index = 3 sel_4_1, sel_4_7, sel_4_7_rot<para/>
''' index = 4 sel_48_1, sel_48_1_rot, sel_48_2<para/>
''' index = 5 sel_8_2, sel_8_3, sel_8_5, sel_8_6<para/>
''' index = 6 sel_8_2, sel_8_3, sel_48_2<para/>
''' index = 7 sel_8_1, sel_8_5, sel_8_6<para/>
''' index = 8 sel_8_2, sel_8_3, sel_8_8, sel_8_9<para/>
''' index = 9 sel_8_5, sel_8_6, sel_8_7, sel_8_7_rot<para/>
''' For thickening (e.g., just a few iterations):<para/>
''' index = 10  sel_4_2, sel_4_3<para/>
''' index = 11  sel_8_4<para/>
''' (3) For a very smooth skeleton, use set 1 for 4 connected and<para/>
''' set 5 for 8 connected thins.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="index">[in] - into specific sets</param>
'''  <param name="debug">[in] - 1 to output display of sela</param>
'''   <returns>sela, or NULL on error</returns>
Public Shared Function selaMakeThinSets(
				 ByVal index as Integer, 
				 ByVal debug as Enumerations.DebugOnOff) as Sela



	Dim _Result as IntPtr = LeptonicaSharp.Natives.selaMakeThinSets( index, debug)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Sela(_Result)
End Function

End Class

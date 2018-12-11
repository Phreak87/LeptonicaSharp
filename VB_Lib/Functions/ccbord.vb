Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' ccbord.c (299, 1)
' ccbaCreate(pixs, n) as CCBorda
' ccbaCreate(PIX *, l_int32) as CCBORDA *
'''  <summary>
''' ccbaCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaCreate/*"/>
'''  <param name="pixs">[in] - binary image can be null</param>
'''  <param name="n">[in] - initial number of ptrs</param>
'''   <returns>ccba, or NULL on error</returns>
Public Shared Function ccbaCreate(
				ByVal pixs as Pix, 
				ByVal n as Integer) as CCBorda


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaCreate(pixs.Pointer,   n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBorda(_Result)
End Function

' ccbord.c (332, 1)
' ccbaDestroy(pccba) as Object
' ccbaDestroy(CCBORDA **) as void
'''  <summary>
''' ccbaDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDestroy/*"/>
'''  <param name="pccba">[in,out] - to be nulled</param>
Public Shared Sub ccbaDestroy(
				ByRef pccba as CCBorda)


	Dim pccbaPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pccba) Then pccbaPtr = pccba.Pointer

	Natives.ccbaDestroy( pccbaPtr)
	
	if pccbaPtr = IntPtr.Zero then pccba = Nothing else pccba = new CCBorda(pccbaPtr)
End Sub

' ccbord.c (364, 1)
' ccbCreate(pixs) as CCBord
' ccbCreate(PIX *) as CCBORD *
'''  <summary>
''' ccbCreate()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbCreate/*"/>
'''  <param name="pixs">[in][optional] - </param>
'''   <returns>ccb or NULL on error</returns>
Public Shared Function ccbCreate(
				ByVal pixs as Pix) as CCBord


	Dim pixsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pixs) Then pixsPtr = pixs.Pointer

	Dim _Result as IntPtr = Natives.ccbCreate(pixsPtr)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBord(_Result)
End Function

' ccbord.c (404, 1)
' ccbDestroy(pccb) as Object
' ccbDestroy(CCBORD **) as void
'''  <summary>
''' ccbDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbDestroy/*"/>
'''  <param name="pccb">[in,out] - to be nulled</param>
Public Shared Sub ccbDestroy(
				ByRef pccb as CCBord)


	Dim pccbPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pccb) Then pccbPtr = pccb.Pointer

	Natives.ccbDestroy( pccbPtr)
	
	if pccbPtr = IntPtr.Zero then pccb = Nothing else pccb = new CCBord(pccbPtr)
End Sub

' ccbord.c (454, 1)
' ccbaAddCcb(ccba, ccb) as Integer
' ccbaAddCcb(CCBORDA *, CCBORD *) as l_ok
'''  <summary>
''' ccbaAddCcb()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaAddCcb/*"/>
'''  <param name="ccba">[in] - </param>
'''  <param name="ccb">[in] - to be added by insertion</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function ccbaAddCcb(
				ByVal ccba as CCBorda, 
				ByVal ccb as CCBord) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
		if IsNothing (ccb) then Throw New ArgumentNullException  ("ccb cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaAddCcb(ccba.Pointer, ccb.Pointer)
	
	return _Result
End Function

' ccbord.c (510, 1)
' ccbaGetCount(ccba) as Integer
' ccbaGetCount(CCBORDA *) as l_int32
'''  <summary>
''' ccbaGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGetCount/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>count, with 0 on error</returns>
Public Shared Function ccbaGetCount(
				ByVal ccba as CCBorda) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaGetCount(ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (535, 1)
' ccbaGetCcb(ccba, index) as CCBord
' ccbaGetCcb(CCBORDA *, l_int32) as CCBORD *
'''  <summary>
''' (1) This returns a clone of the ccb it must be destroyed
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGetCcb/*"/>
'''  <param name="ccba">[in] - </param>
'''  <param name="index">[in] - </param>
'''   <returns>ccb, or NULL on error</returns>
Public Shared Function ccbaGetCcb(
				ByVal ccba as CCBorda, 
				ByVal index as Integer) as CCBord


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaGetCcb(ccba.Pointer,   index)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBord(_Result)
End Function

' ccbord.c (564, 1)
' pixGetAllCCBorders(pixs) as CCBorda
' pixGetAllCCBorders(PIX *) as CCBORDA *
'''  <summary>
''' pixGetAllCCBorders()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetAllCCBorders/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>ccborda, or NULL on error</returns>
Public Shared Function pixGetAllCCBorders(
				ByVal pixs as Pix) as CCBorda


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixGetAllCCBorders(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBorda(_Result)
End Function

' ccbord.c (650, 1)
' pixGetCCBorders(pixs, box) as CCBord
' pixGetCCBorders(PIX *, BOX *) as CCBORD *
'''  <summary>
''' (1) We are finding the exterior and interior borders
'''of an 8-connected component. This should be used
'''on a pix that has exactly one 8-connected component.<para/>
'''
'''(2) Typically, pixs is a c.c. in some larger pix.  The
'''input box gives its location in global coordinates.
'''This box is saved, as well as the boxes for the
'''borders of any holes within the c.c., but the latter
'''are given in relative coords within the c.c.<para/>
'''
'''(3) The calculations for the exterior border are done
'''on a pix with a 1-pixel
'''added border, but the saved pixel coordinates
'''are the correct (relative) ones for the input pix
'''(without a 1-pixel border)<para/>
'''
'''(4) For the definition of the three tables -- xpostab[], ypostab[]
'''and qpostab[] -- see above where they are defined.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetCCBorders/*"/>
'''  <param name="pixs">[in] - 1 bpp, one 8-connected component</param>
'''  <param name="box">[in] - xul, yul, width, height in global coords</param>
'''   <returns>ccbord, or NULL on error</returns>
Public Shared Function pixGetCCBorders(
				ByVal pixs as Pix, 
				ByVal box as Box) as CCBord


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixGetCCBorders(pixs.Pointer, box.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBord(_Result)
End Function

' ccbord.c (761, 1)
' pixGetOuterBordersPtaa(pixs) as Ptaa
' pixGetOuterBordersPtaa(PIX *) as PTAA *
'''  <summary>
''' pixGetOuterBordersPtaa()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBordersPtaa/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>ptaa of outer borders, in global coords, or NULL on error</returns>
Public Shared Function pixGetOuterBordersPtaa(
				ByVal pixs as Pix) as Ptaa


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")
	Dim _Result as IntPtr = Natives.pixGetOuterBordersPtaa(pixs.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Ptaa(_Result)
End Function

' ccbord.c (821, 1)
' pixGetOuterBorderPta(pixs, box) as Pta
' pixGetOuterBorderPta(PIX *, BOX *) as PTA *
'''  <summary>
''' (1) We are finding the exterior border of a single 8-connected
'''component.<para/>
'''
'''(2) If box is NULL, the outline returned is in the local coords
'''of the input pix.  Otherwise, box is assumed to give the
'''location of the pix in global coordinates, and the returned
'''pta will be in those global coordinates.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBorderPta/*"/>
'''  <param name="pixs">[in] - 1 bpp, one 8-connected component</param>
'''  <param name="box">[in][optional] - of pixs, in global coordinates</param>
'''   <returns>pta of outer border, in global coords, or NULL on error</returns>
Public Shared Function pixGetOuterBorderPta(
				ByVal pixs as Pix, 
				Optional ByVal box as Box = Nothing) as Pta


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	Dim boxPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(box) Then boxPtr = box.Pointer

	Dim _Result as IntPtr = Natives.pixGetOuterBorderPta(pixs.Pointer, boxPtr)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ccbord.c (894, 1)
' pixGetOuterBorder(ccb, pixs, box) as Integer
' pixGetOuterBorder(CCBORD *, PIX *, BOX *) as l_ok
'''  <summary>
''' (1) the border is saved in relative coordinates within
'''the c.c. (pixs).  Because the calculation is done
'''in pixb with added 1 pixel border, we must subtract
'''1 from each pixel value before storing it.<para/>
'''
'''(2) the stopping condition is that after the first pixel is
'''returned to, the next pixel is the second pixel.  Having
'''these 2 pixels recur in sequence proves the path is closed,
'''and we do not store the second pixel again.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetOuterBorder/*"/>
'''  <param name="ccb">[in] - unfilled</param>
'''  <param name="pixs">[in] - for the component at hand</param>
'''  <param name="box">[in] - for the component, in global coords</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetOuterBorder(
				ByVal ccb as CCBord, 
				ByVal pixs as Pix, 
				ByVal box as Box) as Integer


if IsNothing (ccb) then Throw New ArgumentNullException  ("ccb cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetOuterBorder(ccb.Pointer, pixs.Pointer, box.Pointer)
	
	return _Result
End Function

' ccbord.c (982, 1)
' pixGetHoleBorder(ccb, pixs, box, xs, ys) as Integer
' pixGetHoleBorder(CCBORD *, PIX *, BOX *, l_int32, l_int32) as l_ok
'''  <summary>
''' (1) we trace out hole border on pixs without addition
'''of single pixel added border to pixs<para/>
'''
'''(2) therefore all coordinates are relative within the c.c. (pixs)<para/>
'''
'''(3) same position tables and stopping condition as for
'''exterior borders
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetHoleBorder/*"/>
'''  <param name="ccb">[in] - the exterior border is already made</param>
'''  <param name="pixs">[in] - for the connected component at hand</param>
'''  <param name="box">[in] - for the specific hole border, in relative coordinates to the c.c.</param>
'''  <param name="xs">[in] - first pixel on hole border, relative to c.c.</param>
'''  <param name="ys">[in] - first pixel on hole border, relative to c.c.</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixGetHoleBorder(
				ByVal ccb as CCBord, 
				ByVal pixs as Pix, 
				ByVal box as Box, 
				ByVal xs as Integer, 
				ByVal ys as Integer) as Integer


if IsNothing (ccb) then Throw New ArgumentNullException  ("ccb cannot be Nothing")
		if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	Dim _Result as Integer = Natives.pixGetHoleBorder(ccb.Pointer, pixs.Pointer, box.Pointer,   xs,   ys)
	
	return _Result
End Function

' ccbord.c (1064, 1)
' findNextBorderPixel(w, h, data, wpl, px, py, pqpos, pnpx, pnpy) as Integer
' findNextBorderPixel(l_int32, l_int32, l_uint32 *, l_int32, l_int32, l_int32, l_int32 *, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' (1) qpos increases clockwise from 0 to 7, with 0 at
'''location with Q to left of P: Q P<para/>
'''
'''(2) this is a low-level function that does not check input
'''parameters.  All calling functions should check them.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findNextBorderPixel/*"/>
'''  <param name="w">[in] - </param>
'''  <param name="h">[in] - </param>
'''  <param name="data">[in] - </param>
'''  <param name="wpl">[in] - </param>
'''  <param name="px">[in] - current P</param>
'''  <param name="py">[in] - current P</param>
'''  <param name="pqpos">[in,out] - input current Q new Q</param>
'''  <param name="pnpx">[out] - new P</param>
'''  <param name="pnpy">[out] - new P</param>
'''   <returns>0 if next pixel found 1 otherwise</returns>
Public Shared Function findNextBorderPixel(
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal data as Byte(), 
				ByVal wpl as Integer, 
				ByVal px as Integer, 
				ByVal py as Integer, 
				ByRef pqpos as Integer(), 
				<Out()>  ByRef pnpx as Integer, 
				<Out()>  ByRef pnpy as Integer) as Integer


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
		Dim dataPtr as IntPtr = 	Marshal.AllocHGlobal(data.Length)
		Marshal.Copy(data, 0, dataPtr, data.Length)

	Dim _Result as Integer = Natives.findNextBorderPixel(  w,   h,   dataPtr,   wpl,   px,   py,   pqpos,   pnpx,   pnpy)
	
	Marshal.FreeHGlobal(dataPtr)
	return _Result
End Function

' ccbord.c (1115, 1)
' locateOutsideSeedPixel(fpx, fpy, spx, spy, pxs, pys) as Object
' locateOutsideSeedPixel(l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as void
'''  <summary>
''' (1) the first and second pixels must be 8-adjacent,
'''so |dx| smaller or equal 1 and |dy| smaller or equal 1 and both dx and dy
'''cannot be 0.  There are 8 possible cases.<para/>
'''
'''(2) the seed pixel is OUTSIDE the foreground of the c.c.<para/>
'''
'''(3) these rules are for the situation where the INSIDE
'''of the c.c. is on the right as you follow the border:
'''cw for an exterior border and ccw for a hole border.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/locateOutsideSeedPixel/*"/>
'''  <param name="fpx">[in] - location of first pixel</param>
'''  <param name="fpy">[in] - location of first pixel</param>
'''  <param name="spx">[in] - location of second pixel</param>
'''  <param name="spy">[in] - location of second pixel</param>
'''  <param name="pxs">[out] - seed pixel to be returned</param>
'''  <param name="pys">[out] - seed pixel to be returned</param>
Public Shared Sub locateOutsideSeedPixel(
				ByVal fpx as Integer, 
				ByVal fpy as Integer, 
				ByVal spx as Integer, 
				ByVal spy as Integer, 
				<Out()>  ByRef pxs as Integer, 
				<Out()>  ByRef pys as Integer)


	Natives.locateOutsideSeedPixel(  fpx,   fpy,   spx,   spy,   pxs,   pys)
	
End Sub

' ccbord.c (1160, 1)
' ccbaGenerateGlobalLocs(ccba) as Integer
' ccbaGenerateGlobalLocs(CCBORDA *) as l_ok
'''  <summary>
''' ccbaGenerateGlobalLocs()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateGlobalLocs/*"/>
'''  <param name="ccba">[in] - with local chain ptaa of borders computed</param>
'''   <returns>0 if OK, 1 on error Action: this uses the pixel locs in the local ptaa, which are all relative to each c.c., to find the global pixel locations, and stores them in the global ptaa.</returns>
Public Shared Function ccbaGenerateGlobalLocs(
				ByVal ccba as CCBorda) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaGenerateGlobalLocs(ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (1231, 1)
' ccbaGenerateStepChains(ccba) as Integer
' ccbaGenerateStepChains(CCBORDA *) as l_ok
'''  <summary>
''' (1) This uses the pixel locs in the local ptaa,
'''which are all relative to each c.c., to find
'''the step directions for successive pixels in
'''the chain, and stores them in the step numaa.<para/>
'''
'''(2) To get the step direction, use
'''1 2 3
'''0 P 4
'''7 6 5
'''where P is the previous pixel at (px, py).  The step direction
'''is the number (from 0 through 7) for each relative location
'''of the current pixel at (cx, cy).  It is easily found by
'''indexing into a 2-d 3x3 array (dirtab).
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateStepChains/*"/>
'''  <param name="ccba">[in] - with local chain ptaa of borders computed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaGenerateStepChains(
				ByVal ccba as CCBorda) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaGenerateStepChains(ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (1305, 1)
' ccbaStepChainsToPixCoords(ccba, coordtype) as Integer
' ccbaStepChainsToPixCoords(CCBORDA *, l_int32) as l_ok
'''  <summary>
''' (1) This uses the step chain data in each ccb to determine
'''the pixel locations, either global or local,
'''and stores them in the appropriate ptaa,
'''either global or local.  For the latter, the
'''pixel locations are relative to the c.c.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaStepChainsToPixCoords/*"/>
'''  <param name="ccba">[in] - with step chains numaa of borders</param>
'''  <param name="coordtype">[in] - CCB_GLOBAL_COORDS or CCB_LOCAL_COORDS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaStepChainsToPixCoords(
				ByVal ccba as CCBorda, 
				ByVal coordtype as Enumerations.CCB_AL_COORDS) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaStepChainsToPixCoords(ccba.Pointer,   coordtype)
	
	return _Result
End Function

' ccbord.c (1405, 1)
' ccbaGenerateSPGlobalLocs(ccba, ptsflag) as Integer
' ccbaGenerateSPGlobalLocs(CCBORDA *, l_int32) as l_ok
'''  <summary>
''' (1) This calculates the splocal rep if not yet made.<para/>
'''
'''(2) It uses the local pixel values in splocal, the single
'''path pta, which are all relative to each c.c., to find
'''the corresponding global pixel locations, and stores
'''them in the spglobal pta.<para/>
'''
'''(3) This lists only the turning points: it both makes a
'''valid svg file and is typically about half the size
'''when all border points are listed.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateSPGlobalLocs/*"/>
'''  <param name="ccba">[in] - </param>
'''  <param name="ptsflag">[in] - CCB_SAVE_ALL_PTS or CCB_SAVE_TURNING_PTS</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaGenerateSPGlobalLocs(
				ByVal ccba as CCBorda, 
				ByVal ptsflag as Enumerations.CCB_SAVE_PTS) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaGenerateSPGlobalLocs(ccba.Pointer,   ptsflag)
	
	return _Result
End Function

' ccbord.c (1522, 1)
' ccbaGenerateSinglePath(ccba) as Integer
' ccbaGenerateSinglePath(CCBORDA *) as l_ok
'''  <summary>
''' (1) Generates a single border in local pixel coordinates.
'''For each c.c., if there is just an outer border, copy it.
'''If there are also hole borders, for each hole border,
'''determine the smallest horizontal or vertical
'''distance from the border to the outside of the c.c.,
'''and find a path through the c.c. for this cut.
'''We do this in a way that guarantees a pixel from the
'''hole border is the starting point of the path, and
'''we must verify that the path intersects the outer
'''border (if it intersects it, then it ends on it).
'''One can imagine pathological cases, but they may not
'''occur in images of text characters and un-textured
'''line graphics.<para/>
'''
'''(2) Once it is verified that the path through the c.c.
'''intersects both the hole and outer borders, we
'''generate the full single path for all borders in the
'''c.c.  Starting at the start point on the outer
'''border, when we hit a line on a cut, we take
'''the cut, do the hold border, and return on the cut
'''to the outer border.  We compose a pta of the
'''outer border pts that are on cut paths, and for
'''every point on the outer border (as we go around),
'''we check against this pta.  When we find a matching
'''point in the pta, we do its cut path and hole border.
'''The single path is saved in the ccb.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaGenerateSinglePath/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaGenerateSinglePath(
				ByVal ccba as CCBorda) as Integer


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaGenerateSinglePath(ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (1680, 1)
' getCutPathForHole(pix, pta, boxinner, pdir, plen) as Pta
' getCutPathForHole(PIX *, PTA *, BOX *, l_int32 *, l_int32 *) as PTA *
'''  <summary>
''' (1) If we don't find a path, we return a pta with no pts
'''in it and len = 0.<para/>
'''
'''(2) The goal is to get a reasonably short path between the
'''inner and outer borders, that goes entirely within the fg of
'''the pix.  This function is cheap-and-dirty, may fail for some
'''holes in complex topologies such as those you might find in a
'''moderately dark scanned halftone.  If it fails to find a
'''path to any particular hole, it gives a warning, and because
'''that hole path is not included, the hole will not be rendered.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getCutPathForHole/*"/>
'''  <param name="pix">[in] - of c.c.</param>
'''  <param name="pta">[in] - of outer border</param>
'''  <param name="boxinner">[in] - b.b. of hole path</param>
'''  <param name="pdir">[out] - direction (0-3), returned only needed for debug</param>
'''  <param name="plen">[out] - length of path, returned</param>
'''   <returns>pta of pts on cut path from the hole border to the outer border, including end points on both borders or NULL on error</returns>
Public Shared Function getCutPathForHole(
				ByVal pix as Pix, 
				ByVal pta as Pta, 
				ByVal boxinner as Box, 
				<Out()>  ByRef pdir as Integer, 
				<Out()>  ByRef plen as Integer) as Pta


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (pta) then Throw New ArgumentNullException  ("pta cannot be Nothing")
		if IsNothing (boxinner) then Throw New ArgumentNullException  ("boxinner cannot be Nothing")
	Dim _Result as IntPtr = Natives.getCutPathForHole(pix.Pointer, pta.Pointer, boxinner.Pointer,   pdir,   plen)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pta(_Result)
End Function

' ccbord.c (1828, 1)
' ccbaDisplayBorder(ccba) as Pix
' ccbaDisplayBorder(CCBORDA *) as PIX *
'''  <summary>
''' (1) Uses global ptaa, which gives each border pixel in
'''global coordinates, and must be computed in advance
'''by calling ccbaGenerateGlobalLocs().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayBorder/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>pix of border pixels, or NULL on error</returns>
Public Shared Function ccbaDisplayBorder(
				ByVal ccba as CCBorda) as Pix


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaDisplayBorder(ccba.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' ccbord.c (1881, 1)
' ccbaDisplaySPBorder(ccba) as Pix
' ccbaDisplaySPBorder(CCBORDA *) as PIX *
'''  <summary>
''' (1) Uses spglobal pta, which gives each border pixel in
'''global coordinates, one path per c.c., and must
'''be computed in advance by calling ccbaGenerateSPGlobalLocs().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplaySPBorder/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>pix of border pixels, or NULL on error</returns>
Public Shared Function ccbaDisplaySPBorder(
				ByVal ccba as CCBorda) as Pix


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaDisplaySPBorder(ccba.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' ccbord.c (1971, 1)
' ccbaDisplayImage1(ccba) as Pix
' ccbaDisplayImage1(CCBORDA *) as PIX *
'''  <summary>
''' (1) Uses local ptaa, which gives each border pixel in
'''local coordinates, so the actual pixel positions must
'''be computed using all offsets.<para/>
'''
'''(2) For the holes, use coordinates relative to the c.c.<para/>
'''
'''(3) This is slower than Method 2.<para/>
'''
'''(4) This uses topological properties (Method 1) to do scan
'''conversion to raster
'''This algorithm deserves some commentary.
'''I first tried the following:
'''~ outer borders: 4-fill from outside, stopping at the
'''border, using pixFillClosedBorders()
'''~ inner borders: 4-fill from outside, stopping again
'''at the border, XOR with the border, and invert
'''to get the hole.  This did not work, because if
'''you have a hole border that looks like:
'''x x x x x x
'''x  x
'''x x x x x
'''x x o x x
'''x x
'''x x
'''x x x
'''if you 4-fill from the outside, the pixel 'o' will
'''not be filled!  XORing with the border leaves it OFF.
'''Inverting then gives a single bad ON pixel that is not
'''actually part of the hole.
'''So what you must do instead is 4-fill the holes from inside.
'''You can do this from a seedfill, using a pix with the hole
'''border as the filling mask.  But you need to start with a
'''pixel inside the hole.  How is this determined?  The best
'''way is from the contour.  We have a right-hand shoulder
'''rule for inside (i.e., the filled region). Take the
'''first 2 pixels of the hole border, and compute dx and dy
'''(second coord minus first coord:  dx = sx - fx, dy = sy - fy).
'''There are 8 possibilities, depending on the values of dx and
'''dy (which can each be -1, 0, and +1, but not both 0).
'''These 8 cases can be broken into 4 see the simple algorithm below.
'''Once you have an interior seed pixel, you fill from the seed,
'''clipping with the hole border pix by filling into its invert.
'''You then successively XOR these interior filled components, in any order.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayImage1/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>pix of image, or NULL on error</returns>
Public Shared Function ccbaDisplayImage1(
				ByVal ccba as CCBorda) as Pix


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaDisplayImage1(ccba.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' ccbord.c (2097, 1)
' ccbaDisplayImage2(ccba) as Pix
' ccbaDisplayImage2(CCBORDA *) as PIX *
'''  <summary>
''' (1) Uses local chain ptaa, which gives each border pixel in
'''local coordinates, so the actual pixel positions must
'''be computed using all offsets.<para/>
'''
'''(2) Treats exterior and hole borders on equivalent
'''footing, and does all calculations on a pix
'''that spans the c.c. with a 1 pixel added boundary.<para/>
'''
'''(3) This uses topological properties (Method 2) to do scan
'''conversion to raster<para/>
'''
'''(4) The algorithm is described at the top of this file (Method 2).
'''It is preferred to Method 1 because it is between 1.2x and 2x
'''faster than Method 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaDisplayImage2/*"/>
'''  <param name="ccba">[in] - </param>
'''   <returns>pix of image, or NULL on error</returns>
Public Shared Function ccbaDisplayImage2(
				ByVal ccba as CCBorda) as Pix


if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaDisplayImage2(ccba.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' ccbord.c (2195, 1)
' ccbaWrite(filename, ccba) as Integer
' ccbaWrite(const char *, CCBORDA *) as l_ok
'''  <summary>
''' ccbaWrite()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWrite/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="ccba">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaWrite(
				ByVal filename as String, 
				ByVal ccba as CCBorda) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaWrite(  filename, ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (2247, 1)
' ccbaWriteStream(fp, ccba) as Integer
' ccbaWriteStream(FILE *, CCBORDA *) as l_ok
'''  <summary>
''' ccbaWriteStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="ccba">[in] - </param>
'''   <returns>0 if OK 1 on error Format: \code ccba: %7d cc\n num. c.c.) (ascii)   (18B pix width 4B pix height 4B [for i = 1, ncc] ulx  4B uly  4B w    4B       -- not req'd for reconstruction h    4B       -- not req'd for reconstruction number of borders 4B [for j = 1, nb] startx  4B starty  4B [for k = 1, nb] 2 steps 1B end in z8 or 88  1B \endcode</returns>
Public Shared Function ccbaWriteStream(
				ByVal fp as FILE, 
				ByVal ccba as CCBorda) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaWriteStream(fp.Pointer, ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (2348, 1)
' ccbaRead(filename) as CCBorda
' ccbaRead(const char *) as CCBORDA *
'''  <summary>
''' ccbaRead()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaRead/*"/>
'''  <param name="filename">[in] - </param>
'''   <returns>ccba, or NULL on error</returns>
Public Shared Function ccbaRead(
				ByVal filename as String) as CCBorda


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.ccbaRead(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBorda(_Result)
End Function

' ccbord.c (2394, 1)
' ccbaReadStream(fp) as CCBorda
' ccbaReadStream(FILE *) as CCBORDA *
'''  <summary>
''' ccbaReadStream()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaReadStream/*"/>
'''  <param name="fp">[in] - file stream</param>
'''   <returns>ccba, or NULL on error \code Format:  ccba: %7d cc\n num. c.c.) (ascii)   (17B pix width 4B pix height 4B [for i = 1, ncc] ulx  4B uly  4B w    4B       -- not req'd for reconstruction h    4B       -- not req'd for reconstruction number of borders 4B [for j = 1, nb] startx  4B starty  4B [for k = 1, nb] 2 steps 1B end in z8 or 88  1B \endcode</returns>
Public Shared Function ccbaReadStream(
				ByVal fp as FILE) as CCBorda


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.ccbaReadStream(fp.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new CCBorda(_Result)
End Function

' ccbord.c (2515, 1)
' ccbaWriteSVG(filename, ccba) as Integer
' ccbaWriteSVG(const char *, CCBORDA *) as l_ok
'''  <summary>
''' ccbaWriteSVG()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteSVG/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="ccba">[in] - </param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function ccbaWriteSVG(
				ByVal filename as String, 
				ByVal ccba as CCBorda) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as Integer = Natives.ccbaWriteSVG(  filename, ccba.Pointer)
	
	return _Result
End Function

' ccbord.c (2546, 1)
' ccbaWriteSVGString(filename, ccba) as String
' ccbaWriteSVGString(const char *, CCBORDA *) as char *
'''  <summary>
''' ccbaWriteSVGString()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/ccbaWriteSVGString/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="ccba">[in] - </param>
'''   <returns>string in svg-formatted, that can be written to file, or NULL on error.</returns>
Public Shared Function ccbaWriteSVGString(
				ByVal filename as String, 
				ByVal ccba as CCBorda) as String


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (ccba) then Throw New ArgumentNullException  ("ccba cannot be Nothing")
	Dim _Result as String = Natives.ccbaWriteSVGString(  filename, ccba.Pointer)
	
	return _Result
End Function

End Class



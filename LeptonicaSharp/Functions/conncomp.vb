Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _AllFunctions


' SRC\conncomp.c (144, 1)
' pixConnComp()
' pixConnComp(PIX *, PIXA **, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) This is the top-level call for getting bounding boxes or
''' a pixa of the components, and it can be used instead
''' of either pixConnCompBB() or pixConnCompPixa(), rsp.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="ppixa">[out][optional] - pixa of each c.c.</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixConnComp(
				ByVal pixs as Pix, 
				ByRef ppixa as Pixa, 
				ByVal connectivity as Integer) as Boxa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConnComp( pixs.Pointer, ppixaPTR, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)

	Return  new Boxa(_Result)
End Function

' SRC\conncomp.c (190, 1)
' pixConnCompPixa()
' pixConnCompPixa(PIX *, PIXA **, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) This finds bounding boxes of 4- or 8-connected components
''' in a binary image, and saves images of each c.c
''' in a pixa array.
''' (2) It sets up 2 temporary pix, and for each c.c. that is
''' located in raster order, it erases the c.c. from one pix,
''' then uses the b.b. to extract the c.c. from the two pix using
''' an XOR, and finally erases the c.c. from the second pix.
''' (3) A clone of the returned boxa (where all boxes in the array
''' are clones) is inserted into the pixa.
''' (4) If the input is valid, this always returns a boxa and a pixa.
''' If pixs is empty, the boxa and pixa will be empty.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="ppixa">[out] - pixa of each c.c.</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixConnCompPixa(
				ByVal pixs as Pix, 
				ByRef ppixa as Pixa, 
				ByVal connectivity as Integer) as Boxa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim ppixaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(ppixa) Then ppixaPTR = ppixa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConnCompPixa( pixs.Pointer, ppixaPTR, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing
	if ppixaPTR <> IntPtr.Zero then ppixa = new Pixa(ppixaPTR)

	Return  new Boxa(_Result)
End Function

' SRC\conncomp.c (304, 1)
' pixConnCompBB()
' pixConnCompBB(PIX *, l_int32) as BOXA *
'''  <summary>
''' Notes
''' (1) Finds bounding boxes of 4- or 8-connected components
''' in a binary image.
''' (2) This works on a copy of the input pix.  The c.c. are located
''' in raster order and erased one at a time.  In the process,
''' the b.b. is computed and saved.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>boxa, or NULL on error</returns>
Public Shared Function pixConnCompBB(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer) as Boxa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixConnCompBB( pixs.Pointer, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\conncomp.c (387, 1)
' pixCountConnComp()
' pixCountConnComp(PIX *, l_int32, l_int32 *) as l_ok
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="pcount">[out] - </param>
'''   <returns>0 if OK, 1 on error Notes (1 This is the top-level call for getting the number of 4- or 8-connected components in a 1 bpp image. 2 It works on a copy of the input pix.  The c.c. are located in raster order and erased one at a time.</returns>
Public Shared Function pixCountConnComp(
				ByVal pixs as Pix, 
				ByVal connectivity as Integer, 
				ByRef pcount as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCountConnComp( pixs.Pointer, connectivity, pcount)

	Return _Result
End Function

' SRC\conncomp.c (449, 1)
' nextOnPixelInRaster()
' nextOnPixelInRaster(PIX *, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="xstart">[in] - starting point for search</param>
'''  <param name="ystart">[in] - starting point for search</param>
'''  <param name="px">[out] - coord value of next ON pixel</param>
'''  <param name="py">[out] - coord value of next ON pixel</param>
'''   <returns>1 if a pixel is found; 0 otherwise or on error</returns>
Public Shared Function nextOnPixelInRaster(
				ByVal pixs as Pix, 
				ByVal xstart as Integer, 
				ByVal ystart as Integer, 
				ByRef px as Integer, 
				ByRef py as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.nextOnPixelInRaster( pixs.Pointer, xstart, ystart, px, py)

	Return _Result
End Function

' SRC\conncomp.c (483, 1)
' nextOnPixelInRasterLow()
' nextOnPixelInRasterLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_int32 *) as l_int32
'''  <summary>
''' 
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - pix data</param>
'''  <param name="w">[in] - width and height</param>
'''  <param name="h">[in] - width and height</param>
'''  <param name="wpl">[in] - words per line</param>
'''  <param name="xstart">[in] - starting point for search</param>
'''  <param name="ystart">[in] - starting point for search</param>
'''  <param name="px">[out] - coord value of next ON pixel</param>
'''  <param name="py">[out] - coord value of next ON pixel</param>
'''   <returns>1 if a pixel is found; 0 otherwise or on error</returns>
Public Shared Function nextOnPixelInRasterLow(
				ByVal data as Byte(), 
				ByVal w as Integer, 
				ByVal h as Integer, 
				ByVal wpl as Integer, 
				ByVal xstart as Integer, 
				ByVal ystart as Integer, 
				ByRef px as Integer, 
				ByRef py as Integer) as Integer

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	Dim _Result as Integer = LeptonicaSharp.Natives.nextOnPixelInRasterLow( dataPTR, w, h, wpl, xstart, ystart, px, py)

	Return _Result
End Function

' SRC\conncomp.c (560, 1)
' pixSeedfillBB()
' pixSeedfillBB(PIX *, L_STACK *, l_int32, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This is the high-level interface to Paul Heckbert's
''' stack-based seedfill algorithm.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>box or NULL on error</returns>
Public Shared Function pixSeedfillBB(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal connectivity as Integer) as Box

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillBB( pixs.Pointer, stack.Pointer, x, y, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\conncomp.c (623, 1)
' pixSeedfill4BB()
' pixSeedfill4BB(PIX *, L_STACK *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This is Paul Heckbert's stack-based 4-cc seedfill algorithm.
''' (2) This operates on the input 1 bpp pix to remove the fg seed
''' pixel, at (x,y), and all pixels that are 4-connected to it.
''' The seed pixel at (x,y) must initially be ON.
''' (3) Returns the bounding box of the erased 4-cc component.
''' (4) Reference see Paul Heckbert's stack-based seed fill algorithm
''' in "Graphic Gems", ed. Andrew Glassner, Academic
''' Press, 1990.  The algorithm description is given
''' on pp. 275-277; working C code is on pp. 721-722.)
''' The code here follows Heckbert's exactly, except
''' we use function calls instead of macros for
''' pushing data on and popping data off the stack.
''' This makes sense to do because Heckbert's fixed-size
''' stack with macros is dangerous images exist that
''' will overrun the stack and crash.   The stack utility
''' here grows dynamically as needed, and the fillseg
''' structures that are not in use are stored in another
''' stack for reuse.  It should be noted that the
''' overhead in the function calls (vs. macros) is negligible.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''   <returns>box or NULL on error.</returns>
Public Shared Function pixSeedfill4BB(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer) as Box

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfill4BB( pixs.Pointer, stack.Pointer, x, y)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\conncomp.c (738, 1)
' pixSeedfill8BB()
' pixSeedfill8BB(PIX *, L_STACK *, l_int32, l_int32) as BOX *
'''  <summary>
''' Notes
''' (1) This is Paul Heckbert's stack-based 8-cc seedfill algorithm.
''' (2) This operates on the input 1 bpp pix to remove the fg seed
''' pixel, at (x,y), and all pixels that are 8-connected to it.
''' The seed pixel at (x,y) must initially be ON.
''' (3) Returns the bounding box of the erased 8-cc component.
''' (4) Reference see Paul Heckbert's stack-based seed fill algorithm
''' in "Graphic Gems", ed. Andrew Glassner, Academic
''' Press, 1990.  The algorithm description is given
''' on pp. 275-277; working C code is on pp. 721-722.)
''' The code here follows Heckbert's closely, except
''' the leak checks are changed for 8 connectivity.
''' See comments on pixSeedfill4BB() for more details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''   <returns>box or NULL on error.</returns>
Public Shared Function pixSeedfill8BB(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer) as Box

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfill8BB( pixs.Pointer, stack.Pointer, x, y)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Box(_Result)
End Function

' SRC\conncomp.c (844, 1)
' pixSeedfill()
' pixSeedfill(PIX *, L_STACK *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This removes the component from pixs with a fg pixel at (x,y).
''' (2) See pixSeedfill4() and pixSeedfill8() for details.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfill(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer, 
				ByVal connectivity as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfill( pixs.Pointer, stack.Pointer, x, y, connectivity)

	Return _Result
End Function

' SRC\conncomp.c (888, 1)
' pixSeedfill4()
' pixSeedfill4(PIX *, L_STACK *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is Paul Heckbert's stack-based 4-cc seedfill algorithm.
''' (2) This operates on the input 1 bpp pix to remove the fg seed
''' pixel, at (x,y), and all pixels that are 4-connected to it.
''' The seed pixel at (x,y) must initially be ON.
''' (3) Reference see pixSeedFill4BB()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfill4(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfill4( pixs.Pointer, stack.Pointer, x, y)

	Return _Result
End Function

' SRC\conncomp.c (982, 1)
' pixSeedfill8()
' pixSeedfill8(PIX *, L_STACK *, l_int32, l_int32) as l_ok
'''  <summary>
''' Notes
''' (1) This is Paul Heckbert's stack-based 8-cc seedfill algorithm.
''' (2) This operates on the input 1 bpp pix to remove the fg seed
''' pixel, at (x,y), and all pixels that are 8-connected to it.
''' The seed pixel at (x,y) must initially be ON.
''' (3) Reference see pixSeedFill8BB()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="stack">[in] - for holding fillsegs</param>
'''  <param name="x">[in] - ,y   location of seed pixel</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixSeedfill8(
				ByVal pixs as Pix, 
				ByVal stack as L_Stack, 
				ByVal x as Integer, 
				ByRef y as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (stack) then Throw New ArgumentNullException  ("stack cannot be Nothing")
	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixSeedfill8( pixs.Pointer, stack.Pointer, x, y)

	Return _Result
End Function

End Class

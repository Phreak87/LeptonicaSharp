Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\morphapp.c (108, 1)
' pixExtractBoundary(pixs, type) as Pix
' pixExtractBoundary(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Extracts the fg or bg boundary pixels for each component.<para/>
''' Components are assumed to end at the boundary of pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="type">[in] - 0 for background pixels 1 for foreground pixels</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixExtractBoundary(
				 ByVal pixs as Pix, 
				 ByVal type as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExtractBoundary( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (148, 1)
' pixMorphSequenceMasked(pixs, pixm, sequence, dispsep) as Pix
' pixMorphSequenceMasked(PIX *, PIX *, const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This applies the morph sequence to the image, but only allows<para/>
''' changes in pixs for pixels under the background of pixm.<para/>
''' (5) If pixm is NULL, this is just pixMorphSequence().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pixm">[in][optional] - 1 bpp mask</param>
'''  <param name="sequence">[in] - string specifying sequence of operations</param>
'''  <param name="dispsep">[in] - horizontal separation in pixels between successive displays use zero to suppress display</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphSequenceMasked(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal sequence as String, 
				 ByVal dispsep as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")

	Dim pixmPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixm) Then pixmPTR = pixm.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphSequenceMasked( pixs.Pointer, pixmPTR, sequence, dispsep)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (195, 1)
' pixMorphSequenceByComponent(pixs, sequence, connectivity, minw, minh, pboxa) as Pix
' pixMorphSequenceByComponent(PIX *, const char *, l_int32, l_int32, l_int32, BOXA **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixMorphSequence() for composing operation sequences.<para/>
''' (2) This operates separately on each c.c. in the input pix.<para/>
''' (3) The dilation does NOT increase the c.c. size it is clipped<para/>
''' to the size of the original c.c. This is necessary to<para/>
''' keep the c.c. independent after the operation.<para/>
''' (4) You can specify that the width and/or height must equal<para/>
''' or exceed a minimum size for the operation to take place.<para/>
''' (5) Use NULL for boxa to avoid returning the boxa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="minw">[in] - minimum width to consider use 0 or 1 for any width</param>
'''  <param name="minh">[in] - minimum height to consider use 0 or 1 for any height</param>
'''  <param name="pboxa">[out][optional] - return boxa of c.c. in pixs</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphSequenceByComponent(
				 ByVal pixs as Pix, 
				 ByVal sequence as String, 
				 ByVal connectivity as Integer, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer, 
				<Out()> ByRef pboxa as Boxa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphSequenceByComponent( pixs.Pointer, sequence, connectivity, minw, minh, pboxaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (265, 1)
' pixaMorphSequenceByComponent(pixas, sequence, minw, minh) as Pixa
' pixaMorphSequenceByComponent(PIXA *, const char *, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixMorphSequence() for composing operation sequences.<para/>
''' (2) This operates separately on each c.c. in the input pixa.<para/>
''' (3) You can specify that the width and/or height must equal<para/>
''' or exceed a minimum size for the operation to take place.<para/>
''' (4) The input pixa should have a boxa giving the locations<para/>
''' of the pix components.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - of 1 bpp pix</param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="minw">[in] - minimum width to consider use 0 or 1 for any width</param>
'''  <param name="minh">[in] - minimum height to consider use 0 or 1 for any height</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaMorphSequenceByComponent(
				 ByVal pixas as Pixa, 
				 ByVal sequence as String, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaMorphSequenceByComponent( pixas.Pointer, sequence, minw, minh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\morphapp.c (348, 1)
' pixMorphSequenceByRegion(pixs, pixm, sequence, connectivity, minw, minh, pboxa) as Pix
' pixMorphSequenceByRegion(PIX *, PIX *, const char *, l_int32, l_int32, l_int32, BOXA **) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixMorphCompSequence() for composing operation sequences.<para/>
''' (2) This operates separately on the region in pixs corresponding<para/>
''' to each c.c. in the mask pixm.  It differs from<para/>
''' pixMorphSequenceByComponent() in that the latter does not have<para/>
''' a pixm (mask), but instead operates independently on each<para/>
''' component in pixs.<para/>
''' (3) Dilation will NOT increase the region size the result<para/>
''' is clipped to the size of the mask region.  This is necessary<para/>
''' to make regions independent after the operation.<para/>
''' (4) You can specify that the width and/or height of a region must<para/>
''' equal or exceed a minimum size for the operation to take place.<para/>
''' (5) Use NULL for %pboxa to avoid returning the boxa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pixm">[in] - mask specifying regions</param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="connectivity">[in] - 4 or 8, used on mask</param>
'''  <param name="minw">[in] - minimum width to consider use 0 or 1 for any width</param>
'''  <param name="minh">[in] - minimum height to consider use 0 or 1 for any height</param>
'''  <param name="pboxa">[out][optional] - return boxa of c.c. in pixm</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphSequenceByRegion(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal sequence as String, 
				 ByVal connectivity as Integer, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer, 
				<Out()> ByRef pboxa as Boxa) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")

Dim pboxaPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pboxa) Then pboxaPTR = pboxa.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphSequenceByRegion( pixs.Pointer, pixm.Pointer, sequence, connectivity, minw, minh, pboxaPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	if pboxaPTR <> IntPtr.Zero then pboxa = new Boxa(pboxaPTR)

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (427, 1)
' pixaMorphSequenceByRegion(pixs, pixam, sequence, minw, minh) as Pixa
' pixaMorphSequenceByRegion(PIX *, PIXA *, const char *, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixMorphSequence() for composing operation sequences.<para/>
''' (2) This operates separately on each region in the input pixs<para/>
''' defined by the components in pixam.<para/>
''' (3) You can specify that the width and/or height of a mask<para/>
''' component must equal or exceed a minimum size for the<para/>
''' operation to take place.<para/>
''' (4) The input pixam should have a boxa giving the locations<para/>
''' of the regions in pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="pixam">[in] - of 1 bpp mask elements</param>
'''  <param name="sequence">[in] - string specifying sequence</param>
'''  <param name="minw">[in] - minimum width to consider use 0 or 1 for any width</param>
'''  <param name="minh">[in] - minimum height to consider use 0 or 1 for any height</param>
'''   <returns>pixad, or NULL on error</returns>
Public Shared Function pixaMorphSequenceByRegion(
				 ByVal pixs as Pix, 
				 ByVal pixam as Pixa, 
				 ByVal sequence as String, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer) as Pixa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixam) then Throw New ArgumentNullException  ("pixam cannot be Nothing")
	If IsNothing (sequence) then Throw New ArgumentNullException  ("sequence cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaMorphSequenceByRegion( pixs.Pointer, pixam.Pointer, sequence, minw, minh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\morphapp.c (502, 1)
' pixUnionOfMorphOps(pixs, sela, type) as Pix
' pixUnionOfMorphOps(PIX *, SELA *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - binary</param>
'''  <param name="sela">[in] - </param>
'''  <param name="type">[in] - L_MORPH_DILATE, etc.</param>
'''   <returns>pixd union of the specified morphological operation on pixs for each Sel in the Sela, or NULL on error</returns>
Public Shared Function pixUnionOfMorphOps(
				 ByVal pixs as Pix, 
				 ByVal sela as Sela, 
				 ByVal type as Enumerations.L_MORPH) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixUnionOfMorphOps( pixs.Pointer, sela.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (555, 1)
' pixIntersectionOfMorphOps(pixs, sela, type) as Pix
' pixIntersectionOfMorphOps(PIX *, SELA *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - binary</param>
'''  <param name="sela">[in] - </param>
'''  <param name="type">[in] - L_MORPH_DILATE, etc.</param>
'''   <returns>pixd intersection of the specified morphological operation on pixs for each Sel in the Sela, or NULL on error</returns>
Public Shared Function pixIntersectionOfMorphOps(
				 ByVal pixs as Pix, 
				 ByVal sela as Sela, 
				 ByVal type as Enumerations.L_MORPH) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (sela) then Throw New ArgumentNullException  ("sela cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixIntersectionOfMorphOps( pixs.Pointer, sela.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (613, 1)
' pixSelectiveConnCompFill(pixs, connectivity, minw, minh) as Pix
' pixSelectiveConnCompFill(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - binary</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''  <param name="minw">[in] - minimum width to consider use 0 or 1 for any width</param>
'''  <param name="minh">[in] - minimum height to consider use 0 or 1 for any height</param>
'''   <returns>pix with holes filled in selected c.c., or NULL on error</returns>
Public Shared Function pixSelectiveConnCompFill(
				 ByVal pixs as Pix, 
				 ByVal connectivity as Integer, 
				 ByVal minw as Integer, 
				 ByVal minh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSelectiveConnCompFill( pixs.Pointer, connectivity, minw, minh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (684, 1)
' pixRemoveMatchedPattern(pixs, pixp, pixe, x0, y0, dsize) as Integer
' pixRemoveMatchedPattern(PIX *, PIX *, PIX *, l_int32, l_int32, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is in-place.<para/>
''' (2) You can use various functions in selgen to create a Sel<para/>
''' that is used to generate pixe from pixs.<para/>
''' (3) This function is applied after pixe has been computed.<para/>
''' It finds the centroid of each c.c., and subtracts<para/>
''' (the appropriately dilated version of) pixp, with the center<para/>
''' of the Sel used to align pixp with pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input image, 1 bpp</param>
'''  <param name="pixp">[in] - pattern to be removed from image, 1 bpp</param>
'''  <param name="pixe">[in] - image after erosion by Sel that approximates pixp, 1 bpp</param>
'''  <param name="x0">[in] - center of Sel</param>
'''  <param name="y0">[in] - center of Sel</param>
'''  <param name="dsize">[in] - number of pixels on each side by which pixp is dilated before being subtracted from pixs valid values are {0, 1, 2, 3, 4}</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRemoveMatchedPattern(
				 ByVal pixs as Pix, 
				 ByVal pixp as Pix, 
				 ByVal pixe as Pix, 
				 ByVal x0 as Integer, 
				 ByVal y0 as Integer, 
				 ByVal dsize as Integer) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixp) then Throw New ArgumentNullException  ("pixp cannot be Nothing")
	If IsNothing (pixe) then Throw New ArgumentNullException  ("pixe cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixRemoveMatchedPattern( pixs.Pointer, pixp.Pointer, pixe.Pointer, x0, y0, dsize)

	Return _Result
End Function

' SRC\morphapp.c (789, 1)
' pixDisplayMatchedPattern(pixs, pixp, pixe, x0, y0, color, scale, nlevels) as Pix
' pixDisplayMatchedPattern(PIX *, PIX *, PIX *, l_int32, l_int32, l_uint32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) A 4 bpp colormapped image is generated.<para/>
''' (2) If scale  is lower = 1.0, do scale to gray for the output, and threshold<para/>
''' to nlevels of gray.<para/>
''' (3) You can use various functions in selgen to create a Sel<para/>
''' that will generate pixe from pixs.<para/>
''' (4) This function is applied after pixe has been computed.<para/>
''' It finds the centroid of each c.c., and colors the output<para/>
''' pixels using pixp (appropriately aligned) as a stencil.<para/>
''' Alignment is done using the origin of the Sel and the<para/>
''' centroid of the eroded image to place the stencil pixp.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - input image, 1 bpp</param>
'''  <param name="pixp">[in] - pattern to be removed from image, 1 bpp</param>
'''  <param name="pixe">[in] - image after erosion by Sel that approximates pixp, 1 bpp</param>
'''  <param name="x0">[in] - center of Sel</param>
'''  <param name="y0">[in] - center of Sel</param>
'''  <param name="color">[in] - to paint the matched patterns 0xrrggbb00</param>
'''  <param name="scale">[in] - reduction factor for output pixd</param>
'''  <param name="nlevels">[in] - if scale  is lower  1.0, threshold to this number of levels</param>
'''   <returns>pixd 8 bpp, colormapped, or NULL on error</returns>
Public Shared Function pixDisplayMatchedPattern(
				 ByVal pixs as Pix, 
				 ByVal pixp as Pix, 
				 ByVal pixe as Pix, 
				 ByVal x0 as Integer, 
				 ByVal y0 as Integer, 
				 ByVal color as UInteger, 
				 ByVal scale as Single, 
				 ByVal nlevels as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixp) then Throw New ArgumentNullException  ("pixp cannot be Nothing")
	If IsNothing (pixe) then Throw New ArgumentNullException  ("pixe cannot be Nothing")
	If IsNothing (scale) then Throw New ArgumentNullException  ("scale cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixDisplayMatchedPattern( pixs.Pointer, pixp.Pointer, pixe.Pointer, x0, y0, color, scale, nlevels)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (901, 1)
' pixaExtendByMorph(pixas, type, niters, sel, include) as Pixa
' pixaExtendByMorph(PIXA *, l_int32, l_int32, SEL *, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This dilates or erodes every pix in %pixas, iteratively,<para/>
''' using the input Sel (or, if null, a 2x2 Sel by default),<para/>
''' and puts the results in %pixad.<para/>
''' (2) If %niters  is lower = 0, this is a no-op it returns a clone of pixas.<para/>
''' (3) If %include == 1, the output %pixad contains all the pix<para/>
''' in %pixas.  Otherwise, it doesn't, but pixaJoin() can be<para/>
''' used later to join pixas with pixad.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="type">[in] - L_MORPH_DILATE, L_MORPH_ERODE</param>
'''  <param name="niters">[in] - </param>
'''  <param name="sel">[in] - used for dilation, erosion uses 2x2 if null</param>
'''  <param name="include">[in] - 1 to include a copy of the input pixas in pixad 0 to omit</param>
'''   <returns>pixad   with derived pix, using all iterations, or NULL on error</returns>
Public Shared Function pixaExtendByMorph(
				 ByVal pixas as Pixa, 
				 ByVal type as Enumerations.L_MORPH, 
				 ByVal niters as Integer, 
				 ByVal sel as Sel, 
				 ByVal include as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (sel) then Throw New ArgumentNullException  ("sel cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaExtendByMorph( pixas.Pointer, type, niters, sel.Pointer, include)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\morphapp.c (973, 1)
' pixaExtendByScaling(pixas, nasc, type, include) as Pixa
' pixaExtendByScaling(PIXA *, NUMA *, l_int32, l_int32) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This scales every pix in %pixas by each factor in %nasc.<para/>
''' and puts the results in %pixad.<para/>
''' (2) If %include == 1, the output %pixad contains all the pix<para/>
''' in %pixas.  Otherwise, it doesn't, but pixaJoin() can be<para/>
''' used later to join pixas with pixad.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixas">[in] - </param>
'''  <param name="nasc">[in] - numa of scaling factors</param>
'''  <param name="type">[in] - L_HORIZ, L_VERT, L_BOTH_DIRECTIONS</param>
'''  <param name="include">[in] - 1 to include a copy of the input pixas in pixad 0 to omit</param>
'''   <returns>pixad   with derived pix, using all scalings, or NULL on error</returns>
Public Shared Function pixaExtendByScaling(
				 ByVal pixas as Pixa, 
				 ByVal nasc as Numa, 
				 ByVal type as Enumerations.L_direction, 
				 ByVal include as Integer) as Pixa

	If IsNothing (pixas) then Throw New ArgumentNullException  ("pixas cannot be Nothing")
	If IsNothing (nasc) then Throw New ArgumentNullException  ("nasc cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaExtendByScaling( pixas.Pointer, nasc.Pointer, type, include)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\morphapp.c (1041, 1)
' pixSeedfillMorph(pixs, pixm, maxiters, connectivity) as Pix
' pixSeedfillMorph(PIX *, PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is in general a very inefficient method for filling<para/>
''' from a seed into a mask.  Use it for a small number of iterations,<para/>
''' but if you expect more than a few iterations, use<para/>
''' pixSeedfillBinary().<para/>
''' (2) We use a 3x3 brick SEL for 8-cc filling and a 3x3 plus SEL for 4-cc.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - seed</param>
'''  <param name="pixm">[in] - mask</param>
'''  <param name="maxiters">[in] - use 0 to go to completion</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd after filling into the mask or NULL on error</returns>
Public Shared Function pixSeedfillMorph(
				 ByVal pixs as Pix, 
				 ByVal pixm as Pix, 
				 ByVal maxiters as Integer, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixSeedfillMorph( pixs.Pointer, pixm.Pointer, maxiters, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (1103, 1)
' pixRunHistogramMorph(pixs, runtype, direction, maxsize) as Numa
' pixRunHistogramMorph(PIX *, l_int32, l_int32, l_int32) as NUMA *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="runtype">[in] - L_RUN_OFF, L_RUN_ON</param>
'''  <param name="direction">[in] - L_HORIZ, L_VERT</param>
'''  <param name="maxsize">[in] - size of largest runlength counted</param>
'''   <returns>numa of run-lengths</returns>
Public Shared Function pixRunHistogramMorph(
				 ByVal pixs as Pix, 
				 ByVal runtype as Enumerations.L_RUN_O, 
				 ByVal direction as Enumerations.L_direction, 
				 ByVal maxsize as Integer) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixRunHistogramMorph( pixs.Pointer, runtype, direction, maxsize)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\morphapp.c (1203, 1)
' pixTophat(pixs, hsize, vsize, type) as Pix
' pixTophat(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Sel is a brick with all elements being hits<para/>
''' (2) If hsize = vsize = 1, returns an image with all 0 data.<para/>
''' (3) The L_TOPHAT_WHITE flag emphasizes small bright regions,<para/>
''' whereas the L_TOPHAT_BLACK flag emphasizes small dark regions.<para/>
''' The L_TOPHAT_WHITE tophat can be accomplished by doing a<para/>
''' L_TOPHAT_BLACK tophat on the inverse, or v.v.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''  <param name="type">[in] - L_TOPHAT_WHITE: image - opening L_TOPHAT_BLACK: closing - image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixTophat(
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer, 
				 ByVal type as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixTophat( pixs.Pointer, hsize, vsize, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (1303, 1)
' pixHDome(pixs, height, connectivity) as Pix
' pixHDome(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) It is more efficient to use a connectivity of 4 for the fill.<para/>
''' (2) This fills bumps to some level, and extracts the unfilled<para/>
''' part of the bump.  To extract the troughs of basins, first<para/>
''' invert pixs and then apply pixHDome().<para/>
''' (3) It is useful to compare the HDome operation with the TopHat.<para/>
''' The latter extracts peaks or valleys that have a width<para/>
''' not exceeding the size of the structuring element used<para/>
''' in the opening or closing, rsp.  The height of the peak is<para/>
''' irrelevant.  By contrast, for the HDome, the gray seedfill<para/>
''' is used to extract all peaks that have a height not exceeding<para/>
''' a given value, regardless of their width!<para/>
''' (4) Slightly more precisely, suppose you set 'height' = 40.<para/>
''' Then all bumps in pixs with a height greater than or equal<para/>
''' to 40 become, in pixd, bumps with a max value of exactly 40.<para/>
''' All shorter bumps have a max value in pixd equal to the height<para/>
''' of the bump.<para/>
''' (5) The method: the filling mask, pixs, is the image whose peaks<para/>
''' are to be extracted.  The height of a peak is the distance<para/>
''' between the top of the peak and the highest "leak" to the<para/>
''' outside -- think of a sombrero, where the leak occurs<para/>
''' at the highest point on the rim.<para/>
''' (a) Generate a seed, pixd, by subtracting some value, p, from<para/>
''' each pixel in the filling mask, pixs.  The value p is<para/>
''' the 'height' input to this function.<para/>
''' (b) Fill in pixd starting with this seed, clipping by pixs,<para/>
''' in the way described in seedfillGrayLow().  The filling<para/>
''' stops before the peaks in pixs are filled.<para/>
''' For peaks that have a height  is greater  p, pixd is filled to<para/>
''' the level equal to the (top-of-the-peak - p).<para/>
''' For peaks of height  is lower  p, the peak is left unfilled<para/>
''' from its highest saddle point (the leak to the outside).<para/>
''' (c) Subtract the filled seed (pixd) from the filling mask (pixs).<para/>
''' Note that in this procedure, everything is done starting<para/>
''' with the filling mask, pixs.<para/>
''' (6) For segmentation, the resulting image, pixd, can be thresholded<para/>
''' and used as a seed for another filling operation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp, filling mask</param>
'''  <param name="height">[in] - of seed below the filling maskhdome must be  is greater = 0</param>
'''  <param name="connectivity">[in] - 4 or 8</param>
'''   <returns>pixd 8 bpp, or NULL on error</returns>
Public Shared Function pixHDome(
				 ByVal pixs as Pix, 
				 ByVal height as Integer, 
				 ByVal connectivity as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixHDome( pixs.Pointer, height, connectivity)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (1359, 1)
' pixFastTophat(pixs, xsize, ysize, type) as Pix
' pixFastTophat(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Don't be fooled. This is NOT a tophat.  It is a tophat-like<para/>
''' operation, where the result is similar to what you'd get<para/>
''' if you used an erosion instead of an opening, or a dilation<para/>
''' instead of a closing.<para/>
''' (2) Instead of opening or closing at full resolution, it does<para/>
''' a fast downscale/minmax operation, then a quick small smoothing<para/>
''' at low res, a replicative expansion of the "background"<para/>
''' to full res, and finally a removal of the background level<para/>
''' from the input image.  The smoothing step may not be important.<para/>
''' (3) It does not remove noise as well as a tophat, but it is<para/>
''' 5 to 10 times faster.<para/>
''' If you need the preciseness of the tophat, don't use this.<para/>
''' (4) The L_TOPHAT_WHITE flag emphasizes small bright regions,<para/>
''' whereas the L_TOPHAT_BLACK flag emphasizes small dark regions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="xsize">[in] - width of max/min op, smoothing any integer  is greater = 1</param>
'''  <param name="ysize">[in] - height of max/min op, smoothing any integer  is greater = 1</param>
'''  <param name="type">[in] - L_TOPHAT_WHITE: image - min L_TOPHAT_BLACK: max - image</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixFastTophat(
				 ByVal pixs as Pix, 
				 ByVal xsize as Integer, 
				 ByVal ysize as Integer, 
				 ByVal type as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFastTophat( pixs.Pointer, xsize, ysize, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (1421, 1)
' pixMorphGradient(pixs, hsize, vsize, smoothing) as Pix
' pixMorphGradient(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - </param>
'''  <param name="hsize">[in] - of Sel must be odd origin implicitly in center</param>
'''  <param name="vsize">[in] - ditto</param>
'''  <param name="smoothing">[in] - half-width of convolution smoothing filter. The width is (2  smoothing + 1, so 0 is no-op.</param>
'''   <returns>pixd, or NULL on error</returns>
Public Shared Function pixMorphGradient(
				 ByVal pixs as Pix, 
				 ByVal hsize as Integer, 
				 ByVal vsize as Integer, 
				 ByVal smoothing as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMorphGradient( pixs.Pointer, hsize, vsize, smoothing)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\morphapp.c (1475, 1)
' pixaCentroids(pixa) as Pta
' pixaCentroids(PIXA *) as PTA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) An error message is returned if any pix has something other<para/>
''' than 1 bpp or 8 bpp depth, and the centroid from that pix<para/>
''' is saved as (0, 0).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixa">[in] - of components 1 or 8 bpp</param>
'''   <returns>pta of centroids relative to the UL corner of each pix, or NULL on error</returns>
Public Shared Function pixaCentroids(
				 ByVal pixa as Pixa) as Pta

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaCentroids( pixa.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pta(_Result)
End Function

' SRC\morphapp.c (1527, 1)
' pixCentroid(pix, centtab, sumtab, pxave, pyave) as Integer
' pixCentroid(PIX *, l_int32 *, l_int32 *, l_float32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Any table not passed in will be made internally and destroyed<para/>
''' after use.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix">[in] - 1 or 8 bpp</param>
'''  <param name="centtab">[in][optional] - table for finding centroids can be null</param>
'''  <param name="sumtab">[in][optional] - table for finding pixel sums can be null</param>
'''  <param name="pxave">[out] - coordinates of centroid, relative to the UL corner of the pix</param>
'''  <param name="pyave">[out] - coordinates of centroid, relative to the UL corner of the pix</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCentroid(
				 ByVal pix as Pix, 
				 ByVal centtab as Integer(), 
				 ByVal sumtab as Integer(), 
				<Out()> ByRef pxave as Single(), 
				<Out()> ByRef pyave as Single()) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixCentroid( pix.Pointer, centtab, sumtab, pxave, pyave)

	Return _Result
End Function

End Class

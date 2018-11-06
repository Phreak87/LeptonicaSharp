Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\scale2.c (204, 1)
' pixScaleToGray(pixs, scalefactor) as Pix
' pixScaleToGray(PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' For faster scaling in the range of scalefactors from 0.0625 to 0.5,<para/>
''' with very little difference in quality, use pixScaleToGrayFast().<para/>
''' Binary images have sharp edges, so they intrinsically have very<para/>
''' high frequency content.  To avoid aliasing, they must be low-pass<para/>
''' filtered, which tends to blur the edges.  How can we keep relatively<para/>
''' crisp edges without aliasing?  The trick is to do binary upscaling<para/>
''' followed by a power-of-2 scaleToGray.  For large reductions, where<para/>
''' you don't end up with much detail, some corners can be cut.<para/>
''' The intent here is to get high quality reduced grayscale<para/>
''' images with relatively little computation.  We do binary<para/>
''' pre-scaling followed by scaleToGrayN() for best results,<para/>
''' esp. to avoid excess blur when the scale factor is near<para/>
''' an inverse power of 2.  Where a low-pass filter is required,<para/>
''' we use simple convolution kernels: either the hat filter for<para/>
''' linear interpolation or a flat filter for larger downscaling.<para/>
''' Other choices, such as a perfect bandpass filter with infinite extent<para/>
''' (the sinc) or various approximations to it (e.g., lanczos), are<para/>
''' unnecessarily expensive.<para/>
''' The choices made are as follows:<para/>
''' (1) Do binary upscaling before scaleToGrayN() for scalefactors  is greater  1/8<para/>
''' (2) Do binary downscaling before scaleToGray8() for scalefactors<para/>
''' between 1/16 and 1/8.<para/>
''' (3) Use scaleToGray16() before grayscale downscaling for<para/>
''' scalefactors less than 1/16<para/>
''' Another reasonable choice would be to start binary downscaling<para/>
''' for scalefactors below 1/4, rather than below 1/8 as we do here.<para/>
''' The general scaling rules, not all of which are used here, go as follows:<para/>
''' (1) For grayscale upscaling, use pixScaleGrayLI().  However,<para/>
''' note that edges will be visibly blurred for scalefactors<para/>
''' near (but above) 1.0.  Replication will avoid edge blur,<para/>
''' and should be considered for factors very near 1.0.<para/>
''' (2) For grayscale downscaling with a scale factor larger than<para/>
''' about 0.7, use pixScaleGrayLI().  For scalefactors near<para/>
''' (but below) 1.0, you tread between Scylla and Charybdis.<para/>
''' pixScaleGrayLI() again gives edge blurring, but<para/>
''' pixScaleBySampling() gives visible aliasing.<para/>
''' (3) For grayscale downscaling with a scale factor smaller than<para/>
''' about 0.7, use pixScaleSmooth()<para/>
''' (4) For binary input images, do as much scale to gray as possible<para/>
''' using the special integer functions (2, 3, 4, 8 and 16).<para/>
''' (5) It is better to upscale in binary, followed by scaleToGrayN()<para/>
''' than to do scaleToGrayN() followed by an upscale using either<para/>
''' LI or oversampling.<para/>
''' (6) It may be better to downscale in binary, followed by<para/>
''' scaleToGrayN() than to first use scaleToGrayN() followed by<para/>
''' downscaling.  For downscaling between 8x and 16x, this is<para/>
''' a reasonable option.<para/>
''' (7) For reductions greater than 16x, it's reasonable to use<para/>
''' scaleToGray16() followed by further grayscale downscaling.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="scalefactor">[in] - reduction: must be  is greater  0.0 and  is lower  1.0</param>
'''   <returns>pixd 8 bpp, scaled down by scalefactor in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray(
				 ByVal pixs as Pix, 
				 ByVal scalefactor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray( pixs.Pointer, scalefactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (315, 1)
' pixScaleToGrayFast(pixs, scalefactor) as Pix
' pixScaleToGrayFast(PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in pixScaleToGray() for the basic approach.<para/>
''' (2) This function is considerably less expensive than pixScaleToGray()<para/>
''' for scalefactor in the range (0.0625 ... 0.5), and the<para/>
''' quality is nearly as good.<para/>
''' (3) Unlike pixScaleToGray(), which does binary upscaling before<para/>
''' downscaling for scale factors  is greater = 0.0625, pixScaleToGrayFast()<para/>
''' first downscales in binary for all scale factors  is lower  0.5, and<para/>
''' then does a 2x scale-to-gray as the final step.  For<para/>
''' scale factors  is lower  0.0625, both do a 16x scale-to-gray, followed<para/>
''' by further grayscale reduction.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGrayFast/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="scalefactor">[in] - reduction: must be  is greater  0.0 and  is lower  1.0</param>
'''   <returns>pixd 8 bpp, scaled down by scalefactor in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGrayFast(
				 ByVal pixs as Pix, 
				 ByVal scalefactor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGrayFast( pixs.Pointer, scalefactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (386, 1)
' pixScaleToGray2(pixs) as Pix
' pixScaleToGray2(PIX *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray2/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 2x in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray2(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray2( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (443, 1)
' pixScaleToGray3(pixs) as Pix
' pixScaleToGray3(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Speed is about 100 x 10^6 src-pixels/sec/GHz.<para/>
''' Another way to express this is it processes 1 src pixel<para/>
''' in about 10 cycles.<para/>
''' (2) The width of pixd is truncated is truncated to a factor of 8.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray3/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 3x in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray3(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray3( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (497, 1)
' pixScaleToGray4(pixs) as Pix
' pixScaleToGray4(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The width of pixd is truncated is truncated to a factor of 2.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray4/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 4x in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray4(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray4( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (552, 1)
' pixScaleToGray6(pixs) as Pix
' pixScaleToGray6(PIX *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The width of pixd is truncated is truncated to a factor of 8.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray6/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 6x in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray6(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray6( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (600, 1)
' pixScaleToGray8(pixs) as Pix
' pixScaleToGray8(PIX *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray8/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 8x in each direction, or NULL on error</returns>
Public Shared Function pixScaleToGray8(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray8( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (649, 1)
' pixScaleToGray16(pixs) as Pix
' pixScaleToGray16(PIX *) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGray16/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''   <returns>pixd 8 bpp, scaled down by 16x in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGray16(
				 ByVal pixs as Pix) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGray16( pixs.Pointer)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (722, 1)
' pixScaleToGrayMipmap(pixs, scalefactor) as Pix
' pixScaleToGrayMipmap(PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' This function is here mainly for pedagogical reasons.<para/>
''' Mip-mapping is widely used in graphics for texture mapping, because<para/>
''' the texture changes smoothly with scale.  This is accomplished by<para/>
''' constructing a multiresolution pyramid and, for each pixel,<para/>
''' doing a linear interpolation between corresponding pixels in<para/>
''' the two planes of the pyramid that bracket the desired resolution.<para/>
''' The computation is very efficient, and is implemented in hardware<para/>
''' in high-end graphics cards.<para/>
''' We can use mip-mapping for scale-to-gray by using two scale-to-gray<para/>
''' reduced images (we don't need the entire pyramid) selected from<para/>
''' the set {2x, 4x, ... 16x}, and interpolating.  However, we get<para/>
''' severe aliasing, probably because we are subsampling from the<para/>
''' higher resolution image.  The method is very fast, but the result<para/>
''' is very poor.  In fact, the results don't look any better than<para/>
''' either subsampling off the higher-res grayscale image or oversampling<para/>
''' on the lower-res image.  Consequently, this method should NOT be used<para/>
''' for generating reduced images, scale-to-gray or otherwise.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleToGrayMipmap/*"/>
'''  <param name="pixs">[in] - 1 bpp</param>
'''  <param name="scalefactor">[in] - reduction: must be  is greater  0.0 and  is lower  1.0</param>
'''   <returns>pixd 8 bpp, scaled down by scalefactor in each direction, or NULL on error.</returns>
Public Shared Function pixScaleToGrayMipmap(
				 ByVal pixs as Pix, 
				 ByVal scalefactor as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1}.contains (pixs.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleToGrayMipmap( pixs.Pointer, scalefactor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (810, 1)
' pixScaleMipmap(pixs1, pixs2, scale) as Pix
' pixScaleMipmap(PIX *, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See notes in pixScaleToGrayMipmap().<para/>
''' (2) This function suffers from aliasing effects that are<para/>
''' easily seen in document images.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleMipmap/*"/>
'''  <param name="pixs1">[in] - high res 8 bpp, no cmap</param>
'''  <param name="pixs2">[in] - low res -- 2x reduced -- 8 bpp, no cmap</param>
'''  <param name="scale">[in] - reduction with respect to high res image,  is greater  0.5</param>
'''   <returns>8 bpp pix, scaled down by reduction in each direction, or NULL on error.</returns>
Public Shared Function pixScaleMipmap(
				 ByVal pixs1 as Pix, 
				 ByVal pixs2 as Pix, 
				 ByVal scale as Single) as Pix

	If IsNothing (pixs1) then Throw New ArgumentNullException  ("pixs1 cannot be Nothing")
	If IsNothing (pixs2) then Throw New ArgumentNullException  ("pixs2 cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleMipmap( pixs1.Pointer, pixs2.Pointer, scale)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (867, 1)
' pixExpandReplicate(pixs, factor) as Pix
' pixExpandReplicate(PIX *, l_int32) as PIX *
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixExpandReplicate/*"/>
'''  <param name="pixs">[in] - 1, 2, 4, 8, 16, 32 bpp</param>
'''  <param name="factor">[in] - integer scale factor for replicative expansion</param>
'''   <returns>pixd scaled up, or NULL on error.</returns>
Public Shared Function pixExpandReplicate(
				 ByVal pixs as Pix, 
				 ByVal factor as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {1,2,4,8,16,32}.contains (pixs.d) = false then Throw New ArgumentException ("1, 2, 4, 8, 16, 32 bpp")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixExpandReplicate( pixs.Pointer, factor)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (1014, 1)
' pixScaleGrayMinMax(pixs, xfact, yfact, type) as Pix
' pixScaleGrayMinMax(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The downscaled pixels in pixd are the min, max or (max - min)<para/>
''' of the corresponding set of xfact  yfact pixels in pixs.<para/>
''' (2) Using L_CHOOSE_MIN is equivalent to a grayscale erosion,<para/>
''' using a brick Sel of size (xfact  yfact), followed by<para/>
''' subsampling within each (xfact  yfact) cell.  Using<para/>
''' L_CHOOSE_MAX is equivalent to the corresponding dilation.<para/>
''' (3) Using L_CHOOSE_MAXDIFF finds the difference between max<para/>
''' and min values in each cell.<para/>
''' (4) For the special case of downscaling by 2x in both directions,<para/>
''' pixScaleGrayMinMax2() is about 2x more efficient.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleGrayMinMax/*"/>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="xfact">[in] - x downscaling factor integer</param>
'''  <param name="yfact">[in] - y downscaling factor integer</param>
'''  <param name="type">[in] - L_CHOOSE_MIN, L_CHOOSE_MAX, L_CHOOSE_MAXDIFF</param>
'''   <returns>pixd 8 bpp</returns>
Public Shared Function pixScaleGrayMinMax(
				 ByVal pixs as Pix, 
				 ByVal xfact as Integer, 
				 ByVal yfact as Integer, 
				 ByVal type as Enumerations.L_CHOOSE_M) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleGrayMinMax( pixs.Pointer, xfact, yfact, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (1121, 1)
' pixScaleGrayMinMax2(pixs, type) as Pix
' pixScaleGrayMinMax2(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Special version for 2x reduction.  The downscaled pixels<para/>
''' in pixd are the min, max or (max - min) of the corresponding<para/>
''' set of 4 pixels in pixs.<para/>
''' (2) The max and min operations are a special case (for levels 1<para/>
''' and 4) of grayscale analog to the binary rank scaling operation<para/>
''' pixReduceRankBinary2().  Note, however, that because of<para/>
''' the photometric definition that higher gray values are<para/>
''' lighter, the erosion-like L_CHOOSE_MIN will darken<para/>
''' the resulting image, corresponding to a threshold level 1<para/>
''' in the binary case.  Likewise, L_CHOOSE_MAX will lighten<para/>
''' the pixd, corresponding to a threshold level of 4.<para/>
''' (3) To choose any of the four rank levels in a 2x grayscale<para/>
''' reduction, use pixScaleGrayRank2().<para/>
''' (4) This runs at about 70 MPix/sec/GHz of source data for<para/>
''' erosion and dilation.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleGrayMinMax2/*"/>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="type">[in] - L_CHOOSE_MIN, L_CHOOSE_MAX, L_CHOOSE_MAXDIFF</param>
'''   <returns>pixd 8 bpp downscaled by 2x</returns>
Public Shared Function pixScaleGrayMinMax2(
				 ByVal pixs as Pix, 
				 ByVal type as Enumerations.L_CHOOSE_M) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleGrayMinMax2( pixs.Pointer, type)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (1204, 1)
' pixScaleGrayRankCascade(pixs, level1, level2, level3, level4) as Pix
' pixScaleGrayRankCascade(PIX *, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This performs up to four cascaded 2x rank reductions.<para/>
''' (2) Use level = 0 to truncate the cascade.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleGrayRankCascade/*"/>
'''  <param name="pixs">[in] - 8 bpp, not cmapped</param>
'''  <param name="level1">[in] - rank thresholds, in set {0, 1, 2, 3, 4}</param>
'''  <param name="level2">[in] - rank thresholds, in set {0, 1, 2, 3, 4}</param>
'''  <param name="level3">[in] - rank thresholds, in set {0, 1, 2, 3, 4}</param>
'''  <param name="level4">[in] - rank thresholds, in set {0, 1, 2, 3, 4}</param>
'''   <returns>pixd 8 bpp, downscaled by up to 16x</returns>
Public Shared Function pixScaleGrayRankCascade(
				 ByVal pixs as Pix, 
				 ByVal level1 as Integer, 
				 ByVal level2 as Integer, 
				 ByVal level3 as Integer, 
				 ByVal level4 as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleGrayRankCascade( pixs.Pointer, level1, level2, level3, level4)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (1268, 1)
' pixScaleGrayRank2(pixs, rank) as Pix
' pixScaleGrayRank2(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Rank 2x reduction.  If rank == 1(4), the downscaled pixels<para/>
''' in pixd are the min(max) of the corresponding set of<para/>
''' 4 pixels in pixs.  Values 2 and 3 are intermediate.<para/>
''' (2) This is the grayscale analog to the binary rank scaling operation<para/>
''' pixReduceRankBinary2().  Here, because of the photometric<para/>
''' definition that higher gray values are lighter, rank 1 gives<para/>
''' the darkest pixel, whereas rank 4 gives the lightest pixel.<para/>
''' This is opposite to the binary rank operation.<para/>
''' (3) For rank = 1 and 4, this calls pixScaleGrayMinMax2(),<para/>
''' which runs at about 70 MPix/sec/GHz of source data.<para/>
''' For rank 2 and 3, this runs 3x slower, at about 25 MPix/sec/GHz.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleGrayRank2/*"/>
'''  <param name="pixs">[in] - 8 bpp, no cmap</param>
'''  <param name="rank">[in] - 1 (darkest), 2, 3, 4 (lightest)</param>
'''   <returns>pixd 8 bpp, downscaled by 2x</returns>
Public Shared Function pixScaleGrayRank2(
				 ByVal pixs as Pix, 
				 ByVal rank as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleGrayRank2( pixs.Pointer, rank)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\scale2.c (1358, 1)
' pixScaleAndTransferAlpha(pixd, pixs, scalex, scaley) as Integer
' pixScaleAndTransferAlpha(PIX *, PIX *, l_float32, l_float32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This scales the alpha component of pixs and inserts into pixd.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleAndTransferAlpha/*"/>
'''  <param name="pixd">[in] - 32 bpp, scaled image</param>
'''  <param name="pixs">[in] - 32 bpp, original unscaled image</param>
'''  <param name="scalex">[in] - both  is greater  0.0</param>
'''  <param name="scaley">[in] - both  is greater  0.0</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function pixScaleAndTransferAlpha(
				 ByVal pixd as Pix, 
				 ByVal pixs as Pix, 
				 Optional ByVal scalex as Single = 1, 
				 Optional ByVal scaley as Single = 1) as Integer

	If IsNothing (pixd) then Throw New ArgumentNullException  ("pixd cannot be Nothing")
	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixScaleAndTransferAlpha( pixd.Pointer, pixs.Pointer, scalex, scaley)

	Return _Result
End Function

' SRC\scale2.c (1436, 1)
' pixScaleWithAlpha(pixs, scalex, scaley, pixg, fract) as Pix
' pixScaleWithAlpha(PIX *, l_float32, l_float32, PIX *, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The alpha channel is transformed separately from pixs,<para/>
''' and aligns with it, being fully transparent outside the<para/>
''' boundary of the transformed pixs.  For pixels that are fully<para/>
''' transparent, a blending function like pixBlendWithGrayMask()<para/>
''' will give zero weight to corresponding pixels in pixs.<para/>
''' (2) Scaling is done with area mapping or linear interpolation,<para/>
''' depending on the scale factors.  Default sharpening is done.<para/>
''' (3) If pixg is NULL, it is generated as an alpha layer that is<para/>
''' partially opaque, using %fract.  Otherwise, it is cropped<para/>
''' to pixs if required, and %fract is ignored.  The alpha<para/>
''' channel in pixs is never used.<para/>
''' (4) Colormaps are removed to 32 bpp.<para/>
''' (5) The default setting for the border values in the alpha channel<para/>
''' is 0 (transparent) for the outermost ring of pixels and<para/>
''' (0.5  fract  255) for the second ring.  When blended over<para/>
''' a second image, this<para/>
''' (a) shrinks the visible image to make a clean overlap edge<para/>
''' with an image below, and<para/>
''' (b) softens the edges by weakening the aliasing there.<para/>
''' Use l_setAlphaMaskBorder() to change these values.<para/>
''' (6) A subtle use of gamma correction is to remove gamma correction<para/>
''' before scaling and restore it afterwards.  This is done<para/>
''' by sandwiching this function between a gamma/inverse-gamma<para/>
''' photometric transform:<para/>
''' pixt = pixGammaTRCWithAlpha(NULL, pixs, 1.0 / gamma, 0, 255)<para/>
''' pixd = pixScaleWithAlpha(pixt, scalex, scaley, NULL, fract)<para/>
''' pixGammaTRCWithAlpha(pixd, pixd, gamma, 0, 255)<para/>
''' pixDestroy( and pixt)<para/>
''' This has the side-effect of producing artifacts in the very<para/>
''' dark regions.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixScaleWithAlpha/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb or cmapped</param>
'''  <param name="scalex">[in] - must be  is greater  0.0</param>
'''  <param name="scaley">[in] - must be  is greater  0.0</param>
'''  <param name="pixg">[in][optional] - 8 bpp, can be null</param>
'''  <param name="fract">[in] - between 0.0 and 1.0, with 0.0 fully transparent and 1.0 fully opaque</param>
'''   <returns>pixd 32 bpp rgba, or NULL on error</returns>
Public Shared Function pixScaleWithAlpha(
				 ByVal pixs as Pix, 
				 ByVal scalex as Single, 
				 ByVal scaley as Single, 
				 ByVal pixg as Pix, 
				 ByVal fract as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim pixgPTR As IntPtr = IntPtr.Zero : If Not IsNothing(pixg) Then pixgPTR = pixg.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixScaleWithAlpha( pixs.Pointer, scalex, scaley, pixgPTR, fract)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

End Class

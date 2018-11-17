Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All

' SRC\colorquant2.c (257, 1)
' pixMedianCutQuant(pixs, ditherflag) as Pix
' pixMedianCutQuant(PIX *, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Simple interface.  See pixMedianCutQuantGeneral() for
''' use of defaulted parameters.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMedianCutQuant/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb color</param>
'''  <param name="ditherflag">[in] - 1 for dither 0 for no dither</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixMedianCutQuant(
				 ByVal pixs as Pix, 
				 ByVal ditherflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMedianCutQuant( pixs.Pointer, ditherflag)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant2.c (308, 1)
' pixMedianCutQuantGeneral(pixs, ditherflag, outdepth, maxcolors, sigbits, maxsub, checkbw) as Pix
' pixMedianCutQuantGeneral(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) %maxcolors must be in the range [2 ... 256].<para/>
''' 
''' (2) Use %outdepth = 0 to have the output depth computed as the
''' minimum required to hold the actual colors found, given
''' the %maxcolors constraint.<para/>
''' 
''' (3) Use %outdepth = 1, 2, 4 or 8 to specify the output depth.
''' In that case, %maxcolors must not exceed 2^(outdepth).<para/>
''' 
''' (4) If there are fewer quantized colors in the image than %maxcolors,
''' the colormap is simply generated from those colors.<para/>
''' 
''' (5) %maxsub is the maximum allowed subsampling to be used in the
''' computation of the color histogram and region of occupied
''' color space.  The subsampling is chosen internally for
''' efficiency, based on the image size, but this parameter
''' limits it.  Use %maxsub = 0 for the internal default, which is the
''' maximum allowed subsampling.  Use %maxsub = 1 to prevent
''' subsampling.  In general use %maxsub greater or equal 1 to specify the
''' maximum subsampling to be allowed, where the actual subsampling
''' will be the minimum of this value and the internally
''' determined default value.<para/>
''' 
''' (6) If the image appears gray because either most of the pixels
''' are gray or most of the pixels are essentially black or white,
''' the image is trivially quantized with a grayscale colormap.  The
''' reason is that median cut divides the color space into rectangular
''' regions, and it does a very poor job if all the pixels are
''' near the diagonal of the color space cube.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMedianCutQuantGeneral/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb color</param>
'''  <param name="ditherflag">[in] - 1 for dither 0 for no dither</param>
'''  <param name="outdepth">[in] - output depth valid: 0, 1, 2, 4, 8</param>
'''  <param name="maxcolors">[in] - between 2 and 256</param>
'''  <param name="sigbits">[in] - valid: 5 or 6 use 0 for default</param>
'''  <param name="maxsub">[in] - max subsampling, integer use 0 for default 1 for no subsampling</param>
'''  <param name="checkbw">[in] - 1 to check if color content is very small, 0 to assume there is sufficient color</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixMedianCutQuantGeneral(
				 ByVal pixs as Pix, 
				 ByVal ditherflag as Integer, 
				 ByVal outdepth as Integer, 
				 ByVal maxcolors as Integer, 
				 ByVal sigbits as Integer, 
				 ByVal maxsub as Integer, 
				 ByVal checkbw as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMedianCutQuantGeneral( pixs.Pointer, ditherflag, outdepth, maxcolors, sigbits, maxsub, checkbw)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant2.c (579, 1)
' pixMedianCutQuantMixed(pixs, ncolor, ngray, darkthresh, lightthresh, diffthresh) as Pix
' pixMedianCutQuantMixed(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) ncolor + ngray must not exceed 255.<para/>
''' 
''' (2) The method makes use of pixMedianCutQuantGeneral() with
''' minimal addition.
''' (a) Preprocess the image, setting all pixels with little color
''' to black, and populating an auxiliary 8 bpp image with the
''' expected colormap values corresponding to the set of
''' quantized gray values.
''' (b) Color quantize the altered input image to n + 1 colors.
''' (c) Augment the colormap with the gray indices, and
''' substitute the gray quantized values from the auxiliary
''' image for those in the color quantized output that had
''' been quantized as black.<para/>
''' 
''' (3) Median cut color quantization is relatively poor for grayscale
''' images with many colors, when compared to octcube quantization.
''' Thus, for images with both gray and color, it is important
''' to quantize the gray pixels by another method.  Here, we
''' are conservative in detecting color, preferring to use
''' a few extra bits to encode colorful pixels that push them
''' to gray.  This is particularly reasonable with this function,
''' because it handles the gray and color pixels separately,
''' using median cut color quantization for the color pixels
''' and equal-bin grayscale quantization for the non-color pixels.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMedianCutQuantMixed/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb color</param>
'''  <param name="ncolor">[in] - maximum number of colors assigned to pixels with significant color</param>
'''  <param name="ngray">[in] - number of gray colors to be used must be greater or equal 2</param>
'''  <param name="darkthresh">[in] - threshold near black if the lightest component is below this, the pixel is not considered to be gray or color uses 0 for default</param>
'''  <param name="lightthresh">[in] - threshold near white if the darkest component is above this, the pixel is not considered to be gray or color use 0 for default</param>
'''  <param name="diffthresh">[in] - thresh for the max difference between component values for differences below this, the pixel is considered to be gray use 0 for default</param>
'''   <returns>pixd 8 bpp cmapped, or NULL on error</returns>
Public Shared Function pixMedianCutQuantMixed(
				 ByVal pixs as Pix, 
				 ByVal ncolor as Integer, 
				 ByVal ngray as Integer, 
				 ByVal darkthresh as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal diffthresh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixMedianCutQuantMixed( pixs.Pointer, ncolor, ngray, darkthresh, lightthresh, diffthresh)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant2.c (754, 1)
' pixFewColorsMedianCutQuantMixed(pixs, ncolor, ngray, maxncolors, darkthresh, lightthresh, diffthresh) as Pix
' pixFewColorsMedianCutQuantMixed(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) This is the "few colors" version of pixMedianCutQuantMixed().
''' It fails (returns NULL) if it finds more than maxncolors, but
''' otherwise it gives the same result.<para/>
''' 
''' (2) Recommended input parameters are:
''' %maxncolors:  20
''' %darkthresh:  20
''' %lightthresh: 244
''' %diffthresh:  15  (any higher can miss colors differing
''' slightly from gray)<para/>
''' 
''' (3) Both ncolor and ngray should be at least equal to maxncolors.
''' If they're not, they are automatically increased, and a
''' warning is given.<para/>
''' 
''' (4) If very little color content is found, the input is
''' converted to gray and quantized in equal intervals.<para/>
''' 
''' (5) This can be useful for quantizing orthographically generated
''' images such as color maps, where there may be more than 256 colors
''' because of aliasing or jpeg artifacts on text or lines, but
''' there are a relatively small number of solid colors.<para/>
''' 
''' (6) Example of usage:
''' // Try to quantize, using default values for mixed med cut
''' Pix pixq = pixFewColorsMedianCutQuantMixed(pixs, 100, 20,
''' 0, 0, 0, 0)
''' if (!pixq)  // too many colors don't quantize
''' pixq = pixClone(pixs)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixFewColorsMedianCutQuantMixed/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ncolor">[in] - number of colors to be assigned to pixels with significant color</param>
'''  <param name="ngray">[in] - number of gray colors to be used must be greater or equal 2</param>
'''  <param name="maxncolors">[in] - maximum number of colors to be returned from pixColorsForQuantization() use 0 for default</param>
'''  <param name="darkthresh">[in] - threshold near black if the lightest component is below this, the pixel is not considered to be gray or color use 0 for default</param>
'''  <param name="lightthresh">[in] - threshold near white if the darkest component is above this, the pixel is not considered to be gray or color use 0 for default</param>
'''  <param name="diffthresh">[in] - thresh for the max difference between component values for differences below this, the pixel is considered to be gray use 0 for default</param>
'''   <returns>pixd 8 bpp, median cut quantized for pixels that are not gray gray pixels are quantized separately over the full gray range null if too many colors or on error</returns>
Public Shared Function pixFewColorsMedianCutQuantMixed(
				 ByVal pixs as Pix, 
				 ByVal ncolor as Integer, 
				 ByVal ngray as Integer, 
				 ByVal maxncolors as Integer, 
				 ByVal darkthresh as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal diffthresh as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFewColorsMedianCutQuantMixed( pixs.Pointer, ncolor, ngray, maxncolors, darkthresh, lightthresh, diffthresh)

	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant2.c (826, 1)
' pixMedianCutHisto(pixs, sigbits, subsample) as Integer()
' pixMedianCutHisto(PIX *, l_int32, l_int32) as l_int32 *
'''  <summary>
''' Notes:<para/>
''' 
''' (1) Array is indexed by (3  sigbits) bits.  The array size
''' is 2^(3  sigbits).<para/>
''' 
''' (2) Indexing into the array from rgb uses red sigbits as
''' most significant and blue as least.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixMedianCutHisto/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb color</param>
'''  <param name="sigbits">[in] - valid: 5 or 6</param>
'''  <param name="subsample">[in] - integer  is greater  0</param>
'''   <returns>histo 1-d array, giving the number of pixels in each quantized region of color space, or NULL on error</returns>
Public Shared Function pixMedianCutHisto(
				 ByVal pixs as Pix, 
				 ByVal sigbits as Integer, 
				 ByVal subsample as Integer) as Integer()

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer() = LeptonicaSharp.Natives.pixMedianCutHisto( pixs.Pointer, sigbits, subsample)


	Return _Result
End Function

End Class

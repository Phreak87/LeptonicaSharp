Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\colorquant2.c (257, 1)
' pixMedianCutQuant()
' pixMedianCutQuant(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Simple interface.  See pixMedianCutQuantGeneral() for<para/>
''' use of defaulted parameters.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' pixMedianCutQuantGeneral()
' pixMedianCutQuantGeneral(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) %maxcolors must be in the range [2 ... 256].<para/>
''' (2) Use %outdepth = 0 to have the output depth computed as the<para/>
''' minimum required to hold the actual colors found, given<para/>
''' the %maxcolors constraint.<para/>
''' (3) Use %outdepth = 1, 2, 4 or 8 to specify the output depth.<para/>
''' In that case, %maxcolors must not exceed 2^(outdepth).<para/>
''' (4) If there are fewer quantized colors in the image than %maxcolors,<para/>
''' the colormap is simply generated from those colors.<para/>
''' (5) %maxsub is the maximum allowed subsampling to be used in the<para/>
''' computation of the color histogram and region of occupied<para/>
''' color space.  The subsampling is chosen internally for<para/>
''' efficiency, based on the image size, but this parameter<para/>
''' limits it.  Use %maxsub = 0 for the internal default, which is the<para/>
''' maximum allowed subsampling.  Use %maxsub = 1 to prevent<para/>
''' subsampling.  In general use %maxsub  is greater = 1 to specify the<para/>
''' maximum subsampling to be allowed, where the actual subsampling<para/>
''' will be the minimum of this value and the internally<para/>
''' determined default value.<para/>
''' (6) If the image appears gray because either most of the pixels<para/>
''' are gray or most of the pixels are essentially black or white,<para/>
''' the image is trivially quantized with a grayscale colormap.  The<para/>
''' reason is that median cut divides the color space into rectangular<para/>
''' regions, and it does a very poor job if all the pixels are<para/>
''' near the diagonal of the color space cube.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
' pixMedianCutQuantMixed()
' pixMedianCutQuantMixed(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) ncolor + ngray must not exceed 255.<para/>
''' (2) The method makes use of pixMedianCutQuantGeneral() with<para/>
''' minimal addition.<para/>
''' (a) Preprocess the image, setting all pixels with little color<para/>
''' to black, and populating an auxiliary 8 bpp image with the<para/>
''' expected colormap values corresponding to the set of<para/>
''' quantized gray values.<para/>
''' (b) Color quantize the altered input image to n + 1 colors.<para/>
''' (c) Augment the colormap with the gray indices, and<para/>
''' substitute the gray quantized values from the auxiliary<para/>
''' image for those in the color quantized output that had<para/>
''' been quantized as black.<para/>
''' (3) Median cut color quantization is relatively poor for grayscale<para/>
''' images with many colors, when compared to octcube quantization.<para/>
''' Thus, for images with both gray and color, it is important<para/>
''' to quantize the gray pixels by another method.  Here, we<para/>
''' are conservative in detecting color, preferring to use<para/>
''' a few extra bits to encode colorful pixels that push them<para/>
''' to gray.  This is particularly reasonable with this function,<para/>
''' because it handles the gray and color pixels separately,<para/>
''' using median cut color quantization for the color pixels<para/>
''' and equal-bin grayscale quantization for the non-color pixels.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb color</param>
'''  <param name="ncolor">[in] - maximum number of colors assigned to pixels with significant color</param>
'''  <param name="ngray">[in] - number of gray colors to be used must be  is greater = 2</param>
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
' pixFewColorsMedianCutQuantMixed()
' pixFewColorsMedianCutQuantMixed(PIX *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is the "few colors" version of pixMedianCutQuantMixed().<para/>
''' It fails (returns NULL) if it finds more than maxncolors, but<para/>
''' otherwise it gives the same result.<para/>
''' (2) Recommended input parameters are:<para/>
''' %maxncolors:  20<para/>
''' %darkthresh:  20<para/>
''' %lightthresh: 244<para/>
''' %diffthresh:  15  (any higher can miss colors differing<para/>
''' slightly from gray)<para/>
''' (3) Both ncolor and ngray should be at least equal to maxncolors.<para/>
''' If they're not, they are automatically increased, and a<para/>
''' warning is given.<para/>
''' (4) If very little color content is found, the input is<para/>
''' converted to gray and quantized in equal intervals.<para/>
''' (5) This can be useful for quantizing orthographically generated<para/>
''' images such as color maps, where there may be more than 256 colors<para/>
''' because of aliasing or jpeg artifacts on text or lines, but<para/>
''' there are a relatively small number of solid colors.<para/>
''' (6) Example of usage:<para/>
''' // Try to quantize, using default values for mixed med cut<para/>
''' Pix pixq = pixFewColorsMedianCutQuantMixed(pixs, 100, 20,<para/>
''' 0, 0, 0, 0)<para/>
''' if (!pixq)  // too many colors don't quantize<para/>
''' pixq = pixClone(pixs)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="ncolor">[in] - number of colors to be assigned to pixels with significant color</param>
'''  <param name="ngray">[in] - number of gray colors to be used must be  is greater = 2</param>
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
' pixMedianCutHisto()
' pixMedianCutHisto(PIX *, l_int32, l_int32) as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Array is indexed by (3  sigbits) bits.  The array size<para/>
''' is 2^(3  sigbits).<para/>
''' (2) Indexing into the array from rgb uses red sigbits as<para/>
''' most significant and blue as least.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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

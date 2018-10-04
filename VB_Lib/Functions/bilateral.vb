Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\bilateral.c (150, 1)
' pixBilateral(pixs, spatial_stdev, range_stdev, ncomps, reduction) as Pix
' pixBilateral(PIX *, l_float32, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This performs a relatively fast, separable bilateral<para/>
''' filtering operation.  The time is proportional to ncomps<para/>
''' and varies inversely approximately as the cube of the<para/>
''' reduction factor.  See bilateral.h for algorithm details.<para/>
''' (2) We impose minimum values for range_stdev and ncomps to<para/>
''' avoid nasty artifacts when either are too small.  We also<para/>
''' impose a constraint on their product:<para/>
''' ncomps  range_stdev  is greater = 100.<para/>
''' So for values of range_stdev  is greater = 25, ncomps can be as small as 4.<para/>
''' Here is a qualitative, intuitive explanation for this constraint.<para/>
''' Call the difference in k values between the J(k) == 'delta', where<para/>
''' 'delta' ~ 200 / ncomps<para/>
''' Then this constraint is roughly equivalent to the condition:<para/>
''' 'delta'  is lower  2  range_stdev<para/>
''' Note that at an intensity difference of (2  range_stdev), the<para/>
''' range part of the kernel reduces the effect by the factor 0.14.<para/>
''' This constraint requires that we have a sufficient number of<para/>
''' PCBs (i.e, a small enough 'delta'), so that for any value of<para/>
''' image intensity I, there exists a k (and a PCB, J(k), such that<para/>
''' |I - k|  is lower  range_stdev<para/>
''' Any fewer PCBs and we don't have enough to support this condition.<para/>
''' (3) The upper limit of 30 on ncomps is imposed because the<para/>
''' gain in accuracy is not worth the extra computation.<para/>
''' (4) The size of the gaussian kernel is twice the spatial_stdev<para/>
''' on each side of the origin.  The minimum value of<para/>
''' spatial_stdev, 0.5, is required to have a finite sized<para/>
''' spatial kernel.  In practice, a much larger value is used.<para/>
''' (5) Computation of the intermediate images goes inversely<para/>
''' as the cube of the reduction factor.  If you can use a<para/>
''' reduction of 2 or 4, it is well-advised.<para/>
''' (6) The range kernel is defined over the absolute value of pixel<para/>
''' grayscale differences, and hence must have size 256 x 1.<para/>
''' Values in the array represent the multiplying weight<para/>
''' depending on the absolute gray value difference between<para/>
''' the source pixel and the neighboring pixel, and should<para/>
''' be monotonically decreasing.<para/>
''' (7) Interesting observation.  Run this on prog/fish24.jpg, with<para/>
''' range_stdev = 60, ncomps = 6, and spatial_dev = {10, 30, 50}.<para/>
''' As spatial_dev gets larger, we get the counter-intuitive<para/>
''' result that the body of the red fish becomes less blurry.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb, no colormap</param>
'''  <param name="spatial_stdev">[in] - of gaussian kernel in pixels,  is greater  0.5</param>
'''  <param name="range_stdev">[in] - of gaussian range kernel  is greater  5.0 typ. 50.0</param>
'''  <param name="ncomps">[in] - number of intermediate sums J(k,x) in [4 ... 30]</param>
'''  <param name="reduction">[in] - 1, 2 or 4</param>
'''   <returns>pixd bilateral filtered image, or NULL on error</returns>
Public Shared Function pixBilateral(
				 ByVal pixs as Pix, 
				 ByVal spatial_stdev as Single, 
				 ByVal range_stdev as Single, 
				 ByVal ncomps as Integer, 
				 ByVal reduction as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (spatial_stdev) then Throw New ArgumentNullException  ("spatial_stdev cannot be Nothing")
	If IsNothing (range_stdev) then Throw New ArgumentNullException  ("range_stdev cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("1, 2 or 4")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilateral( pixs.Pointer, spatial_stdev, range_stdev, ncomps, reduction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilateral.c (220, 1)
' pixBilateralGray(pixs, spatial_stdev, range_stdev, ncomps, reduction) as Pix
' pixBilateralGray(PIX *, l_float32, l_float32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixBilateral() for constraints on the input parameters.<para/>
''' (2) See pixBilateral() for algorithm details.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray</param>
'''  <param name="spatial_stdev">[in] - of gaussian kernel in pixels,  is greater  0.5</param>
'''  <param name="range_stdev">[in] - of gaussian range kernel  is greater  5.0 typ. 50.0</param>
'''  <param name="ncomps">[in] - number of intermediate sums J(k,x) in [4 ... 30]</param>
'''  <param name="reduction">[in] - 1, 2 or 4</param>
'''   <returns>pixd 8 bpp bilateral filtered image, or NULL on error</returns>
Public Shared Function pixBilateralGray(
				 ByVal pixs as Pix, 
				 ByVal spatial_stdev as Single, 
				 ByVal range_stdev as Single, 
				 ByVal ncomps as Integer, 
				 ByVal reduction as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (spatial_stdev) then Throw New ArgumentNullException  ("spatial_stdev cannot be Nothing")
	If IsNothing (range_stdev) then Throw New ArgumentNullException  ("range_stdev cannot be Nothing")
	If reduction > 2 and reduction < 16 then Throw New ArgumentException ("1, 2 or 4")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilateralGray( pixs.Pointer, spatial_stdev, range_stdev, ncomps, reduction)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilateral.c (580, 1)
' pixBilateralExact(pixs, spatial_kel, range_kel) as Pix
' pixBilateralExact(PIX *, L_KERNEL *, L_KERNEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The spatial_kel is a conventional smoothing kernel, typically a<para/>
''' 2-d Gaussian kernel or other block kernel.  It can be either<para/>
''' normalized or not, but must be everywhere positive.<para/>
''' (2) The range_kel is defined over the absolute value of pixel<para/>
''' grayscale differences, and hence must have size 256 x 1.<para/>
''' Values in the array represent the multiplying weight for each<para/>
''' gray value difference between the target pixel and center of the<para/>
''' kernel, and should be monotonically decreasing.<para/>
''' (3) If range_kel == NULL, a constant weight is applied regardless<para/>
''' of the range value difference.  This degenerates to a regular<para/>
''' pixConvolve() with a normalized kernel.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb</param>
'''  <param name="spatial_kel">[in] - gaussian kernel</param>
'''  <param name="range_kel">[in][optional] - 256 x 1, monotonically decreasing</param>
'''   <returns>pixd 8 bpp bilateral filtered image</returns>
Public Shared Function pixBilateralExact(
				 ByVal pixs as Pix, 
				 ByVal spatial_kel as L_Kernel, 
				 ByVal range_kel as L_Kernel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (spatial_kel) then Throw New ArgumentNullException  ("spatial_kel cannot be Nothing")

	Dim range_kelPTR As IntPtr = IntPtr.Zero : If Not IsNothing(range_kel) Then range_kelPTR = range_kel.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilateralExact( pixs.Pointer, spatial_kel.Pointer, range_kelPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilateral.c (634, 1)
' pixBilateralGrayExact(pixs, spatial_kel, range_kel) as Pix
' pixBilateralGrayExact(PIX *, L_KERNEL *, L_KERNEL *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixBilateralExact().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray</param>
'''  <param name="spatial_kel">[in] - gaussian kernel</param>
'''  <param name="range_kel">[in][optional] - 256 x 1, monotonically decreasing</param>
'''   <returns>pixd 8 bpp bilateral filtered image</returns>
Public Shared Function pixBilateralGrayExact(
				 ByVal pixs as Pix, 
				 ByVal spatial_kel as L_Kernel, 
				 ByVal range_kel as L_Kernel) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (spatial_kel) then Throw New ArgumentNullException  ("spatial_kel cannot be Nothing")

	Dim range_kelPTR As IntPtr = IntPtr.Zero : If Not IsNothing(range_kel) Then range_kelPTR = range_kel.Pointer

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBilateralGrayExact( pixs.Pointer, spatial_kel.Pointer, range_kelPTR)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilateral.c (735, 1)
' pixBlockBilateralExact(pixs, spatial_stdev, range_stdev) as Pix
' pixBlockBilateralExact(PIX *, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See pixBilateralExact().  This provides an interface using<para/>
''' the standard deviations of the spatial and range filters.<para/>
''' (2) The convolution window halfwidth is 2  spatial_stdev,<para/>
''' and the square filter size is 4  spatial_stdev + 1.<para/>
''' The kernel captures 95% of total energy.  This is compensated<para/>
''' by normalization.<para/>
''' (3) The range_stdev is analogous to spatial_halfwidth in the<para/>
''' grayscale domain [0...255], and determines how much damping of the<para/>
''' smoothing operation is applied across edges.  The larger this<para/>
''' value is, the smaller the damping.  The smaller the value, the<para/>
''' more edge details are preserved.  These approximations are useful<para/>
''' for deciding the appropriate cutoff.<para/>
''' kernel[1  stdev] ~= 0.6 kernel[0]<para/>
''' kernel[2  stdev] ~= 0.14  kernel[0]<para/>
''' kernel[3  stdev] ~= 0.01  kernel[0]<para/>
''' If range_stdev is infinite there is no damping, and this<para/>
''' becomes a conventional gaussian smoothing.<para/>
''' This value does not affect the run time.<para/>
''' (4) If range_stdev is negative or zero, the range kernel is<para/>
''' ignored and this degenerates to a straight gaussian convolution.<para/>
''' (5) This is very slow for large spatial filters.  The time<para/>
''' on a 3GHz pentium is roughly<para/>
''' T = 1.2  10^-8  (A  sh^2)  sec<para/>
''' where A = # of pixels, sh = spatial halfwidth of filter.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pixs">[in] - 8 bpp gray or 32 bpp rgb</param>
'''  <param name="spatial_stdev">[in] - is greater  0.0</param>
'''  <param name="range_stdev">[in] - is greater  0.0</param>
'''   <returns>pixd 8 bpp or 32 bpp bilateral filtered image</returns>
Public Shared Function pixBlockBilateralExact(
				 ByVal pixs as Pix, 
				 ByVal spatial_stdev as Single, 
				 ByVal range_stdev as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (spatial_stdev) then Throw New ArgumentNullException  ("spatial_stdev cannot be Nothing")
	If IsNothing (range_stdev) then Throw New ArgumentNullException  ("range_stdev cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixBlockBilateralExact( pixs.Pointer, spatial_stdev, range_stdev)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\bilateral.c (787, 1)
' makeRangeKernel(range_stdev) as L_Kernel
' makeRangeKernel(l_float32) as L_KERNEL *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Creates a one-sided Gaussian kernel with the given<para/>
''' standard deviation.  At grayscale difference of one stdev,<para/>
''' the kernel falls to 0.6, and to 0.01 at three stdev.<para/>
''' (2) A typical input number might be 20.  Then pixels whose<para/>
''' value differs by 60 from the center pixel have their<para/>
''' weight in the convolution reduced by a factor of about 0.01.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="range_stdev">[in] - is greater  0</param>
'''   <returns>kel, or NULL on error</returns>
Public Shared Function makeRangeKernel(
				 ByVal range_stdev as Single) as L_Kernel

	If IsNothing (range_stdev) then Throw New ArgumentNullException  ("range_stdev cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.makeRangeKernel( range_stdev)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new L_Kernel(_Result)
End Function

End Class

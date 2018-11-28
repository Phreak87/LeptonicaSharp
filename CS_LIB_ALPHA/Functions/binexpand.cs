using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class _All {

// binexpand.c (67, 1)
// pixExpandBinaryReplicate(pixs, xfact, yfact) as Pix
// pixExpandBinaryReplicate(PIX *, l_int32, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExpandBinaryReplicate/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="xfact">[in] - integer scale factor for horiz. replicative expansion</param>
///  <param name="yfact">[in] - integer scale factor for vertical replicative expansion</param>
///   <returns>pixd scaled up, or NULL on error</returns>
public static Pix pixExpandBinaryReplicate(
				  Pix pixs, 
				  int xfact, 
				  int yfact){

	IntPtr _Result = Natives.pixExpandBinaryReplicate(pixs.Pointer,   xfact,   yfact);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

// binexpand.c (132, 1)
// pixExpandBinaryPower2(pixs, factor) as Pix
// pixExpandBinaryPower2(PIX *, l_int32) as PIX *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixExpandBinaryPower2/*"/>
///  <param name="pixs">[in] - 1 bpp</param>
///  <param name="factor">[in] - expansion factor: 1, 2, 4, 8, 16</param>
///   <returns>pixd expanded 1 bpp by replication, or NULL on error</returns>
public static Pix pixExpandBinaryPower2(
				  Pix pixs, 
				  int factor){

	IntPtr _Result = Natives.pixExpandBinaryPower2(pixs.Pointer,   factor);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new Pix(_Result);
}

}

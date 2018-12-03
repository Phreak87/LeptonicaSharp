using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// recogdid.c (215, 1)
// recogDecode(recog, pixs, nlevels, ppixdb) as Boxa
// recogDecode(L_RECOG *, PIX *, l_int32, PIX **) as BOXA *
///  <summary>
/// (1) The input pixs has been filtered so that it is likely to be
/// composed of more than one touching character.  Specifically,
/// its height can only slightly exceed that of the tallest
/// unscaled template, the width is somewhat larger than the
/// width of the widest unscaled template, and the w/h aspect ratio
/// is bounded by max_wh_ratio.<para/>
/// 
/// (2) This uses the DID mechanism with labeled templates to
/// segment the input %pixs.  The resulting segmentation is
/// returned.  (It is given by didtoboxa).<para/>
/// 
/// (3) In debug mode, the Viterbi path is rescored based on all
/// the templates.  In non-debug mode, the same procedure is
/// carried out by recogIdentifyPix() on the result of the
/// segmentation.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogDecode/*"/>
///  <param name="recog">[in] - with LUT's pre-computed</param>
///  <param name="pixs">[in] - typically of multiple touching characters, 1 bpp</param>
///  <param name="nlevels">[in] - of templates 2 for now</param>
///  <param name="ppixdb">[out][optional] - debug result can be null</param>
///   <returns>boxa  segmentation of pixs into characters, or NULL on error</returns>
public static Boxa recogDecode(
				 L_Recog recog, 
				 Pix pixs, 
				 int nlevels, 
				out Pix ppixdb){

	IntPtr ppixdbPtr = IntPtr.Zero;

	IntPtr _Result = Natives.recogDecode(recog.Pointer, pixs.Pointer,   nlevels, out ppixdbPtr);
	

	if (ppixdbPtr == IntPtr.Zero) {ppixdb = null;} else { ppixdb = new Pix(ppixdbPtr); };

	if (_Result == IntPtr.Zero) {return null;}

	return  new Boxa(_Result);
}

// recogdid.c (747, 1)
// recogCreateDid(recog, pixs) as int
// recogCreateDid(L_RECOG *, PIX *) as l_ok
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogCreateDid/*"/>
///  <param name="recog">[in] - </param>
///  <param name="pixs">[in] - of 1 bpp image to match</param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogCreateDid(
				 L_Recog recog, 
				 Pix pixs){

	int _Result = Natives.recogCreateDid(recog.Pointer, pixs.Pointer);
	



	return _Result;
}

// recogdid.c (818, 1)
// recogDestroyDid(recog) as int
// recogDestroyDid(L_RECOG *) as l_ok
///  <summary>
/// (1) As the signature indicates, this is owned by the recog, and can
/// only be destroyed using this function.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogDestroyDid/*"/>
///  <param name="recog">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogDestroyDid(
				 L_Recog recog){

	int _Result = Natives.recogDestroyDid(recog.Pointer);
	



	return _Result;
}

// recogdid.c (874, 1)
// recogDidExists(recog) as int
// recogDidExists(L_RECOG *) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogDidExists/*"/>
///  <param name="recog">[in] - </param>
///   <returns>1 if recogtodid exists 0 if not or on error.</returns>
public static int recogDidExists(
				 L_Recog recog){

	int _Result = Natives.recogDidExists(recog.Pointer);
	



	return _Result;
}

// recogdid.c (896, 1)
// recogGetDid(recog) as L_Rdid
// recogGetDid(L_RECOG *) as L_RDID *
///  <summary>
/// (1) This also makes sure the arrays are defined.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogGetDid/*"/>
///  <param name="recog">[in] - </param>
///   <returns>did still owned by the recog, or NULL on error</returns>
public static L_Rdid recogGetDid(
				 L_Recog recog){

	IntPtr _Result = Natives.recogGetDid(recog.Pointer);
	


	if (_Result == IntPtr.Zero) {return null;}

	return  new L_Rdid(_Result);
}

// recogdid.c (1005, 1)
// recogSetChannelParams(recog, nlevels) as int
// recogSetChannelParams(L_RECOG *, l_int32) as l_ok
///  <summary>
/// (1) This converts the independent bit-flip probabilities in the
/// "channel" into log-likelihood coefficients on image sums.
/// These coefficients are only defined for the non-background
/// template levels.  Thus for nlevels = 2 (one fg, one bg),
/// only beta[1] and gamma[1] are used.  For nlevels = 4 (three
/// fg templates), we use beta[1-3] and gamma[1-3].
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/recogSetChannelParams/*"/>
///  <param name="recog">[in] - </param>
///  <param name="nlevels">[in] - </param>
///   <returns>0 if OK, 1 on error</returns>
public static int recogSetChannelParams(
				 L_Recog recog, 
				 int nlevels){

	int _Result = Natives.recogSetChannelParams(recog.Pointer,   nlevels);
	



	return _Result;
}


}
}

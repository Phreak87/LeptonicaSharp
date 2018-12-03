using System;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// convertfiles.c (67, 1)
// convertFilesTo1bpp(dirin, substr, upscaling, thresh, firstpage, npages, dirout, outformat) as int
// convertFilesTo1bpp(const char *, const char *, l_int32, l_int32, l_int32, l_int32, const char *, l_int32) as l_ok
///  <summary>
/// (1) Images are sorted lexicographically, and the names in the
/// output directory are retained except for the extension.
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/convertFilesTo1bpp/*"/>
///  <param name="dirin">[in] - </param>
///  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
///  <param name="upscaling">[in] - 1, 2 or 4 only for input color or grayscale</param>
///  <param name="thresh">[in] - global threshold for binarization use 0 for default</param>
///  <param name="firstpage">[in] - </param>
///  <param name="npages">[in] - use 0 to do all from %firstpage to the end</param>
///  <param name="dirout">[in] - </param>
///  <param name="outformat">[in] - IFF_PNG, IFF_TIFF_G4</param>
///   <returns>0 if OK, 1 on error</returns>
public static int convertFilesTo1bpp(
				 String dirin, 
				 String substr, 
				 int upscaling, 
				 int thresh, 
				 int firstpage, 
				 int npages, 
				 String dirout, 
				 int outformat){

	int _Result = Natives.convertFilesTo1bpp(  dirin,   substr,   upscaling,   thresh,   firstpage,   npages,   dirout,   outformat);
	



	return _Result;
}


}
}

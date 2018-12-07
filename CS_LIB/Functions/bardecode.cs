using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// bardecode.c (96, 1)
// barcodeDispatchDecoder(barstr, format, debugflag) as String
// barcodeDispatchDecoder(char *, l_int32, l_int32) as char *
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/barcodeDispatchDecoder/*"/>
///  <param name="barstr">[in] - string of integers in set {1,2,3,4} of bar widths</param>
///  <param name="format">[in] - L_BF_ANY, L_BF_CODEI2OF5, L_BF_CODE93, ...</param>
///  <param name="debugflag">[in] - use 1 to generate debug output</param>
///   <returns>data string of decoded barcode data, or NULL on error</returns>
public static String barcodeDispatchDecoder(
				 String barstr, 
				 IFF format, 
				 int debugflag){

if (barstr == null) {throw new ArgumentNullException  ("barstr cannot be Nothing");}
	String _Result = Natives.barcodeDispatchDecoder(  barstr,  (int) format,   debugflag);
	
	return _Result;
}

// bardecode.c (173, 1)
// barcodeFormatIsSupported(format) as int
// barcodeFormatIsSupported(l_int32) as l_int32
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/barcodeFormatIsSupported/*"/>
///  <param name="format">[in] - </param>
///   <returns>1 if format is one of those supported 0 otherwise</returns>
public static int barcodeFormatIsSupported(
				 IFF format){

	int _Result = Natives.barcodeFormatIsSupported( (int) format);
	
	return _Result;
}


}
}

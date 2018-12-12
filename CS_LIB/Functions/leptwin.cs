using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp{
public partial class _All {

// leptwin.c (303, 1)
// pixGetWindowsHBITMAP(pix) as IntPtr
// pixGetWindowsHBITMAP(PIX *) as HBITMAP
///  <summary>
/// (1) It's the responsibility of the caller to destroy the
/// returned hBitmap with a call to DeleteObject (or with
/// something that eventually calls DeleteObject).
///  </summary>
///  <remarks>
///  </remarks>
///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixGetWindowsHBITMAP/*"/>
///  <param name="pix">[in] - </param>
///   <returns>Windows hBitmap, or NULL on error</returns>
public static IntPtr pixGetWindowsHBITMAP(
				 Pix pix){

if (pix == null) {throw new ArgumentNullException  ("pix cannot be Nothing");}
	IntPtr _Result = Natives.pixGetWindowsHBITMAP(pix.Pointer);
	
	return _Result;
}


}
}

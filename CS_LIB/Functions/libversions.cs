using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// libversions.c (101, 1)
		// getImagelibVersions() as String
		// getImagelibVersions() as char *
		///  <summary>
		/// getImagelibVersions() Return: string of version numbers e.g., libgif 5.0.3 libjpeg 8b (libjpeg-turbo 1.3.0) libpng 1.4.3 libtiff 3.9.5 zlib 1.2.5 libwebp 0.3.0 libopenjp2 2.1.0 Notes: (1) The caller must free the memory.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getImagelibVersions/*"/>
		///   <returns></returns>
		public static String getImagelibVersions()
		{
			String _Result = Natives.getImagelibVersions();
			return _Result;
		}


	}
}

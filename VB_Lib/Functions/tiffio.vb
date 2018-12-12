Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' tiffio.c (371, 1)
' pixReadTiff(filename, n) as Pix
' pixReadTiff(const char *, l_int32) as PIX *
'''  <summary>
''' (1) This is a version of pixRead(), specialized for tiff
'''files, that allows specification of the page to be returned<para/>
'''
'''(2) No warning messages on failure, because of how multi-page
'''TIFF reading works. You are supposed to keep trying until
'''it stops working.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadTiff/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="n">[in] - page number 0 based</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadTiff(
				ByVal filename as String, 
				ByVal n as Integer) as Pix


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.pixReadTiff(  filename,   n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' tiffio.c (408, 1)
' pixReadStreamTiff(fp, n) as Pix
' pixReadStreamTiff(FILE *, l_int32) as PIX *
'''  <summary>
''' (1) No warning messages on failure, because of how multi-page
'''TIFF reading works. You are supposed to keep trying until
'''it stops working.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadStreamTiff/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="n">[in] - page number: 0 based</param>
'''   <returns>pix, or NULL on error or if there are no more images in the file</returns>
Public Shared Function pixReadStreamTiff(
				ByVal fp as FILE, 
				ByVal n as Integer) as Pix


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadStreamTiff(fp.Pointer,   n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' tiffio.c (654, 1)
' pixWriteTiff(filename, pix, comptype, modestr) as Integer
' pixWriteTiff(const char *, PIX *, l_int32, const char *) as l_ok
'''  <summary>
''' (1) For multipage tiff, write the first pix with mode "w" and
'''all subsequent pix with mode "a".<para/>
'''
'''(2) For multipage tiff, there is considerable overhead in the
'''machinery to append an image and add the directory entry,
'''and the time required for each image increases linearly
'''with the number of images in the file.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteTiff/*"/>
'''  <param name="filename">[in] - to write to</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''  <param name="modestr">[in] - "a" or "w"</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteTiff(
				ByVal filename as String, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF, 
				ByVal modestr as String) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteTiff(  filename, pix.Pointer,   comptype,   modestr)
	
	return _Result
End Function

' tiffio.c (711, 1)
' pixWriteTiffCustom(filename, pix, comptype, modestr, natags, savals, satypes, nasizes) as Integer
' pixWriteTiffCustom(const char *, PIX *, l_int32, const char *, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
'''  <summary>
''' pixWriteTiffCustom()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteTiffCustom/*"/>
'''  <param name="filename">[in] - to write to</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''  <param name="modestr">[in] - "a" or "w"</param>
'''  <param name="natags">[in][optional] - NUMA of custom tiff tags</param>
'''  <param name="savals">[in][optional] - SARRAY of values</param>
'''  <param name="satypes">[in][optional] - SARRAY of types</param>
'''  <param name="nasizes">[in][optional] - NUMA of sizes</param>
'''   <returns>0 if OK, 1 on error Usage: 1 This writes a page image to a tiff file, with optional extra tags defined in tiff.h 2 For multipage tiff, write the first pix with mode "w" and all subsequent pix with mode "a". 3 For the custom tiff tags: a The three arrays {natags, savals, satypes} must all be either NULL or defined and of equal size. b If they are defined, the tags are an array of integers, the vals are an array of values in string format, and the types are an array of types in string format. c All valid tags are definined in tiff.h. d The types allowed are the set of strings: "char" "l_uint8" "l_uint16" "l_uint32" "l_int32" "l_float64" "l_uint16-l_uint16" note the dash use it between the two l_uint16 vals in the val string Of these, "char" and "l_uint16" are the most commonly used. e The last array, nasizes, is also optional.  It is for tags that take an array of bytes for a value, a number of elements in the array, and a type that is either "char" or "l_uint8" probably either will work. Use NULL if there are no such tags. f VERY IMPORTANT: if there are any tags that require the extra size value, stored in nasizes, they must be written first!</returns>
Public Shared Function pixWriteTiffCustom(
				ByVal filename as String, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF, 
				ByVal modestr as String, 
				Optional ByVal natags as Numa = Nothing, 
				Optional ByVal savals as Sarray = Nothing, 
				Optional ByVal satypes as Sarray = Nothing, 
				Optional ByVal nasizes as Numa = Nothing) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")
	Dim natagsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(natags) Then natagsPtr = natags.Pointer
	Dim savalsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(savals) Then savalsPtr = savals.Pointer
	Dim satypesPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(satypes) Then satypesPtr = satypes.Pointer
	Dim nasizesPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nasizes) Then nasizesPtr = nasizes.Pointer

	Dim _Result as Integer = Natives.pixWriteTiffCustom(  filename, pix.Pointer,   comptype,   modestr, natagsPtr, savalsPtr, satypesPtr, nasizesPtr)
	
	return _Result
End Function

' tiffio.c (770, 1)
' pixWriteStreamTiff(fp, pix, comptype) as Integer
' pixWriteStreamTiff(FILE *, PIX *, l_int32) as l_ok
'''  <summary>
''' (1) This writes a single image to a file stream opened for writing.<para/>
'''
'''(2) For images with bpp  is greater  1, this resets the comptype, if
'''necessary, to write uncompressed data.<para/>
'''
'''(3) G3 and G4 are only defined for 1 bpp.<para/>
'''
'''(4) We only allow PACKBITS for bpp = 1, because for bpp  is greater  1
'''it typically expands images that are not synthetically generated.<para/>
'''
'''(5) G4 compression is typically about twice as good as G3.
'''G4 is excellent for binary compression of text/line-art,
'''but terrible for halftones and dithered patterns.  (In
'''fact, G4 on halftones can give a file that is larger
'''than uncompressed!)  If a binary image has dithered
'''regions, it is usually better to compress with png.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamTiff/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamTiff(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteStreamTiff(fp.Pointer, pix.Pointer,   comptype)
	
	return _Result
End Function

' tiffio.c (790, 1)
' pixWriteStreamTiffWA(fp, pix, comptype, modestr) as Integer
' pixWriteStreamTiffWA(FILE *, PIX *, l_int32, const char *) as l_ok
'''  <summary>
''' pixWriteStreamTiffWA()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteStreamTiffWA/*"/>
'''  <param name="fp">[in] - file stream opened for append or write</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''  <param name="modestr">[in] - "w" or "a"</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamTiffWA(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF, 
				ByVal modestr as String) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
		if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
		if IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")
	Dim _Result as Integer = Natives.pixWriteStreamTiffWA(fp.Pointer, pix.Pointer,   comptype,   modestr)
	
	return _Result
End Function

' tiffio.c (1177, 1)
' pixReadFromMultipageTiff(fname, poffset) as Pix
' pixReadFromMultipageTiff(const char *, size_t *) as PIX *
'''  <summary>
''' (1) This allows overhead for traversal of a multipage tiff file
'''to be linear in the number of images.  This will also work
'''with a singlepage tiff file.<para/>
'''
'''(2) No TIFF internal data structures are exposed to the caller
'''(thanks to Jeff Breidenbach).<para/>
'''
'''(3) offset is the byte offset of a particular image in a multipage
'''tiff file. To get the first image in the file, input the
'''special offset value of 0.<para/>
'''
'''(4) The offset is updated to point to the next image, for a
'''subsequent call.<para/>
'''
'''(5) On the last image, the offset returned is 0.  Exit the loop
'''when the returned offset is 0.<para/>
'''
'''(6) For reading a multipage tiff from a memory buffer, see
'''pixReadMemFromMultipageTiff()<para/>
'''
'''(7) Example usage for reading all the images in the tif file:
'''size_t offset = 0
'''do {
'''Pix pix = pixReadFromMultipageTiff(filename, [and]offset)
'''// do something with pix
'''} while (offset != 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadFromMultipageTiff/*"/>
'''  <param name="fname">[in] - filename</param>
'''  <param name="poffset">[in,out] - set offset to 0 for first image</param>
'''   <returns>pix, or NULL on error or if previous call returned the last image</returns>
Public Shared Function pixReadFromMultipageTiff(
				ByVal fname as String, 
				ByRef poffset as Byte()) as Pix


if IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
If My.Computer.Filesystem.FileExists (fname) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
		Dim poffsetPtr as IntPtr = 	Marshal.AllocHGlobal(poffset.Length)
		Marshal.Copy(poffset, 0, poffsetPtr, poffset.Length)

	Dim _Result as IntPtr = Natives.pixReadFromMultipageTiff(  fname,   poffsetPtr)
	
	ReDim poffset(IIf(1 > 0, 1, 1) - 1)
	If poffsetPtr <> IntPtr.Zero Then 
	  Marshal.Copy(poffsetPtr, poffset, 0, poffset.count)
	End If
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' tiffio.c (1226, 1)
' pixaReadMultipageTiff(filename) as Pixa
' pixaReadMultipageTiff(const char *) as PIXA *
'''  <summary>
''' pixaReadMultipageTiff()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadMultipageTiff/*"/>
'''  <param name="filename">[in] - input tiff file</param>
'''   <returns>pixa of page images, or NULL on error</returns>
Public Shared Function pixaReadMultipageTiff(
				ByVal filename as String) as Pixa


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as IntPtr = Natives.pixaReadMultipageTiff(  filename)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' tiffio.c (1286, 1)
' pixaWriteMultipageTiff(fname, pixa) as Integer
' pixaWriteMultipageTiff(const char *, PIXA *) as l_ok
'''  <summary>
''' (1) The tiff directory overhead is O(n^2).  I have not been
'''able to reduce it to O(n).  The overhead for n = 2000 is
'''about 1 second.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteMultipageTiff/*"/>
'''  <param name="fname">[in] - input tiff file</param>
'''  <param name="pixa">[in] - any depth colormap will be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteMultipageTiff(
				ByVal fname as String, 
				ByVal pixa as Pixa) as Integer


if IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
		if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim _Result as Integer = Natives.pixaWriteMultipageTiff(  fname, pixa.Pointer)
	
	return _Result
End Function

' tiffio.c (1347, 1)
' writeMultipageTiff(dirin, substr, fileout) as Integer
' writeMultipageTiff(const char *, const char *, const char *) as l_ok
'''  <summary>
''' (1) This writes a set of image files in a directory out
'''as a multipage tiff file.  The images can be in any
'''initial file format.<para/>
'''
'''(2) Images with a colormap have the colormap removed before
'''re-encoding as tiff.<para/>
'''
'''(3) All images are encoded losslessly.  Those with 1 bpp are
'''encoded 'g4'.  The rest are encoded as 'zip' (flate encoding).
'''Because it is lossless, this is an expensive method for
'''saving most rgb images.<para/>
'''
'''(4) The tiff directory overhead is quadratic in the number of
'''images.  To avoid this for very large numbers of images to be
'''written, apply the method used in pixaWriteMultipageTiff().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeMultipageTiff/*"/>
'''  <param name="dirin">[in] - input directory</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="fileout">[in] - output multipage tiff file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function writeMultipageTiff(
				ByVal dirin as String, 
				ByVal substr as String, 
				ByVal fileout as String) as Integer


if IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.writeMultipageTiff(  dirin,   substr,   fileout)
	
	return _Result
End Function

' tiffio.c (1383, 1)
' writeMultipageTiffSA(sa, fileout) as Integer
' writeMultipageTiffSA(SARRAY *, const char *) as l_ok
'''  <summary>
''' (1) See writeMultipageTiff()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/writeMultipageTiffSA/*"/>
'''  <param name="sa">[in] - string array of full path names</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function writeMultipageTiffSA(
				ByVal sa as Sarray, 
				ByVal fileout as String) as Integer


if IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
		if IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")
	Dim _Result as Integer = Natives.writeMultipageTiffSA(sa.Pointer,   fileout)
	
	return _Result
End Function

' tiffio.c (1443, 1)
' fprintTiffInfo(fpout, tiffile) as Integer
' fprintTiffInfo(FILE *, const char *) as l_ok
'''  <summary>
''' fprintTiffInfo()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/fprintTiffInfo/*"/>
'''  <param name="fpout">[in] - stream for output of tag data</param>
'''  <param name="tiffile">[in] - input</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fprintTiffInfo(
				ByVal fpout as FILE, 
				ByVal tiffile as String) as Integer


if IsNothing (fpout) then Throw New ArgumentNullException  ("fpout cannot be Nothing")
		if IsNothing (tiffile) then Throw New ArgumentNullException  ("tiffile cannot be Nothing")
	Dim _Result as Integer = Natives.fprintTiffInfo(fpout.Pointer,   tiffile)
	
	return _Result
End Function

' tiffio.c (1476, 1)
' tiffGetCount(fp, pn) as Integer
' tiffGetCount(FILE *, l_int32 *) as l_ok
'''  <summary>
''' tiffGetCount()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/tiffGetCount/*"/>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pn">[out] - number of images</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function tiffGetCount(
				ByVal fp as FILE, 
				<Out()>  ByRef pn as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.tiffGetCount(fp.Pointer,   pn)
	
	return _Result
End Function

' tiffio.c (1524, 1)
' getTiffResolution(fp, pxres, pyres) as Integer
' getTiffResolution(FILE *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) If neither resolution field is set, this is not an error
'''the returned resolution values are 0 (designating 'unknown').
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/getTiffResolution/*"/>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pxres">[out] - resolution in ppi</param>
'''  <param name="pyres">[out] - resolution in ppi</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function getTiffResolution(
				ByVal fp as FILE, 
				<Out()>  ByRef pxres as Integer, 
				<Out()>  ByRef pyres as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.getTiffResolution(fp.Pointer,   pxres,   pyres)
	
	return _Result
End Function

' tiffio.c (1621, 1)
' readHeaderTiff(filename, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as Integer
' readHeaderTiff(const char *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
'''
'''(2) If %n is equal to or greater than the number of images, returns 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderTiff/*"/>
'''  <param name="filename">[in] - </param>
'''  <param name="n">[in] - page image number: 0-based</param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
'''  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
'''  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
'''  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
'''  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderTiff(
				ByVal filename as String, 
				ByVal n as Integer, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0, 
				<Out()> Optional  ByRef pres as Integer = 0, 
				<Out()> Optional  ByRef pcmap as Integer = 0, 
				<Out()> Optional  ByRef pformat as Integer = 0) as Integer


if IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
If My.Computer.Filesystem.FileExists (filename) = false then 
	   Throw New ArgumentException ("File is missing")
	End If
	Dim _Result as Integer = Natives.readHeaderTiff(  filename,   n,   pw,   ph,   pbps,   pspp,   pres,   pcmap,   pformat)
	
	return _Result
End Function

' tiffio.c (1677, 1)
' freadHeaderTiff(fp, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as Integer
' freadHeaderTiff(FILE *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
'''
'''(2) If %n is equal to or greater than the number of images, returns 1.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/freadHeaderTiff/*"/>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="n">[in] - page image number: 0-based</param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
'''  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
'''  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
'''  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
'''  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function freadHeaderTiff(
				ByVal fp as FILE, 
				ByVal n as Integer, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0, 
				<Out()> Optional  ByRef pres as Integer = 0, 
				<Out()> Optional  ByRef pcmap as Integer = 0, 
				<Out()> Optional  ByRef pformat as Integer = 0) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.freadHeaderTiff(fp.Pointer,   n,   pw,   ph,   pbps,   pspp,   pres,   pcmap,   pformat)
	
	return _Result
End Function

' tiffio.c (1748, 1)
' readHeaderMemTiff(cdata, size, n, pw, ph, pbps, pspp, pres, pcmap, pformat) as Integer
' readHeaderMemTiff(const l_uint8 *, size_t, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' (1) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/readHeaderMemTiff/*"/>
'''  <param name="cdata">[in] - const tiff-encoded</param>
'''  <param name="size">[in] - size of data</param>
'''  <param name="n">[in] - page image number: 0-based</param>
'''  <param name="pw">[out][optional] - width</param>
'''  <param name="ph">[out][optional] - height</param>
'''  <param name="pbps">[out][optional] - bits per sample -- 1, 2, 4 or 8</param>
'''  <param name="pspp">[out][optional] - samples per pixel -- 1 or 3</param>
'''  <param name="pres">[out][optional] - resolution in x dir NULL to ignore</param>
'''  <param name="pcmap">[out][optional] - colormap exists input NULL to ignore</param>
'''  <param name="pformat">[out][optional] - tiff format input NULL to ignore</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function readHeaderMemTiff(
				ByVal cdata as Byte(), 
				ByVal size as UInteger, 
				ByVal n as Integer, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pbps as Integer = 0, 
				<Out()> Optional  ByRef pspp as Integer = 0, 
				<Out()> Optional  ByRef pres as Integer = 0, 
				<Out()> Optional  ByRef pcmap as Integer = 0, 
				<Out()> Optional  ByRef pformat as Integer = 0) as Integer


if IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")
	Dim _Result as Integer = Natives.readHeaderMemTiff(  cdata,   size,   n,   pw,   ph,   pbps,   pspp,   pres,   pcmap,   pformat)
	
	return _Result
End Function

' tiffio.c (1883, 1)
' findTiffCompression(fp, pcomptype) as Integer
' findTiffCompression(FILE *, l_int32 *) as l_ok
'''  <summary>
''' (1) The returned compression type is that defined in
'''the enum in imageio.h.  It is not the tiff flag value.<para/>
'''
'''(2) The compression type is initialized to IFF_UNKNOWN.
'''If it is not one of the specified types, the returned
'''type is IFF_TIFF, which indicates no compression.<para/>
'''
'''(3) When this function is called, the stream must be at BOF.
'''If the opened stream is to be used again to read the
'''file, it must be rewound to BOF after calling this function.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/findTiffCompression/*"/>
'''  <param name="fp">[in] - file stream must be rewound to BOF</param>
'''  <param name="pcomptype">[out] - compression type</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function findTiffCompression(
				ByVal fp as FILE, 
				<Out()>  ByRef pcomptype as Integer) as Integer


if IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	Dim _Result as Integer = Natives.findTiffCompression(fp.Pointer,   pcomptype)
	
	return _Result
End Function

' tiffio.c (1968, 1)
' extractG4DataFromFile(filein, pdata, pnbytes, pw, ph, pminisblack) as Integer
' extractG4DataFromFile(const char *, l_uint8 **, size_t *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' extractG4DataFromFile()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/extractG4DataFromFile/*"/>
'''  <param name="filein">[in] - </param>
'''  <param name="pdata">[out] - binary data of ccitt g4 encoded stream</param>
'''  <param name="pnbytes">[out] - size of binary data</param>
'''  <param name="pw">[out][optional] - image width</param>
'''  <param name="ph">[out][optional] - image height</param>
'''  <param name="pminisblack">[out][optional] - boolean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function extractG4DataFromFile(
				ByVal filein as String, 
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef pnbytes as UInteger, 
				<Out()> Optional  ByRef pw as Integer = 0, 
				<Out()> Optional  ByRef ph as Integer = 0, 
				<Out()> Optional  ByRef pminisblack as Integer = 0) as Integer


if IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.extractG4DataFromFile(  filein,   pdataPtr,   pnbytes,   pw,   ph,   pminisblack)
	
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' tiffio.c (2445, 1)
' pixReadMemTiff(cdata, size, n) as Pix
' pixReadMemTiff(const l_uint8 *, size_t, l_int32) as PIX *
'''  <summary>
''' (1) This is a version of pixReadTiff(), where the data is read
'''from a memory buffer and uncompressed.<para/>
'''
'''(2) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.<para/>
'''
'''(3) No warning messages on failure, because of how multi-page
'''TIFF reading works. You are supposed to keep trying until
'''it stops working.<para/>
'''
'''(4) Tiff directory overhead is linear in the input page number.
'''If reading many images, use pixReadMemFromMultipageTiff().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemTiff/*"/>
'''  <param name="cdata">[in] - const tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''  <param name="n">[in] - page image number: 0-based</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemTiff(
				ByVal cdata as Byte(), 
				ByVal size as UInteger, 
				ByVal n as Integer) as Pix


if IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixReadMemTiff(  cdata,   size,   n)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' tiffio.c (2510, 1)
' pixReadMemFromMultipageTiff(cdata, size, poffset) as Pix
' pixReadMemFromMultipageTiff(const l_uint8 *, size_t, size_t *) as PIX *
'''  <summary>
''' (1) This is a read-from-memory version of pixReadFromMultipageTiff().
'''See that function for usage.<para/>
'''
'''(2) If reading sequentially from the tiff data, this is more
'''efficient than pixReadMemTiff(), which has an overhead
'''proportional to the image index n.<para/>
'''
'''(3) Example usage for reading all the images:
'''size_t offset = 0
'''do {
'''Pix pix = pixReadMemFromMultipageTiff(data, size, [and]offset)
'''// do something with pix
'''} while (offset != 0)
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixReadMemFromMultipageTiff/*"/>
'''  <param name="cdata">[in] - const tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''  <param name="poffset">[in,out] - set offset to 0 for first image</param>
'''   <returns>pix, or NULL on error or if previous call returned the last image</returns>
Public Shared Function pixReadMemFromMultipageTiff(
				ByVal cdata as Byte(), 
				ByVal size as UInteger, 
				ByRef poffset as Byte()) as Pix


if IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")
		Dim poffsetPtr as IntPtr = 	Marshal.AllocHGlobal(poffset.Length)
		Marshal.Copy(poffset, 0, poffsetPtr, poffset.Length)

	Dim _Result as IntPtr = Natives.pixReadMemFromMultipageTiff(  cdata,   size,   poffsetPtr)
	
	ReDim poffset(IIf(size > 0, size, 1) - 1)
	If poffsetPtr <> IntPtr.Zero Then 
	  Marshal.Copy(poffsetPtr, poffset, 0, poffset.count)
	End If
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' tiffio.c (2566, 1)
' pixaReadMemMultipageTiff(data, size) as Pixa
' pixaReadMemMultipageTiff(const l_uint8 *, size_t) as PIXA *
'''  <summary>
''' (1) This is an O(n) read-from-memory version of pixaReadMultipageTiff().
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaReadMemMultipageTiff/*"/>
'''  <param name="data">[in] - const multiple pages tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaReadMemMultipageTiff(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Pixa


if IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")
	Dim _Result as IntPtr = Natives.pixaReadMemMultipageTiff(  data,   size)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pixa(_Result)
End Function

' tiffio.c (2606, 1)
' pixaWriteMemMultipageTiff(pdata, psize, pixa) as Integer
' pixaWriteMemMultipageTiff(l_uint8 **, size_t *, PIXA *) as l_ok
'''  <summary>
''' (1) fopenTiffMemstream() does not work in append mode, so we
'''must work-around with a temporary file.<para/>
'''
'''(2) Getting a file stream from
'''open_memstream((char )pdata, psize)
'''does not work with the tiff directory.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixaWriteMemMultipageTiff/*"/>
'''  <param name="pdata">[out] - const tiff-encoded</param>
'''  <param name="psize">[out] - size of data</param>
'''  <param name="pixa">[in] - any depth colormap will be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteMemMultipageTiff(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pixa as Pixa) as Integer


if IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixaWriteMemMultipageTiff(  pdataPtr,   psize, pixa.Pointer)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' tiffio.c (2672, 1)
' pixWriteMemTiff(pdata, psize, pix, comptype) as Integer
' pixWriteMemTiff(l_uint8 **, size_t *, PIX *, l_int32) as l_ok
'''  <summary>
''' pixWriteMemTiff()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemTiff/*"/>
'''  <param name="pdata">[out] - data of tiff compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''   <returns>0 if OK, 1 on error Usage: 1) See pixWriteTiff(.  This version writes to memory instead of to a file.</returns>
Public Shared Function pixWriteMemTiff(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.pixWriteMemTiff(  pdataPtr,   psize, pix.Pointer,   comptype)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

' tiffio.c (2703, 1)
' pixWriteMemTiffCustom(pdata, psize, pix, comptype, natags, savals, satypes, nasizes) as Integer
' pixWriteMemTiffCustom(l_uint8 **, size_t *, PIX *, l_int32, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
'''  <summary>
''' pixWriteMemTiffCustom()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixWriteMemTiffCustom/*"/>
'''  <param name="pdata">[out] - data of tiff compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''  <param name="natags">[in][optional] - NUMA of custom tiff tags</param>
'''  <param name="savals">[in][optional] - SARRAY of values</param>
'''  <param name="satypes">[in][optional] - SARRAY of types</param>
'''  <param name="nasizes">[in][optional] - NUMA of sizes</param>
'''   <returns>0 if OK, 1 on error Usage: 1) See pixWriteTiffCustom(.  This version writes to memory instead of to a file. 2) Use TIFFClose() TIFFCleanup( doesn't free internal memstream.</returns>
Public Shared Function pixWriteMemTiffCustom(
				<Out()>  ByRef pdata as Byte(), 
				<Out()>  ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF, 
				Optional ByVal natags as Numa = Nothing, 
				Optional ByVal savals as Sarray = Nothing, 
				Optional ByVal satypes as Sarray = Nothing, 
				Optional ByVal nasizes as Numa = Nothing) as Integer


if IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	Dim pdataPtr as IntPtr = IntPtr.Zero
	Dim natagsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(natags) Then natagsPtr = natags.Pointer
	Dim savalsPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(savals) Then savalsPtr = savals.Pointer
	Dim satypesPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(satypes) Then satypesPtr = satypes.Pointer
	Dim nasizesPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(nasizes) Then nasizesPtr = nasizes.Pointer

	Dim _Result as Integer = Natives.pixWriteMemTiffCustom(  pdataPtr,   psize, pix.Pointer,   comptype, natagsPtr, savalsPtr, satypesPtr, nasizesPtr)
	
	ReDim pdata(IIf(psize > 0, psize, 1) - 1)
	If pdataPtr <> IntPtr.Zero Then 
	  Marshal.Copy(pdataPtr, pdata, 0, pdata.count)
	End If
	return _Result
End Function

End Class



Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\tiffio.c (371, 1)
' pixReadTiff()
' pixReadTiff(const char *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a version of pixRead(), specialized for tiff<para/>
''' files, that allows specification of the page to be returned<para/>
''' (2) No warning messages on failure, because of how multi-page<para/>
''' TIFF reading works. You are supposed to keep trying until<para/>
''' it stops working.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - </param>
'''  <param name="n">[in] - page number 0 based</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadTiff(
				ByVal filename as String, 
				ByVal n as Integer) as Pix

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadTiff( filename, n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\tiffio.c (408, 1)
' pixReadStreamTiff()
' pixReadStreamTiff(FILE *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) No warning messages on failure, because of how multi-page<para/>
''' TIFF reading works. You are supposed to keep trying until<para/>
''' it stops working.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="n">[in] - page number: 0 based</param>
'''   <returns>pix, or NULL on error or if there are no more images in the file</returns>
Public Shared Function pixReadStreamTiff(
				ByVal fp as FILE, 
				ByVal n as Integer) as Pix

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadStreamTiff( fp.Pointer, n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\tiffio.c (654, 1)
' pixWriteTiff()
' pixWriteTiff(const char *, PIX *, l_int32, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) For multipage tiff, write the first pix with mode "w" and<para/>
''' all subsequent pix with mode "a".<para/>
''' (2) For multipage tiff, there is considerable overhead in the<para/>
''' machinery to append an image and add the directory entry,<para/>
''' and the time required for each image increases linearly<para/>
''' with the number of images in the file.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteTiff( filename, pix.Pointer, comptype, modestr)

	Return _Result
End Function

' SRC\tiffio.c (711, 1)
' pixWriteTiffCustom()
' pixWriteTiffCustom(const char *, PIX *, l_int32, const char *, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
'''  <remarks>
'''  </remarks>
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
				ByVal natags as Numa, 
				ByVal savals as Sarray, 
				ByVal satypes as Sarray, 
				ByVal nasizes as Numa) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")

	Dim natagsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(natags) Then natagsPTR = natags.Pointer
	Dim savalsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(savals) Then savalsPTR = savals.Pointer
	Dim satypesPTR As IntPtr = IntPtr.Zero : If Not IsNothing(satypes) Then satypesPTR = satypes.Pointer
	Dim nasizesPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nasizes) Then nasizesPTR = nasizes.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteTiffCustom( filename, pix.Pointer, comptype, modestr, natagsPTR, savalsPTR, satypesPTR, nasizesPTR)

	Return _Result
End Function

' SRC\tiffio.c (770, 1)
' pixWriteStreamTiff()
' pixWriteStreamTiff(FILE *, PIX *, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes a single image to a file stream opened for writing.<para/>
''' (2) For images with bpp  is greater  1, this resets the comptype, if<para/>
''' necessary, to write uncompressed data.<para/>
''' (3) G3 and G4 are only defined for 1 bpp.<para/>
''' (4) We only allow PACKBITS for bpp = 1, because for bpp  is greater  1<para/>
''' it typically expands images that are not synthetically generated.<para/>
''' (5) G4 compression is typically about twice as good as G3.<para/>
''' G4 is excellent for binary compression of text/line-art,<para/>
''' but terrible for halftones and dithered patterns.  (In<para/>
''' fact, G4 on halftones can give a file that is larger<para/>
''' than uncompressed!)  If a binary image has dithered<para/>
''' regions, it is usually better to compress with png.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixWriteStreamTiff(
				ByVal fp as FILE, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamTiff( fp.Pointer, pix.Pointer, comptype)

	Return _Result
End Function

' SRC\tiffio.c (790, 1)
' pixWriteStreamTiffWA()
' pixWriteStreamTiffWA(FILE *, PIX *, l_int32, const char *) as l_ok
'''  <remarks>
'''  </remarks>
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

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")
	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")
	If IsNothing (modestr) then Throw New ArgumentNullException  ("modestr cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteStreamTiffWA( fp.Pointer, pix.Pointer, comptype, modestr)

	Return _Result
End Function

' SRC\tiffio.c (1177, 1)
' pixReadFromMultipageTiff()
' pixReadFromMultipageTiff(const char *, size_t *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This allows overhead for traversal of a multipage tiff file<para/>
''' to be linear in the number of images.  This will also work<para/>
''' with a singlepage tiff file.<para/>
''' (2) No TIFF internal data structures are exposed to the caller<para/>
''' (thanks to Jeff Breidenbach).<para/>
''' (3) offset is the byte offset of a particular image in a multipage<para/>
''' tiff file. To get the first image in the file, input the<para/>
''' special offset value of 0.<para/>
''' (4) The offset is updated to point to the next image, for a<para/>
''' subsequent call.<para/>
''' (5) On the last image, the offset returned is 0.  Exit the loop<para/>
''' when the returned offset is 0.<para/>
''' (6) For reading a multipage tiff from a memory buffer, see<para/>
''' pixReadMemFromMultipageTiff()<para/>
''' (7) Example usage for reading all the images in the tif file:<para/>
''' size_t offset = 0<para/>
''' do {<para/>
''' Pix pix = pixReadFromMultipageTiff(filename,  and offset)<para/>
''' // do something with pix<para/>
''' } while (offset != 0)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - filename</param>
'''  <param name="poffset">[in,out] - set offset to 0 for first image</param>
'''   <returns>pix, or NULL on error or if previous call returned the last image</returns>
Public Shared Function pixReadFromMultipageTiff(
				ByVal fname as String, 
				ByRef poffset as Byte()) as Pix

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")

	Dim poffsetPTR As IntPtr = Marshal.AllocHGlobal(poffset.Count) : Marshal.Copy(poffset, 0, poffsetPTR, poffset.Length)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadFromMultipageTiff( fname, poffsetPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	ReDim poffset(IIf(1 > 0, 1, 1) - 1) : If poffsetPTR <> IntPtr.Zero Then Marshal.Copy(poffsetPTR, poffset, 0, poffset.count)

	Return  new Pix(_Result)
End Function

' SRC\tiffio.c (1226, 1)
' pixaReadMultipageTiff()
' pixaReadMultipageTiff(const char *) as PIXA *
'''  <remarks>
'''  </remarks>
'''  <param name="filename">[in] - input tiff file</param>
'''   <returns>pixa of page images, or NULL on error</returns>
Public Shared Function pixaReadMultipageTiff(
				ByVal filename as String) as Pixa

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaReadMultipageTiff( filename)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\tiffio.c (1286, 1)
' pixaWriteMultipageTiff()
' pixaWriteMultipageTiff(const char *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The tiff directory overhead is O(n^2).  I have not been<para/>
''' able to reduce it to O(n).  The overhead for n = 2000 is<para/>
''' about 1 second.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fname">[in] - input tiff file</param>
'''  <param name="pixa">[in] - any depth colormap will be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteMultipageTiff(
				ByVal fname as String, 
				ByVal pixa as Pixa) as Integer

	If IsNothing (fname) then Throw New ArgumentNullException  ("fname cannot be Nothing")
	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteMultipageTiff( fname, pixa.Pointer)

	Return _Result
End Function

' SRC\tiffio.c (1347, 1)
' writeMultipageTiff()
' writeMultipageTiff(const char *, const char *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This writes a set of image files in a directory out<para/>
''' as a multipage tiff file.  The images can be in any<para/>
''' initial file format.<para/>
''' (2) Images with a colormap have the colormap removed before<para/>
''' re-encoding as tiff.<para/>
''' (3) All images are encoded losslessly.  Those with 1 bpp are<para/>
''' encoded 'g4'.  The rest are encoded as 'zip' (flate encoding).<para/>
''' Because it is lossless, this is an expensive method for<para/>
''' saving most rgb images.<para/>
''' (4) The tiff directory overhead is quadratic in the number of<para/>
''' images.  To avoid this for very large numbers of images to be<para/>
''' written, apply the method used in pixaWriteMultipageTiff().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="dirin">[in] - input directory</param>
'''  <param name="substr">[in][optional] - substring filter on filenames can be NULL</param>
'''  <param name="fileout">[in] - output multipage tiff file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function writeMultipageTiff(
				ByVal dirin as String, 
				ByVal substr as String, 
				ByVal fileout as String) as Integer

	If IsNothing (dirin) then Throw New ArgumentNullException  ("dirin cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.writeMultipageTiff( dirin, substr, fileout)

	Return _Result
End Function

' SRC\tiffio.c (1383, 1)
' writeMultipageTiffSA()
' writeMultipageTiffSA(SARRAY *, const char *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) See writeMultipageTiff()<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="sa">[in] - string array of full path names</param>
'''  <param name="fileout">[in] - output ps file</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function writeMultipageTiffSA(
				ByVal sa as Sarray, 
				ByVal fileout as String) as Integer

	If IsNothing (sa) then Throw New ArgumentNullException  ("sa cannot be Nothing")
	If IsNothing (fileout) then Throw New ArgumentNullException  ("fileout cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.writeMultipageTiffSA( sa.Pointer, fileout)

	Return _Result
End Function

' SRC\tiffio.c (1443, 1)
' fprintTiffInfo()
' fprintTiffInfo(FILE *, const char *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fpout">[in] - stream for output of tag data</param>
'''  <param name="tiffile">[in] - input</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function fprintTiffInfo(
				ByVal fpout as FILE, 
				ByVal tiffile as String) as Integer

	If IsNothing (fpout) then Throw New ArgumentNullException  ("fpout cannot be Nothing")
	If IsNothing (tiffile) then Throw New ArgumentNullException  ("tiffile cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.fprintTiffInfo( fpout.Pointer, tiffile)

	Return _Result
End Function

' SRC\tiffio.c (1476, 1)
' tiffGetCount()
' tiffGetCount(FILE *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pn">[out] - number of images</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function tiffGetCount(
				ByVal fp as FILE, 
				ByRef pn as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.tiffGetCount( fp.Pointer, pn)

	Return _Result
End Function

' SRC\tiffio.c (1524, 1)
' getTiffResolution()
' getTiffResolution(FILE *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If neither resolution field is set, this is not an error<para/>
''' the returned resolution values are 0 (designating 'unknown').<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream opened for read</param>
'''  <param name="pxres">[out] - resolution in ppi</param>
'''  <param name="pyres">[out] - resolution in ppi</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function getTiffResolution(
				ByVal fp as FILE, 
				ByRef pxres as Integer, 
				ByRef pyres as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.getTiffResolution( fp.Pointer, pxres, pyres)

	Return _Result
End Function

' SRC\tiffio.c (1621, 1)
' readHeaderTiff()
' readHeaderTiff(const char *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
''' (2) If %n is equal to or greater than the number of images, returns 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				ByRef pw as Integer, 
				ByRef ph as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef pres as Integer, 
				ByRef pcmap as Integer, 
				ByRef pformat as Integer) as Integer

	If IsNothing (filename) then Throw New ArgumentNullException  ("filename cannot be Nothing")
	If My.Computer.Filesystem.Fileexists (filename) = false then Throw New ArgumentException ("File is missing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderTiff( filename, n, pw, ph, pbps, pspp, pres, pcmap, pformat)

	Return _Result
End Function

' SRC\tiffio.c (1677, 1)
' freadHeaderTiff()
' freadHeaderTiff(FILE *, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) If there is a colormap, cmap is returned as 1 else 0.<para/>
''' (2) If %n is equal to or greater than the number of images, returns 1.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				ByRef pw as Integer, 
				ByRef ph as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef pres as Integer, 
				ByRef pcmap as Integer, 
				ByRef pformat as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.freadHeaderTiff( fp.Pointer, n, pw, ph, pbps, pspp, pres, pcmap, pformat)

	Return _Result
End Function

' SRC\tiffio.c (1748, 1)
' readHeaderMemTiff()
' readHeaderMemTiff(const l_uint8 *, size_t, l_int32, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
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
				ByRef pw as Integer, 
				ByRef ph as Integer, 
				ByRef pbps as Integer, 
				ByRef pspp as Integer, 
				ByRef pres as Integer, 
				ByRef pcmap as Integer, 
				ByRef pformat as Integer) as Integer

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.readHeaderMemTiff( cdata, size, n, pw, ph, pbps, pspp, pres, pcmap, pformat)

	Return _Result
End Function

' SRC\tiffio.c (1883, 1)
' findTiffCompression()
' findTiffCompression(FILE *, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The returned compression type is that defined in<para/>
''' the enum in imageio.h.  It is not the tiff flag value.<para/>
''' (2) The compression type is initialized to IFF_UNKNOWN.<para/>
''' If it is not one of the specified types, the returned<para/>
''' type is IFF_TIFF, which indicates no compression.<para/>
''' (3) When this function is called, the stream must be at BOF.<para/>
''' If the opened stream is to be used again to read the<para/>
''' file, it must be rewound to BOF after calling this function.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="fp">[in] - file stream must be rewound to BOF</param>
'''  <param name="pcomptype">[out] - compression type</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function findTiffCompression(
				ByVal fp as FILE, 
				ByRef pcomptype as Integer) as Integer

	If IsNothing (fp) then Throw New ArgumentNullException  ("fp cannot be Nothing")


	Dim _Result as Integer = LeptonicaSharp.Natives.findTiffCompression( fp.Pointer, pcomptype)

	Return _Result
End Function

' SRC\tiffio.c (1968, 1)
' extractG4DataFromFile()
' extractG4DataFromFile(const char *, l_uint8 **, size_t *, l_int32 *, l_int32 *, l_int32 *) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="filein">[in] - </param>
'''  <param name="pdata">[out] - binary data of ccitt g4 encoded stream</param>
'''  <param name="pnbytes">[out] - size of binary data</param>
'''  <param name="pw">[out][optional] - image width</param>
'''  <param name="ph">[out][optional] - image height</param>
'''  <param name="pminisblack">[out][optional] - boolean</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function extractG4DataFromFile(
				ByVal filein as String, 
				ByRef pdata as Byte(), 
				ByRef pnbytes as UInteger, 
				ByRef pw as Integer, 
				ByRef ph as Integer, 
				ByRef pminisblack as Integer) as Integer

	If IsNothing (filein) then Throw New ArgumentNullException  ("filein cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.extractG4DataFromFile( filein, pdataPTR, pnbytes, pw, ph, pminisblack)
	ReDim pdata(IIf(pnbytes > 0, pnbytes, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\tiffio.c (2445, 1)
' pixReadMemTiff()
' pixReadMemTiff(const l_uint8 *, size_t, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a version of pixReadTiff(), where the data is read<para/>
''' from a memory buffer and uncompressed.<para/>
''' (2) Use TIFFClose() TIFFCleanup() doesn't free internal memstream.<para/>
''' (3) No warning messages on failure, because of how multi-page<para/>
''' TIFF reading works. You are supposed to keep trying until<para/>
''' it stops working.<para/>
''' (4) Tiff directory overhead is linear in the input page number.<para/>
''' If reading many images, use pixReadMemFromMultipageTiff().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cdata">[in] - const tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''  <param name="n">[in] - page image number: 0-based</param>
'''   <returns>pix, or NULL on error</returns>
Public Shared Function pixReadMemTiff(
				ByVal cdata as Byte(), 
				ByVal size as UInteger, 
				ByVal n as Integer) as Pix

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemTiff( cdata, size, n)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\tiffio.c (2510, 1)
' pixReadMemFromMultipageTiff()
' pixReadMemFromMultipageTiff(const l_uint8 *, size_t, size_t *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a read-from-memory version of pixReadFromMultipageTiff().<para/>
''' See that function for usage.<para/>
''' (2) If reading sequentially from the tiff data, this is more<para/>
''' efficient than pixReadMemTiff(), which has an overhead<para/>
''' proportional to the image index n.<para/>
''' (3) Example usage for reading all the images:<para/>
''' size_t offset = 0<para/>
''' do {<para/>
''' Pix pix = pixReadMemFromMultipageTiff(data, size,  and offset)<para/>
''' // do something with pix<para/>
''' } while (offset != 0)<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="cdata">[in] - const tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''  <param name="poffset">[in,out] - set offset to 0 for first image</param>
'''   <returns>pix, or NULL on error or if previous call returned the last image</returns>
Public Shared Function pixReadMemFromMultipageTiff(
				ByVal cdata as Byte(), 
				ByVal size as UInteger, 
				ByRef poffset as Byte()) as Pix

	If IsNothing (cdata) then Throw New ArgumentNullException  ("cdata cannot be Nothing")

	Dim poffsetPTR As IntPtr = Marshal.AllocHGlobal(poffset.Count) : Marshal.Copy(poffset, 0, poffsetPTR, poffset.Length)

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixReadMemFromMultipageTiff( cdata, size, poffsetPTR)
	If  _Result = IntPtr.Zero then Return Nothing
	ReDim poffset(IIf(size > 0, size, 1) - 1) : If poffsetPTR <> IntPtr.Zero Then Marshal.Copy(poffsetPTR, poffset, 0, poffset.count)

	Return  new Pix(_Result)
End Function

' SRC\tiffio.c (2566, 1)
' pixaReadMemMultipageTiff()
' pixaReadMemMultipageTiff(const l_uint8 *, size_t) as PIXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an O(n) read-from-memory version of pixaReadMultipageTiff().<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - const multiple pages tiff-encoded</param>
'''  <param name="size">[in] - size of cdata</param>
'''   <returns>pixa, or NULL on error</returns>
Public Shared Function pixaReadMemMultipageTiff(
				ByVal data as Byte(), 
				ByVal size as UInteger) as Pixa

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixaReadMemMultipageTiff( data, size)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pixa(_Result)
End Function

' SRC\tiffio.c (2606, 1)
' pixaWriteMemMultipageTiff()
' pixaWriteMemMultipageTiff(l_uint8 **, size_t *, PIXA *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) fopenTiffMemstream() does not work in append mode, so we<para/>
''' must work-around with a temporary file.<para/>
''' (2) Getting a file stream from<para/>
''' open_memstream((char )pdata, psize)<para/>
''' does not work with the tiff directory.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - const tiff-encoded</param>
'''  <param name="psize">[out] - size of data</param>
'''  <param name="pixa">[in] - any depth colormap will be removed</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixaWriteMemMultipageTiff(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pixa as Pixa) as Integer

	If IsNothing (pixa) then Throw New ArgumentNullException  ("pixa cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixaWriteMemMultipageTiff( pdataPTR, psize, pixa.Pointer)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\tiffio.c (2672, 1)
' pixWriteMemTiff()
' pixWriteMemTiff(l_uint8 **, size_t *, PIX *, l_int32) as l_ok
'''  <remarks>
'''  </remarks>
'''  <param name="pdata">[out] - data of tiff compressed image</param>
'''  <param name="psize">[out] - size of returned data</param>
'''  <param name="pix">[in] - </param>
'''  <param name="comptype">[in] - IFF_TIFF, IFF_TIFF_RLE, IFF_TIFF_PACKBITS, IFF_TIFF_G3, IFF_TIFF_G4, IFF_TIFF_LZW, IFF_TIFF_ZIP</param>
'''   <returns>0 if OK, 1 on error Usage: 1) See pixWriteTiff(.  This version writes to memory instead of to a file.</returns>
Public Shared Function pixWriteMemTiff(
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemTiff( pdataPTR, psize, pix.Pointer, comptype)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

' SRC\tiffio.c (2703, 1)
' pixWriteMemTiffCustom()
' pixWriteMemTiffCustom(l_uint8 **, size_t *, PIX *, l_int32, NUMA *, SARRAY *, SARRAY *, NUMA *) as l_ok
'''  <remarks>
'''  </remarks>
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
				ByRef pdata as Byte(), 
				ByRef psize as UInteger, 
				ByVal pix as Pix, 
				ByVal comptype as Enumerations.IFF, 
				ByVal natags as Numa, 
				ByVal savals as Sarray, 
				ByVal satypes as Sarray, 
				ByVal nasizes as Numa) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim pdataPTR As IntPtr = IntPtr.Zero
	Dim natagsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(natags) Then natagsPTR = natags.Pointer
	Dim savalsPTR As IntPtr = IntPtr.Zero : If Not IsNothing(savals) Then savalsPTR = savals.Pointer
	Dim satypesPTR As IntPtr = IntPtr.Zero : If Not IsNothing(satypes) Then satypesPTR = satypes.Pointer
	Dim nasizesPTR As IntPtr = IntPtr.Zero : If Not IsNothing(nasizes) Then nasizesPTR = nasizes.Pointer

	Dim _Result as Integer = LeptonicaSharp.Natives.pixWriteMemTiffCustom( pdataPTR, psize, pix.Pointer, comptype, natagsPTR, savalsPTR, satypesPTR, nasizesPTR)
	ReDim pdata(IIf(psize > 0, psize, 1) - 1) : If pdataPTR <> IntPtr.Zero Then Marshal.Copy(pdataPTR, pdata, 0, pdata.count)

	Return _Result
End Function

End Class

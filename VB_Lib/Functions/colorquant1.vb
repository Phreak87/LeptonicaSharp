Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\colorquant1.c (535, 1)
' pixOctreeColorQuant(pixs, colors, ditherflag) as Pix
' pixOctreeColorQuant(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' I found one description in the literature of octree color<para/>
''' quantization, using progressive truncation of the octree,<para/>
''' by M. Gervautz and W. Purgathofer in Graphics Gems, pp.<para/>
''' 287-293, ed. A. Glassner, Academic Press, 1990.<para/>
''' Rather than setting up a fixed partitioning of the color<para/>
''' space ab initio, as we do here, they allow the octree to be<para/>
''' progressively truncated as new pixels are added.  They<para/>
''' need to set up some data structures that are traversed<para/>
''' with the addition of each 24 bit pixel, in order to decide<para/>
''' either 1) in which cluster (sub-branch of the octree to put<para/>
''' the pixel, or 2 whether to truncate the octree further<para/>
''' to place the pixel in an existing cluster, or 3 which<para/>
''' two existing clusters should be merged so that the pixel<para/>
''' can be left to start a truncated leaf of the octree.  Such dynamic<para/>
''' truncation is considerably more complicated, and Gervautz et<para/>
''' al. did not explain how they did it in anywhere near the<para/>
''' detail required to check their implementation.<para/>
''' The simple method in pixFixedOctcubeQuant256 is very<para/>
''' fast, and with dithering the results are good, but you<para/>
''' can do better if the color clusters are selected adaptively<para/>
''' from the image.  We want a method that makes much better<para/>
''' use of color samples in regions of color space with high<para/>
''' pixel density, while also fairly representing small numbers<para/>
''' of color pixels in low density regions.  Such adaptation<para/>
''' requires two passes through the image: the first for generating<para/>
''' the pruned tree of color cubes and the second for computing the index<para/>
''' into the color table for each pixel.<para/>
''' A relatively simple adaptive method is pixOctreeQuantByPopulation.<para/>
''' That function first determines if the image has very few colors,<para/>
''' and, if so, quantizes to those colors.  If there are more than<para/>
''' 256 colors, it generates a histogram of octcube leaf occupancy<para/>
''' at level 4, chooses the 192 most populated such leaves as<para/>
''' the first 192 colors, and sets the remaining 64 colors to the<para/>
''' residual average pixel values in each of the 64 level 2 octcubes.<para/>
''' This is a bit faster than pixOctreeColorQuant, and does very<para/>
''' well without dithering, but for most images with dithering it<para/>
''' is clearly inferior.<para/>
''' We now describe pixOctreeColorQuant.  The first pass is done<para/>
''' on a subsampled image, because we do not need to use all the<para/>
''' pixels in the image to generate the tree.  Subsampling<para/>
''' down to 0.25 1/16 of the pixels makes the program run<para/>
''' about 1.3 times faster.<para/>
''' Instead of dividing the color space into 256 equal-sized<para/>
''' regions, we initially divide it into 2^12 or 2^15 or 2^18<para/>
''' equal-sized octcubes.  Suppose we choose to use 2^18 octcubes.<para/>
''' This gives us 6 octree levels.  We then prune back,<para/>
''' starting from level 6.  For every cube at level 6, there<para/>
''' are 8 cubes at level 5.  Call the operation of putting a<para/>
''' cube aside as a color table entry CTE a "saving."<para/>
''' We use a in general level-dependent threshold, and save<para/>
''' those level 6 cubes that are above threshold.<para/>
''' The rest are combined into the containing level 5 cube.<para/>
''' If between 1 and 7 level 6 cubes within a level 5<para/>
''' cube have been saved by thresholding, then the remaining<para/>
''' level 6 cubes in that level 5 cube are automatically<para/>
''' saved as well, without applying a threshold.  This greatly<para/>
''' simplifies both the description of the CTEs and the later<para/>
''' classification of each pixel as belonging to a CTE.<para/>
''' This procedure is iterated through every cube, starting at<para/>
''' level 5, and then 4, 3, and 2, successively.  The result is that<para/>
''' each CTE contains the entirety of a set of from 1 to 7 cubes<para/>
''' from a given level that all belong to a single cube at the<para/>
''' level above. We classify the CTEs in terms of the<para/>
''' condition in which they are made as either being "threshold"<para/>
''' or "residual."  They are "threshold" CTEs if no subcubes<para/>
''' are CTEs that is, they contain every pixel within the cube<para/>
''' and the number of pixels exceeds the threshold for making<para/>
''' a CTE.  They are "residual" CTEs if at least one but not more<para/>
''' than 7 of the subcubes have already been determined to be CTEs<para/>
''' this happens automatically -- no threshold is applied.<para/>
''' If all 8 subcubes are determined to be CTEs, the cube is<para/>
''' marked as having all pixels accounted for 'bleaf' = 1 but<para/>
''' is not saved as a CTE.<para/>
''' We stop the pruning at level 2, at which there are 64<para/>
''' sub-cubes.  Any pixels not already claimed in a CTE are<para/>
''' put in these cubes.<para/>
''' As the cubes are saved as color samples in the color table,<para/>
''' the number of remaining pixels P and the number of<para/>
''' remaining colors in the color table N are recomputed,<para/>
''' along with the average number of pixels P/N ppc to go in<para/>
''' each of the remaining colors.  This running average number is<para/>
''' used to set the threshold at the current level.<para/>
''' Because we are going to very small cubes at levels 6 or 5,<para/>
''' and will dither the colors for errors, it is not necessary<para/>
''' to compute the color center of each cluster we can simply<para/>
''' use the center of the cube.  This gives us a minimax error<para/>
''' condition: the maximum error is half the width of the<para/>
''' level 2 cubes -- 32 color values out of 256 -- for each color<para/>
''' sample.  In practice, most of the pixels will be very much<para/>
''' closer to the center of their cells.  And with dithering,<para/>
''' the average pixel color in a small region will be closer still.<para/>
''' Thus with the octree quantizer, we are able to capture<para/>
''' regions of high color pdf probability density function in small<para/>
''' but accurate CTEs, and to have only a small number of pixels<para/>
''' that end up a significant distance with a guaranteed maximum<para/>
''' from their true color.<para/>
''' How should the threshold factor vary?  Threshold factors<para/>
''' are required for levels 2, 3, 4 and 5 in the pruning stage.<para/>
''' The threshold for level 5 is actually applied to cubes at<para/>
''' level 6, etc.  From various experiments, it appears that<para/>
''' the results do not vary appreciably for threshold values near 1.0.<para/>
''' If you want more colors in smaller cubes, the threshold<para/>
''' factors can be set lower than 1.0 for cubes at levels 4 and 5.<para/>
''' However, if the factor is set much lower than 1.0 for<para/>
''' levels 2 and 3, we can easily run out of colors.<para/>
''' We put aside 64 colors in the calculation of the threshold<para/>
''' values, because we must have 64 color centers at level 2,<para/>
''' that will have very few pixels in most of them.<para/>
''' If we reduce the factor for level 5 to 0.4, this will<para/>
''' generate many level 6 CTEs, and consequently<para/>
''' many residual cells will be formed up from those leaves,<para/>
''' resulting in the possibility of running out of colors.<para/>
''' Remember, the residual CTEs are mandatory, and are formed<para/>
''' without using the threshold, regardless of the number of<para/>
''' pixels that are absorbed.<para/>
''' The implementation logically has four parts:<para/>
''' 1 accumulation into small, fixed cells<para/>
''' 2 pruning back into selected CTE cubes<para/>
''' 3 organizing the CTEs for fast search to find<para/>
''' the CTE to which any image pixel belongs<para/>
''' 4 doing a second scan to code the image pixels by CTE<para/>
''' Step 1 is straightforward we use 2^15 cells.<para/>
''' We've already discussed how the pruning step 2 will be performed.<para/>
''' Steps 3) and (4 are related, in that the organization<para/>
''' used by step 3 determines how the search actually<para/>
''' takes place for each pixel in step 4.<para/>
''' There are many ways to do step 3.  Let's explore a few.<para/>
''' a The simplest is to order the cubes from highest occupancy<para/>
''' to lowest, and traverse the list looking for the deepest<para/>
''' match.  To make this more efficient, so that we know when<para/>
''' to stop looking, any cube that has separate CTE subcubes<para/>
''' would be marked as such, so that we know when we hit a<para/>
''' true leaf.<para/>
''' b Alternatively, we can order the cubes by highest<para/>
''' occupancy separately each level, and work upward,<para/>
''' starting at level 5, so that when we find a match we<para/>
''' know that it will be correct.<para/>
''' c Another approach would be to order the cubes by<para/>
''' "address" and use a hash table to find the cube<para/>
''' corresponding to a pixel color.  I don't know how to<para/>
''' do this with a variable length address, as each CTE<para/>
''' will have 3n bits, where n is the level.<para/>
''' d Another approach entirely is to put the CTE cubes into<para/>
''' a tree, in such a way that starting from the root, and<para/>
''' using 3 bits of address at a time, the correct branch of<para/>
''' each octree can be taken until a leaf is found.  Because<para/>
''' a given cube can be both a leaf and also have branches<para/>
''' going to sub-cubes, the search stops only when no<para/>
''' marked subcubes have addresses that match the given pixel.<para/>
''' In the tree method, we can start with a dense infrastructure,<para/>
''' and place the leaves corresponding to the N colors<para/>
''' in the tree, or we can grow from the root only those<para/>
''' branches that end directly on leaves.<para/>
''' What we do here is to take approach d, and implement the tree<para/>
''' "virtually", as a set of arrays, one array for each level<para/>
''' of the tree. Initially we start at level 5, an array with<para/>
''' 2^15 cubes, each with 8 subcubes.  We then build nodes at<para/>
''' levels closer to the root at level 4 there are 2^12 nodes<para/>
''' each with 8 subcubes etc.  Using these arrays has<para/>
''' several advantages:<para/>
''' ~  We don't need to keep track of links between cubes<para/>
''' and subcubes, because we can use the canonical<para/>
''' addressing on the cell arrays directly to determine<para/>
''' which nodes are parent cubes and which are sub-cubes.<para/>
''' ~  We can prune directly on this tree<para/>
''' ~  We can navigate the pruned tree quickly to classify<para/>
''' each pixel in the image.<para/>
''' Canonical addressing guarantees that the i-th node at level k<para/>
''' has 8 subnodes given by the 8i ... 8i+7 nodes at level k+1.<para/>
''' The pruning step works as follows.  We go from the lowest<para/>
''' level up.  At each level, the threshold is found from the<para/>
''' product of a factor near 1.0 and the ratio of unmarked pixels<para/>
''' to remaining colors minus the 64.  We march through<para/>
''' the space, sequentially considering a cube and its 8 subcubes.<para/>
''' We first check those subcubes that are not already<para/>
''' marked as CTE to see if any are above threshold, and if so,<para/>
''' generate a CTE and mark them as such.<para/>
''' We then determine if any of the subcubes have been marked.<para/>
''' If so, and there are subcubes that are not marked,<para/>
''' we generate a CTE for the cube from the remaining unmarked<para/>
''' subcubes this is mandatory and does not depend on how many<para/>
''' pixels are in the set of subcubes.  If none of the subcubes<para/>
''' are marked, we aggregate their pixels into the cube<para/>
''' containing them, but do not mark it as a CTE that<para/>
''' will be determined when iterating through the next level up.<para/>
''' When all the pixels in a cube are accounted for in one or more<para/>
''' colors, we set the boolean 'bleaf' to true.  This is the<para/>
''' flag used to mark the cubes in the pruning step.  If a cube<para/>
''' is marked, and all 8 subcubes are marked, then it is not<para/>
''' itself given a CTE because all pixels have already been<para/>
''' accounted for.<para/>
''' Note that the pruning of the tree and labelling of the CTEs<para/>
''' step 2 accomplishes step 3 implicitly, because the marked<para/>
''' and pruned tree is ready for use in labelling each pixel<para/>
''' in step 4.  We now, for every pixel in the image, traverse<para/>
''' the tree from the root, looking for the lowest cube that is a leaf.<para/>
''' At each level we have a cube and subcube.  If we reach a subcube<para/>
''' leaf that is marked 0, we know that the color is stored in the<para/>
''' cube above, and we've found the CTE.  Otherwise, the subcube<para/>
''' leaf is marked 1.  If we're at the last level, we've reached<para/>
''' the final leaf and must use it.  Otherwise, continue the<para/>
''' process at the next level down.<para/>
''' For robustness, efficiency and high quality output, we do the following:<para/>
''' (1) Measure the color content of the image.  If there is very little<para/>
''' color, quantize in grayscale.<para/>
''' (2) For efficiency, build the octree with a subsampled image if the<para/>
''' image is larger than some threshold size.<para/>
''' (3) Reserve an extra set of colors to prevent running out of colors<para/>
''' when pruning the octree specifically, during the assignment<para/>
''' of those level 2 cells out of the 64 that have unassigned<para/>
''' pixels.  The problem of running out is more likely to happen<para/>
''' with small images, because the estimation we use for the<para/>
''' number of pixels available is not accurate.<para/>
''' (4) In the unlikely event that we run out of colors, the dithered<para/>
''' image can be very poor.  As this would only happen with very<para/>
''' small images, and dithering is not particularly noticeable with<para/>
''' such images, turn it off.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctreeColorQuant/*"/>
'''  <param name="pixs">[in] - 32 bpp 24-bit color</param>
'''  <param name="colors">[in] - in colormap some number in range [128 ... 256] the actual number of colors used will be smaller</param>
'''  <param name="ditherflag">[in] - 1 to dither, 0 otherwise</param>
'''   <returns>pixd 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixOctreeColorQuant(
				 ByVal pixs as Pix, 
				 ByVal colors as Integer, 
				 ByVal ditherflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctreeColorQuant( pixs.Pointer, colors, ditherflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (601, 1)
' pixOctreeColorQuantGeneral(pixs, colors, ditherflag, validthresh, colorthresh) as Pix
' pixOctreeColorQuantGeneral(PIX *, l_int32, l_int32, l_float32, l_float32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) The parameters %validthresh and %colorthresh are used to<para/>
''' determine if color quantization should be used on an image,<para/>
''' or whether, instead, it should be quantized in grayscale.<para/>
''' If the image has very few non-white and non-black pixels, or<para/>
''' if those pixels that are non-white and non-black are all<para/>
''' very close to either white or black, it is usually better<para/>
''' to treat the color as accidental and to quantize the image<para/>
''' to gray only.  These parameters are useful if you know<para/>
''' something a priori about the image.  Perhaps you know that<para/>
''' there is only a very small fraction of color pixels, but they're<para/>
''' important to preserve then you want to use a smaller value for<para/>
''' these parameters.  To disable conversion to gray and force<para/>
''' color quantization, use %validthresh = 0.0 and %colorthresh = 0.0.<para/>
''' (2) See pixOctreeColorQuant() for algorithmic and implementation<para/>
''' details.  This function has a more general interface.<para/>
''' (3) See pixColorFraction() for computing the fraction of pixels<para/>
''' that are neither white nor black, and the fraction of those<para/>
''' pixels that have little color.  From the documentation there:<para/>
''' If pixfract is very small, there are few pixels that are<para/>
''' neither black nor white.  If colorfract is very small,<para/>
''' the pixels that are neither black nor white have very<para/>
''' little color content.  The product 'pixfract  colorfract'<para/>
''' gives the fraction of pixels with significant color content.<para/>
''' We test against the product %validthresh  %colorthresh<para/>
''' to find color in images that have either very few<para/>
''' intermediate gray pixels or that have many such gray pixels.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctreeColorQuantGeneral/*"/>
'''  <param name="pixs">[in] - 32 bpp 24-bit color</param>
'''  <param name="colors">[in] - in colormap some number in range [128 ... 240] the actual number of colors used will be smaller</param>
'''  <param name="ditherflag">[in] - 1 to dither, 0 otherwise</param>
'''  <param name="validthresh">[in] - minimum fraction of pixels neither near white nor black, required for color quantization typically ~0.01, but smaller for images that have color but are nearly all white</param>
'''  <param name="colorthresh">[in] - minimum fraction of pixels with color that are not near white or black, that are required for color quantization typ. ~0.01, but smaller for images that have color along with a significant fraction of gray</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixOctreeColorQuantGeneral(
				 ByVal pixs as Pix, 
				 ByVal colors as Integer, 
				 ByVal ditherflag as Integer, 
				 ByVal validthresh as Single, 
				 ByVal colorthresh as Single) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctreeColorQuantGeneral( pixs.Pointer, colors, ditherflag, validthresh, colorthresh)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (1361, 1)
' makeRGBToIndexTables(prtab, pgtab, pbtab, cqlevels) as Integer
' makeRGBToIndexTables(l_uint32 **, l_uint32 **, l_uint32 **, l_int32) as l_ok
'''  <summary>
''' <para/>
''' Set up tables.  e.g., for cqlevels = 5, we need an integer 0  is lower  i  is lower  2^15:<para/>
''' rtab = 0  i7  0 0  i6  0 0  i5  0 0 i4  0 0 i3  0 0<para/>
''' gtab = 0  0 i7  0 0  i6  0 0  i5  0 0 i4  0 0 i3  0<para/>
''' btab = 0  0 0 i7  0  0 i6  0  0 i5  0 0 i4  0 0 i3<para/>
''' The tables are then used to map from rbg -- is greater  index as follows:<para/>
''' index = 0  r7  g7  b7  r6  g6  b6  r5  g5  b5  r4  g4  b4  r3  g3  b3<para/>
''' e.g., for cqlevels = 4, we map to<para/>
''' index = 0  0 0 0 r7  g7  b7  r6  g6  b6  r5  g5  b5  r4  g4  b4<para/>
''' This may look a bit strange.  The notation 'r7' means the MSBit of<para/>
''' the r value which has 8 bits, going down from r7 to r0.<para/>
''' Keep in mind that r7 is actually the r component bit for level 1 of<para/>
''' the octtree.  Level 1 is composed of 8 octcubes, represented by<para/>
''' the bits r7 g7 b7, which divide the entire color space into<para/>
''' 8 cubes.  At level 2, each of these 8 octcubes is further divided into<para/>
''' 8 cubes, each labeled by the second most significant bits r6 g6 b6<para/>
''' of the rgb color.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/makeRGBToIndexTables/*"/>
'''  <param name="prtab">[out] - tables</param>
'''  <param name="pgtab">[out] - tables</param>
'''  <param name="pbtab">[out] - tables</param>
'''  <param name="cqlevels">[in] - can be 1, 2, 3, 4, 5 or 6</param>
'''   <returns>0 if OK 1 on error</returns>
Public Shared Function makeRGBToIndexTables(
				<Out()> ByRef prtab as Byte(), 
				<Out()> ByRef pgtab as Byte(), 
				<Out()> ByRef pbtab as Byte(), 
				 ByVal cqlevels as Integer) as Integer

	Dim prtabPTR As IntPtr = IntPtr.Zero
	Dim pgtabPTR As IntPtr = IntPtr.Zero
	Dim pbtabPTR As IntPtr = IntPtr.Zero

	Dim _Result as Integer = LeptonicaSharp.Natives.makeRGBToIndexTables( prtabPTR, pgtabPTR, pbtabPTR, cqlevels)
	ReDim prtab(IIf(1 > 0, 1, 1) - 1) : If prtabPTR <> IntPtr.Zero Then Marshal.Copy(prtabPTR, prtab, 0, prtab.count)
	ReDim pgtab(IIf(1 > 0, 1, 1) - 1) : If pgtabPTR <> IntPtr.Zero Then Marshal.Copy(pgtabPTR, pgtab, 0, pgtab.count)
	ReDim pbtab(IIf(1 > 0, 1, 1) - 1) : If pbtabPTR <> IntPtr.Zero Then Marshal.Copy(pbtabPTR, pbtab, 0, pbtab.count)

	Return _Result
End Function

' SRC\colorquant1.c (1470, 1)
' getOctcubeIndexFromRGB(rval, gval, bval, rtab, gtab, btab, pindex) as Object
' getOctcubeIndexFromRGB(l_int32, l_int32, l_int32, l_uint32 *, l_uint32 *, l_uint32 *, l_uint32 *) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' No error checking!<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/getOctcubeIndexFromRGB/*"/>
'''  <param name="rval">[in] - </param>
'''  <param name="gval">[in] - </param>
'''  <param name="bval">[in] - </param>
'''  <param name="rtab">[in] - generated with makeRGBToIndexTables()</param>
'''  <param name="gtab">[in] - generated with makeRGBToIndexTables()</param>
'''  <param name="btab">[in] - generated with makeRGBToIndexTables()</param>
'''  <param name="pindex">[out] - found index</param>
Public Shared Sub getOctcubeIndexFromRGB(
				 ByVal rval as Integer, 
				 ByVal gval as Integer, 
				 ByVal bval as Integer, 
				 ByVal rtab as Byte(), 
				 ByVal gtab as Byte(), 
				 ByVal btab as Byte(), 
				<Out()> ByRef pindex as UInteger)

	If IsNothing (rtab) then Throw New ArgumentNullException  ("rtab cannot be Nothing")
	If IsNothing (gtab) then Throw New ArgumentNullException  ("gtab cannot be Nothing")
	If IsNothing (btab) then Throw New ArgumentNullException  ("btab cannot be Nothing")

	Dim rtabPTR As IntPtr = Marshal.AllocHGlobal(rtab.Count) : Marshal.Copy(rtab, 0, rtabPTR, rtab.Length)
	Dim gtabPTR As IntPtr = Marshal.AllocHGlobal(gtab.Count) : Marshal.Copy(gtab, 0, gtabPTR, gtab.Length)
	Dim btabPTR As IntPtr = Marshal.AllocHGlobal(btab.Count) : Marshal.Copy(btab, 0, btabPTR, btab.Length)

	LeptonicaSharp.Natives.getOctcubeIndexFromRGB( rval, gval, bval, rtabPTR, gtabPTR, btabPTR, pindex)

End Sub

' SRC\colorquant1.c (1701, 1)
' pixOctreeQuantByPopulation(pixs, level, ditherflag) as Pix
' pixOctreeQuantByPopulation(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This color quantization method works very well without<para/>
''' dithering, using octcubes at two different levels:<para/>
''' (a) the input %level, which is either 3 or 4<para/>
''' (b) level 2 (64 octcubes to cover the entire color space)<para/>
''' (2) For best results, using %level = 4 is recommended.<para/>
''' Why do we provide an option for using level 3?  Because<para/>
''' there are 512 octcubes at level 3, and for many images<para/>
''' not more than 256 are filled.  As a result, on some images<para/>
''' a very accurate quantized representation is possible using<para/>
''' %level = 3.<para/>
''' (3) This first breaks up the color space into octcubes at the<para/>
''' input %level, and computes, for each octcube, the average<para/>
''' value of the pixels that are in it.<para/>
''' (4) Then there are two possible situations:<para/>
''' (a) If there are not more than 256 populated octcubes,<para/>
''' it returns a cmapped pix with those values assigned.<para/>
''' (b) Otherwise, it selects 192 octcubes containing the largest<para/>
''' number of pixels and quantizes pixels within those octcubes<para/>
''' to their average.  Then, to handle the residual pixels<para/>
''' that are not in those 192 octcubes, it generates a<para/>
''' level 2 octree consisting of 64 octcubes, and within<para/>
''' each octcube it quantizes the residual pixels to their<para/>
''' average within each of those level 2 octcubes.<para/>
''' (5) Unpopulated level 2 octcubes are represented in the colormap<para/>
''' by their centers.  This, of course, has no effect unless<para/>
''' dithering is used for the output image.<para/>
''' (6) The depth of pixd is the minimum required to support the<para/>
''' number of colors found at %level namely, 2, 4 or 8.<para/>
''' (7) This function works particularly well on images such as maps,<para/>
''' where there are a relatively small number of well-populated<para/>
''' colors, but due to antialiasing and compression artifacts<para/>
''' there may be a large number of different colors.  This will<para/>
''' pull out and represent accurately the highly populated colors,<para/>
''' while still making a reasonable approximation for the others.<para/>
''' (8) The highest level of octcubes allowed is 4.  Use of higher<para/>
''' levels typically results in having a small fraction of<para/>
''' pixels in the most populated 192 octcubes.  As a result,<para/>
''' most of the pixels are represented at level 2, which is<para/>
''' not sufficiently accurate.<para/>
''' (9) Dithering shows artifacts on some images.  If you plan to<para/>
''' dither, pixOctreeColorQuant() and pixFixedOctcubeQuant256()<para/>
''' usually give better results.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctreeQuantByPopulation/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - significant bits for each of RGB valid for {3,4}, Use 0 for default (level 4 recommended</param>
'''  <param name="ditherflag">[in] - 1 to dither, 0 otherwise</param>
'''   <returns>pixd quantized to octcubes or NULL on error</returns>
Public Shared Function pixOctreeQuantByPopulation(
				 ByVal pixs as Pix, 
				 ByVal level as Integer, 
				 ByVal ditherflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctreeQuantByPopulation( pixs.Pointer, level, ditherflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (2263, 1)
' pixOctreeQuantNumColors(pixs, maxcolors, subsample) as Pix
' pixOctreeQuantNumColors(PIX *, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' pixOctreeColorQuant is very flexible in terms of the relative<para/>
''' depth of different cubes of the octree. By contrast, this function,<para/>
''' pixOctreeQuantNumColors is also adaptive, but it supports octcube<para/>
''' leaves at only two depths: a smaller depth that guarantees<para/>
''' full coverage of the color space and octcubes at one level<para/>
''' deeper for more accurate colors.  Its main virutes are simplicity<para/>
''' and speed, which are both derived from the natural indexing of<para/>
''' the octcubes from the RGB values.<para/>
''' Before describing pixOctreeQuantNumColors, consider an even simpler<para/>
''' approach for 4 bpp with either 8 or 16 colors.  With 8 colors,<para/>
''' you simply go to level 1 octcubes and use the average color<para/>
''' found in each cube.  For 16 colors, you find which of the three<para/>
''' colors has the largest variance at the second level, and use two<para/>
''' indices for that color.  The result is quite poor, because 1 some<para/>
''' of the cubes are nearly empty and 2 you don't get much color<para/>
''' differentiation for the extra 8 colors.  Trust me, this method may<para/>
''' be simple, but it isn't worth anything.<para/>
''' In pixOctreeQuantNumColors, we generate colormapped images at<para/>
''' either 4 bpp or 8 bpp.  For 4 bpp, we have a minimum of 8 colors<para/>
''' for the level 1 octcubes, plus up to 8 additional colors that<para/>
''' are determined from the level 2 popularity.  If the number of colors<para/>
''' is between 8 and 16, the output is a 4 bpp image.  If the number of<para/>
''' colors is greater than 16, the output is a 8 bpp image.<para/>
''' We use a priority queue, implemented with a heap, to select the<para/>
''' requisite number of most populated octcubes at the deepest level<para/>
''' level 2 for 64 or fewer colors level 3 for more than 64 colors.<para/>
''' These are combined with one color for each octcube one level above,<para/>
''' which is used to span the color space of octcubes that were not<para/>
''' included at the deeper level.<para/>
''' If the deepest level is 2, we combine the popular level 2 octcubes<para/>
''' out of a total of 64 with the 8 level 1 octcubes.  If the deepest<para/>
''' level is 3, we combine the popular level 3 octcubes out of a<para/>
''' total 512 with the 64 level 2 octcubes that span the color space.<para/>
''' In the latter case, we require a minimum of 64 colors for the level 2<para/>
''' octcubes, plus up to 192 additional colors determined from level 3<para/>
''' popularity.<para/>
''' The parameter 'maxlevel' is the deepest octcube level that is used.<para/>
''' The implementation also uses two LUTs, which are employed in<para/>
''' two successive traversals of the dest image.  The first maps<para/>
''' from the src octindex at 'maxlevel' to the color table index,<para/>
''' which is the value that is stored in the 4 or 8 bpp dest pixel.<para/>
''' The second LUT maps from that colormap value in the dest to a<para/>
''' new colormap value for a minimum sized colormap, stored back in<para/>
''' the dest.  It is used to remove any color map entries that<para/>
''' correspond to color space regions that have no pixels in the<para/>
''' source image.  These regions can be either from the higher level<para/>
''' e.g., level 1 for 4 bpp, or from octcubes at 'maxlevel' that<para/>
''' are unoccupied.  This remapping results in the minimum number<para/>
''' of colors used according to the constraints induced by the<para/>
''' input 'maxcolors'.  We also compute the average R, G and B color<para/>
''' values in each region of the color space represented by a<para/>
''' colormap entry, and store them in the colormap.<para/>
''' The maximum number of colors is input, which determines the<para/>
''' following properties of the dest image and octcube regions used:<para/>
''' Number of colors  dest image depth  maxlevel<para/>
''' ----------------  ----------------  --------<para/>
''' 8 to 16  4 bpp   2<para/>
''' 17 to 64   8 bpp   2<para/>
''' 65 to 256  8 bpp   3<para/>
''' It may turn out that the number of extra colors, beyond the<para/>
''' minimum 8 and 64 for maxlevel 2 and 3, respectively, is larger<para/>
''' than the actual number of occupied cubes at these levels<para/>
''' In that case, all the pixels are contained in this<para/>
''' subset of cubes at maxlevel, and no colormap colors are needed<para/>
''' to represent the remainder pixels one level above.  Thus, for<para/>
''' example, in use one often finds that the pixels in an image<para/>
''' occupy less than 192 octcubes at level 3, so they can be represented<para/>
''' by a colormap for octcubes at level 3 only.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctreeQuantNumColors/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="maxcolors">[in] - 8 to 256 the actual number of colors used may be less than this</param>
'''  <param name="subsample">[in] - factor for computing color distribution use 0 for default</param>
'''   <returns>pixd 4 or 8 bpp, colormapped, or NULL on error</returns>
Public Shared Function pixOctreeQuantNumColors(
				 ByVal pixs as Pix, 
				 ByVal maxcolors as Integer, 
				 ByVal subsample as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctreeQuantNumColors( pixs.Pointer, maxcolors, subsample)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (2587, 1)
' pixOctcubeQuantMixedWithGray(pixs, depth, graylevels, delta) as Pix
' pixOctcubeQuantMixedWithGray(PIX *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a colormapped image, where the colormap table values<para/>
''' have two components: octcube values representing pixels with<para/>
''' color content, and grayscale values for the rest.<para/>
''' (2) The threshold (delta) is the maximum allowable difference of<para/>
''' the max abs value of | r - g |, | r - b | and | g - b |.<para/>
''' (3) The octcube values are the averages of all pixels that are<para/>
''' found in the octcube, and that are far enough from gray to<para/>
''' be considered color.  This can roughly be visualized as all<para/>
''' the points in the rgb color cube that are not within a "cylinder"<para/>
''' of diameter approximately 'delta' along the main diagonal.<para/>
''' (4) We want to guarantee full coverage of the rgb color space thus,<para/>
''' if the output depth is 4, the octlevel is 1 (2 x 2 x 2 = 8 cubes)<para/>
''' and if the output depth is 8, the octlevel is 2 (4 x 4 x 4<para/>
''' = 64 cubes).<para/>
''' (5) Consequently, we have the following constraint on the number<para/>
''' of allowed gray levels: for 4 bpp, 8 for 8 bpp, 192.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctcubeQuantMixedWithGray/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="depth">[in] - of output pix</param>
'''  <param name="graylevels">[in] - graylevels (must be  is greater  1)</param>
'''  <param name="delta">[in] - threshold for deciding if a pix is color or gray</param>
'''   <returns>pixd     quantized to octcube and gray levels or NULL on error</returns>
Public Shared Function pixOctcubeQuantMixedWithGray(
				 ByVal pixs as Pix, 
				 ByVal depth as Integer, 
				 ByVal graylevels as Integer, 
				 ByVal delta as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctcubeQuantMixedWithGray( pixs.Pointer, depth, graylevels, delta)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (2806, 1)
' pixFixedOctcubeQuant256(pixs, ditherflag) as Pix
' pixFixedOctcubeQuant256(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' This simple 1-pass color quantization works by breaking the<para/>
''' color space into 256 pieces, with 3 bits quantized for each of<para/>
''' red and green, and 2 bits quantized for blue.  We shortchange<para/>
''' blue because the eye is least sensitive to blue.  This<para/>
''' division of the color space is into two levels of octrees,<para/>
''' followed by a further division by 4 not 8, where both<para/>
''' blue octrees have been combined in the third level.<para/>
''' The color map is generated from the 256 color centers by<para/>
''' taking the representative color to be the center of the<para/>
''' cell volume.  This gives a maximum error in the red and<para/>
''' green values of 16 levels, and a maximum error in the<para/>
''' blue sample of 32 levels.<para/>
''' Each pixel in the 24-bit color image is placed in its containing<para/>
''' cell, given by the relevant MSbits of the red, green and blue<para/>
''' samples.  An error-diffusion dithering is performed on each<para/>
''' color sample to give the appearance of good average local color.<para/>
''' Dithering is required without it, the contouring and visible<para/>
''' color errors are very bad.<para/>
''' I originally implemented this algorithm in two passes,<para/>
''' where the first pass was used to compute the weighted average<para/>
''' of each sample in each pre-allocated region of color space.<para/>
''' The idea was to use these centroids in the dithering algorithm<para/>
''' of the second pass, to reduce the average error that was<para/>
''' being dithered.  However, with dithering, there is<para/>
''' virtually no difference, so there is no reason to make the<para/>
''' first pass.  Consequently, this 1-pass version just assigns<para/>
''' the pixels to the centers of the pre-allocated cells.<para/>
''' We use dithering to spread the difference between the sample<para/>
''' value and the location of the center of the cell.  For speed<para/>
''' and simplicity, we use integer dithering and propagate only<para/>
''' to the right, down, and diagonally down-right, with ratios<para/>
''' 3/8, 3/8 and 1/4, respectively.  The results should be nearly<para/>
''' as good, and a bit faster, with propagation only to the right<para/>
''' and down.<para/>
''' The algorithm is very fast, because there is no search,<para/>
''' only fast generation of the cell index for each pixel.<para/>
''' We use a simple mapping from the three 8 bit rgb samples<para/>
''' to the 8 bit cell index namely, r7 r6 r5 g7 g6 g5 b7 b6.<para/>
''' This is not in an octcube format, but it doesn't matter.<para/>
''' There are no storage requirements.  We could keep a<para/>
''' running average of the center of each sample in each<para/>
''' cluster, rather than using the center of the cell, but<para/>
''' this is just extra work, esp. with dithering.<para/>
''' This method gives surprisingly good results with dithering.<para/>
''' However, without dithering, the loss of color accuracy is<para/>
''' evident in regions that are very light or that have subtle<para/>
''' blending of colors.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFixedOctcubeQuant256/*"/>
'''  <param name="pixs">[in] - 32 bpp 24-bit color</param>
'''  <param name="ditherflag">[in] - 1 for dithering 0 for no dithering</param>
'''   <returns>pixd 8 bit with colormap, or NULL on error</returns>
Public Shared Function pixFixedOctcubeQuant256(
				 ByVal pixs as Pix, 
				 ByVal ditherflag as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFixedOctcubeQuant256( pixs.Pointer, ditherflag)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (2940, 1)
' pixFewColorsOctcubeQuant1(pixs, level) as Pix
' pixFewColorsOctcubeQuant1(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a colormapped image, where the colormap table values<para/>
''' are the averages of all pixels that are found in the octcube.<para/>
''' (2) This fails if there are more than 256 colors (i.e., more<para/>
''' than 256 occupied octcubes).<para/>
''' (3) Often level 3 (512 octcubes) will succeed because not more<para/>
''' than half of them are occupied with 1 or more pixels.<para/>
''' (4) The depth of the result, which is either 2, 4 or 8 bpp,<para/>
''' is the minimum required to hold the number of colors that<para/>
''' are found.<para/>
''' (5) This can be useful for quantizing orthographically generated<para/>
''' images such as color maps, where there may be more than 256 colors<para/>
''' because of aliasing or jpeg artifacts on text or lines, but<para/>
''' there are a relatively small number of solid colors.  Then,<para/>
''' use with level = 3 can often generate a compact and accurate<para/>
''' representation of the original RGB image.  For this purpose,<para/>
''' it is better than pixFewColorsOctcubeQuant2(), because it<para/>
''' uses the average value of pixels in the octcube rather<para/>
''' than the first found pixel.  It is also simpler to use,<para/>
''' because it generates the histogram internally.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFewColorsOctcubeQuant1/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - significant bits for each of RGB valid in [1...6]</param>
'''   <returns>pixd quantized to octcube or NULL on error</returns>
Public Shared Function pixFewColorsOctcubeQuant1(
				 ByVal pixs as Pix, 
				 ByVal level as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFewColorsOctcubeQuant1( pixs.Pointer, level)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3110, 1)
' pixFewColorsOctcubeQuant2(pixs, level, na, ncolors, pnerrors) as Pix
' pixFewColorsOctcubeQuant2(PIX *, l_int32, NUMA *, l_int32, l_int32 *) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Generates a colormapped image, where the colormap table values<para/>
''' are the averages of all pixels that are found in the octcube.<para/>
''' (2) This fails if there are more than 256 colors (i.e., more<para/>
''' than 256 occupied octcubes).<para/>
''' (3) Often level 3 (512 octcubes) will succeed because not more<para/>
''' than half of them are occupied with 1 or more pixels.<para/>
''' (4) For an image with not more than 256 colors, it is unlikely<para/>
''' that two pixels of different color will fall in the same<para/>
''' octcube at level = 4. However it is possible, and this<para/>
''' function optionally returns %nerrors, the number of pixels<para/>
''' where, because more than one color is in the same octcube,<para/>
''' the pixel color is not exactly reproduced in the colormap.<para/>
''' The colormap for an occupied leaf of the octree contains<para/>
''' the color of the first pixel encountered in that octcube.<para/>
''' (5) This differs from pixFewColorsOctcubeQuant1(), which also<para/>
''' requires not more than 256 occupied leaves, but represents<para/>
''' the color of each leaf by an average over the pixels in<para/>
''' that leaf.  This also requires precomputing the histogram<para/>
''' of occupied octree leaves, which is generated using<para/>
''' pixOctcubeHistogram().<para/>
''' (6) This is used in pixConvertRGBToColormap() for images that<para/>
''' are determined, by their histogram, to have relatively few<para/>
''' colors.  This typically happens with orthographically<para/>
''' produced images (as oppopsed to natural images), where<para/>
''' it is expected that most of the pixels within a leaf<para/>
''' octcube have exactly the same color, and quantization to<para/>
''' that color is lossless.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFewColorsOctcubeQuant2/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - of octcube indexing, for histogram: 3, 4, 5, 6</param>
'''  <param name="na">[in] - histogram of pixel occupation in octree leaves at given level</param>
'''  <param name="ncolors">[in] - number of occupied octree leaves at given level</param>
'''  <param name="pnerrors">[out][optional] - num of pixels not exactly represented in the colormap</param>
'''   <returns>pixd 2, 4 or 8 bpp with colormap, or NULL on error</returns>
Public Shared Function pixFewColorsOctcubeQuant2(
				 ByVal pixs as Pix, 
				 ByVal level as Integer, 
				 ByVal na as Numa, 
				 ByVal ncolors as Integer, 
				<Out()> Optional ByRef pnerrors as Integer = Nothing) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (na) then Throw New ArgumentNullException  ("na cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFewColorsOctcubeQuant2( pixs.Pointer, level, na.Pointer, ncolors, pnerrors)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3299, 1)
' pixFewColorsOctcubeQuantMixed(pixs, level, darkthresh, lightthresh, diffthresh, minfract, maxspan) as Pix
' pixFewColorsOctcubeQuantMixed(PIX *, l_int32, l_int32, l_int32, l_int32, l_float32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) First runs pixFewColorsOctcubeQuant1().  If this succeeds,<para/>
''' it separates the color from gray(ish) entries in the cmap,<para/>
''' and re-quantizes the gray pixels.  The result has some pixels<para/>
''' in color and others in gray.<para/>
''' (2) This fails if there are more than 256 colors (i.e., more<para/>
''' than 256 occupied octcubes in the color quantization).<para/>
''' (3) Level 3 (512 octcubes) will usually succeed because not more<para/>
''' than half of them are occupied with 1 or more pixels.<para/>
''' (4) This uses the criterion from pixColorFraction() for deciding<para/>
''' if a colormap entry is color namely, if the color components<para/>
''' are not too close to either black or white, and the maximum<para/>
''' difference between component values equals or exceeds a threshold.<para/>
''' (5) For quantizing the gray pixels, it uses a histogram-based<para/>
''' method where input parameters determining the buckets are<para/>
''' the minimum population fraction and the maximum allowed size.<para/>
''' (6) Recommended input parameters are:<para/>
''' %level:  3 or 4  (3 is default)<para/>
''' %darkthresh:  20<para/>
''' %lightthresh: 244<para/>
''' %diffthresh: 20<para/>
''' %minfract: 0.05<para/>
''' %maxspan: 15<para/>
''' These numbers are intended to be conservative (somewhat over-<para/>
''' sensitive) in color detection,  It's usually better to pay<para/>
''' extra with octcube quantization of a grayscale image than<para/>
''' to use grayscale quantization on an image that has some<para/>
''' actual color.  Input 0 on any of these to get the default.<para/>
''' (7) This can be useful for quantizing orthographically generated<para/>
''' images such as color maps, where there may be more than 256 colors<para/>
''' because of aliasing or jpeg artifacts on text or lines, but<para/>
''' there are a relatively small number of solid colors.  It usually<para/>
''' gives results that are better than pixOctcubeQuantMixedWithGray(),<para/>
''' both in size and appearance.  But it is a bit slower.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFewColorsOctcubeQuantMixed/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - significant octcube bits for each of RGB valid in [1...6] use 0 for default</param>
'''  <param name="darkthresh">[in] - threshold near black if the lightest component is below this, the pixel is not considered to be gray or color uses 0 for default</param>
'''  <param name="lightthresh">[in] - threshold near white if the darkest component is above this, the pixel is not considered to be gray or color use 0 for default</param>
'''  <param name="diffthresh">[in] - thresh for the max difference between component values for differences below this, the pixel is considered to be gray use 0 for default</param>
'''  <param name="minfract">[in] - min fraction of pixels for gray histo bin use 0.0 for default</param>
'''  <param name="maxspan">[in] - max size of gray histo bin use 0 for default</param>
'''   <returns>pixd 8 bpp, quantized to octcube for pixels that are not gray gray pixels are quantized separately over the full gray range, or NULL on error</returns>
Public Shared Function pixFewColorsOctcubeQuantMixed(
				 ByVal pixs as Pix, 
				 ByVal level as Integer, 
				 ByVal darkthresh as Integer, 
				 ByVal lightthresh as Integer, 
				 ByVal diffthresh as Integer, 
				 ByVal minfract as Single, 
				 ByVal maxspan as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFewColorsOctcubeQuantMixed( pixs.Pointer, level, darkthresh, lightthresh, diffthresh, minfract, maxspan)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3417, 1)
' pixFixedOctcubeQuantGenRGB(pixs, level) as Pix
' pixFixedOctcubeQuantGenRGB(PIX *, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Unlike the other color quantization functions, this one<para/>
''' generates an rgb image.<para/>
''' (2) The pixel values are quantized to the center of each octcube<para/>
''' (at the specified level) containing the pixel.  They are<para/>
''' not quantized to the average of the pixels in that octcube.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixFixedOctcubeQuantGenRGB/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - significant bits for each of r,g,b</param>
'''   <returns>pixd rgb quantized to octcube centers, or NULL on error</returns>
Public Shared Function pixFixedOctcubeQuantGenRGB(
				 ByVal pixs as Pix, 
				 ByVal level as Integer) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixFixedOctcubeQuantGenRGB( pixs.Pointer, level)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3490, 1)
' pixQuantFromCmap(pixs, cmap, mindepth, level, metric) as Pix
' pixQuantFromCmap(PIX *, PIXCMAP *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is a top-level wrapper for quantizing either grayscale<para/>
''' or rgb images to a specified colormap.<para/>
''' (2) The actual output depth is constrained by %mindepth and<para/>
''' by the number of colors in %cmap.<para/>
''' (3) For grayscale, %level and %metric are ignored.<para/>
''' (4) If the cmap has color and pixs is grayscale, the color is<para/>
''' removed from the cmap before quantizing pixs.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixQuantFromCmap/*"/>
'''  <param name="pixs">[in] - 8 bpp grayscale without cmap, or 32 bpp rgb</param>
'''  <param name="cmap">[in] - to quantize to insert copy into dest pix</param>
'''  <param name="mindepth">[in] - minimum depth of pixd: can be 2, 4 or 8 bpp</param>
'''  <param name="level">[in] - of octcube used for finding nearest color in cmap</param>
'''  <param name="metric">[in] - L_MANHATTAN_DISTANCE, L_EUCLIDEAN_DISTANCE</param>
'''   <returns>pixd  2, 4 or 8 bpp, colormapped, or NULL on error</returns>
Public Shared Function pixQuantFromCmap(
				 ByVal pixs as Pix, 
				 ByVal cmap as PixColormap, 
				 ByVal mindepth as Integer, 
				 ByVal level as Integer, 
				 ByVal metric as Enumerations.L_AN_DISTANCE) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixQuantFromCmap( pixs.Pointer, cmap.Pointer, mindepth, level, metric)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3579, 1)
' pixOctcubeQuantFromCmap(pixs, cmap, mindepth, level, metric) as Pix
' pixOctcubeQuantFromCmap(PIX *, PIXCMAP *, l_int32, l_int32, l_int32) as PIX *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) In typical use, we are doing an operation, such as<para/>
''' interpolative scaling, on a colormapped pix, where it is<para/>
''' necessary to remove the colormap before the operation.<para/>
''' We then want to re-quantize the RGB result using the same<para/>
''' colormap.<para/>
''' (2) The level is used to divide the color space into octcubes.<para/>
''' Each input pixel is, in effect, placed at the center of an<para/>
''' octcube at the given level, and it is mapped into the<para/>
''' exact color (given in the colormap) that is the closest<para/>
''' to that location.  We need to know that distance, for each color<para/>
''' in the colormap.  The higher the level of the octtree, the smaller<para/>
''' the octcubes in the color space, and hence the more accurately<para/>
''' we can determine the closest color in the colormap however,<para/>
''' the size of the LUT, which is the total number of octcubes,<para/>
''' increases by a factor of 8 for each increase of 1 level.<para/>
''' The time required to acquire a level 4 mapping table, which has<para/>
''' about 4K entries, is less than 1 msec, so that is the<para/>
''' recommended minimum size to be used.  At that size, the<para/>
''' octcubes have their centers 16 units apart in each (r,g,b)<para/>
''' direction.  If two colors are in the same octcube, the one<para/>
''' closest to the center will always be chosen.  The maximum<para/>
''' error for any component occurs when the correct color is<para/>
''' at a cube corner and there is an incorrect color just inside<para/>
''' the cube next to the opposite corner, giving an error of<para/>
''' 14 units (out of 256) for each component. Using a level 5<para/>
''' mapping table reduces the maximum error to 6 units.<para/>
''' (3) Typically you should use the Euclidean metric, because the<para/>
''' resulting voronoi cells (which are generated using the actual<para/>
''' colormap values as seeds) are convex for Euclidean distance<para/>
''' but not for Manhattan distance.  In terms of the octcubes,<para/>
''' convexity of the voronoi cells means that if the 8 corners<para/>
''' of any cube (of which the octcubes are special cases)<para/>
''' are all within a cell, then every point in the cube will<para/>
''' lie within the cell.<para/>
''' (4) The depth of the output pixd is equal to the maximum of<para/>
''' (a) %mindepth and (b) the minimum (2, 4 or 8 bpp) necessary<para/>
''' to hold the indices in the colormap.<para/>
''' (5) We build a mapping table from octcube to colormap index so<para/>
''' that this function can run in a time (otherwise) independent<para/>
''' of the number of colors in the colormap.  This avoids a<para/>
''' brute-force search for the closest colormap color to each<para/>
''' pixel in the image.<para/>
''' (6) This is similar to the function pixAssignToNearestColor()<para/>
''' used for color segmentation.<para/>
''' (7) Except for very small images or when using level  is greater  4,<para/>
''' it takes very little time to generate the tables,<para/>
''' compared to the generation of the colormapped dest pix,<para/>
''' so one would not typically use the low-level version.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctcubeQuantFromCmap/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="cmap">[in] - to quantize to insert copy into dest pix</param>
'''  <param name="mindepth">[in] - minimum depth of pixd: can be 2, 4 or 8 bpp</param>
'''  <param name="level">[in] - of octcube used for finding nearest color in cmap</param>
'''  <param name="metric">[in] - L_MANHATTAN_DISTANCE, L_EUCLIDEAN_DISTANCE</param>
'''   <returns>pixd  2, 4 or 8 bpp, colormapped, or NULL on error</returns>
Public Shared Function pixOctcubeQuantFromCmap(
				 ByVal pixs as Pix, 
				 ByVal cmap as PixColormap, 
				 ByVal mindepth as Integer, 
				 ByVal level as Integer, 
				 ByVal metric as Enumerations.L_AN_DISTANCE) as Pix

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctcubeQuantFromCmap( pixs.Pointer, cmap.Pointer, mindepth, level, metric)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Pix(_Result)
End Function

' SRC\colorquant1.c (3729, 1)
' pixOctcubeHistogram(pixs, level, pncolors) as Numa
' pixOctcubeHistogram(PIX *, l_int32, l_int32 *) as NUMA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Input NULL for  and ncolors to prevent computation and return value.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixOctcubeHistogram/*"/>
'''  <param name="pixs">[in] - 32 bpp rgb</param>
'''  <param name="level">[in] - significant bits for each of RGB valid in [1...6]</param>
'''  <param name="pncolors">[out][optional] - number of occupied cubes</param>
'''   <returns>numa histogram of color pixels, or NULL on error</returns>
Public Shared Function pixOctcubeHistogram(
				 ByVal pixs as Pix, 
				 ByVal level as Integer, 
				<Out()> Optional ByRef pncolors as Integer = Nothing) as Numa

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	If {32}.contains (pixs.d) = false then Throw New ArgumentException ("32 bpp rgb")

	Dim _Result as IntPtr = LeptonicaSharp.Natives.pixOctcubeHistogram( pixs.Pointer, level, pncolors)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Numa(_Result)
End Function

' SRC\colorquant1.c (3852, 1)
' pixcmapToOctcubeLUT(cmap, level, metric) as Integer()
' pixcmapToOctcubeLUT(PIXCMAP *, l_int32, l_int32) as l_int32 *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This function is used to quickly find the colormap color<para/>
''' that is closest to any rgb color.  It is used to assign<para/>
''' rgb colors to an existing colormap.  It can be very expensive<para/>
''' to search through the entire colormap for the closest color<para/>
''' to each pixel.  Instead, we first set up this table, which is<para/>
''' populated by the colormap index nearest to each octcube<para/>
''' color.  Then we go through the image for each pixel,<para/>
''' do two table lookups: first to generate the octcube index<para/>
''' from rgb and second to use this table to read out the<para/>
''' colormap index.<para/>
''' (2) Do a slight modification for white and black.  For level = 4,<para/>
''' each octcube size is 16.  The center of the whitest octcube<para/>
''' is at (248, 248, 248), which is closer to 242 than 255.<para/>
''' Consequently, any gray color between 242 and 254 will<para/>
''' be selected, even if white (255, 255, 255) exists.  This is<para/>
''' typically not optimal, because the original color was<para/>
''' likely white.  Therefore, if white exists in the colormap,<para/>
''' use it for any rgb color that falls into the most white octcube.<para/>
''' Do the similar thing for black.<para/>
''' (3) Here are the actual function calls for quantizing to a<para/>
''' specified colormap:<para/>
''' ~ first make the tables that map from rgb -- is greater  octcube index<para/>
''' makeRGBToIndexTables()<para/>
''' ~ then for each pixel:<para/>
''' use the tables to get the octcube index<para/>
''' getOctcubeIndexFromRGB()<para/>
''' use this table to get the nearest color in the colormap<para/>
''' cmap_index = tab[index]<para/>
''' (4) Distance can be either manhattan or euclidean.<para/>
''' (5) In typical use, level = 4 gives reasonable results, and<para/>
''' level = 5 is slightly better.  When this function is used<para/>
''' for color segmentation, there are typically a small number<para/>
''' of colors and the number of levels can be small (e.g., level = 3).<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixcmapToOctcubeLUT/*"/>
'''  <param name="cmap">[in] - </param>
'''  <param name="level">[in] - significant bits for each of RGB valid in [1...6]</param>
'''  <param name="metric">[in] - L_MANHATTAN_DISTANCE, L_EUCLIDEAN_DISTANCE</param>
'''   <returns>tab[23  level]</returns>
Public Shared Function pixcmapToOctcubeLUT(
				 ByVal cmap as PixColormap, 
				 ByVal level as Integer, 
				 ByVal metric as Enumerations.L_AN_DISTANCE) as Integer()

	If IsNothing (cmap) then Throw New ArgumentNullException  ("cmap cannot be Nothing")

	Dim _Result as Integer() = LeptonicaSharp.Natives.pixcmapToOctcubeLUT( cmap.Pointer, level, metric)

	Return _Result
End Function

' SRC\colorquant1.c (3938, 1)
' pixRemoveUnusedColors(pixs) as Integer
' pixRemoveUnusedColors(PIX *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This is an in-place operation.<para/>
''' (2) If the image doesn't have a colormap, returns without error.<para/>
''' (3) Unusued colors are removed from the colormap, and the<para/>
''' image pixels are re-numbered.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixRemoveUnusedColors/*"/>
'''  <param name="pixs">[in] - colormapped</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixRemoveUnusedColors(
				 ByVal pixs as Pix) as Integer

	If IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixRemoveUnusedColors( pixs.Pointer)

	Return _Result
End Function

' SRC\colorquant1.c (4084, 1)
' pixNumberOccupiedOctcubes(pix, level, mincount, minfract, pncolors) as Integer
' pixNumberOccupiedOctcubes(PIX *, l_int32, l_int32, l_float32, l_int32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) Exactly one of (%mincount, %minfract) must be -1, so, e.g.,<para/>
''' if %mincount == -1, then we use %minfract.<para/>
''' (2) If all occupied octcubes are to count, set %mincount == 1.<para/>
''' Setting %minfract == 0.0 is taken to mean the same thing.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="IncludeComments.xml" path="Comments/pixNumberOccupiedOctcubes/*"/>
'''  <param name="pix">[in] - 32 bpp</param>
'''  <param name="level">[in] - of octcube</param>
'''  <param name="mincount">[in] - minimum num pixels in an octcube to be counted -1 to not use</param>
'''  <param name="minfract">[in] - minimum fract of pixels in an octcube to be counted -1 to not use</param>
'''  <param name="pncolors">[out] - number of occupied octcubes</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixNumberOccupiedOctcubes(
				 ByVal pix as Pix, 
				 ByVal level as Integer, 
				 ByVal mincount as Integer, 
				 ByVal minfract as Single, 
				<Out()> ByRef pncolors as Integer) as Integer

	If IsNothing (pix) then Throw New ArgumentNullException  ("pix cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixNumberOccupiedOctcubes( pix.Pointer, level, mincount, minfract, pncolors)

	Return _Result
End Function

End Class

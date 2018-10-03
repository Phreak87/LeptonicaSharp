Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\partition.c (189, 1)
' boxaGetWhiteblocks()
' boxaGetWhiteblocks(BOXA *, BOX *, l_int32, l_int32, l_float32, l_int32, l_float32, l_int32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This uses the elegant Breuel algorithm, found in "Two<para/>
''' Geometric Algorithms for Layout Analysis", 2002,<para/>
''' url: "citeseer.ist.psu.edu/breuel02two.html".<para/>
''' It starts with the bounding boxes (b.b.) of the connected<para/>
''' components (c.c.) in a region, along with the rectangle<para/>
''' representing that region.  It repeatedly divides the<para/>
''' rectangle into four maximal rectangles that exclude a<para/>
''' pivot rectangle, sorting them in a priority queue<para/>
''' according to one of the six sort flags.  It returns a boxa<para/>
''' of the "largest" set that have no intersection with boxes<para/>
''' from the input boxas.<para/>
''' (2) If box == NULL, the initial region is the minimal region<para/>
''' that includes the origin and every box in boxas.<para/>
''' (3) maxboxes is the maximum number of whitespace boxes that will<para/>
''' be returned.  The actual number will depend on the image<para/>
''' and the values chosen for maxoverlap and maxpops.  In many<para/>
''' cases, the actual number will be 'maxboxes'.<para/>
''' (4) maxoverlap allows pruning of whitespace boxes depending on<para/>
''' the overlap.  To avoid all pruning, use maxoverlap = 1.0.<para/>
''' To select only boxes that have no overlap with each other<para/>
''' (maximal pruning), choose maxoverlap = 0.0.<para/>
''' Otherwise, no box can have more than the 'maxoverlap' fraction<para/>
''' of its area overlapped by any larger (in the sense of the<para/>
''' sortflag) box.<para/>
''' (5) Choose maxperim (actually, maximum half-perimeter) to<para/>
''' represent a c.c. that is small enough so that you don't care<para/>
''' about the white space that could be inside of it.  For all such<para/>
''' c.c., the pivot for 'quadfurcation' of a rectangle is selected<para/>
''' as having a reasonable proximity to the rectangle centroid.<para/>
''' (6) Use fract in the range [0.0 ... 1.0].  Set fract = 0.0<para/>
''' to choose the small box nearest the centroid as the pivot.<para/>
''' If you choose fract  is greater  0.0, it is suggested that you call<para/>
''' boxaPermuteRandom() first, to permute the boxes (see usage below).<para/>
''' This should reduce the search time for each of the pivot boxes.<para/>
''' (7) Choose maxpops to be the maximum number of rectangles that<para/>
''' are popped from the heap.  This is an indirect way to limit the<para/>
''' execution time.  Use 0 for default (a fairly large number).<para/>
''' At any time, you can expect the heap to contain about<para/>
''' 2.5 times as many boxes as have been popped off.<para/>
''' (8) The output result is a sorted set of overlapping<para/>
''' boxes, constrained by 'maxboxes', 'maxoverlap' and 'maxpops'.<para/>
''' (9) The main defect of the method is that it abstracts out the<para/>
''' actual components, retaining only the b.b. for analysis.<para/>
''' Consider a component with a large b.b.  If this is chosen<para/>
''' as a pivot, all white space inside is immediately taken<para/>
''' out of consideration.  Furthermore, even if it is never chosen<para/>
''' as a pivot, as the partitioning continues, at no time will<para/>
''' any of the whitespace inside this component be part of a<para/>
''' rectangle with zero overlapping boxes.  Thus, the interiors<para/>
''' of all boxes are necessarily excluded from the union of<para/>
''' the returned whitespace boxes.<para/>
''' (10) It should be noted that the algorithm puts a large number<para/>
''' of partels on the queue.  Setting a limit of X partels to<para/>
''' remove from the queue, one typically finds that there will be<para/>
''' several times that number (say, 2X - 3X) left on the queue.<para/>
''' For an efficient algorithm to find the largest white or<para/>
''' or black rectangles, without permitting them to overlap,<para/>
''' see pixFindLargeRectangles().<para/>
''' (11) USAGE: One way to accommodate to this weakness is to remove such<para/>
''' large b.b. before starting the computation.  For example,<para/>
''' if 'box' is an input image region containing 'boxa' b.b. of c.c.:<para/>
''' // Faster pivot choosing<para/>
''' boxaPermuteRandom(boxa, boxa)<para/>
''' // Remove anything either large width or height<para/>
''' boxat = boxaSelectBySize(boxa, maxwidth, maxheight,<para/>
''' L_SELECT_IF_BOTH, L_SELECT_IF_LT,<para/>
''' NULL)<para/>
''' boxad = boxaGetWhiteblocks(boxat, box, type, maxboxes,<para/>
''' maxoverlap, maxperim, fract,<para/>
''' maxpops)<para/>
''' The result will be rectangular regions of "white space" that<para/>
''' extend into (and often through) the excluded components.<para/>
''' (11) As a simple example, suppose you wish to find the columns on a page.<para/>
''' First exclude large c.c. that may block the columns, and then call:<para/>
''' boxad = boxaGetWhiteblocks(boxa, box, L_SORT_BY_HEIGHT,<para/>
''' 20, 0.15, 200, 0.2, 2000)<para/>
''' to get the 20 tallest boxes with no more than 0.15 overlap<para/>
''' between a box and any of the taller ones, and avoiding the<para/>
''' use of any c.c. with a b.b. half perimeter greater than 200<para/>
''' as a pivot.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - typically, a set of bounding boxes of fg components</param>
'''  <param name="box">[in] - initial region typically including all boxes in boxas if null, it computes the region to include all boxes in boxas</param>
'''  <param name="sortflag">[in] - L_SORT_BY_WIDTH, L_SORT_BY_HEIGHT, L_SORT_BY_MIN_DIMENSION, L_SORT_BY_MAX_DIMENSION, L_SORT_BY_PERIMETER, L_SORT_BY_AREA</param>
'''  <param name="maxboxes">[in] - maximum number of output whitespace boxes e.g., 100</param>
'''  <param name="maxoverlap">[in] - maximum fractional overlap of a box by any of the larger boxes e.g., 0.2</param>
'''  <param name="maxperim">[in] - maximum half-perimeter, in pixels, for which pivot is selected by proximity to box centroid e.g., 200</param>
'''  <param name="fract">[in] - fraction of box diagonal that is an acceptable distance from the box centroid to select the pivot e.g., 0.2</param>
'''  <param name="maxpops">[in] - maximum number of pops from the heap use 0 as default</param>
'''   <returns>boxa of sorted whitespace boxes, or NULL on error</returns>
Public Shared Function boxaGetWhiteblocks(
				ByVal boxas as Boxa, 
				ByVal box as Box, 
				ByVal sortflag as Enumerations.L_SORT_BY, 
				ByVal maxboxes as Integer, 
				ByVal maxoverlap as Single, 
				ByVal maxperim as Integer, 
				ByVal fract as Single, 
				ByVal maxpops as Integer) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (box) then Throw New ArgumentNullException  ("box cannot be Nothing")
	If IsNothing (maxoverlap) then Throw New ArgumentNullException  ("maxoverlap cannot be Nothing")
	If IsNothing (fract) then Throw New ArgumentNullException  ("fract cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaGetWhiteblocks( boxas.Pointer, box.Pointer, sortflag, maxboxes, maxoverlap, maxperim, fract, maxpops)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

' SRC\partition.c (621, 1)
' boxaPruneSortedOnOverlap()
' boxaPruneSortedOnOverlap(BOXA *, l_float32) as BOXA *
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This selectively removes smaller boxes when they are overlapped<para/>
''' by any larger box by more than the input 'maxoverlap' fraction.<para/>
''' (2) To avoid all pruning, use maxoverlap = 1.0.  To select only<para/>
''' boxes that have no overlap with each other (maximal pruning),<para/>
''' set maxoverlap = 0.0.<para/>
''' (3) If there are no boxes in boxas, returns an empty boxa.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="boxas">[in] - sorted by size in decreasing order</param>
'''  <param name="maxoverlap">[in] - maximum fractional overlap of a box by any of the larger boxes</param>
'''   <returns>boxad pruned, or NULL on error</returns>
Public Shared Function boxaPruneSortedOnOverlap(
				ByVal boxas as Boxa, 
				ByVal maxoverlap as Single) as Boxa

	If IsNothing (boxas) then Throw New ArgumentNullException  ("boxas cannot be Nothing")
	If IsNothing (maxoverlap) then Throw New ArgumentNullException  ("maxoverlap cannot be Nothing")


	Dim _Result as IntPtr = LeptonicaSharp.Natives.boxaPruneSortedOnOverlap( boxas.Pointer, maxoverlap)
	If  _Result = IntPtr.Zero then Return Nothing

	Return  new Boxa(_Result)
End Function

End Class

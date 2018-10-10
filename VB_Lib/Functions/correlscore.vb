Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\correlscore.c (125, 1)
' pixCorrelationScore(pix1, pix2, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, pscore) as Integer
' pixCorrelationScore(PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_int32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' We check first that the two pix are roughly the same size.<para/>
''' For jbclass (jbig2) applications at roughly 300 ppi, maxdiffw and<para/>
''' maxdiffh should be at least 2.<para/>
''' Only if they meet that criterion do we compare the bitmaps.<para/>
''' The centroid difference is used to align the two images to the<para/>
''' nearest integer for the correlation.<para/>
''' The correlation score is the ratio of the square of the number of<para/>
''' pixels in the AND of the two bitmaps to the product of the number<para/>
''' of ON pixels in each.  Denote the number of ON pixels in pix1<para/>
''' by |1|, the number in pix2 by |2|, and the number in the AND<para/>
''' of pix1 and pix2 by |1  and  2|.  The correlation score is then<para/>
''' (|1  and  2|)2 / (|1||2|).<para/>
''' This score is compared with an input threshold, which can<para/>
''' be modified depending on the weight of the template.<para/>
''' The modified threshold is<para/>
''' thresh + (1.0 - thresh)  weight  R<para/>
''' where<para/>
''' weight is a fixed input factor between 0.0 and 1.0<para/>
''' R = |2| / area(2)<para/>
''' and area(2) is the total number of pixels in 2 (i.e., width x height).<para/>
''' To understand why a weight factor is useful, consider what happens<para/>
''' with thick, sans-serif characters that look similar and have a value<para/>
''' of R near 1.  Different characters can have a high correlation value,<para/>
''' and the classifier will make incorrect substitutions.  The weight<para/>
''' factor raises the threshold for these characters.<para/>
''' Yet another approach to reduce such substitutions is to run the classifier<para/>
''' in a non-greedy way, matching to the template with the highest<para/>
''' score, not the first template with a score satisfying the matching<para/>
''' constraint.  However, this is not particularly effective.<para/>
''' The implementation here gives the same result as in<para/>
''' pixCorrelationScoreSimple(), where a temporary Pix is made to hold<para/>
''' the AND and implementation uses rasterop:<para/>
''' pixt = pixCreateTemplate(pix1)<para/>
''' pixRasterop(pixt, idelx, idely, wt, ht, PIX_SRC, pix2, 0, 0)<para/>
''' pixRasterop(pixt, 0, 0, wi, hi, PIX_SRC  and  PIX_DST, pix1, 0, 0)<para/>
''' pixCountPixels(pixt,  and count, tab)<para/>
''' pixDestroy( and pixt)<para/>
''' However, here it is done in a streaming fashion, counting as it goes,<para/>
''' and touching memory exactly once, giving a 3-4x speedup over the<para/>
''' simple implementation.  This very fast correlation matcher was<para/>
''' contributed by William Rucklidge.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - test pix, 1 bpp</param>
'''  <param name="pix2">[in] - exemplar pix, 1 bpp</param>
'''  <param name="area1">[in] - number of on pixels in pix1</param>
'''  <param name="area2">[in] - number of on pixels in pix2</param>
'''  <param name="delx">[in] - x comp of centroid difference</param>
'''  <param name="dely">[in] - y comp of centroid difference</param>
'''  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
'''  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
'''  <param name="tab">[in] - sum tab for byte</param>
'''  <param name="pscore">[out] - correlation score</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCorrelationScore(
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal area1 as Integer, 
				 ByVal area2 as Integer, 
				 ByVal delx as Single, 
				 ByVal dely as Single, 
				 ByVal maxdiffw as Integer, 
				 ByVal maxdiffh as Integer, 
				 ByVal tab as Integer(), 
				<Out()> ByRef pscore as Single) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCorrelationScore( pix1.Pointer, pix2.Pointer, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, pscore)

	Return _Result
End Function

' SRC\correlscore.c (423, 1)
' pixCorrelationScoreThresholded(pix1, pix2, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, downcount, score_threshold) as Integer
' pixCorrelationScoreThresholded(PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_int32 *, l_int32 *, l_float32) as l_int32
'''  <summary>
''' <para/>
''' Notes:<para/>
''' We check first that the two pix are roughly the same size.<para/>
''' Only if they meet that criterion do we compare the bitmaps.<para/>
''' The centroid difference is used to align the two images to the<para/>
''' nearest integer for the correlation.<para/>
''' The correlation score is the ratio of the square of the number of<para/>
''' pixels in the AND of the two bitmaps to the product of the number<para/>
''' of ON pixels in each.  Denote the number of ON pixels in pix1<para/>
''' by |1|, the number in pix2 by |2|, and the number in the AND<para/>
''' of pix1 and pix2 by |1  and  2|.  The correlation score is then<para/>
''' (|1  and  2|)2 / (|1||2|).<para/>
''' This score is compared with an input threshold, which can<para/>
''' be modified depending on the weight of the template.<para/>
''' The modified threshold is<para/>
''' thresh + (1.0 - thresh)  weight  R<para/>
''' where<para/>
''' weight is a fixed input factor between 0.0 and 1.0<para/>
''' R = |2| / area(2)<para/>
''' and area(2) is the total number of pixels in 2 (i.e., width x height).<para/>
''' To understand why a weight factor is useful, consider what happens<para/>
''' with thick, sans-serif characters that look similar and have a value<para/>
''' of R near 1.  Different characters can have a high correlation value,<para/>
''' and the classifier will make incorrect substitutions.  The weight<para/>
''' factor raises the threshold for these characters.<para/>
''' Yet another approach to reduce such substitutions is to run the classifier<para/>
''' in a non-greedy way, matching to the template with the highest<para/>
''' score, not the first template with a score satisfying the matching<para/>
''' constraint.  However, this is not particularly effective.<para/>
''' This very fast correlation matcher was contributed by William Rucklidge.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - test pix, 1 bpp</param>
'''  <param name="pix2">[in] - exemplar pix, 1 bpp</param>
'''  <param name="area1">[in] - number of on pixels in pix1</param>
'''  <param name="area2">[in] - number of on pixels in pix2</param>
'''  <param name="delx">[in] - x comp of centroid difference</param>
'''  <param name="dely">[in] - y comp of centroid difference</param>
'''  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
'''  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
'''  <param name="tab">[in] - sum tab for byte</param>
'''  <param name="downcount">[in] - count of 1 pixels below each row of pix1</param>
'''  <param name="score_threshold">[in] - </param>
'''   <returns>whether the correlation score is  is greater = score_threshold</returns>
Public Shared Function pixCorrelationScoreThresholded(
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal area1 as Integer, 
				 ByVal area2 as Integer, 
				 ByVal delx as Single, 
				 ByVal dely as Single, 
				 ByVal maxdiffw as Integer, 
				 ByVal maxdiffh as Integer, 
				 ByVal tab as Integer(), 
				 ByVal downcount as Integer(), 
				 ByVal score_threshold as Single) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")
	If IsNothing (downcount) then Throw New ArgumentNullException  ("downcount cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCorrelationScoreThresholded( pix1.Pointer, pix2.Pointer, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, downcount, score_threshold)

	Return _Result
End Function

' SRC\correlscore.c (732, 1)
' pixCorrelationScoreSimple(pix1, pix2, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, pscore) as Integer
' pixCorrelationScoreSimple(PIX *, PIX *, l_int32, l_int32, l_float32, l_float32, l_int32, l_int32, l_int32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This calculates exactly the same value as pixCorrelationScore().<para/>
''' It is 2-3x slower, but much simpler to understand.<para/>
''' (2) The returned correlation score is 0.0 if the width or height<para/>
''' exceed %maxdiffw or %maxdiffh.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - test pix, 1 bpp</param>
'''  <param name="pix2">[in] - exemplar pix, 1 bpp</param>
'''  <param name="area1">[in] - number of on pixels in pix1</param>
'''  <param name="area2">[in] - number of on pixels in pix2</param>
'''  <param name="delx">[in] - x comp of centroid difference</param>
'''  <param name="dely">[in] - y comp of centroid difference</param>
'''  <param name="maxdiffw">[in] - max width difference of pix1 and pix2</param>
'''  <param name="maxdiffh">[in] - max height difference of pix1 and pix2</param>
'''  <param name="tab">[in] - sum tab for byte</param>
'''  <param name="pscore">[out] - correlation score, in range [0.0 ... 1.0]</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCorrelationScoreSimple(
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal area1 as Integer, 
				 ByVal area2 as Integer, 
				 ByVal delx as Single, 
				 ByVal dely as Single, 
				 ByVal maxdiffw as Integer, 
				 ByVal maxdiffh as Integer, 
				 ByVal tab as Integer(), 
				<Out()> ByRef pscore as Single) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCorrelationScoreSimple( pix1.Pointer, pix2.Pointer, area1, area2, delx, dely, maxdiffw, maxdiffh, tab, pscore)

	Return _Result
End Function

' SRC\correlscore.c (835, 1)
' pixCorrelationScoreShifted(pix1, pix2, area1, area2, delx, dely, tab, pscore) as Integer
' pixCorrelationScoreShifted(PIX *, PIX *, l_int32, l_int32, l_int32, l_int32, l_int32 *, l_float32 *) as l_ok
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This finds the correlation between two 1 bpp images,<para/>
''' when pix2 is shifted by (delx, dely) with respect<para/>
''' to each other.<para/>
''' (2) This is implemented by starting with a copy of pix1 and<para/>
''' ANDing its pixels with those of a shifted pix2.<para/>
''' (3) Get the pixel counts for area1 and area2 using piCountPixels().<para/>
''' (4) A good estimate for a shift that would maximize the correlation<para/>
''' is to align the centroids (cx1, cy1 cx2, cy2), giving the<para/>
''' relative translations etransx and etransy:<para/>
''' etransx = cx1 - cx2<para/>
''' etransy = cy1 - cy2<para/>
''' Typically delx is chosen to be near etransx ditto for dely.<para/>
''' This function is used in pixBestCorrelation(), where the<para/>
''' translations delx and dely are varied to find the best alignment.<para/>
''' (5) We do not check the sizes of pix1 and pix2, because they should<para/>
''' be comparable.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="pix1">[in] - 1 bpp</param>
'''  <param name="pix2">[in] - 1 bpp</param>
'''  <param name="area1">[in] - number of on pixels in pix1</param>
'''  <param name="area2">[in] - number of on pixels in pix2</param>
'''  <param name="delx">[in] - x translation of pix2 relative to pix1</param>
'''  <param name="dely">[in] - y translation of pix2 relative to pix1</param>
'''  <param name="tab">[in] - sum tab for byte</param>
'''  <param name="pscore">[out] - correlation score</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function pixCorrelationScoreShifted(
				 ByVal pix1 as Pix, 
				 ByVal pix2 as Pix, 
				 ByVal area1 as Integer, 
				 ByVal area2 as Integer, 
				 ByVal delx as Integer, 
				 ByVal dely as Integer, 
				 ByVal tab as Integer(), 
				<Out()> ByRef pscore as Single) as Integer

	If IsNothing (pix1) then Throw New ArgumentNullException  ("pix1 cannot be Nothing")
	If IsNothing (pix2) then Throw New ArgumentNullException  ("pix2 cannot be Nothing")
	If IsNothing (tab) then Throw New ArgumentNullException  ("tab cannot be Nothing")

	If {1}.contains (pix1.d) = false then Throw New ArgumentException ("1 bpp")
	If {1}.contains (pix2.d) = false then Throw New ArgumentException ("1 bpp")

	Dim _Result as Integer = LeptonicaSharp.Natives.pixCorrelationScoreShifted( pix1.Pointer, pix2.Pointer, area1, area2, delx, dely, tab, pscore)

	Return _Result
End Function

End Class

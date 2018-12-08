using System;
using System.IO;
using Enumerations;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeptonicaSharp
{
	public partial class _All
	{

		// maze.c (142, 1)
		// generateBinaryMaze(w, h, xi, yi, wallps, ranis) as Pix
		// generateBinaryMaze(l_int32, l_int32, l_int32, l_int32, l_float32, l_float32) as PIX *
		///  <summary>
		/// (1) We have two input probability factors that determine the
		/// density of walls and average length of straight passages.
		/// When ranis  is smaller 1.0, you are more likely to generate a wall
		/// to the side than going forward.  Enter 0.0 for either if
		/// you want to use the default values.<para/>
		///
		/// (2) This is a type of percolation problem, and exhibits
		/// different phases for different parameters wallps and ranis.
		/// For larger values of these parameters, regions in the maze
		/// are not explored because the maze generator walls them
		/// off and cannot get through.  The boundary between the
		/// two phases in this two-dimensional parameter space goes
		/// near these values:
		/// wallps ranis
		/// 0.35 1.00
		/// 0.40 0.85
		/// 0.45 0.70
		/// 0.50 0.50
		/// 0.55 0.40
		/// 0.60 0.30
		/// 0.65 0.25
		/// 0.70 0.19
		/// 0.75 0.15
		/// 0.80 0.11<para/>
		///
		/// (3) Because there is a considerable amount of overhead in calling
		/// pixGetPixel() and pixSetPixel(), this function can be sped
		/// up with little effort using raster line pointers and the
		/// GET_DATA and SET_DATA macros.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/generateBinaryMaze/*"/>
		///  <param name="w">[in] - size of maze</param>
		///  <param name="h">[in] - size of maze</param>
		///  <param name="xi">[in] - initial location</param>
		///  <param name="yi">[in] - initial location</param>
		///  <param name="wallps">[in] - probability that a pixel to the side is ON</param>
		///  <param name="ranis">[in] - ratio of prob that pixel in forward direction is a wall to the probability that pixel in side directions is a wall</param>
		///   <returns>pix, or NULL on error</returns>
		public static Pix generateBinaryMaze(
						int w,
						int h,
						int xi,
						int yi,
						Single wallps,
						Single ranis)
		{
			IntPtr _Result = Natives.generateBinaryMaze(  w,   h,   xi,   yi,   wallps,   ranis);

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pix(_Result);
		}

		// maze.c (339, 1)
		// pixSearchBinaryMaze(pixs, xi, yi, xf, yf, ppixd) as Pta
		// pixSearchBinaryMaze(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **) as PTA *
		///  <summary>
		/// (1) Because of the overhead in calling pixGetPixel() and
		/// pixSetPixel(), we have used raster line pointers and the
		/// GET_DATA and SET_DATA macros for many of the pix accesses.<para/>
		///
		/// (2) Commentary:
		/// The goal is to find the shortest path between beginning and
		/// end points, without going through walls, and there are many
		/// ways to solve this problem.
		/// We use a queue to implement a breadth-first search.  Two auxiliary
		/// "image" data structures can be used: one to mark the visited
		/// pixels and one to give the direction to the parent for each
		/// visited pixel.  The first structure is used to avoid putting
		/// pixels on the queue more than once, and the second is used
		/// for retracing back to the origin, like the breadcrumbs in
		/// Hansel and Gretel.  Each pixel taken off the queue is destroyed
		/// after it is used to locate the allowed neighbors.  In fact,
		/// only one distance image is required, if you initialize it
		/// to some value that signifies "not yet visited."  (We use
		/// a binary image for marking visited pixels because it is clearer.)
		/// This method for a simple search of a binary maze is implemented in
		/// pixSearchBinaryMaze().
		/// An alternative method would store the (manhattan) distance
		/// from the start point with each pixel on the queue.  The children
		/// of each pixel get a distance one larger than the parent.  These
		/// values can be stored in an auxiliary distance map image
		/// that is constructed simultaneously with the search.  Once the
		/// end point is reached, the distance map is used to backtrack
		/// along a minimum path.  There may be several equal length
		/// minimum paths, any one of which can be chosen this way.
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSearchBinaryMaze/*"/>
		///  <param name="pixs">[in] - 1 bpp, maze</param>
		///  <param name="xi">[in] - beginning point use same initial point that was used to generate the maze</param>
		///  <param name="yi">[in] - beginning point use same initial point that was used to generate the maze</param>
		///  <param name="xf">[in] - end point, or close to it</param>
		///  <param name="yf">[in] - end point, or close to it</param>
		///  <param name="ppixd">[out][optional] - maze with path illustrated, or if no path possible, the part of the maze that was searched</param>
		///   <returns>pta shortest path, or NULL if either no path exists or on error</returns>
		public static Pta pixSearchBinaryMaze(
						Pix pixs,
						int xi,
						int yi,
						int xf,
						int yf,
						out Pix ppixd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr ppixdPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixSearchBinaryMaze(pixs.Pointer,   xi,   yi,   xf,   yf, out ppixdPtr);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}

		// maze.c (723, 1)
		// pixSearchGrayMaze(pixs, xi, yi, xf, yf, ppixd) as Pta
		// pixSearchGrayMaze(PIX *, l_int32, l_int32, l_int32, l_int32, PIX **) as PTA *
		///  <summary>
		/// pixSearchGrayMaze()
		///  </summary>
		///  <remarks>
		///  </remarks>
		///  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/pixSearchGrayMaze/*"/>
		///  <param name="pixs">[in] - 1 bpp, maze</param>
		///  <param name="xi">[in] - beginning point use same initial point that was used to generate the maze</param>
		///  <param name="yi">[in] - beginning point use same initial point that was used to generate the maze</param>
		///  <param name="xf">[in] - end point, or close to it</param>
		///  <param name="yf">[in] - end point, or close to it</param>
		///  <param name="ppixd">[out][optional] - maze with path illustrated, or if no path possible, the part of the maze that was searched</param>
		///   <returns>pta shortest path, or NULL if either no path exists or on error Commentary: Consider first a slight generalization of the binary maze search problem.  Suppose that you can go through walls, but the cost is higher say, an increment of 3 to go into a wall pixel rather than 1?  You're still trying to find the shortest path.  One way to do this is with an ordered queue, and a simple way to visualize an ordered queue is as a set of stacks, each stack being marked with the distance of each pixel in the stack from the start.  We place the start pixel in stack 0, pop it, and process its 4 children. Each pixel is given a distance that is incremented from that of its parent 0 in this case, depending on if it is a wall pixel or not.  That value may be recorded on a distance map, according to the algorithm below.  For children of the first pixel, those not on a wall go in stack 1, and wall children go in stack 3.  Stack 0 being emptied, the process then continues with pixels being popped from stack 1. Here is the algorithm for each child pixel.  The pixel's distance value, were it to be placed on a stack, is compared with the value for it that is on the distance map.  There are three possible cases: 1 If the pixel has not yet been registered, it is pushed on its stack and the distance is written to the map. 2 If it has previously been registered with a higher distance, the distance on the map is relaxed to that of the current pixel, which is then placed on its stack. 3 If it has previously been registered with an equal or lower value, the pixel is discarded. The pixels are popped and processed successively from stack 1, and when stack 1 is empty, popping starts on stack 2. This continues until the destination pixel is popped off a stack.   The minimum path is then derived from the distance map, going back from the end point as before.  This is just Dijkstra's algorithm for a directed graph here, the underlying graph consisting of the pixels and four edges connecting each pixel to its 4-neighbor is a special case of a directed graph, where each edge is bi-directional.  The implementation of this generalized maze search is left as an exercise to the reader. Let's generalize a bit further.  Suppose the "maze" is just a grayscale image -- think of it as an elevation map.  The cost of moving on this surface depends on the height, or the gradient, or whatever you want.  All that is required is that the cost is specified and non-negative on each link between adjacent pixels.  Now the problem becomes: find the least cost path moving on this surface between two specified end points. For example, if the cost across an edge between two pixels depends on the "gradient", you can use: cost = 1 + L_ABSdeltaV where deltaV is the difference in value between two adjacent pixels.  If the costs are all integers, we can still use an array of stacks to avoid ordering the queue e.g., by using a heap sort. This is a neat problem, because you don't even have to build a maze -- you can can use it on any grayscale image! Rather than using an array of stacks, a more practical approach is to implement with a priority queue, which is a queue that is sorted so that the elements with the largest or smallest key values always come off first.  The priority queue is efficiently implemented as a heap, and this is how we do it.  Suppose you run the algorithm using a priority queue, doing the bookkeeping with an auxiliary image data structure that saves the distance of each pixel put on the queue as before, according to the method described above.  We implement it as a 2-way choice by initializing the distance array to a large value and putting a pixel on the queue if its distance is less than the value found on the array.  When you finally pop the end pixel from the queue, you're done, and you can trace the path backward, either always going downhill or using an auxiliary image to give you the direction to go at each step.  This is implemented here in searchGrayMaze. Do we really have to use a sorted queue?  Can we solve this generalized maze with an unsorted queue of pixels?  Or even an unsorted stack, doing a depth-first search (DFS)? Consider a different algorithm for this generalized maze, where we travel again breadth first, but this time use a single, unsorted queue.  An auxiliary image is used as before to store the distances and to determine if pixels get pushed on the stack or dropped.  As before, we must allow pixels to be revisited, with relaxation of the distance if a shorter path arrives later.  As a result, we will in general have multiple instances of the same pixel on the stack with different distances.  However, because the queue is not ordered, some of these pixels will be popped when another instance with a lower distance is still on the stack.  Here, we're just popping them in the order they go on, rather than setting up a priority based on minimum distance.  Thus, unlike the priority queue, when a pixel is popped we have to check the distance map to see if a pixel with a lower distance has been put on the queue, and, if so, we discard the pixel we just popped.  So the "while" loop looks like this: ~ pop a pixel from the queue ~ check its distance against the distance stored in the distance map if larger, discard ~ otherwise, for each of its neighbors: ~ compute its distance from the start pixel ~ compare this distance with that on the distance map: ~ if the distance map value higher, relax the distance and push the pixel on the queue ~ if the distance map value is lower, discard the pixel How does this loop terminate?  Before, with an ordered queue, it terminates when you pop the end pixel.  But with an unordered queue or stack, the first time you hit the end pixel, the distance is not guaranteed to be correct, because the pixels along the shortest path may not have yet been visited and relaxed. Because the shortest path can theoretically go anywhere, we must keep going.  How do we know when to stop?   Dijkstra uses an ordered queue to systematically remove nodes from further consideration.  Each time a pixel is popped, we're done with it it's "finalized" in the Dijkstra sense because we know the shortest path to it.  However, with an unordered queue, the brute force answer is: stop when the queue or stack is empty, because then every pixel in the image has been assigned its minimum "distance" from the start pixel. This is similar to the situation when you use a stack for the simpler uniform-step problem: with breadth-first search BFS the pixels on the queue are automatically ordered, so you are done when you locate the end pixel as a neighbor of a popped pixel whereas depth-first search DFS, using a stack, requires, in general, a search of every accessible pixel.  Further, if a pixel is revisited with a smaller distance, that distance is recorded and the pixel is put on the stack again. But surely, you ask, can't we stop sooner?  What if the start and end pixels are very close to each other? OK, suppose they are, and you have very high walls and a long snaking level path that is actually the minimum cost. That long path can wind back and forth across the entire maze many times before ending up at the end point, which could be just over a wall from the start.  With the unordered queue, you very quickly get a high distance for the end pixel, which will be relaxed to the minimum distance only after all the pixels of the path have been visited and placed on the queue, multiple times for many of them.  So that's the price for not ordering the queue!</returns>
		public static Pta pixSearchGrayMaze(
						Pix pixs,
						int xi,
						int yi,
						int xf,
						int yf,
						out Pix ppixd)
		{
			if (pixs == null) {throw new ArgumentNullException  ("pixs cannot be Nothing");}

			IntPtr ppixdPtr = IntPtr.Zero;
			IntPtr _Result = Natives.pixSearchGrayMaze(pixs.Pointer,   xi,   yi,   xf,   yf, out ppixdPtr);
			if (ppixdPtr == IntPtr.Zero) {ppixd = null;} else { ppixd = new Pix(ppixdPtr); };

			if (_Result == IntPtr.Zero) {return null;}

			return  new Pta(_Result);
		}


	}
}

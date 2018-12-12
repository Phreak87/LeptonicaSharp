Imports LeptonicaSharp.Enumerations
Imports System.Runtime.InteropServices

Public Partial Class _All

' watershed.c (203, 1)
' wshedCreate(pixs, pixm, mindepth, debugflag) as L_WShed
' wshedCreate(PIX *, PIX *, l_int32, l_int32) as L_WSHED *
'''  <summary>
''' (1) It is not necessary for the fg pixels in the seed image
'''be at minima, or that they be isolated.  We extract a
'''single pixel from each connected component, and a seed
'''anywhere in a watershed will eventually label the watershed
'''when the filling level reaches it.<para/>
'''
'''(2) Set mindepth to some value to ignore noise in pixs that
'''can create small local minima.  Any watershed shallower
'''than mindepth, even if it has a seed, will not be saved
'''It will either be incorporated in another watershed or
'''eliminated.
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedCreate/*"/>
'''  <param name="pixs">[in] - 8 bpp source</param>
'''  <param name="pixm">[in] - 1 bpp 'marker' seed</param>
'''  <param name="mindepth">[in] - minimum depth anything less is not saved</param>
'''  <param name="debugflag">[in] - 1 for debug output</param>
'''   <returns>WShed, or NULL on error</returns>
Public Shared Function wshedCreate(
				ByVal pixs as Pix, 
				ByVal pixm as Pix, 
				ByVal mindepth as Integer, 
				ByVal debugflag as Integer) as L_WShed


if IsNothing (pixs) then Throw New ArgumentNullException  ("pixs cannot be Nothing")
		if IsNothing (pixm) then Throw New ArgumentNullException  ("pixm cannot be Nothing")
	Dim _Result as IntPtr = Natives.wshedCreate(pixs.Pointer, pixm.Pointer,   mindepth,   debugflag)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new L_WShed(_Result)
End Function

' watershed.c (250, 1)
' wshedDestroy(pwshed) as Object
' wshedDestroy(L_WSHED **) as void
'''  <summary>
''' wshedDestroy()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedDestroy/*"/>
'''  <param name="pwshed">[in,out] - will be set to null before returning</param>
Public Shared Sub wshedDestroy(
				ByRef pwshed as L_WShed)


	Dim pwshedPtr as IntPtr = IntPtr.Zero : 	If Not IsNothing(pwshed) Then pwshedPtr = pwshed.Pointer

	Natives.wshedDestroy( pwshedPtr)
	
	if pwshedPtr = IntPtr.Zero then pwshed = Nothing else pwshed = new L_WShed(pwshedPtr)
End Sub

' watershed.c (305, 1)
' wshedApply(wshed) as Integer
' wshedApply(L_WSHED *) as l_ok
'''  <summary>
''' wshedApply()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedApply/*"/>
'''  <param name="wshed">[in] - generated from wshedCreate()</param>
'''   <returns>0 if OK, 1 on error Iportant note: 1 This is buggy.  It seems to locate watersheds that are duplicates.  The watershed extraction after complete fill grabs some regions belonging to existing watersheds. See prog/watershedtest.c for testing.</returns>
Public Shared Function wshedApply(
				ByVal wshed as L_WShed) as Integer


if IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")
	Dim _Result as Integer = Natives.wshedApply(wshed.Pointer)
	
	return _Result
End Function

' watershed.c (1034, 1)
' wshedBasins(wshed, ppixa, pnalevels) as Integer
' wshedBasins(L_WSHED *, PIXA **, NUMA **) as l_ok
'''  <summary>
''' wshedBasins()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedBasins/*"/>
'''  <param name="wshed">[in] - </param>
'''  <param name="ppixa">[out][optional] - mask of watershed basins</param>
'''  <param name="pnalevels">[out][optional] - watershed levels</param>
'''   <returns>0 if OK, 1 on error</returns>
Public Shared Function wshedBasins(
				ByVal wshed as L_WShed, 
				<Out()> Optional  ByRef ppixa as Pixa = Nothing, 
				<Out()> Optional  ByRef pnalevels as Numa = Nothing) as Integer


if IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")
	Dim ppixaPtr as IntPtr = IntPtr.Zero
	Dim pnalevelsPtr as IntPtr = IntPtr.Zero

	Dim _Result as Integer = Natives.wshedBasins(wshed.Pointer, ppixaPtr, pnalevelsPtr)
	
	if ppixaPtr = IntPtr.Zero then ppixa = Nothing else ppixa = new Pixa(ppixaPtr)
	if pnalevelsPtr = IntPtr.Zero then pnalevels = Nothing else pnalevels = new Numa(pnalevelsPtr)
	return _Result
End Function

' watershed.c (1058, 1)
' wshedRenderFill(wshed) as Pix
' wshedRenderFill(L_WSHED *) as PIX *
'''  <summary>
''' wshedRenderFill()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedRenderFill/*"/>
'''  <param name="wshed">[in] - </param>
'''   <returns>pixd initial image with all basins filled, or NULL on error</returns>
Public Shared Function wshedRenderFill(
				ByVal wshed as L_WShed) as Pix


if IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")
	Dim _Result as IntPtr = Natives.wshedRenderFill(wshed.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

' watershed.c (1094, 1)
' wshedRenderColors(wshed) as Pix
' wshedRenderColors(L_WSHED *) as PIX *
'''  <summary>
''' wshedRenderColors()
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <include file="..\CHM_Help\IncludeComments.xml" path="Comments/wshedRenderColors/*"/>
'''  <param name="wshed">[in] - </param>
'''   <returns>pixd initial image with all basins filled, or NULL on error</returns>
Public Shared Function wshedRenderColors(
				ByVal wshed as L_WShed) as Pix


if IsNothing (wshed) then Throw New ArgumentNullException  ("wshed cannot be Nothing")
	Dim _Result as IntPtr = Natives.wshedRenderColors(wshed.Pointer)
	
	If _Result = IntPtr.Zero then Return Nothing
	return  new Pix(_Result)
End Function

End Class



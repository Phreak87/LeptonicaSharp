Imports System.Runtime.InteropServices
Imports LeptonicaSharp.Enumerations
Partial Public Class _All


' SRC\roplow.c (124, 1)
' rasteropUniLow(datad, dpixw, dpixh, depth, dwpl, dx, dy, dw, dh, op) as Object
' rasteropUniLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <param name="datad">[in] - ptr to dest image data</param>
'''  <param name="dpixw">[in] - width of dest</param>
'''  <param name="dpixh">[in] - height of dest</param>
'''  <param name="depth">[in] - depth of src and dest</param>
'''  <param name="dwpl">[in] - wpl of dest</param>
'''  <param name="dx">[in] - x val of UL corner of dest rectangle</param>
'''  <param name="dy">[in] - y val of UL corner of dest rectangle</param>
'''  <param name="dw">[in] - width of dest rectangle</param>
'''  <param name="dh">[in] - height of dest rectangle</param>
'''  <param name="op">[in] - op code</param>
Public Shared Sub rasteropUniLow(
				 ByVal datad as Byte(), 
				 ByVal dpixw as Integer, 
				 ByVal dpixh as Integer, 
				 ByVal depth as Integer, 
				 ByVal dwpl as Integer, 
				 ByVal dx as Integer, 
				 ByVal dy as Integer, 
				 ByVal dw as Integer, 
				 ByVal dh as Integer, 
				 ByVal op as Integer)

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")

	Dim datadPTR As IntPtr = Marshal.AllocHGlobal(datad.Count) : Marshal.Copy(datad, 0, datadPTR, datad.Length)

	LeptonicaSharp.Natives.rasteropUniLow( datadPTR, dpixw, dpixh, depth, dwpl, dx, dy, dw, dh, op)

End Sub

' SRC\roplow.c (481, 1)
' rasteropLow(datad, dpixw, dpixh, depth, dwpl, dx, dy, dw, dh, op, datas, spixw, spixh, swpl, sx, sy) as Object
' rasteropLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32) as void
'''  <remarks>
'''  </remarks>
'''  <param name="datad">[in] - ptr to dest image data</param>
'''  <param name="dpixw">[in] - width of dest</param>
'''  <param name="dpixh">[in] - height of dest</param>
'''  <param name="depth">[in] - depth of src and dest</param>
'''  <param name="dwpl">[in] - wpl of dest</param>
'''  <param name="dx">[in] - x val of UL corner of dest rectangle</param>
'''  <param name="dy">[in] - y val of UL corner of dest rectangle</param>
'''  <param name="dw">[in] - width of dest rectangle</param>
'''  <param name="dh">[in] - height of dest rectangle</param>
'''  <param name="op">[in] - op code</param>
'''  <param name="datas">[in] - ptr to src image data</param>
'''  <param name="spixw">[in] - width of src</param>
'''  <param name="spixh">[in] - height of src</param>
'''  <param name="swpl">[in] - wpl of src</param>
'''  <param name="sx">[in] - x val of UL corner of src rectangle</param>
'''  <param name="sy">[in] - y val of UL corner of src rectangle</param>
Public Shared Sub rasteropLow(
				 ByVal datad as Byte(), 
				 ByVal dpixw as Integer, 
				 ByVal dpixh as Integer, 
				 ByVal depth as Integer, 
				 ByVal dwpl as Integer, 
				 ByVal dx as Integer, 
				 ByVal dy as Integer, 
				 ByVal dw as Integer, 
				 ByVal dh as Integer, 
				 ByVal op as Integer, 
				 ByVal datas as Byte(), 
				 ByVal spixw as Integer, 
				 ByVal spixh as Integer, 
				 ByVal swpl as Integer, 
				 ByVal sx as Integer, 
				 ByVal sy as Integer)

	If IsNothing (datad) then Throw New ArgumentNullException  ("datad cannot be Nothing")
	If IsNothing (datas) then Throw New ArgumentNullException  ("datas cannot be Nothing")

	Dim datadPTR As IntPtr = Marshal.AllocHGlobal(datad.Count) : Marshal.Copy(datad, 0, datadPTR, datad.Length)
	Dim datasPTR As IntPtr = Marshal.AllocHGlobal(datas.Count) : Marshal.Copy(datas, 0, datasPTR, datas.Length)

	LeptonicaSharp.Natives.rasteropLow( datadPTR, dpixw, dpixh, depth, dwpl, dx, dy, dw, dh, op, datasPTR, spixw, spixh, swpl, sx, sy)

End Sub

' SRC\roplow.c (2146, 1)
' rasteropVipLow(data, pixw, pixh, depth, wpl, x, w, shift) as Object
' rasteropVipLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This clears the pixels that are left exposed after the<para/>
''' translation.  You can consider them as pixels that are<para/>
''' shifted in from outside the image.  This can be later<para/>
''' overridden by the incolor parameter in higher-level functions<para/>
''' that call this.  For example, for images with depth  is greater  1,<para/>
''' these pixels are cleared to black to be white they<para/>
''' must later be SET to white.  See, e.g., pixRasteropVip().<para/>
''' (2) This function scales the width to accommodate any depth,<para/>
''' performs clipping, and then does the in-place rasterop.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - ptr to image data</param>
'''  <param name="pixw">[in] - width</param>
'''  <param name="pixh">[in] - height</param>
'''  <param name="depth">[in] - depth</param>
'''  <param name="wpl">[in] - wpl</param>
'''  <param name="x">[in] - x val of UL corner of rectangle</param>
'''  <param name="w">[in] - width of rectangle</param>
'''  <param name="shift">[in] - + shifts data downward in vertical column</param>
Public Shared Sub rasteropVipLow(
				 ByVal data as Byte(), 
				 ByVal pixw as Integer, 
				 ByVal pixh as Integer, 
				 ByVal depth as Integer, 
				 ByVal wpl as Integer, 
				 ByVal x as Integer, 
				 ByVal w as Integer, 
				 ByVal shift as Integer)

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	LeptonicaSharp.Natives.rasteropVipLow( dataPTR, pixw, pixh, depth, wpl, x, w, shift)

End Sub

' SRC\roplow.c (2359, 1)
' rasteropHipLow(data, pixh, depth, wpl, y, h, shift) as Object
' rasteropHipLow(l_uint32 *, l_int32, l_int32, l_int32, l_int32, l_int32, l_int32) as void
'''  <summary>
''' <para/>
''' Notes:<para/>
''' (1) This clears the pixels that are left exposed after the rasterop.<para/>
''' Therefore, for Pix with depth  is greater  1, these pixels become black,<para/>
''' and must be subsequently SET if they are to be white.<para/>
''' For example, see pixRasteropHip().<para/>
''' (2) This function performs clipping and calls shiftDataHorizontalLow()<para/>
''' to do the in-place rasterop on each line.<para/>
'''  </summary>
'''  <remarks>
'''  </remarks>
'''  <param name="data">[in] - ptr to image data</param>
'''  <param name="pixh">[in] - height</param>
'''  <param name="depth">[in] - depth</param>
'''  <param name="wpl">[in] - wpl</param>
'''  <param name="y">[in] - y val of UL corner of rectangle</param>
'''  <param name="h">[in] - height of rectangle</param>
'''  <param name="shift">[in] - + shifts data to the left in a horizontal column</param>
Public Shared Sub rasteropHipLow(
				 ByVal data as Byte(), 
				 ByVal pixh as Integer, 
				 ByVal depth as Integer, 
				 ByVal wpl as Integer, 
				 ByVal y as Integer, 
				 ByVal h as Integer, 
				 ByVal shift as Integer)

	If IsNothing (data) then Throw New ArgumentNullException  ("data cannot be Nothing")

	Dim dataPTR As IntPtr = Marshal.AllocHGlobal(data.Count) : Marshal.Copy(data, 0, dataPTR, data.Length)

	LeptonicaSharp.Natives.rasteropHipLow( dataPTR, pixh, depth, wpl, y, h, shift)

End Sub

End Class

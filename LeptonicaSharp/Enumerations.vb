Namespace Enumerations
#Region "SRC/environ.h"

'SRC/environ.h (286, 1)
''' <summary>
''' Simple search state variables
''' </summary>
Public Enum L_FOUND
''' <summary></summary>
L_NOT_FOUND
''' <summary></summary>
L_FOUND
End Enum


'SRC/environ.h (296, 1)
''' <summary>
''' Path separator conversion
''' </summary>
Public Enum PATH_SEPCHAR
''' <summary></summary>
UNIX_PATH_SEPCHAR
''' <summary></summary>
WIN_PATH_SEPCHAR
End Enum


'SRC/environ.h (369, 1)
''' <summary>
''' Control printing of error, warning and info messages
''' </summary>
Public Enum L_SEVERITY
''' <summary></summary>
L_SEVERITY_EXTERNAL
''' <summary></summary>
L_SEVERITY_ALL
''' <summary></summary>
L_SEVERITY_DEBUG
''' <summary></summary>
L_SEVERITY_INFO
''' <summary></summary>
L_SEVERITY_WARNING
''' <summary></summary>
L_SEVERITY_ERROR
''' <summary></summary>
L_SEVERITY_NONE
End Enum

#End Region
#Region "SRC/array.h"

'SRC/array.h (140, 1)
''' <summary>
''' Flags for interpolation in Numa
''' </summary>
Public Enum L_INTERP
''' <summary>linear</summary>
L_LINEAR_INTERP
''' <summary>quadratic</summary>
L_QUADRATIC_INTERP
End Enum


'SRC/array.h (146, 1)
''' <summary>
''' Flags for added borders in Numa and Fpix
''' </summary>
Public Enum L_BORDER
''' <summary>extended with same value</summary>
L_CONTINUED_BORDER
''' <summary>extended with constant normal derivative</summary>
L_SLOPE_BORDER
''' <summary>mirrored</summary>
L_MIRRORED_BORDER
End Enum


'SRC/array.h (153, 1)
''' <summary>
''' Flags for data type converted from Numa
''' </summary>
Public Enum L_VALUE
''' <summary>convert to integer</summary>
L_INTEGER_VALUE
''' <summary>convert to float</summary>
L_FLOAT_VALUE
End Enum

#End Region
#Region "SRC/ptra.h"

'SRC/ptra.h (76, 1)
''' <summary>
''' Flags for removal from L_Ptra
''' </summary>
Public Enum L_COMPACTION
''' <summary>null the pointer only</summary>
L_NO_COMPACTION
''' <summary>compact the array</summary>
L_COMPACTION
End Enum


'SRC/ptra.h (82, 1)
''' <summary>
''' Flags for insertion into L_Ptra
''' </summary>
Public Enum L_DOWNSHIFT
''' <summary>choose based on number of holes</summary>
L_AUTO_DOWNSHIFT
''' <summary>downshifts min # of ptrs below insert</summary>
L_MIN_DOWNSHIFT
''' <summary>downshifts all ptrs below insert</summary>
L_FULL_DOWNSHIFT
End Enum


'SRC/ptra.h (89, 1)
''' <summary>
''' Accessor flags for L_Ptraa
''' </summary>
Public Enum L_accessor__l_ptraa
''' <summary>ptr to L_Ptra; caller can inspect only</summary>
L_HANDLE_ONLY
''' <summary>caller owns; destroy or save in L_Ptraa</summary>
L_REMOVE
End Enum

#End Region
#Region "SRC/rbtree.h"

'SRC/rbtree.h (47, 1)
''' <summary>
''' The three valid key types for red-black trees, maps and sets.
''' </summary>
Public Enum L_T_TYPE
''' <summary></summary>
L_INT_TYPE
''' <summary></summary>
L_UINT_TYPE
''' <summary></summary>
L_FLOAT_TYPE
End Enum

#End Region
#Region "SRC/bmf.h"

'SRC/bmf.h (37, 1)
''' <summary>
''' Constants for deciding when text block is divided into paragraphs
''' </summary>
Public Enum SPLIT_ON
''' <summary>tab or space at beginning of line</summary>
SPLIT_ON_LEADING_WHITE
''' <summary>newline with optional white space</summary>
SPLIT_ON_BLANK_LINE
''' <summary>leading white space or newline</summary>
SPLIT_ON_BOTH
End Enum

#End Region
#Region "SRC/ccbord.h"

'SRC/ccbord.h (40, 1)
''' <summary>
''' Use in ccbaStepChainsToPixCoords()
''' </summary>
Public Enum CCB_AL_COORDS
''' <summary></summary>
CCB_LOCAL_COORDS
''' <summary></summary>
CCB_GLOBAL_COORDS
End Enum


'SRC/ccbord.h (46, 1)
''' <summary>
''' Use in ccbaGenerateSPGlobalLocs()
''' </summary>
Public Enum CCB_SAVE_PTS
''' <summary></summary>
CCB_SAVE_ALL_PTS
''' <summary></summary>
CCB_SAVE_TURNING_PTS
End Enum

#End Region
#Region "SRC/gplot.h"

'SRC/gplot.h (47, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_STYLE
''' <summary></summary>
GPLOT_LINES
''' <summary></summary>
GPLOT_POINTS
''' <summary></summary>
GPLOT_IMPULSES
''' <summary></summary>
GPLOT_LINESPOINTS
''' <summary></summary>
GPLOT_DOTS
End Enum


'SRC/gplot.h (56, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_OUTPUT
''' <summary></summary>
GPLOT_NONE
''' <summary></summary>
GPLOT_PNG
''' <summary></summary>
GPLOT_PS
''' <summary></summary>
GPLOT_EPS
''' <summary></summary>
GPLOT_LATEX
End Enum


'SRC/gplot.h (64, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_SCALING
''' <summary>default</summary>
GPLOT_LINEAR_SCALE
''' <summary></summary>
GPLOT_LOG_SCALE_X
''' <summary></summary>
GPLOT_LOG_SCALE_Y
''' <summary></summary>
GPLOT_LOG_SCALE_X_Y
End Enum

#End Region
#Region "SRC/imageio.h"

'SRC/imageio.h (91, 1)
''' <summary>
''' Image file format types
''' </summary>
Public Enum IFF
''' <summary></summary>
IFF_UNKNOWN
''' <summary></summary>
IFF_BMP
''' <summary></summary>
IFF_JFIF_JPEG
''' <summary></summary>
IFF_PNG
''' <summary></summary>
IFF_TIFF
''' <summary></summary>
IFF_TIFF_PACKBITS
''' <summary></summary>
IFF_TIFF_RLE
''' <summary></summary>
IFF_TIFF_G3
''' <summary></summary>
IFF_TIFF_G4
''' <summary></summary>
IFF_TIFF_LZW
''' <summary></summary>
IFF_TIFF_ZIP
''' <summary></summary>
IFF_PNM
''' <summary></summary>
IFF_PS
''' <summary></summary>
IFF_GIF
''' <summary></summary>
IFF_JP2
''' <summary></summary>
IFF_WEBP
''' <summary></summary>
IFF_LPDF
''' <summary></summary>
IFF_DEFAULT
''' <summary></summary>
IFF_SPIX
End Enum


'SRC/imageio.h (119, 1)
''' <summary>
''' Format header ids
''' </summary>
Public Enum ID
''' <summary>BM - for bitmaps</summary>
BMP_ID
''' <summary>MM - for 'motorola'</summary>
TIFF_BIGEND_ID
''' <summary>II - for 'intel'</summary>
TIFF_LITTLEEND_ID
End Enum


'SRC/imageio.h (131, 1)
''' <summary>
''' Hinting bit flags in jpeg reader
''' </summary>
Public Enum L_JPEG
''' <summary>only want luminance data; no chroma</summary>
L_JPEG_READ_LUMINANCE
''' <summary>don't return possibly damaged pix</summary>
L_JPEG_FAIL_ON_BAD_DATA
End Enum


'SRC/imageio.h (142, 1)
''' <summary>
''' Pdf formatted encoding types
''' </summary>
Public Enum L_ENCODE
''' <summary>use default encoding based on image</summary>
L_DEFAULT_ENCODE
''' <summary>use dct encoding: 8 and 32 bpp, no cmap</summary>
L_JPEG_ENCODE
''' <summary>use ccitt g4 fax encoding: 1 bpp</summary>
L_G4_ENCODE
''' <summary>use flate encoding: any depth, cmap ok</summary>
L_FLATE_ENCODE
''' <summary>use jp2k encoding: 8 and 32 bpp, no cmap</summary>
L_JP2K_ENCODE
End Enum


'SRC/imageio.h (193, 1)
''' <summary>
''' Pdf multi image flags
''' </summary>
Public Enum L_T_IMAGE
''' <summary>first image to be used</summary>
L_FIRST_IMAGE
''' <summary>intermediate image; not first or last</summary>
L_NEXT_IMAGE
''' <summary>last image to be used</summary>
L_LAST_IMAGE
End Enum

#End Region
#Region "SRC/jbclass.h"

'SRC/jbclass.h (123, 1)
''' <summary>
''' Classifier methods
''' </summary>
Public Enum JB
''' <summary></summary>
JB_RANKHAUS
''' <summary></summary>
JB_CORRELATION
End Enum


'SRC/jbclass.h (129, 1)
''' <summary>
''' For jbGetComponents(): type of component to extract from images
''' </summary>
Public Enum JB_S
''' <summary></summary>
JB_CONN_COMPS
''' <summary></summary>
JB_CHARACTERS
''' <summary></summary>
JB_WORDS
End Enum

#End Region
#Region "SRC/morph.h"

'SRC/morph.h (109, 1)
''' <summary>
''' Morphological boundary condition flags
''' </summary>
Public Enum MMETRIC_MORPH_BC
''' <summary></summary>
SYMMETRIC_MORPH_BC
''' <summary></summary>
ASYMMETRIC_MORPH_BC
End Enum


'SRC/morph.h (119, 1)
''' <summary>
''' Structuring element types
''' </summary>
Public Enum SEL
''' <summary></summary>
SEL_DONT_CARE
''' <summary></summary>
SEL_HIT
''' <summary></summary>
SEL_MISS
End Enum


'SRC/morph.h (130, 1)
''' <summary>
''' Runlength flags for granulometry
''' </summary>
Public Enum L_RUN_O
''' <summary></summary>
L_RUN_OFF
''' <summary></summary>
L_RUN_ON
End Enum


'SRC/morph.h (141, 1)
''' <summary>
''' Direction flags
''' </summary>
Public Enum L_direction
''' <summary></summary>
L_HORIZ
''' <summary></summary>
L_VERT
''' <summary></summary>
L_BOTH_DIRECTIONS
End Enum


'SRC/morph.h (152, 1)
''' <summary>
''' Morphological operation flags
''' </summary>
Public Enum L_MORPH
''' <summary></summary>
L_MORPH_DILATE
''' <summary></summary>
L_MORPH_ERODE
''' <summary></summary>
L_MORPH_OPEN
''' <summary></summary>
L_MORPH_CLOSE
''' <summary></summary>
L_MORPH_HMT
End Enum


'SRC/morph.h (165, 1)
''' <summary>
''' Grayscale intensity scaling flags
''' </summary>
Public Enum L_L_SCALE
''' <summary></summary>
L_LINEAR_SCALE
''' <summary></summary>
L_LOG_SCALE
End Enum


'SRC/morph.h (175, 1)
''' <summary>
''' Morphological tophat flags
''' </summary>
Public Enum L_TOPHAT
''' <summary></summary>
L_TOPHAT_WHITE
''' <summary></summary>
L_TOPHAT_BLACK
End Enum


'SRC/morph.h (186, 1)
''' <summary>
''' Arithmetic and logical operator flags
''' </summary>
Public Enum L_arithmetic_logical_operator
''' <summary></summary>
L_ARITH_ADD
''' <summary></summary>
L_ARITH_SUBTRACT
''' <summary></summary>
L_ARITH_MULTIPLY
''' <summary></summary>
L_ARITH_DIVIDE
''' <summary></summary>
L_UNION
''' <summary></summary>
L_INTERSECTION
''' <summary></summary>
L_SUBTRACTION
''' <summary></summary>
L_EXCLUSIVE_OR
End Enum


'SRC/morph.h (202, 1)
''' <summary>
''' Min/max selection flags
''' </summary>
Public Enum L_CHOOSE_M
''' <summary></summary>
L_CHOOSE_MIN
''' <summary></summary>
L_CHOOSE_MAX
''' <summary></summary>
L_CHOOSE_MAXDIFF
''' <summary></summary>
L_CHOOSE_MIN_BOOST
''' <summary></summary>
L_CHOOSE_MAX_BOOST
End Enum


'SRC/morph.h (215, 1)
''' <summary>
''' Distance function b.c. flags
''' </summary>
Public Enum L_BOUNDARY_G
''' <summary></summary>
L_BOUNDARY_BG
''' <summary></summary>
L_BOUNDARY_FG
End Enum


'SRC/morph.h (225, 1)
''' <summary>
''' Image comparison flags
''' </summary>
Public Enum L_COMPARE
''' <summary></summary>
L_COMPARE_XOR
''' <summary></summary>
L_COMPARE_SUBTRACT
''' <summary></summary>
L_COMPARE_ABS_DIFF
End Enum


'SRC/morph.h (236, 1)
''' <summary>
''' Color content flags
''' </summary>
Public Enum L_MAX
''' <summary></summary>
L_MAX_DIFF_FROM_AVERAGE_2
''' <summary></summary>
L_MAX_MIN_DIFF_FROM_2
''' <summary></summary>
L_MAX_DIFF
End Enum

#End Region
#Region "SRC/pix.h"

'SRC/pix.h (200, 1)
''' <summary>
''' Colors for 32 bpp
''' </summary>
Public Enum colors_32_bpp
''' <summary>red color index in RGBA_QUAD</summary>
COLOR_RED
''' <summary>green color index in RGBA_QUAD</summary>
COLOR_GREEN
''' <summary>blue color index in RGBA_QUAD</summary>
COLOR_BLUE
''' <summary>alpha value index in RGBA_QUAD</summary>
L_ALPHA_CHANNEL
End Enum


'SRC/pix.h (221, 1)
''' <summary>
''' Colors for drawing boxes
''' </summary>
Public Enum L_DRAW
''' <summary>draw in red</summary>
L_DRAW_RED
''' <summary>draw in green</summary>
L_DRAW_GREEN
''' <summary>draw in blue</summary>
L_DRAW_BLUE
''' <summary>draw specified color</summary>
L_DRAW_SPECIFIED
''' <summary>draw as sequence of r,g,b</summary>
L_DRAW_RGB
''' <summary>draw randomly chosen colors</summary>
L_DRAW_RANDOM
End Enum


'SRC/pix.h (252, 1)
''' <summary>
''' Flags for colormap conversion
''' </summary>
Public Enum REMOVE_CMAP
''' <summary>remove colormap for conv to 1 bpp</summary>
REMOVE_CMAP_TO_BINARY
''' <summary>remove colormap for conv to 8 bpp</summary>
REMOVE_CMAP_TO_GRAYSCALE
''' <summary>remove colormap for conv to 32 bpp</summary>
REMOVE_CMAP_TO_FULL_COLOR
''' <summary>remove colormap and alpha</summary>
REMOVE_CMAP_WITH_ALPHA
''' <summary>remove depending on src format</summary>
REMOVE_CMAP_BASED_ON_SRC
End Enum


'SRC/pix.h (715, 1)
''' <summary>
''' Access and storage flags
''' </summary>
Public Enum L_access_storage
''' <summary>do not copy the object; do not delete the ptr</summary>
L_NOCOPY
''' <summary>stuff it in; do not copy or clone</summary>
L_INSERT
''' <summary>make/use a copy of the object</summary>
L_COPY
''' <summary>make/use clone (ref count) of the object</summary>
L_CLONE
''' <summary>make a new array object (e.g., pixa) and fill    the array with clones (e.g., pix)</summary>
L_COPY_CLONE
End Enum


'SRC/pix.h (730, 1)
''' <summary>
''' Sort mode flags
''' </summary>
Public Enum L_SORT
''' <summary>use shell sort</summary>
L_SHELL_SORT
''' <summary>use bin sort</summary>
L_BIN_SORT
End Enum


'SRC/pix.h (736, 1)
''' <summary>
''' Sort order flags
''' </summary>
Public Enum L_SORT_CREASING
''' <summary>sort in increasing order</summary>
L_SORT_INCREASING
''' <summary>sort in decreasing order</summary>
L_SORT_DECREASING
End Enum


'SRC/pix.h (742, 1)
''' <summary>
''' Sort type flags
''' </summary>
Public Enum L_SORT_BY
''' <summary>sort box or c.c. by left edge location</summary>
L_SORT_BY_X
''' <summary>sort box or c.c. by top edge location</summary>
L_SORT_BY_Y
''' <summary>sort box or c.c. by right edge location</summary>
L_SORT_BY_RIGHT
''' <summary>sort box or c.c. by bot edge location</summary>
L_SORT_BY_BOT
''' <summary>sort box or c.c. by width</summary>
L_SORT_BY_WIDTH
''' <summary>sort box or c.c. by height</summary>
L_SORT_BY_HEIGHT
''' <summary>sort box or c.c. by min dimension</summary>
L_SORT_BY_MIN_DIMENSION
''' <summary>sort box or c.c. by max dimension</summary>
L_SORT_BY_MAX_DIMENSION
''' <summary>sort box or c.c. by perimeter</summary>
L_SORT_BY_PERIMETER
''' <summary>sort box or c.c. by area</summary>
L_SORT_BY_AREA
''' <summary>sort box or c.c. by width/height ratio</summary>
L_SORT_BY_ASPECT_RATIO
End Enum


'SRC/pix.h (762, 1)
''' <summary>
''' Blend flags
''' </summary>
Public Enum L_BLEND
''' <summary>add some of src inverse to itself</summary>
L_BLEND_WITH_INVERSE
''' <summary>shift src colors towards white</summary>
L_BLEND_TO_WHITE
''' <summary>shift src colors towards black</summary>
L_BLEND_TO_BLACK
''' <summary>blend src directly with blender</summary>
L_BLEND_GRAY
''' <summary>add amount of src inverse to itself,    based on blender pix value</summary>
L_BLEND_GRAY_WITH_INVERSE
End Enum


'SRC/pix.h (771, 1)
''' <summary>
''' 
''' </summary>
Public Enum L_PAINT
''' <summary>colorize non-black pixels</summary>
L_PAINT_LIGHT
''' <summary>colorize non-white pixels</summary>
L_PAINT_DARK
End Enum


'SRC/pix.h (782, 1)
''' <summary>
''' Graphics pixel setting
''' </summary>
Public Enum L_PIXELS
''' <summary>set all bits in each pixel to 1</summary>
L_SET_PIXELS
''' <summary>set all bits in each pixel to 0</summary>
L_CLEAR_PIXELS
''' <summary>flip all bits in each pixel</summary>
L_FLIP_PIXELS
End Enum


'SRC/pix.h (794, 1)
''' <summary>
''' Location filter flags
''' </summary>
Public Enum L_SELECT
''' <summary>width must satisfy constraint</summary>
L_SELECT_WIDTH
''' <summary>height must satisfy constraint</summary>
L_SELECT_HEIGHT
''' <summary>x value satisfy constraint</summary>
L_SELECT_XVAL
''' <summary>y value must satisfy constraint</summary>
L_SELECT_YVAL
''' <summary>either width or height (or xval    or yval) can satisfy</summary>
L_SELECT_IF_EITHER
''' <summary>both width and height (or xval     and yval must satisfy</summary>
L_SELECT_IF_BOTH
End Enum


'SRC/pix.h (806, 1)
''' <summary>
''' Size filter flags
''' </summary>
Public Enum L_SELECT_IF
''' <summary>save if value is less than threshold</summary>
L_SELECT_IF_LT
''' <summary>save if value is more than threshold</summary>
L_SELECT_IF_GT
''' <summary>save if value is = to the threshold</summary>
L_SELECT_IF_LTE
''' <summary>save if value is >= to the threshold</summary>
L_SELECT_IF_GTE
End Enum


'SRC/pix.h (819, 1)
''' <summary>
''' Color component selection flags
''' </summary>
Public Enum L_SELECT_
''' <summary>use red component</summary>
L_SELECT_RED
''' <summary>use green component</summary>
L_SELECT_GREEN
''' <summary>use blue component</summary>
L_SELECT_BLUE
''' <summary>use min color component</summary>
L_SELECT_MIN
''' <summary>use max color component</summary>
L_SELECT_MAX
''' <summary>use average of color components</summary>
L_SELECT_AVERAGE
''' <summary>use hue value (in HSV color space)</summary>
L_SELECT_HUE
''' <summary>use saturation value (in HSV space)</summary>
L_SELECT_SATURATION
End Enum


'SRC/pix.h (836, 1)
''' <summary>
''' 16-bit conversion flags
''' </summary>
Public Enum L_16_bit_conversion
''' <summary>use LSB</summary>
L_LS_BYTE
''' <summary>use MSB</summary>
L_MS_BYTE
''' <summary>use LSB if max(val)  256; else MSB</summary>
L_AUTO_BYTE
''' <summary>use max(val, 255)</summary>
L_CLIP_TO_FF
''' <summary>use two LSB</summary>
L_LS_TWO_BYTES
''' <summary>use two MSB</summary>
L_MS_TWO_BYTES
''' <summary>use max(val, 65535)</summary>
L_CLIP_TO_FFFF
End Enum


'SRC/pix.h (852, 1)
''' <summary>
''' Rotate flags
''' </summary>
Public Enum L_ROTATE
''' <summary>use area map rotation, if possible</summary>
L_ROTATE_AREA_MAP
''' <summary>use shear rotation</summary>
L_ROTATE_SHEAR
''' <summary>use sampling</summary>
L_ROTATE_SAMPLING
End Enum


'SRC/pix.h (859, 1)
''' <summary>
''' Background flags
''' </summary>
Public Enum L_BRING_IN
''' <summary>bring in white pixels from the outside</summary>
L_BRING_IN_WHITE
''' <summary>bring in black pixels from the outside</summary>
L_BRING_IN_BLACK
End Enum


'SRC/pix.h (865, 1)
''' <summary>
''' Shear flags
''' </summary>
Public Enum L_SHEAR_ABOUT_CER
''' <summary>shear image about UL corner</summary>
L_SHEAR_ABOUT_CORNER
''' <summary>shear image about center</summary>
L_SHEAR_ABOUT_CENTER
End Enum


'SRC/pix.h (876, 1)
''' <summary>
''' Affine transform order flags
''' </summary>
Public Enum L_affine_transm_order
''' <summary>translate, scale, rotate</summary>
L_TR_SC_RO
''' <summary>scale, rotate, translate</summary>
L_SC_RO_TR
''' <summary>rotate, translate, scale</summary>
L_RO_TR_SC
''' <summary>translate, rotate, scale</summary>
L_TR_RO_SC
''' <summary>rotate, scale, translate</summary>
L_RO_SC_TR
''' <summary>scale, translate, rotate</summary>
L_SC_TR_RO
End Enum


'SRC/pix.h (891, 1)
''' <summary>
''' Grayscale filling flags
''' </summary>
Public Enum L_FILL
''' <summary>fill white pixels (e.g, in fg map)</summary>
L_FILL_WHITE
''' <summary>fill black pixels (e.g., in bg map)</summary>
L_FILL_BLACK
End Enum


'SRC/pix.h (902, 1)
''' <summary>
''' Flags for setting to white or black
''' </summary>
Public Enum L_SET
''' <summary>set pixels to white</summary>
L_SET_WHITE
''' <summary>set pixels to black</summary>
L_SET_BLACK
End Enum


'SRC/pix.h (913, 1)
''' <summary>
''' Flags for getting white or black value
''' </summary>
Public Enum L_GET_VAL
''' <summary>get white pixel value</summary>
L_GET_WHITE_VAL
''' <summary>get black pixel value</summary>
L_GET_BLACK_VAL
End Enum


'SRC/pix.h (924, 1)
''' <summary>
''' Flags for 8 bit and 16 bit pixel sums
''' </summary>
Public Enum L_IS_MAX
''' <summary>white pixels are 0xff or 0xffff; black are 0</summary>
L_WHITE_IS_MAX
''' <summary>black pixels are 0xff or 0xffff; white are 0</summary>
L_BLACK_IS_MAX
End Enum


'SRC/pix.h (937, 1)
''' <summary>
''' Dither parameters
''' </summary>
Public Enum DEFAULT_CLIP
''' <summary>dist to black with no prop; 1 bpp</summary>
DEFAULT_CLIP_LOWER_1
''' <summary>dist to black with no prop; 1 bpp</summary>
DEFAULT_CLIP_UPPER_1
''' <summary>dist to black with no prop; 2 bpp</summary>
DEFAULT_CLIP_LOWER_2
''' <summary>dist to black with no prop; 2 bpp</summary>
DEFAULT_CLIP_UPPER_2
End Enum


'SRC/pix.h (950, 1)
''' <summary>
''' Distance flags
''' </summary>
Public Enum L_AN_DISTANCE
''' <summary>L1 distance (e.g., in color space)</summary>
L_MANHATTAN_DISTANCE
''' <summary>L2 distance</summary>
L_EUCLIDEAN_DISTANCE
End Enum


'SRC/pix.h (961, 1)
''' <summary>
''' Value flags
''' </summary>
Public Enum L_value_
''' <summary>values  0</summary>
L_NEGATIVE
''' <summary>values >= 0</summary>
L_NON_NEGATIVE
''' <summary>values > 0</summary>
L_POSITIVE
''' <summary>values = 0</summary>
L_NON_POSITIVE
''' <summary>values = 0</summary>
L_ZERO
''' <summary>all values</summary>
L_ALL
End Enum


'SRC/pix.h (976, 1)
''' <summary>
''' Statistical measures
''' </summary>
Public Enum L_statistical_measures
''' <summary>average of abs values</summary>
L_MEAN_ABSVAL
''' <summary>median value of set</summary>
L_MEDIAN_VAL
''' <summary>mode value of set</summary>
L_MODE_VAL
''' <summary>mode count of set</summary>
L_MODE_COUNT
''' <summary>rms of values</summary>
L_ROOT_MEAN_SQUARE
''' <summary>standard deviation from mean</summary>
L_STANDARD_DEVIATION
''' <summary>variance of values</summary>
L_VARIANCE
End Enum


'SRC/pix.h (992, 1)
''' <summary>
''' Set selection flags
''' </summary>
Public Enum L_CHOOSE
''' <summary>select 'n' consecutive</summary>
L_CHOOSE_CONSECUTIVE
''' <summary>select at intervals of 'n'</summary>
L_CHOOSE_SKIP_BY
End Enum


'SRC/pix.h (1003, 1)
''' <summary>
''' Text orientation flags
''' </summary>
Public Enum L_TEXT_ORIENT
''' <summary>low confidence on text orientation</summary>
L_TEXT_ORIENT_UNKNOWN
''' <summary>portrait, text rightside-up</summary>
L_TEXT_ORIENT_UP
''' <summary>landscape, text up to left</summary>
L_TEXT_ORIENT_LEFT
''' <summary>portrait, text upside-down</summary>
L_TEXT_ORIENT_DOWN
''' <summary>landscape, text up to right</summary>
L_TEXT_ORIENT_RIGHT
End Enum


'SRC/pix.h (1017, 1)
''' <summary>
''' Edge orientation flags
''' </summary>
Public Enum L_L_EDGES
''' <summary>filters for horizontal edges</summary>
L_HORIZONTAL_EDGES
''' <summary>filters for vertical edges</summary>
L_VERTICAL_EDGES
''' <summary>filters for all edges</summary>
L_ALL_EDGES
End Enum


'SRC/pix.h (1029, 1)
''' <summary>
''' Line orientation flags
''' </summary>
Public Enum L_LINE
''' <summary>horizontal line</summary>
L_HORIZONTAL_LINE
''' <summary>45 degree line with positive slope</summary>
L_POS_SLOPE_LINE
''' <summary>vertical line</summary>
L_VERTICAL_LINE
''' <summary>45 degree line with negative slope</summary>
L_NEG_SLOPE_LINE
''' <summary>neither horizontal nor vertical</summary>
L_OBLIQUE_LINE
End Enum


'SRC/pix.h (1043, 1)
''' <summary>
''' Image orientation flags
''' </summary>
Public Enum L_MODE
''' <summary>typical: page is viewed with height > width</summary>
L_PORTRAIT_MODE
''' <summary>page is viewed at 90 deg to portrait mode</summary>
L_LANDSCAPE_MODE
End Enum


'SRC/pix.h (1054, 1)
''' <summary>
''' Scan direction flags
''' </summary>
Public Enum L_scan_direction
''' <summary>scan from left</summary>
L_FROM_LEFT
''' <summary>scan from right</summary>
L_FROM_RIGHT
''' <summary>scan from top</summary>
L_FROM_TOP
''' <summary>scan from bottom</summary>
L_FROM_BOT
''' <summary>scan in negative direction</summary>
L_SCAN_NEGATIVE
''' <summary>scan in positive direction</summary>
L_SCAN_POSITIVE
''' <summary>scan in both directions</summary>
L_SCAN_BOTH
''' <summary>horizontal scan (direction unimportant)</summary>
L_SCAN_HORIZONTAL
''' <summary>vertical scan (direction unimportant)</summary>
L_SCAN_VERTICAL
End Enum


'SRC/pix.h (1072, 1)
''' <summary>
''' Box size adjustment and location flags
''' </summary>
Public Enum L_box_size_adjustment_location
''' <summary>do not adjust</summary>
L_ADJUST_SKIP
''' <summary>adjust left edge</summary>
L_ADJUST_LEFT
''' <summary>adjust right edge</summary>
L_ADJUST_RIGHT
''' <summary>adjust both left and right edges</summary>
L_ADJUST_LEFT_AND_RIGHT
''' <summary>adjust top edge</summary>
L_ADJUST_TOP
''' <summary>adjust bottom edge</summary>
L_ADJUST_BOT
''' <summary>adjust both top and bottom edges</summary>
L_ADJUST_TOP_AND_BOT
''' <summary>choose the min median value</summary>
L_ADJUST_CHOOSE_MIN
''' <summary>choose the max median value</summary>
L_ADJUST_CHOOSE_MAX
''' <summary>set left side to a given value</summary>
L_SET_LEFT
''' <summary>set right side to a given value</summary>
L_SET_RIGHT
''' <summary>set top side to a given value</summary>
L_SET_TOP
''' <summary>set bottom side to a given value</summary>
L_SET_BOT
''' <summary>get left side location</summary>
L_GET_LEFT
''' <summary>get right side location</summary>
L_GET_RIGHT
''' <summary>get top side location</summary>
L_GET_TOP
''' <summary>get bottom side location</summary>
L_GET_BOT
End Enum


'SRC/pix.h (1098, 1)
''' <summary>
''' Flags for modifying box boundaries using a second box
''' </summary>
Public Enum L__modifying_box_boundaries_using_a_second_box
''' <summary>use boundaries giving min size</summary>
L_USE_MINSIZE
''' <summary>use boundaries giving max size</summary>
L_USE_MAXSIZE
''' <summary>modify boundary if big location diff</summary>
L_SUB_ON_LOC_DIFF
''' <summary>modify boundary if big size diff</summary>
L_SUB_ON_SIZE_DIFF
''' <summary>modify boundary with capped min</summary>
L_USE_CAPPED_MIN
''' <summary>modify boundary with capped max</summary>
L_USE_CAPPED_MAX
End Enum


'SRC/pix.h (1112, 1)
''' <summary>
''' Handling overlapping bounding boxes in Boxa
''' </summary>
Public Enum L_hling_overlapping_bounding_boxes_in_boxa
''' <summary>resize to bounding region; remove smaller</summary>
L_COMBINE
''' <summary>only remove smaller</summary>
L_REMOVE_SMALL
End Enum


'SRC/pix.h (1122, 1)
''' <summary>
''' Flags for replacing invalid boxes
''' </summary>
Public Enum L_USE_BOXES
''' <summary>consider all boxes in the sequence</summary>
L_USE_ALL_BOXES
''' <summary>consider boxes with the same parity</summary>
L_USE_SAME_PARITY_BOXES
End Enum


'SRC/pix.h (1132, 1)
''' <summary>
''' Horizontal warp direction
''' </summary>
Public Enum L_WARP_TO_T
''' <summary>increasing stretch or contraction to left</summary>
L_WARP_TO_LEFT
''' <summary>increasing stretch or contraction to right</summary>
L_WARP_TO_RIGHT
End Enum


'SRC/pix.h (1138, 1)
''' <summary>
''' Horizontal warp stretch mode
''' </summary>
Public Enum L_WARP
''' <summary>stretch or contraction grows linearly</summary>
L_LINEAR_WARP
''' <summary>stretch or contraction grows quadratically</summary>
L_QUADRATIC_WARP
End Enum


'SRC/pix.h (1149, 1)
''' <summary>
''' Pixel selection for resampling
''' </summary>
Public Enum L_ED
''' <summary>linear interpolation from src pixels</summary>
L_INTERPOLATED
''' <summary>nearest src pixel sampling only</summary>
L_SAMPLED
End Enum


'SRC/pix.h (1160, 1)
''' <summary>
''' Thinning flags
''' </summary>
Public Enum L_THIN_G
''' <summary>thin foreground of 1 bpp image</summary>
L_THIN_FG
''' <summary>thin background of 1 bpp image</summary>
L_THIN_BG
End Enum


'SRC/pix.h (1171, 1)
''' <summary>
''' Runlength flags
''' </summary>
Public Enum L_AL_RUNS
''' <summary>determine runlengths of horizontal runs</summary>
L_HORIZONTAL_RUNS
''' <summary>determine runlengths of vertical runs</summary>
L_VERTICAL_RUNS
End Enum


'SRC/pix.h (1182, 1)
''' <summary>
''' Edge filter flags
''' </summary>
Public Enum L_EDGE
''' <summary>Sobel edge filter</summary>
L_SOBEL_EDGE
''' <summary>Two-sided edge filter</summary>
L_TWO_SIDED_EDGE
End Enum


'SRC/pix.h (1193, 1)
''' <summary>
''' Subpixel color component ordering in LC display
''' </summary>
Public Enum L_SUBPIXEL_ORDER
''' <summary>sensor order left-to-right RGB</summary>
L_SUBPIXEL_ORDER_RGB
''' <summary>sensor order left-to-right BGR</summary>
L_SUBPIXEL_ORDER_BGR
''' <summary>sensor order top-to-bottom RGB</summary>
L_SUBPIXEL_ORDER_VRGB
''' <summary>sensor order top-to-bottom BGR</summary>
L_SUBPIXEL_ORDER_VBGR
End Enum


'SRC/pix.h (1206, 1)
''' <summary>
''' HSV histogram flags
''' </summary>
Public Enum L_HISTO
''' <summary>Use hue-saturation histogram</summary>
L_HS_HISTO
''' <summary>Use hue-value histogram</summary>
L_HV_HISTO
''' <summary>Use saturation-value histogram</summary>
L_SV_HISTO
End Enum


'SRC/pix.h (1218, 1)
''' <summary>
''' Region flags (inclusion, exclusion)
''' </summary>
Public Enum L_CLUDE_REGION
''' <summary>Use hue-saturation histogram</summary>
L_INCLUDE_REGION
''' <summary>Use hue-value histogram</summary>
L_EXCLUDE_REGION
End Enum


'SRC/pix.h (1229, 1)
''' <summary>
''' Flags for adding text to a Pix
''' </summary>
Public Enum L_ADD
''' <summary>Add text above the image</summary>
L_ADD_ABOVE
''' <summary>Add text below the image</summary>
L_ADD_BELOW
''' <summary>Add text to the left of the image</summary>
L_ADD_LEFT
''' <summary>Add text to the right of the image</summary>
L_ADD_RIGHT
''' <summary>Add text over the top of the image</summary>
L_ADD_AT_TOP
''' <summary>Add text over the bottom of the image</summary>
L_ADD_AT_BOT
''' <summary>Add text over left side of the image</summary>
L_ADD_AT_LEFT
''' <summary>Add text over right side of the image</summary>
L_ADD_AT_RIGHT
End Enum


'SRC/pix.h (1246, 1)
''' <summary>
''' Flags for plotting on a Pix
''' </summary>
Public Enum L_PLOT_AT
''' <summary>Plot horizontally at top</summary>
L_PLOT_AT_TOP
''' <summary>Plot horizontally at middle</summary>
L_PLOT_AT_MID_HORIZ
''' <summary>Plot horizontally at bottom</summary>
L_PLOT_AT_BOT
''' <summary>Plot vertically at left</summary>
L_PLOT_AT_LEFT
''' <summary>Plot vertically at middle</summary>
L_PLOT_AT_MID_VERT
''' <summary>Plot vertically at right</summary>
L_PLOT_AT_RIGHT
End Enum


'SRC/pix.h (1261, 1)
''' <summary>
''' Flags for selecting display program
''' </summary>
Public Enum L_DISPLAY_WITH
''' <summary>Use xzgv with pixDisplay()</summary>
L_DISPLAY_WITH_XZGV
''' <summary>Use xli with pixDisplay()</summary>
L_DISPLAY_WITH_XLI
''' <summary>Use xv with pixDisplay()</summary>
L_DISPLAY_WITH_XV
''' <summary>Use irfvanview (win) with pixDisplay()</summary>
L_DISPLAY_WITH_IV
''' <summary>Use open (apple) with pixDisplay()</summary>
L_DISPLAY_WITH_OPEN
End Enum


'SRC/pix.h (1277, 1)
''' <summary>
''' Flags used in Pix::special
''' </summary>
Public Enum Unnamed_Enum_1
''' <summary>Write full resolution chroma</summary>
L_NO_CHROMA_SAMPLING_JPEG
End Enum


'SRC/pix.h (1287, 1)
''' <summary>
''' Handling negative values in conversion to unsigned int
''' </summary>
Public Enum L_hling_negative_values_in_conversion_to_unsigned_int
''' <summary>Clip negative values to 0</summary>
L_CLIP_TO_ZERO
''' <summary>Convert to positive using L_ABS()</summary>
L_TAKE_ABSVAL
End Enum


'SRC/pix.h (1298, 1)
''' <summary>
''' Relative to zero flags
''' </summary>
Public Enum L_ZERO
''' <summary>Choose values less than zero</summary>
L_LESS_THAN_ZERO
''' <summary>Choose values equal to zero</summary>
L_EQUAL_TO_ZERO
''' <summary>Choose values greater than zero</summary>
L_GREATER_THAN_ZERO
End Enum


'SRC/pix.h (1310, 1)
''' <summary>
''' Flags for adding or removing traling slash from string
''' </summary>
Public Enum L_TRAIL_SLASH
''' <summary>Add trailing slash to string</summary>
L_ADD_TRAIL_SLASH
''' <summary>Remove trailing slash from string</summary>
L_REMOVE_TRAIL_SLASH
End Enum

#End Region
#Region "SRC/recog.h"

'SRC/recog.h (245, 1)
''' <summary>
''' Flags for describing limited character sets
''' </summary>
Public Enum L__describing_limited_character_sets
''' <summary>character set type is not specified</summary>
L_UNKNOWN
''' <summary>10 digits</summary>
L_ARABIC_NUMERALS
''' <summary>7 lower-case letters (i,v,x,l,c,d,m)</summary>
L_LC_ROMAN_NUMERALS
''' <summary>7 upper-case letters (I,V,X,L,C,D,M)</summary>
L_UC_ROMAN_NUMERALS
''' <summary>26 lower-case letters</summary>
L_LC_ALPHA
''' <summary>26 upper-case letters</summary>
L_UC_ALPHA
End Enum


'SRC/recog.h (258, 1)
''' <summary>
''' Flags for selecting average or all templates: recog->templ_use
''' </summary>
Public Enum L_USE_A_TEMPLATES
''' <summary>use all templates; default</summary>
L_USE_ALL_TEMPLATES
''' <summary>use average templates; special cases</summary>
L_USE_AVERAGE_TEMPLATES
End Enum

#End Region
#Region "SRC/regutils.h"

'SRC/regutils.h (132, 1)
''' <summary>
''' Running modes for the test
''' </summary>
Public Enum L_REG
''' <summary></summary>
L_REG_GENERATE
''' <summary></summary>
L_REG_COMPARE
''' <summary></summary>
L_REG_DISPLAY
End Enum

#End Region
#Region "SRC/stringcode.h"

'SRC/stringcode.h (53, 1)
''' <summary>
''' Select string in stringcode for a specific serializable data type
''' </summary>
Public Enum L_STR
''' <summary>typedef for the data type</summary>
L_STR_TYPE
''' <summary>name of the data type</summary>
L_STR_NAME
''' <summary>reader to get the data type from file</summary>
L_STR_READER
''' <summary>reader to get the compressed string in memory</summary>
L_STR_MEMREADER
End Enum

#End Region
#Region "SRC/sudoku.h"

'SRC/sudoku.h (69, 1)
''' <summary>
''' For printing out array data
''' </summary>
Public Enum L_SUDOKU
''' <summary></summary>
L_SUDOKU_INIT
''' <summary></summary>
L_SUDOKU_STATE
End Enum

#End Region
#Region "SRC/readbarcode.h"

'SRC/readbarcode.h (35, 1)
''' <summary>
''' Flags for method of extracting barcode widths
''' </summary>
Public Enum L_USE_WIS
''' <summary>use histogram of barcode widths</summary>
L_USE_WIDTHS
''' <summary>find best window for decoding transitions</summary>
L_USE_WINDOWS
End Enum


'SRC/readbarcode.h (47, 1)
''' <summary>
''' Flags for barcode formats
''' </summary>
Public Enum L_BF
''' <summary>unknown format</summary>
L_BF_UNKNOWN
''' <summary>try decoding with all known formats</summary>
L_BF_ANY
''' <summary>decode with Code128 format</summary>
L_BF_CODE128
''' <summary>decode with EAN8 format</summary>
L_BF_EAN8
''' <summary>decode with EAN13 format</summary>
L_BF_EAN13
''' <summary>decode with Code 2 of 5 format</summary>
L_BF_CODE2OF5
''' <summary>decode with Interleaved 2 of 5 format</summary>
L_BF_CODEI2OF5
''' <summary>decode with Code39 format</summary>
L_BF_CODE39
''' <summary>decode with Code93 format</summary>
L_BF_CODE93
''' <summary>decode with Code93 format</summary>
L_BF_CODABAR
''' <summary>decode with UPC A format</summary>
L_BF_UPCA
End Enum

#End Region
#Region "SRC\maze.c"

'SRC\maze.c (68, 1)
''' <summary>
''' 
''' </summary>
Public Enum Unnamed_Enum_2
''' <summary></summary>
START_LOC
''' <summary></summary>
DIR_NORTH
''' <summary></summary>
DIR_SOUTH
''' <summary></summary>
DIR_WEST
''' <summary></summary>
DIR_EAST
End Enum

#End Region
#Region "SRC\rbtree.c"

'SRC\rbtree.c (77, 1)
''' <summary>
''' 
''' </summary>
Public Enum L_NODE
''' <summary></summary>
L_RED_NODE
''' <summary></summary>
L_BLACK_NODE
End Enum

#End Region
End Namespace

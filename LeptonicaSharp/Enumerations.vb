Namespace Enumerations
#Region "SRC/environ.h"

'SRC/environ.h (286, 1)
''' <summary>
''' Simple search state variables
''' </summary>
Public Enum L_FOUND
''' <summary></summary>
L_NOT_FOUND = 0
''' <summary></summary>
L_FOUND = 1
End Enum


'SRC/environ.h (296, 1)
''' <summary>
''' Path separator conversion
''' </summary>
Public Enum PATH_SEPCHAR
''' <summary></summary>
UNIX_PATH_SEPCHAR = 0
''' <summary></summary>
WIN_PATH_SEPCHAR = 1
End Enum


'SRC/environ.h (369, 1)
''' <summary>
''' Control printing of error, warning and info messages
''' </summary>
Public Enum L_SEVERITY
''' <summary></summary>
L_SEVERITY_EXTERNAL = 0
''' <summary></summary>
L_SEVERITY_ALL = 1
''' <summary></summary>
L_SEVERITY_DEBUG = 2
''' <summary></summary>
L_SEVERITY_INFO = 3
''' <summary></summary>
L_SEVERITY_WARNING = 4
''' <summary></summary>
L_SEVERITY_ERROR = 5
''' <summary></summary>
L_SEVERITY_NONE = 6
End Enum

#End Region
#Region "SRC/array.h"

'SRC/array.h (140, 1)
''' <summary>
''' Flags for interpolation in Numa
''' </summary>
Public Enum L_INTERP
''' <summary>smaller  linear</summary>
L_LINEAR_INTERP = 1
''' <summary>smaller  quadratic</summary>
L_QUADRATIC_INTERP = 2
End Enum


'SRC/array.h (146, 1)
''' <summary>
''' Flags for added borders in Numa and Fpix
''' </summary>
Public Enum L_BORDER
''' <summary>smaller  extended with same value</summary>
L_CONTINUED_BORDER = 1
''' <summary>smaller  extended with constant normal derivative</summary>
L_SLOPE_BORDER = 2
''' <summary>smaller  mirrored</summary>
L_MIRRORED_BORDER = 3
End Enum


'SRC/array.h (153, 1)
''' <summary>
''' Flags for data type converted from Numa
''' </summary>
Public Enum L_VALUE
''' <summary>smaller  convert to integer</summary>
L_INTEGER_VALUE = 1
''' <summary>smaller  convert to float</summary>
L_FLOAT_VALUE = 2
End Enum

#End Region
#Region "SRC/ptra.h"

'SRC/ptra.h (76, 1)
''' <summary>
''' Flags for removal from L_Ptra
''' </summary>
Public Enum L_COMPACTION
''' <summary>smaller  null the pointer only</summary>
L_NO_COMPACTION = 1
''' <summary>smaller  compact the array</summary>
L_COMPACTION = 2
End Enum


'SRC/ptra.h (82, 1)
''' <summary>
''' Flags for insertion into L_Ptra
''' </summary>
Public Enum L_DOWNSHIFT
''' <summary>smaller  choose based on number of holes</summary>
L_AUTO_DOWNSHIFT = 0
''' <summary>smaller  downshifts min # of ptrs below insert</summary>
L_MIN_DOWNSHIFT = 1
''' <summary>smaller  downshifts all ptrs below insert</summary>
L_FULL_DOWNSHIFT = 2
End Enum


'SRC/ptra.h (89, 1)
''' <summary>
''' Accessor flags for L_Ptraa
''' </summary>
Public Enum L_accessor__l_ptraa
''' <summary>smaller  ptr to L_Ptra; caller can inspect only</summary>
L_HANDLE_ONLY = 0
''' <summary>smaller  caller owns; destroy or save in L_Ptraa</summary>
L_REMOVE = 1
End Enum

#End Region
#Region "SRC/rbtree.h"

'SRC/rbtree.h (47, 1)
''' <summary>
''' The three valid key types for red-black trees, maps and sets.
''' </summary>
Public Enum L_T_TYPE
''' <summary></summary>
L_INT_TYPE = 1
''' <summary></summary>
L_UINT_TYPE = 2
''' <summary></summary>
L_FLOAT_TYPE = 3
End Enum

#End Region
#Region "SRC/bmf.h"

'SRC/bmf.h (37, 1)
''' <summary>
''' Constants for deciding when text block is divided into paragraphs
''' </summary>
Public Enum SPLIT_ON
''' <summary>smaller  tab or space at beginning of line</summary>
SPLIT_ON_LEADING_WHITE = 1
''' <summary>smaller  newline with optional white space</summary>
SPLIT_ON_BLANK_LINE = 2
''' <summary>smaller  leading white space or newline</summary>
SPLIT_ON_BOTH = 3
End Enum

#End Region
#Region "SRC/ccbord.h"

'SRC/ccbord.h (40, 1)
''' <summary>
''' Use in ccbaStepChainsToPixCoords()
''' </summary>
Public Enum CCB_AL_COORDS
''' <summary></summary>
CCB_LOCAL_COORDS = 1
''' <summary></summary>
CCB_GLOBAL_COORDS = 2
End Enum


'SRC/ccbord.h (46, 1)
''' <summary>
''' Use in ccbaGenerateSPGlobalLocs()
''' </summary>
Public Enum CCB_SAVE_PTS
''' <summary></summary>
CCB_SAVE_ALL_PTS = 1
''' <summary></summary>
CCB_SAVE_TURNING_PTS = 2
End Enum

#End Region
#Region "SRC/gplot.h"

'SRC/gplot.h (47, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_STYLE
''' <summary></summary>
GPLOT_LINES = 0
''' <summary></summary>
GPLOT_POINTS = 1
''' <summary></summary>
GPLOT_IMPULSES = 2
''' <summary></summary>
GPLOT_LINESPOINTS = 3
''' <summary></summary>
GPLOT_DOTS = 4
End Enum


'SRC/gplot.h (56, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_OUTPUT
''' <summary></summary>
GPLOT_NONE = 0
''' <summary></summary>
GPLOT_PNG = 1
''' <summary></summary>
GPLOT_PS = 2
''' <summary></summary>
GPLOT_EPS = 3
''' <summary></summary>
GPLOT_LATEX = 4
End Enum


'SRC/gplot.h (64, 6)
''' <summary>
''' 
''' </summary>
Public Enum GPLOT_SCALING
''' <summary>smaller  default</summary>
GPLOT_LINEAR_SCALE = 0
''' <summary></summary>
GPLOT_LOG_SCALE_X = 1
''' <summary></summary>
GPLOT_LOG_SCALE_Y = 2
''' <summary></summary>
GPLOT_LOG_SCALE_X_Y = 3
End Enum

#End Region
#Region "SRC/imageio.h"

'SRC/imageio.h (91, 1)
''' <summary>
''' Image file format types
''' </summary>
Public Enum IFF
''' <summary></summary>
IFF_UNKNOWN = 0
''' <summary></summary>
IFF_BMP = 1
''' <summary></summary>
IFF_JFIF_JPEG = 2
''' <summary></summary>
IFF_PNG = 3
''' <summary></summary>
IFF_TIFF = 4
''' <summary></summary>
IFF_TIFF_PACKBITS = 5
''' <summary></summary>
IFF_TIFF_RLE = 6
''' <summary></summary>
IFF_TIFF_G3 = 7
''' <summary></summary>
IFF_TIFF_G4 = 8
''' <summary></summary>
IFF_TIFF_LZW = 9
''' <summary></summary>
IFF_TIFF_ZIP = 10
''' <summary></summary>
IFF_PNM = 11
''' <summary></summary>
IFF_PS = 12
''' <summary></summary>
IFF_GIF = 13
''' <summary></summary>
IFF_JP2 = 14
''' <summary></summary>
IFF_WEBP = 15
''' <summary></summary>
IFF_LPDF = 16
''' <summary></summary>
IFF_DEFAULT = 17
''' <summary></summary>
IFF_SPIX = 18
End Enum


'SRC/imageio.h (119, 1)
''' <summary>
''' Format header ids
''' </summary>
Public Enum ID
''' <summary>smaller  BM - for bitmaps</summary>
BMP_ID = 19778
''' <summary>smaller  MM - for 'motorola'</summary>
TIFF_BIGEND_ID = 19789
''' <summary>smaller  II - for 'intel'</summary>
TIFF_LITTLEEND_ID = 18761
End Enum


'SRC/imageio.h (131, 1)
''' <summary>
''' Hinting bit flags in jpeg reader
''' </summary>
Public Enum L_JPEG
''' <summary>smaller  only want luminance data; no chroma</summary>
L_JPEG_READ_LUMINANCE = 1
''' <summary>smaller  don't return possibly damaged pix</summary>
L_JPEG_FAIL_ON_BAD_DATA = 2
End Enum


'SRC/imageio.h (142, 1)
''' <summary>
''' Pdf formatted encoding types
''' </summary>
Public Enum L_ENCODE
''' <summary>smaller  use default encoding based on image</summary>
L_DEFAULT_ENCODE = 0
''' <summary>smaller  use dct encoding: 8 and 32 bpp, no cmap</summary>
L_JPEG_ENCODE = 1
''' <summary>smaller  use ccitt g4 fax encoding: 1 bpp</summary>
L_G4_ENCODE = 2
''' <summary>smaller  use flate encoding: any depth, cmap ok</summary>
L_FLATE_ENCODE = 3
''' <summary>smaller  use jp2k encoding: 8 and 32 bpp, no cmap</summary>
L_JP2K_ENCODE = 4
End Enum


'SRC/imageio.h (193, 1)
''' <summary>
''' Pdf multi image flags
''' </summary>
Public Enum L_T_IMAGE
''' <summary>smaller  first image to be used</summary>
L_FIRST_IMAGE = 1
''' <summary>smaller  intermediate image; not first or last</summary>
L_NEXT_IMAGE = 2
''' <summary>smaller  last image to be used</summary>
L_LAST_IMAGE = 3
End Enum

#End Region
#Region "SRC/jbclass.h"

'SRC/jbclass.h (123, 1)
''' <summary>
''' Classifier methods
''' </summary>
Public Enum JB
''' <summary></summary>
JB_RANKHAUS = 0
''' <summary></summary>
JB_CORRELATION = 1
End Enum


'SRC/jbclass.h (129, 1)
''' <summary>
''' For jbGetComponents(): type of component to extract from images
''' </summary>
Public Enum JB_S
''' <summary></summary>
JB_CONN_COMPS = 0
''' <summary></summary>
JB_CHARACTERS = 1
''' <summary></summary>
JB_WORDS = 2
End Enum

#End Region
#Region "SRC/morph.h"

'SRC/morph.h (109, 1)
''' <summary>
''' Morphological boundary condition flags
''' </summary>
Public Enum MMETRIC_MORPH_BC
''' <summary></summary>
SYMMETRIC_MORPH_BC = 0
''' <summary></summary>
ASYMMETRIC_MORPH_BC = 1
End Enum


'SRC/morph.h (119, 1)
''' <summary>
''' Structuring element types
''' </summary>
Public Enum SEL
''' <summary></summary>
SEL_DONT_CARE = 0
''' <summary></summary>
SEL_HIT = 1
''' <summary></summary>
SEL_MISS = 2
End Enum


'SRC/morph.h (130, 1)
''' <summary>
''' Runlength flags for granulometry
''' </summary>
Public Enum L_RUN_O
''' <summary></summary>
L_RUN_OFF = 0
''' <summary></summary>
L_RUN_ON = 1
End Enum


'SRC/morph.h (141, 1)
''' <summary>
''' Direction flags
''' </summary>
Public Enum L_direction
''' <summary></summary>
L_HORIZ = 1
''' <summary></summary>
L_VERT = 2
''' <summary></summary>
L_BOTH_DIRECTIONS = 3
End Enum


'SRC/morph.h (152, 1)
''' <summary>
''' Morphological operation flags
''' </summary>
Public Enum L_MORPH
''' <summary></summary>
L_MORPH_DILATE = 1
''' <summary></summary>
L_MORPH_ERODE = 2
''' <summary></summary>
L_MORPH_OPEN = 3
''' <summary></summary>
L_MORPH_CLOSE = 4
''' <summary></summary>
L_MORPH_HMT = 5
End Enum


'SRC/morph.h (165, 1)
''' <summary>
''' Grayscale intensity scaling flags
''' </summary>
Public Enum L_L_SCALE
''' <summary></summary>
L_LINEAR_SCALE = 1
''' <summary></summary>
L_LOG_SCALE = 2
End Enum


'SRC/morph.h (175, 1)
''' <summary>
''' Morphological tophat flags
''' </summary>
Public Enum L_TOPHAT
''' <summary></summary>
L_TOPHAT_WHITE = 0
''' <summary></summary>
L_TOPHAT_BLACK = 1
End Enum


'SRC/morph.h (186, 1)
''' <summary>
''' Arithmetic and logical operator flags
''' </summary>
Public Enum L_arithmetic_logical_operator
''' <summary></summary>
L_ARITH_ADD = 1
''' <summary></summary>
L_ARITH_SUBTRACT = 2
''' <summary></summary>
L_ARITH_MULTIPLY = 3
''' <summary></summary>
L_ARITH_DIVIDE = 4
''' <summary></summary>
L_UNION = 5
''' <summary></summary>
L_INTERSECTION = 6
''' <summary></summary>
L_SUBTRACTION = 7
''' <summary></summary>
L_EXCLUSIVE_OR = 8
End Enum


'SRC/morph.h (202, 1)
''' <summary>
''' Min/max selection flags
''' </summary>
Public Enum L_CHOOSE_M
''' <summary></summary>
L_CHOOSE_MIN = 1
''' <summary></summary>
L_CHOOSE_MAX = 2
''' <summary></summary>
L_CHOOSE_MAXDIFF = 3
''' <summary></summary>
L_CHOOSE_MIN_BOOST = 4
''' <summary></summary>
L_CHOOSE_MAX_BOOST = 5
End Enum


'SRC/morph.h (215, 1)
''' <summary>
''' Distance function b.c. flags
''' </summary>
Public Enum L_BOUNDARY_G
''' <summary></summary>
L_BOUNDARY_BG = 1
''' <summary></summary>
L_BOUNDARY_FG = 2
End Enum


'SRC/morph.h (225, 1)
''' <summary>
''' Image comparison flags
''' </summary>
Public Enum L_COMPARE
''' <summary></summary>
L_COMPARE_XOR = 1
''' <summary></summary>
L_COMPARE_SUBTRACT = 2
''' <summary></summary>
L_COMPARE_ABS_DIFF = 3
End Enum


'SRC/morph.h (236, 1)
''' <summary>
''' Color content flags
''' </summary>
Public Enum L_MAX
''' <summary></summary>
L_MAX_DIFF_FROM_AVERAGE_2 = 1
''' <summary></summary>
L_MAX_MIN_DIFF_FROM_2 = 2
''' <summary></summary>
L_MAX_DIFF = 3
End Enum

#End Region
#Region "SRC/pix.h"

'SRC/pix.h (200, 1)
''' <summary>
''' Colors for 32 bpp
''' </summary>
Public Enum colors_32_bpp
''' <summary>smaller  red color index in RGBA_QUAD</summary>
COLOR_RED = 0
''' <summary>smaller  green color index in RGBA_QUAD</summary>
COLOR_GREEN = 1
''' <summary>smaller  blue color index in RGBA_QUAD</summary>
COLOR_BLUE = 2
''' <summary>smaller  alpha value index in RGBA_QUAD</summary>
L_ALPHA_CHANNEL = 3
End Enum


'SRC/pix.h (221, 1)
''' <summary>
''' Colors for drawing boxes
''' </summary>
Public Enum L_DRAW
''' <summary>smaller  draw in red</summary>
L_DRAW_RED = 0
''' <summary>smaller  draw in green</summary>
L_DRAW_GREEN = 1
''' <summary>smaller  draw in blue</summary>
L_DRAW_BLUE = 2
''' <summary>smaller  draw specified color</summary>
L_DRAW_SPECIFIED = 3
''' <summary>smaller  draw as sequence of r,g,b</summary>
L_DRAW_RGB = 4
''' <summary>smaller  draw randomly chosen colors</summary>
L_DRAW_RANDOM = 5
End Enum


'SRC/pix.h (252, 1)
''' <summary>
''' Flags for colormap conversion
''' </summary>
Public Enum REMOVE_CMAP
''' <summary>smaller  remove colormap for conv to 1 bpp</summary>
REMOVE_CMAP_TO_BINARY = 0
''' <summary>smaller  remove colormap for conv to 8 bpp</summary>
REMOVE_CMAP_TO_GRAYSCALE = 1
''' <summary>smaller  remove colormap for conv to 32 bpp</summary>
REMOVE_CMAP_TO_FULL_COLOR = 2
''' <summary>smaller  remove colormap and alpha</summary>
REMOVE_CMAP_WITH_ALPHA = 3
''' <summary>smaller  remove depending on src format</summary>
REMOVE_CMAP_BASED_ON_SRC = 4
End Enum


'SRC/pix.h (715, 1)
''' <summary>
''' Access and storage flags
''' </summary>
Public Enum L_access_storage
''' <summary>smaller  do not copy the object; do not delete the ptr</summary>
L_NOCOPY = 0
''' <summary>smaller  stuff it in; do not copy or clone</summary>
L_INSERT = 0
''' <summary>smaller  make/use a copy of the object</summary>
L_COPY = 1
''' <summary>smaller  make/use clone (ref count) of the object</summary>
L_CLONE = 2
''' <summary>smaller  make a new array object (e.g., pixa) and fill    smaller  the array with clones (e.g., pix)</summary>
L_COPY_CLONE = 3
End Enum


'SRC/pix.h (730, 1)
''' <summary>
''' Sort mode flags
''' </summary>
Public Enum L_SORT
''' <summary>smaller  use shell sort</summary>
L_SHELL_SORT = 1
''' <summary>smaller  use bin sort</summary>
L_BIN_SORT = 2
End Enum


'SRC/pix.h (736, 1)
''' <summary>
''' Sort order flags
''' </summary>
Public Enum L_SORT_CREASING
''' <summary>smaller  sort in increasing order</summary>
L_SORT_INCREASING = 1
''' <summary>smaller  sort in decreasing order</summary>
L_SORT_DECREASING = 2
End Enum


'SRC/pix.h (742, 1)
''' <summary>
''' Sort type flags
''' </summary>
Public Enum L_SORT_BY
''' <summary>smaller  sort box or c.c. by left edge location</summary>
L_SORT_BY_X = 1
''' <summary>smaller  sort box or c.c. by top edge location</summary>
L_SORT_BY_Y = 2
''' <summary>smaller  sort box or c.c. by right edge location</summary>
L_SORT_BY_RIGHT = 3
''' <summary>smaller  sort box or c.c. by bot edge location</summary>
L_SORT_BY_BOT = 4
''' <summary>smaller  sort box or c.c. by width</summary>
L_SORT_BY_WIDTH = 5
''' <summary>smaller  sort box or c.c. by height</summary>
L_SORT_BY_HEIGHT = 6
''' <summary>smaller  sort box or c.c. by min dimension</summary>
L_SORT_BY_MIN_DIMENSION = 7
''' <summary>smaller  sort box or c.c. by max dimension</summary>
L_SORT_BY_MAX_DIMENSION = 8
''' <summary>smaller  sort box or c.c. by perimeter</summary>
L_SORT_BY_PERIMETER = 9
''' <summary>smaller  sort box or c.c. by area</summary>
L_SORT_BY_AREA = 10
''' <summary>smaller  sort box or c.c. by width/height ratio</summary>
L_SORT_BY_ASPECT_RATIO = 11
End Enum


'SRC/pix.h (762, 1)
''' <summary>
''' Blend flags
''' </summary>
Public Enum L_BLEND
''' <summary>smaller  add some of src inverse to itself</summary>
L_BLEND_WITH_INVERSE = 1
''' <summary>smaller  shift src colors towards white</summary>
L_BLEND_TO_WHITE = 2
''' <summary>smaller  shift src colors towards black</summary>
L_BLEND_TO_BLACK = 3
''' <summary>smaller  blend src directly with blender</summary>
L_BLEND_GRAY = 4
''' <summary>smaller  add amount of src inverse to itself,    smaller  based on blender pix value</summary>
L_BLEND_GRAY_WITH_INVERSE = 5
End Enum


'SRC/pix.h (771, 1)
''' <summary>
''' 
''' </summary>
Public Enum L_PAINT
''' <summary>smaller  colorize non-black pixels</summary>
L_PAINT_LIGHT = 1
''' <summary>smaller  colorize non-white pixels</summary>
L_PAINT_DARK = 2
End Enum


'SRC/pix.h (782, 1)
''' <summary>
''' Graphics pixel setting
''' </summary>
Public Enum L_PIXELS
''' <summary>smaller  set all bits in each pixel to 1</summary>
L_SET_PIXELS = 1
''' <summary>smaller  set all bits in each pixel to 0</summary>
L_CLEAR_PIXELS = 2
''' <summary>smaller  flip all bits in each pixel</summary>
L_FLIP_PIXELS = 3
End Enum


'SRC/pix.h (794, 1)
''' <summary>
''' Location filter flags
''' </summary>
Public Enum L_SELECT
''' <summary>smaller  width must satisfy constraint</summary>
L_SELECT_WIDTH = 1
''' <summary>smaller  height must satisfy constraint</summary>
L_SELECT_HEIGHT = 2
''' <summary>smaller  x value satisfy constraint</summary>
L_SELECT_XVAL = 3
''' <summary>smaller  y value must satisfy constraint</summary>
L_SELECT_YVAL = 4
''' <summary>smaller  either width or height (or xval    smaller  or yval) can satisfy</summary>
L_SELECT_IF_EITHER = 5
''' <summary>smaller  both width and height (or xval     smaller  and yval must satisfy</summary>
L_SELECT_IF_BOTH = 6
End Enum


'SRC/pix.h (806, 1)
''' <summary>
''' Size filter flags
''' </summary>
Public Enum L_SELECT_IF
''' <summary>smaller  save if value is less than threshold</summary>
L_SELECT_IF_LT = 1
''' <summary>smaller  save if value is more than threshold</summary>
L_SELECT_IF_GT = 2
''' <summary>smaller  save if value is  smaller = to the threshold</summary>
L_SELECT_IF_LTE = 3
''' <summary>smaller  save if value is  bigger = to the threshold</summary>
L_SELECT_IF_GTE = 4
End Enum


'SRC/pix.h (819, 1)
''' <summary>
''' Color component selection flags
''' </summary>
Public Enum L_SELECT_
''' <summary>smaller  use red component</summary>
L_SELECT_RED = 1
''' <summary>smaller  use green component</summary>
L_SELECT_GREEN = 2
''' <summary>smaller  use blue component</summary>
L_SELECT_BLUE = 3
''' <summary>smaller  use min color component</summary>
L_SELECT_MIN = 4
''' <summary>smaller  use max color component</summary>
L_SELECT_MAX = 5
''' <summary>smaller  use average of color components</summary>
L_SELECT_AVERAGE = 6
''' <summary>smaller  use hue value (in HSV color space)</summary>
L_SELECT_HUE = 7
''' <summary>smaller  use saturation value (in HSV space)</summary>
L_SELECT_SATURATION = 8
End Enum


'SRC/pix.h (836, 1)
''' <summary>
''' 16-bit conversion flags
''' </summary>
Public Enum L_16_bit_conversion
''' <summary>smaller  use LSB</summary>
L_LS_BYTE = 1
''' <summary>smaller  use MSB</summary>
L_MS_BYTE = 2
''' <summary>smaller  use LSB if max(val)  smaller  256; else MSB</summary>
L_AUTO_BYTE = 3
''' <summary>smaller  use max(val, 255)</summary>
L_CLIP_TO_FF = 4
''' <summary>smaller  use two LSB</summary>
L_LS_TWO_BYTES = 5
''' <summary>smaller  use two MSB</summary>
L_MS_TWO_BYTES = 6
''' <summary>smaller  use max(val, 65535)</summary>
L_CLIP_TO_FFFF = 7
End Enum


'SRC/pix.h (852, 1)
''' <summary>
''' Rotate flags
''' </summary>
Public Enum L_ROTATE
''' <summary>smaller  use area map rotation, if possible</summary>
L_ROTATE_AREA_MAP = 1
''' <summary>smaller  use shear rotation</summary>
L_ROTATE_SHEAR = 2
''' <summary>smaller  use sampling</summary>
L_ROTATE_SAMPLING = 3
End Enum


'SRC/pix.h (859, 1)
''' <summary>
''' Background flags
''' </summary>
Public Enum L_BRING_IN
''' <summary>smaller  bring in white pixels from the outside</summary>
L_BRING_IN_WHITE = 1
''' <summary>smaller  bring in black pixels from the outside</summary>
L_BRING_IN_BLACK = 2
End Enum


'SRC/pix.h (865, 1)
''' <summary>
''' Shear flags
''' </summary>
Public Enum L_SHEAR_ABOUT_CER
''' <summary>smaller  shear image about UL corner</summary>
L_SHEAR_ABOUT_CORNER = 1
''' <summary>smaller  shear image about center</summary>
L_SHEAR_ABOUT_CENTER = 2
End Enum


'SRC/pix.h (876, 1)
''' <summary>
''' Affine transform order flags
''' </summary>
Public Enum L_affine_transm_order
''' <summary>smaller  translate, scale, rotate</summary>
L_TR_SC_RO = 1
''' <summary>smaller  scale, rotate, translate</summary>
L_SC_RO_TR = 2
''' <summary>smaller  rotate, translate, scale</summary>
L_RO_TR_SC = 3
''' <summary>smaller  translate, rotate, scale</summary>
L_TR_RO_SC = 4
''' <summary>smaller  rotate, scale, translate</summary>
L_RO_SC_TR = 5
''' <summary>smaller  scale, translate, rotate</summary>
L_SC_TR_RO = 6
End Enum


'SRC/pix.h (891, 1)
''' <summary>
''' Grayscale filling flags
''' </summary>
Public Enum L_FILL
''' <summary>smaller  fill white pixels (e.g, in fg map)</summary>
L_FILL_WHITE = 1
''' <summary>smaller  fill black pixels (e.g., in bg map)</summary>
L_FILL_BLACK = 2
End Enum


'SRC/pix.h (902, 1)
''' <summary>
''' Flags for setting to white or black
''' </summary>
Public Enum L_SET
''' <summary>smaller  set pixels to white</summary>
L_SET_WHITE = 1
''' <summary>smaller  set pixels to black</summary>
L_SET_BLACK = 2
End Enum


'SRC/pix.h (913, 1)
''' <summary>
''' Flags for getting white or black value
''' </summary>
Public Enum L_GET_VAL
''' <summary>smaller  get white pixel value</summary>
L_GET_WHITE_VAL = 1
''' <summary>smaller  get black pixel value</summary>
L_GET_BLACK_VAL = 2
End Enum


'SRC/pix.h (924, 1)
''' <summary>
''' Flags for 8 bit and 16 bit pixel sums
''' </summary>
Public Enum L_IS_MAX
''' <summary>smaller  white pixels are 0xff or 0xffff; black are 0</summary>
L_WHITE_IS_MAX = 1
''' <summary>smaller  black pixels are 0xff or 0xffff; white are 0</summary>
L_BLACK_IS_MAX = 2
End Enum


'SRC/pix.h (937, 1)
''' <summary>
''' Dither parameters
''' </summary>
Public Enum DEFAULT_CLIP
''' <summary>smaller  dist to black with no prop; 1 bpp</summary>
DEFAULT_CLIP_LOWER_1 = 10
''' <summary>smaller  dist to black with no prop; 1 bpp</summary>
DEFAULT_CLIP_UPPER_1 = 10
''' <summary>smaller  dist to black with no prop; 2 bpp</summary>
DEFAULT_CLIP_LOWER_2 = 5
''' <summary>smaller  dist to black with no prop; 2 bpp</summary>
DEFAULT_CLIP_UPPER_2 = 5
End Enum


'SRC/pix.h (950, 1)
''' <summary>
''' Distance flags
''' </summary>
Public Enum L_AN_DISTANCE
''' <summary>smaller  L1 distance (e.g., in color space)</summary>
L_MANHATTAN_DISTANCE = 1
''' <summary>smaller  L2 distance</summary>
L_EUCLIDEAN_DISTANCE = 2
End Enum


'SRC/pix.h (961, 1)
''' <summary>
''' Value flags
''' </summary>
Public Enum L_value_
''' <summary>smaller  values  smaller  0</summary>
L_NEGATIVE = 1
''' <summary>smaller  values  bigger = 0</summary>
L_NON_NEGATIVE = 2
''' <summary>smaller  values  bigger  0</summary>
L_POSITIVE = 3
''' <summary>smaller  values  smaller = 0</summary>
L_NON_POSITIVE = 4
''' <summary>smaller  values = 0</summary>
L_ZERO = 5
''' <summary>smaller  all values</summary>
L_ALL = 6
End Enum


'SRC/pix.h (976, 1)
''' <summary>
''' Statistical measures
''' </summary>
Public Enum L_statistical_measures
''' <summary>smaller  average of abs values</summary>
L_MEAN_ABSVAL = 1
''' <summary>smaller  median value of set</summary>
L_MEDIAN_VAL = 2
''' <summary>smaller  mode value of set</summary>
L_MODE_VAL = 3
''' <summary>smaller  mode count of set</summary>
L_MODE_COUNT = 4
''' <summary>smaller  rms of values</summary>
L_ROOT_MEAN_SQUARE = 5
''' <summary>smaller  standard deviation from mean</summary>
L_STANDARD_DEVIATION = 6
''' <summary>smaller  variance of values</summary>
L_VARIANCE = 7
End Enum


'SRC/pix.h (992, 1)
''' <summary>
''' Set selection flags
''' </summary>
Public Enum L_CHOOSE
''' <summary>smaller  select 'n' consecutive</summary>
L_CHOOSE_CONSECUTIVE = 1
''' <summary>smaller  select at intervals of 'n'</summary>
L_CHOOSE_SKIP_BY = 2
End Enum


'SRC/pix.h (1003, 1)
''' <summary>
''' Text orientation flags
''' </summary>
Public Enum L_TEXT_ORIENT
''' <summary>smaller  low confidence on text orientation</summary>
L_TEXT_ORIENT_UNKNOWN = 0
''' <summary>smaller  portrait, text rightside-up</summary>
L_TEXT_ORIENT_UP = 1
''' <summary>smaller  landscape, text up to left</summary>
L_TEXT_ORIENT_LEFT = 2
''' <summary>smaller  portrait, text upside-down</summary>
L_TEXT_ORIENT_DOWN = 3
''' <summary>smaller  landscape, text up to right</summary>
L_TEXT_ORIENT_RIGHT = 4
End Enum


'SRC/pix.h (1017, 1)
''' <summary>
''' Edge orientation flags
''' </summary>
Public Enum L_L_EDGES
''' <summary>smaller  filters for horizontal edges</summary>
L_HORIZONTAL_EDGES = 0
''' <summary>smaller  filters for vertical edges</summary>
L_VERTICAL_EDGES = 1
''' <summary>smaller  filters for all edges</summary>
L_ALL_EDGES = 2
End Enum


'SRC/pix.h (1029, 1)
''' <summary>
''' Line orientation flags
''' </summary>
Public Enum L_LINE
''' <summary>smaller  horizontal line</summary>
L_HORIZONTAL_LINE = 0
''' <summary>smaller  45 degree line with positive slope</summary>
L_POS_SLOPE_LINE = 1
''' <summary>smaller  vertical line</summary>
L_VERTICAL_LINE = 2
''' <summary>smaller  45 degree line with negative slope</summary>
L_NEG_SLOPE_LINE = 3
''' <summary>smaller  neither horizontal nor vertical</summary>
L_OBLIQUE_LINE = 4
End Enum


'SRC/pix.h (1043, 1)
''' <summary>
''' Image orientation flags
''' </summary>
Public Enum L_MODE
''' <summary>smaller  typical: page is viewed with height  bigger  width</summary>
L_PORTRAIT_MODE = 0
''' <summary>smaller  page is viewed at 90 deg to portrait mode</summary>
L_LANDSCAPE_MODE = 1
End Enum


'SRC/pix.h (1054, 1)
''' <summary>
''' Scan direction flags
''' </summary>
Public Enum L_scan_direction
''' <summary>smaller  scan from left</summary>
L_FROM_LEFT = 0
''' <summary>smaller  scan from right</summary>
L_FROM_RIGHT = 1
''' <summary>smaller  scan from top</summary>
L_FROM_TOP = 2
''' <summary>smaller  scan from bottom</summary>
L_FROM_BOT = 3
''' <summary>smaller  scan in negative direction</summary>
L_SCAN_NEGATIVE = 4
''' <summary>smaller  scan in positive direction</summary>
L_SCAN_POSITIVE = 5
''' <summary>smaller  scan in both directions</summary>
L_SCAN_BOTH = 6
''' <summary>smaller  horizontal scan (direction unimportant)</summary>
L_SCAN_HORIZONTAL = 7
''' <summary>smaller  vertical scan (direction unimportant)</summary>
L_SCAN_VERTICAL = 8
End Enum


'SRC/pix.h (1072, 1)
''' <summary>
''' Box size adjustment and location flags
''' </summary>
Public Enum L_box_size_adjustment_location
''' <summary>smaller  do not adjust</summary>
L_ADJUST_SKIP = 0
''' <summary>smaller  adjust left edge</summary>
L_ADJUST_LEFT = 1
''' <summary>smaller  adjust right edge</summary>
L_ADJUST_RIGHT = 2
''' <summary>smaller  adjust both left and right edges</summary>
L_ADJUST_LEFT_AND_RIGHT = 3
''' <summary>smaller  adjust top edge</summary>
L_ADJUST_TOP = 4
''' <summary>smaller  adjust bottom edge</summary>
L_ADJUST_BOT = 5
''' <summary>smaller  adjust both top and bottom edges</summary>
L_ADJUST_TOP_AND_BOT = 6
''' <summary>smaller  choose the min median value</summary>
L_ADJUST_CHOOSE_MIN = 7
''' <summary>smaller  choose the max median value</summary>
L_ADJUST_CHOOSE_MAX = 8
''' <summary>smaller  set left side to a given value</summary>
L_SET_LEFT = 9
''' <summary>smaller  set right side to a given value</summary>
L_SET_RIGHT = 10
''' <summary>smaller  set top side to a given value</summary>
L_SET_TOP = 11
''' <summary>smaller  set bottom side to a given value</summary>
L_SET_BOT = 12
''' <summary>smaller  get left side location</summary>
L_GET_LEFT = 13
''' <summary>smaller  get right side location</summary>
L_GET_RIGHT = 14
''' <summary>smaller  get top side location</summary>
L_GET_TOP = 15
''' <summary>smaller  get bottom side location</summary>
L_GET_BOT = 16
End Enum


'SRC/pix.h (1098, 1)
''' <summary>
''' Flags for modifying box boundaries using a second box
''' </summary>
Public Enum L__modifying_box_boundaries_using_a_second_box
''' <summary>smaller  use boundaries giving min size</summary>
L_USE_MINSIZE = 1
''' <summary>smaller  use boundaries giving max size</summary>
L_USE_MAXSIZE = 2
''' <summary>smaller  modify boundary if big location diff</summary>
L_SUB_ON_LOC_DIFF = 3
''' <summary>smaller  modify boundary if big size diff</summary>
L_SUB_ON_SIZE_DIFF = 4
''' <summary>smaller  modify boundary with capped min</summary>
L_USE_CAPPED_MIN = 5
''' <summary>smaller  modify boundary with capped max</summary>
L_USE_CAPPED_MAX = 6
End Enum


'SRC/pix.h (1112, 1)
''' <summary>
''' Handling overlapping bounding boxes in Boxa
''' </summary>
Public Enum L_hling_overlapping_bounding_boxes_in_boxa
''' <summary>smaller  resize to bounding region; remove smaller</summary>
L_COMBINE = 1
''' <summary>smaller  only remove smaller</summary>
L_REMOVE_SMALL = 2
End Enum


'SRC/pix.h (1122, 1)
''' <summary>
''' Flags for replacing invalid boxes
''' </summary>
Public Enum L_USE_BOXES
''' <summary>smaller  consider all boxes in the sequence</summary>
L_USE_ALL_BOXES = 1
''' <summary>smaller  consider boxes with the same parity</summary>
L_USE_SAME_PARITY_BOXES = 2
End Enum


'SRC/pix.h (1132, 1)
''' <summary>
''' Horizontal warp direction
''' </summary>
Public Enum L_WARP_TO_T
''' <summary>smaller  increasing stretch or contraction to left</summary>
L_WARP_TO_LEFT = 1
''' <summary>smaller  increasing stretch or contraction to right</summary>
L_WARP_TO_RIGHT = 2
End Enum


'SRC/pix.h (1138, 1)
''' <summary>
''' Horizontal warp stretch mode
''' </summary>
Public Enum L_WARP
''' <summary>smaller  stretch or contraction grows linearly</summary>
L_LINEAR_WARP = 1
''' <summary>smaller  stretch or contraction grows quadratically</summary>
L_QUADRATIC_WARP = 2
End Enum


'SRC/pix.h (1149, 1)
''' <summary>
''' Pixel selection for resampling
''' </summary>
Public Enum L_ED
''' <summary>smaller  linear interpolation from src pixels</summary>
L_INTERPOLATED = 1
''' <summary>smaller  nearest src pixel sampling only</summary>
L_SAMPLED = 2
End Enum


'SRC/pix.h (1160, 1)
''' <summary>
''' Thinning flags
''' </summary>
Public Enum L_THIN_G
''' <summary>smaller  thin foreground of 1 bpp image</summary>
L_THIN_FG = 1
''' <summary>smaller  thin background of 1 bpp image</summary>
L_THIN_BG = 2
End Enum


'SRC/pix.h (1171, 1)
''' <summary>
''' Runlength flags
''' </summary>
Public Enum L_AL_RUNS
''' <summary>smaller  determine runlengths of horizontal runs</summary>
L_HORIZONTAL_RUNS = 0
''' <summary>smaller  determine runlengths of vertical runs</summary>
L_VERTICAL_RUNS = 1
End Enum


'SRC/pix.h (1182, 1)
''' <summary>
''' Edge filter flags
''' </summary>
Public Enum L_EDGE
''' <summary>smaller  Sobel edge filter</summary>
L_SOBEL_EDGE = 1
''' <summary>smaller  Two-sided edge filter</summary>
L_TWO_SIDED_EDGE = 2
End Enum


'SRC/pix.h (1193, 1)
''' <summary>
''' Subpixel color component ordering in LC display
''' </summary>
Public Enum L_SUBPIXEL_ORDER
''' <summary>smaller  sensor order left-to-right RGB</summary>
L_SUBPIXEL_ORDER_RGB = 1
''' <summary>smaller  sensor order left-to-right BGR</summary>
L_SUBPIXEL_ORDER_BGR = 2
''' <summary>smaller  sensor order top-to-bottom RGB</summary>
L_SUBPIXEL_ORDER_VRGB = 3
''' <summary>smaller  sensor order top-to-bottom BGR</summary>
L_SUBPIXEL_ORDER_VBGR = 4
End Enum


'SRC/pix.h (1206, 1)
''' <summary>
''' HSV histogram flags
''' </summary>
Public Enum L_HISTO
''' <summary>smaller  Use hue-saturation histogram</summary>
L_HS_HISTO = 1
''' <summary>smaller  Use hue-value histogram</summary>
L_HV_HISTO = 2
''' <summary>smaller  Use saturation-value histogram</summary>
L_SV_HISTO = 3
End Enum


'SRC/pix.h (1218, 1)
''' <summary>
''' Region flags (inclusion, exclusion)
''' </summary>
Public Enum L_CLUDE_REGION
''' <summary>smaller  Use hue-saturation histogram</summary>
L_INCLUDE_REGION = 1
''' <summary>smaller  Use hue-value histogram</summary>
L_EXCLUDE_REGION = 2
End Enum


'SRC/pix.h (1229, 1)
''' <summary>
''' Flags for adding text to a Pix
''' </summary>
Public Enum L_ADD
''' <summary>smaller  Add text above the image</summary>
L_ADD_ABOVE = 1
''' <summary>smaller  Add text below the image</summary>
L_ADD_BELOW = 2
''' <summary>smaller  Add text to the left of the image</summary>
L_ADD_LEFT = 3
''' <summary>smaller  Add text to the right of the image</summary>
L_ADD_RIGHT = 4
''' <summary>smaller  Add text over the top of the image</summary>
L_ADD_AT_TOP = 5
''' <summary>smaller  Add text over the bottom of the image</summary>
L_ADD_AT_BOT = 6
''' <summary>smaller  Add text over left side of the image</summary>
L_ADD_AT_LEFT = 7
''' <summary>smaller  Add text over right side of the image</summary>
L_ADD_AT_RIGHT = 8
End Enum


'SRC/pix.h (1246, 1)
''' <summary>
''' Flags for plotting on a Pix
''' </summary>
Public Enum L_PLOT_AT
''' <summary>smaller  Plot horizontally at top</summary>
L_PLOT_AT_TOP = 1
''' <summary>smaller  Plot horizontally at middle</summary>
L_PLOT_AT_MID_HORIZ = 2
''' <summary>smaller  Plot horizontally at bottom</summary>
L_PLOT_AT_BOT = 3
''' <summary>smaller  Plot vertically at left</summary>
L_PLOT_AT_LEFT = 4
''' <summary>smaller  Plot vertically at middle</summary>
L_PLOT_AT_MID_VERT = 5
''' <summary>smaller  Plot vertically at right</summary>
L_PLOT_AT_RIGHT = 6
End Enum


'SRC/pix.h (1261, 1)
''' <summary>
''' Flags for selecting display program
''' </summary>
Public Enum L_DISPLAY_WITH
''' <summary>smaller  Use xzgv with pixDisplay()</summary>
L_DISPLAY_WITH_XZGV = 1
''' <summary>smaller  Use xli with pixDisplay()</summary>
L_DISPLAY_WITH_XLI = 2
''' <summary>smaller  Use xv with pixDisplay()</summary>
L_DISPLAY_WITH_XV = 3
''' <summary>smaller  Use irfvanview (win) with pixDisplay()</summary>
L_DISPLAY_WITH_IV = 4
''' <summary>smaller  Use open (apple) with pixDisplay()</summary>
L_DISPLAY_WITH_OPEN = 5
End Enum


'SRC/pix.h (1277, 1)
''' <summary>
''' Flags used in Pix::special
''' </summary>
Public Enum Unnamed_Enum_1
''' <summary>smaller  Write full resolution chroma</summary>
L_NO_CHROMA_SAMPLING_JPEG = 1
End Enum


'SRC/pix.h (1287, 1)
''' <summary>
''' Handling negative values in conversion to unsigned int
''' </summary>
Public Enum L_hling_negative_values_in_conversion_to_unsigned_int
''' <summary>smaller  Clip negative values to 0</summary>
L_CLIP_TO_ZERO = 1
''' <summary>smaller  Convert to positive using L_ABS()</summary>
L_TAKE_ABSVAL = 2
End Enum


'SRC/pix.h (1298, 1)
''' <summary>
''' Relative to zero flags
''' </summary>
Public Enum L_ZERO
''' <summary>smaller  Choose values less than zero</summary>
L_LESS_THAN_ZERO = 1
''' <summary>smaller  Choose values equal to zero</summary>
L_EQUAL_TO_ZERO = 2
''' <summary>smaller  Choose values greater than zero</summary>
L_GREATER_THAN_ZERO = 3
End Enum


'SRC/pix.h (1310, 1)
''' <summary>
''' Flags for adding or removing traling slash from string
''' </summary>
Public Enum L_TRAIL_SLASH
''' <summary>smaller  Add trailing slash to string</summary>
L_ADD_TRAIL_SLASH = 1
''' <summary>smaller  Remove trailing slash from string</summary>
L_REMOVE_TRAIL_SLASH = 2
End Enum

#End Region
#Region "SRC/recog.h"

'SRC/recog.h (245, 1)
''' <summary>
''' Flags for describing limited character sets
''' </summary>
Public Enum L__describing_limited_character_sets
''' <summary>smaller  character set type is not specified</summary>
L_UNKNOWN = 0
''' <summary>smaller  10 digits</summary>
L_ARABIC_NUMERALS = 1
''' <summary>smaller  7 lower-case letters (i,v,x,l,c,d,m)</summary>
L_LC_ROMAN_NUMERALS = 2
''' <summary>smaller  7 upper-case letters (I,V,X,L,C,D,M)</summary>
L_UC_ROMAN_NUMERALS = 3
''' <summary>smaller  26 lower-case letters</summary>
L_LC_ALPHA = 4
''' <summary>smaller  26 upper-case letters</summary>
L_UC_ALPHA = 5
End Enum


'SRC/recog.h (258, 1)
''' <summary>
''' Flags for selecting average or all templates: recog->templ_use
''' </summary>
Public Enum L_USE_A_TEMPLATES
''' <summary>smaller  use all templates; default</summary>
L_USE_ALL_TEMPLATES = 0
''' <summary>smaller  use average templates; special cases</summary>
L_USE_AVERAGE_TEMPLATES = 1
End Enum

#End Region
#Region "SRC/regutils.h"

'SRC/regutils.h (132, 1)
''' <summary>
''' Running modes for the test
''' </summary>
Public Enum L_REG
''' <summary></summary>
L_REG_GENERATE = 0
''' <summary></summary>
L_REG_COMPARE = 1
''' <summary></summary>
L_REG_DISPLAY = 2
End Enum

#End Region
#Region "SRC/stringcode.h"

'SRC/stringcode.h (53, 1)
''' <summary>
''' Select string in stringcode for a specific serializable data type
''' </summary>
Public Enum L_STR
''' <summary>smaller  typedef for the data type</summary>
L_STR_TYPE = 0
''' <summary>smaller  name of the data type</summary>
L_STR_NAME = 1
''' <summary>smaller  reader to get the data type from file</summary>
L_STR_READER = 2
''' <summary>smaller  reader to get the compressed string in memory</summary>
L_STR_MEMREADER = 3
End Enum

#End Region
#Region "SRC/sudoku.h"

'SRC/sudoku.h (69, 1)
''' <summary>
''' For printing out array data
''' </summary>
Public Enum L_SUDOKU
''' <summary></summary>
L_SUDOKU_INIT = 0
''' <summary></summary>
L_SUDOKU_STATE = 1
End Enum

#End Region
#Region "SRC/readbarcode.h"

'SRC/readbarcode.h (35, 1)
''' <summary>
''' Flags for method of extracting barcode widths
''' </summary>
Public Enum L_USE_WIS
''' <summary>smaller  use histogram of barcode widths</summary>
L_USE_WIDTHS = 1
''' <summary>smaller  find best window for decoding transitions</summary>
L_USE_WINDOWS = 2
End Enum


'SRC/readbarcode.h (47, 1)
''' <summary>
''' Flags for barcode formats
''' </summary>
Public Enum L_BF
''' <summary>smaller  unknown format</summary>
L_BF_UNKNOWN = 0
''' <summary>smaller  try decoding with all known formats</summary>
L_BF_ANY = 1
''' <summary>smaller  decode with Code128 format</summary>
L_BF_CODE128 = 2
''' <summary>smaller  decode with EAN8 format</summary>
L_BF_EAN8 = 3
''' <summary>smaller  decode with EAN13 format</summary>
L_BF_EAN13 = 4
''' <summary>smaller  decode with Code 2 of 5 format</summary>
L_BF_CODE2OF5 = 5
''' <summary>smaller  decode with Interleaved 2 of 5 format</summary>
L_BF_CODEI2OF5 = 6
''' <summary>smaller  decode with Code39 format</summary>
L_BF_CODE39 = 7
''' <summary>smaller  decode with Code93 format</summary>
L_BF_CODE93 = 8
''' <summary>smaller  decode with Code93 format</summary>
L_BF_CODABAR = 9
''' <summary>smaller  decode with UPC A format</summary>
L_BF_UPCA = 10
End Enum

#End Region
#Region "SRC\maze.c"

'SRC\maze.c (68, 1)
''' <summary>
''' 
''' </summary>
Public Enum Unnamed_Enum_2
''' <summary></summary>
START_LOC = 0
''' <summary></summary>
DIR_NORTH = 1
''' <summary></summary>
DIR_SOUTH = 2
''' <summary></summary>
DIR_WEST = 3
''' <summary></summary>
DIR_EAST = 4
End Enum

#End Region
#Region "SRC\rbtree.c"

'SRC\rbtree.c (77, 1)
''' <summary>
''' 
''' </summary>
Public Enum L_NODE
''' <summary></summary>
L_RED_NODE = 1
''' <summary></summary>
L_BLACK_NODE = 2
End Enum

#End Region
End Namespace

//SRC/environ.h (286, 1)
/// <summary>
/// Simple search state variables
/// </summary>
public enum L_FOUND
{
/// <summary></summary>
L_NOT_FOUND = 0,
/// <summary></summary>
L_FOUND = 1
}

//SRC/environ.h (296, 1)
/// <summary>
/// Path separator conversion
/// </summary>
public enum PATH_SEPCHAR
{
/// <summary></summary>
UNIX_PATH_SEPCHAR = 0,
/// <summary></summary>
WIN_PATH_SEPCHAR = 1
}

//SRC/environ.h (369, 1)
/// <summary>
/// Control printing of error, warning and info messages
/// </summary>
public enum L_SEVERITY
{
/// <summary></summary>
L_SEVERITY_EXTERNAL = 0,
/// <summary></summary>
L_SEVERITY_ALL = 1,
/// <summary></summary>
L_SEVERITY_DEBUG = 2,
/// <summary></summary>
L_SEVERITY_INFO = 3,
/// <summary></summary>
L_SEVERITY_WARNING = 4,
/// <summary></summary>
L_SEVERITY_ERROR = 5,
/// <summary></summary>
L_SEVERITY_NONE = 6
}

//SRC/array.h (140, 1)
/// <summary>
/// Flags for interpolation in Numa
/// </summary>
public enum L_INTERP
{
/// <summary>linear</summary>
L_LINEAR_INTERP = 1,
/// <summary>quadratic</summary>
L_QUADRATIC_INTERP = 2
}

//SRC/array.h (146, 1)
/// <summary>
/// Flags for added borders in Numa and Fpix
/// </summary>
public enum L_BORDER
{
/// <summary>extended with same value</summary>
L_CONTINUED_BORDER = 1,
/// <summary>extended with constant normal derivative</summary>
L_SLOPE_BORDER = 2,
/// <summary>mirrored</summary>
L_MIRRORED_BORDER = 3
}

//SRC/array.h (153, 1)
/// <summary>
/// Flags for data type converted from Numa
/// </summary>
public enum L_VALUE
{
/// <summary>convert to integer</summary>
L_INTEGER_VALUE = 1,
/// <summary>convert to float</summary>
L_FLOAT_VALUE = 2
}

//SRC/ptra.h (76, 1)
/// <summary>
/// Flags for removal from L_Ptra
/// </summary>
public enum L_COMPACTION
{
/// <summary>null the pointer only</summary>
L_NO_COMPACTION = 1,
/// <summary>compact the array</summary>
L_COMPACTION = 2
}

//SRC/ptra.h (82, 1)
/// <summary>
/// Flags for insertion into L_Ptra
/// </summary>
public enum L_DOWNSHIFT
{
/// <summary>choose based on number of holes</summary>
L_AUTO_DOWNSHIFT = 0,
/// <summary>downshifts min # of ptrs below insert</summary>
L_MIN_DOWNSHIFT = 1,
/// <summary>downshifts all ptrs below insert</summary>
L_FULL_DOWNSHIFT = 2
}

//SRC/ptra.h (89, 1)
/// <summary>
/// Accessor flags for L_Ptraa
/// </summary>
public enum L_accessor__l_ptraa
{
/// <summary>ptr to L_Ptra: caller can inspect only</summary>
L_HANDLE_ONLY = 0,
/// <summary>caller owns: destroy or save in L_Ptraa</summary>
L_REMOVE = 1
}

//SRC/rbtree.h (47, 1)
/// <summary>
/// The three valid key types for red-black trees, maps and sets.
/// </summary>
public enum L_T_TYPE
{
/// <summary></summary>
L_INT_TYPE = 1,
/// <summary></summary>
L_UINT_TYPE = 2,
/// <summary></summary>
L_FLOAT_TYPE = 3
}

//SRC/bmf.h (37, 1)
/// <summary>
/// Constants for deciding when text block is divided into paragraphs
/// </summary>
public enum SPLIT_ON
{
/// <summary>tab or space at beginning of line</summary>
SPLIT_ON_LEADING_WHITE = 1,
/// <summary>newline with optional white space</summary>
SPLIT_ON_BLANK_LINE = 2,
/// <summary>leading white space or newline</summary>
SPLIT_ON_BOTH = 3
}

//SRC/ccbord.h (40, 1)
/// <summary>
/// Use in ccbaStepChainsToPixCoords()
/// </summary>
public enum CCB_AL_COORDS
{
/// <summary></summary>
CCB_LOCAL_COORDS = 1,
/// <summary></summary>
CCB_GLOBAL_COORDS = 2
}

//SRC/ccbord.h (46, 1)
/// <summary>
/// Use in ccbaGenerateSPGlobalLocs()
/// </summary>
public enum CCB_SAVE_PTS
{
/// <summary></summary>
CCB_SAVE_ALL_PTS = 1,
/// <summary></summary>
CCB_SAVE_TURNING_PTS = 2
}

//SRC/gplot.h (47, 6)
/// <summary>
/// 
/// </summary>
public enum GPLOT_STYLE
{
/// <summary></summary>
GPLOT_LINES = 0,
/// <summary></summary>
GPLOT_POINTS = 1,
/// <summary></summary>
GPLOT_IMPULSES = 2,
/// <summary></summary>
GPLOT_LINESPOINTS = 3,
/// <summary></summary>
GPLOT_DOTS = 4
}

//SRC/gplot.h (56, 6)
/// <summary>
/// 
/// </summary>
public enum GPLOT_OUTPUT
{
/// <summary></summary>
GPLOT_NONE = 0,
/// <summary></summary>
GPLOT_PNG = 1,
/// <summary></summary>
GPLOT_PS = 2,
/// <summary></summary>
GPLOT_EPS = 3,
/// <summary></summary>
GPLOT_LATEX = 4
}

//SRC/gplot.h (64, 6)
/// <summary>
/// 
/// </summary>
public enum GPLOT_SCALING
{
/// <summary>default</summary>
GPLOT_LINEAR_SCALE = 0,
/// <summary></summary>
GPLOT_LOG_SCALE_X = 1,
/// <summary></summary>
GPLOT_LOG_SCALE_Y = 2,
/// <summary></summary>
GPLOT_LOG_SCALE_X_Y = 3
}

//SRC/imageio.h (91, 1)
/// <summary>
/// Image file format types
/// </summary>
public enum IFF
{
/// <summary></summary>
IFF_UNKNOWN = 0,
/// <summary></summary>
IFF_BMP = 1,
/// <summary></summary>
IFF_JFIF_JPEG = 2,
/// <summary></summary>
IFF_PNG = 3,
/// <summary></summary>
IFF_TIFF = 4,
/// <summary></summary>
IFF_TIFF_PACKBITS = 5,
/// <summary></summary>
IFF_TIFF_RLE = 6,
/// <summary></summary>
IFF_TIFF_G3 = 7,
/// <summary></summary>
IFF_TIFF_G4 = 8,
/// <summary></summary>
IFF_TIFF_LZW = 9,
/// <summary></summary>
IFF_TIFF_ZIP = 10,
/// <summary></summary>
IFF_PNM = 11,
/// <summary></summary>
IFF_PS = 12,
/// <summary></summary>
IFF_GIF = 13,
/// <summary></summary>
IFF_JP2 = 14,
/// <summary></summary>
IFF_WEBP = 15,
/// <summary></summary>
IFF_LPDF = 16,
/// <summary></summary>
IFF_DEFAULT = 17,
/// <summary></summary>
IFF_SPIX = 18
}

//SRC/imageio.h (119, 1)
/// <summary>
/// Format header ids
/// </summary>
public enum ID
{
/// <summary>BM - for bitmaps</summary>
BMP_ID = 19778,
/// <summary>MM - for 'motorola'</summary>
TIFF_BIGEND_ID = 19789,
/// <summary>II - for 'intel'</summary>
TIFF_LITTLEEND_ID = 18761
}

//SRC/imageio.h (131, 1)
/// <summary>
/// Hinting bit flags in jpeg reader
/// </summary>
public enum L_JPEG
{
/// <summary>only want luminance data: no chroma</summary>
L_JPEG_READ_LUMINANCE = 1,
/// <summary>don't return possibly damaged pix</summary>
L_JPEG_FAIL_ON_BAD_DATA = 2
}

//SRC/imageio.h (142, 1)
/// <summary>
/// Pdf formatted encoding types
/// </summary>
public enum L_ENCODE
{
/// <summary>use default encoding based on image</summary>
L_DEFAULT_ENCODE = 0,
/// <summary>use dct encoding: 8 and 32 bpp, no cmap</summary>
L_JPEG_ENCODE = 1,
/// <summary>use ccitt g4 fax encoding: 1 bpp</summary>
L_G4_ENCODE = 2,
/// <summary>use flate encoding: any depth, cmap ok</summary>
L_FLATE_ENCODE = 3,
/// <summary>use jp2k encoding: 8 and 32 bpp, no cmap</summary>
L_JP2K_ENCODE = 4
}

//SRC/imageio.h (193, 1)
/// <summary>
/// Pdf multi image flags
/// </summary>
public enum L_T_IMAGE
{
/// <summary>first image to be used</summary>
L_FIRST_IMAGE = 1,
/// <summary>intermediate image: not first or last</summary>
L_NEXT_IMAGE = 2,
/// <summary>last image to be used</summary>
L_LAST_IMAGE = 3
}

//SRC/jbclass.h (123, 1)
/// <summary>
/// Classifier methods
/// </summary>
public enum JB
{
/// <summary></summary>
JB_RANKHAUS = 0,
/// <summary></summary>
JB_CORRELATION = 1
}

//SRC/jbclass.h (129, 1)
/// <summary>
/// For jbGetComponents(): type of component to extract from images
/// </summary>
public enum JB_S
{
/// <summary></summary>
JB_CONN_COMPS = 0,
/// <summary></summary>
JB_CHARACTERS = 1,
/// <summary></summary>
JB_WORDS = 2
}

//SRC/morph.h (109, 1)
/// <summary>
/// Morphological boundary condition flags
/// </summary>
public enum MMETRIC_MORPH_BC
{
/// <summary></summary>
SYMMETRIC_MORPH_BC = 0,
/// <summary></summary>
ASYMMETRIC_MORPH_BC = 1
}

//SRC/morph.h (119, 1)
/// <summary>
/// Structuring element types
/// </summary>
public enum SEL
{
/// <summary></summary>
SEL_DONT_CARE = 0,
/// <summary></summary>
SEL_HIT = 1,
/// <summary></summary>
SEL_MISS = 2
}

//SRC/morph.h (130, 1)
/// <summary>
/// Runlength flags for granulometry
/// </summary>
public enum L_RUN_O
{
/// <summary></summary>
L_RUN_OFF = 0,
/// <summary></summary>
L_RUN_ON = 1
}

//SRC/morph.h (141, 1)
/// <summary>
/// Direction flags
/// </summary>
public enum L_direction
{
/// <summary></summary>
L_HORIZ = 1,
/// <summary></summary>
L_VERT = 2,
/// <summary></summary>
L_BOTH_DIRECTIONS = 3
}

//SRC/morph.h (152, 1)
/// <summary>
/// Morphological operation flags
/// </summary>
public enum L_MORPH
{
/// <summary></summary>
L_MORPH_DILATE = 1,
/// <summary></summary>
L_MORPH_ERODE = 2,
/// <summary></summary>
L_MORPH_OPEN = 3,
/// <summary></summary>
L_MORPH_CLOSE = 4,
/// <summary></summary>
L_MORPH_HMT = 5
}

//SRC/morph.h (165, 1)
/// <summary>
/// Grayscale intensity scaling flags
/// </summary>
public enum L_L_SCALE
{
/// <summary></summary>
L_LINEAR_SCALE = 1,
/// <summary></summary>
L_LOG_SCALE = 2
}

//SRC/morph.h (175, 1)
/// <summary>
/// Morphological tophat flags
/// </summary>
public enum L_TOPHAT
{
/// <summary></summary>
L_TOPHAT_WHITE = 0,
/// <summary></summary>
L_TOPHAT_BLACK = 1
}

//SRC/morph.h (186, 1)
/// <summary>
/// Arithmetic and logical operator flags
/// </summary>
public enum L_arithmetic_logical_operator
{
/// <summary></summary>
L_ARITH_ADD = 1,
/// <summary></summary>
L_ARITH_SUBTRACT = 2,
/// <summary></summary>
L_ARITH_MULTIPLY = 3,
/// <summary></summary>
L_ARITH_DIVIDE = 4,
/// <summary></summary>
L_UNION = 5,
/// <summary></summary>
L_INTERSECTION = 6,
/// <summary></summary>
L_SUBTRACTION = 7,
/// <summary></summary>
L_EXCLUSIVE_OR = 8
}

//SRC/morph.h (202, 1)
/// <summary>
/// Min/max selection flags
/// </summary>
public enum L_CHOOSE_M
{
/// <summary></summary>
L_CHOOSE_MIN = 1,
/// <summary></summary>
L_CHOOSE_MAX = 2,
/// <summary></summary>
L_CHOOSE_MAXDIFF = 3,
/// <summary></summary>
L_CHOOSE_MIN_BOOST = 4,
/// <summary></summary>
L_CHOOSE_MAX_BOOST = 5
}

//SRC/morph.h (215, 1)
/// <summary>
/// Distance function b.c. flags
/// </summary>
public enum L_BOUNDARY_G
{
/// <summary></summary>
L_BOUNDARY_BG = 1,
/// <summary></summary>
L_BOUNDARY_FG = 2
}

//SRC/morph.h (225, 1)
/// <summary>
/// Image comparison flags
/// </summary>
public enum L_COMPARE
{
/// <summary></summary>
L_COMPARE_XOR = 1,
/// <summary></summary>
L_COMPARE_SUBTRACT = 2,
/// <summary></summary>
L_COMPARE_ABS_DIFF = 3
}

//SRC/morph.h (236, 1)
/// <summary>
/// Color content flags
/// </summary>
public enum L_MAX
{
/// <summary></summary>
L_MAX_DIFF_FROM_AVERAGE_2 = 1,
/// <summary></summary>
L_MAX_MIN_DIFF_FROM_2 = 2,
/// <summary></summary>
L_MAX_DIFF = 3
}

//SRC/pix.h (200, 1)
/// <summary>
/// Colors for 32 bpp
/// </summary>
public enum colors_32_bpp
{
/// <summary>red color index in RGBA_QUAD</summary>
COLOR_RED = 0,
/// <summary>green color index in RGBA_QUAD</summary>
COLOR_GREEN = 1,
/// <summary>blue color index in RGBA_QUAD</summary>
COLOR_BLUE = 2,
/// <summary>alpha value index in RGBA_QUAD</summary>
L_ALPHA_CHANNEL = 3
}

//SRC/pix.h (221, 1)
/// <summary>
/// Colors for drawing boxes
/// </summary>
public enum L_DRAW
{
/// <summary>draw in red</summary>
L_DRAW_RED = 0,
/// <summary>draw in green</summary>
L_DRAW_GREEN = 1,
/// <summary>draw in blue</summary>
L_DRAW_BLUE = 2,
/// <summary>draw specified color</summary>
L_DRAW_SPECIFIED = 3,
/// <summary>draw as sequence of r,g,b</summary>
L_DRAW_RGB = 4,
/// <summary>draw randomly chosen colors</summary>
L_DRAW_RANDOM = 5
}

//SRC/pix.h (252, 1)
/// <summary>
/// Flags for colormap conversion
/// </summary>
public enum REMOVE_CMAP
{
/// <summary>remove colormap for conv to 1 bpp</summary>
REMOVE_CMAP_TO_BINARY = 0,
/// <summary>remove colormap for conv to 8 bpp</summary>
REMOVE_CMAP_TO_GRAYSCALE = 1,
/// <summary>remove colormap for conv to 32 bpp</summary>
REMOVE_CMAP_TO_FULL_COLOR = 2,
/// <summary>remove colormap and alpha</summary>
REMOVE_CMAP_WITH_ALPHA = 3,
/// <summary>remove depending on src format</summary>
REMOVE_CMAP_BASED_ON_SRC = 4
}

//SRC/pix.h (715, 1)
/// <summary>
/// Access and storage flags
/// </summary>
public enum L_access_storage
{
/// <summary>do not copy the object: do not delete the ptr</summary>
L_NOCOPY = 0,
/// <summary>stuff it in: do not copy or clone</summary>
L_INSERT = 0,
/// <summary>make/use a copy of the object</summary>
L_COPY = 1,
/// <summary>make/use clone (ref count) of the object</summary>
L_CLONE = 2,
/// <summary>make a new array object (e.g., pixa) and fill the array with clones (e.g., pix)</summary>
L_COPY_CLONE = 3
}

//SRC/pix.h (730, 1)
/// <summary>
/// Sort mode flags
/// </summary>
public enum L_SORT
{
/// <summary>use shell sort</summary>
L_SHELL_SORT = 1,
/// <summary>use bin sort</summary>
L_BIN_SORT = 2
}

//SRC/pix.h (736, 1)
/// <summary>
/// Sort order flags
/// </summary>
public enum L_SORT_CREASING
{
/// <summary>sort in increasing order</summary>
L_SORT_INCREASING = 1,
/// <summary>sort in decreasing order</summary>
L_SORT_DECREASING = 2
}

//SRC/pix.h (742, 1)
/// <summary>
/// Sort type flags
/// </summary>
public enum L_SORT_BY
{
/// <summary>sort box or c.c. by left edge location</summary>
L_SORT_BY_X = 1,
/// <summary>sort box or c.c. by top edge location</summary>
L_SORT_BY_Y = 2,
/// <summary>sort box or c.c. by right edge location</summary>
L_SORT_BY_RIGHT = 3,
/// <summary>sort box or c.c. by bot edge location</summary>
L_SORT_BY_BOT = 4,
/// <summary>sort box or c.c. by width</summary>
L_SORT_BY_WIDTH = 5,
/// <summary>sort box or c.c. by height</summary>
L_SORT_BY_HEIGHT = 6,
/// <summary>sort box or c.c. by min dimension</summary>
L_SORT_BY_MIN_DIMENSION = 7,
/// <summary>sort box or c.c. by max dimension</summary>
L_SORT_BY_MAX_DIMENSION = 8,
/// <summary>sort box or c.c. by perimeter</summary>
L_SORT_BY_PERIMETER = 9,
/// <summary>sort box or c.c. by area</summary>
L_SORT_BY_AREA = 10,
/// <summary>sort box or c.c. by width/height ratio</summary>
L_SORT_BY_ASPECT_RATIO = 11
}

//SRC/pix.h (762, 1)
/// <summary>
/// Blend flags
/// </summary>
public enum L_BLEND
{
/// <summary>add some of src inverse to itself</summary>
L_BLEND_WITH_INVERSE = 1,
/// <summary>shift src colors towards white</summary>
L_BLEND_TO_WHITE = 2,
/// <summary>shift src colors towards black</summary>
L_BLEND_TO_BLACK = 3,
/// <summary>blend src directly with blender</summary>
L_BLEND_GRAY = 4,
/// <summary>add amount of src inverse to itself, based on blender pix value</summary>
L_BLEND_GRAY_WITH_INVERSE = 5
}

//SRC/pix.h (771, 1)
/// <summary>
/// 
/// </summary>
public enum L_PAINT
{
/// <summary>colorize non-black pixels</summary>
L_PAINT_LIGHT = 1,
/// <summary>colorize non-white pixels</summary>
L_PAINT_DARK = 2
}

//SRC/pix.h (782, 1)
/// <summary>
/// Graphics pixel setting
/// </summary>
public enum L_PIXELS
{
/// <summary>set all bits in each pixel to 1</summary>
L_SET_PIXELS = 1,
/// <summary>set all bits in each pixel to 0</summary>
L_CLEAR_PIXELS = 2,
/// <summary>flip all bits in each pixel</summary>
L_FLIP_PIXELS = 3
}

//SRC/pix.h (794, 1)
/// <summary>
/// Location filter flags
/// </summary>
public enum L_SELECT
{
/// <summary>width must satisfy constraint</summary>
L_SELECT_WIDTH = 1,
/// <summary>height must satisfy constraint</summary>
L_SELECT_HEIGHT = 2,
/// <summary>x value satisfy constraint</summary>
L_SELECT_XVAL = 3,
/// <summary>y value must satisfy constraint</summary>
L_SELECT_YVAL = 4,
/// <summary>either width or height (or xval or yval) can satisfy</summary>
L_SELECT_IF_EITHER = 5,
/// <summary>both width and height (or xval and yval must satisfy</summary>
L_SELECT_IF_BOTH = 6
}

//SRC/pix.h (806, 1)
/// <summary>
/// Size filter flags
/// </summary>
public enum L_SELECT_IF
{
/// <summary>save if value is less than threshold</summary>
L_SELECT_IF_LT = 1,
/// <summary>save if value is more than threshold</summary>
L_SELECT_IF_GT = 2,
/// <summary>save if value is  is smaller = to the threshold</summary>
L_SELECT_IF_LTE = 3,
/// <summary>save if value is  is greater = to the threshold</summary>
L_SELECT_IF_GTE = 4
}

//SRC/pix.h (819, 1)
/// <summary>
/// Color component selection flags
/// </summary>
public enum L_SELECT_
{
/// <summary>use red component</summary>
L_SELECT_RED = 1,
/// <summary>use green component</summary>
L_SELECT_GREEN = 2,
/// <summary>use blue component</summary>
L_SELECT_BLUE = 3,
/// <summary>use min color component</summary>
L_SELECT_MIN = 4,
/// <summary>use max color component</summary>
L_SELECT_MAX = 5,
/// <summary>use average of color components</summary>
L_SELECT_AVERAGE = 6,
/// <summary>use hue value (in HSV color space)</summary>
L_SELECT_HUE = 7,
/// <summary>use saturation value (in HSV space)</summary>
L_SELECT_SATURATION = 8
}

//SRC/pix.h (836, 1)
/// <summary>
/// 16-bit conversion flags
/// </summary>
public enum L_16_bit_conversion
{
/// <summary>use LSB</summary>
L_LS_BYTE = 1,
/// <summary>use MSB</summary>
L_MS_BYTE = 2,
/// <summary>use LSB if max(val)  is smaller  256: else MSB</summary>
L_AUTO_BYTE = 3,
/// <summary>use max(val, 255)</summary>
L_CLIP_TO_FF = 4,
/// <summary>use two LSB</summary>
L_LS_TWO_BYTES = 5,
/// <summary>use two MSB</summary>
L_MS_TWO_BYTES = 6,
/// <summary>use max(val, 65535)</summary>
L_CLIP_TO_FFFF = 7
}

//SRC/pix.h (852, 1)
/// <summary>
/// Rotate flags
/// </summary>
public enum L_ROTATE
{
/// <summary>use area map rotation, if possible</summary>
L_ROTATE_AREA_MAP = 1,
/// <summary>use shear rotation</summary>
L_ROTATE_SHEAR = 2,
/// <summary>use sampling</summary>
L_ROTATE_SAMPLING = 3
}

//SRC/pix.h (859, 1)
/// <summary>
/// Background flags
/// </summary>
public enum L_BRING_IN
{
/// <summary>bring in white pixels from the outside</summary>
L_BRING_IN_WHITE = 1,
/// <summary>bring in black pixels from the outside</summary>
L_BRING_IN_BLACK = 2
}

//SRC/pix.h (865, 1)
/// <summary>
/// Shear flags
/// </summary>
public enum L_SHEAR_ABOUT_CER
{
/// <summary>shear image about UL corner</summary>
L_SHEAR_ABOUT_CORNER = 1,
/// <summary>shear image about center</summary>
L_SHEAR_ABOUT_CENTER = 2
}

//SRC/pix.h (876, 1)
/// <summary>
/// Affine transform order flags
/// </summary>
public enum L_affine_transm_order
{
/// <summary>translate, scale, rotate</summary>
L_TR_SC_RO = 1,
/// <summary>scale, rotate, translate</summary>
L_SC_RO_TR = 2,
/// <summary>rotate, translate, scale</summary>
L_RO_TR_SC = 3,
/// <summary>translate, rotate, scale</summary>
L_TR_RO_SC = 4,
/// <summary>rotate, scale, translate</summary>
L_RO_SC_TR = 5,
/// <summary>scale, translate, rotate</summary>
L_SC_TR_RO = 6
}

//SRC/pix.h (891, 1)
/// <summary>
/// Grayscale filling flags
/// </summary>
public enum L_FILL
{
/// <summary>fill white pixels (e.g, in fg map)</summary>
L_FILL_WHITE = 1,
/// <summary>fill black pixels (e.g., in bg map)</summary>
L_FILL_BLACK = 2
}

//SRC/pix.h (902, 1)
/// <summary>
/// Flags for setting to white or black
/// </summary>
public enum L_SET
{
/// <summary>set pixels to white</summary>
L_SET_WHITE = 1,
/// <summary>set pixels to black</summary>
L_SET_BLACK = 2
}

//SRC/pix.h (913, 1)
/// <summary>
/// Flags for getting white or black value
/// </summary>
public enum L_GET_VAL
{
/// <summary>get white pixel value</summary>
L_GET_WHITE_VAL = 1,
/// <summary>get black pixel value</summary>
L_GET_BLACK_VAL = 2
}

//SRC/pix.h (924, 1)
/// <summary>
/// Flags for 8 bit and 16 bit pixel sums
/// </summary>
public enum L_IS_MAX
{
/// <summary>white pixels are 0xff or 0xffff: black are 0</summary>
L_WHITE_IS_MAX = 1,
/// <summary>black pixels are 0xff or 0xffff: white are 0</summary>
L_BLACK_IS_MAX = 2
}

//SRC/pix.h (937, 1)
/// <summary>
/// Dither parameters
/// </summary>
public enum DEFAULT_CLIP
{
/// <summary>dist to black with no prop: 1 bpp</summary>
DEFAULT_CLIP_LOWER_1 = 10,
/// <summary>dist to black with no prop: 1 bpp</summary>
DEFAULT_CLIP_UPPER_1 = 10,
/// <summary>dist to black with no prop: 2 bpp</summary>
DEFAULT_CLIP_LOWER_2 = 5,
/// <summary>dist to black with no prop: 2 bpp</summary>
DEFAULT_CLIP_UPPER_2 = 5
}

//SRC/pix.h (950, 1)
/// <summary>
/// Distance flags
/// </summary>
public enum L_AN_DISTANCE
{
/// <summary>L1 distance (e.g., in color space)</summary>
L_MANHATTAN_DISTANCE = 1,
/// <summary>L2 distance</summary>
L_EUCLIDEAN_DISTANCE = 2
}

//SRC/pix.h (961, 1)
/// <summary>
/// Value flags
/// </summary>
public enum L_value_
{
/// <summary>values  is smaller  0</summary>
L_NEGATIVE = 1,
/// <summary>values  is greater = 0</summary>
L_NON_NEGATIVE = 2,
/// <summary>values  is greater  0</summary>
L_POSITIVE = 3,
/// <summary>values  is smaller = 0</summary>
L_NON_POSITIVE = 4,
/// <summary>values = 0</summary>
L_ZERO = 5,
/// <summary>all values</summary>
L_ALL = 6
}

//SRC/pix.h (976, 1)
/// <summary>
/// Statistical measures
/// </summary>
public enum L_statistical_measures
{
/// <summary>average of abs values</summary>
L_MEAN_ABSVAL = 1,
/// <summary>median value of set</summary>
L_MEDIAN_VAL = 2,
/// <summary>mode value of set</summary>
L_MODE_VAL = 3,
/// <summary>mode count of set</summary>
L_MODE_COUNT = 4,
/// <summary>rms of values</summary>
L_ROOT_MEAN_SQUARE = 5,
/// <summary>standard deviation from mean</summary>
L_STANDARD_DEVIATION = 6,
/// <summary>variance of values</summary>
L_VARIANCE = 7
}

//SRC/pix.h (992, 1)
/// <summary>
/// Set selection flags
/// </summary>
public enum L_CHOOSE
{
/// <summary>select 'n' consecutive</summary>
L_CHOOSE_CONSECUTIVE = 1,
/// <summary>select at intervals of 'n'</summary>
L_CHOOSE_SKIP_BY = 2
}

//SRC/pix.h (1003, 1)
/// <summary>
/// Text orientation flags
/// </summary>
public enum L_TEXT_ORIENT
{
/// <summary>low confidence on text orientation</summary>
L_TEXT_ORIENT_UNKNOWN = 0,
/// <summary>portrait, text rightside-up</summary>
L_TEXT_ORIENT_UP = 1,
/// <summary>landscape, text up to left</summary>
L_TEXT_ORIENT_LEFT = 2,
/// <summary>portrait, text upside-down</summary>
L_TEXT_ORIENT_DOWN = 3,
/// <summary>landscape, text up to right</summary>
L_TEXT_ORIENT_RIGHT = 4
}

//SRC/pix.h (1017, 1)
/// <summary>
/// Edge orientation flags
/// </summary>
public enum L_L_EDGES
{
/// <summary>filters for horizontal edges</summary>
L_HORIZONTAL_EDGES = 0,
/// <summary>filters for vertical edges</summary>
L_VERTICAL_EDGES = 1,
/// <summary>filters for all edges</summary>
L_ALL_EDGES = 2
}

//SRC/pix.h (1029, 1)
/// <summary>
/// Line orientation flags
/// </summary>
public enum L_LINE
{
/// <summary>horizontal line</summary>
L_HORIZONTAL_LINE = 0,
/// <summary>45 degree line with positive slope</summary>
L_POS_SLOPE_LINE = 1,
/// <summary>vertical line</summary>
L_VERTICAL_LINE = 2,
/// <summary>45 degree line with negative slope</summary>
L_NEG_SLOPE_LINE = 3,
/// <summary>neither horizontal nor vertical</summary>
L_OBLIQUE_LINE = 4
}

//SRC/pix.h (1043, 1)
/// <summary>
/// Image orientation flags
/// </summary>
public enum L_MODE
{
/// <summary>typical: page is viewed with height  is greater  width</summary>
L_PORTRAIT_MODE = 0,
/// <summary>page is viewed at 90 deg to portrait mode</summary>
L_LANDSCAPE_MODE = 1
}

//SRC/pix.h (1054, 1)
/// <summary>
/// Scan direction flags
/// </summary>
public enum L_scan_direction
{
/// <summary>scan from left</summary>
L_FROM_LEFT = 0,
/// <summary>scan from right</summary>
L_FROM_RIGHT = 1,
/// <summary>scan from top</summary>
L_FROM_TOP = 2,
/// <summary>scan from bottom</summary>
L_FROM_BOT = 3,
/// <summary>scan in negative direction</summary>
L_SCAN_NEGATIVE = 4,
/// <summary>scan in positive direction</summary>
L_SCAN_POSITIVE = 5,
/// <summary>scan in both directions</summary>
L_SCAN_BOTH = 6,
/// <summary>horizontal scan (direction unimportant)</summary>
L_SCAN_HORIZONTAL = 7,
/// <summary>vertical scan (direction unimportant)</summary>
L_SCAN_VERTICAL = 8
}

//SRC/pix.h (1072, 1)
/// <summary>
/// Box size adjustment and location flags
/// </summary>
public enum L_box_size_adjustment_location
{
/// <summary>do not adjust</summary>
L_ADJUST_SKIP = 0,
/// <summary>adjust left edge</summary>
L_ADJUST_LEFT = 1,
/// <summary>adjust right edge</summary>
L_ADJUST_RIGHT = 2,
/// <summary>adjust both left and right edges</summary>
L_ADJUST_LEFT_AND_RIGHT = 3,
/// <summary>adjust top edge</summary>
L_ADJUST_TOP = 4,
/// <summary>adjust bottom edge</summary>
L_ADJUST_BOT = 5,
/// <summary>adjust both top and bottom edges</summary>
L_ADJUST_TOP_AND_BOT = 6,
/// <summary>choose the min median value</summary>
L_ADJUST_CHOOSE_MIN = 7,
/// <summary>choose the max median value</summary>
L_ADJUST_CHOOSE_MAX = 8,
/// <summary>set left side to a given value</summary>
L_SET_LEFT = 9,
/// <summary>set right side to a given value</summary>
L_SET_RIGHT = 10,
/// <summary>set top side to a given value</summary>
L_SET_TOP = 11,
/// <summary>set bottom side to a given value</summary>
L_SET_BOT = 12,
/// <summary>get left side location</summary>
L_GET_LEFT = 13,
/// <summary>get right side location</summary>
L_GET_RIGHT = 14,
/// <summary>get top side location</summary>
L_GET_TOP = 15,
/// <summary>get bottom side location</summary>
L_GET_BOT = 16
}

//SRC/pix.h (1098, 1)
/// <summary>
/// Flags for modifying box boundaries using a second box
/// </summary>
public enum L__modifying_box_boundaries_using_a_second_box
{
/// <summary>use boundaries giving min size</summary>
L_USE_MINSIZE = 1,
/// <summary>use boundaries giving max size</summary>
L_USE_MAXSIZE = 2,
/// <summary>modify boundary if big location diff</summary>
L_SUB_ON_LOC_DIFF = 3,
/// <summary>modify boundary if big size diff</summary>
L_SUB_ON_SIZE_DIFF = 4,
/// <summary>modify boundary with capped min</summary>
L_USE_CAPPED_MIN = 5,
/// <summary>modify boundary with capped max</summary>
L_USE_CAPPED_MAX = 6
}

//SRC/pix.h (1112, 1)
/// <summary>
/// Handling overlapping bounding boxes in Boxa
/// </summary>
public enum L_hling_overlapping_bounding_boxes_in_boxa
{
/// <summary>resize to bounding region: remove smaller</summary>
L_COMBINE = 1,
/// <summary>only remove smaller</summary>
L_REMOVE_SMALL = 2
}

//SRC/pix.h (1122, 1)
/// <summary>
/// Flags for replacing invalid boxes
/// </summary>
public enum L_USE_BOXES
{
/// <summary>consider all boxes in the sequence</summary>
L_USE_ALL_BOXES = 1,
/// <summary>consider boxes with the same parity</summary>
L_USE_SAME_PARITY_BOXES = 2
}

//SRC/pix.h (1132, 1)
/// <summary>
/// Horizontal warp direction
/// </summary>
public enum L_WARP_TO_T
{
/// <summary>increasing stretch or contraction to left</summary>
L_WARP_TO_LEFT = 1,
/// <summary>increasing stretch or contraction to right</summary>
L_WARP_TO_RIGHT = 2
}

//SRC/pix.h (1138, 1)
/// <summary>
/// Horizontal warp stretch mode
/// </summary>
public enum L_WARP
{
/// <summary>stretch or contraction grows linearly</summary>
L_LINEAR_WARP = 1,
/// <summary>stretch or contraction grows quadratically</summary>
L_QUADRATIC_WARP = 2
}

//SRC/pix.h (1149, 1)
/// <summary>
/// Pixel selection for resampling
/// </summary>
public enum L_ED
{
/// <summary>linear interpolation from src pixels</summary>
L_INTERPOLATED = 1,
/// <summary>nearest src pixel sampling only</summary>
L_SAMPLED = 2
}

//SRC/pix.h (1160, 1)
/// <summary>
/// Thinning flags
/// </summary>
public enum L_THIN_G
{
/// <summary>thin foreground of 1 bpp image</summary>
L_THIN_FG = 1,
/// <summary>thin background of 1 bpp image</summary>
L_THIN_BG = 2
}

//SRC/pix.h (1171, 1)
/// <summary>
/// Runlength flags
/// </summary>
public enum L_AL_RUNS
{
/// <summary>determine runlengths of horizontal runs</summary>
L_HORIZONTAL_RUNS = 0,
/// <summary>determine runlengths of vertical runs</summary>
L_VERTICAL_RUNS = 1
}

//SRC/pix.h (1182, 1)
/// <summary>
/// Edge filter flags
/// </summary>
public enum L_EDGE
{
/// <summary>Sobel edge filter</summary>
L_SOBEL_EDGE = 1,
/// <summary>Two-sided edge filter</summary>
L_TWO_SIDED_EDGE = 2
}

//SRC/pix.h (1193, 1)
/// <summary>
/// Subpixel color component ordering in LC display
/// </summary>
public enum L_SUBPIXEL_ORDER
{
/// <summary>sensor order left-to-right RGB</summary>
L_SUBPIXEL_ORDER_RGB = 1,
/// <summary>sensor order left-to-right BGR</summary>
L_SUBPIXEL_ORDER_BGR = 2,
/// <summary>sensor order top-to-bottom RGB</summary>
L_SUBPIXEL_ORDER_VRGB = 3,
/// <summary>sensor order top-to-bottom BGR</summary>
L_SUBPIXEL_ORDER_VBGR = 4
}

//SRC/pix.h (1206, 1)
/// <summary>
/// HSV histogram flags
/// </summary>
public enum L_HISTO
{
/// <summary>Use hue-saturation histogram</summary>
L_HS_HISTO = 1,
/// <summary>Use hue-value histogram</summary>
L_HV_HISTO = 2,
/// <summary>Use saturation-value histogram</summary>
L_SV_HISTO = 3
}

//SRC/pix.h (1218, 1)
/// <summary>
/// Region flags (inclusion, exclusion)
/// </summary>
public enum L_CLUDE_REGION
{
/// <summary>Use hue-saturation histogram</summary>
L_INCLUDE_REGION = 1,
/// <summary>Use hue-value histogram</summary>
L_EXCLUDE_REGION = 2
}

//SRC/pix.h (1229, 1)
/// <summary>
/// Flags for adding text to a Pix
/// </summary>
public enum L_ADD
{
/// <summary>Add text above the image</summary>
L_ADD_ABOVE = 1,
/// <summary>Add text below the image</summary>
L_ADD_BELOW = 2,
/// <summary>Add text to the left of the image</summary>
L_ADD_LEFT = 3,
/// <summary>Add text to the right of the image</summary>
L_ADD_RIGHT = 4,
/// <summary>Add text over the top of the image</summary>
L_ADD_AT_TOP = 5,
/// <summary>Add text over the bottom of the image</summary>
L_ADD_AT_BOT = 6,
/// <summary>Add text over left side of the image</summary>
L_ADD_AT_LEFT = 7,
/// <summary>Add text over right side of the image</summary>
L_ADD_AT_RIGHT = 8
}

//SRC/pix.h (1246, 1)
/// <summary>
/// Flags for plotting on a Pix
/// </summary>
public enum L_PLOT_AT
{
/// <summary>Plot horizontally at top</summary>
L_PLOT_AT_TOP = 1,
/// <summary>Plot horizontally at middle</summary>
L_PLOT_AT_MID_HORIZ = 2,
/// <summary>Plot horizontally at bottom</summary>
L_PLOT_AT_BOT = 3,
/// <summary>Plot vertically at left</summary>
L_PLOT_AT_LEFT = 4,
/// <summary>Plot vertically at middle</summary>
L_PLOT_AT_MID_VERT = 5,
/// <summary>Plot vertically at right</summary>
L_PLOT_AT_RIGHT = 6
}

//SRC/pix.h (1261, 1)
/// <summary>
/// Flags for selecting display program
/// </summary>
public enum L_DISPLAY_WITH
{
/// <summary>Use xzgv with pixDisplay()</summary>
L_DISPLAY_WITH_XZGV = 1,
/// <summary>Use xli with pixDisplay()</summary>
L_DISPLAY_WITH_XLI = 2,
/// <summary>Use xv with pixDisplay()</summary>
L_DISPLAY_WITH_XV = 3,
/// <summary>Use irfvanview (win) with pixDisplay()</summary>
L_DISPLAY_WITH_IV = 4,
/// <summary>Use open (apple) with pixDisplay()</summary>
L_DISPLAY_WITH_OPEN = 5
}

//SRC/pix.h (1277, 1)
/// <summary>
/// Flags used in Pix::special
/// </summary>
public enum Unnamed_Enum_1
{
/// <summary>Write full resolution chroma</summary>
L_NO_CHROMA_SAMPLING_JPEG = 1
}

//SRC/pix.h (1287, 1)
/// <summary>
/// Handling negative values in conversion to unsigned int
/// </summary>
public enum L_hling_negative_values_in_conversion_to_unsigned_int
{
/// <summary>Clip negative values to 0</summary>
L_CLIP_TO_ZERO = 1,
/// <summary>Convert to positive using L_ABS()</summary>
L_TAKE_ABSVAL = 2
}

//SRC/pix.h (1298, 1)
/// <summary>
/// Relative to zero flags
/// </summary>
public enum L_ZERO
{
/// <summary>Choose values less than zero</summary>
L_LESS_THAN_ZERO = 1,
/// <summary>Choose values equal to zero</summary>
L_EQUAL_TO_ZERO = 2,
/// <summary>Choose values greater than zero</summary>
L_GREATER_THAN_ZERO = 3
}

//SRC/pix.h (1310, 1)
/// <summary>
/// Flags for adding or removing traling slash from string
/// </summary>
public enum L_TRAIL_SLASH
{
/// <summary>Add trailing slash to string</summary>
L_ADD_TRAIL_SLASH = 1,
/// <summary>Remove trailing slash from string</summary>
L_REMOVE_TRAIL_SLASH = 2
}

//SRC/recog.h (245, 1)
/// <summary>
/// Flags for describing limited character sets
/// </summary>
public enum L__describing_limited_character_sets
{
/// <summary>character set type is not specified</summary>
L_UNKNOWN = 0,
/// <summary>10 digits</summary>
L_ARABIC_NUMERALS = 1,
/// <summary>7 lower-case letters (i,v,x,l,c,d,m)</summary>
L_LC_ROMAN_NUMERALS = 2,
/// <summary>7 upper-case letters (I,V,X,L,C,D,M)</summary>
L_UC_ROMAN_NUMERALS = 3,
/// <summary>26 lower-case letters</summary>
L_LC_ALPHA = 4,
/// <summary>26 upper-case letters</summary>
L_UC_ALPHA = 5
}

//SRC/recog.h (258, 1)
/// <summary>
/// Flags for selecting average or all templates: recog->templ_use
/// </summary>
public enum L_USE_A_TEMPLATES
{
/// <summary>use all templates: default</summary>
L_USE_ALL_TEMPLATES = 0,
/// <summary>use average templates: special cases</summary>
L_USE_AVERAGE_TEMPLATES = 1
}

//SRC/regutils.h (132, 1)
/// <summary>
/// Running modes for the test
/// </summary>
public enum L_REG
{
/// <summary></summary>
L_REG_GENERATE = 0,
/// <summary></summary>
L_REG_COMPARE = 1,
/// <summary></summary>
L_REG_DISPLAY = 2
}

//SRC/stringcode.h (53, 1)
/// <summary>
/// Select string in stringcode for a specific serializable data type
/// </summary>
public enum L_STR
{
/// <summary>typedef for the data type</summary>
L_STR_TYPE = 0,
/// <summary>name of the data type</summary>
L_STR_NAME = 1,
/// <summary>reader to get the data type from file</summary>
L_STR_READER = 2,
/// <summary>reader to get the compressed string in memory</summary>
L_STR_MEMREADER = 3
}

//SRC/sudoku.h (69, 1)
/// <summary>
/// For printing out array data
/// </summary>
public enum L_SUDOKU
{
/// <summary></summary>
L_SUDOKU_INIT = 0,
/// <summary></summary>
L_SUDOKU_STATE = 1
}

//SRC/readbarcode.h (35, 1)
/// <summary>
/// Flags for method of extracting barcode widths
/// </summary>
public enum L_USE_WIS
{
/// <summary>use histogram of barcode widths</summary>
L_USE_WIDTHS = 1,
/// <summary>find best window for decoding transitions</summary>
L_USE_WINDOWS = 2
}

//SRC/readbarcode.h (47, 1)
/// <summary>
/// Flags for barcode formats
/// </summary>
public enum L_BF
{
/// <summary>unknown format</summary>
L_BF_UNKNOWN = 0,
/// <summary>try decoding with all known formats</summary>
L_BF_ANY = 1,
/// <summary>decode with Code128 format</summary>
L_BF_CODE128 = 2,
/// <summary>decode with EAN8 format</summary>
L_BF_EAN8 = 3,
/// <summary>decode with EAN13 format</summary>
L_BF_EAN13 = 4,
/// <summary>decode with Code 2 of 5 format</summary>
L_BF_CODE2OF5 = 5,
/// <summary>decode with Interleaved 2 of 5 format</summary>
L_BF_CODEI2OF5 = 6,
/// <summary>decode with Code39 format</summary>
L_BF_CODE39 = 7,
/// <summary>decode with Code93 format</summary>
L_BF_CODE93 = 8,
/// <summary>decode with Code93 format</summary>
L_BF_CODABAR = 9,
/// <summary>decode with UPC A format</summary>
L_BF_UPCA = 10
}

//SRC\maze.c (68, 1)
/// <summary>
/// 
/// </summary>
public enum Unnamed_Enum_2
{
/// <summary></summary>
START_LOC = 0,
/// <summary></summary>
DIR_NORTH = 1,
/// <summary></summary>
DIR_SOUTH = 2,
/// <summary></summary>
DIR_WEST = 3,
/// <summary></summary>
DIR_EAST = 4
}

//SRC\rbtree.c (77, 1)
/// <summary>
/// 
/// </summary>
public enum L_NODE
{
/// <summary></summary>
L_RED_NODE = 1,
/// <summary></summary>
L_BLACK_NODE = 2
}


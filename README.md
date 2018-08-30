# LeptonicaSharp Beta
Full featured wrapper for leptonica 1.76.0

special thanks to: https://github.com/tvn-cosine/leptonica.net
for the first great library for leptonica  

# Functions:

- VB.Net 4.0 Library
- supports all Leptonica-Functions
- included all propertys from Leptonica structs via Marshaler
- complete documentation and debug-informations from C-Files included

# Todo:

- Functions are only checks if parameter is not nothing, but not the format, e.g. 8 Bit depth.
- define marshal arrays with the right size - Needs external parameters from config.

# Info:
- Optional parameters moved to the back of the parameters list, this differs from C-Source definition.
  Examples for the C-File may not work until you move the optional Parameters to the back!
- Marshaling of Arrays needs a fixed array Size. If Parameter n oder nalloc exists, i use this one,
  else i use "1" instead. e.g. Pix needs to be initialized with ((w*h)*(d/8))-1 (Byte).
- UInteger is not supported by the marshaller. I use Byte instead. (4 Bytes = 1 UInteger). 
  For Picture arrays this is a good thing, for other parts convert it manually to UInteger.

# How to Implement

1. Copy the files from the Dll-folder into your project and add
   a link to LeptonicaSharp. (x32)

# How to extend predefined classes:

1. You can simple extend the classes via
Partial Class Pix
  Function DoAnything (Parameters) as Pix
    ' Natives always return a Pointer,
    ' Classes always created by a Pointer
    return new Pix (Natives.AnyFunction(Parameters))
  End Function
 End Class
 2. Compile again.

# How to compile the C-DLL

1. Download the latest version of CMake from https://cmake.org/ and install
2. Download the latest version of cppan from https://cppan.org/ and copy to CMake\Bin folder
3. Open Cmd and switch to Leptonica C-Source folder. (Or shift-right click and select "CommandPrompt here")
4. Type: "Set Path="Path to CMake-Bin"
5. Type: "cppan --build pvt.cppan.demo.danbloomberg.leptonica"

# Example

- Imports LeptonicaSharp
- Dim Pix as Pix = New LeptonicaSharp.Pix("Test.jpg")
- PictureBox1.Backgroundimage = Pix.toBitmap
- Pix.SaveAutoFormat ("Test.jp2", JP2)

# Special thanks
- Leptonica for this great c-library
- Leptonica.Net for inspiration and implementation comparison
- Clang for the great tool 
- NClang for the wrapper around clang
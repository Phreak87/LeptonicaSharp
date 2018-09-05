# LeptonicaSharp Beta
Full featured wrapper for leptonica 1.76.0

# Functions:

- VB.Net 4.0 Library
- supports all (3299) Leptonica-Functions
- Included extension to view Pix directly
- included all propertys from Leptonica structs via Marshaler
- complete documentation and debug-informations from C-Files included

# Todo:

- more detailed checks of input parameters (e.g. specific pix depths)
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
4. Type: "set PATH=%PATH%;C:\cmake\bin" - Change Folder to your CMake Bin Files
5. Type: "cppan --build pvt.cppan.demo.danbloomberg.leptonica"

# Example

- Imports LeptonicaSharp
- Dim Pix as Pix = New LeptonicaSharp.Pix("Test.jpg")
- PictureBox1.Backgroundimage = Pix.toBitmap
- Pix.SaveAutoFormat ("Test.jp2", JP2)

# Special thanks
- Leptonica for this great c-library
- Leptonica.Net for inspiration and implementation comparison
- SharpDevelop to convert C# snippets to VB.Net
- Clang for the great tool 
- NClang for the wrapper around clang
# LeptonicaSharp
Full featured wrapper for leptonica 1.77.0 (Sep.2018)

# Functions:

- .Net 4.0 and up Library
- supports all (2677) Leptonica-Functions
- well tested
- view Pix directly in windows-forms
- included all propertys from Leptonica classes
- complete documentation and debug-informations from C-Files included

# Todo:

- more detailed checks of input parameters (e.g. specific pix depths)
- bitmap to pix converter more speed and flexibility
- define more optional parameters

# Info:
- Optional parameters moved to the back of the parameters list, this differs from C-Source definition.
  Examples for the C-File may not work until you move the optional Parameters to the back!
- Marshaling of Arrays needs a fixed array Size. If Parameter n oder nalloc exists, i use this one,
  else i use "1" instead. e.g. Pix needs to be initialized with ((w*h)*(d/8))-1 (Byte).
- UInteger is not supported by the marshaller. I use Byte instead. (4 Bytes = 1 UInteger). 
  For Picture arrays this is a good thing, for other parts convert it manually to UInteger.

# How to Implement (From Github)

1. Copy the files from the Dll-folder into your project and add  a link to LeptonicaSharp. (x32)
   
# How to Implement (Via Nuget)

1. Load the Library from Nuget. 
2. Run once LeptonicaSharp.Natives.Initialize() to copy the required dll´s
3. Your ready to start.

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
dont extend the main classes. it will be overwritten
from the generator next build.

# How to compile the C-DLL (Dynamic Version)

1. Download the latest version of CMake from https://cmake.org/ and install
2. Download the latest version of cppan from https://cppan.org/ and copy to CMake\Bin folder
3. Open Cmd and switch to Leptonica C-Source folder. (Or shift-right click and select "CommandPrompt here")
4. Type: "set PATH=%PATH%;C:\cmake\bin" - Change Folder to your CMake Bin Files
5. Type: "cppan --build pvt.cppan.demo.danbloomberg.leptonica"

# How to compile the C-DLL (Static Version, thanks to fdncred)

## Prerequisit Tools

cppan.exe
cmake/cmake-gui

1. Put cppan.exe client in your path.
2. Run cppan.exe --help. This will create %userprofile%\.cppan
3. Modify cppan.yml and point storage_dir to where you want your cppan dependencies
4. cd leptonica
5. Run ccpan.exe
6. Run cmake-gui here
7. Update the CMAKE_INSTALL_PREFIX with your install path. I usually put it under the build folder.
8. set CPPAN_BUILD_SHARED_LIBS=0 - This makes leptonica link statically so you don't have extra cppan dlls.
9. set CPPAN_USE_CACHE=0
10. Run configure several times updating cmake entries as necessary, until there are no more red entries. Then click generate to get vcxproj and sln files.
11. Open sln in Visual Studio from build dir to compile "ALL_BUILD" project for Debug and Release.
12. Build "Install" project for Debug and Release.
13. If you did everything "right" you will end up with an install folder that has a bin folder with leptonica release and debug dlls. 
    As well as debug and release lib files in the lib folder.

# Example

Find the Testapplication.exe and run the Examples included.

# Special thanks
- [FDnCRed](https://github.com/fdncred) for the support, binaries, and helpfile
- (http://www.leptonica.org/) Leptonica for this great c-library
- (https://github.com/tvn-cosine/leptonica.net) Leptonica.Net for inspiration and implementation comparison
- (https://github.com/charlesw/tesseract) for a few snippets from tesseract (works with leptonica)
- (http://www.icsharpcode.net/) SharpDevelop to convert C# snippets to VB.Net (Use Version 4.4)
- (https://clang.llvm.org/) Clang for the great tool 
- (https://github.com/atsushieno/nclang) NClang for the wrapper around clang

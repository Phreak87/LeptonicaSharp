# LeptonicaSharp
Full featured wrapper for leptonica 1.76.0

# Functions:

- VB.Net 4.0 Library
- supports all Leptonica-Functions
- included all propertys from Leptonica structs via Marshaler
- complete documentation and debug-informations from C-Files included

# How to compile the C-DLL

1. Download the latest version of CMake from https://cmake.org/ and install
2. Download the latest version of cppan from https://cppan.org/ and copy to CMake\Bin folder
3. Open Cmd and switch to Leptonica C-Source folder. (Or shift-right click and select "CommandPrompt here")
4. Type: "Set Path="Path to CMake-Bin"
5. Type: "cppan --build pvt.cppan.demo.danbloomberg.leptonica"

# How to implement:

1. copy all the generated Dll-Files to your project-folder
2. copy the LeptonicaSharp.dll to your folder.
3. add a link to leptonicasharp.dll 

# Example

Imports LeptonicaSharp
Dim Pix as Pix = New LeptonicaSharp.Pix("Test.jpg")
PictureBox1.Backgroundimage = Pix.toBitmap
Pix.SaveAutoFormat ("Test.jp2", JP2)

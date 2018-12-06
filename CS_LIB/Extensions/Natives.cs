using System;
using System.IO;
using System.Windows.Forms ; 
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;

	public partial class Natives
	{
		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = false, EntryPoint = "PathFindOnPath")]
		static internal extern bool PathFindOnPath(System.Text.StringBuilder pszFile, string[] ppszOtherDirs);

		private static void CopyNuget()
		{
			Console.WriteLine("Leptonica.dll missing - Copy from Nuget Package");

			// Suche den Pfad der Nuget-Pakete
			string NugetP = Environment.CurrentDirectory;
			while (!(Directory.Exists(NugetP + "\\Packages"))) {
				if (NugetP.Length == 3){Console.WriteLine("No Package found");return;
            }
                // Results in endless Loop if commented out !!!!!!
				NugetP = Directory.GetParent (NugetP).FullName;
			}

			if ((NugetP != null)) {
				NugetP = NugetP + "\\Packages";
				foreach (string Folder in System.IO.Directory.GetDirectories(NugetP)) {
					if (Folder.ToLower().Contains("leptonica")) {
						if (Directory.Exists("Lib")) {
							File.Copy (Folder + "\\Lib", Environment.CurrentDirectory + "\\Lib");
							Console.WriteLine("Restored file from Nuget-Package");
						}
					}
				}
			} else {
			MessageBox.Show  ("Please copy the Leptonica-1.77.0.dll manually to your bin folder");
			}
		}
		private static void CopyFiles()
		{
			if (IntPtr.Size == 4) {
				Console.WriteLine("Init " + DllPath + " for X86");
				File.Copy("Lib\\X86\\" + DllPath, DllPath, true);
			} else {
				Console.WriteLine("Init " + DllPath + " for X64");
				File.Copy("Lib\\X64\\" + DllPath, DllPath, true);
			}
		}
		public static void Initialize()
		{
			CopyNuget();
			CopyFiles();
		}

		public static string GetFullPathFromWindows(string exeName)
		{
			if (exeName.Length > 260) {
				throw new ArgumentException("The exe name is longer than Max Path");
			}
			System.Text.StringBuilder sb = new System.Text.StringBuilder(exeName, 260);
			var retStr = Natives.PathFindOnPath(sb, null) == true ? sb.ToString() : null;
			return retStr;
		}
	}
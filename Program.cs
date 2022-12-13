using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CS.Interop.Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  step 2
            //  This is low-level access. Consider StringBuilder for normal use cases.

            var charArray = new char[256];
            int charsWritten = GetWindowsDirectory(charArray, 256);

            string winDirName = new string(charArray, 0, charsWritten);

            Console.WriteLine($"Windows Directory is: {winDirName}; API has written: {charsWritten} characters to the StringBuilder");
        }

        //  step 1
        //  define a static extern method with the same signature as the Win32 API
        //  Then apply DllImport attribute
        //  Without CharSet it doesn't work.
        //  Auto and Unicode work the same.
        //  Ansi, doesn't work at least in Windows 11.
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern int GetWindowsDirectory(char[] arr, int maxChars);
    }
}

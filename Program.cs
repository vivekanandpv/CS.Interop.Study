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
            StringBuilder sb = new StringBuilder(256);
            int charsWritten = GetWindowsDirectory(sb, 256);

            Console.WriteLine($"Windows Directory is: {sb}; API has written: {charsWritten} characters to the StringBuilder");
        }

        //  step 1
        //  define a static extern method with the same signature as the Win32 API
        //  Then apply DllImport attribute
        [DllImport("kernel32.dll")]
        static extern int GetWindowsDirectory(StringBuilder sb, int maxChars);
    }
}

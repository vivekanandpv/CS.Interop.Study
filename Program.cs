using System;
using System.Runtime.InteropServices;

namespace CS.Interop.Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  step 2
            MessageBox(IntPtr.Zero, "Hello, world!", "Win32 API Interop", 0);
        }

        //  step 1
        //  define a static extern method with the same signature as the Win32 API
        //  Then apply DllImport attribute
        [DllImport("user32.dll")]
        static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);
    }
}

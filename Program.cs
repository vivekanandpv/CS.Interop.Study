﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CS.Interop.Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  step 2
            //  since the structs are value types, we need to pass the struct as ref
            var time = new WindowsTime();
            GetSystemTime(ref time);

            Console.WriteLine($"Windows Time is: {time.Day}-{time.Month}-{time.Year}");
        }

        //  Passing a struct to an unmanaged method
        [DllImport("kernel32.dll")]
        static extern void GetSystemTime(ref WindowsTime wt);
    }

    //  To call GetSystemTime, we define a .NET class (or struct) that matches the C-struct it expects
    //  The order is important as it works with sequential layout. Field names are irrelevant, but the order matters!
    [StructLayout(LayoutKind.Sequential)]
    struct WindowsTime
    {
        public ushort Year;
        public ushort Month;
        public ushort DayOfWeek;
        public ushort Day;
        public ushort Hour;
        public ushort Minute;
        public ushort Second;
        public ushort Milliseconds;
    }
}

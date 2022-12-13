//  In many ways the .NET can be considered as the successor to COM programming model
//  COM implements the rudimentary garbage collection mechanism based on reference counting

//  In COM, one always has to program for the interface. COM doesn't support method overloading.
//  Optional and named parameters are allowed.

//  We start by adding COM reference to the project

using System;

//  import the namespace
using Excel = Microsoft.Office.Interop.Excel;

namespace CS.Interop.Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var excelInstance = new Excel.Application();    //  an appropriate class will be used
            excelInstance.Visible = true;

            Excel.Workbook workBook = excelInstance.Workbooks.Add();
            ((Excel.Range)excelInstance.Cells[1, 1]).Font.FontStyle = "Bold";
            ((Excel.Range)excelInstance.Cells[1, 1]).Value2 = "Hello, there!";
            workBook.SaveAs(@"c:\users\vivek\com-demo.xlsx");
        }
    }
}

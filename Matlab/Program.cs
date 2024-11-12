using System; 
using System.Collections.Generic; 
using System.Text; 

namespace Matlab
{
    class Program
    {
        static void Main(string[] args)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();

            matlab.Execute(@"cd c:\temp\matlabFunction");

            object result = null;

            matlab.Feval("myfunc", 3, out result, 5, 50, "world oo");

            object[] res = result as object[];

            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);
            Console.ReadLine();
        }
    }
}

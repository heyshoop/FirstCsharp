using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func委托
{
    class Program
    {
        static string PrintString() => "hello";

        static void Main(string[] args)
        {
            Func<string> a = PrintString;

            Console.WriteLine(a());
            Console.ReadKey();
        }
    }
}

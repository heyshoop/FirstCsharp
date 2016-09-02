using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        static void PrintString()
        {
            Console.WriteLine("HELLO WORLD");
        }

        static void PrintString(String str)
        {
            Console.WriteLine(str);
        }

        static void PrintString(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            Action<string> a = PrintString;
            Action<int, int> b = PrintString;
            a("你好");
            b(1, 2);
            Console.ReadKey();
        }
    }
}

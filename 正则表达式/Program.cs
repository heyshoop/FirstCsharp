using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            String pattern = @"^\d*$";
            String str = Console.ReadLine();
            bool falg = Regex.IsMatch(str, pattern);
            Console.WriteLine(falg);

            Console.ReadKey();
        }
    }
}

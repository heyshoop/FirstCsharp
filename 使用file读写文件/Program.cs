using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用file读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string[] strArray = File.ReadAllLines("TextFile1.txt");//读取文件,每行为一个字符串，组成数组
            foreach (var str in strArray)
            {
                Console.WriteLine(str);
            }*/

            string str = File.ReadAllText("TextFile1.txt");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}

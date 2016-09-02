using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件操作_查看文件和文件夹信息
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("TextFile1.txt");
            Console.WriteLine(fileInfo.Exists);

            Console.ReadKey();
        }
    }
}

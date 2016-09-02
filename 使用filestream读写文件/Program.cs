using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用filestream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建文件流，用来操作文件
            FileStream stream = new FileStream("TextFile1.txt",FileMode.Open);
            //2.读取或者写入数据
            byte[] data = new byte[1024];
            while (true)
            {
                int length = stream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }
                for (int i = 0; i < length; i++)
                {
                    Console.Write(data[i] + " ");
                }
            }
           
            Console.ReadKey();
        }
    }
}

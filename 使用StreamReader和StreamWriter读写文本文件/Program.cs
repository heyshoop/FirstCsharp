using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用StreamReader和StreamWriter读写文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            ///创建文本文件读取流
            //StreamReader reader = new StreamReader("TextFile1.txt");
            
            //方法一
            /*while (true)
            {

                string str = reader.ReadLine();
                if (str == null)
                {
                    break;
                }
                Console.WriteLine(str);
            }*/


            //方法二
           /* string str = reader.ReadToEnd();
            Console.WriteLine(str);*/



            //方法三
           /* while (true)
            {
                int res = reader.Read();
                if (res == -1)
                {
                    break;
                }
                else
                {
                    Console.Write((char)res);
                }
            }*/
            


            //reader.Close();


            //创建文本写入流
            StreamWriter writer = new StreamWriter("test.txt");//如果文件存在，文件会被覆盖
            while (true)
            {
                string message = Console.ReadLine();
                if (message == "q")
                {
                    break;
                }
               // writer.Write(message);//写入一个字符串
                writer.WriteLine(message);//写入一个字符串并换行
            }
            writer.Close();
            Console.ReadKey();
        }
    }
}

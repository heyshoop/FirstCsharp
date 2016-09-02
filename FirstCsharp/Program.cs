using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double realCoord, imagCord;
            double realTemp, realTemp2,imageTemp, arg;
            int iterations;
            for (imagCord = 1.2; imagCord >= -1.2; imagCord -=0.05)
            {
                for (realCoord = -0.6;  realCoord<= 1.77; realCoord +=0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imageTemp = imagCord;
                    arg = (realCoord * realCoord) + (imagCord * imagCord);
                    while ((arg<4)&&(iterations<40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imageTemp * imageTemp) - realCoord;
                        imageTemp = (2 * realTemp * imageTemp) - imagCord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imageTemp * imageTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }

                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}

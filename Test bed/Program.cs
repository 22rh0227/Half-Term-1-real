using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_bed
{
    using System;
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            


            for(int i = 3; i <= 33; i+=3)
            {
                if (i < 33)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                if (i > 0)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine();

            for (double i = 0; i <= 5; i+=0.5)
            {
                if (i != 5)
                {
                    Console.Write(i + ", ");
                }

                else
                {
                    Console.Write(i);
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i != 10)
                {
                    Console.Write(Math.Pow(i, 2) + ", ");
                }

                else
                {
                    Console.Write(Math.Pow(i, 2));
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i != 10)
                {
                    Console.Write(Math.Pow(2, i) + ", ");
                }

                else
                {
                    Console.Write(Math.Pow(2, i));
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i != 10)
                {
                    Console.Write(Math.Pow(2, i) + ", ");
                }

                else
                {
                    Console.Write(Math.Pow(2, i));
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i != 10)
                {
                    Console.Write(Math.Pow(2, i) + ", ");
                }

                else
                {
                    Console.Write(Math.Pow(2, i));
                }
            }


            for (int i = 1; i <= Math.Pow(i, 10); i *= i)
            {
                if (i != Math.Pow(i, 10))
                {
                    Console.Write(i + ',');
                }

                else
                {
                    Console.Write(i);
                }
            }


















            Console.ReadKey();
        }
    }
}

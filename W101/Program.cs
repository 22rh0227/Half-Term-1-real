using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();

            if (name == "Reece")
            { 
                Console.WriteLine("welcome " + name); 
            
            }
            else
            {
                Console.WriteLine("go away");
            }
            Console.ReadKey();


            int num;

            Console.WriteLine("state a number ");

            num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 100)
            {
                Console.WriteLine("this number is between 1 and 100");
            }

            else
            {
                Console.WriteLine("this number is not between 1 and 100");
            }






        }
    }
}

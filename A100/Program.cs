using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100
{
    using System;
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            // #2
            int num1;
            int num2;

            Console.WriteLine("enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter another number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the sum is " + (num1 + num2));
            Console.WriteLine("the multiplication is " + (num1 * num2));
            Console.WriteLine("the sum squared is" + ((num1 + num2) * (num1 + num2)));


            // #3
            NumberFormatInfo nfi = new CultureInfo("en-GB", false).NumberFormat;

            int slabsAcross;
            int slabsDeep;
            float slabPrice;
            float total;

            Console.WriteLine("enter number of slabs");
            slabsAcross = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number of deep slabs");
            slabsDeep = int.Parse(Console.ReadLine());

            Console.WriteLine("enter price of a slab");
            slabPrice = float.Parse(Console.ReadLine());

            total = (slabsAcross + slabsDeep) * slabPrice;
            Console.WriteLine(total.ToString("C", nfi));





            Console.ReadKey();
        }
    }
}

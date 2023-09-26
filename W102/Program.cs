using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter a number between 1 and 5");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                case 4:
                    Console.WriteLine("four");
                    break;

                case 5:
                    Console.WriteLine("five");
                    break;

                default:
                    Console.WriteLine("invalid number entered");
                    break;
            }

            string weather;
            string confirmWeather;

            Console.WriteLine("what is the weather like");
            weather = Console.ReadLine();

            switch (weather.ToLower())
            {
                case "sunny":
                    Console.WriteLine("wear sunhat");

                    Console.WriteLine("is there a risk of tanning");
                    confirmWeather = Console.ReadLine();
                    switch (confirmWeather.ToLower())
                    {
                        case "yes":
                            Console.WriteLine("wear suncream");
                            break;
                    }
                    break;

                case "windy":
                    Console.WriteLine("wear jumper");
                    break;

                case "wet":
                    Console.WriteLine("wear boots");

                    Console.WriteLine("is it raining");
                    confirmWeather = Console.ReadLine();
                    switch (confirmWeather.ToLower())
                    {
                        case "yes":
                            Console.WriteLine("bring umbrella");
                            break;
                    }
                    break;

                case "snowing":
                    Console.WriteLine("wear coat");
                    break;







                    Console.ReadKey();
        }
    }
}

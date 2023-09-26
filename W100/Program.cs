using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //question 1
            string favouriteSubject = "computer science";

            Console.WriteLine(favouriteSubject);



            int number_1;
            int number_2;
            
            Console.WriteLine("state your first number");
            number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("state your second number");
            number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number_1 + number_2);


            //question 2
            string teamName;
            int wins;
            int draws;

            Console.WriteLine("what is the name of the team?");
            teamName = Console.ReadLine();

            Console.WriteLine("how many wins?");
            wins = int.Parse(Console.ReadLine());

            Console.WriteLine("how many draws?");
            draws = int.Parse(Console.ReadLine());

            int total = wins * 3 + draws;

            Console.WriteLine("total points for team " + teamName + " is " + total);


            //question 3
            string name;
            int number;

            Console.WriteLine("what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("enter a number between 1 and 12");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(name + " here is the timestables for " + number);

            for (int i = 1; i < 11; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine(" " + i + " x " + number + " = " + number * i);
                }

                else
                {
                    Console.WriteLine(i + " x " + number + " = " + number * i);
                }
            }









            Console.ReadKey();
        }
    }
}

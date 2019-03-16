using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string answer1 = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? True or False");
            string answer2 = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string answer3 = Console.ReadLine();

            int age = Convert.ToInt32(answer1);
            bool hadDUI = Convert.ToBoolean(answer2);
            int tickets = Convert.ToInt32(answer3);

            bool isQualified = (age > 15 && hadDUI == false && tickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}

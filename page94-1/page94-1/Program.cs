using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page94_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number (0-100):");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isRight = number == 49;

            do
            {
                switch (number)
                {
                    case 49:
                        Console.WriteLine("This is the number I am looking for. Great job!");
                        isRight = true;
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please try again.");
                        Console.WriteLine("Please type in a number (0-100):");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (isRight == false);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page94
{
    class Program
    {
        static void Main(string[] args)
        {

    
            Console.WriteLine("Please type in a number (0-100):");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isRight = number == 49;

            while (isRight == false)
            {
                switch (number)
                {
                    case 49:
                        Console.WriteLine("This is the number I am looking for. Great job!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please try again.");
                        Console.WriteLine("Please type in a number (0-100):");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            ////while (number != 49);

            //while (!isRight)
            //{
            //    if (number != 49)
            //    {
            //        Console.WriteLine("Please try again.");
            //        number = Convert.ToInt32(Console.ReadLine());  
            //    }
            //    else
            //    {
            //        Console.WriteLine("This is the number I am looking for. Great job!");
            //        Console.ReadLine();
            //    }   
            //}

        }
    }
}

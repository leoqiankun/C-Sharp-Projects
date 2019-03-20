using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page100
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[] { "a", "b", "c", "d", "e" };
            Console.WriteLine("1. Please enter a number (0-4) for a letter:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            while (num1 > 4 || num1 < 0)
            {
                Console.WriteLine("Not valid. Please enter again (0-4):");
                num1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your choice is " + array1[num1] + ".");
            


            int[] array2 = new int[] { 123, 324, 345, 456, 678 };
            Console.WriteLine("2. Please enter a number (0-4) for an integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num2 > 4 || num2 < 0)
            {
                Console.WriteLine("Not valid. Please enter again (0-4):");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your choice is " + array2[num2] + ".");
            

            List<string> list1 = new List<string>();
            list1.Add("Adam");
            list1.Add("Mat");
            list1.Add("Ella");
            list1.Add("James");
            list1.Add("Emme");

            Console.WriteLine("3. Please enter a number (0-4) for a name:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            while (num3 > 4 || num3 < 0)
            {
                Console.WriteLine("Not valid. Please enter again (0-4):");
                num3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your choice is " + list1[num3] + ".");
            Console.ReadLine();

        }
    }
}

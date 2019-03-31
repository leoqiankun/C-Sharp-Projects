using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace page154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            string number = Console.ReadLine();
            File.AppendAllText(@"C:\Users\Kun\Desktop\log.txt", number + "\n");
            Console.WriteLine(File.ReadAllText(@"C:\Users\Kun\Desktop\log.txt"));
            Console.ReadLine();
        }
    }
}

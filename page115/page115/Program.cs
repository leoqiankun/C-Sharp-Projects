﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page115
{
    class Program
    {
        static void Main(string[] args)
        {
            Class Class1 = new Class();
            Console.WriteLine("Please enter a whole number:");
            Class1.oddNum = Convert.ToInt32(Console.ReadLine());
            Class Class2 = new Class();
            Console.WriteLine("Please enter another whole number(optional):");
            Class2.oddNum = Convert.ToInt32(Console.ReadLine());
            int result = Class.addOne(Class1.oddNum, Class2.oddNum);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

/*---------------------------------------------------
# Name:        helloworld
# Purpose:     Practice
# version :    1.0
# Author:      kosei.a
#
# Created:     26/5/2015
# Copyright:   kosei.a
# Licence:     your licence
#---------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- 1.1 only 1 time -----");
            Console.WriteLine("Hello World");
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.2 loop 5 times -----");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello World"); 
            }
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.3 print each characters -----");
            string str = "Hello World";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.4 print [l] character only -----");
            foreach (char c in str)
            {
                if (c == 'l')
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.5 print first 4 characters -----");
            Console.WriteLine(str.Substring(0, 4));
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.6 print last 4 characters -----");
            Console.WriteLine(str.Substring(str.Length -4));
            Console.WriteLine("----- End -----\n");

            Console.WriteLine("----- 1.7 print 4 characters from [W] -----");
            Console.WriteLine(str.Substring(str.IndexOf("W"),4));
            Console.WriteLine("----- End -----\n");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

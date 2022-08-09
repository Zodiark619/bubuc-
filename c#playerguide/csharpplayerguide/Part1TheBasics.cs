using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharpplayerguide.Auxiliaries;

namespace csharpplayerguide
{
    internal class Part1TheBasics
    {
        /// <summary>
        /// Question1 for true or false answer
        /// Question2 for definite answer
        /// </summary>



        public static void KnowledgeCheckCSharp_001()
        {
           
            Question("C# is a special-purpose language optimized for making web applications. ", 0);
            Question2("What is the name of the framework that C# runs on? ",".NET");

        }

        public static void InstallVisualStudio_002()
        {
            Console.WriteLine("If you have forked this project and read this sentence by uncommenting the \"InstallVisualStudio_002\" method and running the app, "+
                "that means your IDE has worked flawlessly, for the time being ");
        }
        public static void HelloWorld_003()
        {
            Console.WriteLine("Hello, World!");
        }
        public static void WhatComesNext_004()
        {
            Console.WriteLine("Another Hello, World!");
        }
        public static void TheMakingsOfAProgrammer_005()
        {
            Console.WriteLine("1.Aaaaa");
            Console.WriteLine("2.Bbbbb");
            Console.WriteLine("3.Ccccc");
            Console.WriteLine("4.Eeeee");
            Console.WriteLine("5.Ddddd");
            Question2("How many statements do you think a program can contain? ", "I think the answer is depends on your hardware capabilities. The limitation " +
                "lies on how much memory and processing power required to run your programs which exist inside your application");


        }
        public static void TheDefenseOfConsolas_015()
        {
            Console.Write("Target Row? ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({row}, {column-1})");
            Console.WriteLine($"({row-1}, {column })");

            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row+1}, {column })");


        }
    }
}

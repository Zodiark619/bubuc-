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



        public static void _001_KnowledgeCheckCSharp()
        {
           
            Question("C# is a special-purpose language optimized for making web applications. ", 0);
            Question2("What is the name of the framework that C# runs on? ",".NET");

        }

        public static void _002_InstallVisualStudio()
        {
            Console.WriteLine("If you have forked this project and read this sentence by uncommenting the \"InstallVisualStudio_002\" method and running the app, "+
                "that means your IDE has worked flawlessly, for the time being ");
        }
        public static void _003_HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
        public static void _004_WhatComesNext()
        {
            Console.WriteLine("Another Hello, World!");
        }
        public static void _005_TheMakingsOfAProgrammer()
        {
            Console.WriteLine("1.Aaaaa");
            Console.WriteLine("2.Bbbbb");
            Console.WriteLine("3.Ccccc");
            Console.WriteLine("4.Eeeee");
            Console.WriteLine("5.Ddddd");
            Question2("How many statements do you think a program can contain? ", "I think the answer is depends on your hardware capabilities. The limitation " +
                "lies on how much memory and processing power required to run your programs which exist inside your application");


        }
        public static void _006_ConsolasAndTelim()
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string meme = Console.ReadLine();
            Console.WriteLine($"Noted: {meme} got bread.");
        }
        public static void _007_TheThingNamer3000()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a=Console.ReadLine();//name of item
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b=Console.ReadLine();/*what kind of item*/
            string c = "of Doom";//constant string lateral
            string d = "3000";//another constant string lateral
            Console.WriteLine("The "+b+" "+a+" of "+c+" "+d+"!");

            Console.WriteLine();
            
             c = "Doom";//fixing the bug
            
            Console.WriteLine("After: The " + b + " " + a + " of " + c + " " + d + "!");
            Question2("Aside from comments, what else could you do to make this code more understandable? ","By changing the variable name to " +
                "something more relatable to the purpose of the program, not just a, b, c, or d");
        }
        public static void _008_KnowledgeCheckVariables()
        {
            Question2("Name the three things all variables have ","Type, Name, and Value");
            Question("Variables must always be declared before being used ",1);
            Question("Can you redeclare a variable? ", 0);
            Question2("Which of the following are legal C# variable names? \"answer, 1stValue, value1, $message, delete-me, delete_me, PI\" ", "answer, value1, delete_me, PI");

        }
        public static void _009_TheVariableShop()
        {
            float a = 0.123123123f;
            double b = 0.123123123;
            decimal c = 0.123123213m;
            bool d = true;
            char e = 'f';
            string f = "meoneogne";
            byte g = 23;
            short h = 23;
            int i = 23;
            long j = 23;
            sbyte k = 23;
            ushort l = 23;
            uint m = 23;
            ulong n = 23;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);


        }
        public static void _010_TheVariableShopReturns()
        {
            float a =12f;
            double b = 12;
            decimal c = 123m;
            bool d = true;
            char e ='d';
            string f = "d";
            byte g = 23;
            short h = 23;
            int i = 23;
            long j = 23;
            sbyte k = 23;
            ushort l = 23;
            uint m = 23;
            ulong n = 23;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(j);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
        }

        public static void _015_TheDefenseOfConsolas()
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

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
        public static void _011_KnowledgeCheckTypeSystem()
        {
            Question("The int type can store any possible integer ",0);
            Question2("Order the following by how large their range is, from smallest to largest: short, long, int, byte ", "byte, short, int, long");
            Question("The byte type is signed ", 0);
            Question2("Which can store higher numbers, int or uint? ", "uint");
            Question2("What three types can store floating-point numbers? ", "float, double, decimal");
            Question2("Which of the options in question 5 can hold the largest number? ","double");
            Question2("Which of the options in question 5 is the most precise? ", "decimal");
            Question2("What type does the literal value \"8\" (including the quotes) have? ", "string");
            Question2("What type stores true or false values? ", "bool");
        }
        public static void _012_TheTriangleFarmer()
        {
            Console.Write("Input base size ");
            int base_size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input height ");
            int height = Convert.ToInt32(Console.ReadLine());
            float area = base_size * height / 2;
            Console.WriteLine($"The result of the area is {area}");
        }
        public static void _013_TheFourSistersAndTheDuckBear() {
            Console.Write("How many chocolate eggs gathered today? ");
            int choco = Convert.ToInt32(Console.ReadLine());
            int egg_sister = choco / 4;
            int egg_bear = choco % 4;
            Console.WriteLine($"Each sister receives {egg_sister} egg(s)");
            Console.WriteLine($"The duckbear receives {egg_bear} egg(s)");

            Question2("What are three total egg counts where the duckbear gets more than each sister does? ", "When they are three eggs left to divide, the rest goes to duckbear. E.g. 7 will yield 3 eggs for the duckbear");
             }

        public static void _014_TheDominionOfKings()
        {
            Console.Write("Input how many estate you got? ");int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Input how many duchy you got? "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input how many province you got? "); int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total points= {a*1+b*3+c*6}");

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
        public static void _016_RepairingTheClocktower()
        {
            Console.Write("Input number: ");int a = Convert.ToInt32(Console.ReadLine());
         
                Console.WriteLine(a % 2 == 0 ? "Tick" : "Tock");
               
           
        }
        public static void _017_Watchtower()
        {
            string direction="";
            Console.Write("Input x value: ");int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y value: "); int y = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                if (y > 0) direction = "northwest";
                else if (y == 0) direction = "west";
                else if (y < 0) direction = "southwest";

            }else if (x == 0)
            {
                if (y > 0) direction = "north";
                else if (y == 0) direction = "..., actually they're here";
                else if (y < 0) direction = "south";
            }
            else
            {
                if (y > 0) direction = "northeast";
                else if (y == 0) direction = "east";
                else if (y < 0) direction = "southeast";
            }


            Console.WriteLine("The enemy is to the " +direction+ "!");
        }
        public static void _018_BuyingInventory()
        {

            string[] meong = { "Rope","Torches", "Climbing Equipment", "Clean Water", "Machete" , "Canoe" , "Food Supplies" };
            Console.WriteLine("The following items are available:");
            for(int i = 0; i < meong.Length; i++)
            {
                Console.WriteLine($"{i+1} - {meong[i]}");

            }

            Console.Write("What number do you want to see the price of ");int a = Convert.ToInt32(Console.ReadLine());

            string response;
            response = a switch
            {
                1 => $"{meong[0]} cost 10 gold",
                2 => $"{meong[1]} costs 15 gold",
                3 => $"{meong[2]} costs 25 gold",
                4 => $"{meong[3]} costs 1 gold",
                5 => $"{meong[4]} costs 20 gold",
                6 => $"{meong[5]} costs 200 gold",
                7 => $"{meong[6]} cost 1 gold",

                _ =>"Input number from the shown list only, peasant"
            };
            Console.WriteLine(response);

        }
        public static void _019_DiscountedInventory()
        {
            Console.Write("What is your name? "); string name = Console.ReadLine();

            string[] meong = { "Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies" };
            Console.WriteLine("The following items are available:");
            for (int i = 0; i < meong.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {meong[i]}");

            }

            Console.Write("What number do you want to see the price of "); int a = Convert.ToInt32(Console.ReadLine());

            string response;
            if (name == "bucin")
            {
                response = a switch
                {
                    1 => $"{meong[0]} cost {10/2f} gold",
                    2 => $"{meong[1]} costs {15/2f} gold",
                    3 => $"{meong[2]} costs {25/2f} gold",
                    4 => $"{meong[3]} costs {1/2f} gold",
                    5 => $"{meong[4]} costs {20/2f} gold",
                    6 => $"{meong[5]} costs {200/2f} gold",
                    7 => $"{meong[6]} cost {1/2f} gold",

                    _ => "Input number from the shown list only, peasant"
                };
            }
            else
            {
                response = a switch
                {
                    1 => $"{meong[0]} cost 10 gold",
                    2 => $"{meong[1]} costs 15 gold",
                    3 => $"{meong[2]} costs 25 gold",
                    4 => $"{meong[3]} costs 1 gold",
                    5 => $"{meong[4]} costs 20 gold",
                    6 => $"{meong[5]} costs 200 gold",
                    7 => $"{meong[6]} cost 1 gold",

                    _ => "Input number from the shown list only, peasant"
                };
            }
            
            Console.WriteLine(response);
        }



        public static void _020_ThePrototype()
        {

        }
    }
}

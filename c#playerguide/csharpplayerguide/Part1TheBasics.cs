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
            Question2("What is the name of the framework that C# runs on? ", ".NET");

        }

        public static void _002_InstallVisualStudio()
        {
            Console.WriteLine("If you have forked this project and read this sentence by uncommenting the \"InstallVisualStudio_002\" method and running the app, " +
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
            string a = Console.ReadLine();//name of item
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine();/*what kind of item*/
            string c = "of Doom";//constant string lateral
            string d = "3000";//another constant string lateral
            Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

            Console.WriteLine();

            c = "Doom";//fixing the bug

            Console.WriteLine("After: The " + b + " " + a + " of " + c + " " + d + "!");
            Question2("Aside from comments, what else could you do to make this code more understandable? ", "By changing the variable name to " +
                "something more relatable to the purpose of the program, not just a, b, c, or d");
        }
        public static void _008_KnowledgeCheckVariables()
        {
            Question2("Name the three things all variables have ", "Type, Name, and Value");
            Question("Variables must always be declared before being used ", 1);
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
            float a = 12f;
            double b = 12;
            decimal c = 123m;
            bool d = true;
            char e = 'd';
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
            Question("The int type can store any possible integer ", 0);
            Question2("Order the following by how large their range is, from smallest to largest: short, long, int, byte ", "byte, short, int, long");
            Question("The byte type is signed ", 0);
            Question2("Which can store higher numbers, int or uint? ", "uint");
            Question2("What three types can store floating-point numbers? ", "float, double, decimal");
            Question2("Which of the options in question 5 can hold the largest number? ", "double");
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
            Console.Write("Input how many estate you got? "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input how many duchy you got? "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input how many province you got? "); int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total points= {a * 1 + b * 3 + c * 6}");

        }
        public static void _015_TheDefenseOfConsolas()
        {
            Console.Write("Target Row? ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");

            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");


        }
        public static void _016_RepairingTheClocktower()
        {
            Console.Write("Input number: "); int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a % 2 == 0 ? "Tick" : "Tock");


        }
        public static void _017_Watchtower()
        {
            string direction = "";
            Console.Write("Input x value: "); int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y value: "); int y = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                if (y > 0) direction = "northwest";
                else if (y == 0) direction = "west";
                else if (y < 0) direction = "southwest";

            } else if (x == 0)
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


            Console.WriteLine("The enemy is to the " + direction + "!");
        }
        public static void _018_BuyingInventory()
        {

            string[] meong = { "Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies" };
            Console.WriteLine("The following items are available:");
            for (int i = 0; i < meong.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {meong[i]}");

            }

            Console.Write("What number do you want to see the price of "); int a = Convert.ToInt32(Console.ReadLine());

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

                _ => "Input number from the shown list only, peasant"
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
                    1 => $"{meong[0]} cost {10 / 2f} gold",
                    2 => $"{meong[1]} costs {15 / 2f} gold",
                    3 => $"{meong[2]} costs {25 / 2f} gold",
                    4 => $"{meong[3]} costs {1 / 2f} gold",
                    5 => $"{meong[4]} costs {20 / 2f} gold",
                    6 => $"{meong[5]} costs {200 / 2f} gold",
                    7 => $"{meong[6]} cost {1 / 2f} gold",

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
            Console.Write("User 1, enter a number between 0 and 100: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("User 2, guess the number. ");
            int b;
            while (true)
            {
                Console.Write("What is your next guess? "); b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                } else if (a < b)
                {
                    Console.WriteLine($"{b} is too high.");

                }
                else
                {
                    Console.WriteLine($"{b} is too low.");

                }

            }

        }
        public static void _021_TheMagicCannon()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and Fire");

                } else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");

                } else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($"{i}: Normal");

                }
            }
        }

        public static void _022_TheReplicatorOfDTo()
        {
            int[] meong1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter item number {i + 1}: ");
                meong1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] meong2 = new int[5];

            for (int i = 0; i < 5; i++)
            {

                meong2[i] = meong1[i];
                Console.WriteLine($"Array 2 item {i + 1} is: {meong2[i]}");

            }

        }
        public static void _023_TheLawsOfFreach()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            foreach (var i in array)
            {
                Console.Write(i);

            }
            int currentSmallest = array[0];
            int total = 0;
            foreach (var i in array)
            {
                if (i < currentSmallest)
                {
                    currentSmallest = i;
                }
                total += i;
            }
            Console.WriteLine($"Smallest value in that array: {currentSmallest}");

            Console.WriteLine($"Average value in that array: {(float)total / array.Length}");
        }

        public static void _024_TakingANumber()
        {
            int AskForNumber(string text)
            {
                Console.Write(text);
                int a = Convert.ToInt32(Console.ReadLine());

                return a;
            }
            int AskForNumberInRange(string text, int min, int max)
            {
                Console.Write(text);
                while (true)
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a > min && a < max)
                    {
                        Console.WriteLine("You got the answer right~");
                        return a;

                    }
                    Console.WriteLine("Only input a number that is in range!");
                }
            }

            int a = AskForNumber("What is the most hilarious number is Spongebob Squarepants? ");

            Console.WriteLine($"The answer is {a}");
            Console.WriteLine();
            AskForNumberInRange("Input a number between 1 and 71 ", 1, 71);


        }

        public static void _025_Countdown()
        {
            int Countdown(int number)
            {
                if (number == 1)
                {
                    Console.WriteLine(number);
                    return 1;
                }
                Console.WriteLine(number);

                return number - Countdown(number - 1);

            }

            Countdown(10);
        }

        public static void _026_KnowledgeCheckMemory()
        {
            Question("You can access anything on the stack at any time ", 0);
            Question("The stack keeps track of local variables ", 1);
            Question("The contents of a value type can be placed on the heap ", 1);
            Question("The contents of a value type are always placed on the heap ", 0);
            Question("The contents of reference types are always placed on the heap ", 1);
            Question("The garbage collector cleans up old, unused space on the heap and stack  ", 0);
            Question("If a and b are array variables referencing the same object, modifying a affects b as well ", 1);
            Question("If a and b are ints with the same value, changing a will also affect b ", 0);

        }
        public static void _027_HuntingTheManticore()
        {
            int CannonDamage(int round)
            {
                if (round % 5 == 0 && round % 3 == 0)
                {
                    return 10;
                } else if (round % 5 == 0 || round % 3 == 0)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
            bool CannonDamage2(int shot, int distance)
            {
                if (shot == distance)
                {
                    Console.WriteLine("That round was a direct HIT!");
                    return true;
                }
                else if (shot < distance)
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                    return false;
                }
                else
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                    return false;
                }
            }



            int manticoreHealth = 10;
            int cityHealth = 15;
            int distance;
            while (true)
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
                distance = Convert.ToInt32(Console.ReadLine());
                if (distance > 0 && distance < 100)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Input between 0 and 100!!!");
                }
            }
            Console.WriteLine("Player 2, it is your turn.");
            int round = 1;
            while (manticoreHealth != 0 && cityHealth != 0)
            {
                Console.WriteLine("=======================================");

                Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
                Console.WriteLine($"The cannon is expected to deal {CannonDamage(round)} damage this round.");
                Console.Write("Enter desired cannon range: ");
                int input = Convert.ToInt32(Console.ReadLine());
                var directHit = CannonDamage2(input, distance);



                if (directHit)
                {
                    manticoreHealth -= CannonDamage(round);
                }
                cityHealth--;
                if (manticoreHealth <= 0)
                {
                    Console.WriteLine("The manticore has been destroyed! The city of Consolas have been saved!");
                    break;
                }
                if (cityHealth <= 0)
                {
                    Console.WriteLine("The Uncoded One has eradicated this city and massacred its citizen. You lose");
                    break;
                }

                round++;
            }

        }

        public static void _028_KnowledgeCheckObjects()
        {
            Question2("What two things does an object bundle together? ", " Datas and their methods");
            Question("C# lets you define new types of objects? ", 1);
        }
        enum _029_ChestState { Open, Closed, Locked }

        public static void _029_SimulaTest()
        {
            int statusOpen = (int)_029_ChestState.Open;
            int statusClosed = (int)_029_ChestState.Closed;
            int statusLocked = (int)_029_ChestState.Locked;

            //initialization for patient zero
            string message = "";
            int counter = 0;
            _029_ChestState meong = _029_ChestState.Locked;

            //putting meong here won't update chest state

            while (true) {
                if (meong == _029_ChestState.Locked)
                {
                    counter = statusLocked;
                    message = "The chest is locked. What do you want to do? ";
                }
                else if (meong == _029_ChestState.Open)
                {
                    counter = statusOpen;

                    message = "The chest is open. What do you want to do? ";

                }
                else if (meong == _029_ChestState.Closed)
                {
                    counter = statusClosed;

                    message = "The chest is closed. What do you want to do? ";

                }
                Console.Write(message);
                string choice = Console.ReadLine();
                if (counter == 0)
                {
                    if (choice == "close")
                    {
                        meong = _029_ChestState.Closed;
                    }
                    else
                    {
                        Console.WriteLine("You fail");
                        Console.WriteLine("Only input close!");
                        break;
                    }
                } else if (counter == 1)
                {
                    if (choice == "lock")
                    {
                        meong = _029_ChestState.Locked;
                    }
                    else if (choice == "open")
                    {
                        meong = _029_ChestState.Open;
                    }
                    else
                    {
                        Console.WriteLine("You fail");
                        Console.WriteLine("Only input open or lock!");
                        break;
                    }
                } else if (counter == 2)
                {
                    if (choice == "unlock")
                    {
                        meong = _029_ChestState.Closed;
                    }
                    else
                    {
                        Console.WriteLine("You fail");
                        Console.WriteLine("Only input unlock!");
                        break;
                    }
                }

            }

        }
        enum _030_type { Soup = 1, Stew, Gumbo }
        enum _030_MainIngredient { Mushrooms = 1, Chicken, Carrots, Potatoes }
        enum _030_Seasoning { Spicy = 1, Salty, Sweet }

        public static void _030_SimulaSoup()
        {
            /*_030_type type;
            _030_MainIngredient mainIngredient;
            _030_Seasoning seasoning;*/
            (_030_type, _030_MainIngredient, _030_Seasoning) meong;
            Console.WriteLine("Pick a number based on this list!");

            Console.WriteLine("Types:");
            Console.WriteLine("1 - Soup");
            Console.WriteLine("2 - Stew");
            Console.WriteLine("3 - Gumbo");
            int typeInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Ingredients:");
            Console.WriteLine("1 - Mushrooms");
            Console.WriteLine("2 - Chicken");
            Console.WriteLine("3 - Carrots");
            Console.WriteLine("4 - Potatoes");
            int mainIngredientInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seasoning:");
            Console.WriteLine("1 - Spicy");
            Console.WriteLine("2 - Salty");
            Console.WriteLine("3 - Sweet");

            int seasoningInput = Convert.ToInt32(Console.ReadLine());
            meong = ((_030_type)typeInput, (_030_MainIngredient)mainIngredientInput, (_030_Seasoning)seasoningInput);
            Console.WriteLine($"Your result is= {meong.Item3} {meong.Item2} {meong.Item1}");
        }

        enum _031_arrowheads { Steel=1, Wood, Obsidian }
        enum _031_fletching { Plastic=1, Turkeyfeathers, Goosefeathers }
        class _031_Arrow
        {
            
            private int arrowheads;
            private int fletching;
            private  float length;

            
            public _031_Arrow(int a, int b, float c)
            {
                this.arrowheads = a;
                this.fletching = b;
                this.length = c;

            }
            public  float GetCost()
            {
                float total = 0f;
                if(this.arrowheads == 1)
                {
                    total += 10;
                }
                else if (this.arrowheads == 2)
                {
                    total += 3;
                }
                else if (this.arrowheads == 3)
                {
                    total += 5;
                }
                if (this.fletching == 1)
                {
                    total += 10;
                }
                else if (this.fletching == 2)
                {
                    total += 5;
                }
                else if (this.fletching == 3)
                {
                    total += 3;
                }
                total += length * 0.05f;
                return total;
            }
        }
        public static void _031_VinFletcherArrows()
        {
            Console.WriteLine("Pick a number from list below based on what arrow you would like to make");
            Console.WriteLine("Arrowhead types");

            Console.WriteLine($"1 - {_031_arrowheads.Steel} 10 golds");
            Console.WriteLine($"2 - {_031_arrowheads.Wood} 3 golds");

            Console.WriteLine($"3 - {_031_arrowheads.Obsidian} 5 golds");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fletching types");

            Console.WriteLine($"1 - {_031_fletching.Plastic} 10 golds");
            Console.WriteLine($"2 - {_031_fletching.Turkeyfeathers} 5 golds");
            Console.WriteLine($"3 - {_031_fletching.Goosefeathers} 3 golds");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input arrow length (betweem 60 to 100 centimeters, 0.05 gold each)");
            int c = Convert.ToInt32(Console.ReadLine());
            _031_Arrow susu = new _031_Arrow(a,b,c);
            Console.WriteLine($"Total cost would be: {susu.GetCost()} golds");
            

        }
        enum _032_arrowheads { Steel = 1, Wood, Obsidian }
        enum _032_fletching { Plastic = 1, Turkeyfeathers, Goosefeathers }
        class _032_Arrow
        {

            private int arrowheads;
            private int fletching;
            private float length;


            public _032_Arrow(int a, int b, float c)
            {
                this.arrowheads = a;
                this.fletching = b;
                this.length = c;

            }

            public int GetArrowheads() => arrowheads;
            public int GetFletching() => fletching;
            public float GetLength() => length;

            public float GetCost()
            {
                float total = 0f;
                if (this.arrowheads == 1)
                {
                    total += 10;
                }
                else if (this.arrowheads == 2)
                {
                    total += 3;
                }
                else if (this.arrowheads == 3)
                {
                    total += 5;
                }
                if (this.fletching == 1)
                {
                    total += 10;
                }
                else if (this.fletching == 2)
                {
                    total += 5;
                }
                else if (this.fletching == 3)
                {
                    total += 3;
                }
                total += length * 0.05f;
                return total;
            }
        }
        public static void _032_VinTrouble()
        {
            _032_Arrow susu = new _032_Arrow(1,1,60);
            _032_arrowheads meong1 = (_032_arrowheads)susu.GetArrowheads();
            _032_fletching meong2 = (_032_fletching)susu.GetFletching();
            Console.WriteLine($"Arrowhead= {meong1}");
            Console.WriteLine($"Fletching= {meong2}");
            Console.WriteLine($"Length= {susu.GetLength()}");
        }


        enum _033_arrowheads { Steel = 1, Wood, Obsidian }
        enum _033_fletching { Plastic = 1, Turkeyfeathers, Goosefeathers }
        class _033_Arrow
        {

            private int arrowheads;
            private int fletching;
            private float length;


            public _033_Arrow()
            {
                this.arrowheads = 1;
                this.fletching = 1;
                this.length =60;
            }
            public _033_Arrow(int a, int b, float c)
            {
                this.arrowheads = a;
                this.fletching = b;
                this.length = c;

            }

            public int Arrowheads{ get;set;}
            public int Fletching { get; set; }
            public float Length {
                get => length;
                set
                {
                    if (value < 60 || value > 100)
                    {
                        Console.WriteLine("Arrow length must be between 60 and 100 cm!");
                        Console.WriteLine("Arrow length will become 60 by default");
                    }
                    else
                    {
                        length = value;
                    }
                     } 
                }


            public float GetCost()
            {
                float total = 0f;
                if (this.arrowheads == 1)
                {
                    total += 10;
                }
                else if (this.arrowheads == 2)
                {
                    total += 3;
                }
                else if (this.arrowheads == 3)
                {
                    total += 5;
                }
                if (this.fletching == 1)
                {
                    total += 10;
                }
                else if (this.fletching == 2)
                {
                    total += 5;
                }
                else if (this.fletching == 3)
                {
                    total += 3;
                }
                total += length * 0.05f;
                return total;
            }
        }
        public static void _033_ThePropertiesOfArrow()
        {
            _033_Arrow susu = new _033_Arrow
            {
                Arrowheads=2,Fletching=2,Length=14
            };
            _033_arrowheads meong1 = (_033_arrowheads)susu.Arrowheads;
            _033_fletching meong2 = (_033_fletching)susu.Fletching;
            Console.WriteLine($"Arrowhead= {meong1}");
            Console.WriteLine($"Fletching= {meong2}");
            Console.WriteLine($"Length= {susu.Length}");
        }


        public static void _034_ArrowFactories()
        {

        }
    }
}

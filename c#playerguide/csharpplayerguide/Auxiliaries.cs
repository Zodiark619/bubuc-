using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpplayerguide
{
    internal class Auxiliaries
    {



        public static void Question2(string question,string answer)
        {
            Console.Write(question);
            string choice = Console.ReadLine();
            TrueOrFalse2(choice, answer);


        }
        public static void TrueOrFalse2(string answer,string answer2)
        {
            if (answer == answer2)
            {
                Console.WriteLine("The answer is right!");

            }
            else
            {
                Console.WriteLine($"The answer is \"{answer2}\"");
            }
        }


        public static void Question(string question,int answer)
        {
            Console.Write(question);
            string choice = Console.ReadLine();
            TrueOrFalse(choice, answer);

        }


        public static void TrueOrFalse(string answer,int answer2)
        {
            //for wrong answer
            string counter = answer2 == 1 ? "True" : "False";
            

           
            if (answer != "True" && answer != "False")
            {
                Console.WriteLine("Only answer \"True\" or \"False\", you stupid peasant!");
                Console.WriteLine($"The answer is {counter}");
            }

            if (answer == "True" && answer2 == 1)
            {
                Console.WriteLine("The answer is right!");
                
            }
            else if(answer == "True" && answer2 == 0)
                {
                Console.WriteLine("The answer is wrong!");
              

            }
            if (answer=="False" && answer2 == 0)
            {
                Console.WriteLine("The answer is right!");
               


            }
            else if(answer=="False"&&answer2 == 1)
                {
                Console.WriteLine("The answer is wrong!");
             

            }
            


        }
    }
}

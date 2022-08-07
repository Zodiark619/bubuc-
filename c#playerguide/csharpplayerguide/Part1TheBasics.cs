using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpplayerguide
{
    internal class Part1TheBasics
    {



        public static void TheDefenseOfConsolas_15()
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

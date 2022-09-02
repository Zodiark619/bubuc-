using System;

namespace Kikiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter properticess vehniasl");
            Vehicle myCar=new Vehicle();

            Console.WriteLine("Model name=");
            string s=Console.ReadLine();
            myCar.model = s;

            Console.WriteLine("Manfufactgure");
            myCar.manufacturer = Console.ReadLine();

            Console.WriteLine("Number of doors");
            s=Console.ReadLine();
            myCar.numOfDoors = Convert.ToInt32(s);
            Console.WriteLine("number of wheel");
            myCar.numOfWheels=Convert.ToInt32(s);


            Console.WriteLine("Your vehicle is a ");
            Console.WriteLine(myCar.manufacturer+" "+myCar.model);
            Console.WriteLine("with " + myCar.numOfDoors + " doors, " 
                + "riding on "+myCar.numOfWheels+" wheels");

        }
    }
}

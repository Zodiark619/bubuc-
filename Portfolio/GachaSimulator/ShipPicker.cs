using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaSimulator
{
    internal class ShipPicker
    {
        static Random random=new Random();
        public static string[] PickSomeShips(int numberOfShips)
        {
            string[] pickedShips = new string[numberOfShips];
            for (int i = 0; i < numberOfShips; i++)
            {
                pickedShips[i] = RandomGacha() ;
            }
            return pickedShips;
        }

        private static string RandomGacha()
        {
            List<string> shipPriority = new List<string> { "Kitakaze", "Roon", "Saint Louis", "Seattle", "Georgia" };
            List<string> shipCommon = new List<string> { "Abukuma", "Aoba", "Aulick", "Hermes", "Furutaka", "Oklahoma", "Nevada" };
            List<string> shipRare = new List<string> { "Acasta", "Achilles", "Ajax", "Hamakaze", "Hamman", "Nagatsuki", "Naka", "Newcastle" };
            List<string> shipElite = new List<string> { "Grenville", "Gromky", "Musketeer", "Mutsu", "Nagisa", "Naganami", "Nautilus", "Nelson" };
            List<string> shipSuperRare = new List<string> { "Akagi", "Illustrious", "Indomitable", "San Diego", "Jervis", "Atago" };
            string rarity;
            int counter;
            string ship;

            int value = random.Next( 100000);
            if (value < 5)
            {
                 rarity = "Priority";
                 counter = random.Next(shipPriority.Count);
                 ship = shipPriority[counter];
                
            }

            else if (value < 1000)
            {
                 rarity = "Super Rare";
                 counter = random.Next(shipSuperRare.Count);
                 ship = shipSuperRare[counter];
               
            }
            else if (value < 5000)
            {
                 rarity = "Elite";
                 counter = random.Next(shipElite.Count);
                 ship = shipElite[counter];

            }
            else if (value < 20000)
            {
                 rarity = "Rare";
                 counter = random.Next(shipRare.Count);
                 ship = shipRare[counter];

            }
            else 
            {
                 rarity = "Common";
                 counter = random.Next(shipCommon.Count);
                 ship = shipCommon[counter];

            }

            return $"{ship} : {rarity} rarity (Random Counter = {value})";
        }


       
       
    }
}

using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cards to pick!");
            string line=Console.ReadLine();
            if(int.TryParse(line,out int numberOfCards))
            {
                string[] results=CardPicker.PickSomeCards(numberOfCards);
                foreach(string card in results)
                {
                    Console.WriteLine(card);
                }
                
            }
            else
            {
                Console.WriteLine("Number couldn't be converted!");
            }
        }
    }
}

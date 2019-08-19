using System;

namespace Yahtzee
{
    public class Dice
    {
        Random random = new Random();
        public int Roll()
        {
            return random.Next(1, 6);      
        }

        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int numberRolled = dice.Roll();
            Console.WriteLine(numberRolled);
            
        }
    }
}

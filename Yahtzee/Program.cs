using System;
using System.Collections.Generic;

namespace Yahtzee
{
    public class Dice
    {
        Random random = new Random();
        public int Roll()
        {
            return random.Next(1, 7);      
        }
        public void rollFiveDice()
        {
            List<int> numbersRolled = new List<int>();
            for ( int i = 0; i < 5; i++)
            {
                numbersRolled.Add(Roll());

            }
            foreach(int number in numbersRolled)
            {
                Console.WriteLine(number);
            }
            
            
        }

        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            
            dice.rollFiveDice();
            
            
        }
    }
}

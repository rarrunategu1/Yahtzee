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
        public List<int> rollFiveDice(string rollAgain)
        {
            List<int> numbersRolled = new List<int>();

            for ( int i = 0; i < 5; i++)
                {
                    numbersRolled.Add(Roll());
                    Console.WriteLine(numbersRolled[i]);

                    if(rollAgain == "yes")
                    {
                        continue;
                    }
                }
         
            return numbersRolled;
        }

        

        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            int rolls = 0;
            
            while (true && rolls < 3)
            {
                Console.WriteLine("Would you like to roll your dice?");
                string reRoll = Console.ReadLine();
                
                if (reRoll == "no")
                {
                    return;
                }
                dice.rollFiveDice(reRoll);
                rolls++;
            }

            








        }
    }
}

using System;
using System.Collections.Generic;

namespace Yahtzee
{
    public class Dice
    {
        Random random = new Random();
        List<int> numbersRolled = new List<int>(){0, 0, 0, 0, 0};
        public int Roll()
        {
            return random.Next(1, 7);      
        }
        public List<int> rollFiveDice()
        {   
            int rolls = 0;

            while (true && rolls < 3)
            {
                Console.WriteLine("Would you like to roll all your dice?");
                string reRoll = Console.ReadLine();

                if (reRoll == "no")
                {
                    break;
                }

                else if (reRoll == "yes")
                {
                    rolls++;

                    if (rolls == 1)
                    { 

                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] +=Roll();
                            Console.WriteLine(numbersRolled[i]);
                        }
                        continue;
                    }
                    else if (rolls > 1)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled = new List<int>(){0, 0, 0, 0, 0};
                            numbersRolled[i] += Roll();
                            Console.WriteLine(numbersRolled[i]);

                        }
                    }
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

            dice.rollFiveDice();


            



            








        }
    }
}

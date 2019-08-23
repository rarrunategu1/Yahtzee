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
            int rolls = 3;

            while (true && rolls > 0)
            {
                Console.WriteLine("Would you like to roll all your dice? You have {0} chances to roll.", rolls);
                string reRoll = Console.ReadLine();

                if (reRoll == "no")
                { 
                    rollOneDie();
                }

                //REROLL UP TO 3 TIMES
                else if (reRoll == "yes")
                {
                    rolls--;

                    if (rolls == 2)
                    { 

                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] +=Roll();
                            Console.WriteLine(numbersRolled[i]);
                        }
                        continue;
                    }
                    else if (rolls < 2)
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
            Console.WriteLine("You've run out of rolls.");
            rollOneDie();

            return numbersRolled;
        }
        public List<int> rollOneDie()
        {
            int rolls = 0;
            while (true && rolls < 3)
            
            {
                Console.WriteLine("Would you like to reroll a particular die?");
                string reRollOne = Console.ReadLine();

                if (reRollOne == "no")
                {
                    break;
                }
                else if (reRollOne == "yes")
                {
                    Console.WriteLine("Which would you like to reroll?");
                    

                    int reRollOption = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int index = 0;

                    for (int i = 0; i < numbersRolled.Count; i++)
                    {
                        //get index of number picked in numbersRolled and replace with another Roll

                        index = numbersRolled.IndexOf(reRollOption);

                        
                        

                        //Roll();
                        
                        //Console.WriteLine(numbersRolled[i]);
                        
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

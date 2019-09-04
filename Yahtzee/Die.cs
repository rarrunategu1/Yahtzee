using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Yahtzee
{
    class Die
    {
        Random random = new Random();
        List<int> numbersRolled = new List<int>() { 0, 0, 0, 0, 0 };
        public int Roll(int sidedDice)
        {
            return random.Next(1, (sidedDice + 1));
        }
        public List<int> RollFiveDice()
        {
            int rolls = 3;

            while (true && rolls > 0)
            {
                Console.WriteLine("Would you like to roll all your dice? You have {0} chances to roll.", rolls);
                string reRoll = Console.ReadLine();

                //REROLL UP TO 3 TIMES
                if (reRoll == "yes")
                {
                    if (rolls == 3)
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] += Roll(6);
                            Console.WriteLine(numbersRolled[i]);
                        }
                        
                    }
                    else if (rolls < 3)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] = Roll(6);
                            Console.WriteLine(numbersRolled[i]);

                        }
                    }
                    rolls--;
                }
                else if (reRoll == "no")
                {

                    RollDice();
                    break;
                }
            }

            return numbersRolled;
        }
        public void RollDice()
        {

            while (true)

            {
                Console.WriteLine("Would you like to reroll any dice?");
                string reRollOne = Console.ReadLine();

                if (reRollOne == "no")
                {
                    break;
                }
                else if (reRollOne == "yes")
                {
                    Console.WriteLine("Which number(s) would you like to reroll?  Enter space separated numbers");
                    string reRollOption = Console.ReadLine();

                    //detect a space and create a list from the numbers to compare to the numbersRolled List
                    int[] reRollNumbers = reRollOption.Split(' ').Select(int.Parse).ToArray();

                    Console.WriteLine();

                    List<int> indexOfReRollOption = new List<int>();

                    //find out the index of every number picked to reroll in our original array
                    for (int i = 0; i < reRollNumbers.Length; i++)
                    {
                        if (numbersRolled.Contains(reRollNumbers[i]))
                        {
                            indexOfReRollOption.Add(numbersRolled.IndexOf(reRollNumbers[i]));

                            //need to make sure duplicate numbers show their correct index and doesn't just repeat the same index

                        }
                        //go through numbers Rolled and find compare indexOfReRollOption to index of numbers Rolled
                       
                    }
                    
                    int numbersRemovedCount = 0;
                    for (int i = 0; i < numbersRolled.Count; i++)
                    {

                        for (int j = 0; j < indexOfReRollOption.Count; j++)
                        {
                            if (i == indexOfReRollOption[j])
                            {
                                numbersRolled.RemoveAt(i);
                                numbersRemovedCount++;
                               
                                
                            }
                            numbersRolled.Add(Roll(6));

                            //Console.WriteLine("Index of ReRoll {0}", indexOfReRollOption[j]);

                        }

                        Console.WriteLine(numbersRolled[i]);
                        

                    }
                    
                    //indexOfReRollOption.Clear();

                }
                
                int firstNumber = numbersRolled[0];
                int count = 0;

                for (int i = 0; i < numbersRolled.Count; i++)
                {
                    if (firstNumber == numbersRolled[i])
                    {
                        count++;
                        if (count == 5)
                        {
                        Console.WriteLine("YAHTZEE!!");
                        break;
                        }
                    }
                }
                //return numbersRolled;
            }


        }
    }
}


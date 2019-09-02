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
            return random.Next(1, sidedDice + 1);
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
                    rolls--;

                    if (rolls == 2)
                    {

                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] += Roll(5);
                            Console.WriteLine(numbersRolled[i]);
                        }
                        continue;
                    }
                    else if (rolls < 2)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            numbersRolled[i] = Roll(5);
                            Console.WriteLine(numbersRolled[i]);

                        }
                    }
                }
                else if (reRoll == "no")
                {

                    break;
                }
            }

            //rollOneDie();

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

                    //find out the index of every number picked to reroll in our original array
                    for (int i = 0; i < reRollNumbers.Length; i++)
                    {
                        if (numbersRolled.Contains(reRollNumbers[i]))
                        {

                            //POSSIBILITY OF JUST CHECKING THE VALUES IN THE THE REROLLNUMBERS AGAINST THE NUMBERS ROLLED INSTEAD OF GETTING THE INDEX
                            List<int> indexOfReRollOption = new List<int>();

                            indexOfReRollOption.Add(numbersRolled.IndexOf(reRollNumbers[i]));
                            //indexOfReRollOption.Add(reRollNumbers[i]);

                            //need to make sure duplicate numbers show their correct index and doesn't just repeat the same index

                            foreach (int num in indexOfReRollOption)
                            {
                                Console.WriteLine(num);
                            }
                        }

                        //Console.WriteLine(numbersRolled[i]);
                    }
                    //int indexOfRerollOption = numbersRolled.IndexOf(reRollOption);


                    //for (int i = 0; i < numbersRolled.Count; i++)
                    //{

                    //    if (i == indexOfRerollOption)
                    //   {
                    //     numbersRolled.RemoveAt(i);
                    //   numbersRolled.Add(Roll());
                    //}

                    //Console.WriteLine(numbersRolled[i]);

                    //}

                }
                //return numbersRolled;
            }


        }
    }
}


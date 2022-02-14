using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class Statements
    {
        public static void BranchingIf()
        {
            Console.Write("What level are you: ");
            int level = Convert.ToInt16(Console.ReadLine());

            if (level < 50) 
            {
                Console.WriteLine("Ha! weaklings aren't allowed to enter the party");
            }else if(level >= 50 && level <= 1000)
            {
                Console.WriteLine("Your getting there but your level still isn't high enough. So you are still a Weakling");
            }
            else
            {
                Console.WriteLine("Welcome to the party of the sweats and no-lifers");
                Console.WriteLine("Go touch some grass");
            }

            //One Line Test....
            //int b = 10;
            //if (b > 5) Console.WriteLine("b is bigger than 5");
        }

        public static void Switching()
        {
            Console.Write("Type a number between 1 and 5 to see how much money you have won!!!!: ");
            int money = Convert.ToInt32(Console.ReadLine());
            string moneyEarned = "";

            switch(money) //Using %7 to wrap days in weeks.
            {
                case 1: //In case d == 1
                    moneyEarned = "$3";
                    break;
                case 2: //In case d == 2
                    moneyEarned = "$30";
                    break;
                case 3:
                    moneyEarned = "$300";
                    break;
                case 4:
                    moneyEarned = "$3000";
                    break;
                case 5:
                    moneyEarned = "$30000";
                    break;
                default:
                    moneyEarned = "$0 LOL THIS IS WHAT YOU GET";
                    Console.WriteLine("ALL YOU HAD TO DO WAS TYPE A NUMBER BETWEEN 1 AND 5!!!!!");
                    break;

            }
            Console.WriteLine("Choice number {0} gave you {1}!!!!", money, moneyEarned);
        }

        public static void ForLoops()
        {
            //Used for counting (often with integers)
            //for (initializer; test-expression; updater)
            for(int i = 2; i < 15; i++)
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            //Nested For Loops useful for populating or traversing grid
            //outer loop(i)
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Outer Loop {0}", i);
                //Inner loop (j)
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}", j);
                }
            }
        }

        public static void WhileLoops()
        {
            //while (test-expression == true) { statements }
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }

            //do-while loop  TESTING gets done at the END (or bottom) of the loop
            int j = 0;
            do
            {
                Console.WriteLine("The value of j is {0}", j);
                j++;
            } while (j < 5);

            //do-while are used for accepting input from a user until they "q"
            do
            {
                Console.Write("Enter command: ");
            } while (Console.ReadLine() != "q");
        }

        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "IT";
            monster[1] = "Godzilla";
            monster[2] = "King Kong";
            monster[3] = "Mechazilla";

            Console.WriteLine("Monster List:");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }
        }

        public static void ForEachIterations()
        {
            List<string> weapons = new List<string>();
            weapons.Add("Buster Sword");
            weapons.Add("Crucible");
            weapons.Add("Spitfire");
            weapons.Add("Energy Sword");
            weapons.Add("Portal Gun");
            weapons.Add("BFG 10000");

            Console.WriteLine("List of weapons in inventory:");
            //Iterate through lists...
            foreach(string w in weapons)
            {
                Console.WriteLine("\t{0}", w);
            }
        }
    }
}

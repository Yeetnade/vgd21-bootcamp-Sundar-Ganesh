using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    class MadLib
    {
        public static void Execute()
        {
            Console.WriteLine("Hey there fella, welcome to the Oasis.\nA virtual world where you can do anything you want");
            Console.WriteLine("I'm your humble guide Walter, and I will guide you through this huge world,\nBut before we get started I need to ask some questions");
            Console.Write("What is you real world name?: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Your real name cannot be used in the virtual world so what name will you go by in the virtual world?");
            Console.Write("Type gamer tag: ");
            string gamerTag = Console.ReadLine();
            Console.Write("How old are you?: ");
            int age = Convert.ToInt16(Console.ReadLine());
            int months = age * 12;
            float days = age * 365.25f;
            Console.WriteLine("You're {0} months old and {1} days old", months, days);
            Console.Write("On a scale of 1 to 10 how much of gamer are you?:");
            int gamerLevel = Convert.ToInt16(Console.ReadLine());
            while (gamerLevel > 10 || gamerLevel < 0)
            {
                Console.Write("It's a scale of 1 to 10, try again: ");
                int gamerLevel2 = Convert.ToInt16(Console.ReadLine());
                if(gamerLevel2 <= 10)
                {
                    goto AfterLoop;
                }
            }
            AfterLoop:
            if (gamerLevel <= 4 && gamerLevel >= 1)
            {
                Console.WriteLine("Looks like your a beginner. I'll teach everything you need to know to get you started");
            }
            else if (gamerLevel <= 7 && gamerLevel >= 5)
            {
                Console.WriteLine("You seem to play games pretty often. You should fit in just right");
            }
            else if (gamerLevel <= 10 && gamerLevel >= 8)
            {
                Console.WriteLine("Wow, I would be scared if I was against ya");
            }




        }
    }
}

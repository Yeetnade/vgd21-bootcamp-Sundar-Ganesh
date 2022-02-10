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
            Console.WriteLine("Why hello {0}!!", playerName);

            Console.WriteLine("Your real name cannot be used in the virtual world so what name will you go by in the virtual world?");
            Console.Write("Type gamer tag: ");
            string gamerTag = Console.ReadLine();
            Console.WriteLine("Nice choice, {0}", gamerTag);

            Console.Write("How old are you?: ");
            OnlyNumInput();

            Console.Write("On a scale of 1 to 10 how much of gamer are you?:");
            int gamerLevel = Convert.ToInt16(Console.ReadLine());

            while (gamerLevel > 10 || gamerLevel <= 0)
            {
                Console.Write("It's a scale of 1 to 10, try again: ");
                gamerLevel = Convert.ToInt16(Console.ReadLine());
                if (gamerLevel <= 10)
                {
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
                    goto AfterLoop;
                }
            }
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

            AfterLoop:
            Console.WriteLine("That's all for question lets get started. Where do you wanna head to:\nA calm rpg with plenty of exploration and fights with monsters to shake it up");
            Console.WriteLine("OR \nAn action packed shooter where you go agianst other players with endless respawning and big guns");
            Console.WriteLine("Type an even number for RPG or an Odd number for Shooter \nWhat will it be: ");
            int a = Convert.ToInt16(Console.ReadLine());
            string Answer = (a % 2 == 0) ? "RPG" : "Shooter";
            Console.WriteLine("{0} is a great choice, let's start our adventure", Answer);

            if(a % 2 == 1)
            {
                Console.WriteLine("Welcome to the shooter");
                Console.Write("Choose your primary Weapon type: ");
                string weaponType = Console.ReadLine();
                Console.Write("Name your Weapon: ");
                string weaponName = Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Noiceer");
            }
        }


        public static void OnlyNumInput()
        {
            string _val = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    double val = 0;
                    bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (_x)
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            int age = Convert.ToInt16(_val);

            int months = age * 12;
            float days = age * 365.25f;
            Console.WriteLine("You're {0} months old and {1} days old", months, days);
        }


    }
}

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

            Console.Write("On a scale of 1 to 10 how much of gamer are you?: ");
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
            Console.WriteLine("That's all for questions lets get started. Where do you wanna head to:\nA calm rpg with plenty of exploration and fights with monsters");
            Console.WriteLine("OR \nAn action packed shooter where you go agianst other players with endless respawning and big guns");
            Console.WriteLine("Type 1 for Shooter or 2 for RPG. Any other number will choose a random game");
            Console.Write("What will it be: ");
            int a = Convert.ToInt16(Console.ReadLine());
            string Answer = (a % 2 == 0) ? "RPG" : "Shooter";
            Console.WriteLine("{0} is a great choice, let's start our adventure", Answer);

            if(a % 2 == 1)
            {
                Console.WriteLine("Welcome to the shooter");
                Console.Write("Choose your primary weapon type (can be anything you want): ");
                string weaponType = Console.ReadLine();
                Console.Write("Name your weapon: ");
                string weaponName = Console.ReadLine();
                Console.Write("Create your secondary weapon type (can be anything you want): ");
                string secondaryWeaponType = Console.ReadLine();
                Console.Write("Name your secondary weapon: ");
                string secondaryWeaponName = Console.ReadLine();

                Console.WriteLine("That should be it now get in the battlefield");
                Console.WriteLine("\nWalter throws {0} AKA {1} into the battlefield to fend for himself despite promising to teach him evereything", playerName, gamerTag);
                Console.WriteLine("Suddenly, a guy with blue hair rushes at him while shooting and {0} is forced to use his weapon", gamerTag);
                Console.WriteLine("{0} tries his best to kill him but nothing works and he dies. His gaming experiance of {1} is nothing compared to the competition in this place", gamerTag, gamerLevel);
                Console.WriteLine("{0} respawns and whips out his {1} named {2}. {0} runs forward and spots a helpless player", gamerTag, weaponType, weaponName);
                Console.WriteLine("{0} runs towards him while shooting {1} but runs out of ammo before he could get his first kill", gamerTag, weaponName);
                Console.WriteLine("{0} switches to his {1} named {2} to finsh the job and get his first kill", gamerTag, secondaryWeaponType, secondaryWeaponName);
                Console.WriteLine("{0} plays for a couple more hours, then decided to leave. \nHowever when he tries to leave, the exit button doesn't show up and his body can't move in the real world", gamerTag);
                Console.WriteLine("Relizing that {0} is stuck in here for the rest of his life, {0} sobs in regret while constantly getting killed by other players", gamerTag);

            }
            else
            {
                Console.WriteLine("Welcome to the RPG");
                Console.Write("What type of medival weapon would you like (can be anything you want): ");
                string medivalWeaponType = Console.ReadLine();
                Console.Write("What will you name it: ");
                string medivalWeaponName = Console.ReadLine();
                Console.Write("how many potions would you like to have: ");
                float potions = Convert.ToInt16(Console.ReadLine());
                float healing = potions / 3;
                float strength = potions / 3;
                float magic = potions / 3;
                Console.Write("What would you like your armor to be made of: ");
                string armorType = Console.ReadLine();

                Console.WriteLine("That should be it now get in and do some exploring");
                Console.WriteLine("\nWalter throws {0} AKA {1} into the world to fend for himself despite promising to teach him evereything", playerName, gamerTag);
                Console.WriteLine("Suddenly, a monster approches {0} he is forced to fight", gamerTag);
                Console.WriteLine("{0} tries his best to use his {1} named {2} to kill the beast but his gamer level of {3} is no match for it", gamerTag, medivalWeaponType, medivalWeaponName, gamerLevel);
                Console.WriteLine("{0} gets killed and gets repawned in a diffrent place. \nThis time he goes through his inventory to see what he has", gamerTag);
                Console.WriteLine("{0} has {1} with {2} armor along with {3} healing potions, {4} strength potions, and {5} magic potions", gamerTag, medivalWeaponName, armorType, healing, strength, magic);
                Console.WriteLine("{0} walks forward and spots the same monster that killed him. Hell-bent on revenge {0} rushes at the monster taking it by surprise", gamerTag);
                Console.WriteLine("{0} uses {1} to damage the monster But that doesn't do much and {0} is forced to defend with {1}", gamerTag, medivalWeaponName);
                Console.WriteLine("{0} then drinks {1} healing potions, {2} strength potions, and {3} magic potions, giving him just enough power to slay the beast", gamerTag, healing, strength, magic);
                Console.WriteLine("{0} plays for a couple more hours, then decided to leave. \nHowever when he tries to leave, the exit button doesn't show up and his body can't move in the real world", gamerTag);
                Console.WriteLine("Relizing that {0} is stuck in here for the rest of his life, {0} sobs in regret while constantly getting killed by other monsters", gamerTag);


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

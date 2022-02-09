using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class Storing
    {
        //Enums
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        //First Method
        public static void Initialize()
        {
            Console.WriteLine("Hi");
            Console.WriteLine("C# Bootcamp Initialized.");
        }

        //Second Method
        public static void DemoVariables()
        {
            int employeeID = 5002;
            char firstInitial = 'S';
            float bodyTemp = 98.4f;
            bool isAlive = true;
            string employeeFullName = "Shreyas Sundar Ganesh";

            Console.WriteLine("EmployeeID:\t\t" + employeeID);
            Console.WriteLine("Full Name:\t\t{0}   [{1}]", employeeFullName, firstInitial);
            Console.WriteLine("Body Temp:\t\t{0}\nIs Alive?:\t\t{1}", bodyTemp, isAlive);
        }

        public static void ReadingInput()
        {
            Console.Write("What is your name? > ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Welcome to the Apex Games,\nA bloodsport where you and your team have to be the last team standing among 19 other teams!!!!", playerName);
            Console.Write("How old are you (in years)? > ");
            int ageInYears = Convert.ToInt16(Console.ReadLine());
            int months = ageInYears * 12;
            float days = ageInYears * 365.25f;
            Console.WriteLine("You are {0} months old. You are {1} days old", months, days);
            if (ageInYears < 18)
            {
                Console.WriteLine("Aren't you a little young for this??\nYou really wanna die now??\nWhatever your choice, get ready for drop we're on Kings Canyon today");
            }
            else
            {
                Console.WriteLine("Get ready for drop, we're on Kings Canyon today and Good Luck");
            }
        }

        public static void UsingArrays()
        {
            Console.WriteLine("\nYou Fly into Kings Canyon and land in Skull Town.\nYou encounter it's Wildlife along with some legends");
            string[] enemyName = new string[5];
            enemyName[0] = "A Giant Spider";
            enemyName[1] = "A Prowler";
            enemyName[2] = "A Dragon";
            enemyName[3] = "Jack Cooper";
            enemyName[4] = "BT-7274";

            int[] health = new int[5] { 10, 20, 100, 1000, 2000 };

            System.Random random = new System.Random();
            int num = random.Next(5);
            Console.WriteLine("You encounter {0} in Skull Town.", enemyName[num]);
            if (num == 0)
            {
                Console.WriteLine("\nThe Prowler uses it's claws to attack you but you use your Wingman to kill the prowler");
                Console.WriteLine("The Prowler has " + health[num] + " health");
                while (true)
                {
                    Console.WriteLine("You Shoot the Wingman");
                    Console.WriteLine("The Prowler has " + health[num] + " health");
                    health[num]--;
                    Console.ReadKey();
                    if (health[num] <= 0)
                    {
                        Console.WriteLine("Prowler Killed");
                        break;
                    }

                }


            }
            if (num == 1)
            {
                Console.WriteLine("\nThe Spider tries to web you use but you use your Wingman to kill the spider");
                Console.WriteLine("The Spider has " + health[num] + " health");
                while (true)
                {
                    Console.WriteLine("You Shoot the Wingman");
                    Console.WriteLine("The Spider has " + health[num] + " health");
                    health[num]--;
                    Console.ReadKey();
                    if (health[num] == 0)
                    {
                        Console.WriteLine("Giant Spider Killed");
                        break;
                    }
                }
            }
            if (num == 2)
            {
                Console.WriteLine("\nThe Dragon takes you to its nest");
                Console.WriteLine("The Dragon has " + health[num] + " health");
                while (true)
                {
                    Console.WriteLine("You Shoot the Wingman");
                    Console.WriteLine("The Dragon has " + health[num] + " health");
                    health[num]--;
                    Console.ReadKey();
                    if (health[num] == 0)
                    {
                        Console.WriteLine("Dragon Killed");
                        break;
                    }
                }
            }
            if (num == 3)
            {
                Console.WriteLine("\nAll attempts to kill Jack Cooper are in vain. He out manuvers you with his wall running tech and kills you");
            }
            if (num == 4)
            {
                Console.WriteLine("\nYeah there's no way your beating a titan");
            }



        }

        public static void ConstantsAndEnums()
        {
            //Constants
            const double PI = 3.1415926535;
            Console.WriteLine(PI);

            //PI = 3.14; //Cannot make this change

            //Enums "enumerators" must be declared PRIOR to the methods
            var dayOfWeek = Days.Sunday;
            Console.WriteLine(dayOfWeek);
            if (dayOfWeek == Days.Saturday || dayOfWeek == Days.Sunday)
            {
                Console.WriteLine("Weekend!!!!! Yay");
            }
            else
            {
                Console.WriteLine("Go to Work or School");
            }
        }


    }
}

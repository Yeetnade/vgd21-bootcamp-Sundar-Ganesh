using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class Storing
    {
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
            Console.WriteLine("Hello, {0}! Welcome to the dungeon!!!!", playerName);
            Console.Write("How old are you (in years)? > ");
            int ageInYears = Convert.ToInt16(Console.ReadLine());
            int months = ageInYears * 12;
            float days = ageInYears * 365.25f;
            Console.WriteLine("You are {0} months old. You are {1} days old", months, days);
        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Scary Enemy";
            enemyName[1] = "Very Scary Enemy";
            enemyName[2] = "Extremely Scary Enemy";
            enemyName[3] = "GOD";
            enemyName[4] = "GOD 2.0";

            System.Random random = new System.Random();
            int num = random.Next(5);
            Console.WriteLine("You encountered {0} in a dark dungeon.", enemyName[num]);


            
        }

    } //public static class Storing
}

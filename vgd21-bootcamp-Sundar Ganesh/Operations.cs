using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class Operations
    {

        //Method
        public static void Arithmetic()
        {
            //Use the debugger to watch the changes...
            int a = 9;
            int b = 6;
            int c;

            a++; //Increment
            b--; //Decrement

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b; //Modulo operator... a/b then return the remainder (10/5)=2R0 -> 0
            c = b % b; //(5/10) - 0R5 -> 5
            c = 13 % 2;
            c = 14 % 2;
            c = 15 % 2; //Modulo usually used to check if number is odd or even...

            //Assingment
            a += b; 
            a -= 7;
            a *= b;
            a /= 7;
        }


        public static void Comparison()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
            Console.WriteLine(a != b);
            Console.WriteLine(a > c);
            Console.WriteLine(a >= c);
            Console.WriteLine(a < c);
            Console.WriteLine(a <= c);
        }

        public static void Logic()
        {
            bool hasWeapon = true;
            bool hasMagic = false;

            //Four operators: NOT ! , AND && , OR ||, XOR ^
            if (!hasMagic) Console.WriteLine("No magic");
            if (hasWeapon && hasMagic) Console.WriteLine("Has a weapon and magic... very dangerous!");
            //For && to return TRUE, BOTH must be true: TT
            if (hasWeapon || hasMagic) Console.WriteLine("Can attack with weapon OR magic");
            //OR can be true for this combination: FT, TF, TT

            //XOR True for these combinations: FT, TF, 
            if (hasWeapon ^ hasMagic) Console.WriteLine("Onely one attack method.");
        }

        public static void Ternary()
        {
            int a, b, c;
            a = 18;
            b = 19;
            c = (a != b) ? a : b; //Ternary Operator
            //c = (test) ? (a if the test is true) : (b if the test is false)
            Console.WriteLine(c);

            //Equivalent code:
            if(a != b)
            {
                c = a;
            }
            else
            {
                c = b;
            }

            //An even/odd tester
            string Answer = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1} ", a, Answer);

        }
    }
}

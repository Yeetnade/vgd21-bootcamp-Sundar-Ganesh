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
    }
}

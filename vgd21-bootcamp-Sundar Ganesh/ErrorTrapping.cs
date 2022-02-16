using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class ErrorTrapping
    {
        public static void DontCatchError()
        {
            Console.WriteLine("The Dvide by Zero Probelm...");
            int numerator = 10;
            for(int d = -3; d <= 3; d++)
            {
                int answer = numerator / d;
                Console.WriteLine("{0}/{1} = {2}", numerator, d, answer);
            }
        }

        public static void CatchError()
        {
            try
            {
                Console.WriteLine("The Dvide by Zero Probelm...");
                int numerator = 10;
                for (int d = -3; d <= 3; d++)
                {
                    int answer = numerator / d;
                    Console.WriteLine("{0}/{1} = {2}", numerator, d, answer);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("We caught an error!");
                Console.WriteLine(error.Message);
                Console.WriteLine("Continue on, admiral!!!");
            }
        }
    }
}

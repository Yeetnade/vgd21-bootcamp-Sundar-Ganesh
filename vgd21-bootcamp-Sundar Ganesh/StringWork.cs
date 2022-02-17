using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_Sundar_Ganesh
{
    public static class StringWork
    {
        public static void StringFeatures()
        {
            Console.WriteLine("Please enter some text: ");
            string text = Console.ReadLine();
            if(String.IsNullOrEmpty( text ))
            {
                Console.WriteLine("!!! Error. No text entered !!!");
            }
            else
            {
                Console.Write("You entered {0} ", text);
                string query = text.StartsWith("C#") ? "does" : "does not";
                Console.WriteLine(", Your text {0} start with C#", query);
                query = text.EndsWith("fun") ? "does" : "does not";
                Console.WriteLine("Your text {0} end with 'fun'", query);
                query = text.Contains(" is") ? "does" : "does not";
                Console.WriteLine("your text {0} conatain 'is'");
            }
        }

        public static void ManipulatingStrings()
        {
            Console.WriteLine("Please enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine("You entered '{0}' ", text);
            Console.WriteLine("\tText Length: {0}", text.Length);
            text = text.Trim();
            Console.WriteLine("\tTrimmed Text Length: {0}", text.Length);
            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine("\t{0}\n\t{1}", upper, lower);
            //Padding
            upper = upper.PadRight(40, '*'); //can use PadLeft
            Console.WriteLine("\nPadded Left: \t{0}", upper);
        }

        public static void JoinAndCompare()
        {
            //A few defferent ways to join strings...
            string[] a = new string[3] { "Alpha", "Beta", "Gamma" };
            string s = string.Concat(a[0], a[2]);
            Console.WriteLine(s);
            s = String.Join(" ", a[0], a[2], a[1]);
            Console.WriteLine(s);
            s = a[0] + " " + a[1] + a[2];
            Console.WriteLine(s);

            //Comparing strings
            int num = String.Compare(a[1], a[1]);
            Console.WriteLine("String compare result is {0}", num);
            Console.WriteLine(a[0] == a[1]); //this works, but not < or >

        }

        public static void FindingSubStrings()
        {
            string phrase = "the quick brown fox jumps over the lazy dog the";
            string searchterm = "the";
            int position = phrase.IndexOf(searchterm, 32);
            Console.WriteLine(position);
        }

        public static void FormattingStrings()
        {
            //Specifiers: G = General, F = Fixed Point, N number with commas, C = Currency,
            //P = perent, 00.000 = Zero Padding
            float number = 1900.56785f;
            Console.WriteLine(number.ToString("G"));
            Console.WriteLine(number.ToString("F"));
            Console.WriteLine(number.ToString("N"));
            Console.WriteLine(number.ToString("C"));
            Console.WriteLine(number.ToString("P"));
            Console.WriteLine("Zero Padding {0:00.0000}", number);

            //Splitting!!!!!!!!!!!!!!!!!
            string data = "the quick brown fox jumps over the lazy dog the";
            string[] items = data.Split(' ');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void DateStrings()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.ToShortDateString());
            DateTime future = now.AddYears(15);
            Console.WriteLine(future.DayOfWeek);

            DateTime birthday = new DateTime(2003, 2, 16);
            DateTime nextYearBirthday = birthday.AddYears(1);
            Console.WriteLine(nextYearBirthday.DayOfWeek);
        }
    }
}

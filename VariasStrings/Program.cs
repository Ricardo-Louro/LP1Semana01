using System;

namespace VariasStrings
{
    /// <summary>
    /// Declare the class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Initialize Main, receiving the array of strings args
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;

            int x = 24;
            char y = '\u00A9';
            string a = "Hello, I'm Bugs";
            string b = $"I'm {x} years old!";
            string c = "I'm {x} years old!";
            string d = @"Hope you guys have a good one! ^__^";
            string e = $"Cool character, {y}";

            string f = "a" + 2;
            string g = "abc" + f;
            string h = $"O valor de g é {g}";
            string i = String.Format("F é {1} e H é {0}", h,f);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            Console.WriteLine(@"Verbatim com f = {0}", f);

            Console.WriteLine($"xx = {xx:f2}");
            Console.WriteLine($"xx = {xx:p1}");

            Console.WriteLine($"ii = {ii:X}");
            Console.WriteLine($"ii = {ii:C}");


        }
    }
}
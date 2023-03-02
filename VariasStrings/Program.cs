using System;

namespace VariasStrings
{
    ///What tags?
    class Program
    {
        ///A lil bit confused
        static void Main(string[] args)
        {
            int x = 24;
            char y = '\u00A9';
            string a = "Hello, I'm Bugs";
            string b = $"I'm {x} years old!";
            string c = "I'm {x} years old!";
            string d = @"Hope you guys have a good one! ^__^";
            string e = $"Cool character, {y}";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
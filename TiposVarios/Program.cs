using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40000;
            byte b = 255;
            short c = -32768;

            char d = '\u00AE';
            char e = '\u00A1';
            char f = '\u00BC';

            float g = 8.92483f;
            double h = 8.92483;

            bool i = true;
            bool j = false;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.WriteLine(i);
            Console.WriteLine(j);

        }
    }
}

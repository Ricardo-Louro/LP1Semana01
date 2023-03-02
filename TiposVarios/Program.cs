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

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

        }
    }
}

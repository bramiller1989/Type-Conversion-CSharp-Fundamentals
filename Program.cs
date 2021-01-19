using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Conversion - byte to int");
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Explicit Conversion using casting - int to byte");
            i = 1;
            b = (byte)i;
            Console.WriteLine(b);
        }
    }
}

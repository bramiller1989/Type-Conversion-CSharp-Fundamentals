﻿using System;

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

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Convert non compatible type - string to int using Convert.ToInt32()");
            var number = "1234";
            int stringToInt = Convert.ToInt32(number);
            Console.WriteLine(stringToInt);
        }
    }
}

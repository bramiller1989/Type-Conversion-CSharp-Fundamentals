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

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Convert non compatible type - string to int using Convert.ToInt32()");
            var number = "1234";
            i = Convert.ToInt32(number);
            Console.WriteLine(i);

            Console.WriteLine("-----------------------------------------------");

            try
            {
                Console.WriteLine("Convert non compatible type - string to byte using Convert.ToByte() and try/catch overflow exception");
                b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            Console.WriteLine("-----------------------------------------------");

            try
            {
                Console.WriteLine("Convert non compatible type - string to bool using Convert.ToBoolean()");
                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);
            }
            catch (Exception)
            {
                Console.WriteLine("String could not be converted to a bool");
            }
        }
    }
}

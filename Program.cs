using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            var totalprice = 20.95f;
            //char mychar = 'A';
            const float Pi = 3.14f;
            Console.WriteLine("Pi value is " + Pi );

            bool isworking = true;

            if (isworking == true)
                    {
                Console.WriteLine("total price is -->" + totalprice);
                Console.WriteLine("{0} {1}", "Min Value Byte "+ byte.MinValue, "Max Value Byte " + byte.MaxValue);
                Console.WriteLine("{0} {1}", "Min Value float " + float.MinValue, "Max Value Float " + float.MaxValue);
            }

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Number could not be converted into Byte Data Type");
                Console.WriteLine(e.Message.ToString());
                //throw;

                
            }

        //Ccamel Case, firtName variable
        //Pascal Cae: FirstName constants
        //HungarianNotation strFirstName
        // Ctrl Shift B-->Compile Application 
        }
    }
}

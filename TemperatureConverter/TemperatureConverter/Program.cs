﻿using System;

namespace TemperatureConverter
{
    class MyApp
    {

        static void Main(string[] args)
        {

            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();
            Console.ReadLine();

        }
    }
}

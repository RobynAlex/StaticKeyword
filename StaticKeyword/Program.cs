using System;

namespace StaticKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32);
            var fahren = TempConverter.CelsiusToFahrenheit(0);
            
            Console.WriteLine($"In Celsius, it is {celsius} degrees");
            Console.WriteLine($"In Fahrenheit, it is {fahren} degrees");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
           var result = (fahrenheit - 32) / 1.8;

            return result;
        }


        public static double CelsiusToFahrenheit(double celsius)
        {
            var answer = (celsius * 9) / 5 + 32;

            return answer;
        }







    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main()
        {
            System.Console.WriteLine("enter a double number please");
            String x = System.Console.ReadLine();
            double y = System.Math.Sqrt(System.Convert.ToDouble(x));
            System.Console.WriteLine("The square root of {0} is {1:0.000}",x, y);
        }
    }
}

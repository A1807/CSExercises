using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter a number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = 2*y*y-4*y+3;
            System.Console.WriteLine("The Fahrenheit is {0}", z);
        }
    }
}

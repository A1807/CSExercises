using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter Centigrade scale please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = 1.8*y+32;
            System.Console.WriteLine("The Fahrenheit is {0}", z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter a number as x1 please");
            String x1 = System.Console.ReadLine();
            System.Console.WriteLine("enter a number as y1 please");
            String y1 = System.Console.ReadLine();
            System.Console.WriteLine("enter a number as x2 please");
            String x2 = System.Console.ReadLine();
            System.Console.WriteLine("enter a number as y2 please");
            String y2 = System.Console.ReadLine();

            double Distance = System.Math.Sqrt((System.Convert.ToDouble(x2) - System.Convert.ToDouble(x1)) * (System.Convert.ToDouble(x2) - System.Convert.ToDouble(x1)) + (System.Convert.ToDouble(y2) - System.Convert.ToDouble(y1))*(System.Convert.ToDouble(y2) - System.Convert.ToDouble(y1)));
          
            System.Console.WriteLine("The Distance is {0:0.0}", Distance);
        }
    }
}

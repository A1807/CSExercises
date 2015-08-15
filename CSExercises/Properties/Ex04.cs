using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main()
        {
            System.Console.WriteLine("enter a double number please");
            String x = System.Console.ReadLine();
            double y = System.Math.Sqrt(System.Convert.ToDouble(x));
            System.Console.WriteLine("The square root of" + x + "is" + y);
        }
    }
}

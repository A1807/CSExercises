using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("enter a integer number please");
                String x = System.Console.ReadLine();
                double y = System.Math.Sqrt(System.Convert.ToInt32(x));
                System.Console.WriteLine("The square root of {0} is {1:0.000}", x, y);
            }
            catch {
                System.Console.WriteLine("please enter a INTEGER number ");
            }
        }
    }
}

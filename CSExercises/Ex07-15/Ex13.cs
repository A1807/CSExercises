using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter distance number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = Math.Ceiling ((4 * y + 24)/10);
            System.Console.WriteLine("The total fare is ${0:0.00}", z);
        }
    }
}

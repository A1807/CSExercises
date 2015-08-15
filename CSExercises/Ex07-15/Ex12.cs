using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter distance number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = Math.Round((0.4 * y + 2.40),1);
            System.Console.WriteLine("The total fare is ${0:0.00}", z);
        }
    }
}

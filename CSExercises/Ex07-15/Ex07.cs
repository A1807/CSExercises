using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter salary number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = y * (1 + 0.1 + 0.03);
            System.Console.WriteLine("The salary is {0}", z);
        }
    }
}

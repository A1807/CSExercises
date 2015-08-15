using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex02
    {
        public static void Main()
        {
            System.Console.WriteLine("enter a integer number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = y * y;
            System.Console.WriteLine("The square of" + x + "is" + z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main()
        {
            System.Console.WriteLine("enter a double number please");
            String x = System.Console.ReadLine();
            double y = System.Convert.ToDouble(x);
            double z = y * y;
            System.Console.WriteLine("The square of" + x +"is"+ z);
        
        }
    }
}

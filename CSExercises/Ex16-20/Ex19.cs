using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter your distance travelled please");
            String dis = System.Console.ReadLine();
            double x=Convert.ToDouble(dis);
            double cost;

            if (x < 0.5)
            { 
                cost=2.4;
            }
            else if (x < 9)
            {
                cost = 2.4 + (x - 0.5) * 0.4;
            }
            else
            {
                cost = 2.4 + 8.5 * 0.4 + (x - 9) * 0.5;
            }

            System.Console.WriteLine("Your travel fee is {0:C} grade", cost);

        }
    }
}
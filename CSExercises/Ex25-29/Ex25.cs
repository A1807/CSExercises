using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" please enter an integer number.");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum1 = 1, sum2 = 1, i = 1, j = x;

            for (i = 1; i <= x; i++)
            {
                sum1 = sum1 * i;
            }
                Console.WriteLine("{0} is the factorial number of {1}", sum1,x );

            for (j = x; j>0; j--)
            {
                sum2 = sum2 * j;
            }
                Console.WriteLine("{0} is the factorial number of {1}", sum2, x);

        }
    }
}

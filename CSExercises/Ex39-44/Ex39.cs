using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {            
            long a =1;
            for (int i = 1; i <= n; i++)
            {
                a=a*i;
            }
               

            return a;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number.");
            long x = Convert.ToInt32(Console.ReadLine());
            long y=Factorial(x);
            Console.WriteLine("the factorial of {0} is:{1}",x,y);

        }
    }
}

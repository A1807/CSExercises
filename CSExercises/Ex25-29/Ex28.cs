using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number.");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            double j = Math.Sqrt(x);
         
                for (i = 2; i <= j; i++)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine("The number {0} is not prime",x);                   
                        return;
                    }
                }
                Console.WriteLine("The number {0} is prime.",x);
           
            
        }
    }
}

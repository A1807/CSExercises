using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number.");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 1;

            for (i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum =sum+ i;
                }
            }
                 
            if (sum == x)
            {
                Console.WriteLine("The number {0} is a perfect number.", x);
            }
            else
            {
                Console.WriteLine("The number {0} is a not perfect number.", x);
            }
           
        }
    }
}

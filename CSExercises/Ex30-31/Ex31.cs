using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int x,i,sum;
            for (x = 2; x <= 1000; x++)
            {
                sum = 1;

            for (i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == x)
            {
                Console.WriteLine(x);
            }
            
            
            
            }
            
           
        }
    }
}

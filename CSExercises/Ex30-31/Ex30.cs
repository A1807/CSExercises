using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {

            int x = 5;
            for (x = 5; x <= 10000; x++)
            {
                int i = 2;
                while (x % i != 0 && i <= Math.Sqrt(x))
                {
                    i++;
                }
                if (i > Math.Sqrt(x))
                    Console.WriteLine(x);
            }  

            


        }
    }
}

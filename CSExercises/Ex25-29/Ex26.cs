using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i = 0;
            double inv = 0;
            double sqr = 0;
            double sq = 0;

            for (i = 1; i <= 10; i++)
            {
                inv = 1 / i;
                sqr = Math.Sqrt(i);
                sq = Math.Pow(i, 2);

                Console.WriteLine("{0:0.0}\t{1:0.0##}\t{2:#.0##}\t{3:0.0}\n", i, inv, sqr, sq);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            double i = 0,j=0;
            double x = -5;
            double y;

            for (i = 0; i <10; i++)
            {
                y= 2*x*x-4*x+3;
                x++;
                //Console.WriteLine("{0:0.0}\t{1:0.0}\n", x, y);
                for (j = 0; j < y; j++)
                { Console.Write("*"); }
                Console.WriteLine("\n");
            }


        }
    }
}

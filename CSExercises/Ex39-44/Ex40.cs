using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            double x;
            int i;
            for (i = 1; i < 25; i++)
            {
                x = SQT(i);

                Console.WriteLine("The square root of {0} is {1}",i,x);
            }

        }

        public static double SQT(int y)
        {
            Random a=new Random();
            double G = a.Next(1, y);
            G=G*(y-1);
            G=G+1;
            bool flag=true ;

            do
            {
                if (y == G * G || (G * G <= y + 0.00001 && G * G >= y - 0.00001))
                {
                   
                    flag = false;
                    
                }
                else
                {
                    G = (G + y / G) / 2;
                }
            }
            while (flag);

            return G;
        }

    }
}

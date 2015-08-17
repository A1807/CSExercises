using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" please enter an integer number to find its square root number.");
            int N = Convert.ToInt32(Console.ReadLine());

            Random a = new Random();
            double G = a.Next(1, N);
            bool flag=true ;

            do
            {
                if (N == G * G || (G * G <= N + 0.00001 && G * G >= N - 0.00001))
                {
                    Console.WriteLine("The square root of {0} is {1:0.00000}",N,G );
                    flag = false;
                }
                else
                {
                    G = (G + N / G) / 2;
                }
            }
            while (flag);

        }
    }
}

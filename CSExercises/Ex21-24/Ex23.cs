using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random a =new Random();
            int mind = a.Next(0,10);
            int i = 1;
            bool flag=true ;
            Console.WriteLine("I have think a number, please enter an integer number to guess.");
           
            do
            {

                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == mind)
                {
                    flag = false;

                }
                else
                {
                    Console.WriteLine("Trt again.");
                    i++;
                }

            }
            while (flag);

            if (i<3)
                Console.WriteLine("You are a Wizard!");
            else if (i<6)
                Console.WriteLine("You are a good guess!");
            else
                Console.WriteLine("You are a lousy!");



            Console.WriteLine(a);

        }
    }
}

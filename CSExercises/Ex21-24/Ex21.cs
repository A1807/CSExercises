using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            
            int a =0;

            while (a != 88)
            {
                Console.WriteLine("enter an integer number please");
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Lucky you");
        }
    }
}

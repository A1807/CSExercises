using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter a three-digit number please");
            int a = Convert.ToInt32(System.Console.ReadLine());

            int a1 =a/100;
            int a2 =(a/10)%10;
            int a3 = a % 10;

            if (a == Math.Pow(a1, 3) + Math.Pow(a2, 3) + Math.Pow(a3, 3))
            {
                System.Console.WriteLine(a+"is a Armstrong number ");
             }
            else 
                System.Console.WriteLine(a + "is a Armstrong number ");
        }
    }
}
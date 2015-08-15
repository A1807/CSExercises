using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter a number as a please");
            double a = Convert.ToDouble ( System.Console.ReadLine());
            System.Console.WriteLine("enter a number as b please");
            double b = Convert.ToDouble ( System.Console.ReadLine());
            System.Console.WriteLine("enter a number as c please");
            double c =Convert.ToDouble ( System.Console.ReadLine());
            
            double area;
            double s=(a+b+c)/2;

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("the area of the triangle is" + area);
            }
            else
            { 
                Console.WriteLine("enter error number!"); 
            }



        }
    }
}
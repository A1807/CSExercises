using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            double num5 = 0;

            Console.WriteLine("Please enter a integer phrase");
            double a = Convert.ToDouble(Console.ReadLine()) * 100;
            num1 = Math.Floor(a / 100);

            if ((a - num1 * 100) != 0)
                num2 = Math.Floor((a - num1 * 100) / 50);

            if ((a - num1 * 100 - num2 * 50) != 0)
                num3 = Math.Floor((a - num1 * 100 - num2 * 50) / 20);

            if ((a - num1 * 100 - num2 * 50 - num3 * 20) != 0)
                num4 = Math.Floor((a - num1 * 100 - num2 * 50 - num3 * 20) / 10);

            if ((a - num1 * 100 - num2 * 50 - num3 * 20 - num4 * 10) != 0)
                num5 = Math.Floor((a - num1 * 100 - num2 * 50 - num3 * 20 - num4 * 10) / 5);



            Console.WriteLine("100c:{0}\n50c:{1}\n20c:{2}\n10c:{3}\n5c:{4}\n", num1, num2, num3, num4, num5);
        }


    }

}
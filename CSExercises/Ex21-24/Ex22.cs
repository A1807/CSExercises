using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an integer number please");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter an integer number please");
            int B = Convert.ToInt32(Console.ReadLine());

            int x=A;
            int y=B;
            int HCF = 0;
            int LCM = 0;

                while (A != B)
                {
                    if (A > B)
                        A = A - B;
                    else
                        B = B - A;
                }

                HCF = A;
                LCM = x * y / HCF;
                Console.WriteLine("HCF:{0}\nLCM:{1}",HCF,LCM);

        }
    }
}

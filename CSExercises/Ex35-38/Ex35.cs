using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer phrase");
            string a = Console.ReadLine();
            //int num=0;
            //for (int i = 0; i < a.Length; i++)
            //{ 
            //switch (a[i])
            //{
            //    case 'a':
            //        num++;
            //        break;
            //    case 'e':
            //        num++;
            //        break;
            //    case 'i':
            //        num++;
            //        break;
            //    case 'o':
            //        num++;
            //        break;
            //    case 'u':
            //        num++;
            //        break;
            //    default:
            //        break;
            //}

            //}

            //Console.WriteLine("Total number of vowels:{0}", num);

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                switch (a[i])
                {
                    case 'a':
                        num1++;
                        break;
                    case 'e':
                        num2++;
                        break;
                    case 'i':
                        num3++;
                        break;
                    case 'o':
                        num4++;
                        break;
                    case 'u':
                        num5++;
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("Number of a:{0}\nNumber of e:{1}\nNumber of i:{2}\nNumber of o:{3}\nNumber of u:{4}\n", num1, num2, num3, num4, num5);






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer phrase");
            string a = Console.ReadLine();
            //char x = new char[] { ' ' };
            //char y = new char[] { ',' };
            //char z = new char[] { '.' };

            //string b = a.ToLower;

            int i;
            for ( i = 0; i <=a.Length/2; i++)
            {
                if(a[i]!=a[a.Length-i-1])
                {
                    Console.WriteLine("Not Palindrome");
                    break;
                }
            }

            if (i >a.Length/2)
                Console.WriteLine("Palindrome");

        }
    }
}

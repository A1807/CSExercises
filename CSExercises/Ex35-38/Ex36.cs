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
            Console.WriteLine("Please enter a word or phrase");
            string a = Console.ReadLine();
            string b = a.ToLower();
            string c = null;
            string[] arr = b.Split(new char[] { ' ', ',', '.'},StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < arr.Length;j++ )
            {
                c = c + arr[j];
            }

            int i;

            for ( i = 0; i <=c.Length/2; i++)
            {
                if(c[i]!=c[c.Length-i-1])
                {
                    Console.WriteLine("Not Palindrome");
                    break;
                }
            }

            if (i >c.Length/2)
                Console.WriteLine("Palindrome");

        }
    }
}

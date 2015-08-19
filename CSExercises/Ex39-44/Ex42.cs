using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex42
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string S1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter a string S2");
            string s2 = Console.ReadLine();

            if (FindWord(s1, s2) != -1)
            {
                Console.WriteLine("String S2 occurs in string S1[{0}]", FindWord(s1, s2));
            }
            else
                Console.WriteLine("String S2 does NOT occur in string S1");
        }

        public static int FindWord(string s1, string s2)
        {

            int x = -1;
            int len1 = s1.Length;
            int len2 = s2.Length;

            if (len1 >= len2)
            { 
            for (int i=0;i<(len1-1);i++)
            {
                if (s1[i] .Equals(s2[0]) && (s1.Substring(i, (len2 - 1))).Equals(s2.Substring(1, len2 - 1)) &&(len1-i)>len2)
                {
                    x = i;
                }
                
            }                 
            
            }

            return x;
        }
    }
}

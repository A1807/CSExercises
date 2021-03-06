using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string S1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Please enter a char c1");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a char c2");
            char c2 = Convert.ToChar(Console.ReadLine());

            string s2 = null;
            s2 = Substitute(s1, c1, c2);

            if (s2 != null)
                Console.WriteLine("S1 has been change into:" + s2);
            else
                Console.WriteLine("S1 has not been change");
        }

        public static string Substitute(string s, char c1, char c2)
        {
            string s2=null;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(c1))
                {
                    s2 = s.Substring(0, i) + c2 + s.Substring(i + 1, (s.Length - 1));
                }
            }

            return s2;
        }
    }
}

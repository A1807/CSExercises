using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter a word or phrase");
            string a = Console.ReadLine();
            string[] arr=a.Split(new char[]{' '});
            string b = null;

            for (int i=0;i<arr.Length ;i++)
            {
                string word=arr[i];
                word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length - 1);
                    b = b + word+' ';

            }

            Console.WriteLine(b);




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter your name please");
            String name = System.Console.ReadLine();

            System.Console.WriteLine("enter your gender please (M/F)");
            String gender = System.Console.ReadLine();
            string gen = "M";

            System.Console.WriteLine("enter your age please");
            string age =Convert.ToString ( System.Console.ReadLine());
            int a = Convert.ToInt32(age);

            int value = gender.CompareTo(gen);
            if (value == 0)
            {
                if (a >= 40)
                    gender = "Uncle";
                else gender = "Mr.";
            }

            else
            {
                if (a >= 40)
                    gender = "Aunty";
                else gender = "Ms.";
            } 

            System.Console.WriteLine("Good mornig " + gender + name);

        }
    }
}
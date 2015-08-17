using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter your name please");
            String name=System.Console.ReadLine();

            System.Console.WriteLine("enter your gender please (M/F)");
            String gender=System.Console.ReadLine();
            string gen="M";
            
            int value=gender.CompareTo(gen);
            if (value==0)
               gender="Mr."; 
            else
                gender="Ms.";

            System.Console.WriteLine("Good mornig "+gender+name );

          
        }
        }
    }

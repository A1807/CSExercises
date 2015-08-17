using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter your score please");
            String score = System.Console.ReadLine();
            double x=Convert.ToDouble(score );
            string grade;
            
            if(x>0&&x<=100)
            {
                if(x>=80)
             {
                grade = "A";
             }
                else if (x>=60)
             {
                grade="B";
              }
                else if (x>=40)
             {
                grade="C";
             }
                else 
             {
                grade = "F";
             }


            }
            else 
            {
             grade="**Error**";
             System.Console.WriteLine("Please enter a number 0-100");
            }

            System.Console.WriteLine("You scored {0} marks which is {1} grade",x,grade);


        }
    }
}
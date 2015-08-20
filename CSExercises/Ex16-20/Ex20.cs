using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double price1=0;
            double price2=0;
            double price3=0;
            double cost;

            Console.WriteLine("enter your order of TV please");
            double tv=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your order of DVD please");
            double dvd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your order of MP3 please");
            double mp3 = Convert.ToDouble(Console.ReadLine());

            cost = 900 * tv + 500 * dvd + 700 * mp3;

            if (cost > 5000)
            {
                price1 = 900 * tv * (1 - 0.1);
                price2 = 500 * dvd * (1 - 0.1);
                price3 = 700 * mp3;
            }
            else if (cost >10000)
            {
                price1 = 900 * tv * (1 - 0.15);
                price2 = 500 * dvd * (1 - 0.15);
                price3 = 700 * mp3; }
            else 
            {
                price1 = 900 * tv;
                price2 = 500 * dvd;
                price3 = 700 * mp3;
            }

    
            cost = price1 + price2 + price3;
            Console.WriteLine("the total price is {0:c}",cost );
            


           
            }

                

        }
    }

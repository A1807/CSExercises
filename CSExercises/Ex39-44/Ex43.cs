using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex43
    {

        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("the Hex of {0} is {1}", i, Hex(i));
                Console.WriteLine("the Hex of {0} is {1:x8}", i, i);
            }

        }

        public static string Hex(int i)
        {
            string x;
          
            int c = 0;
            int d = 0;
  
            c = i / 16;                     
            d = i % 16;

            string a = Convert.ToString(Convert.ToDouble (c));
            string b = Convert.ToString(Convert.ToDouble (d));
            
            switch (a)
                {
                    case "10":  a="A"; break;
                    case "11":  a="B"; break;
                    case "12":  a="C"; break;
                    case "13":  a="D"; break;
                    case "14":  a="E"; break;
                    case "15":  a="F"; break;
                    default:  break;
                }
             switch (b)
                 {
                     case "10": b = "A"; break;
                     case "11": b = "B"; break;
                     case "12": b = "C"; break;
                     case "13": b = "D"; break;
                     case "14": b = "E"; break;
                     case "15": b = "F"; break;
                     default: break;
                 }

             x =a+b;

            return x;
        }
    }
}

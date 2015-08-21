using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Ex01_06
{
    class Class_bizcase2
    {
        public static void Main(string[] args)
        {
            
            string oldpost = "Block 839B Singapore 1852";
            Console.WriteLine("Old code is:" + oldpost);
            string newpost = Update(oldpost);
            Console.WriteLine("New post code is:" + newpost);
        }

        static string Update(string oldpost)
        {
            string[] newpost = oldpost.Split(' ');
            string postcode = null;

            string blocknum=newpost[1];

            if (blocknum.Length == 4)
            {
                switch (blocknum[3])
                {
                    case 'A': blocknum = blocknum.Substring(0, 3) + 1; break;
                    case 'B': blocknum = blocknum.Substring(0, 3) + 2; break;
                    case 'C': blocknum = blocknum.Substring(0, 3) + 3; break;
                    case 'D': blocknum = blocknum.Substring(0, 3) + 4; break;
                    case 'E': blocknum = blocknum.Substring(0, 3) + 5; break;
                    case 'F': blocknum = blocknum.Substring(0, 3) + 6; break;
                    case 'G': blocknum = blocknum.Substring(0, 3) + 7; break;
                    case 'H': blocknum = blocknum.Substring(0, 3) + 8; break;
                    default: break;
                }
            }
            else blocknum = blocknum.Insert(0, "0");

            string head = newpost[3].Substring(2,2);

            postcode = head + blocknum;

            return postcode;
        }


    }
}

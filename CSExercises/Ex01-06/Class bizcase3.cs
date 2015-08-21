using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Ex01_06
{
    class Class_bizcase3
    {
        public static void Main(string[] args)
        {
            Console.Write("Old code is:");
            string oldcode =Console.ReadLine();
            
            string newcode = Encrypt(oldcode);
            Console.WriteLine("New post code is:" + newcode);
        }

        public static string Encrypt(string code)
        {
            string code1=null,newcode=null;
            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(code);
            for (int i = 0; i < code.Length;i++ )
            {   
                if (code[i]!='Z'&&code[i]!='z'&&code[i]!='9')
                {
                    asciiBytes[i]++;                   
                }
                else
                {
                    if (code[i] != '9')
                        asciiBytes[i] -= 27;
                    else
                        asciiBytes[i] -= 9;
                }
                code1 +=Convert.ToString ((char)asciiBytes[i]);
              
            }

            for (int i = 0; i <code1.Length; i++)
            {
               newcode+= code1.Substring ((code1.Length- i - 1), 1);
            }

            return newcode;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] a = new int[]{86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            Console.Write("The original array is:");
            for (int i = 0; i < 12; i++)
            {
                Console.Write( a[i]+"\t");
            }

            for (int green = 0; green < a.Length; green++)
            {
                for (int red = green + 1; red < a.Length; red++)
                {
                    if (a[red] < a[green])
                    {
                        int temp = a[red];
                        a[red] = a[green];
                        a[green] = temp;
                    }
                }
            }

            Console.Write("The sorted array is:");
            for (int j = 0; j < 12; j++)
            {
                Console.Write(a[j] + "\t");
            }
        }
    }
}

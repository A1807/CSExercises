using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int [] Sales=new int[12];
            int i,k,x,a,b,ave;
            int j = 0;
            int l = 0;
            int sum = 0;
            int max = 0;
            int min = 0;

            for (i=0;i<12;i++)
            {
            Console.Write("Enter sales for month {0}:",i);
            Sales[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for ( j = 0; j < Sales.Length-1; j++)
            //{
               a = j;
                for (k=j+1;k<Sales.Length; k++)
                {
                    if (Sales[a]>Sales[k])
                    {
                        a=k;
                    }
                }
                    min = j;

                b = l;
                for (k=l+1;k<Sales.Length; k++)
                {
                    if (Sales[b]<Sales[k])
                    {
                        b=k;
                    }
                }
                    max = b;
               
            //}

            for (x = 0; x< 12; x++)
            {
                
                sum=sum+Sales[x];
            }

            ave = sum / Sales.Length;
            
            Console.WriteLine("Maximum Sales:{0}\nMinimum Sales:{1}\nAverage Sales:{2}", max, min, ave);
        }
    }
}

//int temp;
//for (int green = 0; green < Sales.Length; green++)
//{
//    for (int red = green + 1; red < Sales.Length; red++)
//    { 
//        if (Sales[red]<Sales[green ])
//            temp=Sales[red];
//            Sales[red]=Sales[green ];
//            Sales[green ]=temp;
//    }           

//}
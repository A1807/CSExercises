using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] ran = new int[50];


            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            Random a = new Random();
            for (int i = 0; i < 50; i++)
            {             
                ran[i] = a.Next(0, 10);
            }


            for (int i = 0; i < ran.Length-1; i++)
            {
                for (int j = i + 1; j < ran.Length; j++)
                {
                    if (ran[j] < ran[i])
                    {
                        int temp = ran[j];
                        ran[j] = ran[i];
                        ran[i] = temp;
                    }
                }
            }

            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = 0;
            }

            for (int i = 0; i < ran.Length; i++)
            {
                switch (ran[i])
                {
                    case 0:
                        num[0]++;
                        break;
                    case 1:
                        num[1]++;
                        break;
                    case 2:
                        num[2]++;
                        break;
                    case 3:
                        num[3]++;
                        break;
                    case 4:
                        num[4]++;
                        break;
                    case 5:
                        num[5]++;
                        break;
                    case 6:
                        num[6]++;
                        break;
                    case 7:
                        num[7]++;
                        break;
                    case 8:
                        num[8]++;
                        break;
                    case 9:
                        num[9]++;
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("Number\tCount");
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("{0}\t{1}", Convert.ToString(arr[i]).PadLeft(3,' '), Convert.ToString(num[i]).PadLeft(3,' '));
            }

            Console.WriteLine("Number");
            
                
                for (int j = 0; j < 10; j++)
                {   string count = null;
                    if (num[j] != 0)
                    {
                        for (int k = 0; k < num[j];k++ )
                        count = count + "*";
                    }
                    Console.WriteLine("{0}\t" + count, Convert.ToString(arr[j]).PadLeft(3, ' '));
                }

                
            }
        }

        //static string CentrePrint(int[] i)
        //{
        //    string r=null;
        //    for (int j=0;j<10;j++)
        //    {
        //    int Tolen=((8-Convert.ToString(i[j]).Length)/2)+Convert.ToString(i).Length;
        //    r=Convert.ToString(i).PadLeft(Tolen,' ');
        //    }
        //    return r;
        
        //}



        //static void PrintArray(int[] arr)
        //{
        //    Console.Write("[");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]);
        //        if (i != arr.Length - 1)
        //            Console.Write("\t");
        //    }
        //    Console.WriteLine("]");
        //}


    }


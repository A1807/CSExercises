using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int Overall = 0;
            double OverallAverage = 0;

            

            int[,] a = new int[,] { {56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23,},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            Console.WriteLine("The original array is:");
            for (int i = 0; i < a.GetLongLength(0); i++)
            {
                for (int j = 0; j < a.GetLongLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }

                Console.Write("\n");
            }
            Console.Write("\n");

            int[] student = new int[12];
            for (int i = 0; i < 12; i++)
            {
                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + a[i, j];
                }
                student[i] = sum;
            }
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write(student[i] + "\t");
                Overall = Overall + student[i];
            }
            Console.Write("\n");

            int[] subject = new int[4];
            double [] M= new double[4];
            double [] Vareance= new double[4];
            double SumofXM = 0;
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 12; j++)
                {
                    sum = sum + a[j, i];
                }
                subject[i] = sum;
                M[i]=sum/subject.Length;
                
            }
            
            
            for (int i = 0; i < 4; i++)
            {
                double sum = 0;
                for (int j = 0; j < 12; j++)
                {
                    SumofXM=Math.Pow ((a[j, i]-M[i]),2);
                    sum = sum + SumofXM;
                }
                Vareance[i] =Math.Sqrt( sum / 12);               
            }
            
            
            
            
            for (int i = 0; i < subject.Length; i++)
            {
                Overall = Overall + subject[i];
            }
            OverallAverage = Overall / 48;

            Console.Write("The deviation of marks for each subjuect is:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(+M[i] + "\t");
            }
            Console.Write("\n");

            Console.Write("The overallaverage is:{0}", OverallAverage);

        }
    }
}

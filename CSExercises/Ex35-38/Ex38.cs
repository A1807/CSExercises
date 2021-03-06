using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[,] student = new string[,] { { "John","63" }, {"Venkat", "29" }, {"Mary", "75" }, { "Victor", "82" } ,{"Betty","55"}};
            Console.WriteLine("The original table is:");
            for (int i = 0; i < student.GetLongLength(0); i++)
            {
                for (int j = 0; j < student.GetLongLength(1); j++)
                {
                    Console.Write(student[i, j] + "\t");
                }

                Console.Write("\n");
            }
            Console.Write("\n");

            //by marks
            for (int i = 0; i < student.GetLongLength(0) - 1; i++)
            {
                for (int j = i + 1; j < student.GetLongLength(0); j++)
                {
                    string r = student[i, 1];
                    string g = student[j, 1];
                    int comp = r.CompareTo(g);

                    if (comp < 0)
                    {
                        string temp = student[j, 0];
                        student[j, 0] = student[i, 0];
                        student[i, 0] = temp;

                        temp = student[j, 1];
                        student[j, 1] = student[i, 1];
                        student[i, 1] = temp;

                    }
                }
            }


            ////by name 
            //for (int i = 0; i < student.GetLongLength(0)-1; i++)
            //{
            //    for (int j = i + 1; j < student.GetLongLength(0); j++)
            //    {
            //        string r = student[j, 0];
            //        string g = student[i, 0];
            //        int comp = r.CompareTo(g);

            //        if (comp < 0)
            //        {
            //            string temp = student[j, 0];
            //            student[j, 0] = student[i, 0];
            //            student[i, 0] = temp;

            //            temp = student[j, 1];
            //            student[j, 1] = student[i, 1];
            //            student[i, 1] = temp;

            //        }
            //    }
            //}





            for (int i = 0; i < student.GetLongLength(0); i++)
            {
                for (int j = 0; j < student.GetLongLength(1); j++)
                {
                    Console.Write(student[i, j] + "\t");
                }

                Console.Write("\n");
            }
            Console.Write("\n");



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Ex01_06
{
    class Class_bizcase1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the customer bill");
            string bill = Console.ReadLine();
            double num =Convert.ToDouble(bill);

            //qu xiaoshuwei
            string cent =Convert.ToString( Convert.ToDouble (num * 100) % 100);
            string coin = Ten(cent[0],cent[1]);
            if (coin != null)
                coin = " and Cent " + coin;

            //qu zhengshuwei 
            char[] integer = new char[bill.Length-3];
            //foreach (int i in integer)
            //    integer[i] = ' ';
            int j= 0;
            for (int i=(bill.Length-4);i>=0;i--)
            {
                integer[j] = bill[i];
                j++;
            }

            string decade=null, hundred=null, thousand=null,total=null;
            double dollar =Math.Floor(num);


            if (dollar != 0)//panduan shifou you dollar zifu
            {
                //ge shi bai wei
                if (integer[1] != '0' && integer[0] != '0')
                {
                    if (integer.Length >= 2)
                    {
                        decade = Ten(integer[1], integer[0]);
                    }

                    if (integer.Length >= 3)
                    {
                        hundred = Hundred(integer[2]);
                        if (hundred != null)
                            hundred = hundred + " hundred";
                    }

                    hundred = hundred + " and ";

                }

                if (integer.Length >= 4)
                {
                    thousand = Hundred(integer[3]) + " thousand ";
                    if (integer.Length == 5)
                    {
                        thousand = Ten(integer[4], integer[3]) + " thousand ";
                    }
                }               

                total = "Dollar "+thousand + hundred + decade + coin;
            }
            Console.WriteLine(total+coin+" only.");
        }

        static string Ten(char decade,char unit)
        {
            string result = null;
            if(decade!='0')
            {
                if(decade!='1')
                {
                    switch (decade)
                    {
                        case '2': result = "Twenty";  break;
                        case '3': result = "Thirty";  break;
                        case '4': result = "Forty";   break;
                        case '5': result = "Fifty";   break;
                        case '6': result = "Sixty";   break;
                        case '7': result = "Seventy"; break;
                        case '8': result = "Eighty";  break;
                        case '9': result = "Ninty";   break;
                        default:   break;
                    }
                    switch (unit)
                    {
                        case '1': result += " One"; break;
                        case '2': result += " Two"; break;
                        case '3': result += " Three"; break;
                        case '4': result += " Four"; break;
                        case '5': result += " Five"; break;
                        case '6': result += " Six"; break;
                        case '7': result += " Seven"; break;
                        case '8': result += " Eight"; break;
                        case '9': result += " Nine"; break;
                        default: break;
                    }
                
                }
                else
                {
                    switch (unit)
                    {
                        case '0': result = "Ten";        break;
                        case '1': result = "Eleven";     break;
                        case '2': result = "Twelve";     break;
                        case '3': result = "Thirteen";   break;
                        case '4': result = "Fourteen";   break;
                        case '5': result = "Fifteen";    break;
                        case '6': result = "Sixteen";    break;
                        case '7': result = "Seventeen";  break;
                        case '8': result = "Eighteen";   break;
                        case '9': result = "Ninteen";    break;
                        default:   break;
                    }
               
                }                

            }else 
                    switch (unit)
                    {
                         case '1': result = "One";     break;
                         case '2': result = "Two";     break;
                         case '3': result = "Three";   break;
                         case '4': result = "Four";    break;
                         case '5': result = "Five";    break;
                         case '6': result = "Six";     break;
                         case '7': result = "Seven";   break;
                         case '8': result = "Eight";   break;
                         case '9': result = "Nine";    break;
                         default:  break;  
                    }
            return result;
        }


        static string Hundred(char hund)
        {
            string result = null;
                  switch (hund)
                  {
                        case '1': result = "One";     break;
                        case '2': result = "Two";     break;
                        case '3': result = "Three";   break;
                        case '4': result = "Four";    break;
                        case '5': result = "Five";    break;
                        case '6': result = "Six";     break;
                        case '7': result = "Seven";   break;
                        case '8': result = "Eight";   break;
                        case '9': result = "Nine";    break;
                        default: break;
                  }                   
           return result;
        }


    }
}

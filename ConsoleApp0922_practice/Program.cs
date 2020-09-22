using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_practice
{
    class PrimeNumber
    {
        public void logic(int input)
        {

            bool flag = true;

            for (int i = 2; i <= input; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write("{0}  ", i);
                }

                flag = true;

            }

            Console.WriteLine();
           
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            PrimeNumber p1 = new PrimeNumber();
            //1과 자기 자신만을 약수로 가지는것 솟수?
            Console.WriteLine("값을 입력하시오! : ");
            int max = int.Parse(Console.ReadLine());

            p1.logic(max);
            //int[] input = new int[max];
            



        }
    }
}

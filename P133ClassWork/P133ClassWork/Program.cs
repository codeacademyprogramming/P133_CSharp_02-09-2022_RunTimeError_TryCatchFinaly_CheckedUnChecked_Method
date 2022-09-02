using System;

namespace P133ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class Work 1
            //Console.WriteLine("1-ci Ededi Daxil Et");
            //string input1 = Console.ReadLine();

            //Console.WriteLine("2-ci Ededi Daxil Et");
            //string input2 = Console.ReadLine();

            //Console.WriteLine("3-ci Ededi Daxil Et");
            //string input3 = Console.ReadLine();

            //int num1 = int.Parse(input1);
            //int num2 = int.Parse(input2);
            //int num3 = int.Parse(input3);

            //int graterThanNum = GraterThan(num1, num2, num3);
            //Console.WriteLine(graterThanNum);
            #endregion

            #region Class Work 2
            //string intput1 = Console.ReadLine();
            //string intput2 = Console.ReadLine();
            //string intput3 = Console.ReadLine();
            //string intput4 = Console.ReadLine();
            //string intput5 = Console.ReadLine();

            //int num1 = int.Parse(intput1);
            //int num2 = int.Parse(intput2);
            //int num3 = int.Parse(intput3);
            //int num4 = int.Parse(intput4);
            //int num5 = int.Parse(intput5);

            //int avg = Average(num1, num2, num3, num4, num5);
            //Console.WriteLine(avg);
            #endregion

            #region Class Work 3
            //Isdifadeci Terefinden Daxil Edilen 2 eded
            //araliginda olan cut ededlerin cemini tapan method yazin mutleq yazin

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int sum = GetSumOfRangeNumEvenNums(num1, num2);
            Console.WriteLine(sum);
            #endregion
        }

        static int GetSumOfRangeNumEvenNums(int a, int b)
        {
            int sum = 0;

            int min = 0;
            int max = 0;

            if (a > b)
            {
                min = b;
                max = a;
            }
            else
            {
                min = a;
                max = b;
            }

            while (min <= max)
            {
                if (min % 2 == 0)
                {
                    sum += min;
                }

                min++;
            }

            return sum;
        }

        static int Average(int a, int b, int c, int d, int e)
        {
            int avg = (a + b + c + d + e) / 5;
            return avg;
        }

        static int GraterThan(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else if(c > a && c > b)
            {
                return c;
            }
            else
            {
                Console.WriteLine("Beraberlik Var");
                return 0;
            }
        }
    }
}

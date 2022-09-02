using System;

namespace P133Methods
{
    class Program
    {
        //Method Signature
        //Method Name
        //Method Paramerts Type, Count, Order
        static void WriteConsole(int a, string word = "Hello World")
        {
            GetCountDevideByFive(45, 5646);

            Console.WriteLine(word + a);
        }

        static int GetCountDevideByFive(int num1, int num2)
        {
            int count = 0;

            while (num1 <= num2)
            {
                if (num1 % 5 == 0)
                {
                    count++;
                }

                num1++;
            }

            return count;
        }

        static bool CheckNumForEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            #region Method
            //Console.WriteLine("1-ci Deyeri Daxil Edin");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("2-ci Deyeri Daxil Edin");
            //string input2 = Console.ReadLine();

            //int num1 = int.Parse(input1);
            //int num2 = int.Parse(input2);

            //int myCount = GetCountDevideByFive(num1, num2);

            //bool check = CheckNumForEvenOrOdd(myCount);

            //if (check)
            //{
            //    Console.WriteLine("Cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("tekdir");
            //}

            //Console.WriteLine("1-ci Deyeri Daxil Edin");
            //input1 = Console.ReadLine();
            //Console.WriteLine("2-ci Deyeri Daxil Edin");
            //input2 = Console.ReadLine();

            //num1 = int.Parse(input1);
            //num2 = int.Parse(input2);
            //myCount = GetCountDevideByFive(num1,num2);

            //check = CheckNumForEvenOrOdd(myCount);

            //if (check)
            //{
            //    Console.WriteLine("Cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("tekdir");
            //}
            #endregion

            WriteConsole(133);

            Sum(5,15);
            Sum(5.5,15);
            Sum("asd","asdasd");
        }

        //Method Overloading - Bir Class Daxilin Eyni Add Imzalari Ferqli Olan Methodlar
        static void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Sum(double a,double b)
        {
            Console.WriteLine(a + b);
        }

        static void Sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
    }
}

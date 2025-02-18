using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leeson
{
    class Programm
    {
        public static int task2(int N)
        {
            int NOD = 0;
            for (int i = 2; i <= (int)Math.Sqrt(N); i++)
                if (N % i == 0)
                {
                    NOD = i;
                    break;
                }
            if (NOD != 0)
                return NOD;
            else
                return N;
        }
        public static int task4(int[] a)
        {
            int count = 0;
            foreach (int i in a)
                if (i > 0)
                    count++;
            return count;
        }
        static void Main(string[] args)
        {
            test_task1();
            test_task2();
            test_task4();
            test_task6();
        }
        public static int task1(int[] a)
        {
            int maxCount = 1;
            int currentCount = 1;
            int prevNumber = a[0];
            int i = 1;
            while (a[i] != 0)
            {
                int number = a[i];
                if (number == prevNumber)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                    currentCount = 1;
                prevNumber = number;
                i++;
            }
            return maxCount;

        }
        public static bool task6(string N)
        {
            //string N = Console.ReadLine();
            bool allSame = true;
            char firstDigit = N[0];

            foreach (char digit in N)
            {
                if (digit != firstDigit)
                {
                    allSame = false;
                    break;
                }
            }
            return allSame;
        }
        public static void test_task2()
        {
            Console.WriteLine("Тестируется 2-е задание:");
            int N1 = 2;
            int _count = task2(N1);
            if (_count == 2)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int N2 = 17;
            _count = task2(N2);
            if (_count == 17)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int N3 = 16;
            _count = task2(N3);
            if (_count == 2)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
        public static void test_task4()
        {
            Console.WriteLine("Тестируется 4-е задание:");
            int[] a = { 1, -2, 3, 5 };
            int _count = task4(a);
            if (_count == 3)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a2 = { -1, -2, -3, -5 };
            _count = task4(a2);
            if (_count == 0)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a3 = { 1, 2, 3, 5 };
            _count = task4(a3);
            if (_count == 4)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a4 = { -1, 2, 0, 5 };
            _count = task4(a4);
            if (_count == 2)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
        public static void test_task1()
        {
            Console.WriteLine("Тестируется 1-е задание:");
            int[] a = { 1, 0, 0, 0 };
            int _count = task1(a);
            if (_count == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a2 = { 1, 0 };
            _count = task1(a2);
            if (_count == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a3 = { 1, 2, 3, 4, 5, 0 };
            _count = task1(a3);
            if (_count == 1)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            int[] a4 = { 1, 1, 1, 2, 2, 0 };
            _count = task1(a4);
            if (_count == 3)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
        public static void test_task6()
        {
            Console.WriteLine("Тестируется 6-е задание:");
            string N1 = "222";
            bool _count = task6(N1);
            if (_count == true)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            string N2 = "202";
            _count = task6(N2);
            if (_count == false)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");

            string N3 = "2";
            _count = task6(N3);
            if (_count == true)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Error");
        }
    }
}
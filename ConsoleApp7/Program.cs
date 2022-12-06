using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int b = 20;

            for(int i = 0; i < b; i++)
            {
                for(int s = 0; s < b - i; s++)
                    Console.Write(" ");

                for(int j = 0; j < (2 * i + 1); j++)
                {
                    int p = new Random().Next(1, 100);
                    if (p < 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("▲");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("@");
                    }
                }
                Console.WriteLine();
            }*/



            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[1000000];
            int N = a.Length;

            for (int i = 0; i < 1000000; i++)
            {
                b[i] = i;
            }

            int sum = go(a, 0, N - 1);
            int sum2 = Factorial(5);
            Console.WriteLine((0+1)/2);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(BinarySearch(b, 0, 9999, 18888));
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds); 
            
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Console.WriteLine(BinarySearchUsingLoop(b, 18888));
            stopwatch2.Stop();
            TimeSpan ts2 = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                            ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds);

            Console.WriteLine(DecimalToBinary(8, ""));
            Console.WriteLine(IsPolindrom("qazaq"));
            //Console.ReadKey();
        }
        static int go(int[] a, int l, int r)
        {
            if (l == r)
                return a[l];

            int mid = (l + r) / 2;
            return go(a, l, mid) + go(a, mid + 1, r);
        }

        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        static int BinarySearch(int[] a, int left, int rigth, int x)
        {
            if (left > rigth)
                return -1;

            int mid = (left + rigth)/2;

            if (x == a[mid])
                return mid;

            if (x < a[mid])
                return BinarySearch(a, left, mid-1, x);

            return BinarySearch(a, mid + 1, rigth, x);
        }

        static int BinarySearchUsingLoop(int[] a, int target)
        {
            int l = 0, r=a.Length-1;
            while(l <= r)
            {
                int mid = (l + r)/2;
                if(a[mid] == target) return mid;

                if(target < a[mid])
                    r = mid-1;
                else
                    l = mid+1;
            }

            return -1;
        }

        static string DecimalToBinary(int n, string result)
        {
            if (n == 0) return result;
            result = n % 2 + result;
            return DecimalToBinary(n / 2, result);
        }

        static bool IsPolindrom(string s)
        {
            if (s.Length == 0 || s.Length == 1)
                return true;

            if (s[0] == s[s.Length - 1])
            {
                return IsPolindrom(s.Substring(1, s.Length - 2));
            }
            return false;
        } 
    }
}

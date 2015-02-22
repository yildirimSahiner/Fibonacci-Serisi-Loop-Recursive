using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSureHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {          
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Hangi Sayının Fibonaccisi Lazım?");
            double sayi = Convert.ToDouble(Console.ReadLine());            
            stopwatch.Start();
            Console.WriteLine("Fibonacci:" + Fib_Recursion(sayi));
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed; 
            string elapsedTime = String.Format("{0} saat + {1} dakika + {2} saniye + {3} salise ",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds*10000);
            Console.WriteLine("Toplam Zaman:" + elapsedTime +" geçti.");
            Console.ReadKey();
        
        }
        public static double Fib_Recursion(double sayi)
        {
            if (sayi <= 1)
            {
                return 1;
            }
            else
            {
            return Fib_Recursion(sayi-2) + Fib_Recursion(sayi-1);
            }
       
        }
    }
}

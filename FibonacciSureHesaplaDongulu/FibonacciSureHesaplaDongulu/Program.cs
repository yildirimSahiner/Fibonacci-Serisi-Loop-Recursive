using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSureHesaplaDongulu
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch(); 
            Console.WriteLine("Hangi sayının Fibonaccisi Lazım:");          
            double sayi = Convert.ToDouble(Console.ReadLine()); stopwatch.Start();            
            Console.WriteLine("Fibonacci değeri:" + Fibo_dongu(sayi));
            stopwatch.Stop();
            TimeSpan zaman = stopwatch.Elapsed; 
            string elapsedTime = String.Format("{0} saat + {1} dakika + {2} saniye + {3} salise ", zaman.Hours, zaman.Minutes, zaman.Seconds, zaman.TotalMilliseconds*10000);            
            Console.WriteLine("Toplam Zaman:" + elapsedTime +"geçti ");
            Console.ReadKey(); 
 }

        public static double Fibo_dongu(double fibonacci)
        {
            double degisken1 = 0; double degisken2 = 1;           
            for (int i = 0; i < fibonacci; i++)
            {
                double gecici = degisken1; degisken1 = degisken2;
                degisken2 = gecici + degisken2;
            }
            return degisken1;
        }
        
    }
}

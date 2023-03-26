using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n= ");
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            int gt = 1;
            for  (int i =1; i <= n; i++) 
            {
                    gt = gt * i;
                    tong = tong + gt;
            }
            Console.WriteLine($"Tong giai thua tu 1 den {n} la {tong}");
            Console.ReadKey();
        }
    }
}

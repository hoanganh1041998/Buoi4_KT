using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n =int.Parse(Console.ReadLine());
            int dem_so=0;
            int tong = 0;
            for (int i = 2; i <= n; i++)
            {
                dem_so = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) 
                    {
                        dem_so ++;
                    }
                }
                if (dem_so == 2)
                {
                    tong=tong+i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Tong cac so nguyen to tu 2 den {n} la {tong}");
            Console.ReadLine() ;    
        }
    }
}

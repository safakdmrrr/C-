using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sayi = r.Next (10, 20);

            int[] sayılar = new int[sayi];

            for (int i = 0; i < sayılar.Length; i++)
            {
                int sayi3 = r.Next(0, 1000);
                sayılar[i] = sayi3;

            }
            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

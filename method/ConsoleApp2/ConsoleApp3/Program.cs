using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.sayı giriniz");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı giriniz");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayı giriniz");
            int sayı3 = Convert.ToInt32(Console.ReadLine());

            ortalama.ortalamaa(sayı1, sayı2, sayı3);
            Console.ReadLine();
        }
    }
}

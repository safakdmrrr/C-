using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplam = 1;
            Console.WriteLine("sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=a; i++)
            {
                toplam *= i;
                

            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}

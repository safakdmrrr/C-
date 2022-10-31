using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı yazınız");
            int sayı=Convert.ToInt32(Console.ReadLine());

            if (sayı > 100) 
            {
                Console.WriteLine("Sayı 100 den büyüktür");

            }
            else if (sayı==100)
            {
                Console.WriteLine("Sayı 100 e eşittir");

            }

            else
            {
                Console.WriteLine("Sayı 100 den küçük");
            }
            Console.ReadLine();
        }   
    }
}

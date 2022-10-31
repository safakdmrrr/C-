using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1. Sayıyı giriniz");
            double sayı1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Sayıyı giriniz");
            double sayı2 = Convert.ToDouble(Console.ReadLine());

            if (sayı1>sayı2)
            {
                
                Console.WriteLine("fark  "+(sayı1 - sayı2));

            }
            else
            {
               
                Console.WriteLine("fark" + (sayı2 - sayı1));

            }
            Console.ReadLine();



        }
    }
}

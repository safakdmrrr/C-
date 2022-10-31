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
            Don:
            Console.WriteLine("Vize notunu giriniz");
           int not1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Final Notunu giriniz");
            int not2 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (not1 + not2)/2;


            if (ortalama >=0 && ortalama <= 24)
            {
                Console.WriteLine("FF");
            }
            else if (ortalama >=25 && ortalama <=44 )
            {
                Console.WriteLine("DD");

            }
            else if (ortalama >= 45 && ortalama <= 54)
            {
                Console.WriteLine("CC");

            }
            else if (ortalama >= 55 && ortalama <= 69)
            {
                Console.WriteLine("BB");

            }
            else if (ortalama >= 70 && ortalama <= 84)
            {
                Console.WriteLine("BA");

            }
            else if (ortalama >= 85 && ortalama <=100)
            {
                Console.WriteLine("AA");

            }
            else
            {
                Console.WriteLine("Geçerli değerler giriniz");
                goto Don;
            }
           

            Console.ReadLine();
              
        

        }
    }
}

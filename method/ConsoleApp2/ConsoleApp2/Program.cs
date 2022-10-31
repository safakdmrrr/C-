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
            Console.WriteLine("1.sayı giriniz");
            int sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayı giriniz");
            int sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1-Fark\n2-bolme");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                
                Console.WriteLine("sonuc  "+ıslem.fark(sayı1, sayı2));
                

            }
            else if (secim==2)
            {
                
                Console.WriteLine("sonuc  "+ıslem.bolme(sayı1, sayı2));
            }
            Console.ReadLine();


        }
    }
}

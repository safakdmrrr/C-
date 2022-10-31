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

            int toplam = 0;
            int sayac = 0;
            for (int i = 1; i < 501; i++)
            {
                if (i%13==0)
                {                   
                    toplam += i;
                    sayac++;
                }
                
            }
            Console.WriteLine("++++++toplam+++++++++ "+toplam);
            Console.WriteLine("++++++sayac+++++++++ "+sayac);
            Console.ReadLine();
        }
    }
}

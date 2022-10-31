using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            do
            {
                Console.WriteLine("sayı giriniz");
                int sayı = Convert.ToInt32(Console.ReadLine());
                toplam += sayı;

                if (sayı == 0)
                {
                    Console.WriteLine("Toplam" + toplam);
                    break;
                }

            } while (true);

            Console.ReadLine();




        }
    }
}

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

            Console.WriteLine("Başlangıç değerini yazınız");
            int basla = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitiş değerini yazınız");
            int bitis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artış miktarını yaznız");
            int artış = Convert.ToInt32(Console.ReadLine());

            for (int i = basla; i < bitis; i += artış)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}

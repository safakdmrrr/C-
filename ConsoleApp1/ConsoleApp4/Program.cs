using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aylık geliriniz nedir ?");
             double gelır =Convert.ToDouble (Console.ReadLine());
            if (gelır> 14000)
            {
               double  vergı = gelır * 0.12;
               double kalan = gelır - vergı;
                Console.WriteLine("Vergili hesaplamanız:" + kalan);
                Console.ReadLine();
            }
            else if (gelır <=14000)
            {
                double vergı = gelır * 0.09;
                double kalan = gelır - vergı;
                Console.WriteLine("Vergili hesaplamanız" + kalan);
                Console.ReadLine();

            }


        }
    }
}

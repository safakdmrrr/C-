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
            Don:
            Console.WriteLine("Yaş yazınız");
            int yas =Convert.ToInt32 (Console.ReadLine());
            

            if (yas>=0 && yas <=3)
            {
                Console.WriteLine("Bebek");

            }
            else if (yas >=4 && yas <=10)
            {
                Console.WriteLine("Çocuk");

            }
            else if (yas >= 11 && yas <=  18)
            {
                Console.WriteLine("ergen");

            }
            else if (yas >= 19 && yas <= 28)
            {
                Console.WriteLine("genç");

            }
            else if (yas >= 36 && yas  <= 45)
            {
                Console.WriteLine("orta yaş");

            }
            else if (yas >= 46 && yas <= 55)
            {
                Console.WriteLine("emekli adayı");

            }
            else if (yas >=55 && yas <=100 )
            {
                Console.WriteLine("Emekliliğin tadını cıkarın");

            }
            else
            {
                Console.WriteLine("Geçerli yas yazınız");
                goto Don; 
                
                
            }
                   
            Console.ReadLine();








        }
    }
}

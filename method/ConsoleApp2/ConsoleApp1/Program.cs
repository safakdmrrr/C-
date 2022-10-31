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
             Console.WriteLine("sayı giriniz");
            int sayı1 = Convert.ToInt32(Console.ReadLine());

            
            if (tekcıft.kontrol(sayı1) == true)
            {
                Console.WriteLine("sayı çifttir");
            }
            else
            {
                Console.WriteLine("sayı tektir");
            }
            Console.ReadLine();
            



        }
    }
}

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
            int i = 4;
            while (i>0)
            {
               
                try
                {
                    Console.WriteLine("Sayı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    toplam += sayi;
                    i--;
                    if (i==0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz ");
                    break;
                    
                }

                
                
            }
            Console.WriteLine("Toplam; "+toplam);
            Console.ReadLine();
        }
    }
}

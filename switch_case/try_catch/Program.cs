using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            a:
            try
            {

                Console.WriteLine("1.sayıyı giriniz");
                int sayı1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2.sayıyı giriniz");
                int sayı2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Toplam: " + (sayı1 + sayı2));

            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen rakam giriniz!!!");
                goto a;


            }


            Console.ReadLine();
        }
    }
}

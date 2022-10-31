using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace while3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "123";

            int adet = 3;

            while (adet > 0)
            {
                Console.WriteLine("kullanıcı adını giriniz");
                string ad = Console.ReadLine();

                Console.WriteLine("şifre giriniz");
                string sifre = (Console.ReadLine());

                if (ad == username && sifre == password)
                {
                    Console.WriteLine("giriş başarılı");
                    break;

                }
                else if(adet>0)
                {
                    Console.WriteLine("tekrak deneyin");

                }

                adet--;
                if (adet == 0)
                {
                    Console.WriteLine("hakkınız bitti 10 saniye sonra tekrardan başlayacak ");

                    Thread.Sleep(3000);

                    
                    Console.ReadLine();

                }

            }
            Console.ReadLine();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgele_sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Başlangıç değerini yazınız");
                int baslangıc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("bitiş değerini yazınız");
                int bitis = Convert.ToInt32(Console.ReadLine());
                if (baslangıc <= bitis)
                {
                    method.sayıUret(baslangıc, bitis);
                    break;
                }
                else
                {
                    Console.WriteLine("başlangıç değeri  bitiş değerinden büyük olamaz!!!!!!!!");
                }


            }



        }
    }
}

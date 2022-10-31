using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("kaç ürün satın aldınız");
            //    int adet = Convert.ToInt32(Console.ReadLine()); //3

            //    int odeme = 0; //15,45

            //    while (adet>0)
            //    {
            //        Console.WriteLine("Ürün Fiyatı:"); //15,30
            //        int fiyat = Convert.ToInt32(Console.ReadLine());
            //        odeme += fiyat; //odeme=odeme+fiyat;
            //        adet--;

            //    }

            //    Console.WriteLine("ÖDEME:"+odeme);

            //    Console.ReadLine();




            Console.WriteLine("Ürün adetini giriniz");
            int adet = Convert.ToInt32(Console.ReadLine());

            int ödeme = 0;

            while (adet>0)
            {
                Console.WriteLine("ürün fiyatını giriniz");
                int fiyat = Convert.ToInt32(Console.ReadLine());

                ödeme += fiyat;
                adet--;


            }
            Console.WriteLine("toplam   " + ödeme);

            Console.ReadLine();


























            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //while (sayi1<sayi2)
            //{
            //    Console.WriteLine(sayi1);
            //    sayi1++;

            //}
            //while (sayi2 < sayi1)
            //{
            //    Console.WriteLine(sayi2);
            //    sayi2++;

            //}
            //Console.ReadLine();




        }
    }
}

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
            //int indx = 0;
            //int[] sayilar = { 11, 22, 33, 44, 55, 66, 55, 77, 88, 55, 9 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    if (indx>=0)
            //    {
            //        indx = Array.IndexOf(sayilar, 55, indx+1 );
            //        if (indx==-1)
            //        {
            //            break;
            //        }

            //        Console.WriteLine(indx);

            //    }




            //Console.WriteLine("kayıt olacak personel sayısını giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string[] isimler = new string[sayi];
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("Name:");
            //    string ad = Console.ReadLine();
            //    isimler[i] = ad;

            //}
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            //int index = 0;
            //string[] isimler = new string[sayi];
            //while (index<sayi)
            //{
            //    Console.WriteLine("Name:");
            //        string ad = Console.ReadLine();
            //        isimler[index] = ad;
            //    index++;
            //}


            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}



         
            int toplamt = 0;
            int toplamc = 0;
            int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            

            for (int i = 0; i < sayılar.Length; i++)
            {
                if (sayılar[i]%2==0)
                {
                    toplamc += sayılar[i];


                }
                else
                {
                    toplamt += sayılar[i];
                }
               
                
            }
            Console.WriteLine("toplam çift= " + toplamc);
            Console.WriteLine("toplam tek= " + toplamt);
            Console.ReadLine();













































































        }
    }
}

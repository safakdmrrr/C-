using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \n\n **BUGÜN KENDİNİ MUTLU ET**");
            string[] urunler = {"KOLA","BİSKÜVİ","ÇİKOLATA"};
            int[] fiyat = {7,3,2};
            int[] adet = { 4, 5, 6 };

              
            
            Console.WriteLine("\n1-Admin Girişi \n2-Misafir Girişi ");
            int secim = Convert.ToInt32(Console.ReadLine());


            switch (secim)
            {

                case 1:


                    while (true)
                    {
                        string usurname = "admin";
                        string password = "123";
                        Console.WriteLine("Kullanıcı adınızı giriniz:");
                        string ad = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Şifrenizi giriniz:");
                        string sifre = Convert.ToString(Console.ReadLine());


                        if (usurname == ad && password == sifre)
                        {
                            Console.WriteLine("****Ürüenler****\n");
                            for (int i = 0; i < urunler.Length; i++)
                            {

                                Console.WriteLine((i + 1) + ".Ürün " + urunler[i] + " Fiyat== " + fiyat[i] + " TL =>" + "Ürün Adedi:" + adet[i]);

                            }

                            Console.WriteLine("\n\nEklemek İstediğiniz Ürünü YAzınız:");
                            string eklenecekurun = Console.ReadLine().ToUpper();

                            
                   
                            for(int i=0;i<urunler.Length;i++)
                            {
                                int toplamyeniadet = 0;
                                if (urunler[i] == eklenecekurun)
                                {
                                    Console.WriteLine("\nLütfen Eklemek İstediğiniz Ürün Adedini Yazınız:");
                                    int ekadet = Convert.ToInt32(Console.ReadLine());
                                    toplamyeniadet = ekadet + adet[i];

                                    Console.WriteLine(urunler[i] + " Ürününün Yeni Adet Miktarı: " + toplamyeniadet);
                                }
                               
                            }
                            Console.WriteLine("Ürün Başarıyla Yüklendi.");
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Tekrar Deneyin:");
                        }
                    }


                    break;




                case 2:


                    while (true)
                    {

                        Console.WriteLine("Kayıt için 11 Haneli Telfon Numaranızı Giriniz :");
                    string telno = Convert.ToString(Console.ReadLine());

                    if (telno.Length == 11)

                    {
                            Console.WriteLine("Kayıt Başarılı.. Ürünler için Lütfen Bekleyiniz..");
                            Thread.Sleep(3000);
                            

                            for (int j = 0; j < urunler.Length; j++)
                            {
                               
                                    Console.WriteLine("\n****Ürünler****\n");
                                    for (int i = 0; i < urunler.Length; i++)
                                    {

                                        Console.WriteLine((i + 1) + ".Ürün " + urunler[i] + " Fiyat== " + fiyat[i] + " TL =>" + "Ürün Adedi:" + adet[i]);

                                    }

                                Console.WriteLine("\n\nSeçmek İstediğiniz Ürün Adını Yazınız.");
                                string usecim = Console.ReadLine().ToUpper();

                                for (int i = 0; i < urunler.Length; i++)
                                {
                                    double paraustu = 0;
                                    if (urunler[i]==usecim)
                                    {
                                         Console.WriteLine("lütfen Para Yatırınız");
                                        int yatanpara = Convert.ToInt32(Console.ReadLine());

                                        if (yatanpara >= fiyat[i])
                                        {
                                            paraustu = yatanpara - fiyat[i];
                                            Console.WriteLine("KALAN PARA ÜSTÜ: " + paraustu +"TL \n\n Afiyet Olsun:)");
                                            Console.WriteLine("\n\nÜrünlere Yönlendirliyorsunuz..");

                                            Thread.Sleep(3000);
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Üzgnüm Paran Yetmedi :(( \n\nÜrünlere Yönlendiriliyorsunuz..");
                                            Thread.Sleep(3000);
                                        }
                                      
                                        
                                    }
                                }

                            }
                        }

                        else
                        {
                            Console.WriteLine("Telefon Numarası Hatalı.");
                        }
                    }

                    break;

            }
          
            Console.ReadLine();
        }
    }
}

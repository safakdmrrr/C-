using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList toptancıMeyve = new ArrayList() { "elma", "kiraz", "muz", "armut" };
            ArrayList toptancıSebze = new ArrayList() { "lahana", "havuç", "patates" };
            ArrayList manavMeyveKg = new ArrayList();
            ArrayList manavSebzeKg = new ArrayList();
            ArrayList manavM = new ArrayList();
            ArrayList manavS = new ArrayList();
            ArrayList musterı = new ArrayList();
            while (true)
            {
                Console.WriteLine("HALE HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.");
                string secim = Console.ReadLine().ToUpper();
                if (secim == "M")
                {
                    foreach (var item in toptancıMeyve)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Almak istediğiniz ürünü yazınız!!! ");
                    string ürün = Console.ReadLine();
                    manavM.Add(ürün);
                    Console.WriteLine("Kaç kilo?");
                    int meyvekg = Convert.ToInt32(Console.ReadLine());

                    manavMeyveKg.Add(meyvekg);

                    Console.WriteLine("Başka bir arzunu var mı? Evet E veya Hayır H");
                    string secimm = Console.ReadLine().ToUpper();
                    if (secimm == "H")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (secim == "S")
                {
                    foreach (var item in toptancıSebze)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Almak istediğiniz ürünü yazınız!!! ");
                    string ürün = Console.ReadLine();
                    manavM.Add(ürün);
                    Console.WriteLine("Kaç kilo?");
                    int sebzekg = Convert.ToInt32(Console.ReadLine());

                    manavSebzeKg.Add(sebzekg);

                    Console.WriteLine("Başka bir arzunu var mı? Evet E veya Hayır H");
                    string secimm = Console.ReadLine().ToUpper();
                    if (secimm == "H")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
               

            }
            Console.WriteLine("MANAVA HOŞGELDİNİZ Meyve için M Sebze için S ye basınız.");
            string secimmm = Console.ReadLine().ToUpper();



            if (secimmm=="M")
            {
                foreach (var item in manavM)
                {
                    Console.WriteLine(item);
                }
                while (true)
                {
                    Console.WriteLine("ürün giriniz");
                    string ürün = Console.ReadLine().ToUpper();

                    Console.WriteLine("Kaç kilo?");
                    int meyvekg = Convert.ToInt32(Console.ReadLine());
                    if ((int)manavMeyveKg[manavM.IndexOf(ürün)] < meyvekg)
                    {
                        Console.WriteLine("yeterli ürün yok");
                        
                    }
                    else
                    {
                        musterı.Add(ürün);
                        break;
                    }
                    Console.WriteLine("başka arzunuz varmı Evet E veya Hayır H");
                    string secimm = Console.ReadLine().ToUpper();
                    if (secimm == "H")
                    {
                        foreach (var item in musterı)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        continue;
                    }


                }

               
              

            }
            else if (secimmm == "S")
            {
                foreach (var item in manavS)
                {
                    Console.WriteLine(item);
                }
                while (true)
                {
                    Console.WriteLine("ürün giriniz");
                    string ürün = Console.ReadLine().ToUpper();

                    Console.WriteLine("Kaç kilo?");
                    int sebzekg = Convert.ToInt32(Console.ReadLine());
                    if ((int)manavSebzeKg[manavS.IndexOf(ürün)] <= sebzekg)
                    {
                        Console.WriteLine("yeterli ürün yok");
                        
                    }
                    else
                    {
                        musterı.Add(ürün);
                        break;
                    }
                    Console.WriteLine("başka arzunuz varmı Evet E veya Hayır H");
                    string secimm = Console.ReadLine().ToUpper();
                    if (secimm == "H")
                    {
                        foreach (var item in musterı)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        continue;
                    }

                }//karşılaştırmaı düzgün yapamadım indexof  da sıkıntılar yaşadım yenisini yapıcağım
               

            }






            Console.ReadLine();

        }
    }
}

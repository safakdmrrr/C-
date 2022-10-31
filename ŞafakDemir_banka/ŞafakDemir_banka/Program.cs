using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ŞafakDemir_banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double telefon = 05456930944;
            double kimlik = 12345678910;
            int para = 250;
            string sifre = "ab18";
            int hak = 3;
            int hak2 = 3;
        a1:
            Console.WriteLine("kartlı işlem için 1\nkartsız işlemler için 2");
            int giris = Convert.ToInt32(Console.ReadLine());
            if (giris == 1)
            {
                while (hak > 0)
                {
                    Console.WriteLine("Şifreyi giriniz");
                    string sifre2 = Console.ReadLine();
                    if (sifre == sifre2)
                    {
                    a2:
                        Console.WriteLine("*******ana menü*****\npara çekmek için 1\npara yatırmak için 2\npara transferleri 3\neğitim ödemeleri 4\nödemeler 5\nbilgi güncelleme 6\n");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("Çekilecek tutarı giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (tutar < para)
                            {
                                para = para - tutar;
                                Console.WriteLine(tutar + "  Tutar çekildi" + "\nkalan tutar  " + para + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim2 = Convert.ToInt32(Console.ReadLine());
                                if (secim2 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim2 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }
                            }
                            else if (para < tutar)
                            {
                                Console.WriteLine("yetersiz bakiye " + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim2 = Convert.ToInt32(Console.ReadLine());
                                if (secim2 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim2 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }
                            }

                        }
                        if (secim == 2)
                        {
                            Console.WriteLine("kredi kartına 1\nkendi hesabınıza yatırmak için 2\nAna menü 9\nÇıkmak için 0");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                            Tekrar:
                                Console.WriteLine("Kredi kardı için en az 12 haneli kart numarasını giriniz");
                                string kart = Console.ReadLine();
                                // kart.Substring(12);//Burda 12 hane sınırını verdim ama 12 haneden az verince program çöküyor tabiki başa döndürmek için try catch denedim yapmadım.
                                if (kart.Length == 12)
                                {
                                    Console.WriteLine("yatırılacak tutarı giriniz");
                                    int tutar = Convert.ToInt32(Console.ReadLine());
                                    if (para > tutar || tutar > para)
                                    {
                                        Console.WriteLine(tutar + "TL kredi kartınıza yatırıldı\nkalan tutar:" + (para + tutar) + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                        int secim3 = Convert.ToInt32(Console.ReadLine());
                                        if (secim3 == 9)
                                        {
                                            goto a2;
                                        }
                                        else if (secim3 == 0)
                                        {
                                            Console.WriteLine("Çıkış yapıldı");
                                            goto a1;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kart numarası tekrar deneyin");
                                    goto Tekrar;
                                }




                            }
                            else if (secim2 == 2)
                            {
                                Console.WriteLine("yatırılacak tutarı giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(tutar + "TL yatırıldı\ntoplam tutar:" + (tutar + para) + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());
                                para = tutar + para;
                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }
                            }
                        }
                        if (secim == 3)
                        {
                            Console.WriteLine("Başka hesaba EFT 1\nBaşka hesaba havale 2 ");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                            don:
                                Console.WriteLine("EFT numaranızı giriniz");
                                string eft = Console.ReadLine();
                                bool b = eft.StartsWith("TR");

                                //     bool a = Convert.ToBoolean (eft.Substring(14));  çalışmadı
                                if (b == true && eft.Length == 14)
                                {
                                    Console.WriteLine("Yatırılacak tutatı giriniz");
                                    int tutar = Convert.ToInt32(Console.ReadLine());


                                    Console.WriteLine(tutar + "TL başarıyla yatırıldı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }



                                }
                                else
                                {
                                    Console.WriteLine("Hatalı eft numarası.örnk(TR123456789012)");
                                    goto don;
                                }

                            }
                            else if (secim2 == 2)
                            {
                            don:
                                Console.WriteLine("Lütfen 11 haneli hesap numarasını giriniz");
                                string numara = Console.ReadLine();
                                if (numara.Length == 11)
                                {
                                    Console.WriteLine("yatırmak istediğiniz tutar");
                                    int tutar = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine(tutar + "TL " + numara + " numaralı hesaba yatırıldı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı hesap numarası");
                                    goto don;
                                }


                                // bool b =Convert.ToBoolean (numara.Substring(11));  hata alıyourum
                                /*   if (b==true)
                                   {
                                       Console.WriteLine("a");
                                   }
                                   else
                                   {
                                       Console.WriteLine("aaa");
                                   }*/

                            }
                        }
                        if (secim == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri sayfası arızalı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                            int secim3 = Convert.ToInt32(Console.ReadLine());

                            if (secim3 == 9)
                            {
                                goto a2;
                            }
                            else if (secim3 == 0)
                            {
                                Console.WriteLine("Çıkış yapıldı");
                                goto a1;
                            }
                        }
                        if (secim == 5)
                        {
                            Console.WriteLine("Elektrik faturası 1\nTelefon faturası 2\nİnternet faturası 3\nSu faturası 4\nOGS ödemeleri 5");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                                Console.WriteLine("Fatura tutarını giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                if (para >= tutar)
                                {
                                    para = para - tutar;
                                    Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;

                                    }
                                }

                            }
                            if (secim2 == 2)
                            {
                                Console.WriteLine("Fatura tutarını giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                if (para >= tutar)
                                {
                                    para = para - tutar;
                                    Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;

                                    }
                                }

                            }
                            if (secim2 == 3)
                            {
                                Console.WriteLine("Fatura tutarını giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                if (para >= tutar)
                                {
                                    para = para - tutar;
                                    Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;

                                    }
                                }

                            }
                            if (secim2 == 4)
                            {
                                Console.WriteLine("Fatura tutarını giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                if (para >= tutar)
                                {
                                    para = para - tutar;
                                    Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;

                                    }
                                }

                            }
                            if (secim2 == 5)
                            {
                                Console.WriteLine("Fatura tutarını giriniz");
                                int tutar = Convert.ToInt32(Console.ReadLine());
                                if (para >= tutar)
                                {
                                    para = para - tutar;
                                    Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }
                                }

                            }

                        }
                        if (secim == 6)
                        {
                            Console.WriteLine("Şifreyi değiştirmek için 1");
                            int secim2 = Convert.ToInt32(Console.ReadLine());

                            if (secim2 == 1)
                            {
                                Console.WriteLine("Yeni şifreyi yazınız");
                                string yenı = Console.ReadLine();

                                Console.WriteLine("Şifre değiştirildi");
                                sifre = yenı;
                                Console.WriteLine("\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }


                            }

                        }







                        break;

                    }

                    else
                    {
                        Console.WriteLine("hatalı şifre tekrar deneyin");
                    }
                    hak--;
                    if (hak == 0)
                    {
                        Console.WriteLine("3 hatalı giriş sistem bloke edildi");
                    }
                }
            }
            if (giris == 2)
            {
            a2:

                Console.WriteLine("CepBank para çekmek için 1\nPara yatırmak için 2\nKredi kartı ödeme 3\nEğitim ödemeleri 4\nÖdemeler 5");
                int secim = Convert.ToInt32(Console.ReadLine());
                while (hak2 > 0)
                {
                    if (secim == 1)
                    {
                        Console.WriteLine("Tc kimlik numaranızı giriniz");
                        double kimlik2 = Convert.ToInt64(Console.ReadLine());
                        if (kimlik == kimlik2)
                        {
                            while (hak2 > 0)
                            {
                                Console.WriteLine("Telefon numaranızı giriniz");
                                double telefon2 = Convert.ToInt64(Console.ReadLine());
                                if (telefon == telefon2)
                                {
                                    para = para + 1000;
                                    Console.WriteLine("1000TL ödeme yapıldı\nYeni bakiye: " + para + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı telefon numarası");

                                }
                                hak2--;
                                if (hak2 == 0)
                                {
                                    Console.WriteLine("3 hatalı giriş sistem bloke edildi");
                                }

                            }


                        }
                        else
                        {
                            Console.WriteLine("Hatalı tc kimlik numarası");

                        }
                        hak2--;
                        if (hak2 == 0)
                        {
                            Console.WriteLine("3 hatalı giriş sistem bloke edildi");
                        }

                    }
                    if (secim == 2)
                    {
                        Console.WriteLine("Nakit ödeme 1\nHesaptan ödeme 2\nAna menü 9\nÇıkış 0");
                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 == 1)
                        {
                        a8:
                            Console.WriteLine("12 haneli kredi kart numaranızı giriniz");
                            string kart = Console.ReadLine();
                            if (kart.Length == 12)
                            {
                            a7:
                                Console.WriteLine("Tc kimlik numaranızı giriniz");
                                string kimlik2 = Console.ReadLine();
                                if (kimlik2.Length == 11)
                                {
                                    Console.WriteLine("Nakit ödeme başaralı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                    int secim3 = Convert.ToInt32(Console.ReadLine());

                                    if (secim3 == 9)
                                    {
                                        goto a2;
                                    }
                                    else if (secim3 == 0)
                                    {
                                        Console.WriteLine("Çıkış yapıldı");
                                        goto a1;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı kimlik numarası");
                                    goto a7;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Hatalı kredi kart numarası tekrar deneyin");
                                goto a8;
                            }

                        }


                    }
                    if (secim == 3)
                    {
                        Console.WriteLine("kredi kartı Ödemeleri sayfası arızalı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                        int secim3 = Convert.ToInt32(Console.ReadLine());

                        if (secim3 == 9)
                        {
                            goto a2;
                        }
                        else if (secim3 == 0)
                        {
                            Console.WriteLine("Çıkış yapıldı");
                            goto a1;
                        }



                    }
                    if (secim == 4)
                    {
                        Console.WriteLine("Eğitim Ödemeleri sayfası arızalı" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                        int secim3 = Convert.ToInt32(Console.ReadLine());

                        if (secim3 == 9)
                        {
                            goto a2;
                        }
                        else if (secim3 == 0)
                        {
                            Console.WriteLine("Çıkış yapıldı");
                            goto a1;
                        }
                    }
                    if (secim == 5)
                    {
                        Console.WriteLine("Elektrik faturası 1\nTelefon faturası 2\nİnternet faturası 3\nSu faturası 4\nOGS ödemeleri 5");
                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 == 1)
                        {
                            Console.WriteLine("Fatura tutarını giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (para >= tutar)
                            {
                                para = para - tutar;
                                Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;

                                }
                            }

                        }
                        if (secim2 == 2)
                        {
                            Console.WriteLine("Fatura tutarını giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (para >= tutar)
                            {
                                para = para - tutar;
                                Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;

                                }
                            }

                        }
                        if (secim2 == 3)
                        {
                            Console.WriteLine("Fatura tutarını giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (para >= tutar)
                            {
                                para = para - tutar;
                                Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;

                                }
                            }

                        }
                        if (secim2 == 4)
                        {
                            Console.WriteLine("Fatura tutarını giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (para >= tutar)
                            {
                                para = para - tutar;
                                Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;

                                }
                            }

                        }
                        if (secim2 == 5)
                        {
                            Console.WriteLine("Fatura tutarını giriniz");
                            int tutar = Convert.ToInt32(Console.ReadLine());
                            if (para >= tutar)
                            {
                                para = para - tutar;
                                Console.WriteLine("Fatura başarıyla ödendi\nKalan paranız: " + para + "\n*******************" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz bakiye" + "\nAna menüye dönmek için 9\nÇıkmak için 0");
                                int secim3 = Convert.ToInt32(Console.ReadLine());

                                if (secim3 == 9)
                                {
                                    goto a2;
                                }
                                else if (secim3 == 0)
                                {
                                    Console.WriteLine("Çıkış yapıldı");
                                    goto a1;
                                }
                            }

                        }

                    }


                }
                



            }
            Console.ReadLine();




        }



        


    }





}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            int enb = 0;
            int enk = 0;
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Değer giriniz");
                int değer = Convert.ToInt32(Console.ReadLine());
                if (değer == 0)
                {
                    liste.Sort();
                    foreach (int item in liste)
                    {
                        Console.WriteLine(item);
                        if(enk>item)
                        {
                            enk = item;
                           
                        }
                        else if(enb<item)
                        {
                            enb = item;
                            
                        }

                    }
                    Console.WriteLine("En küçük sayı"+enk);
                    Console.WriteLine("En büyük sayı"+enb);
                    Console.WriteLine("ortalama"+değer/liste.Count);
                    


                    break;
                }
                else
                {
                    liste.Add(değer);
                    toplam +=değer;
                }

            }

            Console.ReadLine();
        }
    }
}

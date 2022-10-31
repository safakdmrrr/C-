using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Not giriniz");
            int not1 = Convert.ToInt32(Console.ReadLine());
            switch (not1)
            {
                case 1:
                    Console.WriteLine("zayıf");
                    


                    break;

                case 2:
                    Console.WriteLine("geçer");
                  
                    break;
                case 3:
                    Console.WriteLine("orta");
                   
                    break;
                case 4:
                    Console.WriteLine("iyi");
                   
                    break;
                case 5:
                    Console.WriteLine("Pekiyi");

                    break;

                default:
                    Console.WriteLine(" lütfen 1-5 arasında sayı giriniz");
                    break;
                    

            }
            Console.ReadLine();
        }
    }
}

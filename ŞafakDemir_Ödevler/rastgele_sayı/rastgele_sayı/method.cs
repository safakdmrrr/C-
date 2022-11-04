using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace rastgele_sayı
{
    internal class method
    {

        public static void sayıUret(int s1, int s2)
        {
            int[] dizi = new int[10];
            Random r = new Random();
            int rast = r.Next(s1, s2);
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(s1, s2);

            }
            Console.WriteLine("yeni dizi:");
            Array.Sort(dizi);
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine("***" + item);

            }
            enbuyuk();
            enkucuk();

          
            void enbuyuk()
            {
                Console.WriteLine("en büyük"+dizi[0]);
            }
            void enkucuk()
            {
                Console.WriteLine("en KÜÇÜK" + dizi[9]);
            }
            Console.ReadLine();
        }
       
        

        


    }
}

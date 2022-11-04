using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10;)
            {
                i++;
                Console.WriteLine(i+ " ile çarpım tablosu*******");
                for (int j = 0; j <11; )
                {
                 
                    Console.WriteLine(i+"*"+j+"="+(i*j));
                    
                    j++;
                }

               
            }
            Console.ReadLine();
        }
    }
}

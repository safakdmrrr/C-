using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tekcıft
    {
        public static bool kontrol(int s1)
        {

            if (s1%2==0)
            {
                Console.WriteLine("sayı çift");
                return true;
            }
            else
            {
                Console.WriteLine("sayı tek");
                return false;
            }


        }
    }
}

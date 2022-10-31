using System;
using System.Collections;
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

            ArrayList array = new ArrayList() { 10, 11, 12, 13, 14 };
            ArrayList arrayy = new ArrayList();
            foreach (int item in array)
            {
                arrayy.Add(item + 10);
                
            }
            foreach (int item in arrayy)
            {
                Console.WriteLine(item);

            }

            Console.ReadLine();
        }
    }
}

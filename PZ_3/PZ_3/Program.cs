using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class Program
    {
        /*Fibonaccijev niz definiran je na sljedeći način: 
• prvi član niza je 0 
• drugi član niza je 1 
• svaki sljedeći član niza jednak je zbroju prethodna dva člana 
Napišite program koji će zatražiti od korisnika da unese broj n, te će izračunati n-ti član 
Fibonaccijevog niza.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi neki broj: ");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int prvi=0, drugi=1;
            int zbroj = drugi + prvi;
            for (int i = 0; i < b; i++)
            {
                drugi = drugi + zbroj;
            }
            Console.WriteLine(drugi);
            Console.ReadKey();
        }
    }
}

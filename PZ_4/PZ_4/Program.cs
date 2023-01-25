using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_4
{
    internal class Program
    {
        /*Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.*/
        static void Main(string[] args)
        {
            string a[4]={ 2, 4.5, 7.6, 8 };
            double b = Convert.ToDouble(a);
            double zbroj = 0, counter = 0, arit=0;
            for(int i=0; i <= 4; i++) { 
                counter++;
                zbroj = zbroj + i;
            }
            arit = zbroj / counter;
            double priv =0;
            for (int j = 0; j <= 4; j++) {
                if (a[j] == arit)
                {
                    Console.WriteLine(j);
                }
                for (int k = 0; k <= 4*2; k++)
                {
                    if(a[k] < arit)
                    {
                        a[k] = priv;
                        a[k + 1] = a[k];
                        priv = a[k + 1];
                    }
                }
            
                Console.WriteLine("Broj najbliži aritmetickoj sredini je: " + a[3]);
        }
    }
}

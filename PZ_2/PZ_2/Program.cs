using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2
{
    internal class Program
    {
        /*Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po 
abecedi u uzlaznom redoslijedu.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dva stringa: ");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string abc ="abcdefghijklmnopqrstuvwxyz";
            string priv = "";
            for(int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if(x[j] == abc[i])
                    {
                        x[j] = priv;
                        x[j + 1] = x[j];
                        priv = x[j + 1];

                    }
                }
            }
            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (y[j] == abc[i])
                    {
                        y[j] = priv;
                        y[j + 1] = y[j];
                        priv = y[j + 1];

                    }
                }
            }

            for(int i = abc.Length; i < abc.Length; i--)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine();
            for (int i = abc.Length; i < abc.Length; i--)
            {
                Console.WriteLine(y[i]);
            }
        }
    }
}

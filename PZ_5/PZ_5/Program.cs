using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_5
{
    internal class Program
    {
        /*Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
• varijable tipa double
BrzinaOkoOsi 
BrzinaOkoSunca 
Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
konstruktore:
Planet(double, double) 
Satelit(double, double) 
koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.*/
        class NebeskoTijelo
        {
            double BrzinaOkoOsi, BrzinaOkoSunca;
            public NebeskoTijelo(double BrzinaOkoOsi, double BrzinaOkoSunca)
            {
                this.BrzinaOkoOsi = BrzinaOkoOsi;
                this.BrzinaOkoSunca = BrzinaOkoSunca; 
            }
            public double BrzinaOkoOsi1 { get => BrzinaOkoOsi2; set => BrzinaOkoOsi2 = value; }
            public double BrzinaOkoOsi2 { get => BrzinaOkoOsi; set => BrzinaOkoOsi = value; }
        }
        class Planet : NebeskoTijelo
        {

            public Planet(double BrzinaOkoOsi, double BrzinaOkoSunca)
            { 
            }
            public string ispis = (BrzinaOkoOsi, BrzinaOkoSunca);
            return ispis;
        }
        class Satelit : NebeskoTijelo
        {
            public Planet(double BrzinaOkoOsi, double BrzinaOkoSunca)
            {
            }
            public string ispis = (BrzinaOkoOsi, BrzinaOkoSunca);
            return ispis;
        }
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(300.0, 3.5);
            Satelit Mjesec = new Satelit(2.4, 3.5);
            Console.WriteLine(Zemlja.BrzinaOkoOsi1 + Zemlja.BrzinaOkoSunca + Mjesec.BrzinaOkoOsi1 + Mjesec.BrzinaOkoSunca);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squadre
{
    class Squadra
    {
        string nomeSq;
        int partiteVinte, partitePerse, partitePareggiate, golFatti, golSubiti, punti;
        public Squadra(string nome, int gFatti, int gSub, int pVinte, int pPerse, int pPar)
        {
            this.nomeSq = nome;
            this.golFatti = gFatti;
            this.golSubiti = gSub;
            this.partiteVinte = pVinte;
            this.partitePerse = pPerse;
            this.partitePareggiate = pPar;
            punti = 0;
        }

        public string Punti()
        {
            punti = (this.partiteVinte * 3) + partitePareggiate;
            return $"La squadra {this.nomeSq} ha {this.punti} punti";
        }

        public void InizioAnno()
        {
            this.golFatti = 0;
            this.golSubiti = 0;
            this.partiteVinte = 0;
            this.partitePerse = 0;
            this.partitePareggiate = 0;
            punti = 0;
        }

        public void GolFatto(int gol)
        {
            this.golFatti += gol;
        }

        public void GolSubito(int gol)
        {
            this.golSubiti += gol;
        }

        static void Main(string[] args)
        {
            int gFattiM, gSubM, pVinteM, pPerseM, pParM;
            bool controllo;
            Ripeti:
            do
            {
                Console.WriteLine("Inserisci i gol fatti dal Milan");
                string g = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(g, out gFattiM);// True = int, False = non int
            } while (!controllo || gFattiM < 0); // Viene chiesto di inserire i gol fatti dalla squadra finchè l'utente non inserisce un numero naturale

            do
            {
                Console.WriteLine("Inserisci i gol subiti dal Milan");
                string g = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(g, out gSubM); // True = int, False = non int
            } while (!controllo || gSubM < 0); // Viene chiesto di inserire i gol subiti dalla squadra finchè l'utente non inserisce un numero naturale

            do
            {
                Console.WriteLine("Inserisci le partite vinte del Milan");
                string g = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(g, out pVinteM); // True = int, False = non int
            } while (!controllo || pVinteM < 0); // Viene chiesto di inserire le partite vinte dalla squadra finchè l'utente non inserisce un numero naturale

            do
            {
                Console.WriteLine("Inserisci le partite perse dal Milan");
                string g = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(g, out pPerseM);
            } while (!controllo || pPerseM < 0);

            do
            {
                Console.WriteLine("Inserisci le partite pareggiate dal Milan");
                string g = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(g, out pParM);
            } while (!controllo || pParM < 0);

            Squadra milan = new Squadra("Milan", gFattiM, gSubM, pVinteM, pPerseM, pParM);
            Squadra juve = new Squadra("Juventus", 1, 2, 3, 4, 5);
            juve.Punti();
            milan.Punti();

            if ((milan.punti == juve.punti && milan.golFatti != juve.golFatti) || (milan.punti > juve.punti && milan.golFatti < juve.golFatti) || (milan.punti < juve.punti && milan.golFatti > juve.golFatti))
            {
                Console.WriteLine("Errore tra i punti e i gol");
                Console.WriteLine("Per favore reinserire i valori\n");
                 goto Ripeti;
            }
            Console.Clear();
            Console.WriteLine($"{milan.Punti()}\n{juve.Punti()}\n");

            if (milan.punti > juve.punti)
            {
                Console.WriteLine("Milan Vincitore\n");
            }
            else if (milan.punti < juve.punti)
            {
                Console.WriteLine("Juventus Vincitore\n");
            }
            else
            {
                Console.WriteLine("Pareggio\n");
            }

            Console.ReadKey();

        }
    }
}

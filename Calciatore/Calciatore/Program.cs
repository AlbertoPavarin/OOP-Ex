using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calciatore
{
    class Calciatore
    {
        bool gols;
        // attributi
        string nome, squadra, ruolo;
        int golSegnati;

        // Metodi
        // Costruttore
        public Calciatore()
        {
            golSegnati = 0;
        }

        public void visualizzaGol()
        {
            Console.WriteLine($"\n\nI gol segnati da {nome} ({ruolo}) della squadra {squadra} sono: {golSegnati}");
        }

        public void setGol()
        {
            int gol;
            Console.WriteLine($"\nNecessario aggiornare i gol del giocatore {nome}? S/N");
            string risposta = Convert.ToString(Console.ReadLine());
            if (risposta == "S" || risposta == "si" || risposta == "SI")
            {
                do
                {
                    Console.WriteLine("\nQuanti sono i gol da aggiungere?");
                    string g = Convert.ToString(Console.ReadLine());
                    gols = int.TryParse(g, out gol);
                } while (!gols);
                golSegnati += gol;
            }

        }

        public void letturaDati()
        {
            Console.WriteLine("Inserire il nome del calciatore");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nInserire la squadra");
            squadra = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nInserire il ruolo del giocatore");
            ruolo = Convert.ToString(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Calciatore calcitore = new Calciatore();
            calcitore.letturaDati();
            calcitore.setGol();
            calcitore.visualizzaGol();

            Console.ReadKey();
        }
    }
}

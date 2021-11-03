using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dopo aver acquisito da tastiera una serie di prezzi relativi ai cellulari in vendita in un negozio,
//scrivere il codice di un programma(OOP) in C# che visualizzi i prezzi maggiori di 100€.

namespace Cellulari
{
    class Cellulari
    {

        //attributi
        double[] prezziCell;
    
        //Costruttore
        public Cellulari(double [] prezzi)
        {
            prezziCell = prezzi;
        }

        // Metodi

        public string toString(int i)
        {
            return $"{prezziCell[i]}";
        }

        static void Main(string[] args)
        {
            bool nVal;
            int nCell;
            do
            {
                Console.WriteLine("\nQuanti cellulari sono stati acquistati?");
                string nc = Convert.ToString(Console.ReadLine());
                nVal = int.TryParse(nc, out nCell);
            } while (!nVal || nCell < 0); // Viene controllato se il numero di prezzi da inserire è un numero naturale oppure no, nel caso non lo sia viene richiesto di inserire il numero

            double [] prezzi = new double[nCell];

            for (int i = 0; i < prezzi.Length; i++)
            {
                do
                {
                    Console.WriteLine($"\nInserisci il prezzo del telefono {i + 1}");
                    string prezzo = Convert.ToString(Console.ReadLine());
                    nVal = double.TryParse(prezzo, out prezzi[i]);
                } while (!nVal || prezzi[i] <= 0); // Viene controllato se il prezzo inserito è un numero maggiore di 0, se non lo è viene richiseto
            }
            Cellulari cell = new Cellulari(prezzi);
            Console.WriteLine("I prezzi maggiori di 100$:");
            for (int i = 0; i < prezzi.Length; i++)
            {
                if (prezzi[i] > 100)
                {
                    Console.WriteLine($"{cell.toString(i)}$");
                }
                else
                {
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}

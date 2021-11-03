using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tramite la programmazione ad oggetti scrivere un programma in c# Che dopo aver letto in input il raggio
// di una circonferenza, calcoli e visualizzi in output la misura del diametro (2*r), della circonferenza (2*r*pi)
// e la sua area (r**2*pi). (Utilizzare la funzione Math.PI).

namespace Circonferenza
{
    class Circonfearenza
    {
        bool raggioValido;

        // Attributi
        double raggio;

        // Costruttore
        public Circonfearenza()
        {
            raggio = 0;
        }

        // Metodi
        public void letturaRaggio()
        {
            do
            {
                Console.WriteLine("\nInserisci la lunghezza del raggio in cm");
                string rg = Convert.ToString(Console.ReadLine());
                raggioValido = double.TryParse(rg, out raggio);
            } while (!raggioValido || raggio <= 0); // Viene controllato se il raggio inserito è un numero maggiore di 0
        }

        public double calcoloDiamentro()
        {
            return 2 * raggio;// Viene calcolato il diametro tramite la formula 2*r
        }

        public double calcoloCirconferenza()
        {
            return 2 * raggio * Math.PI; // Viene calcolata la circonferenza tramite la formul 2 * r * pi
        }

        public double calcoloArea()
        {
            return Math.Pow(raggio, 2) * Math.PI; // Viene calcolata l'area tramite la formula 2 ** r * pi
        }

        public void VisualizzaCalcoli()
        {
            double diametro = calcoloDiamentro();
            double circonferenza = calcoloCirconferenza();
            double area = calcoloArea();
            Console.WriteLine($"\nIl diametro misura {diametro} cm, la circonferenza misura {circonferenza}" +
                $" cm, l'area misura {area} cm^2"); // Vengono visualizzati i dati a schermo
        }
        static void Main(string[] args)
        {
            Circonfearenza circonferenza = new Circonfearenza();

            // Richiamo dei metodi
            circonferenza.letturaRaggio();
            circonferenza.calcoloArea();
            circonferenza.calcoloCirconferenza();
            circonferenza.calcoloDiamentro();
            circonferenza.VisualizzaCalcoli();
           
            Console.ReadKey();
        }
    }
}

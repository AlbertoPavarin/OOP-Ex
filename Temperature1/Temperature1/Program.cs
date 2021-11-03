using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature1
{
    class Temperatura
    {
        // attributi
        int nTemperature;
        double[] temperature;

        bool nTempVal, tempVal;

        // Costruttore
        public Temperatura()
        {
            nTemperature = 0;
            temperature = new double[0];
        }

        // Metodi
        public void lettruraTemperature()
        {
            do
            {
                Console.WriteLine("\nDigita quante temperature vuoi inserire (Gradi Celsius)");
                string temp = Convert.ToString(Console.ReadLine());
                nTempVal = int.TryParse(temp, out nTemperature);
            } while (!nTempVal || nTemperature <= 0); // Viene controllato se il numero di misurazioni è un numero naturale

            temperature = new double[nTemperature];

            for (int i = 0; i < temperature.Length; i++)
            {
                do
                {
                    Console.WriteLine($"\nInserisci la temperatura numero {i + 1}");
                    string temps = Convert.ToString(Console.ReadLine());
                    tempVal = double.TryParse(temps, out temperature[i]);
                } while (!tempVal); // Viene controllato se le temperature inserite sono numeri validi (double)
            }
        }

        public double temperaturaMin()
        {
            Array.Sort(temperature); // l'array temperature viene ordinato
            return temperature[0]; // Ritorna la temperatura nell'array che ha come indice lo 0,
                                   // così ritornando la temperatura minore
        }

        public double temperaturaMax()
        {
            Array.Sort(temperature); // l'array temperature viene ordinato
            return temperature[nTemperature - 1]; // Ritorna la temperatura nell'array che ha come indice il
                                                  // numero delle temperature totali (nTemperature) - 1, così
                                                  // ritornando la temperatura massima
        }

        public void visualizzaTemperature()
        {
            double tempMax = temperaturaMax();
            double tempMin = temperaturaMin();
            Console.WriteLine($"\nLa temperatura massima è stata {tempMax}° e quella minima {tempMin}°");
            // Vengono visualizzate  schermo le temperature massime e minime
        }
        static void Main(string[] args)
        {
            Temperatura t = new Temperatura();
            t.lettruraTemperature();
            t.temperaturaMin();
            t.temperaturaMax();
            t.visualizzaTemperature();

            Console.ReadKey();
        }
    }
}

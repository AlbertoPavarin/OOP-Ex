using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura2
{
    class Temperatura
    {
        //attributi
        double[] temperature;
        int nTemp;

        public Temperatura(int dim, double [] temps)
        {
            this.nTemp = dim;
            temperature = temps;
            Array.Sort(temperature);
        }

        public double tempMax()
        {           
            return temperature[nTemp - 1]; // Ritorna la temperatura nell'array che ha come indice il
                                           // numero delle temperature totali (nTemperature) - 1, così
                                           // ritornando la temperatura massima
        }

        public double tempMin()
        {
            return temperature[0]; // Ritorna la temperatura nell'array che ha come indice lo 0,
                                   // così ritornando la temperatura minore
        }

        public string toString()
        {
            return $"\nLa temperatura minima è {tempMin()}° e quella massima è {tempMax()}°";
        }

        static void Main(string[] args)
        {
            int nTemperatura;
            double[] temperature;
            bool valoreValido;
            do
            {
                Console.WriteLine("Inserisci quante temperature vuoi inserire");
                string nT = Convert.ToString(Console.ReadLine());
                valoreValido = int.TryParse(nT, out nTemperatura);
            } while (!valoreValido || nTemperatura < 0); // Viene controllato se il numero di misurazioni è un numero naturale

            temperature = new double[nTemperatura];

            for (int i = 0; i < temperature.Length; i++)
            {
                do
                {
                    Console.WriteLine($"\nInserisci la {i + 1} temperatura. (Gradi Celsius)");
                    string temps = Convert.ToString(Console.ReadLine());
                    valoreValido = double.TryParse(temps, out temperature[i]);
                } while (!valoreValido); // Viene controllato se le temperature inserite sono numeri validi (double)
            }

            Temperatura t = new Temperatura(nTemperatura, temperature);
            t.tempMax();
            t.tempMin();
            Console.WriteLine(t.toString());

            Console.ReadKey();
        }
    }
}

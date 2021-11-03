using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euquazione_Secondo_Grado
{
    class EqSecGrado
    {
        // attributi
        double a, b, c;

        // Costruttore 
        public EqSecGrado(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //metodi
        public double verificaEquazione()
        {
            if (a != 0 && getDelta() >= 0) // Se a è diverso da 0 e il delta è maggiore o uguale di 0
            {
                return 0; // se l'equazione è di secondo grado ed è possibile ritorna 0
            }
            if (a == 0) // Se a è uguale a 0
            {
                return 1; // Se l'equazione è di primo grado ritorna 1
            }
            if (getDelta() < 0) // Se il delta è minore di 0
            {
                return 2; // Se l'equazione è impossibile ritorna 2
            }

            return -1;
        }

        public double getDelta()
        {
            return (Math.Pow(b, 2) - 4 * a * c); // Ritorna il valore del delta
        }

        public double getSoluzione1()
        {           
            return (-b + Math.Sqrt(getDelta())) / (2 * a); // Ritorna il valore della prima soluzione
        }

        public double getSoluzione2()
        {         
            return (-b - Math.Sqrt(getDelta())) / (2 * a); // Ritorna il valore della seconda soluzione 
        }

        public string toString() // Ritorna l'equazione sotto forma di stringa
        {
            return $"{a}x^2 + ({b})x + ({c})";
        }

        static void Main(string[] args)
        {
            double a, b, c;
            bool valoreValido;
            do
            {
                Console.WriteLine("\nInserisci il valore di a");
                string a1 = Convert.ToString(Console.ReadLine());
                valoreValido = double.TryParse(a1, out a);
            } while (!valoreValido); // Controlla se il valore di a è valido

            do
            {
                Console.WriteLine("\nInserisci il valore di b");
                string b1 = Convert.ToString(Console.ReadLine());
                valoreValido = double.TryParse(b1, out b);
            } while (!valoreValido); // Controlla se il valore di b è valido

            do
            {
                Console.WriteLine("\nInserisci il valore di c");
                string c1 = Convert.ToString(Console.ReadLine());
                valoreValido = double.TryParse(c1, out c);
            } while (!valoreValido); // Controlla se il valore di c è valido

            EqSecGrado eq = new EqSecGrado(a, b, c);
            
            if (eq.verificaEquazione() == 0) // Se la verifica ritorna 0, quindi è un equazione di secondo grado risolvibile allora viene calcolato il delta e le soluzioni e vengono stampate
            {
                eq.getDelta();
                double x1 = eq.getSoluzione1();
                double x2 = eq.getSoluzione2();
                Console.WriteLine($"\nLe soluzioni dell'quazione {eq.toString()} sono:\n{x1}\n{x2}");
            }
            else if (eq.verificaEquazione() == 2) // Se la verifica ritorna 2, quindi l'equazione è impossibile viene stampato che l'equazione è impossibile
            {
                Console.WriteLine($"\nL'equazione {eq.toString()} è impossibile");
            }
            else if(eq.verificaEquazione() == 1) // Se la verifica ritorna 1, quindi l'equazione è di primo grado viene stampato che l'equazione è di primo grado
            {
                Console.WriteLine($"\nL'equazione {eq.toString()} è di primo grado");
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace Veicoli
{
    public class Veicoli
    {
        protected int codVeicolo;
        protected string tipo;
        protected string nome;
        protected string marca;
        protected double km;

        public Veicoli(int id, string tipo, string nome, string marca)
        {
            this.codVeicolo = id;
            this.tipo = tipo;
            this.nome = nome;
            this.marca = marca;
        }

        public virtual double GetCostoMezzo()
        {
            return 5000;
        }

        public virtual double GetCostoUtil()
        {
            return 0;
        }

        public static void Main(string[] args)
        {
            Auto auto = new Auto(1, "s", "s", "s", 60);
            Furgone furgone = new Furgone(2, "a", "a", "a", 100);
            Console.WriteLine($"Il prezzo dell'auto è {auto.GetCostoMezzo()} €");
            Console.WriteLine($"Il prezzo dell'utilizzo per km dell'auto è {auto.GetCostoUtil()} €");
            Console.WriteLine($"Il prezzo del furgone è {furgone.GetCostoMezzo()} €");
            Console.WriteLine($"Il prezzo dell'utilizzo per km del furgone è {furgone.GetCostoUtil()} €");
            Console.ReadKey();
        }
    }
}

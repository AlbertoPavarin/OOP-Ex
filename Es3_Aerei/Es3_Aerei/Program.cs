using System;

namespace Es3_Aerei
{
    public class Aereo
    {
        protected int km;
        protected int codaereo;
        protected string tipo;
        protected string nome;

        public Aereo(int id, string tp, string nm)
        {
            this.codaereo = id;
            this.tipo = tp;
            this.nome = nm;
        }

        public virtual double GetCostoMezzo()
        {
            return 5000000;
        }

        public virtual double GetCostoKm(int km)
        {
            return km;
        }

        public static void Main(string[] args)
        {
            Passeggeri aereoPass = new Passeggeri(1, "Passeggeri", "Fly Emirates");
            Cargo aereoCargo = new Cargo(2, "Cargo", "Raynair");
            Console.WriteLine($"L'aereo passeggeri costa {aereoPass.GetCostoMezzo()}€ e il prezzo per i km è {aereoPass.GetCostoKm(500)}€");
            Console.WriteLine($"L'aereo cargo costa {aereoCargo.GetCostoMezzo()}€ e il prezzo per i km è {aereoCargo.GetCostoKm(300)}€");          
        }
    }
}

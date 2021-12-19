using System;
namespace Veicoli
{
    public class Furgone : Veicoli
    {
        public Furgone(int id, string tipo, string nome, string marca, int km) : base(id, tipo, nome, marca)
        {
            this.km = km;
        }

        public override double GetCostoMezzo()
        {
            return base.GetCostoMezzo() * 1.40;
        }

        public override double GetCostoUtil()
        {
            return this.km * 10;
        }
    }
}

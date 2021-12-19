using System;
namespace Veicoli
{
    public class Auto : Veicoli
    {
        public Auto(int id, string tipo, string nome, string marca, int km) : base(id, tipo, nome, marca)
        {
            this.km = km;
        }

        public override double GetCostoMezzo()
        {
            return base.GetCostoMezzo() * 1.25;
        }

        public override double GetCostoUtil()
        {
            return this.km * 5;
        }
    }
}

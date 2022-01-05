using System;
namespace Es3_Aerei
{
    public class Passeggeri : Aereo
    {
        public Passeggeri(int id, string tp, string nm) : base(id, tp, nm)
        {
            this.codaereo = id;
            this.tipo = tp;
            this.nome = nm;
        }

        public override double GetCostoMezzo()
        {
            return base.GetCostoMezzo() * 1.45;
        }

        public override double GetCostoKm(int km)
        {
            return base.GetCostoKm(km) * 750;
        }
    }
}

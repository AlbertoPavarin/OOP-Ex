using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Treni
{
    class Treni
    {
        // attributi
        protected int codtreno;
        protected string tipo;
        protected string nome;
        protected double costo;

        // costruttore
        public Treni(int id, string tp, string nm)
        {
            this.codtreno = id;
            this.tipo = tp;
            this.nome = nm;
            costo = 100000;
        }

        public virtual double GetCostoMezzo() // Metodo che ritorna il costo base di un treno cioò 100000€
        {
            return costo;
        }

        public virtual double GetCostoUtil(double km) // Metodo che ritorna il numero di km 
        {
            return km;
        }

        // classe derivata Passeggeri
        class Passeggeri : Treni
        {
            // attributi
            protected int numvag;
            protected string alimentazione;

            // costruttore
            public Passeggeri(int id, string tp, string nm, int nv, string al) : base (id, tp, nm)
            {
                this.numvag = nv;
                this.alimentazione = al;
            }

            public override double GetCostoMezzo() // Per calcolare il prezzo del treno passeggeri viene richiamato il metodo GetCostoMezzo() del padre e poi viene moltiplicato per 1.25 facendolo così aumentare del 25%
            {
                return base.GetCostoMezzo() * 1.25;
            }

            public override double GetCostoUtil(double km) // Per calcolare il prezzo per l'utilizzo vengono moltiplicati i km passati per il prezzo al km del mezzo
            {
                return km * 150;
            }
        }

        class Merci : Treni
        {
            protected int numvag;
            protected string alimentazione;
            public Merci(int id, string tp, string nm, int nv, string al) : base(id, tp, nm)
            {
                this.numvag = nv;
                this.alimentazione = al;
            }

            public override double GetCostoMezzo()  // Per calcolare il prezzo del treno merci viene richiamato il metodo GetCostoMezzo() del padre e poi viene moltiplicato per 1.35 facendolo così aumentare del 35%
            {
                return base.GetCostoMezzo() * 1.35;
            }

            public override double GetCostoUtil(double km) // Per calcolare il prezzo per l'utilizzo vengono moltiplicati i km passati per il prezzo al km del mezzo
            {
                return km * 100;
            }
        }
        static void Main(string[] args)
        {
            bool controllo;
            int codMerc, codPass;
            int numVagM, numVagP;
            string tipoMerc, nomeMerc, tipoPass, nomePass;
            string alTrMer, alTrPas;
            double kmMerci, kmPass;
            double costoMerc, costoPass, costoMercUtil, costoPassUtil;
            do
            {
                Console.WriteLine("Inserisci il codice del treno merci");
                string s = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(s, out codMerc);
                Console.WriteLine();
            } while (!controllo || codMerc <= 0); // Viene controllato se il codice inserito è maggiore di 0 o se è un numero valido, se non lo è allora viene richiesto
            do
            {
                Console.WriteLine("Inserisci il tipo di treno merci (regionale, nazionale, internazionale)");
                tipoMerc = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
            } while (tipoMerc.ToUpper() != "REGIONALE" && tipoMerc.ToUpper() != "NAZIONALE" && tipoMerc.ToUpper() != "INTERNAZIONALE"); // Viene controllato se il tipo inserito coincide con i tipi di treni validi

            Console.WriteLine("Inserisci il nome del treno merci");
            nomeMerc = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            do
            {
                Console.WriteLine("Inserisci il numero di vagoni del treno merci");
                string s = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(s, out numVagM);
                Console.WriteLine();
            } while (!controllo || numVagM <= 0); // Viene controllato se il numero di vagoni è maggiore di 0 oppure se è valido, in caso contrario viene richiesto

            Console.WriteLine("Inserisci l'alimentazione del treno merci");
            alTrMer = Convert.ToString(Console.ReadLine());
            Console.WriteLine();


            Merci trMer = new Merci(codMerc, tipoMerc, nomeMerc, numVagM, alTrMer);
            do
            {
                Console.WriteLine("Inserisci il numero di km del treno merci");
                string s = Convert.ToString(Console.ReadLine());
                controllo = double.TryParse(s, out kmMerci);
                Console.WriteLine();
            } while (!controllo || kmMerci < 0); // Viene controllato se i km inseriti sono validi o maggiori di 0
            Console.Clear();
            costoMerc = trMer.GetCostoMezzo();
            costoMercUtil = trMer.GetCostoUtil(kmMerci);                    
                    


            // Per i seguenti comandi viene usata la stessa logica di quella utilizzata in quelli precedenti
            do
            {
                Console.WriteLine("Inserisci il codice del treno passeggeri");
                string s = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(s, out codPass);
                Console.WriteLine();
            } while (!controllo || codPass <= 0); 
            do
            {
                Console.WriteLine("Inserisci il tipo di treno passeggeri (regionale, nazionale, internazionale)");
                tipoPass = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
            } while (tipoPass.ToUpper() != "REGIONALE" && tipoPass.ToUpper() != "NAZIONALE" && tipoPass.ToUpper() != "INTERNAZIONALE");

            Console.WriteLine("Inserisci il nome del treno passeggeri");
            nomePass = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            do
            {
                Console.WriteLine("Inserisci il numero di vagoni del treno passeggeri");
                string s = Convert.ToString(Console.ReadLine());
                controllo = int.TryParse(s, out numVagP);
                Console.WriteLine();
            } while (!controllo || numVagP <= 0);

            Console.WriteLine("Inserisci l'alimentazione del treno passeggeri");
            alTrPas = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Passeggeri trPas = new Passeggeri(codPass, tipoPass, nomePass, numVagP, alTrPas);
            do
            {
                Console.WriteLine("Inserisci il numero di km del treno passeggeri");
                string s = Convert.ToString(Console.ReadLine());
                controllo = double.TryParse(s, out kmPass);
                Console.WriteLine();
            } while (!controllo || kmPass < 0);
            Console.Clear();

            costoPass = trPas.GetCostoMezzo();
            costoPassUtil = trPas.GetCostoUtil(kmPass);
            Console.WriteLine($"Il costo del treno merci ({codMerc}) è {costoMerc}$ mentre il costo per l'utilizzo è {costoMercUtil}$");
            Console.WriteLine($"Il costo del treno passeggeri ({codPass}) è {costoPass}$ mentre il costo per l'utilizzo è {costoPassUtil}$");
            Console.WriteLine($"Il costo totale del mezzo {costoPass + costoMerc + costoPassUtil + costoMercUtil}$");
            
            Console.ReadKey();
        }
    }
}

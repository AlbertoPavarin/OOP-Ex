using System;

namespace ContoCorrente
{
    class Program
    {
        class Conto
        {
            protected double saldo;
            public Conto()
            {
                saldo = 5000;
            }

            public string prelevazione(double soldi)
            {
                saldo -= soldi;
                return $"Il tuo saldo ora è {saldo}\n";
            }

            public string varsamento(double soldi)
            {
                saldo += soldi;
                return $"Il tuo saldo ora è {saldo}\n";
            }

            public override string ToString()
            {
                return $"Il tuo saldo attuale è:{saldo}";
            }           
        }
        class ContoModificato : Conto
        {
            public string preleva(double soldi)
            {
                if (soldi > 3000 || soldi > saldo)
                {
                    return "Errore, stai prelevando più di 3000$ o più soldi rispetto a quelli che hai";
                }
                else
                {
                    base.prelevazione(soldi);
                    return $"Prelevati {soldi}$";
                }
                
            }

            public string versa(double soldi)
            {
                if (soldi > 3000)
                {
                    return "Errore stai depositando più di 3000$\n";
                }
                else
                {
                    base.varsamento(soldi);
                    return $"Versati {soldi}$";
                }
            }
        }
        static void Main(string[] args)
        {
            string risposta;
            bool valido;
            double soldiP;
            double soldiV;
            Conto cc = new Conto();
            ContoModificato cm = new ContoModificato();
            do
            {
                Console.WriteLine($"{cm.ToString()}\n");
                Console.WriteLine("Premi 1 per prelevare\nPremi 2 per versare\nPremi 3 per chiudere il programma");
                risposta = Convert.ToString(Console.ReadLine());
                switch (risposta)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Inserisci quanti soldi vuoi prelevare");
                            string s = Convert.ToString(Console.ReadLine());
                            valido = double.TryParse(s, out soldiP);
                        } while (!valido || soldiP < 0);
                        Console.Clear();
                        Console.WriteLine($"{cm.preleva(soldiP)}");
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("Inserisci quanti soldi vuoi versare");
                            string s = Convert.ToString(Console.ReadLine());
                            valido = double.TryParse(s, out soldiV);
                        } while (!valido || soldiV < 0);
                        Console.Clear();
                        Console.WriteLine($"{cm.versa(soldiV)}");
                        break;
                    default:
                        break;
                }
            } while (risposta != "3");
        }
    }
}

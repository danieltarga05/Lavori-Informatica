using System;
using System.Threading;

namespace Menu

{


    internal class Program
    {
        private enum tAbbonamento
        {
            Ricaricabile,
            Abbonamento,
        }

        private struct Contratto
        {
            public string cognome;
            public string nome;
            public string numCel;
            public double saldo;
            public tAbbonamento cAbbonamento;
            public bool CTel;
        }

        private static void Main(string[] args)
        {
            bool fine = false;
            int Ncontratti = 0;
            string[] opzioni = { "Inserimento", "Visualizzazione", "Modifica", "Fine" };
            do
            {
                int selezione;
                Menu(opzioni, out selezione);
                Selezionamento(selezione, fine, ref Ncontratti);
                Console.ReadLine();
            } while (!fine);

        }

        private static readonly Contratto[] contratto = new Contratto[10];

        private static void Menu(string[] scelte, out int select)
        {

            do
            {
                Console.Clear();
                for (int i = 0; i < scelte.Length; i++)
                {
                    Console.WriteLine((i + 1) + ") " + scelte[i]);
                }
                Console.WriteLine("Immetti numero: ");
            } while (!int.TryParse(Console.ReadLine(), out select) || select < 1 || select > 5);
            Console.Clear();
        }

        private static void Selezionamento(int selezione, bool fine, ref int Ncontratti)
        {

            Console.Clear();
            switch (selezione)
            {
                case 1:
                    if (Ncontratti > contratto.Length)
                    {
                        Console.WriteLine("Tutti i contratti sono stati assegnati.");
                    }
                    else
                    {
                        Inserimento(Ncontratti);
                        Ncontratti++;
                    }
                    break;
                case 2: Visualizzazione(); break;
                case 3: Modifcia(ref Ncontratti); break;
                case 4: Elimina(ref Ncontratti); break;
                case 5: fine = true; break;
            }

        }

        private static void Inserimento(int Ncontratti)
        {
            string tmp;
            int controllo;
            string cell;
            double saldo;
            do
            {
                Console.Write("Inserire il cognome del contatto: ");
                tmp = Console.ReadLine();
                Console.Clear();
            } while (int.TryParse(tmp, out controllo));
            contratto[Ncontratti].nome = tmp;
            do
            {
                Console.Write("Inserire il nome del contatto: ");
                tmp = Console.ReadLine();
                Console.Clear();
            } while (int.TryParse(tmp, out controllo));
            contratto[Ncontratti].cognome = tmp;

            Console.WriteLine(NumeroTelefonico(out cell));

            contratto[Ncontratti].numCel = cell;
            do
            {
                Console.Clear();
                Console.Write("Inserire saldo: ");
            } while (!double.TryParse(Console.ReadLine(), out saldo));
            contratto[Ncontratti].saldo = saldo;
            do
            {
                Console.Clear();
                Console.WriteLine("Specificare tipologia di offerta:\n1) Ricaricabile         2) Abbonamento\n");
                tmp = Console.ReadLine();
            } while (tmp != "1" && tmp != "2");
            switch (tmp)
            {
                case "1": contratto[Ncontratti].cAbbonamento = tAbbonamento.Ricaricabile; break;
                case "2": contratto[Ncontratti].cAbbonamento = tAbbonamento.Abbonamento; break;
                default: break;
            }
            contratto[Ncontratti].CTel = true;

        }

        private static void Visualizzazione()
        {
            int qualeContr;

            SelezioneContratto(out qualeContr);
            if (contratto[qualeContr].CTel == true)
            {
                Console.WriteLine($"Cognome: {contratto[qualeContr].cognome}\nNome: {contratto[qualeContr].nome}\nNumero di telefono: {contratto[qualeContr].numCel}\nSaldo:{contratto[qualeContr].saldo}\nTipo di contratto: {contratto[qualeContr].cAbbonamento}");
                Console.WriteLine("premi qualsiasi tasto per tornare al menù:");
            }
            else
            {
                Console.WriteLine("Contratto non esistente premi un tasto per tornare al menù");
            }

        }
        private static int SelezioneContratto(out int qualec)
        {
            int selezione;

            do
            {
                Console.Clear();
                Console.WriteLine("Selezionare il contratto che vuoi visualizzare(partono da 0):");

            } while (!int.TryParse(Console.ReadLine(), out selezione) || selezione < 0 || selezione > 10);
            Console.Clear();
            qualec = selezione;

            return qualec;
        }

        private static void Modifcia(ref int Ncontratti)
        {
            int selezione;
            int scelta;
            if (Ncontratti != 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Selezionare il contratto che vuoi modificare(partono da 0):");
                } while (!int.TryParse(Console.ReadLine(), out selezione) || selezione < 0 || selezione > 10);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Cosa vuoi modificare: \n1)Saldo \n2)Tipo di offerta: ");
                } while (!int.TryParse(Console.ReadLine(), out scelta));
                switch (scelta)
                {
                    case 1: ModificaSaldo(selezione); break;
                    case 2: ModificaToff(selezione); break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Nesssun parametro modificabile torna al menù");
            }
        }

        private static void ModificaSaldo(int selezione)
        {
            double newSaldo;
            do
            {
                Console.Clear();
                Console.Write("Inserire nuovo saldo: ");
            } while (!double.TryParse(Console.ReadLine(), out newSaldo));
            contratto[selezione].saldo = newSaldo;

        }

        private static void ModificaToff(int selezione)
        {
            string tmp;
            do
            {
                Console.Clear();
                Console.WriteLine("Specificare tipologia di offerta:\n1) Ricaricabile         2) Abbonamento\n");
                tmp = Console.ReadLine();
            } while (tmp != "1" && tmp != "2");
            switch (tmp)
            {
                case "1": contratto[selezione].cAbbonamento = tAbbonamento.Ricaricabile; break;
                case "2": contratto[selezione].cAbbonamento = tAbbonamento.Abbonamento; break;
                default: break;
            }
        }

        private static string NumeroTelefonico(out string telefono)
        {
            telefono = "";
            Console.WriteLine("Inserisci numero telefonico");
            for (int i = 0; i < 10; i++)
            {
                char tasto = Console.ReadKey().KeyChar;
                if (char.IsDigit(tasto))
                {
                    telefono += tasto.ToString();
                }
                else if (tasto == 13)
                {
                    break;
                }
                else
                {
                    Console.Beep();
                    i--;
                }
            }
            return telefono;
        }
        static void Elimina(ref int Ncontratti)
        {
            int selezione;
            if (Ncontratti != 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Selezionare il contratto che vuoi eliminare(partono da 0):");
                } while (!int.TryParse(Console.ReadLine(), out selezione) || selezione < 0 || selezione > 10);
                Console.WriteLine("Cancellazione in corso...");
                contratto[selezione].nome = null;
                contratto[selezione].cognome = null;
                contratto[selezione].numCel = null;
                contratto[selezione].saldo = 0;
                contratto[selezione].cAbbonamento = 0;
                Thread.Sleep(2000);
                return;

            }
            else
            {
                Console.WriteLine("Nesssun parametro eliminabile torna al menù");
            }
        }
    }
}
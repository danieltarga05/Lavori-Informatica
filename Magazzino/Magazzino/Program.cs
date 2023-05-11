using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GestioneMagazzino
{
    class Program
    {
        struct prodotto
        {
            public int codice;
            public string descrizione;
            public int quantità;
            public double prezzo;
        }

        static void Main(string[] args)
        {
            int scelta;//variabile per la scelta dell'opzione
            bool uscita = false;//variabile per l'uscita del programma
            const int dimensione = 3;//dimensione del nostro magazzino
            prodotto[] magazzino = new prodotto[dimensione];//array dove sono inseriti i prodotti del magazzino
            string[] opzioni = { "Inserimento", "Visualizza", "Rimuovi", "Modifica", "Esci" };// array per il menù


            do
            {
                scelta = Menù(40, 10, opzioni, 20, '*');
                switch (scelta)
                {
                    case 1: Inserimento(magazzino); break;
                    case 2: Visualizza(magazzino); break;
                    case 3: Rimuovi(magazzino); break;
                    case 4: Modifica(magazzino); break;
                    case 5: uscita = true; break;
                }
            } while (!uscita);
        }

        static int Menù(int x, int y, string[] opz, int dim, char car)
        {
            int scelta = 0;
            int offset = 5;
            bool controllo;

            do
            {
                Console.Clear();
                for (int i = 0; i < opz.Length; i++)
                {
                    Console.SetCursorPosition(x + offset, ++y);
                    Console.WriteLine(i + 1 + "-" + opz[i]);
                }
                Console.Write("Inserisci scelta : ");
                do
                {
                    Console.Write("Inserire scelta: ");
                    controllo = int.TryParse(Console.ReadLine(), out scelta);
                } while (!controllo);
            } while (scelta < 1 && scelta > opz.Length);

            return scelta;
        }

        static void Inserimento(prodotto[] articoli/*Array che contiene i prodotti nel magazzino*/)//metodo per l'inserimento degli articoli
        {
            prodotto articolo;
            string tmp;//stringa temporanea che verrà usata per il tryparse
            bool controllo;//variabile che andremo ad assegnare al nostro tryparse, dove quando è vera il programma continua, se è falsa ti rifà la domanda

            Console.Clear();

            Console.WriteLine("E' ARRIVATO UN NUOVO ARTICOLO! INSERISCI I SUOI DATI \n");

            do
            {
                Console.Write("Inserisci codice : ");
                tmp = Console.ReadLine();
                controllo = int.TryParse(tmp, out articolo.codice);//inserimento codice

                int conta = 0;

                for (int i = 0; i < articoli.Length; i++)
                {
                    if (articolo.codice == articoli[i].codice)//se gli articoli hanno lo stesso numero di codice, te lo rifà mettere
                    {
                        Console.WriteLine("Codice già esistente, impossibile inserire il prodotto");
                        Thread.Sleep(1000);
                        return;
                    }

                    if (articoli[i].prezzo != 0)
                        conta++;
                }

                if (conta == articoli.Length)//se la lunghezza del vettore è uguale al numero di articoli massimi da inserire, non puoi più inserire niente
                {
                    Console.WriteLine("Il magazzino è pieno, non puoi inserire altri prodotti");
                    Thread.Sleep(1000);
                    return;
                }

            } while (!controllo);


            Console.Write("Inserire descrizione: ");
            try//try catch per vedere se il valore inserito è giusto, se è sbagliato ti rifà la domanda
            {
                articolo.descrizione = Console.ReadLine();
            }
            catch
            {
                Console.Write("Inserisci descrizione: ");
                articolo.descrizione = Console.ReadLine();
            }

            do//inserimento prezzo
            {
                Console.Write("Inserire quantità: ");
                controllo = int.TryParse(Console.ReadLine(), out articolo.quantità);
            } while (!controllo);//finchè il valore inserito non è corretto, te lo richiede. Si ripete anche con l'inserimento prezzo.

            do
            {
                Console.Write("Inserire prezzo: ");
                controllo = double.TryParse(Console.ReadLine(), out articolo.prezzo);
            } while (!controllo);

            for (int i = 0; i < articoli.Length; i++)
                if (articoli[i].prezzo == 0)//controllo se il prezzo è uguale a 0
                {
                    articoli[i] = articolo;
                    break;
                }

        }

        static void Visualizza(prodotto[] articoli)//metodo per la visualizzazione degli articoli
        {
            Console.Clear();
            Console.WriteLine("CONTENUTO MAGAZZINO\n");

            for (int i = 0; i < articoli.Length; i++)//se il nostro contatore è minore del numero di articoli(lunghezza del nostro array), possiamo visualizzare i nostri prodotti
            {
                if (articoli[i].prezzo != 0)
                {
                    Console.Write($"PRODOTTO NUMERO: {i + 1}\n");
                    Console.Write("Descrizione: " + articoli[i].descrizione + "\n");
                    Console.Write("Codice: " + articoli[i].codice + "\n");
                    Console.Write("Prezzo: €" + articoli[i].prezzo + "\n");
                    Console.Write("Quantità: " + articoli[i].quantità + "\n");
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }


        static void Rimuovi(prodotto[] articoli)//metodo per la rimozione degli articoli (non riuscito)
        {
            Console.Clear();
            Visualizza(articoli);
            Console.Write("\n Inserisci il codice del prodotto da eliminare : ");
            bool controllo = int.TryParse(Console.ReadLine(), out int scelta);

            if (!controllo || articoli[scelta - 1].prezzo == 0)
            {
                Console.Write("Prodotto non esistente");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.Write("Sto cancellando il prodotto...");
                articoli[scelta - 1].descrizione = "";
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Inserisci nuova descrizione");
                articoli[scelta - 1].descrizione = Console.ReadLine();
            }

        }
        static void Modifica(prodotto[] articoli)
        {
            Console.Clear();
            Visualizza(articoli);
            Console.Write("\n Inserisci prodotto da modificare : ");
            bool controllo = int.TryParse(Console.ReadLine(), out int scelta);

            if (!controllo || articoli[scelta - 1].prezzo == 0)
            {
                Console.Write("Prodotto non esistente");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.Write("Carico le modifiche...");
                articoli[scelta - 1].quantità = 0;
                articoli[scelta - 1].prezzo = 0;
                Thread.Sleep(1000);
                Console.Clear();
                do//inserimento prezzo
                {
                    Console.Write("Inserire quantità: ");
                    controllo = int.TryParse(Console.ReadLine(), out articoli[scelta - 1].quantità);
                } while (!controllo);//finchè il valore inserito non è corretto, te lo richiede. Si ripete anche con l'inserimento prezzo.

                do
                {
                    Console.Write("Inserire prezzo: ");
                    controllo = double.TryParse(Console.ReadLine(), out articoli[scelta - 1].prezzo);
                } while (!controllo);
            }

        }
    }
}


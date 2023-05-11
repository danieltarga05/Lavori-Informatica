using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tabellone_tombola
{
    class Program
    {

        static bool[] nTombola = new bool[90];
        static Random estratto = new Random();
        static int contaEstrazioni;
        static Boolean[] numeri = new Boolean[90];
        static int[] numEstratto = new int[15];

        static int numero;
        static int contatore = 0;
        static int tomb;
        static int primaRiga = 0;
        static int secondaRiga = 0;
        static int terzaRiga = 0;

        static Boolean ambo;
        static Boolean terna;
        static Boolean quaterna;
        static Boolean cinquina;
        static void Main(string[] args)
        {
            string[] opzione = new string[] { "1-tabellone", "2-cartella", "4-fine" };
            bool fine = false;
            do
            {
                switch (Menu(20, 5, 20, '*', opzione))
                {
                    case 1: tabellone(); Console.ReadLine(); break;
                    case 2: cartella(); Console.ReadLine(); break;
                    case 4: fine = true; break;
                }
            } while (!fine);
            Console.WriteLine("Fine Programma");
            Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                estrazione();
                numEstratto[i] = numero;
            }

            for (int i = 0; i < 15; i++)
                numeri[i] = false;

            cartella();


            while (tomb < 15)
            {

                inserisciNumero();
                cartella();
                vincita();

            }

            Console.Clear();
            Console.WriteLine("Hai fatto la tombola!!");
            Console.ReadLine();

        }

        static void estrazioni()
        {
            int numero;
            do
            {

                numero = estratto.Next(1, 91);
                if (!nTombola[numero - 1])
                {
                    nTombola[numero - 1] = !nTombola[numero - 1];
                    contaEstrazioni++;

                }


            } while (!nTombola[numero - 1]);
            Console.WriteLine($"Numero estratto : {numero}");
            

        }
        static void tabellone()
        {
            do
            {
                int numero = 0;
                for (int riga = 0; riga < 9; riga++)
                {
                    for (int colonna = 0; colonna < 10; colonna++)
                    {

                        if (nTombola[numero] == true)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        numero++;
                        if (numero < 10)
                            Console.Write("0");

                        Console.Write(numero + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.ReadLine();
                Console.Clear();
                estrazioni();


                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            } while (contaEstrazioni < 90);

        }
        //METODO "Disegna"
        //descrizione:disegna nella posizione indicata da x e y  una riga composta dal carattere s di lunghezza l.
        //parametri :
        //int x = ascissa
        //int y = ordinata
        //int l= lunghezza stringa
        //s= simbolo da visualizzare
        static void DisegnaRiga(int x, int y, int l, char s)
        {

            Console.SetCursorPosition(x, y);
            for (int i = 0; i < l; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine();

        }
        //METODO "Menù"
        //descrizione: Inserisce un menù in posizione x e y, con un separatore di lunghezza l composto da un carattere s;
        //Il menù viene inserito dopo aver inserito un valore valido tra 1 e la lunghezza del vettore opzione
        //parametri:
        //int x = ascissa
        //int y = ordinata
        //int l= lunghezza stringa
        //s= simbolo da visualizzare
        static int Menu(int x, int y, int l, char s, string[] opzione)
        {
            int selezione = 0;
            int offset = 4;
            Console.Clear();
            do
            {
                DisegnaRiga(x, y, l, s);
                for (int i = 0; i < opzione.Length; i++)
                {
                    Console.SetCursorPosition(x + offset, ++y);
                    Console.WriteLine(opzione[i]);
                }
                DisegnaRiga(x, ++y, l, s);
                selezione = Convert.ToInt32(Console.ReadLine());
            } while (selezione < 1 || selezione > opzione.Length);

            return selezione;
        }
        static void estrazione()
        {

            bool trovato = false;
            Random estrazione = new Random();

            do
            {
                numero = estrazione.Next(1, 91);

                if (!numeri[numero - 1])
                {
                    numeri[numero - 1] = true;
                    trovato = true;

                }

            } while (!trovato);

        }


        static void cartella()
        {
            Console.Clear();
            for (int num = 0; num < 15; num++)
            {

                if (numeri[num])
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                    if (numEstratto[num] < 10)
                        Console.Write("0" + numEstratto[num] + " ");
                    else
                        Console.Write(numEstratto[num] + " ");

                    Console.ResetColor();
                }
                else
                {
                    if (numEstratto[num] < 10)
                        Console.Write("0" + numEstratto[num] + " ");
                    else
                        Console.Write(numEstratto[num] + " ");
                }

                contatore++;
                if (contatore % 5 == 0)
                    Console.WriteLine();
            }
        }


        static void inserisciNumero()
        {
            int uscita;

            do
            {
                Console.Write("Quale numero è uscito? : ");
                uscita = Convert.ToInt32(Console.ReadLine());

                if (uscita < 0 || uscita > 90)
                {
                    Console.Clear();
                    Console.WriteLine("Valore errato");
                    Console.ReadLine();
                }

            } while (uscita < 0 || uscita > 90);

            for (int verifica = 0; verifica < 15; verifica++)
            {
                if (numEstratto[verifica] == uscita)
                {
                    if (verifica < 5)
                        primaRiga++;
                    else if (verifica < 10)
                        secondaRiga++;
                    else
                        terzaRiga++;

                    numeri[verifica] = true;
                    tomb++;
                }

            }
        }


        static void vincita()
        {

            if (primaRiga == 2 || secondaRiga == 2 || terzaRiga == 2 && ambo == false)
            {
                Console.WriteLine("Hai fatto l' ambo!!");
                ambo = true;

            }

            else if (primaRiga == 3 || secondaRiga == 3 || terzaRiga == 3 && terna == false)
            {
                Console.WriteLine("Hai fatto la terna!!");
                terna = true;
            }

            else if (primaRiga == 4 || secondaRiga == 4 || terzaRiga == 4 && quaterna == false)
            {
                Console.WriteLine("Hai fatto la quaterna!!");
                quaterna = true;
            }

            else if (primaRiga == 5 || secondaRiga == 5 || terzaRiga == 5 && cinquina == false)
            {
                Console.WriteLine("Hai fatto la cinquina!!");
                cinquina = true;
            }
        }
    }
}

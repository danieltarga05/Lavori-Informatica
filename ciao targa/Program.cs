using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Macchinacaffe
{
    internal class Program
    {

        static ConsoleKeyInfo seleziona;
        static int opzioneSelezionata, eseguiOpzione;
        static bool opzione1 = true, opzione2, opzione3, opzione4, opzione5, opzione6, opzione7, opzione8, invioPremuto;
        static int[] supporto = new int[] { 0, 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            string rifare;
            barradiavanzamento();

            string[] opzioni = new string[] { "1-Caffè macchiato\n", "2-Caffè normale\n", "3-Cappuccino\n", "4-Cioccolata\n", "5-Macchiatone\n", "6-Caffè d'orzo\n", "7-Caffè decafeinato\n", "8-Service\n" };
            Console.CursorVisible = false; //non viene visualizzato su console il cursore
            do
            {

                do
                {
                    Menu(opzioni);
                    SelezionaOpzioni();
                } while (!invioPremuto);
                
                Console.WriteLine("Vuoi rifare il caffè? s/n");
                rifare = Console.ReadLine();
            } while (rifare == "s" || rifare == "S");
            Console.ReadLine();
        }

        static void barradiavanzamento()
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                Console.Write("=");
            }
        }


        //  questo è il menù della macchinetta del caffè che verrà visualizzata a schermo 
        static void Menu(string[] opzioni)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("MENU\n");
            if (opzione1) //se la condizione è vera allora viene evidenziata l'opzione
            {
                EvidenziaOpzione();
                opzione1 = false;
            }
            Console.WriteLine(opzioni[0]);
            Console.ResetColor();
            if (opzione2)
            {
                EvidenziaOpzione();
                opzione2 = false;
            }
            Console.WriteLine(opzioni[1]);
            Console.ResetColor();
            if (opzione3)
            {
                EvidenziaOpzione();
                opzione3 = false;
            }
            Console.WriteLine(opzioni[2]);
            Console.ResetColor();
            if (opzione4)
            {
                EvidenziaOpzione();
                opzione4 = false;
            }
            Console.WriteLine(opzioni[3]);
            Console.ResetColor();
            if (opzione5)
            {
                EvidenziaOpzione();
                opzione5 = false;
            }
            Console.WriteLine(opzioni[4]);
            Console.ResetColor();
            if (opzione6)
            {
                EvidenziaOpzione();
                opzione6 = false;
            }
            Console.WriteLine(opzioni[5]);
            Console.ResetColor();
            if (opzione7)
            {
                EvidenziaOpzione();
                opzione7 = false;
            }
            Console.WriteLine(opzioni[6]);
            Console.ResetColor();
            if (opzione8)
            {
                EvidenziaOpzione();
                opzione8 = false;
            }
            Console.WriteLine(opzioni[7]);
            Console.ResetColor();
        }
        static void EvidenziaOpzione() //metodo per evidenziare l'opzione corrente
        {

            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void SelezionaOpzioni() //metodo per l'input e per la selezione delle opzioni
        {
            seleziona = Console.ReadKey(); //prende in input un tasto
            if (seleziona.Key == ConsoleKey.UpArrow && opzioneSelezionata > 0) //se il tasto è freccia su e l'opzione è maggiore di 0 allora viene selezionata l'opzione precedente a essa
            {
                opzioneSelezionata--;

            }
            else if (seleziona.Key == ConsoleKey.DownArrow && opzioneSelezionata < 7) //se il tasto è freccia giù e l'opzione è minore di 7 allora viene selezionata l'opzione successiva a essa
            {
                opzioneSelezionata++;
            }
            else if (seleziona.Key == ConsoleKey.Enter) //se il tasto è invio allora viene selezionata l'opzione corrente e il booleano invioPremuto diventa vero
            {
                eseguiOpzione = opzioneSelezionata;
                invioPremuto = true;
            }
            switch (opzioneSelezionata) //switch per evidenziare tramite condizioni booleane le opzioni che andiamo a selezionare
            {
                case 0: opzione1 = true; break;
                case 1: opzione2 = true; break;
                case 2: opzione3 = true; break;
                case 3: opzione4 = true; break;
                case 4: opzione5 = true; break;
                case 5: opzione6 = true; break;
                case 6: opzione7 = true; break;
                case 7: opzione8 = true; break;
            }
            if (invioPremuto) //se il tasto invio è stato premuto e l'opzione è stata selezionata allora farà avviare il metodo corrispondente
            {
                switch (eseguiOpzione)
                {
                    case 0: Caffèmacchiato(); break;
                    case 1: Caffènormale(); break;
                    case 2: Cappuccino(); break;
                    case 3: Cioccolata(); break;
                    case 4: macchiattone(); break;
                    case 5: caffèdorzo(); break;
                    case 6: caffèdeca(); break;
                    case 7: service(); break;
                }
            }
            Console.Clear();
        }

        //CREAZIONE DEI METODI DI OGNI SINGOLA BEVANDA 
        static void Caffèmacchiato()
        {
            Console.WriteLine("Caffè macchiato\n Costo: 0.50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void Caffènormale()
        {
            Console.WriteLine("Caffè normale\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void Cappuccino()
        {
            Console.WriteLine("Cappuccino\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void Cioccolata()
        {
            Console.WriteLine("Cioccolata\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void macchiattone()
        {
            Console.WriteLine("Macchiatone\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void caffèdorzo()
        {
            Console.WriteLine("Caffè d'orzo\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void caffèdeca()
        {
            Console.WriteLine("Caffè Decafeinato\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(supporto);
            RiscaldamentoAcqua(0, '=');
            caricamnetocaffè(0, '=');
            disegno();
        }
        static void service()
        {
            Console.Clear();
            string[] opzioniservice = new string[] { "1-Ricarica Cialde", "2-Riarica bicchieri", "3-Ricarica acqua" };
            Console.CursorVisible = false;
            do
            {
                MenuService(opzioniservice);
                SelezionaOpzioniService();
            } while (!invioPremuto);

            Console.ReadLine();

        }
        static void MenuService(string[] opzioniservice)
        {
            Console.SetCursorPosition(0, 0);
            if (opzione1)
            {
                EvidenziaOpzione();
                opzione1 = false;
            }
            Console.WriteLine(opzioniservice[0]);
            Console.ResetColor();
            if (opzione2)
            {
                EvidenziaOpzione();
                opzione2 = false;
            }
            Console.WriteLine(opzioniservice[1]);
            Console.ResetColor();
            if (opzione3)
            {
                EvidenziaOpzione();
                opzione3 = false;
            }
            Console.WriteLine(opzioniservice[2]);
            Console.ResetColor();
           
        }
        static void SelezionaOpzioniService()
        {

            seleziona = Console.ReadKey();
            if (seleziona.Key == ConsoleKey.UpArrow && opzioneSelezionata > 0)
            {
                opzioneSelezionata--;

            }
            else if (seleziona.Key == ConsoleKey.DownArrow && opzioneSelezionata < 2)
            {
                opzioneSelezionata++;
            }
            else if (seleziona.Key == ConsoleKey.Enter)
            {
                eseguiOpzione = opzioneSelezionata;
                invioPremuto = true;
            }
            switch (opzioneSelezionata)
            {
                case 0: opzione1 = true; break;
                case 1: opzione2 = true; break;
                case 2: opzione3 = true; break;


            }
            if (invioPremuto)
            {
                switch (eseguiOpzione)
                {
                    /*case 0:ricaricacialde (); break;
                      case 1:ricaricabicchieri(); break;
                      case 2:ricaricacqua(); break;
                      case 3:ricaricazucchero(); break;*/
                }
            }

        }


        static void Zucchero(int[] zucchero)
        {
            Console.Clear();
            Console.WriteLine("Quante palline di zucchero vuoi?");
            Console.WriteLine("Scegli un numero da 1 a 5");
            foreach (int i in zucchero)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            int scelta = int.Parse(Console.ReadLine());

        }
        static void caricamnetocaffè(int tacca, char disegno)
        {
            //int acquatotale = 500;
            //int bicchiere = 10;

            Console.WriteLine("Attendere il caffè si sta preparando...");
            for (; tacca < 12; tacca++)
            {
                Console.Write(disegno);
                Thread.Sleep(1000);
            }

            /* Console.ReadLine();
             Acqua(ref acquatotale, 60);
             Bicchiere(ref bicchiere);*/

        }
        /* static int Acqua(ref int acquatotale, int acquadevanda)
         {
             int acquarimanente = acquatotale - acquadevanda;
             acquatotale = acquarimanente;
             Console.WriteLine($"Sono Presenti ancora {acquatotale}mL di acqua");
             return acquatotale;
         }
         static int Bicchiere(ref int bicchiere)
         {
             bicchiere--;
             Console.WriteLine(bicchiere);
             return bicchiere;
         }*/

        static void RiscaldamentoAcqua(int tacca, char disegno)
        {
            Console.Clear();
            Console.WriteLine("Riscaldamento in corso...");
            for (; tacca < 10; tacca++)
            {
                Thread.Sleep(1000);
                Console.Write(disegno);
            }
            Console.Clear();
        }
        static void InserimentoMoneta(double costo)
        {
            Console.Clear();
            Console.WriteLine("Inserire valore con la virgola.Grazie :)");
            double moneta;
            double somma, mancante, resto;
            Console.WriteLine("Inserisci la moneta");
            moneta = Convert.ToDouble(Console.ReadLine());
            if (moneta < costo)
            {
                Console.WriteLine($"Ti mancano da inserire: {costo - moneta}");
                somma = moneta;
                while (somma != costo)
                {
                    Console.WriteLine("Inserisci soldi mancanti");
                    mancante = Convert.ToDouble(Console.ReadLine());
                    somma += mancante;
                }


            }
            else if (moneta > costo)
            {
                resto = moneta - costo;
                Console.WriteLine($"Il resto è: {resto}");
            }

            Console.WriteLine("Preparo caffè");
            Console.ReadLine();
        }

        static void disegno()
        {
            Console.WriteLine("Caffè pronto");
            Console.WriteLine("     / ");
            Console.WriteLine("    / ");
            Console.WriteLine("   |");
            Console.WriteLine("---------");
            Console.WriteLine("|       |----");
            Console.WriteLine("|       |    |");
            Console.WriteLine("|_______|----");
            Console.ReadLine();
        }



    }
}


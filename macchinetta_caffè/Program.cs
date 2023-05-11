using System;
using System.Threading;

namespace Macchinacaffe
{
    internal class Program
    {
        static int opzioneSelezionata, eseguiOpzione;
        static bool opzione1 = true, opzione2, opzione3, opzione4, opzione5, opzione6, opzione7, opzione8, invioPremuto, premiInvio;
        static int serbatoio = 500;
        static int[] cialde = new int[] { 5, 5, 5, 5, 5, 5, 5 };
        static int bicchieri = 10;
        static void Main(string[] args)
        {
            string rifare;

            Console.Clear();
            RiscaldamentoAcqua(0, '=');

            string[] opzioni = new string[] { "1-Caffè macchiato\n", "2-Caffè normale\n", "3-Cappuccino\n", "4-Cioccolata\n", "5-Macchiatone\n", "6-Caffè d'orzo\n", "7-Caffè decafeinato\n", "8-Service\n" };
            Console.CursorVisible = false; //non viene visualizzato su console il cursore

            int a = 2, b = 4;
            if (a < b)
                int tmp = a;
            string tmp;
            //do
            //{
            //    invioPremuto = false;
            //    Console.Clear();
            //    do
            //    {
            //        controlli();
            //        Menu(opzioni);
            //        SelezionaOpzioni(Console.ReadKey());
            //    } while (!invioPremuto);
            //    Console.WriteLine("Vuoi rifare il caffè? S/N");
            //    rifare = Console.ReadLine().ToUpper();
            //} while (!premiInvio && rifare == "S");
            //Console.Clear();
            Console.ReadLine();
        }

        static void controlli()
        {
            Console.Clear();
            if (bicchieri == 0)
            {
                Console.WriteLine("Ricaricare bicchieri, non ce ne sono più");
            }
            else if (serbatoio == 0)
                Console.WriteLine("Ricaricare serbatoio, manca l'acqua");

            for (int i = 0; i < cialde.Length; i++)
            {
                if (cialde[i] == 0)
                    Console.WriteLine("Ricaricare le cialde");
            }


        }

        //questo è il menù della macchinetta del caffè che verrà visualizzata a schermo 
        //TARGA
        static void Menu(string[] opzioni)
        {
            Console.Clear();
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
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;

        }
        //TARGA
        static void SelezionaOpzioni(ConsoleKeyInfo seleziona) //metodo per l'input e per la selezione delle opzioni
        {
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
                    case 4: Macchiattone(); break;
                    case 5: CaffèDOrzo(); break;
                    case 6: CaffèDeca(); break;
                    case 7: Service(); break;
                }
            }

        }

        //CREAZIONE DEI METODI DI OGNI SINGOLA BEVANDA(PILOTTO) 
        static void Caffèmacchiato()
        {
            Console.WriteLine("Caffè macchiato\n Costo: 0.50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[0]--;
            DecrementoAcqua(90);
            caricamnetocaffè(0, '=', 18);
            Disegno();
        }
        static void Caffènormale()
        {
            Console.WriteLine("Caffè normale\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[1]--;
            DecrementoAcqua(60);
            caricamnetocaffè(0, '=', 12);
            Disegno();
        }
        static void Cappuccino()
        {
            Console.WriteLine("Cappuccino\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[2]--;
            DecrementoAcqua(100);
            caricamnetocaffè(0, '=', 20);
            Disegno();
        }
        static void Cioccolata()
        {

            Console.WriteLine("Cioccolata\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[3]--;
            DecrementoAcqua(100);
            caricamnetocaffè(0, '=', 20);
            Disegno();
        }
        static void Macchiattone()
        {

            Console.WriteLine("Macchiatone\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[4]--;
            DecrementoAcqua(90);

            caricamnetocaffè(0, '=', 18);
            Disegno();
        }
        static void CaffèDOrzo()
        {

            Console.WriteLine("Caffè d'orzo\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[5]--;
            DecrementoAcqua(60);
            caricamnetocaffè(0, '=', 12);
            Disegno();
        }
        static void CaffèDeca()
        {
            Console.WriteLine("Caffè Decafeinato\n Costo: 0,50€\n");
            InserimentoMoneta(0.50);
            Zucchero(new int[] { 0, 1, 2, 3, 4, 5 });
            bicchieri--;
            cialde[6]--;
            DecrementoAcqua(60);
            caricamnetocaffè(0, '=', 12);
            Disegno();
        }
        //PILOTTO
        static void Service()//Metodo dove vengono ricaricate le opportune funzionalità affinchè la macchinetta vada
        {
            int risposta;
            Console.Clear();
            Console.WriteLine("1-Ricarica cialde\n2-Ricarica bicchieri\n3-Ricarica acqua\n");
            risposta = Convert.ToInt32(Console.ReadLine());
            if (risposta != 1 && risposta != 2 && risposta != 3)
            {
                Console.WriteLine("Riscrivi");
                risposta = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            switch (risposta)
            {
                case 1: Ricaricacialde(); break;
                case 2: Ricaricabicchieri(); break;
                case 3: RicaricAcqua(); break;
            }
        }
        //TARGA
        static void Zucchero(int[] zucchero)//Metodo per l'inserimento dello zucchero nella nostra macchinetta
        {
            Console.Clear();
            Console.WriteLine("Quanto zucchero vuoi?");
            foreach (int i in zucchero)//Attraverso questo ciclo vengono scritti i numeri dello zucchero che vuoi inserire
                Console.Write(i + " ");
            Console.WriteLine("Scegli un numero da 0 a 5");
            int scelta = int.Parse(Console.ReadLine());//inserisci in intput il numero che vuoi

        }
        //TARGA
        static void caricamnetocaffè(int tacca, char disegno, int ripetizione)//Metodo per il caricamento della bevanda che si sta preparando
        {


            Console.WriteLine("Attendere, la bevanda si sta preparando...");
            for (; tacca < ripetizione; tacca++)//La bevanda si sta preparando in base alla potenza della pompa, cioè 5mL/s, e ogni simbolo è un secondo
            {
                Console.Write(disegno);
                Thread.Sleep(1000);
            }
            Console.Clear();


        }


        //TARGA
        static void RiscaldamentoAcqua(int tacca, char disegno)//metodo del riscaldamento dell'acqua iniziale
        {
            Console.Clear();
            Console.WriteLine("Riscaldamento in corso...");
            for (; tacca < 10; tacca++)//ciclo dove un simbolo equivale a un secondo e l'acqua si deve riscaldare in 10 secondi, quindi avremo in totale 10 simboli
            {
                Thread.Sleep(1000);
                Console.Write(disegno);
            }
            Console.Clear();
        }
        //PILOTTO
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
                while (somma != costo)//ciclo per restituire il resto 
                {
                    Console.WriteLine("Inserisci soldi mancanti");
                    mancante = Convert.ToDouble(Console.ReadLine());
                    somma += mancante;
                }

                Console.ReadLine();
            }
            else if (moneta > costo)
            {
                resto = moneta - costo;
                Console.WriteLine($"Il resto è: {resto}");
            }
            Console.ReadLine();

        }
        //PILOTTO
        static void Disegno()
        {
            Console.Clear();
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
        //TARGA 
        static void DecrementoAcqua(int acquabevanda)
        {
            serbatoio -= acquabevanda; //dal serbatoio dell'acqua viene sottratta la quantità di acqua utilizzata dalla bevanda relativa
            if (serbatoio < acquabevanda) //se il serbatoio è minore dell'acqua è minore della quantità di acqua utilizzata dalla bevanda viene ricaricata
            {
                RicaricAcqua();
            }
        }
        //TARGA
        static void RicaricAcqua()
        {
            serbatoio = 500; //il serbatoio dell'acqua viene riinizializzato a 500ml
            Console.WriteLine("Ricarico serbatoio " + serbatoio);
            Console.ReadLine();
        }
        //TARGA
        static void Ricaricacialde()
        {

            for (int i = 0; i < cialde.Length; i++) //ciclo per analizzare ogni bevanda dell'array
            {
                if (cialde[i] < 5) //se le cialde della bevanda che stiamo analizzando è minore di 5 allora viene riportata a 5
                    cialde[i] = 5;
            }
            Console.WriteLine("Ricaricato cialde"); //conferma ricarica cialde
            Console.ReadLine();
        }
        static void Ricaricabicchieri()
        {
            if (bicchieri <= 0) //se i bicchieri presenti nella macchinetta sono minori o uguali a 0 allora liriinizializza a 10
            {
                bicchieri = 10;
            }
            Console.WriteLine("Ricaricato bicchieri"); //conferma ricarica bicchieri


        }

    }

}
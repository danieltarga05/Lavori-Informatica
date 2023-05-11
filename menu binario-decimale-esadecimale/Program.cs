using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_binario_decimale_esadecimale
{
    internal class Program
    {
        static int scelta;//permette la scelta di quale operazione utilizzare
        static int numero;//in base alla conversione questo è il numero da inserire
        static string tmp;//stringa temporanea che dopo verrà convertita in un intero
        static string risposta;//la risposta se vuoi continuare il programma
        static void Main(string[] args)
        {
            do
            {
                menu();
                controlli();
                opzione();
                Console.Clear();
                Console.WriteLine("Vuoi continuare il programma? S/N");
                risposta = Console.ReadLine();
                Console.Clear();
            } while (risposta == "S");
            if (risposta=="N")
            {
                Console.Clear();
                Console.WriteLine("Applicazione Terminata");
                Console.ReadLine();
            }
        }
        static void menu()
        {
            //menù
            Console.WriteLine("MENU'");
            Console.WriteLine("1 Binario-decimale");
            Console.WriteLine("2 Decimale-binario");
            Console.WriteLine("3 Decimale-Esadecimale");
            Console.WriteLine("4 Fine");
            Console.WriteLine("Inserisci il numero che ti permette di eseuire l'operazione");
            tmp = Console.ReadLine();//stringa temporanea che dopo verrà convertita in un intero

        }
        static void controlli()//vengono fatti tutti i controlli della scelta
        {
            while (tmp == "")//controllo stringa vuota
            {
                Console.Clear();
                Console.WriteLine("E' presente un errore, riprova a inserire il numero:");
                tmp = Console.ReadLine();
            }
            scelta = Convert.ToInt32(tmp);

            while (scelta>4 || scelta <1)//controllo che finchè la scelta è maggiore di 4 o minore di 1, reinserire il numero
            {
                Console.Clear();
                Console.WriteLine("E' presente un errore, riprova a inserire il numero:");
                scelta=Convert.ToInt32(Console.ReadLine());
            }
        }
        static void opzione()//in questo metodo vengono scelte le opzioni da fare
        {
            switch (scelta)//le operazione che, in base al numero di scelta inserito, te le farà
            {
                case 1: decbin(); break;
                case 2: bindec(); break;
                case 3: decesa(); break;
                case 4: fine(); break;
            }
        }
        static void decbin()
        {
            Console.Clear();
            Console.WriteLine("Inserisci un numnero da convertire in binario");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero>255)//finchè il numero è maggiore di 255, reinserire il numero
            {
                Console.Clear();
                Console.WriteLine("E' presente un errore, riprova a inserire il numero:");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            int bit1 = numero % 2;//dichiarazione e assegnazione dei bit
            numero = numero / 2;

            int bit2 = numero % 2;
            numero = numero / 2;

            int bit3 = numero % 2;
            numero = numero / 2;

            int bit4 = numero % 2;
            numero = numero / 2;

            int bit5 = numero % 2;
            numero = numero / 2;

            int bit6 = numero % 2;
            numero = numero / 2;

            int bit7 = numero % 2;
            numero = numero / 2;

            int bit8 = numero % 2;
            numero = numero / 2;

            Console.WriteLine($"Il numero bimario è {bit8}{bit7}{bit6}{bit5}{bit4}{bit3}{bit2}{bit1}");//stampa il numero binario finale
            Console.ReadLine();

        }
        static void bindec()//metodo per la conversione da binario a decimale (non riuscito nella conversione) 
        {
            Console.Write("Numero binario: ");
            numero = Convert.ToInt32(Console.ReadLine());
            string word = Convert.ToString(numero);//ti converte il numero in una stringa
            int esp = Convert.ToInt32(word.Length);//ti mostra da quante cifre è composto il numero binario

            Console.WriteLine($"Il numero ha {esp}");
            int cifra;
            int conversione = 0;//ti permetterà la visualizzazione dellla conversione in decimale

            while (numero > 0)//finchè il numero è maggiore di 0, potrai eseguire tutte le tue operazoni
            {

                cifra = numero % 10;
                numero /= 10;

                while (cifra != 1 && cifra != 0)//finchè almeno una cifra del numero non è nè 0 nè 1, devi reinserire il numero
                {
                    Console.Clear();
                    Console.Write("Il valore inserito non è binario, riprova: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    word = Convert.ToString(numero);
                    esp = Convert.ToInt32(word.Length);

                    while (word.Length > 8)//finchè il numero non è formato da 8 bit, reinserire il numero 
                    {
                        Console.Clear();
                        Console.Write("Il numero deve avere MASSIMO 8 bit, riprova: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        word = Convert.ToString(numero);
                        esp = Convert.ToInt32(word.Length);
                    }
                }

                conversione = conversione + (cifra * 2 ^ esp);//operazione per la conversione in decimale

            }
            Console.WriteLine($"Numero decimale: {conversione}");
            Console.ReadLine();
        }
        static void decesa()//metodo per la conversione da decimale ad esadecimale
        {
            Console.Clear();
            string conversione = "";
            int resto;
            numero = Convert.ToInt32(Console.ReadLine());
            do
            {
                resto = numero % 16;
                numero /= 16;
                switch (resto)
                {
                    case 10: conversione = "A" + conversione; break;
                    case 11: conversione = "B" + conversione; break;
                    case 12: conversione = "C" + conversione; break;
                    case 13: conversione = "D" + conversione; break;
                    case 14: conversione = "E" + conversione; break;
                    case 15: conversione = "F" + conversione; break;
                }
            } while (numero != 0);
            Console.WriteLine($"Il numero in esadecimale: {conversione}");
            Console.ReadLine();
        }
        static void fine()//l'applicazione viene terminata
        {
            Console.Clear();
            Console.WriteLine("Applicazione Terminata");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operazioni
{
    class Program
    {
        static double numero1, numero2, risultato;
        static int rispostaoperazione, i;
        static string stringavuota, risposta;
        static void Main(string[] args)
        {
            controllo();
            menu1();
            selezione1();
            Console.WriteLine("Vuoi ripetere il programma? S/N");
            risposta = Console.ReadLine();
            Console.Clear();

            if (risposta == "S")
            {
                ciclo();
            }
            else if (risposta == "N")
            {
                Console.Clear();
                Console.WriteLine("Calcolatrice Terminata");
                Console.ReadLine();
            }
        }
        static void controllo()
        {
            Console.WriteLine("Inserisci il primo numero");
            stringavuota = Console.ReadLine();

            while (stringavuota == "")
            {
                Console.Clear();
                Console.WriteLine("E' presente un errore, riprova a inserire il numero:");
                stringavuota = Console.ReadLine();
            }
            numero1 = Convert.ToDouble(stringavuota);

            Console.Clear();
            Console.WriteLine("Inserisci il secondo numero");
            stringavuota = Console.ReadLine();

            while (stringavuota == "")
            {
                Console.WriteLine("E' presente un errore, riprova a inserire il numero:");
                stringavuota = Console.ReadLine();
            }
            numero2 = Convert.ToDouble(stringavuota);
        }
        static void menu1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MENU' OPERAZIONI");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1 Addizione");
            Console.WriteLine("2 Sottrazione");
            Console.WriteLine("3 Moltiplicazione");
            Console.WriteLine("4 Divisione");

            Console.ResetColor();



        }
        static void menu2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MENU' OPERAZIONI");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1 Addizione");
            Console.WriteLine("2 Sottrazione");
            Console.WriteLine("3 Moltiplicazione");
            Console.WriteLine("4 Divisione");
            Console.WriteLine("5 Fine");

            Console.ResetColor();


        }
        static void addizione()
        {
            Console.Clear();
            risultato = numero1 + numero2;
            Console.WriteLine($"{numero1} + {numero2} = {risultato}");
            Console.ReadLine();
        }
        static void sottrazione()
        {
            Console.Clear();
            risultato = numero1 - numero2;
            Console.WriteLine($"{numero1} - {numero2} = {risultato}");
            Console.ReadLine();
        }
        static void moltiplicazione()
        {
            Console.Clear();
            risultato = numero1 * numero2;
            Console.WriteLine($"{numero1} * {numero2} = {risultato}");
            Console.ReadLine();
        }
        static void divisione()
        {
            Console.Clear();

            if (numero2 == 0)
            {
                Console.WriteLine("Impossibile dividere un numero per 0!");
                Console.ReadLine();
            }
            else if (numero2 != 0)
            {
                risultato = numero1 / numero2;
                Console.WriteLine($"{numero1} / {numero2} = {risultato}");
                Console.ReadLine();
            }
        }
        static void ciclo()
        {

            
            do
            {
                controllo();
                menu2();
                selezione2();
                Console.WriteLine("Vuoi ripetere il programma? S/N");
                risposta = Console.ReadLine();
                Console.Clear();

            } while (risposta == "S") ;



        }
        static void selezione1()
        {
            Console.WriteLine("Inserisci il numero corrispondente all'operazione da eseguire:");
            rispostaoperazione = Convert.ToInt32(Console.ReadLine());
            while (rispostaoperazione > 4 || rispostaoperazione < 1)
            {
                Console.Clear();
                Console.WriteLine("Errore! Puoi scegliere dei valori da 1 a 4");
                rispostaoperazione = Convert.ToInt32(Console.ReadLine());
            }
            if (rispostaoperazione == 1)
                addizione();
            else if (rispostaoperazione == 2)
                sottrazione();
            else if (rispostaoperazione == 3)
                moltiplicazione();
            else if (rispostaoperazione == 4)
                divisione();

        }
        static void selezione2()
        {
            Console.WriteLine("Inserisci il numero corrispondente all'operazione da eseguire:");
            rispostaoperazione = Convert.ToInt32(Console.ReadLine());


            while (rispostaoperazione > 5 || rispostaoperazione < 1)
            {

                Console.Clear();
                Console.WriteLine("Errore! Puoi scegliere dei valori da 1 a 5");
                rispostaoperazione = Convert.ToInt32(Console.ReadLine());

            }
            if (rispostaoperazione == 1)
                addizione();
            else if (rispostaoperazione == 2)
                sottrazione();
            else if (rispostaoperazione == 3)
                moltiplicazione();
            else if (rispostaoperazione == 4)
                divisione();
            else if (rispostaoperazione == 5)

                        i++;
                        Console.Clear();
                        Console.WriteLine("Calcolatrice Terminata");
                        Console.ReadLine();



            }

        }
    }







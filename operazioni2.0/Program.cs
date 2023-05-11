using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operazioni
{
    class Program
    {

        static string risposta;
        static int rispostaoperazione;

        static void Main(string[] args)
        {
            menu1();
            selezione1();
            Console.WriteLine("Vuoi ripetere il programma? S/N");
            risposta = Console.ReadLine();
            Console.Clear();

            while (risposta == "S")
            {
                ciclo();
            }
            if (risposta == "N")
            {
                Console.Clear();
                Console.WriteLine("Calcolatrice Terminata");
                Console.ReadLine();
            }
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
        static void addizione(ref double ad1, ref double ad2, out double s)
        {
            
            
            s = ad1 + ad2;
            Console.WriteLine($"Il risultato è: {s}");
            Console.ReadLine();
        }
        static void sottrazione(ref double min, ref double sot, out double dif)
        {
            
            dif = min - sot;
            Console.WriteLine($"Il risultato è: {dif}");
            Console.ReadLine();
        }
        static void moltiplicazione(ref double f1, ref double f2, out double p)
        {
            p = f1 * f2;
            Console.WriteLine($"Il risultato è: {p}");
            Console.ReadLine();
        }
        static void divisione(ref double dividendo, ref double divisore, out double q)
        {
            
                q = dividendo / divisore;
                Console.WriteLine($"Il risultato è: {q}");
                Console.ReadLine();
            
        }
        static void ciclo()
        {
            
           
                menu2();
                selezione2();
                if (rispostaoperazione==5)
                {
                    Console.Clear();
                    Console.WriteLine("Programma terminato");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Vuoi ripetere il programma? S/N");
                    risposta = Console.ReadLine();
                    Console.Clear();
                }
                

            
            


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
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                addizione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 2)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                sottrazione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 3)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                moltiplicazione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 4)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                if (numero2==0)
                {
                    Console.WriteLine("Errore! Un numero diviso per 0 è impossibile!");
                    Console.ReadLine();
                }
                else
                    divisione(ref numero1, ref numero2, out risultato);
            }

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
            {
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                addizione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 2)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                sottrazione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 3)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                moltiplicazione(ref numero1, ref numero2, out risultato);
            }
            else if (rispostaoperazione == 4)
            {
                Console.Clear();
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                double risultato;
                if (numero2 == 0)
                {
                    Console.WriteLine("Errore! Un numero diviso per 0 è impossibile!");
                    Console.ReadLine();
                }
                else
                    divisione(ref numero1, ref numero2, out risultato);
            }




        }

    }
}
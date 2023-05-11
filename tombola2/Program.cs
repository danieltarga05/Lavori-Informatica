using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tombola//non capito come colorare il numero estratto
{
    internal class Program
    {
        static string risposta1, risposta2;//la prima serve per la risposta se vuoi iniziare il gioco, la seconda se vuoi ripetere il programma
        static int[] numeritombola = new int[91];//array che serve per l'estrazione dei numeri

        static void Main(string[] args)
        {
            do
            {
                tabellone();
                estrazionenumeri();
                Console.WriteLine("Vuoi ricominciare il programma? S/N");
                risposta2 = Console.ReadLine();
            } while (risposta2 == "S");//ciclo dove finchè la risposta è ugale a S, il programma verrà ripetuto
            if (risposta1=="N")//se la risposta per l'inizio del programma è N, viene terminata l'applicazione
                Console.WriteLine("Applicazione terminata");
            if (risposta2=="N")//se la risposta per la ripetizione del programma è N, viene terminata l'applicazione
                Console.WriteLine("Applicazione terminata");



        }
        static void tabellone()//metodo per la scritta del tabellone
        {
            Console.WriteLine("| 1  | 2  | 3  | 4  | 5  | 6  | 7  | 8  | 9  | 10 |");
            Console.WriteLine("| 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |");
            Console.WriteLine("| 21 | 22 | 23 | 24 | 25 | 26 | 27 | 28 | 29 | 30 |");
            Console.WriteLine("| 31 | 32 | 33 | 34 | 35 | 36 | 37 | 38 | 39 | 40 |");
            Console.WriteLine("| 41 | 42 | 43 | 44 | 45 | 46 | 47 | 48 | 49 | 50 |");
            Console.WriteLine("| 51 | 52 | 53 | 54 | 55 | 56 | 57 | 58 | 59 | 60 |");
            Console.WriteLine("| 61 | 62 | 63 | 64 | 65 | 66 | 67 | 68 | 69 | 70 |");
            Console.WriteLine("| 71 | 72 | 73 | 74 | 75 | 76 | 77 | 78 | 79 | 80 |");
            Console.WriteLine("| 81 | 82 | 83 | 84 | 85 | 86 | 87 | 88 | 89 | 90 |");
        }
        static void estrazionenumeri()//metodo per l'estrazione casuale dei numeri
        {
            Console.WriteLine("Vuoi incominciare con l'estrazione? S/N");
            risposta1 = Console.ReadLine();
            while (risposta1=="")//finchè la risposta sarà uguale a stringa vuota, dovrai riscriverla correttamente
            {
               
                    Console.Clear();
                    Console.WriteLine("Errore, digita o S o N:");
                    risposta1 = Console.ReadLine();
                
            }
            if (risposta1 == "S")//se la risposta è S, allora inizierà l'estrazione
            {
                    Random numero = new Random();//variabile che serve per l'estrazione casuale dei numeri
                    for (int j = 1; j < numeritombola.Length; j++)
                    {
                        numeritombola[j] = numero.Next(1, 90);
                        Console.WriteLine($"E' uscito il numero {numeritombola[j]}");//ti scrive il numero uscito
                        Thread.Sleep(10000);

                    }
            
            }
            
        }
    }
}

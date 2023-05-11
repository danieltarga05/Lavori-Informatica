using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enalotto
{
    class Program
    {
        static int numeroEstrazioni;
        static string tmp;
        static int[] numeri = new int[90]; //array con tutti i numeri da 0 a 90 
        static int[] Estratti = new int[90]; //array che serve solo per conteggiare i numeri usciti a caso dall 'estrazione




        static void Main(string[] args)
        {
            //input 

            do // chiedere da tastiera il numero di estrazioni da fare con controlllo di eventuale mancato numero di estrazioni scelte
            {
                Console.WriteLine("inserire numero di estrazioni da eseguire in questa partita");
                tmp = Console.ReadLine();
                if (tmp == "")
                {
                    Console.Clear();
                    Console.WriteLine("bisogna giocare almeno un valore , modifichi la sua scelta");

                }

                else
                    numeroEstrazioni = Convert.ToInt32(tmp);

            } while (tmp == "");

            Console.WriteLine("");


            estrazionedeinumeri();



            Console.WriteLine(" ");
            for (int i = 0; i < numeri.Length; i++) // in questo si ciclo si controllano uno ad uno gli eleementi del vettore da 90 elementi
            {
                if (numeri[i] == 0) // condizione per scrivere i numeri estratti , i non estratti e quante volte si sono ripetute
                    Console.WriteLine($"numero: {i + 1} non estratto");
                else
                    Console.WriteLine($"numero: {i + 1}  estratto {numeri[i]} volte");
            }
            Console.ReadLine();
        }

        static void estrazionedeinumeri()
        {
            Random indice = new Random(); //variabile random per esrazione
            int numEstratto;

            Console.WriteLine("Numeri estratti: ");
            for (int i = 0; i < numeroEstrazioni; i++) //esatre i numeri a caso e li inserisce nel vettore 
            {
                Estratti[i] = numEstratto = indice.Next(1, 90); //estrazione dei numeri e l'inserimento nel apposito array
                numeri[numEstratto - 1]++; //incremento dell'elemento estratto
                Console.Write(numEstratto + " "); //visualizzazione numeri estratti
            }
        }
    }
}

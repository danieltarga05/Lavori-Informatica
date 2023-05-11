using static System.Console;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace bubble_e_selection_sort_con_menù
{
    internal class Program
    {
        static bool fine = false;//booleano che serve per sancire la fine del programma
        static bool completo = true;//booleano per decretare la fine del bubble sort
        static int[] nArray;//array contenente i nostri numeri che verranno ordinati
        static Random estratti = new Random();//qui verranno estratti i numeri che verranno ordinati in seguito
        static int lArray/*la lunghezza del  nostro array*/, casuale/*variabile che serve per l'estrazione dei numeri*/, scelta /*la scelta del tipo di ordinamento che vogliamo fare*/, numero/*variabile indispensabile per tutti e tre gli ordinamenti*/;
        static int contanumeri;


        static void Main(string[] args)
        {
            do
            {
                arraycasuale();
                menu();
                foreach (int i in nArray)
                {
                    WriteLine(i);
                    WriteLine($"cicli: {contanumeri}");
                }

            } while (!fine);
            

        }
        static void arraycasuale()//qui avviene la scelta random dei nostri numeri dell'array
        {
            WriteLine("Inserisci gli elementi del vettore:");
            lArray = Convert.ToInt32(ReadLine());
            nArray = new int[lArray];

            for (int i = 0; i < nArray.Length; i++)
            {
                casuale = estratti.Next(0, 80);
                nArray[i] = casuale;

            }
            for (int j = 0; j < nArray.Length; j++)
            {
                WriteLine($"L'array contiene il {nArray[j]}");
            }

        }
        static void menu()
        {
            string tmp;//stringa temporanea che ci servirà per il controllo di stringa vuota
            //menù
            ForegroundColor = ConsoleColor.Green;
            WriteLine(" ");
            WriteLine("TIPI DI ORDINAMENTO");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("1 Selection Sort");
            WriteLine("2 Bubble Sort");
            WriteLine("3 Insertion Sort");
            WriteLine("4 FINE");
            ResetColor();
            tmp = ReadLine();

            while (tmp == "")//controllo stringa vuota
            {
                WriteLine("Errore! Reinserisci il numero");
                tmp = ReadLine();
            }
            scelta = Convert.ToInt32(tmp);


            switch (scelta)//la scelta del tipo di ordinamento che vuoi fare
            {
                case 1: selectionsort(); break;
                case 2: bubblesort(); break;
                case 3: insertionsort(); break;
                case 4: WriteLine("programma terminato"); fine = true; break;
                default: WriteLine("Errore! Reinserisci il numero"); scelta = Convert.ToInt32(ReadLine()); break;
            }
            ReadLine();
            


        }
        static void selectionsort()//qui avviene l'ordinamento selection sort
        {

            contanumeri = 0;
            for (int j = 0; j < nArray.Length; j++)
                {
                contanumeri++;
                    for (int i = j + 1; i < nArray.Length; i++)
                    {
                    contanumeri++;
                        if (nArray[j] > nArray[i])
                        {
                            numero = nArray[j];
                            nArray[j] = nArray[i];
                            nArray[i] = numero;
                        }

                    }
                    WriteLine($"L'array contiene il {nArray[j]}");
                }
         
        }
        static void bubblesort()//qui avviene l'ordinamento bubble sort
        {
            contanumeri = 0;
            bool continua = true;

                for (int j = 0; j <= nArray.Length && continua; j++)
                {
                    contanumeri++;
                    continua = false;
                    for (int i = 0; i <= nArray.Length - 2; i++)
                    {
                    contanumeri++;
                        if (nArray[i] > nArray[i + 1])
                        {
                            numero = nArray[i + 1];
                            nArray[i + 1] = nArray[i];
                            nArray[i] = numero;
                            continua = true;
                        }

                    }
                }
                foreach (int i in nArray)
                    WriteLine($"L'array contiene il {i}");
                
            
        }
        static void insertionsort()//qui avviene l'ordinamento insertion sort
        {
            int valoredappoggio;//variabile d'appoggio per l'ordinamento cvorretto dei dati
            contanumeri = 0;
            


                for (int i = 1; i < nArray.Length; i++)
                {
                    
                    numero = nArray[i];
                    valoredappoggio = 0;
                    for (int j = i - 1; j >= 0 && valoredappoggio != 1;)
                    {
                        contanumeri++;
                        if (numero < nArray[j])
                        {
                            nArray[j + 1] = nArray[j];
                            j--;
                            nArray[j + 1] = numero;
                        }
                        else valoredappoggio = 1;

                    }
                } 
                foreach (int i in nArray)
                    WriteLine($"L'array contiene il {i}");
                
           

        }
     
    }
}

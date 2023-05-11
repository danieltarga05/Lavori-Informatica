using static System.Console;
using static System.Convert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votazioni
{


    internal class Program
    {
        static int votofinale;//variabile che è la nostra media complessiva
        static int numero_studenti;//il numero di studenti che ci sono in quella classe
        static string[] materie = new string[5] { "Matematica", "Italiano", "Storia", "Inglese", "Informatica" };//array dove abbiamo le nostre materie da dove faremo poi la media complessiva
        static string[] studenti = new string[numero_studenti];//array dove è presente il nome di ogni studente
        static int[,] voti = new int[numero_studenti, 5];//matrice che serve per il voto preso nella materia

        static void Main(string[] args)
        {
            Classe();
            Votazioni();
            Media();
        }
        static void Classe()//metodo dove inseriamo il numero e il nome dello studente
        {

            WriteLine("Inserisci numero di studenti");
            numero_studenti = ToInt32(ReadLine());//insermiento numero studente
            studenti = new string[numero_studenti];
            for (int i = 0; i < studenti.Length; i++)//finchè la nostra variabile k è più piccola della lunghezza dell'array "studenti", inseriremo il nome di ogni studente
            {

                WriteLine("Inserisci il nome di ogni studente:");
                studenti[i] = ReadLine();
                while (studenti[i] == "")//controllo stringa vuota
                {
                    Clear();
                    WriteLine("Errore! Inserisci il nome");
                    studenti[i] = ReadLine();

                }
            }
            
            
        }
        static void Votazioni()//metodo che ci permette l'inserimento dei voti per ogni singola materia
        {
            Clear();
            voti = new int[numero_studenti, materie.Length];
            for (int i = 0; i < numero_studenti; i++)//finchè la nostra costante i è più piccola del numero di studenti, verrà incrementata
            {

                for (int k = 0; k < materie.Length; k++)//finchè la nostra costante k è più piccola della lunghezza del vettore "materie", verrà incrementata
                {
                    Write($"L'alunno {studenti[i]} ha il seguente voto in {materie[k]}: ");
                    ForegroundColor=ConsoleColor.Red;
                    voti[i, k] = ToInt32(ReadLine());//inserimento voti per ogni singola materia
                    while (voti[i, k] > 10)//controllo del voto se è valido o no
                    {
                        Clear();
                        WriteLine("Errore, devi inserire un numero minore o uguale di 10!");
                        voti[i, k] = ToInt32(ReadLine());
                    }
                    ResetColor();
                }
                
                    
            }
            ReadLine();
        }
        static void Media()//metodo dove verrà visualizzata la media dello studente
        {
            for (int i = 0; i < numero_studenti; i++)//finchè la nostra costante i è più piccola del numero di studenti, verrà incrementata
            {



                int somma = 0;//variabile che somma tutti i voti presi per ogni materia


                for (int k = 0; k < materie.Length; k++)//finchè la nostra costante k è più piccola della lunghezza del vettore "materie", verrà incrementata
                {
                    somma = somma + voti[i, k];
                    votofinale = somma / 5;//il voto finale sarà uguale alla somma diviso il numero di materie, cioè 5

                }
                Clear();
                
            }
            foreach (string j in studenti)//ciclo dove abbiamo l'inserimento del nome dello studente e la media complessiva
            {
                WriteLine($"L'alunno {j} ha la media del {votofinale}");

            }
            ReadLine();
        }
    }

}

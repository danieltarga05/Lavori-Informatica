using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inserire_stringa_nel_vettore
{
    class Program
    {
        static string[] parole = new string[2];   //array dove verranno inserite le stringhe inserite da tastiera
        static string tmp = ""; //dichiarazione e assegnazione prima stringa
        static string tmp2 = "";//dichiarazione e assegnazione seconda stringa
        static void Main(string[] args)
        {
            string1();
            string2();
        }
        static void string1()
        {
            do//ciclo per far mettere una stringa valida e non stringa vuota
            {
                Console.WriteLine("Inserisci la prima stringa");
                tmp = (Console.ReadLine().ToUpper());//viene inseita la stringa a tua scelta
                if (tmp.Length < 10) //se la condizione è vera inserisce la stringa nella prima casella dell'array , se è falsa mi stampa a schermo "carattere non valido" e non la inserisce nell'array
                {
                    parole[0] = tmp;

                }
                else
                    Console.WriteLine("Carattere non valido");
            } while (tmp == "");
        }
        static void string2()
        {
            do //ciclo per far mettere una stringa valida e non stringa vuota
            {
                Console.WriteLine("Inserisci la seconda stringa");
                tmp2 = Console.ReadLine().ToUpper();//lettura stringa

                if (tmp2.Length < 10) //se la condizione è vera inserisce la stringa nella seconda casella dell'array , se è falsa mi stampa a schermo "carattere non valido" e non la inserisce nell'array
                {
                    parole[1] = tmp2;

                }
                else//condizione che mi stampa a schermo "carattere non valido"
                    Console.WriteLine("Il carattere non è valido");
                if (tmp == tmp2)//condizione se la prima e la seconda stringa sono scritte allo stesso modo , il programma lo rileva e stampa la stessa scrittura una volta sola 
                {
                    Console.WriteLine("Le due stringhe sono uguali");
                    Console.WriteLine(parole[0]);
                    Console.ReadLine();
                }
                else// altrimenti se sono diverse le scritture le stampa in due righe diverse
                {
                    Console.WriteLine(parole[0]);
                    Console.WriteLine(parole[1]);
                    Console.ReadLine().ToUpper();//visualizzo a schermo gli elementi
                }

            } while (tmp2 == "");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menù_grafico
{
    class Program
    {

        static string opzione1 = "1";
        static string opzione2 = "2";
        static string opzione3 = "3";
        static ConsoleKeyInfo tasto;
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            do
            {
                Console.WriteLine(opzione1);
                Console.WriteLine(opzione2);
                Console.WriteLine(opzione3);

                Console.SetCursorPosition(x, y);
                tasto = Console.ReadKey();

                if (tasto.Key == ConsoleKey.DownArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    y++;


                }
                else if (tasto.Key == ConsoleKey.UpArrow)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    y--;
                }
                Console.Clear();
            } while (tasto.Key != ConsoleKey.Enter);

        }
    }
}

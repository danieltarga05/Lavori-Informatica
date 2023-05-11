using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            string matita = ".";
            ConsoleKeyInfo tasto;

            Console.WindowWidth = 120;
            Console.WindowHeight = 30;

            do
            {
                tasto = Console.ReadKey(true);
               
                    if (tasto.Key == ConsoleKey.LeftArrow && x > 0)
                    {
                        Console.SetCursorPosition(x--, y);
                        Console.Write(matita);

                    }
                    else if (tasto.Key == ConsoleKey.RightArrow && x < 119)
                    {
                        Console.SetCursorPosition(x++, y);
                        Console.Write(matita);

                    }
                    else if (tasto.Key == ConsoleKey.DownArrow && y < 29)
                    {
                        Console.SetCursorPosition(x, y++);
                        Console.Write(matita);

                    }
                    else if (tasto.Key == ConsoleKey.UpArrow && y > 0)
                    {
                        Console.SetCursorPosition(x, y--);
                        Console.Write(matita);

                    }
                
                
                


            } while (tasto.Key != ConsoleKey.Escape);
        }
    }
}

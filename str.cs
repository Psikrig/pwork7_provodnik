using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwork_7__provodnik
{
    internal class str
    {
        public static int x;
        public static int strel(int z)
        {
            int pos = 0;
            int max = z;
            while (true)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(" ");
                if (key.Key == ConsoleKey.UpArrow && pos != 0)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Visual.Drivem();
                }
            }
            return pos;
        }
    }
}

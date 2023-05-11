using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.maze;
using System.Threading;
using System.Threading.Tasks;

namespace Game.Enemy
{
    class Print_enemy
    {
        public static void Print_enemy_(ref int count, ref int x, ref int y, ref bool running, maze_ v,bool check)
        {
            if(check==true)
            {
                Console.SetCursorPosition(x, 3);
                Console.Write("||");
                v.maze__[3, x] = "||";
                Console.SetCursorPosition(x, 4);
                Console.Write(".");
                v.maze__[4, x] = ".";
                Console.SetCursorPosition(x - 1, 3);
                Console.Write(" ");
                v.maze__[3, x - 1] = " ";
                Console.SetCursorPosition(x - 1, 4);
                Console.Write(" ");
                v.maze__[4, x - 1] = " ";
                Thread.Sleep(100);
                x++;
                count = 0;
            }
            else if(check==false)
            {
                running = true;

                Console.SetCursorPosition(x, 3);
                Console.Write("||");
                v.maze__[3, x] = "||";
                Console.SetCursorPosition(x, 4);
                Console.Write(".");
                v.maze__[4, x] = ".";
                Console.SetCursorPosition(x + 2, 3);
                Console.Write(" ");
                v.maze__[3, x + 2] = " ";
                Console.SetCursorPosition(x + 1, 4);
                Console.Write(" ");
                v.maze__[4, x + 1] = " ";
                Thread.Sleep(100);
                x--;
                if (x == 2)
                {
                    running = false;
                }
                count = 0;
            }

        }
    }
}

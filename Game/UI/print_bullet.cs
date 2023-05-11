using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Game.maze;

namespace Game.Bullet
{
    class print_bullet
    {
       public static void print_bullet_(ref int t, ref int b, int x, int y, ref bool run, maze_ v, ref int score,int returned)
        {
            if(returned==1)
            {
                Console.SetCursorPosition(b, t);
                Console.Write(".");
                v.maze__[t, b] = ".";
                Console.SetCursorPosition(b, t + 1);
                Console.Write(" ");
                v.maze__[t + 1, b] = " ";
                t--;
                Thread.Sleep(50);
            }
            else if(returned==2)
            {
                Console.SetCursorPosition(b, t + 1);
                Console.Write(" ");
                run = false;
                score++;
            }
            else
            {
                Console.SetCursorPosition(b, t + 1);
                Console.Write(" ");
                run = false;
            }
        }
    }
}

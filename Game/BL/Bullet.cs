using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Variables;
using Game.maze;

namespace Game.Bullet
{
    class Bullet_
    {
        public static int bullet(ref int t, ref int b, int x, int y, ref bool run, maze_ v, ref int score)
        {

            if (run == false)
            {
                b = x;
                t = y;
                run = true;
            }
            if (v.maze__[t - 1, b] == " ")
            {
                return 1;
            }

            else if (v.maze__[t - 1, b] != "#")
            {
                return 2;
            }
            return 3;
        }
    }
}

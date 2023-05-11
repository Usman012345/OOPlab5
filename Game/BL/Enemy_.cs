using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.maze;

namespace Game.Enemy
{
    class Enemy_
    {
       public static bool enemy__(ref int count, ref int x, ref int y, ref bool running, maze_ v)
        {
            if (x < 96 && running == false)
            {
                return true;
            }
            else if (x <= 96)
            {
                return false;
            }
            return true;
        }
    }
}

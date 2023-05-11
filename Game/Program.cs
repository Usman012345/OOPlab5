using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Game.Player;
using System.Runtime.InteropServices;
using EZInput;
using Game.maze;
using Game.Bullet;
using Game.Enemy;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
        maze_ v = new maze_();
          
            int option = 0;
            Console.WriteLine("1.Play");
            Console.WriteLine("2.Instructions");
            option = int.Parse(Console.ReadLine());
            
             if (option == 1)
                play(v);
        }
        static void play(maze_ v)
        {
            Console.Clear();
         int x = 15;
         int y = 15;
            player_ p = new player_(x,y);
            maze_.mazef(v);
            player(ref x,ref y,v);

        }
        static void player(ref int x,ref int y,maze_ v)
        {
            int b = 0;
            int t = 0;
            bool running = false;
            int i = 2;
            bool run = false;
            int j = x;
            int count = 0;
            int n = 5;
            int score=0;
          player_.player_char(x, y, v, n);
            while (true)
            {
                Console.SetCursorPosition(110, 5);
                Console.Write("Score: {0}",score);
                if ((Keyboard.IsKeyPressed(Key.Space)|| run==true))
                {
                    
                   bullet_(ref t,ref b, x, y,ref run,v,ref score);
                    
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                   player_.moveup(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                   player_.movedown(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    player_.moveleft(ref x, ref y, v);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                   player_.moveright(ref x, ref y, v);
                }
                count++;
                if (count == 3)
                {
                    enemy(ref count, ref i, ref j,ref running,v);
                }
                Thread.Sleep(100);
            }
                
            
        }
        static void bullet_(ref int t, ref int b, int x, int y, ref bool run, maze_ v, ref int score)
        {
            int returned;
           returned= Bullet_.bullet(ref t,ref b, x, y, ref run, v, ref score);
            if(returned==1)
            {
                print_bullet.print_bullet_(ref t, ref b, x, y, ref run, v, ref score,returned);
                
            }
            else if(returned==2)
            {
                print_bullet.print_bullet_(ref t, ref b, x, y, ref run, v, ref score,returned);

            }
            else
            {
                print_bullet.print_bullet_(ref t, ref b, x, y, ref run, v, ref score, returned);

            }
        }

        
        static void enemy(ref int count,ref int x,ref int y,ref bool running,maze_ v)
        {
            bool check;
          check= Enemy_. enemy__(ref count, ref x, ref y, ref running, v);

            if (check == true)
            {
                Print_enemy.Print_enemy_(ref count, ref x, ref y, ref running, v, check);

            }
            else if (check == false)
            {
                Print_enemy.Print_enemy_(ref count, ref x, ref y, ref running, v, check);
            }
       }
        
    }

    }

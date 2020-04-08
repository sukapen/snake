using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlimySnake
{
    public class Program
    {
        //static readonly int x = 69;
        //static readonly int y = 9;
        static void Main(string[] args)
        {
            //Console.CursorVisible = false;
            //Console.SetWindowSize(x + 1, y + 1);
            //Console.SetBufferSize(x + 1, y + 1);
            //Menu M = new Menu();
            //M.Present();
            Easy E = new Easy();
            do
            {
                E.UpdateMap();
                E.NewFood();
                E.ClearMap();
                E.MoveHero();
                E.GameOver();
            } while (E.end);
        }
    }
}


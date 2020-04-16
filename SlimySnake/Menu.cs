using System;
using System.Collections.Generic;
using System.Text;

namespace SlimySnake
{
    public class Menu
    {
        static readonly int x = 69;
        static readonly int y = 9;
        public void Present() 
        {
            Console.WriteLine(" ");
            Console.WriteLine(" █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█");
            Console.WriteLine(" █████████████████████████████▀█▀█▀█▀█▀█████████████████████████████");
            Console.WriteLine(" ████████████████████████████SLIMY SNAKE████████████████████████████");
            Console.WriteLine(" ████████████████████████████▄█▄█▄█▄█▄█▄████████████████████████████");
            Console.WriteLine(" ██■ ДЛЯ ВЫБОРА В МЕНЮ НАЖИМАЙТЕ НА НУЖНУЮ КНОПКУ ПЕРЕД ПУНКТОМ ■███");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████■ ДЛЯ ПЕРЕХОДА В ГЛАВНОЕ МЕНЮ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ ■███████");
            Console.WriteLine(" █▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                MainMenu();
            }
        }
        public void MainMenu()
        {
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            Console.WriteLine("");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" █████████████████████████ Q — НАЧАТЬ ИГРУ █████████████████████████");
            Console.WriteLine(" █████████████████████████ A — УПРАВЛЕНИЕ  █████████████████████████");
            Console.WriteLine(" █████████████████████████ Z — АВТОР       █████████████████████████");
            Console.WriteLine(" █████████████████■ ДЛЯ ВЫХОДА ИЗ ИГРЫ НАЖМИТЕ ESC ■████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Q)
            {
                Console.Clear();
                GameMenu();
            }
            else if (Choise.Key == ConsoleKey.A)
            {
                Console.Clear();
                Upra();
            }
            else if (Choise.Key == ConsoleKey.Z)
            {
                Console.Clear();
                Author();
            }
            else if (Choise.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Beep();
                Console.Clear();
                MainMenu();
            }
        }
        public void GameMenu()
        {
            Console.WriteLine("");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" █████████████████████████ Q — ЛЁГКИЙ      █████████████████████████");
            Console.WriteLine(" █████████████████████████ A — НОРМАЛЬНЫЙ  █████████████████████████");
            Console.WriteLine(" █████████████████████████ Z — СЛОЖНЫЙ     █████████████████████████");
            Console.WriteLine(" █████████████■ ДЛЯ ПЕРЕХОДА В ГЛАВНОЕ МЕНЮ НАЖМИТЕ ESC ■███████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Q)
            {
                Easy E = new Easy();
                do
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    E.UpdateMap();
                    E.NewFood();
                    E.ClearMap();
                    E.MoveHero();
                    E.GameOver();
                } while (E.end);
            }
            else if (Choise.Key == ConsoleKey.A)
            {
                Normal N = new Normal();
                do
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    N.UpdateMap();
                    N.NewFood();
                    N.ClearMap();
                    N.MoveHero();
                    N.GameOver();
                } while (N.end);
            }
            else if (Choise.Key == ConsoleKey.Z)
            {
                Hard H = new Hard();
                do
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    H.UpdateMap();
                    H.NewFood();
                    H.ClearMap();
                    H.MoveHero();
                    H.GameOver();
                } while (H.end);
            }
            else if (Choise.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Beep();
                Console.Clear();
                GameMenu();
            }
        }
        public void Author()
        {
            Console.WriteLine("");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████■ АВТОР ИГРЫ: Бледных Данил ■███████████████████");
            Console.WriteLine(" ███████████████████■      vk.com/sukapen       ■███████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" █████████████■ ДЛЯ ПЕРЕХОДА В ГЛАВНОЕ МЕНЮ НАЖМИТЕ ESC ■███████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Beep();
                Console.Clear();
                Author();
            }
        }
        public void Upra()
        {
            Console.WriteLine("");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████■ ДЛЯ УПРАВЛЕНИЯ ИСПОЛЬЗУЙТЕ СТРЕЛОЧКИ НА КЛАВИАТУРЕ ■██████");
            Console.WriteLine(" ███████■    ВАША ЦЕЛЬ - СЪЕСТЬ КАК МОЖНО БОЛЬШЕ ФРУКТОВ     ■██████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" █████████████■ ДЛЯ ПЕРЕХОДА В ГЛАВНОЕ МЕНЮ НАЖМИТЕ ESC ■███████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Beep();
                Console.Clear();
                Upra();
            }
        }
        public void GameOver()
        {
            Console.WriteLine("");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ████████████████████████■    GAME OVER    ■████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" █████████████■ ДЛЯ ПЕРЕХОДА В ГЛАВНОЕ МЕНЮ НАЖМИТЕ ESC ■███████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            Console.WriteLine(" ███████████████████████████████████████████████████████████████████");
            ConsoleKeyInfo Choise = new ConsoleKeyInfo();
            Choise = Console.ReadKey();
            if (Choise.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Beep();
                Console.Clear();
                GameOver();
            }
        }
    }
}


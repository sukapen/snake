using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    public class Osnova
    {
        static List<string[]> frame = new List<string[]>();
        static bool gameStatus = true;
        static string hero = "■";
        static string food = "♥";
        static string wall = "▄, █, ▀";
        static string empty = " ";
        static readonly int x = 20;
        static readonly int y = 20;
        public void Map10()
        {
            Console.SetWindowSize(x - 4, y - 4);
            Console.SetBufferSize(x - 4, y - 4);
            Console.CursorVisible = false;
            frame.Add(new string[] { " " });
            frame.Add(new string[] { " ", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", "■", " ", " ", " ", " ", " ", "♥", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀" });
            frame.Add(new string[] { " " });
            render();
            bool vs = false;
            while (gameStatus)
            {
                var KeyInfo = Console.ReadKey();
                movehero(KeyInfo);
                render();
            }
        }
        public void Map15()
        {
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            Console.CursorVisible = false;
            frame.Add(new string[] { " " });
            frame.Add(new string[] { " ", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", "■", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "♥", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀" });
            frame.Add(new string[] { " " });
            render();
            bool vs = false;
            while (gameStatus)
            {
                var KeyInfo = Console.ReadKey();
                movehero(KeyInfo);
                render();
            }
        }
        public void Map20()
        {
            Console.SetWindowSize(x + 5, y + 4);
            Console.SetBufferSize(x + 5, y + 4);
            Console.CursorVisible = false;
            frame.Add(new string[] { " " });
            frame.Add(new string[] { " ", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄", "▄" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", "■", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "♥", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "█", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "█" });
            frame.Add(new string[] { " ", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", "▀", });
            frame.Add(new string[] { " " });
            render();
            render();
            bool vs = false;
            while (gameStatus)
            {
                var KeyInfo = Console.ReadKey();
                movehero(KeyInfo);
                render();
            }
        }
        public void render()
        {
            Console.Clear();
            for (int i = 0; i < frame.Count; i++)
            {
                Console.WriteLine(string.Join("", frame[i]));
            }
        }
        static void Win()
        {
            Console.Beep();
            gameStatus = true;
            Console.Clear();
        }
        public void movehero(ConsoleKeyInfo keyInfo)
        {
            for (int i = frame.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < frame[i].Length; j++)
                {
                    if (frame[i][j] == hero)
                    {
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if ((i - 1) >= 0 && frame[i - 1][j] == empty)
                            {
                                frame[i][j] = empty;
                                frame[i - 1][j] = hero;
                                return;
                            }
                            else if ((i - 1) >= 0 && frame[i - 1][j] == food)
                            {
                                frame[i][j] = empty;
                                frame[i - 1][j] = hero;
                                Win();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            if ((i + 1) <= (frame.Count - 1) && frame[i + 1][j] == empty)
                            {
                                frame[i][j] = empty;
                                frame[i + 1][j] = hero;
                                return;
                            }
                            else if ((i + 1) <= (frame.Count - 1) && frame[i + 1][j] == food)
                            {
                                frame[i][j] = empty;
                                frame[i + 1][j] = hero;
                                Win();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            if ((j - 1) >= 0 && frame[i][j - 1] == empty)
                            {
                                frame[i][j] = empty;
                                frame[i][j - 1] = hero;
                                return;
                            }
                            else if ((j - 1) >= 0 && frame[i][j - 1] == food)
                            {
                                frame[i][j] = empty;
                                frame[i][j - 1] = hero;
                                Win();
                                return;
                            }
                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            if ((j + 1) <= (frame[i].Length - 1) && frame[i][j + 1] == empty)
                            {
                                frame[i][j] = empty;
                                frame[i][j + 1] = hero;
                                return;
                            }
                            else if ((j + 1) <= (frame[i].Length - 1) && frame[i][j + 1] == food)
                            {
                                frame[i][j] = empty;
                                frame[i][j + 1] = hero;
                                Win();
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
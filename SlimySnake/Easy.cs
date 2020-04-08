using System;
using System.Collections.Generic;
using System.Text;

namespace SlimySnake
{
    public class Easy
    {
        private List<int> snakeX = new List<int>();
        private List<int> snakeY = new List<int>();
        public bool end = true;
        private bool eating = false;
        private int eX, eY;
        private int endsnakeX, endsnakeY;
        private const int x = 10, y = 10;
        private double Time = 300;
        ConsoleKeyInfo KeyInfo = new ConsoleKeyInfo();
        private string[,] mass = new string[x,y];
        char snake = 'o';
        int heroX, heroY, foodX, foodY;
        Random rand = new Random();
        public Easy()
        {
            CompletionMap();
            Starting();
            Mapping();
        }
        private void Starting()
        {
            do
            {
                heroX = rand.Next(0, x);
                heroY = rand.Next(0, y);
                foodX = rand.Next(0, x);
                foodY = rand.Next(0, y);
            } while (heroX == foodX || heroX == foodY || heroY == foodY || heroY == foodX);
            snakeX.Add(heroX); 
            snakeY.Add(heroY);

            mass[snakeX[0], snakeY[0]] = snake.ToString();
            mass[foodX, foodY] = "*";
        }
        private void ReversX()
        {
            endsnakeX = snakeX[snakeX.Count - 1];
            endsnakeY = snakeY[snakeY.Count - 1];
            for (int i = snakeX.Count - 1; i > 0; --i)
            {
                snakeX[i] = snakeX[i - 1];
                snakeY[i] = snakeY[i - 1];
            }
        }
        public void CompletionMap()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.BackgroundColor = ConsoleColor.White;
                    mass[i, j] = " ";
                }
            }
        }
        public void Mapping()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(mass[i, j]);
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void UpdateMap()
        {
            Console.SetCursorPosition(foodY, foodX);
            Console.Write("*");
            for (int i = snakeY.Count - 1; i >= 0; --i)
            {
                Console.SetCursorPosition(snakeY[i], snakeX[i]);
                Console.Write("o");
            }

        }
        public void ClearMap()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
        }
        public void MoveHero()
        {
            switch (KeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    if (snakeX[0] > 0)
                    { ReversX(); snakeX[0]--; }
                    break;
                case ConsoleKey.LeftArrow:
                    if (snakeY[0] > 0)
                    { ReversX(); snakeY[0]--; }
                    break;
                case ConsoleKey.DownArrow:
                    if (snakeX[0] < x - 1)
                    { ReversX(); snakeX[0]++; }
                    break;
                case ConsoleKey.RightArrow:
                    if (snakeY[0] < y - 1)
                    { ReversX(); snakeY[0]++; }
                    break;
                default:
                    break;
            }
            Eating();
            UpdateSnake();
        }
        private void Eating()
        {
            if (eating)
            {
                Time = Time - 1;
                if (eY == endsnakeY && eX == endsnakeX)
                {
                    snakeY.Add(endsnakeY);
                    snakeX.Add(endsnakeX);
                    eating = false;
                }
            }
        }
        private void UpdateSnake()
        {
            if (snakeY.Count == snakeX.Count)
            {
                CompletionMap();
                mass[foodX, foodY] = "*";
                for (int i = 0; i < snakeX.Count; ++i)
                {
                    mass[snakeX[i], snakeY[i]] = snake.ToString();
                }
            }
        }
        public void NewFood()
        {
            System.Threading.Thread.Sleep(400);
            if (snakeX[0] == foodX && snakeY[0] == foodY)
            {
                eating = true;
                eX = foodX;
                eY = foodY;
                do
                {
                    foodX = rand.Next(0, x);
                    foodY = rand.Next(0, y);
                } while (snakeX[0] == foodX || snakeX[0] == foodY || snakeY[0] == foodY || snakeY[0] == foodX);
            }
        }
        public void GameOver()
        {
            for (int i = snakeX.Count - 1; i > 0; --i)
            {
                if (i > 0)
                {
                    if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
                    {
                        Console.WriteLine("Game Over");
                        end = false;
                        break;
                    }

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Osnova Game = new Osnova();
            Console.CursorVisible = false;
            Console.WriteLine("* Добро пожаловать в змейку! *");
            Console.WriteLine("* Для начала игры выбери сложность игры: *");
            Console.WriteLine("* 1 - лёгкая, карта 10 на 10 и медленная скорость; *");
            Console.WriteLine("* 2 - средняя, карта 15 на 15 и нормальная скорость; *");
            Console.WriteLine("* 3 - сложная, карта 20 на 20 и быстрая скорость; *");
            Console.WriteLine("* Введите цифру и нажмите Enter для выбора. *");
            char choise = Convert.ToChar(Console.ReadLine());
            switch (choise)
            {
                case '1':
                    Console.Clear();
                    Game.Map10();
                    Game.render();
                    break;
                case '2':
                    Console.Clear();
                    Game.Map15();
                    Game.render();
                    break;
                case '3':
                    Console.Clear();
                    Game.Map20();
                    Game.render();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}


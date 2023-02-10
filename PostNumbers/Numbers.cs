using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNumbers
{
    class Numbers
    {
        private ConsoleColor color;
        private Random rnd = new Random();

        public char[,] Number(char num)
        {
            char[,,] postNumbers = {{ { '*', '*', '*' }, { '*', ' ', '*' }, { '*', '*', '*' } }, { { ' ', ' ', '*' }, { ' ', '*', '*' }, { ' ', ' ', '*' } }, { { '*', '*', '*' }, { ' ', '*', ' ' }, { '*', '*', '*' } },
            { { '*', '*', '*' }, { ' ', '*', '*' }, { '*', '*', '*' } }, { { '*', ' ', '*' }, { '*', '*', '*' }, { ' ', ' ', '*' } },
            { { '*', '*', '*' }, { ' ', '*', ' ' }, { '*', '*', ' ' } }, { { '*', '*', '*' }, { '*', '*', ' ' }, { '*', '*', ' ' } },
            { { ' ', '*', '*' }, { ' ', ' ', '*' }, { ' ', ' ', '*' } }, { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } },
            { { ' ', '*', '*' }, { ' ', '*', '*' }, { ' ', ' ', '*' } } };

            char[,] number = new char[3, 3];

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    number[i, j] = postNumbers[Convert.ToInt32(num) - 48, i, j];
                }
            }

            return number;
        }

        public void Draw(char[,] array, int ras)
        {
            color = (ConsoleColor)rnd.Next(1, 15 + 1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(j + ras + 1, i + 2) ;
                    Console.Write(array[i, j]);
                }
            }
        }

        public void TranslationPostman(char[] number)
        {
            int ras = 0;

            for(int i = 0; i < number.Length;i++)
            {
                char[,] postNumbers = Number(number[i]);

                Draw(postNumbers, ras);

                ras += 4;
            }
        }
    }
}

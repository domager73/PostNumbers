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
            char[,] number = new char[3, 3];

            switch (num)
            {
                case '1':
                    {
                        char[,] number1 = { { ' ', ' ', '*' }, { ' ', '*', '*' }, { ' ', ' ', '*' } };

                        number = number1;
                        break;
                    }

                case '2':
                    {
                        char[,] number2 = { { '*', '*', '*' }, { ' ', '*', ' ' }, { '*', '*', '*' } };

                        number = number2;
                        break;
                    }

                case '3':
                    {
                        char[,] number3 = { { '*', '*', '*' }, { ' ', '*', '*' }, { '*', '*', '*' } };

                        number = number3;
                        break;
                    }

                case '4':
                    {
                        char[,] number4 = { { '*', ' ', '*' }, { '*', '*', '*' }, { ' ', ' ', '*' } };

                        number = number4;
                        break;
                    }

                case '5':
                    {
                        char[,] number5 = { { '*', '*', '*' }, { ' ', '*', ' ' }, { '*', '*', ' ' } };



                        number = number5;
                        break;
                    }


                case '6':
                    {
                        char[,] number6 = { { '*', '*', '*' }, { '*', '*', ' ' }, { '*', '*', ' ' } };


                        number = number6;
                        break;
                    }

                case '7':
                    {

                        char[,] number7 = { { ' ', '*', '*' }, { ' ', ' ', '*' }, { ' ', ' ', '*' } };
                        number = number7;
                        break;
                    }

                case '8':
                    {

                        char[,] number8 = { { '*', '*', '*' }, { '*', '*', '*' }, { '*', '*', '*' } };



                        number = number8;
                        break;
                    }

                case '9':
                    {
                        char[,] number9 = { { ' ', '*', '*' }, { ' ', '*', '*' }, { ' ', ' ', '*' } };
                        number = number9;
                        break;
                    }

                case '0':
                    {
                        char[,] number0 = { { '*', '*', '*' }, { '*', ' ', '*' }, { '*', '*', '*' } };

                        number = number0;
                        break;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotace
{
    class Program
    {
        static void Main(string[] args)
        {
            // odkaz https://stackoverflow.com/questions/42519/how-do-you-rotate-a-two-dimensional-array

            int velikost = 3;
            int[,] pole = new int[velikost,velikost];

            pole[2,0] = 1;

            vypsatpole(pole, velikost);

            bool rotovatdal = true;

            while (rotovatdal)
            {                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.R:
                        rotovat(pole, velikost);
                        Console.WriteLine();
                        vypsatpole(pole, velikost);
                        break;
                    default:
                        rotovatdal = false;
                        break;
                }                
            }
            
            Console.Read();
        }

        static void vypsatpole(int[,] poleprovypsani, int velikost)
        {
            for (int k = 0; k < velikost; k++)
            {
                for (int i = 0; i < velikost; i++)
                {
                    Console.Write(poleprovypsani[k, i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void rotovat(int[,] pole, int velikost)
        {
            int[,] rotovane = new int[velikost, velikost]; // popsáno v odstavci jak docílíme rotace

            for (int i = 0; i < velikost; i++)
            {
                for (int k = 0; k < velikost; k++)
                {
                    rotovane[i, k] = pole[velikost- k - 1, i];
                }
            } // popsáno v odstavci jak docílíme rotace

            inicializace(pole, velikost);

            for (int i = 0; i < velikost; i++)
            {
                for (int k = 0; k < velikost; k++)
                {
                    if (rotovane[i,k] == 1)
                    {
                        pole[i, k] = 1;
                    }
                }
            }

        }
        static void inicializace(int[,] pole, int velikost) 
        {
            for (int k = 0; k < velikost; k++)
            {
                for (int i = 0; i < velikost; i++)
                {
                    pole[k, i] = 0;
                }
            }
        }
    }
}

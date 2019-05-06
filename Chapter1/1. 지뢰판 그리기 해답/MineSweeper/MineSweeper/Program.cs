using System;

namespace MineSweeper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[,] mineItemArray = new char[9, 9]
            {
                { '0', '1', '1', '1', '0', '0', '1', '1', '1' },
                { '0', '1', '*', '1', '0', '0', '1', '*', '1' },
                { '0', '1', '1', '2', '1', '1', '1', '2', '2' },
                { '1', '1', '0', '2', '*', '2', '1', '*', '1' },
                { '*', '2', '1', '3', '*', '3', '2', '2', '1' },
                { '1', '2', '*', '2', '1', '2', '*', '1', '0' },
                { '1', '2', '2', '2', '1', '2', '1', '1', '0' },
                { '1', '*', '1', '1', '*', '2', '0', '0', '0' },
                { '1', '1', '1', '1', '1', '1', '0', '0', '0' },
            };

            for (int j = 0; j < mineItemArray.GetLength(0); j++)
            {
                for (int i = 0; i < mineItemArray.GetLength(1); i++)
                {
                    Console.Write($"{mineItemArray[j, i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace MineSweeper
{
    public class MineMap
    {
        private readonly MineItem[,] _mineItems;

        public int Width { get; }
        public int Height { get; }

        public MineItem this[int y, int x] => _mineItems[y, x];

        public MineMap(int width, int height)
        {
            Width = width;
            Height = height;

            _mineItems = new MineItem[Height, Width];

            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    _mineItems[j,i] = new MineItem { };
                }
            }


            
        }

        public void GenerateAllNearBombsCount()
        {
            throw new NotImplementedException();
        }
    }
}

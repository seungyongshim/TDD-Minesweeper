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
                    _mineItems[j, i] = new MineItem { };
                }
            }
        }

        public void GenerateAllNearBombsCount()
        {
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    if (_mineItems[j, i].IsBomb == true)
                    {
                        continue;
                    }

                    int nearBombCount = 0;

                    if (j - 1 >= 0)
                    {
                        if (i - 1 >= 0)
                        {
                            if (_mineItems[j - 1, i - 1].IsBomb == true)
                            {
                                nearBombCount++;
                            }
                        }

                        if (_mineItems[j - 1, i].IsBomb == true)
                        {
                            nearBombCount++;
                        }

                        if (i + 1 < Width)
                        {
                            if (_mineItems[j - 1, i + 1].IsBomb == true)
                            {
                                nearBombCount++;
                            }
                        }
                    }
                    if (i - 1 >= 0)
                    {
                        if (_mineItems[j, i - 1].IsBomb == true)
                        {
                            nearBombCount++;
                        }
                    }

                    if (i + 1 < Width)
                    {
                        if (_mineItems[j, i + 1].IsBomb == true)
                        {
                            nearBombCount++;
                        }
                    }

                    if (j + 1 < Height)
                    {
                        if (i - 1 >= 0)
                        {
                            if (_mineItems[j + 1, i - 1].IsBomb == true)
                            {
                                nearBombCount++;
                            }
                        }

                        if (_mineItems[j + 1, i].IsBomb == true)
                        {
                            nearBombCount++;
                        }

                        if (i + 1 < Width)
                        {
                            if (_mineItems[j + 1, i + 1].IsBomb == true)
                            {
                                nearBombCount++;
                            }
                        }
                    }

                    _mineItems[j, i].NearBombsCount = nearBombCount;
                }
            }
        }
    }
}

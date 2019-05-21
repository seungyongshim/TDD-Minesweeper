using System;

namespace MineSweeper
{
    public class MineItem
    {
        public bool IsBomb { get; set; }
        public bool IsCovered { get; set; } = true;
        public int NearBombsCount { get; set; }

        public char Value
        {
            get
            {
                if (IsBomb)
                {
                    return '*';
                }
                else
                {
                    return Convert.ToChar('0' + NearBombsCount);
                }
            }
        }
    }
}

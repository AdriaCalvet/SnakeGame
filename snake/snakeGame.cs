﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace snake
{
    public enum DireccioSnake
    {
        Dreta,
        Esquerre,
        Avall,
        Amunt
    }
    class snakeGame
    {
        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;

        Point capSerp = new Point(0, 0);
        DireccioSnake direccio = DireccioSnake.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake Direccio { get => direccio; set => direccio = value; }

        internal void moure()
        {
            capSerp.Y++;
        }
    }
}

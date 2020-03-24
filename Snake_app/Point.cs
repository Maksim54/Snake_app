﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_app
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public bool isPoison;
        public Point(int x_, int y_, char sym_, bool isPoison)
        {
            x = x_;
            y = y_;
            sym = sym_;
            this.isPoison = isPoison;
        }
        public void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace laba4
{
    class TradeCentr : Bild
    {
        public sealed override int Long { get; set; }
        public sealed override int Width { get; set; }
        public sealed override int Height { get; set; }

        public override int Volume(int Long, int width, int height)
        {
            return Long * width * height;

        }

        public TradeCentr(int l, int w, int h)
        {
            Long = l;
            Width = w;
            Height = h;
        }

        public void Print()
        {
            Console.WriteLine($"Это торговый центр.\nДлинна помещения составляет {Long} Ширина {Width} и высота {Height}\nПри этом обьем помещения равен {Volume(Long,Width,Height)}");
        }

        public TradeCentr() : this(1, 1, 1)
        {
        }


       


    }
}

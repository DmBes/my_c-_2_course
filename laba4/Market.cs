using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Market: TradeCentr
    {
        public int floor; 

        public Market(int l, int w, int h, int f) : base(l, w, h)
        {
            floor = f;
        }

        public override int Volume(int Long, int width, int height)
        {
            return base.Volume(Long, width, 100);
        }

        public new void Print()
        {
            Console.WriteLine($"Это супермаркет со следующими характеристиками\n"+
                              $"Длинна ={Long}, Ширина = {Width}, Высота ={Height}, Этаж ={floor}");
        }
    }

}

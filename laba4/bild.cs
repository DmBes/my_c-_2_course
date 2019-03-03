using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public abstract class Bild
    {
        public abstract int Long { get; set; }
        public abstract int Width { get; set; }
        public abstract int Height { get; set; }

        public abstract int Volume (int Long, int width, int height);

    }
}

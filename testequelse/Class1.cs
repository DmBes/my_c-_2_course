using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testequelse
{
    class two
    {
        public int x;
        public int y;


        public two(int a, int b)
        {
            x = a;
            y = b;
        }
        public two() : this(0, 10) { }


        public override bool Equals(object obj)
        {
            //if (obj.GetType() != this.GetType()) return false;
            if (obj is int) return ((int)obj) == this.x;
            if (obj is two) return ((two)obj).x == this.x;
            if (obj is one) return ((one) obj).Fname == this.x.ToString();
            return false;
        }

        
    }
}

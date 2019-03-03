using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new2
{
    class Man : People
    {


        public override void move()
        {
            Console.WriteLine("Я мужик {0}. Производный класс", nameIs);
        }

        //public new void move()
        //{
        //    Console.WriteLine("Я мужик {0}. Производный класс", nameIs);
        //}

        public Man(int x) : base(x)
        {

        }

        public new object Clone()
        {
            return new Man(this.nameIs);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace new2
{
    class People : Imove, ICloneable, IComparable <People>
    {
        public int nameIs;

        //public virtual void move()
        //{
        //    Console.WriteLine("Я человек {0}  базовый класс", nameIs);

        //}
        public void move()
        {
            Console.WriteLine("Я человек {0}  базовый класс", nameIs);
        }

        public People(int name)
        {
            nameIs = name;
        }


        public object Clone()
        {
            return new People(this.nameIs);
        }


        public int CompareTo(People obj)
        {
            People temp = obj as People;
            if (temp != null) return this.nameIs.CompareTo(temp.nameIs);
            else
            {
                throw new ArgumentException("Parametr not is People");
            }
        }
    }
}

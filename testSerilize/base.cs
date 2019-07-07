using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSerilize
{
    
    class base_class: IComparable
    {
        public string base_string;
        public int base_int;

        public base_class(string s, int i)
        {
            base_string = s;
            base_int = i;
        }
        public base_class(): this("base", 0) { }

        public void Print()
        {
            Console.WriteLine("Я базовый класс {0} и {1}",base_string,base_int);
        }

        public int CompareTo(object obj)
        {
          return this.base_int.CompareTo(((base_class) obj).base_int);
        }
    }

    class derived_class: base_class
    {
        public string derived_string;

        public derived_class(string sd, string sd1, int i) : base(sd, i)
        {
            derived_string = sd1;
        }
        public derived_class(): this("Derived","Тест", 100) { }
        public new void Print() {
            Console.WriteLine("Я производный класс {0} и {1}", base_string, base_int);
        }

    }

}

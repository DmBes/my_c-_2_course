using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSerilize
{
    class Program
    {
        static void Main(string[] args)
        {
            Action pe4at = () =>
            {
                Console.WriteLine("Anonim");
                Console.ReadKey();
            };

            derived_class first = new derived_class();
            base_class second = new base_class();
            List<base_class> MyList = new List<base_class>(){first,second};

            Jobs<base_class> Myobj = new Jobs<base_class>(MyList);
            Console.WriteLine("The End");
            pe4at();
            Myobj.per = 3;

        }
    }
}

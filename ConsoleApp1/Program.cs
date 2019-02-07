using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();
            car1.print();
            bool x = car1.break_out_wheel();
            Cars car2 = new Cars("audi", "a6", -1, -40, -10, "diesel",
                new double[4] { 1.0, 2.0, 3.0, 4.1 });
            car2.print();
            Cars car3 = new Cars("vaz","2101");
            car3.print();

            Cars speed_max = Cars.Get_Cars(car1, car2, car3);
            speed_max.print();
            
            
            Console.ReadKey();
 
            
        }
    }
}

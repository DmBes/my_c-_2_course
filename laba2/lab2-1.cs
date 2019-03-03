using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {/*


        */
        static void Main(string[] args)
        {
            int c;
            rational obj1 = new rational(50, 2);
            rational obj2 = new rational(10,2);
            //var obj3 = new rational(20, 10);
            //obj3.Norm();
           // Console.WriteLine(obj3);
            //obj2.print();
            //obj1.ToString();
            
            

            //rational obj4 = obj3 + obj2;
            //rational obj5 = obj3 - obj2;
            //rational obj6 = obj3 * obj2;
            //rational obj7 = obj3 / obj2;
            //Console.WriteLine( obj1);
            c = obj1;
            //Console.ReadKey();
            Console.WriteLine(c);


            obj1.print();
            //obj1[1] = 30;
            //obj1.print();
           //  obj3.print();
            //obj4.print();
            //obj5.print();
            //obj6.print();
            //obj7.print();

            Console.ReadKey();
        }
    }
}




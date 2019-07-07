using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Выбрать любой класс из предыдущих работ.
                Добавить 2 события – с параметрами и без параметров.
                Создать несколько объектов класса и назначить им различные обработчики событий:
                ●	Статический метод любого класса
                ●	Экземплярный метод собственного класса
                ●	Анонимный делегат
                ●	Лямбда-выражение

             */

            #region Create Object

            

            Kiosk BelsouzDryk = new Kiosk("БелСоюздрук","Рокосовского", 300, 2);
            Kiosk BelsouzDryk1 = new Kiosk();
            Kiosk BelsouzDryk2 = new Kiosk("БелСоюздрук", "Рокосовского", 300, 2);
            Kiosk BelsouzDryk3 = new Kiosk("БелСоюздрук", "Рокосовского", 400, 5);
            Kiosk BelsouzDryk5 = new Kiosk("БелСоюздрук", "Рокосовского", 300, 8);
            Kiosk BelsouzDryk6 = new Kiosk();
            Kiosk BelsouzDryk7 = new Kiosk("БелСоюздрук", "Рокосовского", 300, 9);
            Kiosk BelsouzDryk8 = new Kiosk("БелСоюздрук", "Рокосовского", 400, 10);
            //List<Kiosk> arr_Kiosk = new List<Kiosk>() { BelsouzDryk8, BelsouzDryk, BelsouzDryk1, BelsouzDryk2, BelsouzDryk3, BelsouzDryk5, BelsouzDryk6, BelsouzDryk7 };
            //Console.WriteLine(BelsouzDryk.Equals(BelsouzDryk2));
            //Console.WriteLine(BelsouzDryk.Equals(BelsouzDryk1));
            //Console.WriteLine(BelsouzDryk > BelsouzDryk3);
            #endregion




            //Console.WriteLine(BelsouzDryk);
            MyDelegate_Print dele_print = new MyDelegate_Print(BelsouzDryk.Print);
            MyDelegate_Print dele_print1 = new MyDelegate_Print(BelsouzDryk.Print);
            MyDelegate_Print dele_print2 = dele_print + dele_print1;
            dele_print2 = dele_print2 - dele_print1;
            dele_print2.Invoke();
            MyDelegate_Print del = BelsouzDryk.Print;
            del.Invoke();

            #region Лямбды выражения и функции

            MyDelegate_return_int average = count_days => Convert.ToInt32(BelsouzDryk.ValueProfit / count_days);
            MyDelegate_return_int average2 = (count_days2) => { return count_days2 * 2; };
            MyDelegate_return_int average3 = delegate (int Count_days3) { return Count_days3 * 2; }  ;
            int perem = average.Invoke(40);


            MyDelegate_Print print_dele = () => BelsouzDryk.Print();
            MyDelegate_Print print_dele2 = delegate () { BelsouzDryk.Print(); };
            MyDelegate_return_int oe = (c) => BelsouzDryk.count_kiosk / 2;
            #endregion





            //dele_print();                  //Старый способ вызова делегата. 
            dele_print.Invoke();              // Вызов делегата
            MyDelegate_return_int dele_return_int = new MyDelegate_return_int(BelsouzDryk.AveregeValue);
            dele_return_int.Invoke(30);
            
            int x = BelsouzDryk.AveregeValue(30);
            BelsouzDryk.Print();
  
           


        }


    }
}

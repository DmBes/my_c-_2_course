using System;
using System.Collections;
using System.Collections.Generic;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stars s = new Stars();
            s.St();

            #region kiosk

            

     
            //Create Kiosl

            Kiosk belsouz = new Kiosk(4,5,"Skorini","Belsouz");


            //Print Kiosk

            belsouz.Print();

            s.St();

            #endregion

            #region create Worker , Clone Worker and Trade_center

            
            Worker ivan = new Worker("Иван", 100);
            ivan.Print();
            
            Worker ia = (Worker)ivan.Clone();   //Create Clone

            s.St();

            TradeCentr euroopt = new TradeCentr(100,200,"Сердича","Евроопт", "Иван",500);
            euroopt.Print();

            s.St();
            #endregion

            #region Склеивание и кастинг Euroopt

            //((Imagaz)Euroopt).Print();
            //((Ipeople)Euroopt).Print();               //Склеивание

            //Euroopt.PrintMagaz();
            //Euroopt.PrintPeople();

            #endregion




            #region Create object Euroopt,Kiosk, People and arrayStack




            TradeCentr euroopt2 = new TradeCentr(200, 500, "Рокосовского", "Еврооп_Рокосовсого", "Федор", 600);
            TradeCentr euroopt3 = new TradeCentr(300, 600, "Центральная", "вроопт_центральная", "Дима", 700);
            TradeCentr euroopt4 = new TradeCentr(400, 700, "Ленина", "Ероопт_Ленина", "Сергей", 800);
            TradeCentr euroopt5 = new TradeCentr(1, 100, "Кижеватого", "Евроопт_Кижеватого", "Руслан", 50);
            Kiosk belsouz1 = new Kiosk(14, 15, "Победителей", "BelsouzКижев4атого");
            Kiosk belsouz2 = new Kiosk(24, 25, "Одоевского", "Belsouz_Кижев6атого");
            Kiosk belsouz3 = new Kiosk(34, 35, "Лермонтова", "Belsouz_Лермонтора");
            Kiosk belsouz4 = new Kiosk(3, 1, "Есенина", "Belsouz_Есенина");
            IPeople fedor = new Worker("Федор", 1000);
            IPeople aleksandr = new Worker("Александр", 555);
            IPeople vitya = new Worker("Витя", 777);
            TradeCentr euroopt6 = new TradeCentr(1, 100, "ябеда", "ябеда", "Руслан", 50);
            Stack mystack = new Stack();
            mystack.StackAdd((object)euroopt2, (object)euroopt3, (object)euroopt4, (object)euroopt5, (object)belsouz1, (object)belsouz2);
            mystack.StackAdd((object)belsouz3);
            mystack.StackAdd((object)belsouz4);
            s.Pr();
            short ssss = mystack.GetNum;

            


            IMagaz[] myArrayMagaz = new IMagaz[]  // Создание массива типа Imagaz
                {euroopt2, euroopt5, belsouz2,euroopt3, belsouz3, euroopt4, belsouz4};


            s.Pr();
            foreach (IMagaz tmp in myArrayMagaz)
            {
                tmp.Print();
                Console.WriteLine("\n");


                if (tmp is TradeCentr)
                {
                    ((TradeCentr) tmp).Print();
                }
                else
                {
                    ((Kiosk)tmp).Print();
                }
                s.St();
            



            #endregion




            //for (int i = 0; i < ssss; i++)
            //{
            //    object temp = Mystack.StackDelete();
            //    if (temp is Trade_centr)
            //    {
            //        ((Trade_centr)temp).Print();
            //        s.St();
            //    }
            //    else
            //    {
            //        ((Kiosk)temp).Print();
            //        s.St();
            //    }

            }


            #region Sorted Array (CompareTo and Comparible)




            System.Console.Clear();
            Array.Sort(myArrayMagaz);  // Сортировка Массива Comparible

            foreach (var x in myArrayMagaz)
            {
                x.Print();
                Console.WriteLine($"{x.Longest}");
                
            }

            s.St();

            Array.Sort(myArrayMagaz,new KioslCompare());   // CompareTo
            foreach (var x in myArrayMagaz)
            {
                x.Print();
                Console.WriteLine($"{x.Longest}");

            }


            #endregion


            Console.ReadKey();

            //Лабараторная работа №6

            Console.Clear();
            ArrayList list1 = new ArrayList() { euroopt2,fedor, belsouz1, euroopt6, belsouz2, euroopt3, belsouz3, euroopt4, belsouz4, euroopt5 };
            Lab6 lb6 = new Lab6(list1);

            Console.ReadKey();



        }

    }
}

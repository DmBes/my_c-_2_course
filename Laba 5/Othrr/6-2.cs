using System;
using System.Collections.Generic;

namespace Laba_5
{
    class Class6_2 <T> where T : Kiosk, new(int , int, string, string)
    {
        Stars s = new Stars();
        protected List<T> Arr;
        protected bool Cikle = true;
        private int long_6;
        private int wingth_6;
        private string names_6;
        private string adress_6;
        private int IndexForAdd;
        private Kiosk K = new Kiosk();

        //TOdo Почему возможно только такое создание объекта с кастом Т
        T Kioskprimer = (T) new Kiosk(10,100,"Маринкевича","янычар");
        private T ars = (T)new T ( (10, 200, "dsa", "dsa");



        public Class6_2 (List<T> x)
        {
            Arr = x;
            Arr.Insert(2,Kioskprimer);

            while (Cikle)
            {
                Console.Clear();
                Menu myMenu = new Menu();
                switch (myMenu.SetChoice)
                {
                    case 1:         //1 – просмотр коллекции");
                        Console.Clear();
                        if (Arr.Count > 0)
                        {
                            foreach (var ele in Arr)
                            {
                                if (ele is TradeCentr)
                                {
                                    //((TradeCentr)ele).Print();
                                    (ele as TradeCentr).Print();
                                }

                                else if (ele is Worker) (ele as Worker).Print();

                                else
                                {
                                    ((Kiosk)ele).Print();
                                }
                                s.St();
                            }
                            s.Pr();
                        }

                        Console.ReadKey();
                        break;
                    case 2:         //("2 – добавление элемента");
                        addKiosk();
                        Arr.Add((T) new Kiosk(long_6, wingth_6, adress_6, names_6));
                        break;
                    case 3:         //  ("3 – добавление элемента по указанному индексу");
                        SetIndex();
                        addKiosk();
                        Arr.Insert(IndexForAdd, (T) new Kiosk(long_6, wingth_6, adress_6, names_6));
                        break;
                    case 4:         // ("4 – нахождение элемента с начала коллекции");
                        //string tempstr = Console.ReadLine().ToLower();
                        
                        Console.WriteLine("Элемент находится под номером {0}", Arr.IndexOf(Kioskprimer));
                        Console.ReadKey();
                        break;
                    case 5:          // ("5 – нахождение элемента с конца коллекции");
                        //tempstr = Console.ReadLine().ToLower();
                        Console.WriteLine("Элемент с конца находится под номером {0}", Arr.LastIndexOf(Kioskprimer));
                        Console.ReadKey();
                        break;
                    case 6:       // ("6 – удаление элемента по индексу");
                        SetIndex();
                        Arr.RemoveAt(IndexForAdd);
                        break;
                    case 7:         //("7 – удаление элемента по значению");
                        //string tempstr = Console.ReadLine().ToLower();
                        Arr.Remove(Kioskprimer);
                        break;
                    case 8:          //("8 – реверс коллекции");
                        Arr.Reverse();
                        break;  //
                    case 9:     //("9 – сортировка");
                        Arr.Sort();
                        //Console.Clear();
                        //foreach (var papapa in Arr)
                        //{
                        //    if (papapa is TradeCentr) ((TradeCentr)papapa).Print();
                        //    if (papapa is Kiosk) ((Kiosk)papapa).Print();
                        //    if (papapa is Worker) ((Worker)papapa).Print();
                        //    s.St();
                        //}

                        //Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        foreach (var x1 in Arr)
                        {
                            if (x1 is TradeCentr)
                            {
                                // TODO явное приведение
                                (x1 as TradeCentr).Print_salary();

                            }
                            if (x1 is Kiosk) ((Kiosk)x1).Print();
                            if (x1 is Worker) (x1 as Worker).Print();
                            s.St();
                        }

                        Console.ReadKey();

                        break;
                    default:
                        Cikle = false;
                        break;
                }





            }



        }

        public Class6_2() : this(new List<T>())
        {

        }

        public void addKiosk()
        {
            Console.WriteLine("Введите параметры добавления киоска");

            do
            {
                Console.WriteLine("Введите длинну больше 0");
                long_6 = Convert.ToInt32(Console.ReadLine());
            } while (long_6 < 1);

            do
            {
                Console.WriteLine("Введите ширину больше 0");
                wingth_6 = Convert.ToInt32(Console.ReadLine());
            } while (wingth_6 < 1);

            Console.WriteLine("Введите название обьекта");
            names_6 = Console.ReadLine();
            Console.WriteLine("Введите Адресс обьекта");
            adress_6 = Console.ReadLine();



        }


        public void SetIndex()
        {
            Console.WriteLine("Введите индекс от 0 до {0}:  ", Arr.Count);
            do
            {
                IndexForAdd = Convert.ToInt32(Console.ReadLine());
                if (IndexForAdd < 0) Console.WriteLine(" ВВедите число от единицы до {0}", Arr.Count);

            } while (IndexForAdd <= 0 && IndexForAdd < Arr.Count);
        }



    }
}

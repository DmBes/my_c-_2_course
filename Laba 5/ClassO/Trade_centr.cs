using System;



namespace Laba_5
{
    class TradeCentr : Kiosk, IPeople, IMagaz, IComparable
    {


        public string NamePeople { get ; set ; }
        public int Salary { get; set ; }

        public TradeCentr() : base() { }

        public TradeCentr(int longest, int windth, string adres, string nameObj, string nameWorker, int salaryWorker) : base(longest, windth, adres, nameObj)
        {
            NamePeople = nameWorker;
            Salary = salaryWorker;

        }

        public TradeCentr(int longest, int windth, string adres, string nameObj, string nameTrader) : base(longest, windth, adres, nameObj)
        {

        }



        #region Склеивание





        public void Print()
        {
            Console.WriteLine($"Я торговый центр {NameObject} находящийся по адресу {AdressObject}. \nДлинна {Longest} и ширина {Windth}, площадь составляет {Area(Longest, Windth)} . \nТут трудится сотрудник {NamePeople} с заработной платой {Salary}");
        }

        public void Print_salary()
        {
            Console.WriteLine("Заработная плата сотрудника {1} составляет {0}", Salary, NamePeople);
        }

        #endregion

        #region Кастинг



        void IPeople.Print()
        {
            Console.WriteLine("Я человек  Иван c заработной платой");
        }



        void IMagaz.Print()
        {
            Console.WriteLine($"Я магазин {NameObject} по адресу {AdressObject}");
        }




        #endregion


        #region Кастинг  + обвертывание  (кастинг находится на этапе выше)

        public void PrintPeople()
        {
            ((IPeople)this).Print();
        }

        public void PrintMagaz()
        {
            ((IMagaz)this).Print();
        }


        #endregion

        //public int CompareTo(object obj)
        //{
        //    TradeCentr temp = obj as TradeCentr;
        //    if (temp != null)
        //    {
        //        Console.WriteLine($"Я метод новый {temp.Longest}");
        //        return this.Longest.CompareTo(temp.Longest);


        //    }


        //    throw new Exception("no class in Trade_Center");
        //}

    }
}

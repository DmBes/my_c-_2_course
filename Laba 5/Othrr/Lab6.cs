using System;
using System.Collections;


namespace Laba_5
{
    class Lab6
    {
        protected ArrayList Arr;
        protected bool Cikle = true;
        
        


        public Lab6(ArrayList x)
        {
            Arr = x;

            while (Cikle)
            {
                Console.Clear();
                Menu myMenu = new Menu();
                switch (myMenu.SetChoice)
                {
                    case 1:         //1 – просмотр коллекции");

                        break;
                    case 2:         //("2 – добавление элемента");
                        Arr.Add(new Kiosk());
                        break;
                    case 3:         //  ("3 – добавление элемента по указанному индексу");
                        Arr.Insert(1, new Kiosk());
                        break;
                    case 4:         // ("4 – нахождение элемента с начала коллекции");

                        break;
                    case 5:          // ("5 – нахождение элемента с конца коллекции");

                        break;
                    case 6:       // ("6 – удаление элемента по индексу");
                        Arr.Add(new Kiosk());
                        break;
                    case 7:         //("7 – удаление элемента по значению");
                        Arr.Add(new Kiosk());
                        break;
                    case 8:          //("8 – реверс коллекции");
                        Arr.Reverse();
                        break;  //
                    case 9:     //("9 – сортировка");
                        Arr.Sort();
                        break;
                    case 10:
                        Arr.Add(new Kiosk()); //10 – выполнение методов всех объектов,
                                                //поддерживающих Interface"
                        break;
                    default:
                        Cikle = false;
                        break;
                }

 



            }
            
           

        }

        public Lab6() : this(new ArrayList())
        {
            
        }


    }
}

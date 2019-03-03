using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Menu
    {
        private short _choice;

        public short SetChoice
        {
            set {
                if ( value >= 0 &&  value <= 10)
                {
                    _choice = value;
                    
                 }
                else
                {
                    Console.WriteLine("Введите верное значение от 0 до 10");
                    SetChoice = Convert.ToInt16(Console.ReadLine());
                }
                }

            get => _choice;
        }


        public Menu(short ch)
        {
            SetChoice = ch;
            
        }


        public Menu()
        {
            OutputScreen();
            

        }

        public void OutputScreen()
        {
            Console.WriteLine("1 – просмотр коллекции ");
            Console.WriteLine("2 – добавление элемента(используйте конструктор с 1 - 2 параметрами)");
            Console.WriteLine("3 – добавление элемента по указанному индексу");
            Console.WriteLine("4 – нахождение элемента с начала коллекции(переопределить метод Equals или оператор == для вашего класса – сравнение только по полю name)");
            Console.WriteLine("5 – нахождение элемента с конца коллекции");
            Console.WriteLine("6 – удаление элемента по индексу");
            Console.WriteLine("7 – удаление элемента по значению");
            Console.WriteLine("8 – реверс коллекции");
            Console.WriteLine("9 – сортировка");
            Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих Interface2");
            Console.WriteLine("0 – выход");
            Console.Write("Введите значение: ");
            SetChoice = Convert.ToInt16(Console.ReadLine());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    /*
     * Для строки StringBuilder реализуйте следующие действия:
1 – ввод строки с клавиатуры (указывать размер)
2 – вывод строки
3 – после указанного символа каждый раз вставить *
4 – заменить один символ на другой
5 – удалить все вхождения указанной подстроки
0 - выход

     */
    class chapter3
    {
        IntMenu Menu = new IntMenu();
        private StringBuilder _str;
        private int UserChoice { get; set; }  // Переменная с пользовательским значением

        // Geter i Seter + Проверка на ввод пользовательского значения
        public int SetChoice
        {
            get => UserChoice;
            set
            {
                while (value < 0 || value > 5)
                {
                    Console.Write("Введите корректиное значение от 0 до 9 ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                UserChoice = value;


            }
        }


        public chapter3()
        {

            SetChoice = 1;
            while (SetChoice > 0)
            {
                Menu.PrintMenu_ch2();
                SetChoice = Convert.ToInt32(Console.ReadLine());

                switch (UserChoice)
                {
                    case 1:  //ввод строки с клавиатуры (указывать размер)
                        Console.WriteLine("Введите слово");
                        string param1 = Console.ReadLine();

                        int param2 = -1;
                        while (param2 < 0)
                        {
                            Console.WriteLine("Введите значение от единицы до ...");
                            param2 = Convert.ToInt32(Console.ReadLine());
                        }
                        _str = new StringBuilder(param1,param2);
                        break;

                    case 2:  //вывод строки
                        Menu.separator();
                        Console.WriteLine(_str);
                        Console.ReadKey();
                        
                        break;
                    case 3: //после указанного символа каждый раз вставить *
                        Console.Write("Введите номер после которого будет вставлено \"*\" : ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        string temple = "*";
                        _str.Insert(c, temple);
                        

                        break; 
                    case 4:  //заменить один символ на другой
                        Console.Write("Введите символ замены  (что  нужно заменить): ");
                        string x = Console.ReadLine();
                        Menu.separator();
                        Console.Write("Введите символы для замены (на что нужно заменить): ");
                        string x1 = Console.ReadLine();
                        _str.Replace(x, x1);
                        
                        break;
                    case 5://удалить все вхождения указанной подстроки
                        //Todo кажись замена так себе
                        Console.Write("Введиьте указанную подстроку: ");
                        string pod = Console.ReadLine();
                        
                        string pod1 = "";
                       
                        _str.Replace(pod, pod1);
                        break;
                    case 0: //выход

                        break;
                    default:
                        break;
                        
                }
            }



        }


    }
}

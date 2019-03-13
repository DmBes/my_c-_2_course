using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class IntMenu
    {
        public IntMenu()
        {

        }

        public void PrintMenu_ch1()
        {
            Console.Clear();
            Console.WriteLine("1 – устанавливает текущий диск/каталог");
            Console.WriteLine("2 – выводит список всех каталогов в текущем (пронумерованный)");
            Console.WriteLine("3 – выводит список всех файлов в текущем каталоге (пронумерованнный)");
            Console.WriteLine("4 – выводит на экран содержимое указанного файла (по номеру)");
            Console.WriteLine("5 – создает каталог в текущем");
            Console.WriteLine("6 – удаляет каталог по номеру, если он пустой");
            Console.WriteLine("7 – удаляет файлы с указанными номерами");
            Console.WriteLine("8 – выводит список всех файлов с указанной датой создания (ищет в текущем каталоге и подкаталогах)");
            Console.WriteLine("9 – выводит список всех текстовых файлов, в которых содержится указанный текст (ищет в текущем каталоге и подкаталогах)");
            Console.WriteLine("0 – выход");
            Console.WriteLine("\n");
            Console.WriteLine( "Ваше значение: ");
        }

        public void PrintMenu_ch2()
        {
            Console.Clear();
            Console.WriteLine("1 – ввод строки с клавиатуры (указывать размер)");
            Console.WriteLine("2 – вывод строки");
            Console.WriteLine("3 – после указанного символа каждый раз вставить *");
            Console.WriteLine("4 – заменить один символ на другой");
            Console.WriteLine("5 – удалить все вхождения указанной подстроки");
            Console.WriteLine("0 - выход");
            Console.WriteLine("\n");
            Console.WriteLine("Ваше значение: ");

        }

        public void ClearMenu() { Console.Clear(); }
        
        public void separator() {
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine();
        }


    }
}

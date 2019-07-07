using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sveta
{
    class Program
    {
        static void Main(string[] args)
        {

            m3: Console.Write("Введите своё имя: ");
            string x = Console.ReadLine().ToString();
            if (x.Length <2)
            {
                goto m3;
            }
            int age;
        m4: Console.Write("Введите возрост (данные являются секретными и никому не будут сообщены): ");
            
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) goto m4;

                
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Введено некоректное значение возраста");
                goto m4;
            }
            Menu m = new Menu(x);
            ClassName svet = new ClassName(x,age);
            Pozd p = new Pozd(svet);
            Console.WriteLine("Для выхода нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}

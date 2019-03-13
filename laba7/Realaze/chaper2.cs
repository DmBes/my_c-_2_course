using System;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using laba7.Other;

namespace laba7
{

    /*Используйте любой класс с наследованием от другого класса или интерфейса из работы №2.
Добавьте статический метод, который запишет в текстовый файл всю информацию о типе вашего 
класса (рефлексия). Имя файла – параметр метода.

Добавьте экземплярный метод, который будет сохранять в бинарный файл всю информацию
о текущем объекте. Имя файла – параметр метода.

Метод, который будет читать информацию из бинарного файла и возвращать готовый 
объект. Имя файла – параметр метода.

Добавьте методы, которые сериализуют и десериализуют объекты вашего
класса. Имя файла – параметр метода.

     *
     */
    [Serializable]
    class chapter2

    {
        
        public Trade_center tradeCenter;
        [NonSerialized]
        protected string commment = "Не выгружать";

        public chapter2(): base ()  //ToDo почему нельза положить класс ???
        {

        }

        public chapter2(Trade_center tradeCenter)
        {
            this.tradeCenter = tradeCenter;
            //Reflection();
            MySereseble("tut.txt");



        }
        
        public static void Reflection()
        {

            Type MyClass = typeof(Trade_center);
            using (StreamWriter writer = new StreamWriter("test.txt",false))
            {
                writer.WriteLine(MyClass.BaseType);
                writer.WriteLine(MyClass.FullName);
                writer.WriteLine(MyClass.Attributes);
                writer.WriteLine(MyClass.Name);
                MethodInfo[] x = MyClass.GetMethods();
                foreach (var ob in x)
                {
                    writer.WriteLine(ob);
                    ;
                }
            }
        }


        public void MySereseble(string my)
        {
            Stream t = new FileStream(my,FileMode.Create);
            BinaryFormatter forma = new BinaryFormatter();
            forma.Serialize(t, tradeCenter);
            t.Close();
        }


    }
}

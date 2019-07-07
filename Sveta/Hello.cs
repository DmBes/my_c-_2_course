using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sveta
{
    class Menu
    {
        
        public string name;


        public Menu(string NameOF)
        {
            name = NameOF;
            start();
        }

        public void start()
        {


            Console.Clear();
            Console.WriteLine("Добро пожаловать в программу {0} \n\n\n Для продолжения нажмите любую кнопку", this.name);
            Console.ReadKey();
        }
    }

    class ClassName
        {
            private string name;
            private int age;
            private List<string> Svetlana = new List<string>() {"света", "светлана", "коза", "светка"};

            public string Nameprov
            {
                get => name;
                set
                {
                    int x = 0;
                    
                    while (x == 0)
                    {
                        string mmm = CurrentName(value);
                        if (mmm != null)
                        {
                            x = 1;
                            name = value;
                        }
                        else
                        {
                            value = Newname();
                        }

                    }
                    
                }
            }

            public int AgeGet
            {
                get => age;
                set
                {
                    if (value == 34)
                    {
                        age = 7;
                    }
                    else
                    {
                        string ne = value.ToString();
                        int sum = 0;
                        for (int i = 0; i < ne.Length; i++)
                        {
                            sum = Convert.ToInt32(ne[i]);
                        }

                        age = sum;
                    }
                    
                }
            }

            public ClassName(string x , int y)
            {
                Nameprov = x;
                AgeGet = y;


            }


            public string CurrentName(string name)
            {
                //foreach (var X in Svetlana)
                //{
                //    if (X.ToLower() == name.ToLower())
                //    {
                //        return name;
                //    }
                //}
                

                
                int s = Svetlana.IndexOf(name.ToLower());
                if (s > -1)
                {
                    return name;
                }

                return null;
            }

            public string Newname()
            {
                Console.Write("Введите корректное значение имени: ");
                string x= Console.ReadLine();
                return x;
            }


            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType()) return false;
                string p = (string) obj;
                return (this.Nameprov.ToLower() == p.ToLower());
            }
        }


    class Pozd
    {
        public ClassName woman;
        List<string> happy = new List<string>()
        {
            "Поздравляю с днем рождения! Яркого позитивного настроения,\nвысоких достижений, душевной гармонии, процветания, крепкого здоровья, успехов во всём!\nЖелаю никогда не останавливаться на достигнутом.\nУдачи в познании новых идей, саморазвития и стремления только к самому лучшему!", "Поздравляю с днём рождения тебя! \nЖелаю прекрасной и удивительной жизни, океан безумной любви, бесконечного счастливого времени,\nтолько крепкого здоровья и отличного настроения.","С днем рождения!\nЖелаю добра, света, мира, улыбок, отличного настроения. \nПусть всё плохое обходит стороной, жизненные невзгоды преодолеваются с легкостью,\nа каждый день будет наполнен радостью и счастьем.\nИ конечно, светлой веры, огромной надежды, бесконечной любви.",
            "Поздравляю с днем рождения! \nЖелаю, чтобы твоя жизнь была яркой и восхитительной, \nлюбимые дарили внимание, радость, тепло и ласку, \nдрузья окружали искренним пониманием и поддержкой, \nДИРЕКТОР уважал и ДОРОЖИЛ. \nПусть всё, что казалось несбыточным, сбудется, и самое желанное пусть произойдет!",
           "Чудесный, солнечный человечек, я поздравляю тебя с днём рождения! \nПусть в любой день и в любую погоду у тебя всё будет замечательно, пусть всегда буду те, кому можно подарить свои крепкие объятия, пусть всегда будут те, кто наполнит твою жизнь светом счастья"


        };
        List<string> your = new List<string>() { "Ты лучшая ", "Ты лучшая ", "Ты прекрасная ", "Ты великолепная ",
         "Ты сногшибательная ", "Директор тебя не ценит ", "Лучезарная ",
         "Ты не просто главный бухгалтер, ты лучший главный бухгалтер " };
        private string your_best = "Ты лучшая ";
        public string fraza;
        




        public Pozd(ClassName x)
        {

            woman = x;
            fraza = con(x, your);
            Random rand = new Random();

            int choice = motiv();
            while (choice != 0)
            {
                int pozdravleniya = rand.Next(happy.Count);
                int fact = rand.Next(your.Count);
                if (choice == 2)
                {
                    Print_Fact(your, woman,fact);

                }

                else
                {
                    Print_HP(your,  pozdravleniya);
                }

                choice = motiv();

            }
        }


        public string con (ClassName x1, List<string> b)
        {

            return your_best + " " + x1.Nameprov;
        }

        public int motiv()
        {
            int g = -1;
            
            
            while (g < 0 || g > 2)
            {
                m1: Console.Clear();
                Console.WriteLine("Выбрать значение");
                Console.WriteLine("1 - Поздравление ");
                Console.WriteLine("2 - Факт");
                Console.WriteLine("0 - Выход");
                Console.Write("Твое значение: ");
                try
                {
                    g = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    goto m1;
                }
            }

            return g;
        }

        public void Print_Fact(List<string> fact,ClassName name, int ind)
        {
            Console.Clear();
            string t = fact[ind];
            string a = name.Nameprov;

            Console.WriteLine(t+ a);
            Console.WriteLine("\n\n\nДля продолжения нажать любую клавишу");
            Console.ReadKey();
        }


        public void Print_HP(List<string> fact,  int ind)
        {
            Console.Clear();
            string t = happy[ind];
 

            Console.WriteLine(t);
            Console.WriteLine("\n\n\nДля продолжения нажать любую клавишу");
            Console.ReadKey();
        }


    }
        }

    


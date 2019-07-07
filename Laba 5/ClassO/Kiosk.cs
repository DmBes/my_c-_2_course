using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Laba_5
{
    public class Kiosk : IMagaz, IComparable
    {
        public string NameObject { get; set; }
        public string AdressObject { get; set; }
        public int Longest { get; set; }
        public int Windth { get; set; }
        public int Area(int l, int w)
        {
            return l * w;
        }


        public Kiosk(int longest, int windth, string adres, string nameObj)
        {
            NameObject = nameObj;
            AdressObject = adres;
            this.Longest = longest;
            this.Windth = windth;
        }

        public Kiosk() : this(1, 1, "Независимости", "Пиво")
        {
        }



        public void Print()
        {
            Console.WriteLine($"Это киоск {NameObject} по адресу {AdressObject}\n" +
                              $"c длинной {Longest}, шириной {Windth}\nплощадь помещения" +
                              $" составляет {Area(Longest, Windth)}метров квадратных");

        }


        public int CompareTo(object obj)   // Сортировка  
        {
            Kiosk temp = obj as Kiosk;  // Если это киоск
            if (temp != null)
            {
                return this.NameObject.CompareTo(temp.NameObject);


            }
            Worker temp2 = obj as Worker; //Если это рабочий
            if (temp2 != null)
            {
                return this.NameObject.CompareTo(temp2.NamePeople);
            }
            

          
            throw new Exception("no class in Kiosk");
        }


        public override bool Equals(object obj)   //Сравнение
        {

            if (obj == null)  // Если пришел на вход NUll
                return false;
            if (obj is String) return obj == NameObject; // Если на вход пришла строка
            //if (obj is Int32) return false;
            var temp = obj as Kiosk;  // Если на вход пришел киоск
            if (temp == null) return false;

            return (temp.NameObject == this.NameObject); // .ToLower());





        }
    }

    }

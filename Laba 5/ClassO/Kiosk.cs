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


        public int CompareTo(object obj)
        {
            Kiosk temp = obj as Kiosk;
            if (temp != null)
            {
                return this.NameObject.CompareTo(temp.NameObject);


            }

            //return this.NameObject.CompareTo((Kiosk) obj);
            throw new Exception("no class in Kiosk");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Other
{
    class Kiosk
    {
        public string NameObject { get; set; }
        public string AdressObject { get; set; }



        public Kiosk(string nameObj, string adres)
        {
            NameObject = nameObj;
            AdressObject = adres;

        }

        public Kiosk() : this("Белсоюздрук", "Плеханова 23")
        {
        }


        public void Print()
        {
            Console.WriteLine($"Я киоск {NameObject} по адресу {AdressObject}");
        }

    }
}

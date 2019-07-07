using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace laba7.Other
{
    [Serializable]
    class Kiosk
    {

       
        //[NonSerialized]
        public string NameObject;
       
        public string AdressObject;  

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
            Console.ReadKey();
        }

    }
}

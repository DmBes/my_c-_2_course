using System;

namespace laba8
{
    public class Kiosk 
    {
       
        public string NameObject;   

        public string AdressObject;
        public int count_kiosk;

        public int ValueProfit
        {
            get => count_kiosk * Profit;
        }


        private int Profit;


        


        public Kiosk(string nameObj, string adres, int profit, int count_k)
        {
            NameObject = nameObj;
            AdressObject = adres;
            Profit = profit;
            count_kiosk = count_k;


        }
        
        public Kiosk() : this("Белсоюздрук", "Плеханова 23", 0, 0)
        {
        }


        public void Print()
        {
            Console.WriteLine($"Я киоск {NameObject} по адресу {AdressObject}, моя выручка составляет {ValueProfit}");
            Console.ReadKey();
        }

        public override string ToString()
        {
            return NameObject + " " + AdressObject + " Количество киосков составляет " + count_kiosk;
        }

        public int AveregeValue(int mounth)
        {
            Console.WriteLine("Работает Делегат");
            return Convert.ToInt32(ValueProfit / mounth);
        }

        public override bool Equals(object obj)
        {
            if (obj as Kiosk != null) return this.count_kiosk == ((Kiosk)obj).count_kiosk;
            return false;
        }

        public static bool operator > (Kiosk a, Kiosk b)
        {
            if (a.count_kiosk > b.count_kiosk)
            {
                return true;
            }

            return false;

        }

        public static bool operator <(Kiosk a, Kiosk b)
        {
            if (a.count_kiosk > b.count_kiosk)
            {
                return false;
            }

            return true;
        }

        public static void MethodStatic(Kiosk k)
        {
            k.Print();
        }


     

    }



        

    }


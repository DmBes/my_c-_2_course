using laba3.Properties;

namespace laba3
{
    class Garage
    {
        private short _number;
        public string name;
        public string adres;
        private short _countCar;
        Cars[] Car_arr;

        public Garage(short number, string name, string adres, short count_car, Cars[] CarsArr)
        {
            this._number = number;
            this.name = name;
            this.adres = adres;
            this._countCar = count_car;
            this.Car_arr = CarsArr;
        }

        public Garage() : this(1, "Mintrans", "Софьи Ковалевской, 12", 100, null)
        {

        }


        public void print_garage()
        {
            System.Console.WriteLine("Номер гаража {0}\nНазвание гаража {1}\nАдрес {2}\nКоличество паркуемых машин{3}",_number,name,adres, _countCar);
            foreach(Cars i in Car_arr)
            {
                i.print_car();
            }
        }




    }
}

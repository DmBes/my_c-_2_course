using System;

namespace laba3.Properties
{
    public class Cars
    {
        public string NameCars, CarsModel;

        public Motors Motor;



        public Cars(string nameCars, string carModel, string nameMotor = "Noname", string gas = "diesel power", short power = 1000)
        {
            this.NameCars = nameCars;
            this.CarsModel = carModel;
            Motor = new Motors(nameMotor, gas, power);



        }

        public void print_car()
        {
            Console.WriteLine("Модель автомобиля {0}\n Марка автомобиля {1}", NameCars, CarsModel);
            Motor.print_motor();
            
        }

        //    public Cars(string nameCars, string carsModel) : this (nameCars, carsModel, "Noname", "Diesel power", 1000)
        //    {

        //    }
        //



    }


}
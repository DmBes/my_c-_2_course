using System;

namespace laba3.Properties
{
    public class Cars
    {
        public string NameCars, CarsModel;

        public motors Motor;

        public Cars(string nameCars, string carModel, motors nameMotor)
        {
            this.NameCars = nameCars;
            this.CarsModel = carModel;
            Motor = nameMotor;

        }

        public Cars(string nameCars, string carsModel)
        {
            this.NameCars = nameCars;
            this.CarsModel = carsModel;
        }
    }
    

   



}
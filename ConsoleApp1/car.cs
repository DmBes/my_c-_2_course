using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp
{
    class Cars
    {
        const double presure_wheel_standart = 1.5f;
        public string car_name, cars_model,gasoline;
        private double fuel_consumption, real_speed;
        private short fuel_tank;
        public double[] pressure_wheel;


        public Cars() : this("volvo", "s60", 20.0, 100.0, 77, "gasoline 92", new double[4] { 2.1, 2.1, 2.2, 2.2 })
        { }

        public Cars(string name, string model) : this(name, model, 20, 100, 77, "gasoline 92", new double[4] { 2.5, 1.1, 2.2, 2.5 })
        { }


        public Cars(string name_car, string model, double fuel_consumption1,
            double real_speed, short tank_fuel, string gasoline, double[] pressure)
        {
            this.car_name = name_car;
            this.cars_model = model;
            this.gasoline = gasoline;
            this.fuel_consumption2 = fuel_consumption1;
            speed = real_speed;
            fuel = tank_fuel;
            this.pressure_wheel = pressure;

        }
        public double fuel_consumption2
        {
            get { return fuel_consumption; }

            set { if (value < 200 && value > 0)
                {
                    fuel_consumption = value;
                }
                else fuel_consumption = 10;
            }

        }

        public double speed
        {
            get { return real_speed; }
            set
            {
                if (value < 300 && value > 0)
                {
                    real_speed = value;
                }
                else real_speed = 1.1;
            }
        }

        public short fuel
        {
            get { return fuel_tank; }
            set
            {
                if (value < 300 && value > 0)
                {
                    fuel_tank = value;
                }
                else fuel_tank = 1;
            }
        }




   


        public void print()
        {
            Console.WriteLine("Марка автомобиля {0}", car_name);
            Console.WriteLine("Модель автомобиля {0}", cars_model);
            Console.WriteLine("потребление топлива {0}", fuel_consumption2);
            Console.WriteLine("Текущая скорость составляет {0}", speed);
            Console.WriteLine("Размер топливного бака составляет {0}", fuel);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Давление в колесе номер {0} составляет {1}",i , pressure_wheel[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }


        public bool break_out_wheel ()
        {
            foreach (int key in pressure_wheel)
            {
                if (key >= presure_wheel_standart) continue;
                else {
                    real_speed = 0;
                    return false; }
            }
            return true;



        }



        public bool first (Cars i) 
        {
            if (speed > i.speed) 
                return true;
            return false;
            
        }

        public double max_limit()
        {
            return Math.Round(fuel / fuel_consumption2 * 100, 2);
        }


        public static Cars Get_Cars(Cars x, Cars y, Cars z)
        {
            double max = x.speed;
            Cars maxa = x;
            if (max < y.speed) { max = y.speed; maxa = y; }
            if (max < y.speed) { max = z.speed; maxa = z; }
            return maxa;
        }


      

            
           
     
    }
}



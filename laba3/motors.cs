using System;
using Microsoft.Win32;

namespace laba3.Properties
{
    public class Motors
    {

        public string MotorName = "None";
        public string Gas = "None";
        private int _power;


        public int power
        {
            get => _power;
            set => _power = value;
        }



        public Motors(string name, string gasoline, int power)
        {
            this.MotorName = name;
            this.Gas = gasoline;
            this.power = power;


        }


        public Motors() : this("China_town", "Don't know", 1)
        {
        }

        public Motors(string name) : this(name, "Do not gasoline", 3)
        {

        }

        public void print_motor()
        {
            Console.WriteLine(" ������ ������ {0}, ������������ ��� ������� {1}, �������� ���������� {2}", MotorName,Gas,power);
        }

    }
}
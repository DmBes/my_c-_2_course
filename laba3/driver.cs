using System;
using System.Collections.Generic;


namespace laba3.Properties
{
    class Driver
    {
        public string Fname { get; set; } = "Noname";
        public string Lname { get; set; } = "Noname";
        private short Stage { get; set; }
        private short _salary = 100;
        private short _age = 18;
        Cars _autoForDriver;
        private short _dadadsad;

        

        public short Stage1
        {
            set => Stage = value;
            get => Stage;
        }

        public short Salary1
        {
            set => _salary = value;
            get => _salary;
        }

        public short Age
        {
            get => _age;
            set => _age = value;
        }

        public Driver(string fname, string lname, short stage, short salary, short age, Cars avtomobil)
        {
            this._age = age;
            this._salary = salary;
            this.Stage = stage;
            this.Fname = fname;
            this.Lname = lname;
            _autoForDriver = avtomobil;
        }

        public Driver() : this("Ivan", "Ivanov", 0, 100, 18, null)
        {

        }

        public Driver(string name, string sName) : this(name, sName, 0, 200, 18, null)
        {

        }


        public void print_driver()
        {
            Console.WriteLine("Имя {0} \n Фамилия {1}\n Стаж работы {2}\nВозраст {3}\n Заработная плата {4}", Fname,Lname,Stage1,Age, Salary1);
            if (_autoForDriver == null) Console.WriteLine("Плохой водитель без тачки");
            else { _autoForDriver.print_car(); };
           

        }

    }
}
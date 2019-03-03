using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Worker : IPeople, ICloneable
    {
        public string NamePeople { get; set; }
        public int Salary { get; set; }
        public void Print()
        {
            Console.WriteLine($"Я работник {NamePeople} с заработной платой {Salary}");
        }

        public void Print_salary()
        {
            Console.WriteLine("Заработная плата составляет {0}", Salary);
        }

        public Worker(string nameP, int salary)
        {
            NamePeople = nameP;
            this.Salary = salary;
        }

        public Worker() : this("Вася", 0)
        {
        }


        public object Clone() => new Worker(this.NamePeople, this.Salary);
    }
}

using System.Runtime.InteropServices;
using System.Xml.Serialization;
using laba3.Properties;

namespace laba3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
             void Zvezda()
            {
                System.Console.WriteLine("************************************");
            }
             

            Cars Volvo = new Cars("Volvo", "s60", "B5234T", "Gasoline", 250);
            Volvo.print_car();
            
            Zvezda();
            Driver ivan = new Driver("Petr", "Petrovich",33,1000, 33, Volvo);
            ivan.print_driver();
            Zvezda();
            Cars Audi = new Cars("audi", "a6", "AT321", "diesel", 140);

           

            Zvezda();
            Garage Min = new Garage(1, "Minsantrans", "г.Минск", 100, new Cars[] { Volvo, Audi});
            Min.print_garage();


            Zvezda();
            Cars volvo = new Cars("Volvo", "s60", "Mersedes-Benz", "gas", 250);
            System.Console.ReadKey();
        }
        


        
    }
}
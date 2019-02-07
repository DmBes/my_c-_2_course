using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace new1
{

    class Round {
        private double pi = 3.0f;
        private double x;

        public void get_x(double number)
        {
            x = number;
        }

        public double summ_round()
        {
            return x * pi;
        }
    
    
   


}



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.ReadKey();
            double t;
          
            t = Convert.ToDouble(Console.Read());
            
            Round f1 = new Round();
            f1.get_x(t);

            double summ = f1.summ_round();

            Console.WriteLine(summ);
            Console.ReadKey();


                    }
    }
}
